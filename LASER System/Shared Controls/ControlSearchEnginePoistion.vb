Public Class ControlSearchEnginePoistion
    Public Index As Integer
    Public Event CloseEvent(Index As Integer)

    Private Shared LastIndex As Integer = 0

    Public Sub Init(Text As String, Index As Integer, Optional Color As Color = Nothing)
        LabelPoistion.Text = Text
        Me.Index = Index
        BackColor = If(Color = Nothing, Color.DodgerBlue, Color)

        OnResize(Nothing)
    End Sub

    Public Function GetText() As String
        Return LabelPoistion.Text
    End Function

    Private Sub PicturePoistionClose_Click(sender As Object, e As EventArgs) Handles PicturePoistionClose.Click
        RaiseEvent CloseEvent(Index)
        Dispose()
    End Sub

    Private Sub ControlSearchEnginePoistion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Width = LabelPoistion.Width + PicturePoistionClose.Width + 10
    End Sub
End Class
