Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class TechnicianController
    Inherits AbstractController

    Public Function GetTechnicianNo(TName As String) As Integer
        Return Db.GetData("SELECT TNo FROM Technician WHERE TName = @TNAME;", {
            New MySqlParameter("TNAME", TName)
        })
    End Function

    Public Function GetTechnicianNames() As String()
        Return Db.GetDataList($"Select DISTINCT({Technician.TName}) from {Tables.Technician};").Select(Function(Item) Item(Technician.TName).ToString)
    End Function
End Class
