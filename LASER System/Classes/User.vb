Public NotInheritable Class User
    Private Shared _Instance As User
    Public UserNo As Integer
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

    Public Function IsAdmin() As Boolean
        Return UserType = Type.Admin
    End Function

    Public Function IsNonAdmin() As Boolean
        Return UserType <> Type.Admin
    End Function

    Public Function IsHrAdmin() As Boolean
        Return UserType = Type.HRAdmin OrElse UserType = Type.Admin
    End Function

    Public Structure Type
        Const Admin = "Admin"
        Const Cashier = "Cashier"
        Const HRAdmin = "HR Admin"
    End Structure

End Class

