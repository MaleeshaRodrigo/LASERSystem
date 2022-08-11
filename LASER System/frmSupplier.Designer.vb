<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grdSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSuEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSuTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSuAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSuNo = New System.Windows.Forms.TextBox()
        Me.cmbSuName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSearch.SuspendLayout()
        CType(Me.grdSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(214, 400)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(59, 51)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Name :"
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(311, 21)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(129, 22)
        Me.cmbFilter.TabIndex = 14
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(279, 400)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(57, 51)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.Label10)
        Me.grpSearch.Controls.Add(Me.grdSupplier)
        Me.grpSearch.Location = New System.Drawing.Point(343, 27)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(449, 570)
        Me.grpSearch.TabIndex = 33
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(269, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Filter"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(57, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(206, 22)
        Me.txtSearch.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 14)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Search"
        '
        'grdSupplier
        '
        Me.grdSupplier.AllowUserToAddRows = False
        Me.grdSupplier.AllowUserToDeleteRows = False
        Me.grdSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSupplier.Location = New System.Drawing.Point(7, 50)
        Me.grdSupplier.MultiSelect = False
        Me.grdSupplier.Name = "grdSupplier"
        Me.grdSupplier.RowHeadersVisible = False
        Me.grdSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSupplier.Size = New System.Drawing.Size(433, 514)
        Me.grdSupplier.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSuEmail)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSuTelNo3)
        Me.GroupBox1.Controls.Add(Me.txtSuTelNo2)
        Me.GroupBox1.Controls.Add(Me.txtSuTelNo1)
        Me.GroupBox1.Controls.Add(Me.txtSuRemarks)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSuAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSuNo)
        Me.GroupBox1.Controls.Add(Me.cmbSuName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 367)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Details"
        '
        'txtSuEmail
        '
        Me.txtSuEmail.Location = New System.Drawing.Point(55, 141)
        Me.txtSuEmail.Name = "txtSuEmail"
        Me.txtSuEmail.Size = New System.Drawing.Size(260, 22)
        Me.txtSuEmail.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 14)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Email:"
        '
        'txtSuTelNo3
        '
        Me.txtSuTelNo3.Location = New System.Drawing.Point(110, 225)
        Me.txtSuTelNo3.Mask = "999 0 000 000"
        Me.txtSuTelNo3.Name = "txtSuTelNo3"
        Me.txtSuTelNo3.Size = New System.Drawing.Size(104, 22)
        Me.txtSuTelNo3.TabIndex = 6
        '
        'txtSuTelNo2
        '
        Me.txtSuTelNo2.Location = New System.Drawing.Point(110, 197)
        Me.txtSuTelNo2.Mask = "999 0 000 000"
        Me.txtSuTelNo2.Name = "txtSuTelNo2"
        Me.txtSuTelNo2.Size = New System.Drawing.Size(104, 22)
        Me.txtSuTelNo2.TabIndex = 5
        '
        'txtSuTelNo1
        '
        Me.txtSuTelNo1.Location = New System.Drawing.Point(110, 169)
        Me.txtSuTelNo1.Mask = "999 0 000 000"
        Me.txtSuTelNo1.Name = "txtSuTelNo1"
        Me.txtSuTelNo1.Size = New System.Drawing.Size(104, 22)
        Me.txtSuTelNo1.TabIndex = 4
        '
        'txtSuRemarks
        '
        Me.txtSuRemarks.Location = New System.Drawing.Point(11, 269)
        Me.txtSuRemarks.Multiline = True
        Me.txtSuRemarks.Name = "txtSuRemarks"
        Me.txtSuRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSuRemarks.Size = New System.Drawing.Size(304, 87)
        Me.txtSuRemarks.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Remarks:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 14)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Telephone No 3:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 14)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Telephone No 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Telephone No 1:"
        '
        'txtSuAddress
        '
        Me.txtSuAddress.Location = New System.Drawing.Point(68, 77)
        Me.txtSuAddress.Multiline = True
        Me.txtSuAddress.Name = "txtSuAddress"
        Me.txtSuAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSuAddress.Size = New System.Drawing.Size(247, 58)
        Me.txtSuAddress.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Address:"
        '
        'txtSuNo
        '
        Me.txtSuNo.Enabled = False
        Me.txtSuNo.Location = New System.Drawing.Point(42, 21)
        Me.txtSuNo.Name = "txtSuNo"
        Me.txtSuNo.Size = New System.Drawing.Size(65, 22)
        Me.txtSuNo.TabIndex = 0
        '
        'cmbSuName
        '
        Me.cmbSuName.FormattingEnabled = True
        Me.cmbSuName.Location = New System.Drawing.Point(57, 49)
        Me.cmbSuName.Name = "cmbSuName"
        Me.cmbSuName.Size = New System.Drawing.Size(258, 22)
        Me.cmbSuName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 14)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "No :"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(158, 400)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(50, 51)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(101, 400)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(51, 51)
        Me.cmdNew.TabIndex = 9
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Image = CType(resources.GetObject("cmdDone.Image"), System.Drawing.Image)
        Me.cmdDone.Location = New System.Drawing.Point(11, 400)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(84, 51)
        Me.cmdDone.TabIndex = 8
        Me.cmdDone.Text = "Done + Save"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneSaveToolStripMenuItem, Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'DoneSaveToolStripMenuItem
        '
        Me.DoneSaveToolStripMenuItem.Name = "DoneSaveToolStripMenuItem"
        Me.DoneSaveToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DoneSaveToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DoneSaveToolStripMenuItem.Text = "Done + Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 609)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - Supplier"
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.grdSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grdSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbSuName As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdDone As Button
    Friend WithEvents txtSuEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSuTelNo3 As MaskedTextBox
    Friend WithEvents txtSuTelNo2 As MaskedTextBox
    Friend WithEvents txtSuTelNo1 As MaskedTextBox
    Friend WithEvents txtSuRemarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSuAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoneSaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
