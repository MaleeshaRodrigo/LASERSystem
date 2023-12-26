Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Net.Mail
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmTechnicianSalary
    Private Db As New Database
    Private Sub FrmTechnicianSalary_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub FrmTechnicianSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        txtTSNo.Text = Db.GetNextKey("TechnicianSalary", "TSNo")
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
        If CheckEmptyfield(cmbTName, "ඔබ තවමත් Technician කෙනෙකු තෝරා නැත. කරුණාකර Technician කෙනෙක් තෝරා ගන්න.") = False Then
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim x As String = ";"
        If chkPaidTSal.Checked = False Then x = " and (TSalNo is Null or TSalNo = 0);"
        Dim DT1 As DataTable = Db.GetDataTable("Select Repair.RepNo,DDate,CuName,CuTelNo1,CuTelNo2,CuTelNo3,PCategory,PName,Qty,PaidPrice,Status,'' as RepRemarks1,'' as RepRemarks2, TSalNo from Receive,Customer,Deliver,Repair,Product,Technician Where Receive.RNo = Repair.RNo and Product.PNo = Repair.PNo and Repair.DNo = Deliver.DNo and Customer.CuNo = Receive.CuNo and Technician.TNo = Repair.TNo and TName='" &
                                              cmbTName.Text & "' and DDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                              " 23:59:59# " + x)
        For Each row As DataRow In DT1.Rows
            Dim DR1 As MySqlDataReader = Db.GetDataReader("Select Remarks from RepairRemarks1 Where RepNo=" & row.Item("RepNo"))
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
        Dim DT2 As DataTable = Db.GetDataTable("Select Return.RetNo, RepNo, DDate, CuName, CuTelNo1, CuTelNo2, CuTelNo3, PCategory, PName, Qty, PaidPrice,Status, '' as RetRemarks1,'' as RetRemarks2, TSalNo from Receive,Customer, Deliver, Return, Product, Technician Where Receive.RNo=Return.RNo and Product.PNo = Return.PNo And Return.DNo = Deliver.DNo And Customer.CuNo = Receive.CuNo And Technician.TNo = Return.TNo And TName='" & cmbTName.Text &
                                              "' And DDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59# " + x)
        For Each row As DataRow In DT1.Rows
            Dim DR1 As MySqlDataReader = Db.GetDataReader("Select Remarks from RepairRemarks1 Where RepNo=" & row.Item("RepNo"))
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
        grdCost.DataSource = Db.GetDataTable("Select TechnicianCost.TCNo, TCDate, RepNo, RetNo, SNo, SCategory, SName, Rate, Qty, Total, TCRemarks, TSalNo from (TechnicianCost Inner Join Technician On Technician.TNo = TechnicianCost.TNo) Where TName='" & cmbTName.Text & "' And TCDate BETWEEN #" &
                                              txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59# " + x)
        grdCost.Refresh()
        For Each Row As DataGridViewRow In grdCost.Rows
            If Row.Cells("TCTotal").Value Is Nothing Then Continue For
            txtTotalCost.Text = Val(txtTotalCost.Text) + Val(Row.Cells("TCTotal").Value)
        Next
        Dim DT4 As DataTable = Db.GetDataTable("Select  TLNo, TLDate, SCategory, SName, TLReason, Rate, Qty,Total from (TechnicianLoan TL Inner Join Technician T on T.TNo = TL.TNo) Where TName='" & cmbTName.Text & "' And TLDate BETWEEN #" &
                                              txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59# ")
        DR = Db.GetDataReader("Select * from TechnicianLoan as TL Where TL.TLDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# and #" &
                                     txtTSTo.Value.Date & " 23:59:59#;")
        Dim ArrearsLoan As Integer = 0
        While DR.Read
            If DR("Total").ToString <> "" Then ArrearsLoan += Int(DR("Total").ToString)
        End While
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
        grdSalesRepair.DataSource = Db.GetDataTable("Select SaRepNo, SaRepDate, SCategory, SName, Rate, Qty, Total, TSalNo from SalesRepair,Stock,Technician where Technician.TNo = SalesRepair.TNo And Stock.SNo = SalesRepair.Sno And  TName = '" & cmbTName.Text & "' And SaRepDate Between #" &
                                              txtTSFrom.Value.Date & " 00:00:00# and #" & txtTSTo.Value.Date & " 23:59:59#" + x)
        grdSalesRepair.Refresh()
        For Each Row As DataGridViewRow In grdSalesRepair.Rows
            txtTotalSalesRepair.Text = Int(txtTotalSalesRepair.Text) + Int(Row.Cells("Total").Value.ToString)
        Next
        'calculator part for making salary
        Call TechnicianSalaryCalculator()
        Cursor = Cursors.Default()
    End Sub

    Private Sub CmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call ComboBoxDropDown(Db, cmbTName, "Select TName from Technician group by TName;")
    End Sub

    Private Sub cmdTSCancel_Click(sender As Object, e As EventArgs) Handles cmdTSCancel.Click
        Call FrmTechnicianSalary_Leave(sender, e)
    End Sub

    Private Sub cmdTCDone_Click(sender As Object, e As EventArgs) Handles cmdTSDone.Click
        If CheckEmptyfield(cmbTName, "This operation couldn't be done because Technician was already empty. You should select any Technician and try again.") = False Then
            cmbTName.Focus()
            Exit Sub
        ElseIf CheckExistData(txtTSNo, "Select TSNo from TechnicianSalary where TSNo =" & txtTSNo.Text, "This operation couldn't be done because 'Technician Salary No' was exist in the database. Something was wrong. Please find why that was or call developer of this system.", True) = True Then
            txtTSNo.Focus()
            Exit Sub
        ElseIf CheckExistData(cmbTName, "Select TName from Technician Where TName='" & cmbTName.Text & "'", "Technician Name එක සොයා ගැනීමට නොහැකි විය. කරුණාකර ඔබ ඇතුලත් කල Technician නිවැරදි දැයි පරික්ෂා කරන්න.", False) = False Then
            cmbTName.Focus()
            Exit Sub
        End If
        If chkPaidTSal.Checked = True Then
            MsgBox("You have marked checkbox called 'with Paid Technician Salary'. Therefore This operation couldn't be submitted. So you should unmark that and try agin", vbCritical + vbOKOnly)
            Exit Sub
        End If
        Dim TSalaryTNo As Integer
        Dim DR As MySqlDataReader = Db.GetDataReader("Select TNo, TName from Technician Where Tname='" & cmbTName.Text & "';")
        If DR.HasRows = True Then
            DR.Read()
            TSalaryTNo = DR("TNo").ToString
        End If
        Db.Execute("Insert into TechnicianSalary(TSNo,TNo,TSDate,TotalRepair,TotalReRepair,TotalSalesRepair,TotalCost,TotalLoan,Earned,AddedLoan,Salary) Values(" & txtTSNo.Text & "," & TSalaryTNo.ToString & ",#" & txtTSDate.Value.Date & "#," & txtTotalRepair.Text & "," & txtTotalReRepair.Text & "," & txtTotalSalesRepair.Text & "," & txtTotalCost.Text & "," & txtTotalLoan.Text & "," & txt3.Text & "," & txt5.Text & "," & txt6.Text & ");")
        For Each Row As DataGridViewRow In grdRepair.Rows
            Db.Execute("Update Repair set TSalNo =" & txtTSNo.Text & " where RepNo=" & Row.Cells(0).Value.ToString)
        Next
        For Each Row As DataGridViewRow In grdReRepair.Rows
            Db.Execute("Update `Return` set TSalNo =" & txtTSNo.Text & " where RetNO=" & Row.Cells(0).Value.ToString)
        Next
        For Each Row As DataGridViewRow In grdSalesRepair.Rows
            Db.Execute("Update SalesRepair set TSalNo =" & txtTSNo.Text & " where SaRepNo=" & Row.Cells(0).Value.ToString)
        Next
        For Each Row As DataGridViewRow In grdCost.Rows
            Db.Execute("Update TechnicianCost set TSalNo = " & txtTSNo.Text & " where TCNo=" & Row.Cells(1).Value.ToString)
        Next
        Dim TLNo As String
        DR = Db.GetDataReader("Select Top 1 TLNo from TechnicianLoan order by TLNo desc;")
        If DR.HasRows = True Then
            DR.Read()
            TLNo = Int(DR.Item("TLNo")) + 1
        Else
            TLNo = "1"
        End If
        Db.Execute("Insert Into TechnicianLoan(TLNo,TNo,TLDate,TLReason,TLAmount) Values(" & TLNo & "," & TSalaryTNo.ToString & ",#" & txtTSDate.Value & "#, 'This Loan was paid from Technician Salary No called " & txtTSNo.Text & "',-" & txt5.Text & ");")
        MsgBox("Salary Submit Successful!", vbExclamation + vbOKOnly)
        txtTSNo.Text = Db.GetNextKey("TechnicianSalary", "TSNo")
        Call CmdTSSearch_Click(sender, e)
    End Sub

    Private Sub cmdTSPrint_Click(sender As Object, e As EventArgs) Handles cmdTSPrint.Click
        Dim frm As New frmReport
        frm.ReportViewer.ReportSource = TechnicianSalaryReport()
        frm.Show(Me)
    End Sub

    Private Function TechnicianSalaryReport() As rptTechnicianSalary
        Dim RPT As New rptTechnicianSalary
        Dim DT1 As DataTable = Db.GetDataTable("SELECT REPNO, DDATE, CUNAME,CUTELNO1,
                                              PCATEGORY, PNAME, PAIDPRICE, QTY FROM (((((REPAIR INNER JOIN RECEIVE ON RECEIVE.RNO = REPAIR.RNO)
                                              LEFT JOIN CUSTOMER ON CUSTOMER.CUNO=RECEIVE.CUNO) INNER JOIN DELIVER ON DELIVER.DNO=REPAIR.DNO) 
                                              LEFT JOIN PRODUCT ON PRODUCT.PNO=REPAIR.PNO) INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = REPAIR.TNO)
                                              WHERE TNAME = '" & cmbTName.Text & "' And DDate between #" & txtTSFrom.Value.Date & " 00:00:00#  And #" & txtTSTo.Value.Date & " 23:59:59# And Status='Repaired Delivered' and (TSalNo Is Null Or TSalNo = 0)" & If(chkRepair.Checked = False, " AND 0", "") & " order by DDAte")
        RPT.Subreports("rptTechnicianSalaryRepair.rpt").SetDataSource(DT1)
        Dim DT2 As DataTable = Db.GetDataTable("SELECT RETNO, REPNO,DDATE, CUNAME,CUTELNO1, PCATEGORY, PNAME, PAIDPRICE, QTY FROM 
                                                (((((RETURN INNER JOIN RECEIVE ON RECEIVE.RNO=RETURN.RNO) 
                                                LEFT JOIN CUSTOMER ON CUSTOMER.CUNO = RECEIVE.CUNO)
                                                INNER JOIN DELIVER ON DELIVER.DNO =RETURN.DNO)
                                                LEFT JOIN PRODUCT ON PRODUCT.PNO=RETURN.PNO)
                                                INNER JOIN TECHNICIAN ON TECHNICIAN.TNO=RETURN.TNO) 
                                                WHERE TNAME = '" & cmbTName.Text & "' And DDate Between #" &
                                                  txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                                  " 23:59:59# And Status='Repaired Delivered' and (TSalNo Is Null Or TSalNo = 0)" &
                                                  If(chkReturn.Checked = False, " AND 0", "") & ";")
        RPT.Subreports("rptTechnicianSalaryReRepair.rpt").SetDataSource(DT2)
        Dim DS6 As New DataSet
        Dim DA6 As MySqlDataAdapter = Db.GetDataAdapter("SELECT SAREPNO,SAREPDATE, SALESREPAIR.SNO, SCATEGORY, SNAME, RATE,QTY, TOTAL FROM ((SALESREPAIR INNER JOIN STOCK ON STOCK.SNO=SALESREPAIR.SNO) INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = SALESREPAIR.TNO) WHERE TNAME='" &
                                              cmbTName.Text & "' And SaRepDate Between #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                              " 23:59:59#" & If(chkSalesRepair.Checked = False, " AND 0", "") & ";")
        DA6.Fill(DS6, "SALESREPAIR")
        DA6.Fill(DS6, "STOCK")
        RPT.Subreports("rptTechnicianSalarySalesRepair.rpt").SetDataSource(DS6)
        Dim DS3 As New DataSet
        Dim DA3 As MySqlDataAdapter = Db.GetDataAdapter("SELECT TCNo,TCDATE,REPNO,RETNO,TechnicianCost.SNO,SCATEGORY,SNAME,RATE,QTY,TOTAL,TCREMARKS FROM (TECHNICIANCOST INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = TECHNICIANCOST.TNO) WHERE TNAME='" &
                                                  cmbTName.Text & "' And TCDate BETWEEN #" & txtTSFrom.Value.Date & " 00:00:00# And #" & txtTSTo.Value.Date &
                                                  " 23:59:59# And (TSalNo Is Null Or TSalNo = 0)" & If(chkCost.Checked = False, " AND 0", "") & ";")
        DA3.Fill(DS3, "TECHNICIANCOST")
        DA3.Fill(DS3, "STOCK")
        RPT.Subreports.Item("rptTechnicianSalaryCost.rpt").SetDataSource(DS3)
        Dim DT4 As DataTable = Db.GetDataTable("SELECT TLNo,TLDATE, TechnicianLoan.SNo, SCategory, SName,TLREASON, RATE, QTY, TOTAL FROM (TECHNICIANLOAN INNER JOIN TECHNICIAN ON TECHNICIAN.TNO = TECHNICIANLOAN.TNO) WHERE TNAME='" & cmbTName.Text & "' And TLDate BETWEEN #" &
                                              txtTSFrom.Value.Date &
                                              " 00:00:00# And #" & txtTSTo.Value.Date & " 23:59:59#" & If(chkLoan.Checked = False, " AND 0", "") & ";")
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
        Dim DA5 As MySqlDataAdapter = Db.GetDataAdapter("SELECT * FROM TECHNICIANSALARY")
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
        Return RPT
    End Function

    Private Sub TechnicianSalaryCalculator()
        txt1.Text = Int(txtTotalRepair.Text) + Int(txtTotalReRepair.Text) + Int(txtTotalSalesRepair.Text)
        txt2.Text = txtTotalCost.Text
        txt3.Text = (Int(txt1.Text) - Int(txt2.Text)) / 2
        txt4.Text = txt3.Text
        txt5.Text = txtTotalLoan.Text
        txt6.Text = Int(txt4.Text) - Int(txt5.Text)
    End Sub

    Private Sub SendTechnicianSalaryToTechnicianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendTechnicianSalaryToTechnicianToolStripMenuItem.Click
        Dim frm As New frmReport
        Dim RPT As rptTechnicianSalary = TechnicianSalaryReport()
        frm.ReportViewer.ReportSource = RPT
        Dim DR As MySqlDataReader = Db.GetDataReader("Select * from Technician Where TNAME ='" & cmbTName.Text & "';")
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
        Db.Execute("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status,Attachment1) Values(" &
                Db.GetNextKey("Mail", "MailNo") & ",#" & DateAndTime.Now &
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