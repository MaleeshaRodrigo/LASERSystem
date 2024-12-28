Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCashierDashboard
    Private Db As Database
    Private UserController As New UserController
    Private ControlLoginContainer As ControlCashierDashboardLogin

    Public Sub Init(Db As Database)
        Me.Db = Db
        UserController.SetDatabase(Db)
        Dim DataReader = UserController.GetUser(User.Instance.UserName)
        FillUserInfo(DataReader)
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
        Dim Precentage As Double = My.Settings.SaleCommissionPrecentage / 100
        Dim DataTable = Db.GetDataTable($"SELECT 
            DATE(SaDate) as 'Date',
	        sas.SNo,
	        CONCAT(Sas.SCategory, ' ', Sas.SName) as 'Stock',
	        sas.SaType as 'Type',
	        if(sas.SaType = 'Sale', SaRate, -SaRate)  as 'Rate',
	        SaUnits as 'Qty',
	        if(sas.SaType = 'Sale', SaTotal, -SaTotal) as 'Total',
	        if(sas.SaType = 'Sale', SLowestPrice, -SLowestPrice) as 'LowestPrice',
	        if(sas.SaType = 'Sale', (SLowestPrice * SaUnits), -(SLowestPrice * SaUnits)) as 'TotalLowestPrice',
	        if(sas.SaType = 'Sale', SaTotal - (SLowestPrice * SaUnits), -(SaTotal - (SLowestPrice * SaUnits))) as 'Profit'
            FROM {Tables.StockSale} sas LEFT JOIN {Tables.Sale} sa ON sa.SaNo = sas.SaNo LEFT JOIN `{Tables.User}` u ON u.UNo = sa.UNo LEFT JOIN {Tables.Stock} s ON s.sno = sas.SNo 
            WHERE u.UserName = @USERNAME AND DATE(SaDate) BETWEEN DATE(@FROMDATE) AND DATE(@TODATE);", {
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
        Dim TotalLessAmount As Object = Db.GetData($"SELECT SUM(SaLess) FROM sale WHERE DATE(SaDate) BETWEEN DATE(@FROMDATE) AND DATE(@TODATE);", {
            New MySqlParameter("FROMDATE", PickerFrom.Value.Date),
            New MySqlParameter("TODATE", PickerTo.Value.Date)
        })
        TotalLessAmount = If(IsDBNull(TotalLessAmount), 0, Double.Parse(TotalLessAmount))
        Dim TotalCommission As Double = (TotalProfit - TotalLessAmount) * Precentage
        GridCashierSales.DataSource = DataTable
        LabelLessAmount.Text = $"Less: Rs. {TotalLessAmount}"
        LabelCommision.Text = $"Commission: Rs. {TotalCommission}"
    End Sub

    Private Sub PickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles PickerFrom.ValueChanged, PickerTo.ValueChanged
        FillStockInfo(User.Instance.UserName)
    End Sub

    Private Sub ButtonShowProfit_Click(sender As Object, e As EventArgs) Handles ButtonShowProfit.Click
        If ButtonShowProfit.Text = "Show Profit" Then
            ControlLoginContainer = New ControlCashierDashboardLogin()
            ControlLoginContainer.ControlLogin.Init(Db)
            ControlLoginContainer.Dock = DockStyle.Fill
            AddHandler ControlLoginContainer.ControlLogin.LoginEvent, AddressOf ControlLogin_LoginEvent
            Controls.Add(ControlLoginContainer)
            ControlLoginContainer.BringToFront()
        Else
            ControlLoginContainer.Dispose()
            ShowCommissionControls(False)
            ButtonShowProfit.Text = "Show Profit"
        End If
    End Sub

    Private Sub ControlLogin_LoginEvent(Success As Boolean, User As Dictionary(Of String, Object))
        FillUserInfo(User)
        FillStockInfo(User("UserName"))
        ShowCommissionControls(True)
        ControlLoginContainer.Dispose()
        TimerHideProfit.Start()
        ButtonShowProfit.Text = "Hide Profit"
    End Sub

    Private Sub TimerHideProfit_Tick(sender As Object, e As EventArgs) Handles TimerHideProfit.Tick
        ControlLoginContainer.Dispose()
        ShowCommissionControls(False)
        ButtonShowProfit.Text = "Show Profit"
        TimerHideProfit.Stop()
    End Sub

    Private Sub ShowCommissionControls(Visiable As Boolean)
        Dim Controls = {LabelCommision, GridCashierSales, LabelFrom, PickerFrom, LabelTo, PickerTo}
        For Each Control As Control In Controls
            Control.Visible = Visiable
        Next
    End Sub

    Private Sub ControlCashierDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowCommissionControls(False)
        PickerFrom.Value = New DateTime(PickerFrom.Value.Year, PickerFrom.Value.Month, 1)
    End Sub
End Class