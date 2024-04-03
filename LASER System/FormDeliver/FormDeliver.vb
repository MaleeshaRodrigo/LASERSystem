Imports System.Data.OleDb

Public Class FormDeliver
    Private Db As New Database
    Public ControlPopUp As ControlPopUp
    Public Sub New()
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub frmDeliver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        Call cmdNew_Click(Nothing, Nothing)
        txtDDate.Value = Date.Today
        grdRepair.Focus()
    End Sub

    Private Sub cmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        Call ComboBoxDropDown(Db, cmbCuName, "Select CuName from Customer Group by CuName;")
    End Sub

    Private Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        Dim DR As OleDbDataReader = Db.GetDataReader("SELECT * from Customer where CuName='" & cmbCuName.Text & "';")
        If DR.HasRows = True Then
            txtCuTelNo1.Tag = "1"
            DR.Read()
            txtCuTelNo1.Text = DR("CuTelNo1").ToString
            txtCuTelNo2.Text = DR("CuTelNo2").ToString
            txtCuTelNo3.Text = DR("CuTelNo3").ToString
        End If
        txtCuTelNo1.Tag = ""
    End Sub

    Public Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click, NewToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Call SetNextKey(Db, txtDNo, "SELECT top 1 DNo from Deliver ORDER BY DNo Desc;", "DNo")
        For Each obj As Object In {cmbCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3, txtDRemarks}
            obj.text = ""
        Next
        grdRepair.Rows.Clear()
        grdRERepair.Rows.Clear()

        Dim grdtxt1 As DataGridViewComboBoxColumn = grdRepair.Columns.Item(5)
        Dim DT0 As DataTable = Db.GetDataTable("Select TName from Technician Where TActive=Yes group by TName;")
        Dim items = DT0.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        grdtxt1.DataSource = items

        grdtxt1 = grdRERepair.Columns.Item(6)
        grdtxt1.DataSource = items

        cmdSave.Enabled = True
        grdRepair.Focus()
        grdRepair.CurrentCell = grdRepair.Item(0, grdRepair.Rows.Count - 1)
        Cursor = Cursors.Default
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, SaveToolStripMenuItem.Click
        grdRepair.EndEdit()
        grdRERepair.EndEdit()

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
            Dim DR As OleDbDataReader = Db.GetDataReader("Select TNo from Technician Where TName='" & Row.Cells(5).Value & "'")
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
            Dim DR As OleDbDataReader = Db.GetDataReader("Select TNo from Technician Where TName='" & Row.Cells(6).Value & "'")
            If DR.HasRows = False Then
                MsgBox("Repair No: " & Row.Cells(0).Value & " යන තීරුවෙ Technician ව System එක තුල නොපවතියි. කරුණාකර නැවත පරික්ෂා කරන්න.", vbExclamation + vbOKOnly)
                Exit Sub
            End If
        Next

        ControlPopUp = New ControlPopUp(Db, Me)
        CalculateGrandTotal()

        If txtDDate.Value.Date <> Today.Date And User.Instance.UserType <> User.Type.Admin Then
            Me.AcceptButton = ControlPopUp.cmdNotReceipt
            ControlPopUp.chkCashDrawer.Checked = False
            ControlPopUp.chkCashDrawer.Enabled = False
            ControlPopUp.cmdReceipt.Enabled = False
        Else
            Me.AcceptButton = ControlPopUp.cmdReceipt
            ControlPopUp.cmdReceipt.Enabled = True
            ControlPopUp.chkCashDrawer.Enabled = False
        End If
        Me.Controls.Add(ControlPopUp)
        MenuStrip.Enabled = False
    End Sub

    Public Sub PrintDeliveryReceipt(DNo As Integer, Optional boolPrint As Boolean = False)
        Try
            Dim RPT As New rptDeliver
            Dim frm As New frmReport
            Dim DT1 As New DataTable
            Dim DS1 As New DataSet
            Dim DA1 As OleDbDataAdapter = Db.GetDataAdapter("SELECT Repair.RepNo,Repair.PNo,Product.PCategory,Product.PName,Repair.Qty,Repair.PaidPrice,Repair.TNo from Repair,Product,Deliver where Deliver.DNO = Repair.DNo And Repair.PNo = Product.PNo And Deliver.DNo = " & DNo & ";")
            DA1.Fill(DS1, "Repair")
            DA1.Fill(DS1, "Product")
            RPT.Subreports.Item("rptDeliverRepair.rpt").SetDataSource(DS1)
            Dim DT2 As New DataTable
            Dim DS2 As New DataSet
            Dim DA2 As OleDbDataAdapter = Db.GetDataAdapter("Select Return.RetNo,Return.RepNo,Return.PNo,Product.PCategory,Product.Pname,Return.Qty,Return.PaidPrice,Return.TNo from Return,Product,Deliver where Deliver.DNO = Return.DNo And Return.PNo = Product.PNo And Deliver.DNO  = " & DNo & ";")
            DA2.Fill(DS2, "Return")
            DA2.Fill(DS2, "Product")
            RPT.Subreports.Item("rptDeliverReturn.rpt").SetDataSource(DS2)
            Dim DT3 As New DataTable
            Dim DS3 As New DataSet
            Dim DA3 As OleDbDataAdapter = Db.GetDataAdapter("SELECT Deliver.DNo, Deliver.DDate,Deliver.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3,Deliver.DGrandTotal,Deliver.CReceived,Deliver.CBalance,Deliver.CAmount,Deliver.CPInvoiceNO,Deliver.CPAmount,Deliver.CuLNo,Deliver.CuLAmount,Deliver.DRemarks from Deliver,Customer where Deliver.CuNo = Customer.CuNo And Deliver.DNo = " & DNo &
                                              ";")
            DA3.Fill(DS3, "Deliver")
            DA3.Fill(DS3, "Customer")
            RPT.SetDataSource(DS3)
            RPT.SetParameterValue("Cashier Name", User.Instance.UserName.ToString) 'Set Cashier Name to Parameter Value
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
            MsgBox("යම් ගැටලුවක් පැන නැගී ඇති බැවින් Deliver Receipt එක Print කිරිමට අපොහොසත් විය." + vbCrLf + vbCrLf + "Error: " + ex.ToString, vbExclamation,
                   "Deliver Receipt එක Print කිරිමට නොහැක.")
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
                Dim DRD As OleDbDataReader = Db.GetDataReader("Select RepNo,PCategory,PName,PMOdelNO,PSerialNo,PDetails,Qty,Charge,TName,Status,CuName,CuTelNo1,CuTelNo2,CuTelNo3 from ((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) Where RepNo = " &
                                             grdRepair.Item(0, grdRepair.CurrentCell.RowIndex).Value)
                If DRD.HasRows = True Then
                    DRD.Read()
                    If DRD("Status").ToString = "Repaired Delivered" Or DRD("Status").ToString = "Returned Delivered" Then
                        If MsgBox("මෙම Repair එක දැනටමත් Customer විසින් රැගෙන ගොස් ඇත." + vbCrLf + "ඔබට එම Repair එක විවෘත කිරිමට අවශ්‍යද?",
                                  vbInformation + vbYesNo) = vbYes Then
                            Dim frm As New FormRepair
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
                            Dim frm As New FormRepair
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
                    Dim DR As OleDbDataReader = Db.GetDataReader("Select RepNo from Repair where Status <> 'Repaired Delivered' and Status <> 'Returned Delivered' and Status <> 'Canceled' order by RepNo Desc;")
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
                    Dim DrRetNo As OleDbDataReader = Db.GetDataReader("Select RetNo from Return order by RetNo Desc;")
                    While DrRetNo.Read
                        DataCollection.Add(DrRetNo("RetNo").ToString)
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
                    Dim DrRepNo As OleDbDataReader = Db.GetDataReader("Select REPNO from Return order by REpNo Desc;")
                    While DrRepNo.Read
                        DataCollection.Add(DrRepNo("RepNo").ToString)
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
                DR = Db.GetDataReader("Select RetNo,RepNo,PCategory,PName,PMOdelNO,PSerialNo,PDetails,Qty,Charge,TName,Status,CuName,CuTelNo1,CuTelNo2,CuTelNo3 from ((((Return RET INNER JOIN RECEIVE R ON R.RNO = RET.RNO) INNER JOIN PRODUCT  P ON P.PNO = RET.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = RET.TNO) Where RetNo = " & grdRERepair.Item(0, grdRERepair.CurrentCell.RowIndex).Value)
                If DR.HasRows = True Then
                    DR.Read()
                    If DR("Status").ToString = "Repaired Delivered" Or DR("Status").ToString = "Returned Delivered" Then
                        If MsgBox("මෙම RERepair එක දැනටමත් Customer විසින් රැගෙන ගොස් ඇත." + vbCrLf + "ඔබට එම RERepair එක විවෘත කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
                            Dim frm As New FormRepair
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
                            Dim frm As New FormRepair
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
                Dim DrReturn As OleDbDataReader = Db.GetDataReader("Select RepNo,RetNo,Status from Return Where RepNo=" & grdRERepair.Item(1, e.RowIndex).Value)
                If DrReturn.HasRows = True Then
                    DrReturn.Read()
                    grdRERepair.Item(0, e.RowIndex).Value = DrReturn("RetNo").ToString
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
        Dim frm As New FormRepair
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
        ControlPopUp.txtSubTotal.Text = "0"
        ControlPopUp.txtRepAdvanced.Text = "0"
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index >= grdRepair.Rows.Count - 1 Then Continue For
            ControlPopUp.txtSubTotal.Text += Val(row.Cells(4).Value)
            For Each str As String In Db.GetArray("Select Amount from RepairAdvanced Where RepNo=" &
                                                      row.Cells(0).Value, "Amount")
                ControlPopUp.txtRepAdvanced.Text += Val(str)
            Next
        Next
        For Each row As DataGridViewRow In grdRERepair.Rows
            If row.Index >= grdRERepair.Rows.Count - 1 Then Continue For
            ControlPopUp.txtSubTotal.Text += Val(row.Cells(5).Value)
            For Each str As String In Db.GetArray("Select Amount from RepairAdvanced Where RetNo=" &
                                                      row.Cells(0).Value, "Amount")
                ControlPopUp.txtRepAdvanced.Text += Val(str)
            Next
        Next

        ControlPopUp.txtGrandTotal.Text = Val(ControlPopUp.txtSubTotal.Text) - Val(ControlPopUp.txtRepAdvanced.Text)
        ControlPopUp.txtCAmount.Text = ControlPopUp.txtGrandTotal.Text
    End Sub

    Private Sub frmDeliver_Leave(sender As Object, e As EventArgs) Handles Me.Leave, cmdClose.Click, CloseToolStripMenuItem.Click
        Db.Disconnect()
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

    Private Sub grdRepair_SelectionChanged(sender As Object, e As EventArgs) Handles grdRepair.SelectionChanged
        grdRepair.EndEdit()
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