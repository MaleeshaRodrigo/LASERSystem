<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlStockInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlStockInfo))
        Me.GrpInfo = New System.Windows.Forms.GroupBox()
        Me.TlpSImages = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.TxtDamagedUnits = New System.Windows.Forms.TextBox()
        Me.TxtAvailableUnits = New System.Windows.Forms.TextBox()
        Me.TxtReorderPoint = New System.Windows.Forms.TextBox()
        Me.TxtSalePrice = New System.Windows.Forms.TextBox()
        Me.TxtCostPrice = New System.Windows.Forms.TextBox()
        Me.CmbLocation = New System.Windows.Forms.ComboBox()
        Me.TxtModelNo = New System.Windows.Forms.TextBox()
        Me.CmbName = New System.Windows.Forms.ComboBox()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.TxtSNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpInfo
        '
        Me.GrpInfo.Controls.Add(Me.TlpSImages)
        Me.GrpInfo.Controls.Add(Me.CmdClose)
        Me.GrpInfo.Controls.Add(Me.CmdDelete)
        Me.GrpInfo.Controls.Add(Me.CmdSave)
        Me.GrpInfo.Controls.Add(Me.TxtDamagedUnits)
        Me.GrpInfo.Controls.Add(Me.TxtAvailableUnits)
        Me.GrpInfo.Controls.Add(Me.TxtReorderPoint)
        Me.GrpInfo.Controls.Add(Me.TxtSalePrice)
        Me.GrpInfo.Controls.Add(Me.TxtCostPrice)
        Me.GrpInfo.Controls.Add(Me.CmbLocation)
        Me.GrpInfo.Controls.Add(Me.TxtModelNo)
        Me.GrpInfo.Controls.Add(Me.CmbName)
        Me.GrpInfo.Controls.Add(Me.CmbCategory)
        Me.GrpInfo.Controls.Add(Me.TxtSNo)
        Me.GrpInfo.Controls.Add(Me.Label10)
        Me.GrpInfo.Controls.Add(Me.Label9)
        Me.GrpInfo.Controls.Add(Me.Label8)
        Me.GrpInfo.Controls.Add(Me.Label7)
        Me.GrpInfo.Controls.Add(Me.Label6)
        Me.GrpInfo.Controls.Add(Me.Label5)
        Me.GrpInfo.Controls.Add(Me.Label4)
        Me.GrpInfo.Controls.Add(Me.Label3)
        Me.GrpInfo.Controls.Add(Me.Label2)
        Me.GrpInfo.Controls.Add(Me.Label1)
        Me.GrpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInfo.Location = New System.Drawing.Point(3, 3)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(762, 463)
        Me.GrpInfo.TabIndex = 24
        Me.GrpInfo.TabStop = False
        Me.GrpInfo.Text = "Info"
        '
        'TlpSImages
        '
        Me.TlpSImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpSImages.ColumnCount = 4
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.Location = New System.Drawing.Point(11, 196)
        Me.TlpSImages.Name = "TlpSImages"
        Me.TlpSImages.RowCount = 2
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpSImages.Size = New System.Drawing.Size(745, 257)
        Me.TlpSImages.TabIndex = 32
        '
        'CmdClose
        '
        Me.CmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdClose.Image = CType(resources.GetObject("CmdClose.Image"), System.Drawing.Image)
        Me.CmdClose.Location = New System.Drawing.Point(663, 100)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(85, 33)
        Me.CmdClose.TabIndex = 31
        Me.CmdClose.Text = "Close"
        Me.CmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'CmdDelete
        '
        Me.CmdDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdDelete.Image = CType(resources.GetObject("CmdDelete.Image"), System.Drawing.Image)
        Me.CmdDelete.Location = New System.Drawing.Point(663, 61)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(85, 33)
        Me.CmdDelete.TabIndex = 29
        Me.CmdDelete.Text = "Delete"
        Me.CmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'CmdSave
        '
        Me.CmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.Location = New System.Drawing.Point(663, 22)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(85, 33)
        Me.CmdSave.TabIndex = 28
        Me.CmdSave.Text = "Save"
        Me.CmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'TxtDamagedUnits
        '
        Me.TxtDamagedUnits.Location = New System.Drawing.Point(559, 158)
        Me.TxtDamagedUnits.Name = "TxtDamagedUnits"
        Me.TxtDamagedUnits.Size = New System.Drawing.Size(55, 22)
        Me.TxtDamagedUnits.TabIndex = 19
        Me.TxtDamagedUnits.Text = "0"
        '
        'TxtAvailableUnits
        '
        Me.TxtAvailableUnits.Location = New System.Drawing.Point(559, 125)
        Me.TxtAvailableUnits.Name = "TxtAvailableUnits"
        Me.TxtAvailableUnits.Size = New System.Drawing.Size(55, 22)
        Me.TxtAvailableUnits.TabIndex = 18
        Me.TxtAvailableUnits.Text = "0"
        '
        'TxtReorderPoint
        '
        Me.TxtReorderPoint.Location = New System.Drawing.Point(561, 92)
        Me.TxtReorderPoint.Name = "TxtReorderPoint"
        Me.TxtReorderPoint.Size = New System.Drawing.Size(55, 22)
        Me.TxtReorderPoint.TabIndex = 17
        Me.TxtReorderPoint.Text = "3"
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.Location = New System.Drawing.Point(561, 59)
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(96, 22)
        Me.TxtSalePrice.TabIndex = 16
        Me.TxtSalePrice.Text = "0"
        '
        'TxtCostPrice
        '
        Me.TxtCostPrice.Location = New System.Drawing.Point(561, 26)
        Me.TxtCostPrice.Name = "TxtCostPrice"
        Me.TxtCostPrice.Size = New System.Drawing.Size(96, 22)
        Me.TxtCostPrice.TabIndex = 15
        Me.TxtCostPrice.Text = "0"
        '
        'CmbLocation
        '
        Me.CmbLocation.FormattingEnabled = True
        Me.CmbLocation.Location = New System.Drawing.Point(96, 159)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(214, 24)
        Me.CmbLocation.TabIndex = 14
        '
        'TxtModelNo
        '
        Me.TxtModelNo.Location = New System.Drawing.Point(96, 125)
        Me.TxtModelNo.Name = "TxtModelNo"
        Me.TxtModelNo.Size = New System.Drawing.Size(156, 22)
        Me.TxtModelNo.TabIndex = 13
        '
        'CmbName
        '
        Me.CmbName.FormattingEnabled = True
        Me.CmbName.Location = New System.Drawing.Point(96, 92)
        Me.CmbName.Name = "CmbName"
        Me.CmbName.Size = New System.Drawing.Size(324, 24)
        Me.CmbName.TabIndex = 12
        '
        'CmbCategory
        '
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(96, 59)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(324, 24)
        Me.CmbCategory.TabIndex = 11
        '
        'TxtSNo
        '
        Me.TxtSNo.Location = New System.Drawing.Point(96, 26)
        Me.TxtSNo.Name = "TxtSNo"
        Me.TxtSNo.Size = New System.Drawing.Size(67, 22)
        Me.TxtSNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Reorder Point:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Damaged Units:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Available Units:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sale Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cost Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code:"
        '
        'ControlStockInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrpInfo)
        Me.Name = "ControlStockInfo"
        Me.Size = New System.Drawing.Size(789, 486)
        Me.GrpInfo.ResumeLayout(False)
        Me.GrpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpInfo As GroupBox
    Friend WithEvents TlpSImages As TableLayoutPanel
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDelete As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents TxtDamagedUnits As TextBox
    Friend WithEvents TxtAvailableUnits As TextBox
    Friend WithEvents TxtReorderPoint As TextBox
    Friend WithEvents TxtSalePrice As TextBox
    Friend WithEvents TxtCostPrice As TextBox
    Friend WithEvents CmbLocation As ComboBox
    Friend WithEvents TxtModelNo As TextBox
    Friend WithEvents CmbName As ComboBox
    Friend WithEvents CmbCategory As ComboBox
    Friend WithEvents TxtSNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
