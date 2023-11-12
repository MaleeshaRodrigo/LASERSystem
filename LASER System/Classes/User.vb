Public NotInheritable Class User
    Private Shared _Instance As User
    Public UserName As String
    Public UserType As String
    Public Email As String

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance As User
        Get
            If _Instance Is Nothing Then
                _Instance = New User()
            End If
            Return _Instance
        End Get
    End Property

    Public Structure Type
        Const Admin = "Admin"
        Const Cashier = "Cashier"
    End Structure

End Class

