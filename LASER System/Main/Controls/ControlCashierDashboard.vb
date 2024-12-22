Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCashierDashboard
    Private Db As Database
    Private UserController As New UserController
    Private ControlLogin As ControlLogin

    Public Sub Init(Db As Database)
        Me.Db = Db
        UserController.SetDatabase(Db)
        Dim DataReader = UserController.GetUser(User.Instance.UserName)
        FillUserInfo(DataReader)
        ShowProfit(False)
    End Sub

    Private Sub FillUserInfo(DataReader As Dictionary(Of String, Object))
        If DataReader Is Nothing Then
            Exit Sub
        End If

        LabelUserName.Text = "Name: " + DataReader("UserName").ToString
        LabelEmail.Text = "Email: " + DataReader("Email").ToString
        LabelLastLogin.Text = "Last Login: " + DataReader("LastLogin").ToString
    End Sub

    Private Sub FillStockInfo(UserName As String)
        Dim TotalProfit As Double
        Dim Precentage As Double = 0.3
        Dim DataTable = Db.GetDataTable($"SELECT date(SaDate) AS 'Date', sas.SNo, Sas.SCategory, Sas.SName, sas.SaType AS 'Type', SaRate AS 'Rate', SaUnits AS 'Qty',	SaTotal AS 'Total',	SLowestPrice AS 'LowestPrice',	(SLowestPrice * SaUnits) AS 'TotalLowestPrice', SaTotal - (SLowestPrice * SaUnits) AS 'Profit' FROM {Tables.StockSale} sas LEFT JOIN {Tables.Sale} sa ON sa.SaNo = sas.SaNo LEFT JOIN `USER` u ON u.UNo = sa.UNo LEFT JOIN stock s ON s.sno = sas.SNo WHERE u.UserName = @USERNAME AND SaDate BETWEEN date(@FROMDATE) AND date(@TODATE);", {
            New MySqlParameter("USERNAME", UserName),
            New MySqlParameter("FROMDATE", PickerFrom.Value.Date),
            New MySqlParameter("TODATE", PickerTo.Value.Date)
        })
        For Each Row As DataRow In DataTable.Rows
            If IsDBNull(Row("LowestPrice")) OrElse Row("LowestPrice") = 0 Then
                Row("LowestPrice") = DBNull.Value
                Row("TotalLowestPrice") = DBNull.Value
                Row("Profit") = DBNull.Value
                Continue For
            End If

            TotalProfit += Row("Profit")
        Next
        GridCashierSales.DataSource = DataTable
        LabelProfit.Text = $"Profit: Rs. {TotalProfit * Precentage}"
    End Sub

    Private Sub PickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles PickerFrom.ValueChanged, PickerTo.ValueChanged
        FillStockInfo(User.Instance.UserName)
    End Sub

    Private Sub ButtonShowProfit_Click(sender As Object, e As EventArgs) Handles ButtonShowProfit.Click
        ControlLogin = New ControlLogin
        ControlLogin.Init(Db)
        ControlLogin.Dock = DockStyle.Fill
        TimerHideProfit.Start()
        AddHandler ControlLogin.LoginEvent, AddressOf ControlLogin_LoginEvent
        Controls.Add(ControlLogin)
        ControlLogin.BringToFront()
    End Sub

    Private Sub ControlLogin_LoginEvent(Success As Boolean, User As Dictionary(Of String, Object))
        FillUserInfo(User)
        FillStockInfo(User("UserName"))
        ShowProfit(True)
        ControlLogin.Dispose()
    End Sub

    Private Sub TimerHideProfit_Tick(sender As Object, e As EventArgs) Handles TimerHideProfit.Tick
        ShowProfit(False)
        TimerHideProfit.Stop()
    End Sub

    Private Sub ShowProfit(Visiable As Boolean)
        Dim Controls = {LabelProfit, GridCashierSales, LabelFrom, PickerFrom, LabelTo, PickerTo}
        For Each Control As Control In Controls
            Control.Visible = Visiable
        Next
    End Sub
End Class
