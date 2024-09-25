<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettlement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettlement))
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.lblCashinLocker = New System.Windows.Forms.Label()
        Me.txtLockerCash = New System.Windows.Forms.TextBox()
        Me.lblCTotal = New System.Windows.Forms.Label()
        Me.txtCTotal = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtCPTotal = New System.Windows.Forms.TextBox()
        Me.lblCPTotal = New System.Windows.Forms.Label()
        Me.txtCuLTotal = New System.Windows.Forms.TextBox()
        Me.lblCuLTotal = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.tabSettlement = New System.Windows.Forms.TabControl()
        Me.tpSales = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grdStockSale = New System.Windows.Forms.DataGridView()
        Me.grdSale = New System.Windows.Forms.DataGridView()
        Me.SaNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaLess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuLNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuLAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalofSales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalofSales = New System.Windows.Forms.TextBox()
        Me.tpRepairs = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grdDeliver = New System.Windows.Forms.DataGridView()
        Me.DNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGrandTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdRERepair = New System.Windows.Forms.DataGridView()
        Me.grdRepair = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotalofRepairs = New System.Windows.Forms.TextBox()
        Me.lblTotalofRepairs = New System.Windows.Forms.Label()
        Me.tpTransactions = New System.Windows.Forms.TabPage()
        Me.grdTransaction = New System.Windows.Forms.DataGridView()
        Me.TANo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TADate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TADetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTADate = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalofTransactions = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdTADelete = New System.Windows.Forms.Button()
        Me.cmdTASave = New System.Windows.Forms.Button()
        Me.cmdTANew = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTAAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTADetails = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTANo = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtLKR5000 = New System.Windows.Forms.TextBox()
        Me.lblLKR5000 = New System.Windows.Forms.Label()
        Me.txtLKR1000 = New System.Windows.Forms.TextBox()
        Me.lblLKR1000 = New System.Windows.Forms.Label()
        Me.txtLKR500 = New System.Windows.Forms.TextBox()
        Me.lblLKR500 = New System.Windows.Forms.Label()
        Me.txtLKR100 = New System.Windows.Forms.TextBox()
        Me.lblLKR100 = New System.Windows.Forms.Label()
        Me.txtLKR5 = New System.Windows.Forms.TextBox()
        Me.lblLKR50 = New System.Windows.Forms.Label()
        Me.txtLKR50 = New System.Windows.Forms.TextBox()
        Me.lblLKR20 = New System.Windows.Forms.Label()
        Me.txtLKR2 = New System.Windows.Forms.TextBox()
        Me.lblLKR10 = New System.Windows.Forms.Label()
        Me.txtLKR20 = New System.Windows.Forms.TextBox()
        Me.lblLKR5 = New System.Windows.Forms.Label()
        Me.txtLKR10 = New System.Windows.Forms.TextBox()
        Me.lblLKR2 = New System.Windows.Forms.Label()
        Me.txtCPQtyInvoice = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblLKR1 = New System.Windows.Forms.Label()
        Me.txtLKR1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tabSettlement.SuspendLayout()
        Me.tpSales.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grdStockSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tpRepairs.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.grdDeliver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRERepair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tpTransactions.SuspendLayout()
        CType(Me.grdTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(10, 136)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(53, 14)
        Me.lblIncome.TabIndex = 3
        Me.lblIncome.Text = "Income :"
        '
        'txtIncome
        '
        Me.txtIncome.Enabled = False
        Me.txtIncome.Location = New System.Drawing.Point(171, 133)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(80, 22)
        Me.txtIncome.TabIndex = 4
        Me.txtIncome.Text = "0"
        '
        'lblCashinLocker
        '
        Me.lblCashinLocker.AutoSize = True
        Me.lblCashinLocker.Location = New System.Drawing.Point(6, 472)
        Me.lblCashinLocker.Name = "lblCashinLocker"
        Me.lblCashinLocker.Size = New System.Drawing.Size(87, 14)
        Me.lblCashinLocker.TabIndex = 5
        Me.lblCashinLocker.Text = "Cash in Locker:"
        '
        'txtLockerCash
        '
        Me.txtLockerCash.Location = New System.Drawing.Point(169, 469)
        Me.txtLockerCash.Name = "txtLockerCash"
        Me.txtLockerCash.Size = New System.Drawing.Size(80, 22)
        Me.txtLockerCash.TabIndex = 6
        Me.txtLockerCash.Text = "0"
        '
        'lblCTotal
        '
        Me.lblCTotal.AutoSize = True
        Me.lblCTotal.Location = New System.Drawing.Point(8, 24)
        Me.lblCTotal.Name = "lblCTotal"
        Me.lblCTotal.Size = New System.Drawing.Size(92, 14)
        Me.lblCTotal.TabIndex = 7
        Me.lblCTotal.Text = "Total (By Cash) :"
        '
        'txtCTotal
        '
        Me.txtCTotal.Enabled = False
        Me.txtCTotal.Location = New System.Drawing.Point(169, 21)
        Me.txtCTotal.Name = "txtCTotal"
        Me.txtCTotal.Size = New System.Drawing.Size(80, 22)
        Me.txtCTotal.TabIndex = 8
        Me.txtCTotal.Text = "0"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(988, 27)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(62, 35)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(12, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 22)
        Me.Label35.TabIndex = 110
        Me.Label35.Text = "Date: "
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(297, 26)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(82, 25)
        Me.cmdSearch.TabIndex = 109
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(67, 27)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(224, 22)
        Me.txtFrom.TabIndex = 107
        Me.txtFrom.Value = New Date(2020, 4, 1, 0, 0, 0, 0)
        '
        'txtCPTotal
        '
        Me.txtCPTotal.Enabled = False
        Me.txtCPTotal.Location = New System.Drawing.Point(169, 49)
        Me.txtCPTotal.Name = "txtCPTotal"
        Me.txtCPTotal.Size = New System.Drawing.Size(80, 22)
        Me.txtCPTotal.TabIndex = 115
        Me.txtCPTotal.Text = "0"
        '
        'lblCPTotal
        '
        Me.lblCPTotal.AutoSize = True
        Me.lblCPTotal.Location = New System.Drawing.Point(8, 52)
        Me.lblCPTotal.Name = "lblCPTotal"
        Me.lblCPTotal.Size = New System.Drawing.Size(139, 14)
        Me.lblCPTotal.TabIndex = 114
        Me.lblCPTotal.Text = "Total (By Card Payment) :"
        '
        'txtCuLTotal
        '
        Me.txtCuLTotal.Enabled = False
        Me.txtCuLTotal.Location = New System.Drawing.Point(169, 77)
        Me.txtCuLTotal.Name = "txtCuLTotal"
        Me.txtCuLTotal.Size = New System.Drawing.Size(80, 22)
        Me.txtCuLTotal.TabIndex = 117
        Me.txtCuLTotal.Text = "0"
        '
        'lblCuLTotal
        '
        Me.lblCuLTotal.AutoSize = True
        Me.lblCuLTotal.Location = New System.Drawing.Point(8, 80)
        Me.lblCuLTotal.Name = "lblCuLTotal"
        Me.lblCuLTotal.Size = New System.Drawing.Size(146, 14)
        Me.lblCuLTotal.TabIndex = 116
        Me.lblCuLTotal.Text = "Total (By Customer Loan) :"
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Location = New System.Drawing.Point(169, 497)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(80, 22)
        Me.txtChange.TabIndex = 119
        Me.txtChange.Text = "0"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(8, 500)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(102, 14)
        Me.lblChange.TabIndex = 118
        Me.lblChange.Text = "Change (By Cash):"
        '
        'tabSettlement
        '
        Me.tabSettlement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSettlement.Controls.Add(Me.tpSales)
        Me.tabSettlement.Controls.Add(Me.tpRepairs)
        Me.tabSettlement.Controls.Add(Me.tpTransactions)
        Me.tabSettlement.Location = New System.Drawing.Point(12, 52)
        Me.tabSettlement.Name = "tabSettlement"
        Me.tabSettlement.SelectedIndex = 0
        Me.tabSettlement.Size = New System.Drawing.Size(777, 555)
        Me.tabSettlement.TabIndex = 121
        '
        'tpSales
        '
        Me.tpSales.Controls.Add(Me.TableLayoutPanel1)
        Me.tpSales.Location = New System.Drawing.Point(4, 23)
        Me.tpSales.Name = "tpSales"
        Me.tpSales.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSales.Size = New System.Drawing.Size(769, 528)
        Me.tpSales.TabIndex = 0
        Me.tpSales.Text = "Sales"
        Me.tpSales.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.grdStockSale, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grdSale, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(763, 522)
        Me.TableLayoutPanel1.TabIndex = 125
        '
        'grdStockSale
        '
        Me.grdStockSale.AllowUserToAddRows = False
        Me.grdStockSale.AllowUserToDeleteRows = False
        Me.grdStockSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdStockSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdStockSale.Location = New System.Drawing.Point(3, 244)
        Me.grdStockSale.Name = "grdStockSale"
        Me.grdStockSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdStockSale.Size = New System.Drawing.Size(757, 235)
        Me.grdStockSale.TabIndex = 124
        '
        'grdSale
        '
        Me.grdSale.AllowUserToAddRows = False
        Me.grdSale.AllowUserToDeleteRows = False
        Me.grdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaNo, Me.CuName, Me.CuTelNo1, Me.SaSubTotal, Me.SaLess, Me.SaDue, Me.CReceived, Me.CBalance, Me.CAmount, Me.CPInvoiceNo, Me.CPAmount, Me.CuLNo, Me.CuLAmount, Me.SaRemarks})
        Me.grdSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSale.Location = New System.Drawing.Point(3, 3)
        Me.grdSale.Name = "grdSale"
        Me.grdSale.ReadOnly = True
        Me.grdSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSale.Size = New System.Drawing.Size(757, 235)
        Me.grdSale.TabIndex = 7
        '
        'SaNo
        '
        Me.SaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaNo.DataPropertyName = "SaNo"
        Me.SaNo.HeaderText = "Sale No"
        Me.SaNo.Name = "SaNo"
        Me.SaNo.ReadOnly = True
        Me.SaNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SaNo.Width = 50
        '
        'CuName
        '
        Me.CuName.DataPropertyName = "CuName"
        Me.CuName.HeaderText = "Customer Name"
        Me.CuName.Name = "CuName"
        Me.CuName.ReadOnly = True
        Me.CuName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CuTelNo1
        '
        Me.CuTelNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo1.DataPropertyName = "CuTelNo1"
        Me.CuTelNo1.HeaderText = "Customer Telephone No1"
        Me.CuTelNo1.Name = "CuTelNo1"
        Me.CuTelNo1.ReadOnly = True
        Me.CuTelNo1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CuTelNo1.Width = 115
        '
        'SaSubTotal
        '
        Me.SaSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaSubTotal.DataPropertyName = "SaSubTotal"
        Me.SaSubTotal.HeaderText = "Sub Total"
        Me.SaSubTotal.Name = "SaSubTotal"
        Me.SaSubTotal.ReadOnly = True
        Me.SaSubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SaSubTotal.Width = 57
        '
        'SaLess
        '
        Me.SaLess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaLess.DataPropertyName = "SaLess"
        Me.SaLess.HeaderText = "Less"
        Me.SaLess.Name = "SaLess"
        Me.SaLess.ReadOnly = True
        Me.SaLess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SaLess.Width = 37
        '
        'SaDue
        '
        Me.SaDue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaDue.DataPropertyName = "SaDue"
        Me.SaDue.HeaderText = "Due"
        Me.SaDue.Name = "SaDue"
        Me.SaDue.ReadOnly = True
        Me.SaDue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SaDue.Width = 35
        '
        'CReceived
        '
        Me.CReceived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CReceived.DataPropertyName = "CReceived"
        Me.CReceived.HeaderText = "Received"
        Me.CReceived.Name = "CReceived"
        Me.CReceived.ReadOnly = True
        Me.CReceived.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CReceived.Width = 62
        '
        'CBalance
        '
        Me.CBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CBalance.DataPropertyName = "CBalance"
        Me.CBalance.HeaderText = "Balance"
        Me.CBalance.Name = "CBalance"
        Me.CBalance.ReadOnly = True
        Me.CBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CBalance.Width = 57
        '
        'CAmount
        '
        Me.CAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CAmount.DataPropertyName = "CAmount"
        Me.CAmount.HeaderText = "Cash Amount"
        Me.CAmount.Name = "CAmount"
        Me.CAmount.ReadOnly = True
        Me.CAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CAmount.Width = 76
        '
        'CPInvoiceNo
        '
        Me.CPInvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CPInvoiceNo.DataPropertyName = "CPInvoiceNo"
        Me.CPInvoiceNo.HeaderText = "Card Payment Invoice No"
        Me.CPInvoiceNo.Name = "CPInvoiceNo"
        Me.CPInvoiceNo.ReadOnly = True
        Me.CPInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CPInvoiceNo.Width = 118
        '
        'CPAmount
        '
        Me.CPAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CPAmount.DataPropertyName = "CPAmount"
        Me.CPAmount.HeaderText = "Card Payment Amount"
        Me.CPAmount.Name = "CPAmount"
        Me.CPAmount.ReadOnly = True
        Me.CPAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CPAmount.Width = 118
        '
        'CuLNo
        '
        Me.CuLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuLNo.DataPropertyName = "CuLNo"
        Me.CuLNo.HeaderText = "Customer Loan No"
        Me.CuLNo.Name = "CuLNo"
        Me.CuLNo.ReadOnly = True
        Me.CuLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CuLNo.Width = 87
        '
        'CuLAmount
        '
        Me.CuLAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuLAmount.DataPropertyName = "CuLAmount"
        Me.CuLAmount.HeaderText = "Customer Loan Amount"
        Me.CuLAmount.Name = "CuLAmount"
        Me.CuLAmount.ReadOnly = True
        Me.CuLAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CuLAmount.Width = 87
        '
        'SaRemarks
        '
        Me.SaRemarks.DataPropertyName = "SaRemarks"
        Me.SaRemarks.HeaderText = "Remarks"
        Me.SaRemarks.Name = "SaRemarks"
        Me.SaRemarks.ReadOnly = True
        Me.SaRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotalofSales)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTotalofSales)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 34)
        Me.Panel1.TabIndex = 125
        '
        'lblTotalofSales
        '
        Me.lblTotalofSales.AutoSize = True
        Me.lblTotalofSales.Location = New System.Drawing.Point(6, 12)
        Me.lblTotalofSales.Name = "lblTotalofSales"
        Me.lblTotalofSales.Size = New System.Drawing.Size(87, 14)
        Me.lblTotalofSales.TabIndex = 8
        Me.lblTotalofSales.Text = "Total of Sales: "
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(99, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 22)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Rs."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalofSales
        '
        Me.txtTotalofSales.Enabled = False
        Me.txtTotalofSales.Location = New System.Drawing.Point(124, 9)
        Me.txtTotalofSales.Name = "txtTotalofSales"
        Me.txtTotalofSales.Size = New System.Drawing.Size(82, 22)
        Me.txtTotalofSales.TabIndex = 9
        Me.txtTotalofSales.Text = "0"
        '
        'tpRepairs
        '
        Me.tpRepairs.Controls.Add(Me.TableLayoutPanel2)
        Me.tpRepairs.Location = New System.Drawing.Point(4, 23)
        Me.tpRepairs.Name = "tpRepairs"
        Me.tpRepairs.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRepairs.Size = New System.Drawing.Size(769, 528)
        Me.tpRepairs.TabIndex = 1
        Me.tpRepairs.Text = "Repairs"
        Me.tpRepairs.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.grdDeliver, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.grdRERepair, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.grdRepair, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(763, 522)
        Me.TableLayoutPanel2.TabIndex = 127
        '
        'grdDeliver
        '
        Me.grdDeliver.AllowUserToAddRows = False
        Me.grdDeliver.AllowUserToDeleteRows = False
        Me.grdDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDeliver.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DGrandTotal, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DRemarks})
        Me.TableLayoutPanel2.SetColumnSpan(Me.grdDeliver, 2)
        Me.grdDeliver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDeliver.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdDeliver.Location = New System.Drawing.Point(3, 3)
        Me.grdDeliver.MultiSelect = False
        Me.grdDeliver.Name = "grdDeliver"
        Me.grdDeliver.ReadOnly = True
        Me.grdDeliver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDeliver.Size = New System.Drawing.Size(757, 235)
        Me.grdDeliver.TabIndex = 7
        '
        'DNo
        '
        Me.DNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DNo.DataPropertyName = "DNo"
        Me.DNo.HeaderText = "Deliver No"
        Me.DNo.Name = "DNo"
        Me.DNo.ReadOnly = True
        Me.DNo.Width = 82
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CuName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CuTelNo1"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Telephone No1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 134
        '
        'DGrandTotal
        '
        Me.DGrandTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGrandTotal.DataPropertyName = "DGrandTotal"
        Me.DGrandTotal.HeaderText = "Total Amount"
        Me.DGrandTotal.Name = "DGrandTotal"
        Me.DGrandTotal.ReadOnly = True
        Me.DGrandTotal.Width = 96
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CReceived"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Received"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CBalance"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 76
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CAmount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cash Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CPInvoiceNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Card Payment Invoice No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 137
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CPAmount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Card Payment Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 137
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CuLNo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Customer Loan No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 106
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CuLAmount"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Customer Loan Amount"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 106
        '
        'DRemarks
        '
        Me.DRemarks.DataPropertyName = "DRemarks"
        Me.DRemarks.HeaderText = "Remarks"
        Me.DRemarks.Name = "DRemarks"
        Me.DRemarks.ReadOnly = True
        '
        'grdRERepair
        '
        Me.grdRERepair.AllowUserToAddRows = False
        Me.grdRERepair.AllowUserToDeleteRows = False
        Me.grdRERepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRERepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRERepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdRERepair.Location = New System.Drawing.Point(384, 244)
        Me.grdRERepair.Name = "grdRERepair"
        Me.grdRERepair.ReadOnly = True
        Me.grdRERepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRERepair.Size = New System.Drawing.Size(376, 235)
        Me.grdRERepair.TabIndex = 126
        '
        'grdRepair
        '
        Me.grdRepair.AllowUserToAddRows = False
        Me.grdRepair.AllowUserToDeleteRows = False
        Me.grdRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdRepair.Location = New System.Drawing.Point(3, 244)
        Me.grdRepair.Name = "grdRepair"
        Me.grdRepair.ReadOnly = True
        Me.grdRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepair.Size = New System.Drawing.Size(375, 235)
        Me.grdRepair.TabIndex = 125
        '
        'Panel2
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.txtTotalofRepairs)
        Me.Panel2.Controls.Add(Me.lblTotalofRepairs)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 485)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 34)
        Me.Panel2.TabIndex = 127
        '
        'txtTotalofRepairs
        '
        Me.txtTotalofRepairs.Enabled = False
        Me.txtTotalofRepairs.Location = New System.Drawing.Point(110, 7)
        Me.txtTotalofRepairs.Name = "txtTotalofRepairs"
        Me.txtTotalofRepairs.Size = New System.Drawing.Size(82, 22)
        Me.txtTotalofRepairs.TabIndex = 9
        Me.txtTotalofRepairs.Text = "0"
        '
        'lblTotalofRepairs
        '
        Me.lblTotalofRepairs.AutoSize = True
        Me.lblTotalofRepairs.Location = New System.Drawing.Point(8, 10)
        Me.lblTotalofRepairs.Name = "lblTotalofRepairs"
        Me.lblTotalofRepairs.Size = New System.Drawing.Size(96, 14)
        Me.lblTotalofRepairs.TabIndex = 8
        Me.lblTotalofRepairs.Text = "Total of Repairs:"
        '
        'tpTransactions
        '
        Me.tpTransactions.Controls.Add(Me.grdTransaction)
        Me.tpTransactions.Controls.Add(Me.GroupBox1)
        Me.tpTransactions.Location = New System.Drawing.Point(4, 23)
        Me.tpTransactions.Name = "tpTransactions"
        Me.tpTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTransactions.Size = New System.Drawing.Size(769, 528)
        Me.tpTransactions.TabIndex = 2
        Me.tpTransactions.Text = "Transactions"
        Me.tpTransactions.UseVisualStyleBackColor = True
        '
        'grdTransaction
        '
        Me.grdTransaction.AllowUserToAddRows = False
        Me.grdTransaction.AllowUserToDeleteRows = False
        Me.grdTransaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TANo, Me.TADate, Me.TADetails, Me.TAAmount})
        Me.grdTransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdTransaction.Location = New System.Drawing.Point(6, 273)
        Me.grdTransaction.Name = "grdTransaction"
        Me.grdTransaction.ReadOnly = True
        Me.grdTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTransaction.Size = New System.Drawing.Size(757, 249)
        Me.grdTransaction.TabIndex = 1
        '
        'TANo
        '
        Me.TANo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.TANo.DataPropertyName = "TANo"
        Me.TANo.HeaderText = "Transactions No"
        Me.TANo.Name = "TANo"
        Me.TANo.ReadOnly = True
        Me.TANo.Visible = False
        '
        'TADate
        '
        Me.TADate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TADate.DataPropertyName = "TADate"
        Me.TADate.HeaderText = "Date"
        Me.TADate.Name = "TADate"
        Me.TADate.ReadOnly = True
        Me.TADate.Width = 58
        '
        'TADetails
        '
        Me.TADetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TADetails.DataPropertyName = "TADetails"
        Me.TADetails.HeaderText = "Details"
        Me.TADetails.Name = "TADetails"
        Me.TADetails.ReadOnly = True
        '
        'TAAmount
        '
        Me.TAAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TAAmount.DataPropertyName = "TAAmount"
        Me.TAAmount.HeaderText = "Amount"
        Me.TAAmount.Name = "TAAmount"
        Me.TAAmount.ReadOnly = True
        Me.TAAmount.Width = 74
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpTADate)
        Me.GroupBox1.Controls.Add(Me.txtTotalofTransactions)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmdTADelete)
        Me.GroupBox1.Controls.Add(Me.cmdTASave)
        Me.GroupBox1.Controls.Add(Me.cmdTANew)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtTAAmount)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTADetails)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTANo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transations Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Date:"
        '
        'dtpTADate
        '
        Me.dtpTADate.Location = New System.Drawing.Point(69, 18)
        Me.dtpTADate.Name = "dtpTADate"
        Me.dtpTADate.Size = New System.Drawing.Size(233, 22)
        Me.dtpTADate.TabIndex = 108
        Me.dtpTADate.Value = New Date(2020, 4, 1, 0, 0, 0, 0)
        '
        'txtTotalofTransactions
        '
        Me.txtTotalofTransactions.Enabled = False
        Me.txtTotalofTransactions.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalofTransactions.Location = New System.Drawing.Point(139, 225)
        Me.txtTotalofTransactions.Name = "txtTotalofTransactions"
        Me.txtTotalofTransactions.Size = New System.Drawing.Size(119, 22)
        Me.txtTotalofTransactions.TabIndex = 102
        Me.txtTotalofTransactions.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 14)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Total of Transactions:"
        '
        'cmdTADelete
        '
        Me.cmdTADelete.Image = Global.LASER_System.My.Resources.Resources.Delete
        Me.cmdTADelete.Location = New System.Drawing.Point(416, 216)
        Me.cmdTADelete.Name = "cmdTADelete"
        Me.cmdTADelete.Size = New System.Drawing.Size(75, 39)
        Me.cmdTADelete.TabIndex = 100
        Me.cmdTADelete.Text = "Delete"
        Me.cmdTADelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTADelete.UseVisualStyleBackColor = True
        '
        'cmdTASave
        '
        Me.cmdTASave.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.cmdTASave.Location = New System.Drawing.Point(340, 216)
        Me.cmdTASave.Name = "cmdTASave"
        Me.cmdTASave.Size = New System.Drawing.Size(70, 39)
        Me.cmdTASave.TabIndex = 99
        Me.cmdTASave.Text = "Save"
        Me.cmdTASave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTASave.UseVisualStyleBackColor = True
        '
        'cmdTANew
        '
        Me.cmdTANew.Image = Global.LASER_System.My.Resources.Resources._new
        Me.cmdTANew.Location = New System.Drawing.Point(264, 216)
        Me.cmdTANew.Name = "cmdTANew"
        Me.cmdTANew.Size = New System.Drawing.Size(70, 39)
        Me.cmdTANew.TabIndex = 98
        Me.cmdTANew.Text = "New"
        Me.cmdTANew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTANew.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(68, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 22)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "Rs."
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTAAmount
        '
        Me.txtTAAmount.Location = New System.Drawing.Point(93, 174)
        Me.txtTAAmount.Name = "txtTAAmount"
        Me.txtTAAmount.Size = New System.Drawing.Size(81, 22)
        Me.txtTAAmount.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 14)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Amount:"
        '
        'txtTADetails
        '
        Me.txtTADetails.Location = New System.Drawing.Point(69, 46)
        Me.txtTADetails.Multiline = True
        Me.txtTADetails.Name = "txtTADetails"
        Me.txtTADetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTADetails.Size = New System.Drawing.Size(422, 122)
        Me.txtTADetails.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Details:"
        '
        'txtTANo
        '
        Me.txtTANo.Enabled = False
        Me.txtTANo.Location = New System.Drawing.Point(434, 18)
        Me.txtTANo.Name = "txtTANo"
        Me.txtTANo.Size = New System.Drawing.Size(57, 22)
        Me.txtTANo.TabIndex = 2
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(911, 27)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(71, 35)
        Me.cmdPrint.TabIndex = 122
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'txtLKR5000
        '
        Me.txtLKR5000.Location = New System.Drawing.Point(115, 21)
        Me.txtLKR5000.Name = "txtLKR5000"
        Me.txtLKR5000.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR5000.TabIndex = 124
        Me.txtLKR5000.Text = "0"
        '
        'lblLKR5000
        '
        Me.lblLKR5000.AutoSize = True
        Me.lblLKR5000.Location = New System.Drawing.Point(19, 24)
        Me.lblLKR5000.Name = "lblLKR5000"
        Me.lblLKR5000.Size = New System.Drawing.Size(50, 14)
        Me.lblLKR5000.TabIndex = 123
        Me.lblLKR5000.Text = "Rs. 5000"
        '
        'txtLKR1000
        '
        Me.txtLKR1000.Location = New System.Drawing.Point(115, 49)
        Me.txtLKR1000.Name = "txtLKR1000"
        Me.txtLKR1000.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR1000.TabIndex = 125
        Me.txtLKR1000.Text = "0"
        '
        'lblLKR1000
        '
        Me.lblLKR1000.AutoSize = True
        Me.lblLKR1000.Location = New System.Drawing.Point(19, 52)
        Me.lblLKR1000.Name = "lblLKR1000"
        Me.lblLKR1000.Size = New System.Drawing.Size(50, 14)
        Me.lblLKR1000.TabIndex = 125
        Me.lblLKR1000.Text = "Rs. 1000"
        '
        'txtLKR500
        '
        Me.txtLKR500.Location = New System.Drawing.Point(115, 77)
        Me.txtLKR500.Name = "txtLKR500"
        Me.txtLKR500.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR500.TabIndex = 126
        Me.txtLKR500.Text = "0"
        '
        'lblLKR500
        '
        Me.lblLKR500.AutoSize = True
        Me.lblLKR500.Location = New System.Drawing.Point(19, 80)
        Me.lblLKR500.Name = "lblLKR500"
        Me.lblLKR500.Size = New System.Drawing.Size(44, 14)
        Me.lblLKR500.TabIndex = 127
        Me.lblLKR500.Text = "Rs. 500"
        '
        'txtLKR100
        '
        Me.txtLKR100.Location = New System.Drawing.Point(115, 105)
        Me.txtLKR100.Name = "txtLKR100"
        Me.txtLKR100.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR100.TabIndex = 127
        Me.txtLKR100.Text = "0"
        '
        'lblLKR100
        '
        Me.lblLKR100.AutoSize = True
        Me.lblLKR100.Location = New System.Drawing.Point(19, 111)
        Me.lblLKR100.Name = "lblLKR100"
        Me.lblLKR100.Size = New System.Drawing.Size(44, 14)
        Me.lblLKR100.TabIndex = 129
        Me.lblLKR100.Text = "Rs. 100"
        '
        'txtLKR5
        '
        Me.txtLKR5.Location = New System.Drawing.Point(115, 217)
        Me.txtLKR5.Name = "txtLKR5"
        Me.txtLKR5.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR5.TabIndex = 131
        Me.txtLKR5.Text = "0"
        '
        'lblLKR50
        '
        Me.lblLKR50.AutoSize = True
        Me.lblLKR50.Location = New System.Drawing.Point(19, 136)
        Me.lblLKR50.Name = "lblLKR50"
        Me.lblLKR50.Size = New System.Drawing.Size(38, 14)
        Me.lblLKR50.TabIndex = 131
        Me.lblLKR50.Text = "Rs. 50"
        '
        'txtLKR50
        '
        Me.txtLKR50.Location = New System.Drawing.Point(115, 133)
        Me.txtLKR50.Name = "txtLKR50"
        Me.txtLKR50.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR50.TabIndex = 128
        Me.txtLKR50.Text = "0"
        '
        'lblLKR20
        '
        Me.lblLKR20.AutoSize = True
        Me.lblLKR20.Location = New System.Drawing.Point(19, 164)
        Me.lblLKR20.Name = "lblLKR20"
        Me.lblLKR20.Size = New System.Drawing.Size(38, 14)
        Me.lblLKR20.TabIndex = 133
        Me.lblLKR20.Text = "Rs. 20"
        '
        'txtLKR2
        '
        Me.txtLKR2.Location = New System.Drawing.Point(115, 245)
        Me.txtLKR2.Name = "txtLKR2"
        Me.txtLKR2.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR2.TabIndex = 132
        Me.txtLKR2.Text = "0"
        '
        'lblLKR10
        '
        Me.lblLKR10.AutoSize = True
        Me.lblLKR10.Location = New System.Drawing.Point(19, 192)
        Me.lblLKR10.Name = "lblLKR10"
        Me.lblLKR10.Size = New System.Drawing.Size(38, 14)
        Me.lblLKR10.TabIndex = 135
        Me.lblLKR10.Text = "Rs. 10"
        '
        'txtLKR20
        '
        Me.txtLKR20.Location = New System.Drawing.Point(115, 161)
        Me.txtLKR20.Name = "txtLKR20"
        Me.txtLKR20.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR20.TabIndex = 129
        Me.txtLKR20.Text = "0"
        '
        'lblLKR5
        '
        Me.lblLKR5.AutoSize = True
        Me.lblLKR5.Location = New System.Drawing.Point(19, 220)
        Me.lblLKR5.Name = "lblLKR5"
        Me.lblLKR5.Size = New System.Drawing.Size(32, 14)
        Me.lblLKR5.TabIndex = 137
        Me.lblLKR5.Text = "Rs. 5"
        '
        'txtLKR10
        '
        Me.txtLKR10.Location = New System.Drawing.Point(115, 189)
        Me.txtLKR10.Name = "txtLKR10"
        Me.txtLKR10.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR10.TabIndex = 130
        Me.txtLKR10.Text = "0"
        '
        'lblLKR2
        '
        Me.lblLKR2.AutoSize = True
        Me.lblLKR2.Location = New System.Drawing.Point(19, 248)
        Me.lblLKR2.Name = "lblLKR2"
        Me.lblLKR2.Size = New System.Drawing.Size(32, 14)
        Me.lblLKR2.TabIndex = 139
        Me.lblLKR2.Text = "Rs. 2"
        '
        'txtCPQtyInvoice
        '
        Me.txtCPQtyInvoice.Enabled = False
        Me.txtCPQtyInvoice.Location = New System.Drawing.Point(204, 105)
        Me.txtCPQtyInvoice.Name = "txtCPQtyInvoice"
        Me.txtCPQtyInvoice.Size = New System.Drawing.Size(45, 22)
        Me.txtCPQtyInvoice.TabIndex = 144
        Me.txtCPQtyInvoice.Text = "0"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(8, 108)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(189, 14)
        Me.lblQty.TabIndex = 143
        Me.lblQty.Text = "Quantity of Card Payment Receipt:"
        '
        'lblLKR1
        '
        Me.lblLKR1.AutoSize = True
        Me.lblLKR1.Location = New System.Drawing.Point(19, 276)
        Me.lblLKR1.Name = "lblLKR1"
        Me.lblLKR1.Size = New System.Drawing.Size(32, 14)
        Me.lblLKR1.TabIndex = 146
        Me.lblLKR1.Text = "Rs. 1"
        '
        'txtLKR1
        '
        Me.txtLKR1.Location = New System.Drawing.Point(115, 273)
        Me.txtLKR1.Name = "txtLKR1"
        Me.txtLKR1.Size = New System.Drawing.Size(40, 22)
        Me.txtLKR1.TabIndex = 133
        Me.txtLKR1.Text = "0"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1062, 24)
        Me.MenuStrip.TabIndex = 147
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.PrintToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtIncome)
        Me.GroupBox2.Controls.Add(Me.lblIncome)
        Me.GroupBox2.Controls.Add(Me.lblCTotal)
        Me.GroupBox2.Controls.Add(Me.txtCPQtyInvoice)
        Me.GroupBox2.Controls.Add(Me.txtCTotal)
        Me.GroupBox2.Controls.Add(Me.lblQty)
        Me.GroupBox2.Controls.Add(Me.txtCPTotal)
        Me.GroupBox2.Controls.Add(Me.lblCPTotal)
        Me.GroupBox2.Controls.Add(Me.lblCuLTotal)
        Me.GroupBox2.Controls.Add(Me.txtChange)
        Me.GroupBox2.Controls.Add(Me.txtCuLTotal)
        Me.GroupBox2.Controls.Add(Me.lblChange)
        Me.GroupBox2.Controls.Add(Me.txtLockerCash)
        Me.GroupBox2.Controls.Add(Me.lblCashinLocker)
        Me.GroupBox2.Location = New System.Drawing.Point(795, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 532)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settlement Info"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLKR5)
        Me.GroupBox3.Controls.Add(Me.txtLKR5000)
        Me.GroupBox3.Controls.Add(Me.lblLKR500)
        Me.GroupBox3.Controls.Add(Me.lblLKR5000)
        Me.GroupBox3.Controls.Add(Me.txtLKR20)
        Me.GroupBox3.Controls.Add(Me.lblLKR100)
        Me.GroupBox3.Controls.Add(Me.lblLKR1)
        Me.GroupBox3.Controls.Add(Me.txtLKR2)
        Me.GroupBox3.Controls.Add(Me.txtLKR1000)
        Me.GroupBox3.Controls.Add(Me.lblLKR50)
        Me.GroupBox3.Controls.Add(Me.txtLKR50)
        Me.GroupBox3.Controls.Add(Me.txtLKR1)
        Me.GroupBox3.Controls.Add(Me.lblLKR20)
        Me.GroupBox3.Controls.Add(Me.txtLKR10)
        Me.GroupBox3.Controls.Add(Me.lblLKR1000)
        Me.GroupBox3.Controls.Add(Me.lblLKR10)
        Me.GroupBox3.Controls.Add(Me.txtLKR100)
        Me.GroupBox3.Controls.Add(Me.lblLKR2)
        Me.GroupBox3.Controls.Add(Me.lblLKR5)
        Me.GroupBox3.Controls.Add(Me.txtLKR500)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 302)
        Me.GroupBox3.TabIndex = 147
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cash Types"
        '
        'frmSettlement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 635)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.tabSettlement)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cmdSave)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettlement"
        Me.Text = " LASER System - Settlement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabSettlement.ResumeLayout(False)
        Me.tpSales.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.grdStockSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tpRepairs.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.grdDeliver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRERepair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tpTransactions.ResumeLayout(False)
        CType(Me.grdTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents txtIncome As System.Windows.Forms.TextBox
    Friend WithEvents lblCashinLocker As System.Windows.Forms.Label
    Friend WithEvents txtLockerCash As System.Windows.Forms.TextBox
    Friend WithEvents lblCTotal As System.Windows.Forms.Label
    Friend WithEvents txtCTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCPTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCPTotal As System.Windows.Forms.Label
    Friend WithEvents txtCuLTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCuLTotal As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents tabSettlement As TabControl
    Friend WithEvents tpSales As TabPage
    Friend WithEvents txtTotalofSales As TextBox
    Friend WithEvents lblTotalofSales As Label
    Friend WithEvents grdSale As DataGridView
    Friend WithEvents tpRepairs As TabPage
    Friend WithEvents grdDeliver As DataGridView
    Friend WithEvents DNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DGrandTotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DRemarks As DataGridViewTextBoxColumn
    Friend WithEvents tpTransactions As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTANo As TextBox
    Friend WithEvents txtTAAmount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTADetails As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdTADelete As Button
    Friend WithEvents cmdTASave As Button
    Friend WithEvents cmdTANew As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents grdTransaction As DataGridView
    Friend WithEvents txtTotalofTransactions As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmdPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents grdStockSale As DataGridView
    Friend WithEvents grdRERepair As DataGridView
    Friend WithEvents grdRepair As DataGridView
    Friend WithEvents SaNo As DataGridViewTextBoxColumn
    Friend WithEvents CuName As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo1 As DataGridViewTextBoxColumn
    Friend WithEvents SaSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents SaLess As DataGridViewTextBoxColumn
    Friend WithEvents SaDue As DataGridViewTextBoxColumn
    Friend WithEvents CReceived As DataGridViewTextBoxColumn
    Friend WithEvents CBalance As DataGridViewTextBoxColumn
    Friend WithEvents CAmount As DataGridViewTextBoxColumn
    Friend WithEvents CPInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents CPAmount As DataGridViewTextBoxColumn
    Friend WithEvents CuLNo As DataGridViewTextBoxColumn
    Friend WithEvents CuLAmount As DataGridViewTextBoxColumn
    Friend WithEvents SaRemarks As DataGridViewTextBoxColumn
    Friend WithEvents txtLKR5000 As TextBox
    Friend WithEvents lblLKR5000 As Label
    Friend WithEvents txtLKR1000 As TextBox
    Friend WithEvents lblLKR1000 As Label
    Friend WithEvents txtLKR500 As TextBox
    Friend WithEvents lblLKR500 As Label
    Friend WithEvents txtLKR100 As TextBox
    Friend WithEvents lblLKR100 As Label
    Friend WithEvents txtLKR5 As TextBox
    Friend WithEvents lblLKR50 As Label
    Friend WithEvents txtLKR50 As TextBox
    Friend WithEvents lblLKR20 As Label
    Friend WithEvents txtLKR2 As TextBox
    Friend WithEvents lblLKR10 As Label
    Friend WithEvents txtLKR20 As TextBox
    Friend WithEvents lblLKR5 As Label
    Friend WithEvents txtLKR10 As TextBox
    Friend WithEvents lblLKR2 As Label
    Friend WithEvents txtCPQtyInvoice As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents lblLKR1 As Label
    Friend WithEvents txtLKR1 As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTADate As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTotalofRepairs As TextBox
    Friend WithEvents lblTotalofRepairs As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TANo As DataGridViewTextBoxColumn
    Friend WithEvents TADate As DataGridViewTextBoxColumn
    Friend WithEvents TADetails As DataGridViewTextBoxColumn
    Friend WithEvents TAAmount As DataGridViewTextBoxColumn
End Class
