Public Class Message
    Public Shared Sub ErrorMessage(Message As String)
        MsgBox(Message, vbCritical + vbOKOnly)
    End Sub

End Class
