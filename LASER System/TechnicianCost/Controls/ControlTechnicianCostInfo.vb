Imports MySqlConnector

Public Class ControlTechnicianCostInfo
    Private Db As Database

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Dispose()
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim Validator = SaveValidation()
        If Not Validator.Status Then
            MessageBox.Error(Validator.Message)
            Exit Sub
        End If

        Db.Execute("INSERT INTO TechnicianCost(TCDate, TNo, RepNo, RetNo, SNo, SCategory, SName, Rate, Qty, Total, TCRemarks, UNo) VALUES(@TCDATE, @TNO, @REPNO, @RETNO, @SNO, @SCATEGORY, @SNAME, @RATE, @QTY, @TOTAL, @REMARKS, @UNO) ON DUPLICATE KEY UPDATE TCDate=VALUES(TCDate), TNo=VALUES(TNo), RepNo=VALUES(RepNo), RetNo=VALUES(RetNo), SNo=VALUES(SNo), SCategory=VALUES(SCategory), SName=VALUES(SName), Qty=VALUES(Qty), Total=VALUES(Total), TCRemarks=VALUES(TCRemarks), UNo=VALUES(UNo);", {
            New MySqlParameter("TCDATE", PickerDate.Value),
            New MySqlParameter("TNO", ComboTechnician.Text),
            New MySqlParameter("REPNO",),
            New MySqlParameter("RETNO",),
            New MySqlParameter("SNO",),
            New MySqlParameter("SCATEGORY",),
            New MySqlParameter("SNAME",),
            New MySqlParameter("RATE",),
            New MySqlParameter("QTY",),
            New MySqlParameter("TOTAL",),
            New MySqlParameter("REMARKS",),
            New MySqlParameter("UNO",)
        })
        If grdTechnicianCost.Item(5, e.RowIndex).Value IsNot Nothing And grdTechnicianCost.Item(6, e.RowIndex).Value IsNot Nothing Then
            grdTechnicianCost.Item(7, e.RowIndex).Value = Val(grdTechnicianCost.Item(5, e.RowIndex).Value) *
                Val(grdTechnicianCost.Item(6, e.RowIndex).Value)
            tmp = ",Total=" & grdTechnicianCost.Item(7, e.RowIndex).Value
        Else
            grdTechnicianCost.Item(7, e.RowIndex).Value = "0"
        End If
        Case 9
        grdTechnicianCost.Item(10, e.RowIndex).Value = ""
        tmp += ",RepNo=NULL"
        Case 10
        grdTechnicianCost.Item(9, e.RowIndex).Value = ""
        tmp += ",RetNo=NULL"
        End Select
        If grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value Then
            Exit Sub
        End If
        If e.RowIndex = (grdTechnicianCost.Rows.Count - 1) Then Exit Sub
        If grdTechnicianCost.Item(1, e.RowIndex).Value Is Nothing Then
            grdTechnicianCost.Item(1, e.RowIndex).Value = DateAndTime.Now
            tmp += ",TCDate='" & grdTechnicianCost.Item(1, e.RowIndex).Value & "'"
        End If
        If grdTechnicianCost.Item(11, e.RowIndex).Value Is Nothing Or
            grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value IsNot grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag Then
            grdTechnicianCost.Item(11, e.RowIndex).Value = User.Instance.UserName
            tmp += ",UNo=" & User.Instance.UserNo
        End If
        If grdTechnicianCost.Item("Total", e.RowIndex).Value Is Nothing OrElse
            grdTechnicianCost.Item("Total", e.RowIndex).Value.ToString = "" Then grdTechnicianCost.Item("Total", e.RowIndex).Value = "0"
        If grdTechnicianCost.Item(0, e.RowIndex).Value Is Nothing Then
            grdTechnicianCost.Item(0, e.RowIndex).Value = Db.GetNextKey("TechnicianCost", "TCNo")
        End If
        If Db.CheckDataExists("TechnicianCost", "TCNo", grdTechnicianCost.Item(0, e.RowIndex).Value) = False Then Db.Execute("Insert into TechnicianCost(TCNo,TNo,Rate,Qty,Total,UNo) Values(" & grdTechnicianCost.Item(0, e.RowIndex).Value & "," &
                      Db.GetData("Select TNo from Technician Where TName='" & cmbTName.Text & "'") & ",0,0,0," & User.Instance.UserNo & ")")
        If Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Value).Date <> Today.Date Then
            AdminPer.AdminSend = True
        End If
        Select Case e.ColumnIndex
            Case 1
                Db.Execute("Update TechnicianCost set " & grdTechnicianCost.Columns(e.ColumnIndex).DataPropertyName & "='" &
                          grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value & "' " & tmp & " Where TCNo=" &
                          grdTechnicianCost.Item(0, e.RowIndex).Value, {}, AdminPer)
            Case 2, 5, 6, 7, 9, 10
                Db.Execute("Update TechnicianCost set " & grdTechnicianCost.Columns(e.ColumnIndex).DataPropertyName & "=" &
                          grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value & " " & tmp & " Where TCNo=" &
                          grdTechnicianCost.Item(0, e.RowIndex).Value, {}, AdminPer)
            Case 3, 4, 8
                Db.Execute("Update TechnicianCost set " & grdTechnicianCost.Columns(e.ColumnIndex).DataPropertyName & "='" &
                          grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value & "' " & tmp & " Where TCNo=" &
                          grdTechnicianCost.Item(0, e.RowIndex).Value, {}, AdminPer)
        End Select
        grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = ""
        cmdTCSearch_Click(sender, e)
    End Sub

    Private Function SaveValidation() As (Status As Boolean, Message As String)
        If ComboTechnician.Text.Trim() = "" Then
            Return (False, "Technician Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.")
        End If
        If User.Instance.UserType = User.Type.Cashier AndAlso PickerDate.Value.Date <> Today.Date Then
            Return (False, "අද දිනට නොමැති Technician Cost Data එකක් Update කිරීමට ඔබට Permission ලබා දී නොමැත.")
        End If

        Return (True, "")
    End Function
End Class
