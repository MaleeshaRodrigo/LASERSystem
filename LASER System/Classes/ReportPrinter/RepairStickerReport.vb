Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine

Public Class RepairStickerReport
    Inherits AbstractReportManager
    Implements ReportPrint

    Public Function GenerateReport(ReceiveNo As Integer) As ReportClass
        Dim Report As New rptRepairSticker
        Dim DT As New DataTable
        DT.Clear()
        DT.Columns.Add("RepNo")
        DT.Columns.Add("CuName")
        DT.Columns.Add("CuTelNo1")
        DT.Columns.Add("CuTelNo2")
        DT.Columns.Add("CuTelNo3")
        DT.Columns.Add("PCategory")
        DT.Columns.Add("PName")
        DT.Columns.Add("RDate")
        DT.Columns.Add(New DataColumn("Barcode", GetType(Byte())))
        Dim DT1 = Database.GetDataTable("SELECT Repair.RepNo,RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,PCategory,PName,Qty from Repair,Product,Receive,Customer where Receive.RNO = Repair.RNo and Repair.PNo = Product.PNo and Customer.CuNo = Receive.CuNo and Receive.RNo=" & ReceiveNo & ";")
        For Each row As DataRow In DT1.Rows
            For i As Integer = 1 To row.Item("Qty")
                DT.Rows.Add(
                    "R" & row.Item("RepNo"),
                    row.Item("CuName"),
                    row.Item("CuTelNo1"),
                    row.Item("CuTelNo2"),
                    row.Item("CuTelNo3"),
                    row.Item("PCategory"),
                    row.Item("PName"),
                    Date.Parse(row.Item("RDate")).Date.ToString("yyyy-MM-dd"),
                    GetBarcode(row.Item("RepNo"))
                )
            Next
        Next
        Report.SetDataSource(DT)
        Return Report
    End Function
End Class
