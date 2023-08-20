Public Class CustomValidator
    Implements IValidator
    Private ReadOnly _Condition As Boolean
    Private ReadOnly _Message As String
    Private ReadOnly _MsgBoxStyle As MsgBoxStyle

    Public Sub New(Condition As Boolean, Message As String, Optional MsgBoxStyle As MsgBoxStyle = MsgBoxStyle.Exclamation)
        Me._Condition = Condition
        Me._Message = Message
        Me._MsgBoxStyle = MsgBoxStyle
    End Sub

    Public Function Execute() As Boolean Implements IValidator.Execute
        If _Condition Then
            Return True
        End If
        MsgBox(_Message, _MsgBoxStyle)
        Return False
    End Function
End Class
