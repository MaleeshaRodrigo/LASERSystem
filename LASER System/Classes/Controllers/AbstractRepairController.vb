Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public MustInherit Class AbstractRepairController : Inherits AbstractController
    Private ReadOnly CustomerController As New CustomerController()
    Private ReadOnly ProductController As New ProductController()
    Private ReadOnly TechnicianController As New TechnicianController()

    Public Overrides Function SetDatabase(ByRef Db As Database) As AbstractController
        CustomerController.SetDatabase(Db)
        ProductController.SetDatabase(Db)
        TechnicianController.SetDatabase(Db)
        Return MyBase.SetDatabase(Db)
    End Function


    Public Function SaveReceivedRepair(Data As Dictionary(Of String, Object), RepairTable As DataTable, ReRepairTable As DataTable) As Integer
        Dim CustomerNo As Integer = CustomerController.GetCustomerNo(Data(Customer.CuName), Data(Customer.CuTelNo1), Data(Customer.CuTelNo2), Data(Customer.CuTelNo3))
        If CustomerNo = 0 Then
            CustomerNo = CustomerController.InsertCustomer(New Dictionary(Of String, Object) From {
                {Customer.CuNo, CustomerNo},
                {Customer.CuName, Data(Customer.CuName)},
                {Customer.CuTelNo1, Data(Customer.CuTelNo1)},
                {Customer.CuTelNo2, Data(Customer.CuTelNo2)},
                {Customer.CuTelNo3, Data(Customer.CuTelNo3)}
            })
        End If
        Dim RNo As Integer = InsertReceiveRepair(New Dictionary(Of String, Object) From {
            {Receive.RDate, Data(Receive.RDate)},
            {Receive.CuNo, CustomerNo}
        })
        For Each Row As DataRow In RepairTable.Rows
            InsertRepairData(RNo, Row, IsReRepair:=False)
        Next

        For Each Row As DataRow In ReRepairTable.Rows
            InsertRepairData(RNo, Row, IsReRepair:=True)
        Next

        Return RNo
    End Function

    Private Function GetOrInsertProduct(Row As DataRow) As Integer
        Dim ProductNo As Integer
        Dim ProductResult = ProductController.GetProduct(Row(Product.PCategory), Row(Product.PName))

        If ProductResult IsNot Nothing Then
            ProductNo = ProductResult(Product.PNo)
        Else
            ProductNo = ProductController.InsertProduct(New Dictionary(Of String, Object) From {
                {Product.PCategory, Row(Product.PCategory)},
                {Product.PName, Row(Product.PName)},
                {Product.PDetails, Row(Product.PDetails)}
            })
        End If

        Return ProductNo
    End Function

    Private Sub InsertRepairData(RNo As Integer, TableRow As DataRow, IsReRepair As Boolean)
        Dim ProductNo As Integer = GetOrInsertProduct(TableRow)
        Dim RepairData = New Dictionary(Of String, Object) From {
            {Repair.RNo, RNo},
            {ReRepair.RetNo, If(IsReRepair, TableRow(ReRepair.RetNo), Nothing)},
            {Repair.RepNo, TableRow(ReRepair.RepNo)},
            {Repair.PNo, ProductNo},
            {Repair.PSerialNo, TableRow(Repair.PSerialNo)},
            {Repair.Qty, TableRow(Repair.Qty)},
            {Repair.Problem, TableRow(Repair.Problem)}
        }
        Dim TNo As Object = Nothing
        If Not IsDBNull(TableRow(Technician.TName)) Then
            TNo = TechnicianController.GetTechnicianNo(TableRow(Technician.TName))
        End If
        RepairData.Add(Repair.Status, If(TNo, RepairStatus.HandedOverTo, RepairStatus.Received))
        RepairData.Add(Repair.TNo, TNo)
        Dim RepairController As New RepairController
        Dim ReRepairController As New ReRepairController
        RepairController.SetDatabase(Db)
        ReRepairController.SetDatabase(Db)
        If IsReRepair Then
            ReRepairController.InsertReRepair(RepairData)
            InsertRemarksIfPresent(Nothing, TableRow(ReRepair.RetNo), TableRow(RepairRemarks1.Remarks))
        Else
            RepairController.InsertRepair(RepairData)
            InsertRemarksIfPresent(TableRow(Repair.RepNo), Nothing, TableRow(RepairRemarks1.Remarks))
        End If
    End Sub

    Private Sub InsertRemarksIfPresent(RepNo As Object, RetNo As Object, Remarks As Object)
        If Not IsDBNull(Remarks) Then
            InsertRepairRemarks1(RepNo, RetNo, Remarks)
        End If
    End Sub

    Private Function InsertReceiveRepair(Data As Dictionary(Of String, Object)) As Integer
        Return Db.Execute($"INSERT INTO {Tables.Receive}(RDate,CuNo,UNo) VALUES(NOW(), @CUNO, @UNO);", {
            New MySqlParameter("CUNO", Data(Receive.CuNo)),
            New MySqlParameter("UNO", User.Instance.UserNo)
        })
    End Function

    Private Sub InsertRepairRemarks1(RepairNo As Object, ReRepairNo As Object, Remarks As String)
        Db.Execute($"INSERT INTO {Tables.RepairRemarks1}(Rem1Date, RepNo, RetNo, Remarks, UNo) Values(@DATE, @REPNO, @RETNO, @REMARKS, @UNO);", {
            New MySqlParameter("DATE", Now),
            New MySqlParameter("REPNO", RepairNo),
            New MySqlParameter("RETNO", ReRepairNo),
            New MySqlParameter("REMARKS", Remarks),
            New MySqlParameter("UNO", User.Instance.UserNo)
        })
    End Sub
End Class
