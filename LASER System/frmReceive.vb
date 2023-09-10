﻿Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports ZXing
Imports System.Drawing
Imports System.IO
Imports System.ComponentModel
Imports System.Threading

Public Class frmReceive
    Private Db As New Database
    Public Property Caller As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If MdifrmMain.tslblUserType.Text <> "Cashier" Then
            txtRNo.Visible = True
            lblRNo.Visible = True
        End If
        MenuStrip.Items.Add(mnustrpMENU)
        Call cmdNew_Click(Nothing, Nothing)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        txtCuTelNo1.Focus()
    End Sub
    Private Sub frmReceive_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If pnlRSaveFinal.Visible = True Then
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
        End If
    End Sub

    Private Sub cmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        ComboBoxDropDown(Db, cmbCuName, "Select CuName from Customer Group by CuName;")
    End Sub

    Private Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        If txtCuTelNo1.Text.Trim = "" Then
            CMD = New OleDb.OleDbCommand("SELECT * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
                                         "' and CuTelNo2='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "';")
            DR = CMD.ExecuteReader()
            If DR.HasRows = True Then
                DR.Read()
                cmbCuName_Text(DR("CuName").ToString)
                txtCuTelNo1.Text = DR("CuTelNo1").ToString
                txtCuTelNo2.Text = DR("CuTelNo2").ToString
                txtCuTelNo3.Text = DR("CuTelNo3").ToString
            Else
                For i As Integer = 0 To 1000
                    CMD = New OleDb.OleDbCommand("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
                    DR = CMD.ExecuteReader
                    If DR.HasRows = False Then
                        cmbCuName_Text(cmbCuName.Text + " " + i.ToString)
                        Exit For
                    End If
                Next
            End If
        Else
            CMD = New OleDb.OleDbCommand("SELECT * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
                                         "' and CuTelNo2='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "';")
            DR = CMD.ExecuteReader()
            If DR.HasRows = True Then Exit Sub
            If cmbCuName.Text = "" Then Exit Sub
            CMD = New OleDbCommand("Select CuName from Customer where CuName ='" & cmbCuName.Text & "';")
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                For i As Integer = 0 To 1000
                    CMD = New OleDb.OleDbCommand("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
                    DR = CMD.ExecuteReader
                    If DR.HasRows = False Then
                        cmbCuName_Text(cmbCuName.Text + " " + i.ToString)
                        Exit For
                    End If
                Next
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Cursor = Cursors.WaitCursor
        Call AutomaticPrimaryKey(txtRNo, "SELECT top 1 RNo from Receive ORDER BY RNo Desc;", "RNo")
        'clear customer fileds
        For Each obj As Object In {cmbCuMr, cmbCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3}
            obj.Text = ""
        Next
        grdRepair.Rows.Clear()
        grdReRepair.Rows.Clear()
        'cmbCuName_DropDown(sender, e)
        grdRepair.CurrentCell = grdRepair.Rows(grdRepair.Rows.Count - 1).Cells(0)
        cmdCancel_Click(sender, e)
        Cursor = Cursors.Default
        txtCuTelNo1.Focus()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmReceive_Leave(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CheckEmptyfield(cmbCuName, "Customer Name යන field එක හිස්ව පවතියි. කරුණාකර Customer කෙනෙකු තෝරා නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf grdRepair.Rows.Count < 2 And grdReRepair.Rows.Count < 2 Then
            MsgBox("ඔබ තවමත් කිසිම Repair එකක් හෝ RERepair එකක් ඇතුලත් කර නොමැත. කරුණාකර Repair එකක් හෝ RERepair එකක් ඇතුලත් කර නැවත උත්සහ කරන්න.", vbOKOnly + vbExclamation)
            grdRepair.Focus()
            Exit Sub
        ElseIf txtCuTelNo1.Text.Trim <> "" AndAlso txtCuTelNo1.Text.Trim.Length < 10 Then
            MsgBox("Customer Telephone No 1 field එකෙහි සම්පුර්ණ දුරකතනය ඇතුලත් කර නොමැත.", vbExclamation)
            Exit Sub
        ElseIf txtCuTelNo2.Text.Trim <> "" AndAlso txtCuTelNo2.Text.Trim.Length < 10 Then
            MsgBox("Customer Telephone No 2 field එකෙහි සම්පුර්ණ දුරකතනය ඇතුලත් කර නොමැත.", vbExclamation)
            Exit Sub
        ElseIf txtCuTelNo3.Text.Trim <> "" AndAlso txtCuTelNo3.Text.Trim.Length < 10 Then
            MsgBox("Customer Telephone No 3 field එකෙහි සම්පුර්ණ දුරකතනය ඇතුලත් කර නොමැත.", vbExclamation)
            Exit Sub
        End If
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index = grdRepair.Rows.Count - 1 Then Continue For
            If row.Cells(0).Value.ToString = "" Then
                MsgBox(row.Index + " වන තීරුවේ Repair No යන fild එක හිස්ව පවතින බැවින් Save කිරීමට අපොහොසත් විය. එම තීරුව ඉවත් කර නැවත ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            If row.Cells(1).Value Is Nothing OrElse row.Cells(1).Value.ToString = "" Then
                MsgBox("Repair No: " + row.Cells(0).Value.ToString + " හි Product Category Field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            If row.Cells(2).Value Is Nothing OrElse row.Cells(2).Value.ToString = "" Then
                MsgBox("Repair No: " + row.Cells(0).Value.ToString + " හි Product Name Field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
        Next
        For Each row As DataGridViewRow In grdReRepair.Rows
            If row.Index = grdReRepair.Rows.Count - 1 Then Continue For
            If row.Cells(0).Value.ToString = "" Then
                MsgBox(row.Index + " වන තීරුවේ RERepair No යන fild එක හිස්ව පවතින බැවින් Save කිරීමට අපොහොසත් විය. එම තීරුව ඉවත් කර නැවත ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
            If row.Cells(1).Value.ToString = "" Then
                MsgBox("RERepair No: " + row.Cells(0).Value.ToString + " හි Repair No Field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
        Next
        grdRepair.EndEdit()
        grdReRepair.EndEdit()
        cmdSave.Focus()

        If Me.Tag = "Deliver" Then
            SaveReceive()
            Me.Tag = ""
            frmReceive_Leave(sender, e)
            Exit Sub
        End If

        pnlRSaveFinal.Dock = DockStyle.Fill
        pnlRSaveFinal.BringToFront()
        pnlRSaveFinal.Visible = True
        grpComInfo.Top = (Val(pnlRSaveFinal.Height) / 2) - (Val(grpComInfo.Height) / 2)
        grpComInfo.Left = (Val(pnlRSaveFinal.Width) / 2) - (Val(grpComInfo.Width) / 2)
        MenuStrip.Enabled = False
        AcceptButton = cmdReceiptSticker
        cmdReceiptSticker.Focus()
    End Sub
    Private Sub cmdReceiptSticker_Click(sender As Object, e As EventArgs) Handles cmdReceiptSticker.Click, cmdReceipt.Click, cmdSticker.Click, cmdSaveOnly.Click
        SaveReceive()
        Dim RNo As Integer = txtRNo.Text
        cmdNew_Click(sender, e)
        If sender Is cmdReceipt Or sender Is cmdReceiptSticker Then
            PrintReceipt(RNo, True, True, "ReceivedReceipt")
        End If
        If sender Is cmdSticker Or sender Is cmdReceiptSticker Then
            PrintSticker(RNo, True, True, "ReceivedSticker")
        End If
    End Sub

    Private Sub SaveReceive()
        Cursor = Cursors.WaitCursor
        'Customer Management 
        Dim CuNo, PNo As Integer
        CMD = New OleDb.OleDbCommand("Select * from Customer where CuName='" & cmbCuMr.Text & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
                                     "' and CuTelNo2 ='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "'")
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            CuNo = DR("CuNo")
        Else
            CuNo = AutomaticPrimaryKey("Customer", "CuNo")
            Db.Execute("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & cmbCuMr.Text & cmbCuName.Text & "','" &
                      txtCuTelNo1.Text & "','" & txtCuTelNo2.Text & "','" & txtCuTelNo3.Text & "')")
        End If
        If txtRDate.Value.Date = Today.Date Then txtRDate.Value = DateAndTime.Now
        txtRNo.Text = AutomaticPrimaryKey("Receive", "RNo")
        Db.Execute("Insert into Receive(RNo,RDate,CuNo,UNo) values(" & txtRNo.Text & ",#" & txtRDate.Value & "#," & CuNo & ",'" & MdifrmMain.Tag & "');")
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index = grdRepair.Rows.Count - 1 Then Continue For
            'Product Management
            CMD = New OleDb.OleDbCommand("Select * from Product where PCategory='" & row.Cells(1).Value & "' and PName='" & row.Cells(2).Value & "'")
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                DR.Read()
                PNo = DR("PNo")
            Else
                PNo = AutomaticPrimaryKey("Product", "PNo")
                Db.Execute("Insert into Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) " &
                          "Values(" & PNo & ",'" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" &
                          row.Cells(5).Value & "');")
            End If
            Db.Execute("Insert into Repair(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status)" &
                                        "Values(" & row.Cells(0).Value & "," & txtRNo.Text & "," & PNo & ",'" & row.Cells(4).Value & "'," &
                                        row.Cells(6).Value & ",'" & row.Cells(7).Value & "','Received');")
            Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                      " Values(?NewKey?RepairActivity?RepANo?," &
                      row.Cells(0).Value & ",#" & DateAndTime.Now &
                      "#,'Received Date -> " & txtRDate.Value & vbCrLf &
                      ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text &
                      ", Telephone No2 -> " & txtCuTelNo2.Text &
                      ", Telephone No3 -> " & txtCuTelNo3.Text & vbCrLf &
                      ", Product Category -> " & row.Cells(1).Value &
                      ", Product Name -> " & row.Cells(2).Value &
                      ", Model No -> " & row.Cells(3).Value &
                      ", Serial No -> " & row.Cells(4).Value &
                      ", Problem -> " & row.Cells(5).Value & ".'," & MdifrmMain.Tag & ")")
            If row.Cells(8).Value IsNot Nothing Then
                Db.Execute("Insert into RepairRemarks1(Rem1No,Rem1Date,RepNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,#" & DateAndTime.Now & "#," &
                      row.Cells(0).Value & ",'" & row.Cells(8).Value & "'," & MdifrmMain.Tag & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As frmDeliver In Application.OpenForms().OfType(Of frmDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRepair.Rows.Add(row.Cells("RepairNo").Value, row.Cells("PCategory").Value, row.Cells("PName").Value, row.Cells("PQty").Value,
                                                "0", "", "")
                        End With
                        Exit For
                    End If
                Next
            End If
        Next row
        For Each row As DataGridViewRow In grdReRepair.Rows
            If row.Index = grdReRepair.Rows.Count - 1 Then Continue For
            'Product Management
            CMD = New OleDb.OleDbCommand("Select * from Product where PCategory='" & row.Cells(2).Value & "' and PName = '" & row.Cells(3).Value & "'")
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                DR.Read()
                PNo = DR("PNo")
            Else
                PNo = AutomaticPrimaryKey("Product", "PNo")
                Db.Execute("Insert into Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) " &
                          "Values(" & PNo & ",'" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value &
                          "','" & row.Cells(6).Value & "');")
            End If
            Db.Execute("Insert Into `Return`(RetNo,RNo,RepNo,PNo,PSerialNo,Qty,Problem,Status,RetRemarks1) " &
            "Values(" & row.Cells(0).Value & "," & txtRNo.Text & "," & row.Cells(1).Value & "," & PNo & ",'" & row.Cells(5).Value & "'," &
            row.Cells(7).Value & ",'" & row.Cells(8).Value & "','Received','" & row.Cells(9).Value & "');")
            Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                      " Values(?NewKey?RepairActivity?RepANo?," &
                      row.Cells(0).Value & ",#" & DateAndTime.Now & "#,'Received Date -> " & txtRDate.Value & vbCrLf & ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text & ", Telephone No2 -> " & txtCuTelNo2.Text & ", Telephone No3 -> " & txtCuTelNo3.Text &
                      vbCrLf & ", Product Category -> " & row.Cells(2).Value &
                      ", Product Name -> " & row.Cells(3).Value & ", Model No -> " & row.Cells(4).Value & ", Serial No -> " & row.Cells(5).Value &
                      ", Problem -> " & row.Cells(6).Value & ".'," & MdifrmMain.Tag & ")")
            If row.Cells(9).Value IsNot Nothing Then
                Db.Execute("Insert into RepairRemarks1(Rem1No,Rem1Date,RetNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,#" & DateAndTime.Now & "#," &
                      row.Cells(0).Value & ",'" & row.Cells(9).Value & "'," & MdifrmMain.Tag & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As frmDeliver In Application.OpenForms().OfType(Of frmDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRERepair.Rows.Add(row.Cells("RERepairNo").Value, row.Cells("RETRepNo").Value, row.Cells("RETPCategory").Value,
                                                  row.Cells("RETPName").Value, row.Cells("RETQty").Value, "0", "", "")
                        End With
                    End If
                Next
            End If
        Next row
        Cursor = Cursors.Default
    End Sub

    Public Sub PrintReceipt(RNo As String, Optional boolPrint As Boolean = False, Optional boolClosed As Boolean = False, Optional formTag As String = "")
        If IsNumeric(RNo) = False Or RNo = "" Then Exit Sub
        Dim UserName As String = MdifrmMain.tslblUserName.Text
        Dim threadInvoice As New Thread(
            Sub()
                'Try
                Dim frm1 As New frmReport
                Dim RPT As New rptReceive
                Dim DT1 As DataTable = Db.GetDataTable($"SELECT RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,'' as RetNo, RepNo, PCategory, PName, PModelNo, 
                PSerialNo, Qty, Problem, '' as RepRemarks1 from 
                (((Repair Inner Join Receive On Receive.RNo =Repair.RNo) Left Join Product On Product.PNo=Repair.PNo) 
                Left Join Customer On Customer.CuNo=Receive.CuNo) Where Receive.RNo = {RNo} 
                Union Select RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3, RetNo, RepNo, PCategory, PName, PModelNo, PSerialNo, Qty, Problem, '' as RepRemarks1 
                from (((Return Inner Join Receive On Receive.RNo =Return.RNo) 
                Left Join Product On Product.PNo=Return.PNo) 
                Left Join Customer On Customer.CuNo=Receive.CuNo) 
                Where Receive.RNo = {RNo}")
                For Each row As DataRow In DT1.Rows
                    Dim CMD1 As New OleDbCommand("Select Remarks from RepairRemarks1 Where " &
                                                 If(row.Item("RetNo") = "", "RepNo=" & row.Item("RepNo"), "RetNo=" & row.Item("RetNo")))
                    Dim DR1 As OleDbDataReader = CMD1.ExecuteReader
                    row.Item("RepRemarks1") = ""
                    While DR1.Read
                        row.Item("RepRemarks1") += DR1("Remarks").ToString + vbCrLf
                    End While
                Next
                RPT.SetDataSource(DT1)

                RPT.SetParameterValue("Cashier Name", UserName)
                Dim rawKind1 As Integer
                Dim c1 As Integer
                Dim doctoprint1 As New Printing.PrintDocument()
                doctoprint1.PrinterSettings.PrinterName = My.Settings.BillPrinterName
                For c1 = 0 To doctoprint1.PrinterSettings.PaperSizes.Count - 1
                    If doctoprint1.PrinterSettings.PaperSizes(c1).PaperName = My.Settings.BillPrinterPaperName Then
                        rawKind1 = CInt(doctoprint1.PrinterSettings.PaperSizes(c1).
                                                GetType().GetField("kind", Reflection.BindingFlags.Instance Or
                                                Reflection.BindingFlags.NonPublic).GetValue(doctoprint1.PrinterSettings.PaperSizes(c1)))
                        Exit For
                    End If
                Next
                RPT.PrintOptions.PaperSize = CType(rawKind1, CrystalDecisions.Shared.PaperSize)
                RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                If boolPrint Then   'Choose the printer and paper size. Then, print the report
                    RPT.PrintToPrinter(1, False, 0, 0)
                End If
                With frm1
                    .ReportViewer.ReportSource = RPT
                    .Name = "frmReport" + NextfrmNo(frmReport).ToString
                    .boolClosed = boolClosed
                    .Tag = formTag
                    .WindowState = FormWindowState.Normal
                    .Text = "Report - Received Receipt"
                    Application.Run(frm1)
                End With
                RPT.Close()
                'Catch ex As Exception
                'MsgBox("Receipt Invoice එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message, vbCritical, "Print Receipt Invoice Error")
                'End Try
            End Sub) With {
                .Name = "showInvoiceReport",
                .IsBackground = False
                                            }
        threadInvoice.SetApartmentState(ApartmentState.STA)
        threadInvoice.Priority = ThreadPriority.Highest
        threadInvoice.Start()
    End Sub

    'This method use for continues papers
    'Public Sub PrintReceipt(RNo As String, Optional boolPrint As Boolean = False, Optional boolClosed As Boolean = False)

    '    If IsNumeric(RNo) = False Or RNo = "" Then Exit Sub
    '    Dim threadInvoice As New Thread(
    '        Sub()
    '            'Try
    '            Dim frm1 As New frmReport
    '            Dim RPT As New rptReceive
    '            Dim DT1 As New DataTable
    '            Dim DA1 As New OleDb.OleDbDataAdapter("SELECT RepNo,PCategory,PName,PModelNo," &
    '                                                  "PSerialNo,Qty,Problem,'' as RepRemarks1 from Repair,Product,Receive" &
    '                                                  " where Receive.RNO = Repair.RNo and Repair.PNo = Product.PNo and Receive.RNo = " &
    '                                                  RNo & ";")
    '            DA1.Fill(DT1)
    '            For Each row As DataRow In DT1.Rows
    '                Dim CMD1 As New OleDbCommand("Select Remarks from RepairRemarks1 Where RepNo=" & row.Item("RepNo"))
    '                Dim DR1 As OleDbDataReader = CMD1.ExecuteReader
    '                row.Item("RepRemarks1") = ""
    '                While DR1.Read
    '                    row.Item("RepRemarks1") += DR1("Remarks").ToString + vbCrLf
    '                End While
    '            Next
    '            RPT.Subreports.Item("rptReceiveRepair.rpt").SetDataSource(DT1)

    '            Dim DT2 As New DataTable
    '            Dim DA2 As New OleDb.OleDbDataAdapter("Select Return.RetNo,
    '                                                    RepNo,PCategory,Pname,PModelNo,PSerialNo,Qty,Problem,'' as RetRemarks1 
    '                                                    from Return,Product,Receive
    '                                                    where Receive.RNO = Return.RNo and 
    '                                                    Return.PNo = Product.PNo and Receive.RNo = " & RNo & ";")
    '            DA2.Fill(DT2)
    '            For Each row As DataRow In DT2.Rows
    '                Dim CMD1 As New OleDbCommand("Select Remarks from RepairRemarks1 Where RetNo=" & row.Item("RetNo"))
    '                Dim DR1 As OleDbDataReader = CMD1.ExecuteReader
    '                row.Item("RetRemarks1") = ""
    '                While DR1.Read
    '                    row.Item("RetRemarks1") += DR1("Remarks").ToString + vbCrLf
    '                End While
    '            Next
    '            RPT.Subreports.Item("rptReceiveReturn.rpt").SetDataSource(DT2)

    '            Dim DT3 As New DataTable
    '            Dim DA3 As New OleDb.OleDbDataAdapter("SELECT RNo,RDate,Receive.CuNo,CuName,CuTelNo1,CuTelNo2," &
    '                                          "CuTelNo3 from Receive,Customer where Receive.CuNo = Customer.CuNo and Receive.RNo = " & RNo & ";")
    '            DA3.Fill(DT3)
    '            RPT.SetDataSource(DT3)

    '            RPT.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text)
    '            If boolPrint Then
    '                Dim rawKind1 As Integer
    '                Dim c1 As Integer
    '                Dim doctoprint1 As New Printing.PrintDocument()
    '                doctoprint1.PrinterSettings.PrinterName = My.Settings.BillPrinterName
    '                For c1 = 0 To doctoprint1.PrinterSettings.PaperSizes.Count - 1
    '                    If doctoprint1.PrinterSettings.PaperSizes(c1).PaperName = My.Settings.BillPrinterPaperName Then
    '                        rawKind1 = CInt(doctoprint1.PrinterSettings.PaperSizes(c1).
    '                                              GetType().GetField("kind", Reflection.BindingFlags.Instance Or
    '                                              Reflection.BindingFlags.NonPublic).GetValue(doctoprint1.PrinterSettings.PaperSizes(c1)))
    '                        Exit For
    '                    End If
    '                Next
    '                RPT.PrintOptions.PaperSize = CType(rawKind1, CrystalDecisions.Shared.PaperSize)
    '                RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
    '                RPT.PrintToPrinter(1, False, 0, 0)
    '            End If
    '            With frm1
    '                .ReportViewer.ReportSource = RPT
    '                .Name = "frmReport" + NextfrmNo(frmReport).ToString
    '                If boolClosed = True Then .Tag = "ReceivedRecipt"
    '                .WindowState = FormWindowState.Normal
    '                .Text = "Report - Received Receipt"
    '                Application.Run(frm1)
    '            End With
    '            RPT.Close()
    '            'Catch ex As Exception
    '            '    MsgBox("Receipt Invoice එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message, vbCritical, "Print Receipt Invoice Error")
    '            'End Try
    '        End Sub) With {
    '            .Name = "showInvoiceReport",
    '            .IsBackground = False
    '                                        }
    '    threadInvoice.SetApartmentState(ApartmentState.STA)
    '    threadInvoice.Priority = ThreadPriority.Highest
    '    threadInvoice.Start()
    'End Sub

    Public Sub PrintSticker(RNo As String, Optional boolPrint As Boolean = False, Optional boolClosed As Boolean = False, Optional formTag As String = "")

        If IsNumeric(RNo) = False Or RNo = "" Then Exit Sub
        Dim threadSticker As New Thread(
        Sub()
            Try
                Dim rpt3 As New rptRepairSticker
                DT.Clear()
                DT.Columns.Add("RepNo")
                DT.Columns.Add("CuName")
                DT.Columns.Add("CuTelNo1")
                DT.Columns.Add("CuTelNo2")
                DT.Columns.Add("CuTelNo3")
                DT.Columns.Add("PCategory")
                DT.Columns.Add("PName")
                DT.Columns.Add("RDate")
                DT.Columns.Add(New DataColumn("Barcode", GetType(Byte())))
                Dim writer As New BarcodeWriter
                writer.Format = BarcodeFormat.CODE_128
                writer.Options.PureBarcode = True
                Dim DT1 As DataTable = Db.GetDataTable("SELECT Repair.RepNo,RDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,PCategory,PName,Qty from " &
                                              "Repair,Product,Receive,Customer " &
                                              "where Receive.RNO = Repair.RNo and Repair.PNo = Product.PNo and Customer.CuNo = Receive.CuNo and Receive.RNo=" &
                                              RNo & ";")
                For Each row As DataRow In DT1.Rows
                    Dim imgStream As MemoryStream = New MemoryStream()
                    Dim img As Image = writer.Write(row.Item("RepNo"))
                    img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                    Dim byteArray As Byte() = imgStream.ToArray()
                    imgStream.Close()
                    For i As Integer = 1 To row.Item("Qty")
                        DT.Rows.Add("R" & row.Item("RepNo"), row.Item("CuName"), row.Item("CuTelNo1"), row.Item("CuTelNo2"), row.Item("CuTelNo3"), row.Item("PCategory"),
                        row.Item("PName"), row.Item("RDate"), byteArray)
                    Next
                Next
                rpt3.SetDataSource(DT)
                If DT.Rows.Count < 1 Then Exit Sub
                Dim frm2 As New frmReport
                frm2.ReportViewer.ReportSource = rpt3
                Dim c2 As Integer
                Dim doctoprint2 As New System.Drawing.Printing.PrintDocument()
                doctoprint2.PrinterSettings.PrinterName = My.Settings.StickerPrinterName
                Dim rawKind As Integer
                For c2 = 0 To doctoprint2.PrinterSettings.PaperSizes.Count - 1
                    If doctoprint2.PrinterSettings.PaperSizes(c2).PaperName = My.Settings.RepairStickerPrinterPaperName Then
                        rawKind = CInt(doctoprint2.PrinterSettings.PaperSizes(c2).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint2.PrinterSettings.PaperSizes(c2)))
                        Exit For
                    End If
                Next
                rpt3.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                rpt3.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
                If boolPrint Then
                    rpt3.PrintToPrinter(1, False, 0, 0)
                End If
                With frm2
                    .Name = "frmReport" + NextfrmNo(frmReport).ToString
                    .boolClosed = boolClosed
                    .Tag = formTag
                    .WindowState = FormWindowState.Normal
                    .Text = "Report - Received Sticker/s"
                    Application.Run(frm2)
                End With
                rpt3.Close()
            Catch ex As Exception
                MsgBox("Receipt Sticker එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message, vbCritical, "Print Receipt Sticker Error")
            End Try
        End Sub) With {
                .Name = "showStickerReport",
                .IsBackground = False
                                            }
        threadSticker.SetApartmentState(ApartmentState.STA)
        threadSticker.Priority = ThreadPriority.Highest
        threadSticker.Start()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        pnlRSaveFinal.Visible = False
        pnlRSaveFinal.Dock = DockStyle.None
        MenuStrip.Enabled = True
        AcceptButton = cmdSave
        txtCuTelNo1.Focus()
    End Sub

    Private Sub grdRepair_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepair.EditingControlShowing
        Dim txtKeyPress As TextBox = e.Control
        'remove any existing handler
        RemoveHandler txtKeyPress.KeyPress, AddressOf txtKeyPress_Keypress
        AddHandler txtKeyPress.KeyPress, AddressOf txtKeyPress_Keypress
        Dim autoText As TextBox
        Dim DataCollection As New AutoCompleteStringCollection()
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        If TypeOf e.Control Is TextBox Then
            autoText = TryCast(e.Control, TextBox)
            autoText.AutoCompleteCustomSource = Nothing
            autoText.AutoCompleteSource = AutoCompleteSource.None
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If
        Select Case grdRepair.CurrentCell.ColumnIndex
            Case 1
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select PCategory from Product group by PCategory;")
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("PCategory").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 2
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select PCategory,PName from Product where PCategory ='" & grdRepair.Item(1, grdRepair.CurrentCell.RowIndex).Value & "';")
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("PName").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 6
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        End Select
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub txtKeyPress_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Public Sub grdRepair_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepair.CellEndEdit
        Select Case e.ColumnIndex
            Case 1, 2
                If grdRepair.CurrentCell.RowIndex = grdRepair.Rows.Count - 1 Then Exit Sub
                If grdRepair.Item(1, e.RowIndex).Value Is Nothing And grdRepair.Item(2, e.RowIndex).Value Is Nothing Then
                    grdRepair.Rows.RemoveAt(e.RowIndex)
                End If
                CMD = New OleDb.OleDbCommand("Select * from Product where PCategory='" & grdRepair.Item(1, e.RowIndex).Value & "' and PName='" & grdRepair.Item(2, e.RowIndex).Value & "';")
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    DR.Read()
                    grdRepair.Item(1, e.RowIndex).Value = DR("PCategory").ToString
                    grdRepair.Item(2, e.RowIndex).Value = DR("PName").ToString
                    grdRepair.Item(3, e.RowIndex).Value = DR("PModelNo").ToString
                    grdRepair.Item(5, e.RowIndex).Value = DR("PDetails").ToString
                    grdRepair.Item(6, e.RowIndex).Value = "1"
                Else
                    grdRepair.Item(6, e.RowIndex).Value = "1"
                    grdRepair.Item(3, e.RowIndex).Value = ""
                    grdRepair.Item(5, e.RowIndex).Value = ""
                End If
        End Select
    End Sub

    Private Sub grdRepair_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdRepair.UserAddedRow
        Dim i As Integer
        CMD = New OleDb.OleDbCommand("Select Top 1 REpNo from REpair Order by repno desc;")
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            i = Int(DR("RepNo").ToString) + 1
        Else
            i = 1
        End If
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index = grdRepair.Rows.Count - 1 Then Continue For
            row.Cells(0).Value = i
            i += 1
        Next
    End Sub

    Private Sub grdRepair_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdRepair.UserDeletedRow
        grdRepair_UserAddedRow(sender, e)
    End Sub

    Public Sub GrdReRepair_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdReRepair.CellEndEdit
        Select Case e.ColumnIndex
            Case 1
                If grdReRepair.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then Exit Sub
                Dim CMDRERep = New OleDb.OleDbCommand("Select RepNo,Rep.RNo,Cu.CuNo,CuName,CuTelNo1,CuTElNo2,CuTelNo3 from Repair REP, Receive R, Customer Cu Where Rep.RNo = R.RNo and Cu.CuNo = R.CuNo and RepNo = " & grdReRepair.Item(1, e.RowIndex).Value)
                Dim DRRERep As OleDb.OleDbDataReader = CMDRERep.ExecuteReader
                If DRRERep.HasRows = True Then
                    DRRERep.Read()
                    txtCuTelNo1.Text = DRRERep("CuTelNo1").ToString
                    txtCuTelNo2.Text = DRRERep("CUTelNo2").ToString
                    txtCuTelNo3.Text = DRRERep("CuTelNo3").ToString
                    cmbCuName.Text = DRRERep("CuName").ToString
                End If
                CMDRERep = New OleDb.OleDbCommand("Select RepNo,PCategory,PName,PModelNo,PSerialNo,PDetails,Qty from Repair Rep,Product P where Rep.Pno = P.PNo and RepNo=" & grdReRepair.Item(1, e.RowIndex).Value)
                DRRERep = CMDRERep.ExecuteReader()
                If DRRERep.HasRows = True Then
                    DRRERep.Read()
                    grdReRepair.Item(2, e.RowIndex).Value = DRRERep("PCategory").ToString
                    grdReRepair.Item(3, e.RowIndex).Value = DRRERep("PName").ToString
                    grdReRepair.Item(4, e.RowIndex).Value = DRRERep("PModelNo").ToString
                    grdReRepair.Item(5, e.RowIndex).Value = DRRERep("PSerialNo").ToString
                    grdReRepair.Item(6, e.RowIndex).Value = DRRERep("PDetails").ToString
                    grdReRepair.Item(7, e.RowIndex).Value = DRRERep("Qty").ToString
                End If
        End Select
    End Sub

    Public Sub grdReRepair_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdReRepair.UserAddedRow
        Dim i As Integer
        CMD = New OleDb.OleDbCommand("Select Top 1 RetNo from Return Order by retno desc;")
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            i = Int(DR("RetNo").ToString) + 1
        Else
            i = 1
        End If
        For Each row As DataGridViewRow In grdReRepair.Rows
            If row.Index = grdReRepair.Rows.Count - 1 Then Continue For
            row.Cells(0).Value = i
            i += 1
        Next
    End Sub

    Private Sub grdReRepair_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdReRepair.UserDeletedRow
        Call grdReRepair_UserAddedRow(sender, e)
    End Sub

    Private Sub cmdCuView_Click(sender As Object, e As EventArgs) Handles cmdCuView.Click
        frmCustomer.Tag = "Receive"
        frmCustomer.Show()
        frmCustomer.cmbCuName.Focus()
    End Sub

    Private Sub CustomerInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerInfoToolStripMenuItem.Click
        Call cmdCuView_Click(sender, e)
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

    Private Sub ProductInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductInfoToolStripMenuItem.Click
        With frmProduct
            .Tag = "Receive"
            .Show(Me)
            .cmbPCategory.Focus()
        End With
    End Sub

    Private Sub RepairInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairInfoToolStripMenuItem.Click
        frmSearch.Tag = "Receive"
        frmSearch.Show()
    End Sub

    Private Sub frmReceive_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub txtCuTelNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuTelNo1.KeyPress, txtCuTelNo2.KeyPress, txtCuTelNo3.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub txtCuTelNo1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuTelNo1.KeyUp
        If txtCuTelNo1.Text.Replace(" ", "").Length < 10 Then Exit Sub
        Dim SaCMD As New OleDb.OleDbCommand("Select * from Customer where CuTelNo1='" & txtCuTelNo1.Text & "' or CuTelNo2='" & txtCuTelNo1.Text &
                                            "' or CuTelNo3='" & txtCuTelNo1.Text & "';")
        Dim SaDR As OleDb.OleDbDataReader = SaCMD.ExecuteReader()
        If SaDR.HasRows = True Then
            SaDR.Read()
            If cmbCuMr.Text + cmbCuName.Text = SaDR("CuName").ToString Then Exit Sub
            Dim frm As New frmCustomer
            With frm
                frm.Name = "frmCustomer" + NextfrmNo(frmCustomer).ToString
                frm.Caller = Me.Name
                frm.Tag = "Receive"
                frm.Show(Me)
                frm.cmbCuName.Text = SaDR("CuName").ToString
                Call frm.cmbCuName_SelectedIndexChanged(sender, e)
            End With
        Else
            cmbCuName_SelectedIndexChanged(sender, e)
        End If
        SaCMD.Cancel()
        SaDR.Close()
    End Sub

    Private Sub txtCuTelNo2_KeyUp(sender As Object, e As EventArgs) Handles txtCuTelNo2.KeyUp
        If txtCuTelNo2.Text.Replace(" ", "").Length < 10 Then Exit Sub
        If txtCuTelNo1.Text.Replace(" ", "") = "" Then
            txtCuTelNo1.Text = txtCuTelNo2.Text
            txtCuTelNo2.Text = ""
            Exit Sub
        End If
        Dim SaCMD As New OleDb.OleDbCommand("Select * from Customer where CuTelNo1='" & txtCuTelNo2.Text & "' or CuTelNo2='" & txtCuTelNo2.Text & "' or CuTelNo3='" & txtCuTelNo2.Text & "';")
        Dim SaDR As OleDb.OleDbDataReader = SaCMD.ExecuteReader()
        If SaDR.HasRows = True Then
            SaDR.Read()
            If cmbCuMr.Text + cmbCuName.Text = SaDR("CuName").ToString Then Exit Sub
            Dim frm As New frmCustomer
            With frm
                frm.Name = "frmCustomer" + NextfrmNo(frmCustomer).ToString
                frm.Caller = Me.Name
                frm.Tag = "Receive"
                frm.Show(Me)
                frm.cmbCuName.Text = SaDR("CuName").ToString
                Call frm.cmbCuName_SelectedIndexChanged(sender, e)
            End With
        End If
        SaCMD.Cancel()
        SaDR.Close()
    End Sub

    Private Sub txtCuTelNo3_KeyUp(sender As Object, e As EventArgs) Handles txtCuTelNo3.KeyUp
        If txtCuTelNo3.Text.Replace(" ", "").Length < 10 Then Exit Sub
        If txtCuTelNo1.Text.Replace(" ", "") = "" And txtCuTelNo2.Text.Replace(" ", "") = "" Then
            txtCuTelNo1.Text = txtCuTelNo3.Text
            txtCuTelNo3.Text = ""
            txtCuTelNo2.Text = ""
            Exit Sub
        ElseIf txtCuTelNo1.Text.Replace(" ", "") = "" Then
            txtCuTelNo1.Text = txtCuTelNo2.Text
            txtCuTelNo2.Text = txtCuTelNo3.Text
            txtCuTelNo3.Text = ""
            Exit Sub
        End If
        Dim SaCMD As New OleDb.OleDbCommand("Select * from Customer where CuTelNo1='" & txtCuTelNo3.Text & "' or CuTelNo2='" & txtCuTelNo3.Text & "' or CuTelNo3='" & txtCuTelNo3.Text & "';")
        Dim SaDR As OleDb.OleDbDataReader = SaCMD.ExecuteReader()
        If SaDR.HasRows = True Then
            SaDR.Read()
            If cmbCuMr.Text + cmbCuName.Text = SaDR("CuName").ToString Then Exit Sub
            Dim frm As New frmCustomer
            With frm
                frm.Name = "frmCustomer" + NextfrmNo(frmCustomer).ToString
                frm.Caller = Me.Name
                frm.Tag = "Receive"
                frm.Show(Me)
                frm.cmbCuName.Text = SaDR("CuName").ToString
                Call frm.cmbCuName_SelectedIndexChanged(sender, e)
            End With
        End If
        SaCMD.Cancel()
        SaDR.Close()
    End Sub

    Public Sub cmbCuName_Text(CuName As String)
        cmbCuName.Text = CuName
        CuName = CuName.TrimStart(" ")
        For Each strTmp As String In cmbCuMr.Items
            If CuName.StartsWith(strTmp) Then
                Dim str As String() = CuName.Split(". ")
                cmbCuMr.Text = str.GetValue(0) & ". "
                cmbCuName.Text = CuName.Remove(0, cmbCuMr.Text.Length)
                Exit For
            End If
        Next
    End Sub
End Class