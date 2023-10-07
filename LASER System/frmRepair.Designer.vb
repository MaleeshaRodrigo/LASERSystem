<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepair
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepair))
        Me.boxReceive = New System.Windows.Forms.GroupBox()
        Me.txtRNo = New System.Windows.Forms.TextBox()
        Me.txtRDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxCustomer = New System.Windows.Forms.GroupBox()
        Me.cmbCuName = New System.Windows.Forms.ComboBox()
        Me.cmdCuView = New System.Windows.Forms.Button()
        Me.txtCuTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCuTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCuNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxProduct = New System.Windows.Forms.GroupBox()
        Me.cmdPView = New System.Windows.Forms.Button()
        Me.txtPQty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPSerialNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPDetails = New System.Windows.Forms.TextBox()
        Me.txtPNo = New System.Windows.Forms.TextBox()
        Me.cmbPName = New System.Windows.Forms.ComboBox()
        Me.cmbPCategory = New System.Windows.Forms.ComboBox()
        Me.txtPModelNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPProblem = New System.Windows.Forms.TextBox()
        Me.lblPProblem = New System.Windows.Forms.Label()
        Me.boxTechnician = New System.Windows.Forms.GroupBox()
        Me.cmdTView = New System.Windows.Forms.Button()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.boxRepair = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtRepDate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtRepPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRepRemarks1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.tabRepair = New System.Windows.Forms.TabControl()
        Me.RepInfo = New System.Windows.Forms.TabPage()
        Me.cmdRepView = New System.Windows.Forms.Button()
        Me.cmbRepNo = New System.Windows.Forms.ComboBox()
        Me.cmbRepStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RetInfo = New System.Windows.Forms.TabPage()
        Me.cmbRetRepNo = New System.Windows.Forms.ComboBox()
        Me.cmbRetNo = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmdReRepView = New System.Windows.Forms.Button()
        Me.cmbRetStatus = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.boxDeliver = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDPaidPrice = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDNo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblRepRemarks2 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintReceivedReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRepairStickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDeliverReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.imgRepair = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.grpAdvancePay = New System.Windows.Forms.GroupBox()
        Me.grdAdvance = New System.Windows.Forms.DataGridView()
        Me.AdvancePayAVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvancePayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvancePayPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvancePayRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpActivity = New System.Windows.Forms.GroupBox()
        Me.grdActivity = New System.Windows.Forms.DataGridView()
        Me.ANo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityActivity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpRepTask = New System.Windows.Forms.GroupBox()
        Me.grdRepTask = New System.Windows.Forms.DataGridView()
        Me.TaskTNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.grdRepRemarks2 = New System.Windows.Forms.DataGridView()
        Me.Rem2No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepRemarks2Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepRemarks2Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem2User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdRepRemarks1 = New System.Windows.Forms.DataGridView()
        Me.Rem1No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem1Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem1Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem1UNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxItem = New System.Windows.Forms.GroupBox()
        Me.grdTechnicianCost = New System.Windows.Forms.DataGridView()
        Me.TCNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgPrintReport = New System.ComponentModel.BackgroundWorker()
        Me.boxReceive.SuspendLayout()
        Me.boxCustomer.SuspendLayout()
        Me.boxProduct.SuspendLayout()
        Me.boxTechnician.SuspendLayout()
        Me.boxRepair.SuspendLayout()
        Me.tabRepair.SuspendLayout()
        Me.RepInfo.SuspendLayout()
        Me.RetInfo.SuspendLayout()
        Me.boxDeliver.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.imgRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.grpAdvancePay.SuspendLayout()
        CType(Me.grdAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActivity.SuspendLayout()
        CType(Me.grdActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRepTask.SuspendLayout()
        CType(Me.grdRepTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRepRemarks2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRepRemarks1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxItem.SuspendLayout()
        CType(Me.grdTechnicianCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxReceive
        '
        Me.boxReceive.Controls.Add(Me.txtRNo)
        Me.boxReceive.Controls.Add(Me.txtRDate)
        Me.boxReceive.Controls.Add(Me.Label2)
        Me.boxReceive.Location = New System.Drawing.Point(12, 149)
        Me.boxReceive.Name = "boxReceive"
        Me.boxReceive.Size = New System.Drawing.Size(366, 59)
        Me.boxReceive.TabIndex = 4
        Me.boxReceive.TabStop = False
        Me.boxReceive.Text = "Receive Info"
        '
        'txtRNo
        '
        Me.txtRNo.Enabled = False
        Me.txtRNo.Location = New System.Drawing.Point(314, 21)
        Me.txtRNo.Name = "txtRNo"
        Me.txtRNo.Size = New System.Drawing.Size(45, 26)
        Me.txtRNo.TabIndex = 5
        Me.txtRNo.Visible = False
        '
        'txtRDate
        '
        Me.txtRDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRDate.Location = New System.Drawing.Point(104, 21)
        Me.txtRDate.Name = "txtRDate"
        Me.txtRDate.Size = New System.Drawing.Size(204, 26)
        Me.txtRDate.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Received Date:"
        '
        'boxCustomer
        '
        Me.boxCustomer.Controls.Add(Me.cmbCuName)
        Me.boxCustomer.Controls.Add(Me.cmdCuView)
        Me.boxCustomer.Controls.Add(Me.txtCuTelNo3)
        Me.boxCustomer.Controls.Add(Me.Label12)
        Me.boxCustomer.Controls.Add(Me.txtCuTelNo2)
        Me.boxCustomer.Controls.Add(Me.Label11)
        Me.boxCustomer.Controls.Add(Me.txtCuTelNo1)
        Me.boxCustomer.Controls.Add(Me.txtCuNo)
        Me.boxCustomer.Controls.Add(Me.Label4)
        Me.boxCustomer.Controls.Add(Me.Label5)
        Me.boxCustomer.Location = New System.Drawing.Point(12, 214)
        Me.boxCustomer.Name = "boxCustomer"
        Me.boxCustomer.Size = New System.Drawing.Size(366, 141)
        Me.boxCustomer.TabIndex = 29
        Me.boxCustomer.TabStop = False
        Me.boxCustomer.Text = "Customer Info"
        '
        'cmbCuName
        '
        Me.cmbCuName.FormattingEnabled = True
        Me.cmbCuName.Location = New System.Drawing.Point(63, 18)
        Me.cmbCuName.Name = "cmbCuName"
        Me.cmbCuName.Size = New System.Drawing.Size(267, 26)
        Me.cmbCuName.TabIndex = 8
        '
        'cmdCuView
        '
        Me.cmdCuView.Location = New System.Drawing.Point(334, 18)
        Me.cmdCuView.Name = "cmdCuView"
        Me.cmdCuView.Size = New System.Drawing.Size(26, 22)
        Me.cmdCuView.TabIndex = 9
        Me.cmdCuView.Text = "..."
        Me.cmdCuView.UseVisualStyleBackColor = True
        '
        'txtCuTelNo3
        '
        Me.txtCuTelNo3.Enabled = False
        Me.txtCuTelNo3.Location = New System.Drawing.Point(112, 108)
        Me.txtCuTelNo3.Mask = "999 0 000 000"
        Me.txtCuTelNo3.Name = "txtCuTelNo3"
        Me.txtCuTelNo3.Size = New System.Drawing.Size(92, 26)
        Me.txtCuTelNo3.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 18)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Telephone No 3 :"
        '
        'txtCuTelNo2
        '
        Me.txtCuTelNo2.Enabled = False
        Me.txtCuTelNo2.Location = New System.Drawing.Point(112, 78)
        Me.txtCuTelNo2.Mask = "999 0 000 000"
        Me.txtCuTelNo2.Name = "txtCuTelNo2"
        Me.txtCuTelNo2.Size = New System.Drawing.Size(92, 26)
        Me.txtCuTelNo2.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 18)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Telephone No 2 :"
        '
        'txtCuTelNo1
        '
        Me.txtCuTelNo1.Enabled = False
        Me.txtCuTelNo1.Location = New System.Drawing.Point(112, 46)
        Me.txtCuTelNo1.Mask = "999 0 000 000"
        Me.txtCuTelNo1.Name = "txtCuTelNo1"
        Me.txtCuTelNo1.Size = New System.Drawing.Size(92, 26)
        Me.txtCuTelNo1.TabIndex = 10
        '
        'txtCuNo
        '
        Me.txtCuNo.Enabled = False
        Me.txtCuNo.Location = New System.Drawing.Point(314, 111)
        Me.txtCuNo.Name = "txtCuNo"
        Me.txtCuNo.Size = New System.Drawing.Size(46, 26)
        Me.txtCuNo.TabIndex = 35
        Me.txtCuNo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telephone No 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Name :"
        '
        'boxProduct
        '
        Me.boxProduct.Controls.Add(Me.cmdPView)
        Me.boxProduct.Controls.Add(Me.txtPQty)
        Me.boxProduct.Controls.Add(Me.Label10)
        Me.boxProduct.Controls.Add(Me.txtPSerialNo)
        Me.boxProduct.Controls.Add(Me.Label8)
        Me.boxProduct.Controls.Add(Me.txtPDetails)
        Me.boxProduct.Controls.Add(Me.txtPNo)
        Me.boxProduct.Controls.Add(Me.cmbPName)
        Me.boxProduct.Controls.Add(Me.cmbPCategory)
        Me.boxProduct.Controls.Add(Me.txtPModelNo)
        Me.boxProduct.Controls.Add(Me.Label14)
        Me.boxProduct.Controls.Add(Me.Label15)
        Me.boxProduct.Controls.Add(Me.Label17)
        Me.boxProduct.Controls.Add(Me.Label18)
        Me.boxProduct.Location = New System.Drawing.Point(10, 361)
        Me.boxProduct.Name = "boxProduct"
        Me.boxProduct.Size = New System.Drawing.Size(368, 198)
        Me.boxProduct.TabIndex = 31
        Me.boxProduct.TabStop = False
        Me.boxProduct.Text = "Product Info"
        '
        'cmdPView
        '
        Me.cmdPView.Location = New System.Drawing.Point(336, 17)
        Me.cmdPView.Name = "cmdPView"
        Me.cmdPView.Size = New System.Drawing.Size(27, 22)
        Me.cmdPView.TabIndex = 14
        Me.cmdPView.Text = "..."
        Me.cmdPView.UseVisualStyleBackColor = True
        '
        'txtPQty
        '
        Me.txtPQty.Enabled = False
        Me.txtPQty.Location = New System.Drawing.Point(72, 170)
        Me.txtPQty.Name = "txtPQty"
        Me.txtPQty.Size = New System.Drawing.Size(35, 26)
        Me.txtPQty.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 18)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Quantity:"
        '
        'txtPSerialNo
        '
        Me.txtPSerialNo.Location = New System.Drawing.Point(242, 73)
        Me.txtPSerialNo.Name = "txtPSerialNo"
        Me.txtPSerialNo.Size = New System.Drawing.Size(121, 26)
        Me.txtPSerialNo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Serial No:"
        '
        'txtPDetails
        '
        Me.txtPDetails.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPDetails.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPDetails.Location = New System.Drawing.Point(71, 101)
        Me.txtPDetails.Multiline = True
        Me.txtPDetails.Name = "txtPDetails"
        Me.txtPDetails.ReadOnly = True
        Me.txtPDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPDetails.Size = New System.Drawing.Size(292, 63)
        Me.txtPDetails.TabIndex = 18
        '
        'txtPNo
        '
        Me.txtPNo.Enabled = False
        Me.txtPNo.Location = New System.Drawing.Point(317, 170)
        Me.txtPNo.Name = "txtPNo"
        Me.txtPNo.Size = New System.Drawing.Size(45, 26)
        Me.txtPNo.TabIndex = 20
        Me.txtPNo.Visible = False
        '
        'cmbPName
        '
        Me.cmbPName.FormattingEnabled = True
        Me.cmbPName.Location = New System.Drawing.Point(72, 46)
        Me.cmbPName.Name = "cmbPName"
        Me.cmbPName.Size = New System.Drawing.Size(291, 26)
        Me.cmbPName.TabIndex = 15
        '
        'cmbPCategory
        '
        Me.cmbPCategory.FormattingEnabled = True
        Me.cmbPCategory.Location = New System.Drawing.Point(72, 17)
        Me.cmbPCategory.Name = "cmbPCategory"
        Me.cmbPCategory.Size = New System.Drawing.Size(258, 26)
        Me.cmbPCategory.TabIndex = 13
        '
        'txtPModelNo
        '
        Me.txtPModelNo.Enabled = False
        Me.txtPModelNo.Location = New System.Drawing.Point(72, 73)
        Me.txtPModelNo.Name = "txtPModelNo"
        Me.txtPModelNo.Size = New System.Drawing.Size(100, 26)
        Me.txtPModelNo.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Details:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 18)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Model No:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 18)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Name :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 18)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Category :"
        '
        'txtPProblem
        '
        Me.txtPProblem.BackColor = System.Drawing.SystemColors.Window
        Me.txtPProblem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPProblem.Location = New System.Drawing.Point(12, 584)
        Me.txtPProblem.Multiline = True
        Me.txtPProblem.Name = "txtPProblem"
        Me.txtPProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPProblem.Size = New System.Drawing.Size(366, 110)
        Me.txtPProblem.TabIndex = 21
        '
        'lblPProblem
        '
        Me.lblPProblem.AutoSize = True
        Me.lblPProblem.Location = New System.Drawing.Point(14, 567)
        Me.lblPProblem.Name = "lblPProblem"
        Me.lblPProblem.Size = New System.Drawing.Size(65, 18)
        Me.lblPProblem.TabIndex = 62
        Me.lblPProblem.Text = "Problem:"
        '
        'boxTechnician
        '
        Me.boxTechnician.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxTechnician.Controls.Add(Me.cmdTView)
        Me.boxTechnician.Controls.Add(Me.cmbTName)
        Me.boxTechnician.Controls.Add(Me.Label19)
        Me.boxTechnician.Cursor = System.Windows.Forms.Cursors.Default
        Me.boxTechnician.Location = New System.Drawing.Point(6, 187)
        Me.boxTechnician.Name = "boxTechnician"
        Me.boxTechnician.Size = New System.Drawing.Size(664, 50)
        Me.boxTechnician.TabIndex = 32
        Me.boxTechnician.TabStop = False
        Me.boxTechnician.Text = "Technician Info"
        '
        'cmdTView
        '
        Me.cmdTView.Location = New System.Drawing.Point(284, 19)
        Me.cmdTView.Name = "cmdTView"
        Me.cmdTView.Size = New System.Drawing.Size(25, 22)
        Me.cmdTView.TabIndex = 25
        Me.cmdTView.Text = "..."
        Me.cmdTView.UseVisualStyleBackColor = True
        '
        'cmbTName
        '
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(60, 19)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(218, 26)
        Me.cmbTName.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Name : "
        '
        'boxRepair
        '
        Me.boxRepair.Controls.Add(Me.Label35)
        Me.boxRepair.Controls.Add(Me.txtRepDate)
        Me.boxRepair.Controls.Add(Me.Label27)
        Me.boxRepair.Controls.Add(Me.txtRepPrice)
        Me.boxRepair.Controls.Add(Me.Label3)
        Me.boxRepair.Location = New System.Drawing.Point(9, 575)
        Me.boxRepair.Name = "boxRepair"
        Me.boxRepair.Size = New System.Drawing.Size(323, 81)
        Me.boxRepair.TabIndex = 35
        Me.boxRepair.TabStop = False
        Me.boxRepair.Text = "Repair Info"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(59, 21)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 22)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "Rs."
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRepDate
        '
        Me.txtRepDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtRepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRepDate.Location = New System.Drawing.Point(100, 49)
        Me.txtRepDate.Name = "txtRepDate"
        Me.txtRepDate.Size = New System.Drawing.Size(162, 26)
        Me.txtRepDate.TabIndex = 29
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 51)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 18)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Repaired Date:"
        '
        'txtRepPrice
        '
        Me.txtRepPrice.Location = New System.Drawing.Point(84, 21)
        Me.txtRepPrice.Name = "txtRepPrice"
        Me.txtRepPrice.Size = New System.Drawing.Size(73, 26)
        Me.txtRepPrice.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Charge:"
        '
        'lblRepRemarks1
        '
        Me.lblRepRemarks1.AutoSize = True
        Me.lblRepRemarks1.Location = New System.Drawing.Point(4, 31)
        Me.lblRepRemarks1.Name = "lblRepRemarks1"
        Me.lblRepRemarks1.Size = New System.Drawing.Size(153, 18)
        Me.lblRepRemarks1.TabIndex = 36
        Me.lblRepRemarks1.Text = "Remarks(by Customer):"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdClose.Location = New System.Drawing.Point(1081, 144)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(79, 33)
        Me.cmdClose.TabIndex = 38
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Image = Global.LASER_System.My.Resources.Resources.Delete
        Me.cmdDelete.Location = New System.Drawing.Point(1081, 105)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(79, 33)
        Me.cmdDelete.TabIndex = 37
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.cmdSave.Location = New System.Drawing.Point(1081, 66)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(79, 33)
        Me.cmdSave.TabIndex = 36
        Me.cmdSave.Text = "Update"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'tabRepair
        '
        Me.tabRepair.Controls.Add(Me.RepInfo)
        Me.tabRepair.Controls.Add(Me.RetInfo)
        Me.tabRepair.Location = New System.Drawing.Point(12, 29)
        Me.tabRepair.Name = "tabRepair"
        Me.tabRepair.SelectedIndex = 0
        Me.tabRepair.Size = New System.Drawing.Size(366, 114)
        Me.tabRepair.TabIndex = 58
        '
        'RepInfo
        '
        Me.RepInfo.Controls.Add(Me.cmdRepView)
        Me.RepInfo.Controls.Add(Me.cmbRepNo)
        Me.RepInfo.Controls.Add(Me.cmbRepStatus)
        Me.RepInfo.Controls.Add(Me.Label7)
        Me.RepInfo.Controls.Add(Me.Label6)
        Me.RepInfo.Location = New System.Drawing.Point(4, 27)
        Me.RepInfo.Name = "RepInfo"
        Me.RepInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.RepInfo.Size = New System.Drawing.Size(358, 83)
        Me.RepInfo.TabIndex = 0
        Me.RepInfo.Text = "Repair Info"
        Me.RepInfo.UseVisualStyleBackColor = True
        '
        'cmdRepView
        '
        Me.cmdRepView.Location = New System.Drawing.Point(198, 6)
        Me.cmdRepView.Name = "cmdRepView"
        Me.cmdRepView.Size = New System.Drawing.Size(26, 22)
        Me.cmdRepView.TabIndex = 1
        Me.cmdRepView.Text = "..."
        Me.cmdRepView.UseVisualStyleBackColor = True
        '
        'cmbRepNo
        '
        Me.cmbRepNo.FormattingEnabled = True
        Me.cmbRepNo.Location = New System.Drawing.Point(76, 6)
        Me.cmbRepNo.Name = "cmbRepNo"
        Me.cmbRepNo.Size = New System.Drawing.Size(116, 26)
        Me.cmbRepNo.TabIndex = 0
        '
        'cmbRepStatus
        '
        Me.cmbRepStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepStatus.FormattingEnabled = True
        Me.cmbRepStatus.Items.AddRange(New Object() {"Received", "Hand Over to Technician", "Repairing", "Repaired Not Delivered", "Repaired Delivered", "Returned Not Delivered", "Returned Delivered", "Canceled"})
        Me.cmbRepStatus.Location = New System.Drawing.Point(76, 34)
        Me.cmbRepStatus.Name = "cmbRepStatus"
        Me.cmbRepStatus.Size = New System.Drawing.Size(228, 26)
        Me.cmbRepStatus.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Repair No:"
        '
        'RetInfo
        '
        Me.RetInfo.Controls.Add(Me.cmbRetRepNo)
        Me.RetInfo.Controls.Add(Me.cmbRetNo)
        Me.RetInfo.Controls.Add(Me.Label34)
        Me.RetInfo.Controls.Add(Me.cmdReRepView)
        Me.RetInfo.Controls.Add(Me.cmbRetStatus)
        Me.RetInfo.Controls.Add(Me.Label29)
        Me.RetInfo.Controls.Add(Me.Label30)
        Me.RetInfo.Location = New System.Drawing.Point(4, 27)
        Me.RetInfo.Name = "RetInfo"
        Me.RetInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.RetInfo.Size = New System.Drawing.Size(358, 83)
        Me.RetInfo.TabIndex = 1
        Me.RetInfo.Text = "ReRepair Info"
        Me.RetInfo.UseVisualStyleBackColor = True
        '
        'cmbRetRepNo
        '
        Me.cmbRetRepNo.FormattingEnabled = True
        Me.cmbRetRepNo.Location = New System.Drawing.Point(279, 6)
        Me.cmbRetRepNo.Name = "cmbRetRepNo"
        Me.cmbRetRepNo.Size = New System.Drawing.Size(73, 26)
        Me.cmbRetRepNo.TabIndex = 5
        '
        'cmbRetNo
        '
        Me.cmbRetNo.FormattingEnabled = True
        Me.cmbRetNo.Location = New System.Drawing.Point(90, 6)
        Me.cmbRetNo.Name = "cmbRetNo"
        Me.cmbRetNo.Size = New System.Drawing.Size(83, 26)
        Me.cmbRetNo.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(206, 10)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 18)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = "Repair No :"
        '
        'cmdReRepView
        '
        Me.cmdReRepView.Location = New System.Drawing.Point(174, 6)
        Me.cmdReRepView.Name = "cmdReRepView"
        Me.cmdReRepView.Size = New System.Drawing.Size(26, 22)
        Me.cmdReRepView.TabIndex = 4
        Me.cmdReRepView.Text = "..."
        Me.cmdReRepView.UseVisualStyleBackColor = True
        '
        'cmbRetStatus
        '
        Me.cmbRetStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRetStatus.FormattingEnabled = True
        Me.cmbRetStatus.Items.AddRange(New Object() {"Received", "Hand Over to Technician", "Repairing", "Repaired Not Delivered", "Repaired Delivered", "Returned Not Delivered", "Returned Delivered"})
        Me.cmbRetStatus.Location = New System.Drawing.Point(79, 34)
        Me.cmbRetStatus.Name = "cmbRetStatus"
        Me.cmbRetStatus.Size = New System.Drawing.Size(228, 26)
        Me.cmbRetStatus.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 34)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 18)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Status:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 18)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "ReRepair No:"
        '
        'boxDeliver
        '
        Me.boxDeliver.BackColor = System.Drawing.SystemColors.Control
        Me.boxDeliver.Controls.Add(Me.Label33)
        Me.boxDeliver.Controls.Add(Me.txtDPaidPrice)
        Me.boxDeliver.Controls.Add(Me.Label21)
        Me.boxDeliver.Controls.Add(Me.txtDDate)
        Me.boxDeliver.Controls.Add(Me.txtDNo)
        Me.boxDeliver.Controls.Add(Me.Label31)
        Me.boxDeliver.Location = New System.Drawing.Point(338, 575)
        Me.boxDeliver.Name = "boxDeliver"
        Me.boxDeliver.Size = New System.Drawing.Size(328, 81)
        Me.boxDeliver.TabIndex = 59
        Me.boxDeliver.TabStop = False
        Me.boxDeliver.Text = "Delivered Info"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(79, 49)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 22)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "Rs."
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDPaidPrice
        '
        Me.txtDPaidPrice.Enabled = False
        Me.txtDPaidPrice.Location = New System.Drawing.Point(104, 49)
        Me.txtDPaidPrice.Name = "txtDPaidPrice"
        Me.txtDPaidPrice.Size = New System.Drawing.Size(89, 26)
        Me.txtDPaidPrice.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 18)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Paid Price:"
        '
        'txtDDate
        '
        Me.txtDDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtDDate.Enabled = False
        Me.txtDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDDate.Location = New System.Drawing.Point(104, 21)
        Me.txtDDate.Name = "txtDDate"
        Me.txtDDate.Size = New System.Drawing.Size(163, 26)
        Me.txtDDate.TabIndex = 30
        '
        'txtDNo
        '
        Me.txtDNo.Enabled = False
        Me.txtDNo.Location = New System.Drawing.Point(269, 49)
        Me.txtDNo.Name = "txtDNo"
        Me.txtDNo.Size = New System.Drawing.Size(53, 26)
        Me.txtDNo.TabIndex = 7
        Me.txtDNo.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(105, 18)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Delivered Date:"
        '
        'lblRepRemarks2
        '
        Me.lblRepRemarks2.AutoSize = True
        Me.lblRepRemarks2.Location = New System.Drawing.Point(6, 240)
        Me.lblRepRemarks2.Name = "lblRepRemarks2"
        Me.lblRepRemarks2.Size = New System.Drawing.Size(158, 18)
        Me.lblRepRemarks2.TabIndex = 65
        Me.lblRepRemarks2.Text = "Remarks(by Technician):"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.PRINTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1172, 28)
        Me.MenuStrip.TabIndex = 67
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'DoneToolStripMenuItem
        '
        Me.DoneToolStripMenuItem.Name = "DoneToolStripMenuItem"
        Me.DoneToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DoneToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.DoneToolStripMenuItem.Text = "Done"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageCenterToolStripMenuItem, Me.RepairInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'MessageCenterToolStripMenuItem
        '
        Me.MessageCenterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageToolStripMenuItem, Me.MessageToCustomerForRepairedProductsToolStripMenuItem})
        Me.MessageCenterToolStripMenuItem.Name = "MessageCenterToolStripMenuItem"
        Me.MessageCenterToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.MessageCenterToolStripMenuItem.Text = "Message Center"
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'MessageToCustomerForRepairedProductsToolStripMenuItem
        '
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem.Name = "MessageToCustomerForRepairedProductsToolStripMenuItem"
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem.Text = "Batch Message"
        '
        'RepairInfoToolStripMenuItem
        '
        Me.RepairInfoToolStripMenuItem.Name = "RepairInfoToolStripMenuItem"
        Me.RepairInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RepairInfoToolStripMenuItem.Size = New System.Drawing.Size(256, 26)
        Me.RepairInfoToolStripMenuItem.Text = "Repair Info"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintReceivedReceiptToolStripMenuItem, Me.PrintRepairStickerToolStripMenuItem, Me.PrintDeliverReceiptToolStripMenuItem})
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'PrintReceivedReceiptToolStripMenuItem
        '
        Me.PrintReceivedReceiptToolStripMenuItem.Name = "PrintReceivedReceiptToolStripMenuItem"
        Me.PrintReceivedReceiptToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.PrintReceivedReceiptToolStripMenuItem.Text = "Print Received Receipt"
        '
        'PrintRepairStickerToolStripMenuItem
        '
        Me.PrintRepairStickerToolStripMenuItem.Name = "PrintRepairStickerToolStripMenuItem"
        Me.PrintRepairStickerToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.PrintRepairStickerToolStripMenuItem.Text = "Print Repair Sticker"
        '
        'PrintDeliverReceiptToolStripMenuItem
        '
        Me.PrintDeliverReceiptToolStripMenuItem.Name = "PrintDeliverReceiptToolStripMenuItem"
        Me.PrintDeliverReceiptToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.PrintDeliverReceiptToolStripMenuItem.Text = "Print Deliver Receipt"
        '
        'cmdDone
        '
        Me.cmdDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDone.Image = Global.LASER_System.My.Resources.Resources.Done
        Me.cmdDone.Location = New System.Drawing.Point(1081, 27)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(79, 33)
        Me.cmdDone.TabIndex = 35
        Me.cmdDone.Text = "Done"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'imgRepair
        '
        Me.imgRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgRepair.BackColor = System.Drawing.Color.Black
        Me.imgRepair.Enabled = False
        Me.imgRepair.Location = New System.Drawing.Point(497, 6)
        Me.imgRepair.Name = "imgRepair"
        Me.imgRepair.Size = New System.Drawing.Size(175, 175)
        Me.imgRepair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgRepair.TabIndex = 69
        Me.imgRepair.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.Controls.Add(Me.grpAdvancePay)
        Me.Guna2Panel1.Controls.Add(Me.grpActivity)
        Me.Guna2Panel1.Controls.Add(Me.grpRepTask)
        Me.Guna2Panel1.Controls.Add(Me.cmbLocation)
        Me.Guna2Panel1.Controls.Add(Me.lblLocation)
        Me.Guna2Panel1.Controls.Add(Me.grdRepRemarks2)
        Me.Guna2Panel1.Controls.Add(Me.grdRepRemarks1)
        Me.Guna2Panel1.Controls.Add(Me.imgRepair)
        Me.Guna2Panel1.Controls.Add(Me.lblRepRemarks1)
        Me.Guna2Panel1.Controls.Add(Me.boxTechnician)
        Me.Guna2Panel1.Controls.Add(Me.boxDeliver)
        Me.Guna2Panel1.Controls.Add(Me.boxItem)
        Me.Guna2Panel1.Controls.Add(Me.lblRepRemarks2)
        Me.Guna2Panel1.Controls.Add(Me.boxRepair)
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Guna2Panel1.Location = New System.Drawing.Point(384, 27)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(691, 667)
        Me.Guna2Panel1.TabIndex = 70
        '
        'grpAdvancePay
        '
        Me.grpAdvancePay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAdvancePay.Controls.Add(Me.grdAdvance)
        Me.grpAdvancePay.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpAdvancePay.Location = New System.Drawing.Point(6, 662)
        Me.grpAdvancePay.Name = "grpAdvancePay"
        Me.grpAdvancePay.Size = New System.Drawing.Size(665, 99)
        Me.grpAdvancePay.TabIndex = 83
        Me.grpAdvancePay.TabStop = False
        Me.grpAdvancePay.Text = "Advance Pay Info"
        '
        'grdAdvance
        '
        Me.grdAdvance.AllowUserToAddRows = False
        Me.grdAdvance.AllowUserToDeleteRows = False
        Me.grdAdvance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdAdvance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdvancePayAVNo, Me.AdvancePayDate, Me.AdvancePayPrice, Me.AdvancePayRemarks})
        Me.grdAdvance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAdvance.Location = New System.Drawing.Point(3, 22)
        Me.grdAdvance.Name = "grdAdvance"
        Me.grdAdvance.ReadOnly = True
        Me.grdAdvance.RowHeadersWidth = 51
        Me.grdAdvance.Size = New System.Drawing.Size(659, 74)
        Me.grdAdvance.TabIndex = 32
        '
        'AdvancePayAVNo
        '
        Me.AdvancePayAVNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.AdvancePayAVNo.HeaderText = "Advance Pay No"
        Me.AdvancePayAVNo.MinimumWidth = 6
        Me.AdvancePayAVNo.Name = "AdvancePayAVNo"
        Me.AdvancePayAVNo.ReadOnly = True
        Me.AdvancePayAVNo.Width = 6
        '
        'AdvancePayDate
        '
        Me.AdvancePayDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AdvancePayDate.HeaderText = "Date"
        Me.AdvancePayDate.MinimumWidth = 6
        Me.AdvancePayDate.Name = "AdvancePayDate"
        Me.AdvancePayDate.ReadOnly = True
        Me.AdvancePayDate.Width = 66
        '
        'AdvancePayPrice
        '
        Me.AdvancePayPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AdvancePayPrice.HeaderText = "Price"
        Me.AdvancePayPrice.MinimumWidth = 6
        Me.AdvancePayPrice.Name = "AdvancePayPrice"
        Me.AdvancePayPrice.ReadOnly = True
        Me.AdvancePayPrice.Width = 68
        '
        'AdvancePayRemarks
        '
        Me.AdvancePayRemarks.HeaderText = "Remarks"
        Me.AdvancePayRemarks.MinimumWidth = 6
        Me.AdvancePayRemarks.Name = "AdvancePayRemarks"
        Me.AdvancePayRemarks.ReadOnly = True
        Me.AdvancePayRemarks.Width = 125
        '
        'grpActivity
        '
        Me.grpActivity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpActivity.Controls.Add(Me.grdActivity)
        Me.grpActivity.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpActivity.Location = New System.Drawing.Point(6, 919)
        Me.grpActivity.Name = "grpActivity"
        Me.grpActivity.Size = New System.Drawing.Size(664, 157)
        Me.grpActivity.TabIndex = 82
        Me.grpActivity.TabStop = False
        Me.grpActivity.Text = "Activity Info"
        '
        'grdActivity
        '
        Me.grdActivity.AllowUserToAddRows = False
        Me.grdActivity.AllowUserToDeleteRows = False
        Me.grdActivity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ANo, Me.ActivityDate, Me.ActivityActivity, Me.AUserName})
        Me.grdActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdActivity.Location = New System.Drawing.Point(3, 22)
        Me.grdActivity.Name = "grdActivity"
        Me.grdActivity.ReadOnly = True
        Me.grdActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdActivity.Size = New System.Drawing.Size(658, 132)
        Me.grdActivity.TabIndex = 34
        '
        'ANo
        '
        Me.ANo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ANo.HeaderText = "No"
        Me.ANo.MinimumWidth = 6
        Me.ANo.Name = "ANo"
        Me.ANo.ReadOnly = True
        Me.ANo.Visible = False
        Me.ANo.Width = 125
        '
        'ActivityDate
        '
        Me.ActivityDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ActivityDate.HeaderText = "Date"
        Me.ActivityDate.MinimumWidth = 6
        Me.ActivityDate.Name = "ActivityDate"
        Me.ActivityDate.ReadOnly = True
        Me.ActivityDate.Width = 66
        '
        'ActivityActivity
        '
        Me.ActivityActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivityActivity.DefaultCellStyle = DataGridViewCellStyle1
        Me.ActivityActivity.HeaderText = "Activity"
        Me.ActivityActivity.MinimumWidth = 6
        Me.ActivityActivity.Name = "ActivityActivity"
        Me.ActivityActivity.ReadOnly = True
        '
        'AUserName
        '
        Me.AUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AUserName.HeaderText = "User"
        Me.AUserName.MinimumWidth = 6
        Me.AUserName.Name = "AUserName"
        Me.AUserName.ReadOnly = True
        Me.AUserName.Width = 65
        '
        'grpRepTask
        '
        Me.grpRepTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRepTask.Controls.Add(Me.grdRepTask)
        Me.grpRepTask.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpRepTask.Location = New System.Drawing.Point(6, 767)
        Me.grpRepTask.Name = "grpRepTask"
        Me.grpRepTask.Size = New System.Drawing.Size(664, 146)
        Me.grpRepTask.TabIndex = 81
        Me.grpRepTask.TabStop = False
        Me.grpRepTask.Text = "Task Info"
        '
        'grdRepTask
        '
        Me.grdRepTask.AllowUserToAddRows = False
        Me.grdRepTask.AllowUserToDeleteRows = False
        Me.grdRepTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepTask.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepTask.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskTNo, Me.TaskDate, Me.TaskAction, Me.TaskRemarks, Me.TStatus})
        Me.grdRepTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepTask.Location = New System.Drawing.Point(3, 22)
        Me.grdRepTask.Name = "grdRepTask"
        Me.grdRepTask.ReadOnly = True
        Me.grdRepTask.RowHeadersWidth = 51
        Me.grdRepTask.Size = New System.Drawing.Size(658, 121)
        Me.grdRepTask.TabIndex = 33
        '
        'TaskTNo
        '
        Me.TaskTNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.TaskTNo.DataPropertyName = "MsgNo"
        Me.TaskTNo.HeaderText = "Task No"
        Me.TaskTNo.MinimumWidth = 6
        Me.TaskTNo.Name = "TaskTNo"
        Me.TaskTNo.ReadOnly = True
        Me.TaskTNo.Visible = False
        Me.TaskTNo.Width = 125
        '
        'TaskDate
        '
        Me.TaskDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TaskDate.DataPropertyName = "MsgDate"
        Me.TaskDate.HeaderText = "Date"
        Me.TaskDate.MinimumWidth = 6
        Me.TaskDate.Name = "TaskDate"
        Me.TaskDate.ReadOnly = True
        Me.TaskDate.Width = 66
        '
        'TaskAction
        '
        Me.TaskAction.DataPropertyName = "ACTION"
        Me.TaskAction.HeaderText = "Action"
        Me.TaskAction.MinimumWidth = 6
        Me.TaskAction.Name = "TaskAction"
        Me.TaskAction.ReadOnly = True
        Me.TaskAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TaskAction.Width = 125
        '
        'TaskRemarks
        '
        Me.TaskRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TaskRemarks.DataPropertyName = "MESSAGE"
        Me.TaskRemarks.HeaderText = "Message"
        Me.TaskRemarks.MinimumWidth = 6
        Me.TaskRemarks.Name = "TaskRemarks"
        Me.TaskRemarks.ReadOnly = True
        '
        'TStatus
        '
        Me.TStatus.DataPropertyName = "STATUS"
        Me.TStatus.HeaderText = "Status"
        Me.TStatus.MinimumWidth = 6
        Me.TStatus.Name = "TStatus"
        Me.TStatus.ReadOnly = True
        Me.TStatus.Width = 125
        '
        'cmbLocation
        '
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(64, 6)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(251, 26)
        Me.cmbLocation.TabIndex = 22
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(3, 9)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(63, 18)
        Me.lblLocation.TabIndex = 79
        Me.lblLocation.Text = "Location:"
        '
        'grdRepRemarks2
        '
        Me.grdRepRemarks2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRepRemarks2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepRemarks2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepRemarks2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepRemarks2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rem2No, Me.RepRemarks2Date, Me.RepRemarks2Remarks, Me.Rem2User})
        Me.grdRepRemarks2.Location = New System.Drawing.Point(6, 257)
        Me.grdRepRemarks2.Name = "grdRepRemarks2"
        Me.grdRepRemarks2.RowHeadersWidth = 51
        Me.grdRepRemarks2.Size = New System.Drawing.Size(664, 119)
        Me.grdRepRemarks2.TabIndex = 26
        '
        'Rem2No
        '
        Me.Rem2No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Rem2No.HeaderText = "No"
        Me.Rem2No.MinimumWidth = 6
        Me.Rem2No.Name = "Rem2No"
        Me.Rem2No.ReadOnly = True
        Me.Rem2No.Visible = False
        Me.Rem2No.Width = 125
        '
        'RepRemarks2Date
        '
        Me.RepRemarks2Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RepRemarks2Date.HeaderText = "Date"
        Me.RepRemarks2Date.MinimumWidth = 6
        Me.RepRemarks2Date.Name = "RepRemarks2Date"
        Me.RepRemarks2Date.Width = 66
        '
        'RepRemarks2Remarks
        '
        Me.RepRemarks2Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepRemarks2Remarks.HeaderText = "Remarks"
        Me.RepRemarks2Remarks.MinimumWidth = 6
        Me.RepRemarks2Remarks.Name = "RepRemarks2Remarks"
        '
        'Rem2User
        '
        Me.Rem2User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem2User.HeaderText = "User"
        Me.Rem2User.MinimumWidth = 6
        Me.Rem2User.Name = "Rem2User"
        Me.Rem2User.ReadOnly = True
        Me.Rem2User.Width = 65
        '
        'grdRepRemarks1
        '
        Me.grdRepRemarks1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRepRemarks1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepRemarks1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepRemarks1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepRemarks1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rem1No, Me.Rem1Date, Me.Rem1Remarks, Me.Rem1UNo})
        Me.grdRepRemarks1.Location = New System.Drawing.Point(8, 48)
        Me.grdRepRemarks1.Name = "grdRepRemarks1"
        Me.grdRepRemarks1.RowHeadersWidth = 51
        Me.grdRepRemarks1.Size = New System.Drawing.Size(484, 133)
        Me.grdRepRemarks1.TabIndex = 23
        '
        'Rem1No
        '
        Me.Rem1No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Rem1No.HeaderText = "No"
        Me.Rem1No.MinimumWidth = 6
        Me.Rem1No.Name = "Rem1No"
        Me.Rem1No.ReadOnly = True
        Me.Rem1No.Visible = False
        Me.Rem1No.Width = 125
        '
        'Rem1Date
        '
        Me.Rem1Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem1Date.HeaderText = "Date"
        Me.Rem1Date.MinimumWidth = 6
        Me.Rem1Date.Name = "Rem1Date"
        Me.Rem1Date.Width = 66
        '
        'Rem1Remarks
        '
        Me.Rem1Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Rem1Remarks.HeaderText = "Remarks"
        Me.Rem1Remarks.MinimumWidth = 6
        Me.Rem1Remarks.Name = "Rem1Remarks"
        '
        'Rem1UNo
        '
        Me.Rem1UNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem1UNo.HeaderText = "User"
        Me.Rem1UNo.MinimumWidth = 6
        Me.Rem1UNo.Name = "Rem1UNo"
        Me.Rem1UNo.ReadOnly = True
        Me.Rem1UNo.Width = 65
        '
        'boxItem
        '
        Me.boxItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxItem.Controls.Add(Me.grdTechnicianCost)
        Me.boxItem.Location = New System.Drawing.Point(6, 382)
        Me.boxItem.Name = "boxItem"
        Me.boxItem.Size = New System.Drawing.Size(667, 187)
        Me.boxItem.TabIndex = 60
        Me.boxItem.TabStop = False
        Me.boxItem.Text = "Item Info"
        '
        'grdTechnicianCost
        '
        Me.grdTechnicianCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTechnicianCost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCNo, Me.TCDate, Me.Sno, Me.SCategory, Me.SName, Me.Rate, Me.Qty, Me.Total, Me.TCRemarks, Me.UName})
        Me.grdTechnicianCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTechnicianCost.Location = New System.Drawing.Point(3, 22)
        Me.grdTechnicianCost.Name = "grdTechnicianCost"
        Me.grdTechnicianCost.RowHeadersWidth = 51
        Me.grdTechnicianCost.Size = New System.Drawing.Size(661, 162)
        Me.grdTechnicianCost.TabIndex = 27
        '
        'TCNo
        '
        Me.TCNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.TCNo.DataPropertyName = "TCNo"
        Me.TCNo.HeaderText = "No"
        Me.TCNo.MinimumWidth = 6
        Me.TCNo.Name = "TCNo"
        Me.TCNo.ReadOnly = True
        Me.TCNo.Width = 24
        '
        'TCDate
        '
        Me.TCDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCDate.DataPropertyName = "TCDate"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TCDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.TCDate.HeaderText = "Date"
        Me.TCDate.MinimumWidth = 6
        Me.TCDate.Name = "TCDate"
        Me.TCDate.Width = 66
        '
        'Sno
        '
        Me.Sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sno.DataPropertyName = "SNo"
        Me.Sno.HeaderText = "Item Code"
        Me.Sno.MinimumWidth = 6
        Me.Sno.Name = "Sno"
        Me.Sno.Width = 101
        '
        'SCategory
        '
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Item Category"
        Me.SCategory.MinimumWidth = 6
        Me.SCategory.Name = "SCategory"
        Me.SCategory.Width = 125
        '
        'SName
        '
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Item Name"
        Me.SName.MinimumWidth = 6
        Me.SName.Name = "SName"
        Me.SName.Width = 125
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        Me.Rate.HeaderText = "Unit Price"
        Me.Rate.MinimumWidth = 6
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 125
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MinimumWidth = 6
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 125
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 125
        '
        'TCRemarks
        '
        Me.TCRemarks.DataPropertyName = "TCRemarks"
        Me.TCRemarks.HeaderText = "Remarks"
        Me.TCRemarks.MinimumWidth = 6
        Me.TCRemarks.Name = "TCRemarks"
        Me.TCRemarks.Width = 125
        '
        'UName
        '
        Me.UName.DataPropertyName = "UserName"
        Me.UName.HeaderText = "User"
        Me.UName.MinimumWidth = 6
        Me.UName.Name = "UName"
        Me.UName.ReadOnly = True
        Me.UName.Width = 125
        '
        'frmRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 709)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.txtPProblem)
        Me.Controls.Add(Me.lblPProblem)
        Me.Controls.Add(Me.tabRepair)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.boxProduct)
        Me.Controls.Add(Me.boxCustomer)
        Me.Controls.Add(Me.boxReceive)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmRepair"
        Me.Text = " LASER System - Repair "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.boxReceive.ResumeLayout(False)
        Me.boxReceive.PerformLayout()
        Me.boxCustomer.ResumeLayout(False)
        Me.boxCustomer.PerformLayout()
        Me.boxProduct.ResumeLayout(False)
        Me.boxProduct.PerformLayout()
        Me.boxTechnician.ResumeLayout(False)
        Me.boxTechnician.PerformLayout()
        Me.boxRepair.ResumeLayout(False)
        Me.boxRepair.PerformLayout()
        Me.tabRepair.ResumeLayout(False)
        Me.RepInfo.ResumeLayout(False)
        Me.RepInfo.PerformLayout()
        Me.RetInfo.ResumeLayout(False)
        Me.RetInfo.PerformLayout()
        Me.boxDeliver.ResumeLayout(False)
        Me.boxDeliver.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.imgRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.grpAdvancePay.ResumeLayout(False)
        CType(Me.grdAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActivity.ResumeLayout(False)
        CType(Me.grdActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRepTask.ResumeLayout(False)
        CType(Me.grdRepTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRepRemarks2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRepRemarks1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxItem.ResumeLayout(False)
        CType(Me.grdTechnicianCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxReceive As System.Windows.Forms.GroupBox
    Friend WithEvents txtRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuTelNo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCuTelNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCuTelNo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCuNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxProduct As System.Windows.Forms.GroupBox
    Friend WithEvents txtPSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtPNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbPName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtPModelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPQty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPProblem As System.Windows.Forms.TextBox
    Friend WithEvents lblPProblem As System.Windows.Forms.Label
    Friend WithEvents boxTechnician As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbTName As System.Windows.Forms.ComboBox
    Friend WithEvents txtRNo As System.Windows.Forms.TextBox
    Friend WithEvents boxRepair As System.Windows.Forms.GroupBox
    Friend WithEvents txtRepDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtRepPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRepRemarks1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents tabRepair As System.Windows.Forms.TabControl
    Friend WithEvents RepInfo As System.Windows.Forms.TabPage
    Friend WithEvents cmdRepView As System.Windows.Forms.Button
    Friend WithEvents cmbRepNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRepStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RetInfo As System.Windows.Forms.TabPage
    Friend WithEvents cmdReRepView As System.Windows.Forms.Button
    Friend WithEvents cmbRetStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents boxDeliver As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDNo As System.Windows.Forms.TextBox
    Friend WithEvents lblRepRemarks2 As System.Windows.Forms.Label
    Friend WithEvents cmdTView As System.Windows.Forms.Button
    Friend WithEvents cmdCuView As System.Windows.Forms.Button
    Friend WithEvents cmdPView As System.Windows.Forms.Button
    Friend WithEvents txtDPaidPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmbRetNo As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents DoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbCuName As System.Windows.Forms.ComboBox
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageToCustomerForRepairedProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepairInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintRepairStickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintReceivedReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents imgRepair As PictureBox
    Friend WithEvents PrintDeliverReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents boxItem As GroupBox
    Friend WithEvents grdTechnicianCost As DataGridView
    Friend WithEvents grdRepRemarks1 As DataGridView
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents grdRepRemarks2 As DataGridView
    Friend WithEvents grpActivity As GroupBox
    Friend WithEvents grdActivity As DataGridView
    Friend WithEvents grpRepTask As GroupBox
    Friend WithEvents grdRepTask As DataGridView
    Friend WithEvents grpAdvancePay As GroupBox
    Friend WithEvents grdAdvance As DataGridView
    Friend WithEvents AdvancePayAVNo As DataGridViewTextBoxColumn
    Friend WithEvents AdvancePayDate As DataGridViewTextBoxColumn
    Friend WithEvents AdvancePayPrice As DataGridViewTextBoxColumn
    Friend WithEvents AdvancePayRemarks As DataGridViewTextBoxColumn
    Friend WithEvents TCNo As DataGridViewTextBoxColumn
    Friend WithEvents TCDate As DataGridViewTextBoxColumn
    Friend WithEvents Sno As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TCRemarks As DataGridViewTextBoxColumn
    Friend WithEvents UName As DataGridViewTextBoxColumn
    Friend WithEvents bgPrintReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents TaskTNo As DataGridViewTextBoxColumn
    Friend WithEvents TaskDate As DataGridViewTextBoxColumn
    Friend WithEvents TaskAction As DataGridViewTextBoxColumn
    Friend WithEvents TaskRemarks As DataGridViewTextBoxColumn
    Friend WithEvents TStatus As DataGridViewTextBoxColumn
    Friend WithEvents Rem2No As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks2Date As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks2Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Rem2User As DataGridViewTextBoxColumn
    Friend WithEvents Rem1No As DataGridViewTextBoxColumn
    Friend WithEvents Rem1Date As DataGridViewTextBoxColumn
    Friend WithEvents Rem1Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Rem1UNo As DataGridViewTextBoxColumn
    Friend WithEvents ANo As DataGridViewTextBoxColumn
    Friend WithEvents ActivityDate As DataGridViewTextBoxColumn
    Friend WithEvents ActivityActivity As DataGridViewTextBoxColumn
    Friend WithEvents AUserName As DataGridViewTextBoxColumn
    Friend WithEvents cmbRetRepNo As ComboBox
End Class
