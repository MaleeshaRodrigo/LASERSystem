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
        Me.Grid = New System.Windows.Forms.DataGridView()
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
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaNo, Me.SaDate, Me.CuName, Me.CuTelNo, Me.SaSubTotal, Me.SaLess, Me.SaDue, Me.CReceived, Me.CAmount, Me.CBalance, Me.CPInvoiceNo, Me.CPAmount, Me.CuLNo, Me.CuLAmount, Me.SaRemarks})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.Size = New System.Drawing.Size(1214, 343)
        Me.Grid.TabIndex = 0
        '
        'SaNo
        '
        Me.SaNo.HeaderText = "Sale No"
        Me.SaNo.Name = "SaNo"
        Me.SaNo.ReadOnly = True
        '
        'SaDate
        '
        Me.SaDate.HeaderText = "Sold Date"
        Me.SaDate.Name = "SaDate"
        Me.SaDate.ReadOnly = True
        '
        'CuName
        '
        Me.CuName.HeaderText = "Customer"
        Me.CuName.Name = "CuName"
        Me.CuName.ReadOnly = True
        '
        'CuTelNo
        '
        Me.CuTelNo.HeaderText = "Phone Numbers"
        Me.CuTelNo.Name = "CuTelNo"
        Me.CuTelNo.ReadOnly = True
        '
        'SaSubTotal
        '
        Me.SaSubTotal.HeaderText = "Total"
        Me.SaSubTotal.Name = "SaSubTotal"
        Me.SaSubTotal.ReadOnly = True
        '
        'SaLess
        '
        Me.SaLess.HeaderText = "Less "
        Me.SaLess.Name = "SaLess"
        Me.SaLess.ReadOnly = True
        '
        'SaDue
        '
        Me.SaDue.HeaderText = "Due"
        Me.SaDue.Name = "SaDue"
        Me.SaDue.ReadOnly = True
        '
        'CReceived
        '
        Me.CReceived.HeaderText = "Received Amount"
        Me.CReceived.Name = "CReceived"
        Me.CReceived.ReadOnly = True
        '
        'CAmount
        '
        Me.CAmount.HeaderText = "Cash Amount"
        Me.CAmount.Name = "CAmount"
        Me.CAmount.ReadOnly = True
        '
        'CBalance
        '
        Me.CBalance.HeaderText = "Balance"
        Me.CBalance.Name = "CBalance"
        Me.CBalance.ReadOnly = True
        '
        'CPInvoiceNo
        '
        Me.CPInvoiceNo.HeaderText = "Card Payment Invoice Number"
        Me.CPInvoiceNo.Name = "CPInvoiceNo"
        Me.CPInvoiceNo.ReadOnly = True
        '
        'CPAmount
        '
        Me.CPAmount.HeaderText = "Card Payment Amount"
        Me.CPAmount.Name = "CPAmount"
        Me.CPAmount.ReadOnly = True
        '
        'CuLNo
        '
        Me.CuLNo.HeaderText = "Customer Loan Number"
        Me.CuLNo.Name = "CuLNo"
        Me.CuLNo.ReadOnly = True
        '
        'CuLAmount
        '
        Me.CuLAmount.HeaderText = "Customer Loan Amount"
        Me.CuLAmount.Name = "CuLAmount"
        Me.CuLAmount.ReadOnly = True
        '
        'SaRemarks
        '
        Me.SaRemarks.HeaderText = "Remarks"
        Me.SaRemarks.Name = "SaRemarks"
        Me.SaRemarks.ReadOnly = True
        '
        'GridSaleSearchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "GridSaleSearchControl"
        Me.Size = New System.Drawing.Size(1214, 343)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DataGridView
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
End Class
