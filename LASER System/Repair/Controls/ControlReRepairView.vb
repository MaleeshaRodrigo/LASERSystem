Imports System.Data.Odbc

Public Class ControlReRepairView
    Private ReadOnly DB As Database
    Public Sub New(DB As Database)
        InitializeComponent()

        Me.DB = DB
    End Sub

    Public Sub Init(RepNo As Integer)
        Dim DataTable = DB.GetDataTable($"SELECT RetNo, Status FROM Return WHERE RepNo=@REPNO;", {
                New OdbcParameter("REPNO", RepNo)
            })
        GridReRepairView.DataSource = DataTable
    End Sub

    Public Sub Clear()
        GridReRepairView.DataSource = Nothing
        GridReRepairView.Rows.Clear()
    End Sub

End Class
