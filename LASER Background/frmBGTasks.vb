Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports MaterialSkin
Imports Microsoft.VisualBasic.FileIO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmBGTasks
    Private CNNBG As OleDbConnection
    Private CMDBG1, CMDBG2 As New OleDbCommand
    Private DRBG1, DRBG2 As OleDbDataReader
    Private Database As New Database()
    Private Encoder As New Encoder()

    Public Sub New()
        Me.Hide()
        InitializeComponent()

        Dim process As New Process()
        Dim ApplicationPath As String = Path.Combine(Application.StartupPath, Application.ProductName + ".exe")
        Dim fileName As String = Path.GetFileName(ApplicationPath)
        Dim processName As Process() = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf("."c)))
        If processName.Length > 1 Then
            End
        End If

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        With My.Settings
            txtDBLocation.Text = .DatabasePath
            cmbDbProvider.Text = .DatabaseProvider
            txtDBLocation.Tag = .DatabasePath
            txtMApiKey.Text = .APIKey
            txtMApiToken.Text = .APIToken
            cmbMBgSMS.Text = .BGSendSMS
            chkMSendEmail.Checked = .SendEmail
            txtMAdminEmail.Text = .SystemEmail
            TextHost.Text = .MailServer
            TextPort.Text = .MailServerPort

            txtBackUpDB1.Text = .BackUpDB1
            txtBackUpDB2.Text = .BackUpDB2
            txtBackUpDB3.Text = .BackUpDB3

            chkOnlineDB.Checked = .ODBActive
            If .ODBActive Then
                txtOPath.Text = .OnlineDatabasePath
                txtOUser.Text = My.Settings.OnlineDatabaseUser
            Else
                txtOPath.Text = ""
                txtOUser.Text = ""
            End If
            chkOnlineDB_CheckedChanged(Nothing, Nothing)
        End With
        Dim FilePath As String = Path.Combine(SpecialDirectories.MyDocuments, "LASER System Data")
        If Not Directory.Exists(FilePath) Then
            My.Computer.FileSystem.CreateDirectory(FilePath)
        End If
        FilePath = Path.Combine(FilePath, "LASER Background")
        If Not Directory.Exists(FilePath) Then My.Computer.FileSystem.CreateDirectory(FilePath)
        Dim ActivityFilePath As String = Path.Combine(FilePath, "Activity.json")
        If Not File.Exists(ActivityFilePath) Then
            Dim d As FileStream
            d = File.Create(ActivityFilePath)
            d.Close()
        End If
        'Load the activity file
        Dim JSONStr As String = File.ReadAllText(ActivityFilePath)
        If String.IsNullOrEmpty(JSONStr) Then
            GridActivity.Columns.Add("Date", "Date")
            GridActivity.Columns.Item("Date").DataPropertyName = "Date"
            GridActivity.Columns.Add("Command", "Command")
            GridActivity.Columns.Item("Command").DataPropertyName = "Command"
        Else
            Dim DT As DataTable = JsonConvert.DeserializeObject(Of DataTable)(JSONStr)
            GridActivity.DataSource = DT
        End If

        Dim ShutDownFilePath As String = Path.Combine(FilePath, "ShutDown.txt")
        If File.Exists(ShutDownFilePath) Then
            File.Delete(ShutDownFilePath)
        End If
    End Sub
    Private Sub FrmBGTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.BelowNormal
        CheckForIllegalCrossThreadCalls = False

        Dim Validator = Database.CheckConnection()
        If Validator.Valid = False Then
            CreateMessagePanel("Database Problem",
                               "Message: " + "Database couldn't be found. Please check again and apply." + vbCrLf +
                               "Please inform this error to developer for fixing", "DBError")
            tmrRefresh.Stop()
            Exit Sub
        End If
        tmrRefresh.Start()
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
        If File.Exists(SpecialDirectories.MyDocuments + "\LASER System\LASER Background\ShutDown.txt") Then
            File.Delete(SpecialDirectories.MyDocuments + "\LASER System\LASER Background\ShutDown.txt")
            Me.Close()
        End If

        For Each controlObject As Control In flpMessage.Controls
            If controlObject.Tag = "DBError" Then
                tmrRefresh.Stop()
                Exit Sub
            End If
        Next
        If bgworker.IsBusy = False And PicBGStop.Tag = "Stop" Then bgworker.RunWorkerAsync()
        If My.Settings.ODBActive And bgworkerOnline.IsBusy = False And
            PicBGOStop.Tag = "Stop" Then bgworkerOnline.RunWorkerAsync()
    End Sub

    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworker.DoWork
        Dim Processes As New List(Of IProcess) From {
           New SendEmailProcess(Database, bgworker)
        }
        Dim Process As IProcess = Nothing
        Try
            If CheckForInternetConnection() = False Then
                Exit Sub
            End If

            Database.Connect()
            For Each Process In Processes
                If ErrorExist(Process.ToString) Then
                    Continue For
                End If

                bgworker.ReportProgress((Processes.IndexOf(Process) / Processes.Count) * 100, $"Initialized {Process}")
                Dim SendEmailProcess As New SendEmailProcess(Database, bgworker)
                SendEmailProcess.Perform()
                bgworker.ReportProgress((Processes.IndexOf(Process) + 1 / Processes.Count) * 100, $"Completed {Process}")
            Next
        Catch Ex As Exception
            e.Result = New String() {Process.ToString, Ex.Message}
            Exit Sub
        Finally
            Database.Disconnect()
        End Try
        'If My.Settings.BGSendSMS <> "OFF" Then
        '    bgworker.ReportProgress(60, "Reloading Balance Amount of the SMS Service...")
        '    Try
        '        Dim request As WebRequest = HttpWebRequest.Create($"http://app.newsletters.lk/smsAPI?balance&apikey={My.Settings.APIKey}&apitoken={My.Settings.APIToken}")
        '        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        '        Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
        '        Dim readStream As New StreamReader(s)
        '        Dim dataString As String = readStream.ReadToEnd()
        '        Dim json As JObject = JObject.Parse(dataString)
        '        lblBalance.Text = "Balance : Rs. " + json.SelectToken("balance").ToString
        '    Catch ex As Exception
        '        lblBalance.Text = "Balance : Rs. ###"
        '        Exit Sub
        '    End Try
        'End If
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
                'Case "AdminPermissionError"
                '    CreateMessagePanel("Admin Confirmed කර Data Apply කිරීම බිඳවැටී ඇත.",
                '    "Admin වෙත තහවුරු කිරීම සඳහා යවන ලද Data Database එකට Apply කිරිමේ පද්ධතිය බිඳවැටී ඇත." +
                '    vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "AdminPermissionError")
                '    Exit Sub
                'Case "MessageSendtoCustomerforRepairedItemsError"
                '    CreateMessagePanel("සෑදු අයිතම සඳහා ස්වයංක්‍රීයව යැවෙන Message පණිවිඩය ක්‍රියාවිරහිත වී ඇත.",
                '    "Status එක 'Repaired Not Delivered' හෝ 'Returned Not Delivered' යන Repair වල Customer සඳහා ස්වයංක්‍රීයව යැවෙන SMS පණිවිඩය ක්‍රියාවිරහිත වී ඇත." +
                '    vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "MessageSendtoCustomerforRepairedItemsError")
                    'Exit Sub
                Case ErrorClass.SendEmail
                    CreateMessagePanel("ස්වයංක්‍රීයව යැවෙන Emails ක්‍රියාවිරහිත වී ඇත.",
                    "ස්වයංක්‍රීයව Emails යැවෙන පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
                    vbCrLf + vbCrLf + "Message: " + e.Result(1) + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendEmailsError")
                    Exit Sub
            End Select
        End If
        lblLoad.Text = "Restarting..."
        tsProBar.Value = 100
    End Sub

    Private Function SendSMS(str As String) As JObject
        Dim url As String
        Dim host As String
        Dim apikey As String
        Dim apitoken As String
        Dim originator As String

        host = "https://app.newsletters.lk"
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

        response.Close()
        s.Close()
        readStream.Close()

        Return JObject.Parse(dataString)
    End Function

    Private Sub bgworkerOnline_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworkerOnline.DoWork
        'bgworkerOnline.ReportProgress(0, "Loading...")
        'Dim CMDODB As New OleDbCommand
        'Dim DRODB As OleDbDataReader = Nothing
        'Dim RowsCount, CurrentIndex As Integer
        'Dim OConfig As String = $"user={HashPassword(My.Settings.OnlineDatabaseUser, Simple.Decode(My.Settings.ODBToken))}&password={HashPassword(Simple.Decode(My.Settings.OnlineDatabasePassword) + Format(Now(), "yyyy-MM-dd"), Simple.Decode(My.Settings.ODBToken))}"
        ''Check Internet Connection
        'If CheckForInternetConnection() = False Then Exit Sub

        ''Get the IP Address
        'lblIPAddress.Text = GetIpAddress()

        'If Not My.Settings.ODBActive Then Exit Sub

        'bgworkerOnline.ReportProgress(0, "Updating Local Database...")
        'Try
        '    For Each controlObject As Control In flpMessage.Controls
        '        If controlObject.Tag = "ODBDownloadError" Then
        '            Exit Try
        '        End If
        '    Next

        '    Dim JSONResponse As String = GetResponse(My.Settings.OnlineDatabasePath + "/view", $"{OConfig}&sql=SELECT * FROM `LocalDB` WHERE `Status`='Waiting' ORDER BY `Date`")
        '    If JSONResponse.StartsWith("Error:") Then
        '        e.Result = New String() {"ODBDownloadError", JSONResponse}
        '        Exit Try
        '    End If

        '    Dim DicResult As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(JSONResponse)
        '    If DicResult.Item("status") = True Then
        '        Dim BGDT As DataTable = JsonConvert.DeserializeObject(Of DataTable)(DicResult.Item("result").ToString)
        '        RowsCount = BGDT.Rows.Count
        '        CurrentIndex = 0
        '        For Each DataRow As DataRow In BGDT.Rows
        '            'Check whether user needs to cancel the operation
        '            If bgworkerOnline.CancellationPending Then e.Cancel = True : Exit Try
        '            'Applying the changes online users has made to the local db
        '            Dim Command As String = DataRow("Command").ToString.Trim
        '            If Command.StartsWith("Insert Into", True, Nothing) Then
        '                CMDUPDATE(Command)
        '            Else
        '                Dim CMDBGOnline As New OleDbCommand(Command, CNNBG)
        '                CMDBGOnline.ExecuteNonQuery()
        '                CMDBGOnline.Dispose()
        '            End If
        '            'Mark online db that the changes has done
        '            JSONResponse = GetResponse(My.Settings.OnlineDatabasePath + "/update",
        '                                   $"{OConfig}&sql=UPDATE `LocalDB` Set `Status`='Done' WHERE ID={DataRow("ID").ToString}")

        '            If JSONResponse.Trim = "" Then
        '                e.Result = New String() {"ODBUploadError", "Response is empty."}
        '                Exit Try
        '            End If
        '            If JSONResponse.StartsWith("Error:") Then
        '                e.Result = New String() {"ODBDownloadError", JSONResponse}
        '                Exit Try
        '            End If
        '            DicResult = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(JSONResponse)
        '            If DicResult.Item("status") = False Then
        '                Dim ErrorMsg As String = ""
        '                For Each KeyPair As KeyValuePair(Of String, Object) In DicResult
        '                    ErrorMsg += KeyPair.Key + ": " + KeyPair.Value.ToString + vbNewLine
        '                Next
        '                e.Result = New String() {"ODBDownloadError", ErrorMsg}
        '                Exit Try
        '            End If
        '            'For updating UI
        '            CurrentIndex += 1
        '            bgworkerOnline.ReportProgress(Int((CurrentIndex / RowsCount) * 100),
        '                                      $"Updating Local Database ({CurrentIndex}/{RowsCount})...")
        '        Next
        '    Else
        '        Dim ErrorMsg As String = ""
        '        For Each KeyPair As KeyValuePair(Of String, Object) In DicResult
        '            ErrorMsg += KeyPair.Key + ": " + KeyPair.Value.ToString + vbNewLine
        '        Next
        '        e.Result = New String() {"ODBDownloadError", ErrorMsg}
        '    End If
        'Catch ex As Exception
        '    e.Result = New String() {"ODBDownloadError", ex.Message}
        '    Exit Try
        'End Try

        'bgworkerOnline.ReportProgress(0, "Updating Online Database...")
        'Try
        '    CMDODB = New OleDbCommand("Select * from OnlineDB order by ID", CNNBG)
        '    'For get the count of rows 
        '    Dim CMDODB1 As New OleDbCommand("Select Count(*) From OnlineDB", CNNBG)
        '    RowsCount = CMDODB1.ExecuteScalar      'For updating the value of progressbar
        '    CMDODB1.Cancel()
        '    CurrentIndex = 0
        '    DRODB = CMDODB.ExecuteReader()
        '    While DRODB.Read
        '        'Check whether user needs to cancel the operation
        '        If bgworkerOnline.CancellationPending = True Then e.Cancel = True : Exit Try
        '        If DRODB("Error").ToString <> "" Then Continue While

        '        Dim Command As String = DRODB("Command").ToString
        '        'Replace the # to ' symbol without in double or single quotes
        '        Dim bool As Boolean = False
        '        For i = 0 To Command.Length - 1
        '            Dim c As Char = Command(i)
        '            If c = """" Or c = "'" Then
        '                bool = Not bool
        '                Continue For
        '            End If
        '            If c = "#" And bool = False Then
        '                Command = Command.Substring(0, i) + "'" + Command.Substring(i + 1, Command.Length - i - 1)
        '            End If
        '        Next
        '        Command = HttpUtility.UrlEncode(Command)

        '        Dim OJSONResponse As String = GetResponse(My.Settings.OnlineDatabasePath + "/update",
        '                                   $"{OConfig}&sql={Command}")
        '        If String.IsNullOrEmpty(OJSONResponse) Then
        '            e.Result = New String() {"ODBUploadError", "Response is empty."}
        '            Exit Try
        '        End If
        '        If OJSONResponse.StartsWith("Error:") Then
        '            e.Result = New String() {"ODBUploadError", OJSONResponse}
        '            Exit Try
        '        End If
        '        Dim ODicResult As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(OJSONResponse)
        '        If ODicResult.Item("status") = True Then
        '            Dim CMDOnlineDB1 As New OleDbCommand("Delete from OnlineDB Where ID=" & DRODB("ID").ToString, CNNBG)
        '            CMDOnlineDB1.ExecuteNonQuery()
        '            CMDOnlineDB1.Cancel()
        '        Else
        '            Dim ErrorMsg As String = ""
        '            For Each KeyPair As KeyValuePair(Of String, Object) In ODicResult
        '                ErrorMsg += KeyPair.Key + ": " + KeyPair.Value.ToString + vbNewLine
        '            Next
        '            e.Result = New String() {"ODBUploadError", ErrorMsg}
        '            Dim CMDBGOnline As New OleDbCommand($"UPDATE OnlineDB SET Error=""{ErrorMsg.Replace("""", """""")}"" WHERE ID={DRODB("ID")};", CNNBG)
        '            CMDBGOnline.ExecuteNonQuery()
        '            CMDBGOnline.Cancel()
        '            Continue While
        '        End If
        '        'Update the value of progress bar
        '        CurrentIndex += 1
        '        bgworkerOnline.ReportProgress(Int((CurrentIndex / RowsCount) * 100),
        '                             $"Updating Online Database ({CurrentIndex}/{RowsCount})...")
        '    End While
        'Catch ex As Exception
        '    e.Result = New String() {"ODBUploadError", ex.Message}
        '    Exit Sub
        'End Try
        'If Not IsNothing(DRODB) AndAlso DRODB.IsClosed = False Then
        '    DRODB.Close()
        '    CMDODB.Cancel()
        'End If
        'bgworkerOnline.ReportProgress(100, "Completed")
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

    Public Function GetResponse(Path As String, postdata As String) As String
        Try
            Dim s As HttpWebRequest
            Dim enc As UTF8Encoding
            Dim postdatabytes As Byte()
            s = WebRequest.Create(Path)
            enc = New UTF8Encoding()

            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"
            s.ContentType = "application/x-www-form-urlencoded"
            s.ContentLength = postdatabytes.Length

            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim result = s.GetResponse()
            Dim reader As New StreamReader(result.GetResponseStream)
            Dim str As String = reader.ReadToEnd
            Return str
        Catch ex As Exception
            Return "Error: " + ex.Message
        End Try
    End Function

    Public Sub CreateMessagePanel(Title As String, Message As String, Optional ByVal Tag As String = "")
        Dim MessagePanel As New MessageBox With {
              .Title = Title,
              .Message = Message,
              .Tag = Tag
          }
        flpMessage.Controls.Add(MessagePanel)

        NotifyIcon.ShowBalloonTip(2000, Title, Message, ToolTipIcon.Info)
    End Sub

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
            .DatabasePath = txtDBLocation.Text
            .APIKey = txtMApiKey.Text
            .APIToken = txtMApiToken.Text
            .BGSendSMS = cmbMBgSMS.Text
            .SendEmail = chkMSendEmail.CheckState
            .SystemEmail = txtMAdminEmail.Text
            .SystemEmailPassword = Encoder.Encode(txtMAdminPass.Text)
            .BackUpDB1 = txtBackUpDB1.Text
            .BackUpDB2 = txtBackUpDB2.Text
            .BackUpDB3 = txtBackUpDB3.Text
            If txtDbPassword.Text <> "" Then .DatabasePassword = Encoder.Encode(txtDbPassword.Text)
            .DatabaseProvider = cmbDbProvider.Text
            .ODBActive = chkOnlineDB.Checked
            If chkOnlineDB.CheckState Then
                .OnlineDatabasePath = txtOPath.Text
                .OnlineDatabaseUser = txtOUser.Text
                If txtOPassword.Text <> "" Then .OnlineDatabasePassword = Encoder.Encode(txtOPassword.Text)
                If TxtOToken.Text <> "" Then .ODBToken = Encoder.Encode(TxtOToken.Text)
            Else
                .OnlineDatabasePath = ""
                .OnlineDatabaseUser = ""
                .OnlineDatabasePassword = ""
                .ODBToken = ""
            End If
            .Save()
        End With
        tmrRefresh.Start()
    End Sub

    Private Sub cmdDBLocation_Click(sender As Object, e As EventArgs) Handles cmdDBLocation.Click
        ofdDatabase.Title = "Please select the DataBase file"
        ofdDatabase.InitialDirectory = SpecialDirectories.MyDocuments
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
        Try
            Dim sPrefix As String = ""
            Dim rdm As New Random()
            For i As Integer = 1 To 5
                sPrefix &= ChrW(rdm.Next(65, 90))
            Next
            Dim EmailController As New EmailController(
                TextHost.Text,
                TextPort.Text,
                txtMAdminEmail.Text,
                txtMAdminPass.Text
            )
            EmailController.Send(
                txtMAdminEmail.Text,
                "LASER System එකෙහි Admin Email එකක් ඇතුලත් කරගැනීම සඳහා තහවුරු කිරීම.",
                "LASER System " + vbCrLf + vbCrLf +
                "කරුණාකර ඔබගේ Admin Email එක Verify කිරීම සඳහා පහත සඳහන් කේතය භාවිතා කරන්න. " + vbCrLf + vbCrLf +
                "Admin Email: " + txtMAdminEmail.Text + vbCrLf +
                "Security code: " + sPrefix
            )
            txtMAdminEmailVerify.Tag = sPrefix
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
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

    Private Function ErrorExist(ErrorName As String) As Boolean
        For Each ControlObject As Control In flpMessage.Controls
            If ControlObject.Tag = ErrorName Then
                Return True
            End If
        Next

        Select Case ErrorName
            Case ErrorClass.SendEmail
                Return Not My.Settings.SendEmail
        End Select

        Return False
    End Function
End Class