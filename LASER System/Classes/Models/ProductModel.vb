Public Class ProductModel
    Private _Category As String
    Private _Name As String
    Private _Details As String

    Public Sub New(Category As String, Name As String, Details As String)
        Me._Category = Category
        Me._Name = Name
        Me._Details = Details
    End Sub

    Public Property Category
        Get
            Return _Category
        End Get
        Set(Value)
            _Category = Value
        End Set
    End Property

    Public Property Name
        Get
            Return _Name
        End Get
        Set(Value)
            _Name = Value
        End Set
    End Property

    Public Property Details
        Get
            Return _Details
        End Get
        Set(Value)
            _Details = Value
        End Set
    End Property

End Class
