Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class MdifrmMain
    Private Db As New Database
    Private Sub mdifrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Db.Connect()
        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub MdifrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Create the shutdown.txt for close the BackgroundWorker
        If Not String.IsNullOrEmpty(My.Settings.BGWorkerPath) And File.Exists(My.Settings.BGWorkerPath) Then
            Dim fileName As String = My.Settings.BGWorkerPath
            Dim fi As New IO.FileInfo(fileName)
            Dim directoryName As String = SpecialDirectories.MyDocuments + "\LASER System\LASER Background"
            File.Create(directoryName + "\ShutDown.txt")
        End If

        BarCodePort.Close()
        End
    End Sub

    Public Sub CmdStock_Click(sender As Object, e As EventArgs) Handles cmdStock.Click
        frmStock.Show()
        frmStock.BringToFront()
        If frmStock.WindowState = FormWindowState.Minimized Then frmStock.WindowState = FormWindowState.Maximized
        frmStock.Tag = ""
    End Sub

    Public Sub CmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        frmCustomer.Show()
        frmCustomer.Tag = ""
        frmCustomer.BringToFront()
        If frmCustomer.WindowState = FormWindowState.Minimized Then frmCustomer.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub CmdSupplier_Click(sender As Object, e As EventArgs) Handles cmdSupplier.Click
        frmSupplier.Show()
        frmSupplier.Tag = ""
        frmSupplier.BringToFront()
        If frmSupplier.WindowState = FormWindowState.Minimized Then frmSupplier.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub CmdSupply_Click(sender As Object, e As EventArgs) Handles cmdSupply.Click
        frmSupply.Show()
        frmSupply.Tag = ""
        frmSupply.BringToFront()
        If frmSupply.WindowState = FormWindowState.Minimized Then frmSupply.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub CmdSettlement_Click(sender As Object, e As EventArgs) Handles cmdSettlement.Click
        frmSettlement.Show()
        frmSettlement.BringToFront()
        If frmSettlement.WindowState = FormWindowState.Minimized Then frmSettlement.WindowState = FormWindowState.Maximized

    End Sub

    Public Sub CmdProduct_Click(sender As Object, e As EventArgs) Handles cmdProduct.Click
        frmProduct.Tag = ""
        frmProduct.Show()
    End Sub

    Public Sub CmdReceive_Click(sender As Object, e As EventArgs) Handles cmdReceive.Click
        With frmReceive
            .Show()
            .BringToFront()
            If .WindowState = FormWindowState.Minimized Then .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Public Sub cmdDeliver_Click(sender As Object, e As EventArgs) Handles cmdDeliver.Click
        With frmDeliver
            .Show()
            .BringToFront()
            If .WindowState = FormWindowState.Minimized Then .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Public Sub cmdRepair_Click(sender As Object, e As EventArgs) Handles cmdRepair.Click
        Try
            With frmRepair
                .Show()
                .BringToFront()
                If .WindowState = FormWindowState.Minimized Then .WindowState = FormWindowState.Maximized
                If .tabRepair.SelectedTab.TabIndex = 0 Then
                    .cmbRepNo.Focus()
                Else
                    .cmbRetNo.Focus()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cmdTechnicianCost_Click(sender As Object, e As EventArgs) Handles cmdTechnicianCost.Click
        With frmTechnicianCost
            .Show()
            .BringToFront()
            If .WindowState = FormWindowState.Minimized Then .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Public Sub cmdTechnician_Click(sender As Object, e As EventArgs) Handles cmdTechnician.Click
        frmTechnician.Show()
    End Sub

    Public Sub cmdTechnicianLoan_Click(sender As Object, e As EventArgs) Handles cmdTechnicianLoan.Click
        With frmTechnicianLoan
            .Show()
            .BringToFront()
            If .WindowState = FormWindowState.Minimized Then .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Public Sub cmdTechnicianSalary_Click(sender As Object, e As EventArgs) Handles cmdTechnicianSalary.Click
        frmTechnicianSalary.Show()
    End Sub

    Public Sub cmdCustomerLoan_Click(sender As Object, e As EventArgs) Handles cmdCustomerLoan.Click
        frmCustomerLoan.Show()
    End Sub

    Public Sub cmdSalesRepair_Click(sender As Object, e As EventArgs) Handles cmdSalesRepair.Click
        frmSalesRepair.Show()
    End Sub

    Private Sub CmdSale_Click(sender As Object, e As EventArgs) Handles cmdSale.Click
        Dim frmNewSale As New frmSale
        With frmNewSale
            .Name = "frmSale" + NextfrmNo(frmSale).ToString
            .Tag = ""
            .Show()
        End With
    End Sub

    Public Sub NewSaleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If TypeOf ActiveForm.ActiveControl Is DataGridView Then
            Dim grd As DataGridView = ActiveForm.ActiveControl
            grd.BeginEdit(False)
            Exit Sub
        End If
        CmdSale_Click(sender, e)
    End Sub

    Public Sub OpenSaleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
            If oForm.Name.ToString.StartsWith("frmSale") = True Then
                If ActiveForm.Name.ToString.StartsWith("frmSale") = True Then
                    If Int(ActiveForm.Name.ToString.Replace("frmSale", "")) = NextfrmNo(frmSale) - 1 Then
                        oForm.Show()
                        oForm.BringToFront()
                        If oForm.WindowState = FormWindowState.Minimized Then oForm.WindowState = FormWindowState.Maximized
                        Exit For
                    ElseIf Int(ActiveForm.Name.ToString.Replace("frmSale", "")) < Int(oForm.Name.ToString.Replace("frmSale", "")) Then
                        oForm.Show()
                        oForm.BringToFront()
                        If oForm.WindowState = FormWindowState.Minimized Then oForm.WindowState = FormWindowState.Maximized
                        Exit For
                    End If
                    Continue For
                Else
                    oForm.Show()
                    oForm.BringToFront()
                    If oForm.WindowState = FormWindowState.Minimized Then oForm.WindowState = FormWindowState.Maximized
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Sub BarCodeGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmStockSticker.Show()
    End Sub

    Public Sub cmdRepAdvanced_Click(sender As Object, e As EventArgs) Handles cmdRepAdvanced.Click
        With frmRepairAdvanced
            .Show()
            .BringToFront()
            If .WindowState = FormWindowState.Minimized Then .WindowState = FormWindowState.Maximized
        End With
    End Sub

