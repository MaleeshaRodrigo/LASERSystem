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
        Dim Technicians = Db.GetDataList($"SELECT DISTINCT({Technician.TName}) FROM {Tables.Technician};").ToArray()
        Return (From EachTechnician In Technicians Select New String(EachTechnician(Technician.TName))).ToArray()
    End Function
End Class
