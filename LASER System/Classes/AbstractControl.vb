Public Class AbstractControl
    Protected Db As Database

    Public Function SetDatabase(Db As Database) As AbstractControl
        Me.Db = Db
        Return Me
    End Function
End Class
