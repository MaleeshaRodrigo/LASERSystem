Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class FormRepairAdvance
    Private Db As New Database
    Private ControlRepairAdvanceInfo As ControlRepairAdvanceInfo

    Public Sub Print(AdvanceNo As Integer, Mode As RepairMode)
        Dim Validator = PrintValidation(AdvanceNo)
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
            If Mode = RepairMode.Repair Then
                DataAdapter = Db.GetDataAdapter(Connection, "SELECT CuName,CuTelNo1,CuTelNo2,CuTelNo3,ADDate,Rep.RepNo,Ret.RetNo,PCategory,PName,Amount FROM (((((RepairAdvanced AD LEFT JOIN Repair Rep On Rep.RepNo=AD.RepNo) LEFT JOIN `Return` Ret On Ret.RetNo=AD.RetNo) LEFT JOIN Product P ON P.PNo = Rep.PNo) LEFT JOIN Receive R ON R.RNo = Rep.RNo) LEFT JOIN Customer Cu ON Cu.CuNo=R.CuNo) Where ADNo=@ADNO;", {
                    New MySqlParameter("ADNO", AdvanceNo)
                })
            Else
                DataAdapter = Db.GetDataAdapter(Connection, "SELECT CuName,CuTelNo1,CuTelNo2,CuTelNo3,ADDate,Rep.RepNo,Ret.RetNo,PCategory,PName,Amount FROM (((((RepairAdvanced AD LEFT JOIN `Return` Ret On Ret.RetNo=AD.RetNo) LEFT JOIN Repair Rep On Rep.RepNo=Ret.RepNo) LEft Join Product P ON P.PNo = Rep.PNo) LEFT JOIN Receive R ON R.RNo = Rep.RNo) LEFT JOIN Customer Cu ON Cu.CuNo=R.CuNo) Where ADNo=@ADNO;", {
                    New MySqlParameter("ADNO", AdvanceNo)
                })
            End If
            DataAdapter.Fill(DataSet, "Repair")
            DataAdapter.Fill(DataSet, "Product")
            DataAdapter.Fill(DataSet, "Return")
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
            Throw ex
        Finally
            Connection.Close()
            Report.Close()
            DataSet.Clear()
        End Try
    End Sub

    Private Function PrintValidation(AdvanceNo As Integer) As (Status As Boolean, Message As String)
        If AdvanceNo = 0 Then
            Return (False, "Repair Advanced No එක හිස්ව පවතියි.")
        ElseIf Not Db.CheckDataExists(Tables.RepairAdvanced, RepairAdvanced.ADNo, AdvanceNo) Then
            Return (False, "Repair Advanced No එක Database එක තුලින් සොයා ගැනීමට නොහැකි වුණි.")
        End If

        Return (True, "")
    End Function

    Private Sub ControlRepairAdvanceInfo_Submit()
        cmdSearch.PerformClick()
    End Sub

    Private Sub frmRepairAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilter.Text = "All"
        cmdSearch.PerformClick()
        If User.Instance.UserType = User.Type.Admin Then
            grdRepAdvanced.Columns(0).Visible = True
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim Search As String = "Where "
        Select Case cmbFilter.Text
            Case "Date"
                Search += "ADDate like '%" & txtSearch.Text & "%'"
            Case "Repair No"
                Search += "RepNo like '%" & txtSearch.Text & "%'"
            Case "RE-Repair No"
                Search += "RetNo like '%" & txtSearch.Text & "%'"
            Case "Amount"
                Search += "Amount like '%" & txtSearch.Text & "%'"
            Case "Remarks"
                Search += "Remarks like '%" & txtSearch.Text & "%'"
            Case "All"
                Search += "ADDate like '%" & txtSearch.Text & "%' or RepNo like '%" & txtSearch.Text & "%' or RetNo like '%" & txtSearch.Text & "%' or Amount like '%" & txtSearch.Text & "%' or Remarks like '%" & txtSearch.Text & "%'"
        End Select
        grdRepAdvanced.DataSource = Db.GetDataTable($"Select ADNo, ADDate, RepNo, RetNo, Amount, Remarks, U.UserName as 'User' from RepairAdvanced AD LEFT JOIN `User` U ON U.UNo = AD.UNo {Search} ORDER BY ADDate DESC;")
    End Sub

    Private Sub grdRepAdvanced_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepAdvanced.CellDoubleClick
        If e.RowIndex < 0 OrElse grdRepAdvanced.Item(0, e.RowIndex).Value Is Nothing Then
            Exit Sub
        End If

        ControlRepairAdvanceInfo = New ControlRepairAdvanceInfo With {
            .Dock = DockStyle.Fill
        }
        ControlRepairAdvanceInfo.SetDatabase(Db).SetData(New Dictionary(Of String, Object) From {
            {RepairAdvanced.ADNo, grdRepAdvanced(RepairAdvanced.ADNo, e.RowIndex).Value},
            {RepairAdvanced.ADDate, grdRepAdvanced(RepairAdvanced.ADDate, e.RowIndex).Value},
            {RepairAdvanced.RepNo, grdRepAdvanced(RepairAdvanced.RepNo, e.RowIndex).Value},
            {RepairAdvanced.RetNo, grdRepAdvanced(RepairAdvanced.RetNo, e.RowIndex).Value},
            {RepairAdvanced.Amount, grdRepAdvanced(RepairAdvanced.Amount, e.RowIndex).Value},
            {RepairAdvanced.Remarks, grdRepAdvanced(RepairAdvanced.Remarks, e.RowIndex).Value}
        })
        ControlRepairAdvanceInfo.Mode = UpdateMode.Edit
        Me.Controls.Add(ControlRepairAdvanceInfo)
        ControlRepairAdvanceInfo.BringToFront()

        AddHandler ControlRepairAdvanceInfo.SubmitEvent, AddressOf ControlRepairAdvanceInfo_Submit
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        ControlRepairAdvanceInfo = New ControlRepairAdvanceInfo With {
            .Dock = DockStyle.Fill
        }
        ControlRepairAdvanceInfo.SetDatabase(Db)
        Me.Controls.Add(ControlRepairAdvanceInfo)
        ControlRepairAdvanceInfo.BringToFront()

        AddHandler ControlRepairAdvanceInfo.SubmitEvent, AddressOf ControlRepairAdvanceInfo_Submit
    End Sub

    Private Sub PrintRepairAdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRepairAdvancedToolStripMenuItem.Click
        If grdRepAdvanced.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        If Not IsNumeric(grdRepAdvanced.SelectedRows.Item(0).Cells(RepairAdvanced.ADNo).Value) Then
            Exit Sub
        End If

        Dim Mode As RepairMode
        If IsNumeric(grdRepAdvanced.SelectedRows.Item(0).Cells(RepairAdvanced.RepNo).Value) AndAlso grdRepAdvanced.SelectedRows.Item(0).Cells(RepairAdvanced.RepNo).Value <> 0 Then
            Mode = RepairMode.Repair
        Else
            Mode = RepairMode.ReRepair
        End If

        Print(grdRepAdvanced.SelectedRows.Item(0).Cells(RepairAdvanced.ADNo).Value, Mode)
    End Sub
End Class