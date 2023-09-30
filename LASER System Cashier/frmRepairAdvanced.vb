Imports System.Data.OleDb
Public Class frmRepairAdvanced
    Private Db As New Database

    Private dtpDate As New DateTimePicker
    Private cmdView As New Button
    Private Sub frmRepairAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        cmbFilter.Text = "All"
        cmdSearch_Click(sender, e)
        cmdNew_Click(sender, e)
        If MdifrmMain.tslblUserType.Text = "Admin" Then
            grdRepAdvanced.Columns(0).Visible = True
        End If
    End Sub

    Private Sub frmRepairAdvanced_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        SetNextKey(Db, txtAdNo, "Select Top 1 AdNo from RepairAdvanced Order by AdNo Desc", "AdNo")
        txtAdDate.Value = DateAndTime.Now
        cmbRepNo.Text = "0"
        txtAmount.Text = ""
        txtRemarks.Text = ""
        cmdSearch_Click(sender, e)
        cmdSave.Text = "Save"
        cmdDelete.Enabled = False
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim AdminPer As New AdminPermission(Db)
        If cmbRepNo.Text = "" Then
            MsgBox("Repair No හෝ RE-Repair No එක ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        ElseIf CheckEmptyfield(txtAmount, "Advanced එකෙහි Amount එක ඇතුලත් කරන්න.") = False Then
            Exit Sub
        End If
        Select Case cmdSave.Text
            Case "Save"
                If (MdifrmMain.tslblUserType.Text <> "Admin" And DateAndTime.DateValue(txtAdDate.Value) <> DateTime.Today.Date) Then
                    AdminPer.AdminSend = True
                    AdminPer.Remarks = "අද දිනට නොමැති Repair එකෙහි " & txtAdNo.Text & " වන Advanced Payment එකක් ඇතුලත් කෙරුණි. "
                End If
                If rbRep.Checked = True Then
                    Db.Execute("Insert into RepairAdvanced(ADNo,ADDate,RepNo,RetNo,Amount,Remarks,UNo) Values(?NewKey?RepairAdvanced?AdNo?,#" &
                          txtAdDate.Value & "#," & cmbRepNo.Text & ",0," & txtAmount.Text & ",'" & txtRemarks.Text & "'," & MdifrmMain.Tag & ")",
                              AdminPer)
                Else
                    Db.Execute("Insert into RepairAdvanced(ADNo,ADDate,RepNo,RetNo,Amount,Remarks,UNo) Values(?NewKey?RepairAdvanced?AdNo?,#" &
                          txtAdDate.Value & "#,0," & cmbRepNo.Text & "," & txtAmount.Text & ",'" & txtRemarks.Text & "'," & MdifrmMain.Tag & ")",
                              AdminPer)
                End If
                If MsgBox("Repair Advanced Invoice එක print කිරීමට අවශ්‍යද?", vbYesNo) = vbYes Then
                    PrintRepairAdvancedToolStripMenuItem_Click(sender, e)
                End If
            Case "Edit"
                If (MdifrmMain.tslblUserType.Text <> "Admin" And DateAndTime.DateValue(txtAdDate.Value) <> DateTime.Today.Date) Then
                    AdminPer.AdminSend = True
                    AdminPer.Remarks = "අද දිනට නොමැති Repair එකෙහි " & txtAdNo.Text & " වන Advanced Payment එකක් වෙනස් කෙරුණි. "
                End If
                If rbRep.Checked = True Then
                    Db.Execute("Update RepairAdvanced set ADDate=#" & txtAdDate.Value &
                              "#, RepNo=" & cmbRepNo.Text &
                              ", RetNo=0" &
                              ", Amount=" & txtAmount.Text &
                              ", Remarks='" & txtRemarks.Text &
                              "', UNo=" & MdifrmMain.Tag &
                              " Where AdNo=" & txtAdNo.Text, AdminPer)
                Else
                    Db.Execute("Update RepairAdvanced set ADDate=#" & txtAdDate.Value &
                              "#, RetNo=" & cmbRepNo.Text &
                              ", RepNo=0" &
                              ", Amount=" & txtAmount.Text &
                              ", Remarks='" & txtRemarks.Text &
                              "', UNo=" & MdifrmMain.Tag &
                              " Where AdNo=" & txtAdNo.Text, AdminPer)
                End If
        End Select
        cmdNew_Click(sender, e)
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
        Dim CMDRepAdv = New OleDbCommand("Select * from RepairAdvanced " & Search, CNN)
        Dim DRRepAdv As OleDbDataReader = CMDRepAdv.ExecuteReader
        grdRepAdvanced.Rows.Clear()
        While DRRepAdv.Read
            grdRepAdvanced.Rows.Add(DRRepAdv("ADNo").ToString, DRRepAdv("ADDate").ToString, DRRepAdv("RepNo").ToString, DRRepAdv("RetNo").ToString,
                                    DRRepAdv("Amount").ToString,
                                DRRepAdv("Remarks").ToString, GetStrfromRelatedfield("Select UserName from [User] Where UNo=" &
                                DRRepAdv("UNo").ToString))
        End While
        grdRepAdvanced.Refresh()
        CMDRepAdv.Cancel()
        DRRepAdv.Close()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim AdminPer As New AdminPermission(Db)
        If CheckExistData(txtAdNo, "Select AdNo from RepairAdvanced Where AdNo=" & txtAdNo.Text, "මෙම Advanced එක ඇතුලත් කර නොමැති එකකි." &
                             " කරුණාකර පරික්ෂා කර නැවත උත්සහ කරන්න.", False) = False Then
            Exit Sub
        End If
        If MdifrmMain.tslblUserType.Text <> "Admin" And Convert.ToDateTime(txtAdDate.Value).Date <> DateTime.Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "Repair හි " & txtAdNo.Text & " Advanced Payment එකක් Delete කෙරුණි."
        End If
        Db.Execute("Delete from RepairAdvanced Where AdNo=" & txtAdNo.Text, AdminPer)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmRepairAdvanced_Leave(sender, e)
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub cmbRepNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRepNo.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub grdRepAdvanced_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepAdvanced.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If grdRepAdvanced.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
        Dim CMDRepAdv As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * from " &
                                        "RepairAdvanced where AdNo=" & grdRepAdvanced.Item(0, e.RowIndex).Value & ";", CNN)
        Dim DRRepAdv As OleDb.OleDbDataReader = CMDRepAdv.ExecuteReader()
        If DRRepAdv.HasRows Then
            DRRepAdv.Read()
            txtAdNo.Text = grdRepAdvanced.Item(0, e.RowIndex).Value
            txtAdDate.Value = DRRepAdv("ADDate").ToString
            If DRRepAdv("RepNo").ToString = "0" Then
                cmbRepNo.Text = DRRepAdv("RetNo").ToString
                rbRep.Checked = False
                rbRERep.Checked = True
            Else
                cmbRepNo.Text = DRRepAdv("RepNo").ToString
                rbRERep.Checked = False
                rbRep.Checked = True
            End If
            txtAmount.Text = DRRepAdv("Amount").ToString
            txtRemarks.Text = DRRepAdv("Remarks").ToString
        End If
        CMDRepAdv.Cancel()
        DRRepAdv.Close()
        cmdSave.Text = "Edit"
        cmdDelete.Enabled = True
    End Sub

    Private Sub cmbRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRepNo.DropDown
        If rbRep.Checked = True Then
            CmbDropDown(cmbRepNo, "Select RepNo from Repair order by RepNo desc", "RepNo")
        Else
            CmbDropDown(cmbRepNo, "Select RetNo from Return order by RetNo desc", "RetNo")
        End If
    End Sub

    Private Sub cmdRepView_Click(sender As Object, e As EventArgs) Handles cmdRepView.Click
        Dim frm As New frmRepair
        If cmbRepNo.Text <> "0" Then
            With frm
                .Name = "frmRepair" + NextfrmNo(frm).ToString
                .Tag = "RepairAdvanced"
                .Show(Me)
                .cmbRepNo.Text = cmbRepNo.Text
                .CmbRepNo_SelectedIndexChanged(sender, e)
            End With
        End If
    End Sub

    Private Sub rbRep_Click(sender As Object, e As EventArgs) Handles rbRep.Click
        rbRERep.Checked = False
        rbRep.Checked = True
        cmbRepNo_DropDown(sender, e)
    End Sub

    Private Sub rbRERep_Click(sender As Object, e As EventArgs) Handles rbRERep.Click
        rbRERep.Checked = True
        rbRep.Checked = False
        cmbRepNo_DropDown(sender, e)
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        cmdNew.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        cmdSave.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If cmdDelete.Enabled = True Then cmdDelete.PerformClick()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        cmdClose.PerformClick()
    End Sub

    Private Sub cmdSave_TextChanged(sender As Object, e As EventArgs) Handles cmdSave.TextChanged
        SaveToolStripMenuItem.Text = cmdSave.Text
    End Sub

    Private Sub cmdDelete_EnabledChanged(sender As Object, e As EventArgs) Handles cmdDelete.EnabledChanged
        DeleteToolStripMenuItem.Enabled = cmdDelete.Enabled
    End Sub

    Private Sub PrintRepairAdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRepairAdvancedToolStripMenuItem.Click
        If CheckEmptyfield(txtAdNo, "Repair Advanced No එක හිස්ව පවතියි.") = False Then
            Exit Sub
        ElseIf CheckExistData(txtAdNo, "Select ADNo from RepairAdvanced Where ADNo=" & txtAdNo.Text,
                             "Repair Advanced No එක Database එක තුලින් සොයා ගැනීමට නොහැකි වුණි.", False) = False Then
            Exit Sub
        End If
        Dim RPT As New rptRepairAdvanced
        Dim DS1 As New DataSet
        Dim DA1 As New OleDb.OleDbDataAdapter

        If rbRep.Checked = True Then
            DA1 = New OleDbDataAdapter("SELECT CuName,CuTelNo1,CuTelNo2,CuTelNo3,ADDate,Rep.RepNo,Ret.RetNo,PCategory,PName,Amount from " &
                                       "(((((RepairAdvanced AD Left Join Repair Rep On Rep.RepNo=AD.RepNo) Left JOin Return Ret On " &
                                       "Ret.RetNo=AD.RetNo) LEft Join Product P ON P.PNo = Rep.PNo) Left Join Receive R ON R.RNo = Rep.RNo) " &
                                       "Left Join Customer Cu ON Cu.CuNo=R.CuNo) Where ADNo=" & txtAdNo.Text & ";", CNN)
        Else
            DA1 = New OleDbDataAdapter("SELECT CuName,CuTelNo1,CuTelNo2,CuTelNo3,ADDate,Rep.RepNo,Ret.RetNo,PCategory,PName,Amount from " &
                                                  "(((((RepairAdvanced AD Left Join Return Ret On Ret.RetNo=AD.RetNo) Left Join Repair Rep On " &
                                                  "Rep.RepNo=Ret.RepNo) LEft Join Product P ON P.PNo = Rep.PNo) Left Join Receive R ON R.RNo = Rep.RNo) " &
                                                  "Left Join Customer Cu ON Cu.CuNo=R.CuNo) Where ADNo=" & txtAdNo.Text & ";", CNN)
        End If
        DA1.Fill(DS1, "Repair")
        DA1.Fill(DS1, "Product")
        DA1.Fill(DS1, "Return")
        DA1.Fill(DS1, "Customer")
        DA1.Fill(DS1, "Receive")
        DA1.Fill(DS1, "RepairAdvanced")
        RPT.SetDataSource(DS1)
        RPT.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text) 'Set Cashier Name to Parameter Value
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
        RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        RPT.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)

        Dim frm As New frmReport With {.Name = "frmReport" + NextfrmNo(frmReport).ToString}
        frm.ReportViewer.ReportSource = RPT
        frm.Show(Me)
        RPT.Close()
        DS1.Clear()
    End Sub
End Class