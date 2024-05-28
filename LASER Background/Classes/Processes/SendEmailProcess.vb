Imports System.ComponentModel
Imports System.Data.OleDb
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
        Try
            Dim DataReader As OleDbDataReader = Database.GetDataReader("Select * from Mail Where Status='Waiting';")
            While DataReader.Read()
                If Worker.CancellationPending Then
                    Exit Sub
                End If

                SendEmail(DataReader("MailNo"), DataReader("EmailTo").ToString, DataReader("Subject").ToString, DataReader("Body").ToString)
            End While
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SendEmail(MailNo As Integer, EmailTo As String, Subject As String, Body As String)
        Try
            EmailController.Send(EmailTo, Subject, Body)
            Database.Execute($"Update Mail Set Status='Sent' Where MailNo={MailNo}")
        Catch ex As Exception
            Database.Execute($"Update Mail Set Status='Failed' Where MailNo={MailNo}")
        End Try
    End Sub
End Class
