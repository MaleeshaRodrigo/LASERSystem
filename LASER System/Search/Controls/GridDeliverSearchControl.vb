Imports MySqlConnector

Public Class GridDeliverSearchControl
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
        Dim FilterQuery As String = $"SELECT Deliver.DNo,DDate,Customer.CuNo,CuName,CuTelNo1,CuTelNo2,CuTelNo3,DGrandTotal,CReceived,CBalance,CAmount,CPInvoiceNo,CPAmount,CuLNo,CuLAmount,DRemarks FROM Deliver,Customer WHERE Customer.CuNo=Deliver.CuNo {WhereQuery} ORDER BY DDate DESC;"
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
            {"DNo", "Deliver No"},
            {"DDate", "Delivered Date"},
            {"CuName", "Customer Name"},
            {"CuTelNo", "Customer Telephone No"},
            {"DGrandTotal", "Grand Total"},
            {"CReceived", "Received"},
            {"CBalance", "Balance"},
            {"CAmount", "Cash Amount"},
            {"CPInvoiceNo", "Card Payment Invoice No"},
            {"CPAmount", "Card Payment Amount"},
            {"CuLNo", "Customer Loan No"},
            {"CuLAmount", "Customer Loan Amount"},
            {"DRemarks", "Remarks"}
        }
    End Function
End Class
