<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDeliverInfo
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
        Me.boxDeliver = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDPaidPrice = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDNo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.boxDeliver.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxDeliver
        '
        Me.boxDeliver.BackColor = System.Drawing.SystemColors.Control
        Me.boxDeliver.Controls.Add(Me.Label33)
        Me.boxDeliver.Controls.Add(Me.txtDPaidPrice)
        Me.boxDeliver.Controls.Add(Me.Label21)
        Me.boxDeliver.Controls.Add(Me.txtDDate)
        Me.boxDeliver.Controls.Add(Me.txtDNo)
        Me.boxDeliver.Controls.Add(Me.Label31)
        Me.boxDeliver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxDeliver.Location = New System.Drawing.Point(0, 0)
        Me.boxDeliver.Name = "boxDeliver"
        Me.boxDeliver.Size = New System.Drawing.Size(335, 88)
        Me.boxDeliver.TabIndex = 60
        Me.boxDeliver.TabStop = False
        Me.boxDeliver.Text = "Delivered Info"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(79, 49)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 22)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "Rs."
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDPaidPrice
        '
        Me.txtDPaidPrice.Enabled = False
        Me.txtDPaidPrice.Location = New System.Drawing.Point(104, 49)
        Me.txtDPaidPrice.Name = "txtDPaidPrice"
        Me.txtDPaidPrice.Size = New System.Drawing.Size(89, 22)
        Me.txtDPaidPrice.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 14)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Paid Price:"
        '
        'txtDDate
        '
        Me.txtDDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtDDate.Enabled = False
        Me.txtDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDDate.Location = New System.Drawing.Point(104, 21)
        Me.txtDDate.Name = "txtDDate"
        Me.txtDDate.Size = New System.Drawing.Size(163, 22)
        Me.txtDDate.TabIndex = 30
        '
        'txtDNo
        '
        Me.txtDNo.Enabled = False
        Me.txtDNo.Location = New System.Drawing.Point(269, 49)
        Me.txtDNo.Name = "txtDNo"
        Me.txtDNo.Size = New System.Drawing.Size(53, 22)
        Me.txtDNo.TabIndex = 7
        Me.txtDNo.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 14)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Delivered Date:"
        '
        'ControlDeliverInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.boxDeliver)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlDeliverInfo"
        Me.Size = New System.Drawing.Size(335, 88)
        Me.boxDeliver.ResumeLayout(False)
        Me.boxDeliver.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxDeliver As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtDPaidPrice As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDDate As DateTimePicker
    Friend WithEvents txtDNo As TextBox
    Friend WithEvents Label31 As Label
End Class
