Imports System.Data.Odbc

Public Class ControlActivityInfo
    Private DB As Database

    Public Sub New(DB As Database)
        InitializeComponent()

        Me.DB = DB
    End Sub

    Public Sub InitForRepair(RepNo As Integer)
        Dim DataTable = DB.GetDataTable("Select RepANo, RepADate, Activity, UserName from RepairActivity RepA LEFT JOIN `User` U ON U.UNo=RepA.UNo Where RepNo=@REPNO", {
                                            New OdbcParameter("REPNO", RepNo)
                                        })
        grdActivity.DataSource = DataTable
    End Sub

    Public Sub InitForReRepair(ReRepNo As Integer)
        Dim DataTable = DB.GetDataTable("Select RepANo, RepADate, Activity, UserName from RepairActivity RepA LEFT JOIN `User` U ON U.UNo=RepA.UNo Where RetNo=@REREPNO", {
                                            New OdbcParameter("REREPNO", ReRepNo)
                                        })
        grdActivity.DataSource = DataTable
    End Sub

    Public Sub Clear()
        grdActivity.DataSource = Nothing
        grdActivity.Rows.Clear()
    End Sub
End Class
