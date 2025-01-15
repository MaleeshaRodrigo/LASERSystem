Imports MySqlConnector

Public Class UserController
    Inherits AbstractController

    Public Function GetLastLoggedUser() As String
        Return Db.GetData("Select UserName from `User` Order by LastLogin Desc LIMIT 1;")
    End Function

    Public Function CheckLogin(UserName As String, Password As String) As Dictionary(Of String, Object)
        Dim Data = Db.GetDataDictionary($"Select * from `User` where STRCMP(@USERNAME,UserName)=0 and STRCMP(Password,@PASSWORD)=0", {
            New MySqlParameter("USERNAME", UserName),
            New MySqlParameter("PASSWORD", Password)
        })
        Return Data
    End Function

    Public Function GetUser(UserName As String) As Dictionary(Of String, Object)
        Dim Data = Db.GetDataDictionary($"Select * from `User` where UserName = '{UserName}'")
        Return Data
    End Function
End Class