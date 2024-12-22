<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.ControlLogin.Location = New System.Drawing.Point(22, 55)
        Me.ControlLogin.MaximumSize = New System.Drawing.Size(303, 272)
        Me.ControlLogin.MinimumSize = New System.Drawing.Size(303, 272)
        Me.ControlLogin.Name = "ControlLogin"
        Me.ControlLogin.Size = New System.Drawing.Size(303, 272)
        Me.ControlLogin.TabIndex = 45
        '
        'FormLogin
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
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - User Login"
        Me.pnlWrongPrompt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVersion As Label
    Friend WithEvents pnlWrongPrompt As Panel
    Friend WithEvents lblWrongTime As Label
    Friend WithEvents tmrWrongLoginTime As Timer
    Friend WithEvents cmdClose As Button
    Friend WithEvents ControlLogin As ControlLogin
End Class
