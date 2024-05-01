<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPopUp
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPopUp))
        Me.grpPaymentInfo = New System.Windows.Forms.GroupBox()
        Me.txtRepAdvanced = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkCashDrawer = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.cmdNotReceipt = New System.Windows.Forms.Button()
        Me.tabcontrolPayment = New System.Windows.Forms.TabControl()
        Me.tabpageCash = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCAmount = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCBalance = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCReceived = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tabpageCard = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCPAmount = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCPInvoiceNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tabpageCuLoan = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCuLNo = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCuLAmount = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmdReceipt = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpPaymentInfo.SuspendLayout()
        Me.tabcontrolPayment.SuspendLayout()
        Me.tabpageCash.SuspendLayout()
        Me.tabpageCard.SuspendLayout()
        Me.tabpageCuLoan.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPaymentInfo
        '
        Me.grpPaymentInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpPaymentInfo.Controls.Add(Me.txtRepAdvanced)
        Me.grpPaymentInfo.Controls.Add(Me.Label16)
        Me.grpPaymentInfo.Controls.Add(Me.Label17)
        Me.grpPaymentInfo.Controls.Add(Me.txtSubTotal)
        Me.grpPaymentInfo.Controls.Add(Me.Label14)
        Me.grpPaymentInfo.Controls.Add(Me.Label15)
        Me.grpPaymentInfo.Controls.Add(Me.Label13)
        Me.grpPaymentInfo.Controls.Add(Me.chkCashDrawer)
        Me.grpPaymentInfo.Controls.Add(Me.cmdCancel)
        Me.grpPaymentInfo.Controls.Add(Me.txtGrandTotal)
        Me.grpPaymentInfo.Controls.Add(Me.cmdNotReceipt)
        Me.grpPaymentInfo.Controls.Add(Me.tabcontrolPayment)
        Me.grpPaymentInfo.Controls.Add(Me.cmdReceipt)
        Me.grpPaymentInfo.Controls.Add(Me.Label26)
        Me.grpPaymentInfo.Controls.Add(Me.Label10)
        Me.grpPaymentInfo.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.grpPaymentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpPaymentInfo.Location = New System.Drawing.Point(2, 2)
        Me.grpPaymentInfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpPaymentInfo.Name = "grpPaymentInfo"
        Me.grpPaymentInfo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpPaymentInfo.Size = New System.Drawing.Size(320, 342)
        Me.grpPaymentInfo.TabIndex = 84
        Me.grpPaymentInfo.TabStop = False
        Me.grpPaymentInfo.Text = "Payment Info"
        '
        'txtRepAdvanced
        '
        Me.txtRepAdvanced.Enabled = False
        Me.txtRepAdvanced.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtRepAdvanced.Location = New System.Drawing.Point(97, 43)
        Me.txtRepAdvanced.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRepAdvanced.Name = "txtRepAdvanced"
        Me.txtRepAdvanced.Size = New System.Drawing.Size(60, 24)
        Me.txtRepAdvanced.TabIndex = 114
        Me.txtRepAdvanced.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(4, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 17)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Advanced:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(78, 43)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 20)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "Rs."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtSubTotal.Location = New System.Drawing.Point(97, 21)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(60, 24)
        Me.txtSubTotal.TabIndex = 111
        Me.txtSubTotal.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(4, 24)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 17)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Sub Total:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(78, 21)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 20)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Rs."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(4, 260)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(309, 72)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'chkCashDrawer
        '
        Me.chkCashDrawer.Checked = True
        Me.chkCashDrawer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCashDrawer.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.chkCashDrawer.Location = New System.Drawing.Point(218, 198)
        Me.chkCashDrawer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCashDrawer.Name = "chkCashDrawer"
        Me.chkCashDrawer.Size = New System.Drawing.Size(96, 47)
        Me.chkCashDrawer.TabIndex = 108
        Me.chkCashDrawer.Text = "Cash Drawer එක විවෘත විය යුතුය  "
        Me.chkCashDrawer.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdCancel.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdCancel.Location = New System.Drawing.Point(294, 0)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(26, 24)
        Me.cmdCancel.TabIndex = 105
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txtGrandTotal.Location = New System.Drawing.Point(97, 66)
        Me.txtGrandTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(60, 24)
        Me.txtGrandTotal.TabIndex = 87
        Me.txtGrandTotal.Text = "0"
        '
        'cmdNotReceipt
        '
        Me.cmdNotReceipt.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdNotReceipt.Location = New System.Drawing.Point(116, 195)
        Me.cmdNotReceipt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdNotReceipt.Name = "cmdNotReceipt"
        Me.cmdNotReceipt.Size = New System.Drawing.Size(98, 50)
        Me.cmdNotReceipt.TabIndex = 107
        Me.cmdNotReceipt.Text = "බිල්පතක් අවශ්‍ය නැත."
        Me.cmdNotReceipt.UseVisualStyleBackColor = True
        '
        'tabcontrolPayment
        '
        Me.tabcontrolPayment.Controls.Add(Me.tabpageCash)
        Me.tabcontrolPayment.Controls.Add(Me.tabpageCard)
        Me.tabcontrolPayment.Controls.Add(Me.tabpageCuLoan)
        Me.tabcontrolPayment.Location = New System.Drawing.Point(5, 90)
        Me.tabcontrolPayment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabcontrolPayment.Name = "tabcontrolPayment"
        Me.tabcontrolPayment.SelectedIndex = 0
        Me.tabcontrolPayment.Size = New System.Drawing.Size(309, 100)
        Me.tabcontrolPayment.TabIndex = 52
        '
        'tabpageCash
        '
        Me.tabpageCash.Controls.Add(Me.Label9)
        Me.tabpageCash.Controls.Add(Me.Label8)
        Me.tabpageCash.Controls.Add(Me.Label7)
        Me.tabpageCash.Controls.Add(Me.txtCAmount)
        Me.tabpageCash.Controls.Add(Me.Label34)
        Me.tabpageCash.Controls.Add(Me.txtCBalance)
        Me.tabpageCash.Controls.Add(Me.Label25)
        Me.tabpageCash.Controls.Add(Me.txtCReceived)
        Me.tabpageCash.Controls.Add(Me.Label24)
        Me.tabpageCash.Location = New System.Drawing.Point(4, 23)
        Me.tabpageCash.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageCash.Name = "tabpageCash"
        Me.tabpageCash.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageCash.Size = New System.Drawing.Size(301, 73)
        Me.tabpageCash.TabIndex = 0
        Me.tabpageCash.Text = "By Cash"
        Me.tabpageCash.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(56, 50)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Rs."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(56, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Rs."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(56, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Rs."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCAmount
        '
        Me.txtCAmount.Location = New System.Drawing.Point(75, 5)
        Me.txtCAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCAmount.Name = "txtCAmount"
        Me.txtCAmount.Size = New System.Drawing.Size(79, 22)
        Me.txtCAmount.TabIndex = 45
        Me.txtCAmount.Text = "0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(4, 8)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(52, 14)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Amount:"
        '
        'txtCBalance
        '
        Me.txtCBalance.Enabled = False
        Me.txtCBalance.Location = New System.Drawing.Point(75, 50)
        Me.txtCBalance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCBalance.Name = "txtCBalance"
        Me.txtCBalance.Size = New System.Drawing.Size(79, 22)
        Me.txtCBalance.TabIndex = 43
        Me.txtCBalance.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 54)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 14)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Balance:"
        '
        'txtCReceived
        '
        Me.txtCReceived.Location = New System.Drawing.Point(75, 28)
        Me.txtCReceived.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCReceived.Name = "txtCReceived"
        Me.txtCReceived.Size = New System.Drawing.Size(79, 22)
        Me.txtCReceived.TabIndex = 41
        Me.txtCReceived.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 31)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 14)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Received:"
        '
        'tabpageCard
        '
        Me.tabpageCard.Controls.Add(Me.Label6)
        Me.tabpageCard.Controls.Add(Me.txtCPAmount)
        Me.tabpageCard.Controls.Add(Me.Label32)
        Me.tabpageCard.Controls.Add(Me.txtCPInvoiceNo)
        Me.tabpageCard.Controls.Add(Me.Label28)
        Me.tabpageCard.Location = New System.Drawing.Point(4, 23)
        Me.tabpageCard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageCard.Name = "tabpageCard"
        Me.tabpageCard.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageCard.Size = New System.Drawing.Size(301, 73)
        Me.tabpageCard.TabIndex = 1
        Me.tabpageCard.Text = "By Card Payment"
        Me.tabpageCard.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(52, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 21)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Rs."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCPAmount
        '
        Me.txtCPAmount.Location = New System.Drawing.Point(70, 29)
        Me.txtCPAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCPAmount.Name = "txtCPAmount"
        Me.txtCPAmount.Size = New System.Drawing.Size(52, 22)
        Me.txtCPAmount.TabIndex = 10
        Me.txtCPAmount.Text = "0"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(4, 32)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 14)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Amount:"
        '
        'txtCPInvoiceNo
        '
        Me.txtCPInvoiceNo.Location = New System.Drawing.Point(136, 5)
        Me.txtCPInvoiceNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCPInvoiceNo.Name = "txtCPInvoiceNo"
        Me.txtCPInvoiceNo.Size = New System.Drawing.Size(57, 22)
        Me.txtCPInvoiceNo.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 7)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(137, 14)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Credit/Debit Invoice No:"
        '
        'tabpageCuLoan
        '
        Me.tabpageCuLoan.Controls.Add(Me.Label35)
        Me.tabpageCuLoan.Controls.Add(Me.txtCuLNo)
        Me.tabpageCuLoan.Controls.Add(Me.Label33)
        Me.tabpageCuLoan.Controls.Add(Me.txtCuLAmount)
        Me.tabpageCuLoan.Controls.Add(Me.Label30)
        Me.tabpageCuLoan.Location = New System.Drawing.Point(4, 23)
        Me.tabpageCuLoan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageCuLoan.Name = "tabpageCuLoan"
        Me.tabpageCuLoan.Size = New System.Drawing.Size(301, 73)
        Me.tabpageCuLoan.TabIndex = 2
        Me.tabpageCuLoan.Text = "By Customer Loan"
        Me.tabpageCuLoan.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(56, 28)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(22, 21)
        Me.Label35.TabIndex = 79
        Me.Label35.Text = "Rs."
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuLNo
        '
        Me.txtCuLNo.Enabled = False
        Me.txtCuLNo.Location = New System.Drawing.Point(104, 4)
        Me.txtCuLNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCuLNo.Name = "txtCuLNo"
        Me.txtCuLNo.Size = New System.Drawing.Size(38, 22)
        Me.txtCuLNo.TabIndex = 14
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(5, 6)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(108, 14)
        Me.Label33.TabIndex = 13
        Me.Label33.Text = "Customer Loan No:"
        '
        'txtCuLAmount
        '
        Me.txtCuLAmount.Location = New System.Drawing.Point(79, 28)
        Me.txtCuLAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCuLAmount.Name = "txtCuLAmount"
        Me.txtCuLAmount.Size = New System.Drawing.Size(78, 22)
        Me.txtCuLAmount.TabIndex = 12
        Me.txtCuLAmount.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 31)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 14)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Amount:"
        '
        'cmdReceipt
        '
        Me.cmdReceipt.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdReceipt.Location = New System.Drawing.Point(5, 195)
        Me.cmdReceipt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(106, 50)
        Me.cmdReceipt.TabIndex = 106
        Me.cmdReceipt.Text = "බිල්පතක් අවශ්‍යයි."
        Me.cmdReceipt.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label26.Location = New System.Drawing.Point(4, 69)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(78, 17)
        Me.Label26.TabIndex = 86
        Me.Label26.Text = "Grand Total:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(78, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Rs."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ControlPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpPaymentInfo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ControlPopUp"
        Me.Size = New System.Drawing.Size(334, 347)
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

    End Sub
    Friend WithEvents grpPaymentInfo As GroupBox
    Friend WithEvents txtRepAdvanced As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents chkCashDrawer As CheckBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents cmdNotReceipt As Button
    Friend WithEvents tabcontrolPayment As TabControl
    Friend WithEvents tabpageCash As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCAmount As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtCBalance As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCReceived As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tabpageCard As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCPAmount As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtCPInvoiceNo As MaskedTextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents tabpageCuLoan As TabPage
    Friend WithEvents Label35 As Label
    Friend WithEvents txtCuLNo As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtCuLAmount As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents cmdReceipt As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label10 As Label
End Class
