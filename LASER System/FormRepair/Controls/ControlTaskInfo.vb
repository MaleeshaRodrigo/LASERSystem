Imports System.Data.OleDb

Public Class ControlTaskInfo
    Private DB As Database
    Public Sub New(DB As Database)
        InitializeComponent()

        Me.DB = DB
    End Sub

    Public Sub Init(RepNo As Integer)
        Dim DataTable = DB.GetDataTable("Select MsgNo,MsgDate,Action,Message,Status from Message where RepNo = @REPNO", {
                                            New OleDbParameter("REPNO", RepNo)
                                        })
        grdRepTask.DataSource = DataTable
    End Sub

    Public Sub Clear()
        grdRepTask.DataSource = Nothing
        grdRepTask.Rows.Clear()
    End Sub

End Class
