<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlCustomer
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboPrefix = New System.Windows.Forms.ComboBox()
        Me.TextPhone3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextPhone2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.TextPhone1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextName)
        Me.GroupBox2.Controls.Add(Me.ComboPrefix)
        Me.GroupBox2.Controls.Add(Me.TextPhone3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextPhone2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ButtonView)
        Me.GroupBox2.Controls.Add(Me.TextPhone1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 153)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Info"
        '
        'ComboPrefix
        '
        Me.ComboPrefix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboPrefix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboPrefix.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPrefix.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ComboPrefix.FormattingEnabled = True
        Me.ComboPrefix.Items.AddRange(New Object() {"Mr. ", "Mrs. ", "Miss. ", "Dr. ", "Ven. "})
        Me.ComboPrefix.Location = New System.Drawing.Point(61, 122)
        Me.ComboPrefix.Name = "ComboPrefix"
        Me.ComboPrefix.Size = New System.Drawing.Size(64, 23)
        Me.ComboPrefix.TabIndex = 3
        '
        'TextPhone3
        '
        Me.TextPhone3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextPhone3.Location = New System.Drawing.Point(114, 89)
        Me.TextPhone3.Mask = "999 0 000 000"
        Me.TextPhone3.Name = "TextPhone3"
        Me.TextPhone3.Size = New System.Drawing.Size(104, 24)
        Me.TextPhone3.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Telephone No 3 :"
        '
        'TextPhone2
        '
        Me.TextPhone2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextPhone2.Location = New System.Drawing.Point(114, 57)
        Me.TextPhone2.Mask = "999 0 000 000"
        Me.TextPhone2.Name = "TextPhone2"
        Me.TextPhone2.Size = New System.Drawing.Size(104, 24)
        Me.TextPhone2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Telephone No 2 :"
        '
        'ButtonView
        '
        Me.ButtonView.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonView.Location = New System.Drawing.Point(328, 122)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(30, 25)
        Me.ButtonView.TabIndex = 5
        Me.ButtonView.Text = "..."
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'TextPhone1
        '
        Me.TextPhone1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextPhone1.Location = New System.Drawing.Point(114, 25)
        Me.TextPhone1.Mask = "999 0 000 000"
        Me.TextPhone1.Name = "TextPhone1"
        Me.TextPhone1.Size = New System.Drawing.Size(104, 24)
        Me.TextPhone1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telephone No 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Name :"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(131, 121)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(191, 24)
        Me.TextName.TabIndex = 40
        '
        'ControlCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlCustomer"
        Me.Size = New System.Drawing.Size(365, 153)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboPrefix As ComboBox
    Friend WithEvents TextPhone3 As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextPhone2 As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonView As Button
    Friend WithEvents TextPhone1 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextName As TextBox
End Class
