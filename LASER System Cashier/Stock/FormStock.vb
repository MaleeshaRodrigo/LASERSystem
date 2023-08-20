Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO

Public Class FormStock
    Public Property Caller As String = ""
    Private ReadOnly DB As New Database
    Private ControlStockInfo As New ControlStockInfo(DB)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        MenuStrip.Items.Add(mnustrpMENU)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        AcceptButton = btnSearch
        btnSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Connect()
    End Sub

    Private Sub FormStock_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        DB.Disconnect()
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
        Call FormStock_Leave(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        FormStock_Leave(sender, e)
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

    Private Sub WorkerStock_DoWork(sender As Object, e As DoWorkEventArgs) Handles WorkerStock.DoWork
        Try
            Dim DT As New DataTable
            Dim FilterQuery As String = ""
            grdStock.ScrollBars = ScrollBars.None
            grdStock.ClearSelection()
            If txtSearch.Text <> "" Then
                Select Case cmbFilter.Text
                    Case "by Stock Code"
                        FilterQuery = "Where SNo Like '%" & txtSearch.Text & "%'"
                    Case "by Stock Category"
                        FilterQuery = "Where SCategory like '%" & txtSearch.Text & "%'"
                    Case "by Stock Name"
                        FilterQuery = "Where SName like '%" & txtSearch.Text & "%'"
                    Case "by Stock Model No"
                        FilterQuery = "Where SModelNo like '%" & txtSearch.Text & "%'"
                    Case "by Stock Location"
                        FilterQuery = "Where SLocation like '%" & txtSearch.Text & "%'"
                    Case "by Stock Cost Price"
                        FilterQuery = "Where SCostPrice like '%" & txtSearch.Text & "%'"
                    Case "by Stock Sale Price"
                        FilterQuery = "Where SSalePrice like '%" & txtSearch.Text & "%'"
                    Case "by Stock Reorder Point"
                        FilterQuery = "Where SMinStocks like '%" & txtSearch.Text & "%'"
                    Case "by Stock Details"
                        FilterQuery = "Where SDetails like '%" & txtSearch.Text & "%'"
                    Case "by All"
                        FilterQuery = "Where SNo like '%" & txtSearch.Text & "%' or SCategory like '%" & txtSearch.Text & "%' or SName like '%" & txtSearch.Text & "%' or SModelNo like '%" & txtSearch.Text & "%' or SLocation like '%" & txtSearch.Text & "%' or SCostPrice like '%" & txtSearch.Text & "%' or SSalePrice like '%" & txtSearch.Text & "%' or SMinStocks like '%" & txtSearch.Text & "%' or SDetails like '%" & txtSearch.Text & "%'"
                End Select
            Else
                FilterQuery = " Order by SNo"
            End If
            Dim DA As New OleDbDataAdapter("SELECT SNo,SCategory,SName, SModelNo, SLocation,SMinstocks,SAvailableStocks,SOutofStocks, SCostPrice,SSalePrice, SDetails " &
                                   "from Stock " & FilterQuery & ";", CNN)
            DA.Fill(DT)

            For Each Row As DataRow In DT.Rows
                If WorkerStock.CancellationPending = True Then
                    e.Cancel = True
                    Exit Sub
                End If
                grdStock.Rows.Add(
                        Row("SNo").ToString,
                        Row("SCategory").ToString,
                        Row("SName").ToString,
                        Row("SModelNo").ToString,
                        Row("SLocation").ToString,
                        Row("SCostPrice").ToString,
                        Row("SSalePrice").ToString,
                        Row("SAvailableStocks").ToString,
                        Row("SOutofStocks").ToString,
                        Row("SMinStocks").ToString,
                        Row("SDetails").ToString
                )
                If grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SAvailableStocks").Value <
                grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SMinStocks").Value Then
                    grdStock.Item(7, (grdStock.Rows.Count - 1)).Style.BackColor = Color.Red
                    grdStock.Item(7, (grdStock.Rows.Count - 1)).Style.ForeColor = Color.White
                ElseIf grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SAvailableStocks").Value =
            grdStock.Rows.Item(grdStock.Rows.Count - 1).Cells.Item("SMinStocks").Value Then
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.BackColor = Color.DarkOrange
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.ForeColor = Color.White
                Else
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.BackColor = Color.White
                    grdStock.Item(7, grdStock.Rows.Count - 1).Style.ForeColor = Color.Black
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub bgwStock_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles WorkerStock.RunWorkerCompleted
        grdStock.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub grdStock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdStock.CellEndEdit
        If e.RowIndex < 0 Or e.RowIndex = (grdStock.Rows.Count - 1) Then Exit Sub
        If grdStock.Item("SAvailableStocks", e.RowIndex).Value Is Nothing Then grdStock.Item("SAvailableStocks", e.RowIndex).Value = "0"
        If grdStock.Item("SoutofStocks", e.RowIndex).Value Is Nothing Then grdStock.Item("SOutofStocks", e.RowIndex).Value = "0"
        If grdStock.Item(0, e.RowIndex).Value Is Nothing Then
            grdStock.Item(0, e.RowIndex).Value = AutomaticPrimaryKey("Stock", "SNo")

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
        If File.Exists(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls") Then
            File.Delete(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls")
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
                img.Save(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls", System.Drawing.Imaging.ImageFormat.Jpeg)
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
        'If grdStock.CurrentRow.Index < 0 Or grdStock.CurrentRow.Index = grdStock.Rows.Count - 1 Then
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'CMD = New OleDb.OleDbCommand("Select SaNo,SNo from StockSale where SNo = " & grdStock.Item(0, grdStock.CurrentRow.Index).Value, CNN)
        'DR = CMD.ExecuteReader()
        'If DR.HasRows = True Then
        '    Dim c As Integer = 0
        '    Dim Sano As String = ""
        '    While DR.Read
        '        c = c + 1
        '        Sano += DR("SaNo").ToString + vbCrLf
        '    End While
        '    MsgBox("මෙම Stock එක Delete කිරීමට නොහැකි විය මන්ද, මෙය StockSale යන Table එකත් සමඟ " + c.ToString +
        '           " සම්බන්ධ වී ඇත." + vbCrLf + "ඒවා නම්, " + vbCrLf + vbCrLf + Sano, vbCritical + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'CMD = New OleDb.OleDbCommand("Select TCNo,SNo from TechnicianCost where SNo = " & grdStock.Item(0, grdStock.CurrentRow.Index).Value, CNN)
        'DR = CMD.ExecuteReader()
        'If DR.HasRows = True Then
        '    Dim c As Integer = 0
        '    Dim TCno As String = ""
        '    While DR.Read
        '        c = c + 1
        '        TCno += DR("TCNo").ToString + vbCrLf
        '    End While
        '    MsgBox("මෙම Stock එක Delete කිරීමට නොහැකි විය මන්ද, මෙය TechnicianCost යන Table එකත් සමඟ සම්බන්ධ වී ඇත." + vbCrLf +
        '           "ඒවා නම්, " + vbCrLf + vbCrLf + TCno, vbCritical + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If MsgBox("Are you sure delete?", vbYesNo + vbInformation) = vbYes Then
        '    CMDUPDATE("DELETE from Stock where SNo=" & grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString)
        'Else
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub grdStock_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdStock.RowValidating
        'If e.RowIndex = grdStock.Rows.Count - 1 Then Exit Sub
        'If grdStock.Item(0, e.RowIndex).Value Is Nothing Then
        '    MsgBox("Code එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If grdStock.Item(1, e.RowIndex).Value Is Nothing OrElse grdStock.Item(1, e.RowIndex).Value.ToString = "" Then
        '    MsgBox("Category එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If grdStock.Item(2, e.RowIndex).Value Is Nothing OrElse grdStock.Item(2, e.RowIndex).Value.ToString = "" Then
        '    MsgBox("Name එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If grdStock.Item(5, e.RowIndex).Value Is Nothing Then
        '    MsgBox("Cost Price එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If grdStock.Item(6, e.RowIndex).Value Is Nothing Then
        '    MsgBox("Sale Price එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If grdStock.Item(9, e.RowIndex).Value Is Nothing Then
        '    MsgBox("Reorder Point එක Empty තැබීමට නොහැකි බැවින් එයට අගයක් ඇතුලත් කරන්න.", vbExclamation + vbOKOnly)
        '    e.Cancel = True
        '    Exit Sub
        'End If
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
        If File.Exists(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls") Then
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
            img.Image = Image.FromFile(SpecialDirectories.MyDocuments & "\LASER System\Images\" + "S-" + grdStock.Item(0, grdStock.CurrentRow.Index).Value.ToString + ".ls")
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If WorkerStock.IsBusy Then
            WorkerStock.CancelAsync()
        Else
            grdStock.Rows.Clear()
            WorkerStock.RunWorkerAsync()
        End If
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        ControlStockInfo = New ControlStockInfo(DB)
        Me.Controls.Add(ControlStockInfo)
        ControlStockInfo.ClearControls()
        ControlStockInfo.Dock = DockStyle.Fill
        ControlStockInfo.BringToFront()
    End Sub
End Class