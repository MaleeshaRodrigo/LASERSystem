Public Class ControlPrice
    Public Event ValueChanged()

    Public Property Value As String
        Get
            Return TextPrice.Value
        End Get
        Set
            TextPrice.Value = Value
        End Set
    End Property

    Public Property ReadOnlyText As Boolean
        Get
            Return TextPrice.ReadOnly
        End Get
        Set(value As Boolean)
            TextPrice.ReadOnly = value
        End Set
    End Property


    Private Sub TextPrice_ValueChanged(sender As Object, e As EventArgs) Handles TextPrice.ValueChanged
        RaiseEvent ValueChanged()
    End Sub
End Class
