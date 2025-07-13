Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class ControlTechnicianLoanInfo
    Private Db As Database
    Private UpdateMode As UpdateMode

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
        ControlStockSelection.SetDatabase(Db)
        ControlTechnicianSelection.SetDatabase(Db)
    End Sub

    Public Sub SetUpdateMode(Mode As UpdateMode, Data As Dictionary(Of String, Object))
        ControlTechnicianSelection.SetTechnician(Data(Technician.TName))
        If Mode = UpdateMode.New Then
            TextNo.Text = Db.GetNextKey("TechnicianLoan", "TLNo")
            TextDate.Value = Today
            Return
        End If

        TextNo.Text = Data(TechnicianLoan.No)
        TextDate.Value = Data(TechnicianLoan.TLDate)
        ControlStockSelection.SCode = Data(TechnicianLoan.SNo)
        ControlStockSelection.SCategory = Data(TechnicianLoan.SCategory)
        ControlStockSelection.SName = Data(TechnicianLoan.SName)
        TextItemPrice.Value = Data(TechnicianLoan.Rate)
        TextQty.Text = Data(TechnicianLoan.Qty)
        TextAmount.Text = Data(TechnicianLoan.Total)
        TextReason.Text = Data(TechnicianLoan.TCRemarks)
        ButtonSave.Text = "Edit"
        ButtonDelete.Enabled = True
    End Sub

    Private Function SaveValidation() As ([Error] As Boolean, Message As String)
        If IsNumeric(TextAmount.Text) = False Then
            Return (False, "Amount Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.")
        ElseIf ControlStockSelection.SCode = 0 And String.IsNullOrWhiteSpace(TextReason.Text) Then
            Return (False, "Stock එකක් හෝ  Reason එකක් ඇතුලත් කරන්න.")
        ElseIf User.Instance.IsNonAdmin() And TextDate.Value.Date <> Today.Date Then
            Return (False, "අද දිනට නොමැති Technician Loan එකක් Update කෙරුණි.")
        End If

        Return (True, "")
    End Function

    Private Sub SaveTechnicianLoanRecord()
        Dim Parameters = {
                New MySqlParameter("TLNO", TextNo.Text),
                New MySqlParameter("TNO", ControlTechnicianSelection.GetTechnicianNo()),
                New MySqlParameter("TLDATE", TextDate.Value),
                New MySqlParameter("TLREASON", TextReason.Text),
                New MySqlParameter("RATE", TextItemPrice.Value),
                New MySqlParameter("QTY", TextQty.Value),
                New MySqlParameter("TOTAL", TextAmount.Value),
                New MySqlParameter("UNO", User.Instance.UserNo)
        }
        If ControlStockSelection.IsStockSelected Then
            Parameters = Parameters.Concat({
                New MySqlParameter("SNO", ControlStockSelection.SCode),
                New MySqlParameter("SCATEGORY", ControlStockSelection.SCategory),
                New MySqlParameter("SNAME", ControlStockSelection.SName)
            }).ToArray()
        Else
            Parameters = Parameters.Concat({
                New MySqlParameter("SNO", Nothing),
                New MySqlParameter("SCATEGORY", Nothing),
                New MySqlParameter("SNAME", Nothing)
            }).ToArray()
        End If

        Db.Execute($"INSERT INTO {Tables.TechnicianLoan}(TLNo,TNo,TLDate,SNo,SCategory,SName,TLReason,Rate,Qty,Total,UNo) Values(@TLNO,@TNO,@TLDATE,@SNO,@SCATEGORY,@SNAME,@TLREASON,@RATE,@QTY,@TOTAL,@UNO)", Parameters)
    End Sub

    Private Sub EditTechnicianLoanRecord()
        Dim Parameters = {
            New MySqlParameter("NO", TextNo.Text),
            New MySqlParameter("TNO", ControlTechnicianSelection.GetTechnicianNo()),
            New MySqlParameter("DATE", TextDate.Value),
            New MySqlParameter("SNO", ControlStockSelection.SCode),
            New MySqlParameter("SCATEGORY", ControlStockSelection.SCategory),
            New MySqlParameter("SNAME", ControlStockSelection.SName),
            New MySqlParameter("REASON", TextReason.Text),
            New MySqlParameter("RATE", TextItemPrice.Value),
            New MySqlParameter("QTY", TextQty.Value),
            New MySqlParameter("TOTAL", TextAmount.Value),
            New MySqlParameter("UNO", User.Instance.UserNo)
        }
        If ControlStockSelection.IsStockSelected Then
            Parameters = Parameters.Concat({
                New MySqlParameter("SNO", ControlStockSelection.SCode),
                New MySqlParameter("SCATEGORY", ControlStockSelection.SCategory),
                New MySqlParameter("SNAME", ControlStockSelection.SName)
            }).ToArray()
        Else
            Parameters = Parameters.Concat({
                New MySqlParameter("SNO", Nothing),
                New MySqlParameter("SCATEGORY", Nothing),
                New MySqlParameter("SNAME", Nothing)
            }).ToArray()
        End If

        Db.Execute($"UPDATE {Tables.TechnicianLoan} SET TNo=@TNO, TLDate=@DATE, SNo=@SNO, SCategory=@SCATEGORY, SName=@SNAME, TLReason=@REASON, Rate=@RATE, Qty=@QTY, Total=@TOTAL, UNo=@UNO WHERE @TLNo=@NO;", Parameters)
    End Sub

    Private Function DeleteValidation() As ([Error] As Boolean, Message As String)
        If User.Instance.IsNonAdmin() Then
            Return (False, "ඔබට Technician Loan දත්තය මකා දැමීමට අවසර නැත.")
        ElseIf IsNumeric(TextNo.Text) = False Then
            Return (False, "Technician Loan No එක ඇතුලත් කර නැත. කරුණාකර නැවත උත්සහ කරන්න.")
        End If

        Return (True, "")
    End Function

    Private Sub ControlStockSelection_StockChanged() Handles ControlStockSelection.StockChanged
        Dim Data = Db.GetDataDictionary($"SELECT {Stock.LowestPrice} FROM {Tables.Stock} WHERE SNo = @SNO;", {
            New MySqlParameter("SNO", ControlStockSelection.SCode)
        })
        If Data.Count = 0 Then
            Return
        End If

        TextItemPrice.Value = Data(Stock.LowestPrice)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim Validation = SaveValidation()
        If Not Validation.Error Then
            MessageBox.Error(SaveValidation.Message)
            Return
        End If

        Try
            If TextDate.Value.Date = Today.Date Then
                TextDate.Value = DateAndTime.Now
            End If

            If UpdateMode = UpdateMode.New Then
                SaveTechnicianLoanRecord()
                MessageBox.Success("Save Successfull!")
            ElseIf UpdateMode = UpdateMode.Edit Then

            End If
        Catch ex As Exception
            MessageBox.Error(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim Validation = DeleteValidation()
        If Validation.Error Then
            MessageBox.Error(Validation.Message)
            Return
        End If

        Dim QueryWithValues As New List(Of (Query As String, Parameters As MySqlParameter()))
        Try
            Dim Data = Db.GetDataDictionary("SELECT * FROM TechnicianLoan WHERE TLNo = @NO;", {
                New MySqlParameter("NO", TextNo.Text)
            })
            If Data.Count = 0 Then
                MsgBox("අදාල Technician Loan දත්තය Database එක තුලට ඇතුලත් කර නොමැත.", vbCritical)
                Return
            End If

            QueryWithValues.Add(($"DELETE FROM {Tables.TechnicianLoan} WHERE TCNo=@NO;", {New MySqlParameter("NO", TextNo.Text)}))
            If Not IsNumeric(Data(TechnicianLoan.SNo)) AndAlso MessageBox.Question("ඔබට මෙම Technician Loan record එක ඉවත් කිරීමට අවශ්‍ය ද?") = vbYes Then
                Return
            End If

            Dim Response = MsgBox("ඔබට මෙම Item එක Technician Cost තුලින් ඉවත් කිරිමට අවශ්‍ය බැවින්, එම Item එක නැවත Available Units තුලට පිරවීමට අවශ්‍යද? " + vbCr + vbCr + "Yes - එසෙ නම් ඔබ 'Yes' යන Button එක Click කරන්න. " + vbCr + vbCr + "No - නැතහොත්, ඔබට මෙම item එක Damaged Units වලට add කිරිමට අවශ්‍ය නම්, 'No' යන Button එක Click කරන්න." + vbCr + vbCr + "Cancel - ඔබට ඉවත් වීමට අවශ්‍ය නම් 'Cancel' යන Button එක Click කරන්න.", vbYesNoCancel + vbExclamation)
            If Response = vbYes Then
                QueryWithValues.Add(($"UPDATE {Tables.Stock} SET SAvailablestocks=(SAvailableStocks + @QTY) where SNo = @NO;", {
                    New MySqlParameter("QTY", TextQty.Value),
                    New MySqlParameter("NO", ControlStockSelection.SCode)
                }))
            ElseIf Response = vbNo Then
                QueryWithValues.Add(($"UPDATE {Tables.Stock} SET SOutofStocks=(SOutofStocks + @QTY) WHERE SNo=@NO", {
                    New MySqlParameter("QTY", TextQty.Value),
                    New MySqlParameter("NO", ControlStockSelection.SCode)
                }))
            End If
        Catch ex As Exception
            MessageBox.Error(ex.Message)
        Finally
            Db.ExecuteBatches(QueryWithValues.ToArray())
        End Try
    End Sub

    Private Sub cmdTLClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dispose()
    End Sub

    Private Sub TextQty_ValueChanged(sender As Object, e As EventArgs) Handles TextQty.ValueChanged, TextItemPrice.ValueChanged
        If IsNumeric(TextQty.Value) AndAlso IsNumeric(TextItemPrice.Value) Then
            TextAmount.Value = Convert.ToDecimal(TextQty.Value) * Convert.ToDecimal(TextItemPrice.Value)
        End If
    End Sub
End Class
