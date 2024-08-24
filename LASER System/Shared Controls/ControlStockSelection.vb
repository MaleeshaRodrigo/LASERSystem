Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlStockSelection
    Private Db As Database
    Public Event StockChanged()

    Public Property SCode() As Integer
        Get
            Return TextStockCode.Value
        End Get
        Set(Value As Integer)
            TextStockCode.Value = Value
        End Set
    End Property

    Public Property SCategory() As String
        Get
            Return ComboStockCategory.Text
        End Get
        Set(value As String)
            ComboStockCategory.Text = value
        End Set
    End Property

    Public Property SName() As String
        Get
            Return ComboStockName.Text
        End Get
        Set(value As String)
            ComboStockName.Text = value
        End Set
    End Property

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
    End Sub

    Private Sub ControlStockSelection_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DesignMode Then
            Exit Sub
        End If

        ComboBoxDropDown(Db, ComboStockCategory, "SELECT DISTINCT SCategory FROM Stock ORDER BY SCategory;")
    End Sub

    Private Sub ComboStockCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboStockCategory.SelectedIndexChanged
        ComboBoxDropDown(Db, ComboStockName, $"SELECT SName FROM Stock WHERE SCategory='{ComboStockCategory.Text}' ORDER BY SName;")
        ComboStockName.Text = ""
    End Sub

    Private Sub TextStockCode_ValueChanged(sender As Object, e As EventArgs) Handles TextStockCode.ValueChanged
        Dim Result = Db.GetDataDictionary("SELECT SCategory, SName FROM Stock WHERE SNo=@SNO;", {
            New MySqlParameter("SNO", TextStockCode.Value)
        })
        If Result Is Nothing Then
            ComboStockCategory.Text = ""
            ComboStockName.Text = ""
            Return
        End If

        ComboStockCategory.Text = Result(Stock.Category)
        ComboStockName.Text = Result(Stock.Name)
        RaiseEvent StockChanged()
    End Sub

    Private Sub ComboStockName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboStockName.SelectedIndexChanged
        If ComboStockCategory.Text.Trim = "" Or ComboStockName.Text.Trim = "" Then
            Return
        End If

        TextStockCode.Value = Db.GetData("SELECT SNo FROM Stock WHERE SCategory=@CATEGORY AND SName=@NAME", {
            New MySqlParameter("CATEGORY", ComboStockCategory.Text),
            New MySqlParameter("NAME", ComboStockName.Text)
        })
    End Sub
End Class
