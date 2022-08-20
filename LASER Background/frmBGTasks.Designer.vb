<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBGTasks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBGTasks))
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.bgworkerOnline = New System.ComponentModel.BackgroundWorker()
        Me.ofdDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDBLocation = New System.Windows.Forms.Button()
        Me.chkOnlineDB = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtOnlineDBUser = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtOnlineDBPass = New System.Windows.Forms.TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.chkMSendEmail = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMAdminEmail = New System.Windows.Forms.TextBox()
        Me.txtMAdminPass = New System.Windows.Forms.TextBox()
        Me.btnAdminEmailVerify = New System.Windows.Forms.Button()
        Me.txtMAdminEmailVerify = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMApiKey = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMApiToken = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMBgSMS = New System.Windows.Forms.ComboBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtActivity = New System.Windows.Forms.TextBox()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.tsProBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.lblBGLoad = New System.Windows.Forms.Label()
        Me.probarBGLoad = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOnlineDB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBackUpDB1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBackUpDB2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtBackUpDB3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtDBLocation = New System.Windows.Forms.TextBox()
        Me.cmdBackUpDB1 = New System.Windows.Forms.Button()
        Me.cmdBackUpDB2 = New System.Windows.Forms.Button()
        Me.cmdBackUpDB3 = New System.Windows.Forms.Button()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUserAgent = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbDbProvider = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtDbPassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpMessage = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 10000
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'bgworkerOnline
        '
        Me.bgworkerOnline.WorkerReportsProgress = True
        Me.bgworkerOnline.WorkerSupportsCancellation = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "LASER Background Worker"
        Me.NotifyIcon.Visible = True
        '
        'lblLoad
        '
        Me.lblLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLoad.Location = New System.Drawing.Point(9, 13)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(382, 28)
        Me.lblLoad.TabIndex = 1
        Me.lblLoad.Text = "Please Wait..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Database Location:"
        '
        'cmdDBLocation
        '
        Me.cmdDBLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDBLocation.Location = New System.Drawing.Point(438, 142)
        Me.cmdDBLocation.Name = "cmdDBLocation"
        Me.cmdDBLocation.Size = New System.Drawing.Size(26, 21)
        Me.cmdDBLocation.TabIndex = 25
        Me.cmdDBLocation.Text = "..."
        Me.cmdDBLocation.UseVisualStyleBackColor = True
        '
        'chkOnlineDB
        '
        Me.chkOnlineDB.AutoSize = True
        Me.chkOnlineDB.Location = New System.Drawing.Point(14, 195)
        Me.chkOnlineDB.Name = "chkOnlineDB"
        Me.chkOnlineDB.Size = New System.Drawing.Size(129, 17)
        Me.chkOnlineDB.TabIndex = 28
        Me.chkOnlineDB.Text = "Online Database Path"
        Me.chkOnlineDB.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 225)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "User Name:"
        '
        'txtOnlineDBUser
        '
        Me.txtOnlineDBUser.Location = New System.Drawing.Point(99, 221)
        Me.txtOnlineDBUser.Name = "txtOnlineDBUser"
        Me.txtOnlineDBUser.Size = New System.Drawing.Size(104, 21)
        Me.txtOnlineDBUser.TabIndex = 30
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(209, 225)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Password:"
        '
        'txtOnlineDBPass
        '
        Me.txtOnlineDBPass.Location = New System.Drawing.Point(271, 222)
        Me.txtOnlineDBPass.Name = "txtOnlineDBPass"
        Me.txtOnlineDBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOnlineDBPass.Size = New System.Drawing.Size(123, 21)
        Me.txtOnlineDBPass.TabIndex = 32
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMAdminEmailVerify)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAdminEmailVerify)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMAdminPass)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMAdminEmail)
        Me.Guna2GroupBox1.Controls.Add(Me.Label16)
        Me.Guna2GroupBox1.Controls.Add(Me.Label15)
        Me.Guna2GroupBox1.Controls.Add(Me.chkMSendEmail)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 415)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(382, 153)
        Me.Guna2GroupBox1.TabIndex = 35
        Me.Guna2GroupBox1.Text = "Emails"
        '
        'chkMSendEmail
        '
        Me.chkMSendEmail.BackColor = System.Drawing.Color.Transparent
        Me.chkMSendEmail.Location = New System.Drawing.Point(206, 3)
        Me.chkMSendEmail.Name = "chkMSendEmail"
        Me.chkMSendEmail.Size = New System.Drawing.Size(168, 34)
        Me.chkMSendEmail.TabIndex = 37
        Me.chkMSendEmail.Text = "Automatically send Emails"
        Me.chkMSendEmail.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(7, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 15)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Admin Email:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(7, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 15)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Email Password:"
        '
        'txtMAdminEmail
        '
        Me.txtMAdminEmail.Location = New System.Drawing.Point(91, 45)
        Me.txtMAdminEmail.Name = "txtMAdminEmail"
        Me.txtMAdminEmail.Size = New System.Drawing.Size(285, 23)
        Me.txtMAdminEmail.TabIndex = 40
        '
        'txtMAdminPass
        '
        Me.txtMAdminPass.Location = New System.Drawing.Point(105, 74)
        Me.txtMAdminPass.Name = "txtMAdminPass"
        Me.txtMAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMAdminPass.Size = New System.Drawing.Size(271, 23)
        Me.txtMAdminPass.TabIndex = 41
        '
        'btnAdminEmailVerify
        '
        Me.btnAdminEmailVerify.Location = New System.Drawing.Point(221, 115)
        Me.btnAdminEmailVerify.Name = "btnAdminEmailVerify"
        Me.btnAdminEmailVerify.Size = New System.Drawing.Size(155, 27)
        Me.btnAdminEmailVerify.TabIndex = 42
        Me.btnAdminEmailVerify.Text = "Get Verification Code"
        Me.btnAdminEmailVerify.UseVisualStyleBackColor = True
        '
        'txtMAdminEmailVerify
        '
        Me.txtMAdminEmailVerify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMAdminEmailVerify.DefaultText = ""
        Me.txtMAdminEmailVerify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMAdminEmailVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMAdminEmailVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMAdminEmailVerify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMAdminEmailVerify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMAdminEmailVerify.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMAdminEmailVerify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMAdminEmailVerify.Location = New System.Drawing.Point(113, 115)
        Me.txtMAdminEmailVerify.Name = "txtMAdminEmailVerify"
        Me.txtMAdminEmailVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMAdminEmailVerify.PlaceholderText = ""
        Me.txtMAdminEmailVerify.SelectedText = ""
        Me.txtMAdminEmailVerify.Size = New System.Drawing.Size(102, 27)
        Me.txtMAdminEmailVerify.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(7, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Verification Code:"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 10
        Me.Guna2GroupBox2.Controls.Add(Me.lblBalance)
        Me.Guna2GroupBox2.Controls.Add(Me.cmbMBgSMS)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.txtMApiToken)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.txtMApiKey)
        Me.Guna2GroupBox2.Controls.Add(Me.Label6)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(8, 574)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(384, 164)
        Me.Guna2GroupBox2.TabIndex = 36
        Me.Guna2GroupBox2.Text = "SMS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Api Key:"
        '
        'txtMApiKey
        '
        Me.txtMApiKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMApiKey.Location = New System.Drawing.Point(65, 44)
        Me.txtMApiKey.Name = "txtMApiKey"
        Me.txtMApiKey.Size = New System.Drawing.Size(313, 23)
        Me.txtMApiKey.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(9, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Api Token:"
        '
        'txtMApiToken
        '
        Me.txtMApiToken.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMApiToken.Location = New System.Drawing.Point(77, 71)
        Me.txtMApiToken.Name = "txtMApiToken"
        Me.txtMApiToken.Size = New System.Drawing.Size(301, 23)
        Me.txtMApiToken.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Background send SMS:"
        '
        'cmbMBgSMS
        '
        Me.cmbMBgSMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMBgSMS.FormattingEnabled = True
        Me.cmbMBgSMS.Items.AddRange(New Object() {"OFF", "Only Getting Notification", "Automatically Send SMS"})
        Me.cmbMBgSMS.Location = New System.Drawing.Point(143, 98)
        Me.cmbMBgSMS.Name = "cmbMBgSMS"
        Me.cmbMBgSMS.Size = New System.Drawing.Size(235, 23)
        Me.cmbMBgSMS.TabIndex = 30
        '
        'lblBalance
        '
        Me.lblBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBalance.BackColor = System.Drawing.Color.Lime
        Me.lblBalance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(7, 124)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(371, 33)
        Me.lblBalance.TabIndex = 59
        Me.lblBalance.Text = "Balance: Rs. ###"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtActivity
        '
        Me.txtActivity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtActivity.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtActivity.Location = New System.Drawing.Point(10, 778)
        Me.txtActivity.Multiline = True
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.ReadOnly = True
        Me.txtActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtActivity.Size = New System.Drawing.Size(536, 113)
        Me.txtActivity.TabIndex = 37
        '
        'cmdApply
        '
        Me.cmdApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdApply.Location = New System.Drawing.Point(8, 744)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(538, 28)
        Me.cmdApply.TabIndex = 38
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'tsProBar
        '
        Me.tsProBar.BackColor = System.Drawing.Color.Transparent
        Me.tsProBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.tsProBar.Location = New System.Drawing.Point(0, 0)
        Me.tsProBar.Name = "tsProBar"
        Me.tsProBar.Size = New System.Drawing.Size(549, 8)
        Me.tsProBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.tsProBar.TabIndex = 39
        Me.tsProBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'lblBGLoad
        '
        Me.lblBGLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBGLoad.Location = New System.Drawing.Point(9, 58)
        Me.lblBGLoad.Name = "lblBGLoad"
        Me.lblBGLoad.Size = New System.Drawing.Size(382, 28)
        Me.lblBGLoad.TabIndex = 40
        Me.lblBGLoad.Text = "Please Wait..."
        '
        'probarBGLoad
        '
        Me.probarBGLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.probarBGLoad.Location = New System.Drawing.Point(0, 44)
        Me.probarBGLoad.Name = "probarBGLoad"
        Me.probarBGLoad.Size = New System.Drawing.Size(546, 10)
        Me.probarBGLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.probarBGLoad.TabIndex = 41
        Me.probarBGLoad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Path of Back Up Database:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Path of Back Up Database(2) (Hidden):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Path of Back Up Database(3) (Hidden):"
        '
        'txtOnlineDB
        '
        Me.txtOnlineDB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOnlineDB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOnlineDB.DefaultText = ""
        Me.txtOnlineDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOnlineDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOnlineDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOnlineDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOnlineDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOnlineDB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOnlineDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOnlineDB.Location = New System.Drawing.Point(147, 192)
        Me.txtOnlineDB.Name = "txtOnlineDB"
        Me.txtOnlineDB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOnlineDB.PlaceholderText = ""
        Me.txtOnlineDB.SelectedText = ""
        Me.txtOnlineDB.Size = New System.Drawing.Size(317, 24)
        Me.txtOnlineDB.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(301, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 24)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBackUpDB1
        '
        Me.txtBackUpDB1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackUpDB1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackUpDB1.DefaultText = ""
        Me.txtBackUpDB1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBackUpDB1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBackUpDB1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBackUpDB1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBackUpDB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBackUpDB1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBackUpDB1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBackUpDB1.Location = New System.Drawing.Point(143, 275)
        Me.txtBackUpDB1.Name = "txtBackUpDB1"
        Me.txtBackUpDB1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackUpDB1.PlaceholderText = ""
        Me.txtBackUpDB1.SelectedText = ""
        Me.txtBackUpDB1.Size = New System.Drawing.Size(290, 24)
        Me.txtBackUpDB1.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(301, 305)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 24)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBackUpDB2
        '
        Me.txtBackUpDB2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackUpDB2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackUpDB2.DefaultText = ""
        Me.txtBackUpDB2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBackUpDB2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBackUpDB2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBackUpDB2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBackUpDB2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBackUpDB2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBackUpDB2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBackUpDB2.Location = New System.Drawing.Point(195, 305)
        Me.txtBackUpDB2.Name = "txtBackUpDB2"
        Me.txtBackUpDB2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackUpDB2.PlaceholderText = ""
        Me.txtBackUpDB2.SelectedText = ""
        Me.txtBackUpDB2.Size = New System.Drawing.Size(238, 24)
        Me.txtBackUpDB2.TabIndex = 50
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(301, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 24)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtBackUpDB3
        '
        Me.txtBackUpDB3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackUpDB3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackUpDB3.DefaultText = ""
        Me.txtBackUpDB3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBackUpDB3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBackUpDB3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBackUpDB3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBackUpDB3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBackUpDB3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBackUpDB3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBackUpDB3.Location = New System.Drawing.Point(202, 335)
        Me.txtBackUpDB3.Name = "txtBackUpDB3"
        Me.txtBackUpDB3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackUpDB3.PlaceholderText = ""
        Me.txtBackUpDB3.SelectedText = ""
        Me.txtBackUpDB3.Size = New System.Drawing.Size(231, 24)
        Me.txtBackUpDB3.TabIndex = 52
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(12, 89)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(148, 17)
        Me.chkActive.TabIndex = 53
        Me.chkActive.Text = "Active Background Worker"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtDBLocation
        '
        Me.txtDBLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBLocation.Location = New System.Drawing.Point(115, 142)
        Me.txtDBLocation.Name = "txtDBLocation"
        Me.txtDBLocation.Size = New System.Drawing.Size(317, 21)
        Me.txtDBLocation.TabIndex = 0
        '
        'cmdBackUpDB1
        '
        Me.cmdBackUpDB1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBackUpDB1.Location = New System.Drawing.Point(439, 275)
        Me.cmdBackUpDB1.Name = "cmdBackUpDB1"
        Me.cmdBackUpDB1.Size = New System.Drawing.Size(26, 24)
        Me.cmdBackUpDB1.TabIndex = 55
        Me.cmdBackUpDB1.Text = "..."
        Me.cmdBackUpDB1.UseVisualStyleBackColor = True
        '
        'cmdBackUpDB2
        '
        Me.cmdBackUpDB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBackUpDB2.Location = New System.Drawing.Point(439, 305)
        Me.cmdBackUpDB2.Name = "cmdBackUpDB2"
        Me.cmdBackUpDB2.Size = New System.Drawing.Size(26, 24)
        Me.cmdBackUpDB2.TabIndex = 56
        Me.cmdBackUpDB2.Text = "..."
        Me.cmdBackUpDB2.UseVisualStyleBackColor = True
        '
        'cmdBackUpDB3
        '
        Me.cmdBackUpDB3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBackUpDB3.Location = New System.Drawing.Point(439, 335)
        Me.cmdBackUpDB3.Name = "cmdBackUpDB3"
        Me.cmdBackUpDB3.Size = New System.Drawing.Size(26, 24)
        Me.cmdBackUpDB3.TabIndex = 57
        Me.cmdBackUpDB3.Text = "..."
        Me.cmdBackUpDB3.UseVisualStyleBackColor = True
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(181, 90)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(61, 13)
        Me.lblIPAddress.TabIndex = 58
        Me.lblIPAddress.Text = "IP Address: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "User-Agent:"
        '
        'txtUserAgent
        '
        Me.txtUserAgent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserAgent.Location = New System.Drawing.Point(80, 248)
        Me.txtUserAgent.Name = "txtUserAgent"
        Me.txtUserAgent.Size = New System.Drawing.Size(385, 21)
        Me.txtUserAgent.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Database Provider:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Set Database Password:"
        '
        'cmbDbProvider
        '
        Me.cmbDbProvider.BackColor = System.Drawing.Color.Transparent
        Me.cmbDbProvider.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDbProvider.FocusedColor = System.Drawing.Color.Empty
        Me.cmbDbProvider.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDbProvider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDbProvider.FormattingEnabled = True
        Me.cmbDbProvider.ItemHeight = 16
        Me.cmbDbProvider.Items.AddRange(New Object() {"Microsoft.ACE.OLEDB.12.0"})
        Me.cmbDbProvider.Location = New System.Drawing.Point(115, 112)
        Me.cmbDbProvider.Name = "cmbDbProvider"
        Me.cmbDbProvider.Size = New System.Drawing.Size(278, 22)
        Me.cmbDbProvider.TabIndex = 66
        '
        'txtDbPassword
        '
        Me.txtDbPassword.Location = New System.Drawing.Point(140, 168)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDbPassword.Size = New System.Drawing.Size(156, 21)
        Me.txtDbPassword.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Ex: C:\Database"
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.pnlMain.Controls.Add(Me.Label12)
        Me.pnlMain.Controls.Add(Me.txtDbPassword)
        Me.pnlMain.Controls.Add(Me.cmbDbProvider)
        Me.pnlMain.Controls.Add(Me.Label11)
        Me.pnlMain.Controls.Add(Me.Label10)
        Me.pnlMain.Controls.Add(Me.txtUserAgent)
        Me.pnlMain.Controls.Add(Me.Label9)
        Me.pnlMain.Controls.Add(Me.lblIPAddress)
        Me.pnlMain.Controls.Add(Me.cmdBackUpDB3)
        Me.pnlMain.Controls.Add(Me.cmdBackUpDB2)
        Me.pnlMain.Controls.Add(Me.cmdBackUpDB1)
        Me.pnlMain.Controls.Add(Me.txtDBLocation)
        Me.pnlMain.Controls.Add(Me.chkActive)
        Me.pnlMain.Controls.Add(Me.txtBackUpDB3)
        Me.pnlMain.Controls.Add(Me.Button3)
        Me.pnlMain.Controls.Add(Me.txtBackUpDB2)
        Me.pnlMain.Controls.Add(Me.Button2)
        Me.pnlMain.Controls.Add(Me.txtBackUpDB1)
        Me.pnlMain.Controls.Add(Me.Button1)
        Me.pnlMain.Controls.Add(Me.txtOnlineDB)
        Me.pnlMain.Controls.Add(Me.Label8)
        Me.pnlMain.Controls.Add(Me.Label5)
        Me.pnlMain.Controls.Add(Me.Label4)
        Me.pnlMain.Controls.Add(Me.probarBGLoad)
        Me.pnlMain.Controls.Add(Me.lblBGLoad)
        Me.pnlMain.Controls.Add(Me.tsProBar)
        Me.pnlMain.Controls.Add(Me.cmdApply)
        Me.pnlMain.Controls.Add(Me.txtActivity)
        Me.pnlMain.Controls.Add(Me.Guna2GroupBox2)
        Me.pnlMain.Controls.Add(Me.Guna2GroupBox1)
        Me.pnlMain.Controls.Add(Me.txtOnlineDBPass)
        Me.pnlMain.Controls.Add(Me.Label20)
        Me.pnlMain.Controls.Add(Me.txtOnlineDBUser)
        Me.pnlMain.Controls.Add(Me.Label19)
        Me.pnlMain.Controls.Add(Me.chkOnlineDB)
        Me.pnlMain.Controls.Add(Me.cmdDBLocation)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Controls.Add(Me.lblLoad)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(566, 617)
        Me.pnlMain.TabIndex = 1
        '
        'flpMessage
        '
        Me.flpMessage.AllowDrop = True
        Me.flpMessage.AutoScroll = True
        Me.flpMessage.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.flpMessage.BackColor = System.Drawing.Color.Black
        Me.flpMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.flpMessage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMessage.Location = New System.Drawing.Point(566, 0)
        Me.flpMessage.Name = "flpMessage"
        Me.flpMessage.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.flpMessage.Size = New System.Drawing.Size(455, 617)
        Me.flpMessage.TabIndex = 0
        Me.flpMessage.WrapContents = False
        '
        'frmBGTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 617)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.flpMessage)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBGTasks"
        Me.Text = "LASER System - BackGround Worker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgworkerOnline As System.ComponentModel.BackgroundWorker
    Friend WithEvents ofdDatabase As OpenFileDialog
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents lblLoad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDBLocation As Button
    Friend WithEvents chkOnlineDB As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtOnlineDBUser As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtOnlineDBPass As TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMAdminEmailVerify As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdminEmailVerify As Button
    Friend WithEvents txtMAdminPass As TextBox
    Friend WithEvents txtMAdminEmail As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents chkMSendEmail As CheckBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents cmbMBgSMS As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMApiToken As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMApiKey As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtActivity As TextBox
    Friend WithEvents cmdApply As Button
    Friend WithEvents tsProBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lblBGLoad As Label
    Friend WithEvents probarBGLoad As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOnlineDB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBackUpDB1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtBackUpDB2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtBackUpDB3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents txtDBLocation As TextBox
    Friend WithEvents cmdBackUpDB1 As Button
    Friend WithEvents cmdBackUpDB2 As Button
    Friend WithEvents cmdBackUpDB3 As Button
    Friend WithEvents lblIPAddress As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUserAgent As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbDbProvider As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtDbPassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpMessage As FlowLayoutPanel
End Class
