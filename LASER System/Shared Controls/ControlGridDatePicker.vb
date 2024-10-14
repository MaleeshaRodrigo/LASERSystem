Public Class ControlGridDatePicker
    Private Cell As DataGridViewCell

    Public Property Value As Date
        Get
            Return DatePicker.Value
        End Get
        Set(Value As Date)
            DatePicker.Value = Value
        End Set
    End Property

    Public Sub Init(Cell As DataGridViewCell)
        Me.Cell = Cell
    End Sub

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged
        Cell.Value = DatePicker.Value
    End Sub

    Private Sub DatePicker_LostFocus(sender As Object, e As EventArgs) Handles DatePicker.LostFocus
        Dispose()
    End Sub
End Class
