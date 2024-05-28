Imports System.Data.Odbc
Public Class frmTechnicianCost
    Private Db As New Database
    Private dtpDate As New DateTimePicker

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdTCClose.Click
        Call frmTechnicianCost_Leave(sender, e)
    End Sub

    Private Sub cmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call ComboBoxDropDown(Db, cmbTName, "Select TName from Technician Where TActive = True group by TName;")
    End Sub

    Private Sub cmbTName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTName.SelectedIndexChanged
        Call cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub frmTechnicianCost_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub frmTechnicianCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
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
        DR = Db.GetDataReader("Select TCNo,TCDate,RepNo,RetNo,TCRemarks,SNo,SCategory,SName,Rate, Qty,Total,UserName from ((TechnicianCost TC Inner Join Technician T On T.Tno = TC.TNo) Left Join `User` U ON U.Uno = TC.UNo) where TName='" &
                                cmbTName.Text & "' And TCDate BETWEEN #" & Format(txtTCFrom.Value, "yyyy-MM-dd") & " 00:00:00# And #" &
                                Format(txtTCTo.Value, "yyyy-MM-dd") & " 23:59:59#" &
                                If(txtSearch.Text <> "",
                                " And (TCDate Like '%" & txtSearch.Text & "%' or TCRemarks Like '%" & txtSearch.Text & "%' or SNo Like '%" & txtSearch.Text & "%' or SCategory Like '%" & txtSearch.Text & "%' or SName Like '%" &
                                txtSearch.Text & "%' or Rate Like '%" & txtSearch.Text & "%' or Qty Like '%" & txtSearch.Text & "%' or Total Like '%" & txtSearch.Text & "%' or UserName Like '%" & txtSearch.Text & "%')", "") & ";")
        grdTechnicianCost.Rows.Clear()
        While DR.Read
            grdTechnicianCost.Rows.Add(DR("TCNo").ToString, DR("TCDate").ToString, DR("SNo").ToString, DR("SCategory").ToString,
                DR("SName").ToString, DR("Rate").ToString, DR("Qty").ToString, DR("Total").ToString, DR("TCRemarks").ToString,
                DR("RepNo").ToString, DR("RetNo").ToString, DR("UserName").ToString)
        End While
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

    Private Sub cmdTView_Click(sender As Object, e As EventArgs) Handles cmdTView.Click
        frmTechnician.Tag = "TechnicianCost"
        frmTechnician.Show()
    End Sub

    Private Sub txtTCFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtTCFrom.ValueChanged
        Call cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub txtTCTo_ValueChanged(sender As Object, e As EventArgs) Handles txtTCTo.ValueChanged
        Call cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Call frmTechnicianCost_Leave(sender, e)
    End Sub

    Private Sub TechnicionInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicionInfoToolStripMenuItem.Click
        cmdTView_Click(sender, e)
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

    Public Sub grdTechnicianCost_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdTechnicianCost.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        If e.RowIndex <> grdTechnicianCost.Rows.Count - 1 AndAlso
            CheckEmptyControl(cmbTName, "Technician Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.") = False Then
            'If (grdTechnicianCost.Rows.Count - 1) <> e.RowIndex Then
            '    grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
            'End If
            Exit Sub
        End If
        Dim tmp As String = ""
        Dim AdminPer As New AdminPermission(Db) With {.Remarks = "අද දිනට නොමැති Technician Cost Data එකක් update කෙරුණි."}
        Select Case e.ColumnIndex
            Case 1
                If Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Tag).Date <> Today.Date And
                    User.Instance.UserType <> User.Type.Admin Then
                    AdminPer.AdminSend = True
                    AdminPer.Remarks = "අද දිනට නොමැති Technician Cost Data එකක Time එක update කෙරුණි."
                Else
                    grdTechnicianCost.CurrentCell.Value = dtpDate.Value.ToString
                End If
                dtpDate.Visible = False
            Case 2
                If grdTechnicianCost.Item(2, e.RowIndex).Value Is Nothing Then Exit Sub
                DR = Db.GetDataReader("Select SNo,SCategory,SName,SSalePrice from Stock Where SNo=" &
                                       grdTechnicianCost.Item(2, e.RowIndex).Value.ToString)
                If DR.HasRows Then
                    DR.Read()
                    grdTechnicianCost.Item(3, e.RowIndex).Value = DR("SCategory").ToString
                    grdTechnicianCost.Item(4, e.RowIndex).Value = DR("SName").ToString
                    grdTechnicianCost.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdTechnicianCost.Item(6, e.RowIndex).Value = "1"
                    Dim E1 As New DataGridViewCellEventArgs(6, e.RowIndex)
                    grdTechnicianCost_CellEndEdit(sender, E1)
                    tmp = ",SCategory='" & DR("Scategory").ToString & "',SName='" & DR("SName").ToString & "',Rate=" & DR("SSalePrice").ToString
                End If
            Case 3, 4
                frmSearchDropDown.frm_Close()
                If grdTechnicianCost.Item(3, e.RowIndex).Value Is Nothing Or grdTechnicianCost.Item(4, e.RowIndex).Value Is Nothing Then Exit Sub
                DR = Db.GetDataReader("Select SNo,SCategory,SName,SSalePrice from Stock Where SCategory='" & grdTechnicianCost.Item(3, e.RowIndex).Value &
                                       "' and SName='" & grdTechnicianCost.Item(4, e.RowIndex).Value & "';")
                If DR.HasRows Then
                    DR.Read()
                    grdTechnicianCost.Item(2, e.RowIndex).Value = DR("SNo").ToString
                    grdTechnicianCost.Item(3, e.RowIndex).Value = DR("SCategory").ToString
                    grdTechnicianCost.Item(4, e.RowIndex).Value = DR("SName").ToString
                    grdTechnicianCost.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdTechnicianCost.Item(6, e.RowIndex).Value = "1"
                    Dim E1 As New DataGridViewCellEventArgs(6, e.RowIndex)
                    grdTechnicianCost_CellEndEdit(sender, E1)
                    tmp = ",SNo=" & DR("SNo").ToString &
                        If(e.ColumnIndex = 4, ",SCategory='" & DR("Scategory").ToString, ",SName='" &
                        DR("SName").ToString) & "',Rate=" & DR("SSalePrice").ToString
                End If
            Case 5, 6
                If grdTechnicianCost.Item(5, e.RowIndex).Value IsNot Nothing And grdTechnicianCost.Item(6, e.RowIndex).Value IsNot Nothing Then
                    grdTechnicianCost.Item(7, e.RowIndex).Value = Val(grdTechnicianCost.Item(5, e.RowIndex).Value) *
                        Val(grdTechnicianCost.Item(6, e.RowIndex).Value)
                    tmp = ",Total=" & grdTechnicianCost.Item(7, e.RowIndex).Value
                Else
                    grdTechnicianCost.Item(7, e.RowIndex).Value = "0"
                End If
            Case 9
                grdTechnicianCost.Item(10, e.RowIndex).Value = ""
                tmp += ",RepNo=NULL"
            Case 10
                grdTechnicianCost.Item(9, e.RowIndex).Value = ""
                tmp += ",RetNo=NULL"
        End Select
        If grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value Then
            Exit Sub
        End If
        If e.RowIndex = (grdTechnicianCost.Rows.Count - 1) Then Exit Sub
        If grdTechnicianCost.Item(1, e.RowIndex).Value Is Nothing Then
            grdTechnicianCost.Item(1, e.RowIndex).Value = DateAndTime.Now
            tmp += ",TCDate=#" & grdTechnicianCost.Item(1, e.RowIndex).Value & "#"
        End If
        If grdTechnicianCost.Item(11, e.RowIndex).Value Is Nothing Or
            grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value IsNot grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag Then
            grdTechnicianCost.Item(11, e.RowIndex).Value = User.Instance.UserName
            tmp += ",UNo=" & User.Instance.UserNo
        End If
        If grdTechnicianCost.Item("Total", e.RowIndex).Value Is Nothing OrElse
            grdTechnicianCost.Item("Total", e.RowIndex).Value.ToString = "" Then grdTechnicianCost.Item("Total", e.RowIndex).Value = "0"
        If grdTechnicianCost.Item(0, e.RowIndex).Value Is Nothing Then
            grdTechnicianCost.Item(0, e.RowIndex).Value = Db.GetNextKey("TechnicianCost", "TCNo")
        End If
        If CheckExistData("Select * from TechnicianCost Where TCNo=" & grdTechnicianCost.Item(0, e.RowIndex).Value) = False Then Db.Execute("Insert into TechnicianCost(TCNo,TNo,Rate,Qty,Total,UNo) Values(" & grdTechnicianCost.Item(0, e.RowIndex).Value & "," &
                      Db.GetData("Select TNo from Technician Where TName='" & cmbTName.Text & "'") & ",0,0,0," & User.Instance.UserNo & ")")
        If Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Value).Date <> Today.Date Then
            AdminPer.AdminSend = True
        End If
        Select Case e.ColumnIndex
            Case 1
                Db.Execute("Update TechnicianCost set " & grdTechnicianCost.Columns(e.ColumnIndex).DataPropertyName & "=#" &
                          grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value & "# " & tmp & " Where TCNo=" &
                          grdTechnicianCost.Item(0, e.RowIndex).Value, {}, AdminPer)
            Case 2, 5, 6, 7, 9, 10
                Db.Execute("Update TechnicianCost set " & grdTechnicianCost.Columns(e.ColumnIndex).DataPropertyName & "=" &
                          grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value & " " & tmp & " Where TCNo=" &
                          grdTechnicianCost.Item(0, e.RowIndex).Value, {}, AdminPer)
            Case 3, 4, 8
                Db.Execute("Update TechnicianCost set " & grdTechnicianCost.Columns(e.ColumnIndex).DataPropertyName & "='" &
                          grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value & "' " & tmp & " Where TCNo=" &
                          grdTechnicianCost.Item(0, e.RowIndex).Value, {}, AdminPer)
        End Select
        grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = ""
        cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub grdTechnicianCost_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdTechnicianCost.UserDeletingRow
        If grdTechnicianCost.Item("TCNo", e.Row.Index).Value Is Nothing Then
            MsgBox("Technician Cost No එක හිස්ව පවතියි.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If User.Instance.UserType = User.Type.Admin Then
            Dim DR As OdbcDataReader = Db.GetDataReader("Select TCNo from TechnicianCost Where TCNo=" & grdTechnicianCost.Item("TCNo", e.Row.Index).Value)
            If DR.HasRows = True Then
                DR.Read()
                If DR("SNo").ToString <> "" Then
                    Dim Response = MsgBox("ඔබට මෙම Item එක Technician Cost තුලින් ඉවත් කිරිමට අවශ්‍ය බැවින්, එම Item එක නැවත Available Units තුලට පිරවීමට අවශ්‍යද? " +
                                      vbCr + vbCr + "Yes - එසෙ නම් ඔබ 'Yes' යන Button එක Click කරන්න. " + vbCr + vbCr +
                                      "No - නැතහොත්, ඔබට මෙම item එක Damaged Units වලට add කිරිමට අවශ්‍ය නම්, 'No' යන Button එක Click කරන්න." + vbCr +
                                      vbCr + "Cancel - ඔබට ඉවත් වීමට අවශ්‍ය නම් 'Cancel' යන Button එක Click කරන්න.", vbYesNoCancel + vbCritical)
                    If Response = vbCancel Then
                        e.Cancel = True
                        Exit Sub
                    ElseIf Response = vbYes Then
                        Db.Execute("Update Stock set SAvailablestocks=(SAvailableStocks + " & grdTechnicianCost.Item("Qty", e.Row.Index).Value &
                                                             ") where SNo=" & grdTechnicianCost.Item("SNo", e.Row.Index).Value & "")
                        Db.Execute("DELETE from TechnicianCost where TCNo=" & grdTechnicianCost.Item(0, e.Row.Index).Value)       'delete data from stocksale 
                    ElseIf Response = vbNo Then
                        Db.Execute("Update Stock set SOutofStocks=(SOutofStocks + " & grdTechnicianCost.Item("Qty", e.Row.Index).Value &
                                                             ") where SNo=" & grdTechnicianCost.Item("SNo", e.Row.Index).Value & "")
                        Db.Execute("DELETE from TechnicianCost where TCNo=" & grdTechnicianCost.Item(0, e.Row.Index).Value)      'delete data from stocksale 
                    End If
                Else
                    If MsgBox("Are you sure delete this Technician Cost data?", vbYesNo + vbExclamation) = vbYes Then
                        Db.Execute("DELETE from TechnicianCost where TCNo=" & grdTechnicianCost.Item(0, e.Row.Index).Value)      'delete data from stocksale 
                    End If
                End If
            End If
        End If
        cmdTCSearch_Click(sender, e)
    End Sub

    Private Sub grdTechnicianCost_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdTechnicianCost.RowValidating
        If e.RowIndex < 0 Or e.RowIndex > (grdTechnicianCost.Rows.Count - 2) Then Exit Sub
        Dim DRTC As OdbcDataReader = Db.GetDataReader("Select TC.*,UserName from TechnicianCost TC Left Join `User` U On U.Uno = TC.UNo Where TCNo=" & grdTechnicianCost.Item(0, e.RowIndex).Value)
        If DRTC.HasRows Then
            DRTC.Read()
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
        DRTC.Close()
    End Sub
End Class