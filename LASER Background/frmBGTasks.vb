Imports System.Net.Mail
Imports System.Net
Imports System.Net.Http
Imports System.Web
Imports System.IO
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Web.Security
Imports Guna.UI2.WinForms
Imports Newtonsoft.Json.Linq

Public Class frmBGTasks
    Private CNNBG As OleDbConnection
    Private CMDBG1, CMDBG2 As New OleDbCommand
    Private DRBG1, DRBG2 As OleDbDataReader
    Private ReadOnly Simple As New Simple3Des("RandomKey45")
    Public Sub New()

        Me.Hide()
        ' This call is required by the designer.
        InitializeComponent()
        Dim process As New Process()
        ' Pass your exe file path here.
        Dim path As String = Application.StartupPath + "\" + Application.ProductName + ".exe"
        Dim fileName As String = System.IO.Path.GetFileName(path)
        ' Get the precess that already running as per the exe file name.
        Dim processName As Process() = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf("."c)))
        If processName.Length > 1 Then
            End
        End If
        ' Add any initialization after the InitializeComponent() call.

        With My.Settings
            txtDBLocation.Text = .DatabaseCNN
            cmbDbProvider.Text = .DbProvider
            txtDBLocation.Tag = .DatabaseCNN
            txtMApiKey.Text = .APIKey
            txtMApiToken.Text = .APIToken
            cmbMBgSMS.Text = .BGSendSMS
            chkMSendEmail.Checked = .SendEmail
            txtMAdminEmail.Text = .AdminEmail
            txtBackUpDB1.Text = .BackUpDB1
            txtBackUpDB2.Text = .BackUpDB2
            txtBackUpDB3.Text = .BackUpDB3
            txtUserAgent.Text = .UserAgent

            If .AdminEmailPass <> "" Then txtMAdminPass.Text = Simple.Decode(.AdminEmailPass)
            If .OnlineDBCNN = "" Then
                chkOnlineDB.Checked = False
                txtOnlineDB.Text = ""
                txtOnlineDBUser.Text = ""
                txtOnlineDBPass.Text = ""
                chkOnlineDB_CheckedChanged(Nothing, Nothing)
            Else
                chkOnlineDB.Checked = True
                txtOnlineDB.Text = .OnlineDBCNN
                txtOnlineDBUser.Text = Simple.Decode(My.Settings.OnlineDBUser)
                txtOnlineDBPass.Text = Simple.Decode(My.Settings.OnlineDBPass)
                chkOnlineDB_CheckedChanged(Nothing, Nothing)
            End If
        End With
        If Not Directory.Exists(Application.StartupPath + "/System Files") Then My.Computer.FileSystem.CreateDirectory(Application.StartupPath +
                                                                                                                               "/System Files")
        If Not Directory.Exists(Application.StartupPath + "/System Files/Activity") Then My.Computer.FileSystem.CreateDirectory(Application.StartupPath +
                                                                                                                               "/System Files/Activity")
        If Not File.Exists(Application.StartupPath + "/System Files/Activity/BGActivity.ls") Then
            Dim d As FileStream
            d = File.Create(Application.StartupPath & "/System Files/Activity/BGActivity.ls")
            d.Close()
        End If
        tmrRefresh.Start()
        txtActivity.Text = ""
        txtActivity.Text = File.ReadAllText(Application.StartupPath & "\System Files\Activity\BGActivity.ls")
    End Sub
    Private Sub FrmBGTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.BelowNormal
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        GetCNN()
    End Sub

    Private Sub FrmBGTasks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        bgworker.CancelAsync()
        bgworkerOnline.CancelAsync()
        tmrRefresh.Stop()
        Me.Hide()

        If bgworker.IsBusy = True Or bgworkerOnline.IsBusy = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Tag = "DBError" Then
                tmrRefresh.Stop()
                Exit Sub
            End If
        Next
        If File.Exists(My.Settings.DatabaseCNN) = False Then
            CreateMessagePanel("Database Problem", "Message: " + "Database couldn't be found. Please check again and apply." + vbCrLf +
                               "Please inform this error to developer for fixing", "DBError")
            tmrRefresh.Stop()
            Exit Sub
        ElseIf CNNBG Is Nothing OrElse CNNBG.State = ConnectionState.Closed Then
            GetCNN()
        End If
        If bgworker.IsBusy = False Then bgworker.RunWorkerAsync()
        If My.Settings.OnlineDBCNN <> "" Then
            If bgworkerOnline.IsBusy = False Then bgworkerOnline.RunWorkerAsync()
        Else

        End If
    End Sub

    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworker.DoWork
        tslblLoad.Text = "Applying Admin Confirmed commands..."
        Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "AdminPermissionError" Then
                    Exit Try
                End If
            Next
            CMDBG1 = New OleDb.OleDbCommand("Select * from AdminPermission Where Status='Confirmed';", CNNBG)
            DRBG1 = CMDBG1.ExecuteReader
            While DRBG1.Read
                CMDUPDATE(DRBG1("Command").ToString)
                CMDUPDATE("Update AdminPermission set Status='Completed' Where APNo=" & DRBG1("APNo").ToString)
            End While
        Catch ex As Exception
            e.Result = New String() {"AdminPermissionError", ex.Message}
            Exit Sub
        Finally
            If DRBG1 IsNot Nothing AndAlso DRBG1.IsClosed = False Then
                DRBG1.Close()
                CMDBG1.Cancel()
            End If
        End Try

        tslblLoad.Text = "Send Messages to Customers for Repaired Items..."
        Try
            If My.Settings.BGSendSMS = "OFF" Then Exit Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "MessageSendtoCustomerforRepairedItemsError" Then
                    Exit Try
                End If
            Next
            CMDBG1 = New OleDb.OleDbCommand("Select Rep.RepNo,CuName,CuTelNo1,CuTelNo2,CuTelNo3,PCategory,PName,Status,Charge from " &
                                          "Repair Rep, Customer Cu, Product P, Receive R where Rep.RNo = R.RNo And R.CuNo = Cu.CuNo " &
                                          "And Rep.PNo = P.PNo And (Rep.Status='Repaired Not Delivered' or Rep.Status='Returned Not Delivered')", CNNBG)
            DRBG1 = CMDBG1.ExecuteReader
            While DRBG1.Read
                If DRBG1("CuTelNo1").ToString.Replace(" ", "") = "" Then Continue While
                CMDBG2 = New OleDb.OleDbCommand("Select * from Message where RepNo = " & DRBG1("RepNo").ToString, CNNBG)
                DRBG2 = CMDBG2.ExecuteReader
                If DRBG2.HasRows = False Then
                    If DRBG1("Status").ToString = "Repaired Not Delivered" Then
                        CMDUPDATE("Insert into Message(MsgNo,MsgDate,RepNo,CuTelNo,Message,`Status`) Values(" &
                                          AutomaticPrimaryKeyStr("Message", "MsgNo") & ",#" & DateAndTime.Now & "#," &
                                          DRBG1("RepNo").ToString & ",'" & DRBG1("CuTelNo1").ToString & "','" &
                                    "ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DRBG1("PName").ToString + " " + DRBG1("PCategory").ToString +
                                    " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + DRBG1("Charge").ToString + " වේ.','Waiting')")
                    ElseIf DRBG1("Status").ToString = "Returned Not Delivered" Then
                        If DRBG1("Charge").ToString = "0" Then
                            CMDUPDATE("Insert into Message(MsgNo,MsgDate,RepNo,CuTelNo,Message,`Status`) Values(" &
                                          AutomaticPrimaryKeyStr("Message", "MsgNo") & ",#" & DateAndTime.Now & "#," & DRBG1("RepNo").ToString &
                                          ",'" & DRBG1("CuTelNo1").ToString & "','" &
                                              "ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DRBG1("PName").ToString + " " +
                                              DRBG1("PCategory").ToString +
                                              " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු.','Waiting')")
                        Else
                            CMDUPDATE("Insert into Message(MsgNo,MsgDate,RepNo,CuTelNo,Message,`Status`) Values(" &
                                          AutomaticPrimaryKeyStr("Message", "MsgNo") & ",#" & DateAndTime.Now & "#," & DRBG1("RepNo").ToString &
                                          ",'" & DRBG1("CuTelNo1").ToString & "','" &
                                                  "ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DRBG1("PName").ToString + " " + DRBG1("PCategory").ToString +
                                                  " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටින අතර ඒ සඳහා Rs." +
                                                  DRBG1("Charge").ToString + " අය කෙරෙයි.','Waiting')")
                        End If
                    End If
                End If
                DRBG2.Close()
                CMDBG2.Cancel()
            End While
        Catch ex As Exception
            e.Result = New String() {"MessageSendtoCustomerforRepairedItemsError", ex.Message}
            Exit Sub
        Finally
            If DRBG1 IsNot Nothing AndAlso DRBG1.IsClosed = False Then
                DRBG1.Close()
                CMDBG1.Cancel()
            End If
            If DRBG2 IsNot Nothing AndAlso DRBG2.IsClosed = False Then
                DRBG2.Close()
                CMDBG2.Cancel()
            End If
        End Try

        If CheckForInternetConnection() = False Then Exit Sub

        tslblLoad.Text = "Sending Emails...."
        Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "SendEmailsError" Then
                    Exit Try
                End If
            Next
            CMDBG1 = New OleDb.OleDbCommand("Select * from Mail Where Status='Waiting';", CNNBG)
            DRBG1 = CMDBG1.ExecuteReader()
            While DRBG1.Read()
                Dim mail As New MailMessage()
                Dim SmtpServer As New SmtpClient("smtp.gmail.com")
                mail.From = New MailAddress(My.Settings.AdminEmail)
                mail.[To].Add(DRBG1("EmailTo").ToString)
                mail.Subject = DRBG1("Subject").ToString
                mail.Body = DRBG1("Body").ToString

                If DRBG1("Attachment1").ToString <> "" AndAlso File.Exists(DRBG1("Attachment1").ToString) Then
                    Dim attachment1 As System.Net.Mail.Attachment
                    attachment1 = New System.Net.Mail.Attachment(DRBG1("Attachment1").ToString)
                    mail.Attachments.Add(attachment1)
                End If
                If DRBG1("Attachment2").ToString <> "" AndAlso File.Exists(DRBG1("Attachment2").ToString) Then
                    Dim attachment2 As System.Net.Mail.Attachment
                    attachment2 = New System.Net.Mail.Attachment(DRBG1("Attachment2").ToString)
                    mail.Attachments.Add(attachment2)
                End If
                If DRBG1("Attachment3").ToString <> "" AndAlso File.Exists(DRBG1("Attachment3").ToString) Then
                    Dim attachment3 As System.Net.Mail.Attachment
                    attachment3 = New System.Net.Mail.Attachment(DRBG1("Attachment3").ToString)
                    mail.Attachments.Add(attachment3)
                End If

                SmtpServer.Port = 587
                SmtpServer.UseDefaultCredentials = False
                SmtpServer.Credentials = New System.Net.NetworkCredential(My.Settings.AdminEmail, Simple.Decode(My.Settings.AdminEmailPass))
                SmtpServer.EnableSsl = True

                For i As Integer = 5 To 0 Step -1
                    Try
                        SmtpServer.Send(mail)
                        CMDUPDATE("Update Mail Set Status='Sent' Where MailNo=" & DRBG1("MailNo").ToString)
                        Exit For
                    Catch
                        Threading.Thread.Sleep(2000)
                    End Try
                Next
            End While
        Catch ex As Exception
            e.Result = New String() {"SendEmailsError", ex.Message}
            Exit Sub
        Finally
            If DRBG1 IsNot Nothing AndAlso DRBG1.IsClosed = False Then
                DRBG1.Close()
                CMDBG1.Cancel()
            End If
        End Try

        Try
            Dim request As WebRequest = HttpWebRequest.Create("http://app.newsletters.lk/smsAPI?balance&apikey=" &
                                                              My.Settings.APIKey & "&apitoken=" & My.Settings.APIToken)
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
            Dim readStream As New StreamReader(s)
            Dim dataString As String = readStream.ReadToEnd()
            Dim json As JObject = JObject.Parse(dataString)
            lblBalance.Text = "Balance : Rs. " + json.SelectToken("balance").ToString
        Catch ex As Exception
            lblBalance.Text = "Balance : Rs. ###"
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworker.RunWorkerCompleted
        tslblLoad.Text = "Checking Error..."

        If bgworker.CancellationPending = True And bgworkerOnline.IsBusy = False Then
            End
        End If
        If e.Result IsNot Nothing Then
            Select Case e.Result(0)
                Case "AdminPermissionError"
                    CreateMessagePanel("Admin Confirmed කර Data Apply කිරීම බිඳවැටී ඇත.",
                    "Admin වෙත තහවුරු කිරීම සඳහා යවන ලද Data Database එකට Apply කිරිමේ පද්ධතිය බිඳවැටී ඇත." +
                    vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "AdminPermissionError")
                    Exit Sub
                Case "MessageSendtoCustomerforRepairedItemsError"
                    CreateMessagePanel("සෑදු අයිතම සඳහා ස්වයංක්‍රීයව යැවෙන Message පණිවිඩය ක්‍රියාවිරහිත වී ඇත.",
                    "Status එක 'Repaired Not Delivered' හෝ 'Returned Not Delivered' යන Repair වල Customer සඳහා ස්වයංක්‍රීයව යැවෙන SMS පණිවිඩය ක්‍රියාවිරහිත වී ඇත." +
                    vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "MessageSendtoCustomerforRepairedItemsError")
                    Exit Sub
                Case "SendEmailsError"
                    CreateMessagePanel("ස්වයංක්‍රීයව යැවෙන Emails ක්‍රියාවිරහිත වී ඇත.",
                    "ස්වයංක්‍රීයව Emails යැවෙන පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
                    vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendEmailsError")
                    Exit Sub
            End Select
        End If

        tslblLoad.Text = "Sending SMS Messages..."
        Try
            Dim CMDBG1 As New OleDbCommand
            Dim DRBG1 As OleDbDataReader
            If CheckForInternetConnection() = False Then Exit Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "SendSMSError" Then
                    Exit Try
                End If
            Next
            If My.Settings.BGSendSMS = "Automatically Send SMS" Then
                Dim url As String
                Dim host As String
                Dim apikey As String
                Dim apitoken As String
                Dim originator As String

                CMDBG1 = New OleDb.OleDbCommand("Select * from Message Where Status='Waiting' or Status='Confirmed'", CNNBG)
                DRBG1 = CMDBG1.ExecuteReader
                While DRBG1.Read
                    If bgworker.CancellationPending = True Then Exit Sub
                    host = "http://app.newsletters.lk"
                    Dim str As String = DRBG1("CuTelNo").ToString
                    str = str.TrimStart("0"c)
                    originator = "94" + str.Replace(" ", [String].Empty)
                    apikey = My.Settings.APIKey
                    apitoken = My.Settings.APIToken
                    url = host + "/smsAPI?sendsms&" _
                            & "apikey=" & HttpUtility.UrlEncode(apikey) _
                            & "&apitoken=" + HttpUtility.UrlEncode(apitoken) _
                            & "&type=sms&from=LASERelect" _
                            & "&to=" & HttpUtility.UrlEncode(originator) _
                            & "&text=" + HttpUtility.UrlEncode(DRBG1("Message").ToString) _
                            & "&scheduledate=" + HttpUtility.UrlEncode(DateAndTime.Now)
                    Dim request As WebRequest = HttpWebRequest.Create(url)
                    Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
                    Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
                    Dim readStream As New StreamReader(s)
                    Dim dataString As String = readStream.ReadToEnd()

                    Dim json As JObject = JObject.Parse(dataString)
                    If json.SelectToken("status").ToString = "queued" Then
                        CMDUPDATE("Update Message set Status='Success' Where MsgNo=" & DRBG1("MsgNo").ToString)

                        Dim C As Integer = 0
                        Dim Msg As String = ""
                        For Each controlObject As Control In flpMessage.Controls
                            If controlObject.Tag.ToString.StartsWith("SMSDeliveredSuccess") = True Then
                                If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")) = True Then
                                    C = controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")
                                    For Each ctrlMsg As Control In controlObject.Controls
                                        If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
                                            Msg = ctrlMsg.Text
                                        End If
                                    Next
                                End If
                                controlObject.Dispose()
                            End If
                        Next
                        CreateMessagePanel((C + 1).ToString + " Message" & If(C > 0, "s", "") & " Sent Successfull", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
                                               If(DRBG1("RepNo").ToString = "", DRBG1("RetNo").ToString, DRBG1("RepNo").ToString) +
                                               ": " + DRBG1("Message").ToString, "SMSDeliveredSuccess" + (C + 1).ToString)
                    Else
                        CMDUPDATE("Update Message set Status='Failure' Where MsgNo=" & DRBG1("MsgNo").ToString)

                        Dim C As Integer = 0
                        Dim Msg As String = ""
                        For Each controlObject As Control In flpMessage.Controls
                            If bgworker.CancellationPending = True Then Exit Sub
                            If controlObject.Tag.ToString.StartsWith("SMSDeliveredFailure") = True Then
                                If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")) = True Then
                                    C = controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")
                                    For Each ctrlMsg As Control In controlObject.Controls
                                        If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
                                            Msg = ctrlMsg.Text
                                        End If
                                    Next
                                End If
                                controlObject.Dispose()
                            End If
                        Next
                        CreateMessagePanel((C + 1).ToString + " Message" & If(C > 0, "s", "") & " Sent Failure", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
                                               If(DRBG1("RepNo").ToString = "", DRBG1("RetNo").ToString, DRBG1("RepNo").ToString) +
                                                ": " + DRBG1("Message").ToString, "SMSDeliveredFailure" + (C + 1).ToString)
                    End If
                    response.Close()
                    s.Close()
                    readStream.Close()
                End While
            ElseIf My.Settings.BGSendSMS = "Only Getting Notification" Then
                CMDBG1 = New OleDb.OleDbCommand("Select * from Message Where Status ='Waiting';", CNNBG)
                DRBG1 = CMDBG1.ExecuteReader()
                While DRBG1.Read()
                    If bgworker.CancellationPending = True Then Exit Sub
                    Dim Bool As Boolean = True
                    For Each controlObject As Control In flpMessage.Controls
                        If controlObject.Tag.ToString.StartsWith("SendSMSConfirmation") = True Then
                            If IsNumeric(controlObject.Tag.ToString.Replace("SendSMSConfirmation", "")) = True AndAlso
                                        DRBG1("MsgNo").ToString = controlObject.Tag.ToString.Replace("SendSMSConfirmation", "") Then
                                Bool = False
                            End If
                        End If
                    Next
                    If Bool = True Then CreateSMSMsgPanel(Int(DRBG1("MsgNo").ToString))
                End While
                Dim url As String
                Dim host As String
                Dim apikey As String
                Dim apitoken As String
                Dim originator As String

                CMDBG1 = New OleDbCommand("Select * from Message Where Status='Confirmed'", CNNBG)
                DRBG1 = CMDBG1.ExecuteReader
                While DRBG1.Read
                    If bgworker.CancellationPending = True Then Exit Sub
                    host = "http://app.newsletters.lk"
                    Dim str As String = DRBG1("CuTelNo").ToString
                    str = str.TrimStart("0"c)
                    originator = "94" + str.Replace(" ", [String].Empty)
                    apikey = My.Settings.APIKey
                    apitoken = My.Settings.APIToken
                    url = host + "/smsAPI?sendsms&" _
                            & "apikey=" & HttpUtility.UrlEncode(apikey) _
                            & "&apitoken=" + HttpUtility.UrlEncode(apitoken) _
                            & "&type=sms&from=LASERelect" _
                            & "&to=" & HttpUtility.UrlEncode(originator) _
                            & "&text=" + HttpUtility.UrlEncode(DRBG1("Message").ToString) _
                            & "&scheduledate=" + HttpUtility.UrlEncode(DateAndTime.Now)
                    Dim request As WebRequest = HttpWebRequest.Create(url)
                    Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
                    Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
                    Dim readStream As New StreamReader(s)
                    Dim dataString As String = readStream.ReadToEnd()

                    Dim json As JObject = JObject.Parse(dataString)
                    If json.SelectToken("status").ToString = "queued" Then
                        CMDUPDATE("Update Message set Status='Success' Where MsgNo=" & DRBG1("MsgNo").ToString)

                        Dim C As Integer = 0
                        Dim Msg As String = ""
                        For Each controlObject As Control In flpMessage.Controls
                            If bgworker.CancellationPending = True Then Exit Sub
                            If controlObject.Tag.ToString.StartsWith("SMSDeliveredSuccess") = True Then
                                If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")) = True Then
                                    C = controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")
                                    For Each ctrlMsg As Control In controlObject.Controls
                                        If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
                                            Msg = ctrlMsg.Text
                                        End If
                                    Next
                                End If
                                controlObject.Dispose()
                            End If
                        Next
                        CreateMessagePanel((C + 1).ToString + " Message" & If(C > 0, "s", "") & " Sent Successfull", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
                                               If(DRBG1("RepNo").ToString = "", DRBG1("RetNo").ToString, DRBG1("RepNo").ToString) +
                                               ": " + DRBG1("Message").ToString, "SMSDeliveredSuccess" + (C + 1).ToString)
                    Else
                        CMDUPDATE("Update Message set Status='Failure' Where MsgNo=" & DRBG1("MsgNo").ToString)

                        Dim C As Integer = 0
                        Dim Msg As String = ""
                        For Each controlObject As Control In flpMessage.Controls
                            If bgworker.CancellationPending = True Then Exit Sub
                            If controlObject.Tag.ToString.StartsWith("SMSDeliveredFailure") = True Then
                                If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")) = True Then
                                    C = controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")
                                    For Each ctrlMsg As Control In controlObject.Controls
                                        If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
                                            Msg = ctrlMsg.Text
                                        End If
                                    Next
                                End If
                                controlObject.Dispose()
                            End If
                        Next
                        CreateMessagePanel((C + 1).ToString + " Message " & If(C > 0, "s", "") & " Sent Failure", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
                                               If(DRBG1("RepNo").ToString = "", DRBG1("RetNo").ToString, DRBG1("RepNo").ToString) +
                                                ": " + DRBG1("Message").ToString, "SMSDeliveredFailure" + (C + 1).ToString)
                    End If
                    response.Close()
                    s.Close()
                    readStream.Close()
                End While
                CMDBG1.Cancel()
            End If
        Catch ex As Exception
            CreateMessagePanel("ස්වයංක්‍රීයව යැවෙන SMS පණිවිඩ ක්‍රියාවිරහිත වී ඇත.", "ස්වයංක්‍රීයව SMS යැවෙන පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
            vbCrLf + vbCrLf + "Message: " + ex.Message + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendSMSError")
        Finally
            If DRBG1 IsNot Nothing AndAlso DRBG1.IsClosed = False Then
                DRBG1.Close()
                CMDBG1.Cancel()
            End If
        End Try

        Try
            tslblLoad.Text = "Backing up Database..."
            If IsFileInUse(My.Settings.DatabaseCNN) = False Then Exit Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "SendSMSError" Then
                    Exit Try
                End If
            Next
            If My.Settings.BackUpDB1 <> "" Then
                File.Copy(My.Settings.DatabaseCNN, My.Settings.BackUpDB1 + "\Database.accdb", True)
            End If
            If My.Settings.BackUpDB2 <> "" Then
                If Not System.IO.Directory.Exists(My.Settings.BackUpDB3 + "\Database Backup") Then
                    System.IO.Directory.CreateDirectory(My.Settings.BackUpDB2 + "\Database Backup")
                End If
                File.Copy(My.Settings.DatabaseCNN, My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " +
                          Today.Month.ToString + ".accdb", True)
                File.SetAttributes(My.Settings.BackUpDB2 + "\Database Backup", FileAttributes.Hidden)

                File.Copy(My.Settings.DatabaseCNN, My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " + Today.Month.ToString +
                                  " " + Today.Day.ToString + " " + DateAndTime.Now.Hour.ToString + ".accdb", True)
                For mnt As Integer = 1 To Today.Month
                    For day As Integer = 1 To (Today.Day - 3)
                        For hour As Integer = 0 To 23
                            If File.Exists(My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
                                                " " + day.ToString + " " + hour.ToString + ".accdb") Then
                                File.Delete(My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
                                                " " + day.ToString + " " + hour.ToString + ".accdb")
                            End If
                        Next
                    Next
                Next
            End If
            If My.Settings.BackUpDB3 <> "" Then
                If Not System.IO.Directory.Exists(My.Settings.BackUpDB3 + "\Database Backup") Then
                    System.IO.Directory.CreateDirectory(My.Settings.BackUpDB3 + "\Database Backup")
                End If
                File.Copy(My.Settings.DatabaseCNN, My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + Today.Month.ToString + ".accdb", True)
                File.SetAttributes(My.Settings.BackUpDB3 + "\Database Backup", FileAttributes.Hidden)

                File.Copy(My.Settings.DatabaseCNN, My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + Today.Month.ToString +
                              " " + Today.Day.ToString + " " + DateAndTime.Now.Hour.ToString + ".accdb", True)
                For mnt As Integer = 1 To Today.Month
                    For day As Integer = 1 To (Today.Day - 3)
                        For hour As Integer = 0 To 23
                            If File.Exists(My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
                                                " " + day.ToString + " " + hour.ToString + ".accdb") Then
                                File.Delete(My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
                                                " " + day.ToString + " " + hour.ToString + ".accdb")
                            End If
                        Next
                    Next
                Next
            End If
        Catch ex As Exception
            CreateMessagePanel("Database Back Up කිරීම බිද වැටී ඇත.", "ස්වයංක්‍රීයව Database Back Up කිරීමේ පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
            vbCrLf + vbCrLf + "Message: " + ex.Message + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendSMSError")
        End Try
        tslblLoad.Text = "Completed"
    End Sub

    Private Sub bgworkerOnline_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworkerOnline.DoWork
        lblBGLoad.Text = "Loading..."
        Dim CMDOnlineDB As New OleDbCommand
        Dim DROnlineDB As OleDbDataReader = Nothing
        Try
            lblBGLoad.Text = "Check Internet Connection..."
            If CheckForInternetConnection() = False Then Exit Try

            lblIPAddress.Text = GETIPADDRESS()
            'If lblIPAddress.Text.Replace("Current IP Address: ", "") <> My.Settings.IPAddress Then
            '    CMDUPDATE("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(" &
            '              AutomaticPrimaryKeyStr("Mail", "MailNo") & ",#" &
            '              DateAndTime.Now & "#,'maleeshaachintha@gmail.com','LASER Shop Router එකේ IP Address එක මරු විය'," &
            '              "'Dalugama LASER Shop එකේ Main Router එකේ IP Address එක මාරු වී ඇති බැවින් Online Database එක " &
            '              "සඳහා Access ලබා දෙන්න. මෙය LASER System එකෙන් Auto Generate වෙන Email එකක් බව කාරුණිකව දැනුම් දෙමි." & vbCrLf &
            '              vbCrLf & lblIPAddress.Text & "','Waiting')")
            '    My.Settings.IPAddress = lblIPAddress.Text.Replace("Current IP Address: ", "")
            '    My.Settings.Save()
            'End If

            If My.Settings.OnlineDBCNN = "" Then Exit Try

            lblBGLoad.Text = "Applying Commands from Online Database to Local DB..."
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim client As New WebClient

            client.Headers.Add("user-agent", My.Settings.UserAgent)
            'client.Headers.Add("user-agent",
            '              "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36 Edg/96.0.1054.29")
            ' with proxy server only:
            Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
            proxy.Credentials = CredentialCache.DefaultNetworkCredentials
            client.Proxy = proxy

            Dim baseurl1 As String = My.Settings.OnlineDBCNN &
                                "?username=" & Simple.Decode(My.Settings.OnlineDBUser) &
                                "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
                                Format(Date.Today, "yyyy-MM-dd")) &
                                "&action=reader"
            Dim data1 As Stream
            data1 = client.OpenRead(baseurl1)
            Dim reader1 As StreamReader = New StreamReader(data1)
            Dim strMyJson As String = reader1.ReadToEnd()
            data1.Close()
            reader1.Close()
            If strMyJson = "UserName and Password is incorrect" Or strMyJson = "Please Enter an Action" Or strMyJson = "Please Enter the Command" Or
            strMyJson = "Please Enter UserName and Password" Then
                e.Result = New String() {"OnlineDBError", strMyJson}
                Exit Try
            End If
            Dim CMDBGOnline As New OleDbCommand
            If strMyJson <> "[]" Then
                Dim tbFinalObject As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(strMyJson)
                For Each row As DataRow In tbFinalObject.Rows
                    If bgworkerOnline.CancellationPending = True Then Exit Try
                    If row("Command").ToString.StartsWith("Insert Into") Then
                        CMDUPDATE(row("Command").ToString)
                    Else
                        CMDBGOnline = New OleDbCommand(row("Command").ToString, CNNBG)
                        CMDBGOnline.ExecuteNonQuery()
                    End If
                    CMDBGOnline.Cancel()

                    'CMDBGOnline = New OleDbCommand("Insert into OnlineDB(ID,ODate,Command) Values(" &
                    '                           AutomaticPrimaryKeyStr("OnlineDB", "ID") &
                    '                           ",#" & DateAndTime.Now & "#,""Update LocalDB Set Status='Done' Where ID=" & row("ID").ToString &
                    '                           """)", CNNBG)
                    'CMDBGOnline.ExecuteNonQuery()

                    Dim baseurl As String = My.Settings.OnlineDBCNN &
                                "?username=" & Simple.Decode(My.Settings.OnlineDBUser) &
                                "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
                                Format(Date.Today, "yyyy-MM-dd")) &
                                "&action=updater" &
                                "&Command=Update LocalDB set Status='Done' Where ID=" & row("ID").ToString
                    ' with proxy server only:
                    Dim data As Stream
                    data = client.OpenRead(baseurl)
                    Dim reader As StreamReader = New StreamReader(data)
                    Dim result As String = reader.ReadToEnd()
                    data.Close()
                    reader.Close()

                    If result <> "1" Then
                        e.Result = New String() {"OnlineDBError", result}
                        Exit Try
                    End If
                Next
            End If
            lblBGLoad.Text = "Updating Online Database..."
            CMDOnlineDB = New OleDb.OleDbCommand("Select * from OnlineDB order by ID", CNNBG)
            DROnlineDB = CMDOnlineDB.ExecuteReader()
            While DROnlineDB.Read
                If bgworkerOnline.CancellationPending = True Then Exit Try
                Dim strCommand As String = DROnlineDB("Command").ToString
                strCommand = strCommand.Replace("#", "'")
                strCommand = strCommand.Replace("\", "\\")
                strCommand = HttpUtility.UrlEncode(strCommand)

                'Dim request As HttpWebRequest = CType(WebRequest.Create(My.Settings.OnlineDBCNN &
                '                                                "?DB=" & My.Settings.DatabaseCNN &
                '                                              "&username=" & Simple.Decode(My.Settings.OnlineDBUser) &
                '                                              "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
                '                                              Format(Date.Today, "yyyy-MM-dd")) &
                '                                              "&action=updater" &
                '                                              "&Command=" & strCommand), HttpWebRequest)
                'txtActivity.Text += (vbCrLf + Command())
                'request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.115 Safari/537.36"
                'Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                'Dim Temp As Stream = response.GetResponseStream()
                'Dim Temp1 As New StreamReader(Temp)
                'Dim result As String = Temp1.ReadToEnd
                'Temp1.Close()
                'Temp.Close()
                'response.Close()

                '// Add a user agent header in case the requested URI contains a query.
                Dim baseurl As String = My.Settings.OnlineDBCNN &
                                "?username=" & Simple.Decode(My.Settings.OnlineDBUser) &
                                "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
                                Format(Date.Today, "yyyy-MM-dd")) &
                                "&action=updater" &
                                "&Command=" & strCommand
                ' with proxy server only:
                Dim data As Stream
                data = client.OpenRead(baseurl)
                Dim reader As StreamReader = New StreamReader(data)
                Dim result As String = reader.ReadToEnd()
                data.Close()
                reader.Close()

                'Try
                '    Dim MySQLCNN As New MySqlConnection("server=72.9.159.36;user id=lasertec_maleeshaachintha;" &
                '                        "password=Achintha25581;database=lasertec_DLUDB;")
                '        MySQLCNN.Open()
                '        Dim MySQLCMD As New MySqlCommand(strCommand, MySQLCNN)
                '        MySQLCMD.ExecuteNonQuery()

                '        MySQLCMD.Cancel()
                '        MySQLCNN.Close()

                '    Dim wClient As New WebClient
                '    Dim result As String = wClient.DownloadString(My.Settings.OnlineDBCNN &
                '                                          "?username=" & Simple.Decode(My.Settings.OnlineDBUser) &
                '                                          "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
                '                                          Format(Date.Today, "yyyy-MM-dd")) &
                '                                          "&action=updater" &
                '                                          "&Command=" & Command())

                If result = "1" Then
                    Dim CMDOnlineDB1 As OleDbCommand = New OleDbCommand("Delete from OnlineDB Where ID=" & DROnlineDB("ID").ToString, CNNBG)
                    CMDOnlineDB1.ExecuteNonQuery()
                    CMDOnlineDB1.Cancel()
                Else
                    e.Result = New String() {"OnlineDBError", result}
                    Continue While
                End If

                'Catch ex As Exception
                '    e.Result = New String() {"OnlineDBError", ex.Message}
                '    lblBGLoad.Text = "Got an error! Online Updater has benn stopped temporarily"
                '    Exit While
                'End Try
            End While
        Catch ex As Exception
            e.Result = New String() {"OnlineDBError", ex.Message}
            lblBGLoad.Text = "Got an error! Online Updater has benn stopped temporarily"
        Finally
            If DROnlineDB IsNot Nothing AndAlso DROnlineDB.IsClosed = False Then
            DROnlineDB.Close()
            CMDOnlineDB.Cancel()
        End If
        End Try
        lblBGLoad.Text = "Completed"
    End Sub

    Private Sub bgworkerOnline_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworkerOnline.RunWorkerCompleted
        lblBGLoad.Text = "Checking Errors..."
        If bgworkerOnline.CancellationPending = True And bgworker.IsBusy = False Then
            End
        End If
        If e.Result IsNot Nothing Then
            Select Case e.Result(0)
                Case "OnlineDBError"
                    For Each controlObject As Control In flpMessage.Controls
                        If controlObject.Tag = "OnlineDBError" Then
                            Exit Sub
                        End If
                    Next
                    CreateMessagePanel("Online Database එක Update කිරීමේදී ගැටලුවක් පැන නැගී ඇත.",
            "Online Database එක Update කිරීමේදී ගැටලුවක් පැන නැගී ඇත." +
            vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "OnlineDBError")
            End Select
        End If
    End Sub

    Function GETIPADDRESS() As String
        Dim client As New WebClient
        '// Add a user agent header in case the requested URI contains a query.
        client.Headers.Add("user-agent", My.Settings.UserAgent)
        Dim baseurl As String = "http://checkip.dyndns.org/"
        ' with proxy server only:
        Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
        proxy.Credentials = CredentialCache.DefaultNetworkCredentials
        client.Proxy = proxy
        Dim data As Stream
        Try
            data = client.OpenRead(baseurl)
        Catch ex As Exception
            Return ""
            Exit Function
        End Try
        Dim reader As StreamReader = New StreamReader(data)
        Dim s As String = reader.ReadToEnd()
        data.Close()
        reader.Close()
        s = s.Replace("<html><head><title>Current IP Check</title></head><body>", "").Replace("</body></html>", "").ToString()
        Return s
    End Function

    Public Function CheckForInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("www.lasertec.lk")
        Catch
            Return False
        End Try
    End Function
    Public Sub GetCNN()
        Try

            If File.Exists(My.Settings.DatabaseCNN) Then
                CNNBG = New OleDbConnection("Provider=" & My.Settings.DbProvider & ";Data Source=" &
                                            My.Settings.DatabaseCNN & ";Jet OLEDB:Database Password=" &
                                            Simple.Decode(My.Settings.DbPassword) & ";")
                If CNNBG.State = ConnectionState.Closed Then
                    CNNBG.Open()
                End If
            End If
        Catch ex As Exception
            Dim TmpBool As Boolean = False
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "DBError" Then
                    TmpBool = True
                End If
            Next
            If TmpBool = False Then CreateMessagePanel("Database Problem", "Message: " + ex.Message + vbCrLf +
                               "Please inform this error to developer for fixing", "DBError")
        End Try
    End Sub

#Region "MessagePanel"
    'Used to give unique control names such as label1, label2 etc
    Private _MessagePanelsAddedCount As Integer = 0

    'Add Message panel to flow layout panel
    Public Sub CreateMessagePanel(Title As String, Message As String, Optional ByVal Tag As String = "")
        Dim MessagePanel As New compMessageBox
        'Add panel to flow layout panel
        flpMessage.Controls.Add(MessagePanel)
        'Update panel variables
        _MessagePanelsAddedCount += 1

        MessagePanel.btnMessageDelete.Name = "btnMessageDelete" + (_MessagePanelsAddedCount).ToString

        MessagePanel.lblTitle.Name = "lblTitle" + (_MessagePanelsAddedCount).ToString
        MessagePanel.lblTitle.Text = Title

        MessagePanel.lblMessage.Name = "lblMessage" + (_MessagePanelsAddedCount).ToString
        MessagePanel.lblMessage.Text = Message

        'Set panel properties
        With MessagePanel
            .Name = "pnlMessage" + (_MessagePanelsAddedCount).ToString
            .Tag = Tag
        End With

        NotifyIcon.ShowBalloonTip(2000, Title, Message, ToolTipIcon.Info)
    End Sub

    Public Sub CreateSMSMsgPanel(MsgNo As Integer)
        If MsgNo = Nothing Then Exit Sub
        Dim MessagePanel As New Guna2Panel
        MessagePanel.Width = flpMessage.Width - 30
        MessagePanel.BorderRadius = 10
        MessagePanel.UseTransparentBackground = True
        MessagePanel.FillColor = Color.White
        MessagePanel.Width = flpMessage.Width - 30
        'Add panel to flow layout panel
        flpMessage.Controls.Add(MessagePanel)

        'Update panel variables
        _MessagePanelsAddedCount += 1

        Dim MessageDeleteButton As New PictureBox

        'Set button properties
        With MessageDeleteButton
            .AutoSize = False
            .Size = New Size(16, 16)
            .Location = New Point(MessagePanel.Width - MessageDeleteButton.Width - 5, 5)
            .Image = My.Resources.close
            .Name = "btnMessageDelete" + (_MessagePanelsAddedCount).ToString
        End With

        'Add button to panel 
        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Name = MessagePanel.Name Then
                controlObject.Controls.Add(MessageDeleteButton)
            End If
        Next

        'Add handler for click events
        AddHandler MessageDeleteButton.Click, AddressOf DynamicButton_Click

        Dim MessageTitleLabel As New Label

        With MessageTitleLabel
            .AutoSize = True
            .Font = New Font("Calibri", 15, FontStyle.Bold)
            .Location = New Point(5, 5)
            .Name = "lblTitle" + (_MessagePanelsAddedCount).ToString
            .Text = "Message එක Send කරන්නද?"
            .ForeColor = Color.Black
            .MaximumSize = New Size(MessagePanel.Width - 10, 0)
        End With

        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Name = MessagePanel.Name Then
                controlObject.Controls.Add(MessageTitleLabel)
            End If
        Next

        Dim MessageLabel As New Label

        With MessageLabel
            .AutoSize = True
            .Font = New Font("Calibri", 12, FontStyle.Regular)
            .Location = New Point(5, Int(MessageTitleLabel.Top) + Int(MessageTitleLabel.Height) + 5)
            .Name = "lblMessage" + (_MessagePanelsAddedCount).ToString
            .Text = "Telephone No: " & GetStrfromRelatedfield("Select CuTelNo from Message Where MsgNo=" & MsgNo, "CuTelNo") &
                vbCrLf & "Message: " & GetStrfromRelatedfield("Select Message from Message Where MsgNo=" & MsgNo, "Message")
            .ForeColor = Color.DarkGray
            .MaximumSize = New Size(MessagePanel.Width - 10, 0)
        End With

        'Add button to panel 
        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Name = MessagePanel.Name Then
                controlObject.Controls.Add(MessageLabel)
            End If
        Next

        Dim btnPrimary As New Button
        With btnPrimary
            .AutoSize = True
            .Font = New Font("Calibri", 12, FontStyle.Regular)
            .Location = New Point(5, Int(MessageLabel.Top) + Int(MessageLabel.Height) + 5)
            .Name = "btnPrimary" + (_MessagePanelsAddedCount).ToString
            .Text = "Send"
            .Tag = MsgNo
            .MaximumSize = New Size(((MessagePanel.Width - 10) / 2) - 5, 0)
        End With

        'Add button to panel 
        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Name = MessagePanel.Name Then
                controlObject.Controls.Add(btnPrimary)
            End If
        Next
        'Add handler for click events
        AddHandler btnPrimary.Click, AddressOf btnPrimary_Click

        Dim btnSecondary As New Button
        With btnSecondary
            .AutoSize = True
            .Font = New Font("Calibri", 12, FontStyle.Regular)
            .Location = New Point(Int(btnPrimary.Left) + Int(btnPrimary.Width) + 5, Int(MessageLabel.Top) + Int(MessageLabel.Height) + 5)
            .Name = "btnSecondary" + (_MessagePanelsAddedCount).ToString
            .Text = "Don't Send"
            .Tag = MsgNo
            .MaximumSize = New Size(((MessagePanel.Width - 10) / 2) - 5, 0)
        End With

        'Add button to panel 
        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Name = MessagePanel.Name Then
                controlObject.Controls.Add(btnSecondary)
            End If
        Next
        'Add handler for click events
        AddHandler btnSecondary.Click, AddressOf btnSecondary_Click

        'Set panel properties
        With MessagePanel
            .BackColor = Color.White
            .Height = Int(btnPrimary.Top) + Int(btnPrimary.Height) + 5
            .Name = "pnlMessage" + (_MessagePanelsAddedCount).ToString
            .Tag = "SendSMSConfirmation" + MsgNo.ToString
        End With
    End Sub

    Private Sub btnSecondary_Click(sender As Object, e As EventArgs)
        'Dim i As Integer = If(IsNumeric(sender.name.ToString.Replace("btnPrimary", "")), Int(sender.name.ToString.Replace("btnPrimary", "")), Nothing)
        CMDUPDATE("Update Message set Status='Declined' Where MsgNo=" & sender.tag)
        DynamicButton_Click(sender, e)
    End Sub

    Private Sub btnPrimary_Click(sender As Object, e As EventArgs)
        CMDUPDATE("Update Message set Status='Confirmed' Where MsgNo=" & sender.tag)
        DynamicButton_Click(sender, e)
    End Sub
    'Remove handlers and Message panel 
    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentPanelName As String = Nothing

        'Remove handler from sender
        For Each controlObj As Control In flpMessage.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then
                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click
                    parentPanelName = childControlObj.Parent.Name
                End If
            Next
            If controlObj.Name = parentPanelName Then
                flpMessage.Controls.Remove(controlObj)
                controlObj.Dispose()
            End If
        Next

    End Sub
#End Region

#Region "Encode&Decode"
    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider

        Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function

        Sub New(ByVal key As String)
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        End Sub

        Private Function EncryptData(ByVal plaintext As String) As String

            ' Convert the plaintext string to a byte array. 
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream. 
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream. 
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string. 


            Return Convert.ToBase64String(ms.ToArray)

        End Function

        Private Function DecryptData(ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array. 
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream. 
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream. 
            Dim decStream As New CryptoStream(ms,
                TripleDes.CreateDecryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string. 
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function

        Public Function Decode(cipher As String) As String
            Try
                If cipher <> "" Then
                    Return DecryptData(cipher)
                Else
                    Return ""
                End If
            Catch ex As CryptographicException
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function Encode(txt As String) As String
            Try
                Return EncryptData(txt)
            Catch ex As CryptographicException
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class
    Public Function GetMD5Encoder(theInput As String) As String
        ' Convert to byte array and get hash
#Disable Warning BC40000 ' Type or member is obsolete
        Dim dbytes As Byte() = Encoding.UTF8.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile(theInput, "MD5"))
#Enable Warning BC40000 ' Type or member is obsolete

        Return Convert.ToBase64String(dbytes)
    End Function
#End Region

    Public Sub CMDUPDATE(str As String, Optional ByVal DoesAdminSend As Boolean = False, Optional ByVal Remarks As String = "")
        Dim CMDUPDATEDB As OleDbCommand
        If str.Contains("?") = True Then
            Dim splittxt() As String = str.Split("?")
            If splittxt(1) = "PrimaryKey" Then
                str = str.Replace("?" + splittxt(1) + "?" + splittxt(2) + "?" + splittxt(3) + "?", AutomaticPrimaryKeyStr(splittxt(2), splittxt(3)))
            End If
        End If
        CMDUPDATEDB = New OleDb.OleDbCommand(str, CNNBG)
        CMDUPDATEDB.ExecuteNonQuery()
        CMDUPDATEDB = New OleDbCommand("Insert into OnlineDB(ID,ODate,Command) Values(" &
                                           AutomaticPrimaryKeyStr("OnlineDB", "ID") & ",#" & DateAndTime.Now & "#,""" &
                                           str.Replace("""", """""") & """)", CNNBG)
        CMDUPDATEDB.ExecuteNonQuery()
        WriteActivity(DateAndTime.Now + "- " + str)
        CMDUPDATEDB.Cancel()
    End Sub
    Public Sub WriteActivity(txt As String)
        File.AppendAllText(Application.StartupPath & "\System Files\Activity\BGActivity.ls", txt + vbNewLine)
        txtActivity.AppendText(txt + vbNewLine)
    End Sub

    Public Function GetStrfromRelatedfield(SQL As String, ColumnName As String) As String
        Dim CMD0 = New OleDb.OleDbCommand(SQL, CNNBG)
        Dim DR0 As OleDb.OleDbDataReader = CMD0.ExecuteReader
        If DR0.HasRows = True Then
            DR0.Read()
            Return DR0(ColumnName).ToString
        Else
            Return "0"
        End If
    End Function

    Public Function AutomaticPrimaryKeyStr(TableName As String, ColumnName As String) As String
        Dim CMD0 = New OleDbCommand("Select Top 1 " & ColumnName & " from " & TableName & " Order By " & ColumnName & " Desc;", CNNBG)
        Dim DR0 As OleDbDataReader = CMD0.ExecuteReader()
        If DR0.HasRows = True Then
            DR0.Read()
            Return (Int(DR0.Item(ColumnName)) + 1)
        Else
            Return ("1")
        End If
        CMD0.Cancel()
        DR0.Close()
    End Function

    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        If CheckEmptyfield(txtDBLocation, "Database Location field is empty, Please select the database!") = False Then
            Exit Sub
        ElseIf File.Exists(txtDBLocation.Text) = False Then
            MsgBox("This file name couldn't be found. Please select correct file for using a database", vbExclamation + vbOKOnly)
            Exit Sub
        ElseIf CheckEmptyfield(cmbDbProvider, "Database Provider Field එක හිස්ව පවතියි.") = False Then
            Exit Sub
        End If
        If Me.Tag <> "Login" Then
            If CheckEmptyfield(cmbMBgSMS,
                "Background send SMS යන field එක හිස්ව පවතියි. කරුණාකර එය නැවත සකස් කරන්න.") = False Then
                Exit Sub
            ElseIf chkMSendEmail.Checked = True AndAlso CheckEmptyfield(txtMAdminEmail,
                "Admin Email එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කර උත්සහ කරන්න.") = False Then
                Exit Sub
            ElseIf chkMSendEmail.Checked = True AndAlso CheckEmptyfield(txtMAdminPass, "Admin Email Password එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කර උත්සහ කරන්න.") = False Then
                Exit Sub
            ElseIf cmbMBgSMS.Text <> "OFF" AndAlso CheckEmptyfield(
                txtMApiKey, "Api Key යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කර නැවත උත්සහ කරන්න.") = False Then
                Exit Sub
            ElseIf cmbMBgSMS.Text <> "OFF" AndAlso CheckEmptyfield(
                txtMApiToken, "Api Token යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කර නැවත උත්සහ කරන්න.") = False Then
                Exit Sub
            End If
        End If
        With My.Settings
            .DatabaseCNN = txtDBLocation.Text
            .APIKey = txtMApiKey.Text
            .APIToken = txtMApiToken.Text
            .BGSendSMS = cmbMBgSMS.Text
            .SendEmail = chkMSendEmail.CheckState
            .AdminEmail = txtMAdminEmail.Text
            .AdminEmailPass = Simple.Encode(txtMAdminPass.Text)
            .BackUpDB1 = txtBackUpDB1.Text
            .BackUpDB2 = txtBackUpDB2.Text
            .BackUpDB3 = txtBackUpDB3.Text
            .UserAgent = txtUserAgent.Text
            If txtDbPassword.Text <> "" Then .DbPassword = Simple.Encode(txtDbPassword.Text)
            .DbProvider = cmbDbProvider.Text
            If chkOnlineDB.CheckState = False Then
                .OnlineDBCNN = ""
                .OnlineDBUser = ""
                .OnlineDBPass = ""
            Else
                .OnlineDBCNN = txtOnlineDB.Text
                .OnlineDBUser = Simple.Encode(txtOnlineDBUser.Text)
                .OnlineDBPass = Simple.Encode(txtOnlineDBPass.Text)
            End If
            .Save()
        End With
        tmrRefresh.Start()
    End Sub
    Public Function CheckEmptyfield(cmb As Object, msg As String) As Boolean
        CheckEmptyfield = True
        If cmb.Text = "" Then
            MsgBox(msg, vbCritical + vbOKOnly)
            cmb.Focus()
            Return False
        End If
    End Function

    Private Sub cmdDBLocation_Click(sender As Object, e As EventArgs) Handles cmdDBLocation.Click
        ofdDatabase.Title = "Please select the DataBase file"
        ofdDatabase.InitialDirectory = Application.StartupPath
        ofdDatabase.Filter = "DB Files|*.accdb|DB (old) Files|*.mdb"
        If ofdDatabase.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtDBLocation.Text = ofdDatabase.FileName
        End If
    End Sub

    Private Sub chkOnlineDB_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnlineDB.CheckedChanged
        If chkOnlineDB.Checked = True Then
            txtOnlineDB.Enabled = True
            txtOnlineDBPass.Enabled = True
            txtOnlineDBUser.Enabled = True
        Else
            txtOnlineDB.Enabled = False
            txtOnlineDBPass.Enabled = False
            txtOnlineDBUser.Enabled = False
        End If
    End Sub

    Private Sub btnAdminEmailVerify_Click(sender As Object, e As EventArgs) Handles btnAdminEmailVerify.Click
        If CheckEmptyfield(txtMAdminEmail, "කරුණාකර Admin Email එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim sPrefix As String = ""
        Dim rdm As New Random()
        For i As Integer = 1 To 5 ' 5 Letters generated
            sPrefix &= ChrW(rdm.Next(65, 90))
        Next
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient("smtp.gmail.com")
        mail.From = New MailAddress(txtMAdminEmail.Text)
        mail.[To].Add(txtMAdminEmail.Text)
        mail.Subject = "LASER System එකෙහි Admin Email එකක් ඇතුලත් කරගැනීම සඳහා තහවුරු කිරීම."
        mail.Body = "LASER System " + vbCrLf + vbCrLf +
                "කරුණාකර ඔබගේ Admin Email එක Verify කිරීම සඳහා පහත සඳහන් කේතය භාවිතා කරන්න. " + vbCrLf + vbCrLf +
                "Admin Email: " + txtMAdminEmail.Text & "." + vbCrLf +
                "Security code: " + sPrefix

        SmtpServer.Port = 587
        SmtpServer.UseDefaultCredentials = False
        SmtpServer.Credentials = New System.Net.NetworkCredential(txtMAdminEmail.Text, txtMAdminPass.Text)
        SmtpServer.EnableSsl = True

        For i As Integer = 3 To 0 Step -1
            Try
                SmtpServer.Send(mail)
                Exit For
            Catch
                Threading.Thread.Sleep(2000)
            End Try
        Next

        txtMAdminEmailVerify.Tag = sPrefix
        Cursor = Cursors.Default
    End Sub

    Private Sub frmBGTasks_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        CNNBG.Close()
        End
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmBGTasks_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If chkActive.Checked = False Then Me.Hide()
    End Sub

    Private Sub cmdBackUpDB1_Click(sender As Object, e As EventArgs) Handles cmdBackUpDB1.Click
        If dlgFolder.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtBackUpDB1.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmdBackUpDB2_Click(sender As Object, e As EventArgs) Handles cmdBackUpDB2.Click
        If dlgFolder.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtBackUpDB2.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmdBackUpDB3_Click(sender As Object, e As EventArgs) Handles cmdBackUpDB3.Click
        If dlgFolder.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtBackUpDB3.Text = dlgFolder.SelectedPath
        End If
    End Sub
    Private Function IsFileInUse(sFile As String) As Boolean
        Try
            Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            End Using
        Catch Ex As Exception
            Return True
        End Try
        Return False
    End Function
End Class

