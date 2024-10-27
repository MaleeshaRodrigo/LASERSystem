Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class CustomerController
    Inherits AbstractController

    Public Sub InsertCustomer(Data As Dictionary(Of String, Object))
        Db.Execute("INSERT INTO Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) VALUES(@CUNO, @CUNAME, @CUTELNO1, @CUTELNO2, @CUTELNO3);", {
            New MySqlParameter("CUNO", Data(Customer.CuNo)),
            New MySqlParameter("CUNAME", Data(Customer.CuName)),
            New MySqlParameter("CUTELNO1", Data(Customer.CuTelNo1)),
            New MySqlParameter("CUTELNO2", Data(Customer.CuTelNo2)),
            New MySqlParameter("CUTELNO3", Data(Customer.CuTelNo3))
        })
    End Sub
End Class
