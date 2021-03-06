Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Net.Mail
Imports System.IO
Public Class frmTechnicianSalary
    Private Sub FrmTechnicianSalary_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub FrmTechnicianSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        AutomaticPrimaryKey(txtTSNo, "Select Top 1 TSNo from TechnicianSalary order by TSNo desc;", "TSNo")
        MenuStrip.Items.Add(mnustrpMENU)
        txtTSFrom.Value = "" & Date.Today.Year & "-" & Date.Today.Month & "-01"
        txtTSTo.Value = Date.Today
        ToolTip.SetToolTip(txt1, "Total Amount of Repairs, Re-Repairs and Sales Repairs")
        ToolTip.SetToolTip(txt2, "Total Amount of Cost")
        ToolTip.SetToolTip(txt3, "Technician earn amount")
        ToolTip.SetToolTip(txt4, "Technician earn amount")
        ToolTip.SetToolTip(txt5, "Total Amount of Loan")
        ToolTip.SetToolTip(txt6, "Technician Salary")
        CmbTName_DropDown(sender, e)
    End Sub

    Private Sub CmdTSSearch_Click(sender As Object, e As EventArgs) Handles cmdTSSearch.Click
        txt1.Text = "0"
        txt2.Text = "0"
        txt3.Text = "0"
        txt4.Text = "0"
        txt5.Text = "0"
        txt6.Text = "0"
        txtTotalCost.Text = "0"
        txtTotalLoan.Text = "0"
        txtTotalSalesRepair.Text = "0"
        txtTotalRepair.Text = "0"
        txtTotalReRepair.Text = "0"
        If CheckEmptyfieldcmb(cmbTName, "ඔබ තවමත් Technician කෙනෙකු තෝරා නැත. කරුණාකර Technician කෙනෙක් තෝරා ගන්න.") = False Then
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim x As String = ";"
        If chkPaidTSal.Checked = False Then x = " and (TSalNo is Null or TSalNo = 0);"
        Dim DT1 As New DataTable
        Dim DA1 As New OleDb.OleDbDataAdapter("Select Repair.RepNo,DDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,PCategory,PName,Qty,PaidPrice,Status," &
                                              "'' as RepRemarks1,'' as RepRemarks2, TSalNo from Customer,Deliver,Repair,Product,Technician " &
                                              "Where Product.PNo = Repair.PNo and Repair.DNo = Deliver.DNo and Customer.CuNo = " &
                                              "Deliver.CuNo and Technician.TNo = Repair.TNo and TName='" &
                                              cmbTName.Text & "' and DDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                              " 23:59:59# " + x, CNN)
        DA1.Fill(DT1)
        For Each row As DataRow In DT1.Rows
            Dim CMD1 As New OleDb.OleDbCommand("Select Remarks from RepairRemarks1 Where RepNo=" & row.Item("RepNo"), CNN)
            Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader
            row.Item("RepRemarks1") = ""
            While DR1.Read
                row.Item("RepRemarks1") += DR1("Remarks").ToString + vbCrLf
            End While
        Next
        grdRepair.DataSource = DT1
        grdRepair.Refresh()
        For Each Row As DataGridViewRow In grdRepair.Rows
            txtTotalRepair.Text = Val(txtTotalRepair.Text) + Val(Row.Cells("REPPaidPrice").Value)
        Next
        Dim DT2 As New DataTable
        Dim DA2 As New OleDb.OleDbDataAdapter("Select Return.RetNo, DDate, CuName, CuTelNo1, CuTelNo2, CuTelNo3, PCategory, PName, Qty, PaidPrice," &
                                              "Status, '' as RetRemarks1,'' as RetRemarks2, TSalNo from Customer, Deliver, Return, Product, Technician Where " &
                                              "Product.PNo = Return.PNo And Return.DNo = Deliver.DNo And Customer.CuNo = Deliver.CuNo And Technician.TNo " &
                                              "= Return.TNo And TName='" & cmbTName.Text &
                                              "' And DDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59# " + x, CNN)
        DA2.Fill(DT2)
        For Each row As DataRow In DT1.Rows
            Dim CMD1 As New OleDb.OleDbCommand("Select Remarks from RepairRemarks1 Where RepNo=" & row.Item("RepNo"), CNN)
            Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader
            row.Item("RepRemarks1") = ""
            While DR1.Read
                row.Item("RepRemarks1") += DR1("Remarks").ToString + vbCrLf
            End While
        Next
        grdReRepair.DataSource = DT2
        grdReRepair.Refresh()
        For Each Row As DataGridViewRow In grdReRepair.Rows
            txtTotalReRepair.Text = Val(txtTotalReRepair.Text) + Val(Row.Cells("REREPPaidPrice").Value.ToString)
        Next
        Dim DT3 As New DataTable
        Dim DA3 As New OleDb.OleDbDataAdapter("Select TechnicianCost.TCNo, TCDate, RepNo, RetNo, SNo, SCategory, SName, Rate, Qty, Total, TCRemarks, TSalNo " &
                                              "from (TechnicianCost Inner Join Technician On Technician.TNo = TechnicianCost.TNo)" &
                                              " Where TName='" & cmbTName.Text & "' And TCDate BETWEEN #" &
                                              txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59# " + x, CNN)
        DA3.Fill(DT3)
        grdCost.DataSource = DT3
        grdCost.Refresh()
        For Each Row As DataGridViewRow In grdCost.Rows
            If Row.Cells("TCTotal").Value Is Nothing Then Continue For
            txtTotalCost.Text = Val(txtTotalCost.Text) + Val(Row.Cells("TCTotal").Value)
        Next
        Dim DT4 As New DataTable
        Dim DA4 As New OleDb.OleDbDataAdapter("Select  TLNo, TLDate, SCategory, SName, TLReason, Rate, Qty,Total from (TechnicianLoan TL Inner Join " &
                                              "Technician T on T.TNo = TL.TNo) Where TName='" & cmbTName.Text & "' And TLDate BETWEEN #" &
                                              txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59# ", CNN)
        DA4.Fill(DT4)
        CMD = New OleDb.OleDbCommand("Select * from [TechnicianLoan] as TL Where TL.TLDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# and #" &
                                     txtTSTo.Value.Date & " 23:59:59#;", CNN)
        DR = CMD.ExecuteReader
        Dim ArrearsLoan As Integer = 0
        While DR.Read
            If DR("Total").ToString <> "" Then ArrearsLoan += Int(DR("Total").ToString)
        End While
        CMD.Cancel()
        DR.Close()
        If ArrearsLoan <> 0 Then
            Dim newRow As DataRow = DT4.NewRow()
            newRow(0) = "0"
            newRow(1) = txtTSFrom.Value.Date.ToString
            newRow(4) = "Arrears loan before " & txtTSFrom.Value.Date.ToString
            newRow(7) = ArrearsLoan.ToString
            DT4.Rows.InsertAt(newRow, 0)
        End If
        grdLoan.DataSource = DT4
        grdLoan.Refresh()
        For Each Row As DataGridViewRow In grdLoan.Rows
            If Row.Cells("TLTotal").Value.ToString = "" Then Continue For
            txtTotalLoan.Text = Int(txtTotalLoan.Text) + Int(Row.Cells("TLTotal").Value)
        Next
        Dim DT5 As New DataTable
        Dim DA5 As New OleDb.OleDbDataAdapter("Select SaRepNo, SaRepDate, SCategory, SName, Rate, Qty, Total, TSalNo from SalesRepair,Stock,Technician where " &
                                              "Technician.TNo = SalesRepair.TNo And Stock.SNo = SalesRepair.Sno And  TName = '" & cmbTName.Text & "' And SaRepDate Between #" &
                                              txtTSFrom.Value.Date & " 00:00:00# and #" & txtTSTo.Value.Date & " 23:59:59#" + x, CNN)
        DA5.Fill(DT5)
        grdSalesRepair.DataSource = DT5
        grdSalesRepair.Refresh()
        For Each Row As DataGridViewRow In grdSalesRepair.Rows
            txtTotalSalesRepair.Text = Int(txtTotalSalesRepair.Text) + Int(Row.Cells("Total").Value.ToString)
        Next
        'calculator part for making salary
        Call TechnicianSalaryCalculator()
        Cursor = Cursors.Default()
    End Sub

    Private Sub CmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call CmbDropDown(cmbTName, "Select TName from Technician group by TName;", "TName")
    End Sub

    Private Sub cmdTSCancel_Click(sender As Object, e As EventArgs) Handles cmdTSCancel.Click
        Call FrmTechnicianSalary_Leave(sender, e)
    End Sub

    Private Sub cmdTCDone_Click(sender As Object, e As EventArgs) Handles cmdTSDone.Click
        If CheckEmptyfieldcmb(cmbTName, "This operation couldn't be done because Technician was already empty. You should select any Technician and try again.") = False Then
            cmbTName.Focus()
            Exit Sub
        ElseIf CheckExistDatatxt(txtTSNo, "Select TSNo from TechnicianSalary where TSNo =" & txtTSNo.Text, "This operation couldn't be done because 'Technician Salary No' was exist in the database. Something was wrong. Please find why that was or call developer of this system.", True) = True Then
            txtTSNo.Focus()
            Exit Sub
        ElseIf CheckExistDatacmb(cmbTName, "Select TName from Technician Where TName='" & cmbTName.Text & "'", "Technician Name එක සොයා ගැනීමට නොහැකි විය. කරුණාකර ඔබ ඇතුලත් කල Technician නිවැරදි දැයි පරික්ෂා කරන්න.", True) = False Then
            cmbTName.Focus()
            Exit Sub
        End If
        If chkPaidTSal.Checked = True Then
            MsgBox("You have marked checkbox called 'with Paid Technician Salary'. Therefore This operation couldn't be submitted. So you should unmark that and try agin", vbCritical + vbOKOnly)
            Exit Sub
        End If
        Dim TSalaryTNo As Integer
        CMD = New OleDb.OleDbCommand("Select TNo, TName from Technician Where Tname='" & cmbTName.Text & "';", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            TSalaryTNo = DR("TNo").ToString
        End If
        CMDUPDATE("Insert into TechnicianSalary(TSNo,TNo,TSDate,TotalRepair,TotalReRepair,TotalSalesRepair,TotalCost,TotalLoan,Earned,AddedLoan,Salary) " &
                                     "Values(" & txtTSNo.Text & "," & TSalaryTNo.ToString & ",#" & txtTSDate.Value.Date & "#," & txtTotalRepair.Text & "," & txtTotalReRepair.Text & "," & txtTotalSalesRepair.Text & "," & txtTotalCost.Text & "," & txtTotalLoan.Text & "," & txt3.Text & "," & txt5.Text & "," & txt6.Text & ");")
        For Each Row As DataGridViewRow In grdRepair.Rows
            CMDUPDATE("Update Repair set TSalNo =" & txtTSNo.Text & " where RepNo=" & Row.Cells(0).Value.ToString)
        Next
        For Each Row As DataGridViewRow In grdReRepair.Rows
            CMDUPDATE("Update `Return` set TSalNo =" & txtTSNo.Text & " where RetNO=" & Row.Cells(0).Value.ToString)
        Next
        For Each Row As DataGridViewRow In grdSalesRepair.Rows
            CMDUPDATE("Update SalesRepair set TSalNo =" & txtTSNo.Text & " where SaRepNo=" & Row.Cells(0).Value.ToString)
        Next
        For Each Row As DataGridViewRow In grdCost.Rows
            CMDUPDATE("Update TechnicianCost set TSalNo = " & txtTSNo.Text & " where TCNo=" & Row.Cells(1).Value.ToString)
        Next
        Dim TLNo As String
        CMD = New OleDb.OleDbCommand("Select Top 1 TLNo from TechnicianLoan order by TLNo desc;", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            TLNo = Int(DR.Item("TLNo")) + 1
        Else
            TLNo = "1"
        End If
        CMDUPDATE("Insert Into TechnicianLoan(TLNo,TNo,TLDate,TLReason,TLAmount) Values(" & TLNo & "," & TSalaryTNo.ToString & ",#" & txtTSDate.Value & "#, 'This Loan was paid from Technician Salary No called " & txtTSNo.Text & "',-" & txt5.Text & ");")
        MsgBox("Salary Submit Successful!", vbExclamation + vbOKOnly)
        AutomaticPrimaryKey(txtTSNo, "Select Top 1 TSNo from TechnicianSalary order by TSNo desc;", "TSNo")
        Call CmdTSSearch_Click(sender, e)
    End Sub

    Private Sub cmdTSPrint_Click(sender As Object, e As EventArgs) Handles cmdTSPrint.Click
        Dim RPT As New rptTechnicianSalary
        Dim frm As New frmReport
        Dim DS1 As New DataSet
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT REPNO, REPAIR.DNO, DDATE, DELIVER.CUNO, CUNAME,CUTELNO1, REPAIR.PNO, " &
                                              "PCATEGORY, PNAME, PAIDPRICE, QTY, STATUS FROM CUSTOMER,DELIVER,REPAIR,PRODUCT,TECHNICIAN " &
                                              "WHERE CUSTOMER.CUNO = DELIVER.CUNO And REPAIR.PNO = PRODUCT.PNO And DELIVER.DNO " &
                                              "= REPAIR.DNO AND TECHNICIAN.TNO = REPAIR.TNO And TNAME = '" & cmbTName.Text & "' And DDate between #" & txtTSFrom.Value.Date & " 00:00:00# " &
                                              " And #" & txtTSTo.Value.Date & " 23:59:59# And Status='Repaired Delivered' and (TSalNo Is Null Or TSalNo " &
                                              "= 0)" & If(chkRepair.Checked = False, " AND 0", "") & " order by DDAte", CNN)
        DA1.Fill(DS1, "REPAIR")
            DA1.Fill(DS1, "DELIVER")
            DA1.Fill(DS1, "CUSTOMER")
            DA1.Fill(DS1, "PRODUCT")
        RPT.Subreports("rptTechnicianSalaryRepair.rpt").SetDataSource(DS1)
        Dim DS2 As New DataSet
            Dim DA2 As New OleDb.OleDbDataAdapter("SELECT RETNO, RETURN.DNO, DDATE, DELIVER.CUNO, CUNAME,CUTELNO1, RETURN.PNO, " &
                                                  "PCATEGORY, PNAME, PAIDPRICE, QTY, STATUS FROM CUSTOMER,DELIVER,RETURN," &
                                                  "PRODUCT,TECHNICIAN WHERE CUSTOMER.CUNO = DELIVER.CUNO And RETURN.PNO = PRODUCT.PNO And " &
                                                  "DELIVER.DNO = RETURN.DNO AND TECHNICIAN.TNO =RETURN.TNO And TNAME = '" & cmbTName.Text & "' And DDate Between #" &
                                                  txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                                  " 23:59:59# And Status='Repaired Delivered' and (TSalNo Is Null Or TSalNo = 0)" &
                                                  If(chkReturn.Checked = False, " AND 0", "") & ";", CNN)
            DA2.Fill(DS2, "RETURN")
            DA2.Fill(DS2, "DELIVER")
            DA2.Fill(DS2, "CUSTOMER")
            DA2.Fill(DS2, "PRODUCT")
            RPT.Subreports("rptTechnicianSalaryReRepair.rpt").SetDataSource(DS2)
            Dim DS6 As New DataSet
            Dim DA6 As New OleDb.OleDbDataAdapter("SELECT SAREPNO,SAREPDATE, SALESREPAIR.SNO, SCATEGORY, SNAME, RATE,QTY, TOTAL FROM ((SALESREPAIR " &
                                                  "INNER JOIN STOCK ON STOCK.SNO=SALESREPAIR.SNO) INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = SALESREPAIR.TNO) WHERE TNAME='" &
                                                  cmbTName.Text & "' And SaRepDate Between #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                                  " 23:59:59#" & If(chkSalesRepair.Checked = False, " AND 0", "") & ";", CNN)
            DA6.Fill(DS6, "SALESREPAIR")
            DA6.Fill(DS6, "STOCK")
            RPT.Subreports("rptTechnicianSalarySalesRepair.rpt").SetDataSource(DS6)
        Dim DS3 As New DataSet
        Dim DA3 As New OleDb.OleDbDataAdapter("SELECT TCNo,TCDATE,REPNO,RETNO,TechnicianCost.SNO,SCATEGORY,SNAME,RATE,QTY,TOTAL,TCREMARKS FROM (TECHNICIANCOST " &
                                                  "INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = TECHNICIANCOST.TNO) WHERE TNAME='" &
                                                  cmbTName.Text & "' And TCDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                                  " 23:59:59# And (TSalNo Is Null Or TSalNo = 0)" & If(chkCost.Checked = False, " AND 0", "") & ";", CNN)
            DA3.Fill(DS3, "TECHNICIANCOST")
            DA3.Fill(DS3, "STOCK")
            RPT.Subreports.Item("rptTechnicianSalaryCost.rpt").SetDataSource(DS3)
            Dim DT4 As New DataTable
            Dim DA4 As New OleDb.OleDbDataAdapter("SELECT TLNo,TLDATE, TechnicianLoan.SNo, SCategory, SName,TLREASON, RATE, QTY, TOTAL FROM (TECHNICIANLOAN INNER JOIN " &
                                                  "TECHNICIAN ON TECHNICIAN.TNO = TECHNICIANLOAN.TNO) WHERE TNAME='" & cmbTName.Text & "' And TLDate BETWEEN #" & txtTSFrom.Value.Date &
                                                  " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59#" & If(chkLoan.Checked = False, " AND 0", "") & ";", CNN)
            DA4.Fill(DT4)
        If grdLoan.Rows.Count > 0 And chkLoan.Checked = True Then
            If grdLoan.Item(0, 0).Value = "0" Then
                Dim newRow As DataRow = DT4.NewRow()
                If grdLoan.Item("TLNo", 0).Value.ToString <> "" Then newRow("TLNo") = Int(grdLoan.Item("TLNo", 0).Value)
                newRow("TLDate") = grdLoan.Item("TLDate", 0).Value.ToString
                newRow("SCategory") = grdLoan.Item("TLSCategory", 0).Value.ToString
                newRow("SName") = grdLoan.Item("TLSName", 0).Value.ToString
                newRow("TLReason") = grdLoan.Item("TLReason", 0).Value.ToString
                If grdLoan.Item("TLRate", 0).Value.ToString <> "" Then newRow("Rate") = Int(grdLoan.Item("TLRate", 0).Value)
                If grdLoan.Item("TLQty", 0).Value.ToString <> "" Then newRow("Qty") = Int(grdLoan.Item("TLQty", 0).Value)
                If grdLoan.Item("TLTotal", 0).Value.ToString <> "" Then newRow("Total") = Int(grdLoan.Item("TLTotal", 0).Value)
                DT4.Rows.InsertAt(newRow, 0)
            End If
        End If
        RPT.Subreports.Item("rptTechnicianSalaryLoan.rpt").SetDataSource(DT4)
        Dim DS5 As New DataSet
        Dim DA5 As New OleDb.OleDbDataAdapter("SELECT * FROM TECHNICIANSALARY", CNN)
        DA5.Fill(DS5, "TECHNICIANSALARY")
        RPT.SetDataSource(DS5)
        RPT.SetParameterValue("fromDate", txtTSFrom.Value.Date.ToString)
        RPT.SetParameterValue("ToDate", txtTSTo.Value.Date.ToString)
        RPT.SetParameterValue("Title", cmbTName.Text.ToUpper.ToString + "'S PAYSHEET")
        RPT.SetParameterValue("TotalofRepair", txtTotalRepair.Text)
        RPT.SetParameterValue("TotalofReRepair", txtTotalReRepair.Text)
        RPT.SetParameterValue("TotalofCost", txtTotalCost.Text)
        RPT.SetParameterValue("TotalofLoan", txtTotalLoan.Text)
        RPT.SetParameterValue("Salary", txt6.Text)
        If chkDetails.Checked = True Then
            RPT.SetParameterValue("ShowDetailSection", True)
        Else
            RPT.SetParameterValue("ShowDetailSection", False)
        End If
        frm.ReportViewer.ReportSource = RPT
        frm.Show(Me)
    End Sub

    Private Sub TechnicianSalaryCalculator()
        txt1.Text = Int(txtTotalRepair.Text) + Int(txtTotalReRepair.Text) + Int(txtTotalSalesRepair.Text)
        txt2.Text = txtTotalCost.Text
        txt3.Text = (Int(txt1.Text) - Int(txt2.Text)) / 2
        txt4.Text = txt3.Text
        txt5.Text = txtTotalLoan.Text
        txt6.Text = Int(txt4.Text) - Int(txt5.Text)
    End Sub

    Private Sub SendTechnicianSalaryToTechnicianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendTechnicianSalaryToTechnicianToolStripMenuItem.Click
        Dim RPT As New rptTechnicianSalary
        Dim frm As New frmReport
        Dim DS1 As New DataSet
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT REPNO, REPAIR.DNO, DDATE, DELIVER.CUNO, CUNAME,CUTELNO1, REPAIR.PNO, " &
                                              "PCATEGORY, PNAME, PAIDPRICE, QTY, STATUS FROM CUSTOMER,DELIVER,REPAIR,PRODUCT,TECHNICIAN " &
                                              "WHERE CUSTOMER.CUNO = DELIVER.CUNO And REPAIR.PNO = PRODUCT.PNO And DELIVER.DNO " &
                                              "= REPAIR.DNO AND TECHNICIAN.TNO = REPAIR.TNO And TNAME = '" & cmbTName.Text & "' And DDate between #" & txtTSFrom.Value.Date & " 00:00:00# " &
                                              " And #" & txtTSTo.Value.Date & " 23:59:59# And Status='Repaired Delivered' and (TSalNo Is Null Or TSalNo " &
                                              "= 0) order by DDAte;", CNN)
        DA1.Fill(DS1, "REPAIR")
        DA1.Fill(DS1, "DELIVER")
        DA1.Fill(DS1, "CUSTOMER")
        DA1.Fill(DS1, "PRODUCT")
        RPT.Subreports("rptTechnicianSalaryRepair.rpt").SetDataSource(DS1)
        Dim DS2 As New DataSet
        Dim DA2 As New OleDb.OleDbDataAdapter("SELECT RETNO, RETURN.DNO, DDATE, DELIVER.CUNO, CUNAME,CUTELNO1, RETURN.PNO, " &
                                              "PCATEGORY, PNAME, PAIDPRICE, QTY, STATUS FROM CUSTOMER,DELIVER,RETURN," &
                                              "PRODUCT,TECHNICIAN WHERE CUSTOMER.CUNO = DELIVER.CUNO And RETURN.PNO = PRODUCT.PNO And " &
                                              "DELIVER.DNO = RETURN.DNO AND TECHNICIAN.TNO =RETURN.TNO And TNAME = '" & cmbTName.Text & "' And DDate Between #" &
                                              txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                              " 23:59:59# And Status='Repaired Delivered' and (TSalNo Is Null Or TSalNo = 0);", CNN)
        DA2.Fill(DS2, "RETURN")
        DA2.Fill(DS2, "DELIVER")
        DA2.Fill(DS2, "CUSTOMER")
        DA2.Fill(DS2, "PRODUCT")
        RPT.Subreports("rptTechnicianSalaryReRepair.rpt").SetDataSource(DS2)
        Dim DS6 As New DataSet
        Dim DA6 As New OleDb.OleDbDataAdapter("SELECT SAREPNO,SAREPDATE, SALESREPAIR.SNO, SCATEGORY, SNAME, RATE,QTY, TOTAL FROM ((SALESREPAIR " &
                                              "INNER JOIN STOCK ON STOCK.SNO=SALESREPAIR.SNO) INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = SALESREPAIR.TNO) WHERE TNAME='" &
                                              cmbTName.Text & "' And SaRepDate Between #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59#;", CNN)
        DA6.Fill(DS6, "SALESREPAIR")
        DA6.Fill(DS6, "STOCK")
        RPT.Subreports("rptTechnicianSalarySalesRepair.rpt").SetDataSource(DS6)
        Dim DS3 As New DataSet
        Dim DA3 As New OleDb.OleDbDataAdapter("SELECT TCNo,TCDATE,REPNO,RETNO,SNO,SCATEGORY,SNAME,RATE,QTY,TOTAL,TCREMARKS FROM (TECHNICIANCOST " &
                                              "INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = TECHNICIANCOST.TNO) WHERE TNAME='" &
                                              cmbTName.Text & "' And TCDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                              " 23:59:59# And (TSalNo Is Null Or TSalNo = 0);", CNN)
        DA3.Fill(DS3, "TECHNICIANCOST")
        DA3.Fill(DS3, "STOCK")
        RPT.Subreports.Item("rptTechnicianSalaryCost.rpt").SetDataSource(DS3)
        Dim DT4 As New DataTable
        Dim DA4 As New OleDb.OleDbDataAdapter("SELECT TLNo,TLDATE, SNo, SCategory, SName,TLREASON, RATE, QTY, TOTAL FROM (TECHNICIANLOAN INNER JOIN " &
                                              "TECHNICIAN ON TECHNICIAN.TNO = TECHNICIANLOAN.TNO) WHERE TNAME='" & cmbTName.Text & "' And TLDate BETWEEN #" & txtTSFrom.Value.Date &
                                              " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59#;", CNN)
        DA4.Fill(DT4)
        If grdLoan.Rows.Count > 0 Then
            If grdLoan.Item(0, 0).Value = "0" Then
                Dim newRow As DataRow = DT4.NewRow()
                If grdLoan.Item("TLNo", 0).Value.ToString <> "" Then newRow("TLNo") = Int(grdLoan.Item("TLNo", 0).Value)
                newRow("TLDate") = grdLoan.Item("TLDate", 0).Value.ToString
                newRow("SCategory") = grdLoan.Item("TLSCategory", 0).Value.ToString
                newRow("SName") = grdLoan.Item("TLSName", 0).Value.ToString
                newRow("TLReason") = grdLoan.Item("TLReason", 0).Value.ToString
                If grdLoan.Item("TLRate", 0).Value.ToString <> "" Then newRow("Rate") = Int(grdLoan.Item("TLRate", 0).Value)
                If grdLoan.Item("TLQty", 0).Value.ToString <> "" Then newRow("Qty") = Int(grdLoan.Item("TLQty", 0).Value)
                If grdLoan.Item("TLTotal", 0).Value.ToString <> "" Then newRow("Total") = Int(grdLoan.Item("TLTotal", 0).Value)
                DT4.Rows.InsertAt(newRow, 0)
            End If
        End If
        RPT.Subreports.Item("rptTechnicianSalaryLoan.rpt").SetDataSource(DT4)
        Dim DS5 As New DataSet
        Dim DA5 As New OleDb.OleDbDataAdapter("SELECT * FROM TECHNICIANSALARY", CNN)
        DA5.Fill(DS5, "TECHNICIANSALARY")
        RPT.SetDataSource(DS5)
        RPT.SetParameterValue("fromDate", txtTSFrom.Value.Date.ToString)
        RPT.SetParameterValue("ToDate", txtTSTo.Value.Date.ToString)
        RPT.SetParameterValue("Title", cmbTName.Text.ToUpper.ToString + "'S PAYSHEET")
        RPT.SetParameterValue("TotalofRepair", txtTotalRepair.Text)
        RPT.SetParameterValue("TotalofReRepair", txtTotalReRepair.Text)
        RPT.SetParameterValue("TotalofCost", txtTotalCost.Text)
        RPT.SetParameterValue("TotalofLoan", txtTotalLoan.Text)
        RPT.SetParameterValue("Salary", txt6.Text)
        frm.ReportViewer.ReportSource = RPT
        CMD = New OleDb.OleDbCommand("Select * from Technician Where TNAME ='" & cmbTName.Text & "';", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            If DR("TEmail").ToString = "" Then
                MsgBox("මෙම Technician ගේ Email ලිපිනයක් ඇතුලත් කර නොමැත.", vbCritical + vbOKOnly)
                Exit Sub
            End If
        End If
        'Export PDF File code
        Dim fileName As String = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf"
        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions
        CrDiskFileDestinationOptions.DiskFileName = fileName
        CrExportOptions = RPT.ExportOptions
        With CrExportOptions
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptions
            .FormatOptions = CrFormatTypeOptions
        End With
        RPT.Export()
        CMDUPDATE("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status,Attachment1) Values(" &
                AutomaticPrimaryKeyStr("Mail", "MailNo") & ",#" & DateAndTime.Now &
                "#,'" & DR("TEmail").ToString & "','Technician Salary (from " & txtTSFrom.Value.Date.ToString & " To " & txtTSTo.Value.Date.ToString &
                  ")','LASER System " + Application.ProductVersion + vbCrLf + vbCrLf +
                 "Name: " & DR("TName").ToString & vbCrLf +
                 "From: " & txtTSFrom.Value.Date.ToString & vbCrLf &
                 "To: " & txtTSTo.Value.Date.ToString & vbCrLf &
            "මෙය LASER System තුලින් ස්වයංක්‍රීයව පැමිණෙන්නක් බැවින් මෙහි ගැටලුවක් පවතියි නම්, දත්ත කළමනාකරුව දැනුවත් කරන්න.','Waiting','" & fileName & "');")
        MsgBox("The Email has been sent sucessful!", vbOKOnly + vbInformation)
    End Sub

    Private Sub grdRepair_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdRepair.UserDeletingRow
        txtTotalRepair.Text = "0"
        For Each row As DataGridViewRow In grdRepair.Rows
            txtTotalRepair.Text += Int(row.Cells("Total").Value.ToString)
        Next
        Call TechnicianSalaryCalculator()
    End Sub

    Private Sub grdReRepair_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdReRepair.UserDeletingRow
        txtTotalReRepair.Text = "0"
        For Each row As DataGridViewRow In grdReRepair.Rows
            txtTotalReRepair.Text += Int(row.Cells("Total").Value.ToString)
        Next
        Call TechnicianSalaryCalculator()
    End Sub

    Private Sub grdSalesRepair_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdSalesRepair.UserDeletingRow
        txtTotalSalesRepair.Text = "0"
        For Each row As DataGridViewRow In grdSalesRepair.Rows
            txtTotalSalesRepair.Text += Int(row.Cells("Total").Value.ToString)
        Next
        Call TechnicianSalaryCalculator()
    End Sub

    Private Sub grdLoan_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdLoan.UserDeletingRow
        txtTotalLoan.Text = "0"
        For Each row As DataGridViewRow In grdLoan.Rows
            txtTotalLoan.Text += Int(row.Cells("TLAmount").Value.ToString)
        Next
        Call TechnicianSalaryCalculator()
    End Sub

    Private Sub grdCost_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdCost.UserDeletingRow
        txtTotalCost.Text = "0"
        For Each row As DataGridViewRow In grdCost.Rows
            txtTotalCost.Text += Int(row.Cells(9).Value.ToString)
        Next
        Call TechnicianSalaryCalculator()
    End Sub

    Private Sub txt5_TextChanged(sender As Object, e As EventArgs) Handles txt5.TextChanged
        If txt4.Text <> "" Or txt5.Text <> "" Then txt6.Text = Val(txt4.Text) - Val(txt5.Text)
    End Sub
End Class