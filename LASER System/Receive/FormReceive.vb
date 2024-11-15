Imports LASER_System.StructureDatabase
Imports MySqlConnector
Imports System.IO
Imports System.Threading
Imports ZXing

Public Class FormReceive
    Public Property Caller As String

    Private Db As New Database
    Private RepairController As New RepairController
    Private ReRerepairControlelr As New ReRepairController
    Private ControlCommandInfo As ControlCommandInfo

    Public Sub New()
        InitializeComponent()
        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub FrmReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RepairController.SetDatabase(Db)
        Call CmdNew_Click(Nothing, Nothing)
        txtCuTelNo1.Focus()
    End Sub

    Private Sub FrmReceive_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ControlCommandInfo?.KeyDownEvent(sender, e)
    End Sub

    Private Sub CmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        'If txtCuTelNo1.Text.Trim = "" Then
        '    Dim DrCheckCustomerExist = Db.GetDataDictionary("SELECT * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
        '                                 "' and CuTelNo2='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "';")
        '    If DrCheckCustomerExist IsNot Nothing Then
        '        cmbCuName_Text(DrCheckCustomerExist("CuName").ToString)
        '        txtCuTelNo1.Text = DrCheckCustomerExist("CuTelNo1").ToString
        '        txtCuTelNo2.Text = DrCheckCustomerExist("CuTelNo2").ToString
        '        txtCuTelNo3.Text = DrCheckCustomerExist("CuTelNo3").ToString
        '    Else
        '        For i As Integer = 0 To 1000
        '            Dim DrCuNameSuggest = Db.GetDataDictionary("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
        '            If DrCuNameSuggest Is Nothing Then
        '                cmbCuName_Text(cmbCuName.Text + " " + i.ToString)
        '                Exit For
        '            End If
        '        Next
        '    End If
        'Else
        '    Dim DrCheckCustomerExist = Db.GetDataDictionary("SELECT * from Customer where CuName='" & cmbCuName.Text & "' and CuTelNo1='" & txtCuTelNo1.Text &
        '                                 "' and CuTelNo2='" & txtCuTelNo2.Text & "' and CuTelNo3='" & txtCuTelNo3.Text & "';")
        '    If DrCheckCustomerExist IsNot Nothing Then Exit Sub
        '    If cmbCuName.Text = "" Then Exit Sub
        '    Dim DrCuName = Db.GetDataDictionary("Select CuName from Customer where CuName ='" & cmbCuName.Text & "';")

        '    If DrCuName IsNot Nothing Then
        '        For i As Integer = 0 To 1000
        '            Dim DrCuNameSuggest = Db.GetDataDictionary("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
        '            If DrCuNameSuggest Is Nothing Then
        '                cmbCuName_Text(cmbCuName.Text + " " + i.ToString)
        '                Exit For
        '            End If
        '        Next
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub CmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click, NewToolStripMenuItem.Click
        Call SetNextKey(Db, txtRNo, "SELECT  RNo from Receive ORDER BY RNo Desc LIMIT 1;", "RNo")
        For Each obj As Object In {cmbCuMr, cmbCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3}
            obj.Text = ""
        Next
        grdRepair.Rows.Clear()
        grdReRepair.Rows.Clear()
        grdRepair.CurrentCell = grdRepair.Rows(grdRepair.Rows.Count - 1).Cells(0)
        ComboBoxDropDown(Db, cmbCuName, "SELECT CuName FROM Customer GROUP BY CuName;")

        Dim DataTableTechnician As DataTable = Db.GetDataTable("SELECT TName FROM Technician WHERE TActive=1 GROUP BY TName;")
        Dim newRow As DataRow = DataTableTechnician.NewRow()
        newRow("TName") = "None"
        DataTableTechnician.Rows.InsertAt(newRow, 0)
        Dim Technicians = DataTableTechnician.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        Dim ColumnRepair As DataGridViewComboBoxColumn = grdRepair.Columns.Item(RepairGridColumns.Technician)
        ColumnRepair.DataSource = Technicians
        Dim ColumnReRepair As DataGridViewComboBoxColumn = grdReRepair.Columns.Item(ReRepairGridColumns.Technician)
        ColumnReRepair.DataSource = Technicians

        txtCuTelNo1.Focus()
    End Sub

    Private Sub ControlCommandInfo_Cancel()
        MenuStrip.Enabled = True
        AcceptButton = cmdSave
        txtCuTelNo1.Focus()
    End Sub

    Private Sub ControlCommandInfo_Submit()
        MenuStrip.Enabled = True
        AcceptButton = cmdSave
        CmdNew_Click(ControlCommandInfo, Nothing)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click, CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, SaveToolStripMenuItem.Click
        Try
            Dim Validation = SaveValidation()
            If Not Validation.Status Then
                MessageBox.Error(Validation.Message)
                Return
            End If

            If Tag = "Deliver" Then
                SetDataToControlCommandInfo()
                Tag = ""
                Close()
                Return
            End If

            ControlCommandInfo = New ControlCommandInfo With {
                .Dock = DockStyle.Fill
            }
            ControlCommandInfo.SetDatabase(Db)
            SetDataToControlCommandInfo()
            AddHandler ControlCommandInfo.CancelEvent, AddressOf ControlCommandInfo_Cancel
            AddHandler ControlCommandInfo.SubmitEvent, AddressOf ControlCommandInfo_Submit
            Controls.Add(ControlCommandInfo)
            ControlCommandInfo.BringToFront()

            MenuStrip.Enabled = False
        Catch ex As Exception
            MessageBox.Error("Save Section එකෙහි දෝෂයක් පවතියි." + vbCrLf + "Message: " + ex.Message)
        End Try
    End Sub

    Private Function SaveValidation() As (Status As Boolean, Message As String)
        If cmbCuName.Text.Trim = "" Then
            Return (False, "Customer Name යන field එක හිස්ව පවතියි. කරුණාකර Customer කෙනෙකු තෝරා නැවත උත්සහ කරන්න.")
        ElseIf grdRepair.Rows.Count < 2 And grdReRepair.Rows.Count < 2 Then
            grdRepair.Focus()
            Return (False, "ඔබ තවමත් කිසිම Repair එකක් හෝ RERepair එකක් ඇතුලත් කර නොමැත. කරුණාකර Repair එකක් හෝ RERepair එකක් ඇතුලත් කර නැවත උත්සහ කරන්න.")
        ElseIf txtCuTelNo1.Text.Trim <> "" AndAlso txtCuTelNo1.Text.Trim.Length < 10 Then
            Return (False, "Customer Telephone No 1 field එකෙහි සම්පුර්ණ දුරකතනය ඇතුලත් කර නොමැත.")
        ElseIf txtCuTelNo2.Text.Trim <> "" AndAlso txtCuTelNo2.Text.Trim.Length < 10 Then
            Return (False, "Customer Telephone No 2 field එකෙහි සම්පුර්ණ දුරකතනය ඇතුලත් කර නොමැත.")
        ElseIf txtCuTelNo3.Text.Trim <> "" AndAlso txtCuTelNo3.Text.Trim.Length < 10 Then
            Return (False, "Customer Telephone No 3 field එකෙහි සම්පුර්ණ දුරකතනය ඇතුලත් කර නොමැත.")
        End If

        grdRepair.EndEdit()
        grdReRepair.EndEdit()
        cmdSave.Focus()
        For Each Row As DataGridViewRow In grdRepair.Rows
            If Row.IsNewRow Then
                Continue For
            End If

            If Row.Cells(0).Value.ToString = "" Then
                Return (False, Row.Index + " වන තීරුවේ Repair No යන fild එක හිස්ව පවතින බැවින් Save කිරීමට අපොහොසත් විය. එම තීරුව ඉවත් කර නැවත ඇතුලත් කරන්න.")
            End If
            If Row.Cells(1).Value Is Nothing OrElse Row.Cells(1).Value.ToString = "" Then
                Return (False, "Repair No: " + Row.Cells(0).Value.ToString + " හි Product Category Field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
            End If
            If Row.Cells(2).Value Is Nothing OrElse Row.Cells(2).Value.ToString = "" Then
                Return (False, "Repair No: " + Row.Cells(0).Value.ToString + " හි Product Name Field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
            End If
        Next
        For Each Row As DataGridViewRow In grdReRepair.Rows
            If Row.IsNewRow Then
                Continue For
            End If
            If Row.Cells(0).Value.ToString = "" Then
                Return (False, Row.Index + " වන තීරුවේ RERepair No යන fild එක හිස්ව පවතින බැවින් Save කිරීමට අපොහොසත් විය. එම තීරුව ඉවත් කර නැවත ඇතුලත් කරන්න.")
            End If
            If Row.Cells(1).Value.ToString = "" Then
                Return (False, "RERepair No: " + Row.Cells(0).Value.ToString + " හි Repair No Field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
            End If
        Next

        Return (True, "")
    End Function

    Private Sub SetDataToControlCommandInfo()
        Dim DataTableRepair, DataTableReRepair As New DataTable
        DataTableRepair.Columns.AddRange({
            New DataColumn(Repair.RepNo),
            New DataColumn(Product.PCategory),
            New DataColumn(Product.PName),
            New DataColumn(Repair.PSerialNo),
            New DataColumn(Product.PDetails),
            New DataColumn(Repair.Qty),
            New DataColumn(Repair.Problem),
            New DataColumn(RepairRemarks1.Remarks),
            New DataColumn(Technician.TName)
        })
        For Each Row As DataGridViewRow In grdRepair.Rows
            If Row.IsNewRow Then
                Exit For
            End If
            Dim NewRow As DataRow = DataTableRepair.NewRow()
            NewRow(Repair.RepNo) = Row.Cells(RepairGridColumns.RepairNo).Value
            NewRow(Product.PCategory) = Row.Cells(RepairGridColumns.ProductCategory).Value
            NewRow(Product.PName) = Row.Cells(RepairGridColumns.ProductName).Value
            NewRow(Repair.PSerialNo) = Row.Cells(RepairGridColumns.ProductSerialNo).Value
            NewRow(Product.PDetails) = Row.Cells(RepairGridColumns.ProductDescription).Value
            NewRow(Repair.Qty) = Row.Cells(RepairGridColumns.Qty).Value
            NewRow(Repair.Problem) = Row.Cells(RepairGridColumns.Problem).Value
            NewRow(RepairRemarks1.Remarks) = Row.Cells(RepairGridColumns.Remarks).Value
            NewRow(Technician.TName) = Row.Cells(RepairGridColumns.Technician).Value
            DataTableRepair.Rows.Add(NewRow)
        Next

        DataTableReRepair.Columns.AddRange({
            New DataColumn(ReRepair.RetNo),
            New DataColumn(ReRepair.RepNo),
            New DataColumn(Product.PCategory),
            New DataColumn(Product.PName),
            New DataColumn(ReRepair.PSerialNo),
            New DataColumn(Product.PDetails),
            New DataColumn(ReRepair.Qty),
            New DataColumn(ReRepair.Problem),
            New DataColumn(RepairRemarks1.Remarks),
            New DataColumn(Technician.TName)
        })
        For Each Row As DataGridViewRow In grdReRepair.Rows
            If Row.IsNewRow Then
                Exit For
            End If
            Dim NewRow As DataRow = DataTableReRepair.NewRow()
            NewRow(ReRepair.RetNo) = Row.Cells(ReRepairGridColumns.ReRepairNo).Value
            NewRow(ReRepair.RepNo) = Row.Cells(ReRepairGridColumns.RepairNo).Value
            NewRow(Product.PCategory) = Row.Cells(ReRepairGridColumns.ProductCategory).Value
            NewRow(Product.PName) = Row.Cells(ReRepairGridColumns.ProductName).Value
            NewRow(ReRepair.PSerialNo) = Row.Cells(ReRepairGridColumns.ProductSerialNo).Value
            NewRow(Product.PDetails) = Row.Cells(ReRepairGridColumns.ProductDescription).Value
            NewRow(ReRepair.Qty) = Row.Cells(ReRepairGridColumns.Qty).Value
            NewRow(ReRepair.Problem) = Row.Cells(ReRepairGridColumns.Problem).Value
            NewRow(RepairRemarks1.Remarks) = Row.Cells(ReRepairGridColumns.Remarks).Value
            NewRow(Technician.TName) = Row.Cells(ReRepairGridColumns.Technician).Value
            DataTableReRepair.Rows.Add(NewRow)
        Next
        ControlCommandInfo.SetData(New Dictionary(Of String, Object) From {
            {Receive.RDate, txtRDate.Text},
            {Customer.CuName, $"{cmbCuMr.Text}{cmbCuName.Text}"},
            {Customer.CuTelNo1, txtCuTelNo1.Text},
            {Customer.CuTelNo2, txtCuTelNo2.Text},
            {Customer.CuTelNo3, txtCuTelNo3.Text}
        }, DataTableRepair, DataTableReRepair)
        'If Me.Tag = "Deliver" Then
        '    For Each oForm As FormDeliver In Application.OpenForms().OfType(Of FormDeliver)()
        '        If oForm.Name = Me.Caller Then
        '            With oForm
        '                .cmbCuName.Text = cmbCuMr.Text & cmbCuName.Text
        '                .txtCuTelNo1.Text = txtCuTelNo1.Text
        '                .txtCuTelNo2.Text = txtCuTelNo2.Text
        '                .txtCuTelNo3.Text = txtCuTelNo3.Text
        '                .grdRERepair.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells("RETPCategory").Value, row.Cells("RETPName").Value, row.Cells("RETQty").Value, "0", "", "")
        '            End With
        '            Exit For
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub grdRepair_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepair.EditingControlShowing
        If grdRepair.CurrentCell.ColumnIndex = 8 Then
            Exit Sub
        End If
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
            Case 5
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
            CmbCuName_SelectedIndexChanged(sender, e)
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