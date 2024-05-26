Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft
Imports System.Windows.Documents

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
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Customer where CuName='" & FormParent.cmbCuName.Text & "' and CuTelNo1='" & FormParent.txtCuTelNo1.Text & "' and CuTelNo2 ='" & FormParent.txtCuTelNo2.Text & "' and CuTelNo3='" & FormParent.txtCuTelNo3.Text & "'")
        'Customer Management
        Dim CuNo As String
        If DR.HasRows = True Then
            DR.Read()
            CuNo = DR("CuNo").ToString
        Else
            AdminPer.Keys.Add("CuNo", "?NewKey?Customer?CuNo?")
            CuNo = "?Key?CuNo?"
            Db.Execute("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & FormParent.cmbCuName.Text & "','" & FormParent.txtCuTelNo1.Text &
                      "','" & FormParent.txtCuTelNo2.Text & "','" & FormParent.txtCuTelNo3.Text & "');", {}, AdminPer)
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
                   New OleDbParameter("PINVOICENO", txtCPInvoiceNo.Text),
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
                    Db.Execute("UPDATE `Return` SET RetRepDate = @RETREPDATE,Charge= @CHARGE where RetNo= @RETNO;", {
                            New OleDbParameter("RETREPDATE", FormParent.txtDDate.Value.ToString),
                            New OleDbParameter("CHARGE", Row.Cells(5).Value.ToString),
                            New OleDbParameter("RETNO", Row.Cells(0).Value.ToString)
                        }, AdminPer)
                End If
            End If
            Db.Execute($"Update `Return` set PaidPrice = @PAIDPRICE,TNo = DLookup('TNo', 'Technician', 'TName=""{Row.Cells(6).Value}""'),[Status]= @STATUS,DNo = @DNO where RetNo= @RETNO", {
                            New OleDbParameter("PAIDPRICE", Row.Cells(5).Value.ToString),
                            New OleDbParameter("STATUS", Row.Cells(7).Value.ToString),
                            New OleDbParameter("DNO", DNo),
                            New OleDbParameter("RETNO", Row.Cells(0).Value.ToString)
                           }, AdminPer)
        Next
        If FormParent.cmdSave.Text = "Edit" Then
            Db.Execute("DELETE FROM Deliver D WHERE DNo = @DNO AND Exists( Select 1 From Repair Rep Where Rep.DNo = D.DNo ) = False AND Exists( Select 1 From Return Ret Where Ret.DNo = D.DNo ) = False", {
                            New OleDbParameter("DNO", FormParent.txtDNo.Text)
                       })
        End If
        Return True
    End Function

    Private Sub PreSetPropertyBeforeSaving()
        If FormParent.txtDDate.Value.Date = Today.Date Then
            FormParent.txtDDate.Value = DateAndTime.Now
        End If
        SetNextKey(Db, txtCuLNo, "Select Top 1 CulNo from CustomerLoan order by CuLNo Desc;", "CuLNo")
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
            Dim DrDeliver As OleDbDataReader = Db.GetDataReader("SELECT * from Deliver where DNo=" & FormParent.txtDNo.Text & ";")
            If DrDeliver.HasRows = True Then
                DrDeliver.Read()
                If DrDeliver("CuLNo").ToString <> "0" And txtCuLNo.Text = "0" Then
                    Db.Execute("DELETE from CustomerLoan where CuLNo=" & DrDeliver("CuLNO").ToString, {}, AdminPer)
                ElseIf DrDeliver("CuLNo").ToString <> "0" And txtCuLNo.Text <> "0" Then
                    Db.Execute("Update CustomerLoan set CuLNo = " & DrDeliver("CuLNO").ToString &
                                                      "CuNo = " & CuNo &
                                                      ",CuLAmount = " & txtCuLAmount.Text &
                                                      ",DNo = " & FormParent.txtDNo.Text &
                                                      ",CuLDate = #" & FormParent.txtDDate.Value &
                                                      "# where CuLNo=" & DrDeliver("CuLNO").ToString, {}, AdminPer)
                    txtCuLNo.Text = DrDeliver("CuLNo").ToString
                ElseIf DrDeliver("CuLNo").ToString = "0" And txtCuLNo.Text <> "0" Then
                    Db.Execute("Insert into CustomerLoan(CuLNO,CuLAmount,CuNo,DNo,CulDate,Status) values(?NewKey?CustomerLoan?CuLNo?," &
                              txtCuLAmount.Text & "," & CuNo & "," & FormParent.txtDNo.Text & ",#" & FormParent.txtDDate.Value & "#,'Not Paid')", {}, AdminPer)
                End If
                Dim DR1 As OleDbDataReader = Db.GetDataReader("SELECT RepNo,REP.PNo,PCategory,PName,Qty,Status,REP.TNo, TName,PaidPrice from (((Repair REP INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where D.DNo=" & FormParent.txtDNo.Text)
                While DR1.Read
                    Db.Execute("Update Repair Set " & If(DR1("Status").ToString = "Repaired Delivered", "Status='Repaired Not Delivered'",
                              "Status='Returned Not Delivered'") & ",PaidPrice=0,DNo=0 Where DNo=?Key?DNo?", {}, AdminPer)
                End While
                Dim DRReturn As OleDbDataReader = Db.GetDataReader("SELECT RetNo,RepNo,RET.PNo,PCategory,PName,Qty,Status,RET.TNo, TName,PaidPrice from (((RETURN RET INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where D.DNo=" & FormParent.txtDNo.Text)
                While DRReturn.Read
                    Db.Execute($"Update `Return` Set {If(DRReturn("Status").ToString = "Repaired Delivered", "Status='Repaired Not Delivered'",
                              "Status='Returned Not Delivered'")},PaidPrice=0,DNo=0 Where DNo={FormParent.txtDNo.Text}", {}, AdminPer)
                End While
                Db.Execute($"DELETE FROM Deliver WHERE DNo={FormParent.txtDNo.Text}", {}, AdminPer)
            End If
        End If

    End Sub

    Private Sub SendDeliverEmail(DNo As String)
        Try
            If My.Settings.DeliveredEmailtoT = False Then Exit Sub

            Dim DRAutoD As OleDbDataReader = Db.GetDataReader($"SELECT RepNo,DDate, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TEmail, TName, Status from ((((Repair Rep Inner Join Deliver D On D.DNo=Rep.DNo) Inner Join Technician T On T.TNo = Rep.TNo) Left Join Product P On P.Pno = Rep.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail <> NULL and Status <> 'Returned Delivered' and TActive = Yes AND TBlockEmails <> Yes and D.DNo = {DNo}")
            While DRAutoD.Read()
                Db.Execute($"Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?, #{Now}#, @EMAIL, @SUBJECT, @BODY, 'Waiting');", {
                            New OleDbParameter("EMAIL", DRAutoD("TEmail")),
                            New OleDbParameter("SUBJECT", $"R{DRAutoD("RepNo")}: රු. {DRAutoD("PaidPrice")} දී Customer විසින් රුගෙන ගොස් ඇත."),
                            New OleDbParameter("BODY", GetEmailTemplate(RepairMode.Repair, DRAutoD))
                })
            End While
            DRAutoD = Db.GetDataReader($"SELECT RetNo,RepNo,DDate, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TEmail, TName, Status from ((((Return Ret Inner Join Deliver D On D.DNo=Ret.DNo) Inner Join Technician T On T.TNo = Ret.TNo) Left Join Product P On P.Pno = Ret.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail <> NULL And Status <>'Returned Delivered' and TActive = Yes AND TBlockEmails <> Yes and D.DNo = {DNo}")
            While DRAutoD.Read()
                Db.Execute($"Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?, #{Now}#, @EMAIL, @SUBJECT, @BODY, 'Waiting');", {
                            New OleDbParameter("EMAIL", DRAutoD("TEmail")),
                            New OleDbParameter("SUBJECT", $"RE{DRAutoD("RetNo")}: රු. {DRAutoD("PaidPrice")} දී Customer විසින් රුගෙන ගොස් ඇත."),
                            New OleDbParameter("BODY", GetEmailTemplate(RepairMode.ReRepair, DRAutoD))
                })
            End While
        Catch ex As Exception
            MsgBox("Technician හට Gmail එක යැවීමට අපොහොසත් විය." + vbCrLf + vbCrLf + "Error: " + ex.ToString, vbExclamation, "Technician හට Gmail එක යැවීමට නොහැක.")
        End Try
    End Sub

    Private Function GetEmailTemplate(Mode As RepairMode, DR As OleDbDataReader) As String
        Return $"<!DOCTYPE html PUBLIC "" -// W3C // DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd""><html dir=""ltr"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-Microsoft - com: Office : Office""><head><meta charset=""UTF-8""><meta content=""width=device-width, initial - Scale() = 1"" name=""viewport""><meta name=""x-apple-disable-message-reformatting""><meta http-equiv=""X-UA-Compatible"" content=""IE=edge""><meta content=""telephone=no"" name=""format-detection""><title></title><link href=""https:  //fonts.googleapis.com/css2?family=Jost&display=swap"" rel=""stylesheet""></head><body class=""body""><div dir=""ltr"" class=""es-wrapper-color""><table class=""es-wrapper"" width=""100%"" cellspacing=""0"" cellpadding=""0""><tbody><tr><td class=""esd-email-paddings"" valign=""top""><table class=""es-content esd-header-popover"" cellspacing=""0"" cellpadding=""0"" align=""center""><tbody><tr><td class=""esd-stripe"" align=""center""><table class=""es-content-body"" width=""600"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#D4D9FA"" align=""center"" style=""background-color:    #d4d9fa; background-image: url(https:   //fhudnxn.stripocdn.email/content/guids/CABINET_e18e8b6ad0d2f530731f1cc3bd27d47df9d75aa833914e627ec524bf07cda11b/images/14731345_rm222mind20_1_5nq.png); background-repeat: no-repeat; background-position: Right Bottom;"" background=""https: //fhudnxn.stripocdn.email/content/guids/CABINET_e18e8b6ad0d2f530731f1cc3bd27d47df9d75aa833914e627ec524bf07cda11b/images/14731345_rm222mind20_1_5nq.png"" esd-img-prev-position=""right bottom""><tbody><tr><td class=""esd-structure es-p30t es-p20b es-p20r es-p20l"" align=""left""><table cellspacing=""0"" cellpadding=""0"" width=""100%""><tbody><tr><td class=""es-m-p0r esd-container-frame"" width=""560"" valign=""top"" align=""center""><table width=""100%"" cellspacing=""0"" cellpadding=""0""><tbody><tr><td align=""left"" class=""esd-block-text""><h3 style=""font-size: 24px;"">{If(Mode = RepairMode.Repair, $"Repair No: {DR("RepNo")}", $"RERepair No: {DR("RetNo")}")} එක Customer විසින් රු. {DR("PaidPrice")}දී රුගෙන ගොස් ඇත.</h3></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table><table cellpadding=""0"" cellspacing=""0"" class=""es-content esd-footer-popover"" align=""center""><tbody><tr><td class=""esd-stripe"" align=""center""><table bgcolor=""#fffdf7"" class=""es-content-body"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600""><tbody><tr><td class=""esd-structure es-p20t es-p20r es-p20l"" align=""left""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td width=""560"" class=""esd-container-frame"" align=""center"" valign=""top""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""left"" class=""esd-block-text""><h2>REPAIR DETAILS</h2></td></tr><tr><td align=""left"" class=""esd-block-text es-p10t es-p10b""><ul>{If(Mode = RepairMode.ReRepair, $"<li>RERepair No: <strong>{DR("RetNo")}</strong></li>", "")}<li>Repair No: <strong>{DR("RepNo")}</strong></li><li>Delivered Date: <strong>{DR("DDate")}</strong></li><li>Customer Name: <strong>{DR("CuName")}</strong></li><li>Customer Telephone No1: <strong>{DR("CuTelNo1")}</strong></li><li>Product Category: <strong>{DR("PCategory")}</strong></li><li>Product Name: <strong>{DR("PName")}</strong></li><li>Qty: <strong>{DR("Qty")}</strong></li><li>Paid Charge: Rs. <strong>{DR("PaidPrice")}</strong></li><li>Technician Name: <strong>{DR("TName")}</strong></li><li>Status: <strong>{DR("Status")}</strong></li></ul></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td class=""esd-structure es-p20r es-p20l"" align=""left""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td width=""560"" class=""esd-container-frame"" align=""center"" valign=""top""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""center"" class=""esd-block-spacer es-p5t es-p5b"" style=""font-size0""><table border=""0"" width=""100%"" height=""100%"" cellpadding=""0"" cellspacing=""0""><tbody><tr><td style=""border-bottom: 1px solid #d4d9fa; background: unset; height: 1px; width: 100%; margin: 0px;""></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td class=""esd-structure es-p20r es-p20l"" align=""left""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td width=""560"" class=""esd-container-frame"" align=""center"" valign=""top""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""left"" class=""esd-block-text""><p>මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, කරුණාකර දත්ත කළමනාකරු අමතන්න</p></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td class=""esd-structure es-p20r es-p20l"" align=""left""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td width=""560"" class=""esd-container-frame"" align=""center"" valign=""top""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""center"" class=""esd-block-spacer es-p5t es-p5b"" style=""font-size:0""><table border=""0"" width=""100%"" height=""100%"" cellpadding=""0"" cellspacing=""0""><tbody><tr><td style=""border-bottom: 1px solid #d4d9fa; background: unset; height: 1px; width: 100%; margin: 0px;""></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td class=""esd-structure es-p20t es-p20r es-p20l"" align=""left"" bgcolor=""#ffffff"" style=""background-color: #ffffff;""><!--[if mso]><table width=""560"" cellpadding=""0"" cellspacing=""0""><tr><td width=""180"" valign=""top""><![endif]--><table cellpadding=""0"" cellspacing=""0"" class=""es-left"" align=""left""><tbody><tr><td width=""180"" class=""es-m-p0r es-m-p20b esd-container-frame"" valign=""top"" align=""center""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""center"" class=""esd-block-image"" style=""font-size: 0px;""><a target=""_blank""><img class=""adapt-img"" src=""https://lasertec.lk/wp-content/uploads/2024/05/cropped-36a55f9ce06860aa5d8f60002f8fc8a7.jpeg_120x120q75-1.webp"" alt="" style=""display: block;"" width=""120""></a></td></tr></tbody></table></td></tr></tbody></table><!--[if mso]></td><td width=""20""></td><td width=""360"" valign=""top""><![endif]--><table class=""es-right"" cellpadding=""0"" cellspacing=""0"" align=""right""><tbody><tr><td width=""360"" align=""left"" class=""esd-container-frame""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""left"" class=""esd-block-text es-p5""><p style=""line-height: 150%; font-size: 26px;""><strong>LASER Electronics</strong></p></td></tr></tbody></table></td></tr></tbody></table><!--[if mso]></td></tr></table><![endif]--></td></tr><tr><td class=""esd-structure es-p20b es-p20r es-p20l es-m-p40b es-m-p0r"" align=""left"" bgcolor=""#ffffff"" style=""background-color: #ffffff;""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td width=""560"" align=""left"" class=""esd-container-frame""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""left"" class=""esd-block-text es-p20t es-m-p20r es-m-p20l""><p style=""line-height: 200%;"">No. 157, Dippitigoda road, Dalugama, Kelaniya.<br>laserelectdigi@gmail.com<br>+94 11 2 986 759 | +94 71 4 315 393</p></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></div></body></html>"
    End Function
End Class
