Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCashierDashboard
    Private Db As Database

    Public Sub Init(Db As Database)
        Me.Db = Db

        FillUserInfo()
        FillStockInfo()
    End Sub

    Private Sub FillUserInfo()
        Dim DataReader = Db.GetDataDictionary("Select * from `User` Where UserName=@USERNAME;", {
            New MySqlParameter("USERNAME", User.Instance.UserName)
        })
        If DataReader IsNot Nothing Then
            LabelUserName.Text = "Name: " + DataReader("UserName").ToString
            LabelEmail.Text = "Email: " + DataReader("Email").ToString
            LabelLastLogin.Text = "Last Login: " + DataReader("LastLogin").ToString
            LabelLogCount.Text = "Login Count: " + DataReader("LoginCount").ToString
        End If
    End Sub

    Private Sub FillStockInfo()
        Dim TotalProfit As Double
        Dim Precentage As Double = 0.3
        Dim DataTable = Db.GetDataTable($"SELECT date(SaDate) AS 'Date', sas.SNo, Sas.SCategory, Sas.SName, sas.SaType AS 'Type',	SaRate AS 'Rate', SaUnits AS 'Qty',	SaTotal AS 'Total',	SLowestPrice AS 'LowestPrice',	(SLowestPrice * SaUnits) AS 'TotalLowestPrice', SaTotal - (SLowestPrice * SaUnits) AS 'Profit' FROM {Tables.StockSale} sas LEFT JOIN {Tables.Sale} sa ON sa.SaNo = sas.SaNo LEFT JOIN `USER` u ON u.UNo = sa.UNo LEFT JOIN stock s ON	s.sno = sas.SNo WHERE SaDate BETWEEN date(@FROMDATE) AND date(@TODATE);", {
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
        FillStockInfo()
    End Sub
End Class
