Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlRepairAdvanceInfo
    Private Db As Database
    Public Mode As UpdateMode
    Public Event SubmitEvent()

    Public Function SetDatabase(Db As Database) As ControlRepairAdvanceInfo
        Me.Db = Db
        ControlRepairReRepairSelection.SetDatabase(Db)
        Return Me
    End Function

    Public Function SetData(Data As Dictionary(Of String, Object)) As ControlRepairAdvanceInfo
        txtAdNo.Text = Data(RepairAdvanced.ADNo)
        txtAdDate.Text = Data(RepairAdvanced.ADDate)
        TextAmout.Value = Data(RepairAdvanced.Amount)
        txtRemarks.Text = Data(RepairAdvanced.Remarks)
        If IsNumeric(Data(RepairAdvanced.RepNo)) Then
            ControlRepairReRepairSelection.SetRepair(Data(RepairAdvanced.RepNo))
        Else
            ControlRepairReRepairSelection.SetReRepair(Data(RepairAdvanced.RetNo))
        End If
        Return Me
    End Function

    Private Function SaveValidation() As (Status As Boolean, Message As String)
        If ControlRepairReRepairSelection.Value = 0 Then
            Return (False, "Repair No හෝ  RE-Repair No එක ඇතුලත් කරන්න.")
        ElseIf String.IsNullOrEmpty(TextAmout.Value) Then
            Return (False, "Advanced එකෙහි Amount එක ඇතුලත් කරන්න.")
        ElseIf (User.Instance.UserType <> User.Type.Admin And DateAndTime.DateValue(txtAdDate.Value) <> Today.Date) Then
            Return (False, "අද දිනට නොමැති Repair එකෙහි Advanced Payment එකක් ඇතුලත් කිරීමට ඔබට අවසර නොමැත.")
        End If

        Return (True, "")
    End Function

    Private Function DeleteValidation() As (Status As Boolean, Message As String)
        If (User.Instance.UserType <> User.Type.Admin And DateAndTime.DateValue(txtAdDate.Value) <> Today.Date) Then
            Return (False, "අද දිනට නොමැති Repair එකෙහි Advanced Payment එකක් Delete කිරීමට ඔබට අවසර නොමැත.")
        ElseIf Db.CheckDataExists(Tables.RepairAdvanced, RepairAdvanced.ADNo, txtAdNo.Text) = False Then
            Return (False, "මෙම Advance එක ඇතුලත් කර නොමැති එකකි. කරුණාකර පරික්ෂා කර නැවත උත්සහ කරන්න.")
        End If

        Return (True, "")
    End Function

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim Validator = SaveValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
            Exit Sub
        End If

        Dim Values As New List(Of MySqlParameter) From {
            New MySqlParameter("DATE", DateTime.Parse(txtAdDate.Value)),
            New MySqlParameter("AMOUNT", TextAmout.Value),
            New MySqlParameter("REMARKS", txtRemarks.Text),
            New MySqlParameter("UNO", User.Instance.UserNo)
        }
        If ControlRepairReRepairSelection.RepairMode = RepairMode.Repair Then
            Values.AddRange({
                New MySqlParameter("REPNO", ControlRepairReRepairSelection.Value),
                New MySqlParameter("RETNO", Nothing)
            })
        Else
            Values.AddRange({
                New MySqlParameter("RETNO", ControlRepairReRepairSelection.Value),
                New MySqlParameter("REPNO", Nothing)
            })
        End If

        Select Case Mode
            Case UpdateMode.New
                Db.Execute("INSERT INTO RepairAdvanced(ADDate,RepNo,RetNo,Amount,Remarks,UNo) VALUES(@DATE, @REPNO, @RETNO, @AMOUNT, @REMARKS, @UNO);", Values.ToArray)
            Case UpdateMode.Edit
                Values.Add(New MySqlParameter("ADNO", txtAdNo.Text))
                Db.Execute("Update RepairAdvanced set ADDate=@DATE, RetNo=@RETNO, RepNo=@REPNO, Amount=@AMOUNT, Remarks=@REMARKS, UNo=@UNO Where AdNo=@ADNO;", Values.ToArray)
        End Select
        If MsgBox("Repair Advanced Invoice එක print කිරීමට අවශ්‍යද?", vbYesNo) = vbYes Then
            Print(txtAdNo.Text)
        End If
        RaiseEvent SubmitEvent()
        ButtonClose.PerformClick()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim Validator = DeleteValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
            Exit Sub
        End If

        Db.Execute("DELETE FROM RepairAdvanced WHERE AdNo=@ADNO;", {
            New MySqlParameter("ADNO", txtAdNo.Text)
        })
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub ControlRepairAdvanceInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DesignMode Then
            Exit Sub
        End If

        If Mode = UpdateMode.New Then
            txtAdNo.Text = Db.GetNextKey(Tables.RepairAdvanced, RepairAdvanced.ADNo)
        End If
    End Sub
End Class
