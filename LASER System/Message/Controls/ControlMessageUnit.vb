Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Access.Dao
Imports MySqlConnector

Public Class ControlMessageUnit
    Private Db As New Database

    Private Sub ControlMessageUnit_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextMsgNo.Text = Db.GetNextKey("Message", "MsgNo")

        Dim Datatable As DataTable = Db.GetDataTable("SELECT Message FROM messagesuggestion")
        GridSuggestion.DataSource = Datatable
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Dim Validation = ButtonSendValidation()
        If Validation.Error = True Then
            MessageBox.Error(Validation.Message)
        End If
        If MsgBox("SMS එක යැවීම සඳහා තහවුරු කරන්න.", vbYesNo + vbQuestion) = False Then
            Exit Sub
        End If
        For Each TelNo As String In CheckedListTelNo.SelectedItems
            Dim Values As New List(Of MySqlParameter) From {
                        New MySqlParameter("METHOD", "SMS"),
                        New MySqlParameter("TELNO", TelNo),
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
            Db.Execute("INSERT INTO Message(MsgDate, Action, RepNo, RetNo, CuTelNo, Message, Status) Values(NOW(), @METHOD, @REPNO, @REREPNO, @TELNO, @MESSAGE, @STATUS);", Values.ToArray)
        Next
    End Sub

    Private Function ButtonSendValidation() As (Message As String, [Error] As Boolean)
        If RadioRepNo.Checked = False And RadioReRepNo.Checked = False Then
            Return ("කරුණාකර Repair No හෝ  ReRepair No එකක් තොරන්න.", True)
        End If
        If CheckedListTelNo.SelectedItems.Count < 1 Then
            Return ("කරුණාකර Telephone Number එකක් හෝ වැඩි ගණනක් තොරන්න.", True)
        End If
        If TextMessage.Text.Trim() = "" Then
            Return ("කරුණාකර Message එක හිස්ව නොතියන්න.", True)
        End If

        Return ("", False)
    End Function

    Private Sub ComboRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboRepNo.SelectedIndexChanged
        RadioRepNo.Checked = True

        Dim DicTelNos = Db.GetDataDictionary("SELECT CuTelNo1, CuTelNo2, CuTelNo3 FROM Repair Rep INNER JOIN Receive R ON R.RNo = Rep.RNo INNER JOIN Customer Cu ON Cu.CuNo = R.CuNo WHERE RepNo = @REPNO;", {
            New MySqlParameter("REPNO", ComboRepNo.Text)
        })
        For Each TelNo As String In DicTelNos.Values
            If TelNo Is Nothing OrElse TelNo.Trim() = "" Then
                Continue For
            End If
            CheckedListTelNo.Items.Add(TelNo)
        Next
    End Sub

    Private Sub ComboRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboRepNo.DropDown
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RepNo FROM Repair ORDER BY RepNo DESC;")
    End Sub

    Private Sub ComboReRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboReRepNo.SelectedIndexChanged
        RadioReRepNo.Checked = True
    End Sub

    Private Sub ComboReRepNo_DropDown(sender As Object, e As EventArgs) Handles ComboReRepNo.DropDown
        ComboBoxDropDown(Db, ComboRepNo, "SELECT RetNo FROM `Return` ORDER BY RetNo DESC;")
    End Sub

    Private Sub GridSuggestion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridSuggestion.CellContentClick
        Dim Pattern As String = "{{(\w+)}}"
        Dim Message As String = GridSuggestion.Item(e.ColumnIndex, e.RowIndex).Value
        Dim DicRepair As Dictionary(Of String, Object) = Nothing
        If RadioRepNo.Checked = True Then
            DicRepair = Db.GetDataDictionary("SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PDetails, PSerialNo,Problem,Qty,Charge, PaidPrice,REP.TNo, TName, Status, RepDate,REP.DNo, DDate, Location from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where Rep.Repno = @REPNO;", {
                New MySqlParameter("REPNO", ComboRepNo.Text)
            })
        ElseIf RadioReRepNo.Checked = True Then
            DicRepair = Db.GetDataDictionary("Select Ret.RetNo, RepNo, Ret.RNo, RDate,  R.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3, CuRemarks,  Ret.PNo, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Location, Qty, Ret.TNo, TName, Status, Charge, PaidPrice, RepDate, Ret.DNo, DDate FROM `Return` Ret inner join Receive R On Ret.RNo = R.RNo INNER JOIN Customer Cu On R.CuNo = Cu.CuNo INNER JOIN Product P On Ret.PNo = P.PNo LEFT JOIN Technician T On Ret.TNo = T.TNo LEFT JOIN Deliver D On D.DNo=Ret.DNo WHERE Ret.RetNo = @RETNO", {
                New MySqlParameter("RETNO", ComboReRepNo.Text)
            })
        End If
        If DicRepair IsNot Nothing Then
            For Each Match As Match In Regex.Matches(Message, Pattern, RegexOptions.IgnoreCase)
                Message = Message.Replace(Match.Value, DicRepair(Match.Groups(1).Value))
            Next
        End If
        TextMessage.Text = Message
    End Sub
End Class
