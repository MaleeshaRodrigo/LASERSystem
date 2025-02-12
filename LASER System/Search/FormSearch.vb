Imports System.ComponentModel
Imports MySqlConnector
Imports LASER_System.StructureDatabase

Public Class FormSearch
    Public RequestSource As FormSearchRequestSource
    Public Property Key As String

    Private Db As New Database
    Private x, y As String
    Private GridControl As GridSearchControl
    Private ReadOnly dtpDate As New DateTimePicker

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        MenuStrip1.Items.Add(mnustrpMENU)
        Text = "LASER System - Search Management [Prepairing Sheet....]"
        Select Case RequestSource
            Case FormSearchRequestSource.Deliver
                GridSubSearchLeft.Columns.Clear()
                GridSubSearchLeft.Columns.Add("RepNo", "Repair No")
                GridSubSearchLeft.Columns.Add("PCategory", "Product Category")
                GridSubSearchLeft.Columns.Add("PName", "Product Name")
                GridSubSearchLeft.Columns.Add("Qty", "Qty")
                GridSubSearchLeft.Columns.Add("PaidPrice", "Paid Charge")
                GridSubSearchLeft.Columns.Add("TName", "Technician Name")
                GridSubSearchLeft.Columns.Add("Status", "Status")
                GridSubSearchLeft.Rows.Clear()
                GridSubSearchLeft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                GridSubSearchRight.Columns.Clear()
                GridSubSearchRight.Columns.Add("REREpNo", "RE-Repair No")
                GridSubSearchRight.Columns.Add("RepNo", "Repair No")
                GridSubSearchRight.Columns.Add("PCategory", "Product Category")
                GridSubSearchRight.Columns.Add("PName", "Product Name")
                GridSubSearchRight.Columns.Add("Qty", "Qty")
                GridSubSearchRight.Columns.Add("PaidPrice", "Paid Charge")
                GridSubSearchRight.Columns.Add("TName", "Technician Name")
                GridSubSearchRight.Columns.Add("Status", "Status")
                GridSubSearchLeft.Rows.Clear()
                GridSubSearchRight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Case FormSearchRequestSource.Repair
                GridControl = New GridRepairSearchControl()
                GridControl.Init(Db)
                Controls.Add(GridControl)
                GridControl.Control.Dock = DockStyle.Fill
            Case FormSearchRequestSource.ReRepair
                grdSearch.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                grdSearch.SelectionMode = DataGridViewSelectionMode.CellSelect
                grdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                grdSearch.Columns.Add("ReRepNo", "Re-Repair No")
                grdSearch.Columns.Item(1).Frozen = True

                Dim grdSearchStatus As New DataGridViewComboBoxColumn   '-----------Status Combo Box
                grdSearchStatus.Name = "Status"
                grdSearchStatus.HeaderText = "Status"
                grdSearchStatus.Items.Clear()
                grdSearchStatus.Items.Add(RepairStatus.Received)
                grdSearchStatus.Items.Add(RepairStatus.HandedOverTo)
                grdSearchStatus.Items.Add(RepairStatus.Pending)
                grdSearchStatus.Items.Add(RepairStatus.Repaired)
                grdSearchStatus.Items.Add("Repaired Delivered")
                grdSearchStatus.Items.Add(RepairStatus.Returned)
                grdSearchStatus.Items.Add("Returned Delivered")
                grdSearchStatus.Items.Add("Canceled")
                grdSearch.Columns.Add(grdSearchStatus)
                Dim grdSearchTName As New DataGridViewComboBoxColumn    '-----------TName Combo Box
                grdSearchTName.Name = "TName"
                grdSearchTName.HeaderText = "Technician Name"
                DR = Db.GetDataList("Select TName from Technician group by TName;")
                grdSearchTName.Items.Clear()
                grdSearchTName.Items.Add("")
                For Each Item In DR
                    grdSearchTName.Items.Add(Item("TName").ToString)
                Next
                grdSearch.Columns.Add(grdSearchTName)
                {"RepRemarks2", "Remarks for Technician"},
                {"RepDate", "Repaired Date"},
                {"RepCharge", "Repair Charge"},
                {"DNo", "Deliver No"},
                {"DDate", "Delivered Date"},
                {"PaidPrice", "Paid Repair Charge"},
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
                grdSearch.Columns.Item("PaidPrice").ReadOnly = True
                grdSearch.Columns.Item("RepRemarks1").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                grdSearch.Columns.Item("RepRemarks2").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                grdSearch.Columns.Item("Problem").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End Select
        ControlSearchEngine.Init(GridControl.GetFilterDictionary())
    End Sub

    Private Function GetControlSeachInitDictionary() As Dictionary(Of String, String)
        Select Case Tag
            Case FormSearchRequestSource.ReRepair
                Return New Dictionary(Of String, String) From {
                    {"RepNo", "Repair No"},
                    {"RDate", "Receive Date"},
                    {"CuName", "Customer Name"},
                    {"CuTelNo1", "Customer Telephone No 1"},
                    {"CuTelNo2", "Customer Telephone No 2"},
                    {"CuTelNo3", "Customer Telephone No 3"},
                    {"PCategory", "Product Category"},
                    {"PName", "Product Name"},
                    {"PModelNo", "Product Model No"},
                    {"PSerialNo", "Product Serial No"},
                    {"Problem", "Problem"},
                    {"Qty", "Qty"},
                    {"RepRemarks1", "Remarks for Customer"},
                }
            Case FormSearchRequestSource.DeliverReRepair
                Return New Dictionary(Of String, String) From {
                    {"ReRepNo", "Re-Repair No"},
                    {"RepNo", "Repair No"},
                    {"RDate", "Receive Date"},
                    {"CuName", "Customer Name"},
                    {"CuTelNo1", "Customer Telephone No 1"},
                    {"CuTelNo2", "Customer Telephone No 2"},
                    {"CuTelNo3", "Customer Telephone No 3"},
                    {"PCategory", "Product Category"},
                    {"PName", "Product Name"},
                    {"PModelNo", "Product Model No"},
                    {"PSerialNo", "Product Serial No"},
                    {"Problem", "Problem"},
                    {"Qty", "Qty"},
                    {"RepRemarks1", "Remarks for Customer"},
                    {"Status", "Status"},
                    {"TName", "Technician Name"},
                    {"RepRemarks2", "Remarks for Technician"},
                    {"RepDate", "Repaired Date"},
                    {"RepCharge", "Repair Charge"},
                    {"DNo", "Deliver No"},
                    {"DDate", "Delivered Date"},
                    {"PaidPrice", "Paid Repair Charge"}
                }
            Case FormSearchRequestSource.Sale
                Return New Dictionary(Of String, String) From {
                    {"SaNo", "Sale No"},
                    {"SaDate", "Sale Date"},
                    {"CuNo", "Customer No"},
                    {"CuName", "Customer Name"},
                    {"CuTelNo1", "Customer Telephone No 1"},
                    {"CuTelNo2", "Customer Telephone No 2"},
                    {"CuTelNo3", "Customer Telephone No 3"},
                    {"SubTotal", "Sub Total"},
                    {"Less", "Less"},
                    {"Due", "Due"},
                    {"Received", "Received"},
                    {"Balance", "Balance"},
                    {"CashAmount", "Cash Amount"},
                    {"CPInvoiceNo", "Card Payment Invoice No"},
                    {"CPAmount", "Card Payment Amount"},
                    {"CuLNo", "Customer Loan No"},
                    {"CuLAmount", "Customer Loan Amount"},
                    {"Remarks", "Remarks"}
                }
            Case FormSearchRequestSource.Supply
                Return New Dictionary(Of String, String) From {
                    {"SupNo", "Supply No"},
                    {"SupDate", "Supply Date"},
                    {"SuNo", "Supplier No"},
                    {"SuName", "Supplier Name"},
                    {"SupStatus", "Status"},
                    {"SupPaidDate", "Paid Date"},
                    {"SupRemarks", "Remarks"}
                }
            Case FormSearchRequestSource.Receive, FormSearchRequestSource.DeliverRepair
                Return New Dictionary(Of String, String) From {
                    {"RepNo", "Repair No"},
                    {"RDate", "Received Date"},
                    {"CuName", "Customer Name"},
                    {"CuTelNo1", "Customer Telephone No 1"},
                    {"CuTelNo2", "Customer Telephone No 2"},
                    {"CuTelNo3", "Customer Telephone No 3"},
                    {"PCategory", "Product Category"},
                    {"PName", "Product Name"},
                    {"PModelNo", "Product Model No"},
                    {"PSerialNo", "Product Serial No"},
                    {"Problem", "Problem"},
                    {"Qty", "Qty"},
                    {"RepRemarks1", "Remarks for Customer"},
                    {"Status", "Status"},
                    {"TName", "Technician Name"},
                    {"RepRemarks2", "Remarks for Technician"},
                    {"RepDate", "Repaired Date"},
                    {"RepCharge", "Repair Charge"},
                    {"DDate", "Delivered Date"},
                    {"PaidPrice", "Paid Repair Charge"}
                }
            Case FormSearchRequestSource.Deliver
                Return New Dictionary(Of String, String) From {
                    {"DNo", "Deliver No"},
                    {"DDate", "Delivered Date"},
                    {"CuName", "Customer Name"},
                    {"CuTelNo1", "Customer Telephone No 1"},
                    {"CuTelNo2", "Customer Telephone No 2"},
                    {"CuTelNo3", "Customer Telephone No 3"},
                    {"DGrandTotal", "Grand Total"},
                    {"CReceived", "Received"},
                    {"CBalance", "Balance"},
                    {"CAmount", "Cash Amount"},
                    {"CPInvoiceNo", "Card Payment Invoice No"},
                    {"CPAmount", "Card Payment Amount"},
                    {"CuLNo", "Customer Loan No"},
                    {"CuLAmount", "Customer Loan Amount"},
                    {"DRemarks", "Remarks"}
                }
            Case Else
                Throw New Exception("Invalid Request Source")
        End Select
    End Function

    Private Sub CmdTSSearch_Click(sender As Object, e As EventArgs)
        Try
            If bgwSearch.IsBusy = True Then
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
                If _SearchPanelsAddedCount > 0 Then
                    If cmdAND.BackColor = Color.DodgerBlue Then
                        CreateSearchPanel("AND")
                    Else
                        CreateSearchPanel("OR")
                    End If
                End If
                If cmdLIKE.Text = "LIKE" Then
                    CreateSearchPanel($"{cmbFilter.Text}:{txtTSSearch.Text}")
                Else
                    CreateSearchPanel($"{cmbFilter.Text}={txtTSSearch.Text}")
                End If
            End If
            cmdLeftBracket.BackColor = Color.DarkBlue
            ProgressBar.Value = 0
            ProgressBar.Visible = True
            grdSearch.ScrollBars = ScrollBars.None
            ManageFilter()
            Text = "LASER System - Search Management [Setting Data....]"
            grdSearch.Rows.Clear()
            bgwSearch.RunWorkerAsync()
            txtTSSearch.Text = ""
            txtTSSearch.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ManageFilter()
        Try
            Dim Filter As String = "", Search As String = "", Symbol As Char = ""
            Dim Count As Integer = 0
            x = ""
            y = ""
            Text = "LASER System - Search Management [Please Wait....]"
            For i As Integer = 1 To _SearchPanelsAddedCount
                For Each c As Control In flpSearch.Controls.Find("txtSearch" & i.ToString, True)
                    If TypeOf c IsNot Label Then Exit For
                    If c.Text = "AND" Or c.Text = "OR" Or c.Text = "(" Or c.Text = ")" Then
                        x += " " + c.Text + " "
                        Exit For
                    ElseIf c.Text.Contains(":") Then
                        Dim tmptxt As String = c.Text
                        Dim tmplst() As String = tmptxt.Split(":")
                        Filter = tmplst(0)
                        Search = tmplst(1)
                        Symbol = "%"
                    ElseIf c.Text.Contains("=") Then
                        Dim tmptxt As String = c.Text
                        Dim tmplst() As String = tmptxt.Split("=")
                        Filter = tmplst(0)
                        Search = tmplst(1)
                        Symbol = ""
                    End If
                    Select Case Tag
                        Case FormSearchRequestSource.Sale
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
                                    x += " and Sale.CReceived like '%" & Search & "%'"
                                Case "Received"
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
                                    x += " and (REP.RepNo like '%" & Search & "%' or R.RNo like '%" & Search & "%' or RDate like '%" & Search & "%' or CU.CuNo like '%" & Search & "%' or CuName like '%" & Search & "%' or CuTelNo1 like '%" & Search & "%' or CuTelNo2 like '%" & Search & "%' or CuTelNo3 like '%" & Search & "%' or P.PNo like '%" & Search & "%' or PCategory like '%" & Search & "%' or PName like '%" & Search & "%' or PModelNo like '%" & Search & "%' or PSerialNo like '%" & Search & "%' or Problem like '%" & Search & "%' or PaidPrice like '%" & Search & "%' or T.TNo like '%" & Search & "%' or TName like '%" & Search & "%' or Status like '%" & Search & "%' or RepDate like '%" & Search & "%' or RepRemarks1 like '%" & Search & "%' or RepRemarks2 like '%" & Search & "%')"
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
                                    Dim DRSearch2
                                    DRSearch2 = Db.GetDataList("Select RetNo,Remarks from RepairRemarks1 Where Remarks like '%" & Search & "%' ")
                                    x += " RetNo IN ("
                                    For Each Item In DRSearch2
                                        x += Item("RetNo").ToString + ","
                                    Next
                                    If DRSearch2.Count Then x = x.Remove(x.Length - 1, 1)
                                    x += ") "
                                Case "Remarks by Technician"
                                    Dim CMDSearch2 As New OleDb.OleDbCommand
                                    Dim DRSearch2 = Db.GetDataList("Select RetNo,Remarks from RepairRemarks2 Where Remarks like '%" & Search &
                                                                        "%' ")
                                    x += " RetNo IN ( "
                                    For Each Item In DRSearch2
                                        x += Item("RetNo").ToString + ","
                                    Next
                                    If DRSearch2.Count Then x = x.Remove(x.Length - 1, 1)
                                    x += ") "
                                Case "All"
                                    x += " (RET.RETNo like '%" & Search & "%' or RET.RepNo like '%" & Search & "%' or R.RDate like '%" & Search & "%' or CU.CuName like '%" & Search & "%' or CU.CuTelNo1 like '%" & Search & "%' or CU.CuTelNo2 like '%" & Search & "%' or CU.CuTelNo3 like '%" & Search & "%' or P.PCategory like '%" & Search & "%' or P.PName like '%" & Search & "%' or P.PModelNo like '%" & Search & "%' or RET.PSerialNo like '%" & Search & "%' or RET.Problem like '%" & Search & "%' or RET.Charge like '%" & Search &
                                "%' or RET.PaidPrice like '%" & Search & "%' or T.TName like '%" & Search & "%' or RET.Status like '%" & Search & "%' or RET.RetRepDate like '%" & Search & "%' or D.DDate like '%" & Search & "%')"
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
                                    x += " and (RET.RETNo like '%" & Search & "%' or R.RNo like '%" & Search & "%' or R.RDate like '%" & Search & "%' or CU.CuName like '%" & Search & "%' or CU.CuTelNo1 like '%" & Search & "%' or CU.CuTelNo2 like '%" & Search & "%' or CU.CuTelNo3 like '%" & Search & "%' or P.PCategory like '%" & Search & "%' or P.PName like '%" & Search & "%' or P.PModelNo like '%" & Search & "%' or RET.PSerialNo like '%" & Search & "%' or RET.Problem like '%" & Search & "%' or RET.Charge like '%" & Search & "%' or T.TName like '%" & Search & "%' or RET.Status like '%" & Search & "%' or RET.RetRepDate like '%" & Search & "%' or RET.RETRemarks1 like '%" & Search & "%' or RET.RETRemarks2 like '%" & Search & "%') "
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bgwSearch_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwSearch.DoWork
        Dim Query As String = ""
        Select Case Tag
            Case "Sale"
                Query = "SELECT Sale.SaNo,Sale.SaDate,Sale.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3,Sale.SaSubTotal,Sale.SaLess,Sale.SaDue,Sale.CReceived,Sale.CBalance,Sale.CAmount,Sale.CPInvoiceNo,Sale.CPAmount,Sale.CuLNo,Sale.CuLAmount,Sale.SaRemarks from Sale,Customer where Customer.CuNo=Sale.CuNo " & x & " Order by SaDate Desc;"
            Case "Supply"
                Query = "SELECT Supply.SupNo,SupDate,Supply.SuNo,SuName,SupRemarks,SupStatus,SupPaidDate from (`Supply` Inner Join Supplier On Supplier.SuNo=Supply.SuNo) " & x & ";"
            Case "Receive"
                Query = "SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,RepRemarks1,Status,REP.TNo, TName,RepRemarks2,RepDate,Charge,REP.DNo, DDate, PaidPrice from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where (Status='Repaired Delivered' or Status='Returned Delivered') " & x & ";"
            Case "Deliver"
                Query = "SELECT Deliver.DNo,DDate,Customer.CuNo,CuName,CuTelNo1,CuTelNo2,CuTelNo3,DGrandTotal,CReceived,CBalance,CAmount,CPInvoiceNo,CPAmount,CuLNo,CuLAmount,DRemarks from Deliver,Customer where Customer.CuNo=Deliver.CuNo " & x & " Order by DDate Desc;"
            Case "ReRepair"
                Query = "SELECT RetNo, RepNo,Ret.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, Ret.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,Status, TName,RetREpDate,Charge,Ret.DNo, DDate, PaidPrice from (((((Return RET INNER JOIN RECEIVE R ON R.RNO = Ret.RNO) INNER JOIN PRODUCT  P ON P.PNO = Ret.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = Ret.TNO) LEFT JOIN DELIVER D ON D.DNO = Ret.DNO) " & x & ";"
            Case "DeliverRepair"
                Query = "SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,Charge, PaidPrice, REP.TNo, TName, Status, RepDate,REP.DNo, DDate from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' " & x & ";"
            Case "DeliverReRepair"
                Query = "SELECT RETNo,RET.RepNo,RET.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, RET.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,Charge, RET.TNo, TName, Status, RetRepDate from (((((RETURN RET INNER JOIN RECEIVE R ON R.RNO = RET.RNO) INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' " & x & ";"
        End Select
        Dim Rows_Count As Integer = Db.GetRowsCount(Query)
        Dim DRSearch1 = Db.GetDataList(Query)
        If Rows_Count < 1 Then Exit Sub
        Dim i As Integer = 0
        For Each Item In DRSearch1
            If bgwSearch.CancellationPending = True Then
                e.Cancel = True
                Exit For
            End If
            Select Case Tag
                Case "Sale"
                    grdSearch.Rows.Add(Item("SaNo").ToString, Item("SaDate").ToString, Item("CuNo").ToString, Item("CuName").ToString,
                                           Item("CuTelNo1").ToString, Item("CuTelNo2").ToString, Item("CuTelNo3").ToString,
                                           Item("SaSubTotal").ToString, Item("SaLess").ToString, Item("SaDue").ToString, Item("CReceived").ToString,
                                           Item("CBalance").ToString, Item("CAmount").ToString, Item("CPInvoiceNo").ToString,
                                           Item("CPAmount").ToString, Item("CuLNo").ToString, Item("CuLAmount").ToString,
                                           Item("SaRemarks").ToString)
                Case "Supply"
                    grdSearch.Rows.Add(Item("SupNo").ToString, Item("SupDate").ToString, Item("SuNo").ToString, Item("SuName").ToString,
                                           Item("SupStatus").ToString, Item("SupPaidDate").ToString, Item("SupRemarks").ToString)
                Case "Deliver"
                    grdSearch.Rows.Add(Item("DNo").ToString, Item("DDate").ToString, Item("CuName").ToString, Item("CuTelNo1").ToString,
                                       Item("CuTelNo2").ToString, Item("CuTelNo3").ToString, Item("DGrandTotal").ToString,
                                       Item("CReceived").ToString, Item("CBalance").ToString, Item("CAmount").ToString,
                                       Item("CPInvoiceNo").ToString, Item("CPAmount").ToString,
                                       Item("CuLNo").ToString, Item("CuLAmount").ToString, Item("DRemarks").ToString)
                Case "Receive"
                    grdSearch.Rows.Add(Item("RepNo").ToString, Item("RDate").ToString, Item("CuName").ToString, Item("CuTelNo1").ToString,
                                               Item("CuTelNo2").ToString, Item("CuTelNo3").ToString, Item("PCategory").ToString,
                                               Item("PName").ToString, Item("PModelNo").ToString, Item("PSerialNo").ToString, Item("Problem").ToString,
                                               Item("Qty").ToString, Item("RepRemarks1").ToString,
                                               Item("Status").ToString, Item("TName").ToString, Item("RepRemarks2").ToString, Item("RepDate").ToString,
                                               Item("Charge").ToString, Item("DDate").ToString, Item("PaidPrice").ToString)
                Case "DeliverRepair"
                    grdSearch.Rows.Add(Item("RepNo").ToString(), Item("RDate").ToString(), Item("CuName").ToString(), Item("CuTelNo1").ToString(),
                            Item("CuTelNo2").ToString(), Item("CuTelNo3").ToString(), Item("PCategory").ToString(), Item("PName").ToString(),
                            Item("PModelNo").ToString(), Item("PSerialNo").ToString(), Item("Problem").ToString(), Item("Location").ToString(),
                            Item("Qty").ToString(), "",
                            Item("Status").ToString(), Item("TName").ToString(), "", Item("RepDate").ToString(), Item("Charge").ToString(),
                            Item("DDate").ToString(), Item("PaidPrice").ToString())
                    If (grdSearch.Item("Status", grdSearch.Rows.Count - 1).Value = "Repaired Delivered" Or
                            grdSearch.Item("Status", grdSearch.Rows.Count - 1).Value = "Returned Delivered") Then
                        grdSearch.Rows.Item(grdSearch.Rows.Count - 1).ReadOnly = True
                    End If
                Case "ReRepair", "DeliverReRepair"
                    grdSearch.Rows.Add(Item("RetNo").ToString, Item("RepNo").ToString, Item("RDate").ToString, Item("CuName").ToString,
                                        Item("CuTelNo1").ToString,
                                        Item("CuTelNo2").ToString, Item("CuTelNo3").ToString, Item("PCategory").ToString, Item("PName").ToString,
                                        Item("PModelNo").ToString, Item("PSerialNo").ToString, Item("Problem").ToString, Item("Qty").ToString,
                                        "", Item("Status").ToString, Item("TName").ToString, "",
                                        Item("RetRepDate").ToString, Item("Charge").ToString, Item("DDate").ToString, Item("PaidPrice").ToString)
            End Select
            i += 1
            bgwSearch.ReportProgress((i * 100) / Rows_Count, $"Transfering Data ({i}/{Rows_Count})....]")
        Next
        bgwSearch.ReportProgress(100, "Completed...")
    End Sub

    Private Sub BgwSearch_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwSearch.ProgressChanged
        Text = $"LASER System - Search Management [{e.UserState}]"
        ProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub bgwSearch_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwSearch.RunWorkerCompleted
        Text = "LASER System - Search Management"
        If cmdTSSearch.Tag = "Restart" Then
            cmdTSSearch.Tag = ""
            CmdTSSearch_Click(sender, e)
            Exit Sub
        End If
        ProgressBar.Visible = False
        grdSearch.Refresh()
        grdSearch.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub FrmSearch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub frmSearch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        bgwSearch.CancelAsync()
        e.Cancel = False
        Tag = ""
    End Sub

    Private Sub grdSearch_SelectionChanged(sender As Object, e As EventArgs)
        Select Case Tag
            Case "Repair"
                frmDatagridviewTool.frm_Close()
                If grdSearch.CurrentCell.ColumnIndex = 13 Then
                    Dim DT As DataTable = Db.GetDataTable("Select Rem1Date as `Date`,Remarks,UserName as `User` from (RepairRemarks1 RepRem1 Left join `User` U on U.Uno= RepRem1.UNo) Where RepNo=" & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value)
                    If DT.Rows.Count > 0 Then
                        frmDatagridviewTool.Tag = "RepRem"
                        frmDatagridviewTool.frm_Open(grdSearch, Me, DT)
                    End If
                ElseIf grdSearch.CurrentCell.ColumnIndex = 16 Then
                    Dim DT As DataTable = Db.GetDataTable("Select Rem2Date as `Date`,Remarks,UserName as `User` from (RepairRemarks2 RepRem2 Left join `User` U on U.Uno= RepRem2.UNo) Where RepNo=" & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value)
                    If DT.Rows.Count > 0 Then
                        frmDatagridviewTool.Tag = "RepRem"
                        frmDatagridviewTool.frm_Open(grdSearch, Me, DT)
                    End If
                End If
            Case "Deliver"
                Dim DR = Db.GetDataList("Select RepNo,PCategory,PName,Qty,PaidPrice,TName,Status from (((Repair Rep Inner Join Deliver D On D.DNo=Rep.DNo) Inner Join Product P On p.pno = Rep.pno) Inner Join Technician T On T.TNo = Rep.TNo) Where D.DNo = " &
                                             grdSearch.Item(0, grdSearch.CurrentRow.Index).Value.ToString)
                GridSubSearchLeft.Rows.Clear()
                For Each Item In DR
                    GridSubSearchLeft.Rows.Add(Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString,
                                            Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
                Next
                DR = Db.GetDataList("Select RetNo, RepNo, PCategory, PName, Qty, PaidPrice, TName, Status from (((`Return` Ret Inner Join Deliver D On D.DNo = Ret.DNo) Inner Join Product P On p.pno = Ret.pno) Inner Join Technician T On T.TNo = Ret.TNo) Where D.DNo = " & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value.ToString)
                GridSubSearchRight.Rows.Clear()
                For Each Item In DR
                    GridSubSearchRight.Rows.Add(Item("RetNo").ToString, Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString,
                                        Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
                Next
        End Select
    End Sub

    Private Sub grdSearch_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        If Tag = "Repair" Then
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

    Private Sub grdSearch_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        Select Case Tag
            Case "Repair"
                If e.RowIndex < 0 Or e.RowIndex >= grdSearch.Rows.Count Then Exit Sub
                grdSearch.Item("Charge", e.RowIndex).ErrorText = ""
                grdSearch.Item("Status", e.RowIndex).ErrorText = ""

                If grdSearch.Item("Status", e.RowIndex).Value.ToString <> RepairStatus.Received AndAlso
                grdSearch.Item("TName", e.RowIndex).Value = "" Then
                    grdSearch.Item("Status", e.RowIndex).ErrorText = "Technician Name යන Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න."
                    Exit Sub
                End If

                If grdSearch.Item("Status", e.RowIndex).Value = RepairStatus.Repaired Or grdSearch.Item("Status", e.RowIndex).Value.ToString =
                                RepairStatus.Returned Or grdSearch.Item("Status", e.RowIndex).Value.ToString = "Repaired Delivered" Or
                                grdSearch.Item("Status", e.RowIndex).Value.ToString = "Returned Delivered" Then
                    If grdSearch.Item("RepDate", e.RowIndex).Value.ToString = "" Then grdSearch.Item("RepDate", e.RowIndex).Value = DateAndTime.Now
                    If grdSearch.Item("Charge", e.RowIndex).Value = "" Then
                        grdSearch.Item("Charge", e.RowIndex).ErrorText = "Repair Charge යන Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න."
                        Exit Sub
                    End If
                End If
        End Select
    End Sub

    Private Sub grdSearch_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If Tag = "Repair" Then
            If grdSearch.CurrentCell.ColumnIndex = 17 Then
                dtpDate.Location = grdSearch.GetCellDisplayRectangle(grdSearch.CurrentCell.ColumnIndex, grdSearch.CurrentCell.RowIndex, True).Location
                dtpDate.Size = New Size(grdSearch.Columns.Item(grdSearch.CurrentCell.ColumnIndex).Width, grdSearch.Rows.Item(grdSearch.CurrentCell.RowIndex).Height)
            ElseIf grdSearch.CurrentCell.ColumnIndex = 11 Then
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, grdSearch, Me, "Select Location from Repair group by Location;", "Location")
            End If
        End If
    End Sub

    Private Sub GrdSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If Tag = "" Or e.RowIndex < 0 Then
            Exit Sub
        End If
        If Tag <> "Repair" Then Enabled = False
        Select Case Tag
            Case "Sale"
                For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
                    If oForm.Name = Key Then
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
                                DR = Db.GetDataList("Select Stock.SNo,Stock.SCategory,Stock.SName,StockSale.SaType,StockSale.SaUnits,StockSale.SaRate,SaTotal from StockSale,Stock where StockSale.SNo = Stock.SNo And SaNo = " & .txtSaNo.Text & ";")
                                For Each Item In DR
                                    .grdSale.Rows.Add(Item("SNo").ToString(), Item("SCategory").ToString(), Item("SName").ToString(), Item("SaType").ToString(), Item("SaRate").ToString(), Item("SaUnits").ToString(), Int(Item("SaTotal")))
                                Next
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
                    .cmdNew_Click(sender, e)
                    If index >= 0 Then
                        selectedrow = grdSearch.Rows(index)
                        .txtSupNo.Text = selectedrow.Cells("SupNo").Value.ToString
                        .txtSupDate.Text = selectedrow.Cells("SupDate").Value.ToString
                        .cmbSuName.Text = selectedrow.Cells("SuName").Value.ToString
                        .txtSupRemarks.Text = selectedrow.Cells("SupRemarks").Value.ToString
                        .cmbSupStatus.Text = selectedrow.Cells("SupStatus").Value.ToString
                        If selectedrow.Cells("SupPaidDate").Value <> "" And
                            selectedrow.Cells("SupStatus").Value = "Paid" Then .txtSupPaidDate.Value = selectedrow.Cells("SupPaidDate").Value
                        DR = Db.GetDataList($"Select Sup.SNo,S.SCategory,S.SName,SModelNo,SLocation,SSalePrice,SLowestPrice,SMinStocks,SupType,SupUnits,SupCostPrice,SDetails from StockSupply Sup,Stock S where Sup.SNo = S.SNo And SupNo={ .txtSupNo.Text};")
                        For Each Item In DR
                            .grdSupply.Rows.Add(Item(Stock.Code), Item(Stock.Category), Item(Stock.Name), Item(Stock.ModelNo), Item(Stock.Location), Item(Stock.SalePrice), Item(Stock.LowestPrice), Item(Stock.ReorderPoint), Item("SupType"), Item("SupCostPrice"), Item("SupUnits"), Int(Item("SupUnits")) * Int(Item("SupCostPrice")), Item(Stock.Details))
                        Next
                    End If
                    .cmdSave.Text = "Edit"
                    If User.Instance.UserType = User.Type.Admin Then
                        .cmdDelete.Enabled = True
                    End If
                End With
            Case "Receive"
                'With frmReceive
                '    Dim selectedrow As DataGridViewRow
                '    If e.RowIndex >= 0 Then
                '        selectedrow = grdSearch.Rows(e.RowIndex)
                '        .cmbRetRepNo.Text = selectedrow.Cells(0).Value.ToString
                '        CMD = New OleDb.OleDbCommand("Select * from Repair,Product where Repair.PNo = Product.PNo And RepNo = " & .cmbRetRepNo.Text & ";", CNN) 'This is the copy of cmbrepretno.selectedindexchange()
                '        DR = CMD.ExecuteReader()
                '        If DR.Count Then
                '            
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
                With FormDeliver
                    .txtDNo.Text = grdSearch.Item(0, e.RowIndex).Value
                    .cmdSave.Text = "Edit"
                    DR = Db.GetDataDictionary("Select D.*,CuName,CuTelNo1,CuTelNo2,CuTelNo3 from (Deliver D Inner Join Customer Cu On Cu.CuNo = D.CuNo) Where DNo=" & .txtDNo.Text)
                    If DR IsNot Nothing Then

                        .txtDDate.Value = DR("DDate").ToString
                        .cmbCuName.Text = DR("CuName").ToString
                        .txtCuTelNo1.Text = DR("CuTelNo1").ToString
                        .txtCuTelNo2.Text = DR("CuTelNo2").ToString
                        .txtCuTelNo3.Text = DR("CuTelNo3").ToString
                        .txtDRemarks.Text = DR("DRemarks").ToString
                        Dim DR1 = Db.GetDataList("Select RepNo,REP.PNo,PCategory,PName,Qty,Status,REP.TNo, TName,PaidPrice from (((Repair REP INNER JOIN PRODUCT  P On P.PNO = REP.PNO) LEFT JOIN Technician T On T.TNO = REP.TNO) LEFT JOIN DELIVER D On D.DNO = REP.DNO) Where D.DNo=" & .txtDNo.Text)
                        .grdRepair.Rows.Clear()
                        For Each Item In DR1
                            .grdRepair.Rows.Add(Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString, Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
                        Next
                        DR1 = Db.GetDataList("Select RetNo, RepNo, RET.PNo, PCategory, PName, Qty, Status, RET.TNo, TName, PaidPrice from (((`Return` RET INNER JOIN PRODUCT  P On P.PNO = RET.PNO) LEFT JOIN Technician T On T.TNO = RET.TNO) LEFT JOIN DELIVER D On D.DNO = RET.DNO) Where D.DNo=" & .txtDNo.Text)
                        .grdRERepair.Rows.Clear()
                        For Each Item In DR1
                            .grdRERepair.Rows.Add(Item("RetNo").ToString, Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString, Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
                        Next
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
                With FormDeliver
                    .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = grdSearch.Item(0, grdSearch.CurrentCell.RowIndex).Value
                    Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
                    Call .GrdRepair_CellEndEdit(sender, E1)
                End With
            Case "DeliverReRepair"
                With FormDeliver
                    .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = grdSearch.Item(0, grdSearch.CurrentCell.RowIndex).Value
                    Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
                    Call .GrdRepair_CellEndEdit(sender, E1)
                End With
        End Select
        If Tag <> "Repair" Then
            Enabled = True
            Close()
        End If
    End Sub

    Private Sub frmSearch_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
            frmSearchDropDown.frm_Move()
        End If
    End Sub

    Private Sub GrdSearch_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        Dim currentvalue As String = "", previousvalue As String = ""
        If grdSearch.Item(e.ColumnIndex, e.RowIndex).Value IsNot Nothing Then currentvalue = grdSearch.Item(e.ColumnIndex, e.RowIndex).Value
        If grdSearch.Item(e.ColumnIndex, e.RowIndex).Tag IsNot Nothing Then previousvalue = grdSearch.Item(e.ColumnIndex, e.RowIndex).Tag
        Dim UNo As Integer = User.Instance.UserNo
        If Tag = "Repair" Then
            If e.ColumnIndex = 11 Then frmSearchDropDown.frm_Close()
            If e.ColumnIndex = 13 Or e.ColumnIndex = 16 Then frmDatagridviewTool.frm_Close()
            Task.Run(Sub()
                         Select Case e.ColumnIndex
                             Case 9, 10, 11, 14
                                 If previousvalue <> currentvalue Then
                                     Db.Execute($"UPDATE {Tables.Repair} SET " & grdSearch.Columns(e.ColumnIndex).Name & " ='" & currentvalue & "' where repno = " &
                  grdSearch.Item(0, e.RowIndex).Value)
                                     Db.Execute($"INSERT INTO {Tables.RepairActivity}(RepNo,RepADate,Activity,UNo) Values(" &
 grdSearch.Item(0, e.RowIndex).Value & ",'" & DateAndTime.Now & "','" & grdSearch.Columns(e.ColumnIndex).HeaderText & " -> " &
 currentvalue & "'," & UNo & ")")
                                 End If
                             Case 13    'Remarks by Customer
                                 If currentvalue <> "" Then
                                     Db.Execute($"INSERT INTO {Tables.RepairRemarks1}(Rem1No,RepNo,Rem1Date,Remarks,UNo) Values(" &
                          Db.GetNextKey("RepairRemarks1", "Rem1No") & "," &
                  grdSearch.Item(0, e.RowIndex).Value & ",'" & DateAndTime.Now & "','" & grdSearch.Item(13, e.RowIndex).Value & "'," &
                  UNo & ")")
                                     grdSearch.Item(13, e.RowIndex).Value = ""
                                 End If
                             Case 15    'Technician Name
                                 Dim tmp As String = ""
                                 If currentvalue <> "" And grdSearch.Item("Status", e.RowIndex).Value = RepairStatus.Received Then
                                     grdSearch.Item("Status", e.RowIndex).Value = RepairStatus.HandedOverTo
                                     tmp = ",Status = 'Hand Over to Technician'"
                                 End If
                                 If previousvalue <> currentvalue Then
                                     Dim TNo As String = Db.GetData("Select TNo from Technician WHERE TNAME='" &
                                                                                grdSearch.Item("TName", e.RowIndex).Value & "'")
                                     Db.Execute($"UPDATE {Tables.Repair} SET tno ={TNo}{tmp} where repno=" & grdSearch.Item(0, e.RowIndex).Value & ";")
                                     Db.Execute($"Insert into RepairActivity(RepNo, RepADate, Activity, UNo)
                                     Values({grdSearch.Item(0, e.RowIndex).Value},'{ DateAndTime.Now }',
                                'Technician -> {grdSearch.Item("TName", e.RowIndex).Value}{tmp.Replace("'", "")}',
                                " & UNo & ")")
                                 End If
                             Case 16    'Remarks by Technician
                                 If currentvalue <> "" Then
                                     Db.Execute($"INSERT INTO {Tables.RepairRemarks2}(Rem2No,RepNo,Rem2Date,Remarks,UNo) Values(" &
                          Db.GetNextKey("RepairRemarks2", "Rem2No") & "," &
                  grdSearch.Item(0, e.RowIndex).Value & ",'" & DateAndTime.Now & "','" & grdSearch.Item(16, e.RowIndex).Value & "'," &
                  UNo & ")")
                                     grdSearch.Item(16, e.RowIndex).Value = ""
                                 End If
                             Case 17    'Repaired Date
                                 grdSearch.CurrentCell.Value = dtpDate.Value.ToString
                                 dtpDate.Visible = False
                                 If Db.GetData("Select RepDate from Repair Where RepNo=" & grdSearch.Item(0, e.RowIndex).Value) <>
                                 currentvalue Then
                                     Db.Execute($"UPDATE {Tables.Repair} SET repdate='" & currentvalue & "' where repno=" & grdSearch.Item(0, e.RowIndex).Value & ";")
                                     Db.Execute($"INSERT INTO {Tables.RepairActivity}(RepNo,RepADate,Activity,UNo) Values(" &
                          grdSearch.Item(0, e.RowIndex).Value & ",'" & DateAndTime.Now & "','Repaired Date එක " & currentvalue &
                          " වෙනස් කෙරුණි.'," & UNo & ")")
                                 End If
                             Case 18    'Repair Charge
                                 If currentvalue <> previousvalue Then
                                     grdSearch.Item(17, e.RowIndex).Value = DateAndTime.Now
                                     If currentvalue = "0" Then
                                         grdSearch.Item(14, e.RowIndex).Value = RepairStatus.Returned
                                     Else
                                         grdSearch.Item(14, e.RowIndex).Value = RepairStatus.Repaired
                                     End If
                                     Db.Execute($"UPDATE {Tables.Repair} SET Status ='" & grdSearch.Item(14, e.RowIndex).Value &
                              "',RepDate='" & grdSearch.Item(17, e.RowIndex).Value &
                              "',Charge=" & currentvalue & " where repno=" &
                              grdSearch.Item(0, e.RowIndex).Value & ";")
                                     Db.Execute($"INSERT INTO {Tables.RepairActivity}(RepNo,RepADate,Activity,UNo) Values(" &
             grdSearch.Item(0, e.RowIndex).Value & ",'" & DateAndTime.Now & "','Repaired Date -> " & grdSearch.Item(17, e.RowIndex).Value &
             ", Status -> " & grdSearch.Item(14, e.RowIndex).Value &
             ", Repair Charge -> " & currentvalue &
             "'," & UNo & ")")
                                 End If
                         End Select
                     End Sub)
        End If
    End Sub

    Private Sub SearchSubmission(WhereQuery As String, Values As MySqlParameter()) Handles ControlSearchEngine.SearchSubmissionEvent
        GridControl.SearchSubmission(WhereQuery, Values)
    End Sub

    Private Sub txtTSSearch_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 58 Or Asc(e.KeyChar) = 61 Then
            e.Handled = True
        End If
    End Sub

End Class

Public Enum FormSearchRequestSource
    Repair
    ReRepair
    Sale
    Supply
    Deliver
    Receive
    DeliverRepair
    DeliverReRepair
End Enum