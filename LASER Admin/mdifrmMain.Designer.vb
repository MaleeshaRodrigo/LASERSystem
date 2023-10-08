<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MdifrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdifrmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblUserType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDetailsTitle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblLoad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsProBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdStock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.cmdSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdTechnician = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSale = New System.Windows.Forms.ToolStripButton()
        Me.cmdSupply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdReceive = New System.Windows.Forms.ToolStripButton()
        Me.cmdRepair = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeliver = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.cmdSalesRepair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRepAdvanced = New System.Windows.Forms.ToolStripButton()
        Me.cmdTechnicianCost = New System.Windows.Forms.ToolStripButton()
        Me.cmdTechnicianLoan = New System.Windows.Forms.ToolStripButton()
        Me.cmdCustomerLoan = New System.Windows.Forms.ToolStripButton()
        Me.cmdSettlement = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.cmdTechnicianSalary = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgwMainMenu = New System.ComponentModel.BackgroundWorker()
        Me.BarCodePort = New System.IO.Ports.SerialPort(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flpMessage = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.GrdActivity = New System.Windows.Forms.DataGridView()
        Me.AID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodayIncomeDetails = New System.Windows.Forms.Label()
        Me.lblTodayIncomeNo = New System.Windows.Forms.Label()
        Me.lblQtyRRetDetails = New System.Windows.Forms.Label()
        Me.lblQtyRRepDetails = New System.Windows.Forms.Label()
        Me.lblQtyRRetNo = New System.Windows.Forms.Label()
        Me.lblQtyRRepNo = New System.Windows.Forms.Label()
        Me.tabChart = New System.Windows.Forms.TabControl()
        Me.pageIncomevsDate = New System.Windows.Forms.TabPage()
        Me.lblIncomevsDateCustom = New System.Windows.Forms.Label()
        Me.txtIncomevsDateCustom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbIncomevsDateView = New System.Windows.Forms.ComboBox()
        Me.chtIncomevsDate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pageReceivedRepvsDate = New System.Windows.Forms.TabPage()
        Me.lblReceivedRepvsDateCustom = New System.Windows.Forms.Label()
        Me.txtReceivedRepvsDateCustom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbReceivedRepvsDateView = New System.Windows.Forms.ComboBox()
        Me.chtReceivedRepvsDate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pageCashier = New System.Windows.Forms.TabPage()
        Me.lblULastLogin = New System.Windows.Forms.Label()
        Me.lblULoginCount = New System.Windows.Forms.Label()
        Me.lblUEmail = New System.Windows.Forms.Label()
        Me.lblUName = New System.Windows.Forms.Label()
        Me.picUImage = New System.Windows.Forms.PictureBox()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.GrdActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabChart.SuspendLayout()
        Me.pageIncomevsDate.SuspendLayout()
        CType(Me.chtIncomevsDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageReceivedRepvsDate.SuspendLayout()
        CType(Me.chtReceivedRepvsDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageCashier.SuspendLayout()
        CType(Me.picUImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.tslblUserName, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel6, Me.tslblUserType, Me.ToolStripStatusLabel3, Me.ToolStripStatusDetailsTitle, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.tslblLoad, Me.tsProBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 652)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1229, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(85, 20)
        Me.ToolStripStatusLabel2.Text = "User Name:"
        '
        'tslblUserName
        '
        Me.tslblUserName.Name = "tslblUserName"
        Me.tslblUserName.Size = New System.Drawing.Size(82, 20)
        Me.tslblUserName.Text = "User Name"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripStatusLabel6.Text = "User Type:"
        '
        'tslblUserType
        '
        Me.tslblUserType.Name = "tslblUserType"
        Me.tslblUserType.Size = New System.Drawing.Size(73, 20)
        Me.tslblUserType.Text = "User Type"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusDetailsTitle
        '
        Me.ToolStripStatusDetailsTitle.Name = "ToolStripStatusDetailsTitle"
        Me.ToolStripStatusDetailsTitle.Size = New System.Drawing.Size(601, 20)
        Me.ToolStripStatusDetailsTitle.Text = "This Product is licensed to LASER Electronics.  Copyright © 2018 - 2020 All Right" &
    " Reserved"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripStatusLabel5.Text = "Status:"
        '
        'tslblLoad
        '
        Me.tslblLoad.Name = "tslblLoad"
        Me.tslblLoad.Size = New System.Drawing.Size(94, 20)
        Me.tslblLoad.Text = "Please Wait..."
        '
        'tsProBar
        '
        Me.tsProBar.Name = "tsProBar"
        Me.tsProBar.Size = New System.Drawing.Size(100, 18)
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdStock, Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.cmdSale, Me.cmdSupply, Me.ToolStripSeparator2, Me.cmdReceive, Me.cmdRepair, Me.cmdDeliver, Me.ToolStripDropDownButton2, Me.ToolStripSeparator3, Me.cmdRepAdvanced, Me.cmdTechnicianCost, Me.cmdTechnicianLoan, Me.cmdCustomerLoan, Me.cmdSettlement, Me.ToolStripDropDownButton3})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 30)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1229, 89)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'cmdStock
        '
        Me.cmdStock.Image = CType(resources.GetObject("cmdStock.Image"), System.Drawing.Image)
        Me.cmdStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStock.Name = "cmdStock"
        Me.cmdStock.Size = New System.Drawing.Size(68, 86)
        Me.cmdStock.Text = "Stock"
        Me.cmdStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSupplier, Me.cmdCustomer, Me.cmdTechnician, Me.cmdProduct})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(14, 86)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'cmdSupplier
        '
        Me.cmdSupplier.Name = "cmdSupplier"
        Me.cmdSupplier.Size = New System.Drawing.Size(165, 26)
        Me.cmdSupplier.Text = "Supplier"
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(165, 26)
        Me.cmdCustomer.Text = "Customer"
        '
        'cmdTechnician
        '
        Me.cmdTechnician.Name = "cmdTechnician"
        Me.cmdTechnician.Size = New System.Drawing.Size(165, 26)
        Me.cmdTechnician.Text = "Technician"
        '
        'cmdProduct
        '
        Me.cmdProduct.Name = "cmdProduct"
        Me.cmdProduct.Size = New System.Drawing.Size(165, 26)
        Me.cmdProduct.Text = "Product"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 89)
        '
        'cmdSale
        '
        Me.cmdSale.Image = CType(resources.GetObject("cmdSale.Image"), System.Drawing.Image)
        Me.cmdSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSale.Name = "cmdSale"
        Me.cmdSale.Size = New System.Drawing.Size(68, 86)
        Me.cmdSale.Text = " Sale"
        Me.cmdSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdSupply
        '
        Me.cmdSupply.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cmdSupply.Image = CType(resources.GetObject("cmdSupply.Image"), System.Drawing.Image)
        Me.cmdSupply.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSupply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSupply.Name = "cmdSupply"
        Me.cmdSupply.Size = New System.Drawing.Size(68, 86)
        Me.cmdSupply.Text = "Supply"
        Me.cmdSupply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 89)
        '
        'cmdReceive
        '
        Me.cmdReceive.Image = CType(resources.GetObject("cmdReceive.Image"), System.Drawing.Image)
        Me.cmdReceive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdReceive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReceive.Name = "cmdReceive"
        Me.cmdReceive.Size = New System.Drawing.Size(125, 86)
        Me.cmdReceive.Text = "Receive Product"
        Me.cmdReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdRepair
        '
        Me.cmdRepair.Image = CType(resources.GetObject("cmdRepair.Image"), System.Drawing.Image)
        Me.cmdRepair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdRepair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRepair.Name = "cmdRepair"
        Me.cmdRepair.Size = New System.Drawing.Size(117, 86)
        Me.cmdRepair.Text = "Repair Product"
        Me.cmdRepair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdDeliver
        '
        Me.cmdDeliver.Image = CType(resources.GetObject("cmdDeliver.Image"), System.Drawing.Image)
        Me.cmdDeliver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDeliver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeliver.Name = "cmdDeliver"
        Me.cmdDeliver.Size = New System.Drawing.Size(121, 86)
        Me.cmdDeliver.Text = "Deliver Product"
        Me.cmdDeliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSalesRepair})
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(14, 86)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'cmdSalesRepair
        '
        Me.cmdSalesRepair.Name = "cmdSalesRepair"
        Me.cmdSalesRepair.Size = New System.Drawing.Size(177, 26)
        Me.cmdSalesRepair.Text = "Sales Repair"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 89)
        '
        'cmdRepAdvanced
        '
        Me.cmdRepAdvanced.Image = CType(resources.GetObject("cmdRepAdvanced.Image"), System.Drawing.Image)
        Me.cmdRepAdvanced.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdRepAdvanced.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRepAdvanced.Name = "cmdRepAdvanced"
        Me.cmdRepAdvanced.Size = New System.Drawing.Size(111, 86)
        Me.cmdRepAdvanced.Text = "Advanced Pay"
        Me.cmdRepAdvanced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdTechnicianCost
        '
        Me.cmdTechnicianCost.Image = CType(resources.GetObject("cmdTechnicianCost.Image"), System.Drawing.Image)
        Me.cmdTechnicianCost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdTechnicianCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTechnicianCost.Name = "cmdTechnicianCost"
        Me.cmdTechnicianCost.Size = New System.Drawing.Size(120, 86)
        Me.cmdTechnicianCost.Text = "Technician Cost"
        Me.cmdTechnicianCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdTechnicianLoan
        '
        Me.cmdTechnicianLoan.Image = CType(resources.GetObject("cmdTechnicianLoan.Image"), System.Drawing.Image)
        Me.cmdTechnicianLoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdTechnicianLoan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTechnicianLoan.Name = "cmdTechnicianLoan"
        Me.cmdTechnicianLoan.Size = New System.Drawing.Size(122, 86)
        Me.cmdTechnicianLoan.Text = "Technician Loan"
        Me.cmdTechnicianLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdCustomerLoan
        '
        Me.cmdCustomerLoan.Image = CType(resources.GetObject("cmdCustomerLoan.Image"), System.Drawing.Image)
        Me.cmdCustomerLoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCustomerLoan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCustomerLoan.Name = "cmdCustomerLoan"
        Me.cmdCustomerLoan.Size = New System.Drawing.Size(119, 86)
        Me.cmdCustomerLoan.Text = "Customer Loan"
        Me.cmdCustomerLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCustomerLoan.ToolTipText = "Customer Loan"
        '
        'cmdSettlement
        '
        Me.cmdSettlement.Image = CType(resources.GetObject("cmdSettlement.Image"), System.Drawing.Image)
        Me.cmdSettlement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSettlement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSettlement.Name = "cmdSettlement"
        Me.cmdSettlement.Size = New System.Drawing.Size(90, 86)
        Me.cmdSettlement.Text = "Settlement"
        Me.cmdSettlement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTechnicianSalary})
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(14, 86)
        Me.ToolStripDropDownButton3.Text = "ToolStripDropDownButton3"
        '
        'cmdTechnicianSalary
        '
        Me.cmdTechnicianSalary.Image = CType(resources.GetObject("cmdTechnicianSalary.Image"), System.Drawing.Image)
        Me.cmdTechnicianSalary.Name = "cmdTechnicianSalary"
        Me.cmdTechnicianSalary.Size = New System.Drawing.Size(211, 26)
        Me.cmdTechnicianSalary.Text = "Technician Salary"
        '
        'tmrReload
        '
        Me.tmrReload.Enabled = True
        Me.tmrReload.Interval = 1800000
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1229, 30)
        Me.MenuStrip.TabIndex = 18
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.LASER_Admin.My.Resources.Resources.close
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(67, 26)
        Me.ToolsToolStripMenuItem.Text = "TOOLS"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'bgwMainMenu
        '
        '
        'BarCodePort
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.flpMessage, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlLeft, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 119)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1229, 533)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'flpMessage
        '
        Me.flpMessage.AutoScroll = True
        Me.flpMessage.AutoSize = True
        Me.flpMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpMessage.BackColor = System.Drawing.Color.Black
        Me.flpMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpMessage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMessage.Location = New System.Drawing.Point(863, 3)
        Me.flpMessage.Name = "flpMessage"
        Me.flpMessage.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.flpMessage.Size = New System.Drawing.Size(363, 527)
        Me.flpMessage.TabIndex = 24
        Me.flpMessage.WrapContents = False
        '
        'pnlLeft
        '
        Me.pnlLeft.AutoScroll = True
        Me.pnlLeft.BackColor = System.Drawing.Color.Transparent
        Me.pnlLeft.Controls.Add(Me.GrdActivity)
        Me.pnlLeft.Controls.Add(Me.lblTodayIncomeDetails)
        Me.pnlLeft.Controls.Add(Me.lblTodayIncomeNo)
        Me.pnlLeft.Controls.Add(Me.lblQtyRRetDetails)
        Me.pnlLeft.Controls.Add(Me.lblQtyRRepDetails)
        Me.pnlLeft.Controls.Add(Me.lblQtyRRetNo)
        Me.pnlLeft.Controls.Add(Me.lblQtyRRepNo)
        Me.pnlLeft.Controls.Add(Me.tabChart)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(3, 3)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(854, 527)
        Me.pnlLeft.TabIndex = 23
        '
        'GrdActivity
        '
        Me.GrdActivity.AllowUserToAddRows = False
        Me.GrdActivity.AllowUserToDeleteRows = False
        Me.GrdActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdActivity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.GrdActivity.BackgroundColor = System.Drawing.Color.Black
        Me.GrdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AID, Me.ADate, Me.ACommand})
        Me.GrdActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrdActivity.GridColor = System.Drawing.Color.White
        Me.GrdActivity.Location = New System.Drawing.Point(424, 375)
        Me.GrdActivity.Name = "GrdActivity"
        Me.GrdActivity.ReadOnly = True
        Me.GrdActivity.RowHeadersVisible = False
        Me.GrdActivity.RowHeadersWidth = 51
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdActivity.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdActivity.Size = New System.Drawing.Size(423, 142)
        Me.GrdActivity.TabIndex = 23
        '
        'AID
        '
        Me.AID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AID.DataPropertyName = "ID"
        Me.AID.HeaderText = "ID"
        Me.AID.MinimumWidth = 6
        Me.AID.Name = "AID"
        Me.AID.ReadOnly = True
        Me.AID.Width = 50
        '
        'ADate
        '
        Me.ADate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ADate.DataPropertyName = "Date"
        Me.ADate.HeaderText = "Date"
        Me.ADate.MinimumWidth = 6
        Me.ADate.Name = "ADate"
        Me.ADate.ReadOnly = True
        Me.ADate.Width = 65
        '
        'ACommand
        '
        Me.ACommand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ACommand.DataPropertyName = "Command"
        Me.ACommand.HeaderText = "Command"
        Me.ACommand.MinimumWidth = 6
        Me.ACommand.Name = "ACommand"
        Me.ACommand.ReadOnly = True
        '
        'lblTodayIncomeDetails
        '
        Me.lblTodayIncomeDetails.BackColor = System.Drawing.Color.Black
        Me.lblTodayIncomeDetails.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblTodayIncomeDetails.ForeColor = System.Drawing.Color.White
        Me.lblTodayIncomeDetails.Location = New System.Drawing.Point(224, 475)
        Me.lblTodayIncomeDetails.Name = "lblTodayIncomeDetails"
        Me.lblTodayIncomeDetails.Size = New System.Drawing.Size(196, 44)
        Me.lblTodayIncomeDetails.TabIndex = 22
        Me.lblTodayIncomeDetails.Text = "Today Income"
        Me.lblTodayIncomeDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTodayIncomeNo
        '
        Me.lblTodayIncomeNo.BackColor = System.Drawing.Color.White
        Me.lblTodayIncomeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTodayIncomeNo.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayIncomeNo.Location = New System.Drawing.Point(224, 375)
        Me.lblTodayIncomeNo.Name = "lblTodayIncomeNo"
        Me.lblTodayIncomeNo.Size = New System.Drawing.Size(196, 100)
        Me.lblTodayIncomeNo.TabIndex = 21
        Me.lblTodayIncomeNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQtyRRetDetails
        '
        Me.lblQtyRRetDetails.BackColor = System.Drawing.Color.Black
        Me.lblQtyRRetDetails.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblQtyRRetDetails.ForeColor = System.Drawing.Color.White
        Me.lblQtyRRetDetails.Location = New System.Drawing.Point(118, 475)
        Me.lblQtyRRetDetails.Name = "lblQtyRRetDetails"
        Me.lblQtyRRetDetails.Size = New System.Drawing.Size(100, 44)
        Me.lblQtyRRetDetails.TabIndex = 20
        Me.lblQtyRRetDetails.Text = "Quantity of Received Re-Repairs"
        Me.lblQtyRRetDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQtyRRepDetails
        '
        Me.lblQtyRRepDetails.BackColor = System.Drawing.Color.Black
        Me.lblQtyRRepDetails.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblQtyRRepDetails.ForeColor = System.Drawing.Color.White
        Me.lblQtyRRepDetails.Location = New System.Drawing.Point(12, 475)
        Me.lblQtyRRepDetails.Name = "lblQtyRRepDetails"
        Me.lblQtyRRepDetails.Size = New System.Drawing.Size(100, 44)
        Me.lblQtyRRepDetails.TabIndex = 19
        Me.lblQtyRRepDetails.Text = "Quantity of Received Repairs"
        Me.lblQtyRRepDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQtyRRetNo
        '
        Me.lblQtyRRetNo.BackColor = System.Drawing.Color.White
        Me.lblQtyRRetNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtyRRetNo.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyRRetNo.Location = New System.Drawing.Point(118, 375)
        Me.lblQtyRRetNo.Name = "lblQtyRRetNo"
        Me.lblQtyRRetNo.Size = New System.Drawing.Size(100, 100)
        Me.lblQtyRRetNo.TabIndex = 18
        Me.lblQtyRRetNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQtyRRepNo
        '
        Me.lblQtyRRepNo.BackColor = System.Drawing.Color.White
        Me.lblQtyRRepNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtyRRepNo.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyRRepNo.Location = New System.Drawing.Point(12, 375)
        Me.lblQtyRRepNo.Name = "lblQtyRRepNo"
        Me.lblQtyRRepNo.Size = New System.Drawing.Size(100, 100)
        Me.lblQtyRRepNo.TabIndex = 17
        Me.lblQtyRRepNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabChart
        '
        Me.tabChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabChart.Controls.Add(Me.pageIncomevsDate)
        Me.tabChart.Controls.Add(Me.pageReceivedRepvsDate)
        Me.tabChart.Controls.Add(Me.pageCashier)
        Me.tabChart.Location = New System.Drawing.Point(10, 5)
        Me.tabChart.Name = "tabChart"
        Me.tabChart.SelectedIndex = 0
        Me.tabChart.Size = New System.Drawing.Size(841, 365)
        Me.tabChart.TabIndex = 10
        '
        'pageIncomevsDate
        '
        Me.pageIncomevsDate.Controls.Add(Me.lblIncomevsDateCustom)
        Me.pageIncomevsDate.Controls.Add(Me.txtIncomevsDateCustom)
        Me.pageIncomevsDate.Controls.Add(Me.Label1)
        Me.pageIncomevsDate.Controls.Add(Me.cmbIncomevsDateView)
        Me.pageIncomevsDate.Controls.Add(Me.chtIncomevsDate)
        Me.pageIncomevsDate.Location = New System.Drawing.Point(4, 26)
        Me.pageIncomevsDate.Name = "pageIncomevsDate"
        Me.pageIncomevsDate.Padding = New System.Windows.Forms.Padding(3)
        Me.pageIncomevsDate.Size = New System.Drawing.Size(833, 335)
        Me.pageIncomevsDate.TabIndex = 0
        Me.pageIncomevsDate.Text = "Total Income vs Date"
        Me.pageIncomevsDate.UseVisualStyleBackColor = True
        '
        'lblIncomevsDateCustom
        '
        Me.lblIncomevsDateCustom.AutoSize = True
        Me.lblIncomevsDateCustom.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblIncomevsDateCustom.Location = New System.Drawing.Point(251, 8)
        Me.lblIncomevsDateCustom.Name = "lblIncomevsDateCustom"
        Me.lblIncomevsDateCustom.Size = New System.Drawing.Size(41, 18)
        Me.lblIncomevsDateCustom.TabIndex = 13
        Me.lblIncomevsDateCustom.Text = "Days:"
        '
        'txtIncomevsDateCustom
        '
        Me.txtIncomevsDateCustom.Location = New System.Drawing.Point(317, 6)
        Me.txtIncomevsDateCustom.Name = "txtIncomevsDateCustom"
        Me.txtIncomevsDateCustom.Size = New System.Drawing.Size(43, 24)
        Me.txtIncomevsDateCustom.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "View:"
        '
        'cmbIncomevsDateView
        '
        Me.cmbIncomevsDateView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncomevsDateView.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.cmbIncomevsDateView.Items.AddRange(New Object() {"Days", "Months", "Week Days"})
        Me.cmbIncomevsDateView.Location = New System.Drawing.Point(49, 5)
        Me.cmbIncomevsDateView.Name = "cmbIncomevsDateView"
        Me.cmbIncomevsDateView.Size = New System.Drawing.Size(196, 26)
        Me.cmbIncomevsDateView.TabIndex = 10
        Me.cmbIncomevsDateView.Tag = ""
        '
        'chtIncomevsDate
        '
        Me.chtIncomevsDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chtIncomevsDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chtIncomevsDate.BorderlineColor = System.Drawing.SystemColors.ButtonFace
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.Name = "ChartArea1"
        Me.chtIncomevsDate.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtIncomevsDate.Legends.Add(Legend1)
        Me.chtIncomevsDate.Location = New System.Drawing.Point(6, 33)
        Me.chtIncomevsDate.Name = "chtIncomevsDate"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Blue
        Series1.Legend = "Legend1"
        Series1.Name = "Total Income vs Date"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "Total Income by Repairs vs Date"
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.Lime
        Series3.Legend = "Legend1"
        Series3.Name = "Total Income by Sales vs Date"
        Me.chtIncomevsDate.Series.Add(Series1)
        Me.chtIncomevsDate.Series.Add(Series2)
        Me.chtIncomevsDate.Series.Add(Series3)
        Me.chtIncomevsDate.Size = New System.Drawing.Size(814, 300)
        Me.chtIncomevsDate.TabIndex = 9
        Me.chtIncomevsDate.Text = "Date vs Income"
        '
        'pageReceivedRepvsDate
        '
        Me.pageReceivedRepvsDate.Controls.Add(Me.lblReceivedRepvsDateCustom)
        Me.pageReceivedRepvsDate.Controls.Add(Me.txtReceivedRepvsDateCustom)
        Me.pageReceivedRepvsDate.Controls.Add(Me.Label8)
        Me.pageReceivedRepvsDate.Controls.Add(Me.cmbReceivedRepvsDateView)
        Me.pageReceivedRepvsDate.Controls.Add(Me.chtReceivedRepvsDate)
        Me.pageReceivedRepvsDate.Location = New System.Drawing.Point(4, 26)
        Me.pageReceivedRepvsDate.Name = "pageReceivedRepvsDate"
        Me.pageReceivedRepvsDate.Size = New System.Drawing.Size(833, 335)
        Me.pageReceivedRepvsDate.TabIndex = 1
        Me.pageReceivedRepvsDate.Text = "Qty of Received Repairs vs Date"
        Me.pageReceivedRepvsDate.UseVisualStyleBackColor = True
        '
        'lblReceivedRepvsDateCustom
        '
        Me.lblReceivedRepvsDateCustom.AutoSize = True
        Me.lblReceivedRepvsDateCustom.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblReceivedRepvsDateCustom.Location = New System.Drawing.Point(251, 8)
        Me.lblReceivedRepvsDateCustom.Name = "lblReceivedRepvsDateCustom"
        Me.lblReceivedRepvsDateCustom.Size = New System.Drawing.Size(91, 18)
        Me.lblReceivedRepvsDateCustom.TabIndex = 23
        Me.lblReceivedRepvsDateCustom.Text = "Custom Days:"
        '
        'txtReceivedRepvsDateCustom
        '
        Me.txtReceivedRepvsDateCustom.Location = New System.Drawing.Point(336, 5)
        Me.txtReceivedRepvsDateCustom.Name = "txtReceivedRepvsDateCustom"
        Me.txtReceivedRepvsDateCustom.Size = New System.Drawing.Size(43, 24)
        Me.txtReceivedRepvsDateCustom.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "View:"
        '
        'cmbReceivedRepvsDateView
        '
        Me.cmbReceivedRepvsDateView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReceivedRepvsDateView.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.cmbReceivedRepvsDateView.Items.AddRange(New Object() {"Days", "Months", "Week Days"})
        Me.cmbReceivedRepvsDateView.Location = New System.Drawing.Point(49, 5)
        Me.cmbReceivedRepvsDateView.Name = "cmbReceivedRepvsDateView"
        Me.cmbReceivedRepvsDateView.Size = New System.Drawing.Size(196, 26)
        Me.cmbReceivedRepvsDateView.TabIndex = 20
        Me.cmbReceivedRepvsDateView.Tag = ""
        '
        'chtReceivedRepvsDate
        '
        Me.chtReceivedRepvsDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chtReceivedRepvsDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chtReceivedRepvsDate.BorderlineColor = System.Drawing.SystemColors.ButtonFace
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.Name = "ChartArea1"
        Me.chtReceivedRepvsDate.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtReceivedRepvsDate.Legends.Add(Legend2)
        Me.chtReceivedRepvsDate.Location = New System.Drawing.Point(6, 33)
        Me.chtReceivedRepvsDate.Name = "chtReceivedRepvsDate"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.Name = "Qty of Received Repairs vs Date"
        Me.chtReceivedRepvsDate.Series.Add(Series4)
        Me.chtReceivedRepvsDate.Size = New System.Drawing.Size(844, 300)
        Me.chtReceivedRepvsDate.TabIndex = 19
        Me.chtReceivedRepvsDate.Text = "Qty of Received Repairs vs Date"
        '
        'pageCashier
        '
        Me.pageCashier.Controls.Add(Me.lblULastLogin)
        Me.pageCashier.Controls.Add(Me.lblULoginCount)
        Me.pageCashier.Controls.Add(Me.lblUEmail)
        Me.pageCashier.Controls.Add(Me.lblUName)
        Me.pageCashier.Controls.Add(Me.picUImage)
        Me.pageCashier.Location = New System.Drawing.Point(4, 26)
        Me.pageCashier.Name = "pageCashier"
        Me.pageCashier.Size = New System.Drawing.Size(833, 335)
        Me.pageCashier.TabIndex = 2
        Me.pageCashier.Text = "Cashier"
        Me.pageCashier.UseVisualStyleBackColor = True
        '
        'lblULastLogin
        '
        Me.lblULastLogin.AutoSize = True
        Me.lblULastLogin.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lblULastLogin.Location = New System.Drawing.Point(209, 105)
        Me.lblULastLogin.Name = "lblULastLogin"
        Me.lblULastLogin.Size = New System.Drawing.Size(84, 21)
        Me.lblULastLogin.TabIndex = 4
        Me.lblULastLogin.Text = "Last Login:"
        '
        'lblULoginCount
        '
        Me.lblULoginCount.AutoSize = True
        Me.lblULoginCount.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lblULoginCount.Location = New System.Drawing.Point(210, 76)
        Me.lblULoginCount.Name = "lblULoginCount"
        Me.lblULoginCount.Size = New System.Drawing.Size(102, 21)
        Me.lblULoginCount.TabIndex = 3
        Me.lblULoginCount.Text = "Log In Count:"
        '
        'lblUEmail
        '
        Me.lblUEmail.AutoSize = True
        Me.lblUEmail.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblUEmail.Location = New System.Drawing.Point(209, 38)
        Me.lblUEmail.Name = "lblUEmail"
        Me.lblUEmail.Size = New System.Drawing.Size(77, 31)
        Me.lblUEmail.TabIndex = 2
        Me.lblUEmail.Text = "Email:"
        '
        'lblUName
        '
        Me.lblUName.AutoSize = True
        Me.lblUName.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblUName.Location = New System.Drawing.Point(209, 3)
        Me.lblUName.Name = "lblUName"
        Me.lblUName.Size = New System.Drawing.Size(81, 31)
        Me.lblUName.TabIndex = 1
        Me.lblUName.Text = "Name:"
        '
        'picUImage
        '
        Me.picUImage.BackColor = System.Drawing.Color.Transparent
        Me.picUImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picUImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUImage.Image = Global.LASER_Admin.My.Resources.Resources.Customer
        Me.picUImage.InitialImage = CType(resources.GetObject("picUImage.InitialImage"), System.Drawing.Image)
        Me.picUImage.Location = New System.Drawing.Point(3, 3)
        Me.picUImage.Name = "picUImage"
        Me.picUImage.Size = New System.Drawing.Size(200, 200)
        Me.picUImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUImage.TabIndex = 0
        Me.picUImage.TabStop = False
        '
        'MdifrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1229, 678)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(1247, 725)
        Me.Name = "MdifrmMain"
        Me.Text = "LASER System - Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.GrdActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabChart.ResumeLayout(False)
        Me.pageIncomevsDate.ResumeLayout(False)
        Me.pageIncomevsDate.PerformLayout()
        CType(Me.chtIncomevsDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageReceivedRepvsDate.ResumeLayout(False)
        Me.pageReceivedRepvsDate.PerformLayout()
        CType(Me.chtReceivedRepvsDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageCashier.ResumeLayout(False)
        Me.pageCashier.PerformLayout()
        CType(Me.picUImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusDetailsTitle As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSale As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSupply As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdReceive As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDeliver As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRepair As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdTechnicianCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdTechnicianLoan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSettlement As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCustomerLoan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrReload As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblUserName As ToolStripStatusLabel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslblUserType As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents tslblLoad As ToolStripStatusLabel
    Friend WithEvents tsProBar As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents cmdSupplier As ToolStripMenuItem
    Friend WithEvents cmdCustomer As ToolStripMenuItem
    Friend WithEvents cmdTechnician As ToolStripMenuItem
    Friend WithEvents cmdProduct As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents cmdSalesRepair As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents cmdTechnicianSalary As ToolStripMenuItem
    Friend WithEvents bgwMainMenu As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdRepAdvanced As ToolStripButton
    Friend WithEvents BarCodePort As IO.Ports.SerialPort
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents flpMessage As FlowLayoutPanel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblTodayIncomeDetails As Label
    Friend WithEvents lblTodayIncomeNo As Label
    Friend WithEvents lblQtyRRetDetails As Label
    Friend WithEvents lblQtyRRepDetails As Label
    Friend WithEvents lblQtyRRetNo As Label
    Friend WithEvents lblQtyRRepNo As Label
    Friend WithEvents tabChart As TabControl
    Friend WithEvents pageIncomevsDate As TabPage
    Friend WithEvents lblIncomevsDateCustom As Label
    Friend WithEvents txtIncomevsDateCustom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbIncomevsDateView As ComboBox
    Friend WithEvents chtIncomevsDate As DataVisualization.Charting.Chart
    Friend WithEvents pageReceivedRepvsDate As TabPage
    Friend WithEvents lblReceivedRepvsDateCustom As Label
    Friend WithEvents txtReceivedRepvsDateCustom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbReceivedRepvsDateView As ComboBox
    Friend WithEvents chtReceivedRepvsDate As DataVisualization.Charting.Chart
    Friend WithEvents pageCashier As TabPage
    Friend WithEvents lblULastLogin As Label
    Friend WithEvents lblULoginCount As Label
    Friend WithEvents lblUEmail As Label
    Friend WithEvents lblUName As Label
    Friend WithEvents picUImage As PictureBox
    Friend WithEvents GrdActivity As DataGridView
    Friend WithEvents AID As DataGridViewTextBoxColumn
    Friend WithEvents ADate As DataGridViewTextBoxColumn
    Friend WithEvents ACommand As DataGridViewTextBoxColumn
End Class
