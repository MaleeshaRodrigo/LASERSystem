<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDropDown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lst = New System.Windows.Forms.ListBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lst
        '
        Me.lst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst.FormattingEnabled = True
        Me.lst.ItemHeight = 14
        Me.lst.Location = New System.Drawing.Point(0, 0)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(248, 129)
        Me.lst.TabIndex = 0
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(0, 106)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(128, 22)
        Me.txtType.TabIndex = 1
        '
        'frmSearchDropDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 129)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.lst)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSearchDropDown"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst As ListBox
    Friend WithEvents txtType As TextBox
End Class
