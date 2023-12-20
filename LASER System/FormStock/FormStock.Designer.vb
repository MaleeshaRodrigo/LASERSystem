<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.grdStock = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SModelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLowestPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAvailableStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOutofstocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMinStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpSearch.SuspendLayout()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.btnSearch)
        Me.GrpSearch.Controls.Add(Me.cmbFilter)
        Me.GrpSearch.Controls.Add(Me.txtSearch)
        Me.GrpSearch.Controls.Add(Me.Label11)
        Me.GrpSearch.Controls.Add(Me.cmdNew)
        Me.GrpSearch.Controls.Add(Me.grdStock)
        Me.GrpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GrpSearch.Location = New System.Drawing.Point(0, 28)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(802, 321)
        Me.GrpSearch.TabIndex = 21
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Stock View"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(306, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 27)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.ItemHeight = 19
        Me.cmbFilter.Items.AddRange(New Object() {"by All", "by Code", "by Category", "by Name", "by Model No", "by Location", "by Lowest Price", "by Sale Price", "by Reorder Point", "by Details"})
        Me.cmbFilter.Location = New System.Drawing.Point(448, 31)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(249, 27)
        Me.cmbFilter.TabIndex = 26
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(12, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(288, 27)
        Me.txtSearch.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(396, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Filter"
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(705, 26)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 32)
        Me.cmdNew.TabIndex = 27
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'grdStock
        '
        Me.grdStock.AllowUserToAddRows = False
        Me.grdStock.AllowUserToDeleteRows = False
        Me.grdStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
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
        Me.grdStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.SModelNo, Me.SLocation, Me.SCostPrice, Me.SLowestPrice, Me.SSalePrice, Me.SAvailableStocks, Me.SOutofstocks, Me.SMinStocks, Me.SDetails})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStock.DefaultCellStyle = DataGridViewCellStyle9
        Me.grdStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdStock.GridColor = System.Drawing.Color.White
        Me.grdStock.Location = New System.Drawing.Point(6, 70)
        Me.grdStock.Name = "grdStock"
        Me.grdStock.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdStock.RowHeadersWidth = 51
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.grdStock.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.grdStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grdStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grdStock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkBlue
        Me.grdStock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grdStock.Size = New System.Drawing.Size(790, 245)
        Me.grdStock.TabIndex = 18
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(802, 28)
        Me.MenuStrip.TabIndex = 22
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStockTransactionDetailsToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'ViewStockTransactionDetailsToolStripMenuItem
        '
        Me.ViewStockTransactionDetailsToolStripMenuItem.Name = "ViewStockTransactionDetailsToolStripMenuItem"
        Me.ViewStockTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(293, 26)
        Me.ViewStockTransactionDetailsToolStripMenuItem.Text = "View Stock Transaction Details"
        '
        'SNo
        '
        Me.SNo.DataPropertyName = "Sno"
        Me.SNo.HeaderText = "Code"
        Me.SNo.MinimumWidth = 6
        Me.SNo.Name = "SNo"
        Me.SNo.ReadOnly = True
        Me.SNo.Width = 74
        '
        'SCategory
        '
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.MinimumWidth = 6
        Me.SCategory.Name = "SCategory"
        Me.SCategory.ReadOnly = True
        Me.SCategory.Width = 101
        '
        'SName
        '
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Name"
        Me.SName.MinimumWidth = 6
        Me.SName.Name = "SName"
        Me.SName.ReadOnly = True
        Me.SName.Width = 80
        '
        'SModelNo
        '
        Me.SModelNo.DataPropertyName = "SModelNo"
        Me.SModelNo.HeaderText = "Model No"
        Me.SModelNo.MinimumWidth = 6
        Me.SModelNo.Name = "SModelNo"
        Me.SModelNo.ReadOnly = True
        Me.SModelNo.Width = 108
        '
        'SLocation
        '
        Me.SLocation.DataPropertyName = "SLocation"
        Me.SLocation.HeaderText = "Location"
        Me.SLocation.MinimumWidth = 6
        Me.SLocation.Name = "SLocation"
        Me.SLocation.ReadOnly = True
        Me.SLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SLocation.Width = 74
        '
        'SCostPrice
        '
        Me.SCostPrice.DataPropertyName = "SCostPrice"
        DataGridViewCellStyle2.NullValue = "0"
        Me.SCostPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.SCostPrice.HeaderText = "Cost Price"
        Me.SCostPrice.MinimumWidth = 6
        Me.SCostPrice.Name = "SCostPrice"
        Me.SCostPrice.ReadOnly = True
        Me.SCostPrice.Visible = False
        Me.SCostPrice.Width = 108
        '
        'SLowestPrice
        '
        Me.SLowestPrice.DataPropertyName = "SLowestPrice"
        DataGridViewCellStyle3.NullValue = "0"
        Me.SLowestPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.SLowestPrice.HeaderText = "Lowest Price"
        Me.SLowestPrice.MinimumWidth = 6
        Me.SLowestPrice.Name = "SLowestPrice"
        Me.SLowestPrice.ReadOnly = True
        Me.SLowestPrice.Width = 126
        '
        'SSalePrice
        '
        Me.SSalePrice.DataPropertyName = "SSalePrice"
        DataGridViewCellStyle4.NullValue = "0"
        Me.SSalePrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.SSalePrice.HeaderText = "Sale Price"
        Me.SSalePrice.MinimumWidth = 6
        Me.SSalePrice.Name = "SSalePrice"
        Me.SSalePrice.ReadOnly = True
        Me.SSalePrice.Width = 105
        '
        'SAvailableStocks
        '
        Me.SAvailableStocks.DataPropertyName = "SAvailableStocks"
        DataGridViewCellStyle5.NullValue = "0"
        Me.SAvailableStocks.DefaultCellStyle = DataGridViewCellStyle5
        Me.SAvailableStocks.HeaderText = "Available Units"
        Me.SAvailableStocks.MinimumWidth = 6
        Me.SAvailableStocks.Name = "SAvailableStocks"
        Me.SAvailableStocks.ReadOnly = True
        Me.SAvailableStocks.Width = 143
        '
        'SOutofstocks
        '
        Me.SOutofstocks.DataPropertyName = "SOutofStocks"
        DataGridViewCellStyle6.NullValue = "0"
        Me.SOutofstocks.DefaultCellStyle = DataGridViewCellStyle6
        Me.SOutofstocks.HeaderText = "Damaged Units"
        Me.SOutofstocks.MinimumWidth = 6
        Me.SOutofstocks.Name = "SOutofstocks"
        Me.SOutofstocks.ReadOnly = True
        Me.SOutofstocks.Width = 145
        '
        'SMinStocks
        '
        Me.SMinStocks.DataPropertyName = "SMinStocks"
        DataGridViewCellStyle7.NullValue = "0"
        Me.SMinStocks.DefaultCellStyle = DataGridViewCellStyle7
        Me.SMinStocks.HeaderText = "Reorder Point"
        Me.SMinStocks.MinimumWidth = 6
        Me.SMinStocks.Name = "SMinStocks"
        Me.SMinStocks.ReadOnly = True
        Me.SMinStocks.Width = 135
        '
        'SDetails
        '
        Me.SDetails.DataPropertyName = "SDetails"
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDetails.DefaultCellStyle = DataGridViewCellStyle8
        Me.SDetails.HeaderText = "Details"
        Me.SDetails.MinimumWidth = 6
        Me.SDetails.Name = "SDetails"
        Me.SDetails.ReadOnly = True
        Me.SDetails.Width = 86
        '
        'FormStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(802, 349)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(818, 388)
        Me.Name = "FormStock"
        Me.Text = "LASER System - Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStockTransactionDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents grdStock As DataGridView
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SModelNo As DataGridViewTextBoxColumn
    Friend WithEvents SLocation As DataGridViewTextBoxColumn
    Friend WithEvents SCostPrice As DataGridViewTextBoxColumn
    Friend WithEvents SLowestPrice As DataGridViewTextBoxColumn
    Friend WithEvents SSalePrice As DataGridViewTextBoxColumn
    Friend WithEvents SAvailableStocks As DataGridViewTextBoxColumn
    Friend WithEvents SOutofstocks As DataGridViewTextBoxColumn
    Friend WithEvents SMinStocks As DataGridViewTextBoxColumn
    Friend WithEvents SDetails As DataGridViewTextBoxColumn
End Class
