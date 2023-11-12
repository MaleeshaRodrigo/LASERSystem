<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.tabpageTextSearch = New System.Windows.Forms.TabPage()
        Me.cmdLIKE = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.cmdRightBracket = New System.Windows.Forms.Button()
        Me.cmdLeftBracket = New System.Windows.Forms.Button()
        Me.cmdOR = New System.Windows.Forms.Button()
        Me.cmdAND = New System.Windows.Forms.Button()
        Me.txtTSSearch = New System.Windows.Forms.TextBox()
        Me.flpSearch = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdTSSearch = New System.Windows.Forms.Button()
        Me.grdSearch = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.bgwSearch = New System.ComponentModel.BackgroundWorker()
        Me.tabcontrol.SuspendLayout()
        Me.tabpageTextSearch.SuspendLayout()
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcontrol
        '
        Me.tabcontrol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrol.Controls.Add(Me.tabpageTextSearch)
        Me.tabcontrol.Location = New System.Drawing.Point(12, 41)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(737, 95)
        Me.tabcontrol.TabIndex = 0
        '
        'tabpageTextSearch
        '
        Me.tabpageTextSearch.Controls.Add(Me.cmdLIKE)
        Me.tabpageTextSearch.Controls.Add(Me.cmbFilter)
        Me.tabpageTextSearch.Controls.Add(Me.cmdRightBracket)
        Me.tabpageTextSearch.Controls.Add(Me.cmdLeftBracket)
        Me.tabpageTextSearch.Controls.Add(Me.cmdOR)
        Me.tabpageTextSearch.Controls.Add(Me.cmdAND)
        Me.tabpageTextSearch.Controls.Add(Me.txtTSSearch)
        Me.tabpageTextSearch.Controls.Add(Me.flpSearch)
        Me.tabpageTextSearch.Controls.Add(Me.cmdTSSearch)
        Me.tabpageTextSearch.Location = New System.Drawing.Point(4, 27)
        Me.tabpageTextSearch.Name = "tabpageTextSearch"
        Me.tabpageTextSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageTextSearch.Size = New System.Drawing.Size(729, 64)
        Me.tabpageTextSearch.TabIndex = 0
        Me.tabpageTextSearch.Text = "Text Search"
        Me.tabpageTextSearch.UseVisualStyleBackColor = True
        '
        'cmdLIKE
        '
        Me.cmdLIKE.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdLIKE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLIKE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdLIKE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdLIKE.Location = New System.Drawing.Point(576, 7)
        Me.cmdLIKE.Name = "cmdLIKE"
        Me.cmdLIKE.Size = New System.Drawing.Size(53, 24)
        Me.cmdLIKE.TabIndex = 10
        Me.cmdLIKE.Text = "LIKE"
        Me.cmdLIKE.UseVisualStyleBackColor = False
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.White
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.ItemHeight = 16
        Me.cmbFilter.Location = New System.Drawing.Point(150, 6)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(233, 22)
        Me.cmbFilter.TabIndex = 9
        '
        'cmdRightBracket
        '
        Me.cmdRightBracket.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdRightBracket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRightBracket.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdRightBracket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdRightBracket.Location = New System.Drawing.Point(542, 7)
        Me.cmdRightBracket.Name = "cmdRightBracket"
        Me.cmdRightBracket.Size = New System.Drawing.Size(28, 24)
        Me.cmdRightBracket.TabIndex = 8
        Me.cmdRightBracket.Text = ")"
        Me.cmdRightBracket.UseVisualStyleBackColor = False
        '
        'cmdLeftBracket
        '
        Me.cmdLeftBracket.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdLeftBracket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLeftBracket.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdLeftBracket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdLeftBracket.Location = New System.Drawing.Point(507, 7)
        Me.cmdLeftBracket.Name = "cmdLeftBracket"
        Me.cmdLeftBracket.Size = New System.Drawing.Size(29, 24)
        Me.cmdLeftBracket.TabIndex = 7
        Me.cmdLeftBracket.Text = "("
        Me.cmdLeftBracket.UseVisualStyleBackColor = False
        '
        'cmdOR
        '
        Me.cmdOR.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdOR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdOR.Location = New System.Drawing.Point(448, 6)
        Me.cmdOR.Name = "cmdOR"
        Me.cmdOR.Size = New System.Drawing.Size(53, 24)
        Me.cmdOR.TabIndex = 6
        Me.cmdOR.Text = "OR"
        Me.cmdOR.UseVisualStyleBackColor = False
        '
        'cmdAND
        '
        Me.cmdAND.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdAND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAND.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAND.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdAND.Location = New System.Drawing.Point(389, 6)
        Me.cmdAND.Name = "cmdAND"
        Me.cmdAND.Size = New System.Drawing.Size(53, 24)
        Me.cmdAND.TabIndex = 5
        Me.cmdAND.Text = "AND"
        Me.cmdAND.UseVisualStyleBackColor = False
        '
        'txtTSSearch
        '
        Me.txtTSSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTSSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTSSearch.Location = New System.Drawing.Point(6, 6)
        Me.txtTSSearch.Name = "txtTSSearch"
        Me.txtTSSearch.Size = New System.Drawing.Size(138, 27)
        Me.txtTSSearch.TabIndex = 4
        '
        'flpSearch
        '
        Me.flpSearch.AllowDrop = True
        Me.flpSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpSearch.AutoScroll = True
        Me.flpSearch.Location = New System.Drawing.Point(6, 34)
        Me.flpSearch.Name = "flpSearch"
        Me.flpSearch.Size = New System.Drawing.Size(655, 34)
        Me.flpSearch.TabIndex = 3
        '
        'cmdTSSearch
        '
        Me.cmdTSSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTSSearch.Image = Global.LASER_System.My.Resources.Resources.search
        Me.cmdTSSearch.Location = New System.Drawing.Point(667, 6)
        Me.cmdTSSearch.Name = "cmdTSSearch"
        Me.cmdTSSearch.Size = New System.Drawing.Size(56, 56)
        Me.cmdTSSearch.TabIndex = 1
        Me.cmdTSSearch.Text = "Search"
        Me.cmdTSSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdTSSearch.UseVisualStyleBackColor = True
        '
        'grdSearch
        '
        Me.grdSearch.AllowUserToAddRows = False
        Me.grdSearch.AllowUserToDeleteRows = False
        Me.grdSearch.AllowUserToOrderColumns = True
        Me.grdSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSearch.Location = New System.Drawing.Point(12, 138)
        Me.grdSearch.Name = "grdSearch"
        Me.grdSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSearch.Size = New System.Drawing.Size(737, 144)
        Me.grdSearch.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(757, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(76, 26)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar.Location = New System.Drawing.Point(0, 30)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(757, 10)
        Me.ProgressBar.TabIndex = 5
        '
        'bgwSearch
        '
        Me.bgwSearch.WorkerReportsProgress = True
        Me.bgwSearch.WorkerSupportsCancellation = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 294)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.grdSearch)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSearch"
        Me.Tag = "Repair"
        Me.Text = "LASER System - Search Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabcontrol.ResumeLayout(False)
        Me.tabpageTextSearch.ResumeLayout(False)
        Me.tabpageTextSearch.PerformLayout()
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabcontrol As System.Windows.Forms.TabControl
    Friend WithEvents tabpageTextSearch As System.Windows.Forms.TabPage
    Friend WithEvents cmdTSSearch As System.Windows.Forms.Button
    Friend WithEvents grdSearch As System.Windows.Forms.DataGridView
    Friend WithEvents flpSearch As FlowLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdRightBracket As System.Windows.Forms.Button
    Friend WithEvents cmdLeftBracket As System.Windows.Forms.Button
    Friend WithEvents cmdOR As System.Windows.Forms.Button
    Friend WithEvents cmdAND As System.Windows.Forms.Button
    Friend WithEvents txtTSSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cmdLIKE As System.Windows.Forms.Button
    Friend WithEvents bgwSearch As System.ComponentModel.BackgroundWorker
End Class
