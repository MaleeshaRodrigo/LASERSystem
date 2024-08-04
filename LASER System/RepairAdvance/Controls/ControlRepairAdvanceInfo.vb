Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlRepairAdvanceInfo
    Private Db As Database
    Private Mode As UpdateMode

    Public Function SetDatabase(Db As Database) As ControlRepairAdvanceInfo
        Me.Db = Db
        ControlRepairReRepairSelection.SetDatabase(Db)
        Return Me
    End Function

    Public Function SetData(Data As Dictionary(Of String, Object)) As ControlRepairAdvanceInfo
        txtAdNo.Text = Data(RepairAdvanced.ADNo)
        txtAdDate.Text = Data(RepairAdvanced.ADDate
        TextAmout.Value = Data(RepairAdvanced.Amount)
        txtRemarks.Text = Data(RepairAdvanced.Remarks)
        If IsNumeric(Data(RepairAdvanced.RepNo)) Then
            ControlRepairReRepairSelection.SetRepair(Data(RepairAdvanced.RepNo))
        Else
            ControlRepairReRepairSelection.SetReRepair(Data(RepairAdvanced.RetNo))
        End If
        Return Me
    End Function

    Private Sub Print()
        Dim Validator = PrintValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
            Exit Sub
        End If

        Dim Connection = Db.GetConenction()
        Dim Report As New rptRepairAdvanced
        Dim DataSet As New DataSet
        Dim DataAdapter As MySqlDataAdapter
        Try
            Connection.Open()
            If ControlRepairReRepairSelection.RepairMode = RepairMode.Repair Then
                DataAdapter = Db.GetDataAdapter(Connection, "SELECT CuName,CuTelNo1,CuTelNo2,CuTelNo3,ADDate,Rep.RepNo,Ret.RetNo,PCategory,PName,Amount FROM (((((RepairAdvanced AD LEFT JOIN Repair Rep On Rep.RepNo=AD.RepNo) LEFT JOIN Return Ret On Ret.RetNo=AD.RetNo) LEFT JOIN Product P ON P.PNo = Rep.PNo) LEFT JOIN Receive R ON R.RNo = Rep.RNo) LEFT JOIN Customer Cu ON Cu.CuNo=R.CuNo) Where ADNo=@ADNO;", {
                    New MySqlParameter("ADNO", txtAdNo.Text)
                })
            Else
                DataAdapter = Db.GetDataAdapter(Connection, "SELECT CuName,CuTelNo1,CuTelNo2,CuTelNo3,ADDate,Rep.RepNo,Ret.RetNo,PCategory,PName,Amount FROM (((((RepairAdvanced AD LEFT JOIN Return Ret On Ret.RetNo=AD.RetNo) LEFT JOIN Repair Rep On Rep.RepNo=Ret.RepNo) LEft Join Product P ON P.PNo = Rep.PNo) LEFT JOIN Receive R ON R.RNo = Rep.RNo) LEFT JOIN Customer Cu ON Cu.CuNo=R.CuNo) Where ADNo=@ADNO;", {
                    New MySqlParameter("ADNO", txtAdNo.Text)
                })
            End If
            DataAdapter.Fill(DataSet, "Repair")
            DataAdapter.Fill(DataSet, "Product")
            DataAdapter.Fill(DataSet, "Rerepair")
            DataAdapter.Fill(DataSet, "Customer")
            DataAdapter.Fill(DataSet, "Receive")
            DataAdapter.Fill(DataSet, "RepairAdvanced")
            Report.SetDataSource(DataSet)
            Report.SetParameterValue("Cashier Name", User.Instance.UserName) 'Set Cashier Name to Parameter Value
            Dim c As Integer
            Dim doctoprint As New Printing.PrintDocument()
            doctoprint.PrinterSettings.PrinterName = My.Settings.BillPrinterName
            Dim rawKind As Integer
            For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
                If doctoprint.PrinterSettings.PaperSizes(c).PaperName = My.Settings.BillPrinterPaperName Then
                    rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                    Exit For
                End If
            Next
            Report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            Report.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)

            Dim frm As New frmReport With {.Name = frmReport.Name + NextfrmNo(frmReport).ToString}
            frm.ReportViewer.ReportSource = Report
            frm.Show(Me)
        Catch ex As Exception

        Finally
            Connection.Close()
            Report.Close()
            DataSet.Clear()
        End Try
    End Sub

    Private Function PrintValidation() As (Status As Boolean, Message As String)
        If txtAdNo.Text.Trim = "" Then
            Return (False, "Repair Advanced No එක හිස්ව පවතියි.")
        ElseIf Not Db.CheckDataExists(TAbles.RepairAdvanced, RepairAdvanced.ADNo, txtAdNo.Text) Then
            Return (False, "Repair Advanced No එක Database එක තුලින් සොයා ගැනීමට නොහැකි වුණි.")
        End If

        Return (True, "")
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
                'If MsgBox("Repair Advanced Invoice එක print කිරීමට අවශ්‍යද?", vbYesNo) = vbYes Then
                    'PrintRepairAdvancedToolStripMenuItem_Click(sender, e)
                'End If
            Case UpdateMode.Edit
                Values.Add(New MySqlParameter("ADNO", txtAdNo.Text))
                Db.Execute("Update RepairAdvanced set ADDate=@DATE, RetNo=@RETNO, RepNo=@REPNO, Amount=@AMOUNT, Remarks=@REMARKS, UNo=@UNO Where AdNo=@ADNO;", Values.ToArray)
        End Select
        ButtonClose.PerformClick()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim Validator = DeleteValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
        End If

        Db.Execute("DELETE FROM RepairAdvanced WHERE AdNo=@ADNO;", {
            New MySqlParameter("ADNO", txtAdNo.Text)
        })
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub
End Class