#Region "MenuStrip Items"

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdStock_Click(sender, e)
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdCustomer_Click(sender, e)
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdSupplier_Click(sender, e)
    End Sub

    Private Sub TechnicianToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdTechnician_Click(sender, e)
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdProduct_Click(sender, e)
    End Sub

    Private Sub SupplyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdSupply_Click(sender, e)
    End Sub

    Private Sub ReceiveProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdReceive_Click(sender, e)
    End Sub

    Private Sub RepairProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdRepair_Click(sender, e)
    End Sub

    Private Sub DeliverProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdDeliver_Click(sender, e)
    End Sub

    Private Sub SalesRepairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If cmdSalesRepair.Enabled = True Then cmdSalesRepair_Click(sender, e)
    End Sub

    Private Sub TechnicianCostToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdTechnicianCost_Click(sender, e)
    End Sub

    Private Sub TechnicianLoanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdTechnicianLoan_Click(sender, e)
    End Sub

    Private Sub TechnicianSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdTechnicianSalary_Click(sender, e)
    End Sub

    Private Sub CustomerLoanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdCustomerLoan_Click(sender, e)
    End Sub

    Private Sub SettlementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CmdSettlement_Click(sender, e)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FrmSettings.Tag = ""
        FrmSettings.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Tag = "MainMenu"
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MdifrmMain_Leave(sender, e)
    End Sub

    Private Sub MdifrmMain_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
        End
    End Sub
