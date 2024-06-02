Imports MySqlConnector
Imports System.IO

Public Class FrmSettings
    Private Db As New Database
    Private BoolApplyError As Boolean 'Represent there is an error in apply function

    Public Sub New()
        InitializeComponent()

        BoolApplyError = False
    End Sub
    Public Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Db.CheckConnection().Valid Then
            
        End If
        With My.Settings
            TextDbServer.Text = .DBServer
            TextDBUserName.Text = .DBUserName
            TextDBName.Text = .DBName
            TextDBPort.Text = .DBPort
            chkMSetEmail.Checked = .SendSettlementEmail
            txtMAdminEmail.Text = .AdminEmail
            txtStickerPrinterName.Text = .StickerPrinterName
            txtStickerStockPaperName.Text = .StockStickerPaperName
            txtStickerRepairPaperName.Text = .RepairStickerPrinterPaperName
            txtBillPrinterName.Text = .BillPrinterName
            txtBillPaperName.Text = .BillPrinterPaperName
            TxtBGWokerPath.Text = .BGWorkerPath
            ChkCashDrawer.Checked = .CashDrawer

            chkBSCOMMode.Checked = .BarcodeScannerCOMMode
            cmbBSCOMPort.Text = .BarcodeScannerCOMPort1.ToString
            txtBSBaudRate.Text = .BarcodeScannerBaudRate.ToString
            chkDeliveredEmailtoT.Checked = .DeliveredEmailtoT
        End With
        cmbBSCOMPort1_DropDown(sender, e)
        chkBSCOMMode_CheckedChanged(sender, e)
        Me.AcceptButton = cmdOK
    End Sub

    Private Sub FrmSettings_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If Me.Tag = "Login" Then
            End
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        BoolApplyError = False
        With My.Settings
            .DBServer = TextDbServer.Text
            .DBPort = TextDBPort.Text
            .DBName = TextDBName.Text
            .DBUserName = TextDBUserName.Text
            .DBPassword = If(TextDBPassword.Text.Trim().Length > 0, New Encoder().Encode(TextDBPassword.Text), "")

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
            .BGWorkerPath = TxtBGWokerPath.Text

            .CashDrawer = ChkCashDrawer.Checked
            .Save()

            MdifrmMain.BarCodePort.Close()
            If chkBSCOMMode.Checked Then
                If .BarcodeScannerCOMPort1 <> "" And Ports.SerialPort.GetPortNames.Contains(.BarcodeScannerCOMPort1) Then
                    MdifrmMain.BarCodePort.BaudRate = txtBSBaudRate.Text
                    MdifrmMain.BarCodePort.PortName = cmbBSCOMPort.Text
                    MdifrmMain.BarCodePort.Open()
                End If
            End If
        End With

        Dim ConnectionResult = Db.CheckConnection()
        If ConnectionResult.Valid = False Then
            MsgBox(ConnectionResult.Message, vbExclamation, "Database Connection Error")
            BoolApplyError = True
        End If
    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        CmdApply_Click(sender, e)
        If BoolApplyError Then
            Exit Sub
        End If
        If TextDbServer.Tag <> TextDbServer.Text Then
            Application.Restart()
        Else
            FrmSettings_Leave(sender, e)
        End If
    End Sub

    Private Sub cmdUACheck_Click(sender As Object, e As EventArgs) Handles cmdUACheck.Click
        Dim DR = Db.GetDataReader("Select * from `User` Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "' and Type='Admin';")
        If DR.Count Then
            grpUAUser.Enabled = True
            grdUAUser.Enabled = True
            Dim DT As DataTable = Db.GetDataTable("Select UNo,UserName,Type,Email from `User`")
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
        txtUAUNo.Text = Db.GetNextKey("User", "Uno")
    End Sub

    Private Sub cmdUASave_Click(sender As Object, e As EventArgs) Handles cmdUASave.Click
        Dim Dr = Db.GetDataReader("Select * from `User` Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "'")
        If Dr.Count = 0 Then
            MsgBox("Admin සදහා ලබා දුන් User Name සහ Password එක වැරදිය.", vbExclamation + vbOKOnly)
            Exit Sub
        ElseIf CheckEmptyControl(txtUAUserName, "User Name යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyControl(txtUANewPW, "New Password යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyControl(txtUAReenterPW, "Reenter Password යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf CheckEmptyControl(cmbUAType, "User Type යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
            Exit Sub
        ElseIf txtUANewPW.Text <> txtUAReenterPW.Text Then
            MsgBox("New Password හා Reenter Password යන Field එක එකිනෙකට නොගැලපෙයි. එය නැවත පරිකෂා කරන්න.", vbExclamation + vbOKOnly)
            txtUANewPW.Focus()
            Exit Sub
        ElseIf txtUAUNo.Text = "" Then
            If cmdUASave.Text = "Save" Then
                txtUAUNo.Text = Db.GetNextKey("User", "Uno")
            Else
                MsgBox("ඔබ අදාල User ව නිවැරදිව තෝරා ගෙන නොමැත. නැවත උත්සහ කරන්න.")
                grdUAUser.Focus()
                Exit Sub
            End If
        End If
        Select Case cmdUASave.Text
            Case "Save"
                Db.Execute("Insert Into `User`(UNo,UserName,`Password`,`Type`,Email) Values(" & txtUAUNo.Text & ",'" & txtUAUserName.Text & "','" &
                          txtUANewPW.Text & "','" & cmbUAType.Text & "','" & txtUAEmail.Text & "');")
            Case "Edit"
                If CheckEmptyControl(txtUACurrentPW, "Current Password යන Field එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න.") = False Then
                    Exit Sub
                End If
                Dr = Db.GetDataReader("Select * from `User` Where UNO=" & txtUAUNo.Text & " and Password='" & txtUACurrentPW.Text & "';")
                If Dr Is Nothing Then
                    MsgBox("Current Password එක සඳහා ඇතුලත් කල අගය වැරදියි. නැවත උත්සහ කරන්න.", vbExclamation + vbOKOnly)
                    txtUAUserName.Focus()
                    Exit Sub
                End If
                Db.Execute("Update `User` set UserName='" & txtUAUserName.Text &
                          "',Password='" & txtUANewPW.Text &
                          "',Type='" & cmbUAType.Text &
                          "',Email='" & txtUAEmail.Text & "' Where UNo=" & txtUAUNo.Text)
        End Select
    End Sub

    Private Sub grdUAUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdUAUser.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        Dim DR = Db.GetDataReader("Select * from `User` Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "'")
        If DR.Count = 0 Then
            MsgBox("Admin සදහා ලබා දුන් User Name සහ Password එක වැරදිය.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        DR = Db.GetDataReader("Select * from `User` Where UNo=" & grdUAUser.Item(UAUNo.Index, e.RowIndex).Value)
        If DR.Count Then
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
        Dim DR = Db.GetDataReader("Select * from `User` Where UserName ='" & txtUAAUserName.Text & "' and Password ='" & txtUAAPassword.Text & "'")
        If DR.Count = 0 Then
            MsgBox("Admin සදහා ලබා දුන් fUser Name සහ Password එක වැරදිය.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        DR = Db.GetDataReader("Select * from `User` Where UNo =" & txtUAUNo.Text)
        If DR.Count = 0 Then
            MsgBox("ඔබ අදාල User ව නිවැරදිව තෝරා ගෙන නොමැත. නැවත උත්සහ කරන්න.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        Db.Execute("DELETE from `User` where UNo=" & txtUAUNo.Text)
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

    Private Sub BtnBGWokerPath_Click(sender As Object, e As EventArgs) Handles BtnBGWokerPath.Click
        ofdDatabase.Title = "Please select the Background Worker file"
        ofdDatabase.InitialDirectory = SystemFolderPath
        ofdDatabase.Filter = "EXE file|*.exe"
        If ofdDatabase.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TxtBGWokerPath.Text = ofdDatabase.FileName
        End If
    End Sub
End Class