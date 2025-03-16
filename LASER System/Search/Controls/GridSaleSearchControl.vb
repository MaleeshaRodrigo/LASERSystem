Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class GridSaleSearchControl
    Implements GridSearchControl

    Private Db As Database
    Private FormParent As FormSearch

    Public ReadOnly Property Control As UserControl Implements GridSearchControl.Control
        Get
            Return Me
        End Get
    End Property

    Public Function Init(Db As Database, ParentForm As FormSearch) As GridSearchControl Implements GridSearchControl.Init
        Me.Db = Db
        FormParent = ParentForm
        SearchSubmission("", {})
        Return Me
    End Function

    Public Sub SearchSubmission(WhereQuery As String, Values() As MySqlParameter) Implements GridSearchControl.SearchSubmission
        WhereQuery = If(WhereQuery.Trim() = "", "1", WhereQuery)
        Dim FilterQuery As String = $"SELECT Sale.SaNo, Sale.SaDate, Customer.CuName, CONCAT_WS(' | ', NULLIF(CuTelNo1, ''), NULLIF(CuTelNo2, ''), NULLIF(CuTelNo3, '')) AS 'CuTelNo', Sale.SaSubTotal, Sale.SaLess, Sale.SaDue, Sale.CReceived, Sale.CBalance, Sale.CAmount, Sale.CPInvoiceNo, Sale.CPAmount, Sale.CuLNo, Sale.CuLAmount, Sale.SaRemarks FROM Sale INNER JOIN Customer ON Customer.CuNo = Sale.CuNo AND {WhereQuery} ORDER BY SaDate DESC;"
        Dim DT As DataTable
        Try
            DT = Db.GetDataTable(FilterQuery, Values)
            FormParent.ControlSearchEngine.QueryValidator(True)
            GridSale.DataSource = DT
        Catch ex As Exception
            FormParent.ControlSearchEngine.QueryValidator(False)
        End Try
    End Sub

    Public Sub PerformQueryMapping(ByRef PoistionList As List(Of Object))
        Dim UpdatedPoistionList As New List(Of Object)(PoistionList)
        For Each Poistion As Object In PoistionList
            Select Case True
                Case Poistion.GetType.Name = "String[]" AndAlso {"CuTelNo"}.Contains(Poistion(0))
                    Dim Value As String = Poistion(1)
                    Dim NewPoistionList As New List(Of Object) From {
                        "(",
                        New List(Of Object) From {Customer.CuTelNo1, Value},
                        "OR",
                        New List(Of Object) From {Customer.CuTelNo2, Value},
                        "OR",
                        New List(Of Object) From {Customer.CuTelNo3, Value},
                        ")"
                    }
                    Dim PoistionIndex = UpdatedPoistionList.IndexOf(Poistion)
                    UpdatedPoistionList.Remove(Poistion)
                    UpdatedPoistionList.InsertRange(PoistionIndex, NewPoistionList)
            End Select
        Next
        PoistionList = UpdatedPoistionList
    End Sub

    Public Function GetFilterDictionary() As Dictionary(Of String, String) Implements GridSearchControl.GetFilterDictionary
        Return New Dictionary(Of String, String) From {
            {"All", "All"},
            {Sale.SaNo, "Sale No"},
            {Sale.SaDate, "Sale Date"},
            {Customer.CuName, "Customer Name"},
            {"CuTelNo", "Phone Numbers"},
            {Sale.SaSubTotal, "Total"},
            {Sale.SaLess, "Less"},
            {Sale.SaDue, "Due"},
            {Sale.CReceived, "Received"},
            {Sale.CBalance, "Balance"},
            {Sale.CAmount, "Cash Amount"},
            {Sale.CPInvoiceNo, "Card Payment Invoice No"},
            {Sale.CPAmount, "Card Payment Amount"},
            {Sale.CuLNo, "Customer Loan No"},
            {Sale.CuLAmount, "Customer Loan Amount"},
            {Sale.SaRemarks, "Remarks"}
        }
    End Function

    Public Function PerformFilterAll(Random As Random, SearchText As String) As (Query As String, Value As MySqlParameter)
        Dim QueryArray As New List(Of String)
        Dim RandomNumber As Integer = Random.Next()
        Dim ParameterValue As New MySqlParameter($"VALUE{RandomNumber}", $"%{SearchText}%")
        Dim Filters = GetFilterDictionary()
        For Each Key In Filters.Keys
            If Key = "All" Then
                Continue For
            End If

            Select Case Key
                Case GridColumns.CuTelNo
                    Dim CustomerTelephoneFields As String() = {Customer.CuTelNo1, Customer.CuTelNo2, Customer.CuTelNo3}
                    For Each CustomerTelephoneField As String In CustomerTelephoneFields
                        QueryArray.Add($"{CustomerTelephoneField} LIKE @VALUE{RandomNumber}")
                    Next
                Case Else
                    QueryArray.Add($"{Key} LIKE @VALUE{RandomNumber}")
            End Select
        Next

        Return ($" ({String.Join(" OR ", QueryArray)}) ", ParameterValue)
    End Function

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridSale.CellDoubleClick
        If e.RowIndex < 0 OrElse GridSale.Rows(e.RowIndex).IsNewRow Then
            Return
        End If

        For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
            If oForm.Name <> FormParent.Caller Then
                Continue For
            End If

            Dim CustomerTelephoneNos As String() = GridSale.Item(GridColumns.CuTelNo, e.RowIndex).Value.ToString().Split(" | ")
            oForm.SetEditMode(New Dictionary(Of String, Object) From {
                {Sale.SaNo, GridSale.Item(GridColumns.SaNo, e.RowIndex).Value},
                {Sale.SaDate, GridSale.Item(GridColumns.SaDate, e.RowIndex).Value},
                {Customer.CuName, GridSale.Item(GridColumns.CuName, e.RowIndex).Value},
                {Customer.CuTelNo1, If(CustomerTelephoneNos.Length > 0 AndAlso (Not String.IsNullOrWhiteSpace(CustomerTelephoneNos(0))), CustomerTelephoneNos(0), Nothing)},
                {Customer.CuTelNo2, If(CustomerTelephoneNos.Length > 1 AndAlso (Not String.IsNullOrWhiteSpace(CustomerTelephoneNos(1))), CustomerTelephoneNos(1), Nothing)},
                {Customer.CuTelNo3, If(CustomerTelephoneNos.Length > 2 AndAlso (Not String.IsNullOrWhiteSpace(CustomerTelephoneNos(2))), CustomerTelephoneNos(2), Nothing)},
                {Sale.SaSubTotal, GridSale.Item(GridColumns.SubTotal, e.RowIndex).Value},
                {Sale.SaLess, GridSale.Item(GridColumns.Less, e.RowIndex).Value},
                {Sale.SaDue, GridSale.Item(GridColumns.Due, e.RowIndex).Value},
                {Sale.CReceived, GridSale.Item(GridColumns.Received, e.RowIndex).Value},
                {Sale.CBalance, GridSale.Item(GridColumns.Balance, e.RowIndex).Value},
                {Sale.CAmount, GridSale.Item(GridColumns.CashAmount, e.RowIndex).Value},
                {Sale.CPInvoiceNo, GridSale.Item(GridColumns.CPInvoiceNo, e.RowIndex).Value},
                {Sale.CPAmount, GridSale.Item(GridColumns.CPAmount, e.RowIndex).Value},
                {Sale.CuLNo, GridSale.Item(GridColumns.CuLNo, e.RowIndex).Value},
                {Sale.CuLAmount, GridSale.Item(GridColumns.CuLAmount, e.RowIndex).Value},
                {Sale.SaRemarks, GridSale.Item(GridColumns.Remarks, e.RowIndex).Value}
            })
            Exit For
        Next

        FormParent.Close()
    End Sub

    Private Sub GridSale_SelectionChanged(sender As Object, e As EventArgs) Handles GridSale.SelectionChanged
        If GridSale.CurrentRow.Index < 0 OrElse GridSale.CurrentRow.Index >= GridSale.RowCount Then
            Return
        End If

        Dim DataTable = Db.GetDataTable($"SELECT S.SNo, SSa.SCategory, SSa.SName, SaType, SaUnits, SaRate, SaTotal FROM StockSale SSa LEFT JOIN  Stock S ON SSa.SNo = S.SNo WHERE SaNo = @SANO;", {
            New MySqlParameter("SANO", GridSale.Item(GridColumns.SaNo, GridSale.CurrentRow.Index).Value)
        })
        GridStock.DataSource = DataTable
    End Sub

    Private Structure GridColumns
        Public Const SaNo As String = "SaNo"
        Public Const SaDate As String = "SaDate"
        Public Const CuName As String = "CuName"
        Public Const CuTelNo As String = "CuTelNo"
        Public Const SubTotal As String = "SaSubTotal"
        Public Const Less As String = "SaLess"
        Public Const Due As String = "SaDue"
        Public Const Received As String = "CReceived"
        Public Const Balance As String = "CBalance"
        Public Const CashAmount As String = "CAmount"
        Public Const CPInvoiceNo As String = "CPInvoiceNo"
        Public Const CPAmount As String = "CPAmount"
        Public Const CuLNo As String = "CuLNo"
        Public Const CuLAmount As String = "CuLAmount"
        Public Const Remarks As String = "SaRemarks"
    End Structure
End Class
