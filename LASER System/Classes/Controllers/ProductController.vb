Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ProductController
    Inherits AbstractController

    Public Function GetProduct(Category As String, Name As String) As Dictionary(Of String, Object)
        Return Db.GetDataDictionary("SELECT * FROM Product WHERE PCategory = @PCATEGORY AND PName = @PNAME;", {
            New MySqlParameter("PCATEGORY", Category),
            New MySqlParameter("PNAME", Name)
        })
    End Function

    Public Sub InsertProduct(Data As Dictionary(Of String, Object))
        Db.Execute("INSERT INTO Product(PCATEGORY, PNAME, PDETAILS) VALUES(@PCATEGORY, @PNAME, @PDETAILS);", {
            New MySqlParameter("PCATEGORY", Data(Product.PCategory)),
            New MySqlParameter("PNAME", Data(Product.PName)),
            New MySqlParameter("PDETAILS", Data(Product.PDetails))
        })
    End Sub
End Class
