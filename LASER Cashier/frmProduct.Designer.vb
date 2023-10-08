<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.txtPNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grdProduct = New System.Windows.Forms.DataGridView()
        Me.cmbPName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.txtPDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPModelNo = New System.Windows.Forms.TextBox()
        Me.cmbPCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSearch.SuspendLayout()
        CType(Me.grdProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPNo
        '
        Me.txtPNo.Location = New System.Drawing.Point(37, 21)
        Me.txtPNo.Name = "txtPNo"
        Me.txtPNo.Size = New System.Drawing.Size(65, 26)
        Me.txtPNo.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 18)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "No:"
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.Label10)
        Me.grpSearch.Controls.Add(Me.grdProduct)
        Me.grpSearch.Location = New System.Drawing.Point(343, 27)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(659, 617)
        Me.grpSearch.TabIndex = 39
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search "
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(311, 23)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(129, 26)
        Me.cmbFilter.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(269, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Filter"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(57, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(206, 26)
        Me.txtSearch.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Search"
        '
        'grdProduct
        '
        Me.grdProduct.AllowUserToAddRows = False
        Me.grdProduct.AllowUserToDeleteRows = False
        Me.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdProduct.Location = New System.Drawing.Point(7, 54)
        Me.grdProduct.MultiSelect = False
        Me.grdProduct.Name = "grdProduct"
        Me.grdProduct.RowHeadersVisible = False
        Me.grdProduct.RowHeadersWidth = 51
        Me.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProduct.Size = New System.Drawing.Size(646, 557)
        Me.grdProduct.TabIndex = 12
        '
        'cmbPName
        '
        Me.cmbPName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbPName.FormattingEnabled = True
        Me.cmbPName.Location = New System.Drawing.Point(54, 77)
        Me.cmbPName.Name = "cmbPName"
        Me.cmbPName.Size = New System.Drawing.Size(265, 26)
        Me.cmbPName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Name:"
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(274, 234)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(45, 42)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(165, 234)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(44, 42)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(108, 234)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(51, 42)
        Me.cmdNew.TabIndex = 6
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(215, 234)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(53, 42)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDone)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.txtPDetails)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdNew)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPModelNo)
        Me.GroupBox1.Controls.Add(Me.cmbPCategory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPNo)
        Me.GroupBox1.Controls.Add(Me.cmbPName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 282)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'cmdDone
        '
        Me.cmdDone.Image = Global.LASER_Cashier.My.Resources.Resources.Done
        Me.cmdDone.Location = New System.Drawing.Point(6, 234)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(96, 42)
        Me.cmdDone.TabIndex = 5
        Me.cmdDone.Text = "Done + Save"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'txtPDetails
        '
        Me.txtPDetails.Location = New System.Drawing.Point(60, 133)
        Me.txtPDetails.Multiline = True
        Me.txtPDetails.Name = "txtPDetails"
        Me.txtPDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPDetails.Size = New System.Drawing.Size(259, 95)
        Me.txtPDetails.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Model No:"
        '
        'txtPModelNo
        '
        Me.txtPModelNo.Location = New System.Drawing.Point(74, 105)
        Me.txtPModelNo.Name = "txtPModelNo"
        Me.txtPModelNo.Size = New System.Drawing.Size(100, 26)
        Me.txtPModelNo.TabIndex = 3
        '
        'cmbPCategory
        '
        Me.cmbPCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbPCategory.FormattingEnabled = True
        Me.cmbPCategory.Location = New System.Drawing.Point(68, 49)
        Me.cmbPCategory.Name = "cmbPCategory"
        Me.cmbPCategory.Size = New System.Drawing.Size(251, 26)
        Me.cmbPCategory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Category:"
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 28)
        Me.MenuStrip.TabIndex = 40
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneSaveToolStripMenuItem, Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'DoneSaveToolStripMenuItem
        '
        Me.DoneSaveToolStripMenuItem.Name = "DoneSaveToolStripMenuItem"
        Me.DoneSaveToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DoneSaveToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.DoneSaveToolStripMenuItem.Text = "Done + Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 656)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - Product"
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.grdProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grdProduct As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPModelNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbPCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoneSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
