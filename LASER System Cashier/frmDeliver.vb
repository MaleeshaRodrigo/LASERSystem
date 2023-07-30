Imports System.Data.OleDb
Imports System.Threading

Public Class frmDeliver
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
        Call cmdNew_Click(Nothing, Nothing)
        txtDDate.Value = Date.Today
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmDeliver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        grdRepair.Focus()
    End Sub

    Private Sub frmDeliver_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If pnlDSaveFinal.Visible = True And cmdReceipt.Enabled = True Then
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

    Private Sub cmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        Call CmbDropDown(cmbCuName, "Select CuName from Customer Group by CuName;", "CuName")
    End Sub

    Private Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("SELECT * from Customer where CuName='" & cmbCuName.Text & "';", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            txtCuTelNo1.Tag = "1"
            DR.Read()
            txtCuTelNo1.Text = DR("CuTelNo1").ToString
            txtCuTelNo2.Text = DR("CuTelNo2").ToString
            txtCuTelNo3.Text = DR("CuTelNo3").ToString
        End If
        txtCuTelNo1.Tag = ""
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmDeliver_Leave(sender, e)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Cursor = Cursors.WaitCursor
        Call AutomaticPrimaryKey(txtDNo, "SELECT top 1 DNo from Deliver ORDER BY DNo Desc;", "DNo")
        For Each obj As Object In {cmbCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3, txtDRemarks}
            obj.text = ""
        Next
        grdRepair.Rows.Clear()
        grdRERepair.Rows.Clear()
        For Each obj As Object In {txtGrandTotal, txtCAmount, txtCBalance, txtCReceived, txtCPInvoiceNo, txtCPAmount,
            txtCuLAmount}
            obj.text = "0"
        Next

        Dim DT0 As New DataTable
        Dim grdtxt1 As DataGridViewComboBoxColumn = grdRepair.Columns.Item(5)
        Dim DA0 As New OleDbDataAdapter("Select TName from Technician Where TActive=Yes group by TName;", CNN)
        DA0.Fill(DT0)
        Dim items = DT0.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        grdtxt1.DataSource = items

        grdtxt1 = grdRERepair.Columns.Item(6)
        grdtxt1.DataSource = items

        cmdSave.Enabled = True
        Call AutomaticPrimaryKey(txtCuLNo, "SELECT top 1 CuLNo from CustomerLoan ORDER BY CuLNo Desc;", "CuLNo")
        grdRepair.Focus()
        grdRepair.CurrentCell = grdRepair.Item(0, grdRepair.Rows.Count - 1)
        cmdCancel_Click(sender, e)
        Cursor = Cursors.Default
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        grdRepair.EndEdit()
        grdRERepair.EndEdit()
        cmdSave.Focus()

        If grdRepair.Rows.Count < 2 And grdRERepair.Rows.Count < 2 Then
            MsgBox("ඔබ තවමත් කිසිදු Repair එකක් හෝ RERepair එකක් ඇතුලත් කර නොමැත. කරුණාකර Repair එකක් හෝ RERepair එකක් ඇතුලත් කර නැවත උත්සහ කරන්න.", vbExclamation + vbOKOnly)
            grdRepair.Focus()
            Exit Sub
        End If
        For Each Row As DataGridViewRow In grdRepair.Rows
            If Row.Index = grdRepair.Rows.Count - 1 Then Continue For
            If Row.Cells(0).Value.ToString = "" Then
                grdRepair.Rows.RemoveAt(Row.Index)
            End If
            If Row.Cells(5).Value.ToString = "" Then
                MsgBox("කරුණාකර Repair No: " & Row.Cells(0).Value & " යන තීරුවේ Technician ව තොරා ගන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            If Row.Cells(6).Value.ToString = "" Then
                MsgBox("කරුණාකර Repair No: " & Row.Cells(0).Value & " යන තීරුවේ Status එක තෝරා ගන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            CMD = New OleDb.OleDbCommand("Select TNo from Technician Where TName='" & Row.Cells(5).Value & "'", CNN)
            DR = CMD.ExecuteReader
            If DR.HasRows = False Then
                MsgBox("Repair No: " & Row.Cells(0).Value & " යන තීරුවෙ Technician ව System එක තුල නොපවතියි. කරුණාකර නැවත පරික්ෂා කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
        Next
        For Each Row As DataGridViewRow In grdRERepair.Rows
            If Row.Index = grdRERepair.Rows.Count - 1 Then Continue For
            If Row.Cells(0).Value = "" Then
                grdRERepair.Rows.RemoveAt(Row.Index)
            End If
            If Row.Cells(6).Value.ToString = "" Then
                MsgBox("කරුණාකර Repair No: " & Row.Cells(0).Value & " යන තීරුවේ Technician ව තොරා ගන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            If Row.Cells(7).Value.ToString = "" Then
                MsgBox("කරුණාකර Repair No: " & Row.Cells(0).Value & " යන තීරුවේ Status එක තෝරා ගන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            CMD = New OleDb.OleDbCommand("Select TNo from Technician Where TName='" & Row.Cells(6).Value & "'", CNN)
            DR = CMD.ExecuteReader
            If DR.HasRows = False Then
                MsgBox("Repair No: " & Row.Cells(0).Value & " යන තීරුවෙ Technician ව System එක තුල නොපවතියි. කරුණාකර නැවත පරික්ෂා කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
        Next

        CalculateGrandTotal()
        If txtDDate.Value.Date <> Today.Date And MdifrmMain.tslblUserType.Text <> "Admin" Then
            Me.AcceptButton = cmdNotReceipt
            chkCashDrawer.Checked = False
            chkCashDrawer.Enabled = False
            cmdReceipt.Enabled = False
        Else
            Me.AcceptButton = cmdReceipt
            cmdReceipt.Enabled = True
            chkCashDrawer.Enabled = False
        End If
        chkCashDrawer.Checked = My.Settings.CashDrawer
        pnlDSaveFinal.Dock = DockStyle.Fill
        pnlDSaveFinal.BringToFront()
        grpPaymentInfo.Visible = False
        pnlDSaveFinal.Visible = True
        grpPaymentInfo.Top = (pnlDSaveFinal.Height / 2) - (grpPaymentInfo.Height / 2)
        grpPaymentInfo.Left = (pnlDSaveFinal.Width / 2) - (grpPaymentInfo.Width / 2)
        MenuStrip.Enabled = False
        grpPaymentInfo.Visible = True
        txtCReceived.Focus()
    End Sub

    Private Sub cmdReceipt_Click(sender As Object, e As EventArgs) Handles cmdReceipt.Click, cmdNotReceipt.Click
        If SaveDeliver() = True Then
            Dim DNo As Integer = txtDNo.Text
            Dim threadDeliver As New Thread(Sub()
                                                If sender Is cmdReceipt Then PrintDeliveryReceipt(DNo, True)
                                                AutomatedDeliver(txtDNo.Text)
                                            End Sub)
            threadDeliver.Name = "showDeliverReceiptReport"
            threadDeliver.IsBackground = False
            threadDeliver.Priority = ThreadPriority.Highest
            threadDeliver.SetApartmentState(ApartmentState.STA)
            threadDeliver.Start()
            Call cmdNew_Click(sender, e)
        End If
    End Sub

    Public Sub PrintDeliveryReceipt(DNo As Integer, Optional boolPrint As Boolean = False)
        Try
            Dim RPT As New rptDeliver
            Dim frm As New frmReport
            Dim DT1 As New DataTable
            Dim DS1 As New DataSet
            Dim DA1 As New OleDb.OleDbDataAdapter("SELECT Repair.RepNo,Repair.PNo,Product.PCategory,Product.PName,Repair.Qty,Repair.PaidPrice,Repair.TNo from Repair,Product," &
                                              "Deliver where Deliver.DNO = Repair.DNo And Repair.PNo = Product.PNo And Deliver.DNo = " & DNo & ";", CNN)
            DA1.Fill(DS1, "Repair")
            DA1.Fill(DS1, "Product")
            RPT.Subreports.Item("rptDeliverRepair.rpt").SetDataSource(DS1)
            Dim DT2 As New DataTable
            Dim DS2 As New DataSet
            Dim DA2 As New OleDb.OleDbDataAdapter("Select Return.RetNo,Return.RepNo,Return.PNo,Product.PCategory,Product.Pname,Return.Qty,Return.PaidPrice,Return.TNo from " &
                                              "Return,Product,Deliver where Deliver.DNO = Return.DNo And Return.PNo = Product.PNo And Deliver.DNO  = " & DNo & ";", CNN)
            DA2.Fill(DS2, "Return")
            DA2.Fill(DS2, "Product")
            RPT.Subreports.Item("rptDeliverReturn.rpt").SetDataSource(DS2)
            Dim DT3 As New DataTable
            Dim DS3 As New DataSet
            Dim DA3 As New OleDb.OleDbDataAdapter("SELECT Deliver.DNo, Deliver.DDate,Deliver.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3," &
                                              "Deliver.DGrandTotal,Deliver.CReceived,Deliver.CBalance,Deliver.CAmount,Deliver.CPInvoiceNO,Deliver.CPAmount,Deliver.CuLNo," &
                                              "Deliver.CuLAmount,Deliver.DRemarks from Deliver,Customer where Deliver.CuNo = Customer.CuNo And Deliver.DNo = " & DNo &
                                              ";", CNN)
            DA3.Fill(DS3, "Deliver")
            DA3.Fill(DS3, "Customer")
            RPT.SetDataSource(DS3)
            RPT.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text.ToString) 'Set Cashier Name to Parameter Value
            frm.ReportViewer.ReportSource = RPT
            If boolPrint Then
                Dim c As Integer
                Dim doctoprint As New System.Drawing.Printing.PrintDocument()
                doctoprint.PrinterSettings.PrinterName = My.Settings.BillPrinterName
                Dim rawKind As Integer
                For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
                    If doctoprint.PrinterSettings.PaperSizes(c).PaperName = My.Settings.BillPrinterPaperName Then
                        rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                        Exit For
                    End If
                Next
                RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                RPT.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
                RPT.PrintToPrinter(1, False, 1, 1)
            End If
            Application.Run(frm)
        Catch ex As Exception
            MsgBox("යම් ගැටලුවක් පැන නැගී ඇති බැවින් Deliver Receipt එක Print කිරිමට අපොහොසත් විය." + vbCrLf + vbCrLf + "Error: " + ex.ToString, vbExclamation, "Deliver Receipt එක Print කිරිමට නොහැක.")
        End Try
    End Sub

    Private Function SaveDeliver() As Boolean
        SaveDeliver = True
        If txtGrandTotal.Text <> Val(txtCAmount.Text) + Val(txtCPAmount.Text) + Val(txtCuLAmount.Text) Then
            MsgBox("Grand Total Field එක Cash Amount, Card Payment Amount සහ Customer Loan Amount එකට සමාන නැත. කරුණාකර එය නැවත පරිකෂා කරන්න.", vbExclamation + vbOKOnly)
            Return False
            Exit Function
        End If
        Cursor = Cursors.WaitCursor
        'Send Admin to Verify the delivery data
        Dim AdminPer As New AdminPermission()
        AdminPer.Keys.Add("DNo", "?NewKey?Deliver?DNo?")
        Dim DNo As String = "?Key?DNo?"
        If txtDDate.Value.Date = Today.Date Then
            txtDDate.Value = DateAndTime.Now
        ElseIf MdifrmMain.tslblUserType.Text <> "Admin" Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = $"Date එක අද දිනයට වෙනස් Delivery එකක් Cashier කෙනෙකු වන {MdifrmMain.tslblUserName.Text} 
විසින් ඇතුලත් කෙරුණි."
        End If
        If cmdSave.Text = "Edit" And MdifrmMain.tslblUserType.Text <> "Admin" Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = $"Deliver එකක් Cashier කෙනෙකු වන {MdifrmMain.tslblUserName.Text} විසින් වෙනස් කෙරුණි."
        End If
        If (Val(txtCAmount.Text) > 0 Or Val(txtCPAmount.Text) > 0) And chkCashDrawer.Checked = True Then OpenCashdrawer()
        AutomaticPrimaryKey(txtCuLNo, "Select Top 1 CulNo from CustomerLoan order by CuLNo Desc;", "CuLNo")
        If txtCAmount.Text = "" Or txtCAmount.Text = "0" Then
            txtCAmount.Text = "0"
            txtCReceived.Text = "0"
            txtCBalance.Text = "0"
        End If
        If txtCPAmount.Text = "" Or txtCPAmount.Text = "0" Then
            txtCPAmount.Text = "0"
            txtCPInvoiceNo.Text = "0"
        End If
        If txtCuLAmount.Text = "" Or txtCuLAmount.Text = "0" Then
            txtCuLAmount.Text = "0"
            txtCuLNo.Text = "0"
        End If
        grdRepair.EndEdit()
        grdRERepair.EndEdit()
        cmdSave.Focus()
        CMD = New OleDb.OleDbCommand("Select * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text & "' and CuTelNo2 ='" &
                                     txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "'", CNN)
        DR = CMD.ExecuteReader
        'Customer Management
        Dim CuNo As String
        If DR.HasRows = True Then
            DR.Read()
            CuNo = DR("CuNo").ToString
        Else
            AdminPer.Keys.Add("CuNo", "?NewKey?Customer?CuNo?")
            CuNo = "?Key?CuNo?"
            CMDUPDATE("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & cmbCuName.Text & "','" & txtCuTelNo1.Text &
                      "','" & txtCuTelNo2.Text & "','" & txtCuTelNo3.Text & "');", AdminPer)
        End If

        '-------------Edit Mode------------------------------------------------
        If cmdSave.Text = "Edit" Then
            AdminPer.Keys.Item("DNo") = txtDNo.Text
            CMD = New OleDb.OleDbCommand("SELECT * from Deliver where DNo=" & txtDNo.Text & ";", CNN)
            DR = CMD.ExecuteReader()
            If DR.HasRows = True Then
                DR.Read()
                If DR("CuLNo").ToString <> "0" And txtCuLNo.Text = "0" Then
                    CMDUPDATE("DELETE from CustomerLoan where CuLNo=" & DR("CuLNO").ToString, AdminPer)
                ElseIf DR("CuLNo").ToString <> "0" And txtCuLNo.Text <> "0" Then
                    CMDUPDATE("Update CustomerLoan set CuLNo = " & DR("CuLNO").ToString &
                                                      "CuNo = " & CuNo &
                                                      ",CuLAmount = " & txtCuLAmount.Text &
                                                      ",DNo = " & txtDNo.Text &
                                                      ",CuLDate = #" & txtDDate.Value &
                                                      "# where CuLNo=" & DR("CuLNO").ToString, AdminPer)
                    txtCuLNo.Text = DR("CuLNo").ToString
                ElseIf DR("CuLNo").ToString = "0" And txtCuLNo.Text <> "0" Then
                    CMDUPDATE("Insert into CustomerLoan(CuLNO,CuLAmount,CuNo,DNo,CulDate,Status) values(?NewKey?CustomerLoan?CuLNo?," &
                              txtCuLAmount.Text & "," & CuNo & "," & txtDNo.Text & ",#" & txtDDate.Value & "#,'Not Paid')", AdminPer)
                End If
                Dim CMD1 As New OleDb.OleDbCommand("SELECT RepNo,REP.PNo,PCategory,PName,Qty,Status,REP.TNo, TName,PaidPrice from " &
                                                    "(((Repair REP INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) LEFT JOIN Technician T " &
                                                    "ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where D.DNo=" & txtDNo.Text, CNN)
                Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader
                While DR1.Read
                    CMDUPDATE("Update Repair Set " & If(DR1("Status").ToString = "Repaired Delivered", "Status='Repaired Not Delivered'",
                              "Status='Returned Not Delivered'") & ",PaidPrice=0,DNo=0 " &
                              "Where DNo=?Key?DNo?", AdminPer)
                End While
                CMD1 = New OleDb.OleDbCommand("SELECT RetNo,RepNo,RET.PNo,PCategory,PName,Qty,Status,RET.TNo, TName,PaidPrice from " &
                                                "(((RETURN RET INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) LEFT JOIN Technician T " &
                                                "ON T.TNO = RET.TNO) LEFT JOIN DELIVER D ON D.DNO = RET.DNO) Where D.DNo=" & txtDNo.Text, CNN)
                DR1 = CMD1.ExecuteReader
                While DR1.Read
                    CMDUPDATE($"Update `Return` Set {If(DR1("Status").ToString = "Repaired Delivered", "Status='Repaired Not Delivered'",
                              "Status='Returned Not Delivered'")},PaidPrice=0,DNo=0 Where DNo={txtDNo.Text}", AdminPer)
                End While
                CMDUPDATE($"DELETE FROM Deliver WHERE DNo={txtDNo.Text}", AdminPer)
            End If
        End If
        '---------------Exit Edit Mode-----------------------------------------
        CMDUPDATE("Insert into Deliver(DNo,DDate,Cuno,DGrandTotal,CAmount,CReceived,CBalance,CPINvoiceNo,CPAmount,CuLNO,CuLAmount,DRemarks) " &
                  "Values(" & DNo & ",#" & txtDDate.Value & "#," & CuNo & "," & txtGrandTotal.Text &
                  "," & txtCAmount.Text & "," &
                  txtCReceived.Text & "," & txtCBalance.Text & "," & txtCPInvoiceNo.Text & "," & txtCPAmount.Text & "," & txtCuLNo.Text & "," &
                  txtCuLAmount.Text & ",'" & txtDRemarks.Text & "');", AdminPer)
        If txtCuLAmount.Text <> "0" Then
            CMDUPDATE("Insert into CustomerLoan(CuLNo,CuLDate,CuNO,CuLAmount,DNo,Status) Values(" &
                      "?NewKey?CustomerLoan?CuLNo?,#" & txtDDate.Value & "#," &
                      CuNo & "," & txtCuLAmount.Text & "," & DNo & ",'Not Paid')", AdminPer)
        End If
        If grdRepair.Rows.Count > 1 Then
            For Each Row1 As DataGridViewRow In grdRepair.Rows
                If Row1.Index = grdRepair.Rows.Count - 1 Then Continue For
                CMD = New OleDb.OleDbCommand("Select Status,RepNo from Repair where RepNo=" & Row1.Cells(0).Value, CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows = True Then
                    DR.Read()
                    If DR("Status").ToString = "Received" Or DR("Status").ToString = "Hand Over to Technician" Or
                        DR("Status").ToString = "Repairing" Then
                        CMDUPDATE("Update Repair set RepDate = #" & txtDDate.Value &
                                  "#,Charge=" & Row1.Cells(4).Value & " where RepNo= " & Row1.Cells(0).Value, AdminPer)
                    End If
                End If
                CMDUPDATE("Update Repair set PaidPrice = " & Row1.Cells(4).Value.ToString &
                                             ",TNo = " & GetStrfromRelatedfield("Select TNo from Technician Where TName='" &
                                             Row1.Cells(5).Value & "'") &
                                             ",Status='" & Row1.Cells(6).Value.ToString & "'" &
                                             ",DNo = " & DNo & " where RepNo= " & Row1.Cells(0).Value.ToString, AdminPer)
            Next
        End If
        If grdRERepair.Rows.Count > 1 Then
            For Each Row As DataGridViewRow In grdRERepair.Rows
                If Row.Index = grdRERepair.Rows.Count - 1 Then Continue For
                CMD = New OleDb.OleDbCommand("Select Status,RetNo from Return where RetNo=" & Row.Cells(0).Value, CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows = True Then
                    DR.Read()
                    If DR("Status").ToString = "Received" Or DR("Status").ToString = "Hand Over to Technician" Or DR("Status").ToString = "Repairing" Then
                        CMDUPDATE("Update `Return` set RetRepDate = #" & txtDDate.Value &
                                "#,Charge=" & Row.Cells(5).Value.ToString & " where RepNo= " & Row.Cells(0).Value.ToString, AdminPer)
                    End If
                End If
                CMDUPDATE("Update `Return` set PaidPrice = " & Row.Cells(5).Value.ToString &
                        ",TNo = " & GetStrfromRelatedfield("Select TNo from Technician Where TName='" & Row.Cells(6).Value & "'") &
                        ",Status='" & Row.Cells(7).Value.ToString & "'" &
                        ",DNo = " & DNo & " where RetNo= " & Row.Cells(0).Value.ToString, AdminPer)
            Next
        End If
    End Function

    Private Sub AutomatedDeliver(DNo As String)
        Try
            If My.Settings.DeliveredEmailtoT = False Then Exit Sub
            Dim CMDAutoD As New OleDbCommand("SELECT RepNo,DDate, TEmail,TName, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TName, Status " &
                                                  "from ((((Repair Rep Inner Join Deliver D On D.DNo=Rep.DNo) Inner Join " &
                                                  "Technician T On T.TNo = Rep.TNo) Left Join Product P On P.Pno = Rep.PNo) " &
                                                  "Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail <> NULL and " &
                                                  "Status <>'Returned Delivered' and TBlockEmails <> Yes and D.DNo =" &
                                                  DNo, CNN)
            Dim DRAutoD As OleDbDataReader = CMDAutoD.ExecuteReader()
            While DRAutoD.Read()
                CMDUPDATE("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?,#" & DateAndTime.Now &
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
                                    "මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, " &
                                    "කරුණාකර දත්ත කළමනාකරු අමතන්න"",'Waiting');")
            End While
            CMDAutoD = New OleDbCommand("SELECT RetNo,RepNo,DDate, TEmail,TName, CuName, CuTelNo1, PCategory, PName, Qty, PaidPrice, TName, Status " &
                                        "from ((((Return Ret Inner Join Deliver D On D.DNo=Ret.DNo) Inner Join Technician T On T.TNo = Ret.TNo) " &
                                        " Left Join Product P On P.Pno = Ret.PNo) Left Join Customer Cu On Cu.CuNo = D.CuNo) Where TEmail <> NULL " &
                                        "and Status <>'Returned Delivered' and TBlockEmails <> Yes and D.DNo =" &
                                              DNo, CNN)
            DRAutoD = CMDAutoD.ExecuteReader()
            While DRAutoD.Read()
                CMDUPDATE("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status) Values(?NewKey?Mail?MailNo?,#" & DateAndTime.Now &
                                  "#,'" & DR("TEmail").ToString & "','RERepair No:  " + DRAutoD("RetNo").ToString + " එක Customer විසින් රු." +
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
                                    "මෙම Message එක ස්වයංක්‍රීයව LASER System එකෙන් පැමිණෙන්නක් බැවින් ඉහත දත්ත සඳහා යම් ගැටලුවක් පවතියි නම්, " &
                                    "කරුණාකර දත්ත කළමනාකරු අමතන්න"",'Waiting');")
            End While
        Catch ex As Exception
            MsgBox("Technician හට Gmail එක යැවීමට අපොහොසත් විය. කරුණාකර Internet Connection එක පරික්ෂා කරන්න." + vbCrLf + vbCrLf + "Error: " + ex.ToString, vbExclamation, "Technician හට Gmail එක යැවීමට නොහැක.")
        End Try
    End Sub

    Public Sub GrdRepair_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepair.CellEndEdit
        Select Case e.ColumnIndex
            Case 0
                If grdRepair.CurrentCell Is Nothing Or grdRepair.CurrentRow.Index = Int(grdRepair.Rows.Count) - 1 Then Exit Sub
                If grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value Is Nothing Then
                    grdRepair.Rows.RemoveAt(grdRepair.CurrentCell.RowIndex)
                    Exit Sub
                End If
                Dim CMDD As New OleDb.OleDbCommand("Select RepNo,PCategory,PName,PMOdelNO,PSerialNo,PDetails,Qty,Charge,TName,Status,CuName,CuTelNo1,CuTelNo2,CuTelNo3 " &
                                             "from ((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT P ON P.PNO = REP.PNO) " &
                                             "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) Where RepNo = " &
                                             grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value, CNN)
                Dim DRD As OleDbDataReader = CMDD.ExecuteReader()
                If DRD.HasRows = True Then
                    DRD.Read()
                    If DRD("Status").ToString = "Repaired Delivered" Or DRD("Status").ToString = "Returned Delivered" Then
                        If MsgBox("මෙම Repair එක දැනටමත් Customer විසින් රැගෙන ගොස් ඇත." + vbCrLf + "ඔබට එම Repair එක විවෘත කිරිමට අවශ්‍යද?",
                                  vbInformation + vbYesNo) = vbYes Then
                            Dim frm As New frmRepair
                            With frm
                                .tabRepair.SelectTab(0)
                                .Show(Me)
                                .cmbRepNo.Text = grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value
                                .CmbRepNo_SelectedIndexChanged(sender, e)
                            End With
                        End If
                        grdRepair.Rows.RemoveAt(grdRepair.CurrentCell.RowIndex)
                    ElseIf DRD("Status").ToString = "Canceled" Then
                        If MsgBox("මෙම Repair එක Canceled කර ඇත." + vbCrLf + "ඔබට එම Repair එක විවෘත කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
                            Dim frm As New frmRepair
                            With frm
                                .tabRepair.SelectTab(0)
                                .Show(Me)
                                .cmbRepNo.Text = grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value
                                .CmbRepNo_SelectedIndexChanged(sender, e)
                            End With
                        End If
                        grdRERepair.Rows.RemoveAt(grdRERepair.CurrentCell.RowIndex)
                    Else
                        cmbCuName.Text = DRD("CuName").ToString
                        txtCuTelNo1.Text = DRD("CuTelNo1").ToString
                        txtCuTelNo2.Text = DRD("CuTelNo2").ToString
                        txtCuTelNo3.Text = DRD("CuTElno3").ToString
                        grdRepair.Item(1, grdRepair.CurrentCell.RowIndex).Value = DRD("PCategory").ToString
                        grdRepair.Item(2, grdRepair.CurrentCell.RowIndex).Value = DRD("PName").ToString
                        grdRepair.Item(3, grdRepair.CurrentCell.RowIndex).Value = DRD("Qty").ToString
                        grdRepair.Item(4, grdRepair.CurrentCell.RowIndex).Value = DRD("Charge").ToString
                        'If DR("TName").ToString = "" Then
                        '    Dim CMD1 As New OleDb.OleDbCommand("SELECT TOP 1 TNAME, COUNT(TName) from ((Repair Rep Inner Join Product P on P.PNo = Rep.PNo) 
                        '                                        Inner Join Technician T on T.TNo = Rep.TNo) WHERE PCATEGORY = '" & DR("PCategory").ToString & "' GROUP BY TNAME " &
                        '                                        "ORDER BY COUNT(TNAME) DESC;", CNN)
                        '    Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader
                        '    If DR1.HasRows Then
                        '        DR1.Read()
                        '        grdRepair.Item(5, grdRepair.CurrentCell.RowIndex).Value = DR1("TName").ToString
                        '    End If
                        '    CMD1.Cancel()
                        '    DR1.Close()
                        'Else
                        grdRepair.Item(5, grdRepair.CurrentCell.RowIndex).Value = DRD("TName").ToString
                        'End If
                        If DRD("Status").ToString = "Returned Not Delivered" Then
                            grdRepair.Item(6, grdRepair.CurrentCell.RowIndex).Value = "Returned Delivered"
                        Else
                            grdRepair.Item(6, grdRepair.CurrentCell.RowIndex).Value = "Repaired Delivered"
                        End If
                        For Each row As DataGridViewRow In grdRepair.Rows
                            If row.Index = grdRepair.CurrentCell.RowIndex Then Continue For
                            If grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value = row.Cells(0).Value Then
                                grdRepair.Rows.RemoveAt(row.Index)
                            End If
                        Next
                    End If
                Else
                    grdRepair.Rows.RemoveAt(grdRepair.CurrentCell.RowIndex)
                End If
                If grdRepair.CurrentCell IsNot grdRepair.Item(0, grdRepair.Rows.Count - 1) Then grdRepair.CurrentCell = grdRepair.Item(0, grdRepair.Rows.Count - 1)
            Case 4
                If grdRepair.Item(4, e.RowIndex).Value = "0" Then
                    grdRepair.Item(6, grdRepair.CurrentCell.RowIndex).Value = "Returned Delivered"
                Else
                    grdRepair.Item(6, grdRepair.CurrentCell.RowIndex).Value = "Repaired Delivered"
                End If
        End Select
    End Sub

    Private Sub grdRepair_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepair.EditingControlShowing
        Dim autoText As TextBox
        Dim DataCollection As New AutoCompleteStringCollection()
        If TypeOf e.Control Is TextBox Then
            Dim txtKeyPress As TextBox = e.Control
            'remove any existing handler
            RemoveHandler txtKeyPress.KeyPress, AddressOf txtKeyPress_Keypress
            AddHandler txtKeyPress.KeyPress, AddressOf txtKeyPress_Keypress
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            autoText = TryCast(e.Control, TextBox)
            autoText.AutoCompleteCustomSource = Nothing
            autoText.AutoCompleteSource = AutoCompleteSource.None
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If
        Select Case grdRepair.CurrentCell.ColumnIndex
            Case 0
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select RepNo from Repair where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' and Status <> 'Canceled' order by RepNo Desc;", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("REpNo").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 3
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 4
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub txtKeyPress_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub grdRERepair_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRERepair.EditingControlShowing
        Dim autoText As TextBox
        Dim DataCollection As New AutoCompleteStringCollection()
        If TypeOf e.Control Is TextBox Then
            Dim txtKeyPress As TextBox = e.Control
            'remove any existing handler
            RemoveHandler txtKeyPress.KeyPress, AddressOf txtKeyPress_Keypress
            AddHandler txtKeyPress.KeyPress, AddressOf txtKeyPress_Keypress
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            autoText = TryCast(e.Control, TextBox)
            autoText.AutoCompleteCustomSource = Nothing
            autoText.AutoCompleteSource = AutoCompleteSource.None
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If
        Select Case grdRERepair.CurrentCell.ColumnIndex
            Case 0
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select RetNo from REturn order by RetNo Desc;", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("RetNo").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 1
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select REPNO from Return order by REpNo Desc;", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("RepNo").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 4
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 5
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub

    Public Sub grdRERepair_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRERepair.CellEndEdit
        Select Case e.ColumnIndex
            Case 0
                If grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value = "" Then
                    grdRERepair.Rows.RemoveAt(grdRERepair.CurrentCell.RowIndex)
                    Exit Sub
                End If
                CMD = New OleDb.OleDbCommand("Select RetNo,RepNo,PCategory,PName,PMOdelNO,PSerialNo,PDetails,Qty,Charge,TName,Status,CuName,CuTelNo1,CuTelNo2,CuTelNo3 from ((((Return RET INNER JOIN RECEIVE R ON R.RNO = RET.RNO) INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) " &
                                             "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) Where RetNo = " & grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value, CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    DR.Read()
                    If DR("Status").ToString = "Repaired Delivered" Or DR("Status").ToString = "Returned Delivered" Then
                        If MsgBox("මෙම RERepair එක දැනටමත් Customer විසින් රැගෙන ගොස් ඇත." + vbCrLf + "ඔබට එම RERepair එක විවෘත කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
                            Dim frm As New frmRepair
                            With frm
                                .tabRepair.SelectTab(1)
                                .Show(Me)
                                .cmbRetNo.Text = grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value
                                .CmbRetNo_SelectedIndexChanged(sender, e)
                            End With
                        End If
                        grdRERepair.Rows.RemoveAt(grdRERepair.CurrentCell.RowIndex)
                    ElseIf DR("Status").ToString = "Canceled" Then
                        If MsgBox("මෙම RERepair එක Canceled කර ඇත." + vbCrLf + "ඔබට එම RERepair එක විවෘත කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
                            Dim frm As New frmRepair
                            With frm
                                .tabRepair.SelectTab(1)
                                .Show(Me)
                                .cmbRetNo.Text = grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value
                                .CmbRetNo_SelectedIndexChanged(sender, e)
                            End With
                        End If
                        grdRERepair.Rows.RemoveAt(grdRERepair.CurrentCell.RowIndex)
                    Else
                        cmbCuName.Text = DR("CuName").ToString
                        txtCuTelNo1.Text = DR("CuTelNo1").ToString
                        txtCuTelNo2.Text = DR("CuTelNo2").ToString
                        txtCuTelNo3.Text = DR("CuTElno3").ToString
                        grdRERepair.Item(1, grdRERepair.CurrentCell.RowIndex).Value = DR("Repno").ToString
                        grdRERepair.Item(2, grdRERepair.CurrentCell.RowIndex).Value = DR("PCategory").ToString
                        grdRERepair.Item(3, grdRERepair.CurrentCell.RowIndex).Value = DR("PName").ToString
                        grdRERepair.Item(4, grdRERepair.CurrentCell.RowIndex).Value = DR("Qty").ToString
                        grdRERepair.Item(5, grdRERepair.CurrentCell.RowIndex).Value = DR("Charge").ToString
                        grdRERepair.Item(6, grdRERepair.CurrentCell.RowIndex).Value = DR("TName").ToString
                        If DR("Status").ToString = "Returned Not Delivered" Then
                            grdRERepair.Item(7, grdRERepair.CurrentCell.RowIndex).Value = "Returned Delivered"
                        Else
                            grdRERepair.Item(7, grdRERepair.CurrentCell.RowIndex).Value = "Repaired Delivered"
                        End If
                        For Each row As DataGridViewRow In grdRERepair.Rows
                            If row.Index = grdRERepair.CurrentCell.RowIndex Then Continue For
                            If grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value = row.Cells(0).Value Then
                                grdRERepair.Rows.RemoveAt(row.Index)
                            End If
                            Exit Sub
                        Next
                    End If
                End If
                grdRepair.CurrentCell = grdRepair.Item(0, grdRepair.Rows.Count - 1)
            Case 1
                CMD = New OleDb.OleDbCommand("Select RepNo,RetNo,Status from Return Where RepNo=" & grdRERepair.Item(1, e.RowIndex).Value, CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows = True Then
                    DR.Read()
                    grdRERepair.Item(0, e.RowIndex).Value = DR("RetNo").ToString
                    Dim E1 As New DataGridViewCellEventArgs(0, e.RowIndex)
                    grdRERepair_CellEndEdit(sender, E1)
                Else
                    If MsgBox("එම Repair එක සඳහා RERepair එකක් විවෘත කර නොමැත. ඔබට මෙය ඇතුලත් කිරිමට අවශ්‍ය ද?", vbYesNo + vbInformation) = vbYes Then
                        Dim frm As New frmReceive
                        frm.Name = "frmReceive" + NextfrmNo(frmReceive).ToString
                        frm.Caller = Me.Name
                        frm.Show(Me)
                        frm.grdReRepair.Rows.Add("", grdRERepair.Item(1, e.RowIndex).Value)
                        frm.grdReRepair_UserAddedRow(sender, Nothing)
                        Dim E1 As New DataGridViewCellEventArgs(1, frm.grdReRepair.Rows.Count - 2)
                        frm.GrdReRepair_CellEndEdit(sender, E1)
                    End If
                End If
                grdRepair.CurrentCell = grdRepair.Item(0, grdRepair.Rows.Count - 1)
        End Select
    End Sub

    Private Sub SearchRepairsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchRepairsToolStripMenuItem.Click
        Dim frm As New frmRepair
        If Me.ActiveControl Is grdRepair Then
            frm.Tag = "DeliverRepair"
            frm.tabRepair.SelectTab(0)
            frm.cmbRepNo.Text = grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value
            frm.CmbRepNo_SelectedIndexChanged(sender, e)
            frm.cmbRepNo.Focus()
        ElseIf Me.ActiveControl Is grdRERepair Then
            frm.Tag = "DeliverReRepair"
            frm.tabRepair.SelectTab(1)
            frm.cmbRetNo.Text = grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value
            frm.CmbRetNo_SelectedIndexChanged(sender, e)
            frm.cmbRetNo.Focus()
        End If
        frm.Show(Me)
    End Sub

    Private Sub CalculateGrandTotal()
        txtSubTotal.Text = "0"
        txtRepAdvanced.Text = "0"
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index >= grdRepair.Rows.Count - 1 Then Continue For
            txtSubTotal.Text += Val(row.Cells(4).Value)
            For Each str As String In GetArrayfromSQL("Select Amount from RepairAdvanced Where RepNo=" &
                                                      row.Cells(0).Value, "Amount")
                txtRepAdvanced.Text += Val(str)
            Next
        Next
        For Each row As DataGridViewRow In grdRERepair.Rows
            If row.Index >= grdRERepair.Rows.Count - 1 Then Continue For
            txtSubTotal.Text += Val(row.Cells(5).Value)
            For Each str As String In GetArrayfromSQL("Select Amount from RepairAdvanced Where RetNo=" &
                                                      row.Cells(0).Value, "Amount")
                txtRepAdvanced.Text += Val(str)
            Next
        Next

        txtGrandTotal.Text = Val(txtSubTotal.Text) - Val(txtRepAdvanced.Text)
        txtCAmount.Text = txtGrandTotal.Text
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        pnlDSaveFinal.Visible = False
        pnlDSaveFinal.Dock = DockStyle.None
        MenuStrip.Enabled = True
        AcceptButton = cmdSave
        grdRepair.Focus()
        grdRepair.CurrentCell = grdRepair.Item(0, grdRepair.Rows.Count - 1)
    End Sub

    Private Sub frmDeliver_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub ReceiveInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveInfoToolStripMenuItem.Click
        Dim frmNewReceive As New frmReceive
        With frmNewReceive
            .Name = "frmReceive" + NextfrmNo(frmReceive).ToString
            .Caller = Me.Name
            .Show(Me)
            .Tag = "Deliver"
        End With
    End Sub

    Private Sub txtCReceived_TextChanged(sender As Object, e As EventArgs) Handles txtCReceived.TextChanged
        If txtCAmount.Text <> "" And txtCReceived.Text <> "" Then
            txtCBalance.Text = Val(txtCReceived.Text) - Val(txtCAmount.Text)
        End If
    End Sub

    Private Sub grdRepair_SelectionChanged(sender As Object, e As EventArgs) Handles grdRepair.SelectionChanged
        grdRepair.EndEdit()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Call cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call cmdSave_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Call cmdClose_Click(sender, e)
    End Sub

    Private Sub txtCAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAmount.KeyPress, txtCReceived.KeyPress, txtCPAmount.KeyPress, txtCuLAmount.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub txtCuTelNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuTelNo1.KeyPress, txtCuTelNo2.KeyPress, txtCuTelNo3.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub GetDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDataToolStripMenuItem.Click
        Dim frmNewSearch As New frmSearch
        With frmNewSearch
            .Name = "frmSearch" + NextfrmNo(frmSearch).ToString
            .Key = Me.Name
            .Tag = "Deliver"
            .Show(Me)
        End With
    End Sub
End Class