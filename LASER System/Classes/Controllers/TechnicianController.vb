Imports MySqlConnector

Public Class TechnicianController
    Inherits AbstractController

    Public Function GetTechnicianNo(TName As String) As Integer
        Return Db.GetData("SELECT TNo FROM Technician WHERE TName = @TNAME;", {
            New MySqlParameter("TNAME", TName)
        })
    End Function
End Class
