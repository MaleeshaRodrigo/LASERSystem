Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports ZXing

Public MustInherit Class AbstractReportManager
    Protected PrinterName As String
    Protected PaperName As String
    Protected ReadOnly Database As New Database()

    Public Function SetPrinterName(PrinterName As String) As AbstractReportManager
        Me.PrinterName = PrinterName
        Return Me
    End Function

    Public Function SetPaperName(PaperName As String) As AbstractReportManager
        Me.PaperName = PaperName
        Return Me
    End Function

    Public Overridable Function GetFormReport(ByRef Report As ReportClass, Optional ReportName As String = "Report", Optional ActivateTimelyClosed As Boolean = False) As FormReport
        If Report Is Nothing Then
            Throw New Exception("Report is not set")
        End If

        SetConfiguration(Report)
        Dim Form As New FormReport
        With Form
            .ReportViewer.ReportSource = Report
            .ReportViewer.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
            .Name = "FormReport" + NextFormNo(FormReport).ToString
            .ActiviteTimelyClosed = ActivateTimelyClosed
            .WindowState = FormWindowState.Normal
            .Text = ReportName
        End With
        Return Form
    End Function

    Public Sub Print(Report As ReportClass)
        If Report Is Nothing Then
            Throw New Exception("Report is not set")
        End If

        Report.PrintToPrinter(1, False, 0, 0)
    End Sub

    Protected Function GetBarcode(Value As String) As Byte()
        Dim Writer As New BarcodeWriter With {
            .Format = BarcodeFormat.CODE_128
        }
        Writer.Options.PureBarcode = True
        Using ImgStream As New MemoryStream()
            Dim img As Image = Writer.Write(Value)
            img.Save(ImgStream, Imaging.ImageFormat.Png)
            Return ImgStream.ToArray()
        End Using
    End Function

    Protected Sub SetConfiguration(ByRef Report As ReportClass)
        Dim Count As Integer
        Dim DoctoPrinter As New Printing.PrintDocument()
        DoctoPrinter.PrinterSettings.PrinterName = PrinterName
        Dim RawKind As Integer
        For Count = 0 To DoctoPrinter.PrinterSettings.PaperSizes.Count - 1
            If DoctoPrinter.PrinterSettings.PaperSizes(Count).PaperName <> PaperName Then
                Continue For
            End If

            RawKind = CInt(DoctoPrinter.PrinterSettings.PaperSizes(Count).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(DoctoPrinter.PrinterSettings.PaperSizes(Count)))
            Exit For
        Next
        Report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        Report.PrintOptions.PaperSize = CType(RawKind, CrystalDecisions.Shared.PaperSize)
    End Sub
End Class
