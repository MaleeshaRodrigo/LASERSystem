Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlTechnicianCostBulkInsert
    Public Event SubmitEvent()

    Private Db As Database
    Private ReadOnly DatePicker As New DateTimePicker

    Public Function Init(Db As Database) As ControlTechnicianCostBulkInsert
        Me.Db = Db
        ControlTechnician.SetDatabase(Db)
        Return Me
    End Function

    Public Function SetTechnician(Technician As String) As ControlTechnicianCostBulkInsert
        ControlTechnician.SetTechnician(Technician)
        Return Me
    End Function

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

    Private Sub GridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellEndEdit
        If GridView.CurrentRow.IsNewRow Then
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
        Try
            If ButtonSaveValidationAndAssignDefaultValues() = False Then
                Return
            End If

            Dim Values As New List(Of MySqlParameter())
            For Each Row As DataGridViewRow In GridView.Rows
                If Row.IsNewRow Then
                    Continue For
                End If

                Values.Add({
                    New MySqlParameter("TCDATE", Row.Cells(TechnicianCostGridColumns.Date).Value),
                    New MySqlParameter("TNO", ControlTechnician.GetTechnicianNo),
                    New MySqlParameter("REPNO", Row.Cells(TechnicianCostGridColumns.RepairNo).Value),
                    New MySqlParameter("RETNO", Row.Cells(TechnicianCostGridColumns.ReRepairNo).Value),
                    New MySqlParameter("SNO", Row.Cells(TechnicianCostGridColumns.StockNo).Value),
                    New MySqlParameter("SCATEGORY", Row.Cells(TechnicianCostGridColumns.StockCategory).Value),
                    New MySqlParameter("SNAME", Row.Cells(TechnicianCostGridColumns.StockName).Value),
                    New MySqlParameter("RATE", Row.Cells(TechnicianCostGridColumns.Rate).Value),
                    New MySqlParameter("QTY", Row.Cells(TechnicianCostGridColumns.Qty).Value),
                    New MySqlParameter("TOTAL", Row.Cells(TechnicianCostGridColumns.Total).Value),
                    New MySqlParameter("REMARKS", Row.Cells(TechnicianCostGridColumns.Remarks).Value),
                    New MySqlParameter("UNO", User.Instance.UserNo)
                })
            Next
            Db.ExecuteBatch($"INSERT INTO {Tables.TechnicianCost}(TCDate, TNo, RepNo, RetNo, SNo, SCategory, SName, Rate, Qty, Total, TCRemarks, UNo) VALUES(@TCDATE, @TNO, @REPNO, @RETNO, @SNO, @SCATEGORY, @SNAME, @RATE, @QTY, @TOTAL, @REMARKS, @UNO)", Values.ToArray)
        Catch ex As Exception
            MessageBox.Error(ex.Message)
        Finally
            ButtonClose.PerformClick()
            RaiseEvent SubmitEvent()
        End Try
    End Sub

    Private Function ButtonSaveValidationAndAssignDefaultValues() As Boolean
        If ControlTechnician.GetTechnician() Is Nothing Then
            MessageBox.Exclamation("Technician කෙනෙකු තෝරා නොමැත.")
            Return False
        End If
        For Each Row As DataGridViewRow In GridView.Rows
            If Row.ErrorText <> "" Then
                Return False
            End If
            If String.IsNullOrWhiteSpace(Row.Cells(0).Value) Then
                Row.Cells(0).Value = Now
            End If
        Next

        Return True
    End Function

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dispose()
    End Sub

    Private Sub GridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GridView.RowValidating
        Dim Row As DataGridViewRow = GridView.Rows.Item(e.RowIndex)
        Row.ErrorText = ""
        If Row.IsNewRow Then
            Return
        End If
        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianCostGridColumns.StockNo).Value) And String.IsNullOrWhiteSpace(Row.Cells(TechnicianCostGridColumns.Remarks).Value) Then
            Row.ErrorText = "Stock No හෝ  Remarks Field දෙකම හිස්ව පවතියි."
            e.Cancel = True
            Return
        End If
        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianCostGridColumns.Rate).Value) Then
            Row.ErrorText = "Rate Field එක හිස්ව පවතියි."
            e.Cancel = True
            Return
        End If
        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianCostGridColumns.Qty).Value) Then
            Row.ErrorText = "Qty Field එක හිස්ව පවතියි."
            e.Cancel = True
            Return
        End If
        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianCostGridColumns.RepairNo).Value) = False AndAlso Db.CheckDataExists(Tables.Repair, Repair.RepNo, Row.Cells(TechnicianCostGridColumns.RepairNo).Value) = False Then
            Row.ErrorText = "Repair No එක සොයා ගත නොහැකි විය."
            e.Cancel = True
            Return
        End If
        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianCostGridColumns.ReRepairNo).Value) = False AndAlso Db.CheckDataExists(Tables.ReRepair, ReRepair.RetNo, Row.Cells(TechnicianCostGridColumns.ReRepairNo).Value) = False Then
            Row.ErrorText = "ReRepair No එක සොයා ගත නොහැකි විය."
            e.Cancel = True
            Return
        End If
    End Sub
End Class
