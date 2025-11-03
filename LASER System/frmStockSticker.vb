Imports ZXing
Imports System.IO
Imports BarcodeLib.Barcode.CrystalReports
Imports BarcodeLib.Barcode

Public Class frmStockSticker
    Private Db As New Database

    Public Sub grdStock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdStock.CellEndEdit
        If e.ColumnIndex = 0 Then
            If grdStock.Item(0, e.RowIndex).Value = "" Then Exit Sub
            Dim writer As New BarcodeWriter With {
                .Format = BarcodeFormat.CODE_128
            }
            writer.Options.PureBarcode = True
            grdStock.Item(6, e.RowIndex).Value = writer.Write(grdStock.Item(0, e.RowIndex).Value)
            DR = Db.GetDataDictionary("Select * from Stock where SNo=" & grdStock.Item(0, e.RowIndex).Value)
            If DR IsNot Nothing Then
                grdStock.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                grdStock.Item(2, e.RowIndex).Value = DR("SName").ToString
                grdStock.Item(3, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(4, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
            End If
        ElseIf e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
            DR = Db.GetDataDictionary("Select * from Stock where SCategory='" & grdStock.Item(1, e.RowIndex).Value & "' and SName='" & grdStock.Item(2, e.RowIndex).Value & "';")
            If DR IsNot Nothing Then
                grdStock.Item(0, e.RowIndex).Value = DR("SNo").ToString
                grdStock.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                grdStock.Item(2, e.RowIndex).Value = DR("SName").ToString
                grdStock.Item(3, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(4, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                Dim writer As New BarcodeWriter With {
                    .Format = BarcodeFormat.CODE_128
                }
                writer.Options.PureBarcode = True
                grdStock.Item(6, e.RowIndex).Value = writer.Write(grdStock.Item(0, e.RowIndex).Value)
            End If
        End If
    End Sub

    Private Sub grdStock_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdStock.EditingControlShowing
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
        Select Case grdStock.CurrentCell.ColumnIndex
            Case 1
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    Dim DR = Db.GetDataList("Select SCategory from Stock group by SCategory;")
                    For Each Item In DR
                        DataCollection.Add(Item("SCategory").ToString)
                    Next
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 2
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    Dim DR = Db.GetDataList("Select SCategory,SName from Stock where SCategory ='" & grdStock.Item(1, grdStock.CurrentCell.RowIndex).Value & "';")
                    For Each Item In DR
                        DataCollection.Add(Item("SName").ToString)
                    Next
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 0, 4
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 5
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Public Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim Form As New FormReport
        Try
            Dim ReportManager As New StockStickerReport()
            ReportManager.SetPrinterName(My.Settings.StickerPrinterName).SetPaperName(My.Settings.StockStickerPaperName)
            Dim Report = ReportManager.GenerateReport(grdStock)
            Dim FormReport = ReportManager.GetFormReport(Report, "Report - Stock Sticker", False)
            FormReport.Show(Me)
        Catch ex As Exception
            MessageBox.Error("Stock Sticker එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message)
        End Try
    End Sub

    Private Sub frmStockSticker_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdStock.Width = (Width - (grdStock.Left * 2)) / 2
        rptViewer.Left = (grdStock.Width + grdStock.Left) + 5
        rptViewer.Width = Width - rptViewer.Left - 20
        btnShow.Left = rptViewer.Left - btnShow.Width - 5
        grdStock.Height = Height - grdStock.Top - 50
        rptViewer.Height = Height - rptViewer.Top - 50
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        btnShow_Click(sender, e)
    End Sub
End Class