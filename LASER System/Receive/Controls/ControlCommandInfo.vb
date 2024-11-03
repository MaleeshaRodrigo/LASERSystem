Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCommandInfo
    Public Event CancelEvent()

    Private Db As Database
    Private RepairController As New RepairController()
    Private RepairTable, ReRepairTable As DataTable
    Private Data As Dictionary(Of String, Object)

    Public Function SetDatabase(Db As Database) As ControlCommandInfo
        Me.Db = Db
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

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
        RaiseEvent CancelEvent()
    End Sub

    Private Sub cmdReceiptSticker_Click(sender As Object, e As EventArgs) Handles cmdReceiptSticker.Click, cmdReceipt.Click, cmdSticker.Click, cmdSaveOnly.Click
        Dim ReportPrintManager As New ReportPrintManager()
        RepairController.SaveReceivedRepair(Data, RepairTable, ReRepairTable)
        If sender Is cmdReceipt Or sender Is cmdReceiptSticker Then
            ReportPrintManager.PrintReceivedReceipt(Data(Receive.RNo), True, True, "ReceivedReceipt")
        End If
        If sender Is cmdSticker Or sender Is cmdReceiptSticker Then
            ReportPrintManager.PrintRepairSticker(Data(Receive.RNo), True, True, "ReceivedSticker")
        End If
    End Sub
End Class
