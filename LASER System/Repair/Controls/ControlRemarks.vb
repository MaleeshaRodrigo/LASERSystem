Imports System.Data.OleDb
Imports System.IO

Public Class ControlRemarks
    Private DB As Database
    Private ReadOnly DtpDate As New DateTimePicker
    Private FormParent As FormRepair

    Public Sub New(DB As Database, ParentForm As FormRepair)
        InitializeComponent()
        Me.DB = DB
        Me.FormParent = ParentForm
    End Sub

    Public Sub InitForRepair(RepNo As Integer)
        cmbLocation.Text = FormParent.DataReaderRepair("Location").ToString

        'Adding Data to grdRepRemarks1 
        Dim DRREPNO1 As OleDbDataReader = DB.GetDataReader("Select RepRem.*, UserName from RepairRemarks1 RepRem LEFT JOIN [User] U ON U.UNo=RepRem.UNo Where RepNo=@REPNO;", {
                New OleDbParameter("REPNO", RepNo)
            })
        grdRepRemarks1.Rows.Clear()
        While DRREPNO1.Read
            grdRepRemarks1.Rows.Add(DRREPNO1("Rem1No").ToString, DRREPNO1("Rem1Date").ToString, DRREPNO1("Remarks").ToString, DB.GetData("Select UserName from [User] Where UNo=" & DRREPNO1("UNo").ToString))
        End While

        Dim FilePath As String = Path.Combine(SystemFolderPath, $"\LASER System\Images\REP-{RepNo}.png")
        imgRepair.Image = If(File.Exists(FilePath), Image.FromFile(FilePath), Nothing)
    End Sub

    Public Sub InitForReRepair(ReRepNo As Integer)
        cmbLocation.Text = FormParent.DataReaderRepair("Location").ToString

        Dim DRREPNO1 As OleDbDataReader = DB.GetDataReader("SELECT RepRem.*, UserName FROM RepairRemarks1 RepRem LEFT JOIN [User] U ON U.UNo=RepRem.UNo WHERE RetNo=@REREPPNO;", {
                New OleDbParameter("REREPPNO", ReRepNo)
            })
        grdRepRemarks1.Rows.Clear()
        While DRREPNO1.Read
            grdRepRemarks1.Rows.Add(DRREPNO1("Rem1No").ToString, DRREPNO1("Rem1Date").ToString, DRREPNO1("Remarks").ToString, DRREPNO1("UserName").ToString)
            If IsDate(FormParent.DataReaderRepair("DDate")) AndAlso DateValue(FormParent.DataReaderRepair("DDate")).Month <> Today.Month Then
                grdRepRemarks1.Rows.Item(grdRepRemarks1.Rows.Count - 1).ReadOnly = True
            End If
        End While

        Dim FilePath As String = Path.Combine(SystemFolderPath, $"\LASER System\Images\RET-{ReRepNo}.png")
        imgRepair.Image = If(File.Exists(FilePath), Image.FromFile(FilePath), Nothing)
    End Sub

    Public Sub SaveData(RepNo As Integer)
        DB.Execute($"UPDATE Repair SET Location= '{cmbLocation.Text}' WHERE repno ={RepNo}")
        DB.Execute($"INSERT INTO RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) VALUES({DB.GetNextKey("RepairActivity", "RepANo")},{RepNo},#{DateAndTime.Now}#,'Location -> {cmbLocation.Text}',{User.Instance.UserNo})")
    End Sub

    Public Sub Clear()
        grdRepRemarks1.Rows.Clear()
        cmbLocation.Text = ""
        imgRepair.Image = Nothing
        imgRepair.Refresh()
    End Sub

    Private Sub grdRepRemarks1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks1.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = 1 Then
            grdRepRemarks1.Controls.Add(DtpDate)
            DtpDate.Location = grdRepRemarks1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            DtpDate.Size = New Size(grdRepRemarks1.Columns.Item(e.ColumnIndex).Width, grdRepRemarks1.Rows.Item(e.RowIndex).Height)
            DtpDate.Format = DateTimePickerFormat.Custom
            DtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
            DtpDate.Visible = True
            If grdRepRemarks1.CurrentCell.Value Is Nothing Then
                DtpDate.Value = DateTime.Now
            Else
                DtpDate.Value = Convert.ToDateTime(grdRepRemarks1.CurrentCell.Value)
            End If
        End If
        grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Tag = grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdRepRemarks1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepRemarks1.EditingControlShowing
        If grdRepRemarks1.CurrentCell.RowIndex < 0 Then Exit Sub
        If grdRepRemarks1.Focused And grdRepRemarks1.CurrentCell.ColumnIndex = 1 Then
            DtpDate.Location = grdRepRemarks1.GetCellDisplayRectangle(grdRepRemarks1.CurrentCell.ColumnIndex, grdRepRemarks1.CurrentCell.RowIndex, True).Location
            DtpDate.Size = New Size(grdRepRemarks1.Columns.Item(grdRepRemarks1.CurrentCell.ColumnIndex).Width, grdRepRemarks1.Rows.Item(grdRepRemarks1.CurrentCell.RowIndex).Height)
        End If
    End Sub

    Private Sub grdRepRemarks1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepRemarks1.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Dim AdminPer As New AdminPermission(DB)
        If e.ColumnIndex = 1 Then
            grdRepRemarks1.CurrentCell.Value = DtpDate.Value.ToString
            DtpDate.Visible = False
            If grdRepRemarks1.Item(1, e.RowIndex).Tag IsNot Nothing AndAlso
                Convert.ToDateTime(grdRepRemarks1.Item(1, e.RowIndex).Tag).Date <> DateTime.Today.Date Then
                AdminPer.AdminSend = True
                AdminPer.Remarks = "Repair Remarks 1 හිදි අද දිනට නොමැති Remarks එකක දිනයක් වෙනස් කෙරුණි."
            End If
        ElseIf e.ColumnIndex = 2 And e.RowIndex <> (grdRepRemarks1.Rows.Count - 1) Then
            If (grdRepRemarks1.Item(1, e.RowIndex).Value IsNot Nothing AndAlso
                grdRepRemarks1.Item(1, e.RowIndex).Value.ToString <> "" AndAlso
                DateAndTime.DateValue(grdRepRemarks1.Item(1, e.RowIndex).Value) <> DateTime.Today.Date) Then
                AdminPer.AdminSend = True
                AdminPer.Remarks = "Repair Remarks 1 හිදි අද දිනට නොමැති Remarks එකක් වෙනස් කෙරුණි."
            End If
            If grdRepRemarks1.Item(1, e.RowIndex).Value Is Nothing Or
                grdRepRemarks1.Item(2, e.RowIndex).Value <> grdRepRemarks1.Item(2, e.RowIndex).Tag Then grdRepRemarks1.Item(1, e.RowIndex).Value = DateTime.Now
            If grdRepRemarks1.Item(3, e.RowIndex).Value Is Nothing Or
                    grdRepRemarks1.Item(2, e.RowIndex).Value <> grdRepRemarks1.Item(2, e.RowIndex).Tag Then grdRepRemarks1.Item(3, e.RowIndex).Value =
                    User.Instance.UserName
            If grdRepRemarks1.Item(2, e.RowIndex).Value Is Nothing Then
                grdRepRemarks1.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            ElseIf grdRepRemarks1.Item(2, e.RowIndex).Value.ToString.Replace(" ", "") = "" Then
                grdRepRemarks1.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            Else
                If grdRepRemarks1.Item(0, e.RowIndex).Value Is Nothing Then grdRepRemarks1.Item(0, e.RowIndex).Value =
                    DB.GetNextKey("RepairRemarks1", "Rem1No")
            End If
        End If
        If e.RowIndex <> (grdRepRemarks1.Rows.Count - 1) And
            grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Tag <> grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Value Then
            If DB.CheckDataExists("RepairRemarks1", "Rem1No", grdRepRemarks1.Item(0, e.RowIndex).Value) = True Then
                DB.Execute("Update RepairRemarks1 set " &
                          If(FormParent.Mode = RepairMode.Repair, "RepNo=" & FormParent.cmbRepNo.Text, "RetNo=" & FormParent.cmbRetNo.Text) &
                          ",Rem1Date=#" & grdRepRemarks1.Item(1, e.RowIndex).Value &
                          "#,Remarks='" & grdRepRemarks1.Item(2, e.RowIndex).Value &
                          "',UNo=" & DB.GetData("Select UNo from [User] Where UserName='" &
                          grdRepRemarks1.Item(3, e.RowIndex).Value & "'") &
                          " Where Rem1No=" & grdRepRemarks1.Item(0, e.RowIndex).Value, {}, AdminPer)
            Else
                DB.Execute("Insert into RepairRemarks1(Rem1No," & If(FormParent.Mode = RepairMode.Repair, "RepNo", "RetNo") &
                          ", Rem1Date, Remarks, UNo) Values(" & grdRepRemarks1.Item(0, e.RowIndex).Value & "," &
                          If(FormParent.Mode = RepairMode.Repair, FormParent.cmbRepNo.Text, FormParent.cmbRetNo.Text) & ",#" & grdRepRemarks1.Item(1, e.RowIndex).Value &
                          "#,'" & grdRepRemarks1.Item(2, e.RowIndex).Value & "'," &
                          DB.GetData("Select UNo from [User] Where UserName='" & grdRepRemarks1.Item(3, e.RowIndex).Value & "'") &
                          ")", {}, AdminPer)
            End If
        End If
        If AdminPer.AdminSend = True Then
            Dim E1 As New DataGridViewCellCancelEventArgs(e.ColumnIndex, e.RowIndex)
            grdRepRemarks1_RowValidating(sender, E1)
        End If
    End Sub

    Private Sub grdRepRemarks1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdRepRemarks1.UserDeletingRow
        If e.Row.Index < 0 Or e.Row.Index = (grdRepRemarks1.Rows.Count - 1) Then Exit Sub
        Dim AdminPer As New AdminPermission(DB)
        If Convert.ToDateTime(grdRepRemarks1.Item(1, e.Row.Index).Value).Date <> DateTime.Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "Repair Remarks 1 හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        DB.Execute("Delete from RepairRemarks1 Where Rem1No=@REM1NO", {
                   New OleDbParameter("REM1NO", grdRepRemarks1.Item(0, e.Row.Index).Value)
        }, AdminPer)
    End Sub

    Private Sub grdRepRemarks1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks1.RowValidating
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If grdRepRemarks1.Item(0, e.RowIndex).Value Is Nothing Then
            Exit Sub
        End If
        Dim DR1 As OleDbDataReader = DB.GetDataReader($"SELECT Rem1No,Rem1Date,Remarks,UserName from RepairRemarks1 RepRem1 LEFT JOIN [User] U ON U.UNo=RepRem1.UNo where Rem1No={grdRepRemarks1.Item(0, e.RowIndex).Value};")
        If DR1.HasRows Then
            DR1.Read()
            grdRepRemarks1.Item(1, e.RowIndex).Value = DR1("Rem1Date").ToString
            grdRepRemarks1.Item(2, e.RowIndex).Value = DR1("Remarks").ToString
            grdRepRemarks1.Item(3, e.RowIndex).Value = DR1("UserName").ToString
        Else
            grdRepRemarks1.Rows.RemoveAt(e.RowIndex)
        End If
        DR1.Close()
    End Sub

    Private Sub cmbLocation_DropDown(sender As Object, e As EventArgs) Handles cmbLocation.DropDown
        ComboBoxDropDown(DB, cmbLocation, "Select Location from Repair Group by Location;")
    End Sub
End Class
