<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRepairPrice_DateInfo
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
        Me.boxRepair = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtRepDate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtRepPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxRepair.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxRepair
        '
        Me.boxRepair.Controls.Add(Me.Label35)
        Me.boxRepair.Controls.Add(Me.txtRepDate)
        Me.boxRepair.Controls.Add(Me.Label27)
        Me.boxRepair.Controls.Add(Me.txtRepPrice)
        Me.boxRepair.Controls.Add(Me.Label3)
        Me.boxRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxRepair.Location = New System.Drawing.Point(0, 0)
        Me.boxRepair.Name = "boxRepair"
        Me.boxRepair.Size = New System.Drawing.Size(270, 80)
        Me.boxRepair.TabIndex = 36
        Me.boxRepair.TabStop = False
        Me.boxRepair.Text = "Repair Info"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(59, 21)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 22)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "Rs."
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRepDate
        '
        Me.txtRepDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtRepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRepDate.Location = New System.Drawing.Point(100, 49)
        Me.txtRepDate.Name = "txtRepDate"
        Me.txtRepDate.Size = New System.Drawing.Size(162, 22)
        Me.txtRepDate.TabIndex = 29
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 51)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 14)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Repaired Date:"
        '
        'txtRepPrice
        '
        Me.txtRepPrice.Location = New System.Drawing.Point(84, 21)
        Me.txtRepPrice.Name = "txtRepPrice"
        Me.txtRepPrice.Size = New System.Drawing.Size(73, 22)
        Me.txtRepPrice.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Charge:"
        '
        'ControlRepairPrice_DateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.boxRepair)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ControlRepairPrice_DateInfo"
        Me.Size = New System.Drawing.Size(270, 80)
        Me.boxRepair.ResumeLayout(False)
        Me.boxRepair.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxRepair As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtRepDate As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents txtRepPrice As TextBox
    Friend WithEvents Label3 As Label
End Class
