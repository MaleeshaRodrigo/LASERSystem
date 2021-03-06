Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmSearch
    Dim x, y As String
    Public Property Key As String
    Private grdsubsearch1 As New DataGridView
    Private grdsubsearch2 As New DataGridView
    Private dtpDate As New DateTimePicker

    Private Sub txtTSSearch_TextChanged(sender As Object, e As EventArgs) Handles txtTSSearch.TextChanged
        'Call cmdTSSearch_Click(sender, e)
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        MenuStrip1.Items.Add(mnustrpMENU)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Me.AcceptButton = cmdTSSearch
        Select Case Me.Tag
            Case "Sale"
                cmbFilter.Items.Add("Sale No")
                cmbFilter.Items.Add("Sale Date")
                cmbFilter.Items.Add("Customer No")
                cmbFilter.Items.Add("Customer Name")
                cmbFilter.Items.Add("Customer Telephone No")
                cmbFilter.Items.Add("SubTotal")
                cmbFilter.Items.Add("Less")
                cmbFilter.Items.Add("Due")
                cmbFilter.Items.Add("Received")
                cmbFilter.Items.Add("Balance")
                cmbFilter.Items.Add("Card Payment Invoice No")
                cmbFilter.Items.Add("Card Payment Amount")
                cmbFilter.Items.Add("Customer Loan No")
                cmbFilter.Items.Add("Customer Loan Amount")
                cmbFilter.Items.Add("Remarks")
                cmbFilter.Items.Add("All")
                cmbFilter.Text = "All"
            Case "Supply"
                cmbFilter.Items.Add("Supply No")
                cmbFilter.Items.Add("Supply Date")
                cmbFilter.Items.Add("Supplier No")
                cmbFilter.Items.Add("Supplier Name")
                cmbFilter.Items.Add("Status")
                cmbFilter.Items.Add("Paid Date")
                cmbFilter.Items.Add("Remarks")
                cmbFilter.Items.Add("All")
                cmbFilter.Text = "All"
            Case "Receive"
                cmbFilter.Items.Add("Repair No")
                cmbFilter.Items.Add("Received Date")
                cmbFilter.Items.Add("Customer Name")
                cmbFilter.Items.Add("Customer Telephone No 1")
                cmbFilter.Items.Add("Customer Telephone No 2")
                cmbFilter.Items.Add("Customer Telephone No 3")
                cmbFilter.Items.Add("Product Category")
                cmbFilter.Items.Add("Product Name")
                cmbFilter.Items.Add("Product Model No")
                cmbFilter.Items.Add("Product Serial No")
                cmbFilter.Items.Add("Problem")
                cmbFilter.Items.Add("Remarks for Customer")
                cmbFilter.Items.Add("Status")
                cmbFilter.Items.Add("Technician Name")
                cmbFilter.Items.Add("Remarks for Technician")
                cmbFilter.Items.Add("Repaired Date")
                cmbFilter.Items.Add("Paid Repair Charge")
                cmbFilter.Items.Add("All")
            Case "Deliver"
                cmbFilter.Items.Add("Deliver No")
                cmbFilter.Items.Add("Delivered Date")
                cmbFilter.Items.Add("Customer Name")
                cmbFilter.Items.Add("Customer Telephone No 1")
                cmbFilter.Items.Add("Customer Telephone No 2")
                cmbFilter.Items.Add("Customer Telephone No 3")
                cmbFilter.Items.Add("Grand Total")
                cmbFilter.Items.Add("Received")
                cmbFilter.Items.Add("Balance")
                cmbFilter.Items.Add("Cash Amount")
                cmbFilter.Items.Add("Card Payment Invoice No")
                cmbFilter.Items.Add("Card Payment Amount")
                cmbFilter.Items.Add("Customer Loan No")
                cmbFilter.Items.Add("Customer Loan Amount")
                cmbFilter.Items.Add("Remarks")
                cmbFilter.Items.Add("All")
                cmbFilter.Text = "All"
                grdsubsearch1.Left = grdSearch.Left
                grdsubsearch1.Width = grdSearch.Width / 2
                grdsubsearch2.Left = grdsubsearch1.Left + grdsubsearch1.Width + 5
                grdsubsearch2.Width = grdSearch.Width - grdsubsearch1.Left - grdsubsearch1.Width + 5
                grdSearch.Height = Me.Height / 2
                grdsubsearch1.Top = grdSearch.Top + grdSearch.Height + 5
                grdsubsearch2.Top = grdsubsearch1.Top
                grdsubsearch1.Height = Me.Height - grdsubsearch1.Top - 50
                grdsubsearch2.Height = Me.Height - grdsubsearch2.Top - 50
                grdsubsearch1.AllowUserToAddRows = False
                grdsubsearch1.AllowUserToDeleteRows = False
                grdsubsearch1.EditMode = DataGridViewEditMode.EditProgrammatically
                grdsubsearch2.AllowUserToAddRows = False
                grdsubsearch2.AllowUserToDeleteRows = False
                grdsubsearch2.EditMode = DataGridViewEditMode.EditProgrammatically
                Me.Controls.Add(grdsubsearch1)
                Me.Controls.Add(grdsubsearch2)
            Case "Repair", "DeliverRepair"
                cmbFilter.Items.Add("Repair No")
                cmbFilter.Items.Add("Received Date")
                cmbFilter.Items.Add("Customer Name")
                cmbFilter.Items.Add("Customer Telephone No 1")
                cmbFilter.Items.Add("Customer Telephone No 2")
                cmbFilter.Items.Add("Customer Telephone No 3")
                cmbFilter.Items.Add("Product Category")
                cmbFilter.Items.Add("Product Name")
                cmbFilter.Items.Add("Product Model No")
                cmbFilter.Items.Add("Product Serial No")
                cmbFilter.Items.Add("Problem")
                cmbFilter.Items.Add("Location")
                cmbFilter.Items.Add("Remarks by Customer")
                cmbFilter.Items.Add("Status")
                cmbFilter.Items.Add("Technician Name")
                cmbFilter.Items.Add("Remarks by Technician")
                cmbFilter.Items.Add("Repaired Date")
                cmbFilter.Items.Add("Repair Charge")
                cmbFilter.Items.Add("Delivered Date")
                cmbFilter.Items.Add("Paid Repair Charge")
                cmbFilter.Items.Add("All")
            Case "ReRepair", "DeliverReRepair"
                cmbFilter.Items.Add("Re-Repair No")
                cmbFilter.Items.Add("Repair No")
                cmbFilter.Items.Add("Received Date")
                cmbFilter.Items.Add("Customer Name")
                cmbFilter.Items.Add("Customer Telephone No 1")
                cmbFilter.Items.Add("Customer Telephone No 2")
                cmbFilter.Items.Add("Customer Telephone No 3")
                cmbFilter.Items.Add("Product Category")
                cmbFilter.Items.Add("Product Name")
                cmbFilter.Items.Add("Product Model No")
                cmbFilter.Items.Add("Product Serial No")
                cmbFilter.Items.Add("Problem")
                cmbFilter.Items.Add("Remarks for Customer")
                cmbFilter.Items.Add("Status")
                cmbFilter.Items.Add("Technician Name")
                cmbFilter.Items.Add("Remarks for Technician")
                cmbFilter.Items.Add("Repaired Date")
                cmbFilter.Items.Add("Repair Charge")
                cmbFilter.Items.Add("Delivered Date")
                cmbFilter.Items.Add("Paid Repair Charge")
                cmbFilter.Items.Add("All")
        End Select
        cmbFilter.SelectedIndex = Int(cmbFilter.Items.Count) - 1
        txtTSSearch.Text = ""
        x = ""
        Me.Text = "LASER System - Search Management [Prepairing Sheet....]"
        grdSearch.Columns.Clear()
        Select Case Me.Tag
            Case "Sale"
                grdSearch.Columns.Add("SaNo", "Sale No")
                grdSearch.Columns.Add("SaDate", "Sale Date")
                grdSearch.Columns.Add("CuNo", "Customer No")
                grdSearch.Columns.Add("CuName", "Customer Name")
                grdSearch.Columns.Add("CuTelNo1", "Customer Telephone No 1")
                grdSearch.Columns.Add("CuTelNo2", "Customer Telephone No 2")
                grdSearch.Columns.Add("CuTelNo3", "Customer Telephone No 3")
                grdSearch.Columns.Add("SubTotal", "Sub Total")
                grdSearch.Columns.Add("Less", "Less")
                grdSearch.Columns.Add("Due", "Due")
                grdSearch.Columns.Add("Received", "Received")
                grdSearch.Columns.Add("Balance", "Balance")
                grdSearch.Columns.Add("CashAmount", "Cash Amount")
                grdSearch.Columns.Add("CPInvoiceNo", "Card Payment Invoice No")
                grdSearch.Columns.Add("CPAmount", "Card Payment Amount")
                grdSearch.Columns.Add("CuLNo", "Customer Loan No")
                grdSearch.Columns.Add("CuLAmount", "Customer Loan Amount")
                grdSearch.Columns.Add("Remarks", "Remarks")
            Case "Supply"
                grdSearch.Columns.Add("SupNo", "Supply No")
                grdSearch.Columns.Add("SupDate", "Supply Date")
                grdSearch.Columns.Add("SuNo", "Supplier No")
                grdSearch.Columns.Add("SuName", "Supplier Name")
                grdSearch.Columns.Add("SupStatus", "Status")
                grdSearch.Columns.Add("SupPaidDate", "Paid Date")
                grdSearch.Columns.Add("SupRemarks", "Remarks")
            Case "Deliver"
                grdSearch.Columns.Add("DNo", "Deliver No")
                'If MdifrmMain.tslblUserType.Text <> "Admin" Then grdSearch.Columns.Item("DNo").Visible = False
                grdSearch.Columns.Add("DDate", "Delivered Date")
                grdSearch.Columns.Add("CuName", "Customer Name")
                grdSearch.Columns.Add("CuTelNo1", "Customer Telephone No 1")
                grdSearch.Columns.Add("CuTelNo2", "Customer Telephone No 2")
                grdSearch.Columns.Add("CuTelNo3", "Customer Telephone No 3")
                grdSearch.Columns.Add("DGrandTotal", "Grand Total")
                grdSearch.Columns.Add("CReceived", "Received")
                grdSearch.Columns.Add("CBalance", "Balance")
                grdSearch.Columns.Add("CAmount", "Cash Amount")
                grdSearch.Columns.Add("CPInvoiceNo", "Card Payment Invoice No")
                grdSearch.Columns.Add("CPAmount", "Card Payment Amount")
                grdSearch.Columns.Add("CuLNo", "Customer Loan No")
                grdSearch.Columns.Add("CuLAmount", "Customer Loan Amount")
                grdSearch.Columns.Add("DRemarks", "Remarks")

                grdsubsearch1.Columns.Clear()
                grdsubsearch1.Columns.Add("RepNo", "Repair No")
                grdsubsearch1.Columns.Add("PCategory", "Product Category")
                grdsubsearch1.Columns.Add("PName", "Product Name")
                grdsubsearch1.Columns.Add("Qty", "Qty")
                grdsubsearch1.Columns.Add("PaidCharge", "Paid Charge")
                grdsubsearch1.Columns.Add("TName", "Technician Name")
                grdsubsearch1.Columns.Add("Status", "Status")
                grdsubsearch1.Rows.Clear()
                grdsubsearch1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                grdsubsearch2.Columns.Clear()
                grdsubsearch2.Columns.Add("REREpNo", "RE-Repair No")
                grdsubsearch2.Columns.Add("RepNo", "Repair No")
                grdsubsearch2.Columns.Add("PCategory", "Product Category")
                grdsubsearch2.Columns.Add("PName", "Product Name")
                grdsubsearch2.Columns.Add("Qty", "Qty")
                grdsubsearch2.Columns.Add("PaidCharge", "Paid Charge")
                grdsubsearch2.Columns.Add("TName", "Technician Name")
                grdsubsearch2.Columns.Add("Status", "Status")
                grdsubsearch1.Rows.Clear()
                grdsubsearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Case "Receive", "DeliverRepair"
                grdSearch.Columns.Add("RepNo", "Repair No")
                grdSearch.Columns.Add("RDate", "Received Date")
                grdSearch.Columns.Add("CuName", "Customer Name")
                grdSearch.Columns.Add("CuTelNo1", "Customer Telephone No 1")
                grdSearch.Columns.Add("CuTelNo2", "Customer Telephone No 2")
                grdSearch.Columns.Add("CuTelNo3", "Customer Telephone No 3")
                grdSearch.Columns.Add("PCategory", "Product Category")
                grdSearch.Columns.Add("PName", "Product Name")
                grdSearch.Columns.Add("PModelNo", "Product Model No")
                grdSearch.Columns.Add("PSerialNo", "Product Serial No")
                grdSearch.Columns.Add("Problem", "Problem")
                grdSearch.Columns.Add("Qty", "Qty")
                grdSearch.Columns.Add("RepRemarks1", "Remarks for Customer")
                grdSearch.Columns.Add("Status", "Status")
                grdSearch.Columns.Add("TName", "Technician Name")
                grdSearch.Columns.Add("RepRemarks2", "Remarks for Technician")
                grdSearch.Columns.Add("RepDate", "Repaired Date")
                grdSearch.Columns.Add("RepCharge", "Repair Charge")
                grdSearch.Columns.Add("DDate", "Delivered Date")
                grdSearch.Columns.Add("PaidCharge", "Paid Repair Charge")
            Case "Repair"
                grdSearch.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                grdSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
                grdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                grdSearch.Columns.Add("RepNo", "Repair No")
                grdSearch.Columns.Item(0).Frozen = True
                grdSearch.Columns.Add("RDate", "Received Date")
                grdSearch.Columns.Add("CuName", "Customer Name")
                grdSearch.Columns.Add("CuTelNo1", "Customer Telephone No 1")
                grdSearch.Columns.Add("CuTelNo2", "Customer Telephone No 2")
                grdSearch.Columns.Add("CuTelNo3", "Customer Telephone No 3")
                grdSearch.Columns.Add("PCategory", "Product Category")
                grdSearch.Columns.Add("PName", "Product Name")
                grdSearch.Columns.Add("PModelNo", "Product Model No")
                grdSearch.Columns.Add("PSerialNo", "Product Serial No")
                grdSearch.Columns.Add("Problem", "Problem")
                grdSearch.Columns.Add("Location", "Location")
                grdSearch.Columns.Add("Qty", "Qty")
                grdSearch.Columns.Add("RepRemarks1", "Remarks by Customer")
                Dim grdSearchStatus As New DataGridViewComboBoxColumn   '-----------Status Combo Box
                grdSearchStatus.Name = "Status"
                grdSearchStatus.HeaderText = "Status"
                grdSearchStatus.Items.Clear()
                grdSearchStatus.Items.Add("Received")
                grdSearchStatus.Items.Add("Hand Over to Technician")
                grdSearchStatus.Items.Add("Repairing")
                grdSearchStatus.Items.Add("Repaired Not Delivered")
                grdSearchStatus.Items.Add("Repaired Delivered")
                grdSearchStatus.Items.Add("Returned Not Delivered")
                grdSearchStatus.Items.Add("Returned Delivered")
                grdSearchStatus.Items.Add("Canceled")
                grdSearch.Columns.Add(grdSearchStatus)
                Dim grdSearchTName As New DataGridViewComboBoxColumn    '-----------TName Combo Box
                grdSearchTName.Name = "TName"
                grdSearchTName.HeaderText = "Technician Name"
                CMD = New OleDb.OleDbCommand("Select TName from Technician group by TName;", CNN)
                DR = CMD.ExecuteReader()
                grdSearchTName.Items.Clear()
                grdSearchTName.Items.Add("")
                While DR.Read
                    grdSearchTName.Items.Add(DR("TName").ToString)
                End While
                grdSearch.Columns.Add(grdSearchTName)
                grdSearch.Columns.Add("RepRemarks2", "Remarks by Technician")
                grdSearch.Columns.Add("RepDate", "Repaired Date")
                grdSearch.Columns.Add("Charge", "Repair Charge")
                grdSearch.Columns.Add("DDate", "Delivered Date")
                grdSearch.Columns.Add("PaidCharge", "Paid Repair Charge")
                grdSearch.Columns.Item("RepNo").ReadOnly = True
                grdSearch.Columns.Item("RDate").ReadOnly = True
                grdSearch.Columns.Item("CuName").ReadOnly = True
                grdSearch.Columns.Item("CuTelNo1").ReadOnly = True
                grdSearch.Columns.Item("CuTelNo2").ReadOnly = True
                grdSearch.Columns.Item("CuTelNo3").ReadOnly = True
                grdSearch.Columns.Item("PCategory").ReadOnly = True
                grdSearch.Columns.Item("PName").ReadOnly = True
                grdSearch.Columns.Item("PModelNo").ReadOnly = True
                grdSearch.Columns.Item("Qty").ReadOnly = True
                grdSearch.Columns.Item("DDate").ReadOnly = True
                grdSearch.Columns.Item("PaidCharge").ReadOnly = True
                grdSearch.Columns.Item("RepRemarks1").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                grdSearch.Columns.Item("RepRemarks2").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                grdSearch.Columns.Item("Problem").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Case "ReRepair"
                grdSearch.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                grdSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
                grdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                grdSearch.Columns.Add("ReRepNo", "Re-Repair No")
                grdSearch.Columns.Add("RepNo", "Repair No")
                grdSearch.Columns.Item(1).Frozen = True
                grdSearch.Columns.Add("RDate", "Receive Date")
                grdSearch.Columns.Add("CuName", "Customer Name")
                grdSearch.Columns.Add("CuTelNo1", "Customer Telephone No 1")
                grdSearch.Columns.Add("CuTelNo2", "Customer Telephone No 2")
                grdSearch.Columns.Add("CuTelNo3", "Customer Telephone No 3")
                grdSearch.Columns.Add("PCategory", "Product Category")
                grdSearch.Columns.Add("PName", "Product Name")
                grdSearch.Columns.Add("PModelNo", "Product Model No")
                grdSearch.Columns.Add("PSerialNo", "Product Serial No")
                grdSearch.Columns.Add("Problem", "Problem")
                grdSearch.Columns.Add("Qty", "Qty")
                grdSearch.Columns.Add("RepRemarks1", "Remarks for Customer")
                Dim grdSearchStatus As New DataGridViewComboBoxColumn   '-----------Status Combo Box
                grdSearchStatus.Name = "Status"
                grdSearchStatus.HeaderText = "Status"
                grdSearchStatus.Items.Clear()
                grdSearchStatus.Items.Add("Received")
                grdSearchStatus.Items.Add("Hand Over to Technician")
                grdSearchStatus.Items.Add("Repairing")
                grdSearchStatus.Items.Add("Repaired Not Delivered")
                grdSearchStatus.Items.Add("Repaired Delivered")
                grdSearchStatus.Items.Add("Returned Not Delivered")
                grdSearchStatus.Items.Add("Returned Delivered")
                grdSearchStatus.Items.Add("Canceled")
                grdSearch.Columns.Add(grdSearchStatus)
                Dim grdSearchTName As New DataGridViewComboBoxColumn    '-----------TName Combo Box
                grdSearchTName.Name = "TName"
                grdSearchTName.HeaderText = "Technician Name"
                CMD = New OleDb.OleDbCommand("Select TName from Technician group by TName;", CNN)
                DR = CMD.ExecuteReader()
                grdSearchTName.Items.Clear()
                grdSearchTName.Items.Add("")
                While DR.Read
                    grdSearchTName.Items.Add(DR("TName").ToString)
                End While
                grdSearch.Columns.Add(grdSearchTName)
                grdSearch.Columns.Add("RepRemarks2", "Remarks for Technician")
                grdSearch.Columns.Add("RepDate", "Repaired Date")
                grdSearch.Columns.Add("RepCharge", "Repair Charge")
                grdSearch.Columns.Add("DNo", "Deliver No")
                grdSearch.Columns.Add("DDate", "Delivered Date")
                grdSearch.Columns.Add("PaidCharge", "Paid Repair Charge")
                grdSearch.Columns.Item("ReRepNo").ReadOnly = True
                grdSearch.Columns.Item("RepNo").ReadOnly = True
                grdSearch.Columns.Item("RDate").ReadOnly = True
                grdSearch.Columns.Item("CuName").ReadOnly = True
                grdSearch.Columns.Item("CuTelNo1").ReadOnly = True
                grdSearch.Columns.Item("CuTelNo2").ReadOnly = True
                grdSearch.Columns.Item("CuTelNo3").ReadOnly = True
                grdSearch.Columns.Item("PCategory").ReadOnly = True
                grdSearch.Columns.Item("PName").ReadOnly = True
                grdSearch.Columns.Item("PModelNo").ReadOnly = True
                grdSearch.Columns.Item("Qty").ReadOnly = True
                grdSearch.Columns.Item("DDate").ReadOnly = True
                grdSearch.Columns.Item("PaidCharge").ReadOnly = True
                grdSearch.Columns.Item("RepRemarks1").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                grdSearch.Columns.Item("RepRemarks2").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                grdSearch.Columns.Item("Problem").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Case "DeliverReRepair"
                grdSearch.Columns.Add("ReRepNo", "Re-Repair No")
                grdSearch.Columns.Add("RepNo", "Repair No")
                grdSearch.Columns.Add("RDate", "Receive Date")
                grdSearch.Columns.Add("CuName", "Customer Name")
                grdSearch.Columns.Add("CuTelNo1", "Customer Telephone No 1")
                grdSearch.Columns.Add("CuTelNo2", "Customer Telephone No 2")
                grdSearch.Columns.Add("CuTelNo3", "Customer Telephone No 3")
                grdSearch.Columns.Add("PCategory", "Product Category")
                grdSearch.Columns.Add("PName", "Product Name")
                grdSearch.Columns.Add("PModelNo", "Product Model No")
                grdSearch.Columns.Add("PSerialNo", "Product Serial No")
                grdSearch.Columns.Add("Problem", "Problem")
                grdSearch.Columns.Add("Qty", "Qty")
                grdSearch.Columns.Add("RepRemarks1", "Remarks for Customer")
                grdSearch.Columns.Add("Status", "Status")
                grdSearch.Columns.Add("TName", "Technician Name")
                grdSearch.Columns.Add("RepRemarks2", "Remarks for Technician")
                grdSearch.Columns.Add("RepDate", "Repaired Date")
                grdSearch.Columns.Add("RepCharge", "Repair Charge")
                grdSearch.Columns.Add("DNo", "Deliver No")
                grdSearch.Columns.Add("DDate", "Delivered Date")
                grdSearch.Columns.Add("PaidCharge", "Paid Repair Charge")
        End Select
        CmdTSSearch_Click(sender, e)
        txtTSSearch.Focus()
    End Sub

    Private Sub CmdTSSearch_Click(sender As Object, e As EventArgs) Handles cmdTSSearch.Click
        If (bgwSearch.IsBusy) = True Then
            bgwSearch.CancelAsync()
            cmdTSSearch.Tag = "Restart"
            Exit Sub
        End If
        If txtTSSearch.Text <> "" Then
            If (txtTSSearch.Text.Length = 10) AndAlso (IsNumeric(txtTSSearch.Text)) AndAlso
                (txtTSSearch.Text.ToString.Substring(0, 3) = "076" Or "071" Or "011" Or "075" Or "077" Or "070" Or "072" Or "078" Or "074") Then
                txtTSSearch.Text = txtTSSearch.Text.ToString.Substring(0, 3) & " " & txtTSSearch.Text.ToString.Substring(3, 1) & " " &
                   txtTSSearch.Text.ToString.Substring(4, 3) & " " & txtTSSearch.Text.ToString.Substring(7, 3)
            End If
            If _SearchPanelsAddedCount >= 1 Then
                If cmdAND.FillColor = Color.DodgerBlue Then
                    CreateSearchPanel(" AND ")
                Else
                    CreateSearchPanel(" OR ")
                End If
            End If
            CreateSearchPanel(cmbFilter.Text + ":" + txtTSSearch.Text)
        End If
        cmdLeftBracket.FillColor = Color.DarkBlue
        ProgressBar.Value = 0
        ProgressBar.Visible = True
        grdSearch.ScrollBars = ScrollBars.None
        ManageFilter()
        Me.Text = "LASER System - Search Management [Setting Data....]"
        bgwSearch.RunWorkerAsync()
        txtTSSearch.Text = ""
        txtTSSearch.Focus()
    End Sub

    Private Sub ManageFilter()
        Dim txtSearch() As Label = Me.Controls.OfType(Of Label).Reverse.ToArray
        Dim tmptxt, Filter, Search As String
        Dim tmplst() As String
        Dim Count As Integer = 0
        x = ""
        y = ""
        Me.Text = "LASER System - Search Management [Please Wait....]"
        ProgressBar.Value = 0
        For i As Integer = 1 To _SearchPanelsAddedCount
            For Each c As Control In flpSearch.Controls.Find("txtSearch" & i.ToString, True)
                If TypeOf c IsNot Label Then Exit For
                If c.Text = " AND " Then
                    x += " AND "
                    Exit For
                ElseIf c.Text = " OR " Then
                    x += " OR "
                    Exit For
                ElseIf c.Text = " ( " Then
                    x += " ( "
                    Exit For
                ElseIf c.Text = " ) " Then
                    x += " ) "
                    Exit For
                End If
                tmptxt = c.Text
                tmplst = tmptxt.Split(":")
                Filter = tmplst(0)
                Search = tmplst(1)
                Select Case Me.Tag
                    Case "Sale"
                        Select Case Filter
                            Case "Sale No"
                                x += " and Sale.SaNo Like '%" & Search & "%'"
                            Case "Sale Date"
                                x += " and Sale.SaDate like '%" & Search & "%'"
                            Case "Customer Name"
                                x += " and Customer.CuName like '%" & Search & "%'"
                            Case "Customer Telephone No"
                                x += " and Customer.CuTelNo like '%" & Search & "%'"
                            Case "SubTotal"
                                x += " and Sale.SaSubTotal like '%" & Search & "%'"
                            Case "Less"
                                x += " and Sale.SaLess like '%" & Search & "%'"
                            Case "Due"
                                x += " and Sale.SaDue like '%" & Search & "%'"
                            Case "Received"
                                x += " and Sale.CReceived like '%" & Search & "%'"
                            Case "Balance"
                                x += " and Sale.CBalance like '%" & Search & "%'"
                            Case "Card Payment Invoice No"
                                x += " and Sale.CPInvoiceNo like '%" & Search & "%'"
                            Case "Card Payment Amount"
                                x += " and Sale.CPAmount like '%" & Search & "%'"
                            Case "Customer Loan No"
                                x += " and Sale.CuLNo like '%" & Search & "%'"
                            Case "Customer Loan Amount"
                                x += " and Sale.CuLAmount like '%" & Search & "%'"
                            Case "Remarks"
                                x += " and Sale.SaRemarks like '%" & Search & "%'"
                            Case "All"
                                x += " and (SaNo like '%" & Search & "%' or SaDate like '%" & Search & "%' or Sale.CuNo like '%" & Search & "%' or CuName like '%" & Search & "%' or CuTelNo1 like '%" & Search & "%' or CuTelNo2 like '%" & Search & "%' or CuTelNo3 like '%" & Search & "%' or SaSubTotal like '%" & Search & "%' or SaLess like '%" & Search & "%' or  SaDue like '%" & Search & "%' or CReceived like '%" & Search & "%' or  CBalance like '%" & Search & "%' or CPInvoiceNo like '%" & Search & "%' or CPAmount like '%" & Search & "%' or CuLNo like '%" & Search & "%' or CuLAmount like '%" & Search & "%' or SaRemarks like '%" & Search & "%')"
                        End Select
                    Case "Supply"
                        If x = "" Then
                            x = " Where "
                        End If
                        Select Case Filter
                            Case "Supply No"
                                x += " Supply.SupNo Like '%" & Search & "%'"
                            Case "Supply Date"
                                x += " Supply.SupDate like '%" & Search & "%'"
                            Case "Supplier Name"
                                x += " Supplier.SuName like '%" & Search & "%'"
                            Case "Status"
                                x += " SupStatus like '%" & Search & "%'"
                            Case "Paid Date"
                                x += " SupPaidDate like '%" & Search & "%'"
                            Case "Remarks"
                                x += " SupRemarks like '%" & Search & "%'"
                            Case "All"
                                x += " (Supply.SupNo like '%" & Search & "%' or SupDate like '%" & Search & "%' or Supplier.SuNo like '%" & Search & "%' or SuName like '%" & Search & "%' or SupRemarks like '%" & Search & "%'  or SupPaidDate like '%" & Search & "%' or SupStatus like '%" & Search & "%')"
                        End Select
                    Case "Deliver"
                        Select Case Filter
                            Case "Deliver No"
                                x += " and DNo Like '%" & Search & "%'"
                            Case "Delivered Date"
                                x += " and DDate like '%" & Search & "%'"
                            Case "Customer Name"
                                x += " and CuName like '%" & Search & "%'"
                            Case "Customer Telephone No 1"
                                x += " and CuTelNo1 like '%" & Search & "%'"
                            Case "Customer Telephone No 2"
                                x += " and CuTelNo2 like '%" & Search & "%'"
                            Case "Customer Telephone No 3"
                                x += " and CuTelNo3 like '%" & Search & "%'"
                            Case "Grand Total"
                                x += " and DGrandTotal like '%" & Search & "%'"
                            Case "Cash Amount"
                                x += " and CAmount like '%" & Search & "%'"
                            Case "Received"
                                x += " and CReceived like '%" & Search & "%'"
                            Case "Balance"
                                x += " and CBalance like '%" & Search & "%'"
                            Case "Card Payment Invoice No"
                                x += " and CPInvoiceNo like '%" & Search & "%'"
                            Case "Card Payment Amount"
                                x += " and CPAmount like '%" & Search & "%'"
                            Case "Customer Loan No"
                                x += " and CuLNo like '%" & Search & "%'"
                            Case "Customer Loan Amount"
                                x += " and CuLAmount like '%" & Search & "%'"
                            Case "Remarks"
                                x += " and DRemarks like '%" & Search & "%'"
                            Case "All"
                                x += " and (DNo like '%" & Search & "%' or DDate like '%" & Search & "%' or CuName like '%" & Search & "%' or CuTelNo1 like '%" &
                                        Search & "%' or CuTelNo2 like '%" & Search & "%' or CuTelNo3 like '%" & Search & "%' or DGrandTotal like '%" & Search &
                                        "%' or  CAmount like '%" & Search & "%' or CReceived like '%" &
                                        Search & "%' or  CBalance like '%" & Search & "%' or CPInvoiceNo like '%" & Search & "%' or CPAmount like '%" & Search &
                                        "%' or CuLNo like '%" & Search & "%' or CuLAmount like '%" & Search & "%' or DRemarks like '%" & Search & "%')"
                        End Select
                    Case "Receive", "DeliverRepair"
                        Select Case Filter
                            Case "Repair No"
                                x += " and REP.RepNo like '%" & Search & "%'"
                            Case "Received Date"
                                x += " and RDate like '%" & Search & "%'"
                            Case "Customer Name"
                                x += " and CuName like '%" & Search & "%'"
                            Case "Customer Telephone No 1"
                                x += " and CuTelNo1 like '%" & Search & "%'"
                            Case "Customer Telephone No 2"
                                x += " and CuTelNo2 like '%" & Search & "%'"
                            Case "Customer Telephone No 3"
                                x += " and CuTelNo3 like '%" & Search & "%'"
                            Case "Product Category"
                                x += " and PCategory like '%" & Search & "%'"
                            Case "Product Name"
                                x += " and PName like '%" & Search & "%'"
                            Case "Product Model No"
                                x += " and PModelNo like '%" & Search & "%'"
                            Case "Product Serial No"
                                x += " and PSerialNo like '%" & Search & "%'"
                            Case "Problem"
                                x += " and Problem like '%" & Search & "%'"
                            Case "Paid Repair Charge"
                                x += " and REP.PaidPrice like '%" & Search & "%'"
                            Case "Technician Name"
                                x += " and TName like '%" & Search & "%'"
                            Case "Status"
                                x += " and Status like '%" & Search & "%'"
                            Case "Repaired Date"
                                x += " and RepDate like '%" & Search & "%'"
                            Case "Remarks for Customer"
                                x += " and RepRemarks1 like '%" & Search & "%'"
                            Case "Remarks for Technician"
                                x += " and RepRemarks2 like '%" & Search & "%'"
                            Case "All"
                                x += " and (REP.RepNo like '%" & Search & "%' or R.RNo like '%" & Search & "%' or RDate like '%" & Search & "%' " &
                                        "or CU.CuNo like '%" & Search & "%' or CuName like '%" & Search & "%' or CuTelNo1 like '%" & Search & "%' " &
                                        "or CuTelNo2 like '%" & Search & "%' or CuTelNo3 like '%" & Search & "%' or P.PNo like '%" & Search & "%' " &
                                        "or PCategory like '%" & Search & "%' or PName like '%" & Search & "%' or PModelNo like '%" & Search & "%' " &
                                        "or PSerialNo like '%" & Search & "%' or Problem like '%" & Search & "%' or PaidPrice like '%" & Search & "%' or T.TNo like '%" & Search & "%' or TName like '%" & Search & "%' " &
                                        "or Status like '%" & Search & "%' or RepDate like '%" & Search & "%' or RepRemarks1 like '%" & Search & "%' or RepRemarks2 like '%" & Search & "%')"
                        End Select
                    Case "Repair"
                        If x = "" Then
                            x = " Where "
                        End If
                        Select Case Filter
                            Case "Repair No"
                                Count += 1
                                x += " REP.RepNo =" & Search
                                If y <> "" Then y += ","
                                y += "IIF(REP.RepNo=" & Search & "," & Count
                            Case "Received Date"
                                x += " R.RDate like '%" & Search & "%'"
                            Case "Customer Name"
                                x += " CU.CuName like '%" & Search & "%'"
                            Case "Customer Telephone No 1"
                                x += " CU.CuTelNo1 like '%" & Search & "%'"
                            Case "Customer Telephone No 2"
                                x += " CU.CuTelNo2 like '%" & Search & "%'"
                            Case "Customer Telephone No 3"
                                x += " CU.CuTelNo3 like '%" & Search & "%'"
                            Case "Product Category"
                                x += " P.PCategory like '%" & Search & "%'"
                            Case "Product Name"
                                x += " P.PName like '%" & Search & "%'"
                            Case "Product Model No"
                                x += " P.PModelNo like '%" & Search & "%'"
                            Case "Product Serial No"
                                x += " REP.PSerialNo like '%" & Search & "%'"
                            Case "Problem"
                                x += " REP.Problem like '%" & Search & "%'"
                            Case "Location"
                                x += " REP.Location like '%" & Search & "%'"
                            Case "Remarks by Customer"
                                Dim CMDSearch2 As New OleDb.OleDbCommand
                                Dim DRSearch2 As OleDbDataReader
                                CMDSearch2 = New OleDb.OleDbCommand("Select RepNo,Remarks from RepairRemarks1 Where Remarks like '%" & Search & "%' ", CNN)
                                DRSearch2 = CMDSearch2.ExecuteReader()
                                x += " RepNo IN ("
                                While DRSearch2.Read
                                    x += DRSearch2("RepNo").ToString + ","
                                End While
                                If DRSearch2.HasRows Then x = x.Remove(x.Length - 1, 1)
                                x += ") "
                                If DRSearch2 IsNot Nothing AndAlso DRSearch2.IsClosed = False Then
                                    DRSearch2.Close()
                                    CMDSearch2.Cancel()
                                End If
                            Case "Remarks by Technician"
                                Dim CMDSearch2 As New OleDb.OleDbCommand
                                Dim DRSearch2 As OleDbDataReader
                                CMDSearch2 = New OleDb.OleDbCommand("Select RepNo,Remarks from RepairRemarks2 Where Remarks like '%" & Search &
                                                                        "%' ", CNN)
                                DRSearch2 = CMDSearch2.ExecuteReader()
                                x += " RepNo IN ( "
                                While DRSearch2.Read
                                    x += DRSearch2("RepNo").ToString + ","
                                End While
                                If DRSearch2.HasRows Then x = x.Remove(x.Length - 1, 1)
                                x += ") "
                                If DRSearch2 IsNot Nothing AndAlso DRSearch2.IsClosed = False Then
                                    DRSearch2.Close()
                                    CMDSearch2.Cancel()
                                End If
                            Case "Repair Charge"
                                x += " REP.Charge like '%" & Search & "%'"
                            Case "Paid Repair Charge"
                                x += " REP.PaidPrice like '%" & Search & "%'"
                            Case "Technician Name"
                                x += " T.TName like '%" & Search & "%'"
                            Case "Status"
                                x += " REP.Status like '%" & Search & "%'"
                            Case "Repaired Date"
                                x += " REP.RepDate like '%" & Search & "%'"
                            Case "Delivered Date"
                                x += " D.DDate like '%" & Search & "%'"
                            Case "All"
                                x += " (REP.RepNo like '%" & Search & "%' or R.RDate like '%" & Search & "%' " &
                                        "or CU.CuName like '%" & Search & "%' or CU.CuTelNo1 like '%" & Search & "%' " &
                                        "or CU.CuTelNo2 like '%" & Search & "%' or CU.CuTelNo3 like '%" & Search & "%' " &
                                        "or P.PCategory like '%" & Search & "%' or P.PName like '%" & Search & "%' or P.PModelNo like '%" & Search & "%' " &
                                        "or REP.PSerialNo like '%" & Search & "%' or REP.Problem like '%" & Search & "%' or REP.Charge like '%" & Search & "%' " &
                                        "or REP.Location like '%" & Search & "%' or REP.PaidPrice Like '%" & Search & "%' or T.TName like '%" & Search & "%' " &
                                        "or REP.Status like '%" & Search & "%' or REP.RepDate like '%" & Search & "%' or D.DDate like '%" & Search & "%'"
                                Dim CMDSearch2 As New OleDb.OleDbCommand
                                Dim DRSearch2 As OleDbDataReader
                                CMDSearch2 = New OleDb.OleDbCommand("Select RepNo,Remarks from RepairRemarks1 Where Remarks like '%" & Search &
                                                                    "%' Union Select RepNo,Remarks from RepairRemarks2 Where Remarks like '%" & Search & "%'", CNN)
                                DRSearch2 = CMDSearch2.ExecuteReader()
                                If DRSearch2.HasRows Then
                                    x += " Or RepNo IN ("
                                    While DRSearch2.Read
                                        x += DRSearch2("RepNo").ToString + ","
                                    End While
                                    x = x.Remove(x.Length - 1, 1)
                                    x += ")"
                                    DRSearch2.Close()
                                    CMDSearch2.Cancel()
                                End If
                                x += ") "
                        End Select
                    Case "ReRepair"
                        If x = "" Then
                            x = " Where "
                        End If
                        Select Case Filter
                            Case "Re-Repair No"
                                x += " RET.RETNo like '%" & Search & "%'"
                            Case "Repair No"
                                x += " RET.RepNo like '%" & Search & "%'"
                            Case "Received Date"
                                x += " RDate like '%" & Search & "%'"
                            Case "Customer Name"
                                x += " CU.CuName like '%" & Search & "%'"
                            Case "Customer Telephone No 1"
                                x += " CU.CuTelNo1 like '%" & Search & "%'"
                            Case "Customer Telephone No 2"
                                x += " CU.CuTelNo2 like '%" & Search & "%'"
                            Case "Customer Telephone No 3"
                                x += " CU.CuTelNo3 like '%" & Search & "%'"
                            Case "Product Category"
                                x += " P.PCategory like '%" & Search & "%'"
                            Case "Product Name"
                                x += " P.PName like '%" & Search & "%'"
                            Case "Product Model No"
                                x += " P.PModelNo like '%" & Search & "%'"
                            Case "Product Serial No"
                                x += " PSerialNo like '%" & Search & "%'"
                            Case "Problem"
                                x += " Problem like '%" & Search & "%'"
                            Case "Repair Charge"
                                x += " Charge like '%" & Search & "%'"
                            Case "Paid Repair Charge"
                                x += " PaidPrice like '%" & Search & "%'"
                            Case "Technician Name"
                                x += " T.TName like '%" & Search & "%'"
                            Case "Status"
                                x += " RET.Status like '%" & Search & "%'"
                            Case "Repaired Date"
                                x += " RET.RetRepDate like '%" & Search & "%'"
                            Case "Delivered Date"
                                x += " D.DDate like '%" & Search & "%'"
                            Case "Remarks by Customer"
                                Dim CMDSearch2 As New OleDb.OleDbCommand
                                Dim DRSearch2 As OleDbDataReader
                                CMDSearch2 = New OleDb.OleDbCommand("Select RetNo,Remarks from RepairRemarks1 Where Remarks like '%" & Search & "%' ", CNN)
                                DRSearch2 = CMDSearch2.ExecuteReader()
                                x += " RetNo IN ("
                                While DRSearch2.Read
                                    x += DRSearch2("RetNo").ToString + ","
                                End While
                                If DRSearch2.HasRows Then x = x.Remove(x.Length - 1, 1)
                                x += ") "
                                If DRSearch2 IsNot Nothing AndAlso DRSearch2.IsClosed = False Then
                                    DRSearch2.Close()
                                    CMDSearch2.Cancel()
                                End If
                            Case "Remarks by Technician"
                                Dim CMDSearch2 As New OleDb.OleDbCommand
                                Dim DRSearch2 As OleDbDataReader
                                CMDSearch2 = New OleDb.OleDbCommand("Select RetNo,Remarks from RepairRemarks2 Where Remarks like '%" & Search &
                                                                        "%' ", CNN)
                                DRSearch2 = CMDSearch2.ExecuteReader()
                                x += " RetNo IN ( "
                                While DRSearch2.Read
                                    x += DRSearch2("RetNo").ToString + ","
                                End While
                                If DRSearch2.HasRows Then x = x.Remove(x.Length - 1, 1)
                                x += ") "
                                If DRSearch2 IsNot Nothing AndAlso DRSearch2.IsClosed = False Then
                                    DRSearch2.Close()
                                    CMDSearch2.Cancel()
                                End If
                            Case "All"
                                x += " (RET.RETNo like '%" & Search & "%' or RET.RepNo like '%" & Search & "%' or R.RDate like '%" & Search & "%' " &
                                        "or CU.CuName like '%" & Search & "%' or CU.CuTelNo1 like '%" & Search & "%' " &
                                        "or CU.CuTelNo2 like '%" & Search & "%' or CU.CuTelNo3 like '%" & Search & "%' " &
                                        "or P.PCategory like '%" & Search & "%' or P.PName like '%" & Search & "%' or P.PModelNo like '%" & Search & "%' " &
                                        "or RET.PSerialNo like '%" & Search & "%' or RET.Problem like '%" & Search & "%' or RET.Charge like '%" & Search &
                                        "%' or RET.PaidPrice like '%" & Search & "%' or T.TName like '%" & Search & "%' " &
                                        "or RET.Status like '%" & Search & "%' or RET.RetRepDate like '%" & Search & "%' or D.DDate like '%" & Search & "%')"
                        End Select
                    Case "DeliverReRepair"
                        Select Case Filter
                            Case "Re-Repair No"
                                x += " and RET.RETNo like '%" & Search & "%' "
                            Case "Repair No"
                                x += " and RET.Repno like '%" & Search & "%' "
                            Case "Received Date"
                                x += " and RDate like '%" & Search & "%' "
                            Case "Customer Name"
                                x += " and CU.CuName like '%" & Search & "%' "
                            Case "Customer Telephone No 1"
                                x += " and CU.CuTelNo1 like '%" & Search & "%' "
                            Case "Customer Telephone No 2"
                                x += " and CU.CuTelNo2 like '%" & Search & "%' "
                            Case "Customer Telephone No 3"
                                x += " and CU.CuTelNo3 like '%" & Search & "%' "
                            Case "Product Category"
                                x += " and P.PCategory like '%" & Search & "%' "
                            Case "Product Name"
                                x += " and P.PName like '%" & Search & "%' "
                            Case "Product Model No"
                                x += " and P.PModelNo like '%" & Search & "%'"
                            Case "Product Serial No"
                                x += " and PSerialNo like '%" & Search & "%'"
                            Case "Problem"
                                x += " and Problem like '%" & Search & "%' "
                            Case "Repair Charge"
                                x += " and Charge like '%" & Search & "%' "
                            Case "Technician No"
                                x += " and RET.TNo like '%" & Search & "%' "
                            Case "Technician Name"
                                x += " and T.TName like '%" & Search & "%' "
                            Case "Status"
                                x += " and RET.Status like '%" & Search & "%' "
                            Case "Repaired Date"
                                x += " and RET.RetRepDate like '%" & Search & "%' "
                            Case "Delivered Date"
                                x += " D.DDate like '%" & Search & "%'"
                            Case "Remarks for Customer"
                                x += " and RET.RETRemarks1 like '%" & Search & "%' "
                            Case "Remarks for Technician"
                                x += " and RET.RETRemarks2 like '%" & Search & "%' "
                            Case "All"
                                x += " and (RET.RETNo like '%" & Search & "%' or R.RNo like '%" & Search & "%' or R.RDate like '%" & Search & "%' " &
                                        "or CU.CuName like '%" & Search & "%' or CU.CuTelNo1 like '%" & Search & "%' " &
                                        "or CU.CuTelNo2 like '%" & Search & "%' or CU.CuTelNo3 like '%" & Search & "%' " &
                                        "or P.PCategory like '%" & Search & "%' or P.PName like '%" & Search & "%' or P.PModelNo like '%" & Search & "%' " &
                                        "or RET.PSerialNo like '%" & Search & "%' or RET.Problem like '%" & Search & "%' or RET.Charge like '%" & Search & "%' or T.TName like '%" & Search & "%' " &
                                        "or RET.Status like '%" & Search & "%' or RET.RetRepDate like '%" & Search & "%' or RET.RETRemarks1 like '%" & Search & "%' or RET.RETRemarks2 like '%" & Search & "%') "
                        End Select
                End Select
            Next
        Next
        If y <> "" Then     'Closed every iif condition in Repair 
            y += "," + (Count + 1).ToString
            For i As Integer = 1 To Count
                y += ")"
            Next
            x += " Order by " + y
        End If
    End Sub

    Private Sub bgworker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSearch.DoWork
        Dim CMDSearch1 As New OleDb.OleDbCommand
        Try
            Select Case Me.Tag
                Case "Sale"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT Sale.SaNo,Sale.SaDate,Sale.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3,Sale.SaSubTotal," &
                                                 "Sale.SaLess,Sale.SaDue,Sale.CReceived,Sale.CBalance,Sale.CAmount,Sale.CPInvoiceNo,Sale.CPAmount,Sale.CuLNo,Sale.CuLAmount," &
                                                 "Sale.SaRemarks from Sale,Customer where Customer.CuNo=Sale.CuNo " & x & " Order by SaDate Desc;", CNN)
                Case "Supply"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT Supply.SupNo,SupDate,Supply.SuNo,SuName,SupRemarks,SupStatus,SupPaidDate from ([Supply] Inner Join [Supplier] On Supplier.SuNo=Supply.SuNo) " & x & ";", CNN)
                Case "Receive"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, " &
                                                         "PSerialNo,Problem,Qty,RepRemarks1,Status,REP.TNo, TName,RepRemarks2,RepDate,Charge,REP.DNo, DDate, PaidPrice from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) " &
                                                         "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where (Status='Repaired Delivered' or Status='Returned Delivered') " & x & ";", CNN)
                Case "Deliver"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT Deliver.DNo,DDate,Customer.CuNo,CuName,CuTelNo1,CuTelNo2,CuTelNo3,DGrandTotal," &
                                                    "CReceived,CBalance,CAmount,CPInvoiceNo,CPAmount,CuLNo,CuLAmount," &
                                                    "DRemarks from Deliver,Customer where Customer.CuNo=Deliver.CuNo " & x & " Order by DDate Desc;", CNN)
                Case "Repair"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, " &
                                                         "PSerialNo,Problem,Location,Qty,Status,REP.TNo, TName,RepDate,Charge,REP.DNo, DDate, PaidPrice " &
                                                         "from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) " &
                                                         "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D " &
                                                         "ON D.DNO = REP.DNO)" & x, CNN)
                Case "ReRepair"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT RetNo, RepNo,Ret.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, Ret.PNo,PCategory,PName, PModelNo, " &
                                                         "PSerialNo,Problem,Qty,Status, TName,RetREpDate,Charge,Ret.DNo, DDate, PaidPrice from (((((Return RET INNER JOIN RECEIVE R ON R.RNO = Ret.RNO) INNER JOIN PRODUCT  P ON P.PNO = Ret.PNO) " &
                                                         "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = Ret.TNO) LEFT JOIN DELIVER D ON D.DNO = Ret.DNO) " & x & ";", CNN)
                Case "DeliverRepair"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, " &
                                                         "PSerialNo,Problem,Qty,Charge, PaidPrice, REP.TNo, TName, Status, RepDate,REP.DNo, DDate" &
                                                         " from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = " &
                                                         "REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN " &
                                                         "DELIVER D ON D.DNO = REP.DNO) Where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' " & x & ";", CNN)
                Case "DeliverReRepair"
                    CMDSearch1 = New OleDb.OleDbCommand("SELECT RETNo,RET.RepNo,RET.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, RET.PNo,PCategory,PName, PModelNo, " &
                                                         "PSerialNo,Problem,Qty,Charge, RET.TNo, TName, Status, RetRepDate from (((((RETURN RET INNER JOIN RECEIVE R ON R.RNO = RET.RNO) INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) " &
                                                         "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' " & x & ";", CNN)
            End Select
            Dim Rows_Count As Integer = GetRowsCount(CMDSearch1)
            Dim DRSearch1 As OleDb.OleDbDataReader = CMDSearch1.ExecuteReader()
            grdSearch.Rows.Clear()
            If Rows_Count < 1 Then Exit Sub
            ProgressBar.Maximum = Rows_Count
            Dim i As Integer = 0
            While DRSearch1.Read
                If bgwSearch.CancellationPending = True Then
                    e.Cancel = True
                    Exit While
                End If
                Select Case Me.Tag
                    Case "Sale"
                        grdSearch.Rows.Add(DRSearch1("SaNo").ToString, DRSearch1("SaDate").ToString, DRSearch1("CuNo").ToString, DRSearch1("CuName").ToString,
                                           DRSearch1("CuTelNo1").ToString, DRSearch1("CuTelNo2").ToString, DRSearch1("CuTelNo3").ToString,
                                           DRSearch1("SaSubTotal").ToString, DRSearch1("SaLess").ToString, DRSearch1("SaDue").ToString, DRSearch1("CReceived").ToString,
                                           DRSearch1("CBalance").ToString, DRSearch1("CAmount").ToString, DRSearch1("CPInvoiceNo").ToString,
                                           DRSearch1("CPAmount").ToString, DRSearch1("CuLNo").ToString, DRSearch1("CuLAmount").ToString,
                                           DRSearch1("SaRemarks").ToString)
                    Case "Supply"
                        grdSearch.Rows.Add(DRSearch1("SupNo").ToString, DRSearch1("SupDate").ToString, DRSearch1("SuNo").ToString, DRSearch1("SuName").ToString,
                                           DRSearch1("SupStatus").ToString, DRSearch1("SupPaidDate").ToString, DRSearch1("SupRemarks").ToString)
                    Case "Deliver"
                        grdSearch.Rows.Add(DRSearch1("DNo").ToString, DRSearch1("DDate").ToString, DRSearch1("CuName").ToString, DRSearch1("CuTelNo1").ToString,
                                       DRSearch1("CuTelNo2").ToString, DRSearch1("CuTelNo3").ToString, DRSearch1("DGrandTotal").ToString,
                                       DRSearch1("CReceived").ToString, DRSearch1("CBalance").ToString, DRSearch1("CAmount").ToString,
                                       DRSearch1("CPInvoiceNo").ToString, DRSearch1("CPAmount").ToString,
                                       DRSearch1("CuLNo").ToString, DRSearch1("CuLAmount").ToString, DRSearch1("DRemarks").ToString)
                    Case "Receive"
                        grdSearch.Rows.Add(DRSearch1("RepNo").ToString, DRSearch1("RDate").ToString, DRSearch1("CuName").ToString, DRSearch1("CuTelNo1").ToString,
                                           DRSearch1("CuTelNo2").ToString,
                                           DRSearch1("CuTelNo3").ToString, DRSearch1("PCategory").ToString, DRSearch1("PName").ToString, DRSearch1("PModelNo").ToString,
                                           DRSearch1("PSerialNo").ToString, DRSearch1("Problem").ToString, DRSearch1("Qty").ToString, DRSearch1("RepRemarks1").ToString,
                                           DRSearch1("Status").ToString, DRSearch1("TName").ToString, DRSearch1("RepRemarks2").ToString, DRSearch1("RepDate").ToString,
                                           DRSearch1("Charge").ToString, DRSearch1("DDate").ToString, DRSearch1("PaidPrice").ToString)
                    Case "Repair", "DeliverRepair"
                        grdSearch.Rows.Add(DRSearch1("RepNo").ToString, DRSearch1("RDate").ToString, DRSearch1("CuName").ToString, DRSearch1("CuTelNo1").ToString,
                                       DRSearch1("CuTelNo2").ToString, DRSearch1("CuTelNo3").ToString, DRSearch1("PCategory").ToString, DRSearch1("PName").ToString,
                                       DRSearch1("PModelNo").ToString, DRSearch1("PSerialNo").ToString, DRSearch1("Problem").ToString, DRSearch1("Location").ToString,
                                       DRSearch1("Qty").ToString, "",
                                       DRSearch1("Status").ToString, DRSearch1("TName").ToString, "", DRSearch1("RepDate").ToString, DRSearch1("Charge").ToString,
                                       DRSearch1("DDate").ToString, DRSearch1("PaidPrice").ToString)
                        If (grdSearch.Item("Status", grdSearch.Rows.Count - 1).Value.ToString = "Repaired Delivered" Or
                        grdSearch.Item("Status", grdSearch.Rows.Count - 1).Value.ToString = "Returned Delivered") Then
                            grdSearch.Rows.Item(grdSearch.Rows.Count - 1).ReadOnly = True
                        End If
                    Case "ReRepair", "DeliverReRepair"
                        grdSearch.Rows.Add(DRSearch1("RetNo").ToString, DRSearch1("RepNo").ToString, DRSearch1("RDate").ToString, DRSearch1("CuName").ToString,
                                           DRSearch1("CuTelNo1").ToString,
                                           DRSearch1("CuTelNo2").ToString, DRSearch1("CuTelNo3").ToString, DRSearch1("PCategory").ToString, DRSearch1("PName").ToString,
                                           DRSearch1("PModelNo").ToString, DRSearch1("PSerialNo").ToString, DRSearch1("Problem").ToString, DRSearch1("Qty").ToString,
                                           "", DRSearch1("Status").ToString, DRSearch1("TName").ToString, "",
                                           DRSearch1("RetRepDate").ToString, DRSearch1("Charge").ToString, DRSearch1("DDate").ToString, DRSearch1("PaidPrice").ToString)
                End Select
                i += 1
            Me.Text = "LASER System - Search Management [Transfering Data (" & i.ToString & "/" & Rows_Count.ToString & ")....]"
            ProgressBar.Value = i
            End While
            CMDSearch1.Cancel()
            DRSearch1.Close()
        Catch ex As Exception
        Exit Sub
        End Try
    End Sub

    Private Sub bgworker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwSearch.RunWorkerCompleted
        Me.Text = "LASER System - Search Management"
        If cmdTSSearch.Tag = "Restart" Then
            cmdTSSearch.Tag = ""
            CmdTSSearch_Click(sender, e)
            Exit Sub
        End If
        ProgressBar.Visible = False
        grdSearch.Refresh()
        grdSearch.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub GrdSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSearch.CellDoubleClick
        If Me.Tag = "" Or e.RowIndex < 0 Then
            Exit Sub
        End If
        If Me.Tag <> "Repair" Then Me.Enabled = False
        Select Case Me.Tag
            Case "Sale"
                For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
                    If oForm.Name = Me.Key Then
                        With oForm
                            Dim index As Integer
                            index = e.RowIndex
                            Dim selectedrow As DataGridViewRow
                            .cmdNew.PerformClick()
                            If index >= 0 Then
                                selectedrow = grdSearch.Rows(index)
                                .txtSaNo.Text = selectedrow.Cells(0).Value.ToString
                                .txtSaDate.Text = selectedrow.Cells(1).Value.ToString
                                .cmbCuName.Text = selectedrow.Cells(3).Value.ToString
                                .txtCuTelNo1.Text = selectedrow.Cells(4).Value.ToString
                                .txtCuTelNo2.Text = selectedrow.Cells(5).Value.ToString
                                .txtCuTelNo3.Text = selectedrow.Cells(6).Value.ToString
                                .txtSubTotal.Text = selectedrow.Cells(7).Value.ToString
                                .txtLess.Text = selectedrow.Cells(8).Value.ToString
                                .txtDue.Text = selectedrow.Cells(9).Value.ToString
                                .txtCReceived.Text = selectedrow.Cells(10).Value.ToString
                                .txtCBalance.Text = selectedrow.Cells(11).Value.ToString
                                .txtCAmount.Text = selectedrow.Cells(12).Value.ToString
                                .txtCPInvoiceNo.Text = selectedrow.Cells(13).Value.ToString
                                .txtCPAmount.Text = selectedrow.Cells(14).Value.ToString
                                .txtCuLNo.Text = selectedrow.Cells(15).Value.ToString
                                .txtCuLAmount.Text = selectedrow.Cells(16).Value.ToString
                                .txtSaRemarks.Text = selectedrow.Cells(17).Value.ToString
                                modSystem.CMD = New OleDb.OleDbCommand("Select Stock.SNo,Stock.SCategory,Stock.SName,StockSale.SaType,StockSale.SaUnits,StockSale.SaRate," &
                                                                       "SaTotal from StockSale,Stock where StockSale.SNo = Stock.SNo and SaNo=" & .txtSaNo.Text & ";", CNN)
                                DR = modSystem.CMD.ExecuteReader()
                                If DR.HasRows = True Then
                                    While DR.Read
                                        .grdSale.Rows.Add(DR("SNo").ToString(), DR("SCategory").ToString(), DR("SName").ToString(), DR("SaType").ToString(),
                                                          DR("SaRate").ToString(), DR("SaUnits").ToString(), Int(DR("SaTotal")))
                                    End While
                                End If
                            End If
                            .cmdSave.Text = "Edit"
                            .cmdDelete.Enabled = True
                        End With
                        Exit For
                    End If
                Next
            Case "Supply"
                With frmSupply
                    Dim index As Integer
                    index = e.RowIndex
                    Dim selectedrow As DataGridViewRow
                    .cmdNew.PerformClick()
                    If index >= 0 Then
                        selectedrow = grdSearch.Rows(index)
                        .txtSupNo.Text = selectedrow.Cells("SupNo").Value.ToString
                        .txtSupDate.Text = selectedrow.Cells("SupDate").Value.ToString
                        .cmbSuName.Text = selectedrow.Cells("SuName").Value.ToString
                        .txtSupRemarks.Text = selectedrow.Cells("SupRemarks").Value.ToString
                        .cmbSupStatus.Text = selectedrow.Cells("SupStatus").Value.ToString
                        If selectedrow.Cells("SupPaidDate").Value <> "" And
                            selectedrow.Cells("SupStatus").Value = "Paid" Then .txtSupPaidDate.Value = selectedrow.Cells("SupPaidDate").Value
                        modSystem.CMD = New OleDb.OleDbCommand("Select Stock.SNo,Stock.SCategory,Stock.SName,StockSupply.SupType,StockSupply.SupUnits," &
                                                               "StockSupply.SupCostPrice from StockSupply,Stock where StockSupply.SNo = Stock.SNo and SupNo=" &
                                                               .txtSupNo.Text & ";", CNN)
                        DR = modSystem.CMD.ExecuteReader()
                        If DR.HasRows = True Then
                            While DR.Read
                                .grdSupply.Rows.Add(DR("SNo").ToString(), DR("SCategory").ToString(), DR("SName").ToString(), DR("SupType").ToString(),
                                                    DR("SupCostPrice").ToString(), DR("SupUnits").ToString(), Int(DR("SupUnits")) * Int(DR("SupCostPrice")))
                            End While
                        End If
                    End If
                    .cmdSave.Text = "Edit"
                    .cmdDelete.Enabled = True
                End With
            Case "Receive"
                'With frmReceive
                '    Dim selectedrow As DataGridViewRow
                '    If e.RowIndex >= 0 Then
                '        selectedrow = grdSearch.Rows(e.RowIndex)
                '        .cmbRetRepNo.Text = selectedrow.Cells(0).Value.ToString
                '        CMD = New OleDb.OleDbCommand("SELECT * from Repair,Product where Repair.PNo = Product.PNo and RepNo = " & .cmbRetRepNo.Text & ";", CNN) 'This is the copy of cmbrepretno.selectedindexchange()
                '        DR = CMD.ExecuteReader()
                '        If DR.HasRows = True Then
                '            DR.Read()
                '            .txtRetPNo.Text = DR("Product.PNo").ToString
                '            .cmbRetPCategory.Text = DR("PCategory").ToString
                '            .cmbRetPName.Text = DR("PName").ToString
                '            .txtRetPModelNo.Text = DR("PModelNo").ToString
                '            .txtRetPSerialNo.Text = DR("PSerialNo").ToString
                '            .txtRetPDetails.Text = DR("PDetails").ToString
                '            .txtRetPQty.Text = DR("Qty").ToString
                '        End If
                '        .cmbRetRepNo.Focus()
                '    End If
                'End With
            Case "Deliver"
                bgwSearch.CancelAsync()
                With frmDeliver
                    .txtDNo.Text = grdSearch.Item(0, e.RowIndex).Value
                    .cmdSave.Text = "Edit"
                    CMD = New OleDb.OleDbCommand("SELECT D.*,CuName,CuTelNo1,CuTelNo2,CuTelNo3 from (Deliver D Inner Join Customer Cu On Cu.CuNo = D.CuNo) " &
                                                 "Where DNo=" & .txtDNo.Text, CNN)
                    DR = CMD.ExecuteReader()
                    If DR.HasRows Then
                        DR.Read()
                        .txtDDate.Value = DR("DDate").ToString
                        .cmbCuName.Text = DR("CuName").ToString
                        .txtCuTelNo1.Text = DR("CuTelNo1").ToString
                        .txtCuTelNo2.Text = DR("CuTelNo2").ToString
                        .txtCuTelNo3.Text = DR("CuTelNo3").ToString
                        .txtDRemarks.Text = DR("DRemarks").ToString
                        If DR("CAmount").ToString <> "" Then
                            .txtCAmount.Text = DR("CAmount").ToString
                            .txtCReceived.Text = DR("CReceived").ToString
                            .txtCBalance.Text = DR("CBalance").ToString
                        End If
                        If DR("CPAmount").ToString <> "" Then
                            .txtCPAmount.Text = DR("CPAmount").ToString
                            .txtCPInvoiceNo.Text = DR("CPInvoiceNo").ToString
                        End If
                        If DR("CuLAmount").ToString <> "" Then
                            .txtCuLAmount.Text = DR("CuLAmount").ToString
                            .txtCuLNo.Text = DR("CuLNo").ToString
                        End If
                        Dim CMD1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT RepNo,REP.PNo,PCategory,PName,Qty,Status,REP.TNo, TName,PaidPrice from " &
                                                                                "(((Repair REP INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) LEFT JOIN Technician T " &
                                                                                "ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where D.DNo=" &
                                                                                .txtDNo.Text, CNN)
                        Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader()
                        .grdRepair.Rows.Clear()
                        While DR1.Read
                            .grdRepair.Rows.Add(DR1("RepNo").ToString, DR1("PCategory").ToString, DR1("PName").ToString, DR1("Qty").ToString, DR1("PaidPrice").ToString,
                                                DR1("TName").ToString, DR1("Status").ToString)

                        End While
                        CMD1 = New OleDb.OleDbCommand("SELECT RetNo,RepNo,RET.PNo,PCategory,PName,Qty,Status,RET.TNo, TName,PaidPrice from " &
                                                    "(((Return RET INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) LEFT JOIN Technician T " &
                                                    "ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where D.DNo=" &
                                                    .txtDNo.Text, CNN)
                        DR1 = CMD1.ExecuteReader()
                        .grdRERepair.Rows.Clear()
                        While DR1.Read
                            .grdRERepair.Rows.Add(DR1("RetNo").ToString, DR1("RepNo").ToString, DR1("PCategory").ToString, DR1("PName").ToString, DR1("Qty").ToString,
                                                  DR1("PaidPrice").ToString, DR1("TName").ToString, DR1("Status").ToString)

                        End While
                    End If
                End With
            Case "ReRepair"
                With frmRepair
                    Dim selectedrow As DataGridViewRow
                    If e.RowIndex >= 0 Then
                        selectedrow = grdSearch.Rows(e.RowIndex)
                        .cmbRetNo.Text = selectedrow.Cells(0).Value.ToString
                        Call .CmbRetNo_SelectedIndexChanged(sender, e)
                        .tabRepair.SelectTab(1)
                    End If
                End With
            Case "DeliverRepair"
                With frmDeliver
                    With frmDeliver
                        .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = grdSearch.Item(0, grdSearch.CurrentCell.RowIndex).Value
                        Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
                        Call .GrdRepair_CellEndEdit(sender, E1)
                    End With
                End With
            Case "DeliverReRepair"
                With frmDeliver
                    With frmDeliver
                        .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = grdSearch.Item(0, grdSearch.CurrentCell.RowIndex).Value
                        Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
                        Call .GrdRepair_CellEndEdit(sender, E1)
                    End With
                End With
        End Select
        If Me.Tag <> "Repair" Then
            Me.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub FrmSearch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
        End If
    End Sub

    'Used to give unique control names such as label1, label2 etc
    Private _SearchPanelsAddedCount As Integer = 0

    'Add Message panel to flow layout panel
    Private Sub CreateSearchPanel(txt As String)

        Dim SearchPanel As New Panel()
        _SearchPanelsAddedCount += 1

        'Set panel properties
        With SearchPanel
            .Name = "pnlSearch" + (_SearchPanelsAddedCount).ToString
            If txt = " AND " Or txt = " OR " Then
                .BackColor = Color.DodgerBlue
            Else
                .BackColor = Color.Gray
            End If
        End With

        'Add panel to flow layout panel
        flpSearch.Controls.Add(SearchPanel)

        Dim SearchText As New Label
        'Set button properties
        With SearchText
            .AutoSize = True
            .Size = New Size(0, 19)
            .Location = New Point(0, 0)
            .Font = New Font("Calibri", 12)
            .Name = "txtSearch" + (_SearchPanelsAddedCount).ToString
            .Text = txt
        End With

        'Add button to panel 
        For Each controlObject As Control In flpSearch.Controls
            If controlObject.Name = SearchPanel.Name Then
                controlObject.Controls.Add(SearchText)
            End If
        Next

        Dim SearchDeleteButton As New PictureBox
        'Set button properties
        With SearchDeleteButton
            .Size = New Size(19, 19)
            .Location = New Point(SearchText.Width + SearchText.Left, 3)
            .Image = My.Resources.close
            .Name = "btnSearchDelete" + (_SearchPanelsAddedCount).ToString
            .Cursor = Cursors.Hand
        End With

        'Add button to panel 
        For Each controlObject As Control In flpSearch.Controls
            If controlObject.Name = SearchPanel.Name Then
                controlObject.Controls.Add(SearchDeleteButton)
            End If
        Next

        SearchPanel.Size = New Size(SearchText.Width + SearchDeleteButton.Width + 5, 22)
        'Add handler for click events
        AddHandler SearchDeleteButton.Click, AddressOf DynamicButton_Click
    End Sub

    'Remove handlers and Message panel 
    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentPanelName As String = Nothing
        Dim PanelAddedCount As Integer = 0
        'Remove handler from sender
        For Each controlObj As Control In flpSearch.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then
                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click
                    flpSearch.Controls.Remove(controlObj)
                    controlObj.Dispose()
                    GoTo end_for_loop
                End If
            Next
        Next
