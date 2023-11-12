Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports LASER_System.StructureDatabase

Public Class FormStock
    Public Property Caller As String = ""
    Private ReadOnly DB As New Database

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        MenuStrip.Items.Add(mnustrpMENU)
        Control.CheckForIllegalCrossThreadCalls = False
        AcceptButton = btnSearch
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Connect()
        cmbFilter.SelectedIndex = 0
        If User.Instance.UserType = User.Type.Admin Then
            grdStock.Columns.Item("SCostPrice").Visible = True
        End If

        btnSearch.PerformClick()
    End Sub

    Private Sub grdStock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStock.CellDoubleClick
        Dim CurrentRow = grdStock.Rows.Item(e.RowIndex)
        Select Case Me.Tag
            Case "Sale"
                For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .grdSale.Rows.Add(grdStock.Item(0, grdStock.CurrentRow.Index).Value, grdStock.Item(1, grdStock.CurrentRow.Index).Value,
                                             grdStock.Item(2, grdStock.CurrentRow.Index).Value, "Sale", grdStock.Item(6, grdStock.CurrentRow.Index).Value,
                                             "1", Val(grdStock.Item(6, grdStock.CurrentRow.Index).Value) * 1)
                        End With
                        Exit For
                    End If
                Next
                Me.Close()
            Case "Supply"
                With frmSupply
                    .grdSupply.Rows.Add(grdStock.Item(0, e.RowIndex).Value, grdStock.Item(1, e.RowIndex).Value,
                                        grdStock.Item(2, e.RowIndex).Value, grdStock.Item(3, e.RowIndex).Value,
                                        grdStock.Item(4, e.RowIndex).Value, grdStock.Item(6, e.RowIndex).Value,
                                        grdStock.Item(9, e.RowIndex).Value, "Supply", grdStock.Item(5, e.RowIndex).Value,
                                        "1", Int(grdStock.Item(5, e.RowIndex).Value) * 1, grdStock.Item(10, e.RowIndex).Value)
                End With
                Me.Close()
            Case "TechnicianCost"
                With frmTechnicianCost
                    .grdTechnicianCost.Item("SNo", .grdTechnicianCost.Rows.Count - 1).Value = grdStock.Item(0, grdStock.CurrentRow.Index).Value
                    Dim E1 As New DataGridViewCellEventArgs("SNo", .grdTechnicianCost.Rows.Count - 1)
                    .grdTechnicianCost_CellEndEdit(sender, E1)
                End With
                Me.Close()
            Case Else
                Dim ControlStockInfo As New ControlStockInfo(DB)
                With ControlStockInfo
                    .ClearControls()
                    .TxtSNo.Text = CurrentRow.Cells.Item(Stock.Code).Value
                    .CmbCategory.Text = CurrentRow.Cells.Item(Stock.Category).Value
                    .CmbName.Text = CurrentRow.Cells.Item(Stock.Name).Value
                    .TxtModelNo.Text = CurrentRow.Cells.Item(Stock.ModelNo).Value
                    .CmbLocation.Text = CurrentRow.Cells.Item(Stock.Location).Value
                    .TxtCostPrice.Text = CurrentRow.Cells.Item(Stock.CostPrice).Value
                    .TxtLowestPrice.Text = CurrentRow.Cells.Item(Stock.LowestPrice).Value
                    .TxtSalePrice.Text = CurrentRow.Cells.Item(Stock.SalePrice).Value
                    .TxtAvailableUnits.Text = CurrentRow.Cells.Item(Stock.AvailableUnits).Value
                    .TxtDamagedUnits.Text = CurrentRow.Cells.Item(Stock.DamagedUnits).Value
                    .TxtReorderPoint.Text = CurrentRow.Cells.Item(Stock.ReorderPoint).Value
                    .TxtDetails.Text = CurrentRow.Cells.Item(Stock.Details).Value
                    Me.Controls.Add(ControlStockInfo)
                    .Dock = DockStyle.Fill
                    .BringToFront()
                End With
        End Select
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewStockTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStockTransactionDetailsToolStripMenuItem.Click
        If grdStock.CurrentCell.ColumnIndex > 0 And grdStock.CurrentCell.RowIndex > 0 Then
            Dim txtsno As New TextBox
            txtsno.Text = grdStock.Item(0, grdStock.CurrentRow.Index).Value
            If CheckExistData(txtsno, "Select SNo from Stock where SNo = " & txtsno.Text, "ඔබ Stock එකක් තෝරා ගෙන නොමැත. කරුණාකර Stock එකක් තෝරා ගන්න.", False) = False Then
                frmStockTransaction.Show()
                Exit Sub
            End If
            With frmStockTransaction
                .txtSNo.Text = txtsno.Text
                .txtSNo_TextChanged(sender, e)
                .cmdDone_Click(sender, e)
                .Show()
            End With
        Else
            frmStockTransaction.Show()
        End If
    End Sub
    Private Sub bgwStock_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        grdStock.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Columns As String() = {
            Stock.Code,
            Stock.Category,
            Stock.Name,
            Stock.ModelNo,
            Stock.Location,
            Stock.LowestPrice,
            Stock.SalePrice,
            Stock.AvailableUnits,
            Stock.DamagedUnits,
            Stock.ReorderPoint,
            Stock.Details
        }
        Dim FilterQuery As String = $"Select {String.Join(", ", Columns) } from {Tables.Stock} "
        If txtSearch.Text <> "" Then
            Select Case cmbFilter.Text
                Case "by Code"
                    FilterQuery += $"Where {Stock.Code} Like @VALUE"
                Case "by Category"
                    FilterQuery += $"Where {Stock.Category} like @VALUE"
                Case "by Name"
                    FilterQuery += $"Where {Stock.Name} like @VALUE"
                Case "by Model No"
                    FilterQuery += $"Where {Stock.ModelNo} like @VALUE"
                Case "by Location"
                    FilterQuery += $"Where {Stock.Location} like @VALUE"
                Case "by Lowest Price"
                    FilterQuery += $"Where {Stock.LowestPrice} like @VALUE"
                Case "by Sale Price"
                    FilterQuery += $"Where {Stock.SalePrice} like @VALUE"
                Case "by Reorder Point"
                    FilterQuery += $"Where {Stock.ReorderPoint} like @VALUE"
                Case "by Details"
                    FilterQuery += $"Where {Stock.Details} like @VALUE"
                Case Else
                    FilterQuery += $"Where {Stock.Code} LIKE @VALUE OR 
                        {Stock.Category} LIKE @VALUE OR 
                        {Stock.Name} LIKE @VALUE OR 
                        {Stock.ModelNo} LIKE @VALUE OR 
                        {Stock.Location} LIKE @VALUE OR 
                        {Stock.LowestPrice} LIKE @VALUE OR 
                        {Stock.SalePrice} LIKE @VALUE OR 
                        {Stock.ReorderPoint} LIKE @VALUE OR 
                        {Stock.Details} LIKE @VALUE"
            End Select
        Else
            FilterQuery += $" Order by {Stock.Code}"
        End If
        Dim DT As DataTable = DB.GetDataTable(FilterQuery, {New OleDbParameter("@VALUE", $"%{txtSearch.Text}%")})
        grdStock.DataSource = DT
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Dim ControlStockInfo As New ControlStockInfo(DB)
        Me.Controls.Add(ControlStockInfo)
        ControlStockInfo.ClearControls()
        ControlStockInfo.Dock = DockStyle.Fill
        ControlStockInfo.BringToFront()
    End Sub

    Private Sub FormStock_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        DB.Disconnect()
    End Sub

    Private Sub grdStock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdStock.CellFormatting
        If e.ColumnIndex <> grdStock.Columns.Item("SAvailableStocks").Index Then
            Exit Sub
        End If
        Try
            Dim Row As DataGridViewRow = grdStock.Rows.Item(e.RowIndex)
            If Row.Cells.Item("SAvailableStocks").Value < Row.Cells.Item("SMinStocks").Value Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            ElseIf Row.Cells.Item("SAvailableStocks").Value = Row.Cells.Item("SMinStocks").Value Then
                e.CellStyle.BackColor = Color.DarkOrange
                e.CellStyle.ForeColor = Color.White
            Else
                e.CellStyle.BackColor = Color.White
                e.CellStyle.ForeColor = Color.Black
            End If
        Catch ex As Exception
            Console.Error.Write(ex)
        End Try
    End Sub
End Class