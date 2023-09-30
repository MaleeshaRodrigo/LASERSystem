Public Class frmTechnicianLoan
    Private Db As New Database

    Private Sub frmTechnicianLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        MenuStrip1.Items.Add(mnustrpMENU)
        Call AutomaticPrimaryKey(txtTLNo, "SELECT top 1 TLNo from TechnicianLoan ORDER BY TLNo Desc;", "TLNo")
        txtTLFrom.Value = "" & Date.Today.Year & "-" & Date.Today.Month & "-01"
        txtTLTo.Value = Date.Today
        Call cmdTLSearch_Click(sender, e)
        cmbSCategory_DropDown(sender, e)
        cmbSName_DropDown(sender, e)
        cmbTName_DropDown(sender, e)
    End Sub

    Private Sub cmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call CmbDropDown(cmbTName, "Select TName from Technician Where TActive=True group by TName;", "TName")
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdTLSearch_Click(sender As Object, e As EventArgs) Handles cmdTLSearch.Click
        Dim dt As New DataTable
        If cmbTName.Text = "" Then
            grdTLSearch.Rows.Clear()
            Exit Sub
        End If
        Dim da As New OleDb.OleDbDataAdapter("Select TLNo as [Technician Loan No],TLDate as [Date],SCategory as [Stock Category],SName as [Stock Name],TLReason as [Reason]," &
                                             "Rate,Qty,Total from (TechnicianLoan Inner Join Technician On Technician.TNO = TechnicianLoan.TNo) " &
                                             "where TName='" & cmbTName.Text & "' and TLDate BETWEEN #" & txtTLFrom.Value.Date & " 00:00:00# AND #" &
                                             txtTLTo.Value.Date & " 23:59:59#", CNN)
        da.Fill(dt)
        Me.grdTLSearch.DataSource = dt
        grdTLSearch.Refresh()
        txtTLSubTotal.Text = "0"
        For Each Row As DataGridViewRow In grdTLSearch.Rows
            txtTLSubTotal.Text += Val(Row.Cells(7).Value.ToString)
        Next
    End Sub

    Private Sub txtTLFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtTLFrom.ValueChanged
        Call cmdTLSearch_Click(sender, e)
    End Sub

    Private Sub txtTLTo_ValueChanged(sender As Object, e As EventArgs) Handles txtTLTo.ValueChanged
        Call cmdTLSearch_Click(sender, e)
    End Sub

    Private Sub cmdTLSave_Click(sender As Object, e As EventArgs) Handles cmdTLSave.Click
        If CheckEmptyfield(txtTLAmount, "Amount Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyfield(cmbTName, "Technician ව තෝරා නොමැත. කරුණාකර අදාල Technician ව තොරා ගන්න.") = False Then
            Exit Sub
        ElseIf txtTLReason.Text = "" And txtSNo.Text = "" Then
            MsgBox("ඔබ හේතුවක් හෝ Stock එකක් ඇතුලත් කර නොමැත. කරුණාකර නැවත පරික්ෂා කරන්න.")
            Exit Sub
        End If
        Dim AdminPer As New AdminPermission
        If MdifrmMain.tslblUserType.Text <> "Admin" And txtTLDate.Value.Date <> Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "අද දිනට නොමැති Technician Loan එකක් Update කෙරුණි."
        End If
        If txtTLDate.Value.Date = Today.Date Then txtTLDate.Value = DateAndTime.Now
        Dim TNo As Integer = Int(GetStrfromRelatedfield("Select TNo,TName from Technician where TName='" &
                                                        cmbTName.Text & "'"))
        If cmdTLSave.Text = "Save" Then
            If txtSNo.Text <> "" Then
                Db.Execute("Insert Into TechnicianLoan(TLNo,TNo,TLDate,SNo,SCategory,SName,TLReason,Rate,Qty,Total,UNo) " &
                        "Values(" & txtTLNo.Text & "," & TNo & ",#" & txtTLDate.Value & "#," & txtSNo.Text & ",'" &
                        cmbSCategory.Text & "','" & cmbSName.Text & "','" & txtTLReason.Text &
                        "'," & txtSUnitPrice.Text & "," & txtSQty.Text & "," & txtTLAmount.Text & ",'" & MdifrmMain.Tag & "')", AdminPer)
            Else
                Db.Execute("Insert Into TechnicianLoan(TLNo,TNo,TLDate,TLReason,Total,UNo) " &
                        "Values(" & txtTLNo.Text & "," & TNo & ",#" & txtTLDate.Value & "#,'" & txtTLReason.Text & "'," &
                        txtTLAmount.Text & ",'" & MdifrmMain.Tag & "')", AdminPer)
            End If
            MsgBox("Save Successfull!", vbExclamation + vbOKOnly)
        ElseIf cmdTLSave.Text = "Edit" Then
            Db.Execute("Update TechnicianCost Set TNo=" & TNo &
                      ",TLDate=#" & txtTLDate.Value &
                      "#,SNo=" & txtSNo.Text &
                      ",SCategory='" & cmbSCategory.Text &
                      "',SName='" & cmbSName.Text &
                      "',TLReason='" & txtTLReason.Text &
                      "',Rate=" & txtSUnitPrice.Text &
                      ",Qty=" & txtSQty.Text &
                      ",Total=" & txtTLAmount.Text &
                      ",UNo=" & MdifrmMain.Tag, AdminPer)
        End If
        Call AutomaticPrimaryKey(txtTLNo, "SELECT top 1 TLNo from TechnicianLoan ORDER BY TLNo Desc;", "TLNo")
        cmbSCategory.Text = ""
        cmbSName.Text = ""
        txtSNo.Text = ""
        txtSQty.Text = ""
        txtSUnitPrice.Text = ""
        txtTLAmount.Text = ""
        txtTLReason.Text = ""
        Call cmdTLSearch_Click(sender, e)
    End Sub

    Private Sub cmdTLNew_Click(sender As Object, e As EventArgs) Handles cmdTLNew.Click
        'Prepare form for adding new values
        Call AutomaticPrimaryKey(txtTLNo, "SELECT top 1 TLNo from TechnicianLoan ORDER BY TLNo Desc;", "TLNo")
        txtTLDate.Value = Today
        cmbTName.Text = ""
        cmbSCategory.Text = ""
        cmbSName.Text = ""
        txtSNo.Text = ""
        txtSQty.Text = ""
        txtSUnitPrice.Text = ""
        txtTLAmount.Text = ""
        txtTLReason.Text = ""
        cmdTLSave.Text = "Save"
        cmdTLDelete.Enabled = False
        Call cmdTLSearch_Click(sender, e)
    End Sub

    Private Sub cmbSCategory_DropDown(sender As Object, e As EventArgs) Handles cmbSCategory.DropDown
        CmbDropDown(cmbSCategory, "Select SCategory from Stock group by SCategory;", "Scategory")
    End Sub

    Private Sub cmbSName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSName.SelectedIndexChanged
        If cmbSCategory.Text = "" Then
            CMD = New OleDb.OleDbCommand("Select * from Stock Where SName='" & cmbSName.Text & "'", CNN)
        Else
            CMD = New OleDb.OleDbCommand("SElect * from Stock Where Scategory='" & cmbSCategory.Text & "' and SName ='" & cmbSName.Text & "'", CNN)
        End If
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            txtSNo.Text = DR("SNo").ToString
            txtSUnitPrice.Text = Val(DR("SSAlePRice").ToString)
            txtSQty.Text = "1"
        Else
            txtSNo.Text = ""
            txtSUnitPrice.Text = "0"
            txtSQty.Text = "1"
            txtSQty_TextChanged(sender, e)
        End If
    End Sub

    Private Sub cmbSName_DropDown(sender As Object, e As EventArgs) Handles cmbSName.DropDown
        CmbDropDown(cmbSName, "Select SName from Stock Where SCategory='" & cmbSCategory.Text & "' group by SName;", "SName")
    End Sub

    Private Sub txtSUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSUnitPrice.TextChanged
        If txtSUnitPrice.Text <> "" And txtSQty.Text <> "" Then
            txtTLAmount.Text = Val(txtSQty.Text) * Val(txtSUnitPrice.Text)
        End If
    End Sub

    Private Sub txtSQty_TextChanged(sender As Object, e As EventArgs) Handles txtSQty.TextChanged
        If txtSUnitPrice.Text <> "" And txtSQty.Text <> "" Then
            txtTLAmount.Text = Val(txtSQty.Text) * Val(txtSUnitPrice.Text)
        End If
    End Sub

    Private Sub txtSUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSUnitPrice.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub txtSQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSQty.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub txtTLAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTLAmount.KeyPress
        OnlynumberPrice(e)
    End Sub

    Private Sub txtSNo_TextChanged(sender As Object, e As EventArgs) Handles txtSNo.TextChanged
        If txtSNo.Text = "" Then
            cmbSCategory.Text = ""
            cmbSName.Text = ""
            txtSUnitPrice.Text = "0"
            txtSQty.Text = "1"
            txtTLAmount.Text = "0"
            Exit Sub
        End If
        Dim CMD1 = New OleDb.OleDbCommand("Select SCategory,SName,SNo from [Stock] where SNo =" & txtSNo.Text & ";", CNN)
        Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader
        If DR1.HasRows = True Then
            DR1.Read()
            cmbSCategory.Text = DR1("SCategory").ToString
            cmbSName.Text = DR1("SName").ToString
            Call cmbSName_SelectedIndexChanged(sender, e)
        Else
            cmbSCategory.Text = ""
            cmbSName.Text = ""
            txtSUnitPrice.Text = "0"
            txtSQty.Text = "1"
            txtTLAmount.Text = "0"
        End If
    End Sub

    Private Sub txtSNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSNo.KeyPress
        OnlynumberQty(e)
    End Sub

    Private Sub txtSNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtSNo.Text = "" Then
                cmbSCategory.Text = ""
                cmbSName.Text = ""
                txtSUnitPrice.Text = "0"
                txtSQty.Text = "1"
                txtTLAmount.Text = "0"
                Exit Sub
            End If
            CMD = New OleDb.OleDbCommand("SElect SNO from stock where Sno =" & txtSNo.Text, CNN)
            DR = CMD.ExecuteReader
            If DR.HasRows = False Then
                cmbSCategory.Text = ""
                cmbSName.Text = ""
                txtSUnitPrice.Text = "0"
                txtSQty.Text = "1"
                txtTLAmount.Text = "0"
                Exit Sub
            End If
            txtSQty.Text = "1"
            txtSQty_TextChanged(sender, e)
            cmdTLSave_Click(sender, e)
            txtSNo.Focus()
        End If
    End Sub

    Private Sub cmdIView_Click(sender As Object, e As EventArgs) Handles cmdIView.Click
        FormStock.Tag = "TechnicianCost"
        FormStock.Show()
    End Sub

    Private Sub cmdTView_Click(sender As Object, e As EventArgs) Handles cmdTView.Click
        frmTechnician.Tag = "TechnicianCost"
        frmTechnician.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Call cmdTLNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call cmdTLSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If cmdTLDelete.Enabled = True Then Call cmdTLDelete_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Call frmTechnicianLoan_Leave(sender, e)
    End Sub

    Private Sub TechnicionInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicionInfoToolStripMenuItem.Click
        cmdTView_Click(sender, e)
    End Sub

    Private Sub ItemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemInfoToolStripMenuItem.Click
        Call cmdIView_Click(sender, e)
    End Sub

    Private Sub frmTechnicianLoan_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub cmdTLDelete_Click(sender As Object, e As EventArgs) Handles cmdTLDelete.Click
        If CheckEmptyfield(txtTLNo, "Technician Loan No එක හිස්ව පවතියි. ඔබට Technician Loan පොරමය Closed කර නැවත Open කල යුතුයි.") = False Then
            Me.Close()
            MdifrmMain.cmdTechnicianLoan.PerformClick()
            Exit Sub
        End If
        Dim AdminPer As New AdminPermission
        If MdifrmMain.tslblUserType.Text <> "Admin" And txtTLDate.Value.Date <> Today.Date Then
            AdminPer.AdminSend = True
            AdminPer.Remarks = "අද දිනට නොමැති Technician Loan data එකක් ඉවත් කෙරුණි."
        End If
        CMD = New OleDb.OleDbCommand("Select * from TechnicianLoan Where TLNo=" & txtTLNo.Text, CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            If DR("SNo").ToString <> "" And DR("SNo").ToString <> "0" Then
                Dim Response = MsgBox("ඔබට මෙම Item එක Technician Cost තුලින් ඉවත් කිරිමට අවශ්‍ය බැවින්, එම Item එක නැවත Available Units තුලට පිරවීමට අවශ්‍යද? " +
                                      vbCr + vbCr + "Yes - එසෙ නම් ඔබ 'Yes' යන Button එක Click කරන්න. " + vbCr + vbCr +
                                      "No - නැතහොත්, ඔබට මෙම item එක Damaged Units වලට add කිරිමට අවශ්‍ය නම්, 'No' යන Button එක Click කරන්න." +
                                      vbCr + vbCr + "Cancel - ඔබට ඉවත් වීමට අවශ්‍ය නම් 'Cancel' යන Button එක Click කරන්න.", vbYesNoCancel + vbExclamation)
                If Response = vbYes Then
                    Db.Execute("Update Stock set SAvailablestocks=(SAvailableStocks + " & txtSQty.Text &
                                                             ") where SNo=" & txtSNo.Text & "", AdminPer)
                    Db.Execute("DELETE from TechnicianCost where TCNo=" & txtTLNo.Text, AdminPer)       'decrease unit from stock table 
                ElseIf Response = vbNo Then
                    Db.Execute("Update Stock set SOutofStocks=(SOutofStocks + " & txtSQty.Text &
                                                             ") where SNo=" & txtSNo.Text & "", AdminPer)
                    Db.Execute("DELETE from TechnicianCost where TCNo=" & txtTLNo.Text, AdminPer)       'delete data from technician loan 
                Else
                    Exit Sub
                End If
            Else
                If MsgBox("Are you sure delete this Technician Cost?", vbYesNo + vbExclamation) = vbYes Then
                    Db.Execute("DELETE from TechnicianCost where TCNo=" & txtTLNo.Text, AdminPer)       'delete data from technician loan 
                End If
            End If
        Else
            MsgBox("අදාල Technician Loan දත්තය Database එක තුලට ඇතුලත් කර නොමැත.", vbCritical)
        End If
        cmdTLNew_Click(sender, e)
        cmdTLSearch_Click(sender, e)
    End Sub

    Private Sub cmbSCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCategory.SelectedIndexChanged
        cmbSName.Text = ""
    End Sub

    Private Sub grdTLSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTLSearch.CellDoubleClick
        If e.RowIndex < 0 Or e.RowIndex > (grdTLSearch.Rows.Count - 1) Then Exit Sub
        txtTLNo.Text = grdTLSearch.Item(0, e.RowIndex).Value
        txtTLDate.Value = grdTLSearch.Item(1, e.RowIndex).Value
        cmbSCategory.Text = grdTLSearch.Item(2, e.RowIndex).Value.ToString
        cmbSName.Text = grdTLSearch.Item(3, e.RowIndex).Value.ToString
        cmbSName_SelectedIndexChanged(sender, e)
        txtTLReason.Text = grdTLSearch.Item(4, e.RowIndex).Value
        txtSUnitPrice.Text = grdTLSearch.Item(5, e.RowIndex).Value
        txtSQty.Text = grdTLSearch.Item(6, e.RowIndex).Value
        txtTLAmount.Text = grdTLSearch.Item(7, e.RowIndex).Value
        cmdTLSave.Text = "Edit"
        cmdTLDelete.Enabled = True
    End Sub

    Private Sub cmbTName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTName.SelectedIndexChanged
        cmdTLSearch_Click(sender, e)
    End Sub
End Class