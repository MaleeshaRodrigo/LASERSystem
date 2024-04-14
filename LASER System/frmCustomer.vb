Imports System.Data.OleDb

Public Class frmCustomer
    Private Db As New Database
    Public Property Caller As String = ""
    Public Sub New()
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub cmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        ComboBoxDropDown(Db, cmbCuName, "Select CuName from Customer group by  CuName;")
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Db.Connect()

        cmbFilter.Items.Clear()     'add values of cmdFilters
        cmbFilter.Items.Add("by Customer Name")
        cmbFilter.Items.Add("by Customer Telephone No 1")
        cmbFilter.Items.Add("by Customer Telephone No 2")
        cmbFilter.Items.Add("by Customer Telephone No 3")
        cmbFilter.Items.Add("by All")
        cmbFilter.Text = "by All"
        txtSearch.Text = ""
        Call txtSearch_TextChanged(Nothing, Nothing)   'refresh grdstock
        Call cmdNew_Click(Nothing, Nothing)
        Call cmbCuName_DropDown(Nothing, Nothing)

        If Me.Tag = "" Then
            cmdDone.Enabled = False
        Else
            cmdDone.Enabled = True
        End If
        Select Case Me.Tag
            Case "Repair"
                cmbCuName.Text = FormRepair.TextCuName.Text
                Call cmbCuName_SelectedIndexChanged(Nothing, Nothing)
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        Dim x As String = ""
        If txtSearch.Text <> "" Then
            Select Case cmbFilter.Text
                Case "by Customer Name"
                    x = "Where CuName like '%" & txtSearch.Text & "%'"
                Case "by Customer Telephone No 1"
                    x = "Where CuTelNo1 like '%" & txtSearch.Text & "%'"
                Case "by Customer Telephone No 2"
                    x = "Where CuTelNo2 like '%" & txtSearch.Text & "%'"
                Case "by Customer Telephone No 3"
                    x = "Where CuTelNo3 like '%" & txtSearch.Text & "%'"
                Case "by All"
                    x = "Where CuName like '%" & txtSearch.Text & "%' or CuTelNo1 like '%" & txtSearch.Text & "%' or CuTelNo2 like '%" &
                        txtSearch.Text & "%' or CuTelNo3 like '%" & txtSearch.Text & "%'"
            End Select
        Else
            x = "Order by CuNo"
        End If
        Me.grdCustomer.DataSource = Db.GetDataTable("SELECT CuNo as [No],CuName as [Name],CuTelNo1 as [Telephone No 1],CuTelNo2 as [Telephone No 2],CuTelNo3 as [Telephone No 3] from Customer " & x & ";")
        grdCustomer.Refresh()
    End Sub

    Public Sub cmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        Dim DR As OleDbDataReader = Db.GetDataReader("SELECT * from Customer where CuName='" & cmbCuName.Text & "';")
        If DR.HasRows = True Then
            DR.Read()
            txtCuNo.Text = DR("CuNo").ToString
            cmbCuName.Text = DR("CuName").ToString
            txtCuTelNo1.Text = DR("CuTelNo1").ToString
            txtCuTelNo2.Text = DR("CuTelNo2").ToString
            txtCuTelNo3.Text = DR("CuTelNo3").ToString
            For Each Row As DataGridViewRow In grdCustomer.Rows
                If Row.Cells(0).Value.ToString = txtCuNo.Text Then
                    Row.Selected = True
                    grdCustomer.Select()
                    Exit For
                End If
            Next Row
            cmdSave.Text = "Edit"
            SaveToolStripMenuItem.Text = cmdSave.Text
            cmdDone.Text = "Done"
            DoneSaveToolStripMenuItem.Text = "Done"
            cmdDelete.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub grdCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCustomer.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        If index >= 0 Then
            selectedrow = grdCustomer.Rows(index)
            cmbCuName.Text = selectedrow.Cells(1).Value.ToString
            Call cmbCuName_SelectedIndexChanged(sender, e)
        End If
        cmdSave.Text = "Edit"
        SaveToolStripMenuItem.Text = cmdSave.Text
        cmdDone.Text = "Done"
        DoneSaveToolStripMenuItem.Text = cmdDone.Text
        cmdDelete.Enabled = True
        DeleteToolStripMenuItem.Enabled = True
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click, DoneSaveToolStripMenuItem.Click
        Call cmdSave_Click(sender, e)
        If cmdDone.Tag = "0" Then
            Exit Sub
        End If
        Select Case Me.Tag
            Case "Sale"
                For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .cmbCuName.Text = Me.cmbCuName.Text
                            .txtCuTelNo1.Text = Me.txtCuTelNo1.Text
                            .txtCuTelNo2.Text = Me.txtCuTelNo2.Text
                            .txtCuTelNo3.Text = Me.txtCuTelNo3.Text
                            .txtCuTelNo1.Tag = ""
                        End With
                        Exit For
                    End If
                Next
            Case "Receive"
                For Each oForm As frmReceive In Application.OpenForms().OfType(Of frmReceive)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .txtCuTelNo1.Text = Me.txtCuTelNo1.Text
                            .txtCuTelNo2.Text = Me.txtCuTelNo2.Text
                            .txtCuTelNo3.Text = Me.txtCuTelNo3.Text
                            .cmbCuName_Text(Me.cmbCuName.Text)
                            .grdRepair.CurrentCell = .grdRepair.Item(1, .grdRepair.Rows.Count - 1)
                            .grdRepair.Focus()
                        End With
                        Exit For
                    End If
                Next
            Case "Repair"
                With FormRepair
                    .TextCuName.Text = cmbCuName.Text
                    .txtCuNo.Text = txtCuNo.Text
                    .txtCuTelNo1.Text = txtCuTelNo1.Text
                    .txtCuTelNo2.Text = txtCuTelNo2.Text
                    .txtCuTelNo3.Text = txtCuTelNo3.Text
                End With
        End Select
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, SaveToolStripMenuItem.Click
        cmdDone.Tag = ""
        If CheckEmptyControl(cmbCuName, "Customer Name එක ඇතුලත් කරන්න.") = False Then
            Exit Sub
        End If
        Select Case cmdSave.Text
            Case "Save"
                Dim DR As OleDbDataReader = Db.GetDataReader("Select CuName from Customer where CuName ='" & cmbCuName.Text & "';")
                If DR.HasRows = True Then
                    For i As Integer = 0 To 1000
                        DR = Db.GetDataReader("Select CuName from Customer Where CuName = '" & cmbCuName.Text & " " & i.ToString & "'")
                        If DR.HasRows = False Then
                            cmbCuName.Text = cmbCuName.Text + " " + i.ToString
                            Exit For
                        End If
                    Next
                End If
                If CheckExistData("Select CuNo from Customer where CuNo =" & txtCuNo.Text & ";") = True Then
                    txtCuNo.Text = Db.GetNextKey("Customer", "CuNo")
                End If
                Db.Execute("Insert into Customer(CuNo,CuName,CuTelNo1,CuTelNo2,CuTelNo3) Values(@NO, @NAME, @TELNO1, @TELNO2, @TELNO3);", {
                        New OleDbParameter("@NO", txtCuNo.Text),
                        New OleDbParameter("@NAME", cmbCuName.Text),
                        New OleDbParameter("@TELNO1", txtCuTelNo1.Text),
                        New OleDbParameter("@TELNO2", txtCuTelNo2.Text),
                        New OleDbParameter("@TELNO3", txtCuTelNo3.Text)
                })
                Call txtSearch_TextChanged(sender, e)
                cmdSave.Text = "Edit"
                SaveToolStripMenuItem.Text = cmdSave.Text
                cmdDelete.Enabled = True
                DeleteToolStripMenuItem.Enabled = True
                MsgBox("Save Successful", vbExclamation + vbOKOnly)
            Case "Edit"
                Db.Execute("Update Customer set CuName = '" & cmbCuName.Text & "',CuTelNo1 =  '" & txtCuTelNo1.Text & "',CuTelNo2 =  '" & txtCuTelNo2.Text & "',CuTelNo3 =  '" & txtCuTelNo3.Text & "' where CuNo=" & txtCuNo.Text)
                Call txtSearch_TextChanged(sender, e)
        End Select
        For Each Row As DataGridViewRow In grdCustomer.Rows
            If Row.Cells(0).Value.ToString = txtCuNo.Text Then
                Row.Selected = True
                grdCustomer.Select()
                grdCustomer.FirstDisplayedScrollingRowIndex = Row.Index
                Exit For
            End If
        Next Row
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click, NewToolStripMenuItem.Click
        Call SetNextKey(Db, txtCuNo, "SELECT top 1 CuNo from Customer ORDER BY CuNo Desc;", "CuNo")
        cmbCuName.Text = ""
        txtCuTelNo1.Text = ""
        txtCuTelNo2.Text = ""
        txtCuTelNo3.Text = ""
        cmdSave.Text = "Save"
        SaveToolStripMenuItem.Text = cmdSave.Text
        cmdDone.Text = "Done + Save"
        DoneSaveToolStripMenuItem.Text = cmdDone.Text
        cmdDelete.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click, DeleteToolStripMenuItem.Click
        Dim C As Integer = 0
        Dim tmp As String = ""
        Dim DRSale = Db.GetDataReader("Select * from Sale where CuNo= " & txtCuNo.Text & ";")
        While DRSale.Read
            C = C + 1
            tmp = tmp + "Sale: " + DRSale("SaNo").ToString + vbCrLf
        End While
        Dim DRReceive = Db.GetDataReader("Select * from Receive where CuNo= " & txtCuNo.Text & ";")
        While DRReceive.Read
            C = C + 1
            tmp = tmp + "Receive: " + DRReceive("RNo").ToString + vbCrLf
        End While
        If C > 0 Then
            MsgBox("Relationship/s " & C & " ක් සොයා ගැනුනි.ඒ නිසා මෙම Customer ව Delete කිරීමට හැකියාවක් නොමැත නමුත්, ඔබට එම Relationship/s ඉවත් කිරිමට හැකිනම්, ඒ සඳහා ඉඩ ලබා දෙන්නෙම්. ඒවා, " + vbCrLf + tmp, vbCritical + vbOKOnly)
            Exit Sub
        End If
        If MsgBox("Are you sure delete?", vbYesNo + vbInformation) = vbYes Then
            Db.Execute("DELETE from Customer where CuNo=" & txtCuNo.Text)
            Call txtSearch_TextChanged(sender, e)
            Call cmdNew_Click(sender, e)
        End If
    End Sub

    Private Sub txtCuTelNo1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuTelNo1.KeyUp
        If txtCuTelNo1.Text.Trim.Length < 10 Then Exit Sub
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Customer where CuTelNo1='" & txtCuTelNo1.Text & "' or CuTelNo2='" & txtCuTelNo1.Text & "' or CuTelNo3='" & txtCuTelNo1.Text & "';")
        If DR.HasRows = True Then
            If MsgBox("මෙම Telephone No එකට Customer කෙනෙකු ලියාපදිංචි වී ඇත. එය විවෘත කරන්නද?", vbYesNo + vbCritical) = vbYes Then
                DR.Read()
                cmbCuName.Text = DR("CuName").ToString
                Call cmbCuName_SelectedIndexChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub txtCuTelNo2_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuTelNo2.KeyUp
        If txtCuTelNo2.Text.Trim.Length < 10 Then Exit Sub
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Customer where CuTelNo1='" & txtCuTelNo2.Text & "' or CuTelNo2='" & txtCuTelNo2.Text & "' or CuTelNo3='" & txtCuTelNo2.Text & "';")
        If DR.HasRows = True Then
            If MsgBox("මෙම Telephone No එකට Customer කෙනෙකු ලියාපදිංචි වී ඇත. එය විවෘත කරන්නද?", vbYesNo + vbCritical) = vbYes Then
                DR.Read()
                cmbCuName.Text = DR("CuName").ToString
                Call cmbCuName_SelectedIndexChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub txtCuTelNo3_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuTelNo3.KeyUp
        If txtCuTelNo3.Text.Trim.Length < 10 Then Exit Sub
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Customer where CuTelNo1='" & txtCuTelNo3.Text & "' or CuTelNo2='" & txtCuTelNo3.Text & "' or CuTelNo3='" & txtCuTelNo3.Text & "';")
        If DR.HasRows = True Then
            If MsgBox("Another Customer was found assigned this Telephone No. Will it be opened?", vbYesNo + vbCritical) = vbYes Then
                DR.Read()
                cmbCuName.Text = DR("CuName").ToString
                Call cmbCuName_SelectedIndexChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub frmCustomer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized AndAlso cmdSave.Text = "Edit" Then
            tlpanelMain.ColumnStyles(2).SizeType = SizeType.Percent
            tlpanelMain.ColumnStyles(2).Width = 50
            tlpanelDetails.Visible = True
            If grdRepair.Rows.Count < 1 And grdSale.Rows.Count < 1 And grdCuLoan.Rows.Count < 1 Then TxtCuNo_TextChanged(sender, e)
        Else
            tlpanelDetails.Visible = False
            tlpanelMain.ColumnStyles(2).SizeType = SizeType.Absolute
            tlpanelMain.ColumnStyles(2).Width = 0
        End If
    End Sub

    Private Sub TxtCuNo_TextChanged(sender As Object, e As EventArgs) Handles txtCuNo.TextChanged
        If Me.WindowState = FormWindowState.Maximized AndAlso CheckExistData("Select CuNo from Customer Where CuNo=" & txtCuNo.Text) = True Then
            Dim task1 As Task = Task.Run(Sub()
                                             grdRepair.DataSource = Db.GetDataTable("SELECT RepNo as [Repair No],RDate as [Received Date],PCategory as [Product Category],PName as [Product Name], PModelNo as [Product Model No], PSerialNo as [Product Serial No],Problem,Location,Qty,Status,TName as [Technician Name],RepDate as [Repaired Date],Charge, DDate as [Delivered Date], PaidPrice as [Paid Charge]from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) WHERE R.CuNo=" & txtCuNo.Text)
                                             grdRepair.ScrollBars = ScrollBars.None
                                         End Sub)
            task1.GetAwaiter.OnCompleted(Sub()
                                             grdRepair.ScrollBars = ScrollBars.Both
                                         End Sub)
            Dim task2 As Task = Task.Run(Sub()
                                             grdSale.DataSource = Db.GetDataTable("SELECT Sa.SaNo as [Sale No],SaDate as [Sold Date],SCategory as [Stock Category],SName as [Stock Name],SaRate as [Rate], SaUnits as [Qty],SaTotal as [Total]  from (StockSale SSa INNER JOIN Sale Sa ON Sa.SaNo = SSa.SaNo) INNER JOIN Customer Cu ON Cu.CuNo = Sa.CuNo where Cu.CuNo=" & txtCuNo.Text)
                                             grdSale.ScrollBars = ScrollBars.None
                                         End Sub)
            task2.GetAwaiter.OnCompleted(Sub()
                                             grdSale.ScrollBars = ScrollBars.Both
                                         End Sub)
            Dim task3 As Task = Task.Run(Sub()
                                             grdCuLoan.DataSource = Db.GetDataTable("SELECT CuL.CuLNo as [Customer Loan No],CuLDate as [Customer Loan Date],CuL.CuNo as [No],CuName as [Name],CuTelNo1 as [Telephone No 1],CuTelNo2 as [Telephone No 2],CuTelNo3 as [Telephone No 3],CuL.SaNo as [Sale No],SaDate as [Sale Date], CuL.DNo as [Deliver No], DDate as [Deliver Date], Status,CuLRemarks as [Remarks] from (((CustomerLoan CUL INNER JOIN CUSTOMER CU ON CU.CUNO = CUL.CUNO) LEFT JOIN SALE SA ON SA.SANO = CUL.SANO) LEFT JOIN DELIVER D ON D.DNO = CUL.DNO) WHERE CuL.CuNo=" & txtCuNo.Text)
                                             grdCuLoan.ScrollBars = ScrollBars.None
                                         End Sub)
            task3.GetAwaiter.OnCompleted(Sub()
                                             grdCuLoan.ScrollBars = ScrollBars.Both
                                         End Sub)
            If tlpanelDetails.Visible = False Then frmCustomer_Resize(sender, e)
        End If
    End Sub

    Private Sub frmCustomer_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub
End Class