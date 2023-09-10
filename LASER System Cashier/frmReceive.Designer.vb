<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRNo = New System.Windows.Forms.Label()
        Me.txtRDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRNo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCuMr = New System.Windows.Forms.ComboBox()
        Me.txtCuTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCuTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCuView = New System.Windows.Forms.Button()
        Me.txtCuTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmbCuName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdRepair = New System.Windows.Forms.DataGridView()
        Me.RepairNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PModelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PProblem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grdReRepair = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlRSaveFinal = New System.Windows.Forms.Panel()
        Me.grpComInfo = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSaveOnly = New System.Windows.Forms.Button()
        Me.cmdReceiptSticker = New System.Windows.Forms.Button()
        Me.cmdSticker = New System.Windows.Forms.Button()
        Me.cmdReceipt = New System.Windows.Forms.Button()
        Me.RERepairNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetRepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETPCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETPModelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETPSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETPDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETProblem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdReRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.pnlRSaveFinal.SuspendLayout()
        Me.grpComInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Received Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRNo)
        Me.GroupBox1.Controls.Add(Me.txtRDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 90)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Received Info"
        '
        'lblRNo
        '
        Me.lblRNo.AutoSize = True
        Me.lblRNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lblRNo.Location = New System.Drawing.Point(236, 56)
        Me.lblRNo.Name = "lblRNo"
        Me.lblRNo.Size = New System.Drawing.Size(34, 17)
        Me.lblRNo.TabIndex = 3
        Me.lblRNo.Text = "REC-"
        Me.lblRNo.Visible = False
        '
        'txtRDate
        '
        Me.txtRDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtRDate.Location = New System.Drawing.Point(107, 23)
        Me.txtRDate.Name = "txtRDate"
        Me.txtRDate.Size = New System.Drawing.Size(218, 24)
        Me.txtRDate.TabIndex = 35
        '
        'txtRNo
        '
        Me.txtRNo.Enabled = False
        Me.txtRNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtRNo.Location = New System.Drawing.Point(276, 53)
        Me.txtRNo.Name = "txtRNo"
        Me.txtRNo.Size = New System.Drawing.Size(49, 24)
        Me.txtRNo.TabIndex = 34
        Me.txtRNo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCuMr)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmdCuView)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo1)
        Me.GroupBox2.Controls.Add(Me.cmbCuName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(349, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 144)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Info"
        '
        'cmbCuMr
        '
        Me.cmbCuMr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuMr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuMr.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCuMr.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbCuMr.FormattingEnabled = True
        Me.cmbCuMr.Items.AddRange(New Object() {"Mr. ", "Mrs. ", "Miss. ", "Dr. ", "Ven. "})
        Me.cmbCuMr.Location = New System.Drawing.Point(61, 113)
        Me.cmbCuMr.Name = "cmbCuMr"
        Me.cmbCuMr.Size = New System.Drawing.Size(64, 23)
        Me.cmbCuMr.TabIndex = 3
        '
        'txtCuTelNo3
        '
        Me.txtCuTelNo3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuTelNo3.Location = New System.Drawing.Point(114, 83)
        Me.txtCuTelNo3.Mask = "999 0 000 000"
        Me.txtCuTelNo3.Name = "txtCuTelNo3"
        Me.txtCuTelNo3.Size = New System.Drawing.Size(104, 24)
        Me.txtCuTelNo3.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Telephone No 3 :"
        '
        'txtCuTelNo2
        '
        Me.txtCuTelNo2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuTelNo2.Location = New System.Drawing.Point(114, 53)
        Me.txtCuTelNo2.Mask = "999 0 000 000"
        Me.txtCuTelNo2.Name = "txtCuTelNo2"
        Me.txtCuTelNo2.Size = New System.Drawing.Size(104, 24)
        Me.txtCuTelNo2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Telephone No 2 :"
        '
        'cmdCuView
        '
        Me.cmdCuView.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdCuView.Location = New System.Drawing.Point(328, 113)
        Me.cmdCuView.Name = "cmdCuView"
        Me.cmdCuView.Size = New System.Drawing.Size(30, 23)
        Me.cmdCuView.TabIndex = 5
        Me.cmdCuView.Text = "..."
        Me.cmdCuView.UseVisualStyleBackColor = True
        '
        'txtCuTelNo1
        '
        Me.txtCuTelNo1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuTelNo1.Location = New System.Drawing.Point(114, 23)
        Me.txtCuTelNo1.Mask = "999 0 000 000"
        Me.txtCuTelNo1.Name = "txtCuTelNo1"
        Me.txtCuTelNo1.Size = New System.Drawing.Size(104, 24)
        Me.txtCuTelNo1.TabIndex = 0
        '
        'cmbCuName
        '
        Me.cmbCuName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCuName.DisplayMember = "CuName"
        Me.cmbCuName.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbCuName.FormattingEnabled = True
        Me.cmbCuName.Location = New System.Drawing.Point(131, 113)
        Me.cmbCuName.Name = "cmbCuName"
        Me.cmbCuName.Size = New System.Drawing.Size(191, 23)
        Me.cmbCuName.TabIndex = 4
        Me.cmbCuName.ValueMember = "CuName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telephone No 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Name :"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(1259, 105)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 33)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(1259, 66)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 33)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(1259, 27)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 33)
        Me.cmdNew.TabIndex = 8
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdRepair)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1332, 279)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Repair Collection"
        '
        'grdRepair
        '
        Me.grdRepair.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairNo, Me.PCategory, Me.PName, Me.PModelNo, Me.PSerialNo, Me.PDescription, Me.PQty, Me.PProblem, Me.PRemarks})
        Me.grdRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdRepair.Location = New System.Drawing.Point(6, 21)
        Me.grdRepair.Name = "grdRepair"
        Me.grdRepair.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grdRepair.Size = New System.Drawing.Size(1320, 252)
        Me.grdRepair.TabIndex = 6
        '
        'RepairNo
        '
        Me.RepairNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepairNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.RepairNo.HeaderText = "Repair No"
        Me.RepairNo.Name = "RepairNo"
        Me.RepairNo.ReadOnly = True
        Me.RepairNo.Width = 82
        '
        'PCategory
        '
        Me.PCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PCategory.HeaderText = "Product Category"
        Me.PCategory.Name = "PCategory"
        '
        'PName
        '
        Me.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PName.HeaderText = "Product Name"
        Me.PName.Name = "PName"
        '
        'PModelNo
        '
        Me.PModelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PModelNo.HeaderText = "Product Model No"
        Me.PModelNo.Name = "PModelNo"
        '
        'PSerialNo
        '
        Me.PSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSerialNo.HeaderText = "Product Serial No"
        Me.PSerialNo.Name = "PSerialNo"
        '
        'PDescription
        '
        Me.PDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PDescription.HeaderText = "Product Description"
        Me.PDescription.Name = "PDescription"
        '
        'PQty
        '
        Me.PQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.NullValue = "1"
        Me.PQty.DefaultCellStyle = DataGridViewCellStyle2
        Me.PQty.HeaderText = "Qty"
        Me.PQty.Name = "PQty"
        Me.PQty.Width = 53
        '
        'PProblem
        '
        Me.PProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PProblem.DefaultCellStyle = DataGridViewCellStyle3
        Me.PProblem.HeaderText = "Problem"
        Me.PProblem.Name = "PProblem"
        '
        'PRemarks
        '
        Me.PRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRemarks.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRemarks.HeaderText = "Remarks"
        Me.PRemarks.Name = "PRemarks"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grdReRepair)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 462)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1332, 218)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Re-Repair Collection"
        '
        'grdReRepair
        '
        Me.grdReRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RERepairNo, Me.RetRepNo, Me.RETPCategory, Me.RETPName, Me.RETPModelNo, Me.RETPSerialNo, Me.RETPDescription, Me.RETQty, Me.RETProblem, Me.RETRemarks})
        Me.grdReRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdReRepair.Location = New System.Drawing.Point(6, 21)
        Me.grdReRepair.Name = "grdReRepair"
        Me.grdReRepair.Size = New System.Drawing.Size(1320, 191)
        Me.grdReRepair.TabIndex = 7
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Green
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1364, 24)
        Me.MenuStrip.TabIndex = 58
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
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
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerInfoToolStripMenuItem, Me.ProductInfoToolStripMenuItem, Me.RepairInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'CustomerInfoToolStripMenuItem
        '
        Me.CustomerInfoToolStripMenuItem.Name = "CustomerInfoToolStripMenuItem"
        Me.CustomerInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CustomerInfoToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CustomerInfoToolStripMenuItem.Text = "Customer Info"
        '
        'ProductInfoToolStripMenuItem
        '
        Me.ProductInfoToolStripMenuItem.Name = "ProductInfoToolStripMenuItem"
        Me.ProductInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProductInfoToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ProductInfoToolStripMenuItem.Text = "Product Info"
        '
        'RepairInfoToolStripMenuItem
        '
        Me.RepairInfoToolStripMenuItem.Name = "RepairInfoToolStripMenuItem"
        Me.RepairInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RepairInfoToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.RepairInfoToolStripMenuItem.Text = "Repair Info"
        '
        'pnlRSaveFinal
        '
        Me.pnlRSaveFinal.Controls.Add(Me.grpComInfo)
        Me.pnlRSaveFinal.Location = New System.Drawing.Point(719, 27)
        Me.pnlRSaveFinal.Name = "pnlRSaveFinal"
        Me.pnlRSaveFinal.Size = New System.Drawing.Size(539, 108)
        Me.pnlRSaveFinal.TabIndex = 59
        Me.pnlRSaveFinal.Visible = False
        '
        'grpComInfo
        '
        Me.grpComInfo.Controls.Add(Me.cmdCancel)
        Me.grpComInfo.Controls.Add(Me.cmdSaveOnly)
        Me.grpComInfo.Controls.Add(Me.cmdReceiptSticker)
        Me.grpComInfo.Controls.Add(Me.cmdSticker)
        Me.grpComInfo.Controls.Add(Me.cmdReceipt)
        Me.grpComInfo.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.grpComInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpComInfo.Name = "grpComInfo"
        Me.grpComInfo.Size = New System.Drawing.Size(522, 101)
        Me.grpComInfo.TabIndex = 107
        Me.grpComInfo.TabStop = False
        Me.grpComInfo.Text = "Command Info"
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdCancel.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdCancel.Location = New System.Drawing.Point(488, 7)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(34, 30)
        Me.cmdCancel.TabIndex = 105
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSaveOnly
        '
        Me.cmdSaveOnly.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdSaveOnly.Location = New System.Drawing.Point(408, 23)
        Me.cmdSaveOnly.Name = "cmdSaveOnly"
        Me.cmdSaveOnly.Size = New System.Drawing.Size(68, 65)
        Me.cmdSaveOnly.TabIndex = 106
        Me.cmdSaveOnly.Text = "Save Only"
        Me.cmdSaveOnly.UseVisualStyleBackColor = True
        '
        'cmdReceiptSticker
        '
        Me.cmdReceiptSticker.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdReceiptSticker.Location = New System.Drawing.Point(6, 23)
        Me.cmdReceiptSticker.Name = "cmdReceiptSticker"
        Me.cmdReceiptSticker.Size = New System.Drawing.Size(142, 65)
        Me.cmdReceiptSticker.TabIndex = 103
        Me.cmdReceiptSticker.Text = "බිල්පතක් සහ  Repair Sticker එකක් අවශ්‍යයි."
        Me.cmdReceiptSticker.UseVisualStyleBackColor = True
        '
        'cmdSticker
        '
        Me.cmdSticker.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdSticker.Location = New System.Drawing.Point(281, 23)
        Me.cmdSticker.Name = "cmdSticker"
        Me.cmdSticker.Size = New System.Drawing.Size(121, 65)
        Me.cmdSticker.TabIndex = 105
        Me.cmdSticker.Text = "Repair Sticker එකක් පමණක් අවශ්‍යයි."
        Me.cmdSticker.UseVisualStyleBackColor = True
        '
        'cmdReceipt
        '
        Me.cmdReceipt.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdReceipt.Location = New System.Drawing.Point(154, 23)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(121, 65)
        Me.cmdReceipt.TabIndex = 104
        Me.cmdReceipt.Text = "බිල්පතක් පමණක් අවශ්‍යයි."
        Me.cmdReceipt.UseVisualStyleBackColor = True
        '
        'RERepairNo
        '
        Me.RERepairNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RERepairNo.HeaderText = "Re-Repair No"
        Me.RERepairNo.Name = "RERepairNo"
        Me.RERepairNo.ReadOnly = True
        Me.RERepairNo.Width = 108
        '
        'RetRepNo
        '
        Me.RetRepNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RetRepNo.HeaderText = "Repair No"
        Me.RetRepNo.Name = "RetRepNo"
        Me.RetRepNo.Width = 89
        '
        'RETPCategory
        '
        Me.RETPCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETPCategory.HeaderText = "Product Category"
        Me.RETPCategory.Name = "RETPCategory"
        Me.RETPCategory.ReadOnly = True
        '
        'RETPName
        '
        Me.RETPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETPName.HeaderText = "Product Name"
        Me.RETPName.Name = "RETPName"
        Me.RETPName.ReadOnly = True
        '
        'RETPModelNo
        '
        Me.RETPModelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETPModelNo.HeaderText = "Product Model No"
        Me.RETPModelNo.Name = "RETPModelNo"
        Me.RETPModelNo.ReadOnly = True
        '
        'RETPSerialNo
        '
        Me.RETPSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETPSerialNo.HeaderText = "Product Serial No"
        Me.RETPSerialNo.Name = "RETPSerialNo"
        '
        'RETPDescription
        '
        Me.RETPDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETPDescription.HeaderText = "Product Description"
        Me.RETPDescription.Name = "RETPDescription"
        Me.RETPDescription.ReadOnly = True
        '
        'RETQty
        '
        Me.RETQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.NullValue = "1"
        Me.RETQty.DefaultCellStyle = DataGridViewCellStyle5
        Me.RETQty.HeaderText = "Qty"
        Me.RETQty.Name = "RETQty"
        Me.RETQty.ReadOnly = True
        Me.RETQty.Width = 53
        '
        'RETProblem
        '
        Me.RETProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETProblem.HeaderText = "Problem"
        Me.RETProblem.Name = "RETProblem"
        '
        'RETRemarks
        '
        Me.RETRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RETRemarks.HeaderText = "Remarks"
        Me.RETRemarks.Name = "RETRemarks"
        '
        'frmReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1364, 731)
        Me.Controls.Add(Me.pnlRSaveFinal)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmReceive"
        Me.Text = "LASER System - Receive Products from Customer for Repairing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grdReRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.pnlRSaveFinal.ResumeLayout(False)
        Me.grpComInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCuView As System.Windows.Forms.Button
    Friend WithEvents txtCuTelNo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCuName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents txtCuTelNo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCuTelNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdRepair As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grdReRepair As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepairInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRNo As Label
    Friend WithEvents pnlRSaveFinal As Panel
    Friend WithEvents cmdSaveOnly As Button
    Friend WithEvents cmdSticker As Button
    Friend WithEvents cmdReceipt As Button
    Friend WithEvents cmdReceiptSticker As Button
    Friend WithEvents grpComInfo As GroupBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents RepairNo As DataGridViewTextBoxColumn
    Friend WithEvents PCategory As DataGridViewTextBoxColumn
    Friend WithEvents PName As DataGridViewTextBoxColumn
    Friend WithEvents PModelNo As DataGridViewTextBoxColumn
    Friend WithEvents PSerialNo As DataGridViewTextBoxColumn
    Friend WithEvents PDescription As DataGridViewTextBoxColumn
    Friend WithEvents PQty As DataGridViewTextBoxColumn
    Friend WithEvents PProblem As DataGridViewTextBoxColumn
    Friend WithEvents PRemarks As DataGridViewTextBoxColumn
    Friend WithEvents cmbCuMr As ComboBox
    Friend WithEvents RERepairNo As DataGridViewTextBoxColumn
    Friend WithEvents RetRepNo As DataGridViewTextBoxColumn
    Friend WithEvents RETPCategory As DataGridViewTextBoxColumn
    Friend WithEvents RETPName As DataGridViewTextBoxColumn
    Friend WithEvents RETPModelNo As DataGridViewTextBoxColumn
    Friend WithEvents RETPSerialNo As DataGridViewTextBoxColumn
    Friend WithEvents RETPDescription As DataGridViewTextBoxColumn
    Friend WithEvents RETQty As DataGridViewTextBoxColumn
    Friend WithEvents RETProblem As DataGridViewTextBoxColumn
    Friend WithEvents RETRemarks As DataGridViewTextBoxColumn
End Class
