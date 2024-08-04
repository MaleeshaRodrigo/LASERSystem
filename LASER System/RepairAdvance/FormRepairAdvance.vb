Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class FormRepairAdvance
    Private Db As New Database
    Private ControlRepairAdvanceInfo As ControlRepairAdvanceInfo

    Private Sub frmRepairAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilter.Text = "All"
        cmdSearch_Click(sender, e)
        If User.Instance.UserType = User.Type.Admin Then
            grdRepAdvanced.Columns(0).Visible = True
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim Search As String = "Where "
        Select Case cmbFilter.Text
            Case "Date"
                Search += "ADDate like '%" & txtSearch.Text & "%'"
            Case "Repair No"
                Search += "RepNo like '%" & txtSearch.Text & "%'"
            Case "RE-Repair No"
                Search += "RetNo like '%" & txtSearch.Text & "%'"
            Case "Amount"
                Search += "Amount like '%" & txtSearch.Text & "%'"
            Case "Remarks"
                Search += "Remarks like '%" & txtSearch.Text & "%'"
            Case "All"
                Search += "ADDate like '%" & txtSearch.Text & "%' or RepNo like '%" & txtSearch.Text & "%' or RetNo like '%" & txtSearch.Text & "%' or Amount like '%" &
                    txtSearch.Text & "%' or Remarks like '%" & txtSearch.Text & "%'"
        End Select
        grdRepAdvanced.DataSource = Db.GetDataTable("Select AD.*, U.UserName from RepairAdvanced AD LEFT JOIN `User` U ON U.UNo = AD.UNo " & Search)
    End Sub

    Private Sub grdRepAdvanced_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepAdvanced.CellDoubleClick
        If e.RowIndex < 0 OrElse grdRepAdvanced.Item(0, e.RowIndex).Value Is Nothing Then
            Exit Sub
        End If

        ControlRepairAdvanceInfo = New ControlRepairAdvanceInfo With {
            .Dock = DockStyle.Fill
        }
        ControlRepairAdvanceInfo.SetDatabase(Db).SetData(grdRepAdvanced.Rows.Item(e.RowIndex).DataBoundItem)
        Me.Controls.Add(ControlRepairAdvanceInfo)
        ControlRepairAdvanceInfo.BringToFront()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        ControlRepairAdvanceInfo = New ControlRepairAdvanceInfo With {
            .Dock = DockStyle.Fill
        }
        ControlRepairAdvanceInfo.SetDatabase(Db)
        Me.Controls.Add(ControlRepairAdvanceInfo)
        ControlRepairAdvanceInfo.BringToFront()
    End Sub
End Class