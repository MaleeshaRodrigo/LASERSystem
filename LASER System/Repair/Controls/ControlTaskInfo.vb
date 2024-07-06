Imports System.Web.Configuration
Imports MySqlConnector

Public Class ControlTaskInfo
    Private DB As Database
    Private FormParent As FormRepair

    Public Sub New(DB As Database, RepairForm As FormRepair)
        InitializeComponent()

        Me.DB = DB
        Me.FormParent = RepairForm
    End Sub

    Public Sub InitForRepair(RepNo As Integer)
        Dim DataTable = DB.GetDataTable("SELECT MsgNo,MsgDate,Action,Message,Status FROM Message WHERE RepNo = @REPNO", {
                                            New MySqlParameter("REPNO", RepNo)
                                        })
        grdRepTask.DataSource = DataTable
    End Sub

    Public Sub InitForReRepair(ReRepNo As Integer)
        Dim DataTable = DB.GetDataTable("SELECT MsgNo,MsgDate,Action,Message,Status FROM Message WHERE RetNo = @REREPNO", {
                                            New MySqlParameter("REREPNO", ReRepNo)
                                        })
        grdRepTask.DataSource = DataTable
    End Sub

    Public Sub Clear()
        grdRepTask.DataSource = Nothing
        grdRepTask.Rows.Clear()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim FormMessage As New FormMessage
        Dim ListTelephoneNos As New List(Of String)
        For Each TextCuTelNo As MaskedTextBox In {FormParent.txtCuTelNo1, FormParent.txtCuTelNo2, FormParent.txtCuTelNo3}
            If TextCuTelNo.Text.Trim() <> "" Then
                ListTelephoneNos.Add(TextCuTelNo.Text)
            End If
        Next
        If FormParent.Mode = RepairMode.Repair Then
            FormMessage.ControlMessageUnit.SetData(RepairMode.Repair, FormParent.cmbRepNo.Text, ListTelephoneNos)
        Else
            FormMessage.ControlMessageUnit.SetData(RepairMode.ReRepair, FormParent.cmbRetNo.Text, ListTelephoneNos)
        End If
        FormMessage.Show(FormParent)
    End Sub
End Class