#End Region

    Private Sub cmbIncomevsDateView_SelectedIndexChanged(sender As Object, e As EventArgs)
        Select Case cmbIncomevsDateView.Text
            Case "Days"
                lblIncomevsDateCustom.Text = "අවශ්‍ය දින ගණන "
            Case "WeekDays"
                lblIncomevsDateCustom.Text = "අවශ්‍ය සති ගණන "
            Case "Months"
                lblIncomevsDateCustom.Text = "අවශ්‍ය මාස ගණන "
        End Select
        txtIncomevsDateCustom.Left = lblIncomevsDateCustom.Left + lblIncomevsDateCustom.Width + 5
    End Sub

    Private Sub txtIncomevsDateCustom_KeyPress(sender As Object, e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub cmbReceivedRepvsDateView_SelectedIndexChanged(sender As Object, e As EventArgs)
        Select Case cmbReceivedRepvsDateView.Text
            Case "Days"
                lblReceivedRepvsDateCustom.Text = "අවශ්‍ය දින ගණන "
            Case "WeekDays"
                lblReceivedRepvsDateCustom.Text = "අවශ්‍ය සති ගණන "
            Case "Months"
                lblReceivedRepvsDateCustom.Text = "අවශ්‍ය මාස ගණන "
        End Select
        txtReceivedRepvsDateCustom.Left = lblReceivedRepvsDateCustom.Left + lblReceivedRepvsDateCustom.Width + 5
    End Sub

    Public Sub txtIncomevsDateCustom_TextChanged(sender As Object, e As EventArgs)
        Dim cmd0 As New OleDb.OleDbCommand
        Dim DR0 As OleDb.OleDbDataReader
        If Me.Tag = "Cashier" Then Exit Sub
        tsProBar.Visible = True
        tsProBar.Value = 0
        tslblLoad.Text = "Getting Data to Chart..."
        If txtIncomevsDateCustom.Text <> "" Then
            Select Case cmbIncomevsDateView.Text
                Case "Months"
                    DR0 = Db.GetDataReader("SELECT MonthName(Month(SETDATE)) AS [MonthName],SUM(SETGRANDTOTAL) as [GrandTotal] " &
                                              ",SUM(REPTOTAL) as [REPTOTAL],SUM(SATOTAL) AS [SATOTAL] " &
                                              "FROM SETTLEMENT where YEAR(SETDATE) = " & txtIncomevsDateCustom.Text & " Group by  " &
                                              "Month(SETDATE);")
                    If DR0.HasRows = True Then
                        chtIncomevsDate.Series("Total Income vs Date").Points.Clear()
                        chtIncomevsDate.Series("Total Income by Repairs vs Date").Points.Clear()
                        chtIncomevsDate.Series("Total Income by Sales vs Date").Points.Clear()
                        While DR0.Read()
                            chtIncomevsDate.Series("Total Income vs Date").Points.AddXY(DR0("MonthName").ToString, Int(DR0("GrandTotal").ToString))
                            chtIncomevsDate.Series("Total Income by Repairs vs Date").Points.AddXY(DR0("MonthName").ToString, Int(DR0("REPTOTAL").ToString))
                            chtIncomevsDate.Series("Total Income by Sales vs Date").Points.AddXY(DR0("MonthName").ToString, Int(DR0("SATotal").ToString))
                        End While
                    End If
                Case "Week Days"
                    DR0 = Db.GetDataReader("SELECT WeekDayName(Datepart('w',SETDATE) ) as [WeekDayName], Sum(SETGRANDTotal) as [GrandTotal] " &
                                              ",SUM(REPTOTAL) as [REPTOTAL],SUM(SATOTAL) AS [SATOTAL] " &
                                              "FROM SETTLEMENT where MONTH(SETDATE) = " & txtIncomevsDateCustom.Text & " Group by Datepart('w',SETDATE);")
                    If DR0.HasRows = True Then
                        chtIncomevsDate.Series("Total Income vs Date").Points.Clear()
                        chtIncomevsDate.Series("Total Income by Repairs vs Date").Points.Clear()
                        chtIncomevsDate.Series("Total Income by Sales vs Date").Points.Clear()
                        While DR0.Read()
                            chtIncomevsDate.Series("Total Income vs Date").Points.AddXY(DR0("WeekDayName").ToString, Int(DR0("GrandTotal").ToString))
                            chtIncomevsDate.Series("Total Income by Repairs vs Date").Points.AddXY(DR0("WeekDayName").ToString, Int(DR0("REPTOTAL").ToString))
                            chtIncomevsDate.Series("Total Income by Sales vs Date").Points.AddXY(DR0("WeekDayName").ToString, Int(DR0("SATotal").ToString))
                        End While
                    End If
                Case "Days"
                    DR0 = Db.GetDataReader("SELECT TOP " & txtIncomevsDateCustom.Text & " SETDATE,SETGRANDTOTAL,REPTOTAL,SATOTAL FROM SETTLEMENT ORDER BY SETDATE DESC;")
                    If DR0.HasRows = True Then
                        chtIncomevsDate.Series("Total Income vs Date").Points.Clear()
                        chtIncomevsDate.Series("Total Income by Repairs vs Date").Points.Clear()
                        chtIncomevsDate.Series("Total Income by Sales vs Date").Points.Clear()

                        While DR0.Read()
                            chtIncomevsDate.Series("Total Income vs Date").Points.AddXY(DR0("SETDATE").ToString, Int(DR0("SETGrandTotal").ToString))
                            chtIncomevsDate.Series("Total Income by Repairs vs Date").Points.AddXY(DR0("SETDATE").ToString, Int(DR0("REPTOTAL").ToString))
                            chtIncomevsDate.Series("Total Income by Sales vs Date").Points.AddXY(DR0("SETDATE").ToString, Int(DR0("SATotal").ToString))
                        End While
                    End If
            End Select
        End If
        If txtReceivedRepvsDateCustom.Text <> "" Then
            Select Case cmbReceivedRepvsDateView.Text
                Case "Months"
                    DR0 = Db.GetDataReader("SELECT MonthName(Month(RDate)) AS [MonthName],SUM(Qty) as [Qty] " &
                                              "FROM Repair REP,Receive R where R.RNo = REP.RNo AND YEAR(RDATE) = " &
                                              txtReceivedRepvsDateCustom.Text & " Group by " & "Month(RDATE);")
                    If DR0.HasRows = True Then
                        chtReceivedRepvsDate.Series("Qty of Received Repairs vs Date").Points.Clear()
                        While DR0.Read()
                            chtReceivedRepvsDate.Series("Qty of Received Repairs vs Date").Points.AddXY(DR0("MonthName").ToString, Int(DR0("Qty").ToString))
                        End While
                    End If
                Case "Week Days"
                    DR0 = Db.GetDataReader("SELECT WeekDayName(Datepart('w',RDATE) ) as [WeekDayName], Sum(Qty) as [Qty] " &
                                              "FROM Repair REP,Receive R where R.RNo = REP.RNO and MONTH(RDATE) = " & txtReceivedRepvsDateCustom.Text & " Group by Datepart('w',RDATE);")
                    If DR0.HasRows = True Then
                        chtReceivedRepvsDate.Series("Qty of Received Repairs vs Date").Points.Clear()
                        While DR0.Read()
                            chtReceivedRepvsDate.Series("Qty of Received Repairs vs Date").Points.AddXY(DR0("WeekDayName").ToString, Int(DR0("Qty").ToString))
                        End While
                    End If
                Case "Days"
                    DR0 = Db.GetDataReader("SELECT TOP " & txtReceivedRepvsDateCustom.Text & " DATEVALUE(RDATE) AS [RECEIVEDDATE],SUM(Qty) as [TOTALQty] FROM REPAIR REP,RECEIVE R WHERE R.RNO = REP.RNO GROUP BY DATEVALUE(RDATE) ORDER BY DATEVALUE(RDATE) DESC;")
                    If DR0.HasRows = True Then
                        chtReceivedRepvsDate.Series("Qty of Received Repairs vs Date").Points.Clear()
                        While DR0.Read()
                            chtReceivedRepvsDate.Series("Qty of Received Repairs vs Date").Points.AddXY(DR0("RECEIVEDDATE").ToString, Int(DR0("TOTALQTY").ToString))
                        End While
                    End If
            End Select
        End If
        tsProBar.Value = 100
        tslblLoad.Text = ""
        tsProBar.Visible = False
    End Sub

    Private Sub txtReceivedRepvsDateCustom_TextChanged(sender As Object, e As EventArgs)
        Call txtIncomevsDateCustom_TextChanged(sender, e)
    End Sub

    Public Sub TmrReload_Tick(sender As Object, e As EventArgs) Handles tmrReload.Tick
        bgwMainMenu.RunWorkerAsync()
    End Sub

    Private Sub bgworker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwMainMenu.DoWork
        If Me.Tag = "Admin" Then
            Dim cmd0 As New OleDb.OleDbCommand
            Dim DR0 As OleDb.OleDbDataReader
            DR0 = Db.GetDataReader("SELECT R.RNO, RDATE, REPNO FROM RECEIVE R,REPAIR REP WHERE REP.RNO = R.RNO AND RDATE=#" & Today.Date.ToString & "#;")
            lblQtyRRepNo.Text = "0"
            While DR0.Read
                lblQtyRRepNo.Text += 1
            End While
            DR0 = Db.GetDataReader("SELECT R.RNO, RDATE, RETNO FROM RECEIVE R,RETURN RET WHERE RET.RNO = R.RNO AND RDATE=#" & Today.Date.ToString & "#;")
            lblQtyRRetNo.Text = "0"
            While DR0.Read
                lblQtyRRetNo.Text += 1
            End While
            DR0 = Db.GetDataReader("SELECT SANO, SADATE, SADUE FROM [SALE] WHERE SADATE=#" & Today.Date.ToString & "# UNION SELECT DNO, DDATE, DGRANDTOTAL FROM [DELIVER] WHERE DDATE=#" & Today.Date.ToString & "# UNION SELECT TANo,TADAte,TAAmount from [Transaction] where TADAte=#" & Today.Date.ToString & "#;")
            Dim x As Integer = 0
            While DR0.Read
                x += Int(DR0("SADUE").ToString)
            End While
            lblTodayIncomeNo.Text = String.Format("Rs.{0:N2}", x)

            cmd0.Cancel()
            DR0.Close()
        End If
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles BarCodePort.DataReceived
        Dim str As String = BarCodePort.ReadExisting
        If BarCodePort.IsOpen = True AndAlso str <> "" Then
            Dim CurrentForm As Form = My.Application.OpenForms.Item(My.Application.OpenForms.Count - 1)
            If CurrentForm.Name.StartsWith(frmSearch.Name) And CurrentForm.Tag = "Repair" Then
                Dim frmSearch_Repair As frmSearch = CurrentForm
                frmSearch_Repair.txtTSSearch.Text = str
                Me.BeginInvoke(New EventHandler(Sub()
                                                    frmSearch_Repair.cmdTSSearch.PerformClick()
                                                End Sub))
                Exit Sub
            End If
            If Application.OpenForms().OfType(Of frmSale)().Count < 1 Then
                Me.BeginInvoke(New EventHandler(Sub()
                                                    cmdSale.PerformClick()
                                                End Sub))
                Threading.Thread.Sleep(3000)
            End If
            For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
                With oForm
                    .grdSale.Rows.Add(str)
                    Dim E1 As New DataGridViewCellEventArgs(0, .grdSale.Rows.Count - 2)
                    .grdSale_CellEndEdit(sender, E1)
                End With
                Exit For
            Next
        End If
    End Sub

    Private Sub flpMessage_Resize(sender As Object, e As EventArgs) Handles flpMessage.Resize
        For Each controlObj As Control In flpMessage.Controls
            controlObj.Width = flpMessage.Width - 30
        Next
    End Sub
End Class
