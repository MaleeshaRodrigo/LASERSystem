Imports System.Data.OleDb

Public Class frmCustomerLoan
    Private Db As New Database
    Private Sub cmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        Call ComboBoxDropDown(Db, cmbCuName, "Select CuName from Customer order by CuName;")
    End Sub

    Private Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        DR = Db.GetDataReader("SELECT * from Customer where CuName='" & cmbCuName.Text & "';")
        If DR.HasRows = True Then
            DR.Read()
            cmbCuName.Text = DR("CuName").ToString
            txtCuTelNo1.Text = DR("CuTelNo1").ToString
            txtCuTelNo2.Text = DR("CuTelNo2").ToString
            txtCuTelNo3.Text = DR("CuTelNo3").ToString
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, cmbFilter.TextChanged
        Call cmdSearch_Click(sender, e)
    End Sub

    Private Sub frmCustomerLoan_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub frmCustomerLoan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Db.Connect()
        MenuStrip1.Items.Add(mnustrpMENU)
        cmbCuLStatus.SelectedIndex = 1
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("Customer Loan No")
        cmbFilter.Items.Add("Customer Loan Date")
        cmbFilter.Items.Add("Customer No")
        cmbFilter.Items.Add("Customer Name")
        cmbFilter.Items.Add("Customer Telephone No 1")
        cmbFilter.Items.Add("Customer Telephone No 2")
        cmbFilter.Items.Add("Customer Telephone No 3")
        cmbFilter.Items.Add("Sale No")
        cmbFilter.Items.Add("Sale Date")
        cmbFilter.Items.Add("Deliver No")
        cmbFilter.Items.Add("Deliver Date")
        cmbFilter.Items.Add("All")
        cmbFilter.SelectedIndex = Int(cmbFilter.Items.Count) - 1
        Call cmdNew_Click(sender, e)
        Call cmdSearch_Click(sender, e)
    End Sub

    Private Sub txtDNo_TextChanged(sender As Object, e As EventArgs) Handles txtDNo.TextChanged
        Dim DR As OleDbDataReader = Db.GetDataReader("SELECT DDate from Deliver where DNo =" & txtDNo.Text & ";")
        If DR.HasRows = True Then
            DR.Read()
            txtDDate.Value = DR("DDate").ToString
        End If
    End Sub

    Private Sub txtSaNo_TextChanged(sender As Object, e As EventArgs) Handles txtSaNo.TextChanged
        If txtSaNo.Text = "" Then Exit Sub
        Dim DR As OleDbDataReader = Db.GetDataReader("SELECT SaDate from SAle where SaNo =" & txtSaNo.Text & ";")
        If DR.HasRows = True Then
            DR.Read()
            txtSaDate.Value = DR("SaDate").ToString
        End If
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        SetNextKey(Db, txtCuLNo, "SELECT top 1 CuLNo from CustomerLoan ORDER BY CuLNo Desc;", "CuLNO")
        txtCuLAmount.Text = ""
        cmbCuName.Text = ""
        txtCuTelNo1.Text = ""
        txtCuTelNo2.Text = ""
        txtCuTelNo3.Text = ""
        txtDNo.Text = ""
        txtSaNo.Text = ""
        cmdSave.Text = "Save"
        cmdDelete.Enabled = False
        tabInfo.TabPages.Item(0).Visible = False
        tabInfo.TabPages.Item(1).Visible = False
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmCustomerLoan_Leave(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CheckEmptyControl(txtCuLNo, "This Data couldn't be saved because Customer Loan No was empty. Please Check it and try again.") = False Then
            Exit Sub
        ElseIf CheckEmptyControl(txtCuLAmount, "This Data couldn't be saved because Customer Loan Amount was empty. Please check it and try again.") = False Then
            Exit Sub
        ElseIf CheckEmptyControl(cmbCuName, "Customer Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න. ") = False Then
            Exit Sub
        ElseIf CheckExistData(Db, cmbCuName, "Select CuName from Customer Where CuName='" & cmbCuName.Text & "'", "Customer ව Database එක තුල සොයා ගැනීමට නොහැකි විය. කරුණාකර නැවත පරික්ෂා කරන්න.", False) = False Then
            Exit Sub
        End If
        Dim CuNo As Integer = Int(Db.GetData("Select CuNo from Customer Where CuName='" & cmbCuName.Text & "'"))
        Select Case cmdSave.Text
            Case "Save"
                If CheckExistData(Db, txtCuLNo, "SELECT CULNO FROM CUSTOMERLOAN WHERE CULNO = " & txtCuLNo.Text & ";", "Something was wrong. This Customer Loan No is already exist in the database. Please Check it and try again. Otherwise you can contact a software developer.", True) = True Then
                    Exit Sub
                End If
                Db.Execute("Insert into CustomerLoan(CuLNo,CuLDate,CuNo,CuLAmount,Status,CuLRemarks) Values(" & txtCuLNo.Text & ",#" & txtCuLDate.Value.Date & "#," & CuNo.ToString & "," & txtCuLAmount.Text & ",'" & cmbCuLStatus.Text & "','" & txtCuLRemarks.Text & "');")
                If txtDNo.Text <> "" Then
                    Db.Execute("Update CustomerLoan set DNo = " & txtDNo.Text & " where CuLNO = " & txtCuLNo.Text)
                    If MsgBox("Will the Deliver Section be updated ? ", vbInformation + vbYesNo) = vbYes Then
                        Db.Execute("Update Deliver set CuLNO = " & txtCuLNo.Text &
                                                     ", CuLAmount = " & txtCuLAmount.Text &
                                                     " Where DNo = " & txtDNo.Text)
                    End If
                End If
                If txtSaNo.Text <> "" Then
                    Db.Execute("Update CustomerLoan set SANo = " & txtSaNo.Text & " where CuLNO = " & txtCuLNo.Text)
                    If MsgBox("Will the Sale Section be updated ? ", vbInformation + vbYesNo) = vbYes Then
                        Db.Execute("Update Sale set CuLNo = " & txtCuLNo.Text &
                                                     ", CuLAmount = " & txtCuLAmount.Text &
                                                     " Where SaNo = " & txtSaNo.Text)
                    End If
                End If
            Case "Edit"
                Db.Execute("Update CustomerLoan set CuLDate = #" & txtCuLDate.Text &
                                             "#,CuNo = " & CuNo &
                                             If(txtSaNo.Text <> "", ",SaNo = " & txtSaNo.Text, "") &
                                             If(txtDNo.Text <> "", ",DNo = " & txtDNo.Text, "") &
                                             ",CuLAmount = " & txtCuLAmount.Text &
                                             ",Status= '" & cmbCuLStatus.Text &
                                             "',CuLRemarks = '" & txtCuLRemarks.Text &
                                             "' Where CuLNO = " & txtCuLNo.Text)
                If txtDNo.Text = "" Then
                    If MsgBox("Will the Deliver Section be changed ? ", vbInformation + vbYesNo) = vbYes Then
                        Db.Execute("Update Deliver set CuLNO = " & txtCuLNo.Text &
                                                     ", CuLAmount = " & txtCuLAmount.Text &
                                                     " Where DNo = " & txtDNo.Text)
                    End If
                End If
                If txtSaNo.Text = "" Then
                    If MsgBox("Will the Sale Section be changed ? ", vbInformation + vbYesNo) = vbYes Then
                        Db.Execute("Update Sale set CuLNo = " & txtCuLNo.Text &
                                                     ", CuLAmount = " & txtCuLAmount.Text &
                                                     " Where SaNo = " & txtSaNo.Text)
                    End If
                End If
        End Select
    End Sub

    Private Sub grdCustomerLoan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCustomerLoan.CellContentDoubleClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        If index >= 0 Then
            selectedrow = grdCustomerLoan.Rows(index)
            txtCuLNo.Text = selectedrow.Cells(0).Value.ToString
            Dim Dr As OleDbDataReader = Db.GetDataReader("Select CUL.CuLNo,CuLDate,CuL.CuNo,CuName,CuTelNo1,CuTelNo2,CuTelNo3,Sa.SaNo,Sa.SaDate,D.DNo,D.DDate,CuL.CuLAmount,Status,CuLRemarks from (((CustomerLoan CUL INNER JOIN Customer CU ON CU.CUNO = CUL.CUNO) LEFT JOIN DELIVER D ON D.DNO = CUL.DNO) LEFT JOIN SALE SA ON SA.SANO = CUL.SANO) WHERE CuL.CuLNO =" & txtCuLNo.Text)
            If DR.HasRows = True Then
                DR.Read()
                txtCuLDate.Value = DR("CuLDate").ToString
                cmbCuLStatus.Text = DR("Status").ToString
                txtCuLAmount.Text = DR("CuLAmount").ToString
                cmbCuName.Text = DR("CuName").ToString
                txtCuTelNo1.Text = DR("CuTelNo1").ToString
                txtCuTelNo2.Text = DR("CuTelNo2").ToString
                txtCuTelNo3.Text = DR("CuTelNo3").ToString
                If DR("DNo").ToString <> "" Then
                    txtDNo.Text = DR("DNo").ToString
                    txtDDate.Value = DR("DDate").ToString
                End If
                If DR("SaNo").ToString <> "" Then
                    txtSaNo.Text = DR("SaNo").ToString
                    txtSaDate.Text = DR("SaDate").ToString
                End If
            End If
        End If
        cmdSave.Text = "Edit"
        cmdDelete.Enabled = True
    End Sub


    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim dt As New DataTable
        Dim x As String = ""
        If txtSearch.Text <> "" Then
            Select Case cmbFilter.Text
                Case "Customer Loan No"
                    x = "Where CuLNo Like '%" & txtSearch.Text & "%'"
                Case "Customer Loan Date"
                    x = "Where CuLDate like '%" & txtSearch.Text & "%'"
                Case "Customer No"
                    x = "Where CuNo Like '%" & txtSearch.Text & "%'"
                Case "Customer Name"
                    x = "Where CuName like '%" & txtSearch.Text & "%'"
                Case "Customer Telephone No 1"
                    x = "Where CuTelNo1 like '%" & txtSearch.Text & "%'"
                Case "Customer Telephone No 2"
                    x = "Where CuTelNo2 like '%" & txtSearch.Text & "%'"
                Case "Customer Telephone No 3"
                    x = "Where CuTelNo3 like '%" & txtSearch.Text & "%'"
                Case "Sale No"
                    x = "Where SaNo like '%" & txtSearch.Text & "%'"
                Case "Sale Date"
                    x = "Where SaDate like '%" & txtSearch.Text & "%'"
                Case "Deliver No"
                    x = "Where DNo like '%" & txtSearch.Text & "%'"
                Case "Deliver Date"
                    x = "Where DDate like '%" & txtSearch.Text & "%'"
                Case "Status"
                    x = "Where Status like '%" & txtSearch.Text & "%'"
                Case "All"
                    x = "Where CUL.CuLNo like '%" & txtSearch.Text & "%' or CuLDate like '%" & txtSearch.Text & "%' or CUL.CuNo like '%" &
                        txtSearch.Text & "%' or CuName like '%" & txtSearch.Text & "%' or CuTelNo1 like '%" & txtSearch.Text &
                        "%' or CuTelNo2 like '%" & txtSearch.Text & "%' or CuTelNo3 like '%" & txtSearch.Text & "%' or CUL.SaNo like '%" &
                        txtSearch.Text & "%' or SaDate like '%" & txtSearch.Text & "%' or CUL.DNo like '%" & txtSearch.Text &
                        "%' or DDate like '%" & txtSearch.Text & "%' or Status like '%" & txtSearch.Text & "%'"
            End Select
        Else
            x = " Order by CUL.CuLNo"
        End If
        Me.grdCustomerLoan.DataSource = Db.GetDataTable("SELECT CuL.CuLNo as [Customer Loan No],CuLDate as [Customer Loan Date],CuL.CuNo as [No],CuName as [Name],CuTelNo1 as [Telephone No 1],CuTelNo2 as [Telephone No 2],CuTelNo3 as [Telephone No 3],CuL.SaNo as [Sale No],SaDate as [Sale Date], CuL.DNo as [Deliver No], DDate as [Deliver Date], Status,CuLRemarks as [Remarks] from (((CustomerLoan CUL INNER JOIN CUSTOMER CU ON CU.CUNO = CUL.CUNO) LEFT JOIN SALE SA ON SA.SANO = CUL.SANO) LEFT JOIN DELIVER D ON D.DNO = CUL.DNO) " & x & ";")
        For Each Row As DataGridViewRow In grdCustomerLoan.Rows
            If Row.Cells("Status").Value = "Paid" Then
                Row.DefaultCellStyle.BackColor = Color.LightGreen
                Row.DefaultCellStyle.ForeColor = Color.Black
            Else
                Row.DefaultCellStyle.BackColor = Color.IndianRed
                Row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
        cmdSearch.Refresh()
    End Sub

    Private Sub frmCustomerLoan_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdCustomerLoan.Width = Int(Me.Width) - Int(grdCustomerLoan.Left) - 30
        grdCustomerLoan.Height = Int(Me.Height) - Int(grdCustomerLoan.Top) - 50
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If cmdDelete.Enabled = False Then cmdDelete_Click(sender, e)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        cmdClose_Click(sender, e)
    End Sub
End Class