<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridRepairSearchControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Problem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepRemarks1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RepRemarks2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AssignedTechnician = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HandedOverTechnician = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RepDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepNo, Me.RDate, Me.CuName, Me.CuTelNo, Me.Product, Me.PSerialNo, Me.Problem, Me.Location, Me.Qty, Me.RepRemarks1, Me.RepRemarks2, Me.Status, Me.AssignedTechnician, Me.HandedOverTechnician, Me.RepDate, Me.RepCharge, Me.DDate, Me.PaidPrice})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Grid.Size = New System.Drawing.Size(959, 464)
        Me.Grid.TabIndex = 0
        '
        'RepNo
        '
        Me.RepNo.Frozen = True
        Me.RepNo.HeaderText = "RepNo"
        Me.RepNo.Name = "RepNo"
        '
        'RDate
        '
        Me.RDate.HeaderText = "Received Date"
        Me.RDate.Name = "RDate"
        '
        'CuName
        '
        Me.CuName.HeaderText = "Customer Name"
        Me.CuName.Name = "CuName"
        '
        'CuTelNo
        '
        Me.CuTelNo.HeaderText = "Customer Telephone Nos"
        Me.CuTelNo.Name = "CuTelNo"
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        '
        'PSerialNo
        '
        Me.PSerialNo.HeaderText = "Product Serial No"
        Me.PSerialNo.Name = "PSerialNo"
        '
        'Problem
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Problem.DefaultCellStyle = DataGridViewCellStyle1
        Me.Problem.HeaderText = "Problem"
        Me.Problem.Name = "Problem"
        '
        'Location
        '
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'RepRemarks1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepRemarks1.DefaultCellStyle = DataGridViewCellStyle2
        Me.RepRemarks1.HeaderText = "Remarks (by Customer)"
        Me.RepRemarks1.Name = "RepRemarks1"
        Me.RepRemarks1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepRemarks1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RepRemarks1.Text = "View"
        '
        'RepRemarks2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepRemarks2.DefaultCellStyle = DataGridViewCellStyle3
        Me.RepRemarks2.HeaderText = "Remarks (by Technician)"
        Me.RepRemarks2.Name = "RepRemarks2"
        Me.RepRemarks2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepRemarks2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RepRemarks2.Text = "View"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Items.AddRange(New Object() {"Received", "Assigned To", "Handed Over To", "Pending", "Repaired", "Returned", "Repaired Delivered", "Returned Delivered", "Canceled"})
        Me.Status.Name = "Status"
        '
        'AssignedTechnician
        '
        Me.AssignedTechnician.HeaderText = "Assigned Technician"
        Me.AssignedTechnician.Name = "AssignedTechnician"
        '
        'HandedOverTechnician
        '
        Me.HandedOverTechnician.HeaderText = "Handed Over Technician"
        Me.HandedOverTechnician.Name = "HandedOverTechnician"
        Me.HandedOverTechnician.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HandedOverTechnician.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RepDate
        '
        Me.RepDate.HeaderText = "Repaired Date"
        Me.RepDate.Name = "RepDate"
        '
        'RepCharge
        '
        Me.RepCharge.HeaderText = "Repair Charge"
        Me.RepCharge.Name = "RepCharge"
        '
        'DDate
        '
        Me.DDate.HeaderText = "Delivered Date"
        Me.DDate.Name = "DDate"
        '
        'PaidPrice
        '
        Me.PaidPrice.HeaderText = "Paid Charge"
        Me.PaidPrice.Name = "PaidPrice"
        '
        'GridRepairSearchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "GridRepairSearchControl"
        Me.Size = New System.Drawing.Size(959, 464)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DataGridView
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents RDate As DataGridViewTextBoxColumn
    Friend WithEvents CuName As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo As DataGridViewTextBoxColumn
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents PSerialNo As DataGridViewTextBoxColumn
    Friend WithEvents Problem As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks1 As DataGridViewButtonColumn
    Friend WithEvents RepRemarks2 As DataGridViewButtonColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents AssignedTechnician As DataGridViewComboBoxColumn
    Friend WithEvents HandedOverTechnician As DataGridViewComboBoxColumn
    Friend WithEvents RepDate As DataGridViewTextBoxColumn
    Friend WithEvents RepCharge As DataGridViewTextBoxColumn
    Friend WithEvents DDate As DataGridViewTextBoxColumn
    Friend WithEvents PaidPrice As DataGridViewTextBoxColumn
End Class
