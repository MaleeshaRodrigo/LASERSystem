<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlStockInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlStockInfo))
        Me.GrpInfo = New System.Windows.Forms.GroupBox()
        Me.TxtLowestPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TlpSImages = New System.Windows.Forms.TableLayoutPanel()
        Me.PicMain = New System.Windows.Forms.PictureBox()
        Me.TxtDetails = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.TxtDamagedUnits = New System.Windows.Forms.NumericUpDown()
        Me.TxtAvailableUnits = New System.Windows.Forms.NumericUpDown()
        Me.TxtReorderPoint = New System.Windows.Forms.NumericUpDown()
        Me.TxtSalePrice = New System.Windows.Forms.NumericUpDown()
        Me.TxtCostPrice = New System.Windows.Forms.NumericUpDown()
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
        CType(Me.TxtLowestPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TlpSImages.SuspendLayout()
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDamagedUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAvailableUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtReorderPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSalePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCostPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpInfo
        '
        Me.GrpInfo.BackColor = System.Drawing.SystemColors.Control
        Me.GrpInfo.Controls.Add(Me.TxtLowestPrice)
        Me.GrpInfo.Controls.Add(Me.Label12)
        Me.GrpInfo.Controls.Add(Me.GroupBox1)
        Me.GrpInfo.Controls.Add(Me.TxtDetails)
        Me.GrpInfo.Controls.Add(Me.Label11)
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
        Me.GrpInfo.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.GrpInfo.Location = New System.Drawing.Point(3, 3)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(937, 563)
        Me.GrpInfo.TabIndex = 24
        Me.GrpInfo.TabStop = False
        Me.GrpInfo.Text = "Info"
        '
        'TxtLowestPrice
        '
        Me.TxtLowestPrice.DecimalPlaces = 2
        Me.TxtLowestPrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TxtLowestPrice.Location = New System.Drawing.Point(141, 230)
        Me.TxtLowestPrice.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtLowestPrice.Name = "TxtLowestPrice"
        Me.TxtLowestPrice.Size = New System.Drawing.Size(96, 27)
        Me.TxtLowestPrice.TabIndex = 37
        Me.TxtLowestPrice.ThousandsSeparator = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 21)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Lowest Price:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TlpSImages)
        Me.GroupBox1.Location = New System.Drawing.Point(471, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 528)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pictures Area"
        '
        'TlpSImages
        '
        Me.TlpSImages.ColumnCount = 4
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpSImages.Controls.Add(Me.PicMain, 0, 0)
        Me.TlpSImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpSImages.Location = New System.Drawing.Point(3, 23)
        Me.TlpSImages.Name = "TlpSImages"
        Me.TlpSImages.RowCount = 3
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpSImages.Size = New System.Drawing.Size(454, 502)
        Me.TlpSImages.TabIndex = 33
        '
        'PicMain
        '
        Me.TlpSImages.SetColumnSpan(Me.PicMain, 4)
        Me.PicMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicMain.ErrorImage = Global.LASER_System.My.Resources.Resources.empty
        Me.PicMain.Image = Global.LASER_System.My.Resources.Resources.empty
        Me.PicMain.InitialImage = Global.LASER_System.My.Resources.Resources.empty
        Me.PicMain.Location = New System.Drawing.Point(3, 3)
        Me.PicMain.Name = "PicMain"
        Me.PicMain.Size = New System.Drawing.Size(448, 370)
        Me.PicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicMain.TabIndex = 0
        Me.PicMain.TabStop = False
        '
        'TxtDetails
        '
        Me.TxtDetails.Location = New System.Drawing.Point(141, 397)
        Me.TxtDetails.Multiline = True
        Me.TxtDetails.Name = "TxtDetails"
        Me.TxtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDetails.Size = New System.Drawing.Size(324, 118)
        Me.TxtDetails.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Details:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdClose
        '
        Me.CmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdClose.Image = CType(resources.GetObject("CmdClose.Image"), System.Drawing.Image)
        Me.CmdClose.Location = New System.Drawing.Point(295, 521)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(114, 33)
        Me.CmdClose.TabIndex = 31
        Me.CmdClose.Text = "Close"
        Me.CmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'CmdDelete
        '
        Me.CmdDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdDelete.Image = CType(resources.GetObject("CmdDelete.Image"), System.Drawing.Image)
        Me.CmdDelete.Location = New System.Drawing.Point(182, 521)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(107, 33)
        Me.CmdDelete.TabIndex = 29
        Me.CmdDelete.Text = "Delete"
        Me.CmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'CmdSave
        '
        Me.CmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.Location = New System.Drawing.Point(49, 521)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(127, 33)
        Me.CmdSave.TabIndex = 28
        Me.CmdSave.Text = "Save"
        Me.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'TxtDamagedUnits
        '
        Me.TxtDamagedUnits.Location = New System.Drawing.Point(139, 364)
        Me.TxtDamagedUnits.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtDamagedUnits.Name = "TxtDamagedUnits"
        Me.TxtDamagedUnits.Size = New System.Drawing.Size(55, 27)
        Me.TxtDamagedUnits.TabIndex = 19
        '
        'TxtAvailableUnits
        '
        Me.TxtAvailableUnits.Location = New System.Drawing.Point(139, 331)
        Me.TxtAvailableUnits.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtAvailableUnits.Name = "TxtAvailableUnits"
        Me.TxtAvailableUnits.Size = New System.Drawing.Size(55, 27)
        Me.TxtAvailableUnits.TabIndex = 18
        '
        'TxtReorderPoint
        '
        Me.TxtReorderPoint.Location = New System.Drawing.Point(141, 298)
        Me.TxtReorderPoint.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtReorderPoint.Name = "TxtReorderPoint"
        Me.TxtReorderPoint.Size = New System.Drawing.Size(55, 27)
        Me.TxtReorderPoint.TabIndex = 17
        Me.TxtReorderPoint.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.DecimalPlaces = 2
        Me.TxtSalePrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TxtSalePrice.Location = New System.Drawing.Point(141, 265)
        Me.TxtSalePrice.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(96, 27)
        Me.TxtSalePrice.TabIndex = 16
        Me.TxtSalePrice.ThousandsSeparator = True
        '
        'TxtCostPrice
        '
        Me.TxtCostPrice.DecimalPlaces = 2
        Me.TxtCostPrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TxtCostPrice.Location = New System.Drawing.Point(141, 197)
        Me.TxtCostPrice.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtCostPrice.Name = "TxtCostPrice"
        Me.TxtCostPrice.Size = New System.Drawing.Size(96, 27)
        Me.TxtCostPrice.TabIndex = 15
        Me.TxtCostPrice.ThousandsSeparator = True
        '
        'CmbLocation
        '
        Me.CmbLocation.Location = New System.Drawing.Point(141, 160)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(214, 27)
        Me.CmbLocation.TabIndex = 14
        '
        'TxtModelNo
        '
        Me.TxtModelNo.Location = New System.Drawing.Point(141, 126)
        Me.TxtModelNo.Name = "TxtModelNo"
        Me.TxtModelNo.Size = New System.Drawing.Size(156, 27)
        Me.TxtModelNo.TabIndex = 13
        '
        'CmbName
        '
        Me.CmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbName.FormattingEnabled = True
        Me.CmbName.Location = New System.Drawing.Point(141, 93)
        Me.CmbName.Name = "CmbName"
        Me.CmbName.Size = New System.Drawing.Size(324, 27)
        Me.CmbName.TabIndex = 12
        '
        'CmbCategory
        '
        Me.CmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCategory.Location = New System.Drawing.Point(141, 60)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(324, 27)
        Me.CmbCategory.TabIndex = 11
        '
        'TxtSNo
        '
        Me.TxtSNo.Enabled = False
        Me.TxtSNo.Location = New System.Drawing.Point(141, 27)
        Me.TxtSNo.Name = "TxtSNo"
        Me.TxtSNo.Size = New System.Drawing.Size(67, 27)
        Me.TxtSNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Reorder Point:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Damaged Units:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Available Units:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sale Price:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cost Price:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model No:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ControlStockInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GrpInfo)
        Me.Name = "ControlStockInfo"
        Me.Size = New System.Drawing.Size(947, 595)
        Me.GrpInfo.ResumeLayout(False)
        Me.GrpInfo.PerformLayout()
        CType(Me.TxtLowestPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TlpSImages.ResumeLayout(False)
        Me.TlpSImages.PerformLayout()
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDamagedUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAvailableUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtReorderPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSalePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCostPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpInfo As GroupBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDelete As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents TxtDamagedUnits As NumericUpDown
    Friend WithEvents TxtAvailableUnits As NumericUpDown
    Friend WithEvents TxtReorderPoint As NumericUpDown
    Friend WithEvents TxtSalePrice As NumericUpDown
    Friend WithEvents TxtCostPrice As NumericUpDown
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
    Friend WithEvents TxtDetails As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TlpSImages As TableLayoutPanel
    Friend WithEvents PicMain As PictureBox
    Friend WithEvents TxtLowestPrice As NumericUpDown
    Friend WithEvents Label12 As Label
End Class
