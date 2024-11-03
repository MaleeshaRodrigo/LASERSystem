Public MustInherit Class AbstractController
    Protected Db As Database

    Public Overridable Function SetDatabase(ByRef Db As Database) As AbstractController
        Me.Db = Db
        Return Me
    End Function

End Class
