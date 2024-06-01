﻿Imports System.Data.Odbc

Public Class frmTechnician
    Private Db As New Database

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmTechnician_Leave(sender, e)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        txtTNo.Text = Db.GetNextKey("Technician", "TNo")
        cmbTName.Text = ""
        txtTFullName.Text = ""
        txtTNICNo.Text = ""
        txtTAddress.Text = ""
        txtTEmail.Text = ""
        txtTTelNo1.Text = ""
        txtTTelNo2.Text = ""
        txtTTelNo3.Text = ""
        txtTRemarks.Text = ""
        cmdSave.Text = "Save"
        cmdDone.Text = "Done + Save"
        cmdDelete.Enabled = False
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CheckEmptyControl(txtTNo, "This data couldn't be saved to database. It's because Technician No is empty. If you want to save this, you should fill it.") = False Then
            Exit Sub
        ElseIf CheckEmptyControl(cmbTName, "This data couldn't be saved to database. It's because Technician Name is empty. If you want to save this, you should fil it.") = False Then
            Exit Sub
        End If
        Select Case cmdSave.Text
            Case "Save"
                If CheckExistData(Db, cmbTName, "Select TName from Technician where TName='" & cmbTName.Text & "';", "Saveing is not comfortable because Technician Name which you added has already located in the database. You have to change Technician No to save.", True) = True Then
                    Exit Sub
                ElseIf CheckExistData(Db, txtTNo, "Select TNo from Technician where TNo =" & txtTNo.Text & ";", "This data couldn't be saved to database because Technicino No which you added has already located in the database. You have to change that to save.", True) = True Then
                    Exit Sub
                End If
                Db.Execute("INSERT INTO Technician(TNo,TName,TFullName,TAddress,TEmail,TNicNo,TTelNo1,TTelno2,TTelno3,TRemarks,TActive,TBlockEmails) VALUES(@TNO, @TNAME, @TFULLNAME, TADDRESS, TEMAIL, TNICNO, TTELNO1, TTELNO2, TTELNO3, TREMARKS, TACTIVE, TBLOCKEMAILS)", {
                      New OdbcParameter("TNO", txtTNo.Text),
                      New OdbcParameter("TNAME", cmbTName.Text),
                      New OdbcParameter("TFULLNAME", txtTFullName.Text),
                      New OdbcParameter("TADDRESS", txtTAddress.Text),
                      New OdbcParameter("TEMAIL", txtTEmail.Text),
                      New OdbcParameter("TNICNO", txtTNICNo.Text),
                      New OdbcParameter("TTELNO1", txtTTelNo1.Text),
                      New OdbcParameter("TTELNO2", txtTTelNo2.Text),
                      New OdbcParameter("TTELNO3", txtTTelNo3.Text),
                      New OdbcParameter("TREMARKS", txtTRemarks.Text),
                      New OdbcParameter("TACTIVE", chkActive.Checked),
                      New OdbcParameter("TBLOCKEMAILS", CheckBlockEmails.Checked)
                })
                Call txtSearch_TextChanged(sender, e)
                cmdSave.Text = "Edit"
                cmdDelete.Enabled = True
            Case "Edit"
                If MsgBox("Are you sure edit?", vbYesNo + vbInformation) = vbYes Then
                    Db.Execute("Update Technician Set TName=@TNAME, TFullName=@TFULLNAME, TAddress=@TADDRESS, TEmail=@TEMAIL, TNicNo=@TNICNO, TTelNo1=@TTELNO1, TTelno2=@TTELNO2, TTelno3=@TTELNO3, TRemarks=@TREMARKS, TActive=@TACTIVE, TBlockEmails=@TBLOCKEMAILS WHERE TNo=@TNO;", {
                          New OdbcParameter("TNAME", cmbTName.Text),
                          New OdbcParameter("TFULLNAME", txtTFullName.Text),
                          New OdbcParameter("TADDRESS", txtTAddress.Text),
                          New OdbcParameter("TEMAIL", txtTEmail.Text),
                          New OdbcParameter("TNICNO", txtTNICNo.Text),
                          New OdbcParameter("TTELNO1", txtTTelNo1.Text),
                          New OdbcParameter("TTELNO2", txtTTelNo2.Text),
                          New OdbcParameter("TTELNO3", txtTTelNo3.Text),
                          New OdbcParameter("TREMARKS", txtTRemarks.Text),
                          New OdbcParameter("TACTIVE", chkActive.Checked),
                          New OdbcParameter("TBLOCKEMAILS", CheckBlockEmails.Checked),
                          New OdbcParameter("TNO", txtTNo.Text)
                    })
                    Call txtSearch_TextChanged(sender, e)
                End If
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim DT As New DataTable
        Dim x As String
        Select Case cmbFilter.Text
            Case "Technician No"
                x = "Where TNo like '%" & txtSearch.Text & "%'"
            Case "Technician Name"
                x = "Where TName like '%" & txtSearch.Text & "%'"
            Case "Technician Full Name"
                x = "Where TFullName like '%" & txtSearch.Text & "%'"
            Case "Technician NIC No"
                x = "Where TNICNo like '%" & txtSearch.Text & "%'"
            Case "Technician Address"
                x = "Where TAddress like '%" & txtSearch.Text & "%'"
            Case "Technician Email"
                x = "Where TEmail like '%" & txtSearch.Text & "%'"
            Case "Technician Telephone No 1"
                x = "Where TTelNo1 like '%" & txtSearch.Text & "%'"
            Case "Technician Telephone No 2"
                x = "Where TTelNo2 like '%" & txtSearch.Text & "%'"
            Case "Technician Telephone No 3"
                x = "Where TTelNo3 like '%" & txtSearch.Text & "%'"
            Case "Remarks"
                x = "Where TRemarks like '%" & txtSearch.Text & "%'"
            Case Else
                x = "Where TNo like '%" & txtSearch.Text & "%' or TName like '%" & txtSearch.Text & "%' or TFullName like '%" & txtSearch.Text & "%' or TAddress like '%" & txtSearch.Text & "%' or TNICNo like '%" & txtSearch.Text & "%' or TEmail like '%" & txtSearch.Text & "%' or TTelNo1 like '%" & txtSearch.Text & "%' or TTElNo2 like '%" & txtSearch.Text & "%' or TTelNo3 like '%" & txtSearch.Text & "%'"
        End Select
        Me.grdTechnician.DataSource = Db.GetDataTable("Select * from Technician " & x)
        grdTechnician.Refresh()
    End Sub

    Private Sub frmTechnician_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub frmTechnician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Db.Connect()
        MenuStrip.Items.Add(mnustrpMENU)
        Call txtSearch_TextChanged(sender, e)
        Call cmdNew_Click(sender, e)
        cmbFilter.Text = "All"
        If Me.Tag = "" Then
            cmdDone.Enabled = False
        End If
    End Sub

    Private Sub cmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call ComboBoxDropDown(Db, cmbTName, "Select TName from Technician group by TName;")
    End Sub

    Private Sub cmbTName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTName.SelectedIndexChanged
        Dim DR As OdbcDataReader = Db.GetDataReader("Select * from Technician where TName ='" & cmbTName.Text & "';")
        If DR.HasRows = True Then
            DR.Read()
            txtTNo.Text = DR("TNo").ToString
            txtTAddress.Text = DR("TAddress").ToString
            txtTFullName.Text = DR("TFullName").ToString
            txtTNICNo.Text = DR("TNicNo").ToString
            txtTEmail.Text = DR("TEmail").ToString
            txtTTelNo1.Text = DR("TTelNo1").ToString
            txtTTelNo2.Text = DR("TTelNo2").ToString
            txtTTelNo3.Text = DR("TTelNo3").ToString
            txtTRemarks.Text = DR("TRemarks").ToString
            chkActive.Checked = DR("TActive")
        End If
        cmdSave.Text = "Edit"
        cmdDone.Text = "Done"
        cmdDelete.Enabled = True
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        If cmdDone.Text = "Done + Save" Then
            Call cmdSave_Click(sender, e)
        End If
        Select Case Me.Tag
            Case "TechnicianCost"
                With frmTechnicianCost
                    .cmbTName.Text = Me.cmbTName.Text
                End With
        End Select
        Me.Close()
    End Sub

    Private Sub grdTechnician_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTechnician.CellContentDoubleClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        If index >= 0 Then
            selectedrow = grdTechnician.Rows(index)
            cmbTName.Text = selectedrow.Cells(1).Value.ToString
            Call cmbTName_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckExistRelationsforDelete("Select TNo,RepNo from Repair where TNo = " & txtTNo.Text, "RepNo",
                                        "This Technician couldn't be deleted because this technician has relations with the field/s in 'Repair' table. They are given below.") = False Then
            Exit Sub
        End If
        If CheckExistRelationsforDelete("Select TNo,RetNo from Rerepair where TNo = " & txtTNo.Text, "RetNo",
                                        "This Technician couldn't be deleted because this technician has relations with the field/s in 'Return' table. They are given below.") = False Then
            Exit Sub
        End If
        If CheckExistRelationsforDelete("Select TNo,SaRepNo from SalesRepair where TNo = " & txtTNo.Text, "SaRepNo",
                                        "This Technician couldn't be deleted because this technician has relations with the field/s in 'SalesRepair' table. They are given below.") = False Then
            Exit Sub
        End If
        If CheckEmptyControl(txtTNo, "This Technician couldn't be deleted because Technician No was empty. Please fill it and try again.") = False Then
            Exit Sub
        End If
        If MsgBox("Are you sure delete this Technician?", vbInformation + vbYesNo) = vbYes Then
            Db.Execute("DELETE from Technician where TNo=" & txtTNo.Text)
            Call txtSearch_TextChanged(sender, e)
            Call cmdNew_Click(sender, e)
        End If
    End Sub

    'Private Sub frmTechnician_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    grpSearch.Width = Me.Width - grpSearch.Left - 20
    '    grdTechnician.Width = grpSearch.Width - grdTechnician.Left - 5
    '    grpSearch.Height = Me.Height - grpSearch.Top - 40
    '    grpTInfo.Height = Me.Height - grpTInfo.Top - 40
    '    grdTechnician.Height = grpSearch.Height - grdTechnician.Top - 5
    '    cmdDone.Top = grpTInfo.Height - cmdDone.Height - 5
    '    cmdNew.Top = cmdDone.Top
    '    cmdSave.Top = cmdDone.Top
    '    cmdDelete.Top = cmdDone.Top
    '    cmdClose.Top = cmdDone.Top
    '    txtTRemarks.Height = cmdDone.Top - txtTRemarks.Top - 5
    'End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        If cmdDone.Enabled = True Then cmdDone_Click(sender, e)
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If cmdDelete.Enabled = True Then cmdDelete_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        frmTechnician_Leave(sender, e)
    End Sub
End Class