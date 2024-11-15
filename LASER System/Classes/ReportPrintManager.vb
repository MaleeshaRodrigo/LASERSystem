Imports System.IO
Imports System.Threading
Imports ZXing

Public Class ReportPrintManager

    Public Sub PrintReceivedReceipt(RNo As String, Optional boolPrint As Boolean = False, Optional boolClosed As Boolean = False, Optional formTag As String = "")
        If IsNumeric(RNo) = False Or RNo = "" Then
            Exit Sub
        End If
        Dim UserName As String = User.Instance.UserName
        Dim threadInvoice As New Thread(Sub() PrintReceivedReceiptThread(RNo, boolPrint, boolClosed)) With {
                .Name = "showInvoiceReport",
                .IsBackground = False
        }
        threadInvoice.SetApartmentState(ApartmentState.STA)
        threadInvoice.Priority = ThreadPriority.Highest
        threadInvoice.Start()
    End Sub

    Public Sub PrintRepairSticker(RNo As String, Optional boolPrint As Boolean = False, Optional boolClosed As Boolean = False, Optional formTag As String = "")
        If IsNumeric(RNo) = False Or RNo = "" Then Exit Sub
        Dim threadSticker As New Thread(Sub() PrintRepairStickerThread(RNo, boolPrint, boolClosed)) With {
            .Name = "showStickerReport",
            .IsBackground = False
        }
        threadSticker.SetApartmentState(ApartmentState.STA)
        threadSticker.Priority = ThreadPriority.Highest
        threadSticker.Start()
    End Sub

    Private Sub PrintReceivedReceiptThread(RNo As String, boolPrint As Boolean, boolClosed As Boolean)
        Dim ThreadDb As New Database()
        Dim frm1 As New frmReport
        Dim RPT As New rptReceive
        Try
            Dim DTRepair As DataTable = ThreadDb.GetDataTable($"SELECT RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,'' as RetNo, RepNo, PCategory, PName, PModelNo, PSerialNo, Qty, Problem, '' as RepRemarks1 from (((Repair Inner Join Receive On Receive.RNo =Repair.RNo) Left Join Product On Product.PNo=Repair.PNo) Left Join Customer On Customer.CuNo=Receive.CuNo) Where Receive.RNo = {RNo} Union Select RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3, RetNo, RepNo, PCategory, PName, PModelNo, PSerialNo, Qty, Problem, '' as RepRemarks1 from (((`Return` Inner Join Receive On Receive.RNo =Return.RNo) Left Join Product On Product.PNo=Return.PNo) Left Join Customer On Customer.CuNo=Receive.CuNo) Where Receive.RNo = {RNo}")
            For Each row As DataRow In DTRepair.Rows
                Dim DrRemarks = ThreadDb.GetDataList($"Select Remarks from RepairRemarks1 Where {If(row.Item("RetNo") = "", $"RepNo={row.Item("RepNo")}", $"RetNo={row.Item("RetNo")}")};")
                row.Item("RepRemarks1") = ""
                For Each Item In DrRemarks
                    row.Item("RepRemarks1") += Item("Remarks").ToString + vbCrLf
                Next
            Next
            RPT.SetDataSource(DTRepair)

            RPT.SetParameterValue("Cashier Name", User.Instance.UserName)
            Dim rawKind1 As Integer
            Dim c1 As Integer
            Dim doctoprint1 As New Printing.PrintDocument()
            doctoprint1.PrinterSettings.PrinterName = My.Settings.BillPrinterName
            For c1 = 0 To doctoprint1.PrinterSettings.PaperSizes.Count - 1
                If doctoprint1.PrinterSettings.PaperSizes(c1).PaperName = My.Settings.BillPrinterPaperName Then
                    rawKind1 = CInt(doctoprint1.PrinterSettings.PaperSizes(c1).
                                            GetType().GetField("kind", Reflection.BindingFlags.Instance Or
                                            Reflection.BindingFlags.NonPublic).GetValue(doctoprint1.PrinterSettings.PaperSizes(c1)))
                    Exit For
                End If
            Next
            If rawKind1 Then
                RPT.PrintOptions.PaperSize = CType(rawKind1, CrystalDecisions.Shared.PaperSize)
                RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            End If
            If boolPrint Then   'Choose the printer and paper size. Then, print the report
                RPT.PrintToPrinter(1, False, 0, 0)
            End If
            With frm1
                .ReportViewer.ReportSource = RPT
                .Name = "frmReport" + NextfrmNo(frmReport).ToString
                .boolClosed = boolClosed
                .WindowState = FormWindowState.Normal
                .Text = "Report - Received Receipt"
                Application.Run(frm1)
            End With
        Catch ex As Exception
            MsgBox("Receipt Invoice එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message, vbCritical, "Print Receipt Invoice Error")
        Finally
            RPT.Close()
        End Try
    End Sub

    Private Sub PrintRepairStickerThread(RNo As String, boolPrint As Boolean, boolClosed As Boolean)
        Dim ThreadDb As New Database()
        Try
            Dim rpt3 As New rptRepairSticker
            Dim DT, DT1 As New DataTable
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
            Dim writer As New BarcodeWriter With {
                .Format = BarcodeFormat.CODE_128
            }
            writer.Options.PureBarcode = True
            DT1 = ThreadDb.GetDataTable("SELECT Repair.RepNo,RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,PCategory,PName,Qty from Repair,Product,Receive,Customer where Receive.RNO = Repair.RNo and Repair.PNo = Product.PNo and Customer.CuNo = Receive.CuNo and Receive.RNo=" &
                                                  RNo & ";")
            For Each row As DataRow In DT1.Rows
                Dim imgStream As New MemoryStream()
                Dim img As Image = writer.Write(row.Item("RepNo"))
                img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                Dim byteArray As Byte() = imgStream.ToArray()
                imgStream.Close()
                For i As Integer = 1 To row.Item("Qty")
                    DT.Rows.Add("R" & row.Item("RepNo"), row.Item("CuName"), row.Item("CuTelNo1"), row.Item("CuTelNo2"), row.Item("CuTelNo3"), row.Item("PCategory"),
                            row.Item("PName"), row.Item("RDate"), byteArray)
                Next
            Next
            rpt3.SetDataSource(DT)
            If DT.Rows.Count < 1 Then Exit Sub
            Dim FormReport As New frmReport
            FormReport.ReportViewer.ReportSource = rpt3
            Dim c2 As Integer
            Dim doctoprint2 As New System.Drawing.Printing.PrintDocument()
            doctoprint2.PrinterSettings.PrinterName = My.Settings.StickerPrinterName
            Dim rawKind As Integer
            For c2 = 0 To doctoprint2.PrinterSettings.PaperSizes.Count - 1
                If doctoprint2.PrinterSettings.PaperSizes(c2).PaperName = My.Settings.RepairStickerPrinterPaperName Then
                    rawKind = CInt(doctoprint2.PrinterSettings.PaperSizes(c2).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint2.PrinterSettings.PaperSizes(c2)))
                    Exit For
                End If
            Next
            rpt3.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            rpt3.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
            If boolPrint Then
                rpt3.PrintToPrinter(1, False, 0, 0)
            End If
            With FormReport
                .Name = "frmReport" + NextfrmNo(frmReport).ToString
                .boolClosed = boolClosed
                .WindowState = FormWindowState.Normal
                .Text = "Report - Received Sticker/s"
                Application.Run(FormReport)
            End With
            rpt3.Close()
        Catch ex As Exception
            MsgBox("Receipt Sticker එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message, vbCritical, "Print Receipt Sticker Error")
        End Try
    End Sub
End Class
