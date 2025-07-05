<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBGTasks
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBGTasks))
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.ofdDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblLoad = New MaterialSkin.Controls.MaterialLabel()
        Me.CheckRemoteDb = New MaterialSkin.Controls.MaterialCheckbox()
        Me.Guna2GroupBox1 = New MaterialSkin.Controls.MaterialCard()
        Me.TextPort = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextHost = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtMAdminEmailVerify = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnAdminEmailVerify = New MaterialSkin.Controls.MaterialButton()
        Me.txtMAdminPass = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtMAdminEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.chkMSendEmail = New MaterialSkin.Controls.MaterialCheckbox()
        Me.Guna2GroupBox2 = New MaterialSkin.Controls.MaterialCard()
        Me.RadioDeactivate = New MaterialSkin.Controls.MaterialRadioButton()
        Me.RadioActivate = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblBalance = New MaterialSkin.Controls.MaterialLabel()
        Me.txtMApiToken = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtMApiKey = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tsProBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.lblBGLoad = New MaterialSkin.Controls.MaterialLabel()
        Me.tsBGProBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.txtBackUpDB1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBackUpDB2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBackUpDB3 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.chkActive = New MaterialSkin.Controls.MaterialCheckbox()
        Me.TextDbServer = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cmdBackUpDB1 = New MaterialSkin.Controls.MaterialButton()
        Me.cmdBackUpDB2 = New MaterialSkin.Controls.MaterialButton()
        Me.cmdBackUpDB3 = New MaterialSkin.Controls.MaterialButton()
        Me.lblIPAddress = New MaterialSkin.Controls.MaterialLabel()
        Me.TextDbPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label12 = New MaterialSkin.Controls.MaterialLabel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.BtnOpenAdvDB = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextDbName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextDbUserName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextDbPort = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New MaterialSkin.Controls.MaterialCard()
        Me.ButtonRunFullSynchronization = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextRemoteDbName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextRemoteDbUserName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextRemoteDbPort = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextRemoteDbPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TextRemoteDbServer = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New MaterialSkin.Controls.MaterialCard()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.PicBGOStop = New System.Windows.Forms.PictureBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.PicBGStop = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New MaterialSkin.Controls.MaterialCard()
        Me.GroupBox4 = New MaterialSkin.Controls.MaterialCard()
        Me.cmdApply = New MaterialSkin.Controls.MaterialButton()
        Me.flpMessage = New System.Windows.Forms.FlowLayoutPanel()
        Me.WorkerDatabaseSyncronize = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.MaterialTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.PicBGOStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.PicBGStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 10000
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "LASER Background Worker"
        Me.NotifyIcon.Visible = True
        '
        'lblLoad
        '
        Me.lblLoad.Depth = 0
        Me.lblLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoad.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblLoad.ForeColor = System.Drawing.Color.White
        Me.lblLoad.Location = New System.Drawing.Point(14, 14)
        Me.lblLoad.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(262, 54)
        Me.lblLoad.TabIndex = 1
        Me.lblLoad.Text = "Please Wait..."
        '
        'CheckRemoteDb
        '
        Me.CheckRemoteDb.AutoSize = True
        Me.CheckRemoteDb.Depth = 0
        Me.CheckRemoteDb.ForeColor = System.Drawing.Color.White
        Me.CheckRemoteDb.Location = New System.Drawing.Point(14, 14)
        Me.CheckRemoteDb.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckRemoteDb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckRemoteDb.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckRemoteDb.Name = "CheckRemoteDb"
        Me.CheckRemoteDb.ReadOnly = False
        Me.CheckRemoteDb.Ripple = True
        Me.CheckRemoteDb.Size = New System.Drawing.Size(197, 37)
        Me.CheckRemoteDb.TabIndex = 28
        Me.CheckRemoteDb.Text = "Active Synchronization"
        Me.CheckRemoteDb.UseVisualStyleBackColor = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.TextPort)
        Me.Guna2GroupBox1.Controls.Add(Me.TextHost)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMAdminEmailVerify)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAdminEmailVerify)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMAdminPass)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMAdminEmail)
        Me.Guna2GroupBox1.Controls.Add(Me.chkMSendEmail)
        Me.Guna2GroupBox1.Depth = 0
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(14)
        Me.Guna2GroupBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Padding = New System.Windows.Forms.Padding(14)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(590, 275)
        Me.Guna2GroupBox1.TabIndex = 35
        Me.Guna2GroupBox1.Text = "Emails"
        '
        'TextPort
        '
        Me.TextPort.AnimateReadOnly = False
        Me.TextPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextPort.Depth = 0
        Me.TextPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextPort.HideSelection = True
        Me.TextPort.Hint = "Port"
        Me.TextPort.LeadingIcon = Nothing
        Me.TextPort.Location = New System.Drawing.Point(445, 55)
        Me.TextPort.MaxLength = 32767
        Me.TextPort.MouseState = MaterialSkin.MouseState.OUT
        Me.TextPort.Name = "TextPort"
        Me.TextPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextPort.PrefixSuffixText = Nothing
        Me.TextPort.ReadOnly = False
        Me.TextPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextPort.SelectedText = ""
        Me.TextPort.SelectionLength = 0
        Me.TextPort.SelectionStart = 0
        Me.TextPort.ShortcutsEnabled = True
        Me.TextPort.Size = New System.Drawing.Size(121, 48)
        Me.TextPort.TabIndex = 45
        Me.TextPort.TabStop = False
        Me.TextPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextPort.TrailingIcon = Nothing
        Me.TextPort.UseSystemPasswordChar = False
        '
        'TextHost
        '
        Me.TextHost.AnimateReadOnly = False
        Me.TextHost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextHost.Depth = 0
        Me.TextHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextHost.HideSelection = True
        Me.TextHost.Hint = "Host"
        Me.TextHost.LeadingIcon = Nothing
        Me.TextHost.Location = New System.Drawing.Point(10, 55)
        Me.TextHost.MaxLength = 32767
        Me.TextHost.MouseState = MaterialSkin.MouseState.OUT
        Me.TextHost.Name = "TextHost"
        Me.TextHost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextHost.PrefixSuffixText = Nothing
        Me.TextHost.ReadOnly = False
        Me.TextHost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextHost.SelectedText = ""
        Me.TextHost.SelectionLength = 0
        Me.TextHost.SelectionStart = 0
        Me.TextHost.ShortcutsEnabled = True
        Me.TextHost.Size = New System.Drawing.Size(429, 48)
        Me.TextHost.TabIndex = 44
        Me.TextHost.TabStop = False
        Me.TextHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextHost.TrailingIcon = Nothing
        Me.TextHost.UseSystemPasswordChar = False
        '
        'txtMAdminEmailVerify
        '
        Me.txtMAdminEmailVerify.AnimateReadOnly = False
        Me.txtMAdminEmailVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtMAdminEmailVerify.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMAdminEmailVerify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMAdminEmailVerify.Depth = 0
        Me.txtMAdminEmailVerify.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMAdminEmailVerify.HideSelection = True
        Me.txtMAdminEmailVerify.Hint = "Verification Code"
        Me.txtMAdminEmailVerify.LeadingIcon = Nothing
        Me.txtMAdminEmailVerify.Location = New System.Drawing.Point(11, 159)
        Me.txtMAdminEmailVerify.MaxLength = 32767
        Me.txtMAdminEmailVerify.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMAdminEmailVerify.Name = "txtMAdminEmailVerify"
        Me.txtMAdminEmailVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMAdminEmailVerify.PrefixSuffixText = Nothing
        Me.txtMAdminEmailVerify.ReadOnly = False
        Me.txtMAdminEmailVerify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMAdminEmailVerify.SelectedText = ""
        Me.txtMAdminEmailVerify.SelectionLength = 0
        Me.txtMAdminEmailVerify.SelectionStart = 0
        Me.txtMAdminEmailVerify.ShortcutsEnabled = True
        Me.txtMAdminEmailVerify.Size = New System.Drawing.Size(224, 48)
        Me.txtMAdminEmailVerify.TabIndex = 43
        Me.txtMAdminEmailVerify.TabStop = False
        Me.txtMAdminEmailVerify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMAdminEmailVerify.TrailingIcon = Nothing
        Me.txtMAdminEmailVerify.UseSystemPasswordChar = False
        '
        'btnAdminEmailVerify
        '
        Me.btnAdminEmailVerify.AutoSize = False
        Me.btnAdminEmailVerify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdminEmailVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdminEmailVerify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnAdminEmailVerify.Depth = 0
        Me.btnAdminEmailVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminEmailVerify.HighEmphasis = True
        Me.btnAdminEmailVerify.Icon = Nothing
        Me.btnAdminEmailVerify.Location = New System.Drawing.Point(242, 159)
        Me.btnAdminEmailVerify.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAdminEmailVerify.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAdminEmailVerify.Name = "btnAdminEmailVerify"
        Me.btnAdminEmailVerify.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnAdminEmailVerify.Size = New System.Drawing.Size(204, 51)
        Me.btnAdminEmailVerify.TabIndex = 42
        Me.btnAdminEmailVerify.Text = "Get Verification Code"
        Me.btnAdminEmailVerify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAdminEmailVerify.UseAccentColor = False
        Me.btnAdminEmailVerify.UseVisualStyleBackColor = False
        '
        'txtMAdminPass
        '
        Me.txtMAdminPass.AnimateReadOnly = False
        Me.txtMAdminPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtMAdminPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMAdminPass.Depth = 0
        Me.txtMAdminPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMAdminPass.HideSelection = True
        Me.txtMAdminPass.Hint = "Password"
        Me.txtMAdminPass.LeadingIcon = Nothing
        Me.txtMAdminPass.Location = New System.Drawing.Point(302, 105)
        Me.txtMAdminPass.MaxLength = 32767
        Me.txtMAdminPass.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMAdminPass.Name = "txtMAdminPass"
        Me.txtMAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMAdminPass.PrefixSuffixText = Nothing
        Me.txtMAdminPass.ReadOnly = False
        Me.txtMAdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMAdminPass.SelectedText = ""
        Me.txtMAdminPass.SelectionLength = 0
        Me.txtMAdminPass.SelectionStart = 0
        Me.txtMAdminPass.ShortcutsEnabled = True
        Me.txtMAdminPass.Size = New System.Drawing.Size(265, 48)
        Me.txtMAdminPass.TabIndex = 41
        Me.txtMAdminPass.TabStop = False
        Me.txtMAdminPass.Text = "default"
        Me.txtMAdminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMAdminPass.TrailingIcon = Nothing
        Me.txtMAdminPass.UseSystemPasswordChar = False
        '
        'txtMAdminEmail
        '
        Me.txtMAdminEmail.AnimateReadOnly = False
        Me.txtMAdminEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtMAdminEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMAdminEmail.Depth = 0
        Me.txtMAdminEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMAdminEmail.HideSelection = True
        Me.txtMAdminEmail.Hint = "Admin Email"
        Me.txtMAdminEmail.LeadingIcon = Nothing
        Me.txtMAdminEmail.Location = New System.Drawing.Point(11, 105)
        Me.txtMAdminEmail.MaxLength = 32767
        Me.txtMAdminEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMAdminEmail.Name = "txtMAdminEmail"
        Me.txtMAdminEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMAdminEmail.PrefixSuffixText = Nothing
        Me.txtMAdminEmail.ReadOnly = False
        Me.txtMAdminEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMAdminEmail.SelectedText = ""
        Me.txtMAdminEmail.SelectionLength = 0
        Me.txtMAdminEmail.SelectionStart = 0
        Me.txtMAdminEmail.ShortcutsEnabled = True
        Me.txtMAdminEmail.Size = New System.Drawing.Size(285, 48)
        Me.txtMAdminEmail.TabIndex = 40
        Me.txtMAdminEmail.TabStop = False
        Me.txtMAdminEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMAdminEmail.TrailingIcon = Nothing
        Me.txtMAdminEmail.UseSystemPasswordChar = False
        '
        'chkMSendEmail
        '
        Me.chkMSendEmail.Depth = 0
        Me.chkMSendEmail.Location = New System.Drawing.Point(14, 14)
        Me.chkMSendEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.chkMSendEmail.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkMSendEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkMSendEmail.Name = "chkMSendEmail"
        Me.chkMSendEmail.ReadOnly = False
        Me.chkMSendEmail.Ripple = True
        Me.chkMSendEmail.Size = New System.Drawing.Size(246, 38)
        Me.chkMSendEmail.TabIndex = 37
        Me.chkMSendEmail.Text = "Automatically send Emails"
        Me.chkMSendEmail.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox2.Controls.Add(Me.RadioDeactivate)
        Me.Guna2GroupBox2.Controls.Add(Me.RadioActivate)
        Me.Guna2GroupBox2.Controls.Add(Me.MaterialLabel5)
        Me.Guna2GroupBox2.Controls.Add(Me.lblBalance)
        Me.Guna2GroupBox2.Controls.Add(Me.txtMApiToken)
        Me.Guna2GroupBox2.Controls.Add(Me.txtMApiKey)
        Me.Guna2GroupBox2.Depth = 0
        Me.Guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(14)
        Me.Guna2GroupBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Padding = New System.Windows.Forms.Padding(14)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(590, 275)
        Me.Guna2GroupBox2.TabIndex = 36
        Me.Guna2GroupBox2.Text = "SMS"
        '
        'RadioDeactivate
        '
        Me.RadioDeactivate.AutoSize = True
        Me.RadioDeactivate.Checked = True
        Me.RadioDeactivate.Depth = 0
        Me.RadioDeactivate.Location = New System.Drawing.Point(242, 16)
        Me.RadioDeactivate.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioDeactivate.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioDeactivate.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioDeactivate.Name = "RadioDeactivate"
        Me.RadioDeactivate.Ripple = True
        Me.RadioDeactivate.Size = New System.Drawing.Size(110, 37)
        Me.RadioDeactivate.TabIndex = 62
        Me.RadioDeactivate.TabStop = True
        Me.RadioDeactivate.Text = "Deactivate"
        Me.RadioDeactivate.UseVisualStyleBackColor = True
        '
        'RadioActivate
        '
        Me.RadioActivate.AutoSize = True
        Me.RadioActivate.Depth = 0
        Me.RadioActivate.Location = New System.Drawing.Point(113, 16)
        Me.RadioActivate.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioActivate.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioActivate.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioActivate.Name = "RadioActivate"
        Me.RadioActivate.Ripple = True
        Me.RadioActivate.Size = New System.Drawing.Size(92, 37)
        Me.RadioActivate.TabIndex = 61
        Me.RadioActivate.TabStop = True
        Me.RadioActivate.Text = "Activate"
        Me.RadioActivate.UseVisualStyleBackColor = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.Location = New System.Drawing.Point(14, 26)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(58, 19)
        Me.MaterialLabel5.TabIndex = 60
        Me.MaterialLabel5.Text = "Activate"
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.Color.Lime
        Me.lblBalance.Depth = 0
        Me.lblBalance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBalance.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(14, 228)
        Me.lblBalance.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(562, 33)
        Me.lblBalance.TabIndex = 59
        Me.lblBalance.Text = "Balance: Rs. ###"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMApiToken
        '
        Me.txtMApiToken.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMApiToken.AnimateReadOnly = False
        Me.txtMApiToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtMApiToken.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMApiToken.Depth = 0
        Me.txtMApiToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMApiToken.HideSelection = True
        Me.txtMApiToken.Hint = "API Token"
        Me.txtMApiToken.LeadingIcon = Nothing
        Me.txtMApiToken.Location = New System.Drawing.Point(10, 56)
        Me.txtMApiToken.MaxLength = 32767
        Me.txtMApiToken.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMApiToken.Name = "txtMApiToken"
        Me.txtMApiToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMApiToken.PrefixSuffixText = Nothing
        Me.txtMApiToken.ReadOnly = False
        Me.txtMApiToken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMApiToken.SelectedText = ""
        Me.txtMApiToken.SelectionLength = 0
        Me.txtMApiToken.SelectionStart = 0
        Me.txtMApiToken.ShortcutsEnabled = True
        Me.txtMApiToken.Size = New System.Drawing.Size(563, 48)
        Me.txtMApiToken.TabIndex = 28
        Me.txtMApiToken.TabStop = False
        Me.txtMApiToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMApiToken.TrailingIcon = Nothing
        Me.txtMApiToken.UseSystemPasswordChar = False
        '
        'txtMApiKey
        '
        Me.txtMApiKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMApiKey.AnimateReadOnly = False
        Me.txtMApiKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtMApiKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMApiKey.Depth = 0
        Me.txtMApiKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMApiKey.HideSelection = True
        Me.txtMApiKey.Hint = "API Key"
        Me.txtMApiKey.LeadingIcon = Nothing
        Me.txtMApiKey.Location = New System.Drawing.Point(10, 110)
        Me.txtMApiKey.MaxLength = 32767
        Me.txtMApiKey.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMApiKey.Name = "txtMApiKey"
        Me.txtMApiKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMApiKey.PrefixSuffixText = Nothing
        Me.txtMApiKey.ReadOnly = False
        Me.txtMApiKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMApiKey.SelectedText = ""
        Me.txtMApiKey.SelectionLength = 0
        Me.txtMApiKey.SelectionStart = 0
        Me.txtMApiKey.ShortcutsEnabled = True
        Me.txtMApiKey.Size = New System.Drawing.Size(563, 48)
        Me.txtMApiKey.TabIndex = 26
        Me.txtMApiKey.TabStop = False
        Me.txtMApiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMApiKey.TrailingIcon = Nothing
        Me.txtMApiKey.UseSystemPasswordChar = False
        '
        'tsProBar
        '
        Me.tsProBar.BackColor = System.Drawing.Color.Black
        Me.tsProBar.Depth = 0
        Me.tsProBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsProBar.ForeColor = System.Drawing.Color.White
        Me.tsProBar.Location = New System.Drawing.Point(14, 63)
        Me.tsProBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.tsProBar.Name = "tsProBar"
        Me.tsProBar.Size = New System.Drawing.Size(262, 5)
        Me.tsProBar.TabIndex = 39
        '
        'lblBGLoad
        '
        Me.lblBGLoad.Depth = 0
        Me.lblBGLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBGLoad.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBGLoad.ForeColor = System.Drawing.Color.White
        Me.lblBGLoad.Location = New System.Drawing.Point(14, 14)
        Me.lblBGLoad.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBGLoad.Name = "lblBGLoad"
        Me.lblBGLoad.Size = New System.Drawing.Size(262, 54)
        Me.lblBGLoad.TabIndex = 40
        Me.lblBGLoad.Text = "Please Wait..."
        '
        'tsBGProBar
        '
        Me.tsBGProBar.BackColor = System.Drawing.Color.Black
        Me.tsBGProBar.Depth = 0
        Me.tsBGProBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsBGProBar.ForeColor = System.Drawing.Color.White
        Me.tsBGProBar.Location = New System.Drawing.Point(14, 63)
        Me.tsBGProBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.tsBGProBar.Name = "tsBGProBar"
        Me.tsBGProBar.Size = New System.Drawing.Size(262, 5)
        Me.tsBGProBar.TabIndex = 41
        '
        'txtBackUpDB1
        '
        Me.txtBackUpDB1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackUpDB1.AnimateReadOnly = False
        Me.txtBackUpDB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBackUpDB1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBackUpDB1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackUpDB1.Depth = 0
        Me.txtBackUpDB1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBackUpDB1.HideSelection = True
        Me.txtBackUpDB1.Hint = "Backup Path 1 "
        Me.txtBackUpDB1.LeadingIcon = Nothing
        Me.txtBackUpDB1.Location = New System.Drawing.Point(17, 17)
        Me.txtBackUpDB1.MaxLength = 32767
        Me.txtBackUpDB1.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBackUpDB1.Name = "txtBackUpDB1"
        Me.txtBackUpDB1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackUpDB1.PrefixSuffixText = Nothing
        Me.txtBackUpDB1.ReadOnly = False
        Me.txtBackUpDB1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBackUpDB1.SelectedText = ""
        Me.txtBackUpDB1.SelectionLength = 0
        Me.txtBackUpDB1.SelectionStart = 0
        Me.txtBackUpDB1.ShortcutsEnabled = True
        Me.txtBackUpDB1.Size = New System.Drawing.Size(502, 48)
        Me.txtBackUpDB1.TabIndex = 48
        Me.txtBackUpDB1.TabStop = False
        Me.txtBackUpDB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBackUpDB1.TrailingIcon = Nothing
        Me.txtBackUpDB1.UseSystemPasswordChar = False
        '
        'txtBackUpDB2
        '
        Me.txtBackUpDB2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackUpDB2.AnimateReadOnly = False
        Me.txtBackUpDB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBackUpDB2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBackUpDB2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackUpDB2.Depth = 0
        Me.txtBackUpDB2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBackUpDB2.HideSelection = True
        Me.txtBackUpDB2.Hint = "Backup Path 2 (Hidden)"
        Me.txtBackUpDB2.LeadingIcon = Nothing
        Me.txtBackUpDB2.Location = New System.Drawing.Point(17, 71)
        Me.txtBackUpDB2.MaxLength = 32767
        Me.txtBackUpDB2.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBackUpDB2.Name = "txtBackUpDB2"
        Me.txtBackUpDB2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackUpDB2.PrefixSuffixText = Nothing
        Me.txtBackUpDB2.ReadOnly = False
        Me.txtBackUpDB2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBackUpDB2.SelectedText = ""
        Me.txtBackUpDB2.SelectionLength = 0
        Me.txtBackUpDB2.SelectionStart = 0
        Me.txtBackUpDB2.ShortcutsEnabled = True
        Me.txtBackUpDB2.Size = New System.Drawing.Size(501, 48)
        Me.txtBackUpDB2.TabIndex = 50
        Me.txtBackUpDB2.TabStop = False
        Me.txtBackUpDB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBackUpDB2.TrailingIcon = Nothing
        Me.txtBackUpDB2.UseSystemPasswordChar = False
        '
        'txtBackUpDB3
        '
        Me.txtBackUpDB3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackUpDB3.AnimateReadOnly = False
        Me.txtBackUpDB3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBackUpDB3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBackUpDB3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackUpDB3.Depth = 0
        Me.txtBackUpDB3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBackUpDB3.HideSelection = True
        Me.txtBackUpDB3.Hint = "Backup Path3 (Hidden)"
        Me.txtBackUpDB3.LeadingIcon = Nothing
        Me.txtBackUpDB3.Location = New System.Drawing.Point(17, 125)
        Me.txtBackUpDB3.MaxLength = 32767
        Me.txtBackUpDB3.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBackUpDB3.Name = "txtBackUpDB3"
        Me.txtBackUpDB3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackUpDB3.PrefixSuffixText = Nothing
        Me.txtBackUpDB3.ReadOnly = False
        Me.txtBackUpDB3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBackUpDB3.SelectedText = ""
        Me.txtBackUpDB3.SelectionLength = 0
        Me.txtBackUpDB3.SelectionStart = 0
        Me.txtBackUpDB3.ShortcutsEnabled = True
        Me.txtBackUpDB3.Size = New System.Drawing.Size(502, 48)
        Me.txtBackUpDB3.TabIndex = 52
        Me.txtBackUpDB3.TabStop = False
        Me.txtBackUpDB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBackUpDB3.TrailingIcon = Nothing
        Me.txtBackUpDB3.UseSystemPasswordChar = False
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Depth = 0
        Me.chkActive.ForeColor = System.Drawing.Color.White
        Me.chkActive.Location = New System.Drawing.Point(14, 14)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(0)
        Me.chkActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkActive.Name = "chkActive"
        Me.chkActive.ReadOnly = False
        Me.chkActive.Ripple = True
        Me.chkActive.Size = New System.Drawing.Size(220, 37)
        Me.chkActive.TabIndex = 53
        Me.chkActive.Text = "Active Background Worker"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'TextDbServer
        '
        Me.TextDbServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDbServer.AnimateReadOnly = False
        Me.TextDbServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextDbServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextDbServer.Depth = 0
        Me.TextDbServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextDbServer.HideSelection = True
        Me.TextDbServer.Hint = "Server"
        Me.TextDbServer.LeadingIcon = Nothing
        Me.TextDbServer.Location = New System.Drawing.Point(146, 3)
        Me.TextDbServer.MaxLength = 32767
        Me.TextDbServer.MouseState = MaterialSkin.MouseState.OUT
        Me.TextDbServer.Name = "TextDbServer"
        Me.TextDbServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextDbServer.PrefixSuffixText = Nothing
        Me.TextDbServer.ReadOnly = False
        Me.TextDbServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextDbServer.SelectedText = ""
        Me.TextDbServer.SelectionLength = 0
        Me.TextDbServer.SelectionStart = 0
        Me.TextDbServer.ShortcutsEnabled = True
        Me.TextDbServer.Size = New System.Drawing.Size(314, 48)
        Me.TextDbServer.TabIndex = 0
        Me.TextDbServer.TabStop = False
        Me.TextDbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextDbServer.TrailingIcon = Nothing
        Me.TextDbServer.UseSystemPasswordChar = False
        '
        'cmdBackUpDB1
        '
        Me.cmdBackUpDB1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBackUpDB1.AutoSize = False
        Me.cmdBackUpDB1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBackUpDB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdBackUpDB1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdBackUpDB1.Depth = 0
        Me.cmdBackUpDB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBackUpDB1.HighEmphasis = True
        Me.cmdBackUpDB1.Icon = Nothing
        Me.cmdBackUpDB1.Location = New System.Drawing.Point(526, 17)
        Me.cmdBackUpDB1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdBackUpDB1.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdBackUpDB1.Name = "cmdBackUpDB1"
        Me.cmdBackUpDB1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdBackUpDB1.Size = New System.Drawing.Size(52, 48)
        Me.cmdBackUpDB1.TabIndex = 55
        Me.cmdBackUpDB1.Text = "..."
        Me.cmdBackUpDB1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdBackUpDB1.UseAccentColor = False
        Me.cmdBackUpDB1.UseVisualStyleBackColor = False
        '
        'cmdBackUpDB2
        '
        Me.cmdBackUpDB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBackUpDB2.AutoSize = False
        Me.cmdBackUpDB2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBackUpDB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdBackUpDB2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdBackUpDB2.Depth = 0
        Me.cmdBackUpDB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBackUpDB2.HighEmphasis = True
        Me.cmdBackUpDB2.Icon = Nothing
        Me.cmdBackUpDB2.Location = New System.Drawing.Point(526, 71)
        Me.cmdBackUpDB2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdBackUpDB2.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdBackUpDB2.Name = "cmdBackUpDB2"
        Me.cmdBackUpDB2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdBackUpDB2.Size = New System.Drawing.Size(52, 48)
        Me.cmdBackUpDB2.TabIndex = 56
        Me.cmdBackUpDB2.Text = "..."
        Me.cmdBackUpDB2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdBackUpDB2.UseAccentColor = False
        Me.cmdBackUpDB2.UseVisualStyleBackColor = False
        '
        'cmdBackUpDB3
        '
        Me.cmdBackUpDB3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBackUpDB3.AutoSize = False
        Me.cmdBackUpDB3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBackUpDB3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdBackUpDB3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdBackUpDB3.Depth = 0
        Me.cmdBackUpDB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBackUpDB3.HighEmphasis = True
        Me.cmdBackUpDB3.Icon = Nothing
        Me.cmdBackUpDB3.Location = New System.Drawing.Point(526, 125)
        Me.cmdBackUpDB3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdBackUpDB3.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdBackUpDB3.Name = "cmdBackUpDB3"
        Me.cmdBackUpDB3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdBackUpDB3.Size = New System.Drawing.Size(52, 48)
        Me.cmdBackUpDB3.TabIndex = 57
        Me.cmdBackUpDB3.Text = "..."
        Me.cmdBackUpDB3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdBackUpDB3.UseAccentColor = False
        Me.cmdBackUpDB3.UseVisualStyleBackColor = False
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Depth = 0
        Me.lblIPAddress.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblIPAddress.ForeColor = System.Drawing.Color.White
        Me.lblIPAddress.Location = New System.Drawing.Point(15, 21)
        Me.lblIPAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(84, 19)
        Me.lblIPAddress.TabIndex = 58
        Me.lblIPAddress.Text = "IP Address: "
        '
        'TextDbPassword
        '
        Me.TextDbPassword.AnimateReadOnly = False
        Me.TextDbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextDbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextDbPassword.Depth = 0
        Me.TextDbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextDbPassword.HideSelection = True
        Me.TextDbPassword.Hint = " Password"
        Me.TextDbPassword.LeadingIcon = Nothing
        Me.TextDbPassword.Location = New System.Drawing.Point(146, 111)
        Me.TextDbPassword.MaxLength = 32767
        Me.TextDbPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.TextDbPassword.Name = "TextDbPassword"
        Me.TextDbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextDbPassword.PrefixSuffixText = Nothing
        Me.TextDbPassword.ReadOnly = False
        Me.TextDbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextDbPassword.SelectedText = ""
        Me.TextDbPassword.SelectionLength = 0
        Me.TextDbPassword.SelectionStart = 0
        Me.TextDbPassword.ShortcutsEnabled = True
        Me.TextDbPassword.Size = New System.Drawing.Size(438, 48)
        Me.TextDbPassword.TabIndex = 67
        Me.TextDbPassword.TabStop = False
        Me.TextDbPassword.Text = "default"
        Me.TextDbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextDbPassword.TrailingIcon = Nothing
        Me.TextDbPassword.UseSystemPasswordChar = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Depth = 0
        Me.Label12.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(17, 186)
        Me.Label12.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(462, 19)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Enter the folder path which is gonna to back up (Ex: C:\Database)"
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.BtnOpenAdvDB)
        Me.pnlMain.Controls.Add(Me.MaterialTabControl)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlMain.Controls.Add(Me.GroupBox5)
        Me.pnlMain.Controls.Add(Me.GroupBox4)
        Me.pnlMain.Controls.Add(Me.cmdApply)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(3, 64)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(636, 733)
        Me.pnlMain.TabIndex = 1
        '
        'BtnOpenAdvDB
        '
        Me.BtnOpenAdvDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenAdvDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnOpenAdvDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnOpenAdvDB.Depth = 0
        Me.BtnOpenAdvDB.HighEmphasis = True
        Me.BtnOpenAdvDB.Icon = Nothing
        Me.BtnOpenAdvDB.Location = New System.Drawing.Point(329, 691)
        Me.BtnOpenAdvDB.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnOpenAdvDB.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnOpenAdvDB.Name = "BtnOpenAdvDB"
        Me.BtnOpenAdvDB.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnOpenAdvDB.Size = New System.Drawing.Size(218, 36)
        Me.BtnOpenAdvDB.TabIndex = 78
        Me.BtnOpenAdvDB.Text = "Open Advanced Database"
        Me.BtnOpenAdvDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOpenAdvDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnOpenAdvDB.UseAccentColor = False
        Me.BtnOpenAdvDB.UseVisualStyleBackColor = False
        '
        'MaterialTabControl
        '
        Me.MaterialTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl.Controls.Add(Me.TabPage5)
        Me.MaterialTabControl.Depth = 0
        Me.MaterialTabControl.ImageList = Me.ImageList
        Me.MaterialTabControl.Location = New System.Drawing.Point(14, 183)
        Me.MaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl.Multiline = True
        Me.MaterialTabControl.Name = "MaterialTabControl"
        Me.MaterialTabControl.SelectedIndex = 0
        Me.MaterialTabControl.Size = New System.Drawing.Size(604, 499)
        Me.MaterialTabControl.TabIndex = 77
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ImageKey = "database.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(596, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Local Database"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.TextDbName)
        Me.GroupBox1.Controls.Add(Me.TextDbUserName)
        Me.GroupBox1.Controls.Add(Me.TextDbPort)
        Me.GroupBox1.Controls.Add(Me.TextDbPassword)
        Me.GroupBox1.Controls.Add(Me.TextDbServer)
        Me.GroupBox1.Depth = 0
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox1.Size = New System.Drawing.Size(590, 450)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.Text = "Local Database Info"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(7, 181)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(69, 19)
        Me.MaterialLabel4.TabIndex = 74
        Me.MaterialLabel4.Text = "Database"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(7, 125)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MaterialLabel3.TabIndex = 73
        Me.MaterialLabel3.Text = "Password"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(7, 68)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel2.TabIndex = 72
        Me.MaterialLabel2.Text = "User Name"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(7, 14)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MaterialLabel1.TabIndex = 71
        Me.MaterialLabel1.Text = "Server"
        '
        'TextDbName
        '
        Me.TextDbName.AnimateReadOnly = False
        Me.TextDbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextDbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextDbName.Depth = 0
        Me.TextDbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextDbName.HideSelection = True
        Me.TextDbName.Hint = "Database"
        Me.TextDbName.LeadingIcon = Nothing
        Me.TextDbName.Location = New System.Drawing.Point(146, 165)
        Me.TextDbName.MaxLength = 32767
        Me.TextDbName.MouseState = MaterialSkin.MouseState.OUT
        Me.TextDbName.Name = "TextDbName"
        Me.TextDbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextDbName.PrefixSuffixText = Nothing
        Me.TextDbName.ReadOnly = False
        Me.TextDbName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextDbName.SelectedText = ""
        Me.TextDbName.SelectionLength = 0
        Me.TextDbName.SelectionStart = 0
        Me.TextDbName.ShortcutsEnabled = True
        Me.TextDbName.Size = New System.Drawing.Size(438, 48)
        Me.TextDbName.TabIndex = 70
        Me.TextDbName.TabStop = False
        Me.TextDbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextDbName.TrailingIcon = Nothing
        Me.TextDbName.UseSystemPasswordChar = False
        '
        'TextDbUserName
        '
        Me.TextDbUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDbUserName.AnimateReadOnly = False
        Me.TextDbUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextDbUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextDbUserName.Depth = 0
        Me.TextDbUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextDbUserName.HideSelection = True
        Me.TextDbUserName.Hint = "User Name"
        Me.TextDbUserName.LeadingIcon = Nothing
        Me.TextDbUserName.Location = New System.Drawing.Point(146, 57)
        Me.TextDbUserName.MaxLength = 32767
        Me.TextDbUserName.MouseState = MaterialSkin.MouseState.OUT
        Me.TextDbUserName.Name = "TextDbUserName"
        Me.TextDbUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextDbUserName.PrefixSuffixText = Nothing
        Me.TextDbUserName.ReadOnly = False
        Me.TextDbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextDbUserName.SelectedText = ""
        Me.TextDbUserName.SelectionLength = 0
        Me.TextDbUserName.SelectionStart = 0
        Me.TextDbUserName.ShortcutsEnabled = True
        Me.TextDbUserName.Size = New System.Drawing.Size(438, 48)
        Me.TextDbUserName.TabIndex = 69
        Me.TextDbUserName.TabStop = False
        Me.TextDbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextDbUserName.TrailingIcon = Nothing
        Me.TextDbUserName.UseSystemPasswordChar = False
        '
        'TextDbPort
        '
        Me.TextDbPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDbPort.AnimateReadOnly = False
        Me.TextDbPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextDbPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextDbPort.Depth = 0
        Me.TextDbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextDbPort.HideSelection = True
        Me.TextDbPort.Hint = "Port"
        Me.TextDbPort.LeadingIcon = Nothing
        Me.TextDbPort.Location = New System.Drawing.Point(466, 3)
        Me.TextDbPort.MaxLength = 32767
        Me.TextDbPort.MouseState = MaterialSkin.MouseState.OUT
        Me.TextDbPort.Name = "TextDbPort"
        Me.TextDbPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextDbPort.PrefixSuffixText = Nothing
        Me.TextDbPort.ReadOnly = False
        Me.TextDbPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextDbPort.SelectedText = ""
        Me.TextDbPort.SelectionLength = 0
        Me.TextDbPort.SelectionStart = 0
        Me.TextDbPort.ShortcutsEnabled = True
        Me.TextDbPort.Size = New System.Drawing.Size(118, 48)
        Me.TextDbPort.TabIndex = 68
        Me.TextDbPort.TabStop = False
        Me.TextDbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextDbPort.TrailingIcon = Nothing
        Me.TextDbPort.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.ImageKey = "internet.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(596, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Remote Database"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.ButtonRunFullSynchronization)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel7)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel8)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel9)
        Me.GroupBox3.Controls.Add(Me.TextRemoteDbName)
        Me.GroupBox3.Controls.Add(Me.TextRemoteDbUserName)
        Me.GroupBox3.Controls.Add(Me.TextRemoteDbPort)
        Me.GroupBox3.Controls.Add(Me.TextRemoteDbPassword)
        Me.GroupBox3.Controls.Add(Me.TextRemoteDbServer)
        Me.GroupBox3.Controls.Add(Me.CheckRemoteDb)
        Me.GroupBox3.Depth = 0
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox3.Size = New System.Drawing.Size(590, 275)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.Text = "Online Database Info"
        '
        'ButtonRunFullSynchronization
        '
        Me.ButtonRunFullSynchronization.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRunFullSynchronization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonRunFullSynchronization.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.ButtonRunFullSynchronization.Depth = 0
        Me.ButtonRunFullSynchronization.HighEmphasis = True
        Me.ButtonRunFullSynchronization.Icon = Nothing
        Me.ButtonRunFullSynchronization.Location = New System.Drawing.Point(394, 6)
        Me.ButtonRunFullSynchronization.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonRunFullSynchronization.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonRunFullSynchronization.Name = "ButtonRunFullSynchronization"
        Me.ButtonRunFullSynchronization.NoAccentTextColor = System.Drawing.Color.Empty
        Me.ButtonRunFullSynchronization.Size = New System.Drawing.Size(192, 36)
        Me.ButtonRunFullSynchronization.TabIndex = 84
        Me.ButtonRunFullSynchronization.Text = "Run Full Synchronize"
        Me.ButtonRunFullSynchronization.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.ButtonRunFullSynchronization.UseAccentColor = False
        Me.ButtonRunFullSynchronization.UseVisualStyleBackColor = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.Location = New System.Drawing.Point(10, 234)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(69, 19)
        Me.MaterialLabel6.TabIndex = 83
        Me.MaterialLabel6.Text = "Database"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.Location = New System.Drawing.Point(10, 178)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(71, 19)
        Me.MaterialLabel7.TabIndex = 82
        Me.MaterialLabel7.Text = "Password"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.Location = New System.Drawing.Point(10, 121)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel8.TabIndex = 81
        Me.MaterialLabel8.Text = "User Name"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.Location = New System.Drawing.Point(10, 67)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(45, 19)
        Me.MaterialLabel9.TabIndex = 80
        Me.MaterialLabel9.Text = "Server"
        '
        'TextRemoteDbName
        '
        Me.TextRemoteDbName.AnimateReadOnly = False
        Me.TextRemoteDbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextRemoteDbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextRemoteDbName.Depth = 0
        Me.TextRemoteDbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextRemoteDbName.HideSelection = True
        Me.TextRemoteDbName.Hint = "Database"
        Me.TextRemoteDbName.LeadingIcon = Nothing
        Me.TextRemoteDbName.Location = New System.Drawing.Point(149, 218)
        Me.TextRemoteDbName.MaxLength = 32767
        Me.TextRemoteDbName.MouseState = MaterialSkin.MouseState.OUT
        Me.TextRemoteDbName.Name = "TextRemoteDbName"
        Me.TextRemoteDbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextRemoteDbName.PrefixSuffixText = Nothing
        Me.TextRemoteDbName.ReadOnly = False
        Me.TextRemoteDbName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextRemoteDbName.SelectedText = ""
        Me.TextRemoteDbName.SelectionLength = 0
        Me.TextRemoteDbName.SelectionStart = 0
        Me.TextRemoteDbName.ShortcutsEnabled = True
        Me.TextRemoteDbName.Size = New System.Drawing.Size(438, 48)
        Me.TextRemoteDbName.TabIndex = 79
        Me.TextRemoteDbName.TabStop = False
        Me.TextRemoteDbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextRemoteDbName.TrailingIcon = Nothing
        Me.TextRemoteDbName.UseSystemPasswordChar = False
        '
        'TextRemoteDbUserName
        '
        Me.TextRemoteDbUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextRemoteDbUserName.AnimateReadOnly = False
        Me.TextRemoteDbUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextRemoteDbUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextRemoteDbUserName.Depth = 0
        Me.TextRemoteDbUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextRemoteDbUserName.HideSelection = True
        Me.TextRemoteDbUserName.Hint = "User Name"
        Me.TextRemoteDbUserName.LeadingIcon = Nothing
        Me.TextRemoteDbUserName.Location = New System.Drawing.Point(149, 110)
        Me.TextRemoteDbUserName.MaxLength = 32767
        Me.TextRemoteDbUserName.MouseState = MaterialSkin.MouseState.OUT
        Me.TextRemoteDbUserName.Name = "TextRemoteDbUserName"
        Me.TextRemoteDbUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextRemoteDbUserName.PrefixSuffixText = Nothing
        Me.TextRemoteDbUserName.ReadOnly = False
        Me.TextRemoteDbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextRemoteDbUserName.SelectedText = ""
        Me.TextRemoteDbUserName.SelectionLength = 0
        Me.TextRemoteDbUserName.SelectionStart = 0
        Me.TextRemoteDbUserName.ShortcutsEnabled = True
        Me.TextRemoteDbUserName.Size = New System.Drawing.Size(438, 48)
        Me.TextRemoteDbUserName.TabIndex = 78
        Me.TextRemoteDbUserName.TabStop = False
        Me.TextRemoteDbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextRemoteDbUserName.TrailingIcon = Nothing
        Me.TextRemoteDbUserName.UseSystemPasswordChar = False
        '
        'TextRemoteDbPort
        '
        Me.TextRemoteDbPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextRemoteDbPort.AnimateReadOnly = False
        Me.TextRemoteDbPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextRemoteDbPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextRemoteDbPort.Depth = 0
        Me.TextRemoteDbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextRemoteDbPort.HideSelection = True
        Me.TextRemoteDbPort.Hint = "Port"
        Me.TextRemoteDbPort.LeadingIcon = Nothing
        Me.TextRemoteDbPort.Location = New System.Drawing.Point(469, 56)
        Me.TextRemoteDbPort.MaxLength = 32767
        Me.TextRemoteDbPort.MouseState = MaterialSkin.MouseState.OUT
        Me.TextRemoteDbPort.Name = "TextRemoteDbPort"
        Me.TextRemoteDbPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextRemoteDbPort.PrefixSuffixText = Nothing
        Me.TextRemoteDbPort.ReadOnly = False
        Me.TextRemoteDbPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextRemoteDbPort.SelectedText = ""
        Me.TextRemoteDbPort.SelectionLength = 0
        Me.TextRemoteDbPort.SelectionStart = 0
        Me.TextRemoteDbPort.ShortcutsEnabled = True
        Me.TextRemoteDbPort.Size = New System.Drawing.Size(118, 48)
        Me.TextRemoteDbPort.TabIndex = 77
        Me.TextRemoteDbPort.TabStop = False
        Me.TextRemoteDbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextRemoteDbPort.TrailingIcon = Nothing
        Me.TextRemoteDbPort.UseSystemPasswordChar = False
        '
        'TextRemoteDbPassword
        '
        Me.TextRemoteDbPassword.AnimateReadOnly = False
        Me.TextRemoteDbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextRemoteDbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextRemoteDbPassword.Depth = 0
        Me.TextRemoteDbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextRemoteDbPassword.HideSelection = True
        Me.TextRemoteDbPassword.Hint = " Password"
        Me.TextRemoteDbPassword.LeadingIcon = Nothing
        Me.TextRemoteDbPassword.Location = New System.Drawing.Point(149, 164)
        Me.TextRemoteDbPassword.MaxLength = 32767
        Me.TextRemoteDbPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.TextRemoteDbPassword.Name = "TextRemoteDbPassword"
        Me.TextRemoteDbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextRemoteDbPassword.PrefixSuffixText = Nothing
        Me.TextRemoteDbPassword.ReadOnly = False
        Me.TextRemoteDbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextRemoteDbPassword.SelectedText = ""
        Me.TextRemoteDbPassword.SelectionLength = 0
        Me.TextRemoteDbPassword.SelectionStart = 0
        Me.TextRemoteDbPassword.ShortcutsEnabled = True
        Me.TextRemoteDbPassword.Size = New System.Drawing.Size(438, 48)
        Me.TextRemoteDbPassword.TabIndex = 76
        Me.TextRemoteDbPassword.TabStop = False
        Me.TextRemoteDbPassword.Text = "default"
        Me.TextRemoteDbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextRemoteDbPassword.TrailingIcon = Nothing
        Me.TextRemoteDbPassword.UseSystemPasswordChar = False
        '
        'TextRemoteDbServer
        '
        Me.TextRemoteDbServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextRemoteDbServer.AnimateReadOnly = False
        Me.TextRemoteDbServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextRemoteDbServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextRemoteDbServer.Depth = 0
        Me.TextRemoteDbServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextRemoteDbServer.HideSelection = True
        Me.TextRemoteDbServer.Hint = "Server"
        Me.TextRemoteDbServer.LeadingIcon = Nothing
        Me.TextRemoteDbServer.Location = New System.Drawing.Point(149, 56)
        Me.TextRemoteDbServer.MaxLength = 32767
        Me.TextRemoteDbServer.MouseState = MaterialSkin.MouseState.OUT
        Me.TextRemoteDbServer.Name = "TextRemoteDbServer"
        Me.TextRemoteDbServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextRemoteDbServer.PrefixSuffixText = Nothing
        Me.TextRemoteDbServer.ReadOnly = False
        Me.TextRemoteDbServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextRemoteDbServer.SelectedText = ""
        Me.TextRemoteDbServer.SelectionLength = 0
        Me.TextRemoteDbServer.SelectionStart = 0
        Me.TextRemoteDbServer.ShortcutsEnabled = True
        Me.TextRemoteDbServer.Size = New System.Drawing.Size(314, 48)
        Me.TextRemoteDbServer.TabIndex = 75
        Me.TextRemoteDbServer.TabStop = False
        Me.TextRemoteDbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextRemoteDbServer.TrailingIcon = Nothing
        Me.TextRemoteDbServer.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.ImageKey = "backup.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(596, 281)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Backup"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdBackUpDB3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtBackUpDB1)
        Me.GroupBox2.Controls.Add(Me.txtBackUpDB2)
        Me.GroupBox2.Controls.Add(Me.cmdBackUpDB2)
        Me.GroupBox2.Controls.Add(Me.txtBackUpDB3)
        Me.GroupBox2.Controls.Add(Me.cmdBackUpDB1)
        Me.GroupBox2.Depth = 0
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox2.Size = New System.Drawing.Size(590, 275)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.Text = "Back Up Info"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Guna2GroupBox1)
        Me.TabPage4.ImageKey = "message.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(596, 281)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Email"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Guna2GroupBox2)
        Me.TabPage5.ImageKey = "list-message.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 39)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(596, 281)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "SMS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "backup.png")
        Me.ImageList.Images.SetKeyName(1, "internet.png")
        Me.ImageList.Images.SetKeyName(2, "message.png")
        Me.ImageList.Images.SetKeyName(3, "list-message.png")
        Me.ImageList.Images.SetKeyName(4, "database.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialCard2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialCard1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(636, 110)
        Me.TableLayoutPanel1.TabIndex = 76
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.PicBGOStop)
        Me.MaterialCard2.Controls.Add(Me.tsBGProBar)
        Me.MaterialCard2.Controls.Add(Me.lblBGLoad)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(14, 14)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(290, 82)
        Me.MaterialCard2.TabIndex = 75
        '
        'PicBGOStop
        '
        Me.PicBGOStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBGOStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBGOStop.Image = Global.LASER_Background.My.Resources.Resources.Stop24
        Me.PicBGOStop.Location = New System.Drawing.Point(249, 14)
        Me.PicBGOStop.Name = "PicBGOStop"
        Me.PicBGOStop.Size = New System.Drawing.Size(24, 24)
        Me.PicBGOStop.TabIndex = 42
        Me.PicBGOStop.TabStop = False
        Me.PicBGOStop.Tag = "Stop"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.PicBGStop)
        Me.MaterialCard1.Controls.Add(Me.tsProBar)
        Me.MaterialCard1.Controls.Add(Me.lblLoad)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(332, 14)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(290, 82)
        Me.MaterialCard1.TabIndex = 74
        '
        'PicBGStop
        '
        Me.PicBGStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBGStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBGStop.Image = Global.LASER_Background.My.Resources.Resources.Stop24
        Me.PicBGStop.Location = New System.Drawing.Point(249, 14)
        Me.PicBGStop.Name = "PicBGStop"
        Me.PicBGStop.Size = New System.Drawing.Size(24, 24)
        Me.PicBGStop.TabIndex = 43
        Me.PicBGStop.TabStop = False
        Me.PicBGStop.Tag = "Stop"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.lblIPAddress)
        Me.GroupBox5.Depth = 0
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(285, 111)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox5.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox5.Size = New System.Drawing.Size(333, 59)
        Me.GroupBox5.TabIndex = 73
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.chkActive)
        Me.GroupBox4.Depth = 0
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 111)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox4.Size = New System.Drawing.Size(260, 59)
        Me.GroupBox4.TabIndex = 72
        '
        'cmdApply
        '
        Me.cmdApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdApply.Depth = 0
        Me.cmdApply.HighEmphasis = True
        Me.cmdApply.Icon = Nothing
        Me.cmdApply.Location = New System.Drawing.Point(555, 691)
        Me.cmdApply.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdApply.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdApply.Size = New System.Drawing.Size(67, 36)
        Me.cmdApply.TabIndex = 38
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdApply.UseAccentColor = False
        Me.cmdApply.UseVisualStyleBackColor = False
        '
        'flpMessage
        '
        Me.flpMessage.AllowDrop = True
        Me.flpMessage.AutoScroll = True
        Me.flpMessage.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.flpMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.flpMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.flpMessage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMessage.Location = New System.Drawing.Point(639, 64)
        Me.flpMessage.Name = "flpMessage"
        Me.flpMessage.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.flpMessage.Size = New System.Drawing.Size(455, 733)
        Me.flpMessage.TabIndex = 0
        Me.flpMessage.WrapContents = False
        '
        'WorkerDatabaseSyncronize
        '
        Me.WorkerDatabaseSyncronize.WorkerReportsProgress = True
        Me.WorkerDatabaseSyncronize.WorkerSupportsCancellation = True
        '
        'FormBGTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 800)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.flpMessage)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBGTasks"
        Me.Text = "LASER System - Background Worker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.MaterialTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.PicBGOStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.PicBGStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ofdDatabase As OpenFileDialog
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents Guna2GroupBox1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtMAdminEmailVerify As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtMAdminPass As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtMAdminEmail As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Guna2GroupBox2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtMApiToken As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtMApiKey As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBackUpDB1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBackUpDB2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBackUpDB3 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextDbServer As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextDbPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents pnlMain As Panel
    Friend WithEvents flpMessage As FlowLayoutPanel
    Friend WithEvents GroupBox5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents GroupBox4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents GroupBox3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents GroupBox2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents GroupBox1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblLoad As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CheckRemoteDb As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents btnAdminEmailVerify As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkMSendEmail As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents lblBalance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmdApply As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tsProBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents lblBGLoad As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tsBGProBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents chkActive As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents cmdBackUpDB1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdBackUpDB2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdBackUpDB3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblIPAddress As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label12 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents ImageList As ImageList
    Friend WithEvents WorkerDatabaseSyncronize As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicBGOStop As PictureBox
    Friend WithEvents PicBGStop As PictureBox
    Friend WithEvents BtnOpenAdvDB As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TextPort As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextHost As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextDbPort As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextDbUserName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextDbName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents RadioDeactivate As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents RadioActivate As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextRemoteDbName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextRemoteDbUserName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextRemoteDbPort As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextRemoteDbPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TextRemoteDbServer As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents ButtonRunFullSynchronization As MaterialSkin.Controls.MaterialButton
End Class
