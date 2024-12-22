Public Class FormLogin
    Private Db As New Database
    Private frmMoveX, frmMoveY As Integer
    Private newpoint As New Point

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.Close()
            Exit Sub
            Exit Sub
        End If
        ControlLogin.Init(Db)
        ' Developer Mode
        If My.Settings.DeveloperMode = True Then
            ControlLogin.txtPassword.Text = "admin"
        End If
    End Sub


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.pnlWrongPrompt = New System.Windows.Forms.Panel()
        Me.lblWrongTime = New System.Windows.Forms.Label()
        Me.tmrWrongLoginTime = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ControlLogin = New LASER_System.ControlLogin()
        Me.pnlWrongPrompt.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.ForeColor = System.Drawing.Color.LightGray
        Me.lblVersion.Location = New System.Drawing.Point(122, 9)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(82, 32)
        Me.lblVersion.TabIndex = 39
        Me.lblVersion.Text = "Login"
        '
        'pnlWrongPrompt
        '
        Me.pnlWrongPrompt.Controls.Add(Me.lblWrongTime)
        Me.pnlWrongPrompt.Location = New System.Drawing.Point(369, 67)
        Me.pnlWrongPrompt.Name = "pnlWrongPrompt"
        Me.pnlWrongPrompt.Size = New System.Drawing.Size(80, 67)
        Me.pnlWrongPrompt.TabIndex = 43
        Me.pnlWrongPrompt.Visible = False
        '
        'lblWrongTime
        '
        Me.lblWrongTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWrongTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWrongTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblWrongTime.ForeColor = System.Drawing.Color.Red
        Me.lblWrongTime.Location = New System.Drawing.Point(0, 0)
        Me.lblWrongTime.Name = "lblWrongTime"
        Me.lblWrongTime.Size = New System.Drawing.Size(80, 67)
        Me.lblWrongTime.TabIndex = 34
        Me.lblWrongTime.Text = "You are trying to log in 3 times. You can try again after 00:00:00"
        Me.lblWrongTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrWrongLoginTime
        '
        Me.tmrWrongLoginTime.Interval = 900
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Red
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdClose.Location = New System.Drawing.Point(313, 12)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 25)
        Me.cmdClose.TabIndex = 44
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'ControlLogin
        '
        Me.ControlLogin.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlLogin.Location = New System.Drawing.Point(24, 53)
        Me.ControlLogin.Name = "ControlLogin"
        Me.ControlLogin.Size = New System.Drawing.Size(301, 264)
        Me.ControlLogin.TabIndex = 45
        '
        'frmLogin
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(350, 350)
        Me.Controls.Add(Me.ControlLogin)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.pnlWrongPrompt)
        Me.Controls.Add(Me.lblVersion)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - User Login"
        Me.pnlWrongPrompt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub


    Private Sub FrmLogin_Leave(sender As Object, e As EventArgs) Handles Me.Leave, cmdClose.Click
        End
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

    Private Sub ControlLogin_LoginEvent(Success As Boolean, SuccessUser As Dictionary(Of String, Object)) Handles ControlLogin.LoginEvent
        If Success Then
            Db.DirectExecute("Update `User` set LogInCount='0' Where LoginCount IS NULL")
            Db.DirectExecute("Update `User` set LogInCount= (LogInCount + 1) Where UNo = " & SuccessUser("UNo"))
            Db.DirectExecute("Update `User` set LastLogin=NOW() Where UNo = " & SuccessUser("UNo").ToString)
            User.Instance.UserNo = Int(SuccessUser("UNo"))
            User.Instance.UserName = SuccessUser("UserName").ToString
            User.Instance.UserType = SuccessUser("Type").ToString
            User.Instance.Email = SuccessUser("Email").ToString
            Select Case Me.Tag
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
            Me.Tag = ""
            Me.Close()
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
