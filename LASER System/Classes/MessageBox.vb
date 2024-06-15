Public Class MessageBox
    Public Shared Sub [Error](Message As String)
        MsgBox(Message, vbCritical + vbOKOnly)
    End Sub

    Public Shared Sub Success(Message As String)
        MsgBox(Message, vbOKOnly)
    End Sub
End Class
