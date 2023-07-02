<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBGTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBGTasks))
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.ofdDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblLoad = New MaterialSkin.Controls.MaterialLabel()
        Me.cmdDBLocation = New MaterialSkin.Controls.MaterialButton()
        Me.chkOnlineDB = New MaterialSkin.Controls.MaterialCheckbox()
        Me.txtOUser = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtOPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Guna2GroupBox1 = New MaterialSkin.Controls.MaterialCard()
        Me.txtMAdminEmailVerify = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnAdminEmailVerify = New MaterialSkin.Controls.MaterialButton()
        Me.txtMAdminPass = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtMAdminEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.chkMSendEmail = New MaterialSkin.Controls.MaterialCheckbox()
        Me.Guna2GroupBox2 = New MaterialSkin.Controls.MaterialCard()
        Me.lblBalance = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbMBgSMS = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtMApiToken = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtMApiKey = New MaterialSkin.Controls.MaterialTextBox2()
        Me.tsProBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.lblBGLoad = New MaterialSkin.Controls.MaterialLabel()
        Me.tsBGProBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.txtOPath = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBackUpDB1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBackUpDB2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBackUpDB3 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.chkActive = New MaterialSkin.Controls.MaterialCheckbox()
        Me.txtDBLocation = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cmdBackUpDB1 = New MaterialSkin.Controls.MaterialButton()
        Me.cmdBackUpDB2 = New MaterialSkin.Controls.MaterialButton()
        Me.cmdBackUpDB3 = New MaterialSkin.Controls.MaterialButton()
        Me.lblIPAddress = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbDbProvider = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtDbPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label12 = New MaterialSkin.Controls.MaterialLabel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.GridActivity = New System.Windows.Forms.DataGridView()
        Me.BtnOpenAdvDB = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New MaterialSkin.Controls.MaterialCard()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New MaterialSkin.Controls.MaterialCard()
        Me.TxtOToken = New MaterialSkin.Controls.MaterialTextBox2()
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
        Me.bgworkerOnline = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.GridActivity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmdDBLocation
        '
        Me.cmdDBLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDBLocation.AutoSize = False
        Me.cmdDBLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdDBLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDBLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdDBLocation.Depth = 0
        Me.cmdDBLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDBLocation.HighEmphasis = True
        Me.cmdDBLocation.Icon = Nothing
        Me.cmdDBLocation.Location = New System.Drawing.Point(523, 74)
        Me.cmdDBLocation.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdDBLocation.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdDBLocation.Name = "cmdDBLocation"
        Me.cmdDBLocation.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdDBLocation.Size = New System.Drawing.Size(49, 48)
        Me.cmdDBLocation.TabIndex = 25
        Me.cmdDBLocation.Text = "..."
        Me.cmdDBLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdDBLocation.UseAccentColor = False
        Me.cmdDBLocation.UseVisualStyleBackColor = False
        '
        'chkOnlineDB
        '
        Me.chkOnlineDB.AutoSize = True
        Me.chkOnlineDB.Depth = 0
        Me.chkOnlineDB.ForeColor = System.Drawing.Color.White
        Me.chkOnlineDB.Location = New System.Drawing.Point(14, 14)
        Me.chkOnlineDB.Margin = New System.Windows.Forms.Padding(0)
        Me.chkOnlineDB.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkOnlineDB.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkOnlineDB.Name = "chkOnlineDB"
        Me.chkOnlineDB.ReadOnly = False
        Me.chkOnlineDB.Ripple = True
        Me.chkOnlineDB.Size = New System.Drawing.Size(199, 37)
        Me.chkOnlineDB.TabIndex = 28
        Me.chkOnlineDB.Text = "Active Online Database"
        Me.chkOnlineDB.UseVisualStyleBackColor = True
        '
        'txtOUser
        '
        Me.txtOUser.AnimateReadOnly = False
        Me.txtOUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtOUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtOUser.Depth = 0
        Me.txtOUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtOUser.HideSelection = True
        Me.txtOUser.Hint = "User Name"
        Me.txtOUser.LeadingIcon = Nothing
        Me.txtOUser.Location = New System.Drawing.Point(17, 68)
        Me.txtOUser.MaxLength = 32767
        Me.txtOUser.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOUser.Name = "txtOUser"
        Me.txtOUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOUser.PrefixSuffixText = Nothing
        Me.txtOUser.ReadOnly = False
        Me.txtOUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOUser.SelectedText = ""
        Me.txtOUser.SelectionLength = 0
        Me.txtOUser.SelectionStart = 0
        Me.txtOUser.ShortcutsEnabled = True
        Me.txtOUser.Size = New System.Drawing.Size(314, 48)
        Me.txtOUser.TabIndex = 30
        Me.txtOUser.TabStop = False
        Me.txtOUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtOUser.TrailingIcon = Nothing
        Me.txtOUser.UseSystemPasswordChar = False
        '
        'txtOPassword
        '
        Me.txtOPassword.AnimateReadOnly = False
        Me.txtOPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtOPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtOPassword.Depth = 0
        Me.txtOPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtOPassword.HideSelection = True
        Me.txtOPassword.Hint = "Password"
        Me.txtOPassword.LeadingIcon = Nothing
        Me.txtOPassword.Location = New System.Drawing.Point(337, 68)
        Me.txtOPassword.MaxLength = 32767
        Me.txtOPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOPassword.Name = "txtOPassword"
        Me.txtOPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOPassword.PrefixSuffixText = Nothing
        Me.txtOPassword.ReadOnly = False
        Me.txtOPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOPassword.SelectedText = ""
        Me.txtOPassword.SelectionLength = 0
        Me.txtOPassword.SelectionStart = 0
        Me.txtOPassword.ShortcutsEnabled = True
        Me.txtOPassword.Size = New System.Drawing.Size(236, 48)
        Me.txtOPassword.TabIndex = 32
        Me.txtOPassword.TabStop = False
        Me.txtOPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtOPassword.TrailingIcon = Nothing
        Me.txtOPassword.UseSystemPasswordChar = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(590, 230)
        Me.Guna2GroupBox1.TabIndex = 35
        Me.Guna2GroupBox1.Text = "Emails"
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
        Me.txtMAdminEmailVerify.Location = New System.Drawing.Point(17, 109)
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
        Me.btnAdminEmailVerify.Location = New System.Drawing.Point(248, 109)
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
        Me.txtMAdminPass.Location = New System.Drawing.Point(308, 55)
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
        Me.txtMAdminEmail.Location = New System.Drawing.Point(17, 55)
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
        Me.Guna2GroupBox2.Controls.Add(Me.lblBalance)
        Me.Guna2GroupBox2.Controls.Add(Me.cmbMBgSMS)
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
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(590, 230)
        Me.Guna2GroupBox2.TabIndex = 36
        Me.Guna2GroupBox2.Text = "SMS"
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.Color.Lime
        Me.lblBalance.Depth = 0
        Me.lblBalance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBalance.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(14, 183)
        Me.lblBalance.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(562, 33)
        Me.lblBalance.TabIndex = 59
        Me.lblBalance.Text = "Balance: Rs. ###"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMBgSMS
        '
        Me.cmbMBgSMS.AutoResize = False
        Me.cmbMBgSMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMBgSMS.Depth = 0
        Me.cmbMBgSMS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbMBgSMS.DropDownHeight = 174
        Me.cmbMBgSMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMBgSMS.DropDownWidth = 121
        Me.cmbMBgSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbMBgSMS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbMBgSMS.FormattingEnabled = True
        Me.cmbMBgSMS.Hint = "Option"
        Me.cmbMBgSMS.IntegralHeight = False
        Me.cmbMBgSMS.ItemHeight = 43
        Me.cmbMBgSMS.Items.AddRange(New Object() {"OFF", "Only Getting Notification", "Automatically Send SMS"})
        Me.cmbMBgSMS.Location = New System.Drawing.Point(17, 17)
        Me.cmbMBgSMS.MaxDropDownItems = 4
        Me.cmbMBgSMS.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbMBgSMS.Name = "cmbMBgSMS"
        Me.cmbMBgSMS.Size = New System.Drawing.Size(378, 49)
        Me.cmbMBgSMS.StartIndex = 0
        Me.cmbMBgSMS.TabIndex = 30
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
        Me.txtMApiToken.Location = New System.Drawing.Point(17, 72)
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
        Me.txtMApiToken.Size = New System.Drawing.Size(556, 48)
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
        Me.txtMApiKey.Location = New System.Drawing.Point(17, 126)
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
        Me.txtMApiKey.Size = New System.Drawing.Size(556, 48)
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
        'txtOPath
        '
        Me.txtOPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOPath.AnimateReadOnly = False
        Me.txtOPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtOPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtOPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOPath.Depth = 0
        Me.txtOPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOPath.HelperText = "Make sure add https:// or http:// to the begining of the path"
        Me.txtOPath.HideSelection = True
        Me.txtOPath.Hint = "API Path"
        Me.txtOPath.LeadingIcon = Nothing
        Me.txtOPath.Location = New System.Drawing.Point(227, 14)
        Me.txtOPath.MaxLength = 32767
        Me.txtOPath.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOPath.Name = "txtOPath"
        Me.txtOPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOPath.PrefixSuffixText = Nothing
        Me.txtOPath.ReadOnly = False
        Me.txtOPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOPath.SelectedText = ""
        Me.txtOPath.SelectionLength = 0
        Me.txtOPath.SelectionStart = 0
        Me.txtOPath.ShortcutsEnabled = True
        Me.txtOPath.Size = New System.Drawing.Size(346, 48)
        Me.txtOPath.TabIndex = 45
        Me.txtOPath.TabStop = False
        Me.txtOPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtOPath.TrailingIcon = Nothing
        Me.txtOPath.UseSystemPasswordChar = False
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
        'txtDBLocation
        '
        Me.txtDBLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBLocation.AnimateReadOnly = False
        Me.txtDBLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtDBLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDBLocation.Depth = 0
        Me.txtDBLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDBLocation.HideSelection = True
        Me.txtDBLocation.Hint = "Database Location"
        Me.txtDBLocation.LeadingIcon = Nothing
        Me.txtDBLocation.Location = New System.Drawing.Point(8, 72)
        Me.txtDBLocation.MaxLength = 32767
        Me.txtDBLocation.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDBLocation.Name = "txtDBLocation"
        Me.txtDBLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDBLocation.PrefixSuffixText = Nothing
        Me.txtDBLocation.ReadOnly = False
        Me.txtDBLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBLocation.SelectedText = ""
        Me.txtDBLocation.SelectionLength = 0
        Me.txtDBLocation.SelectionStart = 0
        Me.txtDBLocation.ShortcutsEnabled = True
        Me.txtDBLocation.Size = New System.Drawing.Size(505, 48)
        Me.txtDBLocation.TabIndex = 0
        Me.txtDBLocation.TabStop = False
        Me.txtDBLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDBLocation.TrailingIcon = Nothing
        Me.txtDBLocation.UseSystemPasswordChar = False
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
        'cmbDbProvider
        '
        Me.cmbDbProvider.AutoResize = False
        Me.cmbDbProvider.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDbProvider.Depth = 0
        Me.cmbDbProvider.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbDbProvider.DropDownHeight = 174
        Me.cmbDbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDbProvider.DropDownWidth = 121
        Me.cmbDbProvider.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDbProvider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDbProvider.FormattingEnabled = True
        Me.cmbDbProvider.Hint = "Database Provider"
        Me.cmbDbProvider.IntegralHeight = False
        Me.cmbDbProvider.ItemHeight = 43
        Me.cmbDbProvider.Items.AddRange(New Object() {"Microsoft.ACE.OLEDB.12.0"})
        Me.cmbDbProvider.Location = New System.Drawing.Point(8, 17)
        Me.cmbDbProvider.MaxDropDownItems = 4
        Me.cmbDbProvider.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbDbProvider.Name = "cmbDbProvider"
        Me.cmbDbProvider.Size = New System.Drawing.Size(372, 49)
        Me.cmbDbProvider.StartIndex = 0
        Me.cmbDbProvider.TabIndex = 66
        '
        'txtDbPassword
        '
        Me.txtDbPassword.AnimateReadOnly = False
        Me.txtDbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtDbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDbPassword.Depth = 0
        Me.txtDbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDbPassword.HideSelection = True
        Me.txtDbPassword.Hint = "Database Password"
        Me.txtDbPassword.LeadingIcon = Nothing
        Me.txtDbPassword.Location = New System.Drawing.Point(8, 126)
        Me.txtDbPassword.MaxLength = 32767
        Me.txtDbPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDbPassword.PrefixSuffixText = Nothing
        Me.txtDbPassword.ReadOnly = False
        Me.txtDbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDbPassword.SelectedText = ""
        Me.txtDbPassword.SelectionLength = 0
        Me.txtDbPassword.SelectionStart = 0
        Me.txtDbPassword.ShortcutsEnabled = True
        Me.txtDbPassword.Size = New System.Drawing.Size(372, 48)
        Me.txtDbPassword.TabIndex = 67
        Me.txtDbPassword.TabStop = False
        Me.txtDbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDbPassword.TrailingIcon = Nothing
        Me.txtDbPassword.UseSystemPasswordChar = False
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
        Me.pnlMain.Controls.Add(Me.GridActivity)
        Me.pnlMain.Controls.Add(Me.BtnOpenAdvDB)
        Me.pnlMain.Controls.Add(Me.MaterialTabControl)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlMain.Controls.Add(Me.GroupBox5)
        Me.pnlMain.Controls.Add(Me.GroupBox4)
        Me.pnlMain.Controls.Add(Me.cmdApply)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(3, 64)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(636, 607)
        Me.pnlMain.TabIndex = 1
        '
        'GridActivity
        '
        Me.GridActivity.AllowUserToAddRows = False
        Me.GridActivity.AllowUserToDeleteRows = False
        Me.GridActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridActivity.Location = New System.Drawing.Point(14, 516)
        Me.GridActivity.Name = "GridActivity"
        Me.GridActivity.ReadOnly = True
        Me.GridActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridActivity.Size = New System.Drawing.Size(602, 71)
        Me.GridActivity.TabIndex = 79
        '
        'BtnOpenAdvDB
        '
        Me.BtnOpenAdvDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenAdvDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnOpenAdvDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnOpenAdvDB.Depth = 0
        Me.BtnOpenAdvDB.HighEmphasis = True
        Me.BtnOpenAdvDB.Icon = Nothing
        Me.BtnOpenAdvDB.Location = New System.Drawing.Point(321, 471)
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
        Me.MaterialTabControl.Size = New System.Drawing.Size(604, 279)
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
        Me.TabPage1.Size = New System.Drawing.Size(596, 236)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Local Database"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmdDBLocation)
        Me.GroupBox1.Controls.Add(Me.txtDbPassword)
        Me.GroupBox1.Controls.Add(Me.cmbDbProvider)
        Me.GroupBox1.Controls.Add(Me.txtDBLocation)
        Me.GroupBox1.Depth = 0
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox1.Size = New System.Drawing.Size(590, 230)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.Text = "Local Database Info"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.ImageKey = "internet.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(596, 236)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Online Database"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TxtOToken)
        Me.GroupBox3.Controls.Add(Me.chkOnlineDB)
        Me.GroupBox3.Controls.Add(Me.txtOUser)
        Me.GroupBox3.Controls.Add(Me.txtOPassword)
        Me.GroupBox3.Controls.Add(Me.txtOPath)
        Me.GroupBox3.Depth = 0
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(14)
        Me.GroupBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(14)
        Me.GroupBox3.Size = New System.Drawing.Size(590, 230)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.Text = "Online Database Info"
        '
        'TxtOToken
        '
        Me.TxtOToken.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOToken.AnimateReadOnly = False
        Me.TxtOToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxtOToken.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtOToken.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOToken.Depth = 0
        Me.TxtOToken.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOToken.HideSelection = True
        Me.TxtOToken.Hint = "API Token"
        Me.TxtOToken.LeadingIcon = Nothing
        Me.TxtOToken.Location = New System.Drawing.Point(17, 122)
        Me.TxtOToken.MaxLength = 32767
        Me.TxtOToken.MouseState = MaterialSkin.MouseState.OUT
        Me.TxtOToken.Name = "TxtOToken"
        Me.TxtOToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOToken.PrefixSuffixText = Nothing
        Me.TxtOToken.ReadOnly = False
        Me.TxtOToken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtOToken.SelectedText = ""
        Me.TxtOToken.SelectionLength = 0
        Me.TxtOToken.SelectionStart = 0
        Me.TxtOToken.ShortcutsEnabled = True
        Me.TxtOToken.Size = New System.Drawing.Size(314, 48)
        Me.TxtOToken.TabIndex = 46
        Me.TxtOToken.TabStop = False
        Me.TxtOToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtOToken.TrailingIcon = Nothing
        Me.TxtOToken.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.ImageKey = "backup.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(596, 236)
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
        Me.GroupBox2.Size = New System.Drawing.Size(590, 230)
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
        Me.TabPage4.Size = New System.Drawing.Size(596, 236)
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
        Me.TabPage5.Size = New System.Drawing.Size(596, 236)
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
        Me.cmdApply.Location = New System.Drawing.Point(547, 471)
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
        Me.flpMessage.Size = New System.Drawing.Size(455, 607)
        Me.flpMessage.TabIndex = 0
        Me.flpMessage.WrapContents = False
        '
        'bgworkerOnline
        '
        Me.bgworkerOnline.WorkerReportsProgress = True
        Me.bgworkerOnline.WorkerSupportsCancellation = True
        '
        'frmBGTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 674)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.flpMessage)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBGTasks"
        Me.Text = "LASER System - Background Worker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.GridActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents txtOUser As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtOPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Guna2GroupBox1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtMAdminEmailVerify As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtMAdminPass As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtMAdminEmail As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Guna2GroupBox2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtMApiToken As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtMApiKey As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtOPath As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBackUpDB1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBackUpDB2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBackUpDB3 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDBLocation As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDbPassword As MaterialSkin.Controls.MaterialTextBox2
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
    Friend WithEvents cmdDBLocation As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkOnlineDB As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents btnAdminEmailVerify As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkMSendEmail As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents lblBalance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbMBgSMS As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmdApply As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tsProBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents lblBGLoad As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tsBGProBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents chkActive As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents cmdBackUpDB1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdBackUpDB2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdBackUpDB3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblIPAddress As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbDbProvider As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label12 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents ImageList As ImageList
    Friend WithEvents bgworkerOnline As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicBGOStop As PictureBox
    Friend WithEvents PicBGStop As PictureBox
    Friend WithEvents BtnOpenAdvDB As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GridActivity As DataGridView
    Friend WithEvents TxtOToken As MaterialSkin.Controls.MaterialTextBox2
End Class
