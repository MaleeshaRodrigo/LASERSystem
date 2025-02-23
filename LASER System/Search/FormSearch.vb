Imports System.ComponentModel
Imports MySqlConnector
Imports LASER_System.StructureDatabase

Public Class FormSearch
    Public Property RequestSource As FormSearchRequestSource
    Public Property Key As String

    Private Db As New Database
    Private x, y As String
    Private GridControl As GridSearchControl
    Private ReadOnly dtpDate As New DateTimePicker

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        MenuStrip.Items.Add(mnustrpMENU)
        'Text = "LASER System - Search Management [Prepairing Sheet....]"
        'Select Case RequestSource
        '    Case FormSearchRequestSource.Deliver
        '        GridSubSearchLeft.Columns.Clear()
        '        GridSubSearchLeft.Columns.Add("RepNo", "Repair No")
        '        GridSubSearchLeft.Columns.Add("PCategory", "Product Category")
        '        GridSubSearchLeft.Columns.Add("PName", "Product Name")
        '        GridSubSearchLeft.Columns.Add("Qty", "Qty")
        '        GridSubSearchLeft.Columns.Add("PaidPrice", "Paid Charge")
        '        GridSubSearchLeft.Columns.Add("TName", "Technician Name")
        '        GridSubSearchLeft.Columns.Add("Status", "Status")
        '        GridSubSearchLeft.Rows.Clear()
        '        GridSubSearchLeft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        '        GridSubSearchRight.Columns.Clear()
        '        GridSubSearchRight.Columns.Add("REREpNo", "RE-Repair No")
        '        GridSubSearchRight.Columns.Add("RepNo", "Repair No")
        '        GridSubSearchRight.Columns.Add("PCategory", "Product Category")
        '        GridSubSearchRight.Columns.Add("PName", "Product Name")
        '        GridSubSearchRight.Columns.Add("Qty", "Qty")
        '        GridSubSearchRight.Columns.Add("PaidPrice", "Paid Charge")
        '        GridSubSearchRight.Columns.Add("TName", "Technician Name")
        '        GridSubSearchRight.Columns.Add("Status", "Status")
        '        GridSubSearchLeft.Rows.Clear()
        '        GridSubSearchRight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '    Case FormSearchRequestSource.Repair
        '        GridControl = New GridRepairSearchControl()
        '        GridControl.Init(Db, Me)
        '        Controls.Add(GridControl)
        '        GridControl.Control.Dock = DockStyle.Fill
        '    Case FormSearchRequestSource.ReRepair
        '        GridControl = New GridRepairSearchControl().SetMode(RepairMode.ReRepair)
        '        GridControl.Init(Db, Me)
        '        Controls.Add(GridControl)
        '        GridControl.Control.Dock = DockStyle.Fill
        'End Select
        Select Case RequestSource
            Case FormSearchRequestSource.Repair
                GridControl = New GridRepairSearchControl()
            Case FormSearchRequestSource.ReRepair
                GridControl = New GridRepairSearchControl().SetMode(RepairMode.ReRepair)
            Case FormSearchRequestSource.Sale
                GridControl = New GridSaleSearchControl()
            Case FormSearchRequestSource.Supply
                GridControl = New GridSupplySearchControl()
            Case FormSearchRequestSource.Deliver
                GridControl = New GridDeliverSearchControl()
            Case Else
                Throw New Exception("Invalid Request Source")
        End Select
        GridControl.Init(Db, Me)
        PanelGrid.Controls.Add(GridControl)
        GridControl.Control.Dock = DockStyle.Fill
        ControlSearchEngine.Init(GridControl.GetFilterDictionary())
    End Sub

    Private Function GetControlSeachInitDictionary() As Dictionary(Of String, String)
        Select Case Tag
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
                    {"RepRemarks1", "Remarks For Customer"},
                    {"Status", "Status"},
                    {"TName", "Technician Name"},
                    {"RepRemarks2", "Remarks For Technician"},
                    {"RepDate", "Repaired Date"},
                    {"RepCharge", "Repair Charge"},
                    {"DNo", "Deliver No"},
                    {"DDate", "Delivered Date"},
                    {"PaidPrice", "Paid Repair Charge"}
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
                    {"RepRemarks1", "Remarks For Customer"},
                    {"Status", "Status"},
                    {"TName", "Technician Name"},
                    {"RepRemarks2", "Remarks For Technician"},
                    {"RepDate", "Repaired Date"},
                    {"RepCharge", "Repair Charge"},
                    {"DDate", "Delivered Date"},
                    {"PaidPrice", "Paid Repair Charge"}
                }
            Case Else
                Throw New Exception("Invalid Request Source")
        End Select
    End Function

    Private Sub bgwSearch_DoWork(sender As Object, e As DoWorkEventArgs)
        'Dim Query As String = ""
        'Select Case Tag
        '    Case "Receive"
        '        Query = "Select RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,RepRemarks1,Status,REP.TNo, TName,RepRemarks2,RepDate,Charge,REP.DNo, DDate, PaidPrice from (((((Repair REP INNER JOIN RECEIVE R On R.RNO = REP.RNO) INNER JOIN PRODUCT  P On P.PNO = REP.PNO) INNER JOIN CUSTOMER CU On CU.CUNO = R.CUNO) LEFT JOIN Technician T On T.TNO = REP.TNO) LEFT JOIN DELIVER D On D.DNO = REP.DNO) Where (Status='Repaired Delivered' or Status='Returned Delivered') " & x & ";"
        '    Case "DeliverRepair"
        '        Query = "SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,Charge, PaidPrice, REP.TNo, TName, Status, RepDate,REP.DNo, DDate from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' " & x & ";"
        '    Case "DeliverReRepair"
        '        Query = "SELECT RETNo,RET.RepNo,RET.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, RET.PNo,PCategory,PName, PModelNo, PSerialNo,Problem,Qty,Charge, RET.TNo, TName, Status, RetRepDate from (((((RETURN RET INNER JOIN RECEIVE R ON R.RNO = RET.RNO) INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' " & x & ";"
        'End Select
        'Dim Rows_Count As Integer = Db.GetRowsCount(Query)
        'Dim DRSearch1 = Db.GetDataList(Query)
        'If Rows_Count < 1 Then Exit Sub
        'Dim i As Integer = 0
        'For Each Item In DRSearch1
        '    If bgwSearch.CancellationPending = True Then
        '        e.Cancel = True
        '        Exit For
        '    End If
        '    Select Case Tag
        '        Case "Receive"
        '            grdSearch.Rows.Add(Item("RepNo").ToString, Item("RDate").ToString, Item("CuName").ToString, Item("CuTelNo1").ToString,
        '                                       Item("CuTelNo2").ToString, Item("CuTelNo3").ToString, Item("PCategory").ToString,
        '                                       Item("PName").ToString, Item("PModelNo").ToString, Item("PSerialNo").ToString, Item("Problem").ToString,
        '                                       Item("Qty").ToString, Item("RepRemarks1").ToString,
        '                                       Item("Status").ToString, Item("TName").ToString, Item("RepRemarks2").ToString, Item("RepDate").ToString,
        '                                       Item("Charge").ToString, Item("DDate").ToString, Item("PaidPrice").ToString)
        '        Case "DeliverRepair"
        '            grdSearch.Rows.Add(Item("RepNo").ToString(), Item("RDate").ToString(), Item("CuName").ToString(), Item("CuTelNo1").ToString(),
        '                    Item("CuTelNo2").ToString(), Item("CuTelNo3").ToString(), Item("PCategory").ToString(), Item("PName").ToString(),
        '                    Item("PModelNo").ToString(), Item("PSerialNo").ToString(), Item("Problem").ToString(), Item("Location").ToString(),
        '                    Item("Qty").ToString(), "",
        '                    Item("Status").ToString(), Item("TName").ToString(), "", Item("RepDate").ToString(), Item("Charge").ToString(),
        '                    Item("DDate").ToString(), Item("PaidPrice").ToString())
        '            If (grdSearch.Item("Status", grdSearch.Rows.Count - 1).Value = "Repaired Delivered" Or
        '                    grdSearch.Item("Status", grdSearch.Rows.Count - 1).Value = "Returned Delivered") Then
        '                grdSearch.Rows.Item(grdSearch.Rows.Count - 1).ReadOnly = True
        '            End If
        '        Case "DeliverReRepair"
        '            grdSearch.Rows.Add(Item("RetNo").ToString, Item("RepNo").ToString, Item("RDate").ToString, Item("CuName").ToString,
        '                                Item("CuTelNo1").ToString,
        '                                Item("CuTelNo2").ToString, Item("CuTelNo3").ToString, Item("PCategory").ToString, Item("PName").ToString,
        '                                Item("PModelNo").ToString, Item("PSerialNo").ToString, Item("Problem").ToString, Item("Qty").ToString,
        '                                "", Item("Status").ToString, Item("TName").ToString, "",
        '                                Item("RetRepDate").ToString, Item("Charge").ToString, Item("DDate").ToString, Item("PaidPrice").ToString)
        '    End Select
        '    i += 1
        '    bgwSearch.ReportProgress((i * 100) / Rows_Count, $"Transfering Data ({i}/{Rows_Count})....]")
        'Next
        'bgwSearch.ReportProgress(100, "Completed...")
    End Sub

    Private Sub FrmSearch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
        End If
    End Sub

    Private Sub grdSearch_SelectionChanged(sender As Object, e As EventArgs)
        'Select Case Tag
        '    Case "Deliver"
        '        Dim DR = Db.GetDataList("Select RepNo,PCategory,PName,Qty,PaidPrice,TName,Status from (((Repair Rep Inner Join Deliver D On D.DNo=Rep.DNo) Inner Join Product P On p.pno = Rep.pno) Inner Join Technician T On T.TNo = Rep.TNo) Where D.DNo = " &
        '                                     grdSearch.Item(0, grdSearch.CurrentRow.Index).Value.ToString)
        '        GridSubSearchLeft.Rows.Clear()
        '        For Each Item In DR
        '            GridSubSearchLeft.Rows.Add(Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString,
        '                                    Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
        '        Next
        '        DR = Db.GetDataList("Select RetNo, RepNo, PCategory, PName, Qty, PaidPrice, TName, Status from (((`Return` Ret Inner Join Deliver D On D.DNo = Ret.DNo) Inner Join Product P On p.pno = Ret.pno) Inner Join Technician T On T.TNo = Ret.TNo) Where D.DNo = " & grdSearch.Item(0, grdSearch.CurrentRow.Index).Value.ToString)
        '        GridSubSearchRight.Rows.Clear()
        '        For Each Item In DR
        '            GridSubSearchRight.Rows.Add(Item("RetNo").ToString, Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString,
        '                                Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
        '        Next
        'End Select
    End Sub

    Private Sub GrdSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'If Tag = "" Or e.RowIndex < 0 Then
        '    Exit Sub
        'End If
        'If Tag <> "Repair" Then Enabled = False
        'Select Case Tag
        '    Case "Sale"
        '        For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
        '            If oForm.Name = Key Then
        '                With oForm
        '                    Dim index As Integer
        '                    index = e.RowIndex
        '                    Dim selectedrow As DataGridViewRow
        '                    .cmdNew.PerformClick()
        '                    If index >= 0 Then
        '                        selectedrow = grdSearch.Rows(index)
        '                        .txtSaNo.Text = selectedrow.Cells(0).Value.ToString
        '                        .txtSaDate.Text = selectedrow.Cells(1).Value.ToString
        '                        .cmbCuName.Text = selectedrow.Cells(3).Value.ToString
        '                        .txtCuTelNo1.Text = selectedrow.Cells(4).Value.ToString
        '                        .txtCuTelNo2.Text = selectedrow.Cells(5).Value.ToString
        '                        .txtCuTelNo3.Text = selectedrow.Cells(6).Value.ToString
        '                        .txtSubTotal.Text = selectedrow.Cells(7).Value.ToString
        '                        .txtLess.Text = selectedrow.Cells(8).Value.ToString
        '                        .txtDue.Text = selectedrow.Cells(9).Value.ToString
        '                        .txtCReceived.Text = selectedrow.Cells(10).Value.ToString
        '                        .txtCBalance.Text = selectedrow.Cells(11).Value.ToString
        '                        .txtCAmount.Text = selectedrow.Cells(12).Value.ToString
        '                        .txtCPInvoiceNo.Text = selectedrow.Cells(13).Value.ToString
        '                        .txtCPAmount.Text = selectedrow.Cells(14).Value.ToString
        '                        .txtCuLNo.Text = selectedrow.Cells(15).Value.ToString
        '                        .txtCuLAmount.Text = selectedrow.Cells(16).Value.ToString
        '                        .txtSaRemarks.Text = selectedrow.Cells(17).Value.ToString
        '                        DR = Db.GetDataList("Select Stock.SNo,Stock.SCategory,Stock.SName,StockSale.SaType,StockSale.SaUnits,StockSale.SaRate,SaTotal from StockSale,Stock where StockSale.SNo = Stock.SNo And SaNo = " & .txtSaNo.Text & ";")
        '                        For Each Item In DR
        '                            .grdSale.Rows.Add(Item("SNo").ToString(), Item("SCategory").ToString(), Item("SName").ToString(), Item("SaType").ToString(), Item("SaRate").ToString(), Item("SaUnits").ToString(), Int(Item("SaTotal")))
        '                        Next
        '                    End If
        '                    .cmdSave.Text = "Edit"
        '                    .cmdDelete.Enabled = True
        '                End With
        '                Exit For
        '            End If
        '        Next
        '    Case "Supply"
        '        With frmSupply
        '            Dim index As Integer
        '            index = e.RowIndex
        '            Dim selectedrow As DataGridViewRow
        '            .cmdNew_Click(sender, e)
        '            If index >= 0 Then
        '                selectedrow = grdSearch.Rows(index)
        '                .txtSupNo.Text = selectedrow.Cells("SupNo").Value.ToString
        '                .txtSupDate.Text = selectedrow.Cells("SupDate").Value.ToString
        '                .cmbSuName.Text = selectedrow.Cells("SuName").Value.ToString
        '                .txtSupRemarks.Text = selectedrow.Cells("SupRemarks").Value.ToString
        '                .cmbSupStatus.Text = selectedrow.Cells("SupStatus").Value.ToString
        '                If selectedrow.Cells("SupPaidDate").Value <> "" And
        '                    selectedrow.Cells("SupStatus").Value = "Paid" Then .txtSupPaidDate.Value = selectedrow.Cells("SupPaidDate").Value
        '                DR = Db.GetDataList($"Select Sup.SNo,S.SCategory,S.SName,SModelNo,SLocation,SSalePrice,SLowestPrice,SMinStocks,SupType,SupUnits,SupCostPrice,SDetails from StockSupply Sup,Stock S where Sup.SNo = S.SNo And SupNo={ .txtSupNo.Text};")
        '                For Each Item In DR
        '                    .grdSupply.Rows.Add(Item(Stock.Code), Item(Stock.Category), Item(Stock.Name), Item(Stock.ModelNo), Item(Stock.Location), Item(Stock.SalePrice), Item(Stock.LowestPrice), Item(Stock.ReorderPoint), Item("SupType"), Item("SupCostPrice"), Item("SupUnits"), Int(Item("SupUnits")) * Int(Item("SupCostPrice")), Item(Stock.Details))
        '                Next
        '            End If
        '            .cmdSave.Text = "Edit"
        '            If User.Instance.UserType = User.Type.Admin Then
        '                .cmdDelete.Enabled = True
        '            End If
        '        End With
        '    Case "Receive"
        '        'With frmReceive
        '        '    Dim selectedrow As DataGridViewRow
        '        '    If e.RowIndex >= 0 Then
        '        '        selectedrow = grdSearch.Rows(e.RowIndex)
        '        '        .cmbRetRepNo.Text = selectedrow.Cells(0).Value.ToString
        '        '        CMD = New OleDb.OleDbCommand("Select * from Repair,Product where Repair.PNo = Product.PNo And RepNo = " & .cmbRetRepNo.Text & ";", CNN) 'This is the copy of cmbrepretno.selectedindexchange()
        '        '        DR = CMD.ExecuteReader()
        '        '        If DR.Count Then
        '        '            
        '        '            .txtRetPNo.Text = DR("Product.PNo").ToString
        '        '            .cmbRetPCategory.Text = DR("PCategory").ToString
        '        '            .cmbRetPName.Text = DR("PName").ToString
        '        '            .txtRetPModelNo.Text = DR("PModelNo").ToString
        '        '            .txtRetPSerialNo.Text = DR("PSerialNo").ToString
        '        '            .txtRetPDetails.Text = DR("PDetails").ToString
        '        '            .txtRetPQty.Text = DR("Qty").ToString
        '        '        End If
        '        '        .cmbRetRepNo.Focus()
        '        '    End If
        '        'End With
        '    Case "Deliver"
        '        bgwSearch.CancelAsync()
        '        With FormDeliver
        '            .txtDNo.Text = grdSearch.Item(0, e.RowIndex).Value
        '            .cmdSave.Text = "Edit"
        '            DR = Db.GetDataDictionary("Select D.*,CuName,CuTelNo1,CuTelNo2,CuTelNo3 from (Deliver D Inner Join Customer Cu On Cu.CuNo = D.CuNo) Where DNo=" & .txtDNo.Text)
        '            If DR IsNot Nothing Then

        '                .txtDDate.Value = DR("DDate").ToString
        '                .cmbCuName.Text = DR("CuName").ToString
        '                .txtCuTelNo1.Text = DR("CuTelNo1").ToString
        '                .txtCuTelNo2.Text = DR("CuTelNo2").ToString
        '                .txtCuTelNo3.Text = DR("CuTelNo3").ToString
        '                .txtDRemarks.Text = DR("DRemarks").ToString
        '                Dim DR1 = Db.GetDataList("Select RepNo,REP.PNo,PCategory,PName,Qty,Status,REP.TNo, TName,PaidPrice from (((Repair REP INNER JOIN PRODUCT  P On P.PNO = REP.PNO) LEFT JOIN Technician T On T.TNO = REP.TNO) LEFT JOIN DELIVER D On D.DNO = REP.DNO) Where D.DNo=" & .txtDNo.Text)
        '                .grdRepair.Rows.Clear()
        '                For Each Item In DR1
        '                    .grdRepair.Rows.Add(Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString, Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
        '                Next
        '                DR1 = Db.GetDataList("Select RetNo, RepNo, RET.PNo, PCategory, PName, Qty, Status, RET.TNo, TName, PaidPrice from (((`Return` RET INNER JOIN PRODUCT  P On P.PNO = RET.PNO) LEFT JOIN Technician T On T.TNO = RET.TNO) LEFT JOIN DELIVER D On D.DNO = RET.DNO) Where D.DNo=" & .txtDNo.Text)
        '                .grdRERepair.Rows.Clear()
        '                For Each Item In DR1
        '                    .grdRERepair.Rows.Add(Item("RetNo").ToString, Item("RepNo").ToString, Item("PCategory").ToString, Item("PName").ToString, Item("Qty").ToString, Item("PaidPrice").ToString, Item("TName").ToString, Item("Status").ToString)
        '                Next
        '            End If
        '        End With
        '    Case "ReRepair"
        '        With frmRepair
        '            Dim selectedrow As DataGridViewRow
        '            If e.RowIndex >= 0 Then
        '                selectedrow = grdSearch.Rows(e.RowIndex)
        '                .cmbRetNo.Text = selectedrow.Cells(0).Value.ToString
        '                Call .CmbRetNo_SelectedIndexChanged(sender, e)
        '                .tabRepair.SelectTab(1)
        '            End If
        '        End With
        '    Case "DeliverRepair"
        '        With FormDeliver
        '            .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = grdSearch.Item(0, grdSearch.CurrentCell.RowIndex).Value
        '            Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
        '            Call .GrdRepair_CellEndEdit(sender, E1)
        '        End With
        '    Case "DeliverReRepair"
        '        With FormDeliver
        '            .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = grdSearch.Item(0, grdSearch.CurrentCell.RowIndex).Value
        '            Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
        '            Call .GrdRepair_CellEndEdit(sender, E1)
        '        End With
        'End Select
        'If Tag <> "Repair" Then
        '    Enabled = True
        '    Close()
        'End If
    End Sub

    Private Sub frmSearch_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Tag = "Repair" Then
            frmDatagridviewTool.frm_Move()
            frmSearchDropDown.frm_Move()
        End If
    End Sub

    Private Sub SearchSubmission(WhereQuery As String, Values As MySqlParameter()) Handles ControlSearchEngine.SearchSubmissionEvent
        GridControl.SearchSubmission(WhereQuery, Values)
    End Sub

    Private Sub ControlSearchEngine_PerformQueryMapping(ByRef PoistionList As List(Of Object)) Handles ControlSearchEngine.PerformQueryMapping
        Select Case RequestSource
            Case FormSearchRequestSource.Repair
                Dim Control As GridRepairSearchControl = GridControl
                Control.PerformQueryMapping(PoistionList)
        End Select
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