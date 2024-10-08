﻿Imports MySqlConnector

Public Class ControlTechnicianInfo
    Private DB As Database
    Private ReadOnly DtpDate As New DateTimePicker
    Private FormParent As FormRepair

    Public Sub New(DB As Database, ParentForm As FormRepair)
        InitializeComponent()

        Me.DB = DB
        FormParent = ParentForm
    End Sub

    Public Sub Init()
        cmbTName.Text = FormParent.DataReaderRepair("TName").ToString()
        Dim DataReader As List(Of Dictionary(Of String, Object))
        If FormParent.Mode = RepairMode.Repair Then
            DataReader = DB.GetDataList("Select Rem2No, Rem2Date, Remarks, UserName from RepairRemarks2 RepRem2 LEFT JOIN `User` U ON U.UNo=RepRem2.UNo Where RepNo=@REPNO;", {New MySqlParameter("REPNO", FormParent.DataReaderRepair("RepNo").ToString())})
        Else
            DataReader = DB.GetDataList("Select Rem2No, Rem2Date, Remarks, UserName from RepairRemarks2 RepRem2 LEFT JOIN `User` U ON U.UNo=RepRem2.UNo Where RetNo=@REREPNO;", {
                                        New MySqlParameter("REREPNO", FormParent.DataReaderRepair("RetNo").ToString())
                                    })
        End If
        grdRepRemarks2.Rows.Clear()
        For Each Item In DataReader
            grdRepRemarks2.Rows.Add(Item("Rem2No").ToString, Item("Rem2Date").ToString, Item("Remarks").ToString, Item("UserName").ToString)
        Next

        Call CmbTName_DropDown(Nothing, Nothing)
    End Sub

    Public Sub Clear()
        grdRepRemarks2.DataSource = Nothing
        grdRepRemarks2.Rows.Clear()
    End Sub

    Private Sub CmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call ComboBoxDropDown(DB, cmbTName, "Select TName from Technician Where TActive = True group by TName;")
    End Sub

    Private Sub grdRepRemarks2_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks2.CellBeginEdit
        If grdRepRemarks2.Focused And e.ColumnIndex = 1 And e.RowIndex > -1 Then
            grdRepRemarks2.Controls.Add(DtpDate)
            DtpDate.Location = grdRepRemarks2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            DtpDate.Size = New Size(grdRepRemarks2.Columns.Item(e.ColumnIndex).Width, grdRepRemarks2.Rows.Item(e.RowIndex).Height)
            DtpDate.Format = DateTimePickerFormat.Custom
            DtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
            DtpDate.Visible = True
            If grdRepRemarks2.CurrentCell.Value IsNot Nothing Then
                DtpDate.Value = Convert.ToDateTime(grdRepRemarks2.CurrentCell.Value)
            Else
                DtpDate.Value = Now
            End If
        End If
        grdRepRemarks2.Item(e.ColumnIndex, e.RowIndex).Tag = grdRepRemarks2.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdRepRemarks2_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepRemarks2.EditingControlShowing
        If grdRepRemarks2.CurrentCell.RowIndex < 0 Then Exit Sub
        If grdRepRemarks2.Focused And grdRepRemarks2.CurrentCell.ColumnIndex = 1 Then
            DtpDate.Location = grdRepRemarks2.GetCellDisplayRectangle(grdRepRemarks2.CurrentCell.ColumnIndex, grdRepRemarks2.CurrentCell.RowIndex, True).Location
            DtpDate.Size = New Size(grdRepRemarks2.Columns.Item(grdRepRemarks2.CurrentCell.ColumnIndex).Width, grdRepRemarks2.Rows.Item(grdRepRemarks2.CurrentCell.RowIndex).Height)
        End If
    End Sub

    Private Sub grdRepRemarks2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepRemarks2.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Dim AdminPer As New AdminPermission(DB)
        If grdRepRemarks2.Focused And e.ColumnIndex = 1 Then
            grdRepRemarks2.CurrentCell.Value = DtpDate.Value.ToString
            DtpDate.Visible = False
            If grdRepRemarks2.Item(1, e.RowIndex).Tag IsNot Nothing AndAlso
                Convert.ToDateTime(grdRepRemarks2.Item(1, e.RowIndex).Tag).Date <> Today.Date Then
                AdminPer.AdminSend = True
                AdminPer.Remarks = "Repair Remarks 2 හිදි අද දිනට නොමැති Remarks එකක දිනයක් වෙනස් කෙරුණි."
            End If
        ElseIf e.ColumnIndex = 2 And e.RowIndex <> (grdRepRemarks2.Rows.Count - 1) Then
            If (Not String.IsNullOrEmpty(grdRepRemarks2.Item(1, e.RowIndex).Value)) AndAlso
           Convert.ToDateTime(grdRepRemarks2.Item(1, e.RowIndex).Value).Date <> Today.Date Then
                AdminPer.AdminSend = True
                AdminPer.Remarks = "Repair Remarks 2 හිදි අද දිනට නොමැති Remarks එකක් වෙනස් කෙරුණි."
            End If
            If grdRepRemarks2.Item(1, e.RowIndex).Value Is Nothing Or
                grdRepRemarks2.Item(2, e.RowIndex).Value <> grdRepRemarks2.Item(2, e.RowIndex).Tag Then grdRepRemarks2.Item(1, e.RowIndex).Value = Now
            If grdRepRemarks2.Item(3, e.RowIndex).Value Is Nothing Or
                grdRepRemarks2.Item(2, e.RowIndex).Value <> grdRepRemarks2.Item(2, e.RowIndex).Tag Then grdRepRemarks2.Item(3, e.RowIndex).Value = User.Instance.UserName
            If grdRepRemarks2.Item(2, e.RowIndex).Value Is Nothing Then
                grdRepRemarks2.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            ElseIf grdRepRemarks2.Item(2, e.RowIndex).Value.ToString.Replace(" ", "") = "" Then
                grdRepRemarks2.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            Else
                If grdRepRemarks2.Item(0, e.RowIndex).Value Is Nothing Then
                    grdRepRemarks2.Item(0, e.RowIndex).Value = DB.GetNextKey("RepairRemarks2", "Rem2No")
                    For Each row As DataGridViewRow In grdRepRemarks2.Rows
                        If row.Index = e.RowIndex Or row.Index = (grdRepRemarks2.Rows.Count - 1) Then Continue For
                        If row.Cells(0).Value >= grdRepRemarks2.Item(0, e.RowIndex).Value Then
                            grdRepRemarks2.Item(0, e.RowIndex).Value = row.Cells(0).Value + 1
                        End If
                    Next
                End If
            End If
        End If
        If e.RowIndex <> (grdRepRemarks2.Rows.Count - 1) Then
            If DB.CheckDataExists("RepairRemarks2", "Rem2No", grdRepRemarks2.Item(0, e.RowIndex).Value) = True Then
                DB.Execute($"Update RepairRemarks2 set RepNo=@REPNO, RetNo=@RETNO, Rem2Date=@DATE, Remarks =@REMARKS,UNo=@UNO Where Rem2No=@NO;", {
                    New MySqlParameter("REPNO", If(FormParent.Mode = RepairMode.Repair, FormParent.cmbRepNo.Text, Nothing)),
                    New MySqlParameter("RETNO", If(FormParent.Mode = RepairMode.ReRepair, FormParent.cmbRetNo.Text, Nothing)),
                    New MySqlParameter("DATE", Convert.ToDateTime(grdRepRemarks2.Item(1, e.RowIndex).Value)),
                    New MySqlParameter("REMARKS", grdRepRemarks2.Item(2, e.RowIndex).Value),
                    New MySqlParameter("UNO", User.Instance.UserNo),
                    New MySqlParameter("NO", grdRepRemarks2.Item(0, e.RowIndex).Value)
                }, AdminPer)
            Else
                DB.Execute("Insert into RepairRemarks2(RepNo, RetNo, Rem2Date, Remarks, UNo) Values(@REPNO, @RETNO, @DATE, @REMARKS, @UNO);", {
                    New MySqlParameter("REPNO", If(FormParent.Mode = RepairMode.Repair, FormParent.cmbRepNo.Text, Nothing)),
                    New MySqlParameter("RETNO", If(FormParent.Mode = RepairMode.ReRepair, FormParent.cmbRetNo.Text, Nothing)),
                    New MySqlParameter("DATE", Convert.ToDateTime(grdRepRemarks2.Item(1, e.RowIndex).Value)),
                    New MySqlParameter("REMARKS", grdRepRemarks2.Item(2, e.RowIndex).Value),
                    New MySqlParameter("UNO", User.Instance.UserNo)
                }, AdminPer)
            End If
        End If
        If AdminPer.AdminSend = True Then
            Dim E1 As New DataGridViewCellCancelEventArgs(e.ColumnIndex, e.RowIndex)
            grdRepRemarks2_RowValidating(sender, E1)
        End If
    End Sub

    Private Sub grdRepRemarks2_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdRepRemarks2.UserDeletingRow
        If e.Row.Index < 0 Or e.Row.Index = (grdRepRemarks2.Rows.Count - 1) Then Exit Sub
        Dim AdminPer As New AdminPermission(DB)
        If Convert.ToDateTime(grdRepRemarks2.Item(1, e.Row.Index).Value).Date <> DateTime.Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "Repair Remarks 2 හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        DB.Execute("Delete from RepairRemarks2 Where Rem2No=" & grdRepRemarks2.Item(0, e.Row.Index).Value, {}, AdminPer)
    End Sub

    Private Sub grdRepRemarks2_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks2.RowValidating
        If e.RowIndex < 0 Then Exit Sub
        If grdRepRemarks2.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
        Dim DR1 = DB.GetDataDictionary("SELECT Rem2No,Rem2Date,Remarks,UNo from RepairRemarks2 where Rem2No=" & grdRepRemarks2.Item(0, e.RowIndex).Value & ";")
        If DR1 IsNot Nothing Then
            grdRepRemarks2.Item(1, e.RowIndex).Value = DR1("Rem2Date").ToString
            grdRepRemarks2.Item(2, e.RowIndex).Value = DR1("Remarks").ToString
            grdRepRemarks2.Item(3, e.RowIndex).Value = If(DR1("UNo").ToString <> "",
                DB.GetData("Select UserName from `User` where Uno=" & DR1("UNo").ToString), "")
        Else
            grdRepRemarks2.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class
