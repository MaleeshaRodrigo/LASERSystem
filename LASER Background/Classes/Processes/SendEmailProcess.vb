Imports System.ComponentModel
Imports System.IO
Imports System.Net.Mail

Public Class SendEmailProcess
    Implements IProcess

    Private ReadOnly Database As Database
    Private ReadOnly Worker As BackgroundWorker
    Private ReadOnly EmailController As EmailController

    Public Sub New(Database As Database, Worker As BackgroundWorker)
        Me.Database = Database
        Me.Worker = Worker
        Me.EmailController = New EmailController(
            My.Settings.MailServer,
            My.Settings.MailServerPort,
            My.Settings.SystemEmail,
            (New Encoder()).Decode(My.Settings.SystemEmailPassword)
        )
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        Dim DataList = Database.GetDataList("Select * from Mail Where Status='Waiting';")
        For Each Item In DataList
            If Worker.CancellationPending Then
                Exit Sub
            End If
            If Not Validation(Item("EmailTo").ToString) Then
                Continue For
            End If

            SendEmail(Item("MailNo"), Item("EmailTo").ToString, Item("Subject").ToString, Item("Body").ToString)
        Next
    End Sub

    Private Function Validation(Email As String) As Boolean
        If String.IsNullOrWhiteSpace(Email) Then
            Return False
        End If

        Return True
    End Function

    Private Sub SendEmail(MailNo As Integer, EmailTo As String, Subject As String, Body As String)
        Try
            EmailController.Send(EmailTo, Subject, Body)
            Database.Execute($"Update Mail Set Status='Sent' Where MailNo={MailNo}")
        Catch ex As Exception
            Database.Execute($"Update Mail Set Status='Failed' Where MailNo={MailNo}")
        End Try
    End Sub
End Class
