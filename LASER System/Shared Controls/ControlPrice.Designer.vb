<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrice
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
        Me.Label = New System.Windows.Forms.Label()
        Me.TextPrice = New System.Windows.Forms.NumericUpDown()
        Me.Panel = New System.Windows.Forms.Panel()
        CType(Me.TextPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(24, 22)
        Me.Label.TabIndex = 93
        Me.Label.Text = "Rs."
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextPrice
        '
        Me.TextPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPrice.DecimalPlaces = 2
        Me.TextPrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TextPrice.Location = New System.Drawing.Point(26, 0)
        Me.TextPrice.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(54, 22)
        Me.TextPrice.TabIndex = 94
        Me.TextPrice.ThousandsSeparator = True
        '
        'Panel
        '
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(81, 22)
        Me.Panel.TabIndex = 95
        '
        'ControlPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextPrice)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(76, 22)
        Me.Name = "ControlPrice"
        Me.Size = New System.Drawing.Size(81, 22)
        CType(Me.TextPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents TextPrice As NumericUpDown
    Friend WithEvents Panel As Panel
End Class
