<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRepairReRepairSelection
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
        Me.ComboReRepNo = New System.Windows.Forms.ComboBox()
        Me.ComboRepNo = New System.Windows.Forms.ComboBox()
        Me.RadioReRepNo = New System.Windows.Forms.RadioButton()
        Me.RadioRepNo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ComboReRepNo
        '
        Me.ComboReRepNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboReRepNo.FormattingEnabled = True
        Me.ComboReRepNo.Location = New System.Drawing.Point(102, 31)
        Me.ComboReRepNo.Name = "ComboReRepNo"
        Me.ComboReRepNo.Size = New System.Drawing.Size(92, 22)
        Me.ComboReRepNo.TabIndex = 10
        '
        'ComboRepNo
        '
        Me.ComboRepNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboRepNo.FormattingEnabled = True
        Me.ComboRepNo.Location = New System.Drawing.Point(102, 3)
        Me.ComboRepNo.Name = "ComboRepNo"
        Me.ComboRepNo.Size = New System.Drawing.Size(92, 22)
        Me.ComboRepNo.TabIndex = 9
        '
        'RadioReRepNo
        '
        Me.RadioReRepNo.AutoSize = True
        Me.RadioReRepNo.Location = New System.Drawing.Point(3, 33)
        Me.RadioReRepNo.Name = "RadioReRepNo"
        Me.RadioReRepNo.Size = New System.Drawing.Size(93, 18)
        Me.RadioReRepNo.TabIndex = 8
        Me.RadioReRepNo.TabStop = True
        Me.RadioReRepNo.Text = "Rerepair No:"
        Me.RadioReRepNo.UseVisualStyleBackColor = True
        '
        'RadioRepNo
        '
        Me.RadioRepNo.AutoSize = True
        Me.RadioRepNo.Location = New System.Drawing.Point(3, 5)
        Me.RadioRepNo.Name = "RadioRepNo"
        Me.RadioRepNo.Size = New System.Drawing.Size(82, 18)
        Me.RadioRepNo.TabIndex = 7
        Me.RadioRepNo.TabStop = True
        Me.RadioRepNo.Text = "Repair No:"
        Me.RadioRepNo.UseVisualStyleBackColor = True
        '
        'ControlRepairReRepairSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboReRepNo)
        Me.Controls.Add(Me.ComboRepNo)
        Me.Controls.Add(Me.RadioReRepNo)
        Me.Controls.Add(Me.RadioRepNo)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MaximumSize = New System.Drawing.Size(0, 57)
        Me.MinimumSize = New System.Drawing.Size(197, 57)
        Me.Name = "ControlRepairReRepairSelection"
        Me.Size = New System.Drawing.Size(197, 57)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboReRepNo As ComboBox
    Friend WithEvents ComboRepNo As ComboBox
    Friend WithEvents RadioReRepNo As RadioButton
    Friend WithEvents RadioRepNo As RadioButton
End Class
