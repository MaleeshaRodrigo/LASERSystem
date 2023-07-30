<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechnicianSalary
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechnicianSalary))
        Me.boxItem = New System.Windows.Forms.GroupBox()
        Me.chkPaidTSal = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTSDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmdTSSearch = New System.Windows.Forms.Button()
        Me.txtTSTo = New System.Windows.Forms.DateTimePicker()
        Me.txtTSFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtTSNo = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdTView = New System.Windows.Forms.Button()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdTSDone = New System.Windows.Forms.Button()
        Me.cmdTSCancel = New System.Windows.Forms.Button()
        Me.tabctrlSalary = New System.Windows.Forms.TabControl()
        Me.Repair = New System.Windows.Forms.TabPage()
        Me.chkRepair = New System.Windows.Forms.CheckBox()
        Me.txtTotalRepair = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdRepair = New System.Windows.Forms.DataGridView()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTelNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPPaidPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPRemarks1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPRemarks2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSalNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReRepair = New System.Windows.Forms.TabPage()
        Me.chkReturn = New System.Windows.Forms.CheckBox()
        Me.txtTotalReRepair = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdReRepair = New System.Windows.Forms.DataGridView()
        Me.RetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REREPPaidPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetRemarks1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetRemarks2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesRepair = New System.Windows.Forms.TabPage()
        Me.chkSalesRepair = New System.Windows.Forms.CheckBox()
        Me.txtTotalSalesRepair = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.grdSalesRepair = New System.Windows.Forms.DataGridView()
        Me.SaRepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaRepDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.TabPage()
        Me.chkCost = New System.Windows.Forms.CheckBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdCost = New System.Windows.Forms.DataGridView()
        Me.TCNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCSCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCSName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Loan = New System.Windows.Forms.TabPage()
        Me.chkLoan = New System.Windows.Forms.CheckBox()
        Me.txtTotalLoan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grdLoan = New System.Windows.Forms.DataGridView()
        Me.TLNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLSCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLSName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdTSPrint = New System.Windows.Forms.Button()
        Me.lblRs1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicianInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendTechnicianSalaryToTechnicianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDetails = New System.Windows.Forms.CheckBox()
        Me.boxItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabctrlSalary.SuspendLayout()
        Me.Repair.SuspendLayout()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReRepair.SuspendLayout()
        CType(Me.grdReRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesRepair.SuspendLayout()
        CType(Me.grdSalesRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cost.SuspendLayout()
        CType(Me.grdCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Loan.SuspendLayout()
        CType(Me.grdLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxItem
        '
        Me.boxItem.Controls.Add(Me.chkPaidTSal)
        Me.boxItem.Controls.Add(Me.Label8)
        Me.boxItem.Controls.Add(Me.txtTSDate)
        Me.boxItem.Controls.Add(Me.Label3)
        Me.boxItem.Controls.Add(Me.Label5)
        Me.boxItem.Controls.Add(Me.Label35)
        Me.boxItem.Controls.Add(Me.cmdTSSearch)
        Me.boxItem.Controls.Add(Me.txtTSTo)
        Me.boxItem.Controls.Add(Me.txtTSFrom)
        Me.boxItem.Controls.Add(Me.txtTSNo)
        Me.boxItem.Controls.Add(Me.Label58)
        Me.boxItem.Location = New System.Drawing.Point(12, 27)
        Me.boxItem.Name = "boxItem"
        Me.boxItem.Size = New System.Drawing.Size(680, 79)
        Me.boxItem.TabIndex = 63
        Me.boxItem.TabStop = False
        Me.boxItem.Text = "Technician Salary Info"
        '
        'chkPaidTSal
        '
        Me.chkPaidTSal.AutoSize = True
        Me.chkPaidTSal.Location = New System.Drawing.Point(444, 23)
        Me.chkPaidTSal.Name = "chkPaidTSal"
        Me.chkPaidTSal.Size = New System.Drawing.Size(174, 18)
        Me.chkPaidTSal.TabIndex = 125
        Me.chkPaidTSal.Text = "with Paid Technician Salary"
        Me.chkPaidTSal.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(172, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 14)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Date:"
        '
        'txtTSDate
        '
        Me.txtTSDate.Location = New System.Drawing.Point(214, 21)
        Me.txtTSDate.Name = "txtTSDate"
        Me.txtTSDate.Size = New System.Drawing.Size(224, 22)
        Me.txtTSDate.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 14)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Search Date:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(356, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 22)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "To"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(88, 49)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 22)
        Me.Label35.TabIndex = 120
        Me.Label35.Text = "From"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdTSSearch
        '
        Me.cmdTSSearch.Location = New System.Drawing.Point(610, 49)
        Me.cmdTSSearch.Name = "cmdTSSearch"
        Me.cmdTSSearch.Size = New System.Drawing.Size(63, 22)
        Me.cmdTSSearch.TabIndex = 119
        Me.cmdTSSearch.Text = "Search"
        Me.cmdTSSearch.UseVisualStyleBackColor = True
        '
        'txtTSTo
        '
        Me.txtTSTo.Location = New System.Drawing.Point(380, 49)
        Me.txtTSTo.Name = "txtTSTo"
        Me.txtTSTo.Size = New System.Drawing.Size(224, 22)
        Me.txtTSTo.TabIndex = 118
        Me.txtTSTo.Value = New Date(2020, 4, 6, 0, 0, 0, 0)
        '
        'txtTSFrom
        '
        Me.txtTSFrom.Location = New System.Drawing.Point(126, 49)
        Me.txtTSFrom.Name = "txtTSFrom"
        Me.txtTSFrom.Size = New System.Drawing.Size(224, 22)
        Me.txtTSFrom.TabIndex = 117
        Me.txtTSFrom.Value = New Date(2020, 4, 1, 0, 0, 0, 0)
        '
        'txtTSNo
        '
        Me.txtTSNo.Enabled = False
        Me.txtTSNo.Location = New System.Drawing.Point(134, 21)
        Me.txtTSNo.Name = "txtTSNo"
        Me.txtTSNo.Size = New System.Drawing.Size(33, 22)
        Me.txtTSNo.TabIndex = 90
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(6, 24)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(122, 14)
        Me.Label58.TabIndex = 89
        Me.Label58.Text = "Technician Salary No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTView)
        Me.GroupBox1.Controls.Add(Me.cmbTName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(698, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 79)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Info"
        '
        'cmdTView
        '
        Me.cmdTView.Location = New System.Drawing.Point(327, 21)
        Me.cmdTView.Name = "cmdTView"
        Me.cmdTView.Size = New System.Drawing.Size(26, 22)
        Me.cmdTView.TabIndex = 24
        Me.cmdTView.Text = "..."
        Me.cmdTView.UseVisualStyleBackColor = True
        '
        'cmbTName
        '
        Me.cmbTName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(53, 21)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(268, 22)
        Me.cmbTName.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 14)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Earned Amount ="
        '
        'txt1
        '
        Me.txt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt1.Enabled = False
        Me.txt1.Location = New System.Drawing.Point(139, 358)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(50, 22)
        Me.txt1.TabIndex = 71
        '
        'txt2
        '
        Me.txt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt2.Enabled = False
        Me.txt2.Location = New System.Drawing.Point(237, 358)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(50, 22)
        Me.txt2.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(195, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 14)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "-"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(195, 399)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 14)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "2"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(399, 378)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 14)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Technician Salary ="
        '
        'txt4
        '
        Me.txt4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt4.Enabled = False
        Me.txt4.Location = New System.Drawing.Point(540, 373)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(50, 22)
        Me.txt4.TabIndex = 82
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(596, 377)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 14)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "-"
        '
        'txt5
        '
        Me.txt5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt5.Location = New System.Drawing.Point(638, 373)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(50, 22)
        Me.txt5.TabIndex = 83
        '
        'txt6
        '
        Me.txt6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt6.Enabled = False
        Me.txt6.Location = New System.Drawing.Point(738, 374)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(50, 22)
        Me.txt6.TabIndex = 86
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(694, 378)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 14)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "="
        '
        'cmdTSDone
        '
        Me.cmdTSDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTSDone.Image = My.Resources.Resources.Save
        Me.cmdTSDone.Location = New System.Drawing.Point(1052, 357)
        Me.cmdTSDone.Name = "cmdTSDone"
        Me.cmdTSDone.Size = New System.Drawing.Size(72, 56)
        Me.cmdTSDone.TabIndex = 87
        Me.cmdTSDone.Text = "Submit"
        Me.cmdTSDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTSDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdTSDone.UseVisualStyleBackColor = True
        '
        'cmdTSCancel
        '
        Me.cmdTSCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTSCancel.Image = My.Resources.Resources.close
        Me.cmdTSCancel.Location = New System.Drawing.Point(1130, 357)
        Me.cmdTSCancel.Name = "cmdTSCancel"
        Me.cmdTSCancel.Size = New System.Drawing.Size(72, 56)
        Me.cmdTSCancel.TabIndex = 88
        Me.cmdTSCancel.Text = "Close"
        Me.cmdTSCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTSCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdTSCancel.UseVisualStyleBackColor = True
        '
        'tabctrlSalary
        '
        Me.tabctrlSalary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabctrlSalary.Controls.Add(Me.Repair)
        Me.tabctrlSalary.Controls.Add(Me.ReRepair)
        Me.tabctrlSalary.Controls.Add(Me.SalesRepair)
        Me.tabctrlSalary.Controls.Add(Me.Cost)
        Me.tabctrlSalary.Controls.Add(Me.Loan)
        Me.tabctrlSalary.Location = New System.Drawing.Point(12, 112)
        Me.tabctrlSalary.Name = "tabctrlSalary"
        Me.tabctrlSalary.SelectedIndex = 0
        Me.tabctrlSalary.Size = New System.Drawing.Size(1205, 243)
        Me.tabctrlSalary.TabIndex = 89
        '
        'Repair
        '
        Me.Repair.Controls.Add(Me.chkRepair)
        Me.Repair.Controls.Add(Me.txtTotalRepair)
        Me.Repair.Controls.Add(Me.Label4)
        Me.Repair.Controls.Add(Me.grdRepair)
        Me.Repair.Location = New System.Drawing.Point(4, 23)
        Me.Repair.Name = "Repair"
        Me.Repair.Padding = New System.Windows.Forms.Padding(3)
        Me.Repair.Size = New System.Drawing.Size(1197, 216)
        Me.Repair.TabIndex = 0
        Me.Repair.Text = "Repair"
        Me.Repair.UseVisualStyleBackColor = True
        '
        'chkRepair
        '
        Me.chkRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRepair.AutoSize = True
        Me.chkRepair.Checked = True
        Me.chkRepair.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRepair.Location = New System.Drawing.Point(372, 190)
        Me.chkRepair.Name = "chkRepair"
        Me.chkRepair.Size = New System.Drawing.Size(184, 18)
        Me.chkRepair.TabIndex = 100
        Me.chkRepair.Text = "Show Repairs in Salary Sheet"
        Me.chkRepair.UseVisualStyleBackColor = True
        '
        'txtTotalRepair
        '
        Me.txtTotalRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRepair.Enabled = False
        Me.txtTotalRepair.Location = New System.Drawing.Point(252, 188)
        Me.txtTotalRepair.Name = "txtTotalRepair"
        Me.txtTotalRepair.Size = New System.Drawing.Size(114, 22)
        Me.txtTotalRepair.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Amount of Delivered Repair Products:"
        '
        'grdRepair
        '
        Me.grdRepair.AllowUserToAddRows = False
        Me.grdRepair.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepNo, Me.DDate, Me.CuName, Me.CuTelNo1, Me.CuTelNo2, Me.CuTelNo3, Me.PCategory, Me.PName, Me.Qty, Me.REPPaidPrice, Me.Status, Me.REPRemarks1, Me.REPRemarks2, Me.TSalNo})
        Me.grdRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdRepair.Location = New System.Drawing.Point(3, 3)
        Me.grdRepair.Name = "grdRepair"
        Me.grdRepair.RowHeadersVisible = False
        Me.grdRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepair.Size = New System.Drawing.Size(1191, 179)
        Me.grdRepair.TabIndex = 3
        '
        'RepNo
        '
        Me.RepNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RepNo.DataPropertyName = "RepNo"
        Me.RepNo.HeaderText = "Repair No"
        Me.RepNo.Name = "RepNo"
        Me.RepNo.Width = 79
        '
        'DDate
        '
        Me.DDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DDate.DataPropertyName = "DDate"
        Me.DDate.HeaderText = "Deliver Date"
        Me.DDate.Name = "DDate"
        Me.DDate.Width = 92
        '
        'CuName
        '
        Me.CuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuName.DataPropertyName = "CuName"
        Me.CuName.HeaderText = "Customer Name"
        Me.CuName.Name = "CuName"
        Me.CuName.Width = 108
        '
        'CuTelNo1
        '
        Me.CuTelNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo1.DataPropertyName = "CuTelNo1"
        Me.CuTelNo1.HeaderText = "Customer Telephone No1"
        Me.CuTelNo1.Name = "CuTelNo1"
        Me.CuTelNo1.Width = 134
        '
        'CuTelNo2
        '
        Me.CuTelNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo2.DataPropertyName = "CuTelNo2"
        Me.CuTelNo2.HeaderText = "Customer Telephone No2"
        Me.CuTelNo2.Name = "CuTelNo2"
        Me.CuTelNo2.Width = 134
        '
        'CuTelNo3
        '
        Me.CuTelNo3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuTelNo3.DataPropertyName = "CuTelNo3"
        Me.CuTelNo3.HeaderText = "Customer Telephone No3"
        Me.CuTelNo3.Name = "CuTelNo3"
        Me.CuTelNo3.Width = 134
        '
        'PCategory
        '
        Me.PCategory.DataPropertyName = "PCategory"
        Me.PCategory.HeaderText = "Product Category"
        Me.PCategory.Name = "PCategory"
        '
        'PName
        '
        Me.PName.DataPropertyName = "PName"
        Me.PName.HeaderText = "Product Name"
        Me.PName.Name = "PName"
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 49
        '
        'REPPaidPrice
        '
        Me.REPPaidPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.REPPaidPrice.DataPropertyName = "PaidPrice"
        Me.REPPaidPrice.HeaderText = "Paid Charge"
        Me.REPPaidPrice.Name = "REPPaidPrice"
        Me.REPPaidPrice.Width = 88
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 66
        '
        'REPRemarks1
        '
        Me.REPRemarks1.DataPropertyName = "REPREMARKS1"
        Me.REPRemarks1.HeaderText = "Remarks from Customer"
        Me.REPRemarks1.Name = "REPRemarks1"
        '
        'REPRemarks2
        '
        Me.REPRemarks2.DataPropertyName = "REPREMARKS2"
        Me.REPRemarks2.HeaderText = "Remarks from Technician"
        Me.REPRemarks2.Name = "REPRemarks2"
        '
        'TSalNo
        '
        Me.TSalNo.DataPropertyName = "TSalNo"
        Me.TSalNo.HeaderText = "Technician Salary No"
        Me.TSalNo.Name = "TSalNo"
        '
        'ReRepair
        '
        Me.ReRepair.Controls.Add(Me.chkReturn)
        Me.ReRepair.Controls.Add(Me.txtTotalReRepair)
        Me.ReRepair.Controls.Add(Me.Label6)
        Me.ReRepair.Controls.Add(Me.grdReRepair)
        Me.ReRepair.Location = New System.Drawing.Point(4, 23)
        Me.ReRepair.Name = "ReRepair"
        Me.ReRepair.Padding = New System.Windows.Forms.Padding(3)
        Me.ReRepair.Size = New System.Drawing.Size(1197, 216)
        Me.ReRepair.TabIndex = 1
        Me.ReRepair.Text = "ReRepair"
        Me.ReRepair.UseVisualStyleBackColor = True
        '
        'chkReturn
        '
        Me.chkReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkReturn.AutoSize = True
        Me.chkReturn.Checked = True
        Me.chkReturn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReturn.Location = New System.Drawing.Point(390, 188)
        Me.chkReturn.Name = "chkReturn"
        Me.chkReturn.Size = New System.Drawing.Size(201, 18)
        Me.chkReturn.TabIndex = 100
        Me.chkReturn.Text = "Show RE-Repairs in Salary Sheet"
        Me.chkReturn.UseVisualStyleBackColor = True
        '
        'txtTotalReRepair
        '
        Me.txtTotalReRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalReRepair.Enabled = False
        Me.txtTotalReRepair.Location = New System.Drawing.Point(270, 188)
        Me.txtTotalReRepair.Name = "txtTotalReRepair"
        Me.txtTotalReRepair.Size = New System.Drawing.Size(114, 22)
        Me.txtTotalReRepair.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Amount of Delivered Re-Repair Products:"
        '
        'grdReRepair
        '
        Me.grdReRepair.AllowUserToAddRows = False
        Me.grdReRepair.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdReRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RetNo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.REREPPaidPrice, Me.DataGridViewTextBoxColumn14, Me.RetRemarks1, Me.RetRemarks2, Me.Column1})
        Me.grdReRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdReRepair.Location = New System.Drawing.Point(3, 3)
        Me.grdReRepair.Name = "grdReRepair"
        Me.grdReRepair.RowHeadersVisible = False
        Me.grdReRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdReRepair.Size = New System.Drawing.Size(1189, 179)
        Me.grdReRepair.TabIndex = 4
        '
        'RetNo
        '
        Me.RetNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RetNo.DataPropertyName = "RetNo"
        Me.RetNo.HeaderText = "Re-Repair No"
        Me.RetNo.Name = "RetNo"
        Me.RetNo.Width = 96
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Deliver Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 92
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CuName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 108
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CuTelNo1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Customer Telephone No1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 134
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CuTelNo2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Customer Telephone No2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 134
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CuTelNo3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Customer Telephone No3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 134
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PCategory"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Product Category"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 49
        '
        'REREPPaidPrice
        '
        Me.REREPPaidPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.REREPPaidPrice.DataPropertyName = "PaidPrice"
        Me.REREPPaidPrice.HeaderText = "Paid Charge"
        Me.REREPPaidPrice.Name = "REREPPaidPrice"
        Me.REREPPaidPrice.Width = 88
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 66
        '
        'RetRemarks1
        '
        Me.RetRemarks1.DataPropertyName = "RETRemarks1"
        Me.RetRemarks1.HeaderText = "Remarks for Customer "
        Me.RetRemarks1.Name = "RetRemarks1"
        '
        'RetRemarks2
        '
        Me.RetRemarks2.DataPropertyName = "RetRemarks2"
        Me.RetRemarks2.HeaderText = "Remarks for Technician"
        Me.RetRemarks2.Name = "RetRemarks2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.DataPropertyName = "TSalNo"
        Me.Column1.HeaderText = "Technician Salary No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 118
        '
        'SalesRepair
        '
        Me.SalesRepair.Controls.Add(Me.chkSalesRepair)
        Me.SalesRepair.Controls.Add(Me.txtTotalSalesRepair)
        Me.SalesRepair.Controls.Add(Me.Label19)
        Me.SalesRepair.Controls.Add(Me.grdSalesRepair)
        Me.SalesRepair.Location = New System.Drawing.Point(4, 23)
        Me.SalesRepair.Name = "SalesRepair"
        Me.SalesRepair.Padding = New System.Windows.Forms.Padding(3)
        Me.SalesRepair.Size = New System.Drawing.Size(1197, 216)
        Me.SalesRepair.TabIndex = 4
        Me.SalesRepair.Text = "Sales Repair"
        Me.SalesRepair.UseVisualStyleBackColor = True
        '
        'chkSalesRepair
        '
        Me.chkSalesRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSalesRepair.AutoSize = True
        Me.chkSalesRepair.Checked = True
        Me.chkSalesRepair.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSalesRepair.Location = New System.Drawing.Point(306, 188)
        Me.chkSalesRepair.Name = "chkSalesRepair"
        Me.chkSalesRepair.Size = New System.Drawing.Size(217, 18)
        Me.chkSalesRepair.TabIndex = 100
        Me.chkSalesRepair.Text = "Show Sales Repairs in Salary Sheet"
        Me.chkSalesRepair.UseVisualStyleBackColor = True
        '
        'txtTotalSalesRepair
        '
        Me.txtTotalSalesRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalSalesRepair.Enabled = False
        Me.txtTotalSalesRepair.Location = New System.Drawing.Point(186, 188)
        Me.txtTotalSalesRepair.Name = "txtTotalSalesRepair"
        Me.txtTotalSalesRepair.Size = New System.Drawing.Size(114, 22)
        Me.txtTotalSalesRepair.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 191)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(174, 14)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Total Amount of Sales Repairs:"
        '
        'grdSalesRepair
        '
        Me.grdSalesRepair.AllowUserToAddRows = False
        Me.grdSalesRepair.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSalesRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSalesRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaRepNo, Me.SaRepDate, Me.SCategory, Me.SName, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.Column2})
        Me.grdSalesRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSalesRepair.Location = New System.Drawing.Point(3, 3)
        Me.grdSalesRepair.Name = "grdSalesRepair"
        Me.grdSalesRepair.RowHeadersVisible = False
        Me.grdSalesRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSalesRepair.Size = New System.Drawing.Size(1191, 179)
        Me.grdSalesRepair.TabIndex = 6
        '
        'SaRepNo
        '
        Me.SaRepNo.DataPropertyName = "SaRepNo"
        Me.SaRepNo.HeaderText = "Sale Repair No"
        Me.SaRepNo.Name = "SaRepNo"
        '
        'SaRepDate
        '
        Me.SaRepDate.DataPropertyName = "SaRepDate"
        Me.SaRepDate.HeaderText = "Date"
        Me.SaRepDate.Name = "SaRepDate"
        '
        'SCategory
        '
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Stock Category"
        Me.SCategory.Name = "SCategory"
        '
        'SName
        '
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Stock Name"
        Me.SName.Name = "SName"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Rate"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 57
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 49
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 59
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "TSalNo"
        Me.Column2.HeaderText = "Technician Salary No"
        Me.Column2.Name = "Column2"
        '
        'Cost
        '
        Me.Cost.Controls.Add(Me.chkCost)
        Me.Cost.Controls.Add(Me.txtTotalCost)
        Me.Cost.Controls.Add(Me.Label7)
        Me.Cost.Controls.Add(Me.grdCost)
        Me.Cost.Location = New System.Drawing.Point(4, 23)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(1197, 216)
        Me.Cost.TabIndex = 2
        Me.Cost.Text = "Cost"
        Me.Cost.UseVisualStyleBackColor = True
        '
        'chkCost
        '
        Me.chkCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCost.AutoSize = True
        Me.chkCost.Checked = True
        Me.chkCost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCost.Location = New System.Drawing.Point(324, 191)
        Me.chkCost.Name = "chkCost"
        Me.chkCost.Size = New System.Drawing.Size(165, 18)
        Me.chkCost.TabIndex = 100
        Me.chkCost.Text = "Show Cost in Salary Sheet"
        Me.chkCost.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Location = New System.Drawing.Point(204, 191)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(114, 22)
        Me.txtTotalCost.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Amount of Technician Cost:"
        '
        'grdCost
        '
        Me.grdCost.AllowUserToAddRows = False
        Me.grdCost.AllowUserToDeleteRows = False
        Me.grdCost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCNo, Me.TCDate, Me.TCRepNo, Me.TCRetNo, Me.TCRemarks, Me.TCSCategory, Me.TCSName, Me.TCRate, Me.TCQty, Me.TCTotal, Me.Column3})
        Me.grdCost.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdCost.Location = New System.Drawing.Point(3, 3)
        Me.grdCost.Name = "grdCost"
        Me.grdCost.ReadOnly = True
        Me.grdCost.RowHeadersVisible = False
        Me.grdCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCost.Size = New System.Drawing.Size(1191, 182)
        Me.grdCost.TabIndex = 3
        '
        'TCNo
        '
        Me.TCNo.DataPropertyName = "TCNo"
        Me.TCNo.HeaderText = "Technician Cost No"
        Me.TCNo.Name = "TCNo"
        Me.TCNo.ReadOnly = True
        '
        'TCDate
        '
        Me.TCDate.DataPropertyName = "TCDate"
        Me.TCDate.HeaderText = "Date"
        Me.TCDate.Name = "TCDate"
        Me.TCDate.ReadOnly = True
        '
        'TCRepNo
        '
        Me.TCRepNo.DataPropertyName = "RepNo"
        Me.TCRepNo.HeaderText = "Repair No"
        Me.TCRepNo.Name = "TCRepNo"
        Me.TCRepNo.ReadOnly = True
        '
        'TCRetNo
        '
        Me.TCRetNo.DataPropertyName = "RetNo"
        Me.TCRetNo.HeaderText = "Re-Repair No"
        Me.TCRetNo.Name = "TCRetNo"
        Me.TCRetNo.ReadOnly = True
        '
        'TCRemarks
        '
        Me.TCRemarks.DataPropertyName = "TCRemarks"
        Me.TCRemarks.HeaderText = "Remarks"
        Me.TCRemarks.Name = "TCRemarks"
        Me.TCRemarks.ReadOnly = True
        '
        'TCSCategory
        '
        Me.TCSCategory.DataPropertyName = "SCategory"
        Me.TCSCategory.HeaderText = "Item Category"
        Me.TCSCategory.Name = "TCSCategory"
        Me.TCSCategory.ReadOnly = True
        '
        'TCSName
        '
        Me.TCSName.DataPropertyName = "SName"
        Me.TCSName.HeaderText = "Item Name"
        Me.TCSName.Name = "TCSName"
        Me.TCSName.ReadOnly = True
        '
        'TCRate
        '
        Me.TCRate.DataPropertyName = "Rate"
        Me.TCRate.HeaderText = "Rate"
        Me.TCRate.Name = "TCRate"
        Me.TCRate.ReadOnly = True
        '
        'TCQty
        '
        Me.TCQty.DataPropertyName = "Qty"
        Me.TCQty.HeaderText = "Qty"
        Me.TCQty.Name = "TCQty"
        Me.TCQty.ReadOnly = True
        '
        'TCTotal
        '
        Me.TCTotal.DataPropertyName = "Total"
        Me.TCTotal.HeaderText = "Total"
        Me.TCTotal.Name = "TCTotal"
        Me.TCTotal.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "TSalNo"
        Me.Column3.HeaderText = "Technician Salary No"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Loan
        '
        Me.Loan.Controls.Add(Me.chkLoan)
        Me.Loan.Controls.Add(Me.txtTotalLoan)
        Me.Loan.Controls.Add(Me.Label9)
        Me.Loan.Controls.Add(Me.grdLoan)
        Me.Loan.Location = New System.Drawing.Point(4, 23)
        Me.Loan.Name = "Loan"
        Me.Loan.Size = New System.Drawing.Size(1197, 216)
        Me.Loan.TabIndex = 3
        Me.Loan.Text = "Loan"
        Me.Loan.UseVisualStyleBackColor = True
        '
        'chkLoan
        '
        Me.chkLoan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLoan.AutoSize = True
        Me.chkLoan.Checked = True
        Me.chkLoan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoan.Location = New System.Drawing.Point(324, 191)
        Me.chkLoan.Name = "chkLoan"
        Me.chkLoan.Size = New System.Drawing.Size(168, 18)
        Me.chkLoan.TabIndex = 100
        Me.chkLoan.Text = "Show Loan in Salary Sheet"
        Me.chkLoan.UseVisualStyleBackColor = True
        '
        'txtTotalLoan
        '
        Me.txtTotalLoan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalLoan.Enabled = False
        Me.txtTotalLoan.Location = New System.Drawing.Point(204, 191)
        Me.txtTotalLoan.Name = "txtTotalLoan"
        Me.txtTotalLoan.Size = New System.Drawing.Size(114, 22)
        Me.txtTotalLoan.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Total Amount of Technician Loan:"
        '
        'grdLoan
        '
        Me.grdLoan.AllowUserToAddRows = False
        Me.grdLoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TLNo, Me.TLDate, Me.TLSCategory, Me.TLSName, Me.TLReason, Me.TLRate, Me.TLQty, Me.TLTotal})
        Me.grdLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdLoan.Location = New System.Drawing.Point(3, 3)
        Me.grdLoan.Name = "grdLoan"
        Me.grdLoan.RowHeadersVisible = False
        Me.grdLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLoan.Size = New System.Drawing.Size(1191, 182)
        Me.grdLoan.TabIndex = 3
        '
        'TLNo
        '
        Me.TLNo.DataPropertyName = "TLNo"
        Me.TLNo.HeaderText = "Technician Loan No"
        Me.TLNo.Name = "TLNo"
        '
        'TLDate
        '
        Me.TLDate.DataPropertyName = "TLDate"
        Me.TLDate.HeaderText = "Date"
        Me.TLDate.Name = "TLDate"
        '
        'TLSCategory
        '
        Me.TLSCategory.DataPropertyName = "SCategory"
        Me.TLSCategory.HeaderText = "Stock Category"
        Me.TLSCategory.Name = "TLSCategory"
        '
        'TLSName
        '
        Me.TLSName.DataPropertyName = "SName"
        Me.TLSName.HeaderText = "Stock Name"
        Me.TLSName.Name = "TLSName"
        '
        'TLReason
        '
        Me.TLReason.DataPropertyName = "TLReason"
        Me.TLReason.HeaderText = "Reason"
        Me.TLReason.Name = "TLReason"
        '
        'TLRate
        '
        Me.TLRate.DataPropertyName = "Rate"
        Me.TLRate.HeaderText = "Rate"
        Me.TLRate.Name = "TLRate"
        '
        'TLQty
        '
        Me.TLQty.DataPropertyName = "Qty"
        Me.TLQty.HeaderText = "Qty"
        Me.TLQty.Name = "TLQty"
        '
        'TLTotal
        '
        Me.TLTotal.DataPropertyName = "Total"
        Me.TLTotal.HeaderText = "Total"
        Me.TLTotal.Name = "TLTotal"
        '
        'cmdTSPrint
        '
        Me.cmdTSPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTSPrint.Location = New System.Drawing.Point(937, 357)
        Me.cmdTSPrint.Name = "cmdTSPrint"
        Me.cmdTSPrint.Size = New System.Drawing.Size(109, 55)
        Me.cmdTSPrint.TabIndex = 90
        Me.cmdTSPrint.Text = "Print Technician Salary Report"
        Me.cmdTSPrint.UseVisualStyleBackColor = True
        '
        'lblRs1
        '
        Me.lblRs1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRs1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRs1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblRs1.Location = New System.Drawing.Point(114, 358)
        Me.lblRs1.Name = "lblRs1"
        Me.lblRs1.Size = New System.Drawing.Size(24, 22)
        Me.lblRs1.TabIndex = 91
        Me.lblRs1.Text = "Rs."
        Me.lblRs1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(212, 358)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 22)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Rs."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(515, 373)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 22)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Rs."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(613, 373)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 22)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Rs."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(713, 374)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 22)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "Rs."
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.MalToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1214, 24)
        Me.MenuStrip.TabIndex = 97
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.PrintToolStripMenuItem, Me.SubmitToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'SubmitToolStripMenuItem
        '
        Me.SubmitToolStripMenuItem.Name = "SubmitToolStripMenuItem"
        Me.SubmitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SubmitToolStripMenuItem.Text = "Submit"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicianInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'TechnicianInfoToolStripMenuItem
        '
        Me.TechnicianInfoToolStripMenuItem.Name = "TechnicianInfoToolStripMenuItem"
        Me.TechnicianInfoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TechnicianInfoToolStripMenuItem.Text = "Technician Info"
        '
        'MalToolStripMenuItem
        '
        Me.MalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendTechnicianSalaryToTechnicianToolStripMenuItem})
        Me.MalToolStripMenuItem.Name = "MalToolStripMenuItem"
        Me.MalToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.MalToolStripMenuItem.Text = "MESSAGE"
        '
        'SendTechnicianSalaryToTechnicianToolStripMenuItem
        '
        Me.SendTechnicianSalaryToTechnicianToolStripMenuItem.Name = "SendTechnicianSalaryToTechnicianToolStripMenuItem"
        Me.SendTechnicianSalaryToTechnicianToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.SendTechnicianSalaryToTechnicianToolStripMenuItem.Text = "Send Technician Salary to Technician"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(299, 378)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 14)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "="
        '
        'txt3
        '
        Me.txt3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt3.Enabled = False
        Me.txt3.Location = New System.Drawing.Point(343, 374)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(50, 22)
        Me.txt3.TabIndex = 80
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(318, 374)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 22)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Rs."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 14)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "-------------------------------------------"
        '
        'chkDetails
        '
        Me.chkDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDetails.AutoSize = True
        Me.chkDetails.Checked = True
        Me.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDetails.Location = New System.Drawing.Point(793, 378)
        Me.chkDetails.Name = "chkDetails"
        Me.chkDetails.Size = New System.Drawing.Size(138, 18)
        Me.chkDetails.TabIndex = 99
        Me.chkDetails.Text = "Salary Detail Section"
        Me.chkDetails.UseVisualStyleBackColor = True
        '
        'frmTechnicianSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 453)
        Me.Controls.Add(Me.chkDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblRs1)
        Me.Controls.Add(Me.cmdTSPrint)
        Me.Controls.Add(Me.tabctrlSalary)
        Me.Controls.Add(Me.cmdTSCancel)
        Me.Controls.Add(Me.cmdTSDone)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.boxItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmTechnicianSalary"
        Me.Text = "LASER System - Technician Salary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.boxItem.ResumeLayout(False)
        Me.boxItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabctrlSalary.ResumeLayout(False)
        Me.Repair.ResumeLayout(False)
        Me.Repair.PerformLayout()
        CType(Me.grdRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReRepair.ResumeLayout(False)
        Me.ReRepair.PerformLayout()
        CType(Me.grdReRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesRepair.ResumeLayout(False)
        Me.SalesRepair.PerformLayout()
        CType(Me.grdSalesRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cost.ResumeLayout(False)
        Me.Cost.PerformLayout()
        CType(Me.grdCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Loan.ResumeLayout(False)
        Me.Loan.PerformLayout()
        CType(Me.grdLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxItem As System.Windows.Forms.GroupBox
    Friend WithEvents txtTSNo As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTView As System.Windows.Forms.Button
    Friend WithEvents cmbTName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmdTSSearch As System.Windows.Forms.Button
    Friend WithEvents txtTSTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTSFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt6 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdTSDone As System.Windows.Forms.Button
    Friend WithEvents cmdTSCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTSDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabctrlSalary As System.Windows.Forms.TabControl
    Friend WithEvents Repair As System.Windows.Forms.TabPage
    Friend WithEvents txtTotalRepair As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grdRepair As System.Windows.Forms.DataGridView
    Friend WithEvents ReRepair As System.Windows.Forms.TabPage
    Friend WithEvents Cost As System.Windows.Forms.TabPage
    Friend WithEvents Loan As System.Windows.Forms.TabPage
    Friend WithEvents txtTotalReRepair As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grdReRepair As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grdCost As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalLoan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grdLoan As System.Windows.Forms.DataGridView
    Friend WithEvents cmdTSPrint As System.Windows.Forms.Button
    Friend WithEvents SalesRepair As System.Windows.Forms.TabPage
    Friend WithEvents txtTotalSalesRepair As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents grdSalesRepair As System.Windows.Forms.DataGridView
    Friend WithEvents lblRs1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents chkPaidTSal As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TechnicianInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendTechnicianSalaryToTechnicianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaRepNo As DataGridViewTextBoxColumn
    Friend WithEvents SaRepDate As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TLNo As DataGridViewTextBoxColumn
    Friend WithEvents TLDate As DataGridViewTextBoxColumn
    Friend WithEvents TLSCategory As DataGridViewTextBoxColumn
    Friend WithEvents TLSName As DataGridViewTextBoxColumn
    Friend WithEvents TLReason As DataGridViewTextBoxColumn
    Friend WithEvents TLRate As DataGridViewTextBoxColumn
    Friend WithEvents TLQty As DataGridViewTextBoxColumn
    Friend WithEvents TLTotal As DataGridViewTextBoxColumn
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents DDate As DataGridViewTextBoxColumn
    Friend WithEvents CuName As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo1 As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo2 As DataGridViewTextBoxColumn
    Friend WithEvents CuTelNo3 As DataGridViewTextBoxColumn
    Friend WithEvents PCategory As DataGridViewTextBoxColumn
    Friend WithEvents PName As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents REPPaidPrice As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents REPRemarks1 As DataGridViewTextBoxColumn
    Friend WithEvents REPRemarks2 As DataGridViewTextBoxColumn
    Friend WithEvents TSalNo As DataGridViewTextBoxColumn
    Friend WithEvents RetNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents REREPPaidPrice As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents RetRemarks1 As DataGridViewTextBoxColumn
    Friend WithEvents RetRemarks2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TCNo As DataGridViewTextBoxColumn
    Friend WithEvents TCDate As DataGridViewTextBoxColumn
    Friend WithEvents TCRepNo As DataGridViewTextBoxColumn
    Friend WithEvents TCRetNo As DataGridViewTextBoxColumn
    Friend WithEvents TCRemarks As DataGridViewTextBoxColumn
    Friend WithEvents TCSCategory As DataGridViewTextBoxColumn
    Friend WithEvents TCSName As DataGridViewTextBoxColumn
    Friend WithEvents TCRate As DataGridViewTextBoxColumn
    Friend WithEvents TCQty As DataGridViewTextBoxColumn
    Friend WithEvents TCTotal As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkDetails As CheckBox
    Friend WithEvents chkRepair As CheckBox
    Friend WithEvents chkReturn As CheckBox
    Friend WithEvents chkSalesRepair As CheckBox
    Friend WithEvents chkCost As CheckBox
    Friend WithEvents chkLoan As CheckBox
End Class
