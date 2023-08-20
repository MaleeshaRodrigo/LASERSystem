Public Class ExecuteValidators
    Private _Validators As ArrayList

    Public Sub AddValidator(Validator As IValidator)
        Me._Validators.Add(Validator)
    End Sub

    Public Function Execute() As Boolean
        For Each Validator As IValidator In _Validators
            If Not Validator.Execute() Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
