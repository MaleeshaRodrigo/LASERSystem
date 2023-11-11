Public NotInheritable Class User
    Private Shared ReadOnly _instance As User
    Public UserName As String
    Public UserType As Type

    Private Sub New()
    End Sub

    Public Shared Function Instance() As User
        If _instance Is Nothing Then
            _instanct = New User()
        End If
        Return _instance
    End Function

    Public Structure Type
        Const Admin = "Admin"
        Const Cashier = "Cashier"
    End Structure

End Class

