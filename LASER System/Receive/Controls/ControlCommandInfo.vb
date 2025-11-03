Imports System.Threading
Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCommandInfo
    Public Event SubmitEvent()
    Public Event CancelEvent()

    Private Db As New TransactionDatabase
    Private RepairController As New RepairController()
    Private RepairTable, ReRepairTable As DataTable
    Private Data As Dictionary(Of String, Object)

    Public Function Init() As ControlCommandInfo
        RepairController.SetDatabase(Db)
        Return Me
    End Function

    Public Function SetData(Data As Dictionary(Of String, Object), RepairTable As DataTable, ReRepairTable As DataTable) As ControlCommandInfo
        Me.Data = Data
        Me.RepairTable = RepairTable
        Me.ReRepairTable = ReRepairTable
        Return Me
    End Function

    Public Sub KeyDownEvent(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
            cmdCancel.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
            cmdReceiptSticker.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
            cmdReceipt.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
            cmdSticker.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
            cmdSaveOnly.PerformClick()
        End If
    End Sub

    Private Sub ControlCommandInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmdReceiptSticker.Focus()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Dispose()
        RaiseEvent CancelEvent()
    End Sub

    Private Sub CmdReceiptSticker_Click(sender As Object, e As EventArgs) Handles cmdReceiptSticker.Click, cmdReceipt.Click, cmdSticker.Click, cmdSaveOnly.Click
        Try
            Dim RNo As Integer = SaveReceivedRepair()
            If sender Is cmdReceipt Or sender Is cmdReceiptSticker Then
                ReceivedInvoicePrint(RNo)
            End If
            If sender Is cmdSticker Or sender Is cmdReceiptSticker Then
                RepairStickerPrint(RNo)
            End If
        Catch ex As Exception
            MessageBox.Error("Received Repair Save and Print Section එකෙහි දෝෂයක් පවතියි." + vbCrLf + "Message: " + ex.Message)
        Finally
            Dispose()
            RaiseEvent SubmitEvent()
        End Try
    End Sub

    Private Function SaveReceivedRepair() As Integer
        Try
            Db.BeginTransaction()
            Dim RNo As Integer = RepairController.SaveReceivedRepair(Data, RepairTable, ReRepairTable)
            Db.CommitTransaction()
            Return RNo
        Catch ex As Exception
            Db.RollbackTransaction()
            Throw ex
        End Try
    End Function

    Private Sub ReceivedInvoicePrint(ReceivedNo As Integer)
        If IsNumeric(ReceivedNo) = False Then
            Exit Sub
        End If

        Dim UserName As String = User.Instance.UserName
        Dim ThreadInvoice As New Thread(
            Sub()
                Dim Form As New FormReport
                Try
                    Dim ReportManager As New ReceivedInvoiceReport()
                    ReportManager.SetPrinterName(My.Settings.BillPrinterName).SetPaperName(My.Settings.BillPrinterPaperName)
                    Dim Report = ReportManager.GenerateReport(ReceivedNo)
                    Dim FormReport = ReportManager.GetFormReport(Report, "Report - Received Receipt", True)
                    ReportManager.Print(Report)
                    Application.Run(FormReport)
                Catch ex As Exception
                    MessageBox.Error("Receipt Invoice එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message)
                End Try
            End Sub) With {.Name = "ShowInvoiceReport", .IsBackground = False}
        ThreadInvoice.SetApartmentState(ApartmentState.STA)
        ThreadInvoice.Priority = ThreadPriority.Highest
        ThreadInvoice.Start()
    End Sub

    Private Sub RepairStickerPrint(ReceivedNo As Integer)
        If IsNumeric(ReceivedNo) = False Then
            Exit Sub
        End If

        Dim UserName As String = User.Instance.UserName
        Dim ThreadInvoice As New Thread(
            Sub()
                Dim Form As New FormReport
                Try
                    Dim ReportManager As New RepairStickerReport()
                    ReportManager.SetPrinterName(My.Settings.StickerPrinterName).SetPaperName(My.Settings.RepairStickerPrinterPaperName)
                    Dim Report = ReportManager.GenerateReport(ReceivedNo)
                    Dim FormReport = ReportManager.GetFormReport(Report, "Report - Repair Sticker", True)
                    ReportManager.Print(Report)
                    Application.Run(FormReport)
                Catch ex As Exception
                    MessageBox.Error("Receipt Sticker එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message)
                End Try
            End Sub) With {.Name = "ShowRepairStickerReport", .IsBackground = False}
        ThreadInvoice.SetApartmentState(ApartmentState.STA)
        ThreadInvoice.Priority = ThreadPriority.Highest
        ThreadInvoice.Start()
    End Sub
End Class
