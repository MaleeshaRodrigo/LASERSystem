Public Class ControlGridRemarks
    Public Sub Init(Db As Database, RepairMode As RepairMode, ControlRemarksOption As ControlRemarksOption, PrimaryNo As Integer)
        ControlRemarks.ControlRemarkOption = ControlRemarksOption
        ControlRemarks.Init(Db, RepairMode, PrimaryNo)
        LabelRepairNo.Text = LabelRepairNo.Text & PrimaryNo
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dispose()
    End Sub
End Class
