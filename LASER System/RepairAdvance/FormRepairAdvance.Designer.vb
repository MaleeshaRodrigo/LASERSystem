<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRepairAdvance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRepairAdvance))
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grdRepAdvanced = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRepairAdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.AdNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdRepAdvanced, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSearch.Image = Global.LASER_System.My.Resources.Resources.search__2_
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearch.Location = New System.Drawing.Point(206, 27)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(77, 25)
        Me.cmdSearch.TabIndex = 99
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Date", "Repair No", "RE-Repair No", "Amount", "Remarks", "All"})
        Me.cmbFilter.Location = New System.Drawing.Point(332, 30)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(150, 23)
        Me.cmbFilter.TabIndex = 93
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(289, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Filter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(14, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 17)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(66, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 24)
        Me.txtSearch.TabIndex = 91
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
        Me.grdRepAdvanced.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdNo, Me.AdDate, Me.RepNo, Me.RetNo, Me.Amount, Me.Remarks, Me.UserName})
        Me.grdRepAdvanced.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdRepAdvanced.Location = New System.Drawing.Point(12, 69)
        Me.grdRepAdvanced.Name = "grdRepAdvanced"
        Me.grdRepAdvanced.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.grdRepAdvanced.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepAdvanced.Size = New System.Drawing.Size(776, 315)
        Me.grdRepAdvanced.TabIndex = 89
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
        'ButtonNew
        '
        Me.ButtonNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonNew.Image = Global.LASER_System.My.Resources.Resources._new
        Me.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNew.Location = New System.Drawing.Point(711, 26)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(77, 25)
        Me.ButtonNew.TabIndex = 103
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'AdNo
        '
        Me.AdNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.AdNo.DataPropertyName = "ADNo"
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
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
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
        'UserName
        '
        Me.UserName.DataPropertyName = "User"
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'FormRepairAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 396)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.grdRepAdvanced)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRepairAdvance"
        Me.Text = "LASER System - Repair Advanced"
        CType(Me.grdRepAdvanced, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdRepAdvanced As DataGridView
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintRepairAdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonNew As Button
    Friend WithEvents AdNo As DataGridViewTextBoxColumn
    Friend WithEvents AdDate As DataGridViewTextBoxColumn
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents RetNo As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
End Class
