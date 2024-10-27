Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class RepairController
    Inherits AbstractController
    Private CustomerController As New CustomerController()
    Private ProductController As New ProductController()

    Public Sub New()
        CustomerController.SetDatabase(Db)
        ProductController.SetDatabase(Db)
    End Sub

    Public Sub SaveReceivedRepair(Data As Dictionary(Of String, Object), RepairTable As DataTable, ReRepairTable As DataTable)
        Dim CustomerNo As Integer
        Dim Result = Db.GetDataDictionary("SELECT * FROM Customer where CuName = @CUNAME AND CuTelNo1 = @CUTELNO1 AND CuTelNo2 = @CUTELNO2 AND CuTelNo3 = @CUTELNO3;", {
            New MySqlParameter("CUNAME", Data("CuName")),
            New MySqlParameter("CUTELNO1", Data("CuTelNo1")),
            New MySqlParameter("CUTELNO2", Data("CuTelNo2")),
            New MySqlParameter("CUTELNO3", Data("CuTelNo3"))
        })
        If Result IsNot Nothing Then
            CustomerNo = Result("CuNo")
        Else
            CustomerNo = Db.GetNextKey("Customer", "CuNo")
            CustomerController.InsertCustomer(New Dictionary(Of String, Object) From {
                {Customer.CuNo, CustomerNo},
                {Customer.CuName, Data(Customer.CuName)},
                {Customer.CuTelNo1, Data(Customer.CuTelNo1)},
                {Customer.CuTelNo2, Data(Customer.CuTelNo2)},
                {Customer.CuTelNo3, Data(Customer.CuTelNo3)}
            })
        End If
        Db.Execute("INSERT INTO Receive(RDate,CuNo,UNo) VALUES(@RDATE, @CUNO, @UNO);", {
            New MySqlParameter("RDATE", Data(Receive.RDate)),
            New MySqlParameter("CUNO", CustomerNo),
            New MySqlParameter("UNO", User.Instance.UserNo)
        })
        For Each Row As DataRow In RepairTable.Rows
            Dim ProductNo As Integer
            Dim ProductResult = ProductController.GetProduct(Row(Product.PCategory), Row(Product.PName))
            If ProductResult IsNot Nothing Then
                ProductNo = ProductResult(Product.PNo)
            Else
                ProductNo = Db.GetNextKey(Tables.Product, Product.PNo)
                ProductController.InsertProduct({
                                                
                })
                })
            End If
            Db.Execute("INSERT INTO Repair(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status) VALUES(@REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS);", {
                New MySqlParameter("REPNO", Row(Repair.RepNo)),
                New MySqlParameter("RNO", Row(Repair.RNo)),
                New MySqlParameter("PNO", Row(Repair.PNo)),
                New MySqlParameter("PSERIALNO", Row(Repair.PSerialNo)),
                New MySqlParameter("QTY", Row(Repair.Qty)),
                New MySqlParameter("PROBLEM", Row(Repair.Problem)),
                New MySqlParameter("STATUS", Row(Repair.Status))
            })
            If Row(RepairRemarks1.Remarks) IsNot Nothing Then
                InsertRepairRemarks1(Row(Repair.RepNo), Row(RepairRemarks1.Remarks))
            End If
        Next Row
        For Each Row As DataRow In ReRepairTable.Rows
            Dim ProductNo As Integer
            Dim DrProduct = ProductController.GetProduct(Row(Product.PCategory), Row(Product.PName))
            If DrProduct IsNot Nothing Then
                ProductNo = DrProduct("PNo")
            Else
                ProductNo = Db.GetNextKey("Product", "PNo")
                ProductController.InsertProduct(New Dictionary(Of String, Object) From {
                    {Product.PCategory, Row(Product.PCategory)},
                    {Product.PName, Row(Product.PName)},
                    {Product.PDetails, Row(Product.PDetails)}
                })
                Db.Execute("INSERT INTO Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) VALUES(@PNO, @PCATEGORY, @PNAME, @PMODELNO, @PDETAILS);", {
                    New MySqlParameter("PNO", Row(Product.PNo)),
                    New MySqlParameter("PCATEGORY", Row(Product.PCategory)),
                    New MySqlParameter("PNAME", Row(Product.PName)),
                    New MySqlParameter("PDETAILS", Row.Cells(6).Value)
                })
            End If
            Db.Execute("INSERT INTO `Return`(RetNo,RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status) VALUES(@RETNO, @REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS)", {
                New MySqlParameter("RETNO", Row.Cells(0).Value),
                New MySqlParameter("REPNO", Row.Cells(1).Value),
                New MySqlParameter("RNO", txtRNo.Text),
                New MySqlParameter("PNO", ProductNo),
                New MySqlParameter("PSERIALNO", Row.Cells(5).Value),
                New MySqlParameter("QTY", Row.Cells(7).Value),
                New MySqlParameter("PROBLEM", Row.Cells(8).Value),
                New MySqlParameter("STATUS", "Received")
            })
            Db.Execute("INSERT INTO RepairActivity(RetNo,RepADate,Activity,UNo) VALUES(@RETNO, NOW(), @ACTIVITY, @UNO);", {
                New MySqlParameter("RETNO", Row.Cells(0).Value),
                New MySqlParameter("ACTIVITY", "Received Date -> " & txtRDate.Value &
                      ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text &
                      ", Telephone No2 -> " & txtCuTelNo2.Text &
                      ", Telephone No3 -> " & txtCuTelNo3.Text &
                      ", Product Category -> " & Row.Cells(2).Value &
                      ", Product Name -> " & Row.Cells(3).Value &
                      ", Model No -> " & Row.Cells(4).Value &
                      ", Serial No -> " & Row.Cells(5).Value &
                      ", Problem -> " & Row.Cells(8).Value),
                New MySqlParameter("UNO", User.Instance.UserNo)
            })
            If Row.Cells(8).Value IsNot Nothing Then
                Db.Execute("Insert into RepairRemarks1(Rem1No,Rem1Date,RetNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,NOW()," &
                      Row.Cells(0).Value & ",'" & Row.Cells(9).Value & "'," & User.Instance.UserNo & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As FormDeliver In Application.OpenForms().OfType(Of FormDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRERepair.Rows.Add(Row.Cells(0).Value, Row.Cells(1).Value, Row.Cells("RETPCategory").Value, Row.Cells("RETPName").Value, Row.Cells("RETQty").Value, "0", "", "")
                        End With
                        Exit For
                    End If
                Next
            End If
        Next Row
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
