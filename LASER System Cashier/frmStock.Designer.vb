<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
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
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.grdStock = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SModelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAvailableStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOutofstocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMinStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdStockmnustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgwStock = New System.ComponentModel.BackgroundWorker()
        Me.GrpSearch.SuspendLayout()
        Me.GrpInfo.SuspendLayout()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.grdStockmnustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.btnSearch)
        Me.GrpSearch.Controls.Add(Me.GrpInfo)
        Me.GrpSearch.Controls.Add(Me.cmbFilter)
        Me.GrpSearch.Controls.Add(Me.txtSearch)
        Me.GrpSearch.Controls.Add(Me.Label11)
        Me.GrpSearch.Controls.Add(Me.cmdNew)
        Me.GrpSearch.Controls.Add(Me.grdStock)
        Me.GrpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GrpSearch.Location = New System.Drawing.Point(0, 24)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(1044, 640)
        Me.GrpSearch.TabIndex = 21
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Search "
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(226, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 23)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
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
        Me.GrpInfo.Location = New System.Drawing.Point(141, 137)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(762, 463)
        Me.GrpInfo.TabIndex = 23
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
        Me.TxtDamagedUnits.Size = New System.Drawing.Size(55, 23)
        Me.TxtDamagedUnits.TabIndex = 19
        Me.TxtDamagedUnits.Text = "0"
        '
        'TxtAvailableUnits
        '
        Me.TxtAvailableUnits.Location = New System.Drawing.Point(559, 125)
        Me.TxtAvailableUnits.Name = "TxtAvailableUnits"
        Me.TxtAvailableUnits.Size = New System.Drawing.Size(55, 23)
        Me.TxtAvailableUnits.TabIndex = 18
        Me.TxtAvailableUnits.Text = "0"
        '
        'TxtReorderPoint
        '
        Me.TxtReorderPoint.Location = New System.Drawing.Point(561, 92)
        Me.TxtReorderPoint.Name = "TxtReorderPoint"
        Me.TxtReorderPoint.Size = New System.Drawing.Size(55, 23)
        Me.TxtReorderPoint.TabIndex = 17
        Me.TxtReorderPoint.Text = "3"
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.Location = New System.Drawing.Point(561, 59)
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(96, 23)
        Me.TxtSalePrice.TabIndex = 16
        Me.TxtSalePrice.Text = "0"
        '
        'TxtCostPrice
        '
        Me.TxtCostPrice.Location = New System.Drawing.Point(561, 26)
        Me.TxtCostPrice.Name = "TxtCostPrice"
        Me.TxtCostPrice.Size = New System.Drawing.Size(96, 23)
        Me.TxtCostPrice.TabIndex = 15
        Me.TxtCostPrice.Text = "0"
        '
        'CmbLocation
        '
        Me.CmbLocation.FormattingEnabled = True
        Me.CmbLocation.Location = New System.Drawing.Point(96, 159)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(214, 23)
        Me.CmbLocation.TabIndex = 14
        '
        'TxtModelNo
        '
        Me.TxtModelNo.Location = New System.Drawing.Point(96, 125)
        Me.TxtModelNo.Name = "TxtModelNo"
        Me.TxtModelNo.Size = New System.Drawing.Size(156, 23)
        Me.TxtModelNo.TabIndex = 13
        '
        'CmbName
        '
        Me.CmbName.FormattingEnabled = True
        Me.CmbName.Location = New System.Drawing.Point(96, 92)
        Me.CmbName.Name = "CmbName"
        Me.CmbName.Size = New System.Drawing.Size(324, 23)
        Me.CmbName.TabIndex = 12
        '
        'CmbCategory
        '
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(96, 59)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(324, 23)
        Me.CmbCategory.TabIndex = 11
        '
        'TxtSNo
        '
        Me.TxtSNo.Location = New System.Drawing.Point(96, 26)
        Me.TxtSNo.Name = "TxtSNo"
        Me.TxtSNo.Size = New System.Drawing.Size(67, 23)
        Me.TxtSNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Reorder Point:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Damaged Units:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Available Units:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sale Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cost Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code:"
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.White
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.ItemHeight = 16
        Me.cmbFilter.Items.AddRange(New Object() {"by Stock Code", "by Stock Category", "by Stock Name", "by Stock Model No", "by Stock Location"")", "by Stock Cost Price", "by Stock Sale Price", "by Stock Reorder Point", "by Stock Details", "by All"})
        Me.cmbFilter.Location = New System.Drawing.Point(358, 21)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(249, 22)
        Me.cmbFilter.TabIndex = 26
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(6, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 23)
        Me.txtSearch.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Filter"
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(953, 13)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 32)
        Me.cmdNew.TabIndex = 27
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'grdStock
        '
        Me.grdStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.SModelNo, Me.SLocation, Me.SCostPrice, Me.SSalePrice, Me.SAvailableStocks, Me.SOutofstocks, Me.SMinStocks, Me.SDetails, Me.SImage})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStock.DefaultCellStyle = DataGridViewCellStyle10
        Me.grdStock.GridColor = System.Drawing.Color.White
        Me.grdStock.Location = New System.Drawing.Point(6, 51)
        Me.grdStock.Name = "grdStock"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdStock.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.grdStock.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.grdStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grdStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grdStock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkBlue
        Me.grdStock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grdStock.Size = New System.Drawing.Size(1032, 583)
        Me.grdStock.TabIndex = 18
        '
        'SNo
        '
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Code"
        Me.SNo.MinimumWidth = 6
        Me.SNo.Name = "SNo"
        Me.SNo.ReadOnly = True
        Me.SNo.Width = 59
        '
        'SCategory
        '
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.MinimumWidth = 6
        Me.SCategory.Name = "SCategory"
        Me.SCategory.Width = 80
        '
        'SName
        '
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Name"
        Me.SName.MinimumWidth = 6
        Me.SName.Name = "SName"
        Me.SName.Width = 63
        '
        'SModelNo
        '
        Me.SModelNo.DataPropertyName = "SModelNo"
        Me.SModelNo.HeaderText = "Model No"
        Me.SModelNo.MinimumWidth = 6
        Me.SModelNo.Name = "SModelNo"
        Me.SModelNo.Width = 79
        '
        'SLocation
        '
        Me.SLocation.DataPropertyName = "SLocation"
        Me.SLocation.HeaderText = "Location"
        Me.SLocation.MinimumWidth = 6
        Me.SLocation.Name = "SLocation"
        Me.SLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SLocation.Width = 59
        '
        'SCostPrice
        '
        Me.SCostPrice.DataPropertyName = "SCostPrice"
        Me.SCostPrice.HeaderText = "Cost Price"
        Me.SCostPrice.MinimumWidth = 6
        Me.SCostPrice.Name = "SCostPrice"
        Me.SCostPrice.Width = 80
        '
        'SSalePrice
        '
        Me.SSalePrice.DataPropertyName = "SSalePrice"
        Me.SSalePrice.HeaderText = "Sale Price"
        Me.SSalePrice.MinimumWidth = 6
        Me.SSalePrice.Name = "SSalePrice"
        Me.SSalePrice.Width = 79
        '
        'SAvailableStocks
        '
        Me.SAvailableStocks.DataPropertyName = "SAvailableStocks"
        Me.SAvailableStocks.HeaderText = "Available Units"
        Me.SAvailableStocks.MinimumWidth = 6
        Me.SAvailableStocks.Name = "SAvailableStocks"
        Me.SAvailableStocks.ReadOnly = True
        Me.SAvailableStocks.Width = 106
        '
        'SOutofstocks
        '
        Me.SOutofstocks.DataPropertyName = "SOutofStocks"
        Me.SOutofstocks.HeaderText = "Damaged Units"
        Me.SOutofstocks.MinimumWidth = 6
        Me.SOutofstocks.Name = "SOutofstocks"
        Me.SOutofstocks.ReadOnly = True
        Me.SOutofstocks.Width = 106
        '
        'SMinStocks
        '
        Me.SMinStocks.DataPropertyName = "SMinStocks"
        Me.SMinStocks.HeaderText = "Reorder Point"
        Me.SMinStocks.MinimumWidth = 6
        Me.SMinStocks.Name = "SMinStocks"
        Me.SMinStocks.Width = 98
        '
        'SDetails
        '
        Me.SDetails.DataPropertyName = "SDetails"
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDetails.DefaultCellStyle = DataGridViewCellStyle8
        Me.SDetails.HeaderText = "Details"
        Me.SDetails.MinimumWidth = 6
        Me.SDetails.Name = "SDetails"
        Me.SDetails.Width = 71
        '
        'SImage
        '
        Me.SImage.DataPropertyName = "SImage"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SImage.DefaultCellStyle = DataGridViewCellStyle9
        Me.SImage.HeaderText = "Picture"
        Me.SImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.SImage.MinimumWidth = 6
        Me.SImage.Name = "SImage"
        Me.SImage.Width = 52
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1044, 24)
        Me.MenuStrip.TabIndex = 22
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStockTransactionDetailsToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'ViewStockTransactionDetailsToolStripMenuItem
        '
        Me.ViewStockTransactionDetailsToolStripMenuItem.Name = "ViewStockTransactionDetailsToolStripMenuItem"
        Me.ViewStockTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ViewStockTransactionDetailsToolStripMenuItem.Text = "View Stock Transaction Details"
        '
        'grdStockmnustrip
        '
        Me.grdStockmnustrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.grdStockmnustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeToolStripMenuItem, Me.ViewToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.grdStockmnustrip.Name = "grdStockmnustrip"
        Me.grdStockmnustrip.Size = New System.Drawing.Size(156, 70)
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ChangeToolStripMenuItem.Text = "Change Picture"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ViewToolStripMenuItem1.Text = "Open Picture"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'bgwStock
        '
        Me.bgwStock.WorkerReportsProgress = True
        Me.bgwStock.WorkerSupportsCancellation = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1044, 664)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStock"
        Me.Text = "LASER System - Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpInfo.ResumeLayout(False)
        Me.GrpInfo.PerformLayout()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.grdStockmnustrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStockTransactionDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grdStockmnustrip As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents grdStock As DataGridView
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents bgwStock As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSearch As Button
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SModelNo As DataGridViewTextBoxColumn
    Friend WithEvents SLocation As DataGridViewTextBoxColumn
    Friend WithEvents SCostPrice As DataGridViewTextBoxColumn
    Friend WithEvents SSalePrice As DataGridViewTextBoxColumn
    Friend WithEvents SAvailableStocks As DataGridViewTextBoxColumn
    Friend WithEvents SOutofstocks As DataGridViewTextBoxColumn
    Friend WithEvents SMinStocks As DataGridViewTextBoxColumn
    Friend WithEvents SDetails As DataGridViewTextBoxColumn
    Friend WithEvents SImage As DataGridViewImageColumn
    Friend WithEvents GrpInfo As GroupBox
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
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdDelete As Button
    Friend WithEvents CmdSave As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents TlpSImages As TableLayoutPanel
End Class
