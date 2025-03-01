<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlGridRemarks
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
        Me.ControlRemarks = New LASER_System.ControlRemarks()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ControlRemarks
        '
        Me.ControlRemarks.ControlRemarkOption = LASER_System.ControlRemarksOption.RemarksByCustomer
        Me.ControlRemarks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlRemarks.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlRemarks.Location = New System.Drawing.Point(0, 34)
        Me.ControlRemarks.Name = "ControlRemarks"
        Me.ControlRemarks.Size = New System.Drawing.Size(502, 199)
        Me.ControlRemarks.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClose.Location = New System.Drawing.Point(432, 3)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(67, 25)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ControlGridRemarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ControlRemarks)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlGridRemarks"
        Me.Size = New System.Drawing.Size(502, 233)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlRemarks As ControlRemarks
    Friend WithEvents ButtonClose As Button
End Class
