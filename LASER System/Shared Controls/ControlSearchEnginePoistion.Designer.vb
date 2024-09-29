<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSearchEnginePoistion
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelPoistion = New System.Windows.Forms.Panel()
        Me.PicturePoistionClose = New System.Windows.Forms.PictureBox()
        Me.LabelPoistion = New System.Windows.Forms.Label()
        Me.PanelPoistion.SuspendLayout()
        CType(Me.PicturePoistionClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPoistion
        '
        Me.PanelPoistion.AutoSize = True
        Me.PanelPoistion.Controls.Add(Me.PicturePoistionClose)
        Me.PanelPoistion.Controls.Add(Me.LabelPoistion)
        Me.PanelPoistion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPoistion.Location = New System.Drawing.Point(0, 0)
        Me.PanelPoistion.Name = "PanelPoistion"
        Me.PanelPoistion.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelPoistion.Size = New System.Drawing.Size(135, 23)
        Me.PanelPoistion.TabIndex = 1
        '
        'PicturePoistionClose
        '
        Me.PicturePoistionClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicturePoistionClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.PicturePoistionClose.Location = New System.Drawing.Point(116, 3)
        Me.PicturePoistionClose.Name = "PicturePoistionClose"
        Me.PicturePoistionClose.Size = New System.Drawing.Size(16, 17)
        Me.PicturePoistionClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicturePoistionClose.TabIndex = 1
        Me.PicturePoistionClose.TabStop = False
        '
        'LabelPoistion
        '
        Me.LabelPoistion.AutoSize = True
        Me.LabelPoistion.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelPoistion.Location = New System.Drawing.Point(3, 3)
        Me.LabelPoistion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelPoistion.Name = "LabelPoistion"
        Me.LabelPoistion.Size = New System.Drawing.Size(70, 14)
        Me.LabelPoistion.TabIndex = 0
        Me.LabelPoistion.Text = "Text1234574"
        '
        'ControlSearchEnginePoistion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.Controls.Add(Me.PanelPoistion)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximumSize = New System.Drawing.Size(0, 23)
        Me.MinimumSize = New System.Drawing.Size(0, 23)
        Me.Name = "ControlSearchEnginePoistion"
        Me.Size = New System.Drawing.Size(135, 23)
        Me.PanelPoistion.ResumeLayout(False)
        Me.PanelPoistion.PerformLayout()
        CType(Me.PicturePoistionClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelPoistion As Panel
    Friend WithEvents PicturePoistionClose As PictureBox
    Friend WithEvents LabelPoistion As Label
End Class
