Public Class MessagePanel
    'Indicates current Message panel to add controls to 
    Private _CurrentMessagePanelName As String = Nothing
    'Used to give unique control names such as label1, label2 etc
    Private Shared _MessagePanelsAddedCount As Integer = 0

    'Add Message panel to flow layout panel
    Public Sub New(Title As String, Message As String, Optional ByVal Tag As String = "")
        Dim MessagePanel As New compMessageBox
        'Add panel to flow layout panel
        MdifrmMain.flpMessage.Controls.Add(MessagePanel)

        'Update panel variables
        _CurrentMessagePanelName = MessagePanel.Name
        _MessagePanelsAddedCount += 1

        MessagePanel.btnMessageDelete.Name = "btnMessageDelete" + (_MessagePanelsAddedCount).ToString

        MessagePanel.lblTitle.Name = "lblTitle" + (_MessagePanelsAddedCount).ToString
        MessagePanel.lblTitle.Text = Title

        MessagePanel.lblMessage.Name = "lblMessage" + (_MessagePanelsAddedCount).ToString
        MessagePanel.lblMessage.Text = Message

        'Set panel properties
        With MessagePanel
            .Name = "pnlMessage" + (_MessagePanelsAddedCount).ToString
            .Tag = Tag
        End With
    End Sub

    'Remove handlers and Message panel 
    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentPanelName As String

        parentPanelName = Nothing

        'Remove handler from sender
        For Each controlObj As Control In MdifrmMain.flpMessage.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then
                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click
                    parentPanelName = childControlObj.Parent.Name
                End If
            Next
            If controlObj.Name = parentPanelName Then
                MdifrmMain.flpMessage.Controls.Remove(controlObj)
                controlObj.Dispose()
            End If
        Next

    End Sub

End Class
