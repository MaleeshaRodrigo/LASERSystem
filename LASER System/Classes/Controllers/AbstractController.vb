Public MustInherit Class AbstractController
    Protected Db As Database

    Public Function SetDatabase(Db As Database) As AbstractController
        Me.Db = Db
        Return Me
    End Function

End Class
