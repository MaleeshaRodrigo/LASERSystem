Imports MySqlConnector

Public Class GridSupplySearchControl
    Implements GridSearchControl

    Private Db As Database
    Private FormParent As FormSearch

    Public ReadOnly Property Control As UserControl Implements GridSearchControl.Control
        Get
            Return Me
        End Get
    End Property

    Public Function Init(Db As Database, FormParent As FormSearch) As GridSearchControl Implements GridSearchControl.Init
        Me.Db = Db
        Me.FormParent = FormParent
        Return Me
    End Function

    Public Sub SearchSubmission(WhereQuery As String, Values() As MySqlParameter) Implements GridSearchControl.SearchSubmission
        WhereQuery = If(WhereQuery.Trim() = "", "1", WhereQuery)
        Dim FilterQuery As String = $"SELECT Supply.SupNo,SupDate,Supply.SuNo,SuName,SupRemarks,SupStatus,SupPaidDate FROM (`Supply` Inner Join Supplier On Supplier.SuNo=Supply.SuNo) WHERE {WhereQuery};"
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
            {"SupNo", "Supply No"},
            {"SupDate", "Supply Date"},
            {"SuNo", "Supplier No"},
            {"SuName", "Supplier Name"},
            {"SupStatus", "Status"},
            {"SupPaidDate", "Paid Date"},
            {"SupRemarks", "Remarks"}
        }
    End Function
End Class
