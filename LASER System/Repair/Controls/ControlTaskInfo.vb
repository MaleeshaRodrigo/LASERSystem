Imports System.Data.Odbc

Public Class ControlTaskInfo
    Private DB As Database
    Public Sub New(DB As Database)
        InitializeComponent()

        Me.DB = DB
    End Sub

    Public Sub InitForRepair(RepNo As Integer)
        Dim DataTable = DB.GetDataTable("SELECT MsgNo,MsgDate,Action,Message,Status FROM Message WHERE RepNo = @REPNO", {
                                            New OdbcParameter("REPNO", RepNo)
                                        })
        grdRepTask.DataSource = DataTable
    End Sub

    Public Sub InitForReRepair(ReRepNo As Integer)
        Dim DataTable = DB.GetDataTable("SELECT MsgNo,MsgDate,Action,Message,Status FROM Message WHERE RetNo = @REREPNO", {
                                            New OdbcParameter("REREPNO", ReRepNo)
                                        })
        grdRepTask.DataSource = DataTable
    End Sub

    Public Sub Clear()
        grdRepTask.DataSource = Nothing
        grdRepTask.Rows.Clear()
    End Sub

End Class
