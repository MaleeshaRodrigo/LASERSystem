Imports MySqlConnector

Public Class ControlStockSelection
    Private Db As Database

    Public Property SCategory()
        Get
            Return ComboStockCategory.Text
        End Get
        Set(value)
            ComboStockCategory.Text = value
        End Set
    End Property

    Public Property SName()
        Get
            Return ComboStockName.Text
        End Get
        Set(value)
            ComboStockName.Text = value
        End Set
    End Property

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
    End Sub

    Private Sub ComboStockCategory_DropDown(sender As Object, e As EventArgs) Handles ComboStockCategory.DropDown
        ComboBoxDropDown(Db, ComboStockCategory, "SELECT SCategory FROM Stock ORDER BY SCategory;")
    End Sub

    Private Sub ComboStockName_DropDown(sender As Object, e As EventArgs) Handles ComboStockName.DropDown
        ComboBoxDropDown(Db, ComboStockName, $"SELECT SName FROM Stock WHERE SCategory='{ComboStockCategory.Text}' ORDER BY SName;")
    End Sub
End Class
