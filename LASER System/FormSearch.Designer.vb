<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearch))
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.grdSearch = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.bgwSearch = New System.ComponentModel.BackgroundWorker()
        Me.tabpageTextSearch = New System.Windows.Forms.TabPage()
        Me.ControlSearchEngine = New LASER_System.ControlSearchEngine()
        Me.tabcontrol.SuspendLayout()
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabpageTextSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.tabpageTextSearch)
        Me.tabcontrol.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabcontrol.Location = New System.Drawing.Point(0, 24)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(757, 95)
        Me.tabcontrol.TabIndex = 0
        '
        'grdSearch
        '
        Me.grdSearch.AllowUserToAddRows = False
        Me.grdSearch.AllowUserToDeleteRows = False
        Me.grdSearch.AllowUserToOrderColumns = True
        Me.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSearch.Location = New System.Drawing.Point(0, 119)
        Me.grdSearch.Name = "grdSearch"
        Me.grdSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSearch.Size = New System.Drawing.Size(757, 175)
        Me.grdSearch.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(757, 24)
        Me.MenuStrip1.TabIndex = 2
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
        Me.ClearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar.Location = New System.Drawing.Point(0, 119)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(757, 10)
        Me.ProgressBar.TabIndex = 5
        '
        'bgwSearch
        '
        Me.bgwSearch.WorkerReportsProgress = True
        Me.bgwSearch.WorkerSupportsCancellation = True
        '
        'tabpageTextSearch
        '
        Me.tabpageTextSearch.Controls.Add(Me.ControlSearchEngine)
        Me.tabpageTextSearch.Location = New System.Drawing.Point(4, 23)
        Me.tabpageTextSearch.Name = "tabpageTextSearch"
        Me.tabpageTextSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageTextSearch.Size = New System.Drawing.Size(749, 68)
        Me.tabpageTextSearch.TabIndex = 0
        Me.tabpageTextSearch.Text = "Advanced Search"
        Me.tabpageTextSearch.UseVisualStyleBackColor = True
        '
        'ControlSearchEngine
        '
        Me.ControlSearchEngine.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlSearchEngine.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlSearchEngine.Location = New System.Drawing.Point(3, 3)
        Me.ControlSearchEngine.Name = "ControlSearchEngine"
        Me.ControlSearchEngine.Size = New System.Drawing.Size(743, 65)
        Me.ControlSearchEngine.TabIndex = 0
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
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
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabpageTextSearch.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabcontrol As System.Windows.Forms.TabControl
    Friend WithEvents grdSearch As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgwSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents tabpageTextSearch As TabPage
    Friend WithEvents ControlSearchEngine As ControlSearchEngine
End Class
