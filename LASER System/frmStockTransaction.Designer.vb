<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockTransaction))
        Me.grpStock = New System.Windows.Forms.GroupBox()
        Me.cmbSName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbSCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdSupply = New System.Windows.Forms.DataGridView()
        Me.SupDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdSale = New System.Windows.Forms.DataGridView()
        Me.SaDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdTLoan = New System.Windows.Forms.DataGridView()
        Me.TLDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLTName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grdTCost = New System.Windows.Forms.DataGridView()
        Me.TCDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpStock.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdSupply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdTLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdTCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStock
        '
        Me.grpStock.Controls.Add(Me.cmbSName)
        Me.grpStock.Controls.Add(Me.cmbSCategory)
        Me.grpStock.Controls.Add(Me.txtSNo)
        Me.grpStock.Controls.Add(Me.Label9)
        Me.grpStock.Controls.Add(Me.Label2)
        Me.grpStock.Controls.Add(Me.Label1)
        Me.grpStock.Location = New System.Drawing.Point(12, 27)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(437, 82)
        Me.grpStock.TabIndex = 21
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Stock Details"
        '
        'cmbSName
        '
        Me.cmbSName.BackColor = System.Drawing.Color.Transparent
        Me.cmbSName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSName.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSName.FocusedState.Parent = Me.cmbSName
        Me.cmbSName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSName.FormattingEnabled = True
        Me.cmbSName.HoverState.Parent = Me.cmbSName
        Me.cmbSName.ItemHeight = 18
        Me.cmbSName.ItemsAppearance.Parent = Me.cmbSName
        Me.cmbSName.Location = New System.Drawing.Point(78, 53)
        Me.cmbSName.Name = "cmbSName"
        Me.cmbSName.ShadowDecoration.Parent = Me.cmbSName
        Me.cmbSName.Size = New System.Drawing.Size(351, 24)
        Me.cmbSName.TabIndex = 29
        '
        'cmbSCategory
        '
        Me.cmbSCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbSCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSCategory.FocusedState.Parent = Me.cmbSCategory
        Me.cmbSCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSCategory.FormattingEnabled = True
        Me.cmbSCategory.HoverState.Parent = Me.cmbSCategory
        Me.cmbSCategory.ItemHeight = 18
        Me.cmbSCategory.ItemsAppearance.Parent = Me.cmbSCategory
        Me.cmbSCategory.Location = New System.Drawing.Point(78, 23)
        Me.cmbSCategory.Name = "cmbSCategory"
        Me.cmbSCategory.ShadowDecoration.Parent = Me.cmbSCategory
        Me.cmbSCategory.Size = New System.Drawing.Size(220, 24)
        Me.cmbSCategory.TabIndex = 28
        '
        'txtSNo
        '
        Me.txtSNo.Location = New System.Drawing.Point(382, 22)
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.Size = New System.Drawing.Size(47, 24)
        Me.txtSNo.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Stock Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Category :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdSupply)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 299)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply"
        '
        'grdSupply
        '
        Me.grdSupply.AllowUserToAddRows = False
        Me.grdSupply.AllowUserToDeleteRows = False
        Me.grdSupply.AllowUserToOrderColumns = True
        Me.grdSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSupply.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupDate, Me.SuName, Me.SupType, Me.SupCostPrice, Me.SupUnits, Me.SupTotal})
        Me.grdSupply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSupply.Location = New System.Drawing.Point(3, 20)
        Me.grdSupply.Name = "grdSupply"
        Me.grdSupply.ReadOnly = True
        Me.grdSupply.RowHeadersVisible = False
        Me.grdSupply.Size = New System.Drawing.Size(664, 276)
        Me.grdSupply.TabIndex = 0
        '
        'SupDate
        '
        Me.SupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupDate.DataPropertyName = "SupDate"
        Me.SupDate.HeaderText = "Supplied Date"
        Me.SupDate.Name = "SupDate"
        Me.SupDate.ReadOnly = True
        '
        'SuName
        '
        Me.SuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SuName.DataPropertyName = "SuName"
        Me.SuName.HeaderText = "Supplier Name"
        Me.SuName.Name = "SuName"
        Me.SuName.ReadOnly = True
        Me.SuName.Width = 115
        '
        'SupType
        '
        Me.SupType.DataPropertyName = "SupType"
        Me.SupType.HeaderText = "Type"
        Me.SupType.Name = "SupType"
        Me.SupType.ReadOnly = True
        '
        'SupCostPrice
        '
        Me.SupCostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SupCostPrice.DataPropertyName = "SupCostPrice"
        Me.SupCostPrice.HeaderText = "Cost Price"
        Me.SupCostPrice.Name = "SupCostPrice"
        Me.SupCostPrice.ReadOnly = True
        Me.SupCostPrice.Width = 88
        '
        'SupUnits
        '
        Me.SupUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SupUnits.DataPropertyName = "SupUnits"
        Me.SupUnits.HeaderText = "Qty"
        Me.SupUnits.Name = "SupUnits"
        Me.SupUnits.ReadOnly = True
        Me.SupUnits.Width = 53
        '
        'SupTotal
        '
        Me.SupTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SupTotal.DataPropertyName = "SupTotal"
        Me.SupTotal.HeaderText = "Total"
        Me.SupTotal.Name = "SupTotal"
        Me.SupTotal.ReadOnly = True
        Me.SupTotal.Width = 61
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdSale)
        Me.GroupBox2.Location = New System.Drawing.Point(688, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 299)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sale"
        '
        'grdSale
        '
        Me.grdSale.AllowUserToAddRows = False
        Me.grdSale.AllowUserToDeleteRows = False
        Me.grdSale.AllowUserToOrderColumns = True
        Me.grdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaDate, Me.CuName, Me.SaType, Me.SaRate, Me.SaUnits, Me.SaTotal})
        Me.grdSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSale.Location = New System.Drawing.Point(3, 20)
        Me.grdSale.Name = "grdSale"
        Me.grdSale.RowHeadersVisible = False
        Me.grdSale.Size = New System.Drawing.Size(658, 276)
        Me.grdSale.TabIndex = 1
        '
        'SaDate
        '
        Me.SaDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SaDate.DataPropertyName = "SaDate"
        Me.SaDate.HeaderText = "Date"
        Me.SaDate.Name = "SaDate"
        '
        'CuName
        '
        Me.CuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CuName.DataPropertyName = "CuName"
        Me.CuName.HeaderText = "Customer Name"
        Me.CuName.Name = "CuName"
        '
        'SaType
        '
        Me.SaType.DataPropertyName = "SaType"
        Me.SaType.HeaderText = "Type"
        Me.SaType.Name = "SaType"
        '
        'SaRate
        '
        Me.SaRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SaRate.DataPropertyName = "SaRate"
        Me.SaRate.HeaderText = "Rate"
        Me.SaRate.Name = "SaRate"
        Me.SaRate.Width = 60
        '
        'SaUnits
        '
        Me.SaUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SaUnits.DataPropertyName = "SaUnits"
        Me.SaUnits.HeaderText = "Qty"
        Me.SaUnits.Name = "SaUnits"
        Me.SaUnits.Width = 53
        '
        'SaTotal
        '
        Me.SaTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SaTotal.DataPropertyName = "SaTotal"
        Me.SaTotal.HeaderText = "Total"
        Me.SaTotal.Name = "SaTotal"
        Me.SaTotal.Width = 61
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdTLoan)
        Me.GroupBox3.Location = New System.Drawing.Point(688, 420)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(664, 294)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Technician Loan"
        '
        'grdTLoan
        '
        Me.grdTLoan.AllowUserToAddRows = False
        Me.grdTLoan.AllowUserToDeleteRows = False
        Me.grdTLoan.AllowUserToOrderColumns = True
        Me.grdTLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TLDate, Me.TLTName, Me.TLReason, Me.TLRate, Me.TLQty, Me.TLTotal})
        Me.grdTLoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTLoan.Location = New System.Drawing.Point(3, 20)
        Me.grdTLoan.Name = "grdTLoan"
        Me.grdTLoan.RowHeadersVisible = False
        Me.grdTLoan.Size = New System.Drawing.Size(658, 271)
        Me.grdTLoan.TabIndex = 1
        '
        'TLDate
        '
        Me.TLDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TLDate.DataPropertyName = "TLDate"
        Me.TLDate.HeaderText = "Date"
        Me.TLDate.Name = "TLDate"
        '
        'TLTName
        '
        Me.TLTName.DataPropertyName = "TName"
        Me.TLTName.HeaderText = "Technician Name"
        Me.TLTName.Name = "TLTName"
        '
        'TLReason
        '
        Me.TLReason.DataPropertyName = "TLReason"
        Me.TLReason.HeaderText = "Reason"
        Me.TLReason.Name = "TLReason"
        '
        'TLRate
        '
        Me.TLRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLRate.DataPropertyName = "Rate"
        Me.TLRate.HeaderText = "Rate"
        Me.TLRate.Name = "TLRate"
        Me.TLRate.Width = 60
        '
        'TLQty
        '
        Me.TLQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLQty.DataPropertyName = "Qty"
        Me.TLQty.HeaderText = "Qty"
        Me.TLQty.Name = "TLQty"
        Me.TLQty.Width = 53
        '
        'TLTotal
        '
        Me.TLTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLTotal.DataPropertyName = "Total"
        Me.TLTotal.HeaderText = "Total"
        Me.TLTotal.Name = "TLTotal"
        Me.TLTotal.Width = 61
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grdTCost)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 420)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 294)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Technician Cost"
        '
        'grdTCost
        '
        Me.grdTCost.AllowUserToAddRows = False
        Me.grdTCost.AllowUserToDeleteRows = False
        Me.grdTCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTCost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCDate, Me.TName, Me.RepNo, Me.RetNo, Me.TCRemarks, Me.Rate, Me.Qty, Me.Total})
        Me.grdTCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTCost.Location = New System.Drawing.Point(3, 20)
        Me.grdTCost.Name = "grdTCost"
        Me.grdTCost.ReadOnly = True
        Me.grdTCost.RowHeadersVisible = False
        Me.grdTCost.Size = New System.Drawing.Size(664, 271)
        Me.grdTCost.TabIndex = 1
        '
        'TCDate
        '
        Me.TCDate.DataPropertyName = "TCDate"
        Me.TCDate.HeaderText = "Date"
        Me.TCDate.Name = "TCDate"
        Me.TCDate.ReadOnly = True
        '
        'TName
        '
        Me.TName.DataPropertyName = "TName"
        Me.TName.HeaderText = "Technician Name"
        Me.TName.Name = "TName"
        Me.TName.ReadOnly = True
        '
        'RepNo
        '
        Me.RepNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RepNo.DataPropertyName = "RepNo"
        Me.RepNo.HeaderText = "Repair No"
        Me.RepNo.Name = "RepNo"
        Me.RepNo.ReadOnly = True
        Me.RepNo.Width = 82
        '
        'RetNo
        '
        Me.RetNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RetNo.DataPropertyName = "RetNo"
        Me.RetNo.HeaderText = "RERepair No"
        Me.RetNo.Name = "RetNo"
        Me.RetNo.ReadOnly = True
        Me.RetNo.Width = 96
        '
        'TCRemarks
        '
        Me.TCRemarks.DataPropertyName = "TCRemarks"
        Me.TCRemarks.HeaderText = "Remarks"
        Me.TCRemarks.Name = "TCRemarks"
        Me.TCRemarks.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rate.DataPropertyName = "Rate"
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 60
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 53
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 61
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(1252, 70)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 39)
        Me.cmdClose.TabIndex = 26
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDone.Image = CType(resources.GetObject("cmdDone.Image"), System.Drawing.Image)
        Me.cmdDone.Location = New System.Drawing.Point(1252, 27)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(100, 37)
        Me.cmdDone.TabIndex = 27
        Me.cmdDone.Text = "Done"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1364, 24)
        Me.MenuStrip.TabIndex = 28
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'DoneToolStripMenuItem
        '
        Me.DoneToolStripMenuItem.Name = "DoneToolStripMenuItem"
        Me.DoneToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DoneToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DoneToolStripMenuItem.Text = "Done"
        '
        'frmStockTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpStock)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Name = "frmStockTransaction"
        Me.Text = "LASER System - Stock Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpStock.ResumeLayout(False)
        Me.grpStock.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdSupply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdTLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grdTCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpStock As GroupBox
    Friend WithEvents txtSNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents grdSupply As DataGridView
    Friend WithEvents grdSale As DataGridView
    Friend WithEvents grdTLoan As DataGridView
    Friend WithEvents grdTCost As DataGridView
    Friend WithEvents cmdDone As Button
    Friend WithEvents SupDate As DataGridViewTextBoxColumn
    Friend WithEvents SuName As DataGridViewTextBoxColumn
    Friend WithEvents SupType As DataGridViewTextBoxColumn
    Friend WithEvents SupCostPrice As DataGridViewTextBoxColumn
    Friend WithEvents SupUnits As DataGridViewTextBoxColumn
    Friend WithEvents SupTotal As DataGridViewTextBoxColumn
    Friend WithEvents SaDate As DataGridViewTextBoxColumn
    Friend WithEvents CuName As DataGridViewTextBoxColumn
    Friend WithEvents SaType As DataGridViewTextBoxColumn
    Friend WithEvents SaRate As DataGridViewTextBoxColumn
    Friend WithEvents SaUnits As DataGridViewTextBoxColumn
    Friend WithEvents SaTotal As DataGridViewTextBoxColumn
    Friend WithEvents TLDate As DataGridViewTextBoxColumn
    Friend WithEvents TLTName As DataGridViewTextBoxColumn
    Friend WithEvents TLReason As DataGridViewTextBoxColumn
    Friend WithEvents TLRate As DataGridViewTextBoxColumn
    Friend WithEvents TLQty As DataGridViewTextBoxColumn
    Friend WithEvents TLTotal As DataGridViewTextBoxColumn
    Friend WithEvents TCDate As DataGridViewTextBoxColumn
    Friend WithEvents TName As DataGridViewTextBoxColumn
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents RetNo As DataGridViewTextBoxColumn
    Friend WithEvents TCRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cmbSCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoneToolStripMenuItem As ToolStripMenuItem
End Class
