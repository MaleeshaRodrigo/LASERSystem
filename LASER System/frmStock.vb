Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Public Class frmStock
    Public Property Caller As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        MenuStrip.Items.Add(mnustrpMENU)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        cmbFilter.Items.Clear()     'add values of cmdFilters
        cmbFilter.Items.Add("by Stock Code")
        cmbFilter.Items.Add("by Stock Category")
        cmbFilter.Items.Add("by Stock Name")
        cmbFilter.Items.Add("by Stock Model No")
        cmbFilter.Items.Add("by Stock Location")
        cmbFilter.Items.Add("by Stock Cost Price")
        cmbFilter.Items.Add("by Stock Sale Price")
        cmbFilter.Items.Add("by Stock Reorder Point")
        cmbFilter.Items.Add("by Stock Details")
        cmbFilter.Items.Add("by All")
        cmbFilter.Text = "by All"
        txtSearch.Text = ""
        AcceptButton = btnSearch
        btnSearch_Click(Nothing, Nothing)
        If MdifrmMain.tslblUserType.Text = "Admin" Then
            grdStock.Columns.Item("AdminCostPrice").Visible = True
        End If
    End Sub

    Private Sub frmStock_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Tag = ""
        Me.Close()
    End Sub

    Private Sub grdStock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStock.CellDoubleClick
        If Me.Tag = "" Then Exit Sub
        Select Case Me.Tag
            Case "Sale"
                For Each oForm As frmSale In Application.OpenForms().OfType(Of frmSale)()
                    If oForm.Name = Me.Caller Then
                        With oForm
                            .grdSale.Rows.Add(grdStock.Item(0, grdStock.CurrentRow.Index).Value, grdStock.Item(1, grdStock.CurrentRow.Index).Value,
                                             grdStock.Item(2, grdStock.CurrentRow.Index).Value, "Sale", grdStock.Item(6, grdStock.CurrentRow.Index).Value,
                                             "1", Val(grdStock.Item(6, grdStock.CurrentRow.Index).Value) * 1)
                        End With
                        Exit For
                    End If
                Next
            Case "Supply"
                With frmSupply
                    .grdSupply.Rows.Add(grdStock.Item(0, grdStock.CurrentRow.Index).Value, grdStock.Item(1, grdStock.CurrentRow.Index).Value,
                                        grdStock.Item(2, grdStock.CurrentRow.Index).Value, grdStock.Item(3, grdStock.CurrentRow.Index).Value,
                                        grdStock.Item(4, grdStock.CurrentRow.Index).Value, grdStock.Item(6, grdStock.CurrentRow.Index).Value,
                                        grdStock.Item(9, grdStock.CurrentRow.Index).Value, "Supply", grdStock.Item(5, grdStock.CurrentRow.Index).Value,
                                        "1", Int(grdStock.Item(5, grdStock.CurrentRow.Index).Value) * 1, grdStock.Item(10, grdStock.CurrentRow.Index).Value)
                End With
            Case "TechnicianCost"
                With frmTechnicianCost
                    .grdTechnicianCost.Item("SNo", .grdTechnicianCost.Rows.Count - 1).Value = grdStock.Item(0, grdStock.CurrentRow.Index).Value
                    Dim E1 As New DataGridViewCellEventArgs("SNo", .grdTechnicianCost.Rows.Count - 1)
                    .grdTechnicianCost_CellEndEdit(sender, E1)
                End With
        End Select
        Call frmStock_Leave(sender, e)
    End Sub

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        frmStock_Leave(sender, e)
    End Sub

    Private Sub ViewStockTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStockTransactionDetailsToolStripMenuItem.Click
        If grdStock.CurrentCell.ColumnIndex > 0 And grdStock.CurrentCell.RowIndex > 0 Then
            Dim txtsno As New TextBox
            txtsno.Text = grdStock.Item(0, grdStock.CurrentRow.Index).Value
            If CheckExistData(txtsno, "Select SNo from Stock where SNo = " & txtsno.Text, "ඔබ Stock එකක් තෝරා ගෙන නොමැත. කරුණාකර Stock එකක් තෝරා ගන්න.", False) = False Then
                frmStockTransaction.Show()
                Exit Sub
            End If
            With frmStockTransaction
                .txtSNo.Text = txtsno.Text
                .txtSNo_TextChanged(sender, e)
                .cmdDone_Click(sender, e)
                .Show()
            End With
        Else
            frmStockTransaction.Show()
        End If
    End Sub

    Private Sub BgwStock_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwStock.DoWork
        Try
            Dim dt As New DataTable
            Dim x As String = ""
            grdStock.ScrollBars = ScrollBars.None
            grdStock.ClearSelection()
            If txtSearch.Text <> "" Then
                Select Case cmbFilter.Text
                    Case "by Stock Code"
                        x = "Where SNo Like '%" & txtSearch.Text & "%'"
                    Case "by Stock Category"
                        x = "Where SCategory like '%" & txtSearch.Text & "%'"
                    Case "by Stock Name"
                        x = "Where SName like '%" & txtSearch.Text & "%'"
                    Case "by Stock Model No"
                        x = "Where SModelNo like '%" & txtSearch.Text & "%'"
                    Case "by Stock Location"
                        x = "Where SLocation like '%" & txtSearch.Text & "%'"
                    Case "by Stock Cost Price"
                        x = "Where SCostPrice like '%" & txtSearch.Text & "%'"
                    Case "by Stock Sale Price"
                        x = "Where SSalePrice like '%" & txtSearch.Text & "%'"
                    Case "by Stock Reorder Point"
                        x = "Where SMinStocks like '%" & txtSearch.Text & "%'"
                    Case "by Stock Details"
                        x = "Where SDetails like '%" & txtSearch.Text & "%'"
                    Case "by All"
                        x = "Where SNo like '%" & txtSearch.Text & "%' or SCategory like '%" & txtSearch.Text & "%' or SName like '%" & txtSearch.Text & "%' or SModelNo like '%" & txtSearch.Text & "%' or SLocation like '%" & txtSearch.Text & "%' or SCostPrice like '%" & txtSearch.Text & "%' or SSalePrice like '%" & txtSearch.Text & "%' or SMinStocks like '%" & txtSearch.Text & "%' or SDetails like '%" & txtSearch.Text & "%'"
                End Select
            Else
                x = " Order by SNo"
            End If
            Dim da As New OleDbDataAdapter("SELECT SNo,SCategory,SName, SModelNo, SLocation,SMinstocks,SAvailableStocks,SOutofStocks, SCostPrice,SSalePrice, SDetails " &
                                   "from Stock " & x & ";", CNN)
            da.Fill(dt)
            dt.Columns.Add(New DataColumn("SImage", GetType(Byte())))

            For Each row As DataRow In dt.Rows
                If bgwStock.CancellationPending = True Then
                    e.Cancel = True
                    Exit Sub
                End If
                Try
                    If File.Exists(Application.StartupPath & "\System Files\Images\" + "S-" + row("SNo").ToString + ".ls") = True Then
                        Dim imgStream As MemoryStream = New MemoryStream()
                        Dim img As Image = Image.FromFile(Application.StartupPath & "\System Files\Images\" + "S-" + row("SNo").ToString + ".ls")
                        img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                        imgStream.Close()
                        Dim byteArray As Byte() = imgStream.ToArray()
                    Else
                        row("SImage") = Nothing
                    End If
                Catch ex As Exception
                    MsgBox(row(0).ToString + " හි Stock Image එකේ දෝෂයක් පවතියි." + vbCrLf +
                       "Error: " + ex.Message, vbCritical, "Error of Stock Image Section")
                End Try
                grdStock.Rows.Add(row("SNo").ToString, row("SCategory").ToString, row("SName").ToString, row("SModelNo").ToString, row("SLocation").ToString,
                          row("SCostPrice").ToString, row("SSalePrice").ToString, row("SAvailableStocks").ToString, row("SOutofStocks").ToString,
                          row("SMinStocks").ToString, row("SDetails").ToString, row("SImage"))
                If grdStock.Item("SImage", grdStock.Rows.Count - 2).Value IsNot Nothing Then grdStock.Rows.Item(grdStock.Rows.Count - 2).Height = 50
                If grdStock.Rows.Item(grdStock.Rows.Count - 2).Cells.Item("SAvailableStocks").Value <
                grdStock.Rows.Item(grdStock.Rows.Count - 2).Cells.Item("SMinStocks").Value Then
                    grdStock.Item(7, (grdStock.Rows.Count - 2)).Style.BackColor = Color.Red
                    grdStock.Item(7, (grdStock.Rows.Count - 2)).Style.ForeColor = Color.White
                ElseIf grdStock.Rows.Item(grdStock.Rows.Count - 2).Cells.Item("SAvailableStocks").Value =
            grdStock.Rows.Item(grdStock.Rows.Count - 2).Cells.Item("SMinStocks").Value Then
                    grdStock.Item(7, grdStock.Rows.Count - 2).Style.BackColor = Color.DarkOrange
                    grdStock.Item(7, grdStock.Rows.Count - 2).Style.ForeColor = Color.White
                Else
                    grdStock.Item(7, grdStock.Rows.Count - 2).Style.BackColor = Color.White
                    grdStock.Item(7, grdStock.Rows.Count - 2).Style.ForeColor = Color.Black
                End If
            Next
            grdStock.Item("SImage", grdStock.Rows.Count - 1).Value = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub bgwStock_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwStock.RunWorkerCompleted
        grdStock.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub grdStock_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdStock.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
            RemoveHandler CType(e.Control, TextBox).KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
        End If
        Select Case grdStock.CurrentCell.ColumnIndex
            Case 1
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdStock, Me, "Select SCategory from Stock group by SCategory;", "SCategory")
            Case 2
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdStock, Me, "Select SCategory,SName from Stock where SCategory ='" &
                                           grdStock.Item(1, grdStock.CurrentCell.RowIndex).Value & "';", "SName")
            Case 4
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdStock, Me, "Select SLocation from Stock Group by SLocation;", "SLocation")
            Case 0, 7, 8, 9
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
            Case 5, 6
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxPrice_keyPress
        End Select
    End Sub

    Private Sub grdStock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdStock.CellEndEdit
        If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 4 Then
            frmSearchDropDown.frm_Close()
        End If
        If e.RowIndex < 0 Or e.RowIndex = (grdStock.Rows.Count - 1) Then Exit Sub
        If grdStock.Item("SAvailableStocks", e.RowIndex).Value Is Nothing Then grdStock.Item("SAvailableStocks", e.RowIndex).Value = "0"
        If grdStock.Item("SoutofStocks", e.RowIndex).Value Is Nothing Then grdStock.Item("SOutofStocks", e.RowIndex).Value = "0"
        If grdStock.Item(0, e.RowIndex).Value Is Nothing Then
            grdStock.Item(0, e.RowIndex).Value = AutomaticPrimaryKey("Stock", "SNo")
            CMDUPDATE("Insert into Stock(SNo, SAvailableStocks, SOutofstocks) Values(" & grdStock.Item(0, e.RowIndex).Value.ToString & ",0,0);")
        End If
        If grdStock.Item(e.ColumnIndex, e.RowIndex).Value <> grdStock.Item(e.ColumnIndex, e.RowIndex).Tag Then
            Select Case e.ColumnIndex
                Case 0, 5, 6, 7, 8, 9
                    CMDUPDATE("Update Stock Set " & grdStock.Columns(e.ColumnIndex).DataPropertyName & "= " & grdStock.Item(e.ColumnIndex, e.RowIndex).Value &
                              " Where SNO=" & grdStock.Item(0, e.RowIndex).Value.ToString)
                Case 1, 2, 3, 4, 10
                    CMDUPDATE("Update Stock Set " & grdStock.Columns(e.ColumnIndex).DataPropertyName & "='" & grdStock.Item(e.ColumnIndex, e.RowIndex).Value &
                              "' Where SNO=" & grdStock.Item(0, e.RowIndex).Value)
            End Select
        End If
    End Sub

    Private Sub TextBoxPrice_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberPrice(e)
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        grdStock.Item("SImage", grdStock.CurrentRow.Index).Value = Nothing
        If File.Exists(Application.StartupPath & "\System Files\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls") Then
            File.Delete(Application.StartupPath & "\System Files\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls")
        End If
        grdStock.CurrentRow.Height = 20
        GC.Collect()
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        'Try
        With OpenFileDialog
            .CheckFileExists = True
            .CheckPathExists = True
            .DefaultExt = "jpg"
            .DereferenceLinks = True
            .FileName = ""
            .Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG|All Files|*.*"
            .Multiselect = False
            .RestoreDirectory = True
            .Title = "Select an image to open"
            .ValidateNames = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim imgStream As MemoryStream = New MemoryStream()
                Dim img As Image = Image.FromFile(.FileName)
                img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                imgStream.Close()
                Dim byteArray As Byte() = imgStream.ToArray()
                grdStock.Item(11, grdStock.CurrentRow.Index).Value = byteArray
                grdStock.CurrentRow.Height = 50
                img.Save(Application.StartupPath & "\System Files\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls", System.Drawing.Imaging.ImageFormat.Jpeg)
                'Catch fileException As Exception
                '    Throw fileException
                'End Try
            End If

        End With
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        'End Try
    End Sub

    Private Sub grdStock_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdStock.UserDeletingRow
        If grdStock.CurrentRow.Index < 0 Or grdStock.CurrentRow.Index = grdStock.Rows.Count - 1 Then
            e.Cancel = True
            Exit Sub
        End If
        CMD = New OleDb.OleDbCommand("Select SaNo,SNo from StockSale where SNo = " & grdStock.Item(0, grdStock.CurrentRow.Index).Value, CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            Dim c As Integer = 0
            Dim Sano As String = ""
            While DR.Read
                c = c + 1
                Sano += DR("SaNo").ToString + vbCrLf
            End While
            MsgBox("මෙම Stock එක Delete කිරීමට නොහැකි විය මන්ද, මෙය StockSale යන Table එකත් සමඟ " + c.ToString +
                   " සම්බන්ධ වී ඇත." + vbCrLf + "ඒවා නම්, " + vbCrLf + vbCrLf + Sano, vbCritical + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        CMD = New OleDb.OleDbCommand("Select TCNo,SNo from TechnicianCost where SNo = " & grdStock.Item(0, grdStock.CurrentRow.Index).Value, CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            Dim c As Integer = 0
            Dim TCno As String = ""
            While DR.Read
                c = c + 1
                TCno += DR("TCNo").ToString + vbCrLf
            End While
            MsgBox("මෙම Stock එක Delete කිරීමට නොහැකි විය මන්ද, මෙය TechnicianCost යන Table එකත් සමඟ සම්බන්ධ වී ඇත." + vbCrLf +
                   "ඒවා නම්, " + vbCrLf + vbCrLf + TCno, vbCritical + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If MsgBox("Are you sure delete?", vbYesNo + vbInformation) = vbYes Then
            CMDUPDATE("DELETE from Stock where SNo=" & grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub grdStock_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdStock.RowValidating
        If e.RowIndex = grdStock.Rows.Count - 1 Then Exit Sub
        If grdStock.Item(0, e.RowIndex).Value Is Nothing Then
            MsgBox("Code එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If grdStock.Item(1, e.RowIndex).Value Is Nothing OrElse grdStock.Item(1, e.RowIndex).Value.ToString = "" Then
            MsgBox("Category එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If grdStock.Item(2, e.RowIndex).Value Is Nothing OrElse grdStock.Item(2, e.RowIndex).Value.ToString = "" Then
            MsgBox("Name එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If grdStock.Item(5, e.RowIndex).Value Is Nothing Then
            MsgBox("Cost Price එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If grdStock.Item(6, e.RowIndex).Value Is Nothing Then
            MsgBox("Sale Price එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
        If grdStock.Item(9, e.RowIndex).Value Is Nothing Then
            MsgBox("Reorder Point එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub grdStock_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdStock.CellMouseUp
        If e.RowIndex > -1 And e.RowIndex < grdStock.Rows.Count And e.ColumnIndex = 11 And e.Button = Windows.Forms.MouseButtons.Right Then
            grdStock.CurrentCell = grdStock.Rows(e.RowIndex).Cells(e.ColumnIndex)
            grdStockmnustrip.Close()
            grdStockmnustrip.Show(grdStock, e.Location)
            grdStockmnustrip.Show(Cursor.Position)
        End If
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        If File.Exists(Application.StartupPath & "\System Files\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls") Then
            Dim frmImage As New Form
            frmImage.Name = "frmImage"
            frmImage.Text = "LASER System - Image Viewer [S-" & grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString & "]"
            frmImage.WindowState = FormWindowState.Maximized
            frmImage.MaximizeBox = False
            frmImage.MinimizeBox = False
            frmImage.BackColor = Color.Black
            frmImage.BringToFront()
            Dim img As New PictureBox
            img.Name = "img"
            img.Top = 0
            img.Left = 0
            img.Dock = DockStyle.Fill
            img.SizeMode = PictureBoxSizeMode.Zoom
            img.Image = Image.FromFile(Application.StartupPath & "\System Files\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls")
            If frmImage.Visible = False Then
                frmImage.Show(Me)
                frmImage.Controls.Add(img)
            Else
                For Each controlObject As Control In frmImage.Controls
                    If controlObject.Name = "img" Then
                        controlObject = img
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub frmStock_Move(sender As Object, e As EventArgs) Handles Me.Move
        frmSearchDropDown.frm_Move()
    End Sub
    Private Sub grdStock_Scroll(sender As Object, e As ScrollEventArgs) Handles grdStock.Scroll
        frmSearchDropDown.frm_Move()
    End Sub

    Private Sub frmStock_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        frmSearchDropDown.frm_Move()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If bgwStock.IsBusy Then bgwStock.CancelAsync()
        If bgwStock.IsBusy = False Then
            grdStock.Rows.Clear()
            bgwStock.RunWorkerAsync()
        End If
    End Sub

End Class