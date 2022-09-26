Imports System.ComponentModel

Public Class MessageBox
    'Used to give unique control names such as label1, label2 etc
    Public Shared Count As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Count += 1
        For Each obj As Control In {lblTitle, lblMessage, btnMessageDelete, Me}
            obj.Name += Count.ToString
        Next

    End Sub

    <Category("Custom Props")>
    Public Property Title As String
        Get
            Return lblTitle.Text
        End Get
        Set(value As String)
            lblTitle.Text = value
        End Set
    End Property

    <Category("Custom Props")>
    Public Property Message As String
        Get
            Return lblMessage.Text
        End Get
        Set(value As String)
            lblMessage.Text = value
        End Set
    End Property

    <Category("Custom Props")>
    Public Property Icon As Image
        Get
            Return PictureBox.Image
        End Get
        Set(value As Image)
            PictureBox.Image = value
        End Set
    End Property

    Private Sub compMessageBox_Resize(sender As Object, e As EventArgs) Handles Me.Resize, Me.Load
        lblMessage.MaximumSize = New Size(Width - lblMessage.Left - 10, 0)
        lblTitle.MaximumSize = New Size(Width - lblTitle.Left - btnMessageDelete.Height - 10, 0)
        lblMessage.Top = lblTitle.Top + lblTitle.Height + 10
        Height = lblMessage.Top + lblMessage.Height + If(PanelAction.Visible, PanelAction.Height, 0) + 10
        If Me.Parent IsNot Nothing Then Me.Width = Me.Parent.Width - 20
    End Sub
    Private Sub btnMessageDelete_Click(sender As Object, e As EventArgs) Handles btnMessageDelete.Click
        Dispose()
    End Sub
End Class
