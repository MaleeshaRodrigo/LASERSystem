<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridSaleSearchControl
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridSale = New System.Windows.Forms.DataGridView()
        Me.SaNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaLess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuLNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuLAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.GridStock = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        CType(Me.GridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridSale
        '
        Me.GridSale.AllowUserToAddRows = False
        Me.GridSale.AllowUserToDeleteRows = False
        Me.GridSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaNo, Me.SaDate, Me.CuName, Me.CuTelNo, Me.SaSubTotal, Me.SaLess, Me.SaDue, Me.CReceived, Me.CAmount, Me.CBalance, Me.CPInvoiceNo, Me.CPAmount, Me.CuLNo, Me.CuLAmount, Me.SaRemarks})
        Me.GridSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridSale.Location = New System.Drawing.Point(3, 3)
        Me.GridSale.Name = "GridSale"
        Me.GridSale.ReadOnly = True
        Me.GridSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSale.Size = New System.Drawing.Size(875, 234)
        Me.GridSale.TabIndex = 0
        '
        'SaNo
        '
        Me.SaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaNo.DataPropertyName = "SaNo"
        Me.SaNo.HeaderText = "Sale No"
        Me.SaNo.Name = "SaNo"
        Me.SaNo.ReadOnly = True
        Me.SaNo.Width = 69
        '
        'SaDate
        '
        Me.SaDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaDate.DataPropertyName = "SaDate"
        Me.SaDate.HeaderText = "Sold Date"
        Me.SaDate.Name = "SaDate"
        Me.SaDate.ReadOnly = True
        Me.SaDate.Width = 79
        '
        'CuName
        '
        Me.CuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuName.DataPropertyName = "CuName"
        Me.CuName.HeaderText = "Customer"
        Me.CuName.Name = "CuName"
        Me.CuName.ReadOnly = True
        Me.CuName.Width = 83
        '
        'CuTelNo
        '
        Me.CuTelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo.DataPropertyName = "CuTelNo"
        Me.CuTelNo.HeaderText = "Phone Numbers"
        Me.CuTelNo.Name = "CuTelNo"
        Me.CuTelNo.ReadOnly = True
        Me.CuTelNo.Width = 108
        '
        'SaSubTotal
        '
        Me.SaSubTotal.DataPropertyName = "SaSubTotal"
        Me.SaSubTotal.HeaderText = "Total"
        Me.SaSubTotal.Name = "SaSubTotal"
        Me.SaSubTotal.ReadOnly = True
        Me.SaSubTotal.Width = 59
        '
        'SaLess
        '
        Me.SaLess.DataPropertyName = "SaLess"
        Me.SaLess.HeaderText = "Less "
        Me.SaLess.Name = "SaLess"
        Me.SaLess.ReadOnly = True
        Me.SaLess.Width = 59
        '
        'SaDue
        '
        Me.SaDue.DataPropertyName = "SaDue"
        Me.SaDue.HeaderText = "Due"
        Me.SaDue.Name = "SaDue"
        Me.SaDue.ReadOnly = True
        Me.SaDue.Width = 54
        '
        'CReceived
        '
        Me.CReceived.DataPropertyName = "CReceived"
        Me.CReceived.HeaderText = "Received Amount"
        Me.CReceived.Name = "CReceived"
        Me.CReceived.ReadOnly = True
        Me.CReceived.Width = 115
        '
        'CAmount
        '
        Me.CAmount.DataPropertyName = "CAmount"
        Me.CAmount.HeaderText = "Cash Amount"
        Me.CAmount.Name = "CAmount"
        Me.CAmount.ReadOnly = True
        Me.CAmount.Width = 95
        '
        'CBalance
        '
        Me.CBalance.DataPropertyName = "CBalance"
        Me.CBalance.HeaderText = "Balance"
        Me.CBalance.Name = "CBalance"
        Me.CBalance.ReadOnly = True
        Me.CBalance.Width = 76
        '
        'CPInvoiceNo
        '
        Me.CPInvoiceNo.DataPropertyName = "CPInvoiceNo"
        Me.CPInvoiceNo.HeaderText = "Card Payment Invoice Number"
        Me.CPInvoiceNo.Name = "CPInvoiceNo"
        Me.CPInvoiceNo.ReadOnly = True
        Me.CPInvoiceNo.Width = 137
        '
        'CPAmount
        '
        Me.CPAmount.DataPropertyName = "CPAmount"
        Me.CPAmount.HeaderText = "Card Payment Amount"
        Me.CPAmount.Name = "CPAmount"
        Me.CPAmount.ReadOnly = True
        Me.CPAmount.Width = 137
        '
        'CuLNo
        '
        Me.CuLNo.DataPropertyName = "CuLNo"
        Me.CuLNo.HeaderText = "Customer Loan Number"
        Me.CuLNo.Name = "CuLNo"
        Me.CuLNo.ReadOnly = True
        Me.CuLNo.Width = 106
        '
        'CuLAmount
        '
        Me.CuLAmount.DataPropertyName = "CuLAmount"
        Me.CuLAmount.HeaderText = "Customer Loan Amount"
        Me.CuLAmount.Name = "CuLAmount"
        Me.CuLAmount.ReadOnly = True
        Me.CuLAmount.Width = 106
        '
        'SaRemarks
        '
        Me.SaRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SaRemarks.DataPropertyName = "SaRemarks"
        Me.SaRemarks.HeaderText = "Remarks"
        Me.SaRemarks.Name = "SaRemarks"
        Me.SaRemarks.ReadOnly = True
        '
        'Panel
        '
        Me.Panel.ColumnCount = 1
        Me.Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel.Controls.Add(Me.GridStock, 0, 1)
        Me.Panel.Controls.Add(Me.GridSale, 0, 0)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.RowCount = 2
        Me.Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.Panel.Size = New System.Drawing.Size(881, 343)
        Me.Panel.TabIndex = 1
        '
        'GridStock
        '
        Me.GridStock.AllowUserToAddRows = False
        Me.GridStock.AllowUserToDeleteRows = False
        Me.GridStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.Type, Me.Rate, Me.Qty, Me.Total})
        Me.GridStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridStock.Location = New System.Drawing.Point(3, 243)
        Me.GridStock.Name = "GridStock"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GridStock.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridStock.Size = New System.Drawing.Size(875, 97)
        Me.GridStock.TabIndex = 34
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 59
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.Name = "SCategory"
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Name"
        Me.SName.Name = "SName"
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Type.DataPropertyName = "SaType"
        Me.Type.HeaderText = "Type"
        Me.Type.Items.AddRange(New Object() {"Sale", "Return to Available Units", "Return to Damaged Units"})
        Me.Type.Name = "Type"
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Type.Width = 56
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rate.DataPropertyName = "SaRate"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle1
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 57
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Qty.DataPropertyName = "SaUnits"
        DataGridViewCellStyle2.Format = "N0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 49
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.DataPropertyName = "SaTotal"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 59
        '
        'GridSaleSearchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "GridSaleSearchControl"
        Me.Size = New System.Drawing.Size(881, 343)
        CType(Me.GridSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        CType(Me.GridStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridSale As DataGridView
    Friend WithEvents SaNo As DataGridViewTextBoxColumn
    Friend WithEvents SaDate As DataGridViewTextBoxColumn
    Friend WithEvents CuName As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo As DataGridViewTextBoxColumn
    Friend WithEvents SaSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents SaLess As DataGridViewTextBoxColumn
    Friend WithEvents SaDue As DataGridViewTextBoxColumn
    Friend WithEvents CReceived As DataGridViewTextBoxColumn
    Friend WithEvents CAmount As DataGridViewTextBoxColumn
    Friend WithEvents CBalance As DataGridViewTextBoxColumn
    Friend WithEvents CPInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents CPAmount As DataGridViewTextBoxColumn
    Friend WithEvents CuLNo As DataGridViewTextBoxColumn
    Friend WithEvents CuLAmount As DataGridViewTextBoxColumn
    Friend WithEvents SaRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Panel As TableLayoutPanel
    Friend WithEvents GridStock As DataGridView
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewComboBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
