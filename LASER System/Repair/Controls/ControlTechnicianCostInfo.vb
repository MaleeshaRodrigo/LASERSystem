Imports MySqlConnector

Public Class ControlTechnicianCostInfo
    Private Db As Database
    Private ReadOnly DtpDate As New DateTimePicker
    Private ParentRepairForm As FormRepair
    Public Sub New(Db As Database, ParentForm As FormRepair)
        InitializeComponent()

        Me.Db = Db
        Me.ParentRepairForm = ParentForm
    End Sub

    Public Sub InitForRepair(RepNo As Integer)
        Dim DataTable = Db.GetDataTable("SELECT TCNo,TCDate,TC.SNo,S.SCategory,S.SName,Rate,Qty,Total,TCRemarks,UserName FROM (Stock S INNER JOIN TechnicianCost TC ON TC.SNo = S.SNo) LEFT JOIN `User` U ON U.UNo = TC.UNo WHERE RepNo=@REPNO;", {
            New MySqlParameter("REPNO", RepNo)
                                        })
        grdTechnicianCost.DataSource = DataTable
    End Sub

    Public Sub InitForReRepair(ReRepNo As Integer)
        Dim DataTable = Db.GetDataTable("SELECT TCNo,TCDate,TC.SNo,S.SCategory,S.SName,Rate,Qty,Total,TCRemarks,UserName FROM (Stock S INNER JOIN TechnicianCost TC ON TC.SNo = S.SNo) LEFT JOIN `User` U ON U.UNo = TC.UNo WHERE RetNo=@REREPNO;", {
            New MySqlParameter("REREPNO", ReRepNo)
                                        })
        grdTechnicianCost.DataSource = DataTable
    End Sub

    Public Sub Clear()
        grdTechnicianCost.DataSource = Nothing
        grdTechnicianCost.Rows.Clear()
    End Sub

    Private Sub grdTechnicianCost_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        If CheckEmptyControl(ParentRepairForm.ControlTechnicianInfo.cmbTName, "Technician Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.") = False Then
            If (grdTechnicianCost.Rows.Count - 1) <> e.RowIndex Then
                grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
            End If
            Exit Sub
        ElseIf CheckEmptyControl(ParentRepairForm.cmbRepNo, "Repair No යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.") = False Then
            If (grdTechnicianCost.Rows.Count - 1) <> e.RowIndex Then
                grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
            End If
            Exit Sub
        End If
        Dim AdminPer As New AdminPermission(Db)
        Select Case e.ColumnIndex
            Case 1
                grdTechnicianCost.CurrentCell.Value = DtpDate.Value.ToString
                DtpDate.Visible = False
                If grdTechnicianCost.Item(1, e.RowIndex).Tag IsNot Nothing AndAlso
                    Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Tag).Date <> DateTime.Today.Date Then
                    AdminPer.AdminSend = True
                    AdminPer.Remarks = "Repair හි Technician Cost හිදි අද දිනට නොමැති Technician Cost Data එකක දිනයක් වෙනස් කෙරුණි."
                End If
            Case 2
                If grdTechnicianCost.Item(2, e.RowIndex).Value Is Nothing Then Exit Sub
                Dim DrStock = Db.GetDataDictionary("Select SNo,SCategory,SName,SCostPrice from Stock Where SNo=" & grdTechnicianCost.Item(2, e.RowIndex).Value.ToString)
                If DrStock IsNot Nothing Then
                    grdTechnicianCost.Item(3, e.RowIndex).Value = DrStock("SCategory").ToString
                    grdTechnicianCost.Item(4, e.RowIndex).Value = DrStock("SName").ToString
                    grdTechnicianCost.Item(5, e.RowIndex).Value = DrStock("SCostPrice").ToString
                    grdTechnicianCost.Item(6, e.RowIndex).Value = "1"
                    Dim E1 As New DataGridViewCellEventArgs(5, e.RowIndex)
                    grdTechnicianCost_CellEndEdit(sender, E1)
                End If
            Case 3, 4
                frmSearchDropDown.frm_Close()
                DR = Db.GetDataDictionary("Select SNo,SCategory,SName,SCostPrice from Stock Where SCategory='" & grdTechnicianCost.Item(3, e.RowIndex).Value &
                                       "' and SName='" & grdTechnicianCost.Item(4, e.RowIndex).Value & "';")
                If DR IsNot Nothing Then

                    grdTechnicianCost.Item(2, e.RowIndex).Value = DR("SNo").ToString
                    grdTechnicianCost.Item(3, e.RowIndex).Value = DR("SCategory").ToString
                    grdTechnicianCost.Item(4, e.RowIndex).Value = DR("SName").ToString
                    grdTechnicianCost.Item(5, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdTechnicianCost.Item(6, e.RowIndex).Value = "1"
                    Dim E1 As New DataGridViewCellEventArgs(5, e.RowIndex)
                    grdTechnicianCost_CellEndEdit(sender, E1)
                Else
                    grdTechnicianCost.Item(2, e.RowIndex).Value = ""
                End If
            Case 6, 5
                If grdTechnicianCost.Item(5, e.RowIndex).Value IsNot Nothing And grdTechnicianCost.Item(6, e.RowIndex).Value IsNot Nothing Then
                    grdTechnicianCost.Item(7, e.RowIndex).Value = grdTechnicianCost.Item(5, e.RowIndex).Value * grdTechnicianCost.Item(6, e.RowIndex).Value
                End If
        End Select
        If User.Instance.UserType <> User.Type.Admin And (grdTechnicianCost.Item(1, e.RowIndex).Value IsNot Nothing AndAlso
           Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Value).Date <> DateTime.Today.Date) Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "Repair හි Technician Cost හිදි අද දිනට නොමැති Technician Cost එකක් වෙනස් කෙරුණි."
        End If
        If e.RowIndex = (grdTechnicianCost.Rows.Count - 1) Then Exit Sub
        If grdTechnicianCost.Item(1, e.RowIndex).Value Is Nothing Then grdTechnicianCost.Item(1, e.RowIndex).Value = DateAndTime.Now
        If grdTechnicianCost.Item(9, e.RowIndex).Value Is Nothing Or
            grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value <> grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag Then grdTechnicianCost.Item(9, e.RowIndex).Value = User.Instance.UserName
        If grdTechnicianCost.Item(0, e.RowIndex).Value Is Nothing Then
            grdTechnicianCost.Item(0, e.RowIndex).Value = Db.GetNextKey("TechnicianCost", "TCNo")
            Db.Execute("Insert into TechnicianCost(TCNo) Values(" & grdTechnicianCost.Item(0, e.RowIndex).Value & ")",
                      {}, AdminPer)
        End If
        If Db.CheckDataExists("TechnicianCost", "TCNo", grdTechnicianCost.Item(0, e.RowIndex).Value) = True Then
            Db.Execute("Update TechnicianCost set TCDate='" & grdTechnicianCost.Item("TCDate", e.RowIndex).Value &
                      "',TNo" = Db.GetData($"SELECT TNo from Technician WHERE TName='{ParentRepairForm.ControlTechnicianInfo.cmbTName.Text}'") &
                      ",SNo=" & grdTechnicianCost.Item("SNo", e.RowIndex).Value &
                      ",SCategory='" & grdTechnicianCost.Item("SCategory", e.RowIndex).Value &
                      "',SName='" & grdTechnicianCost.Item("SName", e.RowIndex).Value &
                      "',Rate=" & grdTechnicianCost.Item("Rate", e.RowIndex).Value &
                      ",Qty=" & grdTechnicianCost.Item("Qty", e.RowIndex).Value &
                      ",Total=" & grdTechnicianCost.Item("Total", e.RowIndex).Value &
                      ",TCRemarks='" & grdTechnicianCost.Item("TCRemarks", e.RowIndex).Value &
                      "',UNo=" & Db.GetData("Select UNo from `User` Where UserName='" &
                      grdTechnicianCost.Item("UNo", e.RowIndex).Value & "'") &
                      " Where TCNo=" & grdTechnicianCost.Item("TCNo", e.RowIndex).Value, {}, AdminPer)
        End If
        If AdminPer.AdminSend = True Then
            Dim E1 As New DataGridViewCellCancelEventArgs(e.ColumnIndex, e.RowIndex)
            grdTechnicianCost_RowValidating(sender, E1)
        End If
    End Sub

    Private Sub grdTechnicianCost_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 1
                grdTechnicianCost.Controls.Add(DtpDate)
                DtpDate.Location = grdTechnicianCost.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                DtpDate.Size = New Size(grdTechnicianCost.Columns.Item(e.ColumnIndex).Width, grdTechnicianCost.Rows.Item(e.RowIndex).Height)
                DtpDate.Format = DateTimePickerFormat.Custom
                DtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
                DtpDate.Visible = True
                If grdTechnicianCost.CurrentCell.Value Is Nothing Then
                    DtpDate.Value = DateAndTime.Now
                Else
                    DtpDate.Value = Convert.ToDateTime(grdTechnicianCost.CurrentCell.Value)
                End If
                DtpDate.Focus()
        End Select
        grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdTechnicianCost_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If grdTechnicianCost.CurrentCell.RowIndex < 0 Then Exit Sub
        Select Case grdTechnicianCost.CurrentCell.ColumnIndex
            Case 1
                DtpDate.Location = grdTechnicianCost.GetCellDisplayRectangle(grdTechnicianCost.CurrentCell.ColumnIndex, grdTechnicianCost.CurrentCell.RowIndex, True).Location
                DtpDate.Size = New Size(grdTechnicianCost.Columns.Item(grdTechnicianCost.CurrentCell.ColumnIndex).Width, grdTechnicianCost.Rows.Item(grdTechnicianCost.CurrentCell.RowIndex).Height)
            Case 3
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, grdTechnicianCost, ParentRepairForm, "Select SCategory from Stock group by SCategory;", "SCategory")
            Case 4
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, grdTechnicianCost, ParentRepairForm, "Select SCategory,SName from Stock where SCategory ='" &
                                                   grdTechnicianCost.Item(3, grdTechnicianCost.CurrentCell.RowIndex).Value & "';", "SName")
        End Select
    End Sub

    Private Sub grdTechnicianCost_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs)
        If e.Row.Index < 0 Or e.Row.Index = (grdTechnicianCost.Rows.Count - 1) Then Exit Sub
        Dim AdminPer As New AdminPermission(Db)
        If Convert.ToDateTime(grdTechnicianCost.Item(1, e.Row.Index).Value).Date <>
            DateTime.Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "Repair හි Technician Cost හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        Db.Execute("Delete from TechnicianCost Where TCNo=" & grdTechnicianCost.Item(0, e.Row.Index).Value, {}, AdminPer)
    End Sub

    Private Sub grdTechnicianCost_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        If grdTechnicianCost.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
        Dim DR1 = Db.GetDataDictionary("SELECT * from TechnicianCost where TCNo=" & grdTechnicianCost.Item(0, e.RowIndex).Value & ";")
        If DR1 IsNot Nothing Then
            grdTechnicianCost.Item(1, e.RowIndex).Value = DR1("TCDate").ToString
            grdTechnicianCost.Item(2, e.RowIndex).Value = DR1("SNo").ToString
            grdTechnicianCost.Item(3, e.RowIndex).Value = DR1("SCategory").ToString
            grdTechnicianCost.Item(4, e.RowIndex).Value = DR1("SName").ToString
            grdTechnicianCost.Item(5, e.RowIndex).Value = DR1("Rate").ToString
            grdTechnicianCost.Item(6, e.RowIndex).Value = DR1("Qty").ToString
            grdTechnicianCost.Item(7, e.RowIndex).Value = DR1("Total").ToString
            grdTechnicianCost.Item(8, e.RowIndex).Value = DR1("TCRemarks").ToString
            grdTechnicianCost.Item(9, e.RowIndex).Value = If(DR1("UNo").ToString <> "",
                Db.GetData("Select UserName from \`User\` where Uno=" & DR1("UNo").ToString), "")
        Else
            grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class
