<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTechnicianLoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTechnicianLoan))
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.lblTLSubTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextToDate = New System.Windows.Forms.DateTimePicker()
        Me.TextFromDate = New System.Windows.Forms.DateTimePicker()
        Me.GridTechnicianLoan = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicionInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ControlTechnicianSelection = New LASER_System.ControlTechnicianSelection()
        Me.TLNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridTechnicianLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextTotal
        '
        Me.TextTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextTotal.Enabled = False
        Me.TextTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotal.Location = New System.Drawing.Point(135, 334)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(99, 27)
        Me.TextTotal.TabIndex = 116
        '
        'lblTLSubTotal
        '
        Me.lblTLSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTLSubTotal.AutoSize = True
        Me.lblTLSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTLSubTotal.Location = New System.Drawing.Point(16, 337)
        Me.lblTLSubTotal.Name = "lblTLSubTotal"
        Me.lblTLSubTotal.Size = New System.Drawing.Size(88, 19)
        Me.lblTLSubTotal.TabIndex = 115
        Me.lblTLSubTotal.Text = "Total Loan: "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(282, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 24)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "To"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label35.Location = New System.Drawing.Point(14, 86)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 24)
        Me.Label35.TabIndex = 113
        Me.Label35.Text = "From"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonSearch.Location = New System.Drawing.Point(536, 86)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(63, 24)
        Me.ButtonSearch.TabIndex = 112
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextToDate
        '
        Me.TextToDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextToDate.Location = New System.Drawing.Point(306, 86)
        Me.TextToDate.Name = "TextToDate"
        Me.TextToDate.Size = New System.Drawing.Size(224, 24)
        Me.TextToDate.TabIndex = 111
        '
        'TextFromDate
        '
        Me.TextFromDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextFromDate.Location = New System.Drawing.Point(52, 86)
        Me.TextFromDate.Name = "TextFromDate"
        Me.TextFromDate.Size = New System.Drawing.Size(224, 24)
        Me.TextFromDate.TabIndex = 110
        '
        'GridTechnicianLoan
        '
        Me.GridTechnicianLoan.AllowUserToAddRows = False
        Me.GridTechnicianLoan.AllowUserToDeleteRows = False
        Me.GridTechnicianLoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTechnicianLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTechnicianLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TLNo, Me.TLDate, Me.SNo, Me.SCategory, Me.SName, Me.TLReason, Me.Rate, Me.Qty, Me.Total})
        Me.GridTechnicianLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridTechnicianLoan.Location = New System.Drawing.Point(14, 113)
        Me.GridTechnicianLoan.Name = "GridTechnicianLoan"
        Me.GridTechnicianLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridTechnicianLoan.Size = New System.Drawing.Size(688, 215)
        Me.GridTechnicianLoan.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(103, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 27)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Rs."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 24)
        Me.MenuStrip1.TabIndex = 126
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicionInfoToolStripMenuItem, Me.ItemInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'TechnicionInfoToolStripMenuItem
        '
        Me.TechnicionInfoToolStripMenuItem.Name = "TechnicionInfoToolStripMenuItem"
        Me.TechnicionInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TechnicionInfoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.TechnicionInfoToolStripMenuItem.Text = "Technicion Info"
        '
        'ItemInfoToolStripMenuItem
        '
        Me.ItemInfoToolStripMenuItem.Name = "ItemInfoToolStripMenuItem"
        Me.ItemInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ItemInfoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ItemInfoToolStripMenuItem.Text = "Item Info"
        '
        'ButtonNew
        '
        Me.ButtonNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonNew.Image = Global.LASER_System.My.Resources.Resources._new
        Me.ButtonNew.Location = New System.Drawing.Point(626, 27)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(76, 39)
        Me.ButtonNew.TabIndex = 129
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ControlTechnicianSelection)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 53)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Info"
        '
        'ControlTechnicianSelection
        '
        Me.ControlTechnicianSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlTechnicianSelection.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlTechnicianSelection.Location = New System.Drawing.Point(6, 23)
        Me.ControlTechnicianSelection.MaximumSize = New System.Drawing.Size(300, 29)
        Me.ControlTechnicianSelection.MinimumSize = New System.Drawing.Size(200, 25)
        Me.ControlTechnicianSelection.Name = "ControlTechnicianSelection"
        Me.ControlTechnicianSelection.Size = New System.Drawing.Size(281, 25)
        Me.ControlTechnicianSelection.TabIndex = 130
        '
        'TLNo
        '
        Me.TLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TLNo.DataPropertyName = "TLNo"
        Me.TLNo.HeaderText = "No"
        Me.TLNo.Name = "TLNo"
        Me.TLNo.Visible = False
        Me.TLNo.Width = 47
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
        Me.SNo.HeaderText = "Item Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 87
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
        'TLReason
        '
        Me.TLReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TLReason.DataPropertyName = "TLReason"
        Me.TLReason.HeaderText = "Reason"
        Me.TLReason.Name = "TLReason"
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
        Me.Total.Width = 59
        '
        'FormTechnicianLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 373)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.lblTLSubTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextToDate)
        Me.Controls.Add(Me.TextFromDate)
        Me.Controls.Add(Me.GridTechnicianLoan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTechnicianLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - Technician Loan"
        CType(Me.GridTechnicianLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextTotal As TextBox
    Friend WithEvents lblTLSubTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextToDate As DateTimePicker
    Friend WithEvents TextFromDate As DateTimePicker
    Friend WithEvents GridTechnicianLoan As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TechnicionInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ControlTechnicianSelection As ControlTechnicianSelection
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TLNo As DataGridViewTextBoxColumn
    Friend WithEvents TLDate As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents TLReason As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
