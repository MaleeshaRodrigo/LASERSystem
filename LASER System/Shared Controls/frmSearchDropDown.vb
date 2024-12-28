Imports MySqlConnector

Public Class frmSearchDropDown
    Private Db As Database
    Private grd As New DataGridView
    Private frmParent As New Form
    Private txt As New TextBox
    Private SQL, ColumnName As String
    Public Sub frm_Open(Db As Database, grdParent As DataGridView, frmParentForm As Form, ParentSQL As String, ParentColumnName As String)
        Me.Db = Db
        grd = grdParent
        frmParent = frmParentForm
        SQL = ParentSQL
        ColumnName = ParentColumnName
        If Visible = False Then
            Show(ParentForm)
        Else
            frm_Load(Nothing, Nothing)
            Visible = True
        End If
        frm_Move()
        Activate()
        txtType.Text = txt.Text
        txtType.DeselectAll()
        txtType.Focus()
    End Sub
    Public Sub frm_Move()
        If Visible = True Then
            Left = grd.PointToScreen(grd.GetCellDisplayRectangle(grd.CurrentCell.ColumnIndex, grd.CurrentCell.RowIndex, False).Location).X
            Top = grd.PointToScreen(grd.GetCellDisplayRectangle(grd.CurrentCell.ColumnIndex, grd.CurrentCell.RowIndex, False).Location).Y +
                grd.CurrentRow.Height

            If (Left + Width) > My.Computer.Screen.Bounds.Size.Width Then
                Left = My.Computer.Screen.Bounds.Size.Width - Width
            End If
            If (Top + Height) > My.Computer.Screen.Bounds.Size.Height Then
                Top = grd.PointToScreen(grd.GetCellDisplayRectangle(grd.CurrentCell.ColumnIndex, grd.CurrentCell.RowIndex, False).Location).Y -
                    Height
            End If
        End If
    End Sub

    Public Sub frm_Close()
        Close()
    End Sub

    Public Sub passtext(txtValue As TextBox)
        txt = txtValue
        txtType.Text = txtValue.Text
    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Font = grd.Font
        lst.Items.Clear()
        Dim DR = Db.GetDataList(SQL)
        For Each Item In DR
            If Item(ColumnName).ToString <> "" AndAlso Item(ColumnName).ToLower().Contains(txt.Text.ToLower) = True Then
                lst.Items.Add(Item(ColumnName).ToString)
            End If
        Next
        If lst.Items.Count > 10 Then
            Height = lst.ItemHeight * 11
        ElseIf lst.Items.Count <= 10 Then
            Height = lst.ItemHeight * (lst.Items.Count + 1)
        ElseIf lst.Items.Count = 0 Then
            Visible = False
        End If
        Width = grd.Columns.Item(grd.CurrentCell.ColumnIndex).Width
        Height = lst.Height
        lst.Cursor = Cursors.Hand
        BringToFront()
        txtType.Focus()
        txtType.DeselectAll()
    End Sub

    Public Sub dgv_KeyUp(sender As Object, e As KeyEventArgs)
        txtType.Text = txt.Text
        txtType.Focus()
        txtType.Select(txtType.Text.Length, 0)
    End Sub

    Private Sub lst_MouseClick(sender As Object, e As MouseEventArgs) Handles lst.MouseClick
        grd.CurrentCell.Selected = True
        grd.Focus()
        txtType.Text = lst.SelectedItem.ToString
        grd.EndEdit()
    End Sub

    Private Sub frm_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        If Visible = True Then
            lst.Items.Clear()
            Dim DR = Db.GetDataList(SQL)
            For Each Item In DR
                If Item(ColumnName).ToString = "" Then Continue For
                'For Each str As String In Item(ColumnName).ToString.Split(" ")
                '    For Each strtxt As String In txt.Text.ToString.Split(" ")
                If Item(ColumnName).ToLower().Contains(txtType.Text.ToLower) = True Then
                    lst.Items.Add(Item(ColumnName).ToString)
                    Continue For
                End If
                '    Next
                'Next
            Next
            If lst.Items.Count > 10 Then
                Height = lst.ItemHeight * 11
            ElseIf lst.Items.Count <= 10 Then
                Height = lst.ItemHeight * (lst.Items.Count + 1)
            ElseIf lst.Items.Count = 0 Then
                Visible = False
            End If
            Width = grd.Columns.Item(grd.CurrentCell.ColumnIndex).Width
            Height = lst.Height
            Activate()
            txt.Text = txtType.Text
            frm_Move()
        End If
    End Sub

    Private Sub lst_MouseMove(sender As Object, e As MouseEventArgs) Handles lst.MouseMove
        Dim point As Point = lst.PointToClient(Cursor.Position)
        Dim index As Integer = lst.IndexFromPoint(point)
        If index < 0 Then Exit Sub
        lst.GetItemRectangle(index).Inflate(1, 2)
        lst.SelectedIndex = index
    End Sub

    Private Sub frmSearchDropDown_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        txtType.Top = Height
        txtType.Left = 0
        txtType.Width = 0
    End Sub

    Private Sub lst_GotFocus(sender As Object, e As EventArgs) Handles lst.GotFocus
        txtType.Focus()
        txtType.DeselectAll()
    End Sub

    Private Sub txtType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtType.KeyDown
        If Visible = False Then Exit Sub
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            If lst.SelectedIndex > -1 Then
                lst.SelectedIndex = lst.SelectedIndex - 1
            Else
                lst.SelectedIndex = (lst.Items.Count - 1)
            End If
            e.Handled = True
        ElseIf (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            If lst.SelectedIndex < (lst.Items.Count - 1) Then
                lst.SelectedIndex = lst.SelectedIndex + 1
            Else
                lst.SelectedIndex = -1
            End If
            e.Handled = True
        ElseIf (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            e.SuppressKeyPress = True
            If lst.SelectedIndex > -1 Then
                lst_MouseClick(sender, Nothing)
            Else
                grd.CurrentCell.Value = txt.Text
                grd.EndEdit()
                Visible = False
                grd.Focus()
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtType_Leave(sender As Object, e As EventArgs) Handles txtType.Leave
        If lst.SelectedIndex > -1 Then
            lst_MouseClick(sender, Nothing)
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Private Sub lst_MouseLeave(sender As Object, e As EventArgs) Handles lst.MouseLeave
    '    lst.SelectedIndex = -1
    'End Sub
End Class