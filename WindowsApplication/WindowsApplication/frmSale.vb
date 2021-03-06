Imports System.Drawing.Drawing2D
Public Class frmSale
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        MenuStrip.Items.Add(mnustrpMENU)
        Call cmdNew_Click(Nothing, Nothing)
        txtSaDate.Value = DateAndTime.Now
        If MdifrmMain.Tag <> "Admin" Then
            GetDataToolStripMenuItem.Enabled = False
            txtSaDate.Enabled = False
        End If
        cmbCuName.Text = "No Name"
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        Me.AcceptButton = cmdSave
        grdSale.Focus()
    End Sub

    Private Sub frmSale_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If pnlSaSaveFinal.Visible = True Then
            If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
                cmdCancel_Click(sender, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = True
                cmdReceipt_Click(sender, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = True
                cmdNotReceipt_Click(sender, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = False
                cmdReceipt_Click(sender, e)
            ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
                chkCashDrawer.Checked = False
                cmdNotReceipt_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub frmSale_Move(sender As Object, e As EventArgs) Handles Me.Move
        frmSearchDropDown.frm_Move()
    End Sub

    Private Sub frmSale_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Tag = ""
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmSale_Leave(sender, e)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Cursor = Cursors.WaitCursor
        AutomaticPrimaryKey(txtSaNo, "SELECT top 1 SaNo from Sale ORDER BY SaNo Desc;", "SaNo")
        cmbCuName.Text = "No Name"             'clear customer fileds
        cmbCuName_SelectedIndexChanged(sender, e)
        txtSubTotal.Text = "0"
        txtLess.Text = "0"
        txtDue.Text = "0"
        txtCAmount.Text = "0"
        txtCReceived.Text = "0"
        txtCBalance.Text = "0"
        txtCPAmount.Text = "0"
        txtCPInvoiceNo.Text = "0"
        txtCuLAmount.Text = "0"
        AutomaticPrimaryKey(txtCuLNo, "Select top 1 CuLNo from CustomerLoan order by CuLNo Desc;", "CuLNo")
        grdSale.Rows.Clear()
        cmdSave.Text = "Save"
        SaveToolStripMenuItem.Text = "Save"
        cmdDelete.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        cmbCuName_DropDown(sender, e)
        grdSale.Focus()
        grdSale.CurrentCell = grdSale.Item(0, grdSale.Rows.Count - 1)
        cmdCancel_Click(sender, e)
        Cursor = Cursors.Default
    End Sub

    Private Sub cmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        CmbDropDown(cmbCuName, "Select CuName from Customer group by  CuName;", "CuName")
    End Sub

    Private Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("SELECT * from Customer where CuName='" & cmbCuName.Text & "';", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            txtCuTelNo1.Tag = "1"
            DR.Read()
            cmbCuName.Text = DR("CuName").ToString
            txtCuTelNo1.Text = DR("CuTelNo1").ToString
            txtCuTelNo2.Text = DR("CuTelNo2").ToString
            txtCuTelNo3.Text = DR("CuTelNo3").ToString
        End If
        txtCuTelNo1.Tag = ""
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        grdSale.EndEdit()
        cmdSave.Focus()

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
        If CheckEmptyfieldcmb(cmbCuName, "ඔබ Customer Name එක ඇතුලත් කර නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf grdSale.Rows.Count < 2 Then
            MsgBox("Cart එක තවමත් හිස්ව පවතියි. කරුණාකර එය පුරවා නැවත උත්සහ කරන්න.", vbOKOnly + vbExclamation)
            grdSale.Focus()
            Exit Sub
        End If

        txtSubTotal.Text = "0"
        For Each Row As DataGridViewRow In grdSale.Rows
            If Row.Cells(6).Value <> Nothing Then
                If Row.Cells(3).Value = "Return to Available Units" Or Row.Cells(3).Value = "Return to Damaged Units" Then
                    txtSubTotal.Text -= Int(Row.Cells(6).Value)
                ElseIf Row.Cells(3).Value = "Sale" Then
                    txtSubTotal.Text += Int(Row.Cells(6).Value)
                End If
            End If
        Next
        If txtSubTotal.Text <> "" And txtLess.Text <> "" Then
            txtDue.Text = Int(txtSubTotal.Text) - Int(txtLess.Text)
            txtCAmount.Text = txtDue.Text
        End If
        txtLess_TextChanged(sender, e)
        AutomaticPrimaryKey(txtCuLNo, "Select Top 1 CuLNo from CustomerLoan Order by CuLNo Desc", "CuLNo")
        pnlSaSaveFinal.Dock = DockStyle.Fill
        pnlSaSaveFinal.BringToFront()
        pnlSaSaveFinal.Visible = True
        grpPaymentInfo.Top = (pnlSaSaveFinal.Height / 2) - (grpPaymentInfo.Height / 2)
        grpPaymentInfo.Left = (pnlSaSaveFinal.Width / 2) - (grpPaymentInfo.Width / 2)
        MenuStrip.Enabled = False
        AcceptButton = cmdReceipt
        txtCReceived.Focus()
    End Sub

    Private Sub cmdReceipt_Click(sender As Object, e As EventArgs) Handles cmdReceipt.Click
        If SaveSale() = True Then
            Dim rpt As New rptSale 'The report you created.
            Dim DT As New DataTable
            Cursor = Cursors.WaitCursor
            Dim DA As New OleDb.OleDbDataAdapter("SELECT Sale.SaNo,Sale.SaDate,Sale.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3," &
                                                 "SCategory, SName, StockSale.SaType,StockSale.SaUnits, StockSale.SaRate, StockSale.SaTotal,Sale.SaSubTotal," &
                                                 "Sale.SaLess,Sale.SaDue,Sale.CReceived,Sale.CBalance,Sale.CAmount,Sale.CPInvoiceNo,Sale.CPAmount,Sale.CuLNo," &
                                                 "sale.CuLAmount FROM ((StockSale Inner Join SALE ON StockSale.SaNo= Sale.SaNo) " &
                                                 "INNER JOIN Customer ON Sale.CuNo = Customer.CuNo) where StockSale.SaNo=" & txtSaNo.Text, CNN)
            DA.Fill(DT)
            rpt.SetDataSource(DT)
            rpt.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text) 'Set Cashier Name to Parameter Value
            frmReport.ReportViewer.ReportSource = rpt
            Dim c As Integer
            Dim doctoprint As New System.Drawing.Printing.PrintDocument()
            doctoprint.PrinterSettings.PrinterName = "Zonerich AB-220K"
            Dim rawKind As Integer
            For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
                If doctoprint.PrinterSettings.PaperSizes(c).PaperName = "76mm * 297mm" Then
                    rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                    Exit For
                End If
            Next
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            rpt.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
            rpt.PrintToPrinter(1, False, 1, 1)
            frmReport.Show(Me)
            Cursor = Cursors.Default
            cmdNew_Click(sender, e)
        End If
    End Sub

    Private Sub cmdNotReceipt_Click(sender As Object, e As EventArgs) Handles cmdNotReceipt.Click
        If SaveSale() = True Then
            cmdNew_Click(sender, e)
        End If
    End Sub

    Private Function SaveSale() As Boolean
        SaveSale = True
        Dim CMD1 As New OleDb.OleDbCommand
        Dim DR1 As OleDb.OleDbDataReader
        If Val(txtDue.Text) <> Val(txtCAmount.Text) + Val(txtCPAmount.Text) + Val(txtCuLAmount.Text) Then
            MsgBox("Due Amount එක Cash Amount, Card Payment Amount සහ Customer Loan Amount එකෙ එකතුවට අසමාන බැවින්, කරුණාකර එය නිවැරදි කර නැවත උත්සහ කරන්න.", vbCritical + vbOKOnly)
            Return False
            Exit Function
        End If
        Cursor = Cursors.WaitCursor
        txtSaDate.Value = DateAndTime.Now
        If (Val(txtCAmount.Text) > 0 Or Val(txtCPAmount.Text) > 0) And chkCashDrawer.Checked = True Then OpenCashdrawer()
        'Customer Management
        Dim CuNo As Integer
        CMD = New OleDb.OleDbCommand("Select * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text & "' and CuTelNo2 ='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "'", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            CuNo = DR("CuNo").ToString
        Else
            CuNo = AutomaticPrimaryKeyStr("Customer", "CuNo")
            CMDUPDATE("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & cmbCuName.Text & "','" & txtCuTelNo1.Text & "','" &
                      txtCuTelNo2.Text & "','" & txtCuTelNo3.Text & "');")
        End If
        Select Case cmdSave.Text
            Case "Save"
                AutomaticPrimaryKey(txtSaNo, "SELECT top 1 SaNo from Sale ORDER BY SaNo Desc;", "SaNo")
                'Add Values into Sale
                CMDUPDATE("Insert into Sale(SaNo,SaDate,CuNo,SaSubTotal,SaLess,SaDue,CAmount,CReceived,CBalance," &
                       "CPInvoiceNo,CPAmount,CuLNo,CuLAmount,SaRemarks,UNo)" &
                       "Values(" & txtSaNo.Text & ",'" & txtSaDate.Value & "'," & CuNo & "," & txtSubTotal.Text & "," & txtLess.Text &
                       "," & txtDue.Text & "," & txtCAmount.Text & "," & txtCReceived.Text & "," & txtCBalance.Text & "," &
                       txtCPInvoiceNo.Text & "," & txtCPAmount.Text & "," & txtCuLNo.Text & "," & txtCuLAmount.Text & ",'" &
                       txtSaRemarks.Text & "'," & MdifrmMain.Tag & ");")
                If txtCuLAmount.Text <> "0" Then
                    AutomaticPrimaryKey(txtCuLNo, "Select Top 1 CuLNo from CustomerLoan Order by CuLNo Desc", "CuLNo")
                    CMDUPDATE("Insert into CustomerLoan(CuLNo,CuLDate,CuNo,CuLAmount,SaNo,Status) Values(" & txtCuLNo.Text & ",#" & txtSaDate.Value & "#," & CuNo & "," &
                              txtCuLAmount.Text & "," & txtSaNo.Text & ",'Not Paid')")
                End If
                'Add Values into StockSale
                For Each row As DataGridViewRow In grdSale.Rows
                    If row.Index = Int(grdSale.Rows.Count) - 1 Then Exit For
                    If row.Cells.Item(0).Value <> "" Then
                        CMDUPDATE("Insert into StockSale(SSaNo,SaNo,SNo,SCategory,SName,SaType,SaRate,SaUnits,SaTotal) Values(" &
                                  AutomaticPrimaryKeyStr("StockSale", "SSaNo") & "," &
                                  txtSaNo.Text & "," &
                                  row.Cells(0).Value.ToString() & ",'" & row.Cells(1).Value.ToString & "','" & row.Cells(2).Value.ToString &
                                  "','" & row.Cells(3).Value.ToString() & "'," & row.Cells(4).Value.ToString() & "," & row.Cells(5).Value.ToString() & "," &
                                  row.Cells(6).Value.ToString() & ");")
                        'Update Store
                        If row.Cells(3).Value.ToString = "Sale" Then
                            CMDUPDATE("Update Stock set SAvailablestocks=(SAvailableStocks - " & row.Cells("Qty").Value.ToString &
                                                         ") where SNo=" & row.Cells(0).Value.ToString & "")
                        ElseIf row.Cells(3).Value.ToString = "Return to Damaged Units" Then
                            CMDUPDATE("Update Stock set Soutofstocks=(SOutofstocks + " & row.Cells("Qty").Value.ToString &
                                                                                ") where SNo=" & row.Cells(0).Value.ToString & "")
                        ElseIf row.Cells(3).Value.ToString = "Return to Available Units" Then
                            CMDUPDATE("Update Stock set SAvailablestocks=(SAvailablestocks + " & row.Cells("Qty").Value.ToString &
                                                                                ") where SNo=" & row.Cells(0).Value.ToString & "")
                        End If
                    Else
                        CMDUPDATE("Insert into StockSale(SSaNo,SaNo,SCategory,SName,SaType,SaRate,SaUnits,SaTotal) Values(" &
                                  AutomaticPrimaryKeyStr("StockSale", "SSaNo") & "," & txtSaNo.Text & ",'" &
                                 row.Cells(1).Value.ToString & "','" & row.Cells(2).Value.ToString &
                                  "','" & row.Cells(3).Value.ToString() & "'," & row.Cells(4).Value.ToString() & "," & row.Cells(5).Value.ToString() & "," &
                                  row.Cells(6).Value.ToString() & ");")
                    End If
                Next
            Case "Edit"
                CMD = New OleDb.OleDbCommand("SELECT * from Sale where SaNo=" & txtSaNo.Text & ";", CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    DR.Read()
                    If DR("CuLNo").ToString <> "0" And txtCuLNo.Text = "0" Then
                        CMDUPDATE("DELETE from CustomerLoan where CuLNo=" & DR("CuLNO").ToString)
                    ElseIf DR("CuLNo").ToString <> "0" And txtCuLNo.Text <> "0" Then
                        CMDUPDATE("Update CustomerLoan set CuLNo = " & DR("CuLNO").ToString &
                                                      "CuNo = " & CuNo &
                                                      ",CuLAmount = " & txtCuLAmount.Text &
                                                      ",SaNo = " & txtSaNo.Text &
                                                      ",CuLDate = " & txtSaDate.Value &
                                                      "where CuLNo=" & DR("CuLNO").ToString)
                        txtCuLNo.Text = DR("CuLNo").ToString
                    ElseIf DR("CuLNo").ToString = "0" And txtCuLNo.Text <> "0" Then
                        CMDUPDATE("Insert into CustomerLoan(CuLNO,CuLAmount,CuNo,SaNO,CulDate,Status) values(" & txtCuLNo.Text & "," & txtCuLAmount.Text & "," & CuNo & "," & txtSaNo.Text & "," & txtSaDate.Text & ",'Not Paid')")
                    End If
                End If
                'Delete old Customer if there is no records about that customer
                CMD = New OleDb.OleDbCommand("Select CuNo from Sale where SaNo=" & txtSaNo.Text, CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows = True Then
                    DR.Read()
                    CMD1 = New OleDb.OleDbCommand("Select CuNo from Sale Where CuNo = " & DR("CuNo").ToString, CNN)
                    DR1 = CMD1.ExecuteReader()
                    Dim CMD2 As New OleDb.OleDbCommand("Select CuNo from Receive where CuNo = " & DR("CuNo").ToString, CNN)
                    Dim DR2 As OleDb.OleDbDataReader = CMD2.ExecuteReader()
                    If DR1.HasRows = False And DR2.HasRows = False Then
                        CMDUPDATE("Delete from Customer where CuNo=" & DR("CuNo").ToString)
                    End If
                End If
                CMDUPDATE("Update Sale set SaNo= " & txtSaNo.Text &
                                        ",SaDate = '" & txtSaDate.Value &
                                        "',CuNo = " & CuNo &
                                        ",SaSubTotal = " & txtSubTotal.Text &
                                        ",SaLess= " & txtLess.Text &
                                        ",SaDue=" & txtDue.Text &
                                        ",CAmount= " & txtCAmount.Text &
                                        ",CReceived= " & txtCReceived.Text &
                                        ",CBalance=" & txtCBalance.Text &
                                        ",CPInvoiceNo=" & txtCPInvoiceNo.Text &
                                        ",CPAmount=" & txtCPAmount.Text &
                                        ",CuLNo=" & txtCuLNo.Text &
                                        ",CuLAmount=" & txtCuLAmount.Text &
                                        ",SaRemarks='" & txtSaRemarks.Text & "' Where SaNo = " & txtSaNo.Text)
                'Delete and update stocksale and stock old data
                CMD1 = New OleDb.OleDbCommand("Select * from StockSale where SaNo = " & txtSaNo.Text & "", CNN)
                DR1 = CMD1.ExecuteReader()
                While DR1.Read
                    If DR1("SaType").ToString = "Sale" Then
                        CMDUPDATE("Update Stock set SAvailablestocks=(SAvailableStocks + " & DR1("SaUnits").ToString &
                                                     ") where SNo=" & DR1("SNo").ToString & "")
                    ElseIf DR1("SaType").ToString = "Return to Damaged Units" Then
                        CMDUPDATE("Update Stock set SOutofstocks=(SOutofstocks - " & DR1("SaUnits").ToString &
                                                                            ") where SNo=" & DR1("SNo").ToString & "")
                    ElseIf DR1("SaType").ToString = "Return to Available Units" Then
                        CMDUPDATE("Update Stock set SAvailablestocks=(SAvailablestocks - " & DR1("SaUnits").ToString &
                                                                                ") where SNo=" & DR1("SNo").ToString & "")
                    End If
                End While
                CMDUPDATE("DELETE from StockSale where SaNo=" & txtSaNo.Text)       'delete data from stocksale
                'Add New StockSale and Stock Data
                For Each row As DataGridViewRow In grdSale.Rows
                    If row.Index = grdSale.Rows.Count - 1 Then Continue For
                    If row.Cells.Item(0).Value <> "" Then
                        CMDUPDATE("Insert into StockSale(SSaNo,SaNo,SNo,SCategory,SName,SaType,SaRate,SaUnits,SaTotal) Values(" &
                                  AutomaticPrimaryKeyStr("StockSale", "SSaNo") & "," & txtSaNo.Text & "," &
                                      row.Cells(0).Value.ToString() & ",'" & row.Cells(1).Value.ToString & "','" & row.Cells(2).Value.ToString &
                                      "','" & row.Cells(3).Value.ToString() & "'," & row.Cells(4).Value.ToString() & "," & row.Cells(5).Value.ToString() & "," &
                                      row.Cells(6).Value.ToString() & ");")
                        If row.Cells(3).Value.ToString = "Sale" Then
                            CMDUPDATE("Update Stock set SAvailablestocks=(SAvailableStocks - " & row.Cells(5).Value.ToString &
                                                         ") where SNo=" & row.Cells(0).Value.ToString & "")
                        ElseIf row.Cells(3).Value.ToString = "Return to Damaged Units" Then
                            CMDUPDATE("Update Stock set Soutofstocks=(SOutofstocks + " & row.Cells("Qty").Value.ToString &
                                                                                ") where SNo=" & row.Cells(0).Value.ToString & "")
                        ElseIf row.Cells(3).Value.ToString = "Return to Available Units" Then
                            CMDUPDATE("Update Stock set SAvailablestocks=(SAvailablestocks + " & row.Cells("Qty").Value.ToString &
                                                                                ") where SNo=" & row.Cells(0).Value.ToString & "")
                        End If
                    Else
                        CMDUPDATE("Insert into StockSale(SSaNo,SaNo,SCategory,SName,SaType,SaRate,SaUnits,SaTotal) Values(" &
                                  AutomaticPrimaryKeyStr("StockSale", "SSaNo") & "," & txtSaNo.Text & ",'" &
                                 row.Cells(1).Value.ToString & "','" & row.Cells(2).Value.ToString &
                                  "','" & row.Cells(3).Value.ToString() & "'," & row.Cells(4).Value.ToString() & "," & row.Cells(5).Value.ToString() & "," &
                                  row.Cells(6).Value.ToString() & ");")
                    End If
                Next
                MsgBox("Edit Successful!", vbOKOnly + vbExclamation)
        End Select
        Cursor = Cursors.Default
    End Function

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        pnlSaSaveFinal.Visible = False
        pnlSaSaveFinal.Dock = DockStyle.None
        MenuStrip.Enabled = True
        AcceptButton = cmdSave
        grdSale.Focus()
        grdSale.CurrentCell = grdSale.Item(0, grdSale.Rows.Count - 1)
    End Sub

    Private Sub txtLess_TextChanged(sender As Object, e As EventArgs) Handles txtLess.TextChanged
        If txtSubTotal.Text <> "" And txtLess.Text <> "" Then
            txtDue.Text = Int(txtSubTotal.Text) - Int(txtLess.Text)
            If txtCAmount.Text <> "0" And txtCAmount.Text <> "" Then
                txtCAmount.Text = txtDue.Text
            ElseIf txtCPAmount.Text <> "0" And txtCPAmount.Text <> "" Then
                txtCPAmount.Text = txtDue.Text
            ElseIf txtCuLAmount.Text <> "0" And txtCuLAmount.Text <> "" Then
                txtCuLAmount.Text = txtDue.Text
            End If
            Call txtCReceived_TextChanged(sender, e)
        End If
    End Sub

    Private Sub cmdCuView_Click(sender As Object, e As EventArgs) Handles cmdCuView.Click
        Dim frmNewCustomer As New frmCustomer
        With frmNewCustomer
            .Name = "frmCustomer" + NextfrmNo(frmCustomer).ToString
            .Caller = Me.Name
            .Tag = "Sale"
            .Show(Me)
        End With
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure delete?", vbYesNo + vbInformation) = vbYes Then
            CMDUPDATE("DELETE from Sale where SaNo=" & txtSaNo.Text)
            WriteActivity("Sale No " & txtSaNo.Text & " was deleted in 'Sale' table on " + DateAndTime.Now)
            CMDUPDATE("DELETE from StockSale where SaNo=" & txtSaNo.Text)
            WriteActivity("Sale No " & txtSaNo.Text & " was deleted in 'StockSale' table on " + DateAndTime.Now)
            cmdNew_Click(sender, e)
        End If
    End Sub

    Private Sub frmSale_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdSale.Width = cmdClose.Left - grdSale.Left - 5
        grdSale.Height = Me.Height - grdSale.Top - 40
    End Sub

    Public Sub grdSale_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdSale.CellEndEdit
        Select Case e.ColumnIndex
            Case 0
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                'If IsNumeric(grdSale.Item(0, e.RowIndex).Value) = False Then grdSale.Rows.RemoveAt(e.RowIndex)
                If grdSale.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
                CMD = New OleDb.OleDbCommand("Select * from Stock where SNo =" & grdSale.Item(0, e.RowIndex).Value.ToString, CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows = True Then
                    DR.Read()
                    grdSale.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                    grdSale.Item(2, e.RowIndex).Value = DR("SName").ToString
                    grdSale.Item(3, e.RowIndex).Value = "Sale"
                    grdSale.Item(4, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdSale.Item(5, e.RowIndex).Value = "1"
                    grdSale.Item(6, e.RowIndex).Value = Int(grdSale.Item(4, e.RowIndex).Value.ToString) * Int(grdSale.Item(5, e.RowIndex).Value.ToString)
                    For Each row As DataGridViewRow In grdSale.Rows
                        If row.Index = e.RowIndex Or row.Index = grdSale.Rows.Count - 1 Then Continue For
                        If row.Cells(0).Value = grdSale.Item(0, e.RowIndex).Value Then
                            row.Cells(5).Value += Int(grdSale.Item(5, e.RowIndex).Value)
                            Dim E1 As New DataGridViewCellEventArgs(4, row.Index)
                            grdSale_CellEndEdit(sender, E1)
                            BeginInvoke(New MethodInvoker(Sub()
                                                              grdSale.Rows.RemoveAt(e.RowIndex)
                                                          End Sub))

                        End If
                    Next
                Else
                    grdSale.Rows.RemoveAt(e.RowIndex)
                End If
            Case 1, 2
                frmSearchDropDown.frm_Close()
                CMD = New OleDb.OleDbCommand("Select * from Stock where SCategory='" & grdSale.Item(1, e.RowIndex).Value & "' and SName='" & grdSale.Item(2, e.RowIndex).Value & "';", CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    DR.Read()
                    grdSale.Item(0, e.RowIndex).Value = DR("SNo").ToString
                    grdSale.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                    grdSale.Item(2, e.RowIndex).Value = DR("SName").ToString
                    grdSale.Item(3, e.RowIndex).Value = "Sale"
                    grdSale.Item(4, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdSale.Item(5, e.RowIndex).Value = "1"
                    grdSale.Item(6, e.RowIndex).Value = Int(grdSale.Item(4, e.RowIndex).Value.ToString) * Int(grdSale.Item(5, e.RowIndex).Value.ToString)
                Else
                    grdSale.Item(0, e.RowIndex).Value = ""
                    grdSale.Item(3, e.RowIndex).Value = "Sale"
                    grdSale.Item(4, e.RowIndex).Value = "0"
                    grdSale.Item(5, e.RowIndex).Value = "1"
                    grdSale.Item(6, e.RowIndex).Value = "0"
                End If
                If grdSale.Item(1, e.RowIndex).Value Is Nothing And grdSale.Item(2, e.RowIndex).Value Is Nothing And ((grdSale.Rows.Count - 1) <> e.RowIndex) Then
                    grdSale.Rows.RemoveAt(grdSale.CurrentRow.Index)
                End If
            Case 4, 5
                If grdSale.Item(5, e.RowIndex).Value IsNot Nothing And grdSale.Item(4, e.RowIndex).Value IsNot Nothing Then
                    grdSale.Item(6, e.RowIndex).Value = Int(grdSale.Item(4, e.RowIndex).Value) * Int(grdSale.Item(5, e.RowIndex).Value)
                End If
                If grdSale.Item(1, e.RowIndex).Value Is Nothing Then
                    grdSale.Item(1, e.RowIndex).Value = "No Category"
                End If
                If grdSale.Item(2, e.RowIndex).Value Is Nothing Then
                    grdSale.Item(2, e.RowIndex).Value = "No Category"
                End If
        End Select
        txtSubTotal.Text = "0"
        For Each Row As DataGridViewRow In grdSale.Rows
            If Row.Cells(6).Value <> Nothing Then
                If Row.Cells(3).Value = "Return to Available Units" Or Row.Cells(3).Value = "Return to Damaged Units" Then
                    txtSubTotal.Text -= Int(Row.Cells(6).Value)
                ElseIf Row.Cells(3).Value = "Sale" Then
                    txtSubTotal.Text += Int(Row.Cells(6).Value)
                End If
            End If
        Next
        txtLess_TextChanged(sender, e)
    End Sub

    Private Sub grdSale_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdSale.EditingControlShowing
        Dim autoText As TextBox
        Dim DataCollection As New AutoCompleteStringCollection()
        If TypeOf e.Control Is TextBox Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
            autoText = TryCast(e.Control, TextBox)
            autoText.AutoCompleteCustomSource = Nothing
            autoText.AutoCompleteSource = AutoCompleteSource.None
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If
        Select Case grdSale.CurrentCell.ColumnIndex
            Case 1
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdSale, Me, "Select SCategory from Stock group by SCategory;", "SCategory")
            Case 2
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdSale, Me, "Select SCategory,SName from Stock where SCategory ='" & grdSale.Item(1, grdSale.CurrentCell.RowIndex).Value &
                                           "';", "SName")
            Case 0, 5
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 4, 6
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub
    Private Sub grdSale_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles grdSale.RowsAdded
        txtSubTotal.Text = "0"
        For Each Row As DataGridViewRow In grdSale.Rows
            If Row.Cells(6).Value <> Nothing Then txtSubTotal.Text += Int(Row.Cells(6).Value)
        Next
        txtLess_TextChanged(sender, e)
    End Sub

    Private Sub grdSale_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grdSale.RowsRemoved
        txtSubTotal.Text = "0"
        For Each Row As DataGridViewRow In grdSale.Rows
            If Row.Cells(6).Value <> Nothing Then txtSubTotal.Text += Int(Row.Cells(6).Value)
        Next
        txtLess_TextChanged(sender, e)
    End Sub

    Private Sub txtCuTelNo1_TextChanged(sender As Object, e As EventArgs) Handles txtCuTelNo1.TextChanged
        If txtCuTelNo1.Text = "          " Or txtCuTelNo1.Tag = "1" Then Exit Sub
        Dim SaCMD As New OleDb.OleDbCommand("Select * from Customer where CuTelNo1='" & txtCuTelNo1.Text & "' or CuTelNo2='" & txtCuTelNo1.Text & "' or CuTelNo3='" & txtCuTelNo1.Text & "';", CNN)
        Dim SaDR As OleDb.OleDbDataReader = SaCMD.ExecuteReader()
        If SaDR.HasRows = True Then
            txtCuTelNo1.Tag = "1"
            Dim frm As New frmCustomer
            frm.Tag = "Sale"
            frm.Show(Me)
            SaDR.Read()
            cmbCuName.Text = SaDR("CuName").ToString
            Call cmbCuName_SelectedIndexChanged(sender, e)
            frm.cmbCuName.Text = SaDR("CuName").ToString
            Call frm.cmbCuName_SelectedIndexChanged(sender, e)
        End If
        SaCMD.Cancel()
        SaDR.Close()
        txtCuTelNo1.Tag = ""
    End Sub

    Private Sub txtCuTelNo2_TextChanged(sender As Object, e As EventArgs) Handles txtCuTelNo2.TextChanged
        If txtCuTelNo2.Text = "          " Or txtCuTelNo1.Tag = "1" Then Exit Sub
        Dim SaCMD As New OleDb.OleDbCommand("Select * from Customer where CuTelNo1='" & txtCuTelNo2.Text & "' or CuTelNo2='" & txtCuTelNo2.Text & "' or CuTelNo3='" & txtCuTelNo2.Text & "';", CNN)
        Dim SaDR As OleDb.OleDbDataReader = SaCMD.ExecuteReader()
        If SaDR.HasRows = True Then
            txtCuTelNo1.Tag = "1"
            Dim frm As New frmCustomer
            frm.Tag = "Sale"
            frm.Show(Me)
            SaDR.Read()
            cmbCuName.Text = SaDR("CuName").ToString
            Call cmbCuName_SelectedIndexChanged(sender, e)
            frm.cmbCuName.Text = SaDR("CuName").ToString
            Call frm.cmbCuName_SelectedIndexChanged(sender, e)
        End If
        SaCMD.Cancel()
        SaDR.Close()
        txtCuTelNo1.Tag = ""
    End Sub

    Private Sub txtCuTelNo3_TextChanged(sender As Object, e As EventArgs) Handles txtCuTelNo3.TextChanged
        If txtCuTelNo3.Text = "          " Or txtCuTelNo1.Tag = "1" Then Exit Sub
        Dim SaCMD As New OleDb.OleDbCommand("Select * from Customer where CuTelNo1='" & txtCuTelNo3.Text & "' or CuTelNo2='" & txtCuTelNo3.Text & "' or CuTelNo3='" & txtCuTelNo3.Text & "';", CNN)
        Dim SaDR As OleDb.OleDbDataReader = SaCMD.ExecuteReader()
        If SaDR.HasRows = True Then
            txtCuTelNo1.Tag = "1"
            Dim frm As New frmCustomer
            frm.Tag = "Sale"
            frm.Show(Me)
            SaDR.Read()
            cmbCuName.Text = SaDR("CuName").ToString
            Call cmbCuName_SelectedIndexChanged(sender, e)
            frm.cmbCuName.Text = SaDR("CuName").ToString
            Call frm.cmbCuName_SelectedIndexChanged(sender, e)
        End If
        SaCMD.Cancel()
        SaDR.Close()
        txtCuTelNo1.Tag = ""
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDetailsToolStripMenuItem.Click
        Dim frm As New frmStock
        With frm
            .Caller = Me.Name.ToString
            .Name = "frmStock" + NextfrmNo(frmStock).ToString
            .Tag = "Sale"
            .Show(Me)
            .txtSearch.Focus()
        End With
    End Sub

    Private Sub txtCReceived_TextChanged(sender As Object, e As EventArgs) Handles txtCReceived.TextChanged
        If txtDue.Text <> "" And txtCReceived.Text <> "" Then
            txtCBalance.Text = Val(txtCReceived.Text) - Val(txtCAmount.Text)
        End If
    End Sub

    Private Sub txtCAmount_TextChanged(sender As Object, e As EventArgs) Handles txtCAmount.TextChanged
        txtCReceived_TextChanged(sender, e)
        If txtDue.Text = "" Then Exit Sub
        If txtCPAmount.Text = "" Then txtCPAmount.Text = "0"
        If txtCuLAmount.Text = "" Then txtCuLAmount.Text = "0"
        If txtDue.Text = txtCAmount.Text Then
            txtCPAmount.Text = "0"
            txtCuLAmount.Text = "0"
        End If
    End Sub

    Private Sub txtCAmount_GotFocus(sender As Object, e As EventArgs) Handles txtCAmount.GotFocus
        If txtDue.Text <> "" And txtCPAmount.Text <> "" And txtCuLAmount.Text <> "" Then
            txtCAmount.Text = Val(txtDue.Text) - Val(txtCPAmount.Text) - Val(txtCuLAmount.Text)
        End If
    End Sub

    Private Sub txtCPAmount_TextChanged(sender As Object, e As EventArgs) Handles txtCPAmount.TextChanged
        If txtDue.Text = "" Then Exit Sub
        If txtCAmount.Text = "" Then txtCAmount.Text = "0"
        If txtCuLAmount.Text = "" Then txtCuLAmount.Text = "0"
        If txtDue.Text = txtCPAmount.Text Then
            txtCAmount.Text = "0"
            txtCuLAmount.Text = "0"
        End If
    End Sub

    Private Sub txtCPAmount_GotFocus(sender As Object, e As EventArgs) Handles txtCPAmount.GotFocus
        If txtDue.Text <> "" And txtCAmount.Text <> "" And txtCuLAmount.Text <> "" Then
            txtCPAmount.Text = Val(txtDue.Text) - Val(txtCAmount.Text) - Val(txtCuLAmount.Text)
        End If
    End Sub

    Private Sub txtCuLAmount_TextChanged(sender As Object, e As EventArgs) Handles txtCuLAmount.TextChanged
        If txtDue.Text = "" Then Exit Sub
        If txtCAmount.Text = "" Then txtCAmount.Text = "0"
        If txtCPAmount.Text = "" Then txtCPAmount.Text = "0"
        If txtDue.Text = txtCuLAmount.Text Then
            txtCAmount.Text = "0"
            txtCPAmount.Text = "0"
        End If
    End Sub

    Private Sub txtCuLAmount_GotFocus(sender As Object, e As EventArgs) Handles txtCuLAmount.GotFocus
        If txtDue.Text <> "" And txtCAmount.Text <> "" And txtCPAmount.Text <> "" Then
            txtCuLAmount.Text = Val(txtDue.Text) - Val(txtCAmount.Text) - Val(txtCPAmount.Text)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If cmdNew.Enabled = True Then cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If cmdSave.Enabled = True Then cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If cmdDelete.Enabled = True Then cmdDelete_Click(sender, e)
    End Sub

    Private Sub GetDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDataToolStripMenuItem.Click
        If MdifrmMain.Tag = "Admin" Then
            Dim frmNewSearch As New frmSearch
            With frmNewSearch
                .Name = "frmSearch" + NextfrmNo(frmSearch).ToString
                .Key = Me.Name
                .Tag = "Sale"
                .Show(Me)
            End With
        Else
            MsgBox("ඔබට මේ සඳහා Permission නොමැත.", vbExclamation + vbOKOnly)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If cmdClose.Enabled = True Then cmdClose_Click(sender, e)
    End Sub

    Private Sub CustomerInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerInfoToolStripMenuItem.Click
        If cmdCuView.Enabled = True Then cmdCuView_Click(sender, e)
    End Sub

    Private Sub txtCuTelNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuTelNo1.KeyPress, txtCuTelNo2.KeyPress, txtCuTelNo3.KeyPress, txtCPInvoiceNo.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub txtCAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAmount.KeyPress, txtCReceived.KeyPress, txtCPAmount.KeyPress, txtCuLAmount.KeyPress, txtLess.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub cmdSave_Text(txt As String)
        cmdSave.Text = txt
        SaveToolStripMenuItem.Text = txt
        If txt = "Edit" Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub

End Class