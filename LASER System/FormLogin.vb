Public Class FormLogin
    Private Db As New Database
    Private frmMoveX, frmMoveY As Integer
    Private newpoint As New Point

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High
        Dim ConnectionResult = Db.CheckConnection()
        If ConnectionResult.Valid = False Then
            MsgBox($"Database එක Connect කර ගැනීමට අපොහොසත් විය. කරුණාකර Database Credentials නිවැරැදි දැයි පරික්ෂා කරන්න. {vbCrLf} Issue: {ConnectionResult.Message}", vbCritical, "Database Connection Error")
            ' Show the setting form
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpDatabase)
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpGeneral)
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpUserAccount)
            FrmSettings.tcSettings.TabPages.Remove(FrmSettings.tpPrinter)
            FrmSettings.tcSettings.TabPages.Add(FrmSettings.tpDatabase)
            FrmSettings.Tag = "Login"
            FrmSettings.Show()
            Close()
            Exit Sub
            Exit Sub
        End If
        ControlLogin.Init(Db)
        ' Developer Mode
        If My.Settings.DeveloperMode = True Then
            ControlLogin.txtPassword.Text = "admin"
        End If
    End Sub

    Private Sub FormLogin_Leave(sender As Object, e As EventArgs) Handles Me.Leave, cmdClose.Click
        End
    End Sub

    Private Sub FormLogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Width = 350
        Height = 350
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

    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lblVersion.MouseDown
        frmMoveX = Control.MousePosition.X - Location.X
        frmMoveY = Control.MousePosition.Y - Location.Y
    End Sub

    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, lblVersion.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= frmMoveX
            newpoint.Y -= frmMoveY
            Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub ControlLogin_LoginEvent(Success As Boolean, SuccessUser As Dictionary(Of String, Object)) Handles ControlLogin.LoginEvent
        If Success Then
            Db.DirectExecute("Update `User` set LogInCount='0' Where LoginCount IS NULL")
            Db.DirectExecute("Update `User` set LogInCount= (LogInCount + 1) Where UNo = " & SuccessUser("UNo"))
            Db.DirectExecute("Update `User` set LastLogin=NOW() Where UNo = " & SuccessUser("UNo").ToString)
            User.Instance.UserNo = Int(SuccessUser("UNo"))
            User.Instance.UserName = SuccessUser("UserName").ToString
            User.Instance.UserType = SuccessUser("Type").ToString
            User.Instance.Email = SuccessUser("Email").ToString
            Select Case Tag
                Case "MainMenu"
                    With FormMain
                        .Tag = SuccessUser("UNo").ToString
                        .tslblUserName.Text = SuccessUser("UserName").ToString
                        .tslblUserType.Text = SuccessUser("Type").ToString
                    End With
                Case Else
                    FrmSplash.Show()
                    With FormMain
                        .Tag = SuccessUser("UNo").ToString
                        .tslblUserName.Text = SuccessUser("UserName").ToString
                        .tslblUserType.Text = SuccessUser("Type").ToString
                    End With
            End Select
            My.Settings.CountwrongLogins = 0
            Tag = ""
            Close()
        Else
            MsgBox("Incorrect User Name or Password!" & vbCrLf & vbCrLf & "You can try another " & Str(4 - (My.Settings.CountwrongLogins Mod 5)) & " chance.", vbCritical + vbOKOnly, "Incorrect User Name Or Password!")
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
End Class