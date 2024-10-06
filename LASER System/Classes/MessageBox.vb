Public Class MessageBox
    Public Shared Sub [Error](Message As String)
        MsgBox(Message, vbCritical + vbOKOnly)
    End Sub

    Public Shared Sub Success(Message As String)
        MsgBox(Message, vbOKOnly)
    End Sub

    Public Shared Function Question(Message As String) As MsgBoxResult
        Return MsgBox(Message, vbYesNo + vbQuestion)
    End Function

    Public Shared Function Exclamation(Message As String) As MsgBoxResult
        Return MsgBox(Message, vbOKOnly + vbExclamation)
    End Function
End Class
