Imports MySqlConnector
Public Class FormTechnicianCost
    Private Db As New Database
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

    Private Sub txtTCFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtTCFrom.ValueChanged, txtTCTo.ValueChanged, cmbTName.SelectedIndexChanged, txtSearch.TextChanged
        Call cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        ControlTechnicianCostInfo = New ControlTechnicianCostInfo
        ControlTechnicianCostInfo.SetDatabase(Db).Init(UpdateMode.New).SetTechnician(cmbTName.Text)
        AddHandler ControlTechnicianCostInfo.SubmitEvent, AddressOf ControlTechnicianCostInfo_Submit
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
        AddHandler ControlTechnicianCostInfo.SubmitEvent, AddressOf ControlTechnicianCostInfo_Submit
        Me.Controls.Add(ControlTechnicianCostInfo)
        ControlTechnicianCostInfo.Dock = DockStyle.Fill
        ControlTechnicianCostInfo.BringToFront()
    End Sub

    Private Sub ControlTechnicianCostInfo_Submit()
        cmdTCSearch.PerformClick()
    End Sub

    Private Sub ButtonBulkInsert_Click(sender As Object, e As EventArgs) Handles ButtonBulkInsert.Click
        Dim ControlBulkInsert As New ControlTechnicianCostBulkInsert
        ControlBulkInsert.Init(Db)
        Me.Controls.Add(ControlBulkInsert)
        ControlBulkInsert.BringToFront()
        ControlBulkInsert.Dock = DockStyle.Fill
    End Sub
End Class