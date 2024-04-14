Public Class MessageBox
    Public Shared Sub [Error](Message As String)
        MsgBox(Message, vbCritical + vbOKOnly)
    End Sub

End Class
