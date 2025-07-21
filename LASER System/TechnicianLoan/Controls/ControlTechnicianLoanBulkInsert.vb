Imports LASER_System.StructureDatabase
Imports Microsoft.Office.Interop.Access.Dao
Imports MySqlConnector

Public Class ControlTechnicianLoanBulkInsert
    Public Event SubmitEvent()

    Private Db As Database
    Private DatePicker As ControlGridDatePicker

    Public Function Init(Db As Database) As ControlTechnicianLoanBulkInsert
        Me.Db = Db
        ControlTechnician.SetDatabase(Db)
        Return Me
    End Function

    Public Function SetTechnician(Technician As String) As ControlTechnicianLoanBulkInsert
        ControlTechnician.SetTechnician(Technician)
        Return Me
    End Function

    Private Function ButtonSaveValidationAndAssignDefaultValues() As Boolean
        If ControlTechnician.GetTechnician() Is Nothing Then
            Throw New Exception("Technician කෙනෙකු තෝරා නොමැත.")
        End If
        For Each Row As DataGridViewRow In GridView.Rows
            If Row.ErrorText <> "" Then
                Throw New Exception("Insert කිරීමට ගනු ලබන Data වල Errors පවතියි.")
            End If
            If String.IsNullOrWhiteSpace(Row.Cells(0).Value) Then
                Row.Cells(0).Value = Now
            End If
        Next

        Return True
    End Function

    Private Sub GridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GridView.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 0
                DatePicker = New ControlGridDatePicker()
                DatePicker.Init(GridView.CurrentCell)
                DatePicker.Location = GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                DatePicker.Size = New Size(GridView.Columns.Item(e.ColumnIndex).Width, GridView.Rows.Item(e.RowIndex).Height)
                DatePicker.Value = If(GridView.CurrentCell.Value Is Nothing, Now, Convert.ToDateTime(GridView.CurrentCell.Value))
                GridView.Controls.Add(DatePicker)
        End Select
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
                frmSearchDropDown.frm_Open(Db, GridView, ParentForm, "SELECT SCategory FROM Stock GROUP BY SCategory;", "SCategory")
            Case 3
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, GridView, ParentForm, "SELECT SCategory,SName FROM Stock WHERE SCategory='" &
                GridView.Item(2, GridView.CurrentCell.RowIndex).Value & "';", "SName")
        End Select
    End Sub

    Private Sub GridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellEndEdit
        Dim CurrentRowIndex As Integer = GridView.CurrentCell.RowIndex
        If GridView.Item(TechnicianLoanGridColumns.Date, CurrentRowIndex).Value Is Nothing Then
            GridView.Item(TechnicianLoanGridColumns.Date, CurrentRowIndex).Value = Now
        End If

        Select Case e.ColumnIndex
            Case GridView.Columns(TechnicianLoanGridColumns.StockNo).Index
                Dim Result = Db.GetDataDictionary("SELECT SCategory, SName, SLowestPrice FROM Stock WHERE SNo = @SNO;", {
                    New MySqlParameter("SNO", GridView.Item(TechnicianLoanGridColumns.StockNo, CurrentRowIndex).Value)
                })
                If Result Is Nothing Then
                    Return
                End If

                GridView.Item(TechnicianLoanGridColumns.StockCategory, CurrentRowIndex).Value = Result(Stock.Category)
                GridView.Item(TechnicianLoanGridColumns.StockName, CurrentRowIndex).Value = Result(Stock.Name)
                GridView.Item(TechnicianLoanGridColumns.Rate, CurrentRowIndex).Value = Result(Stock.LowestPrice)
                Dim EventArg As New DataGridViewCellEventArgs(
                    GridView.Columns(TechnicianLoanGridColumns.Rate).Index, CurrentRowIndex)
                GridView_CellEndEdit(sender, EventArg)
            Case GridView.Columns(TechnicianLoanGridColumns.StockCategory).Index, GridView.Columns(TechnicianLoanGridColumns.StockName).Index
                frmSearchDropDown.frm_Close()
                Dim Result = Db.GetDataDictionary("SELECT SNo, SLowestPrice FROM Stock WHERE SCategory = @SCATEGORY AND SName = @SNAME;", {
                    New MySqlParameter("SCATEGORY", GridView.Item(TechnicianLoanGridColumns.StockCategory, CurrentRowIndex).Value),
                    New MySqlParameter("SNAME", GridView.Item(TechnicianLoanGridColumns.StockName, CurrentRowIndex).Value)
                })
                If Result Is Nothing Then
                    Return
                End If

                GridView.Item(TechnicianLoanGridColumns.StockNo, CurrentRowIndex).Value = Result(Stock.Code)
                GridView.Item(TechnicianLoanGridColumns.Rate, CurrentRowIndex).Value = Result(Stock.LowestPrice)
                Dim EventArg As New DataGridViewCellEventArgs(5, CurrentRowIndex)
                GridView_CellEndEdit(sender, EventArg)
            Case GridView.Columns(TechnicianLoanGridColumns.Qty).Index, GridView.Columns(TechnicianLoanGridColumns.Rate).Index
                If GridView.Item(TechnicianLoanGridColumns.Qty, CurrentRowIndex).Value Is Nothing Then
                    GridView.Item(TechnicianLoanGridColumns.Qty, CurrentRowIndex).Value = 1
                End If

                If IsNumeric(GridView.Item(TechnicianLoanGridColumns.Qty, CurrentRowIndex).Value) = False Or
                    IsNumeric(GridView.Item(TechnicianLoanGridColumns.Rate, CurrentRowIndex).Value) = False Then
                    Return
                End If

                GridView.Item(TechnicianLoanGridColumns.Total, CurrentRowIndex).Value = Double.Parse(GridView.Item(TechnicianLoanGridColumns.Qty, CurrentRowIndex).Value) * Double.Parse(GridView.Item(TechnicianLoanGridColumns.Rate, CurrentRowIndex).Value)
        End Select
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            If ButtonSaveValidationAndAssignDefaultValues() = False Then
                Return
            End If

            Dim QueriesWithValues As New List(Of (Query As String, Parameters As MySqlParameter()))
            For Each Row As DataGridViewRow In GridView.Rows
                If Row.IsNewRow Then
                    Continue For
                End If

                QueriesWithValues.Add(($"INSERT INTO {Tables.TechnicianLoan}(TLDate, TNo, SNo, SCategory, SName, Rate, Qty, Total, TLRemarks, UNo) VALUES(@TLDATE, @TNO, @SNO, @SCATEGORY, @SNAME, @RATE, @QTY, @TOTAL, @REMARKS, @UNO)", {
                    New MySqlParameter("TLDATE", Date.Parse(Row.Cells(TechnicianLoanGridColumns.Date).Value)),
                    New MySqlParameter("TNO", ControlTechnician.GetTechnicianNo),
                    New MySqlParameter("SNO", Row.Cells(TechnicianLoanGridColumns.StockNo).Value),
                    New MySqlParameter("SCATEGORY", Row.Cells(TechnicianLoanGridColumns.StockCategory).Value),
                    New MySqlParameter("SNAME", Row.Cells(TechnicianLoanGridColumns.StockName).Value),
                    New MySqlParameter("RATE", Row.Cells(TechnicianLoanGridColumns.Rate).Value),
                    New MySqlParameter("QTY", Row.Cells(TechnicianLoanGridColumns.Qty).Value),
                    New MySqlParameter("TOTAL", Row.Cells(TechnicianLoanGridColumns.Total).Value),
                    New MySqlParameter("REMARKS", Row.Cells(TechnicianLoanGridColumns.Remarks).Value),
                    New MySqlParameter("UNO", User.Instance.UserNo)
                }))
                If String.IsNullOrWhiteSpace(Row.Cells(TechnicianLoanGridColumns.StockNo).Value) = False Then
                    QueriesWithValues.Add(($"UPDATE {Tables.Stock} SET {Stock.AvailableUnits}=({Stock.AvailableUnits}-@UNITS) WHERE {Stock.Code}=@CODE;", {
                        New MySqlParameter("UNITS", Row.Cells(TechnicianLoanGridColumns.Qty).Value),
                        New MySqlParameter("CODE", Row.Cells(TechnicianLoanGridColumns.StockNo).Value)
                    }))
                End If
            Next
            Db.ExecuteBatches(QueriesWithValues.ToArray)
            ButtonClose.PerformClick()
            RaiseEvent SubmitEvent()
        Catch ex As Exception
            MessageBox.Error(ex.Message)
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dispose()
    End Sub

    Private Sub GridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GridView.RowValidating
        Dim Row As DataGridViewRow = GridView.Rows.Item(e.RowIndex)
        Row.ErrorText = ""
        If Row.IsNewRow Then
            Return
        End If

        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianLoanGridColumns.StockNo).Value) And String.IsNullOrWhiteSpace(Row.Cells(TechnicianLoanGridColumns.Remarks).Value) Then
            Row.ErrorText = "Stock No හෝ  Remarks Field දෙකම හිස්ව පවතියි."
            e.Cancel = True
            Return
        End If

        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianLoanGridColumns.Rate).Value) Then
            Row.ErrorText = "Rate Field එක හිස්ව පවතියි."
            e.Cancel = True
            Return
        End If

        If String.IsNullOrWhiteSpace(Row.Cells(TechnicianLoanGridColumns.Qty).Value) Then
            Row.ErrorText = "Qty Field එක හිස්ව පවතියි."
            e.Cancel = True
            Return
        End If

        If User.Instance.UserType = User.Type.Cashier AndAlso Today.Date.CompareTo(Date.Parse(Row.Cells(0).Value).Date) Then
            Row.ErrorText = "ඔබට අද දිනට අදාළ නොවන Record එකක් ඇතුලත් කිරීමට අවසර නොමැත."
            e.Cancel = True
            Return
        End If
    End Sub

    Private Structure TechnicianLoanGridColumns
        Const [Date] = "TLDate"
        Const StockNo = "SNo"
        Const StockCategory = "SCategory"
        Const StockName = "SName"
        Const Rate = "Rate"
        Const Qty = "Qty"
        Const Total = "Total"
        Const Remarks = "TLRemarks"
        Const User = "UName"
    End Structure
End Class

