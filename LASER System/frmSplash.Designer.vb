<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        Me.imgSplash = New System.Windows.Forms.PictureBox()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLoad = New System.Windows.Forms.Label()
        CType(Me.imgSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgSplash
        '
        Me.imgSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgSplash.Image = CType(resources.GetObject("imgSplash.Image"), System.Drawing.Image)
        Me.imgSplash.Location = New System.Drawing.Point(0, 0)
        Me.imgSplash.Name = "imgSplash"
        Me.imgSplash.Size = New System.Drawing.Size(498, 305)
        Me.imgSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgSplash.TabIndex = 0
        Me.imgSplash.TabStop = False
        '
        'tmrSplash
        '
        Me.tmrSplash.Interval = 10
        '
        'LoadingBar
        '
        Me.LoadingBar.BackColor = System.Drawing.SystemColors.Control
        Me.LoadingBar.ForeColor = System.Drawing.Color.Lime
        Me.LoadingBar.Location = New System.Drawing.Point(0, 373)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(498, 15)
        Me.LoadingBar.Step = 1
        Me.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingBar.TabIndex = 1
        Me.LoadingBar.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 307)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(132, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "This Product is licensed to LASER Electronics"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(132, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Copyright © 2018 - 2020 All Right Reserved"
        '
        'txtLoad
        '
        Me.txtLoad.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtLoad.ForeColor = System.Drawing.Color.Red
        Me.txtLoad.Location = New System.Drawing.Point(132, 353)
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(366, 17)
        Me.txtLoad.TabIndex = 5
        Me.txtLoad.Text = "Please Wait..."
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(497, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLoad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.imgSplash)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.imgSplash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgSplash As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSplash As System.Windows.Forms.Timer
    Friend WithEvents LoadingBar As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLoad As System.Windows.Forms.Label
End Class
