Imports System.Net.Mail

Public Class EmailController
    Private ReadOnly Host As String
    Private ReadOnly Email As String
    Private ReadOnly Password As String
    Private ReadOnly Port As Integer

    Public Sub New(Host As String, Port As Integer, Email As String, Password As String)
        Me.Host = Host
        Me.Port = Port
        Me.Email = Email
        Me.Password = Password
    End Sub

    Public Sub Send(EmailTo As String, Subject As String, Body As String)
        Dim Mail As New MailMessage()
        Dim SmtpServer As New SmtpClient(Host)
        Mail.From = New MailAddress(Email)
        Mail.[To].Add(EmailTo)
        Mail.Subject = Subject
        Mail.Body = Body
        Mail.IsBodyHtml = True
        'If DataReader("Attachment1").ToString <> "" AndAlso File.Exists(DataReader("Attachment1").ToString) Then
        '    Dim Attachment1 As Attachment
        '    Attachment1 = New Attachment(DataReader("Attachment1").ToString)
        '    Mail.Attachments.Add(Attachment1)
        'End If
        SmtpServer.Port = Port
        SmtpServer.UseDefaultCredentials = False
        SmtpServer.Credentials = New Net.NetworkCredential(Email, Password)
        SmtpServer.EnableSsl = True

        For i As Integer = 5 To 0 Step -1
            Try
                SmtpServer.Send(Mail)
                Exit Sub
            Catch Ex As TimeoutException
                Threading.Thread.Sleep(2000)
            End Try
        Next
    End Sub

End Class
