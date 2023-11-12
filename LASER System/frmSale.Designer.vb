<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSale
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSaNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCuTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtCuTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cmdCuView = New System.Windows.Forms.Button()
        Me.txtCuTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmbCuName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdSale = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSaRemarks = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.pnlSaSaveFinal = New System.Windows.Forms.Panel()
        Me.grpPaymentInfo = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkCashDrawer = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNotReceipt = New System.Windows.Forms.Button()
        Me.cmdReceipt = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtDue = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtLess = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tabcontrolPayment = New System.Windows.Forms.TabControl()
        Me.tabpageCash = New System.Windows.Forms.TabPage()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtCAmount = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCBalance = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCReceived = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tabpageCard = New System.Windows.Forms.TabPage()
        Me.txtCPInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCPAmount = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tabpageCuLoan = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuLNo = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCuLAmount = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.pnlSaSaveFinal.SuspendLayout()
        Me.grpPaymentInfo.SuspendLayout()
        Me.tabcontrolPayment.SuspendLayout()
        Me.tabpageCash.SuspendLayout()
        Me.tabpageCard.SuspendLayout()
        Me.tabpageCuLoan.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSaDate)
        Me.GroupBox1.Controls.Add(Me.txtSaNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(66, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SA-"
        '
        'txtSaDate
        '
        Me.txtSaDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSaDate.Location = New System.Drawing.Point(52, 53)
        Me.txtSaDate.Name = "txtSaDate"
        Me.txtSaDate.Size = New System.Drawing.Size(216, 24)
        Me.txtSaDate.TabIndex = 1
        '
        'txtSaNo
        '
        Me.txtSaNo.Enabled = False
        Me.txtSaNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSaNo.Location = New System.Drawing.Point(98, 22)
        Me.txtSaNo.Name = "txtSaNo"
        Me.txtSaNo.Size = New System.Drawing.Size(60, 24)
        Me.txtSaNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo3)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo2)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.cmdCuView)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo1)
        Me.GroupBox2.Controls.Add(Me.cmbCuName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 150)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'txtCuTelNo3
        '
        Me.txtCuTelNo3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuTelNo3.Location = New System.Drawing.Point(119, 82)
        Me.txtCuTelNo3.Mask = "999 0 000 000"
        Me.txtCuTelNo3.Name = "txtCuTelNo3"
        Me.txtCuTelNo3.Size = New System.Drawing.Size(93, 24)
        Me.txtCuTelNo3.TabIndex = 7
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label37.Location = New System.Drawing.Point(6, 85)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(107, 17)
        Me.Label37.TabIndex = 39
        Me.Label37.Text = "Telephone No(3) :"
        '
        'txtCuTelNo2
        '
        Me.txtCuTelNo2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuTelNo2.Location = New System.Drawing.Point(119, 52)
        Me.txtCuTelNo2.Mask = "999 0 000 000"
        Me.txtCuTelNo2.Name = "txtCuTelNo2"
        Me.txtCuTelNo2.Size = New System.Drawing.Size(93, 24)
        Me.txtCuTelNo2.TabIndex = 6
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label36.Location = New System.Drawing.Point(6, 55)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(107, 17)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "Telephone No(2) :"
        '
        'cmdCuView
        '
        Me.cmdCuView.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdCuView.Location = New System.Drawing.Point(276, 114)
        Me.cmdCuView.Name = "cmdCuView"
        Me.cmdCuView.Size = New System.Drawing.Size(28, 23)
        Me.cmdCuView.TabIndex = 3
        Me.cmdCuView.Text = "..."
        Me.cmdCuView.UseVisualStyleBackColor = True
        '
        'txtCuTelNo1
        '
        Me.txtCuTelNo1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuTelNo1.Location = New System.Drawing.Point(119, 22)
        Me.txtCuTelNo1.Mask = "999 0 000 000"
        Me.txtCuTelNo1.Name = "txtCuTelNo1"
        Me.txtCuTelNo1.Size = New System.Drawing.Size(93, 24)
        Me.txtCuTelNo1.TabIndex = 5
        '
        'cmbCuName
        '
        Me.cmbCuName.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbCuName.FormattingEnabled = True
        Me.cmbCuName.Location = New System.Drawing.Point(61, 114)
        Me.cmbCuName.Name = "cmbCuName"
        Me.cmbCuName.Size = New System.Drawing.Size(209, 23)
        Me.cmbCuName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telephone No(1) :"
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
        'grdSale
        '
        Me.grdSale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.SCategory, Me.SName, Me.Type, Me.Rate, Me.Qty, Me.Total})
        Me.grdSale.Location = New System.Drawing.Point(12, 183)
        Me.grdSale.Name = "grdSale"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.grdSale.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdSale.Size = New System.Drawing.Size(1044, 509)
        Me.grdSale.TabIndex = 33
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1364, 24)
        Me.MenuStrip.TabIndex = 83
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToCartToolStripMenuItem, Me.ToolStripSeparator1, Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.GetDataToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'AddToCartToolStripMenuItem
        '
        Me.AddToCartToolStripMenuItem.Name = "AddToCartToolStripMenuItem"
        Me.AddToCartToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddToCartToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddToCartToolStripMenuItem.Text = "Add to Cart"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'GetDataToolStripMenuItem
        '
        Me.GetDataToolStripMenuItem.Name = "GetDataToolStripMenuItem"
        Me.GetDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GetDataToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GetDataToolStripMenuItem.Text = "Get Data"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerInfoToolStripMenuItem, Me.StockDetailsToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'CustomerInfoToolStripMenuItem
        '
        Me.CustomerInfoToolStripMenuItem.Name = "CustomerInfoToolStripMenuItem"
        Me.CustomerInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CustomerInfoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CustomerInfoToolStripMenuItem.Text = "Customer Details"
        '
        'StockDetailsToolStripMenuItem
        '
        Me.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem"
        Me.StockDetailsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StockDetailsToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.StockDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'txtSaRemarks
        '
        Me.txtSaRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaRemarks.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSaRemarks.Location = New System.Drawing.Point(609, 47)
        Me.txtSaRemarks.Multiline = True
        Me.txtSaRemarks.Name = "txtSaRemarks"
        Me.txtSaRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSaRemarks.Size = New System.Drawing.Size(646, 130)
        Me.txtSaRemarks.TabIndex = 84
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label26.Location = New System.Drawing.Point(609, 27)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 17)
        Me.Label26.TabIndex = 85
        Me.Label26.Text = "Remarks :"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdClose.Location = New System.Drawing.Point(1261, 144)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 33)
        Me.cmdClose.TabIndex = 39
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdDelete.Image = Global.LASER_System.My.Resources.Resources.Delete
        Me.cmdDelete.Location = New System.Drawing.Point(1261, 105)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(91, 33)
        Me.cmdDelete.TabIndex = 37
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSave.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.cmdSave.Location = New System.Drawing.Point(1261, 66)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(91, 33)
        Me.cmdSave.TabIndex = 36
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdNew.Image = Global.LASER_System.My.Resources.Resources._new
        Me.cmdNew.Location = New System.Drawing.Point(1261, 27)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(91, 33)
        Me.cmdNew.TabIndex = 35
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'pnlSaSaveFinal
        '
        Me.pnlSaSaveFinal.BackColor = System.Drawing.Color.White
        Me.pnlSaSaveFinal.Controls.Add(Me.grpPaymentInfo)
        Me.pnlSaSaveFinal.Location = New System.Drawing.Point(764, 295)
        Me.pnlSaSaveFinal.Name = "pnlSaSaveFinal"
        Me.pnlSaSaveFinal.Size = New System.Drawing.Size(404, 422)
        Me.pnlSaSaveFinal.TabIndex = 86
        Me.pnlSaSaveFinal.Visible = False
        '
        'grpPaymentInfo
        '
        Me.grpPaymentInfo.BackColor = System.Drawing.Color.White
        Me.grpPaymentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpPaymentInfo.Controls.Add(Me.Label7)
        Me.grpPaymentInfo.Controls.Add(Me.chkCashDrawer)
        Me.grpPaymentInfo.Controls.Add(Me.cmdCancel)
        Me.grpPaymentInfo.Controls.Add(Me.cmdNotReceipt)
        Me.grpPaymentInfo.Controls.Add(Me.cmdReceipt)
        Me.grpPaymentInfo.Controls.Add(Me.Label40)
        Me.grpPaymentInfo.Controls.Add(Me.Label39)
        Me.grpPaymentInfo.Controls.Add(Me.Label38)
        Me.grpPaymentInfo.Controls.Add(Me.txtDue)
        Me.grpPaymentInfo.Controls.Add(Me.Label23)
        Me.grpPaymentInfo.Controls.Add(Me.txtLess)
        Me.grpPaymentInfo.Controls.Add(Me.Label22)
        Me.grpPaymentInfo.Controls.Add(Me.txtSubTotal)
        Me.grpPaymentInfo.Controls.Add(Me.Label21)
        Me.grpPaymentInfo.Controls.Add(Me.tabcontrolPayment)
        Me.grpPaymentInfo.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.grpPaymentInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpPaymentInfo.Name = "grpPaymentInfo"
        Me.grpPaymentInfo.Size = New System.Drawing.Size(387, 404)
        Me.grpPaymentInfo.TabIndex = 92
        Me.grpPaymentInfo.TabStop = False
        Me.grpPaymentInfo.Text = "Payment Info"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(7, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(374, 108)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'chkCashDrawer
        '
        Me.chkCashDrawer.Checked = True
        Me.chkCashDrawer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCashDrawer.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.chkCashDrawer.Location = New System.Drawing.Point(227, 239)
        Me.chkCashDrawer.Name = "chkCashDrawer"
        Me.chkCashDrawer.Size = New System.Drawing.Size(150, 44)
        Me.chkCashDrawer.TabIndex = 105
        Me.chkCashDrawer.Text = "Cash Drawer එක විවෘත විය යුතුය  "
        Me.chkCashDrawer.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdCancel.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdCancel.Location = New System.Drawing.Point(354, 7)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(34, 30)
        Me.cmdCancel.TabIndex = 104
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNotReceipt
        '
        Me.cmdNotReceipt.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdNotReceipt.Location = New System.Drawing.Point(115, 235)
        Me.cmdNotReceipt.Name = "cmdNotReceipt"
        Me.cmdNotReceipt.Size = New System.Drawing.Size(106, 48)
        Me.cmdNotReceipt.TabIndex = 103
        Me.cmdNotReceipt.Text = "බිල්පතක් අවශ්‍ය නැත"
        Me.cmdNotReceipt.UseVisualStyleBackColor = True
        '
        'cmdReceipt
        '
        Me.cmdReceipt.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdReceipt.Location = New System.Drawing.Point(6, 235)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(103, 48)
        Me.cmdReceipt.TabIndex = 102
        Me.cmdReceipt.Text = "බිල්පතක් අවශ්‍යයි"
        Me.cmdReceipt.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label40.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label40.Location = New System.Drawing.Point(93, 79)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(30, 23)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "Rs."
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label39.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label39.Location = New System.Drawing.Point(93, 51)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(30, 23)
        Me.Label39.TabIndex = 100
        Me.Label39.Text = "Rs."
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label38.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label38.Location = New System.Drawing.Point(93, 23)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 23)
        Me.Label38.TabIndex = 99
        Me.Label38.Text = "Rs."
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDue
        '
        Me.txtDue.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtDue.Location = New System.Drawing.Point(124, 79)
        Me.txtDue.Name = "txtDue"
        Me.txtDue.Size = New System.Drawing.Size(79, 24)
        Me.txtDue.TabIndex = 95
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(9, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 17)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "Due:"
        '
        'txtLess
        '
        Me.txtLess.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtLess.Location = New System.Drawing.Point(124, 51)
        Me.txtLess.Name = "txtLess"
        Me.txtLess.Size = New System.Drawing.Size(79, 24)
        Me.txtLess.TabIndex = 94
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(9, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 17)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "Less:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSubTotal.Location = New System.Drawing.Point(124, 23)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(79, 24)
        Me.txtSubTotal.TabIndex = 93
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(9, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 17)
        Me.Label21.TabIndex = 96
        Me.Label21.Text = "Sub Total:"
        '
        'tabcontrolPayment
        '
        Me.tabcontrolPayment.Controls.Add(Me.tabpageCash)
        Me.tabcontrolPayment.Controls.Add(Me.tabpageCard)
        Me.tabcontrolPayment.Controls.Add(Me.tabpageCuLoan)
        Me.tabcontrolPayment.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.tabcontrolPayment.Location = New System.Drawing.Point(6, 111)
        Me.tabcontrolPayment.Name = "tabcontrolPayment"
        Me.tabcontrolPayment.SelectedIndex = 0
        Me.tabcontrolPayment.Size = New System.Drawing.Size(375, 122)
        Me.tabcontrolPayment.TabIndex = 52
        '
        'tabpageCash
        '
        Me.tabpageCash.Controls.Add(Me.Label43)
        Me.tabpageCash.Controls.Add(Me.Label42)
        Me.tabpageCash.Controls.Add(Me.Label41)
        Me.tabpageCash.Controls.Add(Me.txtCAmount)
        Me.tabpageCash.Controls.Add(Me.Label34)
        Me.tabpageCash.Controls.Add(Me.txtCBalance)
        Me.tabpageCash.Controls.Add(Me.Label25)
        Me.tabpageCash.Controls.Add(Me.txtCReceived)
        Me.tabpageCash.Controls.Add(Me.Label24)
        Me.tabpageCash.Location = New System.Drawing.Point(4, 24)
        Me.tabpageCash.Name = "tabpageCash"
        Me.tabpageCash.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageCash.Size = New System.Drawing.Size(367, 94)
        Me.tabpageCash.TabIndex = 0
        Me.tabpageCash.Text = "By Cash"
        Me.tabpageCash.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label43.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label43.Location = New System.Drawing.Point(75, 62)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(29, 24)
        Me.Label43.TabIndex = 82
        Me.Label43.Text = "Rs."
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label42.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label42.Location = New System.Drawing.Point(75, 34)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(29, 24)
        Me.Label42.TabIndex = 81
        Me.Label42.Text = "Rs."
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label41.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label41.Location = New System.Drawing.Point(75, 6)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(29, 24)
        Me.Label41.TabIndex = 80
        Me.Label41.Text = "Rs."
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCAmount
        '
        Me.txtCAmount.Location = New System.Drawing.Point(105, 6)
        Me.txtCAmount.Name = "txtCAmount"
        Me.txtCAmount.Size = New System.Drawing.Size(104, 24)
        Me.txtCAmount.TabIndex = 26
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 10)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 17)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Amount:"
        '
        'txtCBalance
        '
        Me.txtCBalance.Enabled = False
        Me.txtCBalance.Location = New System.Drawing.Point(105, 62)
        Me.txtCBalance.Name = "txtCBalance"
        Me.txtCBalance.Size = New System.Drawing.Size(104, 24)
        Me.txtCBalance.TabIndex = 28
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 66)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 17)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Balance:"
        '
        'txtCReceived
        '
        Me.txtCReceived.Location = New System.Drawing.Point(105, 34)
        Me.txtCReceived.Name = "txtCReceived"
        Me.txtCReceived.Size = New System.Drawing.Size(104, 24)
        Me.txtCReceived.TabIndex = 27
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 17)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Received:"
        '
        'tabpageCard
        '
        Me.tabpageCard.Controls.Add(Me.txtCPInvoiceNo)
        Me.tabpageCard.Controls.Add(Me.Label29)
        Me.tabpageCard.Controls.Add(Me.txtCPAmount)
        Me.tabpageCard.Controls.Add(Me.Label32)
        Me.tabpageCard.Controls.Add(Me.Label28)
        Me.tabpageCard.Location = New System.Drawing.Point(4, 24)
        Me.tabpageCard.Name = "tabpageCard"
        Me.tabpageCard.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageCard.Size = New System.Drawing.Size(367, 94)
        Me.tabpageCard.TabIndex = 1
        Me.tabpageCard.Text = "By Card Payment"
        Me.tabpageCard.UseVisualStyleBackColor = True
        '
        'txtCPInvoiceNo
        '
        Me.txtCPInvoiceNo.Location = New System.Drawing.Point(156, 6)
        Me.txtCPInvoiceNo.Name = "txtCPInvoiceNo"
        Me.txtCPInvoiceNo.Size = New System.Drawing.Size(44, 24)
        Me.txtCPInvoiceNo.TabIndex = 81
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label29.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label29.Location = New System.Drawing.Point(70, 34)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(26, 24)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "Rs."
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCPAmount
        '
        Me.txtCPAmount.Location = New System.Drawing.Point(97, 34)
        Me.txtCPAmount.Name = "txtCPAmount"
        Me.txtCPAmount.Size = New System.Drawing.Size(72, 24)
        Me.txtCPAmount.TabIndex = 30
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 37)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(57, 17)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Amount:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(144, 17)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Credit/Debit Invoice No:"
        '
        'tabpageCuLoan
        '
        Me.tabpageCuLoan.Controls.Add(Me.Label3)
        Me.tabpageCuLoan.Controls.Add(Me.txtCuLNo)
        Me.tabpageCuLoan.Controls.Add(Me.Label33)
        Me.tabpageCuLoan.Controls.Add(Me.txtCuLAmount)
        Me.tabpageCuLoan.Controls.Add(Me.Label30)
        Me.tabpageCuLoan.Location = New System.Drawing.Point(4, 24)
        Me.tabpageCuLoan.Name = "tabpageCuLoan"
        Me.tabpageCuLoan.Size = New System.Drawing.Size(367, 94)
        Me.tabpageCuLoan.TabIndex = 2
        Me.tabpageCuLoan.Text = "By Customer Loan"
        Me.tabpageCuLoan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(69, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 24)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Rs."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuLNo
        '
        Me.txtCuLNo.Enabled = False
        Me.txtCuLNo.Location = New System.Drawing.Point(128, 7)
        Me.txtCuLNo.Name = "txtCuLNo"
        Me.txtCuLNo.Size = New System.Drawing.Size(50, 24)
        Me.txtCuLNo.TabIndex = 31
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(7, 9)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(115, 17)
        Me.Label33.TabIndex = 13
        Me.Label33.Text = "Customer Loan No:"
        '
        'txtCuLAmount
        '
        Me.txtCuLAmount.Location = New System.Drawing.Point(99, 37)
        Me.txtCuLAmount.Name = "txtCuLAmount"
        Me.txtCuLAmount.Size = New System.Drawing.Size(68, 24)
        Me.txtCuLAmount.TabIndex = 32
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 37)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 17)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Amount:"
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNo.HeaderText = "Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 59
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCategory.HeaderText = "Category"
        Me.SCategory.Name = "SCategory"
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SName.HeaderText = "Name"
        Me.SName.Name = "SName"
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Type.HeaderText = "Type"
        Me.Type.Items.AddRange(New Object() {"Sale", "Return to Available Units", "Return to Damaged Units"})
        Me.Type.Name = "Type"
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Type.Width = 56
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle1
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 57
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "N0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 49
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 59
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.pnlSaSaveFinal)
        Me.Controls.Add(Me.txtSaRemarks)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.grdSale)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmSale"
        Me.Text = "LASER System - Sale Stocks to the Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.pnlSaSaveFinal.ResumeLayout(False)
        Me.grpPaymentInfo.ResumeLayout(False)
        Me.grpPaymentInfo.PerformLayout()
        Me.tabcontrolPayment.ResumeLayout(False)
        Me.tabpageCash.ResumeLayout(False)
        Me.tabpageCash.PerformLayout()
        Me.tabpageCard.ResumeLayout(False)
        Me.tabpageCard.PerformLayout()
        Me.tabpageCuLoan.ResumeLayout(False)
        Me.tabpageCuLoan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSaDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSaNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuTelNo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCuName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdSale As System.Windows.Forms.DataGridView
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdCuView As System.Windows.Forms.Button
    Friend WithEvents txtCuTelNo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtCuTelNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSaRemarks As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents pnlSaSaveFinal As Panel
    Friend WithEvents grpPaymentInfo As GroupBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdNotReceipt As Button
    Friend WithEvents cmdReceipt As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtDue As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtLess As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tabcontrolPayment As TabControl
    Friend WithEvents tabpageCash As TabPage
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents txtCAmount As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtCBalance As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCReceived As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tabpageCard As TabPage
    Friend WithEvents txtCPInvoiceNo As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtCPAmount As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tabpageCuLoan As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuLNo As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtCuLAmount As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents chkCashDrawer As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewComboBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
