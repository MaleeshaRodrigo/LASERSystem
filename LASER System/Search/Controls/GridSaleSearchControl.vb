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
            Grid.DataSource = DT
        Catch ex As Exception
            FormParent.ControlSearchEngine.QueryValidator(False)
        End Try
    End Sub

    Public Function GetFilterDictionary() As Dictionary(Of String, String) Implements GridSearchControl.GetFilterDictionary
        Return New Dictionary(Of String, String) From {
            {"All", "All"},
            {"SaNo", "Sale No"},
            {"SaDate", "Sale Date"},
            {"CuName", "Customer Name"},
            {"CuTelNo", "Phone Numbers"},
            {"SubTotal", "Total"},
            {"Less", "Less"},
            {"Due", "Due"},
            {"Received", "Received"},
            {"Balance", "Balance"},
            {"CashAmount", "Cash Amount"},
            {"CPInvoiceNo", "Card Payment Invoice No"},
            {"CPAmount", "Card Payment Amount"},
            {"CuLNo", "Customer Loan No"},
            {"CuLAmount", "Customer Loan Amount"},
            {"Remarks", "Remarks"}
        }
    End Function

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        If e.RowIndex < 0 OrElse Grid.Rows(e.RowIndex).IsNewRow Then
            Return
        End If

        For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
            If oForm.Name <> FormParent.Caller Then
                Continue For
            End If

            Dim CustomerTelephoneNos As String() = Grid.Item(GridColumns.CuTelNo, e.RowIndex).Value.ToString().Split(" | ")
            oForm.SetEditMode(New Dictionary(Of String, Object) From {
                {Sale.SaNo, Grid.Item(GridColumns.SaNo, e.RowIndex).Value},
                {Sale.SaDate, Grid.Item(GridColumns.SaDate, e.RowIndex).Value},
                {Customer.CuName, Grid.Item(GridColumns.CuName, e.RowIndex).Value},
                {Customer.CuTelNo1, If(CustomerTelephoneNos.Length > 0 AndAlso (Not String.IsNullOrWhiteSpace(CustomerTelephoneNos(0))), CustomerTelephoneNos(0), Nothing)},
                {Customer.CuTelNo2, If(CustomerTelephoneNos.Length > 1 AndAlso (Not String.IsNullOrWhiteSpace(CustomerTelephoneNos(1))), CustomerTelephoneNos(1), Nothing)},
                {Customer.CuTelNo3, If(CustomerTelephoneNos.Length > 2 AndAlso (Not String.IsNullOrWhiteSpace(CustomerTelephoneNos(2))), CustomerTelephoneNos(2), Nothing)},
                {Sale.SaSubTotal, Grid.Item(GridColumns.SubTotal, e.RowIndex).Value},
                {Sale.SaLess, Grid.Item(GridColumns.Less, e.RowIndex).Value},
                {Sale.SaDue, Grid.Item(GridColumns.Due, e.RowIndex).Value},
                {Sale.CReceived, Grid.Item(GridColumns.Received, e.RowIndex).Value},
                {Sale.CBalance, Grid.Item(GridColumns.Balance, e.RowIndex).Value},
                {Sale.CAmount, Grid.Item(GridColumns.CashAmount, e.RowIndex).Value},
                {Sale.CPInvoiceNo, Grid.Item(GridColumns.CPInvoiceNo, e.RowIndex).Value},
                {Sale.CPAmount, Grid.Item(GridColumns.CPAmount, e.RowIndex).Value},
                {Sale.CuLNo, Grid.Item(GridColumns.CuLNo, e.RowIndex).Value},
                {Sale.CuLAmount, Grid.Item(GridColumns.CuLAmount, e.RowIndex).Value},
                {Sale.SaRemarks, Grid.Item(GridColumns.Remarks, e.RowIndex).Value}
            })
            Exit For
        Next

        FormParent.Close()
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
