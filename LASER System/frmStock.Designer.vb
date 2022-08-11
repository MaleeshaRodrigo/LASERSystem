<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grdStock = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SModelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAvailableStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOutofstocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMinStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdStockmnustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgwStock = New System.ComponentModel.BackgroundWorker()
        Me.grpSearch.SuspendLayout()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.grdStockmnustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearch
        '
        Me.grpSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.grdStock)
        Me.grpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSearch.Location = New System.Drawing.Point(12, 27)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(953, 411)
        Me.grpSearch.TabIndex = 21
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search "
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(226, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 23)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        '
        'cmbFilter
        '
        Me.cmbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.ItemHeight = 16
        Me.cmbFilter.Location = New System.Drawing.Point(696, 23)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(249, 22)
        Me.cmbFilter.TabIndex = 26
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(6, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Keyword"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(215, 23)
        Me.txtSearch.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(654, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Filter"
        '
        'grdStock
        '
        Me.grdStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.SModelNo, Me.SLocation, Me.SCostPrice, Me.SSalePrice, Me.SAvailableStocks, Me.SOutofstocks, Me.SMinStocks, Me.SDetails, Me.SImage})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStock.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdStock.GridColor = System.Drawing.Color.White
        Me.grdStock.Location = New System.Drawing.Point(6, 51)
        Me.grdStock.Name = "grdStock"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.grdStock.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grdStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grdStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grdStock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkBlue
        Me.grdStock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grdStock.Size = New System.Drawing.Size(941, 354)
        Me.grdStock.TabIndex = 18
        '
        'SNo
        '
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Code"
        Me.SNo.Name = "SNo"
        Me.SNo.ReadOnly = True
        Me.SNo.Width = 59
        '
        'SCategory
        '
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.Name = "SCategory"
        Me.SCategory.Width = 80
        '
        'SName
        '
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Name"
        Me.SName.Name = "SName"
        Me.SName.Width = 63
        '
        'SModelNo
        '
        Me.SModelNo.DataPropertyName = "SModelNo"
        Me.SModelNo.HeaderText = "Model No"
        Me.SModelNo.Name = "SModelNo"
        Me.SModelNo.Width = 79
        '
        'SLocation
        '
        Me.SLocation.DataPropertyName = "SLocation"
        Me.SLocation.HeaderText = "Location"
        Me.SLocation.Name = "SLocation"
        Me.SLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SLocation.Width = 59
        '
        'SCostPrice
        '
        Me.SCostPrice.DataPropertyName = "SCostPrice"
        Me.SCostPrice.HeaderText = "Cost Price"
        Me.SCostPrice.Name = "SCostPrice"
        Me.SCostPrice.Width = 80
        '
        'SSalePrice
        '
        Me.SSalePrice.DataPropertyName = "SSalePrice"
        Me.SSalePrice.HeaderText = "Sale Price"
        Me.SSalePrice.Name = "SSalePrice"
        Me.SSalePrice.Width = 79
        '
        'SAvailableStocks
        '
        Me.SAvailableStocks.DataPropertyName = "SAvailableStocks"
        Me.SAvailableStocks.HeaderText = "Available Units"
        Me.SAvailableStocks.Name = "SAvailableStocks"
        Me.SAvailableStocks.ReadOnly = True
        Me.SAvailableStocks.Width = 106
        '
        'SOutofstocks
        '
        Me.SOutofstocks.DataPropertyName = "SOutofStocks"
        Me.SOutofstocks.HeaderText = "Damaged Units"
        Me.SOutofstocks.Name = "SOutofstocks"
        Me.SOutofstocks.ReadOnly = True
        Me.SOutofstocks.Width = 106
        '
        'SMinStocks
        '
        Me.SMinStocks.DataPropertyName = "SMinStocks"
        Me.SMinStocks.HeaderText = "Reorder Point"
        Me.SMinStocks.Name = "SMinStocks"
        Me.SMinStocks.Width = 98
        '
        'SDetails
        '
        Me.SDetails.DataPropertyName = "SDetails"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.SDetails.HeaderText = "Details"
        Me.SDetails.Name = "SDetails"
        Me.SDetails.Width = 71
        '
        'SImage
        '
        Me.SImage.DataPropertyName = "SImage"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SImage.DefaultCellStyle = DataGridViewCellStyle3
        Me.SImage.HeaderText = "Picture"
        Me.SImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.SImage.Name = "SImage"
        Me.SImage.Width = 52
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(972, 24)
        Me.MenuStrip.TabIndex = 22
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
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStockTransactionDetailsToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'ViewStockTransactionDetailsToolStripMenuItem
        '
        Me.ViewStockTransactionDetailsToolStripMenuItem.Name = "ViewStockTransactionDetailsToolStripMenuItem"
        Me.ViewStockTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ViewStockTransactionDetailsToolStripMenuItem.Text = "View Stock Transaction Details"
        '
        'grdStockmnustrip
        '
        Me.grdStockmnustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeToolStripMenuItem, Me.ViewToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.grdStockmnustrip.Name = "grdStockmnustrip"
        Me.grdStockmnustrip.Size = New System.Drawing.Size(156, 70)
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ChangeToolStripMenuItem.Text = "Change Picture"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ViewToolStripMenuItem1.Text = "Open Picture"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'bgwStock
        '
        Me.bgwStock.WorkerReportsProgress = True
        Me.bgwStock.WorkerSupportsCancellation = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(972, 447)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStock"
        Me.Text = "LASER System - Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.grdStockmnustrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStockTransactionDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grdStockmnustrip As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents grdStock As DataGridView
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents bgwStock As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SModelNo As DataGridViewTextBoxColumn
    Friend WithEvents SLocation As DataGridViewTextBoxColumn
    Friend WithEvents SCostPrice As DataGridViewTextBoxColumn
    Friend WithEvents SSalePrice As DataGridViewTextBoxColumn
    Friend WithEvents SAvailableStocks As DataGridViewTextBoxColumn
    Friend WithEvents SOutofstocks As DataGridViewTextBoxColumn
    Friend WithEvents SMinStocks As DataGridViewTextBoxColumn
    Friend WithEvents SDetails As DataGridViewTextBoxColumn
    Friend WithEvents SImage As DataGridViewImageColumn
End Class
