Imports MySqlConnector
Imports System.IO
Imports System.Threading
Imports ZXing

Public Class FormReceive
    Public Property Caller As String

    Private Db As New Database
    Private ControlCommandInfo As ControlCommandInfo

    Public Sub New()
        InitializeComponent()
        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub FrmReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cmdNew_Click(Nothing, Nothing)
        txtCuTelNo1.Focus()
    End Sub

    'Private Sub frmReceive_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    'If ControlCommandInfo IsNot Nothing Then
    '    If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
    '        cmdCancel.PerformClick()
    '    ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
    '        cmdReceiptSticker.PerformClick()
    '    ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
    '        cmdReceipt.PerformClick()
    '    ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
    '        cmdSticker.PerformClick()
    '    ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
    '        cmdSaveOnly.PerformClick()
    '    End If
    'End If
    'End Sub

    Private Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        If txtCuTelNo1.Text.Trim = "" Then
            Dim DrCheckCustomerExist = Db.GetDataDictionary("SELECT * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
                                         "' and CuTelNo2='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "';")
            If DrCheckCustomerExist IsNot Nothing Then
                cmbCuName_Text(DrCheckCustomerExist("CuName").ToString)
                txtCuTelNo1.Text = DrCheckCustomerExist("CuTelNo1").ToString
                txtCuTelNo2.Text = DrCheckCustomerExist("CuTelNo2").ToString
                txtCuTelNo3.Text = DrCheckCustomerExist("CuTelNo3").ToString
            Else
                For i As Integer = 0 To 1000
                    Dim DrCuNameSuggest = Db.GetDataDictionary("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
                    If DrCuNameSuggest Is Nothing Then
                        cmbCuName_Text(cmbCuName.Text + " " + i.ToString)
                        Exit For
                    End If
                Next
            End If
        Else
            Dim DrCheckCustomerExist = Db.GetDataDictionary("SELECT * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
                                         "' and CuTelNo2='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "';")
            If DrCheckCustomerExist IsNot Nothing Then Exit Sub
            If cmbCuName.Text = "" Then Exit Sub
            Dim DrCuName = Db.GetDataDictionary("Select CuName from Customer where CuName ='" & cmbCuName.Text & "';")

            If DrCuName IsNot Nothing Then
                For i As Integer = 0 To 1000
                    Dim DrCuNameSuggest = Db.GetDataDictionary("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
                    If DrCuNameSuggest Is Nothing Then
                        cmbCuName_Text(cmbCuName.Text + " " + i.ToString)
                        Exit For
                    End If
                Next
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click, NewToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Call SetNextKey(Db, txtRNo, "SELECT  RNo from Receive ORDER BY RNo Desc LIMIT 1;", "RNo")
        'clear customer fileds
        For Each obj As Object In {cmbCuMr, cmbCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3}
            obj.Text = ""
        Next
        grdRepair.Rows.Clear()
        grdReRepair.Rows.Clear()
        grdRepair.CurrentCell = grdRepair.Rows(grdRepair.Rows.Count - 1).Cells(0)
        cmdCancel_Click(sender, e)
        ComboBoxDropDown(Db, cmbCuName, "SELECT CuName FROM Customer GROUP BY CuName;")
        Cursor = Cursors.Default
        txtCuTelNo1.Focus()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click, CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, SaveToolStripMenuItem.Click
        If CheckEmptyControl(cmbCuName, "Customer Name යන field එක හිස්ව පවතියි. කරුණාකර Customer කෙනෙකු තෝරා නැවත උත්සහ කරන්න.") = False Then
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

        If Tag = "Deliver" Then
            SaveReceivedRepair()
            Tag = ""
            Close()
            Exit Sub
        End If

        ControlCommandInfo = New ControlCommandInfo With {
            .Dock = DockStyle.Fill
        }
        Controls.Add(ControlCommandInfo)
        ControlCommandInfo.BringToFront()

        MenuStrip.Enabled = False
        AcceptButton = cmdReceiptSticker
        cmdReceiptSticker.Focus()
    End Sub

    Private Sub SaveReceivedRepair()
        'Customer Management 
        Dim CuNo, PNo As Integer
        Dim DR = Db.GetDataDictionary("Select * from Customer where CuName='" & cmbCuMr.Text & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text & "' and CuTelNo2 ='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "'")
        If DR IsNot Nothing Then
            CuNo = DR("CuNo")
        Else
            CuNo = Db.GetNextKey("Customer", "CuNo")
            Db.Execute("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CutelNo3) Values(" & CuNo & ",'" & cmbCuMr.Text & cmbCuName.Text & "','" & txtCuTelNo1.Text & "','" & txtCuTelNo2.Text & "','" & txtCuTelNo3.Text & "')")
        End If
        If txtRDate.Value.Date = Today.Date Then txtRDate.Value = DateAndTime.Now
        txtRNo.Text = Db.GetNextKey("Receive", "RNo")
        Db.Execute("Insert into Receive(RNo,RDate,CuNo,UNo) values(@RNO, @RDATE, @CUNO, @UNO);", {
            New MySqlParameter("RNO", txtRNo.Text),
            New MySqlParameter("RDATE", txtRDate.Value),
            New MySqlParameter("CUNO", CuNo),
            New MySqlParameter("UNO", User.Instance.UserNo)
        })
        For Each row As DataGridViewRow In grdRepair.Rows
            If row.Index = grdRepair.Rows.Count - 1 Then Continue For
            'Product Management
            Dim DrProduct = Db.GetDataDictionary("Select * from Product where PCategory='" & row.Cells(1).Value & "' and PName='" & row.Cells(2).Value & "'")
            If DrProduct IsNot Nothing Then
                PNo = DrProduct("PNo")
            Else
                PNo = Db.GetNextKey("Product", "PNo")
                Db.Execute("INSERT INTO Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) Values(" & PNo & ",'" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(5).Value & "');")
            End If
            Db.Execute("INSERT INTO Repair(RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status)Values(" & row.Cells(0).Value & "," & txtRNo.Text & "," & PNo & ",'" & row.Cells(4).Value & "'," &
                                        row.Cells(6).Value & ",'" & row.Cells(7).Value & "','Received');")
            Db.Execute("INSERT INTO RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(?NewKey?RepairActivity?RepANo?," &
                      row.Cells(0).Value & ",NOW(),'Received Date -> " & txtRDate.Value & vbCrLf &
                      ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text &
                      ", Telephone No2 -> " & txtCuTelNo2.Text &
                      ", Telephone No3 -> " & txtCuTelNo3.Text & vbCrLf &
                      ", Product Category -> " & row.Cells(1).Value &
                      ", Product Name -> " & row.Cells(2).Value &
                      ", Model No -> " & row.Cells(3).Value &
                      ", Serial No -> " & row.Cells(4).Value &
                      ", Problem -> " & row.Cells(5).Value & ".'," & User.Instance.UserNo & ")")
            If row.Cells(8).Value IsNot Nothing Then
                Db.Execute("INSERT INTO RepairRemarks1(Rem1No,Rem1Date,RepNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,NOW()," &
                      row.Cells(0).Value & ",'" & row.Cells(8).Value & "'," & User.Instance.UserNo & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As FormDeliver In Application.OpenForms().OfType(Of FormDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRepair.Rows.Add(row.Cells("RepairNo").Value, row.Cells("PCategory").Value, row.Cells("PName").Value, row.Cells("PQty").Value, "0", "", "")
                        End With
                        Exit For
                    End If
                Next
            End If
        Next row
        For Each row As DataGridViewRow In grdReRepair.Rows
            If row.Index = grdReRepair.Rows.Count - 1 Then Continue For
            'Product Management
            Dim DrProduct = Db.GetDataDictionary("Select * from Product where PCategory='" & row.Cells(2).Value & "' and PName='" & row.Cells(3).Value & "'")
            If DrProduct IsNot Nothing Then
                PNo = DrProduct("PNo")
            Else
                PNo = Db.GetNextKey("Product", "PNo")
                Db.Execute("INSERT INTO Product(PNO,PCATEGORY,PNAME,PMODELNO,PDETAILS) Values(@PNO, @PCATEGORY, @PNAME, @PMODELNO, @PDETAILS)", {
                    New MySqlParameter("PNO", PNo),
                    New MySqlParameter("PCATEGORY", row.Cells(2).Value),
                    New MySqlParameter("PNAME", row.Cells(3).Value),
                    New MySqlParameter("PMODELNO", row.Cells(4).Value),
                    New MySqlParameter("PDETAILS", row.Cells(6).Value)
                })
            End If
            Db.Execute("INSERT INTO `Return`(RetNo,RepNo,RNo,PNo,PSerialNo,Qty,Problem,Status) VALUES(@RETNO, @REPNO, @RNO, @PNO, @PSERIALNO, @QTY, @PROBLEM, @STATUS)", {
                New MySqlParameter("RETNO", row.Cells(0).Value),
                New MySqlParameter("REPNO", row.Cells(1).Value),
                New MySqlParameter("RNO", txtRNo.Text),
                New MySqlParameter("PNO", PNo),
                New MySqlParameter("PSERIALNO", row.Cells(5).Value),
                New MySqlParameter("QTY", row.Cells(7).Value),
                New MySqlParameter("PROBLEM", row.Cells(8).Value),
                New MySqlParameter("STATUS", "Received")
            })
            Db.Execute("INSERT INTO RepairActivity(RetNo,RepADate,Activity,UNo) VALUES(@RETNO, NOW(), @ACTIVITY, @UNO);", {
                New MySqlParameter("RETNO", row.Cells(0).Value),
                New MySqlParameter("ACTIVITY", "Received Date -> " & txtRDate.Value &
                      ", Name -> " & cmbCuMr.Text & cmbCuName.Text &
                      ", Telephone No1 -> " & txtCuTelNo1.Text &
                      ", Telephone No2 -> " & txtCuTelNo2.Text &
                      ", Telephone No3 -> " & txtCuTelNo3.Text &
                      ", Product Category -> " & row.Cells(2).Value &
                      ", Product Name -> " & row.Cells(3).Value &
                      ", Model No -> " & row.Cells(4).Value &
                      ", Serial No -> " & row.Cells(5).Value &
                      ", Problem -> " & row.Cells(8).Value),
                New MySqlParameter("UNO", User.Instance.UserNo)
            })
            If row.Cells(8).Value IsNot Nothing Then
                Db.Execute("Insert into RepairRemarks1(Rem1No,Rem1Date,RetNo,Remarks,UNo) Values(?NewKey?RepairRemarks1?Rem1No?,NOW()," &
                      row.Cells(0).Value & ",'" & row.Cells(9).Value & "'," & User.Instance.UserNo & ")")
            End If
            If Me.Tag = "Deliver" Then
                For Each oForm As FormDeliver In Application.OpenForms().OfType(Of FormDeliver)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
                            .txtCuTelNo1.Text = txtCuTelNo1.Text
                            .txtCuTelNo2.Text = txtCuTelNo2.Text
                            .txtCuTelNo3.Text = txtCuTelNo3.Text
                            .grdRERepair.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells("RETPCategory").Value, row.Cells("RETPName").Value, row.Cells("RETQty").Value, "0", "", "")
                        End With
                        Exit For
                    End If
                Next
            End If
        Next row
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
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
                    Dim DrProduct = Db.GetDataList("Select PCategory from Product group by PCategory;")
                    For Each Item In DrProduct
                        DataCollection.Add(Item("PCategory").ToString)
                    Next
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 2
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    Dim DR = Db.GetDataList("Select PCategory,PName from Product where PCategory ='" & grdRepair.Item(1, grdRepair.CurrentCell.RowIndex).Value & "';")
                    For Each Item In DR
                        DataCollection.Add(Item("PName").ToString)
                    Next
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
                Dim DR = Db.GetDataDictionary("Select * from Product where PCategory='" & grdRepair.Item(1, e.RowIndex).Value & "' and PName='" & grdRepair.Item(2, e.RowIndex).Value & "';")
                If DR IsNot Nothing Then
                    grdRepair.Item(1, e.RowIndex).Value = DR("PCategory").ToString
                    grdRepair.Item(2, e.RowIndex).Value = DR("PName").ToString
                    grdRepair.Item(4, e.RowIndex).Value = DR("PDetails").ToString
                    grdRepair.Item(5, e.RowIndex).Value = "1"
                Else
                    grdRepair.Item(5, e.RowIndex).Value = "1"
                    grdRepair.Item(4, e.RowIndex).Value = ""
                End If
        End Select
    End Sub

    Private Sub grdRepair_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdRepair.UserAddedRow
        Dim i As Integer
        Dim DR = Db.GetDataDictionary("Select RepNo from Repair Order by RepNo desc LIMIT 1;")
        If DR IsNot Nothing Then
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
                Dim DrCustomer = Db.GetDataDictionary("Select RepNo, Rep.RNo, Cu.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3 from Repair REP, Receive R, Customer Cu Where Rep.RNo = R.RNo and Cu.CuNo = R.CuNo and RepNo = " & grdReRepair.Item(1, e.RowIndex).Value)
                If DrCustomer IsNot Nothing Then
                    txtCuTelNo1.Text = DrCustomer("CuTelNo1").ToString
                    txtCuTelNo2.Text = DrCustomer("CuTelNo2").ToString
                    txtCuTelNo3.Text = DrCustomer("CuTelNo3").ToString
                    cmbCuName.Text = DrCustomer("CuName").ToString
                End If
                Dim DrProduct = Db.GetDataDictionary("Select RepNo,PCategory,PName,PSerialNo,PDetails,Qty from Repair Rep,Product P where Rep.Pno = P.PNo and RepNo=" & grdReRepair.Item(1, e.RowIndex).Value)
                If DrProduct IsNot Nothing Then
                    grdReRepair.Item(2, e.RowIndex).Value = DrProduct("PCategory").ToString
                    grdReRepair.Item(3, e.RowIndex).Value = DrProduct("PName").ToString
                    grdReRepair.Item(4, e.RowIndex).Value = DrProduct("PSerialNo").ToString
                    grdReRepair.Item(5, e.RowIndex).Value = DrProduct("PDetails").ToString
                    grdReRepair.Item(6, e.RowIndex).Value = DrProduct("Qty").ToString
                End If
        End Select
    End Sub

    Public Sub grdReRepair_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdReRepair.UserAddedRow
        Dim i As Integer
        Dim DR = Db.GetDataDictionary("Select  RetNo from `Return` Order by retno desc LIMIT 1;")
        If DR.Count Then

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

    Private Sub cmdCuView_Click(sender As Object, e As EventArgs) Handles cmdCuView.Click, CustomerInfoToolStripMenuItem.Click
        frmCustomer.Tag = "Receive"
        frmCustomer.Show()
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

    Private Sub txtCuTelNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuTelNo1.KeyPress, txtCuTelNo2.KeyPress, txtCuTelNo3.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub TextCuTelNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuTelNo1.KeyUp, txtCuTelNo2.KeyUp, txtCuTelNo3.KeyUp
        If sender.Text.Replace(" ", "").Length < 10 Then Exit Sub
        Dim SaDR = Db.GetDataDictionary($"Select * from Customer where CuTelNo1='{sender.Text}' or CuTelNo2='{sender.Text}' or CuTelNo3='{sender.Text}';")
        If SaDR IsNot Nothing Then
            If cmbCuMr.Text + cmbCuName.Text = SaDR("CuName").ToString Then Exit Sub
            Dim frm As New frmCustomer
            With frm
                frm.Name = "frmCustomer" + NextfrmNo(frmCustomer).ToString
                frm.Caller = Me.Name
                frm.Tag = "Receive"
                frm.Show(Me)
                frm.SelectCustomer(SaDR("CuNo"), SaDR("CuName"), SaDR("CuTelNo1"), SaDR("CuTelNo2"), SaDR("CuTelNo3"))
            End With
        Else
            cmbCuName_SelectedIndexChanged(sender, e)
        End If
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