<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlStockSelection
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextStockCode = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboStockName = New System.Windows.Forms.ComboBox()
        Me.ComboStockCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TextStockCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextStockCode)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboStockName)
        Me.Panel1.Controls.Add(Me.ComboStockCategory)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 90)
        Me.Panel1.TabIndex = 0
        '
        'TextStockCode
        '
        Me.TextStockCode.InterceptArrowKeys = False
        Me.TextStockCode.Location = New System.Drawing.Point(69, 3)
        Me.TextStockCode.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.TextStockCode.Name = "TextStockCode"
        Me.TextStockCode.Size = New System.Drawing.Size(80, 22)
        Me.TextStockCode.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Code:"
        '
        'ComboStockName
        '
        Me.ComboStockName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboStockName.FormattingEnabled = True
        Me.ComboStockName.Location = New System.Drawing.Point(69, 61)
        Me.ComboStockName.Name = "ComboStockName"
        Me.ComboStockName.Size = New System.Drawing.Size(127, 22)
        Me.ComboStockName.TabIndex = 7
        '
        'ComboStockCategory
        '
        Me.ComboStockCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboStockCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboStockCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboStockCategory.FormattingEnabled = True
        Me.ComboStockCategory.Location = New System.Drawing.Point(69, 31)
        Me.ComboStockCategory.Name = "ComboStockCategory"
        Me.ComboStockCategory.Size = New System.Drawing.Size(127, 22)
        Me.ComboStockCategory.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Category:"
        '
        'ControlStockSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MaximumSize = New System.Drawing.Size(0, 90)
        Me.MinimumSize = New System.Drawing.Size(200, 90)
        Me.Name = "ControlStockSelection"
        Me.Size = New System.Drawing.Size(200, 90)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TextStockCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboStockName As ComboBox
    Friend WithEvents ComboStockCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextStockCode As NumericUpDown
End Class
