<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesRepair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesRepair))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdTView = New System.Windows.Forms.Button()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxItem = New System.Windows.Forms.GroupBox()
        Me.txtSaRepDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaRepNo = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSCharge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSSalePrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSDamagedStocks = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSAvailableStocks = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdSView = New System.Windows.Forms.Button()
        Me.txtSTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSQuantity = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSDetails = New System.Windows.Forms.TextBox()
        Me.txtSNo = New System.Windows.Forms.TextBox()
        Me.txtSCostPrice = New System.Windows.Forms.TextBox()
        Me.txtSMinStocks = New System.Windows.Forms.TextBox()
        Me.txtSLocation = New System.Windows.Forms.TextBox()
        Me.cmbSName = New System.Windows.Forms.ComboBox()
        Me.cmbSCategory = New System.Windows.Forms.ComboBox()
        Me.txtSModelNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmdSaRepSearch = New System.Windows.Forms.Button()
        Me.txtSaRepTo = New System.Windows.Forms.DateTimePicker()
        Me.txtSaRepFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtSaRepTotal = New System.Windows.Forms.TextBox()
        Me.lblSaRepTotal = New System.Windows.Forms.Label()
        Me.grdSalesRepair = New System.Windows.Forms.DataGridView()
        Me.SaRepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaRepDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSaRepDelete = New System.Windows.Forms.Button()
        Me.cmdSaRepNew = New System.Windows.Forms.Button()
        Me.cmdSaRepSave = New System.Windows.Forms.Button()
        Me.cmdSaRepClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.boxItem.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdSalesRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTView)
        Me.GroupBox1.Controls.Add(Me.cmbTName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Info"
        '
        'cmdTView
        '
        Me.cmdTView.Location = New System.Drawing.Point(113, 23)
        Me.cmdTView.Name = "cmdTView"
        Me.cmdTView.Size = New System.Drawing.Size(29, 24)
        Me.cmdTView.TabIndex = 24
        Me.cmdTView.Text = "..."
        Me.cmdTView.UseVisualStyleBackColor = True
        '
        'cmbTName
        '
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(54, 54)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(215, 22)
        Me.cmbTName.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'txtTNo
        '
        Me.txtTNo.Location = New System.Drawing.Point(54, 23)
        Me.txtTNo.Name = "txtTNo"
        Me.txtTNo.Size = New System.Drawing.Size(53, 22)
        Me.txtTNo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No:"
        '
        'boxItem
        '
        Me.boxItem.Controls.Add(Me.txtSaRepDate)
        Me.boxItem.Controls.Add(Me.Label10)
        Me.boxItem.Controls.Add(Me.txtSaRepNo)
        Me.boxItem.Controls.Add(Me.Label58)
        Me.boxItem.Location = New System.Drawing.Point(12, 13)
        Me.boxItem.Name = "boxItem"
        Me.boxItem.Size = New System.Drawing.Size(275, 86)
        Me.boxItem.TabIndex = 62
        Me.boxItem.TabStop = False
        Me.boxItem.Text = "Sales Repair Info"
        '
        'txtSaRepDate
        '
        Me.txtSaRepDate.Location = New System.Drawing.Point(48, 51)
        Me.txtSaRepDate.Name = "txtSaRepDate"
        Me.txtSaRepDate.Size = New System.Drawing.Size(220, 22)
        Me.txtSaRepDate.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 14)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Date:"
        '
        'txtSaRepNo
        '
        Me.txtSaRepNo.Enabled = False
        Me.txtSaRepNo.Location = New System.Drawing.Point(109, 21)
        Me.txtSaRepNo.Name = "txtSaRepNo"
        Me.txtSaRepNo.Size = New System.Drawing.Size(68, 22)
        Me.txtSaRepNo.TabIndex = 90
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(6, 25)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(97, 14)
        Me.Label58.TabIndex = 89
        Me.Label58.Text = "Sales Repair No:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSCharge)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtSSalePrice)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtSDamagedStocks)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtSAvailableStocks)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cmdSView)
        Me.GroupBox3.Controls.Add(Me.txtSTotal)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtSQuantity)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtSDetails)
        Me.GroupBox3.Controls.Add(Me.txtSNo)
        Me.GroupBox3.Controls.Add(Me.txtSCostPrice)
        Me.GroupBox3.Controls.Add(Me.txtSMinStocks)
        Me.GroupBox3.Controls.Add(Me.txtSLocation)
        Me.GroupBox3.Controls.Add(Me.cmbSName)
        Me.GroupBox3.Controls.Add(Me.cmbSCategory)
        Me.GroupBox3.Controls.Add(Me.txtSModelNo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(455, 272)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Details"
        '
        'txtSCharge
        '
        Me.txtSCharge.Location = New System.Drawing.Point(66, 234)
        Me.txtSCharge.Name = "txtSCharge"
        Me.txtSCharge.Size = New System.Drawing.Size(72, 22)
        Me.txtSCharge.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Charge:"
        '
        'txtSSalePrice
        '
        Me.txtSSalePrice.Location = New System.Drawing.Point(80, 135)
        Me.txtSSalePrice.Name = "txtSSalePrice"
        Me.txtSSalePrice.Size = New System.Drawing.Size(86, 22)
        Me.txtSSalePrice.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Sale Price:"
        '
        'txtSDamagedStocks
        '
        Me.txtSDamagedStocks.AutoCompleteCustomSource.AddRange(New String() {"Rs. ####"})
        Me.txtSDamagedStocks.Enabled = False
        Me.txtSDamagedStocks.Location = New System.Drawing.Point(117, 192)
        Me.txtSDamagedStocks.Name = "txtSDamagedStocks"
        Me.txtSDamagedStocks.Size = New System.Drawing.Size(43, 22)
        Me.txtSDamagedStocks.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 195)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 14)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Damaged Units:"
        '
        'txtSAvailableStocks
        '
        Me.txtSAvailableStocks.AutoCompleteCustomSource.AddRange(New String() {"Rs. ####"})
        Me.txtSAvailableStocks.Enabled = False
        Me.txtSAvailableStocks.Location = New System.Drawing.Point(117, 164)
        Me.txtSAvailableStocks.Name = "txtSAvailableStocks"
        Me.txtSAvailableStocks.Size = New System.Drawing.Size(43, 22)
        Me.txtSAvailableStocks.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 167)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 14)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Available Units :"
        '
        'cmdSView
        '
        Me.cmdSView.Location = New System.Drawing.Point(293, 24)
        Me.cmdSView.Name = "cmdSView"
        Me.cmdSView.Size = New System.Drawing.Size(25, 23)
        Me.cmdSView.TabIndex = 45
        Me.cmdSView.Text = "..."
        Me.cmdSView.UseVisualStyleBackColor = True
        '
        'txtSTotal
        '
        Me.txtSTotal.Enabled = False
        Me.txtSTotal.Location = New System.Drawing.Point(338, 234)
        Me.txtSTotal.Name = "txtSTotal"
        Me.txtSTotal.Size = New System.Drawing.Size(74, 22)
        Me.txtSTotal.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(255, 237)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 14)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Total Charge:"
        '
        'txtSQuantity
        '
        Me.txtSQuantity.Location = New System.Drawing.Point(219, 234)
        Me.txtSQuantity.Name = "txtSQuantity"
        Me.txtSQuantity.Size = New System.Drawing.Size(30, 22)
        Me.txtSQuantity.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(158, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 14)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Quantity:"
        '
        'txtSDetails
        '
        Me.txtSDetails.Location = New System.Drawing.Point(213, 120)
        Me.txtSDetails.Multiline = True
        Me.txtSDetails.Name = "txtSDetails"
        Me.txtSDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSDetails.Size = New System.Drawing.Size(232, 70)
        Me.txtSDetails.TabIndex = 36
        '
        'txtSNo
        '
        Me.txtSNo.Enabled = False
        Me.txtSNo.Location = New System.Drawing.Point(401, 24)
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.Size = New System.Drawing.Size(45, 22)
        Me.txtSNo.TabIndex = 35
        '
        'txtSCostPrice
        '
        Me.txtSCostPrice.AutoCompleteCustomSource.AddRange(New String() {"Rs. ####"})
        Me.txtSCostPrice.Enabled = False
        Me.txtSCostPrice.Location = New System.Drawing.Point(107, 107)
        Me.txtSCostPrice.Name = "txtSCostPrice"
        Me.txtSCostPrice.Size = New System.Drawing.Size(97, 22)
        Me.txtSCostPrice.TabIndex = 33
        '
        'txtSMinStocks
        '
        Me.txtSMinStocks.Enabled = False
        Me.txtSMinStocks.Location = New System.Drawing.Point(408, 81)
        Me.txtSMinStocks.Name = "txtSMinStocks"
        Me.txtSMinStocks.Size = New System.Drawing.Size(37, 22)
        Me.txtSMinStocks.TabIndex = 32
        '
        'txtSLocation
        '
        Me.txtSLocation.Enabled = False
        Me.txtSLocation.Location = New System.Drawing.Point(253, 81)
        Me.txtSLocation.Name = "txtSLocation"
        Me.txtSLocation.Size = New System.Drawing.Size(56, 22)
        Me.txtSLocation.TabIndex = 31
        '
        'cmbSName
        '
        Me.cmbSName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSName.FormattingEnabled = True
        Me.cmbSName.Location = New System.Drawing.Point(75, 53)
        Me.cmbSName.Name = "cmbSName"
        Me.cmbSName.Size = New System.Drawing.Size(370, 22)
        Me.cmbSName.TabIndex = 30
        '
        'cmbSCategory
        '
        Me.cmbSCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSCategory.FormattingEnabled = True
        Me.cmbSCategory.Location = New System.Drawing.Point(75, 24)
        Me.cmbSCategory.Name = "cmbSCategory"
        Me.cmbSCategory.Size = New System.Drawing.Size(212, 22)
        Me.cmbSCategory.TabIndex = 29
        '
        'txtSModelNo
        '
        Me.txtSModelNo.Enabled = False
        Me.txtSModelNo.Location = New System.Drawing.Point(83, 79)
        Me.txtSModelNo.Name = "txtSModelNo"
        Me.txtSModelNo.Size = New System.Drawing.Size(100, 22)
        Me.txtSModelNo.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 14)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Stock Code :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 14)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Purchase Price :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(315, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Reorder Point :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(189, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 14)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Location :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 14)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Model No :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 14)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Name :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 14)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Category :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(280, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 22)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "To"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(12, 290)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 22)
        Me.Label35.TabIndex = 115
        Me.Label35.Text = "From"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSaRepSearch
        '
        Me.cmdSaRepSearch.Location = New System.Drawing.Point(534, 290)
        Me.cmdSaRepSearch.Name = "cmdSaRepSearch"
        Me.cmdSaRepSearch.Size = New System.Drawing.Size(63, 22)
        Me.cmdSaRepSearch.TabIndex = 114
        Me.cmdSaRepSearch.Text = "Search"
        Me.cmdSaRepSearch.UseVisualStyleBackColor = True
        '
        'txtSaRepTo
        '
        Me.txtSaRepTo.Location = New System.Drawing.Point(304, 290)
        Me.txtSaRepTo.Name = "txtSaRepTo"
        Me.txtSaRepTo.Size = New System.Drawing.Size(224, 22)
        Me.txtSaRepTo.TabIndex = 113
        '
        'txtSaRepFrom
        '
        Me.txtSaRepFrom.Location = New System.Drawing.Point(50, 290)
        Me.txtSaRepFrom.Name = "txtSaRepFrom"
        Me.txtSaRepFrom.Size = New System.Drawing.Size(224, 22)
        Me.txtSaRepFrom.TabIndex = 112
        '
        'txtSaRepTotal
        '
        Me.txtSaRepTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaRepTotal.Location = New System.Drawing.Point(186, 568)
        Me.txtSaRepTotal.Name = "txtSaRepTotal"
        Me.txtSaRepTotal.Size = New System.Drawing.Size(204, 27)
        Me.txtSaRepTotal.TabIndex = 119
        '
        'lblSaRepTotal
        '
        Me.lblSaRepTotal.AutoSize = True
        Me.lblSaRepTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaRepTotal.Location = New System.Drawing.Point(8, 571)
        Me.lblSaRepTotal.Name = "lblSaRepTotal"
        Me.lblSaRepTotal.Size = New System.Drawing.Size(172, 19)
        Me.lblSaRepTotal.TabIndex = 118
        Me.lblSaRepTotal.Text = "Total of Sales Repaired: "
        '
        'grdSalesRepair
        '
        Me.grdSalesRepair.AllowUserToAddRows = False
        Me.grdSalesRepair.AllowUserToDeleteRows = False
        Me.grdSalesRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSalesRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaRepNo, Me.SaRepDate, Me.SNo, Me.SCategory, Me.SName, Me.Charge, Me.Qty, Me.Total})
        Me.grdSalesRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSalesRepair.Location = New System.Drawing.Point(12, 315)
        Me.grdSalesRepair.Name = "grdSalesRepair"
        Me.grdSalesRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSalesRepair.Size = New System.Drawing.Size(1280, 247)
        Me.grdSalesRepair.TabIndex = 117
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
        'SNo
        '
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Stock Code"
        Me.SNo.Name = "SNo"
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
        'Charge
        '
        Me.Charge.DataPropertyName = "Charge"
        Me.Charge.HeaderText = "Charge"
        Me.Charge.Name = "Charge"
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'cmdSaRepDelete
        '
        Me.cmdSaRepDelete.Location = New System.Drawing.Point(1224, 78)
        Me.cmdSaRepDelete.Name = "cmdSaRepDelete"
        Me.cmdSaRepDelete.Size = New System.Drawing.Size(68, 28)
        Me.cmdSaRepDelete.TabIndex = 124
        Me.cmdSaRepDelete.Text = "Delete"
        Me.cmdSaRepDelete.UseVisualStyleBackColor = True
        '
        'cmdSaRepNew
        '
        Me.cmdSaRepNew.Location = New System.Drawing.Point(1224, 12)
        Me.cmdSaRepNew.Name = "cmdSaRepNew"
        Me.cmdSaRepNew.Size = New System.Drawing.Size(68, 27)
        Me.cmdSaRepNew.TabIndex = 123
        Me.cmdSaRepNew.Text = "New"
        Me.cmdSaRepNew.UseVisualStyleBackColor = True
        '
        'cmdSaRepSave
        '
        Me.cmdSaRepSave.Location = New System.Drawing.Point(1224, 45)
        Me.cmdSaRepSave.Name = "cmdSaRepSave"
        Me.cmdSaRepSave.Size = New System.Drawing.Size(68, 27)
        Me.cmdSaRepSave.TabIndex = 122
        Me.cmdSaRepSave.Text = "Save"
        Me.cmdSaRepSave.UseVisualStyleBackColor = True
        '
        'cmdSaRepClose
        '
        Me.cmdSaRepClose.Location = New System.Drawing.Point(1224, 113)
        Me.cmdSaRepClose.Name = "cmdSaRepClose"
        Me.cmdSaRepClose.Size = New System.Drawing.Size(68, 30)
        Me.cmdSaRepClose.TabIndex = 121
        Me.cmdSaRepClose.Text = "Close"
        Me.cmdSaRepClose.UseVisualStyleBackColor = True
        '
        'frmSalesRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 687)
        Me.Controls.Add(Me.cmdSaRepDelete)
        Me.Controls.Add(Me.cmdSaRepNew)
        Me.Controls.Add(Me.cmdSaRepSave)
        Me.Controls.Add(Me.cmdSaRepClose)
        Me.Controls.Add(Me.txtSaRepTotal)
        Me.Controls.Add(Me.lblSaRepTotal)
        Me.Controls.Add(Me.grdSalesRepair)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmdSaRepSearch)
        Me.Controls.Add(Me.txtSaRepTo)
        Me.Controls.Add(Me.txtSaRepFrom)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.boxItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalesRepair"
        Me.Text = "LASER System - Sales Repair"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.boxItem.ResumeLayout(False)
        Me.boxItem.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdSalesRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTView As System.Windows.Forms.Button
    Friend WithEvents cmbTName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boxItem As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaRepDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSaRepNo As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSDamagedStocks As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSAvailableStocks As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdSView As System.Windows.Forms.Button
    Friend WithEvents txtSTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtSNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtSMinStocks As System.Windows.Forms.TextBox
    Friend WithEvents txtSLocation As System.Windows.Forms.TextBox
    Friend WithEvents cmbSName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtSModelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmdSaRepSearch As System.Windows.Forms.Button
    Friend WithEvents txtSaRepTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSaRepFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSaRepTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSaRepTotal As System.Windows.Forms.Label
    Friend WithEvents grdSalesRepair As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSaRepDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSaRepNew As System.Windows.Forms.Button
    Friend WithEvents cmdSaRepSave As System.Windows.Forms.Button
    Friend WithEvents cmdSaRepClose As System.Windows.Forms.Button
    Friend WithEvents SaRepNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaRepDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
