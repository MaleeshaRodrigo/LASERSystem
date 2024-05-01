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
        Me.TlpStockForm = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtSNo = New System.Windows.Forms.TextBox()
        Me.TxtCostPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.CmbName = New System.Windows.Forms.ComboBox()
        Me.CmbLocation = New System.Windows.Forms.ComboBox()
        Me.TxtModelNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TxtDetails = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblCostPrice = New System.Windows.Forms.Label()
        Me.TxtDamagedUnits = New System.Windows.Forms.NumericUpDown()
        Me.TxtAvailableUnits = New System.Windows.Forms.NumericUpDown()
        Me.TxtReorderPoint = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSalePrice = New System.Windows.Forms.NumericUpDown()
        Me.TxtLowestPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TlpSImages = New System.Windows.Forms.TableLayoutPanel()
        Me.PicMain = New System.Windows.Forms.PictureBox()
        Me.GrpInfo.SuspendLayout()
        Me.TlpStockForm.SuspendLayout()
        CType(Me.TxtCostPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtDamagedUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAvailableUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtReorderPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSalePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLowestPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TlpSImages.SuspendLayout()
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpInfo
        '
        Me.GrpInfo.BackColor = System.Drawing.SystemColors.Control
        Me.GrpInfo.Controls.Add(Me.TlpStockForm)
        Me.GrpInfo.Controls.Add(Me.GroupBox1)
        Me.GrpInfo.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.GrpInfo.Location = New System.Drawing.Point(3, 2)
        Me.GrpInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrpInfo.Size = New System.Drawing.Size(1017, 600)
        Me.GrpInfo.TabIndex = 24
        Me.GrpInfo.TabStop = False
        Me.GrpInfo.Text = "Info"
        '
        'TlpStockForm
        '
        Me.TlpStockForm.ColumnCount = 2
        Me.TlpStockForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TlpStockForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TlpStockForm.Controls.Add(Me.TxtSNo, 1, 0)
        Me.TlpStockForm.Controls.Add(Me.TxtCostPrice, 1, 5)
        Me.TlpStockForm.Controls.Add(Me.Label2, 0, 1)
        Me.TlpStockForm.Controls.Add(Me.Label3, 0, 2)
        Me.TlpStockForm.Controls.Add(Me.Label4, 0, 3)
        Me.TlpStockForm.Controls.Add(Me.Label5, 0, 4)
        Me.TlpStockForm.Controls.Add(Me.CmbCategory, 1, 1)
        Me.TlpStockForm.Controls.Add(Me.CmbName, 1, 2)
        Me.TlpStockForm.Controls.Add(Me.CmbLocation, 1, 4)
        Me.TlpStockForm.Controls.Add(Me.TxtModelNo, 1, 3)
        Me.TlpStockForm.Controls.Add(Me.Label1, 0, 0)
        Me.TlpStockForm.Controls.Add(Me.Panel1, 0, 12)
        Me.TlpStockForm.Controls.Add(Me.TxtDetails, 1, 11)
        Me.TlpStockForm.Controls.Add(Me.Label11, 0, 11)
        Me.TlpStockForm.Controls.Add(Me.Label9, 0, 10)
        Me.TlpStockForm.Controls.Add(Me.Label8, 0, 9)
        Me.TlpStockForm.Controls.Add(Me.Label10, 0, 8)
        Me.TlpStockForm.Controls.Add(Me.LblCostPrice, 0, 5)
        Me.TlpStockForm.Controls.Add(Me.TxtDamagedUnits, 1, 10)
        Me.TlpStockForm.Controls.Add(Me.TxtAvailableUnits, 1, 9)
        Me.TlpStockForm.Controls.Add(Me.TxtReorderPoint, 1, 8)
        Me.TlpStockForm.Controls.Add(Me.Label7, 0, 7)
        Me.TlpStockForm.Controls.Add(Me.TxtSalePrice, 1, 7)
        Me.TlpStockForm.Controls.Add(Me.TxtLowestPrice, 1, 6)
        Me.TlpStockForm.Controls.Add(Me.Label6, 0, 6)
        Me.TlpStockForm.Location = New System.Drawing.Point(7, 26)
        Me.TlpStockForm.Margin = New System.Windows.Forms.Padding(4)
        Me.TlpStockForm.Name = "TlpStockForm"
        Me.TlpStockForm.RowCount = 13
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TlpStockForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TlpStockForm.Size = New System.Drawing.Size(533, 566)
        Me.TlpStockForm.TabIndex = 25
        '
        'TxtSNo
        '
        Me.TxtSNo.Enabled = False
        Me.TxtSNo.Location = New System.Drawing.Point(162, 2)
        Me.TxtSNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSNo.Name = "TxtSNo"
        Me.TxtSNo.Size = New System.Drawing.Size(67, 27)
        Me.TxtSNo.TabIndex = 10
        '
        'TxtCostPrice
        '
        Me.TxtCostPrice.DecimalPlaces = 2
        Me.TxtCostPrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TxtCostPrice.Location = New System.Drawing.Point(162, 187)
        Me.TxtCostPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCostPrice.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TxtCostPrice.Name = "TxtCostPrice"
        Me.TxtCostPrice.Size = New System.Drawing.Size(96, 27)
        Me.TxtCostPrice.TabIndex = 15
        Me.TxtCostPrice.ThousandsSeparator = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model No:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCategory
        '
        Me.CmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCategory.Location = New System.Drawing.Point(162, 39)
        Me.CmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(324, 27)
        Me.CmbCategory.TabIndex = 11
        '
        'CmbName
        '
        Me.CmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbName.FormattingEnabled = True
        Me.CmbName.Location = New System.Drawing.Point(162, 76)
        Me.CmbName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbName.Name = "CmbName"
        Me.CmbName.Size = New System.Drawing.Size(324, 27)
        Me.CmbName.TabIndex = 12
        '
        'CmbLocation
        '
        Me.CmbLocation.Location = New System.Drawing.Point(162, 150)
        Me.CmbLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(215, 27)
        Me.CmbLocation.TabIndex = 14
        '
        'TxtModelNo
        '
        Me.TxtModelNo.Location = New System.Drawing.Point(162, 113)
        Me.TxtModelNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtModelNo.Name = "TxtModelNo"
        Me.TxtModelNo.Size = New System.Drawing.Size(156, 27)
        Me.TxtModelNo.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.TlpStockForm.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.CmdSave)
        Me.Panel1.Controls.Add(Me.CmdDelete)
        Me.Panel1.Controls.Add(Me.CmdClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 509)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 53)
        Me.Panel1.TabIndex = 35
        '
        'CmdSave
        '
        Me.CmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.Location = New System.Drawing.Point(3, 2)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(127, 47)
        Me.CmdSave.TabIndex = 28
        Me.CmdSave.Text = "Save"
        Me.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'CmdDelete
        '
        Me.CmdDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdDelete.Image = CType(resources.GetObject("CmdDelete.Image"), System.Drawing.Image)
        Me.CmdDelete.Location = New System.Drawing.Point(135, 2)
        Me.CmdDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(107, 47)
        Me.CmdDelete.TabIndex = 29
        Me.CmdDelete.Text = "Delete"
        Me.CmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'CmdClose
        '
        Me.CmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CmdClose.Image = CType(resources.GetObject("CmdClose.Image"), System.Drawing.Image)
        Me.CmdClose.Location = New System.Drawing.Point(247, 2)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(115, 47)
        Me.CmdClose.TabIndex = 31
        Me.CmdClose.Text = "Close"
        Me.CmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'TxtDetails
        '
        Me.TxtDetails.Location = New System.Drawing.Point(162, 409)
        Me.TxtDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDetails.Multiline = True
        Me.TxtDetails.Name = "TxtDetails"
        Me.TxtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDetails.Size = New System.Drawing.Size(324, 93)
        Me.TxtDetails.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 407)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Details:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Damaged Units:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Available Units:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Reorder Point:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCostPrice
        '
        Me.LblCostPrice.AutoSize = True
        Me.LblCostPrice.Location = New System.Drawing.Point(3, 185)
        Me.LblCostPrice.Name = "LblCostPrice"
        Me.LblCostPrice.Size = New System.Drawing.Size(84, 21)
        Me.LblCostPrice.TabIndex = 5
        Me.LblCostPrice.Text = "Cost Price:"
        Me.LblCostPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDamagedUnits
        '
        Me.TxtDamagedUnits.Location = New System.Drawing.Point(162, 372)
        Me.TxtDamagedUnits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDamagedUnits.Name = "TxtDamagedUnits"
        Me.TxtDamagedUnits.Size = New System.Drawing.Size(55, 27)
        Me.TxtDamagedUnits.TabIndex = 19
        '
        'TxtAvailableUnits
        '
        Me.TxtAvailableUnits.Location = New System.Drawing.Point(162, 335)
        Me.TxtAvailableUnits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAvailableUnits.Name = "TxtAvailableUnits"
        Me.TxtAvailableUnits.Size = New System.Drawing.Size(55, 27)
        Me.TxtAvailableUnits.TabIndex = 18
        '
        'TxtReorderPoint
        '
        Me.TxtReorderPoint.Location = New System.Drawing.Point(162, 298)
        Me.TxtReorderPoint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtReorderPoint.Name = "TxtReorderPoint"
        Me.TxtReorderPoint.Size = New System.Drawing.Size(55, 27)
        Me.TxtReorderPoint.TabIndex = 17
        Me.TxtReorderPoint.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sale Price:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.DecimalPlaces = 2
        Me.TxtSalePrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TxtSalePrice.Location = New System.Drawing.Point(162, 261)
        Me.TxtSalePrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSalePrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(96, 27)
        Me.TxtSalePrice.TabIndex = 16
        Me.TxtSalePrice.ThousandsSeparator = True
        '
        'TxtLowestPrice
        '
        Me.TxtLowestPrice.DecimalPlaces = 2
        Me.TxtLowestPrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TxtLowestPrice.Location = New System.Drawing.Point(162, 224)
        Me.TxtLowestPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtLowestPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.TxtLowestPrice.Name = "TxtLowestPrice"
        Me.TxtLowestPrice.Size = New System.Drawing.Size(96, 27)
        Me.TxtLowestPrice.TabIndex = 15
        Me.TxtLowestPrice.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lowest Price:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TlpSImages)
        Me.GroupBox1.Location = New System.Drawing.Point(547, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(460, 567)
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
        Me.TlpSImages.Location = New System.Drawing.Point(3, 22)
        Me.TlpSImages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TlpSImages.Name = "TlpSImages"
        Me.TlpSImages.RowCount = 3
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpSImages.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpSImages.Size = New System.Drawing.Size(454, 543)
        Me.TlpSImages.TabIndex = 33
        '
        'PicMain
        '
        Me.TlpSImages.SetColumnSpan(Me.PicMain, 4)
        Me.PicMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicMain.ErrorImage = Global.LASER_System.My.Resources.Resources.empty
        Me.PicMain.Image = Global.LASER_System.My.Resources.Resources.empty
        Me.PicMain.InitialImage = Global.LASER_System.My.Resources.Resources.empty
        Me.PicMain.Location = New System.Drawing.Point(3, 2)
        Me.PicMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicMain.Name = "PicMain"
        Me.PicMain.Size = New System.Drawing.Size(448, 403)
        Me.PicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMain.TabIndex = 0
        Me.PicMain.TabStop = False
        '
        'ControlStockInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GrpInfo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ControlStockInfo"
        Me.Size = New System.Drawing.Size(1036, 611)
        Me.GrpInfo.ResumeLayout(False)
        Me.TlpStockForm.ResumeLayout(False)
        Me.TlpStockForm.PerformLayout()
        CType(Me.TxtCostPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TxtDamagedUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAvailableUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtReorderPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSalePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLowestPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TlpSImages.ResumeLayout(False)
        CType(Me.PicMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpInfo As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TlpSImages As TableLayoutPanel
    Friend WithEvents PicMain As PictureBox
    Friend WithEvents TxtDetails As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDelete As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents TxtDamagedUnits As NumericUpDown
    Friend WithEvents TxtAvailableUnits As NumericUpDown
    Friend WithEvents TxtReorderPoint As NumericUpDown
    Friend WithEvents TxtSalePrice As NumericUpDown
    Friend WithEvents TxtLowestPrice As NumericUpDown
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
    Friend WithEvents TlpStockForm As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtCostPrice As NumericUpDown
    Friend WithEvents LblCostPrice As Label
End Class
