Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class FormCommission
    Private Db As New Database

    Private Sub FormCommission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxDropDown(Db, ComboUser, $"SELECT DISTINCT(UserName) FROM `{Tables.User}` ORDER BY UserName;")
        TextDateFrom.Value = $"{Date.Today.Year}-{Date.Today.Month}-01"
        TextDateTo.Value = $"{Date.Today.Year}-{Date.Today.Month}-{Date.DaysInMonth(Date.Today.Year, Date.Today.Month)}"
    End Sub

    Private Sub LoadDataGrid()
        Dim TotalSale As Double = 0
        Dim TotalCost As Double = 0
        Dim DataTable As DataTable = Db.GetDataTable($"SELECT sa.SaDate, ssa.SNo, ssa.SCategory, ssa.SName,	SaType,	SaRate,	SLowestPrice, SaUnits, SaTotal,	IF(satype = 'Sale', (SLowestPrice * SaUnits), -(SLowestPrice * SaUnits)) AS 'SaTotalLowest' FROM `stocksale` ssa LEFT JOIN stock s ON s.SNo  = ssa.SNo INNER JOIN sale sa ON sa.SaNo = ssa.SaNo INNER JOIN `user` u ON u.uno = sa.UNo WHERE u.UserName = @USERNAME ORDER BY sa.SaDate;", {
            New MySqlParameter("USERNAME", ComboUser.Text)
        })
        GridCommission.DataSource = DataTable
        For Each Row As DataRow In DataTable.Rows
            If IsNumeric(Row("SaTotal")) Then
                TotalSale += Row("SaTotal")
            End If

            If IsNumeric(Row("SaTotalLowest")) Then
                TotalCost += Row("SaTotalLowest")
            End If
        Next
    End Sub

    Private Sub ComboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUser.SelectedIndexChanged, TextDateFrom.ValueChanged, TextDateTo.ValueChanged
        If ComboUser.Text = "" Then
            Return
        End If

        LoadDataGrid()
    End Sub
End Class