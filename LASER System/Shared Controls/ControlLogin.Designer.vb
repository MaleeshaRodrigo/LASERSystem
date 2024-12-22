<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlLogin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PasswordLog = New System.Windows.Forms.TabPage()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmbUserName = New System.Windows.Forms.ComboBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.OTPLog = New System.Windows.Forms.TabPage()
        Me.cmdGetOTP = New System.Windows.Forms.Button()
        Me.cmdOTPLogin = New System.Windows.Forms.Button()
        Me.txtOTPCode = New System.Windows.Forms.TextBox()
        Me.txtOTPUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProviderPassword = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderOtp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl.SuspendLayout()
        Me.PasswordLog.SuspendLayout()
        Me.OTPLog.SuspendLayout()
        CType(Me.ErrorProviderPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderOtp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PasswordLog)
        Me.TabControl.Controls.Add(Me.OTPLog)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(303, 272)
        Me.TabControl.TabIndex = 16
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
        Me.PasswordLog.Size = New System.Drawing.Size(295, 245)
        Me.PasswordLog.TabIndex = 0
        Me.PasswordLog.Text = "Password Login"
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.cmdLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdLogin.Location = New System.Drawing.Point(6, 187)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(280, 41)
        Me.cmdLogin.TabIndex = 2
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(24, 129)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(237, 22)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbUserName
        '
        Me.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserName.ForeColor = System.Drawing.Color.Black
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.ItemHeight = 14
        Me.cmbUserName.Location = New System.Drawing.Point(24, 50)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Size = New System.Drawing.Size(237, 22)
        Me.cmbUserName.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(20, 101)
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
        Me.lblUserName.Location = New System.Drawing.Point(20, 24)
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
        Me.OTPLog.Size = New System.Drawing.Size(295, 245)
        Me.OTPLog.TabIndex = 1
        Me.OTPLog.Text = "OTP Login"
        '
        'cmdGetOTP
        '
        Me.cmdGetOTP.AutoEllipsis = True
        Me.cmdGetOTP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdGetOTP.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.cmdGetOTP.ForeColor = System.Drawing.Color.Black
        Me.cmdGetOTP.Location = New System.Drawing.Point(155, 131)
        Me.cmdGetOTP.Name = "cmdGetOTP"
        Me.cmdGetOTP.Size = New System.Drawing.Size(96, 31)
        Me.cmdGetOTP.TabIndex = 6
        Me.cmdGetOTP.Text = "Get OTP Code"
        Me.cmdGetOTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdGetOTP.UseVisualStyleBackColor = False
        '
        'cmdOTPLogin
        '
        Me.cmdOTPLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdOTPLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOTPLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdOTPLogin.Location = New System.Drawing.Point(6, 190)
        Me.cmdOTPLogin.Name = "cmdOTPLogin"
        Me.cmdOTPLogin.Size = New System.Drawing.Size(280, 38)
        Me.cmdOTPLogin.TabIndex = 7
        Me.cmdOTPLogin.Text = "Login"
        Me.cmdOTPLogin.UseVisualStyleBackColor = False
        '
        'txtOTPCode
        '
        Me.txtOTPCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtOTPCode.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTPCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOTPCode.Location = New System.Drawing.Point(24, 131)
        Me.txtOTPCode.Name = "txtOTPCode"
        Me.txtOTPCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOTPCode.Size = New System.Drawing.Size(125, 31)
        Me.txtOTPCode.TabIndex = 5
        '
        'txtOTPUserName
        '
        Me.txtOTPUserName.BackColor = System.Drawing.SystemColors.Control
        Me.txtOTPUserName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTPUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOTPUserName.Location = New System.Drawing.Point(24, 41)
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
        Me.Label1.Location = New System.Drawing.Point(20, 104)
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
        'ErrorProviderPassword
        '
        Me.ErrorProviderPassword.ContainerControl = Me
        '
        'ErrorProviderOtp
        '
        Me.ErrorProviderOtp.ContainerControl = Me
        '
        'ControlLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MaximumSize = New System.Drawing.Size(303, 272)
        Me.MinimumSize = New System.Drawing.Size(303, 272)
        Me.Name = "ControlLogin"
        Me.Size = New System.Drawing.Size(303, 272)
        Me.TabControl.ResumeLayout(False)
        Me.PasswordLog.ResumeLayout(False)
        Me.PasswordLog.PerformLayout()
        Me.OTPLog.ResumeLayout(False)
        Me.OTPLog.PerformLayout()
        CType(Me.ErrorProviderPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderOtp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents PasswordLog As TabPage
    Friend WithEvents cmdLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbUserName As ComboBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents OTPLog As TabPage
    Friend WithEvents cmdGetOTP As Button
    Friend WithEvents cmdOTPLogin As Button
    Friend WithEvents txtOTPCode As TextBox
    Friend WithEvents txtOTPUserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProviderPassword As ErrorProvider
    Friend WithEvents ErrorProviderOtp As ErrorProvider
End Class