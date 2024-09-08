<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlTechnicianCostListInfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.boxItem = New System.Windows.Forms.GroupBox()
        Me.grdTechnicianCost = New System.Windows.Forms.DataGridView()
        Me.TCNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxItem.SuspendLayout()
        CType(Me.grdTechnicianCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxItem
        '
        Me.boxItem.Controls.Add(Me.grdTechnicianCost)
        Me.boxItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxItem.Location = New System.Drawing.Point(0, 0)
        Me.boxItem.Name = "boxItem"
        Me.boxItem.Size = New System.Drawing.Size(648, 193)
        Me.boxItem.TabIndex = 61
        Me.boxItem.TabStop = False
        Me.boxItem.Text = "Item Info"
        '
        'grdTechnicianCost
        '
        Me.grdTechnicianCost.AllowUserToAddRows = False
        Me.grdTechnicianCost.AllowUserToDeleteRows = False
        Me.grdTechnicianCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTechnicianCost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCNo, Me.TCDate, Me.Sno, Me.SCategory, Me.SName, Me.Rate, Me.Qty, Me.Total, Me.TCRemarks, Me.TName, Me.UName})
        Me.grdTechnicianCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTechnicianCost.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdTechnicianCost.Location = New System.Drawing.Point(3, 18)
        Me.grdTechnicianCost.Name = "grdTechnicianCost"
        Me.grdTechnicianCost.Size = New System.Drawing.Size(642, 172)
        Me.grdTechnicianCost.TabIndex = 27
        '
        'TCNo
        '
        Me.TCNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.TCNo.DataPropertyName = "TCNo"
        Me.TCNo.HeaderText = "No"
        Me.TCNo.Name = "TCNo"
        Me.TCNo.ReadOnly = True
        Me.TCNo.Width = 5
        '
        'TCDate
        '
        Me.TCDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCDate.DataPropertyName = "TCDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TCDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.TCDate.HeaderText = "Date"
        Me.TCDate.Name = "TCDate"
        Me.TCDate.Width = 58
        '
        'Sno
        '
        Me.Sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sno.DataPropertyName = "SNo"
        Me.Sno.HeaderText = "Item Code"
        Me.Sno.Name = "Sno"
        Me.Sno.Width = 87
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Item Category"
        Me.SCategory.Name = "SCategory"
        Me.SCategory.Width = 106
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Item Name"
        Me.SName.Name = "SName"
        Me.SName.Width = 92
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Rate.DataPropertyName = "Rate"
        Me.Rate.HeaderText = "Unit Price"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 84
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 49
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 59
        '
        'TCRemarks
        '
        Me.TCRemarks.DataPropertyName = "TCRemarks"
        Me.TCRemarks.HeaderText = "Remarks"
        Me.TCRemarks.Name = "TCRemarks"
        '
        'TName
        '
        Me.TName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TName.DataPropertyName = "TName"
        Me.TName.HeaderText = "Technician"
        Me.TName.Name = "TName"
        Me.TName.Width = 90
        '
        'UName
        '
        Me.UName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UName.DataPropertyName = "UserName"
        Me.UName.HeaderText = "User"
        Me.UName.Name = "UName"
        Me.UName.ReadOnly = True
        Me.UName.Width = 57
        '
        'ControlTechnicianCostListInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.boxItem)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlTechnicianCostListInfo"
        Me.Size = New System.Drawing.Size(648, 193)
        Me.boxItem.ResumeLayout(False)
        CType(Me.grdTechnicianCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxItem As GroupBox
    Friend WithEvents grdTechnicianCost As DataGridView
    Friend WithEvents TCNo As DataGridViewTextBoxColumn
    Friend WithEvents TCDate As DataGridViewTextBoxColumn
    Friend WithEvents Sno As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TCRemarks As DataGridViewTextBoxColumn
    Friend WithEvents TName As DataGridViewTextBoxColumn
    Friend WithEvents UName As DataGridViewTextBoxColumn
End Class
