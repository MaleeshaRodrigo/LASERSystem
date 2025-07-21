<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlTechnicianLoanBulkInsert
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.ControlTechnician = New LASER_System.ControlTechnicianSelection()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TLDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ControlTechnician)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Controls.Add(Me.GridView)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 390)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Loan Bulk Insertion"
        '
        'GridView
        '
        Me.GridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TLDate, Me.SNo, Me.SCategory, Me.SName, Me.TLRemarks, Me.Rate, Me.Qty, Me.Total})
        Me.GridView.Location = New System.Drawing.Point(6, 52)
        Me.GridView.Name = "GridView"
        Me.GridView.Size = New System.Drawing.Size(528, 332)
        Me.GridView.TabIndex = 0
        '
        'ControlTechnician
        '
        Me.ControlTechnician.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlTechnician.Location = New System.Drawing.Point(6, 21)
        Me.ControlTechnician.MaximumSize = New System.Drawing.Size(0, 29)
        Me.ControlTechnician.MinimumSize = New System.Drawing.Size(200, 25)
        Me.ControlTechnician.Name = "ControlTechnician"
        Me.ControlTechnician.Size = New System.Drawing.Size(200, 25)
        Me.ControlTechnician.TabIndex = 3
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.ButtonSave.Location = New System.Drawing.Point(388, 12)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(70, 34)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.ButtonClose.Location = New System.Drawing.Point(464, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(70, 34)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Cancel"
        Me.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TLDate
        '
        Me.TLDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TLDate.DataPropertyName = "TLDate"
        Me.TLDate.HeaderText = "Date"
        Me.TLDate.Name = "TLDate"
        Me.TLDate.Width = 58
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 59
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.Name = "SCategory"
        Me.SCategory.Width = 78
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Name"
        Me.SName.Name = "SName"
        Me.SName.Width = 64
        '
        'TLRemarks
        '
        Me.TLRemarks.DataPropertyName = "TLRemarks"
        Me.TLRemarks.HeaderText = "Remarks"
        Me.TLRemarks.Name = "TLRemarks"
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Rate.DataPropertyName = "Rate"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle1
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 57
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
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle2
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 59
        '
        'ControlTechnicianLoanBulkInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlTechnicianLoanBulkInsert"
        Me.Size = New System.Drawing.Size(540, 390)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ControlTechnician As ControlTechnicianSelection
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents GridView As DataGridView
    Friend WithEvents TLDate As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents TLRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
