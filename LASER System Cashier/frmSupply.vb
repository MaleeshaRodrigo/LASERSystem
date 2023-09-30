Imports ZXing
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO

Public Class frmSupply
    Private Db As New Database

    Private Sub frmSupply_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        MenuStrip.Items.Add(mnustrpMENU)
        Call cmdNew_Click(sender, e)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        SetNextKey(Db, txtSupNo, "SELECT top 1 SupNo from Supply ORDER BY SupNo Desc;", "SupNo")
        cmbSuName_DropDown(sender, e)
        cmbSuName.Text = "No Name"             'clear customer fileds
        cmbSupStatus.Text = "Not Paid"
        grdSupply.Rows.Clear()
        cmdDelete.Enabled = False
        cmdSave.Text = "Save"
    End Sub

    Public Sub cmbSuName_DropDown(sender As Object, e As EventArgs) Handles cmbSuName.DropDown
        Call CmbDropDown(cmbSuName, "Select SuName from Supplier group by  SuName;", "SuName")
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call frmSupply_Leave(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CheckEmptyfield(cmbSuName, "Supplier Name යන field එක හිස්ව පවතියි. කරුණාකර අදාල Supplier තොරා ගෙන නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        ElseIf grdSupply.Rows.Count < 2 Then
            MsgBox("ඔබ තවමත් Stock එකක් හො ඇතුලත් කල නැත. කරුණාකර Stock එකක් හෝ ඇතුලත් කර නැවත උත්සහ කරන්න.", vbOKOnly + vbExclamation)
            grdSupply.Focus()
            Exit Sub
        End If
        If txtSupNo.Text = "" Then
            SetNextKey(Db, txtSupNo, "SELECT top 1 SupNo from Supply ORDER BY SupNo Desc;", "SupNo")
        End If
        CMD = New OleDb.OleDbCommand("Select SupNo from Supply where SupNo =" & txtSupNo.Text, CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            SetNextKey(Db, txtSupNo, "SELECT top 1 SupNo from Supply ORDER BY SupNo Desc;", "SupNo")
        End If
        Dim SuNo As Integer
        CMD = New OleDb.OleDbCommand("Select SuName, SuNo from Supplier where SuName='" & cmbSuName.Text & "';", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            SuNo = DR("SuNo").ToString
        Else
            MsgBox("ඔබ ඇතුලත් කල Supplier Name එක Database තුල සොයා ගැනීමට නොහැකිය. කරුණාකර නැවත පරිකෂා කරන්න." + vbCrLf + "ඔබට මෙම ගැටලුව විසදීමට නොහැකි නම්, අපගෙ Programe Developer ව අමතන්න.")
        End If
        Select Case cmdSave.Text
            Case "Save"
                For Each row As DataGridViewRow In grdSupply.Rows
                    If grdSupply.Rows.Count - 1 = row.Index Then Continue For
                    If row.Cells(0).Value = Nothing Then
                        row.Cells(0).Value = SetStockCode()
                    End If
                    If row.Cells(1).Value Is Nothing Or row.Cells(2).Value Is Nothing Then
                        MsgBox("ඔබ Stock Code: " + row.Cells(0).Value + " යන Stock එකෙහි Stock Category හෝ Stock Name යන අයිතම දෙකම හෝ ඉන් එකක් හෝ හිස්ව පවතියි. කරුණාකර එ සඳහා සුදුසු නමක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
                        Exit Sub
                    End If
                    CMD = New OleDb.OleDbCommand("Select * from Stock Where SNo =" & row.Cells(0).Value, CNN)
                    DR = CMD.ExecuteReader
                    Dim CMD1 As New OleDb.OleDbCommand
                    If DR.HasRows = False Then
                        Db.Execute("Insert into Stock(SNo,SCategory,SName,SModelNo,SLocation,SDetails,SSalePrice,SCostPrice,SAvailableStocks,SOutofStocks,SMinStocks) " &
                                  "Values(" & row.Cells(0).Value & ",'" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value &
                                  "','" & row.Cells(11).Value & "'," & row.Cells(5).Value & "," & row.Cells(8).Value & ",0,0," & row.Cells(6).Value & ");")
                    Else
                        Db.Execute("Update Stock Set SCostPrice =" & row.Cells(8).Value &
                                                           ",SSalePrice= " & row.Cells(5).Value & ", SMinSTocks = " & row.Cells(6).Value &
                                                           ",SLocation = '" & row.Cells(4).Value & "', SModelNo = '" & row.Cells(3).Value &
                                                           "',SDetails='" & row.Cells(11).Value & "' Where SNo = " & row.Cells(0).Value)
                    End If
                Next
                If cmbSupStatus.Text = "Paid" Then
                    Db.Execute("Insert into Supply(SupNo, SupDate, SuNo, SupRemarks, SupStatus, SupPaidDate,UNo) " &
                              "Values(" & txtSupNo.Text & ",#" & txtSupDate.Value & "#," & SuNo & ",'" & txtSupRemarks.Text & "','" & cmbSupStatus.Text & "',#" &
                              txtSupPaidDate.Value & "#," & MdifrmMain.Tag & ");")
                Else
                    Db.Execute("Insert into Supply(SupNo,SupDate,SuNo,SupRemarks,SupStatus,UName) " &
                              "Values(" & txtSupNo.Text & ",#" & txtSupDate.Value & "#," & SuNo & ",'" & txtSupRemarks.Text & "','" & cmbSupStatus.Text & "','" & MdifrmMain.Tag & "');")
                End If
                For Each row As DataGridViewRow In grdSupply.Rows
                    If grdSupply.Rows.Count - 1 = row.Index Then Continue For
                    Db.Execute("Insert into StockSupply(SupNo,SNo,SupType,SupUnits,SupCostPrice,SupTotal) " &
                              "Values(" & txtSupNo.Text & "," & row.Cells(0).Value.ToString() & ",'" & row.Cells(7).Value.ToString() & "'," & row.Cells(9).Value.ToString() & "," & row.Cells(8).Value.ToString() & "," & row.Cells(10).Value.ToString() & ");")
                    If row.Cells(7).Value.ToString = "Supply" Then
                        Db.Execute("Update Stock set SAvailablestocks=(SAvailableStocks + " & row.Cells(9).Value.ToString &
                                  ") where SNo=" & row.Cells(0).Value.ToString & "")
                    Else
                        Db.Execute("Update Stock set SOutofstocks=(SOutofstocks - " & row.Cells(9).Value.ToString &
                                  ") where SNo=" & row.Cells(0).Value.ToString & "")
                    End If
                Next
                With frmStockSticker
                    For Each row As DataGridViewRow In grdSupply.Rows
                        If grdSupply.Rows.Count - 1 = row.Index Then Continue For
                        Dim AvailableUnits As Integer
                        CMD = New OleDb.OleDbCommand("Select SAvailableStocks from stock where sno =" & row.Cells(0).Value, CNN)
                        DR = CMD.ExecuteReader()
                        If DR.HasRows = True Then
                            DR.Read()
                            AvailableUnits = DR("SAvailableStocks").ToString
                        End If
                        Dim writer As New BarcodeWriter
                        writer.Format = BarcodeFormat.CODE_128
                        writer.Options.PureBarcode = True
                        .grdStock.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, AvailableUnits, row.Cells(9).Value, row.Cells(5).Value, writer.Write(row.Cells(0).Value))
                        .Show()
                    Next
                End With
                frmStockSticker.btnShow_Click(sender, e)
                MsgBox("Supply Added Successful!", vbOKOnly + vbExclamation)
                cmdNew_Click(sender, e)
        End Select
    End Sub

    Private Sub cmdGetData_Click(sender As Object, e As EventArgs) Handles cmdGetData.Click
        Dim frmSearchSupply As New frmSearch With {
            .Tag = "Supply"
        }
        frmSearchSupply.Show(Me)
    End Sub

    Private Sub cmdSuView_Click(sender As Object, e As EventArgs) Handles cmdSuView.Click
        If cmdGetData.Enabled = True Then cmdGetData_Click(sender, e)
    End Sub

    Private Sub frmSupply_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdNew.Left = Me.Width - cmdNew.Width - 20
        cmdSave.Left = cmdNew.Left
        cmdGetData.Left = cmdNew.Left
        cmdDelete.Left = cmdNew.Left
        cmdClose.Left = cmdNew.Left
        grdSupply.Width = cmdNew.Left - grdSupply.Left - 5
        txtSupRemarks.Width = cmdNew.Left - txtSupRemarks.Left - 5
        grdSupply.Height = Me.Height - grdSupply.Top - 50
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        If cmdNew.Enabled = True Then cmdNew_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If cmdSave.Enabled = True Then cmdSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If cmdDelete.Enabled = True Then cmdDelete_Click(sender, e)
    End Sub

    Private Sub GetDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDataToolStripMenuItem.Click
        If cmdGetData.Enabled = True Then cmdGetData_Click(sender, e)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckEmptyfield(txtSupNo, "Supply No was empty. Please check again and try agin.") = False Then
            Exit Sub
        ElseIf CheckExistData(txtSupNo, "Select SupNo from [Supply] where SupNo =" & txtSupNo.Text, "Supply No was not exist in the database. Please check it and try again.", False) = False Then
            Exit Sub
        End If
        If MsgBox("Are you sure delete this supply record?", vbYesNo + vbExclamation) = vbYes Then
            Db.Execute("Delete from Supply where SupNo = " & txtSupNo.Text)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        frmSupply_Leave(sender, e)
    End Sub

    Private Sub grdSupply_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdSupply.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 0
                If grdSupply.Item(0, e.RowIndex).Value = "" Then Exit Sub
                CMD = New OleDb.OleDbCommand("Select * from Stock where SNo=" & grdSupply.Item(0, e.RowIndex).Value, CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    DR.Read()
                    grdSupply.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                    grdSupply.Item(2, e.RowIndex).Value = DR("SName").ToString
                    grdSupply.Item(3, e.RowIndex).Value = DR("SModelNo").ToString
                    grdSupply.Item(4, e.RowIndex).Value = DR("SLocation").ToString
                    grdSupply.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdSupply.Item(6, e.RowIndex).Value = DR("SMinStocks").ToString
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(8, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdSupply.Item(9, e.RowIndex).Value = "1"
                    grdSupply.Item(10, e.RowIndex).Value = Int(DR("SCostPrice").ToString) * 1
                    grdSupply.Item(11, e.RowIndex).Value = DR("SDetails").ToString
                    For Each row As DataGridViewRow In grdSupply.Rows
                        If row.Index = e.RowIndex Or row.Index = grdSupply.Rows.Count - 1 Then Continue For
                        If row.Cells(0).Value = grdSupply.Item(0, e.RowIndex).Value Then
                            row.Cells(9).Value += Int(grdSupply.Item(9, e.RowIndex).Value)
                            Dim E1 As New DataGridViewCellEventArgs(9, row.Index)
                            grdSupply_CellEndEdit(sender, E1)
                            grdSupply.Rows.Remove(grdSupply.CurrentRow)
                        End If
                    Next
                Else
                    grdSupply.Item(0, e.RowIndex).Value = SetStockCode()
                    grdSupply.Item(1, e.RowIndex).Value = ""
                    grdSupply.Item(2, e.RowIndex).Value = ""
                    grdSupply.Item(3, e.RowIndex).Value = ""
                    grdSupply.Item(4, e.RowIndex).Value = ""
                    grdSupply.Item(5, e.RowIndex).Value = "0"
                    grdSupply.Item(6, e.RowIndex).Value = "3"
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(8, e.RowIndex).Value = "0"
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(9, e.RowIndex).Value = "1"
                End If
            Case 1, 2
                CMD = New OleDb.OleDbCommand("Select * from Stock where SCategory='" & grdSupply.Item(1, e.RowIndex).Value & "' and SName='" & grdSupply.Item(2, e.RowIndex).Value & "';", CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    DR.Read()
                    grdSupply.Item(0, e.RowIndex).Value = DR("SNo").ToString
                    grdSupply.Item(1, e.RowIndex).Value = DR("SCategory").ToString
                    grdSupply.Item(2, e.RowIndex).Value = DR("SName").ToString
                    grdSupply.Item(3, e.RowIndex).Value = DR("SModelNo").ToString
                    grdSupply.Item(4, e.RowIndex).Value = DR("SLocation").ToString
                    grdSupply.Item(5, e.RowIndex).Value = DR("SSalePrice").ToString
                    grdSupply.Item(6, e.RowIndex).Value = DR("SMinStocks").ToString
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(8, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdSupply.Item(9, e.RowIndex).Value = "1"
                    grdSupply.Item(10, e.RowIndex).Value = Int(DR("SCostPrice").ToString) * 1
                    grdSupply.Item(11, e.RowIndex).Value = DR("SDetails").ToString
                Else
                    grdSupply.Item(0, e.RowIndex).Value = SetStockCode()
                    grdSupply.Item(6, e.RowIndex).Value = "3"
                    grdSupply.Item(7, e.RowIndex).Value = "Supply"
                    grdSupply.Item(9, e.RowIndex).Value = "1"
                End If
            Case 8, 9
                If grdSupply.Item(8, e.RowIndex).Value.ToString <> "" And grdSupply.Item(9, e.RowIndex).Value.ToString <> "" Then
                    grdSupply.Item(10, e.RowIndex).Value = Val(grdSupply.Item(8, e.RowIndex).Value) * Val(grdSupply.Item(9, e.RowIndex).Value)
                End If
        End Select
    End Sub

    Private Function SetStockCode() As Integer
        Dim max As Integer
        CMD = New OleDb.OleDbCommand("Select top 1 SNo from Stock order by sno desc;", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            max = Int(DR("SNo").ToString) + 1
        Else
            max = 1
        End If
        For Each row As DataGridViewRow In grdSupply.Rows
            If grdSupply.CurrentCell.RowIndex = row.Index Or row.Index = grdSupply.Rows.Count - 1 Then Continue For
            CMD = New OleDb.OleDbCommand("Select Sno from Stock Where SNo=" & row.Cells(0).Value, CNN)
            DR = CMD.ExecuteReader
            If DR.HasRows = False Then
                row.Cells(0).Value = max
                max += 1
            End If
        Next
        Return max
    End Function

    Private Sub SupplierInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierInfoToolStripMenuItem.Click
        cmdSuView_Click(sender, e)
    End Sub

    Private Sub StockInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockInfoToolStripMenuItem.Click
        Dim frm As New FormStock
        frm.Tag = "Supply"
        frm.ShowDialog()
        frm.txtSearch.Focus()
    End Sub

    Private Sub cmbSupStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupStatus.SelectedIndexChanged
        If cmbSupStatus.Text = "Not Paid" Then
            txtSupPaidDate.Visible = False
            lblSupPaidDate.Visible = False
        Else
            txtSupPaidDate.Visible = True
            lblSupPaidDate.Visible = True
        End If
    End Sub

    Private Sub grdSupply_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdSupply.EditingControlShowing
        Dim autoText As TextBox
        Dim DataCollection As New AutoCompleteStringCollection()
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        If TypeOf e.Control Is TextBox Then
            autoText = TryCast(e.Control, TextBox)
            autoText.AutoCompleteCustomSource = Nothing
            autoText.AutoCompleteSource = AutoCompleteSource.None
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If
        Select Case grdSupply.CurrentCell.ColumnIndex
            Case 1
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select SCategory from Stock group by SCategory;", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("SCategory").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 2
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select SCategory,SName from Stock where SCategory ='" & grdSupply.Item(1, grdSupply.CurrentCell.RowIndex).Value & "';", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("SName").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 4
                autoText = TryCast(e.Control, TextBox)
                If autoText IsNot Nothing Then
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                    DataCollection.Clear()
                    CMD = New OleDb.OleDbCommand("Select SLocation from Stock group by SLocation;", CNN)
                    DR = CMD.ExecuteReader()
                    While DR.Read
                        DataCollection.Add(DR("SLocation").ToString)
                    End While
                    autoText.AutoCompleteCustomSource = DataCollection
                End If
            Case 0, 9, 6
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 8, 5
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

End Class