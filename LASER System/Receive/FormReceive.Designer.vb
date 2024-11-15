<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReceive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.RepairGridRepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridPCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridPSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridPDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridProblem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairGridTName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grdReRepair = New System.Windows.Forms.DataGridView()
        Me.ReRepairGridRetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridRepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridPCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridPSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridPDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridProblem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepairGridTName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdReRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(990, 105)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 33)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(990, 66)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 33)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Location = New System.Drawing.Point(990, 27)
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
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1057, 156)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Repair Collection"
        '
        'grdRepair
        '
        Me.grdRepair.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairGridRepNo, Me.RepairGridPCategory, Me.RepairGridPName, Me.RepairGridPSerialNo, Me.RepairGridPDescription, Me.RepairGridQty, Me.RepairGridProblem, Me.RepairGridRemarks, Me.RepairGridTName})
        Me.grdRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdRepair.Location = New System.Drawing.Point(3, 20)
        Me.grdRepair.Name = "grdRepair"
        Me.grdRepair.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grdRepair.Size = New System.Drawing.Size(1051, 133)
        Me.grdRepair.TabIndex = 6
        '
        'RepairGridRepNo
        '
        Me.RepairGridRepNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepairGridRepNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.RepairGridRepNo.HeaderText = "Repair No"
        Me.RepairGridRepNo.Name = "RepairGridRepNo"
        Me.RepairGridRepNo.ReadOnly = True
        Me.RepairGridRepNo.Width = 82
        '
        'RepairGridPCategory
        '
        Me.RepairGridPCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepairGridPCategory.HeaderText = "Product Category"
        Me.RepairGridPCategory.Name = "RepairGridPCategory"
        '
        'RepairGridPName
        '
        Me.RepairGridPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepairGridPName.HeaderText = "Product Name"
        Me.RepairGridPName.Name = "RepairGridPName"
        '
        'RepairGridPSerialNo
        '
        Me.RepairGridPSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepairGridPSerialNo.HeaderText = "Product Serial No"
        Me.RepairGridPSerialNo.Name = "RepairGridPSerialNo"
        '
        'RepairGridPDescription
        '
        Me.RepairGridPDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepairGridPDescription.HeaderText = "Product Description"
        Me.RepairGridPDescription.Name = "RepairGridPDescription"
        '
        'RepairGridQty
        '
        Me.RepairGridQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.NullValue = "1"
        Me.RepairGridQty.DefaultCellStyle = DataGridViewCellStyle2
        Me.RepairGridQty.HeaderText = "Qty"
        Me.RepairGridQty.Name = "RepairGridQty"
        Me.RepairGridQty.Width = 53
        '
        'RepairGridProblem
        '
        Me.RepairGridProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepairGridProblem.DefaultCellStyle = DataGridViewCellStyle3
        Me.RepairGridProblem.HeaderText = "Problem"
        Me.RepairGridProblem.Name = "RepairGridProblem"
        '
        'RepairGridRemarks
        '
        Me.RepairGridRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepairGridRemarks.DefaultCellStyle = DataGridViewCellStyle4
        Me.RepairGridRemarks.HeaderText = "Remarks"
        Me.RepairGridRemarks.Name = "RepairGridRemarks"
        '
        'RepairGridTName
        '
        Me.RepairGridTName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.NullValue = "None"
        Me.RepairGridTName.DefaultCellStyle = DataGridViewCellStyle5
        Me.RepairGridTName.HeaderText = "Technician"
        Me.RepairGridTName.Items.AddRange(New Object() {"None"})
        Me.RepairGridTName.Name = "RepairGridTName"
        Me.RepairGridTName.Width = 73
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grdReRepair)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 165)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1057, 157)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Re-Repair Collection"
        '
        'grdReRepair
        '
        Me.grdReRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReRepairGridRetNo, Me.ReRepairGridRepNo, Me.ReRepairGridPCategory, Me.ReRepairGridPName, Me.ReRepairGridPSerialNo, Me.ReRepairGridPDescription, Me.ReRepairGridQty, Me.ReRepairGridProblem, Me.ReRepairGridRemarks, Me.ReRepairGridTName})
        Me.grdReRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdReRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdReRepair.Location = New System.Drawing.Point(3, 20)
        Me.grdReRepair.Name = "grdReRepair"
        Me.grdReRepair.Size = New System.Drawing.Size(1051, 134)
        Me.grdReRepair.TabIndex = 7
        '
        'ReRepairGridRetNo
        '
        Me.ReRepairGridRetNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReRepairGridRetNo.HeaderText = "Re-Repair No"
        Me.ReRepairGridRetNo.Name = "ReRepairGridRetNo"
        Me.ReRepairGridRetNo.ReadOnly = True
        Me.ReRepairGridRetNo.Width = 99
        '
        'ReRepairGridRepNo
        '
        Me.ReRepairGridRepNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReRepairGridRepNo.HeaderText = "Repair No"
        Me.ReRepairGridRepNo.Name = "ReRepairGridRepNo"
        Me.ReRepairGridRepNo.Width = 82
        '
        'ReRepairGridPCategory
        '
        Me.ReRepairGridPCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReRepairGridPCategory.HeaderText = "Product Category"
        Me.ReRepairGridPCategory.Name = "ReRepairGridPCategory"
        Me.ReRepairGridPCategory.ReadOnly = True
        '
        'ReRepairGridPName
        '
        Me.ReRepairGridPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReRepairGridPName.HeaderText = "Product Name"
        Me.ReRepairGridPName.Name = "ReRepairGridPName"
        Me.ReRepairGridPName.ReadOnly = True
        '
        'ReRepairGridPSerialNo
        '
        Me.ReRepairGridPSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReRepairGridPSerialNo.HeaderText = "Product Serial No"
        Me.ReRepairGridPSerialNo.Name = "ReRepairGridPSerialNo"
        '
        'ReRepairGridPDescription
        '
        Me.ReRepairGridPDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReRepairGridPDescription.HeaderText = "Product Description"
        Me.ReRepairGridPDescription.Name = "ReRepairGridPDescription"
        Me.ReRepairGridPDescription.ReadOnly = True
        '
        'ReRepairGridQty
        '
        Me.ReRepairGridQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.NullValue = "1"
        Me.ReRepairGridQty.DefaultCellStyle = DataGridViewCellStyle6
        Me.ReRepairGridQty.HeaderText = "Qty"
        Me.ReRepairGridQty.Name = "ReRepairGridQty"
        Me.ReRepairGridQty.ReadOnly = True
        Me.ReRepairGridQty.Width = 53
        '
        'ReRepairGridProblem
        '
        Me.ReRepairGridProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReRepairGridProblem.HeaderText = "Problem"
        Me.ReRepairGridProblem.Name = "ReRepairGridProblem"
        '
        'ReRepairGridRemarks
        '
        Me.ReRepairGridRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReRepairGridRemarks.HeaderText = "Remarks"
        Me.ReRepairGridRemarks.Name = "ReRepairGridRemarks"
        '
        'ReRepairGridTName
        '
        DataGridViewCellStyle7.NullValue = "None"
        Me.ReRepairGridTName.DefaultCellStyle = DataGridViewCellStyle7
        Me.ReRepairGridTName.HeaderText = "Technician"
        Me.ReRepairGridTName.Items.AddRange(New Object() {"None"})
        Me.ReRepairGridTName.Name = "ReRepairGridTName"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Green
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1087, 24)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 177)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1063, 325)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'FormReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1087, 514)
        Me.Controls.Add(Me.TableLayoutPanel1)
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
        Me.Name = "FormReceive"
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
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents cmbCuMr As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RepairGridRepNo As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridPCategory As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridPName As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridPSerialNo As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridPDescription As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridQty As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridProblem As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridRemarks As DataGridViewTextBoxColumn
    Friend WithEvents RepairGridTName As DataGridViewComboBoxColumn
    Friend WithEvents ReRepairGridRetNo As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridRepNo As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridPCategory As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridPName As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridPSerialNo As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridPDescription As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridQty As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridProblem As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridRemarks As DataGridViewTextBoxColumn
    Friend WithEvents ReRepairGridTName As DataGridViewComboBoxColumn
End Class
