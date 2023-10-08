<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockSticker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.grdStock = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAvailableStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Barcode = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdStock
        '
        Me.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.SAvailableStocks, Me.SQty, Me.Rate, Me.Barcode})
        Me.grdStock.Location = New System.Drawing.Point(12, 59)
        Me.grdStock.Name = "grdStock"
        Me.grdStock.Size = New System.Drawing.Size(696, 325)
        Me.grdStock.TabIndex = 4
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNo.HeaderText = "Stock Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 83
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.Name = "SCategory"
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SName.HeaderText = "Name"
        Me.SName.Name = "SName"
        '
        'SAvailableStocks
        '
        Me.SAvailableStocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SAvailableStocks.HeaderText = "Available Units"
        Me.SAvailableStocks.Name = "SAvailableStocks"
        Me.SAvailableStocks.ReadOnly = True
        Me.SAvailableStocks.Width = 106
        '
        'SQty
        '
        Me.SQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SQty.HeaderText = "Qty"
        Me.SQty.Name = "SQty"
        Me.SQty.Width = 49
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 57
        '
        'Barcode
        '
        Me.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(639, 27)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(69, 26)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Location = New System.Drawing.Point(714, 27)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(100, 357)
        Me.rptViewer.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(822, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Show"
        '
        'frmStockSticker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 391)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grdStock)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.rptViewer)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "frmStockSticker"
        Me.Text = "LASER System - BarCode Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdStock As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SAvailableStocks As DataGridViewTextBoxColumn
    Friend WithEvents SQty As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Barcode As DataGridViewImageColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
End Class