end_for_loop:
        For Each controlObj As Control In flpSearch.Controls
            PanelAddedCount += 1
            controlObj.Name = "pnlSearch" + PanelAddedCount.ToString
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name.StartsWith("txtSearch") = True Then
                    Dim str = childControlObj.Name
                    Dim str2 = childControlObj.Text
                    childControlObj.Name = "txtSearch" + PanelAddedCount.ToString
                ElseIf childControlObj.Name.StartsWith("btnSearchDelete") = True Then
                    childControlObj.Name = "btnSearchDelete" + PanelAddedCount.ToString
                End If
            Next
        Next

        _SearchPanelsAddedCount = PanelAddedCount
        CmdTSSearch_Click(sender, e)
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        If flpSearch.Controls.Count < 1 Then Exit Sub
        'Remove Message panel
        flpSearch.Controls.RemoveAt(0)
        'Dim PanelAddedCount As Integer = 0
        'For Each controlObj As Control In flpSearch.Controls
        '    If IsNumeric(controlObj.Name.Replace("pnlSearch", "")) AndAlso PanelAddedCount < Int(controlObj.Name.Replace("pnlSearch", "")) Then
        '        PanelAddedCount = controlObj.Name.Replace("pnlSearch", "")
        '    End If
        'Next
        '_SearchPanelsAddedCount = PanelAddedCount
        CmdTSSearch_Click(sender, e)
    End Sub

    Private Sub FlpSearch_Resize(sender As Object, e As EventArgs) Handles flpSearch.Resize
        flpSearch.Width = cmdTSSearch.Left - flpSearch.Left - 10
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtTSSearch.Focus()
    End Sub

    Private Sub frmSearch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = False
        Me.Tag = ""
    End Sub

    Private Sub grdSearch_SelectionChanged(sender As Object, e As EventArgs) Handles grdSearch.SelectionChanged
        Select Case Me.Tag
            Case "Deliver"
                CMD = New OleDb.OleDbCommand("Select RepNo,PCategory,PName,Qty,PaidPrice,TName,Status from (((Repair Rep Inner Join Deliver D ON D.DNo=Rep.DNo) " &
                                             "Inner Join Product P on p.pno = Rep.pno) Inner Join Technician T On T.TNo = Rep.TNo) Where D.DNo = " &
                                             grdSearch.Item(0, grdSearch.CurrentRow.Index).Value.ToString, CNN)
                DR = CMD.ExecuteReader
                grdsubsearch1.Rows.Clear()
                While DR.Read
                    grdsubsearch1.Rows.Add(DR("RepNo").ToString, DR("PCategory").ToString, DR("PName").ToString, DR("Qty").ToString,
                                            DR("PaidPrice").ToString, DR("TName").ToString, DR("Status").ToString)
                End While
                CMD = New OleDb.OleDbCommand("Select RetNo,RepNo,PCAtegory,PName,Qty,PaidPrice,TName,Status from (((Return Ret Inner Join Deliver D" &
                                                       " ON D.DNo = Ret.DNo) Inner Join Product P on p.pno = Ret.pno) Inner Join Technician T On T.TNo = Ret.TNo) " &
                                                       "Where D.DNo = " & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value.ToString, CNN)
                DR = CMD.ExecuteReader
                grdsubsearch2.Rows.Clear()
                While DR.Read
                    grdsubsearch2.Rows.Add(DR("RetNo").ToString, DR("RepNo").ToString, DR("PCategory").ToString, DR("PName").ToString, DR("Qty").ToString,
                                            DR("PaidPrice").ToString, DR("TName").ToString, DR("Status").ToString)
                End While
        End Select
    End Sub

    Private Sub cmdLeftBracket_Click(sender As Object, e As EventArgs) Handles cmdLeftBracket.Click
        CreateSearchPanel(" ( ")
    End Sub

    Private Sub cmdRightBracket_Click(sender As Object, e As EventArgs) Handles cmdRightBracket.Click
        CreateSearchPanel(" ) ")
        CmdTSSearch_Click(sender, e)
    End Sub

    Private Sub cmdAND_Click(sender As Object, e As EventArgs) Handles cmdAND.Click
        cmdAND.FillColor = Color.DodgerBlue
        cmdOR.FillColor = Color.DarkBlue
    End Sub

    Private Sub cmdOR_Click(sender As Object, e As EventArgs) Handles cmdOR.Click
        cmdOR.FillColor = Color.DodgerBlue
        cmdAND.FillColor = Color.DarkBlue
    End Sub

    Private Sub grdSearch_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdSearch.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        If Me.Tag = "Repair" Then
            If e.ColumnIndex = 17 Then
                grdSearch.Controls.Add(dtpDate)
                dtpDate.Location = grdSearch.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                dtpDate.Size = New Size(grdSearch.Columns.Item(e.ColumnIndex).Width, grdSearch.Rows.Item(e.RowIndex).Height)
                dtpDate.Format = DateTimePickerFormat.Custom
                dtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
                dtpDate.Visible = True
                If grdSearch.CurrentCell.Value Is Nothing OrElse grdSearch.CurrentCell.Value.ToString = "" Then
                    dtpDate.Value = DateTime.Now
                Else
                    dtpDate.Value = Convert.ToDateTime(grdSearch.CurrentCell.Value)
                End If
            End If
            grdSearch.Item(e.ColumnIndex, e.RowIndex).Tag = grdSearch.Item(e.ColumnIndex, e.RowIndex).Value
        End If
    End Sub

    Private Sub grdSearch_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdSearch.RowValidating
        If e.RowIndex < 0 Then Exit Sub
        Select Case Me.Tag
            Case "Repair"
                If grdSearch.Item("Status", e.RowIndex).Value = "" Then MsgBox("Status යන Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.",
                                                                               vbExclamation + vbOKOnly)

                If grdSearch.Item("TName", e.RowIndex).Value <> "" And grdSearch.Item("Status", e.RowIndex).Value =
                    "Received" Then grdSearch.Item("Status", e.RowIndex).Value = "Hand Over to Technician"
                If grdSearch.Item("Charge", e.RowIndex).Value = "0" And (grdSearch.Item("Status", e.RowIndex).Value =
                    "Received" Or grdSearch.Item("Status", e.RowIndex).Value = "Hand Over to Technician" Or
                    grdSearch.Item("Status", e.RowIndex).Value = "Repairing") Then grdSearch.Item("Status", e.RowIndex).Value = "Returned Not Delivered"
                If grdSearch.Item("Charge", e.RowIndex).Value <> "" And (grdSearch.Item("Status", e.RowIndex).Value =
                    "Received" Or grdSearch.Item("Status", e.RowIndex).Value = "Hand Over to Technician" Or
                    grdSearch.Item("Status", e.RowIndex).Value = "Repairing") Then grdSearch.Item("Status", e.RowIndex).Value = "Repaired Not Delivered"

                If grdSearch.Item("Status", e.RowIndex).Value.ToString <> "Received" And
                   grdSearch.Item("Status", e.RowIndex).Value.ToString <> "" Then
                    If grdSearch.Item("TName", e.RowIndex).Value = "" Then MsgBox("Technician Name යන Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.",
                                                                                  vbExclamation + vbOKOnly)
                End If
                If grdSearch.Item("Status", e.RowIndex).Value = "Repaired Not Delivered" Or grdSearch.Item("Status", e.RowIndex).Value.ToString =
                    "Returned Not Delivered" Or grdSearch.Item("Status", e.RowIndex).Value.ToString = "Repaired Delivered" Or
                    grdSearch.Item("Status", e.RowIndex).Value.ToString = "Returned Delivered" Then
                    If grdSearch.Item("RepDate", e.RowIndex).Value.ToString = "" Then grdSearch.Item("RepDate", e.RowIndex).Value = DateAndTime.Now
                    If grdSearch.Item("Charge", e.RowIndex).Value = "" Then MsgBox("Repair Charge යන Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.",
                                                                                   vbExclamation + vbOKOnly)
                End If
        End Select
    End Sub

    Private Sub grdSearch_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdSearch.EditingControlShowing
        If Me.Tag = "Repair" Then
            If grdSearch.CurrentCell.ColumnIndex = 13 Then
                Dim DT As New DataTable
                Dim DA = New OleDb.OleDbDataAdapter("Select Rem1Date as [Date],Remarks,UserName as [User] from ([RepairRemarks1] RepRem1 Left join " &
                                                    "[User] U on U.Uno= RepRem1.UNo) Where RepNo=" & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value, CNN)
                DA.Fill(DT)
                frmDatagridviewTool.Tag = "RepRem"
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmDatagridviewTool.passtext(tb)
                AddHandler tb.KeyDown, AddressOf frmDatagridviewTool.dgv_KeyDown
                frmDatagridviewTool.frm_Open(grdSearch, Me, DT)
            ElseIf grdSearch.CurrentCell.ColumnIndex = 16 Then
                Dim DT As New DataTable
                Dim DA = New OleDb.OleDbDataAdapter("Select Rem2Date as [Date],Remarks,UserName as [User] from ([RepairRemarks2] RepRem2 Left join " &
                                                    "[User] U on U.Uno= RepRem2.UNo) Where RepNo=" & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value, CNN)
                DA.Fill(DT)
                frmDatagridviewTool.Tag = "RepRem"
                frmDatagridviewTool.frm_Open(grdSearch, Me, DT)
            ElseIf grdSearch.CurrentCell.ColumnIndex = 17 Then
                dtpDate.Location = grdSearch.GetCellDisplayRectangle(grdSearch.CurrentCell.ColumnIndex, grdSearch.CurrentCell.RowIndex, True).Location
                dtpDate.Size = New Size(grdSearch.Columns.Item(grdSearch.CurrentCell.ColumnIndex).Width, grdSearch.Rows.Item(grdSearch.CurrentCell.RowIndex).Height)
            ElseIf grdSearch.CurrentCell.ColumnIndex = 11 Then
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdSearch, Me, "Select Location from Repair group by Location;", "Location")
            End If
        End If
    End Sub

    Private Sub frmSearch_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Me.Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
            frmSearchDropDown.frm_Move()
        End If
    End Sub

    Private Sub grdSearch_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdSearch.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        Dim currentvalue, previousvalue As String
        currentvalue = ""
        previousvalue = ""
        If grdSearch.Item(e.ColumnIndex, e.RowIndex).Value IsNot Nothing Then currentvalue = grdSearch.Item(e.ColumnIndex, e.RowIndex).Value
        If grdSearch.Item(e.ColumnIndex, e.RowIndex).Tag IsNot Nothing Then previousvalue = grdSearch.Item(e.ColumnIndex, e.RowIndex).Tag
        If Me.Tag = "Repair" Then
            Select Case e.ColumnIndex
                Case 9, 10, 11, 14
                    If e.ColumnIndex = 11 Then frmSearchDropDown.frm_Close()
                    If previousvalue <> currentvalue Then
                        CMDUPDATE("UPDATE Repair SET " & grdSearch.Columns(e.ColumnIndex).Name & " ='" & currentvalue & "' where repno = " &
                          grdSearch.Item(0, e.RowIndex).Value)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                      " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                      grdSearch.Item(0, e.RowIndex).Value & ",#" & DateAndTime.Now & "#,'" & grdSearch.Columns(e.ColumnIndex).HeaderText & " -> " &
                      currentvalue & "'," & MdifrmMain.Tag & ")")
                    End If
                Case 13
                    frmDatagridviewTool.frm_Close()
                    If currentvalue <> "" Then
                        CMDUPDATE("Insert into RepairRemarks1(Rem1No,RepNo,Rem1Date,Remarks,UNo) Values(" &
                                  AutomaticPrimaryKeyStr("RepairRemarks1", "Rem1No") & "," &
                          grdSearch.Item(0, e.RowIndex).Value & ",#" & DateAndTime.Now & "#,'" & grdSearch.Item(13, e.RowIndex).Value & "'," &
                          MdifrmMain.Tag & ")")
                        grdSearch.Item(13, e.RowIndex).Value = ""
                    End If
                Case 15
                    If currentvalue <> "" And grdSearch.Item("Status", e.RowIndex).Value = "Received" Then
                        grdSearch.Item("Status", e.RowIndex).Value = "Hand Over to Technician"
                        Dim E1 As New DataGridViewCellEventArgs(14, e.RowIndex)
                        grdSearch_CellEndEdit(sender, E1)
                    End If
                    If previousvalue <> currentvalue Then
                        Dim TNo As String = GetStrfromRelatedfield("Select TNo from Technician WHERE TNAME='" & grdSearch.Item("TName", e.RowIndex).Value & "'", "TNo")
                        CMDUPDATE("update Repair set tno =" & TNo & " where repno=" & grdSearch.Item(0, e.RowIndex).Value & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  grdSearch.Item(0, e.RowIndex).Value & ",#" & DateAndTime.Now & "#,'Technician -> " & grdSearch.Item("TName", e.RowIndex).Value &
                                  "'," & MdifrmMain.Tag & ")")
                    End If
                Case 16
                    frmDatagridviewTool.frm_Close()
                    If currentvalue <> "" Then
                        CMDUPDATE("Insert into RepairRemarks2(Rem2No,RepNo,Rem2Date,Remarks,UNo) Values(" &
                                  AutomaticPrimaryKeyStr("RepairRemarks2", "Rem2No") & "," &
                          grdSearch.Item(0, e.RowIndex).Value & ",#" & DateAndTime.Now & "#,'" & grdSearch.Item(16, e.RowIndex).Value & "'," &
                          MdifrmMain.Tag & ")")
                        grdSearch.Item(16, e.RowIndex).Value = ""
                    End If
                Case 17
                    grdSearch.CurrentCell.Value = dtpDate.Value.ToString
                    dtpDate.Visible = False
                    If GetStrfromRelatedfield("Select RepDate from Repair Where RepNo=" & grdSearch.Item(0, e.RowIndex).Value, "RepDate") <> currentvalue Then
                        CMDUPDATE("update Repair set repdate=#" & currentvalue & "# where repno=" & grdSearch.Item(0, e.RowIndex).Value & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  grdSearch.Item(0, e.RowIndex).Value & ",#" & DateAndTime.Now & "#,'Repaired Date එක " & currentvalue &
                                  " වෙනස් කෙරුණි.'," & MdifrmMain.Tag & ")")
                    End If
                Case 18
                    If currentvalue <> previousvalue Then
                        grdSearch.Item(17, e.RowIndex).Value = DateAndTime.Now
                        If currentvalue = "0" Then
                            grdSearch.Item(14, e.RowIndex).Value = "Returned Not Delivered"
                        Else
                            grdSearch.Item(14, e.RowIndex).Value = "Repaired Not Delivered"
                        End If
                        CMDUPDATE("UPDATE Repair set Status ='" & grdSearch.Item(14, e.RowIndex).Value &
                                      "',RepDate=#" & grdSearch.Item(17, e.RowIndex).Value &
                                      "#,Charge=" & currentvalue & " where repno=" &
                                      grdSearch.Item(0, e.RowIndex).Value & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  grdSearch.Item(0, e.RowIndex).Value & ",#" & DateAndTime.Now & "#,'" &
                                  "Repaired Date -> " & grdSearch.Item(17, e.RowIndex).Value &
                                  ", Status -> " & grdSearch.Item(14, e.RowIndex).Value &
                                  ", Repair Charge -> " & currentvalue &
                                  "'," & MdifrmMain.Tag & ")")
                    End If
            End Select
        End If
    End Sub

    Private Sub grdSearch_Scroll(sender As Object, e As ScrollEventArgs) Handles grdSearch.Scroll
        If Me.Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
        End If
    End Sub

    Private Sub cmdLIKE_Click(sender As Object, e As EventArgs) Handles cmdLIKE.Click
        If cmdLIKE.Text = "LIKE" Then
            cmdLIKE.Text = "="
        Else
            cmdLIKE.Text = "LIKE"
        End If
    End Sub
End Class