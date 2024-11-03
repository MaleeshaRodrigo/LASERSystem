Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class CustomerController
    Inherits AbstractController

    Public Function InsertCustomer(Data As Dictionary(Of String, Object)) As Integer
        Return Db.Execute("INSERT INTO Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) VALUES(@CUNO, @CUNAME, @CUTELNO1, @CUTELNO2, @CUTELNO3);", {
            New MySqlParameter("CUNO", Data(Customer.CuNo)),
            New MySqlParameter("CUNAME", Data(Customer.CuName)),
            New MySqlParameter("CUTELNO1", Data(Customer.CuTelNo1)),
            New MySqlParameter("CUTELNO2", Data(Customer.CuTelNo2)),
            New MySqlParameter("CUTELNO3", Data(Customer.CuTelNo3))
        })
    End Function

    Public Function GetCustomer(CuName As String, CuTelNo1 As String, CuTelNo2 As String, CuTelNo3 As String) As Dictionary(Of String, Object)
        Return Db.GetDataDictionary("SELECT * FROM Customer WHERE CuName = @CUNAME AND CuTelNo1 = @CUTELNO1 AND CuTelNo2 = @CUTELNO2 AND CuTelNo3 = @CUTELNO3;", {
            New MySqlParameter("CUNAME", CuName),
            New MySqlParameter("CUTELNO1", CuTelNo1),
            New MySqlParameter("CUTELNO2", CuTelNo2),
            New MySqlParameter("CUTELNO3", CuTelNo3)
        })
    End Function

    Public Function GetCustomerNo(CuName As String, CuTelNo1 As String, CuTelNo2 As String, CuTelNo3 As String) As Integer
        Return Db.GetData("SELECT CuNo FROM Customer WHERE CuName = @CUNAME AND CuTelNo1 = @CUTELNO1 AND CuTelNo2 = @CUTELNO2 AND CuTelNo3 = @CUTELNO3;", {
            New MySqlParameter("CUNAME", CuName),
            New MySqlParameter("CUTELNO1", CuTelNo1),
            New MySqlParameter("CUTELNO2", CuTelNo2),
            New MySqlParameter("CUTELNO3", CuTelNo3)
        })
    End Function
End Class
