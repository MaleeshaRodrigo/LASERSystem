<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grdCustomer = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCuTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCuRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtCuTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tlpanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpanelDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.grdCuLoan = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grdSale = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdRepair = New System.Windows.Forms.DataGridView()
        Me.TextCuName = New System.Windows.Forms.TextBox()
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.tlpanelMain.SuspendLayout()
        Me.tlpanelDetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdCuLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Filter"
        '
        'txtCuNo
        '
        Me.txtCuNo.Enabled = False
        Me.txtCuNo.Location = New System.Drawing.Point(268, 21)
        Me.txtCuNo.Name = "txtCuNo"
        Me.txtCuNo.Size = New System.Drawing.Size(45, 22)
        Me.txtCuNo.TabIndex = 0
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
        'grdCustomer
        '
        Me.grdCustomer.AllowUserToAddRows = False
        Me.grdCustomer.AllowUserToDeleteRows = False
        Me.grdCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdCustomer.Location = New System.Drawing.Point(7, 50)
        Me.grdCustomer.MultiSelect = False
        Me.grdCustomer.Name = "grdCustomer"
        Me.grdCustomer.RowHeadersVisible = False
        Me.grdCustomer.RowHeadersWidth = 51
        Me.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCustomer.Size = New System.Drawing.Size(393, 527)
        Me.grdCustomer.TabIndex = 13
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Location = New System.Drawing.Point(57, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(140, 22)
        Me.txtSearch.TabIndex = 11
        '
        'grpSearch
        '
        Me.grpSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.Label10)
        Me.grpSearch.Controls.Add(Me.grdCustomer)
        Me.grpSearch.Location = New System.Drawing.Point(328, 3)
        Me.grpSearch.MinimumSize = New System.Drawing.Size(406, 290)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(406, 583)
        Me.grpSearch.TabIndex = 27
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search "
        '
        'cmbFilter
        '
        Me.cmbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(241, 21)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(159, 22)
        Me.cmbFilter.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Telephone No 1 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextCuName)
        Me.GroupBox1.Controls.Add(Me.txtCuTelNo1)
        Me.GroupBox1.Controls.Add(Me.txtCuRemarks)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdDone)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cmdNew)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.txtCuTelNo3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCuTelNo2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCuNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(0, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 288)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'txtCuTelNo1
        '
        Me.txtCuTelNo1.Location = New System.Drawing.Point(112, 21)
        Me.txtCuTelNo1.Mask = "999 0 000 000"
        Me.txtCuTelNo1.Name = "txtCuTelNo1"
        Me.txtCuTelNo1.Size = New System.Drawing.Size(109, 22)
        Me.txtCuTelNo1.TabIndex = 2
        '
        'txtCuRemarks
        '
        Me.txtCuRemarks.Location = New System.Drawing.Point(11, 150)
        Me.txtCuRemarks.Multiline = True
        Me.txtCuRemarks.Name = "txtCuRemarks"
        Me.txtCuRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCuRemarks.Size = New System.Drawing.Size(302, 82)
        Me.txtCuRemarks.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Remarks:"
        '
        'cmdDone
        '
        Me.cmdDone.Image = CType(resources.GetObject("cmdDone.Image"), System.Drawing.Image)
        Me.cmdDone.Location = New System.Drawing.Point(8, 238)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(84, 44)
        Me.cmdDone.TabIndex = 6
        Me.cmdDone.Text = "Done + Save"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(144, 238)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(59, 44)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(98, 238)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(40, 44)
        Me.cmdNew.TabIndex = 7
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(266, 238)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(47, 44)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(209, 238)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 44)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtCuTelNo3
        '
        Me.txtCuTelNo3.Location = New System.Drawing.Point(112, 77)
        Me.txtCuTelNo3.Mask = "999 0 000 000"
        Me.txtCuTelNo3.Name = "txtCuTelNo3"
        Me.txtCuTelNo3.Size = New System.Drawing.Size(109, 22)
        Me.txtCuTelNo3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 14)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Telephone No 3 :"
        '
        'txtCuTelNo2
        '
        Me.txtCuTelNo2.Location = New System.Drawing.Point(112, 49)
        Me.txtCuTelNo2.Mask = "999 0 000 000"
        Me.txtCuTelNo2.Name = "txtCuTelNo2"
        Me.txtCuTelNo2.Size = New System.Drawing.Size(109, 22)
        Me.txtCuTelNo2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 14)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Telephone No 2 :"
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
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1150, 24)
        Me.MenuStrip.TabIndex = 28
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'tlpanelMain
        '
        Me.tlpanelMain.ColumnCount = 3
        Me.tlpanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
        Me.tlpanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpanelMain.Controls.Add(Me.tlpanelDetails, 2, 0)
        Me.tlpanelMain.Controls.Add(Me.grpSearch, 1, 0)
        Me.tlpanelMain.Controls.Add(Me.GroupBox1, 0, 0)
        Me.tlpanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpanelMain.Location = New System.Drawing.Point(0, 24)
        Me.tlpanelMain.Name = "tlpanelMain"
        Me.tlpanelMain.RowCount = 1
        Me.tlpanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpanelMain.Size = New System.Drawing.Size(1150, 589)
        Me.tlpanelMain.TabIndex = 30
        '
        'tlpanelDetails
        '
        Me.tlpanelDetails.ColumnCount = 1
        Me.tlpanelDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpanelDetails.Controls.Add(Me.GroupBox5, 0, 2)
        Me.tlpanelDetails.Controls.Add(Me.GroupBox4, 0, 1)
        Me.tlpanelDetails.Controls.Add(Me.GroupBox3, 0, 0)
        Me.tlpanelDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpanelDetails.Location = New System.Drawing.Point(740, 3)
        Me.tlpanelDetails.Name = "tlpanelDetails"
        Me.tlpanelDetails.RowCount = 3
        Me.tlpanelDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpanelDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpanelDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpanelDetails.Size = New System.Drawing.Size(407, 583)
        Me.tlpanelDetails.TabIndex = 28
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.grdCuLoan)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 469)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(401, 111)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Customer Loan Info"
        '
        'grdCuLoan
        '
        Me.grdCuLoan.AllowUserToAddRows = False
        Me.grdCuLoan.AllowUserToDeleteRows = False
        Me.grdCuLoan.AllowUserToOrderColumns = True
        Me.grdCuLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCuLoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCuLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdCuLoan.Location = New System.Drawing.Point(3, 18)
        Me.grdCuLoan.Name = "grdCuLoan"
        Me.grdCuLoan.RowHeadersWidth = 51
        Me.grdCuLoan.Size = New System.Drawing.Size(395, 90)
        Me.grdCuLoan.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grdSale)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 236)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(401, 227)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sale Info"
        '
        'grdSale
        '
        Me.grdSale.AllowUserToAddRows = False
        Me.grdSale.AllowUserToDeleteRows = False
        Me.grdSale.AllowUserToOrderColumns = True
        Me.grdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSale.Location = New System.Drawing.Point(3, 18)
        Me.grdSale.Name = "grdSale"
        Me.grdSale.RowHeadersWidth = 51
        Me.grdSale.Size = New System.Drawing.Size(395, 206)
        Me.grdSale.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdRepair)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(401, 227)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Repair Info"
        '
        'grdRepair
        '
        Me.grdRepair.AllowUserToAddRows = False
        Me.grdRepair.AllowUserToDeleteRows = False
        Me.grdRepair.AllowUserToOrderColumns = True
        Me.grdRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdRepair.Location = New System.Drawing.Point(3, 18)
        Me.grdRepair.Name = "grdRepair"
        Me.grdRepair.RowHeadersWidth = 51
        Me.grdRepair.Size = New System.Drawing.Size(395, 206)
        Me.grdRepair.TabIndex = 0
        '
        'TextCuName
        '
        Me.TextCuName.Location = New System.Drawing.Point(59, 105)
        Me.TextCuName.Name = "TextCuName"
        Me.TextCuName.Size = New System.Drawing.Size(254, 22)
        Me.TextCuName.TabIndex = 40
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 613)
        Me.Controls.Add(Me.tlpanelMain)
        Me.Controls.Add(Me.MenuStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(18, 290)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company System - Customer"
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.tlpanelMain.ResumeLayout(False)
        Me.tlpanelDetails.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.grdCuLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCuNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grdCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtCuTelNo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCuTelNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoneSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents txtCuTelNo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tlpanelMain As TableLayoutPanel
    Friend WithEvents tlpanelDetails As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents grdCuLoan As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdRepair As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents grdSale As DataGridView
    Friend WithEvents TextCuName As TextBox
End Class
