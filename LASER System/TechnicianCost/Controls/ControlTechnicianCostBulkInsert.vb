Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlTechnicianCostBulkInsert
    Private Db As Database
    Private ReadOnly DatePicker As New DateTimePicker

    Public Sub Init(Db As Database)
        Me.Db = Db
    End Sub

    Private Sub GridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GridView.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 0
                GridView.Controls.Add(DatePicker)
                DatePicker.Location = GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                DatePicker.Size = New Size(GridView.Columns.Item(e.ColumnIndex).Width, GridView.Rows.Item(e.RowIndex).Height)
                DatePicker.Format = DateTimePickerFormat.Custom
                DatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
                DatePicker.Visible = True
                If GridView.CurrentCell.Value Is Nothing Then
                    DatePicker.Value = Now
                Else
                    DatePicker.Value = Convert.ToDateTime(GridView.CurrentCell.Value)
                End If
        End Select
        GridView.Item(e.ColumnIndex, e.RowIndex).Tag = GridView.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub GridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridView.EditingControlShowing
        If GridView.CurrentCell.RowIndex < 0 Then Exit Sub
        Select Case GridView.CurrentCell.ColumnIndex
            Case 0
                DatePicker.Location = GridView.GetCellDisplayRectangle(
                    GridView.CurrentCell.ColumnIndex,
                    GridView.CurrentCell.RowIndex,
                    True
                ).Location
                DatePicker.Size = New Size(GridView.Columns.Item(GridView.CurrentCell.ColumnIndex).Width,
                                        GridView.Rows.Item(GridView.CurrentCell.RowIndex).Height)
            Case 2
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, GridView, Me.ParentForm, "Select SCategory from Stock group by SCategory;", "SCategory")
            Case 3
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, GridView, Me.ParentForm, "Select SCategory,SName from Stock where SCategory='" &
                GridView.Item(2, GridView.CurrentCell.RowIndex).Value & "';", "SName")
        End Select
    End Sub

    'Private Sub GridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GridView.RowValidating
    '    If e.RowIndex < 0 Or e.RowIndex > (GridView.Rows.Count - 2) Then Exit Sub
    '    Dim DRTC = Db.GetDataDictionary("Select TC.*,UserName from TechnicianCost TC Left Join `User` U On U.Uno = TC.UNo Where TCNo=" & GridView.Item(0, e.RowIndex).Value)
    '    If DRTC IsNot Nothing Then
    '        GridView.Item(1, e.RowIndex).Value = DRTC("TCDate").ToString
    '        GridView.Item(2, e.RowIndex).Value = DRTC("SNo").ToString
    '        GridView.Item(3, e.RowIndex).Value = DRTC("SCategory").ToString
    '        GridView.Item(4, e.RowIndex).Value = DRTC("SName").ToString
    '        GridView.Item(5, e.RowIndex).Value = DRTC("Rate").ToString
    '        GridView.Item(6, e.RowIndex).Value = DRTC("Qty").ToString
    '        GridView.Item(7, e.RowIndex).Value = DRTC("Total").ToString
    '        GridView.Item(8, e.RowIndex).Value = DRTC("TCRemarks").ToString
    '        GridView.Item(9, e.RowIndex).Value = DRTC("RepNo").ToString
    '        GridView.Item(10, e.RowIndex).Value = DRTC("RetNo").ToString
    '        GridView.Item(11, e.RowIndex).Value = DRTC("UserName").ToString
    '    End If
    'End Sub

    Private Sub GridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellEndEdit
        If GridView.CurrentCell.RowIndex < 0 Then
            Exit Sub
        End If
        Dim CurrentRowIndex As Integer = GridView.CurrentCell.RowIndex
        If GridView.Item(0, CurrentRowIndex).Value Is Nothing Then
            GridView.Item(0, CurrentRowIndex).Value = Now
        End If
        Select Case e.ColumnIndex
            Case 0
                GridView.CurrentCell.Value = DatePicker.Value.ToString
                DatePicker.Visible = False
            Case 1
                Dim Result = Db.GetDataDictionary("SELECT SCategory, SName, SLowestPrice FROM Stock WHERE SNo = @SNO;", {
                    New MySqlParameter("SNO", GridView.Item(1, CurrentRowIndex).Value)
                })
                If Result Is Nothing Then
                    Return
                End If
                GridView.Item(2, CurrentRowIndex).Value = Result(Stock.Category)
                GridView.Item(3, CurrentRowIndex).Value = Result(Stock.Name)
                GridView.Item(5, CurrentRowIndex).Value = Result(Stock.LowestPrice)
                Dim EventArg As New DataGridViewCellEventArgs(5, CurrentRowIndex)
                GridView_CellEndEdit(sender, EventArg)
            Case 2, 3
                frmSearchDropDown.frm_Close()
                Dim Result = Db.GetDataDictionary("SELECT SNo, SLowestPrice FROM Stock WHERE SCategory = @SCATEGORY AND SName = @SNAME;", {
                    New MySqlParameter("SCATEGORY", GridView.Item(2, CurrentRowIndex).Value),
                    New MySqlParameter("SNAME", GridView.Item(3, CurrentRowIndex).Value)
                })
                If Result Is Nothing Then
                    Return
                End If

                GridView.Item(1, CurrentRowIndex).Value = Result(Stock.Code)
                GridView.Item(5, CurrentRowIndex).Value = Result(Stock.LowestPrice)
                Dim EventArg As New DataGridViewCellEventArgs(5, CurrentRowIndex)
                GridView_CellEndEdit(sender, EventArg)
            Case 5, 6
                If GridView.Item(6, CurrentRowIndex).Value Is Nothing Then
                    GridView.Item(6, CurrentRowIndex).Value = 1
                End If
                If IsNumeric(GridView.Item(5, CurrentRowIndex).Value) = False Or IsNumeric(GridView.Item(6, CurrentRowIndex).Value) = False Then
                    Return
                End If

                GridView.Item(7, CurrentRowIndex).Value = Double.Parse(GridView.Item(5, CurrentRowIndex).Value) * Double.Parse(GridView.Item(6, CurrentRowIndex).Value)
        End Select
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        For Each Row As DataGridViewRow In GridView.Rows
            If Row.Cells(TechnicianCostGridColumns.Date).Value Is Nothing And Row.Cells(TechnicianCostGridColumns.Remarks) Is Nothing Then
                Return
            End If
            If Row.Cells(0).Value Is Nothing Then
                Row.Cells(0).Value = Now
            End If
        Next


    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dispose()
    End Sub
End Class
