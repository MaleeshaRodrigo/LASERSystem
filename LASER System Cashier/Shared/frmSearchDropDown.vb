Public Class frmSearchDropDown
    Private grd As New DataGridView
    Private frmParent As New Form
    Private txt As New TextBox
    Private SQL, ColumnName As String
    Public Sub frm_Open(grdParent As DataGridView, frmParentForm As Form, ParentSQL As String, ParentColumnName As String)
        grd = grdParent
        frmParent = frmParentForm
        SQL = ParentSQL
        ColumnName = ParentColumnName
        If Me.Visible = False Then
            Me.Show(Me.ParentForm)
        Else
            frm_Load(Nothing, Nothing)
            Me.Visible = True
        End If
        frm_Move()
        Me.Activate()
        txtType.Text = txt.Text
        txtType.DeselectAll()
        txtType.Focus()
    End Sub
    Public Sub frm_Move()
        If Me.Visible = True Then
            Me.Left = grd.PointToScreen(grd.GetCellDisplayRectangle(grd.CurrentCell.ColumnIndex, grd.CurrentCell.RowIndex, False).Location).X
            Me.Top = grd.PointToScreen(grd.GetCellDisplayRectangle(grd.CurrentCell.ColumnIndex, grd.CurrentCell.RowIndex, False).Location).Y +
                grd.CurrentRow.Height

            If (Me.Left + Me.Width) > My.Computer.Screen.Bounds.Size.Width Then
                Me.Left = My.Computer.Screen.Bounds.Size.Width - Me.Width
            End If
            If (Me.Top + Me.Height) > My.Computer.Screen.Bounds.Size.Height Then
                Me.Top = grd.PointToScreen(grd.GetCellDisplayRectangle(grd.CurrentCell.ColumnIndex, grd.CurrentCell.RowIndex, False).Location).Y -
                    Me.Height
            End If
        End If
    End Sub

    Public Sub frm_Close()
        Me.Close()
    End Sub

    Public Sub passtext(txtValue As TextBox)
        txt = txtValue
        txtType.Text = txtValue.Text
    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Font = grd.Font
        lst.Items.Clear()
        CMD = New OleDb.OleDbCommand(SQL, CNN)
        DR = CMD.ExecuteReader()
        While DR.Read
            If DR(ColumnName).ToString <> "" AndAlso DR(ColumnName).ToLower().Contains(txt.Text.ToLower) = True Then
                lst.Items.Add(DR(ColumnName).ToString)
            End If
        End While
        If lst.Items.Count > 10 Then
            Me.Height = lst.ItemHeight * 11
        ElseIf lst.Items.Count <= 10 Then
            Me.Height = lst.ItemHeight * (lst.Items.Count + 1)
        ElseIf lst.Items.Count = 0 Then
            Me.Visible = False
        End If
        Me.Width = grd.Columns.Item(grd.CurrentCell.ColumnIndex).Width
        Me.Height = lst.Height
        lst.Cursor = Cursors.Hand
        Me.BringToFront()
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
        Me.Close()
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        If Me.Visible = True Then
            lst.Items.Clear()
            CMD = New OleDb.OleDbCommand(SQL, CNN)
            DR = CMD.ExecuteReader()
            While DR.Read
                If DR(ColumnName).ToString = "" Then Continue While
                'For Each str As String In DR(ColumnName).ToString.Split(" ")
                '    For Each strtxt As String In txt.Text.ToString.Split(" ")
                If DR(ColumnName).ToLower().Contains(txtType.Text.ToLower) = True Then
                    lst.Items.Add(DR(ColumnName).ToString)
                    Continue While
                End If
                '    Next
                'Next
            End While
            If lst.Items.Count > 10 Then
                Me.Height = lst.ItemHeight * 11
            ElseIf lst.Items.Count <= 10 Then
                Me.Height = lst.ItemHeight * (lst.Items.Count + 1)
            ElseIf lst.Items.Count = 0 Then
                Me.Visible = False
            End If
            Me.Width = grd.Columns.Item(grd.CurrentCell.ColumnIndex).Width
            Me.Height = lst.Height
            Me.Activate()
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
        txtType.Top = Me.Height
        txtType.Left = 0
        txtType.Width = 0
    End Sub

    Private Sub lst_GotFocus(sender As Object, e As EventArgs) Handles lst.GotFocus
        txtType.Focus()
        txtType.DeselectAll()
    End Sub

    Private Sub txtType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtType.KeyDown
        If Me.Visible = False Then Exit Sub
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
                Me.Visible = False
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