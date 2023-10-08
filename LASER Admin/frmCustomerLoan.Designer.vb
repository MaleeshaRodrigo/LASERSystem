<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerLoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerLoan))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCuTelNo3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCuTelNo2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCuView = New System.Windows.Forms.Button()
        Me.txtCuTelNo1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmbCuName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdCustomerLoan = New System.Windows.Forms.DataGridView()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtCuLRemarks = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuLAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCuLDate = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbCuLStatus = New System.Windows.Forms.ComboBox()
        Me.txtCuLNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabInfo = New System.Windows.Forms.TabControl()
        Me.RepairInfo = New System.Windows.Forms.TabPage()
        Me.cmdDInfo = New System.Windows.Forms.Button()
        Me.txtDDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaleInfo = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSaDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSaNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdCustomerLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabInfo.SuspendLayout()
        Me.RepairInfo.SuspendLayout()
        Me.SaleInfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmdCuView)
        Me.GroupBox2.Controls.Add(Me.txtCuTelNo1)
        Me.GroupBox2.Controls.Add(Me.cmbCuName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 134)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Info"
        '
        'txtCuTelNo3
        '
        Me.txtCuTelNo3.Enabled = False
        Me.txtCuTelNo3.Location = New System.Drawing.Point(110, 102)
        Me.txtCuTelNo3.Mask = "999 0 000 000"
        Me.txtCuTelNo3.Name = "txtCuTelNo3"
        Me.txtCuTelNo3.Size = New System.Drawing.Size(104, 24)
        Me.txtCuTelNo3.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Telephone No 3 :"
        '
        'txtCuTelNo2
        '
        Me.txtCuTelNo2.Enabled = False
        Me.txtCuTelNo2.Location = New System.Drawing.Point(110, 74)
        Me.txtCuTelNo2.Mask = "999 0 000 000"
        Me.txtCuTelNo2.Name = "txtCuTelNo2"
        Me.txtCuTelNo2.Size = New System.Drawing.Size(104, 24)
        Me.txtCuTelNo2.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Telephone No 2 :"
        '
        'cmdCuView
        '
        Me.cmdCuView.Location = New System.Drawing.Point(326, 16)
        Me.cmdCuView.Name = "cmdCuView"
        Me.cmdCuView.Size = New System.Drawing.Size(28, 24)
        Me.cmdCuView.TabIndex = 36
        Me.cmdCuView.Text = "..."
        Me.cmdCuView.UseVisualStyleBackColor = True
        '
        'txtCuTelNo1
        '
        Me.txtCuTelNo1.Enabled = False
        Me.txtCuTelNo1.Location = New System.Drawing.Point(110, 46)
        Me.txtCuTelNo1.Mask = "999 0 000 000"
        Me.txtCuTelNo1.Name = "txtCuTelNo1"
        Me.txtCuTelNo1.Size = New System.Drawing.Size(104, 24)
        Me.txtCuTelNo1.TabIndex = 4
        '
        'cmbCuName
        '
        Me.cmbCuName.FormattingEnabled = True
        Me.cmbCuName.Location = New System.Drawing.Point(110, 17)
        Me.cmbCuName.Name = "cmbCuName"
        Me.cmbCuName.Size = New System.Drawing.Size(210, 23)
        Me.cmbCuName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telephone No 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Name :"
        '
        'grdCustomerLoan
        '
        Me.grdCustomerLoan.AllowUserToAddRows = False
        Me.grdCustomerLoan.AllowUserToDeleteRows = False
        Me.grdCustomerLoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCustomerLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomerLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdCustomerLoan.Location = New System.Drawing.Point(17, 307)
        Me.grdCustomerLoan.Name = "grdCustomerLoan"
        Me.grdCustomerLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCustomerLoan.Size = New System.Drawing.Size(805, 176)
        Me.grdCustomerLoan.TabIndex = 31
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(373, 277)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(159, 23)
        Me.cmbFilter.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(330, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Filter"
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(66, 277)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(193, 24)
        Me.txtSearch.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(14, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Search"
        '
        'cmdSave
        '
        Me.cmdSave.Image = My.Resources.Resources.Save
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(748, 68)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 31)
        Me.cmdSave.TabIndex = 39
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Image = My.Resources.Resources.close
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(748, 142)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 31)
        Me.cmdClose.TabIndex = 41
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = My.Resources.Resources.Delete
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(748, 105)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 31)
        Me.cmdDelete.TabIndex = 40
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtCuLRemarks
        '
        Me.txtCuLRemarks.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtCuLRemarks.Location = New System.Drawing.Point(449, 171)
        Me.txtCuLRemarks.Multiline = True
        Me.txtCuLRemarks.Name = "txtCuLRemarks"
        Me.txtCuLRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCuLRemarks.Size = New System.Drawing.Size(293, 100)
        Me.txtCuLRemarks.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(382, 171)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 17)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Remarks:"
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdSearch.Location = New System.Drawing.Point(265, 277)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(59, 24)
        Me.cmdSearch.TabIndex = 44
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Customer Loan Amount:"
        '
        'txtCuLAmount
        '
        Me.txtCuLAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtCuLAmount.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtCuLAmount.Location = New System.Drawing.Point(181, 79)
        Me.txtCuLAmount.Name = "txtCuLAmount"
        Me.txtCuLAmount.Size = New System.Drawing.Size(100, 24)
        Me.txtCuLAmount.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Customer Loan Date:"
        '
        'txtCuLDate
        '
        Me.txtCuLDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtCuLDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCuLDate.Location = New System.Drawing.Point(139, 20)
        Me.txtCuLDate.Name = "txtCuLDate"
        Me.txtCuLDate.Size = New System.Drawing.Size(173, 24)
        Me.txtCuLDate.TabIndex = 38
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(156, 79)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 24)
        Me.Label35.TabIndex = 79
        Me.Label35.Text = "Rs."
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 17)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Status:"
        '
        'cmbCuLStatus
        '
        Me.cmbCuLStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuLStatus.FormattingEnabled = True
        Me.cmbCuLStatus.Items.AddRange(New Object() {"Paid", "Not Paid"})
        Me.cmbCuLStatus.Location = New System.Drawing.Point(59, 50)
        Me.cmbCuLStatus.Name = "cmbCuLStatus"
        Me.cmbCuLStatus.Size = New System.Drawing.Size(155, 23)
        Me.cmbCuLStatus.TabIndex = 82
        '
        'txtCuLNo
        '
        Me.txtCuLNo.Enabled = False
        Me.txtCuLNo.Location = New System.Drawing.Point(318, 20)
        Me.txtCuLNo.Name = "txtCuLNo"
        Me.txtCuLNo.Size = New System.Drawing.Size(40, 24)
        Me.txtCuLNo.TabIndex = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCuLNo)
        Me.GroupBox1.Controls.Add(Me.cmbCuLStatus)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.txtCuLDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCuLAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 134)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Loan Info"
        '
        'tabInfo
        '
        Me.tabInfo.Controls.Add(Me.RepairInfo)
        Me.tabInfo.Controls.Add(Me.SaleInfo)
        Me.tabInfo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.tabInfo.Location = New System.Drawing.Point(12, 171)
        Me.tabInfo.Name = "tabInfo"
        Me.tabInfo.SelectedIndex = 0
        Me.tabInfo.Size = New System.Drawing.Size(364, 104)
        Me.tabInfo.TabIndex = 45
        '
        'RepairInfo
        '
        Me.RepairInfo.Controls.Add(Me.cmdDInfo)
        Me.RepairInfo.Controls.Add(Me.txtDDate)
        Me.RepairInfo.Controls.Add(Me.Label2)
        Me.RepairInfo.Controls.Add(Me.txtDNo)
        Me.RepairInfo.Controls.Add(Me.Label1)
        Me.RepairInfo.Location = New System.Drawing.Point(4, 24)
        Me.RepairInfo.Name = "RepairInfo"
        Me.RepairInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.RepairInfo.Size = New System.Drawing.Size(356, 76)
        Me.RepairInfo.TabIndex = 0
        Me.RepairInfo.Text = "Deliver Info"
        Me.RepairInfo.UseVisualStyleBackColor = True
        '
        'cmdDInfo
        '
        Me.cmdDInfo.Location = New System.Drawing.Point(190, 6)
        Me.cmdDInfo.Name = "cmdDInfo"
        Me.cmdDInfo.Size = New System.Drawing.Size(28, 24)
        Me.cmdDInfo.TabIndex = 7
        Me.cmdDInfo.Text = "..."
        Me.cmdDInfo.UseVisualStyleBackColor = True
        '
        'txtDDate
        '
        Me.txtDDate.Enabled = False
        Me.txtDDate.Location = New System.Drawing.Point(110, 36)
        Me.txtDDate.Name = "txtDDate"
        Me.txtDDate.Size = New System.Drawing.Size(212, 24)
        Me.txtDDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Delivered Date:"
        '
        'txtDNo
        '
        Me.txtDNo.Location = New System.Drawing.Point(84, 6)
        Me.txtDNo.Name = "txtDNo"
        Me.txtDNo.Size = New System.Drawing.Size(100, 24)
        Me.txtDNo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Deliver No:"
        '
        'SaleInfo
        '
        Me.SaleInfo.Controls.Add(Me.Button2)
        Me.SaleInfo.Controls.Add(Me.txtSaDate)
        Me.SaleInfo.Controls.Add(Me.txtSaNo)
        Me.SaleInfo.Controls.Add(Me.Label6)
        Me.SaleInfo.Controls.Add(Me.Label7)
        Me.SaleInfo.Location = New System.Drawing.Point(4, 24)
        Me.SaleInfo.Name = "SaleInfo"
        Me.SaleInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.SaleInfo.Size = New System.Drawing.Size(356, 76)
        Me.SaleInfo.TabIndex = 1
        Me.SaleInfo.Text = "Sale Info"
        Me.SaleInfo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSaDate
        '
        Me.txtSaDate.Enabled = False
        Me.txtSaDate.Location = New System.Drawing.Point(77, 36)
        Me.txtSaDate.Name = "txtSaDate"
        Me.txtSaDate.Size = New System.Drawing.Size(238, 24)
        Me.txtSaDate.TabIndex = 8
        '
        'txtSaNo
        '
        Me.txtSaNo.Location = New System.Drawing.Point(66, 6)
        Me.txtSaNo.Name = "txtSaNo"
        Me.txtSaNo.Size = New System.Drawing.Size(78, 24)
        Me.txtSaNo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sold Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Sale No:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(14, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Search"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(330, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Filter"
        '
        'cmdNew
        '
        Me.cmdNew.Image = My.Resources.Resources._new
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(748, 31)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 31)
        Me.cmdNew.TabIndex = 38
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'OPTIONToolStripMenuItem
        '
        Me.OPTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OPTIONToolStripMenuItem.Name = "OPTIONToolStripMenuItem"
        Me.OPTIONToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OPTIONToolStripMenuItem.Text = "OPTION"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'frmCustomerLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 495)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tabInfo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtCuLRemarks)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdCustomerLoan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerLoan"
        Me.Text = "LASER System - Customer Loan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdCustomerLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabInfo.ResumeLayout(False)
        Me.RepairInfo.ResumeLayout(False)
        Me.RepairInfo.PerformLayout()
        Me.SaleInfo.ResumeLayout(False)
        Me.SaleInfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuTelNo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCuTelNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdCuView As System.Windows.Forms.Button
    Friend WithEvents txtCuTelNo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCuName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdCustomerLoan As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtCuLRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuLAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCuLDate As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbCuLStatus As ComboBox
    Friend WithEvents txtCuLNo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tabInfo As TabControl
    Friend WithEvents RepairInfo As TabPage
    Friend WithEvents txtDDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SaleInfo As TabPage
    Friend WithEvents txtSaDate As DateTimePicker
    Friend WithEvents txtSaNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdDInfo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
