Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public MustInherit Class AbstractRepairController : Inherits AbstractController
    Private ReadOnly CustomerController As New CustomerController()
    Private ReadOnly ProductController As New ProductController()

    Public Overrides Function SetDatabase(ByRef Db As Database) As AbstractController
        CustomerController.SetDatabase(Db)
        ProductController.SetDatabase(Db)
        Return MyBase.SetDatabase(Db)
    End Function


    Public Sub SaveReceivedRepair(Data As Dictionary(Of String, Object), RepairTable As DataTable, ReRepairTable As DataTable)
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
        InsertReceiveRepair(New Dictionary(Of String, Object) From {
            {Receive.RDate, Data(Receive.RDate)},
            {Receive.CuNo, CustomerNo}
        })
        For Each Row As DataRow In RepairTable.Rows
            InsertRepairData(Row, IsReRepair:=False)
        Next

        For Each Row As DataRow In ReRepairTable.Rows
            InsertRepairData(Row, IsReRepair:=True)
        Next
    End Sub

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

    Private Sub InsertRepairData(TableRow As DataRow, IsReRepair As Boolean)
        Dim ProductNo As Integer = GetOrInsertProduct(TableRow)
        Dim repairData = New Dictionary(Of String, Object) From {
            {If(IsReRepair, ReRepair.RetNo, Repair.RepNo), TableRow(If(IsReRepair, ReRepair.RetNo, Repair.RepNo))},
            {If(IsReRepair, ReRepair.RepNo, Repair.RNo), TableRow(If(IsReRepair, ReRepair.RepNo, Repair.RNo))},
            {If(IsReRepair, ReRepair.PNo, Repair.PNo), ProductNo},
            {If(IsReRepair, ReRepair.PSerialNo, Repair.PSerialNo), TableRow(If(IsReRepair, ReRepair.PSerialNo, Repair.PSerialNo))},
            {If(IsReRepair, ReRepair.Qty, Repair.Qty), TableRow(If(IsReRepair, ReRepair.Qty, Repair.Qty))},
            {If(IsReRepair, ReRepair.Problem, Repair.Problem), TableRow(If(IsReRepair, ReRepair.Problem, Repair.Problem))}
        }
        Dim RepairController As New RepairController
        Dim ReRepairController As New ReRepairController
        RepairController.SetDatabase(Db)
        ReRepairController.SetDatabase(Db)
        If Not IsReRepair Then
            repairData.Add(Repair.Status, TableRow(Repair.Status))
            RepairController.InsertRepair(repairData)
        Else
            ReRepairController.InsertReRepair(repairData)
        End If

        InsertRemarksIfPresent(TableRow(If(IsReRepair, ReRepair.RepNo, Repair.RepNo)), TableRow(RepairRemarks1.Remarks))
    End Sub

    Private Sub InsertRemarksIfPresent(RepNo As Object, Remarks As Object)
        If Remarks IsNot Nothing AndAlso Not String.IsNullOrEmpty(Remarks.ToString()) Then
            InsertRepairRemarks1(RepNo, Remarks)
        End If
    End Sub

    Private Sub InsertReceiveRepair(Data As Dictionary(Of String, Object))
        Db.Execute("INSERT INTO Receive(RDate,CuNo,UNo) VALUES(@RDATE, @CUNO, @UNO);", {
            New MySqlParameter("RDATE", Date.Parse(Data(Receive.RDate))),
            New MySqlParameter("CUNO", Data(Receive.CuNo)),
            New MySqlParameter("UNO", User.Instance.UserNo)
        })
    End Sub

    Private Sub InsertRepairRemarks1(RepairNo As Integer, Remarks As String)
        Db.Execute("INSERT INTO RepairRemarks1(Rem1Date,RepNo,Remarks,UNo) Values(@DATE, @REPNO, @REMARKS, @UNO);", {
            New MySqlParameter("DATE", Now),
            New MySqlParameter("REPNO", RepairNo),
            New MySqlParameter("REMARKS", Remarks),
            New MySqlParameter("UNO", User.Instance.UserNo)
        })
    End Sub
End Class
