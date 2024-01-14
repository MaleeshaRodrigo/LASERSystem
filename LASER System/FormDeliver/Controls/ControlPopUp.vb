﻿Imports System.Data.OleDb
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
        SetNextKey(Db, txtCuLNo, "SELECT top 1 CuLNo from CustomerLoan ORDER BY CuLNo Desc;", "CuLNo")
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
        If FormParent.cmdSave.Text = "Save" AndAlso SaveDeliverRecord() = False Then
            Exit Sub
        End If
        If FormParent.cmdSave.Text = "Edit" AndAlso EditDeliverRecord() = False Then
            Exit Sub
        End If
        If sender Is cmdReceipt Then
            Dim DNo As Integer = FormParent.txtDNo.Text
            Dim threadDeliver As New Thread(Sub()
                                                If sender Is cmdReceipt Then
                                                    FormParent.PrintDeliveryReceipt(DNo, True)
                                                End If
                                                SendDeliverEmail(FormParent.txtDNo.Text)
                                            End Sub) With {
            .Name = "showDeliverReceiptReport",
            .IsBackground = False,
            .Priority = ThreadPriority.Highest
                                        }
            threadDeliver.SetApartmentState(ApartmentState.STA)
            threadDeliver.Start()
        End If

        Call FormParent.cmdNew_Click(sender, e)
        cmdCancel.PerformClick()
    End Sub

    Private Function SaveDeliverRecord() As Boolean
        Dim Validator = New ExecuteValidators()
        With Validator
            .AddValidator(New CustomValidator(txtGrandTotal.Text <> Val(txtCAmount.Text) + Val(txtCPAmount.Text) + Val(txtCuLAmount.Text), "Grand Total Field එක Cash Amount, Card Payment Amount සහ Customer Loan Amount එකේ එකතුවට සමාන නැත. කරුණාකර එය නැවත පරිකෂා කරන්න."))
            If Not .Execute() Then
                Return False
            End If
        End With
        Cursor = Cursors.WaitCursor
        'Send Admin to Verify the delivery data
        Dim AdminPer As AdminPermission = GetAdminPermission()
        PreSetPropertyBeforeSaving()
        If (Val(txtCAmount.Text) > 0 Or Val(txtCPAmount.Text) > 0) And chkCashDrawer.Checked = True Then
            CashDrawer.Open()
        End If
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Customer where CuName='" & FormParent.cmbCuName.Text & "' and CuTelNo1='" & FormParent.txtCuTelNo1.Text & "' and CuTelNo2 ='" & FormParent.txtCuTelNo2.Text & "' and CuTelNo3='" & FormParent.txtCuTelNo3.Text & "'")
        'Customer Management
        Dim CuNo As String
        If DR.HasRows = True Then
            DR.Read()
            CuNo = DR("CuNo").ToString
        Else
            AdminPer.Keys.Add("CuNo", "?NewKey?Customer?CuNo?")
            CuNo = "?Key?CuNo?"
            Db.Execute($"Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values({CuNo},'{FormParent.cmbCuName.Text}','{FormParent.txtCuTelNo1.Text}','{FormParent.txtCuTelNo2.Text}','{FormParent.txtCuTelNo3.Text }');", {}, AdminPer)
        End If
        Dim DNo As Integer = Db.GetNextKey("Deliver", "DNo")
        Db.Execute("INSERT INTO Deliver(DNo,DDate,Cuno,DGrandTotal,CAmount,CReceived,CBalance,CPINvoiceNo,CPAmount,CuLNO,CuLAmount,DRemarks) VALUES(@DNO, @DDATE, @CUNO, @DGRANDTOTAL, @CAMOUNT, @CRECEIVED, @CBALANCE, @CPINVOICENO, @CPAMOUNT, @CULNO, @CULAMOUNT, @DREMARKS);", {
                   New OleDbParameter("DNO", DNo),
                   New OleDbParameter("DDATE", FormParent.txtDDate.Value.ToString),
                   New OleDbParameter("CUNO", CuNo),
                   New OleDbParameter("DGRANDTOTAL", txtGrandTotal.Text),
                   New OleDbParameter("CAMOUNT", txtCAmount.Text),
                   New OleDbParameter("CRECEIVED", txtCReceived.Text),
                   New OleDbParameter("CBALANCE", txtCBalance.Text),
                   New OleDbParameter("CPINVOICENO", txtCPInvoiceNo.Text),
                   New OleDbParameter("CPAMOUNT", txtCPAmount.Text),
                   New OleDbParameter("CULNO", txtCuLNo.Text),
                   New OleDbParameter("CULAMOUNT", txtCuLAmount.Text),
                   New OleDbParameter("DREMARKS", FormParent.txtDRemarks.Text)
                   }, AdminPer)
        If txtCuLAmount.Text <> "0" Then
            Db.Execute("Insert into CustomerLoan(CuLNo,CuLDate,CuNO,CuLAmount,DNo,Status) Values(?NewKey?CustomerLoan?CuLNo?,@CULDATE,@CUNO,@CULAMOUNT,@DNO,'Not Paid')", {
                   New OleDbParameter("CULDATE", FormParent.txtDDate.Value.ToString),
                   New OleDbParameter("CUNO", CuNo),
                   New OleDbParameter("CULAMOUNT", txtCuLAmount.Text),
                   New OleDbParameter("DNO", DNo)
            }, AdminPer)
        End If
        For Each Row1 As DataGridViewRow In FormParent.grdRepair.Rows
            If Row1.Index = FormParent.grdRepair.Rows.Count - 1 Then Continue For
            Dim DrRepStatus As OleDbDataReader = Db.GetDataReader("Select Status,RepNo from Repair where RepNo=" & Row1.Cells(0).Value)
            If DrRepStatus.HasRows = True Then
                DrRepStatus.Read()
                If DrRepStatus("Status").ToString = "Received" Or DrRepStatus("Status").ToString = "Hand Over to Technician" Or
                    DrRepStatus("Status").ToString = "Repairing" Then
                    Db.Execute("Update Repair set RepDate = @REPDATE,Charge=@CHARGE where RepNo=@REPNO;", {
                        New OleDbParameter("REPDATE", FormParent.txtDDate.Value.ToString),
                        New OleDbParameter("CHARGE", Row1.Cells(4).Value),
                        New OleDbParameter("REPNO", Row1.Cells(0).Value)
                    }, AdminPer)
                End If
            End If
            Db.Execute($"UPDATE Repair SET PaidPrice = @PAIDPRICE,TNo = DLookup('TNo', 'Technician', 'TName=""{Row1.Cells(5).Value}""'),[Status]=@STATUS,DNo = @DNO WHERE RepNo=@REPNO;", {
                       New OleDbParameter("PAIDPRICE", Row1.Cells(4).Value),
                       New OleDbParameter("STATUS", Row1.Cells(6).Value.ToString),
                       New OleDbParameter("DNO", DNo),
                       New OleDbParameter("REPNO", Row1.Cells(0).Value)
                       }, AdminPer)
        Next
        For Each Row As DataGridViewRow In FormParent.grdRERepair.Rows
            If Row.Index = FormParent.grdRERepair.Rows.Count - 1 Then Continue For
            Dim DrRetStatus As OleDbDataReader = Db.GetDataReader("Select Status,RetNo from Return where RetNo=" & Row.Cells(0).Value)
            If DrRetStatus.HasRows = True Then
                DrRetStatus.Read()
                If DrRetStatus("Status").ToString = "Received" Or DrRetStatus("Status").ToString = "Hand Over to Technician" Or DrRetStatus("Status").ToString = "Repairing" Then
                    Db.Execute("UPDATE `Return` SET RetRepDate = @RETREPDATE,Charge= @CHARGE where RepNo= @REPNO;", {
                        New OleDbParameter("RETREPDATE", FormParent.txtDDate.Value.ToString),
                        New OleDbParameter("CHARGE", Row.Cells(5).Value.ToString),
                        New OleDbParameter("REPNO", Row.Cells(0).Value.ToString)
                    }, AdminPer)
                End If
            End If
            Db.Execute("Update `Return` set PaidPrice = @PAIDPRICE,TNo = DLookup('TNo', 'Technician', 'TName=""{Row.Cells(6).Value}""'),Status= @STATUS,DNo = @DNO where RetNo= @RETNO", {
                        New OleDbParameter("PAIDPRICE", Row.Cells(5).Value.ToString),
                        New OleDbParameter("STATUS", Row.Cells(7).Value.ToString),
                        New OleDbParameter("DNO", DNo),
                        New OleDbParameter("RETNO", Row.Cells(0).Value.ToString)
                       }, AdminPer)
        Next
        Return True
    End Function

    Private Function EditDeliverRecord() As Boolean
        If FormParent.cmdSave.Text <> "Edit" Then
            Return False
        End If
        Dim DrDeliver As OleDbDataReader = Db.GetDataReader("SELECT * from Deliver where DNo=" & FormParent.txtDNo.Text & ";")
        If DrDeliver.HasRows = False Then
            Return False
        End If
        PreSetPropertyBeforeSaving(True)
        Dim CuNo As Integer = Db.GetData("Select CuNo from Customer where CuName=@CUNAME and CuTelNo1=@CUTELNO1 and CuTelNo2=@CUTELNO2 and CuTelNo3=@CUTELNO3", {
            New OleDbParameter("CUNAME", FormParent.cmbCuName.Text),
            New OleDbParameter("CUTELNO1", FormParent.txtCuTelNo1.Text),
            New OleDbParameter("CUTELNO2", FormParent.txtCuTelNo2.Text),
            New OleDbParameter("CUTELNO3", FormParent.txtCuTelNo3.Text)
        })
        Db.Execute($"UPDATE Deliver SET DDate=@DDATE,CuNo=@CUNO,DGrandTotal=@DGRANDTOTAL,CAmount=@CAMOUNT,CReceived=@CRECEIVED,CBalance=@CBALANCE,CPINvoiceNo=@CPINVOICENO,CPAmount=@CPAMOUNT,CuLNO=@CULNO,CuLAmount=@CULAMOUNT,DRemarks=@DREMARKS WHERE DNo=@DNO", {
            New OleDbParameter("DDATE", FormParent.txtDDate.Value.ToString),
            New OleDbParameter("CUNO", CuNo),
            New OleDbParameter("DGRANDTOTAL", txtGrandTotal.Text),
            New OleDbParameter("CAMOUNT", txtCAmount.Text),
            New OleDbParameter("CRECEIVED", txtCReceived.Text),
            New OleDbParameter("CBALANCE", txtCBalance.Text),
            New OleDbParameter("CPINVOICENO", txtCPInvoiceNo.Text),
            New OleDbParameter("CPAMOUNT", txtCPAmount.Text),
            New OleDbParameter("CULNO", txtCuLNo.Text),
            New OleDbParameter("CULAMOUNT", txtCuLAmount.Text),
            New OleDbParameter("DREMARKS", FormParent.txtDRemarks.Text),
            New OleDbParameter("DNO", FormParent.txtDNo.Text)
        })
        For Each Row1 As DataGridViewRow In FormParent.grdRepair.Rows
            If Row1.Index = FormParent.grdRepair.Rows.Count - 1 Then Continue For
            Db.Execute($"UPDATE Repair SET PaidPrice = @PAIDPRICE,TNo = DLookup('TNo', 'Technician', 'TName=""{Row1.Cells(5).Value}""'),[Status]=@STATUS,DNo = @DNO WHERE RepNo=@REPNO;", {
                           New OleDbParameter("PAIDPRICE", Row1.Cells(4).Value),
                           New OleDbParameter("STATUS", Row1.Cells(6).Value.ToString),
                           New OleDbParameter("DNO", FormParent.txtDNo.Text),
                           New OleDbParameter("REPNO", Row1.Cells(0).Value)
                           })
        Next
        For Each Row As DataGridViewRow In FormParent.grdRERepair.Rows
            If Row.Index = FormParent.grdRERepair.Rows.Count - 1 Then Continue For
            Db.Execute("Update `Return` set PaidPrice = @PAIDPRICE,TNo = DLookup('TNo', 'Technician', 'TName=""{Row.Cells(6).Value}""'),Status= @STATUS,DNo = @DNO where RetNo= @RETNO", {
                        New OleDbParameter("PAIDPRICE", Row.Cells(5).Value.ToString),
                        New OleDbParameter("STATUS", Row.Cells(7).Value.ToString),
                        New OleDbParameter("DNO", FormParent.txtDNo.Text),
                        New OleDbParameter("RETNO", Row.Cells(0).Value.ToString)
                       })
        Next
        Return True
    End Function

    Private Sub PreSetPropertyBeforeSaving(Optional EditMode As Boolean = False)
        If FormParent.txtDDate.Value.Date = Today.Date Then
            FormParent.txtDDate.Value = DateAndTime.Now
        End If
        If (EditMode = False) Then
            SetNextKey(Db, txtCuLNo, "Select Top 1 CulNo from CustomerLoan order by CuLNo Desc;", "CuLNo")
        End If
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

    Private Sub SendDeliverEmail(DNo As String)
        Try
            If My.Settings.DeliveredEmailtoT = False Then Exit Sub
            Dim DRAutoD As OleDbDataReader = Db.GetDataReader("SELECT RepNo,DDate, TEmail,TName, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TName, Status from ((((Repair Rep Inner Join Deliver D On D.DNo=Rep.DNo) Inner Join Technician T On T.TNo = Rep.TNo) Left Join Product P On P.Pno = Rep.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail <> NULL and Status <>'Returned Delivered' and TBlockEmails <> Yes and D.DNo =" & DNo)
            While DRAutoD.Read()
                Db.Execute("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?,#" & DateAndTime.Now &
                                  "#,'" & DRAutoD("TEmail").ToString & "','Repair No:  " + DRAutoD("RepNo").ToString + " එක Customer විසින් රු." +
                                  DRAutoD("PaidPrice").ToString + " දී රුගෙන ගොස් ඇත.',""LASER System " + vbCrLf + vbCrLf +
                                    "Repair No: " + DRAutoD("RepNo").ToString + vbCrLf +
                                    "Delivered Date: " + DRAutoD("DDate").ToString + vbCrLf +
                                    "Customer Name: " + DRAutoD("CuName").ToString + vbCrLf +
                                    "Customer Telephone No1: " + DRAutoD("CuTelNo1").ToString + vbCrLf +
                                    "Product Category: " + DRAutoD("PCategory").ToString.Replace("""", """""") + vbCrLf +
                                    "Product Name: " + DRAutoD("PName").ToString.Replace("""", """""") + vbCrLf +
                                    "Qty: " + DRAutoD("Qty").ToString + vbCrLf +
                                    "Paid Charge: Rs. " + DRAutoD("PaidPrice").ToString + vbCrLf +
                                    "Technician Name: " + DRAutoD("TName").ToString + vbCrLf +
                                    "Status: " + DRAutoD("Status").ToString + vbCrLf + vbCrLf +
                                    "මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, කරුණාකර දත්ත කළමනාකරු අමතන්න"",'Waiting');")
            End While
            DRAutoD = Db.GetDataReader($"SELECT RetNo,RepNo,DDate, TEmail,TName, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TName, Status from ((((Return Ret Inner Join Deliver D On D.DNo=Ret.DNo) Inner Join Technician T On T.TNo = Ret.TNo) Left Join Product P On P.Pno = Ret.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail <> NULL and Status <>'Returned Delivered' and TBlockEmails <> Yes and D.DNo = {DNo}")
            While DRAutoD.Read()
                Db.Execute("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?,#" & DateAndTime.Now &
                                  "#,'" & DRAutoD("TEmail").ToString & "','RERepair No:  " + DRAutoD("RetNo").ToString + " එක Customer විසින් රු." +
                                  DRAutoD("PaidPrice").ToString + "දී රුගෙන ගොස් ඇත.',
                                  ""LASER System " + vbCrLf + vbCrLf +
                                "RERepair No: " + DRAutoD("RetNo").ToString + vbCrLf +
                                "Repair No: " + DRAutoD("RepNo").ToString + vbCrLf +
                                    "Delivered Date: " + DRAutoD("DDate").ToString + vbCrLf +
                                    "Customer Name: " + DRAutoD("CuName").ToString + vbCrLf +
                                    "Customer Telephone No1: " + DRAutoD("CuTelNo1").ToString + vbCrLf +
                                    "Product Category: " + DRAutoD("PCategory").ToString.Replace("""", """""") + vbCrLf +
                                    "Product Name: " + DRAutoD("PName").ToString.Replace("""", """""") + vbCrLf +
                                    "Qty: " + DRAutoD("Qty").ToString + vbCrLf +
                                    "Paid Charge: Rs. " + DRAutoD("PaidPrice").ToString + vbCrLf +
                                    "Technician Name: " + DRAutoD("TName").ToString + vbCrLf +
                                    "Status: " + DRAutoD("Status").ToString + vbCrLf + vbCrLf +
                                    "මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, කරුණාකර දත්ත කළමනාකරු අමතන්න"",'Waiting');")
            End While
        Catch ex As Exception
            MsgBox("Technician හට Gmail එක යැවීමට අපොහොසත් විය. කරුණාකර Internet Connection එක පරික්ෂා කරන්න." + vbCrLf + vbCrLf + "Error: " + ex.ToString, vbExclamation, "Technician හට Gmail එක යැවීමට නොහැක.")
        End Try
    End Sub
End Class
