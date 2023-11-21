<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTechnicianLoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechnicianLoan))
        Me.boxItem = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTLDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTLNo = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtTLReason = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTLAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdTView = New System.Windows.Forms.Button()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTLSubTotal = New System.Windows.Forms.TextBox()
        Me.lblTLSubTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmdTLSearch = New System.Windows.Forms.Button()
        Me.txtTLTo = New System.Windows.Forms.DateTimePicker()
        Me.txtTLFrom = New System.Windows.Forms.DateTimePicker()
        Me.grdTLSearch = New System.Windows.Forms.DataGridView()
        Me.lblRs1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSQty = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtSUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmdIView = New System.Windows.Forms.Button()
        Me.txtSNo = New System.Windows.Forms.TextBox()
        Me.cmbSName = New System.Windows.Forms.ComboBox()
        Me.cmbSCategory = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmdTLDelete = New System.Windows.Forms.Button()
        Me.cmdTLNew = New System.Windows.Forms.Button()
        Me.cmdTLSave = New System.Windows.Forms.Button()
        Me.cmdTLClose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicionInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.boxItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdTLSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxItem
        '
        Me.boxItem.Controls.Add(Me.Label1)
        Me.boxItem.Controls.Add(Me.txtTLDate)
        Me.boxItem.Controls.Add(Me.Label10)
        Me.boxItem.Controls.Add(Me.txtTLNo)
        Me.boxItem.Controls.Add(Me.Label58)
        Me.boxItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.boxItem.Location = New System.Drawing.Point(12, 27)
        Me.boxItem.Name = "boxItem"
        Me.boxItem.Size = New System.Drawing.Size(329, 81)
        Me.boxItem.TabIndex = 63
        Me.boxItem.TabStop = False
        Me.boxItem.Text = "Technician Loan Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(132, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "TL-"
        '
        'txtTLDate
        '
        Me.txtTLDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtTLDate.Location = New System.Drawing.Point(52, 51)
        Me.txtTLDate.Name = "txtTLDate"
        Me.txtTLDate.Size = New System.Drawing.Size(271, 24)
        Me.txtTLDate.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(6, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Date:"
        '
        'txtTLNo
        '
        Me.txtTLNo.Enabled = False
        Me.txtTLNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtTLNo.Location = New System.Drawing.Point(163, 21)
        Me.txtTLNo.Name = "txtTLNo"
        Me.txtTLNo.Size = New System.Drawing.Size(63, 24)
        Me.txtTLNo.TabIndex = 90
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label58.Location = New System.Drawing.Point(6, 23)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(120, 17)
        Me.Label58.TabIndex = 89
        Me.Label58.Text = "Technician Loan No:"
        '
        'txtTLReason
        '
        Me.txtTLReason.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtTLReason.Location = New System.Drawing.Point(12, 193)
        Me.txtTLReason.Multiline = True
        Me.txtTLReason.Name = "txtTLReason"
        Me.txtTLReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTLReason.Size = New System.Drawing.Size(329, 101)
        Me.txtTLReason.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Reason:"
        '
        'txtTLAmount
        '
        Me.txtTLAmount.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtTLAmount.Location = New System.Drawing.Point(100, 300)
        Me.txtTLAmount.Name = "txtTLAmount"
        Me.txtTLAmount.Size = New System.Drawing.Size(94, 24)
        Me.txtTLAmount.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTView)
        Me.GroupBox1.Controls.Add(Me.cmbTName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 53)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Info"
        '
        'cmdTView
        '
        Me.cmdTView.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdTView.Location = New System.Drawing.Point(290, 21)
        Me.cmdTView.Name = "cmdTView"
        Me.cmdTView.Size = New System.Drawing.Size(33, 23)
        Me.cmdTView.TabIndex = 24
        Me.cmdTView.Text = "..."
        Me.cmdTView.UseVisualStyleBackColor = True
        '
        'cmbTName
        '
        Me.cmbTName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTName.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(61, 21)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(223, 23)
        Me.cmbTName.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'txtTLSubTotal
        '
        Me.txtTLSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTLSubTotal.Enabled = False
        Me.txtTLSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTLSubTotal.Location = New System.Drawing.Point(129, 537)
        Me.txtTLSubTotal.Name = "txtTLSubTotal"
        Me.txtTLSubTotal.Size = New System.Drawing.Size(99, 27)
        Me.txtTLSubTotal.TabIndex = 116
        '
        'lblTLSubTotal
        '
        Me.lblTLSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTLSubTotal.AutoSize = True
        Me.lblTLSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTLSubTotal.Location = New System.Drawing.Point(10, 540)
        Me.lblTLSubTotal.Name = "lblTLSubTotal"
        Me.lblTLSubTotal.Size = New System.Drawing.Size(88, 19)
        Me.lblTLSubTotal.TabIndex = 115
        Me.lblTLSubTotal.Text = "Total Loan: "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(281, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 24)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "To"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label35.Location = New System.Drawing.Point(13, 327)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 24)
        Me.Label35.TabIndex = 113
        Me.Label35.Text = "From"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdTLSearch
        '
        Me.cmdTLSearch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdTLSearch.Location = New System.Drawing.Point(535, 327)
        Me.cmdTLSearch.Name = "cmdTLSearch"
        Me.cmdTLSearch.Size = New System.Drawing.Size(63, 24)
        Me.cmdTLSearch.TabIndex = 112
        Me.cmdTLSearch.Text = "Search"
        Me.cmdTLSearch.UseVisualStyleBackColor = True
        '
        'txtTLTo
        '
        Me.txtTLTo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtTLTo.Location = New System.Drawing.Point(305, 327)
        Me.txtTLTo.Name = "txtTLTo"
        Me.txtTLTo.Size = New System.Drawing.Size(224, 24)
        Me.txtTLTo.TabIndex = 111
        '
        'txtTLFrom
        '
        Me.txtTLFrom.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtTLFrom.Location = New System.Drawing.Point(51, 327)
        Me.txtTLFrom.Name = "txtTLFrom"
        Me.txtTLFrom.Size = New System.Drawing.Size(224, 24)
        Me.txtTLFrom.TabIndex = 110
        '
        'grdTLSearch
        '
        Me.grdTLSearch.AllowUserToAddRows = False
        Me.grdTLSearch.AllowUserToDeleteRows = False
        Me.grdTLSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTLSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTLSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdTLSearch.Location = New System.Drawing.Point(13, 354)
        Me.grdTLSearch.Name = "grdTLSearch"
        Me.grdTLSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTLSearch.Size = New System.Drawing.Size(867, 177)
        Me.grdTLSearch.TabIndex = 109
        '
        'lblRs1
        '
        Me.lblRs1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRs1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblRs1.Location = New System.Drawing.Point(75, 300)
        Me.lblRs1.Name = "lblRs1"
        Me.lblRs1.Size = New System.Drawing.Size(24, 24)
        Me.lblRs1.TabIndex = 117
        Me.lblRs1.Text = "Rs."
        Me.lblRs1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSQty)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.txtSUnitPrice)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.cmdIView)
        Me.GroupBox2.Controls.Add(Me.txtSNo)
        Me.GroupBox2.Controls.Add(Me.cmbSName)
        Me.GroupBox2.Controls.Add(Me.cmbSCategory)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 140)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Info"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(80, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Rs."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSQty
        '
        Me.txtSQty.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSQty.Location = New System.Drawing.Point(80, 106)
        Me.txtSQty.Name = "txtSQty"
        Me.txtSQty.Size = New System.Drawing.Size(43, 24)
        Me.txtSQty.TabIndex = 107
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label55.Location = New System.Drawing.Point(7, 109)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(32, 17)
        Me.Label55.TabIndex = 106
        Me.Label55.Text = "Qty:"
        '
        'txtSUnitPrice
        '
        Me.txtSUnitPrice.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSUnitPrice.Location = New System.Drawing.Point(105, 78)
        Me.txtSUnitPrice.Name = "txtSUnitPrice"
        Me.txtSUnitPrice.Size = New System.Drawing.Size(86, 24)
        Me.txtSUnitPrice.TabIndex = 105
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label54.Location = New System.Drawing.Point(7, 81)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(67, 17)
        Me.Label54.TabIndex = 104
        Me.Label54.Text = "Unit Price:"
        '
        'cmdIView
        '
        Me.cmdIView.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdIView.Location = New System.Drawing.Point(413, 20)
        Me.cmdIView.Name = "cmdIView"
        Me.cmdIView.Size = New System.Drawing.Size(31, 25)
        Me.cmdIView.TabIndex = 103
        Me.cmdIView.Text = "..."
        Me.cmdIView.UseVisualStyleBackColor = True
        '
        'txtSNo
        '
        Me.txtSNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSNo.Location = New System.Drawing.Point(365, 20)
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.Size = New System.Drawing.Size(42, 24)
        Me.txtSNo.TabIndex = 89
        '
        'cmbSName
        '
        Me.cmbSName.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbSName.FormattingEnabled = True
        Me.cmbSName.Location = New System.Drawing.Point(80, 49)
        Me.cmbSName.Name = "cmbSName"
        Me.cmbSName.Size = New System.Drawing.Size(364, 23)
        Me.cmbSName.TabIndex = 88
        '
        'cmbSCategory
        '
        Me.cmbSCategory.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmbSCategory.FormattingEnabled = True
        Me.cmbSCategory.Location = New System.Drawing.Point(80, 20)
        Me.cmbSCategory.Name = "cmbSCategory"
        Me.cmbSCategory.Size = New System.Drawing.Size(226, 23)
        Me.cmbSCategory.TabIndex = 87
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label44.Location = New System.Drawing.Point(312, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 17)
        Me.Label44.TabIndex = 86
        Me.Label44.Text = "Code :"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label45.Location = New System.Drawing.Point(7, 54)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(46, 17)
        Me.Label45.TabIndex = 85
        Me.Label45.Text = "Name:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label46.Location = New System.Drawing.Point(7, 23)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(63, 17)
        Me.Label46.TabIndex = 84
        Me.Label46.Text = "Category:"
        '
        'cmdTLDelete
        '
        Me.cmdTLDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTLDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdTLDelete.Image = My.Resources.Resources.Delete
        Me.cmdTLDelete.Location = New System.Drawing.Point(804, 128)
        Me.cmdTLDelete.Name = "cmdTLDelete"
        Me.cmdTLDelete.Size = New System.Drawing.Size(76, 39)
        Me.cmdTLDelete.TabIndex = 124
        Me.cmdTLDelete.Text = "Delete"
        Me.cmdTLDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTLDelete.UseVisualStyleBackColor = True
        '
        'cmdTLNew
        '
        Me.cmdTLNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTLNew.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdTLNew.Image = My.Resources.Resources._new
        Me.cmdTLNew.Location = New System.Drawing.Point(804, 40)
        Me.cmdTLNew.Name = "cmdTLNew"
        Me.cmdTLNew.Size = New System.Drawing.Size(76, 39)
        Me.cmdTLNew.TabIndex = 123
        Me.cmdTLNew.Text = "New"
        Me.cmdTLNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTLNew.UseVisualStyleBackColor = True
        '
        'cmdTLSave
        '
        Me.cmdTLSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTLSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdTLSave.Image = My.Resources.Resources.Save
        Me.cmdTLSave.Location = New System.Drawing.Point(804, 85)
        Me.cmdTLSave.Name = "cmdTLSave"
        Me.cmdTLSave.Size = New System.Drawing.Size(76, 37)
        Me.cmdTLSave.TabIndex = 122
        Me.cmdTLSave.Text = "Save"
        Me.cmdTLSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTLSave.UseVisualStyleBackColor = True
        '
        'cmdTLClose
        '
        Me.cmdTLClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTLClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdTLClose.Image = My.Resources.Resources.close
        Me.cmdTLClose.Location = New System.Drawing.Point(804, 173)
        Me.cmdTLClose.Name = "cmdTLClose"
        Me.cmdTLClose.Size = New System.Drawing.Size(76, 40)
        Me.cmdTLClose.TabIndex = 121
        Me.cmdTLClose.Text = "Close"
        Me.cmdTLClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdTLClose.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(97, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 27)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Rs."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(893, 24)
        Me.MenuStrip1.TabIndex = 126
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicionInfoToolStripMenuItem, Me.ItemInfoToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'TechnicionInfoToolStripMenuItem
        '
        Me.TechnicionInfoToolStripMenuItem.Name = "TechnicionInfoToolStripMenuItem"
        Me.TechnicionInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TechnicionInfoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.TechnicionInfoToolStripMenuItem.Text = "Technicion Info"
        '
        'ItemInfoToolStripMenuItem
        '
        Me.ItemInfoToolStripMenuItem.Name = "ItemInfoToolStripMenuItem"
        Me.ItemInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ItemInfoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ItemInfoToolStripMenuItem.Text = "Item Info"
        '
        'frmTechnicianLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 606)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdTLDelete)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdTLNew)
        Me.Controls.Add(Me.cmdTLSave)
        Me.Controls.Add(Me.lblRs1)
        Me.Controls.Add(Me.cmdTLClose)
        Me.Controls.Add(Me.txtTLSubTotal)
        Me.Controls.Add(Me.txtTLReason)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTLSubTotal)
        Me.Controls.Add(Me.txtTLAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmdTLSearch)
        Me.Controls.Add(Me.txtTLTo)
        Me.Controls.Add(Me.txtTLFrom)
        Me.Controls.Add(Me.grdTLSearch)
        Me.Controls.Add(Me.boxItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTechnicianLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - Technician Loan"
        Me.boxItem.ResumeLayout(False)
        Me.boxItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdTLSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxItem As System.Windows.Forms.GroupBox
    Friend WithEvents txtTLDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTLNo As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTView As System.Windows.Forms.Button
    Friend WithEvents cmbTName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTLReason As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTLAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTLSubTotal As TextBox
    Friend WithEvents lblTLSubTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents cmdTLSearch As Button
    Friend WithEvents txtTLTo As DateTimePicker
    Friend WithEvents txtTLFrom As DateTimePicker
    Friend WithEvents grdTLSearch As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRs1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSQty As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtSUnitPrice As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents cmdIView As Button
    Friend WithEvents txtSNo As TextBox
    Friend WithEvents cmbSName As ComboBox
    Friend WithEvents cmbSCategory As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdTLDelete As Button
    Friend WithEvents cmdTLNew As Button
    Friend WithEvents cmdTLSave As Button
    Friend WithEvents cmdTLClose As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TechnicionInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemInfoToolStripMenuItem As ToolStripMenuItem
End Class
