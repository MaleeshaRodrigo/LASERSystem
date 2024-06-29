Imports MySqlConnector

Public Class ControlMessageUnit
    Private Db As New Database

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        If MsgBox("Phone No: " + TextTelNo.Text & vbCr &
                  "Message: " + TextMessage.Text & vbCr &
                  "SMS එක යැවීම සඳහා තහවුරු කරන්න.", vbYesNo + vbQuestion) = False Then
            Exit Sub
        End If
        Dim Values As New List(Of MySqlParameter) With {
            New MySqlParameter("METHOD", "SMS"),
            New MySqlParameter("TELNO", TextTelNo.Text),
            New MySqlParameter("MESSAGE", TextMessage.Text),
            New MySqlParameter("STATUS", "Waiting")
        }
        If RadioRepNo.Checked = True Then
            Values.Add(New MySqlParameter("REPNO", ComboRepNo.Text))
            Values.Add(New MySqlParameter("REREPNO", Nothing))
        ElseIf RadioReRepNo.Checked = True Then
            Values.Add(New MySqlParameter("REPNO", Nothing))
            Values.Add(New MySqlParameter("REREPNO", ComboReRepNo.Text))
        Else
            Values.Add(New MySqlParameter("REPNO", Nothing))
            Values.Add(New MySqlParameter("REREPNO", Nothing))
        End If
        Db.Execute("Insert Into Message(Action, RepNo, RetNo, CuTelNo, Message, Status) Values(@METHOD, @REPNO, @REREPNO, @TELNO, @MESSAGE, @STATUS);", Values.ToArray)
    End Sub

    Private Sub ComboRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboRepNo.SelectedIndexChanged
        RadioRepNo.Checked = True
    End Sub

    Private Sub ComboRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboRepNo.DropDown
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RepNo FROM Repair ORDER BY RepNo;")
    End Sub

    Private Sub ComboReRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboReRepNo.SelectedIndexChanged
        RadioReRepNo.Checked = True
    End Sub

    Private Sub ComboReRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboReRepNo.DropDown
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RetNo FROM `Return` ORDER BY RetNo;")
    End Sub
End Class
