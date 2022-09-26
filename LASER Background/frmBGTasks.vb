Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports System.Web
Imports MaterialSkin
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmBGTasks
    Private CNNBG As OleDbConnection
    Private CMDBG1, CMDBG2 As New OleDbCommand
    Private DRBG1, DRBG2 As OleDbDataReader
    Public ReadOnly Simple As New Simple3Des("RandomKey45")
    Public Sub New()

        Me.Hide()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim process As New Process()
        ' Pass your exe file path here.
        Dim path As String = Application.StartupPath + "\" + Application.ProductName + ".exe"
        Dim fileName As String = System.IO.Path.GetFileName(path)
        ' Get the precess that already running as per the exe file name.
        Dim processName As Process() = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf("."c)))
        If processName.Length > 1 Then
            End
        End If

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        With My.Settings
            txtDBLocation.Text = .DatabaseCNN
            cmbDbProvider.Text = .DBProvider
            txtDBLocation.Tag = .DatabaseCNN
            txtMApiKey.Text = .APIKey
            txtMApiToken.Text = .APIToken
            cmbMBgSMS.Text = .BGSendSMS
            chkMSendEmail.Checked = .SendEmail
            txtMAdminEmail.Text = .AdminEmail
            txtBackUpDB1.Text = .BackUpDB1
            txtBackUpDB2.Text = .BackUpDB2
            txtBackUpDB3.Text = .BackUpDB3

            If .AdminEmailPass <> "" Then txtMAdminPass.Text = Simple.Decode(.AdminEmailPass)
            chkOnlineDB.Checked = .ODBActive
            If .ODBActive Then
                txtOPath.Text = .ODBPath
                txtOUser.Text = My.Settings.ODBUser
            Else
                txtOPath.Text = ""
                txtOUser.Text = ""
            End If
            chkOnlineDB_CheckedChanged(Nothing, Nothing)
        End With
        If Not Directory.Exists(Application.StartupPath + "/System Files") Then My.Computer.FileSystem.CreateDirectory(Application.StartupPath +
                                                                                                                               "/System Files")
        If Not Directory.Exists(Application.StartupPath + "/System Files/Activity") Then My.Computer.FileSystem.CreateDirectory(Application.StartupPath +
                                                                                                                               "/System Files/Activity")
        If Not File.Exists(Application.StartupPath + "/System Files/Activity/BGActivity.json") Then
            Dim d As FileStream
            d = File.Create(Application.StartupPath & "/System Files/Activity/BGActivity.json")
            d.Close()
        End If
        'Load the activity file
        Dim JSONStr As String = File.ReadAllText(Application.StartupPath & "\System Files\Activity\BGActivity.json")
        If String.IsNullOrEmpty(JSONStr) Then
            GridActivity.Columns.Add("Date", "Date")
            GridActivity.Columns.Item("Date").DataPropertyName = "Date"
            GridActivity.Columns.Add("Command", "Command")
            GridActivity.Columns.Item("Command").DataPropertyName = "Command"
        Else
            Dim DT As DataTable = JsonConvert.DeserializeObject(Of DataTable)(JSONStr)
            GridActivity.DataSource = DT
        End If
        tmrRefresh.Start()
    End Sub
    Private Sub FrmBGTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.BelowNormal
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        GetCNN()

        If File.Exists(Application.StartupPath + "\ShutDown.txt") Then
            File.Delete(Application.StartupPath + "\ShutDown.txt")
        End If
    End Sub

    Private Sub FrmBGTasks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        bgworker.CancelAsync()
        bgworkerOnline.CancelAsync()
        tmrRefresh.Stop()
        Me.Hide()
        Me.Tag = "Close"

        If bgworker.IsBusy = True Or bgworkerOnline.IsBusy = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        If File.Exists(Application.StartupPath + "\ShutDown.txt") Then
            File.Delete(Application.StartupPath + "\ShutDown.txt")
            Me.Close()
        End If

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
        If bgworker.IsBusy = False And PicBGStop.Tag = "Stop" Then bgworker.RunWorkerAsync()
        If My.Settings.ODBActive And bgworkerOnline.IsBusy = False And
            PicBGOStop.Tag = "Stop" Then bgworkerOnline.RunWorkerAsync()
    End Sub

    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworker.DoWork
        bgworker.ReportProgress(0, "Applying Admin Confirmed commands...")
        Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "AdminPermissionError" Then
                    Exit Sub
                End If
            Next
            CMDBG1 = New OleDb.OleDbCommand("Select * from AdminPermission Where Status='Confirmed';", CNNBG)
            DRBG1 = CMDBG1.ExecuteReader
            While DRBG1.Read
                If bgworker.CancellationPending Then e.Cancel = True : Exit Sub
                Dim Dict As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(DRBG1("Keys").ToString)
                'Replace a new index instead of command in keys dictionary 
                If Dict.Count > 0 Then
                    For Each key As String In Dict.Keys.ToList()
                        If Dict(key).Contains("?") = True Then
                            Dim splittxt() As String = Dict(key).Split("?")
                            Select Case splittxt(1)
                                Case "NewKey"
                                    Dict(key) = Dict(key).Replace("?" + splittxt(1) + "?" + splittxt(2) + "?" + splittxt(3) + "?",
AutomaticPrimaryKey(splittxt(2), splittxt(3)))
                            End Select
                        End If
                    Next
                    CMDUPDATE($"Update AdminPermission Set Keys='{JsonConvert.SerializeObject(Dict, Formatting.Indented)}' 
Where APNo={DRBG1("APNo")}")
                End If
                CMDBG2 = New OleDbCommand($"Select * from APCommand Where APNo={DRBG1("APNo")}", CNNBG)
                DRBG2 = CMDBG2.ExecuteReader()
                While DRBG2.Read
                    Dim Str As String = DRBG2("Commands")
                    'Replace a new index instead of command
                    If DRBG2("Commands").Contains("?") = True Then
                        Dim splittxt() As String = Str.Split("?")
                        Dim i As Integer = 0
                        While i < splittxt.Length
                            Select Case splittxt(i)
                                Case "NewKey"
                                    Str = Str.Replace("?" + splittxt(i) + "?" + splittxt(i + 1) +
                                                                                  "?" + splittxt(i + 2) + "?",
AutomaticPrimaryKey(splittxt(i + 1), splittxt(i + 2)))
                                    i += 2
                                Case "Key"
                                    If Dict.ContainsKey(splittxt(i + 1)) Then
                                        Str = Str.Replace($"?{splittxt(i)}?{splittxt(i + 1)}?", Dict.Item(splittxt(i + 1)))
                                        i += 1
                                    End If
                            End Select
                            i += 1
                        End While
                        CMDUPDATE($"Update APCommand Set Commands=""{Str}"" Where APCNo={DRBG2("APCNo")}")
                    End If
                    CMDUPDATE(Str)
                End While
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

        bgworker.ReportProgress(20, "Send Messages to Customers for Repaired Items...")
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
                If bgworker.CancellationPending Then e.Cancel = True : Exit Sub
                If DRBG1("CuTelNo1").ToString.Replace(" ", "") = "" Then Continue While
                CMDBG2 = New OleDb.OleDbCommand("Select * from Message where RepNo = " & DRBG1("RepNo").ToString, CNNBG)
                DRBG2 = CMDBG2.ExecuteReader
                If DRBG2.HasRows = False Then
                    If DRBG1("Status").ToString = "Repaired Not Delivered" Then
                        CMDUPDATE("Insert into Message(MsgNo,MsgDate,RepNo,CuTelNo,Message,`Status`) Values(" &
                                          AutomaticPrimaryKey("Message", "MsgNo") & ",#" & DateAndTime.Now & "#," &
                                          DRBG1("RepNo").ToString & ",'" & DRBG1("CuTelNo1").ToString & "','" &
                                    "ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DRBG1("PName").ToString + " " + DRBG1("PCategory").ToString +
                                    " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + DRBG1("Charge").ToString + " වේ.','Waiting')")
                    ElseIf DRBG1("Status").ToString = "Returned Not Delivered" Then
                        If DRBG1("Charge").ToString = "0" Then
                            CMDUPDATE("Insert into Message(MsgNo,MsgDate,RepNo,CuTelNo,Message,`Status`) Values(" &
                                          AutomaticPrimaryKey("Message", "MsgNo") & ",#" & DateAndTime.Now & "#," & DRBG1("RepNo").ToString &
                                          ",'" & DRBG1("CuTelNo1").ToString & "','" &
                                              "ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DRBG1("PName").ToString + " " +
                                              DRBG1("PCategory").ToString +
                                              " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු.','Waiting')")
                        Else
                            CMDUPDATE("Insert into Message(MsgNo,MsgDate,RepNo,CuTelNo,Message,`Status`) Values(" &
                                          AutomaticPrimaryKey("Message", "MsgNo") & ",#" & DateAndTime.Now & "#," & DRBG1("RepNo").ToString &
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

        bgworker.ReportProgress(40, "Sending Emails...")
        Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "SendEmailsError" Then
                    Exit Try
                End If
            Next
            CMDBG1 = New OleDb.OleDbCommand("Select * from Mail Where Status='Waiting';", CNNBG)
            DRBG1 = CMDBG1.ExecuteReader()
            While DRBG1.Read()
                If bgworker.CancellationPending Then e.Cancel = True : Exit Sub
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

        If My.Settings.BGSendSMS <> "OFF" Then
            bgworker.ReportProgress(60, "Reloading Balance Amount of the SMS Service...")
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
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub BgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworker.RunWorkerCompleted
        lblLoad.Text = "Checking Error..."
        tsProBar.Value = 65

        If e.Cancelled And bgworkerOnline.IsBusy = False And Me.Tag = "Close" Then
            End
        ElseIf e.Cancelled Then
            Exit Sub
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

        lblLoad.Text = "Sending SMS Messages..."
        tsProBar.Value = 70
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
                    If Bool = True Then CreateMessagePanel(Int(DRBG1("MsgNo").ToString))
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

        lblLoad.Text = "Backing up Database..."
        tsProBar.Value = 90
        Try
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

        lblLoad.Text = "Restarting..."
        tsProBar.Value = 100
    End Sub

    Private Sub bgworkerOnline_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworkerOnline.DoWork
        bgworkerOnline.ReportProgress(0, "Loading...")
        Dim CMDODB As New OleDbCommand
        Dim DRODB As OleDbDataReader = Nothing
        Dim RowsCount, CurrentIndex As Integer
        Dim OConfig As String = $"user={HashPassword(My.Settings.ODBUser, Simple.Decode(My.Settings.ODBToken))}&password={HashPassword(Simple.Decode(My.Settings.ODBPassword) + Format(Now(), "yyyy-MM-dd"), Simple.Decode(My.Settings.ODBToken))}"
        'Check Internet Connection
        If CheckForInternetConnection() = False Then Exit Sub

        'Get the IP Address
        lblIPAddress.Text = GETIPADDRESS()

        If Not My.Settings.ODBActive Then Exit Sub

        bgworkerOnline.ReportProgress(0, "Updating Local Database...")
        Try
            For Each controlObject As Control In flpMessage.Controls
                If controlObject.Tag = "ODBDownloadError" Then
                    Exit Try
                End If
            Next

            Dim JSONResponse As String = GetResponse(My.Settings.ODBPath + "/view", $"{OConfig}&sql=SELECT * FROM `LocalDB` WHERE `Status`='Waiting' ORDER BY `Date`")
            If JSONResponse.StartsWith("Error:") Then
                e.Result = New String() {"ODBDownloadError", JSONResponse}
                Exit Sub
            End If

            Dim DicResult As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(JSONResponse)
            If DicResult.Item("status") = True Then
                Dim BGDT As DataTable = JsonConvert.DeserializeObject(Of DataTable)(DicResult.Item("result").ToString)
                RowsCount = BGDT.Rows.Count
                CurrentIndex = 0
                For Each DataRow As DataRow In BGDT.Rows
                    'Check whether user needs to cancel the operation
                    If bgworkerOnline.CancellationPending Then e.Cancel = True : Exit Sub
                    'Applying the changes online users has made to the local db
                    Dim Command As String = DataRow("Command").ToString.Trim
                    If Command.StartsWith("Insert Into", True, Nothing) Then
                        CMDUPDATE(Command)
                    Else
                        Dim CMDBGOnline As New OleDbCommand(Command, CNNBG)
                        CMDBGOnline.ExecuteNonQuery()
                        CMDBGOnline.Dispose()
                    End If
                    'Mark online db that the changes has done
                    JSONResponse = GetResponse(My.Settings.ODBPath + "/update",
                                           $"{OConfig}&sql=UPDATE `LocalDB` Set `Status`='Done' WHERE ID={DataRow("ID").ToString}")
                    If JSONResponse.StartsWith("Error:") Then
                        e.Result = New String() {"ODBDownloadError", JSONResponse}
                        Exit Sub
                    End If
                    DicResult = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(JSONResponse)
                    If DicResult.Item("status") = False Then
                        Dim ErrorMsg As String = ""
                        For Each KeyPair As KeyValuePair(Of String, Object) In DicResult
                            ErrorMsg += KeyPair.Key + ": " + KeyPair.Value.ToString + vbNewLine
                        Next
                        e.Result = New String() {"ODBDownloadError", ErrorMsg}
                        Exit Sub
                    End If
                    'For updating UI
                    CurrentIndex += 1
                    bgworkerOnline.ReportProgress(Int((CurrentIndex / RowsCount) * 100),
                                                  $"Updating Local Database ({CurrentIndex}/{RowsCount})...")
                Next
            Else
                Dim ErrorMsg As String = ""
                For Each KeyPair As KeyValuePair(Of String, Object) In DicResult
                    ErrorMsg += KeyPair.Key + ": " + KeyPair.Value.ToString + vbNewLine
                Next
                e.Result = New String() {"ODBDownloadError", ErrorMsg}
            End If
        Catch ex As Exception
            e.Result = New String() {"ODBDownloadError", ex.Message}
            Exit Sub
        End Try

        bgworkerOnline.ReportProgress(0, "Updating Online Database...")
        Try
            CMDODB = New OleDbCommand("Select * from OnlineDB order by ID", CNNBG)
            'For get the count of rows 
            Dim CMDODB1 As New OleDbCommand("Select Count(*) From OnlineDB", CNNBG)
            RowsCount = CMDODB1.ExecuteScalar      'For updating the value of progressbar
            CMDODB1.Cancel()
            CurrentIndex = 0
            DRODB = CMDODB.ExecuteReader()
            While DRODB.Read
                'Check whether user needs to cancel the operation
                If bgworkerOnline.CancellationPending = True Then e.Cancel = True : Exit Sub

                Dim Command As String = DRODB("Command").ToString.Replace("#", "'")
                Dim JSONResponse As String = GetResponse(My.Settings.ODBPath + "/update",
                                       $"{OConfig}&sql={Command}")
                If JSONResponse.StartsWith("Error:") Then
                    e.Result = New String() {"ODBUploadError", JSONResponse}
                    Exit Sub
                End If
                Dim DicResult As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(JSONResponse)
                If DicResult.Item("status") = True Then
                    Dim CMDOnlineDB1 As New OleDbCommand("Delete from OnlineDB Where ID=" & DRODB("ID").ToString, CNNBG)
                    CMDOnlineDB1.ExecuteNonQuery()
                    CMDOnlineDB1.Cancel()
                Else
                    Dim ErrorMsg As String = ""
                    For Each KeyPair As KeyValuePair(Of String, Object) In DicResult
                        ErrorMsg += KeyPair.Key + ": " + KeyPair.Value.ToString + vbNewLine
                    Next
                    e.Result = New String() {"ODBUploadError", ErrorMsg}
                    Exit Sub
                End If
                'Update the value of progress bar
                CurrentIndex += 1
                bgworkerOnline.ReportProgress(Int((CurrentIndex / RowsCount) * 100),
                                     $"Updating Online Database ({CurrentIndex}/{RowsCount})...")
            End While
        Catch ex As Exception
            e.Result = New String() {"ODBUploadError", ex.Message}
            Exit Sub
        End Try
        If Not IsNothing(DRODB) AndAlso DRODB.IsClosed = False Then
            DRODB.Close()
            CMDODB.Cancel()
        End If
        bgworkerOnline.ReportProgress(100, "Completed")
    End Sub

    Private Sub bgworkerOnline_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworkerOnline.RunWorkerCompleted
        lblBGLoad.Text = "Checking Errors..."
        If e.Cancelled And bgworker.IsBusy = False And Me.Tag = "Close" Then
            End
        ElseIf e.Cancelled Then
            Exit Sub
        End If
        If e.Result IsNot Nothing Then
            lblBGLoad.Text = "Freezed"
            Select Case e.Result(0)
                Case "ODBDownloadError"
                    CreateMessagePanel("Local Database එක Update කිරීමේදී ගැටලුවක් පැන නැගී ඇත.",
                                       e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "ODBDownloadError")
                Case "ODBUploadError"
                    For Each controlObject As Control In flpMessage.Controls
                        If controlObject.Tag = "ODBUploadError" Then
                            Exit Sub
                        End If
                    Next
                    CreateMessagePanel("Online Database එක Update කිරීමේදී ගැටලුවක් පැන නැගී ඇත.",
                                       e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "ODBUploadError")
            End Select
        End If
    End Sub

    Public Function GetResponse(Path As String, Data As String) As String
        Try
            Dim s As HttpWebRequest
            Dim enc As UTF8Encoding
            Dim postdata As String
            Dim postdatabytes As Byte()
            s = HttpWebRequest.Create(Path)
            enc = New System.Text.UTF8Encoding()

            postdata = Data
            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"
            s.ContentType = "application/x-www-form-urlencoded"
            s.ContentLength = postdatabytes.Length

            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim result = s.GetResponse()
            Dim reader As New StreamReader(result.GetResponseStream)
            Return reader.ReadToEnd
        Catch ex As Exception
            Return "Error: " + ex.Message
        End Try
    End Function

    Public Function HashPassword(ByVal Password As String, ByVal Salt As String) As String
        Dim pwd As String = Password & Salt
        Dim hasher As New System.Security.Cryptography.SHA256Managed()
        Dim pwdb As Byte() = System.Text.Encoding.UTF8.GetBytes(pwd)
        Dim pwdh As Byte() = hasher.ComputeHash(pwdb)
        Return Convert.ToBase64String(pwdh)
    End Function

    Private Function GETIPADDRESS() As String
        Dim client As New WebClient
        '// Add a user agent header in case the requested URI contains a query.
        client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko")
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
                CNNBG = New OleDbConnection("Provider=" & My.Settings.DBProvider & ";Data Source=" &
                                            My.Settings.DatabaseCNN & ";Jet OLEDB:Database Password=" &
                                            Simple.Decode(My.Settings.DBPassword) & ";")
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

    'Add Message panel to flow layout panel
    Public Sub CreateMessagePanel(Title As String, Message As String, Optional ByVal Tag As String = "")

        'Update panel variables
        Dim MessagePanel As New MessageBox With {
            .Title = Title,
            .Message = Message,
            .Tag = Tag
        }
        flpMessage.Controls.Add(MessagePanel)

        NotifyIcon.ShowBalloonTip(2000, Title, Message, ToolTipIcon.Info)
    End Sub

    Public Sub CreateMessagePanel(MsgNo As Integer)
        If MsgNo = Nothing Then Exit Sub
        Dim MessagePanel As New MessageBox With {
            .Title = "Message එක Send කරන්නද?",
            .Message = "Telephone No: " & GetStrfromRelatedfield("Select CuTelNo from Message Where MsgNo=" & MsgNo, "CuTelNo") &
                vbCrLf & "Message: " & GetStrfromRelatedfield("Select Message from Message Where MsgNo=" & MsgNo, "Message"),
            .Width = flpMessage.Width - 30,
            .Tag = "SendSMSConfirmation" + MsgNo.ToString
        }

        'Set panel properties
        With MessagePanel
            .PanelAction.Visible = True
            .Btn1.Text = "Send"
            .Btn2.Text = "Don't Send"
        End With

        'Add panel to flow layout panel
        flpMessage.Controls.Add(MessagePanel)
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
#End Region

    Public Sub CMDUPDATE(str As String, Optional ByVal DoesAdminSend As Boolean = False, Optional ByVal Remarks As String = "")
        Dim CMDUPDATEDB As OleDbCommand
        If str.Contains("?") = True Then
            Dim splittxt() As String = str.Split("?")
            If splittxt(1) = "PrimaryKey" Then
                str = str.Replace("?" + splittxt(1) + "?" + splittxt(2) + "?" + splittxt(3) + "?", AutomaticPrimaryKey(splittxt(2), splittxt(3)))
            End If
        End If
        CMDUPDATEDB = New OleDb.OleDbCommand(str, CNNBG)
        CMDUPDATEDB.ExecuteNonQuery()
        CMDUPDATEDB = New OleDbCommand("Insert into OnlineDB(ID,ODate,Command) Values(" &
                                           AutomaticPrimaryKey("OnlineDB", "ID") & ",#" & DateAndTime.Now & "#,""" &
                                           str.Replace("""", """""") & """)", CNNBG)
        CMDUPDATEDB.ExecuteNonQuery()
        WriteActivity(str)
        CMDUPDATEDB.Cancel()
    End Sub
    Public Sub WriteActivity(txt As String)
        Dim DT As New DataTable
        Dim newID As Integer
        Dim Rjson As String = File.ReadAllText(Application.StartupPath & "\System Files\Activity\BGActivity.json")
        If String.IsNullOrEmpty(Rjson) Then
            DT.Columns.Add("ID")
            DT.Columns.Add("Date")
            DT.Columns.Add("Command")
            newID = 1
        Else
            DT = JsonConvert.DeserializeObject(Of DataTable)(Rjson)
            newID = DT.Rows(DT.Rows.Count - 1)(0) + 1
        End If
        DT.Rows.Add(newID, Now, txt)

        Dim Wjson As String = JsonConvert.SerializeObject(DT, Formatting.Indented)
        File.WriteAllText(Application.StartupPath & "\System Files\Activity\BGActivity.json", Wjson)
    End Sub

    Public Function GetRowsCount(CMDBG As OleDbCommand) As Integer
        Dim DA0 As New OleDbDataAdapter(CMDBG)
        Dim DT0 As New DataTable
        DA0.Fill(DT0)
        Return DT0.Rows.Count
    End Function

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

    Public Function AutomaticPrimaryKey(TableName As String, ColumnName As String) As String
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
            If txtDbPassword.Text <> "" Then .DBPassword = Simple.Encode(txtDbPassword.Text)
            .DBProvider = cmbDbProvider.Text
            .ODBActive = chkOnlineDB.Checked
            If chkOnlineDB.CheckState Then
                .ODBPath = txtOPath.Text
                .ODBUser = txtOUser.Text
                If txtOPassword.Text <> "" Then .ODBPassword = Simple.Encode(txtOPassword.Text)
                If TxtOToken.Text <> "" Then .ODBToken = Simple.Encode(TxtOToken.Text)
            Else
                .ODBPath = ""
                .ODBUser = ""
                .ODBPassword = ""
                .ODBToken = ""
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
            txtOPath.Enabled = True
            txtOPassword.Enabled = True
            txtOUser.Enabled = True
        Else
            txtOPath.Enabled = False
            txtOPassword.Enabled = False
            txtOUser.Enabled = False
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

    Private Sub bgworker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgworker.ProgressChanged
        lblLoad.Text = e.UserState
        tsProBar.Value = e.ProgressPercentage
    End Sub

    Private Sub bgworkerOnline_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgworkerOnline.ProgressChanged
        lblBGLoad.Text = e.UserState
        tsBGProBar.Value = e.ProgressPercentage
    End Sub

    Private Sub PicStop_Click(sender As Object, e As EventArgs) Handles PicBGOStop.Click, PicBGStop.Click
        If sender Is PicBGStop Then
            If PicBGStop.Tag = "Stop" Then bgworker.CancelAsync()
            lblLoad.Text = "Stoped"
        Else
            If PicBGOStop.Tag = "Stop" Then bgworkerOnline.CancelAsync()
            lblBGLoad.Text = "Stoped"
        End If
        If sender.Tag = "Stop" Then
            sender.Image = My.Resources.Play24
            sender.tag = "Play"
        Else
            sender.Image = My.Resources.Stop24
            sender.tag = "Stop"
        End If
    End Sub
    Private Sub BtnOpenAdvDB_Click(sender As Object, e As EventArgs) Handles BtnOpenAdvDB.Click
        FrmAdvDB.Show()
    End Sub

    Private Sub NotifyIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon.BalloonTipClicked, NotifyIcon.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class

'updating Online DB to Local DB ------------------------------------------------------------------------
'ServicePointManager.Expect100Continue = True
'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

'Dim client As New WebClient

'client.Headers.Add("user-agent", My.Settings.UserAgent)
''client.Headers.Add("user-agent",
''              "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36 Edg/96.0.1054.29")
'' with proxy server only:
'Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
'proxy.Credentials = CredentialCache.DefaultNetworkCredentials
'client.Proxy = proxy

'Dim baseurl1 As String = My.Settings.ODBServer &
'                    "?username=" & Simple.Decode(My.Settings.ODBUser) &
'                    "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.ODBPassword) +
'                    Format(Date.Today, "yyyy-MM-dd")) &
'                    "&action=reader"
'Dim data1 As Stream
'data1 = client.OpenRead(baseurl1)
'Dim reader1 As New StreamReader(data1)
'Dim strMyJson As String = reader1.ReadToEnd()
'data1.Close()
'reader1.Close()
'If strMyJson = "UserName and Password is incorrect" Or strMyJson = "Please Enter an Action" Or strMyJson = "Please Enter the Command" Or
'strMyJson = "Please Enter UserName and Password" Then
'    e.Result = New String() {"OnlineDBError", strMyJson}
'    Exit Try
'End If
'Dim CurrentIndex As Integer, RowsCount As Integer   'For updating the value of the progress bar
'Dim CMDBGOnline As New OleDbCommand
'If strMyJson <> "[]" Then
'    Dim tbFinalObject As DataTable = JsonConvert.DeserializeObject(Of DataTable)(strMyJson)
'    RowsCount = tbFinalObject.Rows.Count    'For updating the value of the progress bar
'    For Each row As DataRow In tbFinalObject.Rows
'        If bgworkerOnline.CancellationPending = True Then Exit Try
'        If row("Command").ToString.StartsWith("Insert Into") Then
'            CMDUPDATE(row("Command").ToString)
'        Else
'            CMDBGOnline = New OleDbCommand(row("Command").ToString, CNNBG)
'            CMDBGOnline.ExecuteNonQuery()
'        End If
'        CMDBGOnline.Cancel()

'        Dim baseurl As String = My.Settings.ODBServer &
'                    "?username=" & Simple.Decode(My.Settings.ODBUser) &
'                    "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.ODBPassword) +
'                    Format(Date.Today, "yyyy-MM-dd")) &
'                    "&action=updater" &
'                    "&Command=Update LocalDB set Status='Done' Where ID=" & row("ID").ToString
'        ' with proxy server only:
'        Dim data As Stream
'        data = client.OpenRead(baseurl)
'        Dim reader As New StreamReader(data)
'        Dim result As String = reader.ReadToEnd()
'        data.Close()
'        reader.Close()

'        If result <> "1" Then
'            e.Result = New String() {"OnlineDBError", result}
'            Exit Try
'        End If

'        'Update the value of progress bar
'        CurrentIndex += 1
'        bgworkerOnline.ReportProgress(20 + Int((CurrentIndex / RowsCount) * 30),
'                                      $"Applying Commands from Online Database to Local DB ({CurrentIndex}/{RowsCount})...")
'    Next
'End If

'Update Local DB to Online DB--------------------------------------------------------------------------------
'Dim strCommand As String = DROnlineDB("Command").ToString
'strCommand = strCommand.Replace("#", "'")
'strCommand = strCommand.Replace("\", "\\")
'strCommand = HttpUtility.UrlEncode(strCommand)

''// Add a user agent header in case the requested URI contains a query.
'Dim baseurl As String = My.Settings.OnlineDBCNN &
'                "?username=" & Simple.Decode(My.Settings.OnlineDBUser) &
'                "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
'                Format(Date.Today, "yyyy-MM-dd")) &
'                "&action=updater" &
'                "&Command=" & strCommand
'' with proxy server only:
'Dim data As Stream
'data = client.OpenRead(baseurl)
'Dim reader As New StreamReader(data)
'Dim result As String = reader.ReadToEnd()
'data.Close()
'reader.Close()

'Dim MySQLCNN As New MySqlConnection("server=72.9.159.36;user id=lasertec_maleeshaachintha;" &
'                    "password=Achintha25581;database=lasertec_DLUDB;")
'MySQLCNN.Open()


'Dim wClient As New WebClient
'Dim result As String = wClient.DownloadString(My.Settings.OnlineDBCNN &
'                                                          "?username=" & Simple.Decode(My.Settings.OnlineDBUser) &
'                                                          "&password=" & GetMD5Encoder(Simple.Decode(My.Settings.OnlineDBPass) +
'                                                          Format(Date.Today, "yyyy-MM-dd")) &
'                                                          "&action=updater" &
'                                                          "&Command=" & Command())
