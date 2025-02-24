Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlRemarks
    Public Property ControlRemarkOption As ControlRemarksOption

    Private Db As Database
    Private FormParent As FormRepair
    Private GridCellPreviousValue As Object
    Private ReadOnly DtpDate As New DateTimePicker

    Public Sub Init(Db As Database, RepairMode As RepairMode, PrimaryNo As Integer)
        Me.Db = Db
        Dim WhereBlock As String = If(RepairMode.Repair, "RepNo=@PRIMARYNO", "RetNo=@PRIMARYNO")
        Dim Query As String = If(
            ControlRemarkOption = ControlRemarksOption.RemarksByCustomer,
            $"Select Rem1No As 'RemNo', Rem1Date AS 'RemDate', Remarks, UserName FROM RepairRemarks1 RepRem LEFT JOIN `User` U ON U.UNo=RepRem.UNo WHERE {WhereBlock};",
            $"SELECT Rem2No AS 'RemNo', Rem2Date AS 'RemDate', Remarks, UserName FROM RepairRemarks2 RepRem LEFT JOIN `User` U ON U.UNo=RepRem.UNo WHERE {WhereBlock};"
        )
        Dim DataTable As DataTable = Db.GetDataTable(Query, {
                New MySqlParameter("PRIMARYNO", PrimaryNo)
            })
        GridRemarks.DataSource = DataTable
    End Sub

    Private Sub GridRemarks_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GridRemarks.CellBeginEdit
        If e.RowIndex < 0 Then
            Return
        End If

        Dim GridDateCellValue As Date = GridRemarks.Item(GridRemarksColumns.Date, e.RowIndex).Value
        Dim DateValidation As Boolean = IsDate(GridDateCellValue) = False OrElse DateValue(GridDateCellValue).Date <> Today.Date
        Dim UserValidation As Boolean = GridRemarks.Item(GridRemarksColumns.UserName, e.RowIndex).Value <> User.Instance.UserName
        If DateValidation Or UserValidation Then
            e.Cancel = True
            Return
        End If

        If e.ColumnIndex = GridRemarks.Columns(GridRemarksColumns.Date).Index Then
            GridRemarks.Controls.Add(DtpDate)
            DtpDate.Location = GridRemarks.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            DtpDate.Size = New Size(GridRemarks.Columns.Item(e.ColumnIndex).Width, GridRemarks.Rows.Item(e.RowIndex).Height)
            DtpDate.Format = DateTimePickerFormat.Custom
            DtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
            DtpDate.Visible = True
            If GridRemarks.CurrentCell.Value Is Nothing Then
                DtpDate.Value = Date.Now
            Else
                DtpDate.Value = Convert.ToDateTime(GridRemarks.CurrentCell.Value)
            End If
        End If

        GridCellPreviousValue = GridRemarks.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub GridRemarks_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridRemarks.EditingControlShowing
        If GridRemarks.CurrentCell.RowIndex < 0 Then
            Exit Sub
        End If

        If GridRemarks.Focused And GridRemarks.CurrentCell.ColumnIndex = GridRemarks.Columns(GridRemarksColumns.Date).Index Then
            DtpDate.Location = GridRemarks.GetCellDisplayRectangle(GridRemarks.CurrentCell.ColumnIndex, GridRemarks.CurrentCell.RowIndex, True).Location
            DtpDate.Size = New Size(GridRemarks.Columns.Item(GridRemarks.CurrentCell.ColumnIndex).Width, GridRemarks.Rows.Item(GridRemarks.CurrentCell.RowIndex).Height)
        End If
    End Sub

    Private Sub GridRemarks_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridRemarks.CellEndEdit
        If e.RowIndex < 0 Or GridRemarks.Rows(e.RowIndex).IsNewRow Or GridRemarks.Item(GridRemarksColumns.Remarks, e.RowIndex).Value.Equals(GridCellPreviousValue) Then
            Return
        End If

        Dim Remarks As String = GridRemarks.Item(GridRemarksColumns.Remarks, e.RowIndex).Value
        Dim TableName As String
        Dim PrimaryKey As String
        Dim DateColumnName As String
        If ControlRemarkOption = ControlRemarksOption.RemarksByCustomer Then
            TableName = Tables.RepairRemarks1
            PrimaryKey = RepairRemarks1.Rem1No
            DateColumnName = RepairRemarks1.Rem1Date
        Else
            TableName = Tables.RepairRemarks2
            PrimaryKey = RepairRemarks2.Rem2No
            DateColumnName = RepairRemarks2.Rem2Date
        End If

        Select Case e.ColumnIndex
            Case GridRemarks.Columns(GridRemarksColumns.Date).Index
                GridRemarks.CurrentCell.Value = DtpDate.Value.ToString
                DtpDate.Visible = False
            Case GridRemarks.Columns(GridRemarksColumns.Remarks).Index
                If GridRemarks.Item(GridRemarksColumns.Date, e.RowIndex).Value Is Nothing Then
                    GridRemarks.Item(GridRemarksColumns.Date, e.RowIndex).Value = Date.Now
                End If

                If GridRemarks.Item(GridRemarksColumns.UserName, e.RowIndex).Value Is Nothing Then
                    GridRemarks.Item(GridRemarksColumns.UserName, e.RowIndex).Value = User.Instance.UserName
                End If

                If IsNothing(GridRemarks.Item(GridRemarksColumns.Remarks, e.RowIndex).Value) OrElse
                    String.IsNullOrWhiteSpace(GridRemarks.Item(GridRemarksColumns.Remarks, e.RowIndex).Value) Then
                    GridRemarks.Rows.RemoveAt(e.RowIndex)
                    Return
                End If

                If GridRemarks.Item(GridRemarksColumns.No, e.RowIndex).Value Is Nothing Then
                    GridRemarks.Item(GridRemarksColumns.No, e.RowIndex).Value = Db.GetNextKey(TableName, PrimaryKey)
                End If
        End Select

        If Db.CheckDataExists("RepairRemarks1", "Rem1No", GridRemarks.Item(GridRemarksColumns.No, e.RowIndex).Value) = True Then
            Db.Execute($"UPDATE {TableName} SET " & If(FormParent.Mode = RepairMode.Repair, "RepNo=" & FormParent.cmbRepNo.Text, "RetNo=" & FormParent.cmbRetNo.Text) & $", {DateColumnName}=@REMDATE, Remarks=@REMARKS, UNo=@UNO WHERE {PrimaryKey}=@REM1NO;", {
                    New MySqlParameter("REMDATE", GridRemarks.Item(GridRemarksColumns.Date, e.RowIndex).Value),
                    New MySqlParameter("REMARKS", GridRemarks.Item(GridRemarksColumns.Remarks, e.RowIndex).Value),
                    New MySqlParameter("UNO", User.Instance.UserNo),
                    New MySqlParameter("REM1NO", GridRemarks.Item(GridRemarksColumns.No, e.RowIndex).Value)
                })
        Else
            Db.Execute($"INSERT INTO {TableName}({PrimaryKey}," & If(FormParent.Mode = RepairMode.Repair, "RepNo", "RetNo") & $", {DateColumnName}, Remarks, UNo) VALUES(@REMNO," & If(FormParent.Mode = RepairMode.Repair, FormParent.cmbRepNo.Text, FormParent.cmbRetNo.Text) & ", @REMDATE, @REMARKS, @UNO);", {
                    New MySqlParameter("REMNO", GridRemarks.Item(GridRemarksColumns.No, e.RowIndex).Value),
                    New MySqlParameter("REMDATE", GridRemarks.Item(GridRemarksColumns.Date, e.RowIndex).Value),
                    New MySqlParameter("REMARKS", GridRemarks.Item(GridRemarksColumns.Remarks, e.RowIndex).Value),
                    New MySqlParameter("UNO", User.Instance.UserNo)
                })
        End If
    End Sub

    Private Sub GridRemarks_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles GridRemarks.UserDeletingRow
        If e.Row.Index < 0 Or e.Row.Index = (grdRepRemarks1.Rows.Count - 1) Then
            Exit Sub
        End If

        Dim AdminPer As New AdminPermission(Db)
        If Convert.ToDateTime(grdRepRemarks1.Item(1, e.Row.Index).Value).Date <> DateTime.Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "Repair Remarks 1 හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        Db.Execute($"Delete from {Tables.RepairRemarks1} Where Rem1No=@REM1NO", {
                   New MySqlParameter("REM1NO", grdRepRemarks1.Item(0, e.Row.Index).Value)
        }, AdminPer)
    End Sub

    Private Structure GridRemarksColumns
        Public Const No As String = "RemNo"
        Public Const [Date] As String = "RemDate"
        Public Const Remarks As String = "Remarks"
        Public Const UserName As String = "RemUser"
    End Structure
End Class

Public Enum ControlRemarksOption
    RemarksByCustomer
    RemarksByTechnician
End Enum



