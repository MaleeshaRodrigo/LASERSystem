Public Class compMessageBox
    Private Sub compMessageBox_Resize(sender As Object, e As EventArgs) Handles Me.Resize, Me.Load
        lblMessage.MaximumSize = New Size(Width - 10, 0)
        lblTitle.MaximumSize = New Size(Width - 25, 0)
        Height = Int(lblMessage.Top) + Int(lblMessage.Height) + 5
    End Sub
End Class
