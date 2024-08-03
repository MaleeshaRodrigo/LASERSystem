Imports System.Text.RegularExpressions
Imports MySqlConnector

Public Class ControlMessageUnit
    Private Db As Database

    Public Sub Init(Db As Database)
        Me.Db = Db
        Me.ControlRepairReRepairSelection.SetDatabase(Db)
        TextMsgNo.Text = Db.GetNextKey("Message", "MsgNo")
        Dim Datatable As DataTable = Db.GetDataTable("SELECT Message FROM messagesuggestion")
        GridSuggestion.DataSource = Datatable
    End Sub

    Public Sub SetData(RepairMode As RepairMode, RepairNo As Integer, TelephoneNos As List(Of String))
        If RepairMode = RepairMode.Repair Then
            ControlRepairReRepairSelection.SetRepair(RepairNo)
        Else
            ControlRepairReRepairSelection.SetReRepair(RepairNo)
        End If
        SetTelephoneNos(TelephoneNos)
    End Sub

    Public Sub SetTelephoneNos(TelephoneNos As List(Of String))
        CheckedListTelNo.Items.Clear()
        CheckedListTelNo.Items.AddRange(TelephoneNos.ToArray)
        For I As Integer = 0 To CheckedListTelNo.Items.Count - 1
            CheckedListTelNo.SetItemChecked(I, True)
        Next
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Dim Validation = ButtonSendValidation()
        If Validation.Error = True Then
            MessageBox.Error(Validation.Message)
            Exit Sub
        End If
        If MsgBox("SMS එක යැවීම සඳහා තහවුරු කරන්න.", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If
        For Each TelNo As String In CheckedListTelNo.CheckedItems
            Dim Values As New List(Of MySqlParameter) From {
                        New MySqlParameter("METHOD", "SMS"),
                        New MySqlParameter("TELNO", TelNo),
                        New MySqlParameter("MESSAGE", TextMessage.Text),
                        New MySqlParameter("STATUS", "Waiting")
                    }
            If ControlRepairReRepairSelection.RepairMode = RepairMode.Repair Then
                Values.Add(New MySqlParameter("REPNO", ControlRepairReRepairSelection.Value))
                Values.Add(New MySqlParameter("REREPNO", Nothing))
            ElseIf ControlRepairReRepairSelection.RepairMode = RepairMode.ReRepair Then
                Values.Add(New MySqlParameter("REPNO", Nothing))
                Values.Add(New MySqlParameter("REREPNO", ControlRepairReRepairSelection.Value))
            Else
                Values.Add(New MySqlParameter("REPNO", Nothing))
                Values.Add(New MySqlParameter("REREPNO", Nothing))
            End If
            Db.Execute("INSERT INTO Message(MsgDate, Action, RepNo, RetNo, TelNo, Message, Status) Values(NOW(), @METHOD, @REPNO, @REREPNO, @TELNO, @MESSAGE, @STATUS);", Values.ToArray)
        Next
        ParentForm?.Close()
    End Sub

    Private Function ButtonSendValidation() As (Message As String, [Error] As Boolean)
        If ControlRepairReRepairSelection.Value = Nothing Then
            Return ("කරුණාකර Repair No හෝ  ReRepair No එකක් තොරන්න.", True)
        End If
        If CheckedListTelNo.CheckedItems.Count < 1 Then
            Return ("කරුණාකර Telephone Number එකක් හෝ වැඩි ගණනක් තොරන්න.", True)
        End If
        If TextMessage.Text.Trim() = "" Then
            Return ("කරුණාකර Message එක හිස්ව නොතියන්න.", True)
        End If

        Return ("", False)
    End Function

    Private Sub ControlRepairReRepairSelection_RepairNoChanged(RepairNo As Integer) Handles ControlRepairReRepairSelection.RepairNoChanged
        Dim DicTelNos = Db.GetDataDictionary("SELECT CuTelNo1, CuTelNo2, CuTelNo3 FROM Repair Rep INNER JOIN Receive R ON R.RNo = Rep.RNo INNER JOIN Customer Cu ON Cu.CuNo = R.CuNo WHERE RepNo = @REPNO;", {
            New MySqlParameter("REPNO", RepairNo)
        })
        Dim ListTelephoneNos As New List(Of String)
        For Each TelNo As String In DicTelNos.Values
            If TelNo Is Nothing OrElse TelNo.Trim() = "" Then
                Continue For
            End If
            ListTelephoneNos.Add(TelNo)
        Next
        SetTelephoneNos(ListTelephoneNos)
    End Sub

    Private Sub ComboReRepNo_SelectedIndexChanged(ReRepairNo As Integer) Handles ControlRepairReRepairSelection.ReRepairNoChanged
        Dim DicTelNos = Db.GetDataDictionary("SELECT CuTelNo1, CuTelNo2, CuTelNo3 FROM `Return` Ret INNER JOIN Receive R ON R.RNo = Ret.RNo INNER JOIN Customer Cu ON Cu.CuNo = R.CuNo WHERE RetNo = @RETNO;", {
            New MySqlParameter("RETNO", ReRepairNo)
        })
        Dim ListTelephoneNos As New List(Of String)
        For Each TelNo As String In DicTelNos.Values
            If TelNo Is Nothing OrElse TelNo.Trim() = "" Then
                Continue For
            End If
            ListTelephoneNos.Add(TelNo)
        Next
        SetTelephoneNos(ListTelephoneNos)
    End Sub

    Private Sub GridSuggestion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridSuggestion.CellContentClick
        Dim Pattern As String = "{{(\w+)}}"
        Dim Message As String = GridSuggestion.Item(e.ColumnIndex, e.RowIndex).Value
        Dim DicRepair As Dictionary(Of String, Object) = Nothing
        Try
            If ControlRepairReRepairSelection.RepairMode = RepairMode.Repair Then
                DicRepair = Db.GetDataDictionary("SELECT CONCAT('R', RepNo) AS 'RepNo', RDate, CuName, CuTelNo1,CuTelNo2, CuTelNo3, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Qty, Charge, PaidPrice, TName, Status, RepDate, DDate, Location from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where Rep.Repno = @REPNO;", {
                New MySqlParameter("REPNO", ControlRepairReRepairSelection.Value)
            })
            ElseIf ControlRepairReRepairSelection.RepairMode = RepairMode.ReRepair Then
                DicRepair = Db.GetDataDictionary("SELECT CONCAT('RE', Ret.RetNo) AS 'RetNo', CONCAT('R', RepNo) AS 'RepNo', RDate, CuName, CuTelNo1, CuTelNo2, CuTelNo3, CuRemarks,  PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Location, Qty, TName, Status, Charge, PaidPrice, RepDate, DDate FROM `Return` Ret inner join Receive R On Ret.RNo = R.RNo INNER JOIN Customer Cu On R.CuNo = Cu.CuNo INNER JOIN Product P On Ret.PNo = P.PNo LEFT JOIN Technician T On Ret.TNo = T.TNo LEFT JOIN Deliver D On D.DNo=Ret.DNo WHERE Ret.RetNo = @RETNO;", {
                New MySqlParameter("RETNO", ControlRepairReRepairSelection.Value)
            })
            End If

            If DicRepair Is Nothing Then
                Exit Try
            End If

            For Each Match As Match In Regex.Matches(Message, Pattern, RegexOptions.IgnoreCase)
                If IsDBNull(DicRepair(Match.Groups(1).Value)) Then
                    Continue For
                End If

                Message = Message.Replace(Match.Value, DicRepair(Match.Groups(1).Value))
            Next
        Catch ex As Exception
            Throw ex
        End Try
        TextMessage.Text = Message
    End Sub
End Class
