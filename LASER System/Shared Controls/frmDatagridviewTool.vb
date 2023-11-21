Public Class frmDatagridviewTool
    Private grdParent As New DataGridView
    Private frmParent As New Form
    Private grddt As New DataTable

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Left = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).X
        Me.Top = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).Y + grdParent.CurrentRow.Height
        If (Me.Left + Me.Width) > (frmParent.Width + frmParent.Left) Then
            Me.Left = Me.Left - (Me.Width - grdParent.CurrentCell.Size.Width)
        End If
        Me.Font = grdParent.Font
        grd.DataSource = grddt
        If grd.Rows.Count = 0 Then
            Me.Visible = False
        End If
        If Me.Tag = "RepRem" Then
            grd.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            grd.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grd.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        End If
        Me.Height = (grd.ColumnHeadersHeight * 2) + grd.Rows.GetRowsHeight(DataGridViewElementStates.None)
        Me.BringToFront()
    End Sub

    Public Sub frm_Open(grdParentParent As DataGridView, frmParentForm As Form, parentDT As DataTable)
        grdParent = grdParentParent
        frmParent = frmParentForm
        grddt = parentDT
        If Me.Visible = False Then
            Me.Show(Me.ParentForm)
        Else
            frm_Load(Nothing, Nothing)
            Me.Visible = True
        End If
        AddHandler grdParent.Scroll, AddressOf frm_Scroll
    End Sub

    Private Sub frm_Scroll(sender As Object, e As ScrollEventArgs)
        If Me.Visible = True Then
            frm_Move()
        End If
    End Sub

    Public Sub frm_Close()
        Me.Close()
    End Sub

    Private Sub frm_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Public Sub frm_Move()
        If Me.Visible = True Then
            Me.Left = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).X
            Me.Top = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).Y + grdParent.CurrentRow.Height
            If (Me.Left + Me.Width) > (frmParent.Width + frmParent.Left) Then
                Me.Left = Me.Left - (Me.Width - grdParent.CurrentCell.Size.Width)
            End If
        End If
    End Sub

    Public Sub dgv_KeyDown(sender As Object, e As KeyEventArgs)
        e.Handled = False
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub
End Class