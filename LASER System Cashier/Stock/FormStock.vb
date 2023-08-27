Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO

Public Class FormStock
    Public Property Caller As String = ""
    Private ReadOnly DB As New Database
    Private ControlStockInfo As New ControlStockInfo(DB)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        MenuStrip.Items.Add(mnustrpMENU)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        AcceptButton = btnSearch
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Connect()
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
                ControlStockInfo = New ControlStockInfo(DB)
                With ControlStockInfo
                    Me.Controls.Add(ControlStockInfo)
                    .ClearControls()
                    .TxtSNo.Text = CurrentRow.Cells.Item(StructureDbStock.Code).Value
                    .CmbCategory.Text = CurrentRow.Cells.Item(StructureDbStock.Category).Value
                    .CmbName.Text = CurrentRow.Cells.Item(StructureDbStock.Name).Value
                    .TxtModelNo.Text = CurrentRow.Cells.Item(StructureDbStock.ModelNo).Value
                    .CmbLocation.Text = CurrentRow.Cells.Item(StructureDbStock.Location).Value
                    .TxtCostPrice.Text = CurrentRow.Cells.Item(StructureDbStock.CostPrice).Value
                    .TxtSalePrice.Text = CurrentRow.Cells.Item(StructureDbStock.SalePrice).Value
                    .TxtAvailableUnits.Text = CurrentRow.Cells.Item(StructureDbStock.AvailableUnits).Value
                    .TxtDamagedUnits.Text = CurrentRow.Cells.Item(StructureDbStock.DamagedUnits).Value
                    .TxtReorderPoint.Text = CurrentRow.Cells.Item(StructureDbStock.ReorderPoint).Value
                    .TxtDetails.Text = CurrentRow.Cells.Item(StructureDbStock.Details).Value
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

    Private Sub WorkerStock_DoWork(sender As Object, e As DoWorkEventArgs) Handles WorkerStock.DoWork
        Try
            Dim DT As New DataTable
            Dim FilterQuery As String = ""
            grdStock.ScrollBars = ScrollBars.None
            grdStock.ClearSelection()
            If txtSearch.Text <> "" Then
                Select Case cmbFilter.Text
                    Case "by Stock Code"
                        FilterQuery = "Where SNo Like '%" & txtSearch.Text & "%'"
                    Case "by Stock Category"
                        FilterQuery = "Where SCategory like '%" & txtSearch.Text & "%'"
                    Case "by Stock Name"
                        FilterQuery = "Where SName like '%" & txtSearch.Text & "%'"
                    Case "by Stock Model No"
                        FilterQuery = "Where SModelNo like '%" & txtSearch.Text & "%'"
                    Case "by Stock Location"
                        FilterQuery = "Where SLocation like '%" & txtSearch.Text & "%'"
                    Case "by Stock Cost Price"
                        FilterQuery = "Where SCostPrice like '%" & txtSearch.Text & "%'"
                    Case "by Stock Sale Price"
                        FilterQuery = "Where SSalePrice like '%" & txtSearch.Text & "%'"
                    Case "by Stock Reorder Point"
                        FilterQuery = "Where SMinStocks like '%" & txtSearch.Text & "%'"
                    Case "by Stock Details"
                        FilterQuery = "Where SDetails like '%" & txtSearch.Text & "%'"
                    Case "by All"
                        FilterQuery = "Where SNo like '%" & txtSearch.Text & "%' or SCategory like '%" & txtSearch.Text & "%' or SName like '%" & txtSearch.Text & "%' or SModelNo like '%" & txtSearch.Text & "%' or SLocation like '%" & txtSearch.Text & "%' or SCostPrice like '%" & txtSearch.Text & "%' or SSalePrice like '%" & txtSearch.Text & "%' or SMinStocks like '%" & txtSearch.Text & "%' or SDetails like '%" & txtSearch.Text & "%'"
                End Select
            Else
                FilterQuery = " Order by SNo"
            End If
            Dim DA As New OleDbDataAdapter("SELECT SNo,SCategory,SName, SModelNo, SLocation,SMinstocks,SAvailableStocks,SOutofStocks, SCostPrice,SSalePrice, SDetails " &
                                   "from Stock " & FilterQuery & ";", CNN)
            DA.Fill(DT)

            For Each Row As DataRow In DT.Rows
                If WorkerStock.CancellationPending = True Then
                    e.Cancel = True
                    Exit Sub
                End If
                grdStock.Rows.Add(
                        Row("SNo").ToString,
                        Row("SCategory").ToString,
                        Row("SName").ToString,
                        Row("SModelNo").ToString,
                        Row("SLocation").ToString,
                        Row("SCostPrice").ToString,
                        Row("SSalePrice").ToString,
                        Row("SAvailableStocks").ToString,
                        Row("SOutofStocks").ToString,
                        Row("SMinStocks").ToString,
                        Row("SDetails").ToString
                )
                If grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SAvailableStocks").Value <
                grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SMinStocks").Value Then
                    grdStock.Item(7, (grdStock.Rows.Count - 1)).Style.BackColor = Color.Red
                    grdStock.Item(7, (grdStock.Rows.Count - 1)).Style.ForeColor = Color.White
                ElseIf grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SAvailableStocks").Value =
            grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SMinStocks").Value Then
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.BackColor = Color.DarkOrange
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.ForeColor = Color.White
                Else
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.BackColor = Color.White
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.ForeColor = Color.Black
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub bgwStock_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles WorkerStock.RunWorkerCompleted
        grdStock.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If File.Exists(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls") Then
            Dim frmImage As New Form
            frmImage.Name = "frmImage"
            frmImage.Text = "LASER System - Image Viewer [S-" & grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString & "]"
            frmImage.WindowState = FormWindowState.Maximized
            frmImage.MaximizeBox = False
            frmImage.MinimizeBox = False
            frmImage.BackColor = Color.Black
            frmImage.BringToFront()
            Dim img As New PictureBox
            img.Name = "img"
            img.Top = 0
            img.Left = 0
            img.Dock = DockStyle.Fill
            img.SizeMode = PictureBoxSizeMode.Zoom
            img.Image = Image.FromFile(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls")
            If frmImage.Visible = False Then
                frmImage.Show(Me)
                frmImage.Controls.Add(img)
            Else
                For Each controlObject As Control In frmImage.Controls
                    If controlObject.Name = "img" Then
                        controlObject = img
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If WorkerStock.IsBusy Then
            WorkerStock.CancelAsync()
        Else
            grdStock.Rows.Clear()
            WorkerStock.RunWorkerAsync()
        End If
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        ControlStockInfo = New ControlStockInfo(DB)
        Me.Controls.Add(ControlStockInfo)
        ControlStockInfo.ClearControls()
        ControlStockInfo.Dock = DockStyle.Fill
        ControlStockInfo.BringToFront()
    End Sub

    Private Sub FormStock_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        DB.Disconnect()
    End Sub
End Class