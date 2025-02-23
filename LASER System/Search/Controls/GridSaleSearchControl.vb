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
        Return Me
    End Function

    Public Sub SearchSubmission(WhereQuery As String, Values() As MySqlParameter) Implements GridSearchControl.SearchSubmission
        WhereQuery = If(WhereQuery.Trim() = "", "1", WhereQuery)
        Dim FilterQuery As String = $"SELECT Sale.SaNo, Sale.SaDate, Customer.CuName, Customer.CuTelNo1, Customer.CuTelNo2, Customer.CuTelNo3, Sale.SaSubTotal, Sale.SaLess, Sale.SaDue, Sale.CReceived, Sale.CBalance, Sale.CAmount, Sale.CPInvoiceNo, Sale.CPAmount, Sale.CuLNo, Sale.CuLAmount, Sale.SaRemarks FROM Sale INNER JOIN Customer ON Customer.CuNo = Sale.CuNo AND {WhereQuery} ORDER BY SaDate DESC;"
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
End Class
