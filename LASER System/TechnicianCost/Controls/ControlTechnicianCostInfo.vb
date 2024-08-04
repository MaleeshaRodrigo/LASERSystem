Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlTechnicianCostInfo
    Public Event SubmitEvent()

    Private Db As Database
    Private UpdateMode As UpdateMode

    Public Function Init(UpdateMode As UpdateMode, Optional TechnicianCostData As Dictionary(Of String, Object) = Nothing) As ControlTechnicianCostInfo
        Me.UpdateMode = UpdateMode
        If UpdateMode = UpdateMode.Edit Then
            TextTechnicianCostNo.Text = TechnicianCostData(TechnicianCostGridColumns.No)
            PickerDate.Value = TechnicianCostData(TechnicianCostGridColumns.Date)
            ControlTechnicianSelection.SetTechnician(TechnicianCostData("TName"))
            ControlStockSelection.SCode = TechnicianCostData(TechnicianCostGridColumns.StockNo)
            ControlStockSelection.SCategory = TechnicianCostData(TechnicianCostGridColumns.StockCategory)
            ControlStockSelection.SName = TechnicianCostData(TechnicianCostGridColumns.StockName)
            If Not String.IsNullOrEmpty(TechnicianCostData(TechnicianCostGridColumns.RepairNo)) Then
                ControlRepairReRepairSelection.SetRepair(TechnicianCostData(TechnicianCostGridColumns.RepairNo))
            ElseIf Not String.IsNullOrEmpty(TechnicianCostData(TechnicianCostGridColumns.ReRepairNo)) Then
                ControlRepairReRepairSelection.SetReRepair(TechnicianCostData(TechnicianCostGridColumns.ReRepairNo))
            End If
            TextRate.Value = TechnicianCostData(TechnicianCostGridColumns.Rate)
            TextQty.Value = TechnicianCostData(TechnicianCostGridColumns.Qty)
            TextTotal.Value = TechnicianCostData(TechnicianCostGridColumns.Total)
            TextRemarks.Text = TechnicianCostData(TechnicianCostGridColumns.Remarks)
        Else
            TextTechnicianCostNo.Text = Db.GetNextKey(Tables.TechnicianCost, "TCNo")
            ButtonDelete.Enabled = False
        End If

        Return Me
    End Function

    Public Function SetDatabase(Db As Database) As ControlTechnicianCostInfo
        Me.Db = Db
        ControlTechnicianSelection.SetDatabase(Db)
        ControlStockSelection.SetDatabase(Db)
        ControlRepairReRepairSelection.SetDatabase(Db)
        Return Me
    End Function

    Public Function SetTechnician(Name As String) As ControlTechnicianCostInfo
        ControlTechnicianSelection.SetTechnician(Name)
        Return Me
    End Function

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim Validator = SaveValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
            Exit Sub
        End If

        Dim Values As New List(Of MySqlParameter) From {
            New MySqlParameter("TCDATE", PickerDate.Value),
            New MySqlParameter("TNO", ControlTechnicianSelection.GetTechnicianNo),
            New MySqlParameter("SNO", ControlStockSelection.SCode),
            New MySqlParameter("SCATEGORY", ControlStockSelection.SCategory),
            New MySqlParameter("SNAME", ControlStockSelection.SName),
            New MySqlParameter("RATE", TextRate.Value),
            New MySqlParameter("QTY", TextQty.Value),
            New MySqlParameter("TOTAL", TextTotal.Value),
            New MySqlParameter("REMARKS", TextRemarks.Text),
            New MySqlParameter("UNO", User.Instance.UserNo)
        }
        If ControlRepairReRepairSelection.RepairMode = RepairMode.Repair And ControlRepairReRepairSelection.Value <> 0 Then
            Values.AddRange({
                New MySqlParameter("REPNO", ControlRepairReRepairSelection.Value),
                New MySqlParameter("RETNO", Nothing)
            })
        ElseIf ControlRepairReRepairSelection.RepairMode = RepairMode.ReRepair And ControlRepairReRepairSelection.Value <> 0 Then
            Values.AddRange({
                New MySqlParameter("REPNO", Nothing),
                New MySqlParameter("RETNO", ControlRepairReRepairSelection.Value)
            })
        Else
            Values.AddRange({
                New MySqlParameter("REPNO", Nothing),
                New MySqlParameter("RETNO", Nothing)
            })
        End If
        If UpdateMode = UpdateMode.New Then
            Db.Execute("INSERT INTO TechnicianCost(TCDate, TNo, RepNo, RetNo, SNo, SCategory, SName, Rate, Qty, Total, TCRemarks, UNo) VALUES(@TCDATE, @TNO, @REPNO, @RETNO, @SNO, @SCATEGORY, @SNAME, @RATE, @QTY, @TOTAL, @REMARKS, @UNO);", Values.ToArray)
        Else
            Values.Add(New MySqlParameter("TCNO", TextTechnicianCostNo.Text))
            Db.Execute("UPDATE TechnicianCost SET TCDate=@TCDATE, TNo=@TNO, RepNo=@REPNO, RetNo=@RETNO, SNo=@SNO, SCategory=@SCATEGORY, SName=@SNAME, Rate=@RATE, Qty=@QTY, Total=@TOTAL, TCRemarks=@REMARKS, UNo=@UNO WHERE TCNo=@TCNO;", Values.ToArray)
        End If

        RaiseEvent SubmitEvent()
        ButtonClose.PerformClick()
    End Sub

    Private Function SaveValidation() As (Status As Boolean, Message As String)
        If ControlTechnicianSelection.GetTechnicianNo = Nothing Then
            Return (False, "Technician Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
        End If
        If User.Instance.UserType = User.Type.Cashier AndAlso PickerDate.Value.Date <> Today.Date Then
            Return (False, "අද දිනට නොමැති Technician Cost Data එකක් Update කිරීමට ඔබට Permission ලබා දී නොමැත.")
        End If
        If ControlStockSelection.SCode = Nothing And TextRemarks.Text.Trim = "" Then
            Return (False, "Stock සහ  Remarks යන fields දෙකම හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
        End If

        Return (True, "")
    End Function

    Private Sub TextQty_ValueChanged(sender As Object, e As EventArgs) Handles TextQty.ValueChanged, TextRate.ValueChanged
        If IsNumeric(TextQty.Value) And IsNumeric(TextRate.Value) Then
            TextTotal.Value = Val(TextQty.Value) * Val(TextRate.Value)
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim Validator = DeleteValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
            Exit Sub
        End If
        If Not MessageBox.Question("මෙම Record එක Delete කිරීමට තහවුරු කරන්න.") = vbYes Then
            Exit Sub
        End If

        Db.Execute("DELETE FROM TechnicianCost WHERE TCNo = @TCNO;", {
            New MySqlParameter("TCNO", TextTechnicianCostNo.Text)
        })
    End Sub

    Private Function DeleteValidation() As (Status As Boolean, Message As String)
        If User.Instance.UserType <> User.Type.Admin Then
            Return (False, "ඔබට මෙම Record එක Delete කිරීමට Permission නොමැත.")
        End If
        If String.IsNullOrEmpty(TextTechnicianCostNo.Text) Then
            Return (False, "Technician Cost Record එකක් තෝරා නොමැත.")
        End If
        If Not Db.CheckDataExists("TechnicianCost", "TCNo", TextTechnicianCostNo.Text) Then
            Return (False, "Technician Cost Record එක Database එක තුලින් සොයා  ගැනීමට නොහැකි විය.")
        End If

        Return (True, "")
    End Function
End Class
