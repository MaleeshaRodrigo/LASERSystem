<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechnician
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechnician))
        Me.grpTInfo = New System.Windows.Forms.GroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtTEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtTTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtTRemarks = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTNICNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTFullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdTechnician = New System.Windows.Forms.DataGridView()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNICNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTelNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTelNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTelNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpTInfo.SuspendLayout()
        CType(Me.grdTechnician, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTInfo
        '
        Me.grpTInfo.Controls.Add(Me.chkActive)
        Me.grpTInfo.Controls.Add(Me.txtTEmail)
        Me.grpTInfo.Controls.Add(Me.Label12)
        Me.grpTInfo.Controls.Add(Me.txtTTelNo3)
        Me.grpTInfo.Controls.Add(Me.txtTTelNo2)
        Me.grpTInfo.Controls.Add(Me.txtTTelNo1)
        Me.grpTInfo.Controls.Add(Me.cmdDone)
        Me.grpTInfo.Controls.Add(Me.cmdDelete)
        Me.grpTInfo.Controls.Add(Me.txtTRemarks)
        Me.grpTInfo.Controls.Add(Me.Label9)
        Me.grpTInfo.Controls.Add(Me.cmbTName)
        Me.grpTInfo.Controls.Add(Me.cmdNew)
        Me.grpTInfo.Controls.Add(Me.cmdClose)
        Me.grpTInfo.Controls.Add(Me.cmdSave)
        Me.grpTInfo.Controls.Add(Me.Label8)
        Me.grpTInfo.Controls.Add(Me.Label7)
        Me.grpTInfo.Controls.Add(Me.Label6)
        Me.grpTInfo.Controls.Add(Me.txtTAddress)
        Me.grpTInfo.Controls.Add(Me.Label5)
        Me.grpTInfo.Controls.Add(Me.txtTNICNo)
        Me.grpTInfo.Controls.Add(Me.Label4)
        Me.grpTInfo.Controls.Add(Me.txtTFullName)
        Me.grpTInfo.Controls.Add(Me.Label3)
        Me.grpTInfo.Controls.Add(Me.Label2)
        Me.grpTInfo.Controls.Add(Me.txtTNo)
        Me.grpTInfo.Controls.Add(Me.Label1)
        Me.grpTInfo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTInfo.Location = New System.Drawing.Point(7, 27)
        Me.grpTInfo.Name = "grpTInfo"
        Me.grpTInfo.Size = New System.Drawing.Size(290, 475)
        Me.grpTInfo.TabIndex = 0
        Me.grpTInfo.TabStop = False
        Me.grpTInfo.Text = "Technician Info"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(227, 17)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(57, 18)
        Me.chkActive.TabIndex = 31
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtTEmail
        '
        Me.txtTEmail.Location = New System.Drawing.Point(53, 216)
        Me.txtTEmail.Name = "txtTEmail"
        Me.txtTEmail.Size = New System.Drawing.Size(231, 22)
        Me.txtTEmail.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 14)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Email:"
        '
        'txtTTelNo3
        '
        Me.txtTTelNo3.Location = New System.Drawing.Point(108, 300)
        Me.txtTTelNo3.Mask = "999 0 000 000"
        Me.txtTTelNo3.Name = "txtTTelNo3"
        Me.txtTTelNo3.Size = New System.Drawing.Size(104, 22)
        Me.txtTTelNo3.TabIndex = 28
        '
        'txtTTelNo2
        '
        Me.txtTTelNo2.Location = New System.Drawing.Point(108, 272)
        Me.txtTTelNo2.Mask = "999 0 000 000"
        Me.txtTTelNo2.Name = "txtTTelNo2"
        Me.txtTTelNo2.Size = New System.Drawing.Size(104, 22)
        Me.txtTTelNo2.TabIndex = 27
        '
        'txtTTelNo1
        '
        Me.txtTTelNo1.Location = New System.Drawing.Point(108, 244)
        Me.txtTTelNo1.Mask = "999 0 000 000"
        Me.txtTTelNo1.Name = "txtTTelNo1"
        Me.txtTTelNo1.Size = New System.Drawing.Size(104, 22)
        Me.txtTTelNo1.TabIndex = 26
        '
        'cmdDone
        '
        Me.cmdDone.Image = CType(resources.GetObject("cmdDone.Image"), System.Drawing.Image)
        Me.cmdDone.Location = New System.Drawing.Point(6, 424)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(81, 42)
        Me.cmdDone.TabIndex = 24
        Me.cmdDone.Text = "Done + Save"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(184, 424)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 43)
        Me.cmdDelete.TabIndex = 25
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtTRemarks
        '
        Me.txtTRemarks.Location = New System.Drawing.Point(9, 344)
        Me.txtTRemarks.Multiline = True
        Me.txtTRemarks.Name = "txtTRemarks"
        Me.txtTRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTRemarks.Size = New System.Drawing.Size(275, 74)
        Me.txtTRemarks.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Remarks:"
        '
        'cmbTName
        '
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(54, 43)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(230, 22)
        Me.cmbTName.TabIndex = 21
        '
        'cmdNew
        '
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(93, 424)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(39, 43)
        Me.cmdNew.TabIndex = 20
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(242, 424)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(45, 43)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(138, 424)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(40, 44)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Telephone No 3:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Telephone No 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telephone No 1:"
        '
        'txtTAddress
        '
        Me.txtTAddress.Location = New System.Drawing.Point(66, 152)
        Me.txtTAddress.Multiline = True
        Me.txtTAddress.Name = "txtTAddress"
        Me.txtTAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTAddress.Size = New System.Drawing.Size(218, 58)
        Me.txtTAddress.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address:"
        '
        'txtTNICNo
        '
        Me.txtTNICNo.Location = New System.Drawing.Point(151, 122)
        Me.txtTNICNo.Name = "txtTNICNo"
        Me.txtTNICNo.Size = New System.Drawing.Size(133, 22)
        Me.txtTNICNo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "National Identy Card No:"
        '
        'txtTFullName
        '
        Me.txtTFullName.Location = New System.Drawing.Point(78, 71)
        Me.txtTFullName.Multiline = True
        Me.txtTFullName.Name = "txtTFullName"
        Me.txtTFullName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTFullName.Size = New System.Drawing.Size(206, 45)
        Me.txtTFullName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'txtTNo
        '
        Me.txtTNo.Location = New System.Drawing.Point(37, 15)
        Me.txtTNo.Name = "txtTNo"
        Me.txtTNo.Size = New System.Drawing.Size(53, 22)
        Me.txtTNo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No:"
        '
        'grdTechnician
        '
        Me.grdTechnician.AllowUserToAddRows = False
        Me.grdTechnician.AllowUserToDeleteRows = False
        Me.grdTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTechnician.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TActive, Me.TNo, Me.TName, Me.TFullName, Me.TNICNo, Me.TEmail, Me.TAddress, Me.TTelNo1, Me.TTelNo2, Me.TTelNo3, Me.TRemarks})
        Me.grdTechnician.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdTechnician.Location = New System.Drawing.Point(6, 50)
        Me.grdTechnician.MultiSelect = False
        Me.grdTechnician.Name = "grdTechnician"
        Me.grdTechnician.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTechnician.Size = New System.Drawing.Size(887, 417)
        Me.grdTechnician.TabIndex = 1
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.Label10)
        Me.grpSearch.Controls.Add(Me.grdTechnician)
        Me.grpSearch.Location = New System.Drawing.Point(303, 27)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(899, 475)
        Me.grpSearch.TabIndex = 2
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search and Data View"
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Technician No", "Technician Name", "Technician Full Name", "Technician NIC No", "Technician Address", "Technician Telephone No 1", "Technician Telephone No 2", "Technician Telephone No 3", "Remarks", "All"})
        Me.cmbFilter.Location = New System.Drawing.Point(311, 20)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(159, 22)
        Me.cmbFilter.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(269, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 14)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Filter"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(57, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(206, 22)
        Me.txtSearch.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 14)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Search"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1214, 24)
        Me.MenuStrip.TabIndex = 39
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneToolStripMenuItem, Me.NewToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'DoneToolStripMenuItem
        '
        Me.DoneToolStripMenuItem.Name = "DoneToolStripMenuItem"
        Me.DoneToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DoneToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DoneToolStripMenuItem.Text = "Done"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TActive
        '
        Me.TActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TActive.DataPropertyName = "TActive"
        Me.TActive.HeaderText = "Active"
        Me.TActive.Name = "TActive"
        Me.TActive.Width = 44
        '
        'TNo
        '
        Me.TNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TNo.DataPropertyName = "TNo"
        Me.TNo.HeaderText = "No"
        Me.TNo.Name = "TNo"
        Me.TNo.Width = 47
        '
        'TName
        '
        Me.TName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TName.DataPropertyName = "TName"
        Me.TName.HeaderText = "Name"
        Me.TName.Name = "TName"
        Me.TName.Width = 64
        '
        'TFullName
        '
        Me.TFullName.DataPropertyName = "TFullName"
        Me.TFullName.HeaderText = "Full Name"
        Me.TFullName.Name = "TFullName"
        '
        'TNICNo
        '
        Me.TNICNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TNICNo.DataPropertyName = "TNICNo"
        Me.TNICNo.HeaderText = "NIC No"
        Me.TNICNo.Name = "TNICNo"
        Me.TNICNo.Width = 68
        '
        'TEmail
        '
        Me.TEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TEmail.DataPropertyName = "TEmail"
        Me.TEmail.HeaderText = "Email"
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Width = 63
        '
        'TAddress
        '
        Me.TAddress.DataPropertyName = "TAddress"
        Me.TAddress.HeaderText = "Address"
        Me.TAddress.Name = "TAddress"
        '
        'TTelNo1
        '
        Me.TTelNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TTelNo1.DataPropertyName = "TTelNo1"
        Me.TTelNo1.HeaderText = "Telephone No1"
        Me.TTelNo1.Name = "TTelNo1"
        Me.TTelNo1.Width = 105
        '
        'TTelNo2
        '
        Me.TTelNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TTelNo2.DataPropertyName = "TTelNo2"
        Me.TTelNo2.HeaderText = "Telephone No2"
        Me.TTelNo2.Name = "TTelNo2"
        Me.TTelNo2.Width = 105
        '
        'TTelNo3
        '
        Me.TTelNo3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TTelNo3.DataPropertyName = "TTelNo3"
        Me.TTelNo3.HeaderText = "Telephone No3"
        Me.TTelNo3.Name = "TTelNo3"
        Me.TTelNo3.Width = 105
        '
        'TRemarks
        '
        Me.TRemarks.DataPropertyName = "TRemarks"
        Me.TRemarks.HeaderText = "Remarks"
        Me.TRemarks.Name = "TRemarks"
        '
        'frmTechnician
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 499)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpTInfo)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmTechnician"
        Me.Text = "LASER System - Technician"
        Me.grpTInfo.ResumeLayout(False)
        Me.grpTInfo.PerformLayout()
        CType(Me.grdTechnician, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtTNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTNICNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents grdTechnician As System.Windows.Forms.DataGridView
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbTName As System.Windows.Forms.ComboBox
    Friend WithEvents txtTRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtTTelNo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTTelNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTTelNo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents DoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TActive As DataGridViewCheckBoxColumn
    Friend WithEvents TNo As DataGridViewTextBoxColumn
    Friend WithEvents TName As DataGridViewTextBoxColumn
    Friend WithEvents TFullName As DataGridViewTextBoxColumn
    Friend WithEvents TNICNo As DataGridViewTextBoxColumn
    Friend WithEvents TEmail As DataGridViewTextBoxColumn
    Friend WithEvents TAddress As DataGridViewTextBoxColumn
    Friend WithEvents TTelNo1 As DataGridViewTextBoxColumn
    Friend WithEvents TTelNo2 As DataGridViewTextBoxColumn
    Friend WithEvents TTelNo3 As DataGridViewTextBoxColumn
    Friend WithEvents TRemarks As DataGridViewTextBoxColumn
End Class
