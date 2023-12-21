Public Class NumberValidator
    Implements IValidator
    Private ReadOnly _Control As Control
    Private ReadOnly _Value As String
    Private ReadOnly _Key As String
    Private ReadOnly _MsgBoxStyle As MsgBoxStyle

    Public Sub New(Control As Control, Key As String, Optional MsgBoxStyle As MsgBoxStyle = MsgBoxStyle.Exclamation)
        _Control = Control
        _Key = Key
        _MsgBoxStyle = MsgBoxStyle
    End Sub

    Public Sub New(Value As String, Message As String, Optional MsgBoxStyle As MsgBoxStyle = MsgBoxStyle.Exclamation)
        _Value = Value
        _Key = Message
        _MsgBoxStyle = MsgBoxStyle
    End Sub

    Public Function Execute() As Boolean Implements IValidator.Execute
        If _Control IsNot Nothing AndAlso IsNumeric(_Control.Text) = True Then
            Return True
        End If
        If _Value IsNot Nothing AndAlso IsNumeric(_Value) = True Then
            Return True
        End If
        MsgBox($"{_Key} එක Numeric අගයක්ව නොපවතියි.", _MsgBoxStyle)
        If _Control IsNot Nothing Then _Control.Focus()
        Return False
    End Function
End Class
