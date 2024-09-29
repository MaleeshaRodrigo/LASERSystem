<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTechnicianCost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTechnicianCost))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmdTCSearch = New System.Windows.Forms.Button()
        Me.txtTCSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtTCFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtTCTo = New System.Windows.Forms.DateTimePicker()
        Me.grdTechnicianCost = New System.Windows.Forms.DataGridView()
        Me.TCNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnustripOpenRepair = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonBulkInsert = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.grdTechnicianCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnustripOpenRepair.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Info"
        '
        'cmbTName
        '
        Me.cmbTName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(68, 21)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(210, 22)
        Me.cmbTName.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(283, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 22)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "To"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.DimGray
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(15, 84)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 22)
        Me.Label35.TabIndex = 110
        Me.Label35.Text = "From"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdTCSearch
        '
        Me.cmdTCSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTCSearch.Image = Global.LASER_System.My.Resources.Resources.search__2_
        Me.cmdTCSearch.Location = New System.Drawing.Point(672, 84)
        Me.cmdTCSearch.Name = "cmdTCSearch"
        Me.cmdTCSearch.Size = New System.Drawing.Size(71, 23)
        Me.cmdTCSearch.TabIndex = 109
        Me.cmdTCSearch.Text = "Search"
        Me.cmdTCSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTCSearch.UseVisualStyleBackColor = True
        '
        'txtTCSubTotal
        '
        Me.txtTCSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTCSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCSubTotal.Location = New System.Drawing.Point(137, 314)
        Me.txtTCSubTotal.Name = "txtTCSubTotal"
        Me.txtTCSubTotal.Size = New System.Drawing.Size(118, 27)
        Me.txtTCSubTotal.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Total Cost: "
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(752, 24)
        Me.MenuStrip.TabIndex = 121
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
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'ItemInfoToolStripMenuItem
        '
        Me.ItemInfoToolStripMenuItem.Name = "ItemInfoToolStripMenuItem"
        Me.ItemInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ItemInfoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ItemInfoToolStripMenuItem.Text = "Item Info"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(104, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 27)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Rs."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Location = New System.Drawing.Point(538, 84)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(128, 22)
        Me.txtSearch.TabIndex = 124
        '
        'txtTCFrom
        '
        Me.txtTCFrom.Location = New System.Drawing.Point(53, 84)
        Me.txtTCFrom.Name = "txtTCFrom"
        Me.txtTCFrom.Size = New System.Drawing.Size(229, 22)
        Me.txtTCFrom.TabIndex = 125
        '
        'txtTCTo
        '
        Me.txtTCTo.Location = New System.Drawing.Point(311, 84)
        Me.txtTCTo.Name = "txtTCTo"
        Me.txtTCTo.Size = New System.Drawing.Size(221, 22)
        Me.txtTCTo.TabIndex = 126
        '
        'grdTechnicianCost
        '
        Me.grdTechnicianCost.AllowUserToAddRows = False
        Me.grdTechnicianCost.AllowUserToDeleteRows = False
        Me.grdTechnicianCost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTechnicianCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTechnicianCost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCNo, Me.TCDate, Me.SNo, Me.SCategory, Me.SName, Me.Rate, Me.Qty, Me.Total, Me.TCRemarks, Me.RepNo, Me.RetNo, Me.UName})
        Me.grdTechnicianCost.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdTechnicianCost.Location = New System.Drawing.Point(15, 109)
        Me.grdTechnicianCost.Name = "grdTechnicianCost"
        Me.grdTechnicianCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTechnicianCost.Size = New System.Drawing.Size(728, 202)
        Me.grdTechnicianCost.TabIndex = 127
        '
        'TCNo
        '
        Me.TCNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.TCNo.DataPropertyName = "TCNo"
        Me.TCNo.HeaderText = "Technician Cost No"
        Me.TCNo.Name = "TCNo"
        Me.TCNo.ReadOnly = True
        Me.TCNo.Width = 5
        '
        'TCDate
        '
        Me.TCDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TCDate.DataPropertyName = "TCDate"
        Me.TCDate.HeaderText = "Date"
        Me.TCDate.Name = "TCDate"
        Me.TCDate.Width = 58
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Stock Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 5
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
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Rate.DataPropertyName = "Rate"
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
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 59
        '
        'TCRemarks
        '
        Me.TCRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TCRemarks.DataPropertyName = "TCRemarks"
        Me.TCRemarks.HeaderText = "Remarks"
        Me.TCRemarks.Name = "TCRemarks"
        Me.TCRemarks.Width = 79
        '
        'RepNo
        '
        Me.RepNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RepNo.DataPropertyName = "RepNo"
        Me.RepNo.HeaderText = "Repair No"
        Me.RepNo.Name = "RepNo"
        Me.RepNo.Width = 79
        '
        'RetNo
        '
        Me.RetNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RetNo.DataPropertyName = "RetNo"
        Me.RetNo.HeaderText = "RE-Repair No"
        Me.RetNo.Name = "RetNo"
        Me.RetNo.Width = 95
        '
        'UName
        '
        Me.UName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UName.DataPropertyName = "UName"
        Me.UName.HeaderText = "User Name"
        Me.UName.Name = "UName"
        Me.UName.ReadOnly = True
        Me.UName.Width = 85
        '
        'mnustripOpenRepair
        '
        Me.mnustripOpenRepair.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem1})
        Me.mnustripOpenRepair.Name = "grdStockmnustrip"
        Me.mnustripOpenRepair.Size = New System.Drawing.Size(140, 26)
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ClearToolStripMenuItem1.Text = "Open Repair"
        '
        'ButtonNew
        '
        Me.ButtonNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNew.Image = Global.LASER_System.My.Resources.Resources._new
        Me.ButtonNew.Location = New System.Drawing.Point(672, 39)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(71, 37)
        Me.ButtonNew.TabIndex = 128
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonBulkInsert
        '
        Me.ButtonBulkInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBulkInsert.Image = Global.LASER_System.My.Resources.Resources.upload
        Me.ButtonBulkInsert.Location = New System.Drawing.Point(572, 41)
        Me.ButtonBulkInsert.Name = "ButtonBulkInsert"
        Me.ButtonBulkInsert.Size = New System.Drawing.Size(94, 37)
        Me.ButtonBulkInsert.TabIndex = 129
        Me.ButtonBulkInsert.Text = "Bulk Insert"
        Me.ButtonBulkInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBulkInsert.UseVisualStyleBackColor = True
        '
        'FormTechnicianCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 356)
        Me.Controls.Add(Me.ButtonBulkInsert)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.grdTechnicianCost)
        Me.Controls.Add(Me.txtTCTo)
        Me.Controls.Add(Me.txtTCFrom)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTCSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmdTCSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormTechnicianCost"
        Me.Text = "LASER System - Technician Cost "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.grdTechnicianCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnustripOpenRepair.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmdTCSearch As System.Windows.Forms.Button
    Friend WithEvents txtTCSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtTCFrom As DateTimePicker
    Friend WithEvents txtTCTo As DateTimePicker
    Friend WithEvents grdTechnicianCost As DataGridView
    Friend WithEvents mnustripOpenRepair As ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TCNo As DataGridViewTextBoxColumn
    Friend WithEvents TCDate As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TCRemarks As DataGridViewTextBoxColumn
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents RetNo As DataGridViewTextBoxColumn
    Friend WithEvents UName As DataGridViewTextBoxColumn
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonBulkInsert As Button
End Class
