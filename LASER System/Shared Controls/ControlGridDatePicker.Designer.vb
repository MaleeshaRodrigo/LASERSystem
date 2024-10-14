<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlGridDatePicker
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
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'DatePicker
        '
        Me.DatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.DatePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.Location = New System.Drawing.Point(0, 0)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(262, 26)
        Me.DatePicker.TabIndex = 0
        '
        'ControlGridDatePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DatePicker)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MaximumSize = New System.Drawing.Size(9999, 27)
        Me.Name = "ControlGridDatePicker"
        Me.Size = New System.Drawing.Size(262, 27)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatePicker As DateTimePicker
End Class
