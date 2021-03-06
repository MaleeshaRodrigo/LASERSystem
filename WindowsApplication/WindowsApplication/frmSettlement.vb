Imports CrystalDecisions.Shared
Imports System.IO
Public Class frmSettlement

    Private Sub frmSettlement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        MenuStrip.Items.Add(mnustrpMENU)
        txtFrom.Value = Today
        txtTo.Value = Today
        CmdTANew_Click(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtLockerCash.Text = "" Then
            MsgBox("Cash in Locker is empty, fill it", vbOKOnly + vbExclamation)
            Exit Sub
        ElseIf txtFrom.Value.Date <> txtTo.Value.Date Then
            MsgBox("'From' Date Value and 'To' Date Value is different. Therefore this record couldn't be saved. You should change that to a date.", vbOKOnly + vbCritical)
            Exit Sub
        ElseIf MdifrmMain.tslblUserType.Text <> "Admin" And txtFrom.Value.Date <> Today.Date Then
            MsgBox("ඔබට පැරණි දින වල Settlement වෙනස් කිරීමට Permission ලබා දී නොමැත. කරුණාකර Admin කෙනෙකු අමතන්න.", vbCritical + vbOKOnly)
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        CMD = New OleDb.OleDbCommand("Select * from Settlement where SetDate=#" & txtFrom.Value.Date & "#", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            CMDUPDATE("Update Settlement Set SaTotal =" & txtTotalofSales.Text & ", RepTotal = " & txtTotalofRepairs.Text & ",TATotal=" & txtTotalofTransactions.Text &
                                              ",SetGrandTotal=" & txtIncome.Text & ",CTotal=" & txtCTotal.Text & ",CPTotal =" & txtCPTotal.Text & ",CuLTotal =" & txtCuLTotal.Text &
                                              ",CPReceiptQty=" & txtCPQtyInvoice.Text & ",CashinLocker=" & txtLockerCash.Text & ",SetChange = " & txtChange.Text &
                                              ",LKR5000=" & txtLKR5000.Text & ",LKR1000=" & txtLKR1000.Text & ",LKR500=" & txtLKR500.Text & ",LKR100=" & txtLKR100.Text &
                                              ",LKR50=" & txtLKR50.Text & ",LKR20=" & txtLKR20.Text & ",LKR10=" & txtLKR10.Text & ",LKR5=" & txtLKR5.Text & ",LKR2=" & txtLKR2.Text &
                                              ",LKR1=" & txtLKR1.Text & " Where SetDate =#" & txtFrom.Value.Date & "#;")
        Else
            CMDUPDATE("Insert into Settlement(SetDate,SaTotal,RepTotal,TATotal,SetGrandTotal,CTotal,CPTotal,CuLTotal,CPReceiptQty,CashinLocker,SetChange," &
                                              "LKR5000,LKR1000,LKR500,LKR100,LKR50,LKR20,LKR10,LKR5,LKR2,LKR1) Values(#" & txtFrom.Value.Date & "#," & txtTotalofSales.Text & "," &
                                              txtTotalofRepairs.Text & "," & txtTotalofTransactions.Text & "," & txtIncome.Text & "," & txtCTotal.Text & "," & txtCPTotal.Text & "," &
                                              txtCuLTotal.Text & "," & txtCPQtyInvoice.Text & "," & txtLockerCash.Text & "," & txtChange.Text & "," & txtLKR5000.Text & "," & txtLKR1000.Text &
                                              "," & txtLKR500.Text & "," & txtLKR100.Text & "," & txtLKR50.Text & "," & txtLKR20.Text & "," & txtLKR10.Text & "," & txtLKR5.Text & "," & txtLKR2.Text &
                                              "," & txtLKR1.Text & ");")
        End If

        Try
            If CheckForInternetConnection() = False Then Exit Try
            Dim Simple As New Simple3Des("RandomKey45")
            If My.Settings.SendSettlementEmail = "False" Then Exit Try
            For Each controlObject As Control In MdifrmMain.flpMessage.Controls
                If controlObject.Tag = "SendAdminsSettlementError" Then
                    Exit Try
                End If
            Next
            If File.Exists(Path.Combine(Application.StartupPath & "\Reports", "SettlementSheet " & Today.Year.ToString & " - " &
                                            Today.Month.ToString & " - " & Today.Day.ToString & ".pdf")) Or File.Exists(Path.Combine(Application.StartupPath &
                                            "\Reports", "TechnicianCost " & Today.Year.ToString & " - " & Today.Month.ToString & " - " & Today.Day.ToString &
                                            ".pdf")) Or File.Exists(Path.Combine(Application.StartupPath & "\Reports", "TechinicianLoan " & Today.Year.ToString &
                                            " - " & Today.Month.ToString & " - " & Today.Day.ToString & ".pdf")) Then Exit Sub
            MdifrmMain.tsProBar.Visible = True
            MdifrmMain.tsProBar.Value = 0
            MdifrmMain.tslblLoad.Text = "Collecting Data for Settlement Report..."

            Dim RPT As New LASERSystem.rptSettlement
            Dim DT1 As New DataTable
            Dim SaTotal, RepTotal, CTotal, CPTotal, CuLTotal, CPQty, TATotal, GrandTotal As Integer
            Dim DA1 As New OleDb.OleDbDataAdapter("SELECT sale.SaNo, sale.SaDate, sale.CuNo, Customer.CuName, Customer.CuTelNo1, Customer.CuTelNo2, " &
                                                      "Customer.CuTelNo3, StockSale.SNo, SCategory, SName, StockSale.SaType, StockSale.SaUnits, " &
                                                      "StockSale.SaRate, StockSale.SaTotal, sale.SaSubTotal, sale.SaLess, sale.SaDue, sale.CReceived, sale.CBalance, " &
                                                      "sale.CAmount, sale.CPInvoiceNo, sale.CPAmount, sale.CuLNo, sale.CuLAmount FROM [Customer], [sale], " &
                                                      "[StockSale] where Customer.CuNo = Sale.CuNo And Sale.SaNo = StockSale.SaNo And " &
                                                      "SaDate Between #" & Today.Date & " 00:00:00# And #" & Today.Date & " 23:59:59#", CNN)
            DA1.Fill(DT1)
            SaTotal = 0
            CTotal = 0
            CuLTotal = 0
            CPTotal = 0
            CPQty = 0
            GrandTotal = 0
            TATotal = 0
            For Each row As DataRow In DT1.Rows
                SaTotal += row("SaDue")
                If row("CAmount").ToString <> "" And row("CAmount").ToString <> "0" Then CTotal += Val(row("CAmount"))
                If row("CuLAmount").ToString <> "" And row("CuLAmount").ToString <> "0" Then CuLTotal += Val(row("CuLAmount"))
                If row("CPAmount").ToString <> "" And row("CPAmount").ToString <> "0" Then
                    CPTotal += Val(row("CPAmount"))
                    CPQty += 1
                End If
            Next
            RPT.Subreports("rptSettlementSale.rpt").SetDataSource(DT1)
            Dim DT2 As New DataTable
            Dim DA2 As New OleDb.OleDbDataAdapter("SELECT RepNo,Repair.PNo,PCategory,PName, PaidPrice, Qty, Status, Repair.TNo,TName, Repair.Dno, DDate, " &
                                                      "Deliver.CuNo, CuName, CuTelNo1,DGrandTotal, CAmount, CReceived, CBalance, CPInvoiceNo, CPAmount, CuLNo, " &
                                                      "CuLAmount, 'Repair' as [TableName]  from Deliver, Customer,Repair,Technician, Product where " &
                                                      "Product.Pno = Repair.Pno and Repair.TNo = Technician.TNo and Customer.Cuno = Deliver.CuNo and " &
                                                      "Repair.Dno = Deliver.Dno and Deliver.DDate Between #" & Today.Date & " 00:00:00# and #" & Today.Date &
                                                      " 23:59:59# UNION Select RetNo, Return.PNo,PCategory,PName, PaidPrice, Qty, Status, Return.TNo, TName, " &
                                                      "Return.Dno, DDate, Deliver.CuNo, CuName, CuTelNo1,DGrandTotal, CAmount, CReceived, CBalance, CPInvoiceNo, " &
                                                      "CPAmount, CuLNo, CuLAmount, 'Re-Repair' as [TableName] from Deliver, Customer,Return,Product, Technician " &
                                                      "where Product.Pno = Return.Pno and Return.TNo = Technician.TNo and Customer.Cuno = Deliver.CuNo and " &
                                                      "Return.Dno = Deliver.Dno and Deliver.DDate Between #" & Today.Date & " 00:00:00# and #" & Today.Date &
                                                      " 23:59:59#;", CNN)
            DA2.Fill(DT2)
            RepTotal = 0
            For Each row As DataRow In DT2.Rows
                RepTotal += row("DGrandTotal")
                If row("CAmount").ToString <> "" And row("CAmount").ToString <> "0" Then CTotal += Val(row("CAmount"))
                If row("CuLAmount").ToString <> "" And row("CuLAmount").ToString <> "0" Then CuLTotal += Val(row("CuLAmount"))
                If row("CPAmount").ToString <> "" And row("CPAmount").ToString <> "0" Then
                    CPTotal += Val(row("CPAmount"))
                    CPQty += 1
                End If
            Next
            RPT.Subreports("rptSettlementDeliver.rpt").SetDataSource(DT2)
            Dim DT3 As New DataTable
            Dim DA3 As New OleDb.OleDbDataAdapter("SELECT TANO,TADATE,TADETAILS,TAAMOUNT FROM [TRANSACTION] WHERE TADATE BETWEEN #" & Today.Date &
                                                      " 00:00:00# AND #" & Today.Date & " 23:59:59#;", CNN)
            DA3.Fill(DT3)
            For Each row As DataRow In DT3.Rows
                TATotal += row("TAAmount")
                If row("TAAmount").ToString <> "" And row("TAAmount").ToString <> "0" Then CTotal += Val(row("TAAmount"))
            Next
            GrandTotal = SaTotal + RepTotal + TATotal
            RPT.Subreports("rptSettlementTransaction").SetDataSource(DT3)
            Dim DS4 As New DataSet
            Dim DA4 As New OleDb.OleDbDataAdapter("SELECT * from Settlement;", CNN)
            DA4.Fill(DS4, "Settlement")
            RPT.SetDataSource(DS4)
            RPT.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text)
            RPT.SetParameterValue("SetDate", Today.Date)
            RPT.SetParameterValue("SaTotal", SaTotal)
            RPT.SetParameterValue("RepTotal", RepTotal)
            RPT.SetParameterValue("CTotal", CTotal)
            RPT.SetParameterValue("CPTotal", CPTotal)
            RPT.SetParameterValue("CuLTotal", CuLTotal)
            RPT.SetParameterValue("CPQty", CPQty)
            RPT.SetParameterValue("GrandTotal", GrandTotal)
            RPT.SetParameterValue("CashinLocker", "0")
            RPT.SetParameterValue("Change", "0")
            MdifrmMain.tsProBar.Value = 30
            MdifrmMain.tslblLoad.Text = "Collecting Data for Technician Cost Report..."
            Dim RPT1 As New rptTechnicianCost
            Dim DS1 As New DataSet
            Dim DA5 As New OleDb.OleDbDataAdapter("SELECT TCNO,TCDATE,TECHNICIANCOST.TNO,TNAME,REPNO,RETNO,SNO,SCATEGORY,SNAME," &
                                                      "RATE,QTY,TOTAL,TCREMARKS FROM (TECHNICIANCOST INNER JOIN TECHNICIAN  ON TECHNICIAN.TNO = " &
                                                      "TECHNICIANCOST.TNO) WHERE TCDATE Between #" &
                                                      Today.Date & " 00:00:00# and #" & Today.Date & " 23:59:59#;", CNN)
            DA5.Fill(DS1, "TECHNICIANCOST")
            DA5.Fill(DS1, "STOCK")
            DA5.Fill(DS1, "TECHNICIAN")
            RPT1.SetDataSource(DS1)
            MdifrmMain.tsProBar.Value = 40
            MdifrmMain.tslblLoad.Text = "Collecting Data for Technician Loan Report..."
            Dim RPT2 As New rptTechnicianLoan
            Dim frm2 As New frmReport
            Dim DS2 As New DataSet
            Dim DA6 As New OleDb.OleDbDataAdapter("SELECT TLNO,TL.TNO,TNAME,TLDATE,SNO,SCATEGORY,SNAME,TLREASON,QTY,RATE,TOTAL FROM " &
                                                      "(TECHNICIANLOAN TL INNER JOIN TECHNICIAN T ON T.TNO = TL.TNO) " &
                                                      "WHERE TLDATE Between #" & Today.Date & " 00:00:00# and #" & Today.Date & " 23:59:59#;", CNN)
            DA6.Fill(DS2, "TECHNICIANLOAN")
            DA6.Fill(DS2, "STOCK")
            DA6.Fill(DS2, "TECHNICIAN")
            RPT2.SetDataSource(DS2)
            MdifrmMain.tsProBar.Value = 50
            MdifrmMain.tslblLoad.Text = "Creating Settlement Report..."
            If DT1.Rows.Count > 0 Or DT2.Rows.Count > 0 Or DT3.Rows.Count > 0 Then
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions
                CrDiskFileDestinationOptions.DiskFileName = Path.Combine(Application.StartupPath & "\Reports", "SettlementSheet " &
                                                                             Today.Year.ToString & " - " & Today.Month.ToString & " - " &
                                                                             Today.Day.ToString & ".pdf")
                CrExportOptions = RPT.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                RPT.Export()
            End If

            MdifrmMain.tsProBar.Value = 60
            MdifrmMain.tslblLoad.Text = "Creating Technician Cost Report..."
            If DS1.Tables("TechnicianCost").Rows.Count > 0 Then
                Dim CrExportOptions1 As ExportOptions
                Dim CrDiskFileDestinationOptions1 As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions1 As New PdfRtfWordFormatOptions
                CrDiskFileDestinationOptions1.DiskFileName = Path.Combine(Application.StartupPath & "\Reports", "TechnicianCost " &
                                                                              Today.Year.ToString & " - " & Today.Month.ToString & " - " &
                                                                              Today.Day.ToString & ".pdf")
                CrExportOptions1 = RPT1.ExportOptions
                With CrExportOptions1
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions1
                    .FormatOptions = CrFormatTypeOptions1
                End With
                RPT1.Export()
            End If

            MdifrmMain.tsProBar.Value = 70
            MdifrmMain.tslblLoad.Text = "Creating Technician Loan Report..."
            If DS2.Tables("TechnicianLoan").Rows.Count > 0 Then
                Dim CrExportOptions2 As ExportOptions
                Dim CrDiskFileDestinationOptions2 As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions2 As New PdfRtfWordFormatOptions
                CrDiskFileDestinationOptions2.DiskFileName = Path.Combine(Application.StartupPath & "\Reports", "TechnicianLoan " &
                                                                              Today.Year.ToString & " - " & Today.Month.ToString & " - " &
                                                                              Today.Day.ToString & ".pdf")
                CrExportOptions2 = RPT2.ExportOptions
                With CrExportOptions2
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions2
                    .FormatOptions = CrFormatTypeOptions2
                End With
                RPT2.Export()
            End If


            If DT1.Rows.Count > 0 Or DT2.Rows.Count > 0 Or DT3.Rows.Count > 0 Or DS1.Tables("TechnicianCost").Rows.Count > 0 Or
                    DS2.Tables("TechnicianLoan").Rows.Count > 0 Then
                MdifrmMain.tsProBar.Value = 80
                MdifrmMain.tslblLoad.Text = "Sending Email..."
                CMDUPDATE("Insert Into Mail(MailNo,MailDate,EmailTo,Subject,Body,Status,Attachment1,Attachment2,Attachment3) Values(" &
                                AutomaticPrimaryKeyStr("Mail", "MailNo") & ",#" & DateAndTime.Now &
                                "#,'" & My.Settings.AdminEmail & "','Settlement " & Today.Date.ToString & "','මෙය LASER System එකෙන් Automatically පැමිණන Email " &
                              "එකක් බැවින් ඔබට මෙය නැවැත්වීමට අවශ්‍යනම්, අපගේ Programe Developer හට දැනුම් දෙන්න.','Waiting','" &
                    If(File.Exists(Application.StartupPath & "\Reports\SettlementSheet " & Today.Year.ToString & " - " & Today.Month.ToString & " - " &
                                   Today.Day.ToString & ".pdf"), Application.StartupPath & "\Reports\SettlementSheet " & Today.Year.ToString & " - " &
                                                                    Today.Month.ToString & " - " & Today.Day.ToString & ".pdf", "") & "','" &
                    If(File.Exists(Application.StartupPath & "\Reports\TechnicianCost " & Today.Year.ToString & " - " & Today.Month.ToString & " - " &
                                   Today.Day.ToString & ".pdf"), Application.StartupPath & "\Reports\TechnicianCost " & Today.Year.ToString & " - " &
                                                                     Today.Month.ToString & " - " & Today.Day.ToString & ".pdf", "") & "','" &
                    If(File.Exists(Application.StartupPath & "\Reports\TechnicianLoan " & Today.Year.ToString & " - " & Today.Month.ToString & " - " &
                                   Today.Day.ToString & ".pdf"), Application.StartupPath & "\Reports\TechnicianLoan " & Today.Year.ToString & " - " &
                                                                     Today.Month.ToString & " - " & Today.Day.ToString & ".pdf", "") & "')")
            End If
            MdifrmMain.tsProBar.Value = 100
            MdifrmMain.tslblLoad.Text = "Settlement Email sent successfull..."
            RPT.Close()
            RPT1.Close()
            RPT2.Close()
        Catch ex As Exception
            CreateMessagePanel("ස්වයංක්‍රීයව දවසේ Settlements Admin ලට යැවෙන Emails ක්‍රියාවිරහිත වී ඇත.",
        "ස්වයංක්‍රීයව දවසේ Settlements Admin ලට Emails යැවෙන පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
        vbCrLf + vbCrLf + "Message: " + ex.Message + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendAdminsSettlementError")
            Exit Sub
        End Try
        Cursor = Cursors.Default
        MsgBox("Save Succefull!", vbOKOnly + vbExclamation)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim DT0, DT1, DT2 As New DataTable
        Dim DA0 As New OleDb.OleDbDataAdapter("Select Sale.SaNo,CuName,CuTelNo1,SaSubTotal,SaLess,SaDue,CReceived,CBalance,CAmount,CPInvoiceNo,CPAmount,CuLno,CuLAmount,SaRemarks from Sale,Customer where Sale.CuNo=Customer.CuNo And SaDate BETWEEN #" & txtFrom.Value.Date & " 0000:00# And #" & txtTo.Value.Date & " 23:59:59#;", CNN)
        DA0.Fill(DT0)
        grdSale.DataSource = DT0
        grdSale.Refresh()
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT Deliver.DNo,CuName,CuTelNo1,DGrandTotal, CReceived,CBalance,CAmount,CPInvoiceNo,CPAmount,CuLno,CuLAmount,DRemarks from Customer,Deliver where Customer.CuNo = Deliver.CuNo And DDate BETWEEN #" & txtFrom.Value.Date & " 0000:00# And #" & txtTo.Value.Date & " 23:59:59#;", CNN)
        DA1.Fill(DT1)
        grdDeliver.DataSource = DT1
        grdDeliver.Refresh()
        Dim DA2 As New OleDb.OleDbDataAdapter("SELECT * from [Transaction] where TADate BETWEEN #" & txtFrom.Value.Date & " 0000:00# And #" & txtTo.Value.Date & " 23:59:59#;", CNN)
        DA2.Fill(DT2)
        grdTransaction.DataSource = DT2
        grdTransaction.Refresh()
        Call CmdTANew_Click(sender, e)
        txtTotalofRepairs.Text = "0"
        txtTotalofSales.Text = "0"
        txtIncome.Text = "0"
        txtCTotal.Text = "0"
        txtCPTotal.Text = "0"
        txtCuLTotal.Text = "0"
        txtCPQtyInvoice.Text = "0"
        txtLockerCash.Text = "0"
        txtChange.Text = "0"
        If txtFrom.Value.Date = txtTo.Value.Date Then
            CMD = New OleDb.OleDbCommand("Select * from Settlement where SetDate =#" & txtFrom.Value.Date & "#", CNN)
            DR = CMD.ExecuteReader()
            If DR.HasRows = True Then
                DR.Read()
                txtLockerCash.Text = DR("CashinLocker").ToString
                txtLKR5000.Text = DR("LKR5000").ToString
                txtLKR1000.Text = DR("LKR1000").ToString
                txtLKR500.Text = DR("LKR500").ToString
                txtLKR100.Text = DR("LKR100").ToString
                txtLKR50.Text = DR("LKR50").ToString
                txtLKR20.Text = DR("LKR20").ToString
                txtLKR10.Text = DR("LKR10").ToString
                txtLKR5.Text = DR("LKR5").ToString
                txtLKR2.Text = DR("LKR2").ToString
                txtLKR1.Text = DR("LKR1").ToString
            End If
        End If
        For Each row As DataRow In DT0.Rows
            txtIncome.Text += Int(row.Item("SaDue").ToString)
            txtCTotal.Text += Int(row.Item("CAmount").ToString)
            txtCPTotal.Text += Int(row.Item("CPAmount").ToString)
            txtCuLTotal.Text += Int(row.Item("CuLAmount").ToString)
            txtTotalofSales.Text += Int(row.Item("SaDue").ToString)
            If row.Item("CPAmount").ToString <> "0" Then txtCPQtyInvoice.Text += 1
        Next
        For Each row As DataRow In DT1.Rows
            txtIncome.Text += Int(row.Item("DGrandTotal").ToString)
            txtCTotal.Text += Int(row.Item("CAmount").ToString)
            txtCPTotal.Text += Int(row.Item("CPAmount").ToString)
            txtCuLTotal.Text += Int(row.Item("CuLAmount").ToString)
            txtTotalofRepairs.Text += Int(row.Item("DGrandTotal").ToString)
            If row.Item("CPAmount").ToString <> "0" Then txtCPQtyInvoice.Text += 1
        Next
        For Each row As DataRow In DT2.Rows
            txtIncome.Text += Int(row.Item("TAAmount").ToString)
            txtCTotal.Text += Int(row.Item("TAAmount").ToString)
            txtTotalofTransactions.Text += Int(row.Item("TAAmount").ToString)
        Next
        Call TxtLockerCash_TextChanged(sender, e)
    End Sub

    Private Sub CmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Cursor = Cursors.WaitCursor
        Dim RPT As New rptSettlement
        Dim DT1 As New DataTable
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT sale.SaNo, sale.SaDate, sale.CuNo, Customer.CuName, Customer.CuTelNo1, Customer.CuTelNo2, Customer.CuTelNo3, " &
                                              "StockSale.SNo, SCategory, SName, StockSale.SaType, StockSale.SaUnits, StockSale.SaRate, StockSale.SaTotal, " &
                                              "sale.SaSubTotal, sale.SaLess, sale.SaDue, sale.CReceived, sale.CBalance, sale.CAmount, sale.CPInvoiceNo, sale.CPAmount, " &
                                              "sale.CuLNo, sale.CuLAmount FROM [Customer], [sale], [StockSale] where Customer.CuNo = Sale.CuNo And Sale.SaNo " &
                                              "= StockSale.SaNo And SaDate Between #" & Format(txtFrom.Value, "yyyy-MM-dd") & " 0000:00# And #" &
                                              Format(txtTo.Value, "yyyy-MM-dd") & " 23:59:59#", CNN)
        DA1.Fill(DT1)
        RPT.Subreports("rptSettlementSale.rpt").SetDataSource(DT1)
        Dim DT2 As New DataTable
        Dim DA2 As New OleDb.OleDbDataAdapter("SELECT RepNo,Repair.PNo,PCategory,PName, PaidPrice, Qty, Status, Repair.TNo,TName, Repair.Dno, DDate, Deliver.CuNo, " &
                                              "CuName, CuTelNo1,DGrandTotal, CAmount, CReceived, CBalance, CPInvoiceNo, CPAmount, CuLNo, CuLAmount, 'Repair' as " &
                                              "[TableName]  from Deliver, Customer,Repair,Technician, Product where Product.Pno = Repair.Pno and Repair.TNo = " &
                                              "Technician.TNo and Customer.Cuno = Deliver.CuNo and Repair.Dno = Deliver.Dno and Deliver.DDate Between #" &
                                              Format(txtFrom.Value, "yyyy-MM-dd") & " 00:00:00# and #" & Format(txtTo.Value, "yyyy-MM-dd") &
                                              " 23:59:59# UNION Select RetNo, Return.PNo,PCategory," &
                                              "PName, PaidPrice, Qty, Status, Return.TNo, TName, Return.Dno, DDate, Deliver.CuNo, CuName, CuTelNo1,DGrandTotal, " &
                                              "CAmount, CReceived, CBalance, CPInvoiceNo, CPAmount, CuLNo, CuLAmount, 'Re-Repair' as [TableName] from Deliver, " &
                                              "Customer,Return,Product, Technician where Product.Pno = Return.Pno and Return.TNo = Technician.TNo and Customer.Cuno" &
                                              " = Deliver.CuNo and Return.Dno = Deliver.Dno and Deliver.DDate Between #" & Format(txtFrom.Value, "yyyy-MM-dd") & " 00:00:00# and #" &
                                              Format(txtTo.Value, "yyyy-MM-dd") & " 23:59:59#;", CNN)
        DA2.Fill(DT2)
        RPT.Subreports("rptSettlementDeliver.rpt").SetDataSource(DT2)
        Dim DT3 As New DataTable
        Dim DA3 As New OleDb.OleDbDataAdapter("SELECT TANO,TADATE,TADETAILS,TAAMOUNT FROM [TRANSACTION] WHERE TADATE BETWEEN #" & Format(txtFrom.Value, "yyyy-MM-dd") &
                                              " 00:00:00# AND #" & Format(txtTo.Value.Date, "yyyy-MM-dd") & " 23:59:59#;", CNN)
        DA3.Fill(DT3)
        RPT.Subreports("rptSettlementTransaction").SetDataSource(DT3)
        Dim DS4 As New DataSet
        Dim DA4 As New OleDb.OleDbDataAdapter("SELECT * from Settlement Where SetDate=#" & Format(txtFrom.Value, "yyyy-MM-dd") & "#;", CNN)
        DA4.Fill(DS4, "Settlement")
        RPT.SetDataSource(DS4)
        RPT.SetParameterValue("Cashier Name", MdifrmMain.Tag)
        RPT.SetParameterValue("SetDate", txtFrom.Value.Date)
        RPT.SetParameterValue("SaTotal", txtTotalofSales.Text)
        RPT.SetParameterValue("RepTotal", txtTotalofRepairs.Text)
        RPT.SetParameterValue("CTotal", txtCTotal.Text)
        RPT.SetParameterValue("CPTotal", txtCPTotal.Text)
        RPT.SetParameterValue("CuLTotal", txtCuLTotal.Text)
        RPT.SetParameterValue("CPQty", txtCPQtyInvoice.Text)
        RPT.SetParameterValue("GrandTotal", txtIncome.Text)
        RPT.SetParameterValue("CashinLocker", txtLockerCash.Text)
        RPT.SetParameterValue("Change", txtChange.Text)
        frmReport.ReportViewer.ReportSource = RPT
        frmReport.Show(Me)

        Dim frm1 As New frmReport
        Dim RPT1 As New rptTechnicianCost
        Dim DS1 As New DataSet
        Dim DA5 As New OleDb.OleDbDataAdapter("SELECT TCNO,TCDATE,TECHNICIANCOST.TNO,TNAME,REPNO,RETNO,TECHNICIANCOST.SNO,SCATEGORY,SNAME, RATE,QTY,TOTAL," &
                                              "TCREMARKS FROM (TECHNICIANCOST INNER JOIN TECHNICIAN  ON TECHNICIAN.TNO = TECHNICIANCOST.TNO) " &
                                              "WHERE TCDATE Between #" & Format(txtFrom.Value, "yyyy-MM-dd") & " 00:00:00# and #" &
                                              Format(txtTo.Value, "yyyy-MM-dd") & " 23:59:59#;", CNN)
        DA5.Fill(DS1, "TECHNICIANCOST")
        DA5.Fill(DS1, "STOCK")
        DA5.Fill(DS1, "TECHNICIAN")
        RPT1.SetDataSource(DS1)
        frm1.ReportViewer.ReportSource = RPT1
        frm1.Show(Me)

        Dim RPT2 As New rptTechnicianLoan
        Dim frm2 As New frmReport
        Dim DS2 As New DataSet
        Dim DA6 As New OleDb.OleDbDataAdapter("SELECT TLNO,TL.TNO,TNAME,TLDATE,TL.SNO,SCATEGORY,SNAME,TLREASON,QTY,RATE,TOTAL FROM ((TECHNICIANLOAN TL INNER " &
                                              "JOIN TECHNICIAN T ON T.TNO = TL.TNO) LEFT JOIN STOCK S ON S.SNO = TL.SNO) WHERE TLDATE Between #" &
                                              Format(txtFrom.Value, "yyyy-MM-dd") & " 00:00:00# and #" & Format(txtTo.Value, "yyyy-MM-dd") & " 23:59:59#;", CNN)
        DA6.Fill(DS2, "TECHNICIANLOAN")
        DA6.Fill(DS2, "STOCK")
        DA6.Fill(DS2, "TECHNICIAN")
        RPT2.SetDataSource(DS2)
        frm2.ReportViewer.ReportSource = RPT2
        frm2.Show(Me)
        Cursor = Cursors.Default
    End Sub

    Private Sub TxtLockerCash_TextChanged(sender As Object, e As EventArgs) Handles txtLockerCash.TextChanged
        If txtLockerCash.Text <> "" And txtCTotal.Text <> "" Then
            txtChange.Text = Int(txtLockerCash.Text) - Int(txtCTotal.Text)
        End If
    End Sub

    Private Sub CmdTANew_Click(sender As Object, e As EventArgs) Handles cmdTANew.Click
        txtTANo.Text = ""
        AutomaticPrimaryKey(txtTANo, "Select Top 1 TANo from [Transaction] order by TANo Desc;", "TANO")
        txtTADetails.Text = ""
        txtTAAmount.Text = ""
        grdTransaction.Refresh()
        cmdTASave.Text = "Save"
        cmdTADelete.Enabled = False
    End Sub

    Private Sub CmdTASave_Click(sender As Object, e As EventArgs) Handles cmdTASave.Click
        If CheckEmptyfieldtxt(txtTADetails, "Transactions Details is empty. Please fill it and try again") = False Then
            Exit Sub
        ElseIf CheckEmptyfieldtxt(txtTAAmount, "Transactions Amount is empty. Please fill it and try again") = False Then
            Exit Sub
        End If
        Dim AdminSend As Boolean = False
        Dim Remarks As String = "අද දිනට නොමැති " & txtTANo.Text & " වන Transaction Data එක Edit කෙරුණි."

        If dtpTADate.Value.Date = Today.Date Then dtpTADate.Value = DateAndTime.Now
        If dtpTADate.Value.Date <> Today.Date And MdifrmMain.tslblUserType.Text <> "Admin" Then
            AdminSend = True
        End If
        Select Case cmdSave.Text
            Case "Save"
                AutomaticPrimaryKey(txtTANo, "Select Top 1 TANo from [Transaction] order by TANo Desc;", "TANo")
                CMDUPDATE("Insert into [Transaction](TANo, TADate,TADetails, TAAmount) Values(" & txtTANo.Text & ",#" &
                                             dtpTADate.Value.ToString & "#,'" & txtTADetails.Text & "', " & txtTAAmount.Text & ");")
            Case "Edit"
                CMDUPDATE("UPDATE [Transaction] SET TADate=#" & dtpTADate.Value.ToString & "#," &
                                                 "TADetails'" & txtTADetails.Text & "'," &
                                                 "TAAmount=" & txtTAAmount.Text &
                                                 " WHERE TANO = " & txtTANo.Text, AdminSend, Remarks)
        End Select
        grdTransaction.Refresh()
        CmdTANew_Click(sender, e)
        CmdSearch_Click(sender, e)
    End Sub

    Private Sub CmdTADelete_Click(sender As Object, e As EventArgs) Handles cmdTADelete.Click
        Dim Remarks As String
        Dim AdminSend As Boolean
        Remarks = "අද දිනට නොමැති Transaction එකෙහි " & txtTANo.Text & " වන Data එක Delete කෙරුණි."
        If dtpTADate.Value.Date <> Today.Date And MdifrmMain.tslblUserType.Text <> "Admin" Then
            AdminSend = True
        End If
        If CheckEmptyfieldtxt(txtTANo, "Transactions No is empty. Please fill it and try again") = False Then
            Exit Sub
        End If
        If MsgBox("Are you sure delete this transaction?", vbInformation + vbYesNo) = vbYes Then
            CMDUPDATE("DELETE from [Transaction] where TANO = " & txtTANo.Text, AdminSend, Remarks)
        End If
        CmdTANew_Click(sender, e)
    End Sub


    Private Sub GrdTransaction_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTransaction.CellDoubleClick
        If e.RowIndex > -1 Then
            txtTANo.Text = grdTransaction.Item(0, e.RowIndex).Value.ToString
            dtpTADate.Value = grdTransaction.Item(1, e.RowIndex).Value
            txtTADetails.Text = grdTransaction.Item(2, e.RowIndex).Value.ToString
            txtTAAmount.Text = grdTransaction.Item(3, e.RowIndex).Value.ToString
            cmdTASave.Text = "Edit"
            cmdTADelete.Enabled = True
        End If
    End Sub

    Private Sub frmSettlement_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        tabSettlement.Width = Me.Width - (tabSettlement.Left * 3)
        grdSale.Width = tabSettlement.Width - (grdSale.Left * 3)
        grdStockSale.Width = grdSale.Width
        grdDeliver.Width = tabSettlement.Width - (grdDeliver.Left * 3)
        grdRepair.Width = (grdDeliver.Width / 2) - 5
        grdRERepair.Left = grdRepair.Left + grdRepair.Width + 5
        grdRERepair.Width = grdDeliver.Width - grdRERepair.Left + 5
        grdTransaction.Width = tabSettlement.Width - grdTransaction.Left - 15
        cmdClose.Left = Me.Width - cmdClose.Width - 25
        cmdSave.Left = cmdClose.Left - cmdSave.Width - 5
        cmdPrint.Left = cmdSave.Left - cmdPrint.Width - 5
        tabSettlement.Height = Me.Height - tabSettlement.Top - 130
        lblIncome.Top = tabSettlement.Top + tabSettlement.Height + 5
        txtIncome.Top = tabSettlement.Top + tabSettlement.Height + 5
        lblCTotal.Top = tabSettlement.Top + tabSettlement.Height + 5
        txtCTotal.Top = lblCTotal.Top
        lblCPTotal.Top = txtCTotal.Top + txtCTotal.Height + 5
        txtCPTotal.Top = lblCPTotal.Top
        lblCuLTotal.Top = txtCPTotal.Top + txtCPTotal.Height + 5
        txtCuLTotal.Top = lblCuLTotal.Top
        lblCashinLocker.Top = tabSettlement.Top + tabSettlement.Height + 5
        txtLockerCash.Top = lblCashinLocker.Top
        lblQty.Top = txtLockerCash.Top + txtLockerCash.Height + 5
        txtCPQtyInvoice.Top = lblQty.Top
        lblChange.Top = txtCPQtyInvoice.Top + txtCPQtyInvoice.Height + 5
        txtChange.Top = lblChange.Top
        pnlMoneyCalculator.Top = lblCashinLocker.Top
        pnlMoneyCalculator.Height = Me.Height - pnlMoneyCalculator.Top - 30

        cmdSave.Top = tabSettlement.Top + tabSettlement.Height + 5
        cmdPrint.Top = tabSettlement.Top + tabSettlement.Height + 5
        cmdClose.Top = tabSettlement.Top + tabSettlement.Height + 5
        lblTotalofSales.Top = tabSettlement.Height - txtTotalofRepairs.Height - 30
        txtTotalofSales.Top = lblTotalofSales.Top
        lblTotalofRepairs.Top = tabSettlement.Height - txtTotalofRepairs.Height - 30
        txtTotalofRepairs.Top = lblTotalofRepairs.Top
        grdRepair.Top = txtTotalofRepairs.Top - grdRepair.Height - 5
        grdRERepair.Top = grdRepair.Top
        grdStockSale.Top = txtTotalofSales.Top - grdStockSale.Height - 5
        grdSale.Height = grdStockSale.Top - grdSale.Top - 5
        grdDeliver.Height = grdRepair.Top - grdDeliver.Top - 5
        grdTransaction.Height = tabSettlement.Height - grdTransaction.Top - 30

    End Sub

    Private Sub grdSale_SelectionChanged(sender As Object, e As EventArgs) Handles grdSale.SelectionChanged
        If grdSale.CurrentCell Is Nothing Then Exit Sub
        If grdSale.CurrentRow.Cells(0).Value <> vbNull Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter("SELECT SS.SNo as [Stock Code], SCategory as [Stock Category], SName as [Stock Name], SS.SaType as [Type], " &
                                                "SS.SaRate as [Rate],SS.SaUnits as [Qty], SS.SaTotal as [Total] from Sale Sa,StockSale SS " &
                                                "Where Sa.SaNo = SS.SaNo and Sa.SaNo =" & grdSale.Item(0, grdSale.CurrentCell.RowIndex).Value, CNN)
            DA.Fill(DT)
            grdStockSale.DataSource = DT
            grdStockSale.Refresh()
        End If
    End Sub

    Private Sub grdDeliver_SelectionChanged(sender As Object, e As EventArgs) Handles grdDeliver.SelectionChanged
        If grdDeliver.CurrentCell Is Nothing Then Exit Sub
        Dim dgv As New DataGridView
        Dim DT1 As New DataTable
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT rep.RepNo as [Repair No],PCategory as [Product Category],PName as [Product Name]," &
                                         "Qty, PaidPrice as [Paid Charge],TName as [Technician Name],Status from Repair Rep,Technician T, Product P " &
                                         "Where P.Pno = Rep.Pno and Rep.TNo = T.TNo and DNo = " & grdDeliver.Item(0, grdDeliver.CurrentCell.RowIndex).Value, CNN)
        DA1.Fill(DT1)
        grdRepair.DataSource = DT1
        grdRepair.Refresh()
        Dim DT2 As New DataTable
        Dim DA2 As New OleDb.OleDbDataAdapter("SELECT Ret.RetNo as [RERepair No],RepNo as [Repair No],PCategory as [Product Category],PName as [Product Name]," &
                                         "Qty, PaidPrice as [Paid Charge],TName as [Technician Name],Status from Return Ret,Technician T, Product P " &
                                         "Where P.Pno = Ret.Pno and Ret.TNo = T.TNo and DNo = " & grdDeliver.Item(0, grdDeliver.CurrentCell.RowIndex).Value, CNN)
        DA2.Fill(DT2)
        grdRERepair.DataSource = DT2
        grdRERepair.Refresh()
    End Sub

    Private Sub CalculateCashinLocker()
        txtLockerCash.Text = "0"
        For Each txt As TextBox In {txtLKR5000, txtLKR1000, txtLKR500, txtLKR100, txtLKR50, txtLKR20, txtLKR10, txtLKR5, txtLKR2, txtLKR1}
            If txt.Text = "" Then
                txt.Text = "0"
            End If
        Next
        txtLockerCash.Text = (Int(txtLKR5000.Text) * 5000) + (Int(txtLKR1000.Text) * 1000) + (Int(txtLKR500.Text) * 500) +
                    (Int(txtLKR100.Text) * 100) + (Int(txtLKR50.Text) * 50) + (Int(txtLKR20.Text) * 20) + (Int(txtLKR10.Text) * 10) +
                    (Int(txtLKR5.Text) * 5) + (Int(txtLKR2.Text) * 2) + (Int(txtLKR1.Text) * 1)
    End Sub

    Private Sub txtLKR_TextChanged(sender As Object, e As EventArgs) Handles txtLKR5000.TextChanged, txtLKR1000.TextChanged, txtLKR500.TextChanged,
            txtLKR100.TextChanged, txtLKR50.TextChanged, txtLKR20.TextChanged, txtLKR10.TextChanged, txtLKR5.TextChanged, txtLKR2.TextChanged,
            txtLKR1.TextChanged
        CalculateCashinLocker()
    End Sub
    'Private Sub txtLKR1000_TextChanged(sender As Object, e As EventArgs) Handles txtLKR1000.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR500_TextChanged(sender As Object, e As EventArgs) Handles txtLKR500.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR100_TextChanged(sender As Object, e As EventArgs) Handles txtLKR100.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR50_TextChanged(sender As Object, e As EventArgs) Handles txtLKR50.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR20_TextChanged(sender As Object, e As EventArgs) Handles txtLKR20.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR10_TextChanged(sender As Object, e As EventArgs) Handles txtLKR10.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR5_TextChanged(sender As Object, e As EventArgs) Handles txtLKR5.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR2_TextChanged(sender As Object, e As EventArgs) Handles txtLKR2.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    'Private Sub txtLKR1_TextChanged(sender As Object, e As EventArgs) Handles txtLKR1.TextChanged
    '    CalculateCashinLocker()
    'End Sub

    Private Sub txtLKR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR5000.KeyPress, txtLKR1000.KeyPress, txtLKR500.KeyPress,
            txtLKR100.KeyPress, txtLKR50.KeyPress, txtLKR20.KeyPress, txtLKR10.KeyPress, txtLKR5.KeyPress, txtLKR2.KeyPress,
            txtLKR1.KeyPress
        OnlynumberQty(e)
    End Sub

    'Private Sub txtLKR1000_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR1000.KeyPress
    '    OnlynumberQty(e)
    'End Sub

    'Private Sub txtLKR500_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR500.KeyPress
    '    OnlynumberQty(e)
    'End Sub

    'Private Sub txtLKR100_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR100.KeyPress
    '    OnlynumberQty(e)
    'End Sub
    'Private Sub txtLKR50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR50.KeyPress
    '    OnlynumberQty(e)
    'End Sub
    'Private Sub txtLKR20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR20.KeyPress
    '    OnlynumberQty(e)
    'End Sub
    'Private Sub txtLKR10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR10.KeyPress
    '    OnlynumberQty(e)
    'End Sub
    'Private Sub txtLKR5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR5.KeyPress
    '    OnlynumberQty(e)
    'End Sub
    'Private Sub txtLKR2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR2.KeyPress
    '    OnlynumberQty(e)
    'End Sub
    'Private Sub txtLKR1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLKR1.KeyPress
    '    OnlynumberQty(e)
    'End Sub

    Private Sub txtLockerCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLockerCash.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If cmdSave.Enabled = True Then cmdSave_Click(sender, e)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        CmdPrint_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        cmdClose_Click(sender, e)
    End Sub
End Class