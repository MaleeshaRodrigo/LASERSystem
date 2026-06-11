<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRepAdvanced = New System.Windows.Forms.ToolStripButton()
        Me.cmdTechnicianCost = New System.Windows.Forms.ToolStripButton()
        Me.cmdTechnicianLoan = New System.Windows.Forms.ToolStripButton()
        Me.cmdCustomerLoan = New System.Windows.Forms.ToolStripButton()
        Me.cmdSettlement = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarCodePort = New System.IO.Ports.SerialPort(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flpMessage = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.ControlCashierDashboard = New LASER_System.ControlCashierDashboard()
        Me.ControlRepairDashboard = New LASER_System.ControlRepairDashboard()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabChart.SuspendLayout()
        Me.pageIncomevsDate.SuspendLayout()
        CType(Me.chtIncomevsDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageReceivedRepvsDate.SuspendLayout()
        CType(Me.chtReceivedRepvsDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageCashier.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.tslblUserName, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel6, Me.tslblUserType, Me.ToolStripStatusLabel3, Me.ToolStripStatusDetailsTitle, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.tslblLoad, Me.tsProBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 715)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1364, 26)
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
        Me.ToolStripStatusDetailsTitle.Text = "This Product is licensed to LASER Electronics.  Copyright © 2018 - 2024 All Right" &
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
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdStock, Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.cmdSale, Me.cmdSupply, Me.ToolStripSeparator2, Me.cmdReceive, Me.cmdRepair, Me.cmdDeliver, Me.ToolStripSeparator3, Me.cmdRepAdvanced, Me.cmdTechnicianCost, Me.cmdTechnicianLoan, Me.cmdCustomerLoan, Me.cmdSettlement})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1364, 89)
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
        Me.cmdRepAdvanced.Size = New System.Drawing.Size(102, 86)
        Me.cmdRepAdvanced.Text = "Advance Pay"
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
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1364, 28)
        Me.MenuStrip.TabIndex = 18
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
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
        Me.ExitToolStripMenuItem.Image = Global.LASER_System.My.Resources.Resources.close
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.ToolsToolStripMenuItem.Text = "TOOLS"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BarCodePort
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.flpMessage, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 117)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1364, 598)
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
        Me.flpMessage.Location = New System.Drawing.Point(957, 3)
        Me.flpMessage.Name = "flpMessage"
        Me.flpMessage.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.flpMessage.Size = New System.Drawing.Size(404, 592)
        Me.flpMessage.TabIndex = 24
        Me.flpMessage.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.tabChart)
        Me.Panel1.Controls.Add(Me.ControlRepairDashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 592)
        Me.Panel1.TabIndex = 25
        '
        'tabChart
        '
        Me.tabChart.Controls.Add(Me.pageIncomevsDate)
        Me.tabChart.Controls.Add(Me.pageReceivedRepvsDate)
        Me.tabChart.Controls.Add(Me.pageCashier)
        Me.tabChart.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabChart.Location = New System.Drawing.Point(0, 433)
        Me.tabChart.Name = "tabChart"
        Me.tabChart.SelectedIndex = 0
        Me.tabChart.Size = New System.Drawing.Size(927, 365)
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
        Me.pageIncomevsDate.Size = New System.Drawing.Size(919, 335)
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
        ChartArea3.AxisX.Interval = 1.0R
        ChartArea3.Name = "ChartArea1"
        Me.chtIncomevsDate.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtIncomevsDate.Legends.Add(Legend3)
        Me.chtIncomevsDate.Location = New System.Drawing.Point(6, 33)
        Me.chtIncomevsDate.Name = "chtIncomevsDate"
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.Blue
        Series5.Legend = "Legend1"
        Series5.Name = "Total Income vs Date"
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.Red
        Series6.Legend = "Legend1"
        Series6.Name = "Total Income by Repairs vs Date"
        Series7.ChartArea = "ChartArea1"
        Series7.Color = System.Drawing.Color.Lime
        Series7.Legend = "Legend1"
        Series7.Name = "Total Income by Sales vs Date"
        Me.chtIncomevsDate.Series.Add(Series5)
        Me.chtIncomevsDate.Series.Add(Series6)
        Me.chtIncomevsDate.Series.Add(Series7)
        Me.chtIncomevsDate.Size = New System.Drawing.Size(900, 300)
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
        Me.pageReceivedRepvsDate.Size = New System.Drawing.Size(923, 335)
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
        ChartArea4.AxisX.Interval = 1.0R
        ChartArea4.Name = "ChartArea1"
        Me.chtReceivedRepvsDate.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chtReceivedRepvsDate.Legends.Add(Legend4)
        Me.chtReceivedRepvsDate.Location = New System.Drawing.Point(6, 33)
        Me.chtReceivedRepvsDate.Name = "chtReceivedRepvsDate"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.Name = "Qty of Received Repairs vs Date"
        Me.chtReceivedRepvsDate.Series.Add(Series8)
        Me.chtReceivedRepvsDate.Size = New System.Drawing.Size(823, 300)
        Me.chtReceivedRepvsDate.TabIndex = 19
        Me.chtReceivedRepvsDate.Text = "Qty of Received Repairs vs Date"
        '
        'pageCashier
        '
        Me.pageCashier.Controls.Add(Me.ControlCashierDashboard)
        Me.pageCashier.Location = New System.Drawing.Point(4, 26)
        Me.pageCashier.Name = "pageCashier"
        Me.pageCashier.Size = New System.Drawing.Size(923, 335)
        Me.pageCashier.TabIndex = 2
        Me.pageCashier.Text = "Cashier"
        Me.pageCashier.UseVisualStyleBackColor = True
        '
        'ControlCashierDashboard
        '
        Me.ControlCashierDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlCashierDashboard.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlCashierDashboard.Location = New System.Drawing.Point(0, 0)
        Me.ControlCashierDashboard.Name = "ControlCashierDashboard"
        Me.ControlCashierDashboard.Size = New System.Drawing.Size(906, 339)
        Me.ControlCashierDashboard.TabIndex = 0
        '
        'ControlRepairDashboard
        '
        Me.ControlRepairDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlRepairDashboard.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlRepairDashboard.Location = New System.Drawing.Point(0, 0)
        Me.ControlRepairDashboard.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.ControlRepairDashboard.MinimumSize = New System.Drawing.Size(660, 0)
        Me.ControlRepairDashboard.Name = "ControlRepairDashboard"
        Me.ControlRepairDashboard.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ControlRepairDashboard.Size = New System.Drawing.Size(927, 433)
        Me.ControlRepairDashboard.TabIndex = 11
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1364, 741)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormMain"
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
        Me.Panel1.ResumeLayout(False)
        Me.tabChart.ResumeLayout(False)
        Me.pageIncomevsDate.ResumeLayout(False)
        Me.pageIncomevsDate.PerformLayout()
        CType(Me.chtIncomevsDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageReceivedRepvsDate.ResumeLayout(False)
        Me.pageReceivedRepvsDate.PerformLayout()
        CType(Me.chtReceivedRepvsDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageCashier.ResumeLayout(False)
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
    Friend WithEvents cmdRepAdvanced As ToolStripButton
    Friend WithEvents BarCodePort As IO.Ports.SerialPort
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents flpMessage As FlowLayoutPanel
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
    Friend WithEvents ControlCashierDashboard As ControlCashierDashboard
    Friend WithEvents ControlRepairDashboard As ControlRepairDashboard
    Friend WithEvents Panel1 As Panel
End Class