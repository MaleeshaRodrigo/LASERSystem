<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridDeliverSearchControl
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
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.DNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGrandTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuLNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuLAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNo, Me.DDate, Me.CuName, Me.CuTelNo1, Me.CuTelNo2, Me.CuTelNo3, Me.DGrandTotal, Me.CReceived, Me.CBalance, Me.CAmount, Me.CPInvoiceNo, Me.CPAmount, Me.CuLNo, Me.CuLAmount, Me.DRemarks})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(596, 451)
        Me.Grid.TabIndex = 0
        '
        'DNo
        '
        Me.DNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DNo.DataPropertyName = "DNo"
        Me.DNo.HeaderText = "Deliver No"
        Me.DNo.Name = "DNo"
        Me.DNo.ReadOnly = True
        Me.DNo.Width = 89
        '
        'DDate
        '
        Me.DDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DDate.DataPropertyName = "DDate"
        Me.DDate.HeaderText = "Date"
        Me.DDate.Name = "DDate"
        Me.DDate.ReadOnly = True
        Me.DDate.Width = 58
        '
        'CuName
        '
        Me.CuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuName.DataPropertyName = "CuName"
        Me.CuName.HeaderText = "Customer Name"
        Me.CuName.Name = "CuName"
        Me.CuName.ReadOnly = True
        Me.CuName.Width = 108
        '
        'CuTelNo1
        '
        Me.CuTelNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo1.DataPropertyName = "CuTelNo1"
        Me.CuTelNo1.HeaderText = "Customer Telephone No 1"
        Me.CuTelNo1.Name = "CuTelNo1"
        Me.CuTelNo1.ReadOnly = True
        Me.CuTelNo1.Width = 134
        '
        'CuTelNo2
        '
        Me.CuTelNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo2.DataPropertyName = "CuTelNo2"
        Me.CuTelNo2.HeaderText = "Customer Telephone No 2"
        Me.CuTelNo2.Name = "CuTelNo2"
        Me.CuTelNo2.ReadOnly = True
        Me.CuTelNo2.Width = 134
        '
        'CuTelNo3
        '
        Me.CuTelNo3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo3.DataPropertyName = "CuTelNo3"
        Me.CuTelNo3.HeaderText = "Customer Telephone No 3"
        Me.CuTelNo3.Name = "CuTelNo3"
        Me.CuTelNo3.ReadOnly = True
        Me.CuTelNo3.Width = 134
        '
        'DGrandTotal
        '
        Me.DGrandTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGrandTotal.DataPropertyName = "DGrandTotal"
        Me.DGrandTotal.HeaderText = "Grand Total"
        Me.DGrandTotal.Name = "DGrandTotal"
        Me.DGrandTotal.ReadOnly = True
        Me.DGrandTotal.Width = 88
        '
        'CReceived
        '
        Me.CReceived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CReceived.DataPropertyName = "CReceived"
        Me.CReceived.HeaderText = "Cash Received"
        Me.CReceived.Name = "CReceived"
        Me.CReceived.ReadOnly = True
        Me.CReceived.Width = 101
        '
        'CBalance
        '
        Me.CBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CBalance.DataPropertyName = "CBalance"
        Me.CBalance.HeaderText = "Cash Balance"
        Me.CBalance.Name = "CBalance"
        Me.CBalance.ReadOnly = True
        Me.CBalance.Width = 97
        '
        'CAmount
        '
        Me.CAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CAmount.DataPropertyName = "CAmount"
        Me.CAmount.HeaderText = "Cash Amount"
        Me.CAmount.Name = "CAmount"
        Me.CAmount.ReadOnly = True
        Me.CAmount.Width = 95
        '
        'CPInvoiceNo
        '
        Me.CPInvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CPInvoiceNo.DataPropertyName = "CPInvoiceNo"
        Me.CPInvoiceNo.HeaderText = "Card Payment Invoice No"
        Me.CPInvoiceNo.Name = "CPInvoiceNo"
        Me.CPInvoiceNo.ReadOnly = True
        Me.CPInvoiceNo.Width = 137
        '
        'CPAmount
        '
        Me.CPAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CPAmount.DataPropertyName = "CPAmount"
        Me.CPAmount.HeaderText = "Card Payment Amount"
        Me.CPAmount.Name = "CPAmount"
        Me.CPAmount.ReadOnly = True
        Me.CPAmount.Width = 137
        '
        'CuLNo
        '
        Me.CuLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuLNo.DataPropertyName = "CuLNo"
        Me.CuLNo.HeaderText = "Customer Loan No"
        Me.CuLNo.Name = "CuLNo"
        Me.CuLNo.ReadOnly = True
        Me.CuLNo.Width = 106
        '
        'CuLAmount
        '
        Me.CuLAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuLAmount.DataPropertyName = "CuLAmount"
        Me.CuLAmount.HeaderText = "Customer Loan Amount"
        Me.CuLAmount.Name = "CuLAmount"
        Me.CuLAmount.ReadOnly = True
        Me.CuLAmount.Width = 106
        '
        'DRemarks
        '
        Me.DRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DRemarks.DataPropertyName = "DRemarks"
        Me.DRemarks.HeaderText = "Remarks"
        Me.DRemarks.Name = "DRemarks"
        Me.DRemarks.ReadOnly = True
        '
        'GridDeliverSearchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "GridDeliverSearchControl"
        Me.Size = New System.Drawing.Size(596, 451)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DataGridView
    Friend WithEvents DNo As DataGridViewTextBoxColumn
    Friend WithEvents DDate As DataGridViewTextBoxColumn
    Friend WithEvents CuName As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo1 As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo2 As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo3 As DataGridViewTextBoxColumn
    Friend WithEvents DGrandTotal As DataGridViewTextBoxColumn
    Friend WithEvents CReceived As DataGridViewTextBoxColumn
    Friend WithEvents CBalance As DataGridViewTextBoxColumn
    Friend WithEvents CAmount As DataGridViewTextBoxColumn
    Friend WithEvents CPInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents CPAmount As DataGridViewTextBoxColumn
    Friend WithEvents CuLNo As DataGridViewTextBoxColumn
    Friend WithEvents CuLAmount As DataGridViewTextBoxColumn
    Friend WithEvents DRemarks As DataGridViewTextBoxColumn
End Class
