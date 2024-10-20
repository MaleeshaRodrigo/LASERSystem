Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCommandInfo


    Private Sub SaveReceive()
        Cursor = Cursors.WaitCursor
        'Customer Management 
        Dim CuNo, PNo As Integer
        Dim DR = db.GetDataDictionary("Select * from Customer where CuName='" & cmbCuMr.Text & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text & "' and CuTelNo2 ='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "'")
        If DR IsNot Nothing Then
            CuNo = DR("CuNo")
        Else
            CuNo = db.GetNextKey("Customer", "CuNo")
            db.Execute("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & cmbCuMr.Text & cmbCuName.Text & "','" & txtCuTelNo1.Text & "','" & txtCuTelNo2.Text & "','" & txtCuTelNo3.Text & "')")
        End If
        If txtRDate.Value.Date = Today.Date Then txtRDate.Value = DateAndTime.Now
        txtRNo.Text = db.GetNextKey("Receive", "RNo")
        db.Execute("Insert into Receive(RNo,RDate,CuNo,UNo) values(@RNO, @RDATE, @CUNO, @UNO);", {
            New MySqlParameter("RNO", txtRNo.Text),
            New MySqlParameter("RDATE", txtRDate.Value),
            New MySqlParameter("CUNO", CuNo),
New MySqlParameter("UNO", User.Instance.UserNo)
        })
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index = grdRepair.Rows.Count - 1 Then Continue For
            'Product Management
            Dim DrProduct = db.GetDataDictionary("Select * from Product where PCategory='" & row.Cells(1).Value & "' and PName='" & row.Cells(2).Value & "'")
            If DrProduct IsNot Nothing Then
                PNo = DrProduct("PNo")
            Else
                PNo = db.GetNextKey("Product", "PNo")
                db.Execute("INSERT INTO Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) Values(" & PNo & ",'" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(5).Value & "');")
            End If
            db.Execute("INSERT INTO Repair(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status)Values(" & row.Cells(0).Value & "," & txtRNo.Text & "," & PNo & ",'" & row.Cells(4).Value & "'," &
                                        row.Cells(6).Value & ",'" & row.Cells(7).Value & "','Received');")
            db.Execute("INSERT INTO RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(?NewKey?RepairActivity?RepANo?," &
                      row.Cells(0).Value & ",NOW(),'Received Date -> " & txtRDate.Value & vbCrLf &
                      ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text &
                      ", Telephone No2 -> " & txtCuTelNo2.Text &
                      ", Telephone No3 -> " & txtCuTelNo3.Text & vbCrLf &
                      ", Product Category -> " & row.Cells(1).Value &
                      ", Product Name -> " & row.Cells(2).Value &
                      ", Model No -> " & row.Cells(3).Value &
                      ", Serial No -> " & row.Cells(4).Value &
                      ", Problem -> " & row.Cells(5).Value & ".'," & User.Instance.UserNo & ")")
            If row.Cells(8).Value IsNot Nothing Then
                db.Execute("INSERT INTO RepairRemarks1(Rem1No,Rem1Date,RepNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,NOW()," &
                      row.Cells(0).Value & ",'" & row.Cells(8).Value & "'," & User.Instance.UserNo & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As FormDeliver In Application.OpenForms().OfType(Of FormDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRepair.Rows.Add(row.Cells("RepairNo").Value, row.Cells("PCategory").Value, row.Cells("PName").Value, row.Cells("PQty").Value, "0", "", "")
                        End With
                        Exit For
                    End If
                Next
            End If
        Next row
        For Each row As DataGridViewRow In grdReRepair.Rows
            If row.Index = grdReRepair.Rows.Count - 1 Then Continue For
            'Product Management
            Dim DrProduct = db.GetDataDictionary("Select * from Product where PCategory='" & row.Cells(2).Value & "' and PName='" & row.Cells(3).Value & "'")
            If DrProduct IsNot Nothing Then
                PNo = DrProduct("PNo")
            Else
                PNo = db.GetNextKey("Product", "PNo")
                db.Execute("INSERT INTO Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) Values(@PNO, @PCATEGORY, @PNAME, @PMODELNO, @PDETAILS)", {
                    New MySqlParameter("PNO", PNo),
                    New MySqlParameter("PCATEGORY", row.Cells(2).Value),
                    New MySqlParameter("PNAME", row.Cells(3).Value),
                    New MySqlParameter("PMODELNO", row.Cells(4).Value),
                    New MySqlParameter("PDETAILS", row.Cells(6).Value)
                })
            End If
            db.Execute("INSERT INTO `Return`(RetNo,RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status) VALUES(@RETNO, @REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS)", {
                New MySqlParameter("RETNO", row.Cells(0).Value),
                New MySqlParameter("REPNO", row.Cells(1).Value),
                New MySqlParameter("RNO", txtRNo.Text),
                New MySqlParameter("PNO", PNo),
                New MySqlParameter("PSERIALNO", row.Cells(5).Value),
                New MySqlParameter("QTY", row.Cells(7).Value),
                New MySqlParameter("PROBLEM", row.Cells(8).Value),
                New MySqlParameter("STATUS", "Received")
            })
            db.Execute("INSERT INTO RepairActivity(RetNo,RepADate,Activity,UNo) VALUES(@RETNO, NOW(), @ACTIVITY, @UNO);", {
                New MySqlParameter("RETNO", row.Cells(0).Value),
                New MySqlParameter("ACTIVITY", "Received Date -> " & txtRDate.Value &
                      ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text &
                      ", Telephone No2 -> " & txtCuTelNo2.Text &
                      ", Telephone No3 -> " & txtCuTelNo3.Text &
                      ", Product Category -> " & row.Cells(2).Value &
                      ", Product Name -> " & row.Cells(3).Value &
                      ", Model No -> " & row.Cells(4).Value &
                      ", Serial No -> " & row.Cells(5).Value &
                      ", Problem -> " & row.Cells(8).Value),
                New MySqlParameter("UNO", User.Instance.UserNo)
            })
            If row.Cells(8).Value IsNot Nothing Then
                db.Execute("Insert into RepairRemarks1(Rem1No,Rem1Date,RetNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,NOW()," &
                      row.Cells(0).Value & ",'" & row.Cells(9).Value & "'," & User.Instance.UserNo & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As FormDeliver In Application.OpenForms().OfType(Of FormDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRERepair.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells("RETPCategory").Value, row.Cells("RETPName").Value, row.Cells("RETQty").Value, "0", "", "")
                        End With
                        Exit For
                    End If
                Next
            End If
        Next row
        Cursor = Cursors.Default
    End Sub

    Private Sub ControlCommandInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
            cmdCancel.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
            cmdReceiptSticker.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
            cmdReceipt.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
            cmdSticker.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
            cmdSaveOnly.PerformClick()
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        pnlRSaveFinal.Visible = False
        pnlRSaveFinal.Dock = DockStyle.None
        MenuStrip.Enabled = True
        AcceptButton = cmdSave
        txtCuTelNo1.Focus()
    End Sub

    Private Sub cmdReceiptSticker_Click(sender As Object, e As EventArgs) Handles cmdReceiptSticker.Click, cmdReceipt.Click, cmdSticker.Click
        SaveReceive()
        Dim RNo As Integer = txtRNo.Text
        cmdNew_Click(sender, e)
        If sender Is cmdReceipt Or sender Is cmdReceiptSticker Then
            PrintReceivedReceipt(RNo, True, True, "ReceivedReceipt")
        End If
        If sender Is cmdSticker Or sender Is cmdReceiptSticker Then
            PrintSticker(RNo, True, True, "ReceivedSticker")
        End If
    End Sub
End Class
