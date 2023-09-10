Public Class frmProduct

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmProduct_Leave(sender, e)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        CMD = New OleDb.OleDbCommand("SELECT top 1 PNO from PRODUCT ORDER BY PNO Desc;", CNN)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        If DR.HasRows = True Then
            DR.Read()
            txtPNo.Text = Int(DR.Item("PNo")) + 1
        Else : txtPNo.Text = "1"
        End If
        cmbPCategory.Text = ""
        cmbPName.Text = ""
        txtPModelNo.Text = ""
        txtPDetails.Text = ""
        cmdSave.Text = "Save"
        SaveToolStripMenuItem.Text = cmdSave.Text
        If Me.Tag = "" Then
            cmdDone.Enabled = False
            DoneSaveToolStripMenuItem.Enabled = False
        Else
            cmdDone.Enabled = True
            DoneSaveToolStripMenuItem.Enabled = True
        End If
        cmdDone.Text = "Done + Save"
        DoneSaveToolStripMenuItem.Text = cmdDone.Text
        cmdDelete.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        Dim x As String = ""
        grdProduct.ClearSelection()
        If txtSearch.Text <> "" Then
            Select Case cmbFilter.Text
                Case "by Product No"
                    x = "Where PNo Like '%" & txtSearch.Text & "%'"
                Case "by Product Category"
                    x = "Where PCategory like '%" & txtSearch.Text & "%'"
                Case "by Product Name"
                    x = "Where PName like '%" & txtSearch.Text & "%'"
                Case "by Product Model No"
                    x = "Where PModelNo like '%" & txtSearch.Text & "%'"
                Case "by Product Details"
                    x = "Where PDetails like '%" & txtSearch.Text & "%'"
                Case "by All"
                    x = "Where PNo like '%" & txtSearch.Text & "%' or PCategory like '%" & txtSearch.Text & "%' or PName like '%" & txtSearch.Text & "%' or PModelNo like '%" & txtSearch.Text & "%' or PDetails like '%" & txtSearch.Text & "%'"
            End Select
        Else
            x = "Order by PNo"
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT PNO as [No],PCategory as [Category],PName as [Name],PModelNo as [Model No],PDetails as [Details] from Product " & x & ";", CNN)
        da.Fill(dt)
        Me.grdProduct.DataSource = dt
        grdProduct.Refresh()
    End Sub

    Private Sub frmProduct_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Tag = ""
        Me.Close()
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        MenuStrip.Items.Add(mnustrpMENU)
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("by Product No")
        cmbFilter.Items.Add("by Product Category")
        cmbFilter.Items.Add("by Product Name")
        cmbFilter.Items.Add("by Product Model No")
        cmbFilter.Items.Add("by Product Details")
        cmbFilter.Items.Add("by All")
        cmbFilter.Text = "by All"
        txtSearch.Text = ""
        Call txtSearch_TextChanged(sender, e)
        cmdNew_Click(sender, e)
        Call cmbPCategory_DropDown(sender, e)
        Call cmbPName_DropDown(sender, e)
        Select Case Me.Tag
            Case "Receive"
                cmbPCategory.Text = frmReceive.grdRepair.Item(1, frmReceive.grdRepair.CurrentCell.RowIndex).Value
                cmbPName.Text = frmReceive.grdRepair.Item(2, frmReceive.grdRepair.CurrentCell.RowIndex).Value
                cmbPName_SelectedIndexChanged(sender, e)
            Case "Repair"
                cmbPCategory.Text = frmRepair.cmbPCategory.Text
                cmbPName.Text = frmRepair.cmbPName.Text
                Call cmbPName_SelectedIndexChanged(sender, e)
        End Select
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtPNo.Text = "" Then
            MsgBox("Please enter product no", vbOKOnly + vbExclamation)
            txtPNo.Focus()
            Exit Sub
        ElseIf cmbPCategory.Text = "" Then
            MsgBox("Please enter product category", vbOKOnly + vbExclamation)
            cmbPCategory.Focus()
            Exit Sub
        ElseIf cmbPName.Text = "" Then
            MsgBox("Please enter product name", vbOKOnly + vbExclamation)
            cmbPName.Focus()
            Exit Sub
        End If
        Select Case cmdSave.Text
            Case "Save"
                CMD = New OleDb.OleDbCommand("Select PNo from Product where PNo =" & txtPNo.Text & ";", CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    MsgBox("Product No is exist", vbOKOnly + vbExclamation)
                    txtPNo.Focus()
                    Exit Sub
                End If
                CMD = New OleDb.OleDbCommand("Select PCategory,PName from Product where PCategory = '" & cmbPCategory.Text & "' and PName ='" & cmbPName.Text & "';", CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    MsgBox("Product category and product name are exist", vbOKOnly + vbExclamation)
                    cmbPCategory.Focus()
                    Exit Sub
                End If
                CMDUPDATE("Insert into Product(PNo,PCategory,PName,PModelNo,PDetails) Values(" & txtPNo.Text & ",'" & cmbPCategory.Text & "','" & cmbPName.Text & "','" & txtPModelNo.Text & "','" & txtPDetails.Text & "');")
                Call txtSearch_TextChanged(sender, e)
                MsgBox("Save Successful", vbExclamation + vbOKOnly)
            Case "Edit"
                CMDUPDATE("Update Product set PNo=" & txtPNo.Text &
                                                 ",PCategory = '" & cmbPCategory.Text & "'" &
                                                 ",PName = '" & cmbPName.Text & "'" &
                                                 ",PModelNo =  '" & txtPModelNo.Text & "'" &
                                                 ",PDetails =  '" & txtPDetails.Text & "'" &
                                                 " where PNo=" & txtPNo.Text)
                Call txtSearch_TextChanged(sender, e)
        End Select
        For Each Row As DataGridViewRow In grdProduct.Rows
            If Row.Cells(0).Value.ToString = txtPNo.Text Then
                Row.Selected = True
                grdProduct.Select()
                Exit Sub
            End If
        Next Row
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim C As Integer = 0
        If txtPNo.Text = "" Then
            MsgBox("Product No is empty", vbExclamation + vbOKOnly)
            txtPNo.Focus()
            Exit Sub
        End If
        CMD = New OleDb.OleDbCommand("Select * from Product where Pno =" & txtPNo.Text & "", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = False Then
            MsgBox("Product isn't in the database", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        If CheckExistRelationsforDelete("Select PNo,RepNo from Repair where PNo= " & txtPNo.Text & ";", "RepNo", "This Product couldn't be deleted because this product has relations with the field/s in 'Repair' table. They are given below.") = False Then
            Exit Sub
        End If
        If CheckExistRelationsforDelete("Select PNo,RetNo from Return where PNo= " & txtPNo.Text & ";", "RetNo", "This Product couldn't be deleted because this product has relations with the field/s in 'Return' table. They are given below.") = False Then
            Exit Sub
        End If
        If MsgBox("Are you sure delete?", vbYesNo + vbInformation) = vbYes Then
            CMDUPDATE("DELETE from Product where PNo=" & txtPNo.Text)
            WriteActivity("Product no " + txtPNo.Text + " was deleted successful in 'Product' table on " + DateAndTime.Now)
            Call txtSearch_TextChanged(sender, e)
            Call cmdNew_Click(sender, e)
        End If
    End Sub

    Private Sub cmbPCategory_DropDown(sender As Object, e As EventArgs) Handles cmbPCategory.DropDown
        Call CmbDropDown(cmbPCategory, "Select PCategory from Product group by  PCategory;", "PCategory")
    End Sub

    Private Sub cmbPCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPCategory.SelectedIndexChanged
        cmbPName.Text = ""
        Call cmbPName_DropDown(sender, e)
    End Sub

    Private Sub cmbPName_DropDown(sender As Object, e As EventArgs) Handles cmbPName.DropDown
        Call CmbDropDown(cmbPName, "Select PName from Product where PCategory='" & cmbPCategory.Text & "' group by  PName;", "PName")
    End Sub

    Public Sub cmbPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("SELECT * from Product where PCategory = '" & cmbPCategory.Text & "' and PName='" & cmbPName.Text & "';", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            txtPNo.Text = DR("PNo").ToString
            cmbPCategory.Text = DR("PCategory").ToString
            cmbPName.Text = DR("PName").ToString
            txtPModelNo.Text = DR("PModelNo").ToString
            txtPDetails.Text = DR("PDETAILS").ToString
            cmdSave.Text = "Edit"
            SaveToolStripMenuItem.Text = "Edit"
            cmdDone.Text = "Done"
            DoneSaveToolStripMenuItem.Text = "Done"
            cmdDelete.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
            For Each Row As DataGridViewRow In grdProduct.Rows
                If Row.Cells(0).Value.ToString = txtPNo.Text Then
                    Row.Selected = True
                    grdProduct.Select()
                    Exit Sub
                End If
            Next Row
        End If
    End Sub

    Private Sub grdProduct_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProduct.CellContentDoubleClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        If index >= 0 Then
            selectedrow = grdProduct.Rows(index)
            cmbPCategory.Text = selectedrow.Cells(1).Value.ToString
            cmbPName.Text = selectedrow.Cells(2).Value.ToString
            Call cmbPName_SelectedIndexChanged(sender, e)
            cmdSave.Text = "Edit"   'Change edit mode
            SaveToolStripMenuItem.Text = "Edit"
            cmdDone.Text = "Done"
            DoneSaveToolStripMenuItem.Text = cmdDone.Text
            cmdDelete.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        If Me.Tag = "" Then Exit Sub
        If cmdDone.Text = "Done + Save" Then
            Call cmdSave_Click(sender, e)
        End If
        Select Case Me.Tag
            Case "Receive"
                With frmReceive
                    .grdRepair.Item(1, .grdRepair.CurrentCell.RowIndex).Value = cmbPCategory.Text
                    .grdRepair.Item(2, .grdRepair.CurrentCell.RowIndex).Value = cmbPName.Text
                    Dim E1 As New DataGridViewCellEventArgs(1, .grdRepair.CurrentCell.RowIndex)
                    Call .grdRepair_CellEndEdit(sender, E1)
                End With
            Case "Repair"
                With frmRepair
                    .cmbPCategory.Text = cmbPCategory.Text
                    .cmbPName.Text = cmbPName.Text
                    Call .CmbPName_SelectedIndexChanged(sender, e)
                End With
        End Select
        Call frmProduct_Leave(sender, e)
    End Sub

    Private Sub DoneSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneSaveToolStripMenuItem.Click
        Call cmdDone_Click(sender, e)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Call cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call cmdDelete_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Call cmdClose_Click(sender, e)
    End Sub

    Private Sub frmProduct_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grpSearch.Width = Me.Width - grpSearch.Left - 20
        grdProduct.Width = grpSearch.Width - grdProduct.Left - 5
        grpSearch.Height = Me.Height - grpSearch.Top - 40
        grdProduct.Height = grpSearch.Height - grdProduct.Top - 5
    End Sub
End Class