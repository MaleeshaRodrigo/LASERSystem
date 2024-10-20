Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlCommandInfo
    Private Db As Database

    Public Function SetDatabase(Db As Database) As ControlCommandInfo
        Me.Db = Db
        Return Me
    End Function

    Private Sub ControlCommandInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
            cmdCancel.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
            cmdReceiptSticker.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
            cmdReceipt.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
            cmdSticker.PerformClick()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
            cmdSaveOnly.PerformClick()
        End If
    End Sub

    'Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
    '    pnlRSaveFinal.Visible = False
    '    pnlRSaveFinal.Dock = DockStyle.None
    '    MenuStrip.Enabled = True
    '    AcceptButton = cmdSave
    '    txtCuTelNo1.Focus()
    'End Sub

    'Private Sub cmdReceiptSticker_Click(sender As Object, e As EventArgs) Handles cmdReceiptSticker.Click, cmdReceipt.Click, cmdSticker.Click
    '    SaveReceive()
    '    Dim RNo As Integer = txtRNo.Text
    '    cmdNew_Click(sender, e)
    '    If sender Is cmdReceipt Or sender Is cmdReceiptSticker Then
    '        PrintReceivedReceipt(RNo, True, True, "ReceivedReceipt")
    '    End If
    '    If sender Is cmdSticker Or sender Is cmdReceiptSticker Then
    '        PrintSticker(RNo, True, True, "ReceivedSticker")
    '    End If
    'End Sub
End Class
