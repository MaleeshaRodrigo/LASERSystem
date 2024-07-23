Imports MySqlConnector
Public Class FormTechnicianCost
    Private Db As New Database
    Private dtpDate As New DateTimePicker
    Private ControlTechnicianCostInfo As ControlTechnicianCostInfo

    Private Sub cmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call ComboBoxDropDown(Db, cmbTName, "Select TName from Technician Where TActive = True group by TName;")
    End Sub

    Private Sub frmTechnicianCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip.Items.Add(mnustrpMENU)
        txtTCFrom.Value = Date.Today.Year & "-" & Date.Today.Month & "-01"
        txtTCTo.Value = Date.Today
        cmbTName_DropDown(sender, e)
    End Sub

    Private Sub cmdTCSearch_Click(sender As Object, e As EventArgs) Handles cmdTCSearch.Click
        If cmbTName.Text = "" Then
            grdTechnicianCost.Rows.Clear()
            Exit Sub
        End If
        DR = Db.GetDataList("Select TCNo,TCDate,RepNo,RetNo,TCRemarks,SNo,SCategory,SName,Rate, Qty,Total,UserName from ((TechnicianCost TC Inner Join Technician T On T.Tno = TC.TNo) Left Join `User` U ON U.Uno = TC.UNo) where TName='" &
                                cmbTName.Text & "' And TCDate BETWEEN '" & Format(txtTCFrom.Value, "yyyy-MM-dd") & " 00:00:00' And '" &
                                Format(txtTCTo.Value, "yyyy-MM-dd") & " 23:59:59'" &
                                If(txtSearch.Text <> "",
                                " And (TCDate Like '%" & txtSearch.Text & "%' or TCRemarks Like '%" & txtSearch.Text & "%' or SNo Like '%" & txtSearch.Text & "%' or SCategory Like '%" & txtSearch.Text & "%' or SName Like '%" &
                                txtSearch.Text & "%' or Rate Like '%" & txtSearch.Text & "%' or Qty Like '%" & txtSearch.Text & "%' or Total Like '%" & txtSearch.Text & "%' or UserName Like '%" & txtSearch.Text & "%')", "") & ";")
        grdTechnicianCost.Rows.Clear()
        For Each Item In DR
            grdTechnicianCost.Rows.Add(Item("TCNo").ToString, Item("TCDate").ToString, Item("SNo").ToString, Item("SCategory").ToString,
                Item("SName").ToString, Item("Rate").ToString, Item("Qty").ToString, Item("Total").ToString, Item("TCRemarks").ToString,
                Item("RepNo").ToString, Item("RetNo").ToString, Item("UserName").ToString)
        Next
        grdTechnicianCost.Refresh()
        txtTCSubTotal.Text = "0"
        For Each Row As DataGridViewRow In grdTechnicianCost.Rows
            If Row.Cells("Total").Value <> "" And txtTCSubTotal.Text <> "" Then
                txtTCSubTotal.Text = Int(txtTCSubTotal.Text) + Int(Row.Cells("Total").Value.ToString)
            Else
                Continue For
            End If
        Next
    End Sub

    Private Sub txtTCFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtTCFrom.ValueChanged, txtTCTo.ValueChanged, cmbTName.SelectedIndexChanged
        Call cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub grdTechnicianCost_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdTechnicianCost.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 1
                grdTechnicianCost.Controls.Add(dtpDate)
                dtpDate.Location = grdTechnicianCost.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                dtpDate.Size = New Size(grdTechnicianCost.Columns.Item(e.ColumnIndex).Width, grdTechnicianCost.Rows.Item(e.RowIndex).Height)
                dtpDate.Format = DateTimePickerFormat.Custom
                dtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
                dtpDate.Visible = True
                If grdTechnicianCost.CurrentCell.Value Is Nothing Then
                    dtpDate.Value = DateAndTime.Now
                Else
                    dtpDate.Value = Convert.ToDateTime(grdTechnicianCost.CurrentCell.Value)
                End If
        End Select
        grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdTechnicianCost_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdTechnicianCost.EditingControlShowing
        If grdTechnicianCost.CurrentCell.RowIndex < 0 Then Exit Sub
        Select Case grdTechnicianCost.CurrentCell.ColumnIndex
            Case 1
                dtpDate.Location = grdTechnicianCost.GetCellDisplayRectangle(grdTechnicianCost.CurrentCell.ColumnIndex,
                                                                              grdTechnicianCost.CurrentCell.RowIndex, True).Location
                dtpDate.Size = New Size(grdTechnicianCost.Columns.Item(grdTechnicianCost.CurrentCell.ColumnIndex).Width,
                                        grdTechnicianCost.Rows.Item(grdTechnicianCost.CurrentCell.RowIndex).Height)
            Case 3
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, grdTechnicianCost, Me, "Select SCategory from Stock group by SCategory;", "SCategory")
            Case 4
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(Db, grdTechnicianCost, Me, "Select SCategory,SName from Stock where SCategory='" &
                grdTechnicianCost.Item(3, grdTechnicianCost.CurrentCell.RowIndex).Value & "';", "SName")
        End Select
    End Sub

    Private Sub grdTechnicianCost_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdTechnicianCost.RowValidating
        If e.RowIndex < 0 Or e.RowIndex > (grdTechnicianCost.Rows.Count - 2) Then Exit Sub
        Dim DRTC = Db.GetDataDictionary("Select TC.*,UserName from TechnicianCost TC Left Join `User` U On U.Uno = TC.UNo Where TCNo=" & grdTechnicianCost.Item(0, e.RowIndex).Value)
        If DRTC IsNot Nothing Then
            grdTechnicianCost.Item(1, e.RowIndex).Value = DRTC("TCDate").ToString
            grdTechnicianCost.Item(2, e.RowIndex).Value = DRTC("SNo").ToString
            grdTechnicianCost.Item(3, e.RowIndex).Value = DRTC("SCategory").ToString
            grdTechnicianCost.Item(4, e.RowIndex).Value = DRTC("SName").ToString
            grdTechnicianCost.Item(5, e.RowIndex).Value = DRTC("Rate").ToString
            grdTechnicianCost.Item(6, e.RowIndex).Value = DRTC("Qty").ToString
            grdTechnicianCost.Item(7, e.RowIndex).Value = DRTC("Total").ToString
            grdTechnicianCost.Item(8, e.RowIndex).Value = DRTC("TCRemarks").ToString
            grdTechnicianCost.Item(9, e.RowIndex).Value = DRTC("RepNo").ToString
            grdTechnicianCost.Item(10, e.RowIndex).Value = DRTC("RetNo").ToString
            grdTechnicianCost.Item(11, e.RowIndex).Value = DRTC("UserName").ToString
        End If
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        ControlTechnicianCostInfo = New ControlTechnicianCostInfo
        ControlTechnicianCostInfo.SetDatabase(Db).Init(UpdateMode.New).SetTechnician(cmbTName.Text)
        Me.Controls.Add(ControlTechnicianCostInfo)
        ControlTechnicianCostInfo.Dock = DockStyle.Fill
        ControlTechnicianCostInfo.BringToFront()
    End Sub

    Private Sub grdTechnicianCost_DoubleClick(sender As Object, e As EventArgs) Handles grdTechnicianCost.DoubleClick
        ControlTechnicianCostInfo = New ControlTechnicianCostInfo
        Dim Data As New Dictionary(Of String, Object) From {
            {"TName", cmbTName.Text}
        }
        For Each Column As DataGridViewColumn In grdTechnicianCost.Columns
            Data.Add(Column.Name, grdTechnicianCost.CurrentRow.Cells(Column.Name).Value)
        Next
        ControlTechnicianCostInfo.SetDatabase(Db).Init(UpdateMode.Edit, Data).SetTechnician(cmbTName.Text)
        Me.Controls.Add(ControlTechnicianCostInfo)
        ControlTechnicianCostInfo.Dock = DockStyle.Fill
        ControlTechnicianCostInfo.BringToFront()
    End Sub
End Class