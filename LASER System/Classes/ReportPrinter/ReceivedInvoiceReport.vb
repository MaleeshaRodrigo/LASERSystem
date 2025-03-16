Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine

Public Class ReceivedInvoiceReport
    Inherits AbstractReportManager
    Implements ReportPrint

    Public Function GenerateReport(ReceivedNo As Integer) As ReportClass
        Dim Report As New rptReceive
        Dim DataTable As DataTable = Database.GetDataTable($"SELECT RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,'' as RetNo, RepNo, PCategory, PName, PModelNo, PSerialNo, Qty, Problem, '' as RepRemarks1 from (((Repair Inner Join Receive On Receive.RNo =Repair.RNo) Left Join Product On Product.PNo=Repair.PNo) Left Join Customer On Customer.CuNo=Receive.CuNo) Where Receive.RNo = {ReceivedNo} Union Select RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3, RetNo, RepNo, PCategory, PName, PModelNo, PSerialNo, Qty, Problem, '' as RepRemarks1 from (((`Return` Inner Join Receive On Receive.RNo =Return.RNo) Left Join Product On Product.PNo=Return.PNo) Left Join Customer On Customer.CuNo=Receive.CuNo) Where Receive.RNo = {ReceivedNo}")
        DataTable.Columns.Add(New DataColumn("Barcode", GetType(Byte())))
        For Each Row As DataRow In DataTable.Rows
            Dim DrRemarks = Database.GetDataList($"Select Remarks from RepairRemarks1 Where {If(Row.Item("RetNo") = "", $"RepNo={Row.Item("RepNo")}", $"RetNo={Row.Item("RetNo")}")};")
            Row.Item("RepRemarks1") = ""
            For Each Item In DrRemarks
                Row.Item("RepRemarks1") += Item("Remarks").ToString + vbCrLf
            Next
            Row.Item("Barcode") = GetBarcode(Row.Item("RepNo"))
        Next
        Report.SetDataSource(DataTable)
        Report.SetParameterValue("Cashier Name", User.Instance.UserName)
        Return Report
    End Function
End Class
