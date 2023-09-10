Public Class RequiredValidator
    Implements IValidator
    Private ReadOnly _Control As Control
    Private ReadOnly _Value As String
    Private ReadOnly _Key As String
    Private ReadOnly _MsgBoxStyle As MsgBoxStyle

    Public Sub New(Control As Control, Key As String, Optional MsgBoxStyle As MsgBoxStyle = MsgBoxStyle.Exclamation)
        Me._Control = Control
        Me._Key = Key
        Me._MsgBoxStyle = MsgBoxStyle
    End Sub

    Public Sub New(Value As String, Message As String, Optional MsgBoxStyle As MsgBoxStyle = MsgBoxStyle.Exclamation)
        Me._Value = Value
        Me._Key = Message
        Me._MsgBoxStyle = MsgBoxStyle
    End Sub

    Public Function Execute() As Boolean Implements IValidator.Execute
        If _Control IsNot Nothing AndAlso Trim(_Control.Text) <> "" Then
            Return True
        End If
        If _Value IsNot Nothing AndAlso Trim(_Value) <> "" Then
            Return True
        End If
        MsgBox($"{_Key} එක හිස් අගයක්ව පවතියි.", _MsgBoxStyle)
        If _Control IsNot Nothing Then _Control.Focus()
        Return False
    End Function
End Class
