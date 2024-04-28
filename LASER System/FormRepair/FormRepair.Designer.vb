<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRepair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRepair))
        Me.boxReceive = New System.Windows.Forms.GroupBox()
        Me.txtRNo = New System.Windows.Forms.TextBox()
        Me.txtRDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxCustomer = New System.Windows.Forms.GroupBox()
        Me.TextCuName = New System.Windows.Forms.TextBox()
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
        Me.cmdClose = New System.Windows.Forms.Button()
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
        Me.bgPrintReport = New System.ComponentModel.BackgroundWorker()
        Me.PanelMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.boxReceive.SuspendLayout()
        Me.boxCustomer.SuspendLayout()
        Me.boxProduct.SuspendLayout()
        Me.tabRepair.SuspendLayout()
        Me.RepInfo.SuspendLayout()
        Me.RetInfo.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
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
        Me.boxReceive.Visible = False
        '
        'txtRNo
        '
        Me.txtRNo.Enabled = False
        Me.txtRNo.Location = New System.Drawing.Point(314, 21)
        Me.txtRNo.Name = "txtRNo"
        Me.txtRNo.Size = New System.Drawing.Size(45, 22)
        Me.txtRNo.TabIndex = 5
        Me.txtRNo.Visible = False
        '
        'txtRDate
        '
        Me.txtRDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRDate.Location = New System.Drawing.Point(104, 21)
        Me.txtRDate.Name = "txtRDate"
        Me.txtRDate.Size = New System.Drawing.Size(204, 22)
        Me.txtRDate.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Received Date:"
        '
        'boxCustomer
        '
        Me.boxCustomer.Controls.Add(Me.TextCuName)
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
        Me.boxCustomer.Visible = False
        '
        'TextCuName
        '
        Me.TextCuName.Enabled = False
        Me.TextCuName.Location = New System.Drawing.Point(70, 17)
        Me.TextCuName.Name = "TextCuName"
        Me.TextCuName.Size = New System.Drawing.Size(258, 22)
        Me.TextCuName.TabIndex = 40
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
        Me.txtCuTelNo3.Size = New System.Drawing.Size(92, 22)
        Me.txtCuTelNo3.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 14)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Telephone No 3 :"
        '
        'txtCuTelNo2
        '
        Me.txtCuTelNo2.Enabled = False
        Me.txtCuTelNo2.Location = New System.Drawing.Point(112, 78)
        Me.txtCuTelNo2.Mask = "999 0 000 000"
        Me.txtCuTelNo2.Name = "txtCuTelNo2"
        Me.txtCuTelNo2.Size = New System.Drawing.Size(92, 22)
        Me.txtCuTelNo2.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 14)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Telephone No 2 :"
        '
        'txtCuTelNo1
        '
        Me.txtCuTelNo1.Enabled = False
        Me.txtCuTelNo1.Location = New System.Drawing.Point(112, 46)
        Me.txtCuTelNo1.Mask = "999 0 000 000"
        Me.txtCuTelNo1.Name = "txtCuTelNo1"
        Me.txtCuTelNo1.Size = New System.Drawing.Size(92, 22)
        Me.txtCuTelNo1.TabIndex = 10
        '
        'txtCuNo
        '
        Me.txtCuNo.Enabled = False
        Me.txtCuNo.Location = New System.Drawing.Point(314, 111)
        Me.txtCuNo.Name = "txtCuNo"
        Me.txtCuNo.Size = New System.Drawing.Size(46, 22)
        Me.txtCuNo.TabIndex = 35
        Me.txtCuNo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 14)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telephone No 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 14)
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
        Me.boxProduct.Visible = False
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
        Me.txtPQty.Size = New System.Drawing.Size(35, 22)
        Me.txtPQty.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Quantity:"
        '
        'txtPSerialNo
        '
        Me.txtPSerialNo.Location = New System.Drawing.Point(242, 73)
        Me.txtPSerialNo.Name = "txtPSerialNo"
        Me.txtPSerialNo.Size = New System.Drawing.Size(121, 22)
        Me.txtPSerialNo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
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
        Me.txtPNo.Size = New System.Drawing.Size(45, 22)
        Me.txtPNo.TabIndex = 20
        Me.txtPNo.Visible = False
        '
        'cmbPName
        '
        Me.cmbPName.FormattingEnabled = True
        Me.cmbPName.Location = New System.Drawing.Point(72, 46)
        Me.cmbPName.Name = "cmbPName"
        Me.cmbPName.Size = New System.Drawing.Size(291, 22)
        Me.cmbPName.TabIndex = 15
        '
        'cmbPCategory
        '
        Me.cmbPCategory.FormattingEnabled = True
        Me.cmbPCategory.Location = New System.Drawing.Point(72, 17)
        Me.cmbPCategory.Name = "cmbPCategory"
        Me.cmbPCategory.Size = New System.Drawing.Size(258, 22)
        Me.cmbPCategory.TabIndex = 13
        '
        'txtPModelNo
        '
        Me.txtPModelNo.Enabled = False
        Me.txtPModelNo.Location = New System.Drawing.Point(72, 73)
        Me.txtPModelNo.Name = "txtPModelNo"
        Me.txtPModelNo.Size = New System.Drawing.Size(100, 22)
        Me.txtPModelNo.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 14)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Details:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 14)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Model No:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 14)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Name :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 14)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Category :"
        '
        'txtPProblem
        '
        Me.txtPProblem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPProblem.BackColor = System.Drawing.SystemColors.Window
        Me.txtPProblem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPProblem.Location = New System.Drawing.Point(12, 584)
        Me.txtPProblem.Multiline = True
        Me.txtPProblem.Name = "txtPProblem"
        Me.txtPProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPProblem.Size = New System.Drawing.Size(366, 71)
        Me.txtPProblem.TabIndex = 21
        Me.txtPProblem.Visible = False
        '
        'lblPProblem
        '
        Me.lblPProblem.AutoSize = True
        Me.lblPProblem.Location = New System.Drawing.Point(14, 567)
        Me.lblPProblem.Name = "lblPProblem"
        Me.lblPProblem.Size = New System.Drawing.Size(55, 14)
        Me.lblPProblem.TabIndex = 62
        Me.lblPProblem.Text = "Problem:"
        Me.lblPProblem.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdClose.Location = New System.Drawing.Point(863, 110)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(79, 33)
        Me.cmdClose.TabIndex = 38
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.cmdSave.Location = New System.Drawing.Point(863, 66)
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
        Me.RepInfo.Location = New System.Drawing.Point(4, 23)
        Me.RepInfo.Name = "RepInfo"
        Me.RepInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.RepInfo.Size = New System.Drawing.Size(358, 87)
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
        Me.cmbRepNo.Size = New System.Drawing.Size(116, 22)
        Me.cmbRepNo.TabIndex = 0
        '
        'cmbRepStatus
        '
        Me.cmbRepStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepStatus.FormattingEnabled = True
        Me.cmbRepStatus.Items.AddRange(New Object() {"Received", "Hand Over to Technician", "Repairing", "Repaired Not Delivered", "Repaired Delivered", "Returned Not Delivered", "Returned Delivered", "Canceled"})
        Me.cmbRepStatus.Location = New System.Drawing.Point(76, 34)
        Me.cmbRepStatus.Name = "cmbRepStatus"
        Me.cmbRepStatus.Size = New System.Drawing.Size(228, 22)
        Me.cmbRepStatus.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 14)
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
        Me.RetInfo.Location = New System.Drawing.Point(4, 23)
        Me.RetInfo.Name = "RetInfo"
        Me.RetInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.RetInfo.Size = New System.Drawing.Size(358, 87)
        Me.RetInfo.TabIndex = 1
        Me.RetInfo.Text = "ReRepair Info"
        Me.RetInfo.UseVisualStyleBackColor = True
        '
        'cmbRetRepNo
        '
        Me.cmbRetRepNo.FormattingEnabled = True
        Me.cmbRetRepNo.Location = New System.Drawing.Point(90, 34)
        Me.cmbRetRepNo.Name = "cmbRetRepNo"
        Me.cmbRetRepNo.Size = New System.Drawing.Size(73, 22)
        Me.cmbRetRepNo.TabIndex = 5
        '
        'cmbRetNo
        '
        Me.cmbRetNo.FormattingEnabled = True
        Me.cmbRetNo.Location = New System.Drawing.Point(90, 6)
        Me.cmbRetNo.Name = "cmbRetNo"
        Me.cmbRetNo.Size = New System.Drawing.Size(83, 22)
        Me.cmbRetNo.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 37)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 14)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = "Repair No :"
        '
        'cmdReRepView
        '
        Me.cmdReRepView.Location = New System.Drawing.Point(179, 6)
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
        Me.cmbRetStatus.Location = New System.Drawing.Point(90, 62)
        Me.cmbRetStatus.Name = "cmbRetStatus"
        Me.cmbRetStatus.Size = New System.Drawing.Size(228, 22)
        Me.cmbRetStatus.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 65)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 14)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Status:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 14)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "ReRepair No:"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.PRINTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip.TabIndex = 67
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'DoneToolStripMenuItem
        '
        Me.DoneToolStripMenuItem.Name = "DoneToolStripMenuItem"
        Me.DoneToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DoneToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DoneToolStripMenuItem.Text = "Done"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageCenterToolStripMenuItem, Me.RepairInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'MessageCenterToolStripMenuItem
        '
        Me.MessageCenterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageToolStripMenuItem, Me.MessageToCustomerForRepairedProductsToolStripMenuItem})
        Me.MessageCenterToolStripMenuItem.Name = "MessageCenterToolStripMenuItem"
        Me.MessageCenterToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MessageCenterToolStripMenuItem.Text = "Message Center"
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'MessageToCustomerForRepairedProductsToolStripMenuItem
        '
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem.Name = "MessageToCustomerForRepairedProductsToolStripMenuItem"
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MessageToCustomerForRepairedProductsToolStripMenuItem.Text = "Batch Message"
        '
        'RepairInfoToolStripMenuItem
        '
        Me.RepairInfoToolStripMenuItem.Name = "RepairInfoToolStripMenuItem"
        Me.RepairInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RepairInfoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RepairInfoToolStripMenuItem.Text = "Repair Info"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintReceivedReceiptToolStripMenuItem, Me.PrintRepairStickerToolStripMenuItem, Me.PrintDeliverReceiptToolStripMenuItem})
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'PrintReceivedReceiptToolStripMenuItem
        '
        Me.PrintReceivedReceiptToolStripMenuItem.Name = "PrintReceivedReceiptToolStripMenuItem"
        Me.PrintReceivedReceiptToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PrintReceivedReceiptToolStripMenuItem.Text = "Print Received Receipt"
        '
        'PrintRepairStickerToolStripMenuItem
        '
        Me.PrintRepairStickerToolStripMenuItem.Name = "PrintRepairStickerToolStripMenuItem"
        Me.PrintRepairStickerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PrintRepairStickerToolStripMenuItem.Text = "Print Repair Sticker"
        '
        'PrintDeliverReceiptToolStripMenuItem
        '
        Me.PrintDeliverReceiptToolStripMenuItem.Name = "PrintDeliverReceiptToolStripMenuItem"
        Me.PrintDeliverReceiptToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PrintDeliverReceiptToolStripMenuItem.Text = "Print Deliver Receipt"
        '
        'cmdDone
        '
        Me.cmdDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDone.Image = Global.LASER_System.My.Resources.Resources.Done
        Me.cmdDone.Location = New System.Drawing.Point(863, 27)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(79, 33)
        Me.cmdDone.TabIndex = 35
        Me.cmdDone.Text = "Done"
        Me.cmdDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.AutoScroll = True
        Me.PanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PanelMain.Location = New System.Drawing.Point(384, 27)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(473, 628)
        Me.PanelMain.TabIndex = 68
        Me.PanelMain.WrapContents = False
        '
        'FormRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 670)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.txtPProblem)
        Me.Controls.Add(Me.lblPProblem)
        Me.Controls.Add(Me.tabRepair)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.boxProduct)
        Me.Controls.Add(Me.boxCustomer)
        Me.Controls.Add(Me.boxReceive)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormRepair"
        Me.Text = " LASER System - Repair "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.boxReceive.ResumeLayout(False)
        Me.boxReceive.PerformLayout()
        Me.boxCustomer.ResumeLayout(False)
        Me.boxCustomer.PerformLayout()
        Me.boxProduct.ResumeLayout(False)
        Me.boxProduct.PerformLayout()
        Me.tabRepair.ResumeLayout(False)
        Me.RepInfo.ResumeLayout(False)
        Me.RepInfo.PerformLayout()
        Me.RetInfo.ResumeLayout(False)
        Me.RetInfo.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
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
    Friend WithEvents txtRNo As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
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
    Friend WithEvents cmdCuView As System.Windows.Forms.Button
    Friend WithEvents cmdPView As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbRetNo As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents DoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageToCustomerForRepairedProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepairInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintRepairStickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintReceivedReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDeliverReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgPrintReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbRetRepNo As ComboBox
    Friend WithEvents PanelMain As FlowLayoutPanel
    Friend WithEvents TextCuName As TextBox
End Class
