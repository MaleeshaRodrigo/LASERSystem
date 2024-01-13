<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSupply
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupply))
        Me.GroupSupply = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSupDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSupNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupSupplier = New System.Windows.Forms.GroupBox()
        Me.cmdSuView = New System.Windows.Forms.Button()
        Me.cmbSuName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdSupply = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SModelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLowestPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMinStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdGetData = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupRemarks = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenBarcodeGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupFinancial = New System.Windows.Forms.GroupBox()
        Me.cmbSupStatus = New System.Windows.Forms.ComboBox()
        Me.txtSupPaidDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSupPaidDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupSupply.SuspendLayout()
        Me.GroupSupplier.SuspendLayout()
        CType(Me.grdSupply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.GroupFinancial.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupSupply
        '
        Me.GroupSupply.Controls.Add(Me.Label5)
        Me.GroupSupply.Controls.Add(Me.txtSupDate)
        Me.GroupSupply.Controls.Add(Me.txtSupNo)
        Me.GroupSupply.Controls.Add(Me.Label2)
        Me.GroupSupply.Controls.Add(Me.Label1)
        Me.GroupSupply.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupSupply.Location = New System.Drawing.Point(12, 27)
        Me.GroupSupply.Name = "GroupSupply"
        Me.GroupSupply.Size = New System.Drawing.Size(327, 83)
        Me.GroupSupply.TabIndex = 0
        Me.GroupSupply.TabStop = False
        Me.GroupSupply.Text = "Supply Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(80, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SUP-"
        '
        'txtSupDate
        '
        Me.txtSupDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSupDate.Location = New System.Drawing.Point(103, 53)
        Me.txtSupDate.Name = "txtSupDate"
        Me.txtSupDate.Size = New System.Drawing.Size(216, 28)
        Me.txtSupDate.TabIndex = 1
        '
        'txtSupNo
        '
        Me.txtSupNo.Enabled = False
        Me.txtSupNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSupNo.Location = New System.Drawing.Point(120, 22)
        Me.txtSupNo.Name = "txtSupNo"
        Me.txtSupNo.Size = New System.Drawing.Size(62, 28)
        Me.txtSupNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplied Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supply No:"
        '
        'GroupSupplier
        '
        Me.GroupSupplier.Controls.Add(Me.cmdSuView)
        Me.GroupSupplier.Controls.Add(Me.cmbSuName)
        Me.GroupSupplier.Controls.Add(Me.Label4)
        Me.GroupSupplier.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupSupplier.Location = New System.Drawing.Point(345, 27)
        Me.GroupSupplier.Name = "GroupSupplier"
        Me.GroupSupplier.Size = New System.Drawing.Size(302, 83)
        Me.GroupSupplier.TabIndex = 1
        Me.GroupSupplier.TabStop = False
        Me.GroupSupplier.Text = "Supplier Info"
        '
        'cmdSuView
        '
        Me.cmdSuView.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSuView.Location = New System.Drawing.Point(267, 42)
        Me.cmdSuView.Name = "cmdSuView"
        Me.cmdSuView.Size = New System.Drawing.Size(29, 23)
        Me.cmdSuView.TabIndex = 6
        Me.cmdSuView.Text = "..."
        Me.cmdSuView.UseVisualStyleBackColor = True
        '
        'cmbSuName
        '
        Me.cmbSuName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuName.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbSuName.FormattingEnabled = True
        Me.cmbSuName.Location = New System.Drawing.Point(6, 42)
        Me.cmbSuName.Name = "cmbSuName"
        Me.cmbSuName.Size = New System.Drawing.Size(255, 29)
        Me.cmbSuName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name:"
        '
        'grdSupply
        '
        Me.grdSupply.AllowUserToOrderColumns = True
        Me.grdSupply.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSupply.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.SModelNo, Me.SLocation, Me.SSalePrice, Me.SLowestPrice, Me.SMinStocks, Me.SupType, Me.CostPrice, Me.SupQty, Me.SupTotal, Me.SDetails})
        Me.grdSupply.Location = New System.Drawing.Point(12, 116)
        Me.grdSupply.Name = "grdSupply"
        Me.grdSupply.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdSupply.Size = New System.Drawing.Size(1249, 407)
        Me.grdSupply.TabIndex = 21
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.SNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.SNo.HeaderText = "Stock Code"
        Me.SNo.MinimumWidth = 6
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 105
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SCategory.HeaderText = "Stock Category"
        Me.SCategory.MinimumWidth = 6
        Me.SCategory.Name = "SCategory"
        Me.SCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SCategory.Width = 128
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SName.HeaderText = "Stock Name"
        Me.SName.MinimumWidth = 6
        Me.SName.Name = "SName"
        Me.SName.Width = 110
        '
        'SModelNo
        '
        Me.SModelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SModelNo.HeaderText = "Model No"
        Me.SModelNo.MinimumWidth = 6
        Me.SModelNo.Name = "SModelNo"
        Me.SModelNo.Width = 98
        '
        'SLocation
        '
        Me.SLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SLocation.HeaderText = "Location"
        Me.SLocation.MinimumWidth = 6
        Me.SLocation.Name = "SLocation"
        Me.SLocation.Width = 88
        '
        'SSalePrice
        '
        Me.SSalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.SSalePrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.SSalePrice.HeaderText = "Sale Price"
        Me.SSalePrice.MinimumWidth = 6
        Me.SSalePrice.Name = "SSalePrice"
        Me.SSalePrice.Width = 97
        '
        'SLowestPrice
        '
        Me.SLowestPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.SLowestPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.SLowestPrice.HeaderText = "Lowest Price"
        Me.SLowestPrice.MinimumWidth = 6
        Me.SLowestPrice.Name = "SLowestPrice"
        Me.SLowestPrice.Width = 115
        '
        'SMinStocks
        '
        Me.SMinStocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SMinStocks.HeaderText = "Reorder Units"
        Me.SMinStocks.MinimumWidth = 6
        Me.SMinStocks.Name = "SMinStocks"
        Me.SMinStocks.Width = 122
        '
        'SupType
        '
        Me.SupType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SupType.HeaderText = "Type"
        Me.SupType.Items.AddRange(New Object() {"Supply", "Return"})
        Me.SupType.MinimumWidth = 6
        Me.SupType.Name = "SupType"
        Me.SupType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SupType.Width = 66
        '
        'CostPrice
        '
        Me.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.CostPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostPrice.HeaderText = "Rate"
        Me.CostPrice.MinimumWidth = 6
        Me.CostPrice.Name = "CostPrice"
        Me.CostPrice.Width = 65
        '
        'SupQty
        '
        Me.SupQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.SupQty.DefaultCellStyle = DataGridViewCellStyle5
        Me.SupQty.HeaderText = "Qty"
        Me.SupQty.MinimumWidth = 6
        Me.SupQty.Name = "SupQty"
        Me.SupQty.Width = 59
        '
        'SupTotal
        '
        Me.SupTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.SupTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.SupTotal.HeaderText = "Total"
        Me.SupTotal.MinimumWidth = 6
        Me.SupTotal.Name = "SupTotal"
        Me.SupTotal.ReadOnly = True
        Me.SupTotal.Width = 67
        '
        'SDetails
        '
        Me.SDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SDetails.HeaderText = "Details"
        Me.SDetails.MinimumWidth = 6
        Me.SDetails.Name = "SDetails"
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(1267, 27)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 32)
        Me.cmdNew.TabIndex = 22
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(1267, 65)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 33)
        Me.cmdSave.TabIndex = 23
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(1267, 104)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 33)
        Me.cmdDelete.TabIndex = 24
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdGetData
        '
        Me.cmdGetData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGetData.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdGetData.Image = CType(resources.GetObject("cmdGetData.Image"), System.Drawing.Image)
        Me.cmdGetData.Location = New System.Drawing.Point(1267, 143)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.Size = New System.Drawing.Size(85, 33)
        Me.cmdGetData.TabIndex = 25
        Me.cmdGetData.Text = "Get Data"
        Me.cmdGetData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdGetData.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(1267, 182)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 33)
        Me.cmdClose.TabIndex = 26
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(961, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Remarks:"
        '
        'txtSupRemarks
        '
        Me.txtSupRemarks.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSupRemarks.Location = New System.Drawing.Point(961, 44)
        Me.txtSupRemarks.Multiline = True
        Me.txtSupRemarks.Name = "txtSupRemarks"
        Me.txtSupRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSupRemarks.Size = New System.Drawing.Size(300, 66)
        Me.txtSupRemarks.TabIndex = 4
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1364, 30)
        Me.MenuStrip.TabIndex = 38
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.GetDataToolStripMenuItem, Me.OpenBarcodeGeneratorToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(76, 26)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(257, 26)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(257, 26)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'GetDataToolStripMenuItem
        '
        Me.GetDataToolStripMenuItem.Name = "GetDataToolStripMenuItem"
        Me.GetDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GetDataToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.GetDataToolStripMenuItem.Text = "Get Data"
        '
        'OpenBarcodeGeneratorToolStripMenuItem
        '
        Me.OpenBarcodeGeneratorToolStripMenuItem.Name = "OpenBarcodeGeneratorToolStripMenuItem"
        Me.OpenBarcodeGeneratorToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.OpenBarcodeGeneratorToolStripMenuItem.Text = "Open Barcode Generator"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierInfoToolStripMenuItem, Me.StockInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(58, 26)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'SupplierInfoToolStripMenuItem
        '
        Me.SupplierInfoToolStripMenuItem.Name = "SupplierInfoToolStripMenuItem"
        Me.SupplierInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.SupplierInfoToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.SupplierInfoToolStripMenuItem.Text = "Supplier Info"
        '
        'StockInfoToolStripMenuItem
        '
        Me.StockInfoToolStripMenuItem.Name = "StockInfoToolStripMenuItem"
        Me.StockInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StockInfoToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.StockInfoToolStripMenuItem.Text = "Stock Info"
        '
        'GroupFinancial
        '
        Me.GroupFinancial.Controls.Add(Me.cmbSupStatus)
        Me.GroupFinancial.Controls.Add(Me.txtSupPaidDate)
        Me.GroupFinancial.Controls.Add(Me.lblSupPaidDate)
        Me.GroupFinancial.Controls.Add(Me.Label8)
        Me.GroupFinancial.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupFinancial.Location = New System.Drawing.Point(653, 27)
        Me.GroupFinancial.Name = "GroupFinancial"
        Me.GroupFinancial.Size = New System.Drawing.Size(302, 83)
        Me.GroupFinancial.TabIndex = 39
        Me.GroupFinancial.TabStop = False
        Me.GroupFinancial.Text = "Financial Info"
        '
        'cmbSupStatus
        '
        Me.cmbSupStatus.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupStatus.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbSupStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSupStatus.FormattingEnabled = True
        Me.cmbSupStatus.Items.AddRange(New Object() {"Not Paid", "Paid"})
        Me.cmbSupStatus.Location = New System.Drawing.Point(60, 25)
        Me.cmbSupStatus.Name = "cmbSupStatus"
        Me.cmbSupStatus.Size = New System.Drawing.Size(115, 29)
        Me.cmbSupStatus.TabIndex = 4
        '
        'txtSupPaidDate
        '
        Me.txtSupPaidDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSupPaidDate.Location = New System.Drawing.Point(80, 53)
        Me.txtSupPaidDate.Name = "txtSupPaidDate"
        Me.txtSupPaidDate.Size = New System.Drawing.Size(216, 28)
        Me.txtSupPaidDate.TabIndex = 1
        '
        'lblSupPaidDate
        '
        Me.lblSupPaidDate.AutoSize = True
        Me.lblSupPaidDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lblSupPaidDate.Location = New System.Drawing.Point(7, 56)
        Me.lblSupPaidDate.Name = "lblSupPaidDate"
        Me.lblSupPaidDate.Size = New System.Drawing.Size(81, 21)
        Me.lblSupPaidDate.TabIndex = 1
        Me.lblSupPaidDate.Text = "Paid Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(7, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Status:"
        '
        'frmSupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 537)
        Me.Controls.Add(Me.GroupFinancial)
        Me.Controls.Add(Me.txtSupRemarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdGetData)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.grdSupply)
        Me.Controls.Add(Me.GroupSupplier)
        Me.Controls.Add(Me.GroupSupply)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmSupply"
        Me.Text = "LASER System - Supply"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupSupply.ResumeLayout(False)
        Me.GroupSupply.PerformLayout()
        Me.GroupSupplier.ResumeLayout(False)
        Me.GroupSupplier.PerformLayout()
        CType(Me.grdSupply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupFinancial.ResumeLayout(False)
        Me.GroupFinancial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupSupply As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSupDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSupNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupSupplier As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbSuName As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSuView As System.Windows.Forms.Button
    Friend WithEvents grdSupply As System.Windows.Forms.DataGridView
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdGetData As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSupRemarks As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GetDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupFinancial As GroupBox
    Friend WithEvents txtSupPaidDate As DateTimePicker
    Friend WithEvents lblSupPaidDate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSupStatus As ComboBox
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SModelNo As DataGridViewTextBoxColumn
    Friend WithEvents SLocation As DataGridViewTextBoxColumn
    Friend WithEvents SSalePrice As DataGridViewTextBoxColumn
    Friend WithEvents SLowestPrice As DataGridViewTextBoxColumn
    Friend WithEvents SMinStocks As DataGridViewTextBoxColumn
    Friend WithEvents SupType As DataGridViewComboBoxColumn
    Friend WithEvents CostPrice As DataGridViewTextBoxColumn
    Friend WithEvents SupQty As DataGridViewTextBoxColumn
    Friend WithEvents SupTotal As DataGridViewTextBoxColumn
    Friend WithEvents SDetails As DataGridViewTextBoxColumn
    Friend WithEvents OpenBarcodeGeneratorToolStripMenuItem As ToolStripMenuItem
End Class
