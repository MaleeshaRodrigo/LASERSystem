Public Class ControlRepairReRepairSelection
    Private Db As Database

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
    End Sub

    Private Sub ComboRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboRepNo.DropDown
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RepNo FROM Repair ORDER BY RepNo DESC;")
    End Sub

    Private Sub ComboReRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboReRepNo.DropDown
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RetNo FROM `Return` ORDER BY RetNo DESC;")
    End Sub

End Class
