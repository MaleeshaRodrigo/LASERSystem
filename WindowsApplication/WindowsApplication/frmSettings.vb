Imports System.IO
Imports System.Net.Mail
Public Class FrmSettings
    Public Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With My.Settings
            txtDBLoc.Text = .DatabaseCNN
            txtDBLoc.Tag = .DatabaseCNN
            chkMSetEmail.Checked = .SendSettlementEmail
            txtMAdminEmail.Text = .AdminEmail
            txtStickerPrinterName.Text = .StickerPrinterName
            txtStickerStockPaperName.Text = .StockStickerPaperName
            txtStickerRepairPaperName.Text = .RepairStickerPrinterPaperName
            txtBillPrinterName.Text = .BillPrinterName
            txtBillPaperName.Text = .BillPrinterPaperName
            cmbDBProvider.Text = .DBProvider

            cmbBSCOMPort1_DropDown(sender, e)
            chkBSCOMMode.Checked = .BarcodeScannerCOMMode
            cmbBSCOMPort.Text = .BarcodeScannerCOMPort1.ToString
            txtBSBaudRate.Text = .BarcodeScannerBaudRate.ToString
            chkBSCOMMode_CheckedChanged(sender, e)
            chkDeliveredEmailtoT.Checked = .DeliveredEmailtoT
        End With
    End Sub

    Private Sub FrmSettings_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        If CheckEmptyfieldtxt(txtDBLoc, "Database Location field is empty, Please select the database!") = False Then
            tpDatabase.Select()
            Exit Sub
        ElseIf File.Exists(txtDBLoc.Text) = False Then
            MsgBox("This file name couldn't be found. Please select correct file for using a database", vbExclamation + vbOKOnly)
            Exit Sub
        End If

        With My.Settings
            .DatabaseCNN = txtDBLoc.Text
            .SendSettlementEmail = chkMSetEmail.CheckState
            .DeliveredEmailtoT = chkDeliveredEmailtoT.Checked
            .AdminEmail = txtMAdminEmail.Text
            .StickerPrinterName = txtStickerPrinterName.Text
            .StockStickerPaperName = txtStickerStockPaperName.Text
            .RepairStickerPrinterPaperName = txtStickerRepairPaperName.Text
            .BillPrinterName = txtBillPrinterName.Text
            .BillPrinterPaperName = txtBillPaperName.Text
            .BarcodeScannerCOMMode = chkBSCOMMode.Checked
            .BarcodeScannerCOMPort1 = cmbBSCOMPort.Text
            .BarcodeScannerBaudRate = Int(txtBSBaudRate.Text)
            .DBPassword = Simple.Encode(txtDBPassword.Text)
            .DBProvider = cmbDBProvider.Text
            .Save()

            MdifrmMain.BarCodePort.Close()
            If chkBSCOMMode.Checked Then
                If My.Settings.BarcodeScannerCOMPort1 <> "" And
                    IO.Ports.SerialPort.GetPortNames.Contains(My.Settings.BarcodeScannerCOMPort1) Then
                    MdifrmMain.BarCodePort.BaudRate = txtBSBaudRate.Text
                    MdifrmMain.BarCodePort.PortName = cmbBSCOMPort.Text
                    MdifrmMain.BarCodePort.Open()
                End If
            End If
        End With

        If Me.Tag = "Login" Then
            GetCNN()
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        CmdApply_Click(sender, e)
        If txtDBLoc.Tag <> txtDBLoc.Text Then
            Application.Restart()
        Else
            FrmSettings_Leave(sender, e)
        End If
    End Sub

    Private Sub cmdDBLocation_Click(sender As Object, e As EventArgs) Handles cmdDBLocation.Click
        ofdDatabase.Title = "Please select the Database file"
        ofdDatabase.InitialDirectory = Application.StartupPath
        ofdDatabase.Filter = "DB Files|*.accdb|DB (old) Files|*.mdb"
        If ofdDatabase.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtDBLoc.Text = ofdDatabase.FileName
        End If
    End Sub

    Private Sub cmdUACheck_Click(sender As Object, e As EventArgs) Handles cmdUACheck.Click
        CMD = New OleDb.OleDbCommand("Select * from [User] Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "' and Type='Admin';", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            grpUAUser.Enabled = True
            grdUAUser.Enabled = True
            Dim DT As New DataTable
            DA = New OleDb.OleDbDataAdapter("Select UNo,UserName,Type,Email from [User]", CNN)
            DA.Fill(DT)
            grdUAUser.DataSource = DT
            cmdUANew_Click(sender, e)
        Else
            grpUAUser.Enabled = False
            grdUAUser.Enabled = False
            If grpUAUser.Tag Is Nothing Then grpUAUser.Tag = "0"
            grpUAUser.Tag += 1
            If Int(grpUAUser.Tag) > 3 Then
                grpUAAdmin.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmdUANew_Click(sender As Object, e As EventArgs) Handles cmdUANew.Click
        txtUAUserName.Text = ""
        txtUACurrentPW.Text = ""
        txtUANewPW.Text = ""
        txtUAReenterPW.Text = ""
        txtUAEmail.Text = ""
        cmbUAType.Text = ""
        txtUACurrentPW.Visible = False
        lblUACurrentPW.Visible = False
        txtUANewPW.Top = txtUAUserName.Top + txtUAUserName.Height + 5
        txtUAReenterPW.Top = txtUANewPW.Top + txtUANewPW.Height + 5
        txtUAEmail.Top = txtUAReenterPW.Top + txtUAReenterPW.Height + 5
        cmdUASave.Top = txtUAEmail.Top + txtUAEmail.Height + 5
        cmdUANew.Top = cmdUASave.Top
        cmdUADelete.Top = cmdUASave.Top
        lblUANewPW.Top = txtUANewPW.Top
        lblUAReenterPW.Top = txtUAReenterPW.Top
        lblUAEmail.Top = txtUAEmail.Top
        cmdUASave.Text = "Save"
        cmdUADelete.Enabled = False
        AutomaticPrimaryKey(txtUAUNo, "Select Top 1 UNo from [User] Order by UNo Desc;", "Uno")
    End Sub

    Private Sub cmdUASave_Click(sender As Object, e As EventArgs) Handles cmdUASave.Click
        CMD = New OleDb.OleDbCommand("Select * from [User] Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "'", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = False Then
            MsgBox("Admin සදහා ලබා දුන් User Name සහ Password එක වැරදිය.", vbExclamation + vbOKOnly)
            Exit Sub
        ElseIf CheckEmptyfieldtxt(txtUAUserName, "User Name යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyfieldtxt(txtUANewPW, "New Password යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyfieldtxt(txtUAReenterPW, "Reenter Password යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyfieldcmb(cmbUAType, "User Type යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf txtUANewPW.Text <> txtUAReenterPW.Text Then
            MsgBox("New Password හා Reenter Password යන Field එක එකිනෙකට නොගැලපෙයි. එය නැවත පරිකෂා කරන්න.", vbExclamation + vbOKOnly)
            txtUANewPW.Focus()
            Exit Sub
        ElseIf txtUANewPW.Text.Length < 8 Then
            MsgBox("Password එක සඳහා Characters 8 කට වඩා වැඩි ප්‍රමාණයක් යොදා ගන්න.", vbExclamation + vbOKOnly)
            txtUANewPW.Focus()
            Exit Sub
        ElseIf txtUAUNo.Text = "" Then
            If cmdUASave.Text = "Save" Then
                AutomaticPrimaryKey(txtUAUNo, "Select Top 1 UNo from [User] Order by UNo Desc;", "Uno")
            Else
                MsgBox("ඔබ අදාල User ව නිවැරදිව තෝරා ගෙන නොමැත. නැවත උත්සහ කරන්න.")
                grdUAUser.Focus()
                Exit Sub
            End If
        ElseIf txtUANewPW.Text Like "*[A-Z]*" Then
            MsgBox("Password එක සඳහා Capital Character එකක් හෝ වැඩි ගණනක් යොදාගන්න.", vbExclamation + vbOKOnly)
            txtUANewPW.Focus()
            Exit Sub
        End If
        Select Case cmdUASave.Text
            Case "Save"
                CMDUPDATE("Insert Into [User]([UNo],[UserName],[Password],[Type],[Email]) Values(" & txtUAUNo.Text & ",'" & txtUAUserName.Text & "','" &
                          txtUANewPW.Text & "','" & cmbUAType.Text & "','" & txtUAEmail.Text & "');")
            Case "Edit"
                If CheckEmptyfieldtxt(txtUACurrentPW, "Current Password යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
                    Exit Sub
                End If
                CMD = New OleDb.OleDbCommand("Select * from [User] Where UNO=" & txtUAUNo.Text & " and Password='" & txtUACurrentPW.Text & "';", CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows = False Then
                    MsgBox("Current Password එක සඳහා ඇතුලත් කල අගය වැරදියි. නැවත උත්සහ කරන්න.", vbExclamation + vbOKOnly)
                    txtUAUserName.Focus()
                    Exit Sub
                End If
                CMDUPDATE("Update [User] set UserName='" & txtUAUserName.Text &
                          "',Password='" & txtUANewPW.Text &
                          "',Type='" & cmbUAType.Text &
                          "',Email='" & txtUAEmail.Text & "' Where UNo=" & txtUAUNo.Text)
        End Select
    End Sub

    Private Sub grdUAUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdUAUser.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        CMD = New OleDb.OleDbCommand("Select * from [User] Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "'", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = False Then
            MsgBox("Admin සදහා ලබා දුන් User Name සහ Password එක වැරදිය.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        CMD = New OleDb.OleDbCommand("Select * from [User] Where UNo=" & grdUAUser.Item(UAUNo.Index, e.RowIndex).Value, CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            txtUAUNo.Text = DR("UNo").ToString
            cmbUAType.Text = DR("Type").ToString
            txtUAUserName.Text = DR("UserName").ToString
            txtUAEmail.Text = DR("Email").ToString
        End If

        txtUACurrentPW.Visible = True
        lblUACurrentPW.Visible = True
        txtUANewPW.Top = txtUACurrentPW.Top + txtUACurrentPW.Height + 5
        txtUAReenterPW.Top = txtUANewPW.Top + txtUANewPW.Height + 5
        txtUAEmail.Top = txtUAReenterPW.Top + txtUAReenterPW.Height + 5
        cmdUASave.Top = txtUAEmail.Top + txtUAEmail.Height + 5
        cmdUANew.Top = cmdUASave.Top
        cmdUADelete.Top = cmdUASave.Top
        lblUANewPW.Top = txtUANewPW.Top
        lblUAReenterPW.Top = txtUAReenterPW.Top
        lblUAEmail.Top = txtUAEmail.Top
        cmdUADelete.Enabled = True
        cmdUASave.Text = "Edit"
    End Sub

    Private Sub cmdUADelete_Click(sender As Object, e As EventArgs) Handles cmdUADelete.Click
        CMD = New OleDb.OleDbCommand("Select * from [User] Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "'", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = False Then
            MsgBox("Admin සදහා ලබා දුන් fUser Name සහ Password එක වැරදිය.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        CMD = New OleDb.OleDbCommand("Select * from [User] Where UNo =" & txtUAUNo.Text, CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = False Then
            MsgBox("ඔබ අදාල User ව නිවැරදිව තෝරා ගෙන නොමැත. නැවත උත්සහ කරන්න.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        CMDUPDATE("DELETE from [User] where UNo=" & txtUAUNo.Text)
    End Sub

    Private Sub txtMEmailTime_KeyPress(sender As Object, e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub chkBSCOMMode_CheckedChanged(sender As Object, e As EventArgs) Handles chkBSCOMMode.CheckedChanged
        If chkBSCOMMode.Checked = True Then
            cmbBSCOMPort.Enabled = True
            txtBSBaudRate.Enabled = True
            cmbBSCOMPort1_DropDown(sender, e)
        Else
            cmbBSCOMPort.Enabled = False
            txtBSBaudRate.Enabled = False
        End If
    End Sub

    Private Sub cmbBSCOMPort1_DropDown(sender As Object, e As EventArgs) Handles cmbBSCOMPort.DropDown
        cmbBSCOMPort.Items.Clear()
        Dim myPort As Array
        myPort = IO.Ports.SerialPort.GetPortNames
        For Each StrPort As String In myPort
            cmbBSCOMPort.Items.Add(StrPort)
        Next
    End Sub
End Class