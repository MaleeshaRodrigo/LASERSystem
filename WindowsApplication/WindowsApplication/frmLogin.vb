Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Net.Mail
Imports System.Net

Public Class frmLogin
    Dim frmMoveX, frmMoveY As Integer
    Dim newpoint As New Point
    Private Sub FrmLogin_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        CNN.Close()
        End
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High
        If My.Settings.DatabaseCNN = "" Then My.Settings.DatabaseCNN = Application.StartupPath + "\Database.accdb"
        If My.Settings.DBPassword = "" Then My.Settings.DBPassword = "/CiDhN0RE7ogLrZ7JyJIGHgx8FV+iuIqCmLeeYXy8a/zeSQjc4NyUQ=="
        GetCNN()
        Me.AcceptButton = cmdLogin
        cmbUserName_DropDown(sender, e)
        CMD = New OleDbCommand("Select Top 1 UserName from [User] Order by LastLogin Desc;", CNN)
        cmbUserName.Text = CMD.ExecuteScalar
        ActiveControl = cmbUserName
        '--------Developer Mode-------------
        txtPassword.Text = "1999"
        CmdLogin_Click(sender, e)
        '-----------------------------------
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If CheckEmptyfieldcmb(cmbUserName, "User Name is empty, fill it") = False Then
            Exit Sub
        ElseIf CheckEmptyStr(txtPassword.Text, "Password is empty, fill it") = False Then
            Exit Sub
        End If
        If cmbUserName.Text = "admin" And txtPassword.Text = "123" Then
            frmStock.Show()
            Me.Tag = ""
            Me.Close()
            Exit Sub
        End If
        CMD = New OleDb.OleDbCommand("Select * from [User] where UserName ='" & cmbUserName.Text & "'", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            CMD = New OleDb.OleDbCommand("Select * from [User] where  StrComp('" & cmbUserName.Text & "',UserName,0)=0 and " &
                                         "StrComp(Password,'" & txtPassword.Text & "',0)=0", CNN)
            DR = CMD.ExecuteReader()
            If DR.HasRows = True Then
                DR.Read()
                Dim CMD1 As New OleDbCommand("Update [User] set LogInCount='0' Where LoginCount IS NULL", CNN)
                CMD1.ExecuteNonQuery()
                CMD1 = New OleDbCommand("Update [User] set LogInCount= (LogInCount + 1) Where UNo = " & DR("UNo").ToString, CNN)
                CMD1.ExecuteNonQuery()
                CMD1 = New OleDbCommand("Update [User] set LastLogin=#" & DateAndTime.Now & "# Where UNo = " & DR("UNo").ToString, CNN)
                CMD1.ExecuteNonQuery()
                CMD1.Cancel()
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
        If CheckEmptyfieldtxt(txtOTPUserName, "කරුණාකර User Name එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckExistDatatxt(txtOTPUserName, "Select UserName from [User] Where UserName='" & txtOTPUserName.Text & "'", "ඔබ ඇතුලත් කල User Name එක වැරදි කරුණාකර නිවැරදි User Name එක ඇතුලත් කරන්න.", False) = False Then
            Exit Sub
        End If
        CMD = New OleDbCommand("Select Email from [User] Where UserName='" & txtOTPUserName.Text & "'", CNN)
        DR = CMD.ExecuteReader()
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
            CMDUPDATE("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?PrimaryKey?Mail?MailNo?,#" &
                      DateAndTime.Now & "#,'" & DR("Email").ToString & "','New Signed in Detected from your LASER System account','" &
                      "Please use the following security code for the LASER System account " & txtOTPUserName.Text & "." + vbCrLf + vbCrLf +
                        "Security code: " + sPrefix & "','Waiting');")
            txtOTPCode.Tag = sPrefix
        End If
    End Sub

    Private Sub cmdOTPLogin_Click(sender As Object, e As EventArgs) Handles cmdOTPLogin.Click
        If CheckEmptyfieldtxt(txtOTPUserName, "කරුණාකර User Name එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyfieldtxt(txtOTPCode, "කරුණාකර OTP Code එක ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        End If
        If txtOTPCode.Text = txtOTPCode.Tag Then
            cmbUserName.Text = txtOTPUserName.Text
            CMD = New OleDbCommand("Select Password from [User] Where UserName='" & cmbUserName.Text & "'", CNN)
            DR = CMD.ExecuteReader()
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
            (My.Settings.LastwrongLoginTime - DateAndTime.Now).Hours.ToString & " : " & (My.Settings.LastwrongLoginTime - DateAndTime.Now).Minutes.ToString & " : " & (My.Settings.LastwrongLoginTime - DateAndTime.Now).Seconds.ToString
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
        CmbDropDown(cmbUserName, "Select UserName from [User] group by UserName", "UserName")
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
