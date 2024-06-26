﻿Imports MySqlConnector
Imports System.Threading

Public Class ControlPopUp
    Private Db As Database
    Private FormParent As FormDeliver

    Public Sub New(Db As Database, FormParent As FormDeliver)
        InitializeComponent()

        Me.Db = Db
        Me.FormParent = FormParent
    End Sub

    Private Sub ControlPopUp_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If cmdReceipt.Enabled = True Then
            If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
                cmdCancel_Click(sender, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = True
                cmdReceipt_Click(cmdReceipt, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = True
                cmdReceipt_Click(cmdNotReceipt, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = False
                cmdReceipt_Click(cmdReceipt, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = False
                cmdReceipt_Click(cmdNotReceipt, e)
            End If
        End If
    End Sub

    Private Sub txtCReceived_TextChanged(sender As Object, e As EventArgs) Handles txtCReceived.TextChanged
        If txtCAmount.Text <> "" And txtCReceived.Text <> "" Then
            txtCBalance.Text = Val(txtCReceived.Text) - Val(txtCAmount.Text)
        End If
    End Sub

    Private Sub txtCAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAmount.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCAmount.KeyPress, txtCReceived.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub ControlPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dock = DockStyle.Fill
        BringToFront()
        chkCashDrawer.Checked = My.Settings.CashDrawer
        txtCuLNo.Text = Db.GetNextKey("CustomerLoan", "CuLNo")
        txtCReceived.Focus()
    End Sub

    Private Sub ControlPopUp_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        FormParent.MenuStrip.Enabled = True
        AcceptButton = FormParent.cmdSave
        FormParent.grdRepair.Focus()
        FormParent.grdRepair.CurrentCell = FormParent.grdRepair.Item(0, FormParent.grdRepair.Rows.Count - 1)
    End Sub

    Private Sub ControlPopUp_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grpPaymentInfo.Top = (Height / 2) - (grpPaymentInfo.Height / 2)
        grpPaymentInfo.Left = (Width / 2) - (grpPaymentInfo.Width / 2)
    End Sub

    Private Sub cmdReceipt_Click(sender As Object, e As EventArgs) Handles cmdReceipt.Click, cmdNotReceipt.Click
        If SaveDeliverRecord() = False Then
            Exit Sub
        End If
        Dim DNo As Integer = FormParent.txtDNo.Text
        Dim threadDeliver As New Thread(Sub()
                                            If sender Is cmdReceipt Then
                                                FormParent.PrintDeliveryReceipt(DNo, True)
                                            End If
                                            SendDeliverEmail(DNo)
                                        End Sub) With {
        .Name = "showDeliverReceiptReport",
        .IsBackground = False,
        .Priority = ThreadPriority.Highest}
        threadDeliver.SetApartmentState(ApartmentState.STA)
        threadDeliver.Start()

        Call FormParent.cmdNew_Click(sender, e)
        cmdCancel.PerformClick()
    End Sub

    Private Function SaveDeliverRecord() As Boolean
        If txtGrandTotal.Text <> Val(txtCAmount.Text) + Val(txtCPAmount.Text) + Val(txtCuLAmount.Text) Then
            MsgBox("Grand Total Field එක Cash Amount, Card Payment Amount සහ Customer Loan Amount එකේ එකතුවට සමාන නැත. කරුණාකර එය නැවත පරිකෂා කරන්න.", vbExclamation + vbOKOnly)
            Return False
            Exit Function
        End If
        Cursor = Cursors.WaitCursor
        'Send Admin to Verify the delivery data
        Dim AdminPer As AdminPermission = GetAdminPermission()
        PreSetPropertyBeforeSaving()
        If (Val(txtCAmount.Text) > 0 Or Val(txtCPAmount.Text) > 0) And chkCashDrawer.Checked = True Then
            CashDrawer.Open()
        End If
        Dim CustomerData = Db.GetDataDictionary("Select * from Customer where CuName='" & FormParent.cmbCuName.Text & "' and CuTelNo1='" & FormParent.txtCuTelNo1.Text & "' and CuTelNo2 ='" & FormParent.txtCuTelNo2.Text & "' and CuTelNo3='" & FormParent.txtCuTelNo3.Text & "'")
        'Customer Management
        Dim CuNo As String
        If CustomerData IsNot Nothing Then
            CuNo = CustomerData("CuNo").ToString
        Else
            AdminPer.Keys.Add("CuNo", "?NewKey?Customer?CuNo?")
            CuNo = "?Key?CuNo?"
            Db.Execute("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & FormParent.cmbCuName.Text & "','" & FormParent.txtCuTelNo1.Text &
                      "','" & FormParent.txtCuTelNo2.Text & "','" & FormParent.txtCuTelNo3.Text & "');", {}, AdminPer)
        End If
        Dim DNo As Integer = Db.GetNextKey("Deliver", "DNo")
        Db.Execute($"INSERT INTO Deliver(DNo,DDate,Cuno,DGrandTotal,CAmount,CReceived,CBalance,CPINvoiceNo,CPAmount,CuLNO,CuLAmount,DRemarks) VALUES(@DNO, @DDATE, @CUNO, @DGRANDTOTAL, @CAMOUNT, @CRECEIVED, @CBALANCE, @CPINVOICENO, @CPAMOUNT, @CULNO, @CULAMOUNT, @DREMARKS);", {
                   New MySqlParameter("DNO", DNo),
                   New MySqlParameter("DDATE", FormParent.txtDDate.Value),
                   New MySqlParameter("CUNO", CuNo),
                   New MySqlParameter("DGRANDTOTAL", txtGrandTotal.Text),
                   New MySqlParameter("CAMOUNT", txtCAmount.Text),
                   New MySqlParameter("CRECEIVED", txtCReceived.Text),
                   New MySqlParameter("CBALANCE", txtCBalance.Text),
                   New MySqlParameter("CPINVOICENO", txtCPInvoiceNo.Text),
                   New MySqlParameter("CPAMOUNT", txtCPAmount.Text),
                   New MySqlParameter("CULNO", txtCuLNo.Text),
                   New MySqlParameter("CULAMOUNT", txtCuLAmount.Text),
                   New MySqlParameter("DREMARKS", FormParent.txtDRemarks.Text)
        }, AdminPer)
        If txtCuLAmount.Text <> "0" Then
            Db.Execute("Insert into CustomerLoan(CuLNo,CuLDate,CuNO,CuLAmount,DNo,Status) Values(?NewKey?CustomerLoan?CuLNo?,@CULDATE,@CUNO,@CULAMOUNT,@DNO,'Not Paid')", {
                   New MySqlParameter("CULDATE", FormParent.txtDDate.Value),
                   New MySqlParameter("CUNO", CuNo),
                   New MySqlParameter("CULAMOUNT", txtCuLAmount.Text),
                   New MySqlParameter("DNO", DNo)
            }, AdminPer)
        End If
        For Each Row1 As DataGridViewRow In FormParent.grdRepair.Rows
            If Row1.Index = FormParent.grdRepair.Rows.Count - 1 Then Continue For
            Dim DrRepStatus = Db.GetDataDictionary("Select Status,RepNo from Repair where RepNo=" & Row1.Cells(0).Value)
            If DrRepStatus IsNot Nothing Then
                If DrRepStatus("Status").ToString = "Received" Or DrRepStatus("Status").ToString = "Hand Over to Technician" Or
                        DrRepStatus("Status").ToString = "Repairing" Then
                    Db.Execute("Update Repair set RepDate = @REPDATE,Charge=@CHARGE where RepNo=@REPNO;", {
                            New MySqlParameter("REPDATE", FormParent.txtDDate.Value),
                            New MySqlParameter("CHARGE", Row1.Cells(4).Value),
                            New MySqlParameter("REPNO", Row1.Cells(0).Value)
                        }, AdminPer)
                End If
            End If
            Db.Execute($"UPDATE Repair SET PaidPrice = @PAIDPRICE,TNo = (SELECT TNo FROM Technician WHERE TName = @TNAME),Status=@STATUS,DNo = @DNO WHERE RepNo=@REPNO;", {
                           New MySqlParameter("PAIDPRICE", Row1.Cells(4).Value),
                           New MySqlParameter("TNAME", Row1.Cells(5).Value),
                           New MySqlParameter("STATUS", Row1.Cells(6).Value.ToString),
                           New MySqlParameter("DNO", DNo),
                           New MySqlParameter("REPNO", Row1.Cells(0).Value)
                           }, AdminPer)
        Next
        For Each Row As DataGridViewRow In FormParent.grdRERepair.Rows
            If Row.Index = FormParent.grdRERepair.Rows.Count - 1 Then Continue For
            Dim DrRetStatus = Db.GetDataDictionary("Select Status,RetNo from `Return` where RetNo=" & Row.Cells(0).Value)
            If DrRetStatus IsNot Nothing Then
                If DrRetStatus("Status").ToString = "Received" Or DrRetStatus("Status").ToString = "Hand Over to Technician" Or DrRetStatus("Status").ToString = "Repairing" Then
                    Db.Execute("UPDATE `Return` SET RepDate = @REPDATE,Charge= @CHARGE where RetNo= @RETNO;", {
                            New MySqlParameter("REPDATE", FormParent.txtDDate.Value),
                            New MySqlParameter("CHARGE", Row.Cells(5).Value.ToString),
                            New MySqlParameter("RETNO", Row.Cells(0).Value.ToString)
                        }, AdminPer)
                End If
            End If
            Db.Execute($"Update `Return` set PaidPrice = @PAIDPRICE,TNo = (SELECT TNo FROM Technician WHERE TName = @TNAME),Status= @STATUS,DNo = @DNO where RetNo= @RETNO", {
                            New MySqlParameter("PAIDPRICE", Row.Cells(5).Value.ToString),
                            New MySqlParameter("TNAME", Row.Cells(6).Value.ToString),
                            New MySqlParameter("STATUS", Row.Cells(7).Value.ToString),
                            New MySqlParameter("DNO", DNo),
                            New MySqlParameter("RETNO", Row.Cells(0).Value.ToString)
                           }, AdminPer)
        Next
        If FormParent.cmdSave.Text = "Edit" Then
            Db.Execute("DELETE FROM Deliver WHERE DNo = @DNO AND Exists( Select 1 From Repair Rep Where Rep.DNo = Deliver.DNo ) = False AND Exists( Select 1 From `Return` Ret Where Ret.DNo = Deliver.DNo ) = False", {
                                New MySqlParameter("DNO", FormParent.txtDNo.Text)
                           })
        End If
        Return True
    End Function

    Private Sub PreSetPropertyBeforeSaving()
        If FormParent.txtDDate.Value.Date = Today.Date Then
            FormParent.txtDDate.Value = DateAndTime.Now
        End If
        txtCuLNo.Text = Db.GetNextKey("CustomerLoan", "CuLNo")
        If txtCAmount.Text.Trim = "" Or txtCAmount.Text = "0" Then
            txtCAmount.Text = "0"
            txtCReceived.Text = "0"
            txtCBalance.Text = "0"
        End If
        If txtCPAmount.Text.Trim = "" Or txtCPAmount.Text = "0" Then
            txtCPAmount.Text = "0"
            txtCPInvoiceNo.Text = "0"
        End If
        If txtCuLAmount.Text.Trim = "" Or txtCuLAmount.Text = "0" Then
            txtCuLAmount.Text = "0"
            txtCuLNo.Text = "0"
        End If
    End Sub

    Private Function GetAdminPermission() As AdminPermission
        Dim AdminPer As New AdminPermission(Db)
        AdminPer.Keys.Add("DNo", "?NewKey?Deliver?DNo?")
        If FormParent.txtDDate.Value.Date <> Today.Date And User.Instance.UserType <> User.Type.Admin Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = $"Date එක අද දිනයට වෙනස් Delivery No: {FormParent.txtDNo.Text} Deliver එක Cashier: {User.Instance.UserName} විසින් ඇතුලත් කෙරුණි."
        End If
        If FormParent.cmdSave.Text = "Edit" And User.Instance.UserType <> User.Type.Admin Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = $"Deliver No: {FormParent.txtDNo.Text} Deliver එක Cashier කෙනෙකු විසින් වෙනස් කෙරුණි."
        End If
        Return AdminPer
    End Function

    Private Sub EditDeliverRecord(AdminPer As AdminPermission)
        If FormParent.cmdSave.Text = "Edit" Then
            AdminPer.Keys.Item("DNo") = FormParent.txtDNo.Text
            Dim DrDeliver = Db.GetDataDictionary("SELECT * from Deliver where DNo=" & FormParent.txtDNo.Text & ";")
            If DrDeliver IsNot Nothing Then
                If DrDeliver("CuLNo").ToString <> "0" And txtCuLNo.Text = "0" Then
                    Db.Execute("DELETE from CustomerLoan where CuLNo=" & DrDeliver("CuLNO").ToString, {}, AdminPer)
                ElseIf DrDeliver("CuLNo").ToString <> "0" And txtCuLNo.Text <> "0" Then
                    Db.Execute("Update CustomerLoan set CuLNo = " & DrDeliver("CuLNO").ToString &
                                                      "CuNo = " & CuNo &
                                                      ",CuLAmount = " & txtCuLAmount.Text &
                                                      ",DNo = " & FormParent.txtDNo.Text &
                                                      ",CuLDate = '" & FormParent.txtDDate.Value &
                                                      "' where CuLNo=" & DrDeliver("CuLNO").ToString, {}, AdminPer)
                    txtCuLNo.Text = DrDeliver("CuLNo").ToString
                ElseIf DrDeliver("CuLNo").ToString = "0" And txtCuLNo.Text <> "0" Then
                    Db.Execute("Insert into CustomerLoan(CuLNO,CuLAmount,CuNo,DNo,CulDate,Status) values(?NewKey?CustomerLoan?CuLNo?," &
                              txtCuLAmount.Text & "," & CuNo & "," & FormParent.txtDNo.Text & ",'" & FormParent.txtDDate.Value & "','Not Paid')", {}, AdminPer)
                End If
                Dim DR1 = Db.GetDataList("SELECT RepNo,REP.PNo,PCategory,PName,Qty,Status,REP.TNo, TName,PaidPrice from (((Repair REP INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where D.DNo=" & FormParent.txtDNo.Text)
                For Each Item In DR1
                    Db.Execute("Update Repair Set " & If(Item("Status").ToString = "Repaired Delivered", "Status='Repaired Not Delivered'",
                              "Status='Returned Not Delivered'") & ",PaidPrice=0,DNo=0 Where DNo=?Key?DNo?", {}, AdminPer)
                Next

                Dim DRReturn = Db.GetDataDictionary("SELECT RetNo,RepNo,RET.PNo,PCategory,PName,Qty,Status,RET.TNo, TName,PaidPrice from (( `RETURN` RET INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where D.DNo=" & FormParent.txtDNo.Text)
                For Each Item In DR1
                    Db.Execute($"Update `Return` Set {If(Item("Status").ToString = "Repaired Delivered", "Status='Repaired Not Delivered'",
                              "Status='Returned Not Delivered'")},PaidPrice=0,DNo=0 Where DNo={FormParent.txtDNo.Text}", {}, AdminPer)
                Next
                Db.Execute($"DELETE FROM Deliver WHERE DNo={FormParent.txtDNo.Text}", {}, AdminPer)
            End If
        End If

    End Sub

    Private Sub SendDeliverEmail(DNo As String)
        Try
            If My.Settings.DeliveredEmailtoT = False Then Exit Sub

            Dim DRAutoD = Db.GetDataList($"SELECT RepNo,DDate, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TEmail, TName, `Status` from ((((Repair Rep Inner Join Deliver D On D.DNo=Rep.DNo) Inner Join Technician T On T.TNo = Rep.TNo) Left Join Product P On P.Pno = Rep.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail IS NOT NULL and `Status` <> 'Returned Delivered' and TActive = 1 AND TBlockEmails <> 1 and D.DNo = {DNo}")
            For Each Item In DRAutoD
                Db.Execute("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?, NOW(), @EMAILTO, @SUBJECT, @BODY, 'Waiting');", {
                    New MySqlParameter("EMAILTO", Item("TEmail").ToString),
                    New MySqlParameter("SUBJECT", "Repair No: " + Item("RepNo").ToString + " රු." + Item("PaidPrice").ToString + " දී Customer විසින් රුගෙන ගොස් ඇත."),
                    New MySqlParameter("BODY", "LASER System " + vbCrLf + vbCrLf +
                            "Repair No: " + Item("RepNo").ToString + vbCrLf +
                            "Delivered Date: " + Item("DDate").ToString + vbCrLf +
                            "Customer Name: " + Item("CuName").ToString + vbCrLf +
                            "Customer Telephone No1: " + Item("CuTelNo1").ToString + vbCrLf +
                            "Product Category: " + Item("PCategory").ToString.Replace("""", """""") + vbCrLf +
                            "Product Name: " + Item("PName").ToString.Replace("""", """""") + vbCrLf +
                            "Qty: " + Item("Qty").ToString + vbCrLf +
                            "Paid Charge: Rs. " + Item("PaidPrice").ToString + vbCrLf +
                            "Technician Name: " + Item("TName").ToString + vbCrLf +
                            "Status: " + Item("Status").ToString + vbCrLf + vbCrLf +
                            "මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, කරුණාකර දත්ත කළමනාකරු අමතන්න")
                })
            Next
            DRAutoD = Db.GetDataList($"SELECT RetNo,RepNo,DDate, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TEmail, TName, `Status` from ((( `Return` Ret Inner Join Deliver D On D.DNo=Ret.DNo) Inner Join Technician T On T.TNo = Ret.TNo) Left Join Product P On P.Pno = Ret.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo Where TEmail IS NOT NULL and `Status` <>'Returned Delivered' and TActive = 1 AND TBlockEmails <> 1 and D.DNo = {DNo}")
            For Each Item In DRAutoD
                Db.Execute("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?, NOW(), @EMAILTO, @SUBJECT, @BODY, 'Waiting');", {
                    New MySqlParameter("EMAILTO", Item("TEmail").ToString),
                    New MySqlParameter("SUBJECT", "RE-Repair No:  " + Item("RetNo").ToString + " රු." + Item("PaidPrice").ToString + " දී Customer විසින් රුගෙන ගොස් ඇත."),
                    New MySqlParameter("BODY", "LASER System " + vbCrLf + vbCrLf +
                            "RERepair No: " + Item("RetNo").ToString + vbCrLf +
                            "Repair No: " + Item("RepNo").ToString + vbCrLf +
                                "Delivered Date: " + Item("DDate").ToString + vbCrLf +
                                "Customer Name: " + Item("CuName").ToString + vbCrLf +
                                "Customer Telephone No1: " + Item("CuTelNo1").ToString + vbCrLf +
                                "Product Category: " + Item("PCategory").ToString.Replace("""", """""") + vbCrLf +
                                "Product Name: " + Item("PName").ToString.Replace("""", """""") + vbCrLf +
                                "Qty: " + Item("Qty").ToString + vbCrLf +
                                "Paid Charge: Rs. " + Item("PaidPrice").ToString + vbCrLf +
                                "Technician Name: " + Item("TName").ToString + vbCrLf +
                                "Status: " + Item("Status").ToString + vbCrLf + vbCrLf +
                                "මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, කරුණාකර දත්ත කළමනාකරු අමතන්න")
                })
            Next
        Catch ex As Exception
            MsgBox("Technician හට Mail එක යැවීමට අපොහොසත් විය." + vbCrLf + vbCrLf + "Error: " + ex.ToString, vbExclamation, "Technician හට Gmail එක යැවීමට නොහැක.")
        End Try
    End Sub
End Class
