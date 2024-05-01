Public Class ControlRepairDeliverInfo
    Private Db As Database

    Public Sub New(Db As Database)
        InitializeComponent()

        Me.Db = Db
    End Sub

    Public Function SetRepDetails(RepairCharge As Decimal, RepairedDate As String) As ControlRepairDeliverInfo
        txtRepPrice.Text = RepairCharge
        txtRepDate.Text = RepairedDate
        Return Me
    End Function

    Public Function SetDeliverDetails(DNo As Integer, PaidPrice As Decimal, DeliveredDate As String) As ControlRepairDeliverInfo
        txtDNo.Text = DNo
        txtDPaidPrice.Text = PaidPrice
        txtDDate.Text = DeliveredDate
        Return Me
    End Function

    Public Function SetDeliverInfoVisibility(Visible As Boolean) As ControlRepairDeliverInfo
        boxDeliver.Visible = Visible
        Return Me
    End Function

    Public Sub Clear()
        For Each ClearControl As Control In {txtRepPrice, txtRepDate, txtDNo, txtDDate, txtDPaidPrice}
            ClearControl.Text = ""
        Next
    End Sub

End Class
