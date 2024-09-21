﻿Imports System.ComponentModel
Imports System.IO
Imports MySqlConnector
Imports Microsoft.VisualBasic.FileIO
Imports LASER_System.StructureDatabase

Public Class FormStock
    Public Property Caller As String = ""
    Private ReadOnly DB As New Database

    Public Sub New()
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If User.Instance.UserType = User.Type.Admin Then
            grdStock.Columns.Item("SCostPrice").Visible = True
        End If

        ControlSearchEngine.Init(New Dictionary(Of String, String) From {
            {"All", "All"},
            {"SNo", "Code"},
            {"SCategory", "Category"},
            {"SName", "Name"},
            {"SModelNo", "Model No"},
            {"SLocation", "Location"},
            {"SSalePrice", "SalePrice"},
            {"SDetails", "Details"}
        })
        SearchSubmission("", {})
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
                    .TxtSNo.Text = CurrentRow.Cells.Item(Stock.Code).Value.ToString()
                    .CmbCategory.Text = CurrentRow.Cells.Item(Stock.Category).Value.ToString()
                    .CmbName.Text = CurrentRow.Cells.Item(Stock.Name).Value.ToString()
                    .TxtModelNo.Text = CurrentRow.Cells.Item(Stock.ModelNo).Value.ToString()
                    .CmbLocation.Text = CurrentRow.Cells.Item(Stock.Location).Value.ToString()
                    .TxtCostPrice.Text = CurrentRow.Cells.Item(Stock.CostPrice).Value.ToString()
                    .TxtLowestPrice.Text = CurrentRow.Cells.Item(Stock.LowestPrice).Value.ToString()
                    .TxtSalePrice.Text = CurrentRow.Cells.Item(Stock.SalePrice).Value.ToString()
                    .TxtAvailableUnits.Text = CurrentRow.Cells.Item(Stock.AvailableUnits).Value.ToString()
                    .TxtDamagedUnits.Text = CurrentRow.Cells.Item(Stock.DamagedUnits).Value.ToString()
                    .TxtReorderPoint.Text = CurrentRow.Cells.Item(Stock.ReorderPoint).Value.ToString()
                    .TxtDetails.Text = CurrentRow.Cells.Item(Stock.Details).Value.ToString()
                    Me.Controls.Add(ControlStockInfo)
                    .FormParent = Me
                    .Dock = DockStyle.Fill
                    .BringToFront()
                End With
        End Select
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewStockTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStockTransactionDetailsToolStripMenuItem.Click
        If Not (grdStock.CurrentCell.ColumnIndex > 0 And grdStock.CurrentCell.RowIndex > 0) Then
            frmStockTransaction.Show()
            Exit Sub
        End If
        Dim SNo As Integer = grdStock.Item(0, grdStock.CurrentRow.Index).Value
        If Not DB.CheckDataExists(Tables.Stock, Stock.Code, SNo) Then
            MsgBox("ඔබ Stock එකක් තෝරා ගෙන නොමැත. කරුණාකර Stock එකක් තෝරා ගන්න.", vbCritical)
            frmStockTransaction.Show()
            Exit Sub
        End If
        With frmStockTransaction
            .txtSNo.Text = SNo
            .txtSNo_TextChanged(sender, e)
            .cmdDone_Click(sender, e)
            .Show()
        End With
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

    Private Sub SearchSubmission(WhereQuery As String, Values As MySqlParameter()) Handles ControlSearchEngine.SearchSubmissionEvent
        Dim Columns As String() = {
            Stock.Code,
            Stock.Category,
            Stock.Name,
            Stock.ModelNo,
            Stock.Location,
            Stock.CostPrice,
            Stock.LowestPrice,
            Stock.SalePrice,
            Stock.AvailableUnits,
            Stock.DamagedUnits,
            Stock.ReorderPoint,
            Stock.Details
        }
        WhereQuery = If(WhereQuery.Trim() = "", "1", WhereQuery)
        Dim FilterQuery As String = $"SELECT {String.Join(", ", Columns) } FROM {Tables.Stock} WHERE {WhereQuery} ORDER BY {Stock.Code};"
        Dim DT As New DataTable
        Try
            DT = DB.GetDataTable(FilterQuery, Values)
            ControlSearchEngine.QueryValidator(True)
            grdStock.DataSource = DT
        Catch ex As Exception
            DT = DB.GetDataTable($"SELECT {String.Join(", ", Columns) } FROM {Tables.Stock} ORDER BY {Stock.Code};", {})
            ControlSearchEngine.QueryValidator(False)
        End Try
    End Sub

    Private Sub CmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Dim ControlStockInfo As New ControlStockInfo(DB)
        Me.Controls.Add(ControlStockInfo)
        ControlStockInfo.ClearControls()
        ControlStockInfo.FormParent = Me
        ControlStockInfo.Dock = DockStyle.Fill
        ControlStockInfo.BringToFront()
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