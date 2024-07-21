Public Class ControlRepairReRepairSelection
    Public RepairMode As RepairMode
    Public Event RepairNoChanged(RepairNo As Integer)
    Public Event ReRepairNoChanged(ReRepairNo As Integer)

    Private Db As Database

    Public ReadOnly Property Value() As Integer
        Get
            If RepairMode = RepairMode.Repair And IsNumeric(ComboRepNo.Text) Then
                Return ComboRepNo.Text
            ElseIf RepairMode = RepairMode.ReRepair And IsNumeric(ComboReRepNo.Text) Then
                Return ComboReRepNo.Text
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
    End Sub

    Public Sub SetRepair(RepairNo As Integer)
        ComboRepNo.Text = RepairNo
        RadioRepNo.Checked = True
    End Sub

    Public Sub SetReRepair(ReRepairNo As Integer)
        ComboReRepNo.Text = ReRepairNo
        RadioReRepNo.Checked = True
    End Sub

    Private Sub ComboRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboRepNo.DropDown, Me.Load
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RepNo FROM Repair ORDER BY RepNo DESC;")
    End Sub

    Private Sub ComboReRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboReRepNo.DropDown, Me.Load
        ComboBoxDropDown(Db, ComboReRepNo, "SELECT RetNo FROM `Return` ORDER BY RetNo DESC;")
    End Sub

    Private Sub ComboRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboRepNo.SelectedIndexChanged
        SetRepair(ComboRepNo.Text)
        RaiseEvent RepairNoChanged(ComboRepNo.Text)
    End Sub

    Private Sub ComboReRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboReRepNo.SelectedIndexChanged
        SetReRepair(ComboReRepNo.Text)
        RaiseEvent ReRepairNoChanged(ComboReRepNo.Text)
    End Sub

    Private Sub RadioRepNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRepNo.CheckedChanged
        If RadioRepNo.Checked Then
            RepairMode = RepairMode.Repair
            ComboReRepNo.Text = ""
        ElseIf RadioReRepNo.Checked Then
            RepairMode = RepairMode.ReRepair
            ComboRepNo.Text = ""
        End If
    End Sub
End Class
