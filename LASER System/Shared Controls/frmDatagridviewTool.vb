Public Class frmDatagridviewTool
    Private grdParent As New DataGridView
    Private frmParent As New Form
    Private grddt As New DataTable

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Left = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).X
        Top = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).Y + grdParent.CurrentRow.Height
        If (Left + Width) > (frmParent.Width + frmParent.Left) Then
            Left = Left - (Width - grdParent.CurrentCell.Size.Width)
        End If
        Font = grdParent.Font
        grd.DataSource = grddt
        If grd.Rows.Count = 0 Then
            Visible = False
        End If
        If Tag = "RepRem" Then
            grd.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            grd.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            grd.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        End If
        Height = (grd.ColumnHeadersHeight * 2) + grd.Rows.GetRowsHeight(DataGridViewElementStates.None)
        BringToFront()
    End Sub

    Public Sub frm_Open(grdParentParent As DataGridView, frmParentForm As Form, parentDT As DataTable)
        grdParent = grdParentParent
        frmParent = frmParentForm
        grddt = parentDT
        If Visible = False Then
            Show(ParentForm)
        Else
            frm_Load(Nothing, Nothing)
            Visible = True
        End If
        AddHandler grdParent.Scroll, AddressOf frm_Scroll
    End Sub

    Private Sub frm_Scroll(sender As Object, e As ScrollEventArgs)
        If Visible = True Then
            frm_Move()
        End If
    End Sub

    Public Sub frm_Close()
        Close()
    End Sub

    Private Sub frm_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub

    Public Sub frm_Move()
        If Visible = True Then
            Left = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).X
            Top = grdParent.PointToScreen(grdParent.GetCellDisplayRectangle(grdParent.CurrentCell.ColumnIndex, grdParent.CurrentCell.RowIndex, False).Location).Y + grdParent.CurrentRow.Height
            If (Left + Width) > (frmParent.Width + frmParent.Left) Then
                Left = Left - (Width - grdParent.CurrentCell.Size.Width)
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