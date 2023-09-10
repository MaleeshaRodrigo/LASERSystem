Imports ZXing
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO

Public Class frmStockSticker
    Public Sub grdStock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdStock.CellEndEdit
        If e.ColumnIndex = 0 Then
            If grdStock.Item(0, e.RowIndex).Value = "" Then Exit Sub
            Dim writer As New BarcodeWriter
            writer.Format = BarcodeFormat.CODE_128
            writer.Options.PureBarcode = True
            grdStock.Item(6, e.RowIndex).Value = writer.Write(grdStock.Item(0, e.RowIndex).Value)
            CMD = New OleDbCommand("Select * from Stock where SNo=" & grdStock.Item(0, e.RowIndex).Value, CNN)
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                DR.Read()
                grdStock.Item(1, e.RowIndex).Value = DR("Scategory").ToString
                grdStock.Item(2, e.RowIndex).Value = DR("SName").ToString
                grdStock.Item(3, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(4, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
            End If
        ElseIf e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
            CMD = New OleDb.OleDbCommand("Select * from Stock where SCategory='" & grdStock.Item(1, e.RowIndex).Value & "' and SName='" & grdStock.Item(2, e.RowIndex).Value & "';", CNN)
            DR = CMD.ExecuteReader()
            If DR.HasRows = True Then
                DR.Read()
                grdStock.Item(0, e.RowIndex).Value = DR("SNo").ToString
                grdStock.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                grdStock.Item(2, e.RowIndex).Value = DR("SName").ToString
                grdStock.Item(3, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(4, e.RowIndex).Value = DR("SAvailableStocks").ToString
                grdStock.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                Dim writer As New BarcodeWriter
                writer.Format = BarcodeFormat.CODE_128
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
                    CMD = New OleDb.OleDbCommand("Select SCategory from Stock group by SCategory;", CNN)
                    DR = CMD.ExecuteReader()
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
                    CMD = New OleDb.OleDbCommand("Select SCategory,SName from Stock where SCategory ='" & grdStock.Item(1, grdStock.CurrentCell.RowIndex).Value & "';", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("SName").ToString)
                    End While
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
        Dim dt As New DataTable
        dt.Clear()
        dt.Columns.Add("SNo")
        dt.Columns.Add("SCategory")
        dt.Columns.Add("SName")
        dt.Columns.Add("Qty")
        dt.Columns.Add(New DataColumn("Barcode", GetType(Byte())))
        dt.Columns.Add("Rate")
        For Each row As DataGridViewRow In grdStock.Rows
            If row.Cells(0).Value = Nothing Then Exit For
            For i As Integer = 1 To row.Cells(4).Value.ToString
                Dim imgStream As MemoryStream = New MemoryStream()
                Dim img As Image = row.Cells(6).Value
                img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                imgStream.Close()
                Dim byteArray As Byte() = imgStream.ToArray()
                dt.Rows.Add(row.Cells.Item(0).Value, row.Cells.Item(1).Value, row.Cells.Item(2).Value, row.Cells.Item(4).Value, byteArray, "Rs." + row.Cells.Item(5).Value)
            Next
        Next
        Dim rpt As New rptStockSticker
        rpt.SetDataSource(dt)
        Dim c As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = My.Settings.StickerPrinterName
        Dim rawKind As Integer
        For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(c).PaperName = My.Settings.StockStickerPaperName Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                Exit For
            End If
        Next
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
        rptViewer.ReportSource = rpt
    End Sub

    Private Sub frmStockSticker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
    End Sub

    Private Sub frmStockSticker_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdStock.Width = (Me.Width - (grdStock.Left * 2)) / 2
        rptViewer.Left = (grdStock.Width + grdStock.Left) + 5
        rptViewer.Width = Me.Width - rptViewer.Left - 20
        btnShow.Left = rptViewer.Left - btnShow.Width - 5
        grdStock.Height = Me.Height - grdStock.Top - 50
        rptViewer.Height = Me.Height - rptViewer.Top - 50
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        btnShow_Click(sender, e)
    End Sub
End Class