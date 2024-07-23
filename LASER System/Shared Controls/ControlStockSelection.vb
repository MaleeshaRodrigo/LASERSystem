Imports MySqlConnector

Public Class ControlStockSelection
    Private Db As Database
    Public Property SCode() As Integer

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

    Private Sub ComboStockCategory_DropDown(sender As Object, e As EventArgs) Handles ComboStockCategory.DropDown, Me.Load
        ComboBoxDropDown(Db, ComboStockCategory, "SELECT DISTINCT SCategory FROM Stock ORDER BY SCategory;")
    End Sub

    Private Sub ComboStockName_DropDown(sender As Object, e As EventArgs) Handles ComboStockName.DropDown
        ComboBoxDropDown(Db, ComboStockName, $"SELECT SName FROM Stock WHERE SCategory='{ComboStockCategory.Text}' ORDER BY SName;")
    End Sub

    Private Sub ComboStockName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboStockName.SelectedIndexChanged, ComboStockCategory.SelectedIndexChanged
        If ComboStockCategory.Text.Trim = "" Or ComboStockName.Text.Trim = "" Then
            SCode = Nothing
            Exit Sub
        End If
        SCode = Db.GetData("SELECT SNo FROM Stock WHERE SCategory=@CATEGORY AND SName=@NAME", {
            New MySqlParameter("CATEGORY", ComboStockCategory.Text),
            New MySqlParameter("NAME", ComboStockName.Text)
        })
    End Sub
End Class
