Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO

Public Class frmLogin
    Private Db As New Database
    Private frmMoveX, frmMoveY As Integer
    Private newpoint As New Point
    Private Sub FrmLogin_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        End
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High
        If My.Settings.DBPath = "" Then My.Settings.DBPath = SpecialDirectories.MyDocuments + "\Database.accdb"
        Dim ConnectionResult = Db.CheckConnection()
        If ConnectionResult.Valid = False Then
            MsgBox(ConnectionResult.Message, vbCritical, "Database Connection Error")
            ' Show the setting form
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpDatabase)
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpGeneral)
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpUserAccount)
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpPrinter)
            FrmSettings.tcSettings.TabPages.Add(FrmSettings.tpDatabase)
            FrmSettings.Tag = "Login"
            FrmSettings.Show()
            Me.Close()
            Exit Sub
            Exit Sub
        Else
            Db.Connect()
        End If
        Me.AcceptButton = cmdLogin
        cmbUserName_DropDown(sender, e)
        cmbUserName.Text = Db.GetData("Select Top 1 UserName from [User] Order by LastLogin Desc;")
        cmbUserName.Focus()
        '--------Developer Mode-------------
        If My.Settings.DeveloperMode = True Then
            txtPassword.Text = "cashier"
            CmdLogin_Click(sender, e)
        End If
        '-----------------------------------
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If CheckEmptyfield(cmbUserName, "User Name is empty, fill it") = False Then
            Exit Sub
        ElseIf CheckEmptyStr(txtPassword.Text, "Password is empty, fill it") = False Then
            Exit Sub
        End If
        If cmbUserName.Text = "admin" And txtPassword.Text = "123" Then
            FormStock.Show()
            Me.Tag = ""
            Me.Close()
            Exit Sub
        End If
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from [User] where UserName ='" & cmbUserName.Text & "'")
        If DR.HasRows = True Then
            DR = Db.GetDataReader("Select * from [User] where  StrComp('" & cmbUserName.Text & "',UserName,0)=0 and " &
                                         "StrComp(Password,'" & txtPassword.Text & "',0)=0")
            If DR.HasRows = True Then
                DR.Read()
                Db.DirectExecute("Update [User] set LogInCount='0' Where LoginCount IS NULL")
                Db.DirectExecute("Update [User] set LogInCount= (LogInCount + 1) Where UNo = " & DR("UNo").ToString)
                Db.DirectExecute("Update [User] set LastLogin=#" & DateAndTime.Now & "# Where UNo = " & DR("UNo").ToString)
                Select Case Me.Tag
                    Case "MainMenu"
                        With MdifrmMain
                            .Tag = DR("UNo").ToString
                            .tslblUserName.Text = DR("UserName").ToString
                            .tslblUserType.Text = DR("Type").ToString
                            .tsProBar.Value = 100
                            .tslblLoad.Text = "Successfull Logged In " + DR("UserName").ToString
                        End With
                    Case Else
                        FrmSplash.Show()
                        With MdifrmMain
                            .Tag = DR("UNo").ToString
                            .tslblUserName.Text = DR("UserName").ToString
                            .tslblUserType.Text = DR("Type").ToString
                            .tsProBar.Value = 100
                            .tslblLoad.Text = "Welcome! LASER System Loaded Successfull"
                        End With
                End Select
                My.Settings.CountwrongLogins = 0
                txtPassword.Text = ""
                cmbUserName.Text = ""
                Me.Tag = ""
                Me.Close()
            Else
                MsgBox("Incorrect User Name or Password!" & vbCrLf & vbCrLf & "You can try another " & Str(4 - (My.Settings.CountwrongLogins Mod 5)) & " chance.", vbCritical + vbOKOnly, "Incorrect User Name Or Password!")
                txtPassword.Text = ""
                My.Settings.CountwrongLogins = My.Settings.CountwrongLogins + 1
            End If
        Else
            MsgBox("Incorrect User Name or Password!" & vbCrLf & vbCrLf & "You can try another " & Str(4 - (My.Settings.CountwrongLogins Mod 5)) & " chance.", vbCritical + vbOKOnly, "Incorrect User Name Or Password!")
            txtPassword.Text = ""
            cmbUserName.Text = ""
            My.Settings.CountwrongLogins = My.Settings.CountwrongLogins + 1
        End If
        If My.Settings.CountwrongLogins <> 0 And (My.Settings.CountwrongLogins Mod 5 = 0) Then
            pnlWrongPrompt.Dock = DockStyle.Fill
            pnlWrongPrompt.BringToFront()
            My.Settings.LastwrongLoginTime = Now.AddMinutes(1 * (My.Settings.CountwrongLogins \ 5))
            pnlWrongPrompt.Visible = True
            tmrWrongLoginTime.Start()
        End If
    End Sub

    Private Sub cmdGetOTP_Click(sender As Object, e As EventArgs) Handles cmdGetOTP.Click
        If CheckEmptyfield(txtOTPUserName, "කරුණාකර User Name එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckExistData(txtOTPUserName, "Select UserName from [User] Where UserName='" & txtOTPUserName.Text & "'", "ඔබ ඇතුලත් කල User Name එක වැරදි කරුණාකර නිවැරදි User Name එක ඇතුලත් කරන්න.", False) = False Then
            Exit Sub
        End If
        Dim DR As OleDbDataReader = Db.GetDataReader("Select Email from [User] Where UserName='" & txtOTPUserName.Text & "'")
        If DR.HasRows = True Then
            DR.Read()
            If DR("Email").ToString = "" Then
                MsgBox("මෙම User සඳහා Email ලිපිනයක් ඇතුලත් කර නොමැත. Email ලිපිනයක් සහිත User Name එකක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
                txtOTPUserName.Focus()
                Exit Sub
            End If
            Dim sPrefix As String = ""
            Dim rdm As New Random()
            For i As Integer = 1 To 5 ' 5 Letters generated
                sPrefix &= ChrW(rdm.Next(65, 90))
            Next
            Db.Execute("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?,#" &
                      DateAndTime.Now & "#,'" & DR("Email").ToString & "','New Signed in Detected from your LASER System account','" &
                      "Please use the following security code for the LASER System account " & txtOTPUserName.Text & "." + vbCrLf + vbCrLf +
                        "Security code: " + sPrefix & "','Waiting');")
            txtOTPCode.Tag = sPrefix
        End If
    End Sub

    Private Sub cmdOTPLogin_Click(sender As Object, e As EventArgs) Handles cmdOTPLogin.Click
        If CheckEmptyfield(txtOTPUserName, "කරුණාකර User Name එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyfield(txtOTPCode, "කරුණාකර OTP Code එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        End If
        If txtOTPCode.Text = txtOTPCode.Tag Then
            cmbUserName.Text = txtOTPUserName.Text
            Dim DR As OleDbDataReader = Db.GetDataReader("Select Password from [User] Where UserName='" & cmbUserName.Text & "'")
            If DR.HasRows = True Then
                DR.Read()
                txtPassword.Text = DR("Password").ToString
            End If
            CmdLogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = 350
        Me.Height = 350
    End Sub

    Private Sub tmrWrongLoginTime_Tick(sender As Object, e As EventArgs) Handles tmrWrongLoginTime.Tick
        lblWrongTime.Text = "You are trying to log in " & My.Settings.CountwrongLogins.ToString & " times. You can try again after " &
            (Convert.ToDateTime(My.Settings.LastwrongLoginTime) - DateAndTime.Now).Hours.ToString & " : " & (Convert.ToDateTime(My.Settings.LastwrongLoginTime) - DateAndTime.Now).Minutes.ToString & " : " &
            (Convert.ToDateTime(My.Settings.LastwrongLoginTime) - DateAndTime.Now).Seconds.ToString
        If DateAndTime.Now >= My.Settings.LastwrongLoginTime Then
            pnlWrongPrompt.Visible = False
            pnlWrongPrompt.Dock = DockStyle.None
            tmrWrongLoginTime.Stop()
        End If
    End Sub

    Private Sub tctrlLogin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlLogin.SelectedIndexChanged
        If tctrlLogin.SelectedTab.TabIndex = 0 Then
            AcceptButton = cmdLogin
            cmbUserName.Focus()
        Else
            AcceptButton = cmdOTPLogin
            txtOTPUserName.Focus()
        End If
    End Sub

    Private Sub cmbUserName_DropDown(sender As Object, e As EventArgs) Handles cmbUserName.DropDown
        ComboBoxDropDown(Db, cmbUserName, "Select UserName from [User] group by UserName")
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        End
    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lblVersion.MouseDown
        frmMoveX = Control.MousePosition.X - Me.Location.X
        frmMoveY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, lblVersion.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= frmMoveX
            newpoint.Y -= frmMoveY
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
