<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepairAdvanced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepairAdvanced))
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grdRepAdvanced = New System.Windows.Forms.DataGridView()
        Me.AdNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.rbRERep = New System.Windows.Forms.RadioButton()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.rbRep = New System.Windows.Forms.RadioButton()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdRepView = New System.Windows.Forms.Button()
        Me.cmbRepNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdNo = New System.Windows.Forms.TextBox()
        Me.txtAdDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRepairAdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grdRepAdvanced, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSearch.Location = New System.Drawing.Point(530, 27)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(62, 24)
        Me.cmdSearch.TabIndex = 99
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmbFilter
        '
        Me.cmbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Date", "Repair No", "RE-Repair No", "Amount", "Remarks", "All"})
        Me.cmbFilter.Location = New System.Drawing.Point(638, 27)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(150, 23)
        Me.cmbFilter.TabIndex = 93
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(595, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Filter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(338, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 17)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(390, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 24)
        Me.txtSearch.TabIndex = 91
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(338, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 17)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Search"
        '
        'grdRepAdvanced
        '
        Me.grdRepAdvanced.AllowUserToAddRows = False
        Me.grdRepAdvanced.AllowUserToDeleteRows = False
        Me.grdRepAdvanced.AllowUserToOrderColumns = True
        Me.grdRepAdvanced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRepAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepAdvanced.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdNo, Me.AdDate, Me.RepNo, Me.RetNo, Me.Price, Me.Remarks, Me.UName})
        Me.grdRepAdvanced.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdRepAdvanced.Location = New System.Drawing.Point(337, 57)
        Me.grdRepAdvanced.Name = "grdRepAdvanced"
        Me.grdRepAdvanced.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.grdRepAdvanced.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepAdvanced.Size = New System.Drawing.Size(451, 327)
        Me.grdRepAdvanced.TabIndex = 89
        '
        'AdNo
        '
        Me.AdNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.AdNo.DataPropertyName = "AdNo"
        Me.AdNo.HeaderText = "Repair Advanced No"
        Me.AdNo.Name = "AdNo"
        Me.AdNo.ReadOnly = True
        Me.AdNo.Width = 5
        '
        'AdDate
        '
        Me.AdDate.DataPropertyName = "ADDate"
        Me.AdDate.HeaderText = "Date"
        Me.AdDate.Name = "AdDate"
        '
        'RepNo
        '
        Me.RepNo.DataPropertyName = "RepNo"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.RepNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.RepNo.HeaderText = "Repair No"
        Me.RepNo.Name = "RepNo"
        '
        'RetNo
        '
        Me.RetNo.DataPropertyName = "RetNo"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.RetNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.RetNo.HeaderText = "RE-Repair No"
        Me.RetNo.Name = "RetNo"
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle3
        Me.Price.HeaderText = "Amount"
        Me.Price.Name = "Price"
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        DataGridViewCellStyle4.Format = "g"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle4
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'UName
        '
        Me.UName.HeaderText = "User Name"
        Me.UName.Name = "UName"
        Me.UName.ReadOnly = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.Controls.Add(Me.cmdDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.rbRERep)
        Me.Guna2GroupBox1.Controls.Add(Me.cmdNew)
        Me.Guna2GroupBox1.Controls.Add(Me.cmdSave)
        Me.Guna2GroupBox1.Controls.Add(Me.rbRep)
        Me.Guna2GroupBox1.Controls.Add(Me.cmdClose)
        Me.Guna2GroupBox1.Controls.Add(Me.txtRemarks)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAmount)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.cmdRepView)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbRepNo)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAdNo)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAdDate)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(319, 357)
        Me.Guna2GroupBox1.TabIndex = 101
        Me.Guna2GroupBox1.Text = "Advanced Payment Info:"
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdDelete.Image = My.Resources.Resources.Delete
        Me.cmdDelete.Location = New System.Drawing.Point(158, 303)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(76, 32)
        Me.cmdDelete.TabIndex = 128
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'rbRERep
        '
        Me.rbRERep.AutoSize = True
        Me.rbRERep.BackColor = System.Drawing.Color.White
        Me.rbRERep.Location = New System.Drawing.Point(8, 110)
        Me.rbRERep.Name = "rbRERep"
        Me.rbRERep.Size = New System.Drawing.Size(76, 19)
        Me.rbRERep.TabIndex = 123
        Me.rbRERep.Text = "RE-Repair"
        Me.rbRERep.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = My.Resources.Resources._new
        Me.cmdNew.Location = New System.Drawing.Point(3, 301)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(67, 32)
        Me.cmdNew.TabIndex = 127
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSave.Image = My.Resources.Resources.Save
        Me.cmdSave.Location = New System.Drawing.Point(76, 303)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(76, 30)
        Me.cmdSave.TabIndex = 126
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'rbRep
        '
        Me.rbRep.AutoSize = True
        Me.rbRep.BackColor = System.Drawing.Color.White
        Me.rbRep.Checked = True
        Me.rbRep.Location = New System.Drawing.Point(9, 81)
        Me.rbRep.Name = "rbRep"
        Me.rbRep.Size = New System.Drawing.Size(58, 19)
        Me.rbRep.TabIndex = 122
        Me.rbRep.TabStop = True
        Me.rbRep.Text = "Repair"
        Me.rbRep.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdClose.Image = My.Resources.Resources.close
        Me.cmdClose.Location = New System.Drawing.Point(240, 303)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 33)
        Me.cmdClose.TabIndex = 125
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(8, 187)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(303, 110)
        Me.txtRemarks.TabIndex = 121
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Remarks:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(67, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Rs."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(93, 138)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(77, 23)
        Me.txtAmount.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount:"
        '
        'cmdRepView
        '
        Me.cmdRepView.Location = New System.Drawing.Point(252, 91)
        Me.cmdRepView.Name = "cmdRepView"
        Me.cmdRepView.Size = New System.Drawing.Size(25, 25)
        Me.cmdRepView.TabIndex = 8
        Me.cmdRepView.Text = "..."
        Me.cmdRepView.UseVisualStyleBackColor = True
        '
        'cmbRepNo
        '
        Me.cmbRepNo.FormattingEnabled = True
        Me.cmbRepNo.Location = New System.Drawing.Point(138, 93)
        Me.cmbRepNo.Name = "cmbRepNo"
        Me.cmbRepNo.Size = New System.Drawing.Size(108, 23)
        Me.cmbRepNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(105, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No:"
        '
        'txtAdNo
        '
        Me.txtAdNo.Enabled = False
        Me.txtAdNo.Location = New System.Drawing.Point(261, 45)
        Me.txtAdNo.Name = "txtAdNo"
        Me.txtAdNo.Size = New System.Drawing.Size(50, 23)
        Me.txtAdNo.TabIndex = 3
        '
        'txtAdDate
        '
        Me.txtAdDate.Location = New System.Drawing.Point(46, 45)
        Me.txtAdDate.Name = "txtAdDate"
        Me.txtAdDate.Size = New System.Drawing.Size(209, 23)
        Me.txtAdDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date:"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.PRINTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 102
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintRepairAdvancedToolStripMenuItem})
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'PrintRepairAdvancedToolStripMenuItem
        '
        Me.PrintRepairAdvancedToolStripMenuItem.Name = "PrintRepairAdvancedToolStripMenuItem"
        Me.PrintRepairAdvancedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintRepairAdvancedToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PrintRepairAdvancedToolStripMenuItem.Text = "Print"
        '
        'frmRepairAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 396)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.grdRepAdvanced)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepairAdvanced"
        Me.Text = "LASER System - Repair Advanced"
        CType(Me.grdRepAdvanced, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents grdRepAdvanced As DataGridView
    Friend WithEvents AdNo As DataGridViewTextBoxColumn
    Friend WithEvents AdDate As DataGridViewTextBoxColumn
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents RetNo As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents UName As DataGridViewTextBoxColumn
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdDate As DateTimePicker
    Friend WithEvents txtAdNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbRepNo As ComboBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdRepView As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rbRERep As RadioButton
    Friend WithEvents rbRep As RadioButton
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintRepairAdvancedToolStripMenuItem As ToolStripMenuItem
End Class
