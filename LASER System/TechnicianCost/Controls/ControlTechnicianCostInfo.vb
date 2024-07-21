Imports MySqlConnector

Public Class ControlTechnicianCostInfo
    Private Db As Database
    Private UpdateMode As UpdateMode

    Public Function Init(UpdateMode As UpdateMode, Optional TechnicianCostNo As Integer = Nothing) As ControlTechnicianCostInfo
        Me.UpdateMode = UpdateMode
        If UpdateMode = UpdateMode.Edit Then
            TextTechnicianCostNo.Text = TechnicianCostNo
        Else
            TextTechnicianCostNo.Text = Db.GetNextKey("TechnicianCost", "TCNo")
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
            New MySqlParameter("SNO", ControlStockSelection.GetStockNo),
            New MySqlParameter("SCATEGORY", ControlStockSelection.SCategory),
            New MySqlParameter("SNAME", ControlStockSelection.SName),
            New MySqlParameter("RATE", TextRate.Value),
            New MySqlParameter("QTY", TextQty.Value),
            New MySqlParameter("TOTAL", TextTotal.Value),
            New MySqlParameter("REMARKS", TextRemarks.Text),
            New MySqlParameter("UNO", User.Instance.UserNo)
        }
        If ControlRepairReRepairSelection.RepairMode = RepairMode.Repair Then
            Values.AddRange({
                New MySqlParameter("REPNO", ControlRepairReRepairSelection.Value),
                New MySqlParameter("RETNO", Nothing)
            })
        Else
            Values.AddRange({
                New MySqlParameter("REPNO", Nothing),
                New MySqlParameter("RETNO", ControlRepairReRepairSelection.Value)
            })
        End If
        If UpdateMode = UpdateMode.New Then
            Db.Execute("INSERT INTO TechnicianCost(TCDate, TNo, RepNo, RetNo, SNo, SCategory, SName, Rate, Qty, Total, TCRemarks, UNo) VALUES(@TCDATE, @TNO, @REPNO, @RETNO, @SNO, @SCATEGORY, @SNAME, @RATE, @QTY, @TOTAL, @REMARKS, @UNO);", Values.ToArray)
        Else
            Values.Append(New MySqlParameter("TCNO", TextTechnicianCostNo.Text))
            Db.Execute("UPDATE TechnicianCost SET TCDate=@TCDATE, TNo=@TNO, RepNo=@REPNO, RetNo=@RETNO, SNo=@SNO, SCategory=@SCATEGORY, SName=@SNAME, Rate=@RATE, Qty=@QTY, Total=@TOTAL, TCRemarks=@TCREMARKS, UNo=@UNO WHERE TCNo=@TCNO;", Values.ToArray)
        End If
        ButtonClose.PerformClick()
    End Sub

    Private Function SaveValidation() As (Status As Boolean, Message As String)
        If ControlTechnicianSelection.GetTechnicianNo = Nothing Then
            Return (False, "Technician Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
        End If
        If User.Instance.UserType = User.Type.Cashier AndAlso PickerDate.Value.Date <> Today.Date Then
            Return (False, "අද දිනට නොමැති Technician Cost Data එකක් Update කිරීමට ඔබට Permission ලබා දී නොමැත.")
        End If

        Return (True, "")
    End Function

    Private Sub TextQty_ValueChanged(sender As Object, e As EventArgs) Handles TextQty.ValueChanged, TextRate.ValueChanged
        If IsNumeric(TextQty.Value) And IsNumeric(TextRate.Value) Then
            TextTotal.Value = Val(TextQty.Value) * Val(TextRate.Value)
        End If
    End Sub
End Class
