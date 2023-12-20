﻿Imports ZXing
Imports System.Data.OleDb
Imports LASER_System.StructureDatabase

Public Class frmSupply
    Private Db As New Database

    Private Sub frmSupply_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub frmSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        MenuStrip.Items.Add(mnustrpMENU)
        Call cmdNew_Click(sender, e)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        SetNextKey(Db, txtSupNo, "SELECT top 1 SupNo from Supply ORDER BY SupNo Desc;", "SupNo")
        cmbSuName_DropDown(sender, e)
        cmbSuName.Text = "No Name"             'clear customer fileds
        cmbSupStatus.Text = "Not Paid"
        grdSupply.Rows.Clear()
        cmdDelete.Enabled = False
        cmdSave.Text = "Save"
    End Sub

    Public Sub cmbSuName_DropDown(sender As Object, e As EventArgs) Handles cmbSuName.DropDown
        Call ComboBoxDropDown(Db, cmbSuName, "Select SuName from Supplier group by  SuName;")
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmSupply_Leave(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CheckEmptyfield(cmbSuName, "Supplier Name යන field එක හිස්ව පවතියි. කරුණාකර අදාල Supplier තොරා ගෙන නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf grdSupply.Rows.Count < 2 Then
            MsgBox("ඔබ තවමත් Stock එකක් හො ඇතුලත් කල නැත. කරුණාකර Stock එකක් හෝ ඇතුලත් කර නැවත උත්සහ කරන්න.", vbOKOnly + vbExclamation)
            grdSupply.Focus()
            Exit Sub
        End If
        For Each Row As DataGridViewRow In grdSupply.Rows
            If grdSupply.Rows.Count - 1 = Row.Index Then Continue For

            If Row.Cells(0).Value = Nothing Then
                Row.Cells(0).Value = GetLastStockCode()
            End If
            If Row.Cells(1).Value Is Nothing Or Row.Cells(2).Value Is Nothing Then
                MsgBox("ඔබ Stock Code: " + Row.Cells(0).Value.ToString + " යන Stock එකෙහි Stock Category හෝ Stock Name යන අයිතම දෙකම හෝ ඉන් එකක් හෝ හිස්ව පවතියි. කරුණාකර එ සඳහා සුදුසු නමක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
        Next
        SetNextKey(Db, txtSupNo, "SELECT top 1 SupNo from Supply ORDER BY SupNo Desc;", "SupNo")
        Dim SuNo As Integer = Db.GetData("Select SuNo from Supplier where SuName=@SUNAME;", {
                                New OleDbParameter("SUNAME", cmbSuName.Text)
        })
        If SuNo = 0 Then
            MsgBox("ඔබ ඇතුලත් කල Supplier Name එක Database තුල සොයා ගැනීමට නොහැකිය. කරුණාකර නැවත පරිකෂා කරන්න." + vbCrLf + "ඔබට මෙම ගැටලුව විසදීමට නොහැකි නම්, අපගෙ Programe Developer ව අමතන්න.")
            Exit Sub
        End If
        Select Case cmdSave.Text
            Case "Save"
                SaveSupplyInformation(SuNo)
        End Select
    End Sub

    Private Sub SaveSupplyInformation(SuNo As Integer)
        Db.Execute("Insert into Supply(SupNo,SupDate,SuNo,SupRemarks,SupStatus,SupPaidDate,UNo) Values(@SUPNO,@SUPDATE,@SUNO, @SUPREMARKS, @SUPSTATUS, @SUPPAIDDATE, @UNO)", {
                New OleDbParameter("SUPNO", txtSupNo.Text),
                New OleDbParameter("SUPDATE", txtSupDate.Value.ToString),
                New OleDbParameter("SUNO", SuNo),
                New OleDbParameter("SUPREMARKS", txtSupRemarks.Text),
                New OleDbParameter("SUPSTATUS", cmbSupStatus.Text),
                New OleDbParameter("SUPPAIDDATE", If(cmbSupStatus.Text = "Paid", txtSupPaidDate.Value.ToString, DBNull.Value)),
                New OleDbParameter("UNO", User.Instance.UserNo)
            })
        For Each Row As DataGridViewRow In grdSupply.Rows
            If grdSupply.Rows.Count - 1 = Row.Index Then Continue For

            If Db.CheckDataExists(Tables.Stock, Stock.Code, Row.Cells(Stock.Code).Value) = False Then
                Db.Execute($"INSERT INTO {Tables.Stock}({Stock.Code}, {Stock.Category}, {Stock.Name}, {Stock.ModelNo}, {Stock.Location}, {Stock.Details}, {Stock.CostPrice}, {Stock.LowestPrice}, {Stock.SalePrice}, {Stock.AvailableUnits}, {Stock.DamagedUnits}, {Stock.ReorderPoint}) Values(@NO, @CATEGORY, @NAME, @MODELNO, @LOCATION, @DETAILS, @COSTPRICE, @LOWESTPRICE, @SALEPRICE, @AVAILABLESTOCKS, @OUTOFSTOCKS, @REORDERPOINT);", {
                  New OleDbParameter("@NO", Row.Cells(Stock.Code).Value),
                  New OleDbParameter("@CATEGORY", Row.Cells(Stock.Category).Value),
                  New OleDbParameter("@NAME", Row.Cells(Stock.Name).Value),
                  New OleDbParameter("@MODELNO", Row.Cells(Stock.ModelNo).Value),
                  New OleDbParameter("@LOCATION", Row.Cells(Stock.Location).Value),
                  New OleDbParameter("@DETAILS", Row.Cells(Stock.Details).Value),
                  New OleDbParameter("@COSTPRICE", Row.Cells("CostPrice").Value),
                  New OleDbParameter("@LOWESTPRICE", Row.Cells(Stock.LowestPrice).Value),
                  New OleDbParameter("@SALEPRICE", Row.Cells(Stock.SalePrice).Value),
                  New OleDbParameter("@AVAILABLESTOCKS", 0),
                  New OleDbParameter("@OUTOFSTOCKS", 0),
                  New OleDbParameter("@REORDERPOINT", Row.Cells(Stock.ReorderPoint).Value)
            })
            Else
                Db.Execute($"UPDATE {Tables.Stock} SET {Stock.Location}=@LOCATION,{Stock.ModelNo}=@MODELNO,{Stock.Details}=@DETAILS,{Stock.CostPrice}=@COSTPRICE,{Stock.LowestPrice}=@LOWESTPRICE, {Stock.SalePrice}=@SALEPRICE,{Stock.ReorderPoint}=@REORDERPOINT WHERE {Stock.Code}=@NO;", {
                  New OleDbParameter("@MODELNO", Row.Cells(Stock.ModelNo).Value),
                  New OleDbParameter("@LOCATION", Row.Cells(Stock.Location).Value),
                  New OleDbParameter("@DETAILS", Row.Cells(Stock.Details).Value),
                  New OleDbParameter("@COSTPRICE", Row.Cells("CostPrice").Value),
                  New OleDbParameter("@LOWESTPRICE", Row.Cells(Stock.LowestPrice).Value),
                  New OleDbParameter("@SALEPRICE", Row.Cells(Stock.SalePrice).Value),
                  New OleDbParameter("@REORDERPOINT", Row.Cells(Stock.ReorderPoint).Value),
                  New OleDbParameter("@NO", Row.Cells(Stock.Code).Value)
                })
            End If

            Db.Execute("INSERT INTO StockSupply(SupNo,SNo,SupType,SupUnits,SupCostPrice,SupTotal) VALUES(@SUPNO,@SNO,@SUPTYPE,@SUPUNITS,@COSTPRICE,@SUPTOTAL)", {
                New OleDbParameter("SUPNO", txtSupNo.Text),
                New OleDbParameter("SNO", Row.Cells(Stock.Code).Value),
                New OleDbParameter("SUPTYPE", Row.Cells("SupType").Value),
                New OleDbParameter("SUPUNITS", Row.Cells("SupQty").Value),
                New OleDbParameter("COSTPRICE", Row.Cells("CostPrice").Value),
                New OleDbParameter("SUPTOTAL", Row.Cells("SupTotal").Value)
            })
            If Row.Cells("SupType").Value.ToString = "Supply" Then
                Db.Execute($"Update {Tables.Stock} set {Stock.AvailableUnits}=({Stock.AvailableUnits} + {Row.Cells("SupQty").Value}) where SNo=@CODE", {
                    New OleDbParameter("CODE", Row.Cells(Stock.Code).Value)
                })
            Else
                Db.Execute($"Update {Tables.Stock} Set {Stock.DamagedUnits}=({Stock.DamagedUnits} - {Row.Cells("SupQty").Value}) where SNo=@CODE", {
                    New OleDbParameter("CODE", Row.Cells(Stock.Code).Value)
                })
            End If
        Next
        If MsgBox("සාර්ථකව Supply එක Update කෙරුණි. ඔබට මෙම Stocks සඳහා  Barcodes Print කිරීමට අවශ්‍යද?", vbYesNo + vbExclamation) = vbYes Then
            BarcodeViewerShow()
        End If

        cmdNew_Click(cmdSave, Nothing)
    End Sub

    Private Sub BarcodeViewerShow()
        With frmStockSticker
            For Each row As DataGridViewRow In grdSupply.Rows
                If grdSupply.Rows.Count - 1 = row.Index Then Continue For
                Dim AvailableUnits As Integer
                DR = Db.GetDataReader("Select SAvailableStocks from stock where sno =" & row.Cells(0).Value)
                If DR.HasRows = True Then
                    DR.Read()
                    AvailableUnits = DR("SAvailableStocks").ToString
                End If

                Dim writer As New BarcodeWriter With {
                    .Format = BarcodeFormat.CODE_128
                }
                writer.Options.PureBarcode = True
                .grdStock.Rows.Add(row.Cells(Stock.Code).Value, row.Cells(Stock.Category).Value, row.Cells(Stock.Name).Value, AvailableUnits, row.Cells("CostPrice").Value, row.Cells("SupQty").Value, writer.Write(row.Cells(Stock.Code).Value))
            Next
            .Show()
            .btnShow_Click(cmdSave, Nothing)
        End With
    End Sub

    Private Sub cmdGetData_Click(sender As Object, e As EventArgs) Handles cmdGetData.Click
        Dim frmSearchSupply As New frmSearch With {
            .Tag = "Supply"
        }
        frmSearchSupply.Show(Me)
    End Sub

    Private Sub cmdSuView_Click(sender As Object, e As EventArgs) Handles cmdSuView.Click
        If cmdGetData.Enabled = True Then cmdGetData_Click(sender, e)
    End Sub

    Private Sub frmSupply_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdNew.Left = Me.Width - cmdNew.Width - 20
        cmdSave.Left = cmdNew.Left
        cmdGetData.Left = cmdNew.Left
        cmdDelete.Left = cmdNew.Left
        cmdClose.Left = cmdNew.Left
        grdSupply.Width = cmdNew.Left - grdSupply.Left - 5
        txtSupRemarks.Width = cmdNew.Left - txtSupRemarks.Left - 5
        grdSupply.Height = Me.Height - grdSupply.Top - 50
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        If cmdNew.Enabled = True Then cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If cmdSave.Enabled = True Then cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If cmdDelete.Enabled = True Then cmdDelete_Click(sender, e)
    End Sub

    Private Sub GetDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDataToolStripMenuItem.Click
        If cmdGetData.Enabled = True Then cmdGetData_Click(sender, e)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckEmptyfield(txtSupNo, "Supply No was empty. Please check again And Try agin.") = False Then
            Exit Sub
        ElseIf Db.CheckDataExists("Supply", "SupNo", txtSupNo.Text) = False Then
            MsgBox("Supply No was Not exist In the database. Please check it And Try again.", vbCritical + vbOKOnly)
            Exit Sub
        End If
        If MsgBox("Are you sure delete this supply record?", vbYesNo + vbExclamation) = vbYes Then
            Db.Execute("Delete from Supply where SupNo = " & txtSupNo.Text)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        frmSupply_Leave(sender, e)
    End Sub

    Private Sub grdSupply_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdSupply.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 0
                If grdSupply.Item(0, e.RowIndex).Value = "" Then Exit Sub
                Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Stock where SNo=" & grdSupply.Item(0, e.RowIndex).Value)
                If DR.HasRows = True Then
                    DR.Read()
                    grdSupply.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                    grdSupply.Item(2, e.RowIndex).Value = DR("SName").ToString
                    grdSupply.Item(3, e.RowIndex).Value = DR("SModelNo").ToString
                    grdSupply.Item(4, e.RowIndex).Value = DR("SLocation").ToString
                    grdSupply.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdSupply.Item(6, e.RowIndex).Value = DR("SLowestPrice").ToString
                    grdSupply.Item(7, e.RowIndex).Value = DR("SMinStocks").ToString
                    grdSupply.Item(8, e.RowIndex).Value = "Supply"
                    grdSupply.Item(9, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdSupply.Item(10, e.RowIndex).Value = "1"
                    grdSupply.Item(11, e.RowIndex).Value = Int(DR("SCostPrice").ToString) * 1
                    grdSupply.Item(12, e.RowIndex).Value = DR("SDetails").ToString
                    For Each row As DataGridViewRow In grdSupply.Rows
                        If row.Index = e.RowIndex Or row.Index = grdSupply.Rows.Count - 1 Then Continue For
                        If row.Cells(0).Value = grdSupply.Item(0, e.RowIndex).Value Then
                            row.Cells(9).Value += Int(grdSupply.Item(9, e.RowIndex).Value)
                            Dim E1 As New DataGridViewCellEventArgs(9, row.Index)
                            grdSupply_CellEndEdit(sender, E1)
                            grdSupply.Rows.Remove(grdSupply.CurrentRow)
                        End If
                    Next
                Else
                    grdSupply.Item(0, e.RowIndex).Value = GetLastStockCode()
                End If
            Case 1, 2
                Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Stock where SCategory='" & grdSupply.Item(1, e.RowIndex).Value & "' and SName='" & grdSupply.Item(2, e.RowIndex).Value & "';")
                If DR.HasRows = True Then
                    DR.Read()
                    grdSupply.Item(0, e.RowIndex).Value = DR("SNo").ToString
                    grdSupply.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                    grdSupply.Item(2, e.RowIndex).Value = DR("SName").ToString
                    grdSupply.Item(3, e.RowIndex).Value = DR("SModelNo").ToString
                    grdSupply.Item(4, e.RowIndex).Value = DR("SLocation").ToString
                    grdSupply.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdSupply.Item(6, e.RowIndex).Value = DR("SMinStocks").ToString
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(8, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdSupply.Item(9, e.RowIndex).Value = "1"
                    grdSupply.Item(10, e.RowIndex).Value = Int(DR("SCostPrice").ToString) * 1
                    grdSupply.Item(11, e.RowIndex).Value = DR("SDetails").ToString
                Else
                    grdSupply.Item(0, e.RowIndex).Value = GetLastStockCode()
                    grdSupply.Item(6, e.RowIndex).Value = "3"
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(9, e.RowIndex).Value = "1"
                End If
            Case 9, 10
                If grdSupply.Item(9, e.RowIndex).Value.ToString <> "" And grdSupply.Item(10, e.RowIndex).Value.ToString <> "" Then
                    grdSupply.Item(11, e.RowIndex).Value = Val(grdSupply.Item(9, e.RowIndex).Value) * Val(grdSupply.Item(10, e.RowIndex).Value)
                End If
        End Select
    End Sub

    Private Function GetLastStockCode() As Integer
        Dim StockId As Integer = Db.GetNextKey("Stock", "SNo")
        For Each Row As DataGridViewRow In grdSupply.Rows
            If grdSupply.CurrentCell.RowIndex = Row.Index Or Row.Index = grdSupply.Rows.Count - 1 Then Continue For

            If Db.CheckDataExists("Stock", "SNo", Row.Cells(0).Value) = False Then
                Row.Cells(0).Value = StockId
                StockId += 1
            End If
        Next
        Return StockId
    End Function

    Private Sub SupplierInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierInfoToolStripMenuItem.Click
        cmdSuView_Click(sender, e)
    End Sub

    Private Sub StockInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockInfoToolStripMenuItem.Click
        Dim frm As New FormStock
        frm.Tag = "Supply"
        frm.ShowDialog()
        frm.txtSearch.Focus()
    End Sub

    Private Sub cmbSupStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupStatus.SelectedIndexChanged
        If cmbSupStatus.Text = "Not Paid" Then
            txtSupPaidDate.Visible = False
            lblSupPaidDate.Visible = False
        Else
            txtSupPaidDate.Visible = True
            lblSupPaidDate.Visible = True
        End If
    End Sub

    Private Sub grdSupply_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdSupply.EditingControlShowing
        Dim autoText As TextBox
        Dim DataCollection As New AutoCompleteStringCollection()
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        If TypeOf e.Control Is TextBox Then
            autoText = TryCast(e.Control, TextBox)
            autoText.AutoCompleteCustomSource = Nothing
            autoText.AutoCompleteSource = AutoCompleteSource.None
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If
        Select Case grdSupply.CurrentCell.ColumnIndex
            Case 1
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    Dim DR As OleDbDataReader = Db.GetDataReader("Select SCategory from Stock group by SCategory;")
                    While DR.Read
                        DataCollection.Add(DR("SCategory").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 2
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    Dim DR As OleDbDataReader = Db.GetDataReader("Select SCategory,SName from Stock where SCategory ='" & grdSupply.Item(1, grdSupply.CurrentCell.RowIndex).Value & "';")
                    While DR.Read
                        DataCollection.Add(DR("SName").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 4
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    Dim DR As OleDbDataReader = Db.GetDataReader("Select SLocation from Stock group by SLocation;")
                    While DR.Read
                        DataCollection.Add(DR("SLocation").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 0, 9, 6
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 8, 5
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

End Class