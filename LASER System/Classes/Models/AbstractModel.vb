Public MustInherit Class AbstractModel
    Protected Db As Database

    Public Function SetDatabase(Db As Database) As AbstractModel
        Me.Db = Db
        Return Me
    End Function

End Class
