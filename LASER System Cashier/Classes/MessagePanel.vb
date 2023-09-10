Public Class MessagePanel
    Private _ControlMessagePanel As New compMessageBox
    'Used to give unique control names such as label1, label2 etc
    Private Shared _MessagePanelsAddedCount As Integer = 0

    'Add Message panel to flow layout panel
    Public Sub New(Title As String, Message As String, Optional ByVal Tag As String = "")
        _ControlMessagePanel.btnMessageDelete.Name = "btnMessageDelete" + (_MessagePanelsAddedCount).ToString

        _ControlMessagePanel.lblTitle.Name = "lblTitle" + (_MessagePanelsAddedCount).ToString
        _ControlMessagePanel.lblTitle.Text = Title

        _ControlMessagePanel.lblMessage.Name = "lblMessage" + (_MessagePanelsAddedCount).ToString
        _ControlMessagePanel.lblMessage.Text = Message

        With _ControlMessagePanel
            .Name = "pnlMessage" + (_MessagePanelsAddedCount).ToString
            .Tag = Tag
        End With
        _MessagePanelsAddedCount += 1
    End Sub

    Public Sub Add()
        'Add panel to flow layout panel
        MdifrmMain.flpMessage.Controls.Add(_ControlMessagePanel)
    End Sub
End Class
