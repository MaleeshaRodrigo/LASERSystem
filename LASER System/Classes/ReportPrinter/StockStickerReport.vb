Imports CrystalDecisions.CrystalReports.Engine

Public Class StockStickerReport
    Inherits AbstractReportManager
    Implements ReportPrint

    Public Function GenerateReport(Grid As DataGridView) As ReportClass
        Dim Report As New rptStockSticker
        Dim DataTable As New DataTable
        DataTable.Clear()
        DataTable.Columns.Add("SNo")
        DataTable.Columns.Add("SCategory")
        DataTable.Columns.Add("SName")
        DataTable.Columns.Add("Qty")
        DataTable.Columns.Add(New DataColumn("Barcode", GetType(Byte())))
        DataTable.Columns.Add("Rate")
        For Each row As DataGridViewRow In Grid.Rows
            If row.Cells(0).Value Is Nothing Then
                Exit For
            End If

            For i As Integer = 1 To row.Cells(4).Value.ToString
                DataTable.Rows.Add(row.Cells.Item(0).Value, row.Cells.Item(1).Value, row.Cells.Item(2).Value, row.Cells.Item(4).Value, GetBarcode(row.Cells(0).Value), $"Rs.{row.Cells.Item(5).Value}")
            Next
        Next

        Report.SetDataSource(DataTable)
        Return Report
    End Function

End Class
