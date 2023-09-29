Public Class frmSupplier
    Private Db As New Database

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        CMD = New OleDb.OleDbCommand("SELECT top 1 SuNo from Supplier ORDER BY SuNo Desc;", CNN)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        If DR.HasRows = True Then
            DR.Read()
            txtSuNo.Text = Int(DR.Item("SuNo")) + 1
        End If
        cmbSuName.Text = ""
        txtSuTelNo1.Text = ""
        cmdSave.Text = "Save"
        cmdDelete.Enabled = False
        If Me.Tag <> "" Then cmdDone.Text = "Done + Save"
    End Sub

    Private Sub frmSupplier_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        MenuStrip1.Items.Add(mnustrpMENU)
        If Me.Tag = "" Then
            cmdDone.Enabled = False
            DoneSaveToolStripMenuItem.Enabled = False
        Else
            cmdDone.Enabled = True
            DoneSaveToolStripMenuItem.Enabled = True
        End If
        cmbFilter.Items.Clear()     'add values of cmdFilters
        cmbFilter.Items.Add("by Supplier No")
        cmbFilter.Items.Add("by Supplier Name")
        cmbFilter.Items.Add("by Supplier Address")
        cmbFilter.Items.Add("by Supplier Email")
        cmbFilter.Items.Add("by Supplier Telephone No1")
        cmbFilter.Items.Add("by Supplier Telephone No2")
        cmbFilter.Items.Add("by Supplier Telephone No3")
        cmbFilter.Items.Add("by Remarks")
        cmbFilter.Items.Add("by All")
        cmbFilter.Text = "by All"
        txtSearch.Text = ""
        Call txtSearch_TextChanged(sender, e)   'refresh grdstock
        Call cmdNew_Click(sender, e)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmSupplier_Leave(sender, e)
    End Sub

    Private Sub cmbSuName_DropDown(sender As Object, e As EventArgs) Handles cmbSuName.DropDown
        CmbDropDown(cmbSuName, "Select SuName from Supplier group by  SuName;", "SuName")
    End Sub

    Private Sub cmbSuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSuName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("SELECT * from Supplier where SuName='" & cmbSuName.Text & "';", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            txtSuNo.Text = DR("SuNo").ToString
            cmbSuName.Text = DR("SuName").ToString
            txtSuAddress.Text = DR("SuAddress").ToString
            txtSuEmail.Text = DR("SuEmail").ToString
            txtSuTelNo1.Text = DR("SuTelNo1").ToString
            txtSuTelNo2.Text = DR("SuTelNo2").ToString
            txtSuTelNo3.Text = DR("SuTelNo3").ToString
            txtSuRemarks.Text = DR("SuRemarks").ToString
            For Each Row As DataGridViewRow In grdSupplier.Rows
                If Row.Cells(0).Value.ToString = txtSuNo.Text Then
                    Row.Selected = True
                    grdSupplier.Select()
                    Exit Sub
                End If
            Next Row
            cmdSave.Text = "Edit"
            cmdDelete.Enabled = True
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtSuNo.Text = "" Then
            MsgBox("Please enter supplier no", vbOKOnly + vbExclamation)
            txtSuNo.Focus()
            Exit Sub
        ElseIf cmbSuName.Text = "" Then
            MsgBox("Please enter supplier name", vbOKOnly + vbExclamation)
            cmbSuName.Focus()
            Exit Sub
        End If
        Select Case cmdSave.Text
            Case "Save"
                If CheckExistData(txtSuNo, "Select SuNo from Supplier where SuNo =" & txtSuNo.Text & ";", "Supplier No is exist", True) = True Then
                    Exit Sub
                ElseIf CheckExistData(cmbSuName, "Select SuName from Supplier where SuName ='" & cmbSuName.Text & "';", "Supplier Name is exist", True) = True Then
                    Exit Sub
                End If
                CMDUPDATE("Insert into Supplier(SuNo,SuName,SuAddress, SuEmail, SuTelNo1, SuTelNo2, SuTelNo3,SuRemarks)" &
                                             "Values(" & txtSuNo.Text & ",'" & cmbSuName.Text & "','" & txtSuAddress.Text & "','" & txtSuEmail.Text & "','" & txtSuTelNo1.Text & "','" & txtSuTelNo2.Text & "','" & txtSuTelNo3.Text & "','" & txtSuRemarks.Text & "');")
                Call txtSearch_TextChanged(sender, e)
                cmdSave.Text = "Edit"
                SaveToolStripMenuItem.Text = "Edit"
                cmdDelete.Enabled = True
                DeleteToolStripMenuItem.Enabled = True
                WriteActivity("Supplier No " + txtSuNo.Text + " was saved to 'Supplier' table on " + DateTime.Now)
                MsgBox("Save Successful", vbExclamation + vbOKOnly)
            Case "Edit"
                If CheckExistData(txtSuNo, "Select SuNo from Supplier where SuNo =" & txtSuNo.Text, "Supplier No was not exist in the database please check again", False) = False Then
                    Exit Sub
                End If
                If MsgBox("Are you sure edit?", vbYesNo + vbInformation) = vbYes Then
                    CMDUPDATE("Update Supplier set SuNo=" & txtSuNo.Text &
                                                 ",SuName = '" & cmbSuName.Text & "'" &
                                                 ",SuAddress = '" & txtSuAddress.Text & "'" &
                                                 ",SuEmail = '" & txtSuEmail.Text & "'" &
                                                 ",SuTelNo1 =  '" & txtSuTelNo1.Text & "'" &
                                                 ",SuTelNo2 =  '" & txtSuTelNo2.Text & "'" &
                                                 ",SuTelNo3 =  '" & txtSuTelNo3.Text & "'" &
                                                 ",SuRemarks =  '" & txtSuRemarks.Text & "'" &
                                                 " where SuNo=" & txtSuNo.Text)
                    Call txtSearch_TextChanged(sender, e)
                End If
        End Select
        For Each Row As DataGridViewRow In grdSupplier.Rows
            If Row.Cells(0).Value.ToString = txtSuNo.Text Then
                Row.Selected = True
                grdSupplier.Select()
                Exit Sub
            End If
        Next Row
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckEmptyfield(txtSuNo, "Supplier No was empty. So, this operation couldn't be successful. Please check it and try again.") = False Then
            Exit Sub
        End If
        If CheckExistRelationsforDelete("Select SupNo,SuNo from Supply SuNo = " & txtSuNo.Text, "SupNo", "This Supplier couldn't be deleted because this supplier has relations with the field/s in 'Supply' table. They are given below.") = False Then
            Exit Sub
        End If
        If MsgBox("Are you sure delete?", vbYesNo + vbInformation) = vbYes Then
            CMDUPDATE("DELETE from Supplier where SuNo=" & txtSuNo.Text)
            WriteActivity("Supplier No " + txtSuNo.Text + " was deleted in 'Supplier' table on " + DateTime.Now)
            Call txtSearch_TextChanged(sender, e)
            Call cmdNew_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        Dim x As String = ""
        grdSupplier.ClearSelection()
        If txtSearch.Text <> "" Then
            Select Case cmbFilter.Text
                Case "by Supplier No"
                    x = "Where SuNo Like '%" & txtSearch.Text & "%'"
                Case "by Supplier Name"
                    x = "Where SuName like '%" & txtSearch.Text & "%'"
                Case "by Supplier Address"
                    x = "Where SuAddress like '%" & txtSearch.Text & "%'"
                Case "by Supplier Email"
                    x = "Where SuEmail like '%" & txtSearch.Text & "%'"
                Case "by Supplier Telephone No1"
                    x = "Where SuTelNo1 like '%" & txtSearch.Text & "%'"
                Case "by Supplier Telephone No2"
                    x = "Where SuTelNo2 like '%" & txtSearch.Text & "%'"
                Case "by Supplier Telephone No3"
                    x = "Where SuTelNo3 like '%" & txtSearch.Text & "%'"
                Case "by Remarks"
                    x = "Where SuRemarks like '%" & txtSearch.Text & "%'"
                Case "by All"
                    x = "Where SuNo like '%" & txtSearch.Text & "%' or SuName like '%" & txtSearch.Text & "%' or SuAddress like '%" & txtSearch.Text & "%' or SuEmail like '%" & txtSearch.Text & "%' or SuTelNo1 like '%" & txtSearch.Text & "%' or SuTelNo2 like '%" & txtSearch.Text & "%' or SuTelNo3 like '%" & txtSearch.Text & "%' or SuRemarks like '%" & txtSearch.Text & "%'"
            End Select
        Else
            x = "Order by SuNo"
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT SuNo as [No],SuName as [Name],SuAddress as [Address],SuEmail as [Email], SuTelNo1 as [Telephone No1],SuTelNo2 as [Telephone No2],SuTelNo3 as [Telephone No3], SuRemarks as [Remarks] from Supplier " & x & ";", CNN)
        da.Fill(dt)
        Me.grdSupplier.DataSource = dt
        grdSupplier.Refresh()
    End Sub

    Private Sub grdSupplier_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSupplier.CellContentDoubleClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        If index >= 0 Then
            selectedrow = grdSupplier.Rows(index)
            cmbSuName.Text = selectedrow.Cells(1).Value.ToString
            Call cmbSuName_SelectedIndexChanged(sender, e)
            cmdSave.Text = "Edit"   'Change edit mode
            cmdDelete.Enabled = True
            If Me.Tag <> "" Then cmdDone.Text = "Done"
        End If
    End Sub

    Private Sub frmSupplier_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grpSearch.Width = Me.Width - grpSearch.Left - 20
        grpSearch.Height = Me.Height - grpSearch.Top - 40
        grdSupplier.Width = grpSearch.Width - 10
        grdSupplier.Height = grpSearch.Height - grdSupplier.Top - 5
    End Sub

    Private Sub DoneSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneSaveToolStripMenuItem.Click
        Call cmdDone_Click(sender, e)
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        If cmdDone.Text = "Done + Save" Then
            Call cmdSave_Click(sender, e)
        End If
        If cmdDone.Tag = "0" Then
            Exit Sub
        End If
        Select Case Me.Tag
            Case "Supply"
                With frmSupply
                    .cmbSuName_DropDown(sender, e)
                    .cmbSuName.Text = cmbSuName.Text
                    frmSupply.Show()
                    Me.Close()
                End With
        End Select
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        cmdDelete_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        cmdClose_Click(sender, e)
    End Sub

End Class