<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tctrlLogin = New System.Windows.Forms.TabControl()
        Me.PasswordLog = New System.Windows.Forms.TabPage()
        Me.cmdLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbUserName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.OTPLog = New System.Windows.Forms.TabPage()
        Me.cmdGetOTP = New System.Windows.Forms.Button()
        Me.cmdOTPLogin = New System.Windows.Forms.Button()
        Me.txtOTPCode = New System.Windows.Forms.TextBox()
        Me.txtOTPUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.pnlWrongPrompt = New System.Windows.Forms.Panel()
        Me.lblWrongTime = New System.Windows.Forms.Label()
        Me.tmrWrongLoginTime = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New Guna.UI2.WinForms.Guna2Button()
        Me.tctrlLogin.SuspendLayout()
        Me.PasswordLog.SuspendLayout()
        Me.OTPLog.SuspendLayout()
        Me.pnlWrongPrompt.SuspendLayout()
        Me.SuspendLayout()
        '
        'tctrlLogin
        '
        Me.tctrlLogin.Controls.Add(Me.PasswordLog)
        Me.tctrlLogin.Controls.Add(Me.OTPLog)
        Me.tctrlLogin.Location = New System.Drawing.Point(22, 59)
        Me.tctrlLogin.Name = "tctrlLogin"
        Me.tctrlLogin.SelectedIndex = 0
        Me.tctrlLogin.Size = New System.Drawing.Size(300, 227)
        Me.tctrlLogin.TabIndex = 15
        '
        'PasswordLog
        '
        Me.PasswordLog.BackColor = System.Drawing.Color.Black
        Me.PasswordLog.Controls.Add(Me.cmdLogin)
        Me.PasswordLog.Controls.Add(Me.txtPassword)
        Me.PasswordLog.Controls.Add(Me.cmbUserName)
        Me.PasswordLog.Controls.Add(Me.lblPassword)
        Me.PasswordLog.Controls.Add(Me.lblUserName)
        Me.PasswordLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PasswordLog.Location = New System.Drawing.Point(4, 23)
        Me.PasswordLog.Name = "PasswordLog"
        Me.PasswordLog.Padding = New System.Windows.Forms.Padding(3)
        Me.PasswordLog.Size = New System.Drawing.Size(292, 200)
        Me.PasswordLog.TabIndex = 0
        Me.PasswordLog.Text = "Password Login"
        '
        'cmdLogin
        '
        Me.cmdLogin.Animated = True
        Me.cmdLogin.AutoRoundedCorners = True
        Me.cmdLogin.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogin.BorderRadius = 19
        Me.cmdLogin.CheckedState.Parent = Me.cmdLogin
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.CustomImages.Parent = Me.cmdLogin
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.HoverState.FillColor = System.Drawing.Color.DodgerBlue
        Me.cmdLogin.HoverState.Parent = Me.cmdLogin
        Me.cmdLogin.Location = New System.Drawing.Point(15, 141)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.ShadowDecoration.Parent = Me.cmdLogin
        Me.cmdLogin.Size = New System.Drawing.Size(257, 40)
        Me.cmdLogin.TabIndex = 2
        Me.cmdLogin.Text = "Login"
        '
        'txtPassword
        '
        Me.txtPassword.AutoRoundedCorners = True
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(24, 102)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(237, 22)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbUserName
        '
        Me.cmbUserName.AutoRoundedCorners = True
        Me.cmbUserName.BackColor = System.Drawing.Color.Transparent
        Me.cmbUserName.BorderColor = System.Drawing.Color.LightGray
        Me.cmbUserName.BorderRadius = 10
        Me.cmbUserName.BorderThickness = 2
        Me.cmbUserName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserName.FocusedColor = System.Drawing.Color.Empty
        Me.cmbUserName.FocusedState.Parent = Me.cmbUserName
        Me.cmbUserName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbUserName.ForeColor = System.Drawing.Color.Black
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.HoverState.Parent = Me.cmbUserName
        Me.cmbUserName.ItemHeight = 16
        Me.cmbUserName.ItemsAppearance.Parent = Me.cmbUserName
        Me.cmbUserName.Location = New System.Drawing.Point(24, 40)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.ShadowDecoration.Parent = Me.cmbUserName
        Me.cmbUserName.Size = New System.Drawing.Size(237, 22)
        Me.cmbUserName.TabIndex = 0
        Me.cmbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmbUserName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(20, 74)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(79, 19)
        Me.lblPassword.TabIndex = 34
        Me.lblPassword.Text = "Password :"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(20, 14)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(89, 19)
        Me.lblUserName.TabIndex = 33
        Me.lblUserName.Text = "User Name :"
        '
        'OTPLog
        '
        Me.OTPLog.BackColor = System.Drawing.Color.Black
        Me.OTPLog.Controls.Add(Me.cmdGetOTP)
        Me.OTPLog.Controls.Add(Me.cmdOTPLogin)
        Me.OTPLog.Controls.Add(Me.txtOTPCode)
        Me.OTPLog.Controls.Add(Me.txtOTPUserName)
        Me.OTPLog.Controls.Add(Me.Label1)
        Me.OTPLog.Controls.Add(Me.Label2)
        Me.OTPLog.Location = New System.Drawing.Point(4, 23)
        Me.OTPLog.Name = "OTPLog"
        Me.OTPLog.Padding = New System.Windows.Forms.Padding(3)
        Me.OTPLog.Size = New System.Drawing.Size(292, 200)
        Me.OTPLog.TabIndex = 1
        Me.OTPLog.Text = "OTP Login"
        '
        'cmdGetOTP
        '
        Me.cmdGetOTP.AutoEllipsis = True
        Me.cmdGetOTP.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGetOTP.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.cmdGetOTP.ForeColor = System.Drawing.Color.Black
        Me.cmdGetOTP.Location = New System.Drawing.Point(155, 96)
        Me.cmdGetOTP.Name = "cmdGetOTP"
        Me.cmdGetOTP.Size = New System.Drawing.Size(107, 30)
        Me.cmdGetOTP.TabIndex = 6
        Me.cmdGetOTP.Text = "Get OTP Code"
        Me.cmdGetOTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdGetOTP.UseVisualStyleBackColor = False
        '
        'cmdOTPLogin
        '
        Me.cmdOTPLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdOTPLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOTPLogin.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdOTPLogin.Location = New System.Drawing.Point(24, 144)
        Me.cmdOTPLogin.Name = "cmdOTPLogin"
        Me.cmdOTPLogin.Size = New System.Drawing.Size(237, 38)
        Me.cmdOTPLogin.TabIndex = 7
        Me.cmdOTPLogin.Text = "Login"
        Me.cmdOTPLogin.UseVisualStyleBackColor = False
        '
        'txtOTPCode
        '
        Me.txtOTPCode.BackColor = System.Drawing.Color.Black
        Me.txtOTPCode.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTPCode.ForeColor = System.Drawing.Color.White
        Me.txtOTPCode.Location = New System.Drawing.Point(24, 96)
        Me.txtOTPCode.Name = "txtOTPCode"
        Me.txtOTPCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOTPCode.Size = New System.Drawing.Size(125, 31)
        Me.txtOTPCode.TabIndex = 5
        '
        'txtOTPUserName
        '
        Me.txtOTPUserName.BackColor = System.Drawing.Color.Black
        Me.txtOTPUserName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTPUserName.ForeColor = System.Drawing.Color.White
        Me.txtOTPUserName.Location = New System.Drawing.Point(24, 36)
        Me.txtOTPUserName.Name = "txtOTPUserName"
        Me.txtOTPUserName.Size = New System.Drawing.Size(237, 31)
        Me.txtOTPUserName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "OTP Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "User Name :"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.ForeColor = System.Drawing.Color.LightGray
        Me.lblVersion.Location = New System.Drawing.Point(94, 9)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(145, 32)
        Me.lblVersion.TabIndex = 39
        Me.lblVersion.Text = "User Login"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.BackColor = System.Drawing.Color.Transparent
        Me.lblOR.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOR.ForeColor = System.Drawing.Color.White
        Me.lblOR.Location = New System.Drawing.Point(136, 289)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(52, 26)
        Me.lblOR.TabIndex = 42
        Me.lblOR.Text = "- or -"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegister.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.Aqua
        Me.lblRegister.Location = New System.Drawing.Point(123, 315)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(80, 26)
        Me.lblRegister.TabIndex = 41
        Me.lblRegister.Text = "Register"
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
        Me.lblWrongTime.BackColor = System.Drawing.Color.Transparent
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
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.CheckedState.Parent = Me.cmdClose
        Me.cmdClose.CustomImages.Parent = Me.cmdClose
        Me.cmdClose.FillColor = System.Drawing.Color.Transparent
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.HoverState.Parent = Me.cmdClose
        Me.cmdClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdClose.ImageOffset = New System.Drawing.Point(0, -2)
        Me.cmdClose.Location = New System.Drawing.Point(313, 12)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.PressedColor = System.Drawing.Color.Transparent
        Me.cmdClose.ShadowDecoration.Parent = Me.cmdClose
        Me.cmdClose.Size = New System.Drawing.Size(25, 25)
        Me.cmdClose.TabIndex = 44
        Me.cmdClose.UseTransparentBackground = True
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
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.pnlWrongPrompt)
        Me.Controls.Add(Me.lblOR)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.tctrlLogin)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - User Login"
        Me.tctrlLogin.ResumeLayout(False)
        Me.PasswordLog.ResumeLayout(False)
        Me.PasswordLog.PerformLayout()
        Me.OTPLog.ResumeLayout(False)
        Me.OTPLog.PerformLayout()
        Me.pnlWrongPrompt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tctrlLogin As TabControl
    Friend WithEvents PasswordLog As TabPage
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents OTPLog As TabPage
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblOR As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents cmdGetOTP As Button
    Friend WithEvents cmdOTPLogin As Button
    Friend WithEvents txtOTPCode As TextBox
    Friend WithEvents txtOTPUserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlWrongPrompt As Panel
    Friend WithEvents lblWrongTime As Label
    Friend WithEvents tmrWrongLoginTime As Timer
    Friend WithEvents cmbUserName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmdLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdClose As Guna.UI2.WinForms.Guna2Button
End Class
