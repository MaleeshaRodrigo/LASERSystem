Imports MySqlConnector

Public Class ControlReRepairView
    Private DB As Database

    Public Function SetDatabase(Db As Database) As ControlReRepairView
        Me.DB = Db
        Return Me
    End Function

    Public Sub Init(RepNo As Integer)
        Dim DataTable = DB.GetDataTable($"SELECT RetNo, Status FROM `Return` WHERE RepNo=@REPNO;", {
                New MySqlParameter("REPNO", RepNo)
            })
        GridReRepairView.DataSource = DataTable
    End Sub

    Public Sub Clear()
        GridReRepairView.DataSource = Nothing
        GridReRepairView.Rows.Clear()
    End Sub

End Class
