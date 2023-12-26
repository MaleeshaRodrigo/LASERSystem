Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json.Linq
Imports MySql.Data.MySqlClient

Public Class frmMessage
    Private Db As New Database
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        MenuStrip.Items.Add(mnustrpMENU)
        TabControl.TabPages.Remove(tabMsg)
        TabControl.TabPages.Remove(tabMsgHistory)
        TabControl.TabPages.Remove(tabRepTask)
    End Sub

    Private Sub frmMessage_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Select Case Me.Tag
            Case "Message"
                TabControl.TabPages.Add(tabMsg)
                cmbField.Text = "Repair"
                If frmRepair.txtCuTelNo1.Text <> "          " Then
                    Dim str As String = frmRepair.txtCuTelNo1.Text.TrimStart("0"c)
                    txtPhoneNo.Text = "94" + str.Replace(" ", [String].Empty)
                End If
                With frmRepair
                    If .cmbRepStatus.Text = "Hand Over to Technician" Then
                        txtMessage.Text = .cmbCuName.Text + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + .cmbPName.Text + " " + .cmbPCategory.Text + " අයිතමය Technician හට භාර දී ඇත."
                    ElseIf .cmbRepStatus.Text = "Repaired Not Delivered" Then
                        txtMessage.Text = .cmbCuName.Text + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + .cmbPName.Text + " " + .cmbPCategory.Text + " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + .txtRepPrice.Text + " වේ."
                    ElseIf .cmbRepStatus.Text = "Returned Not Delivered" Then
                        If .txtRepPrice.Text = "0" Then
                            txtMessage.Text = .cmbCuName.Text + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + .cmbPName.Text + " " + .cmbPCategory.Text + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු."
                        Else
                            txtMessage.Text = .cmbCuName.Text + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + .cmbPName.Text + " " + .cmbPCategory.Text + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටින අතර ඒ සඳහා Rs." + .txtRepPrice.Text + " අය කෙරෙයි."
                        End If
                    End If
                End With
                SetNextKey(Db, txtMsgNo, "Select Top 1 MsgNo from Message order by MsgNo Desc;", "MsgNo")
            Case "MessagetoCu"
                TabControl.TabPages.Add(tabMsgHistory)
                grdMsgHistory.DataSource = Db.GetDataTable("Select * from Message Order by MsgDate;")
                grdMsgHistory.Refresh()
            Case "RepTask"
                TabControl.TabPages.Add(tabRepTask)
                bgworker.RunWorkerAsync()
        End Select
    End Sub
    Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdMSend.Click
        If MsgBox("Phone No: " + txtPhoneNo.Text & vbCr &
               "Message: " + txtMessage.Text & vbCr &
               "SMS එක යැවීම සඳහා තහවුරු කරන්න.", vbYesNo + vbExclamation) = False Then Exit Sub
        If cmbField.Text = "Repair" Then
            Db.Execute("Insert Into Message(MsgNo,REPNo,CuTelNo,Message,Status) Values(" &
                  txtMsgNo.Text & "," & cmbRepNo.Text & ",'" & txtPhoneNo.Text & "','" & txtMessage.Text & "','Waiting');")
        ElseIf cmbField.Text = "RERepair" Then
            Db.Execute("Insert Into Message(MsgNo,RETNo,CuTelNo,Message,Status) Values(" &
                  txtMsgNo.Text & "," & cmbRepNo.Text & ",'" & txtPhoneNo.Text & "','" & txtMessage.Text & "','Waiting');")
        Else
            Db.Execute("Insert Into Message(MsgNo,CuTelNo,Message,Status) Values(" &
                  txtMsgNo.Text & ",'" & txtPhoneNo.Text & "','" & txtMessage.Text & "','Waiting');")
        End If
    End Sub
    Private Sub cmbRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRepNo.DropDown
        If cmbField.Text = "Repair" Then
            ComboBoxDropDown(Db, cmbRepNo, "Select REPNo from Repair Order by RePNO Desc;")
        ElseIf cmbField.Text = "RERepair" Then
            ComboBoxDropDown(Db, cmbRepNo, "Select RetNo from Return Order by RetNO Desc;")
        End If
    End Sub

    Private Sub grdMsgHistory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdMsgHistory.CellEndEdit
        If e.ColumnIndex = 0 Then
            DR = Db.GetDataReader("Select RepNo, RDate, CuName, CuTElNo1, PCategory, PName, Charge, Qty, TName, Status, '' as Message from ((((Repair REP INNER JOIN Product P ON P.PNO = REP.PNO) INNER JOIN Receive R ON R.RNo = REP.RNo) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNo=REP.TNo) where RepNo = " &
                                            grdMsgHistory.Item(e.ColumnIndex, e.RowIndex).Value & ";")
            If DR.HasRows = True Then
                DR.Read()
                grdMsgHistory.Item("RetNo", e.RowIndex).Value = ""
                grdMsgHistory.Item("CuName", e.RowIndex).Value = DR("CuName").ToString
                grdMsgHistory.Item("CuTelNo1", e.RowIndex).Value = DR("CuTelNo1").ToString
                grdMsgHistory.Item("PCategory", e.RowIndex).Value = DR("PCategory").ToString
                grdMsgHistory.Item("PName", e.RowIndex).Value = DR("PName").ToString
                grdMsgHistory.Item("Charge", e.RowIndex).Value = DR("Charge").ToString
                grdMsgHistory.Item("TName", e.RowIndex).Value = DR("TName").ToString
                grdMsgHistory.Item("Status", e.RowIndex).Value = DR("Status").ToString

                If DR("Status").ToString = "Hand Over to Technician" Then
                    grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය Technician හට භාර දී ඇත."
                ElseIf DR("Status").ToString = "Repaired Not Delivered" Then
                    grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + DR("Charge").ToString + " වේ."
                ElseIf DR("Status").ToString = "Returned Not Delivered" Then
                    If DR("Charge") = "0" Then
                        grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු."
                    Else
                        grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටින අතර ඒ සඳහා Rs." + DR("Charge").ToString + " අය කෙරෙයි."
                    End If
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then
            DR = Db.GetDataReader("Select RetNo,RDate,CuName, CuTelNo1, PCategory,PName,Charge,Qty,TName, Status, '' as Message from ((((RETURN RET INNER JOIN Product P ON P.PNO = RET.PNO) INNER JOIN Receive R ON R.RNo = RET.RNo) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNo=RET.TNo) where ReTNo = " & grdMsgHistory.Item(1, e.RowIndex).Value & ";")
            If DR.HasRows = True Then
                DR.Read()
                grdMsgHistory.Item("RepNo", e.RowIndex).Value = ""
                grdMsgHistory.Item("CuName", e.RowIndex).Value = DR("CuName").ToString
                grdMsgHistory.Item("CuTelNo1", e.RowIndex).Value = DR("CuTelNo1").ToString
                grdMsgHistory.Item("PCategory", e.RowIndex).Value = DR("PCategory").ToString
                grdMsgHistory.Item("PName", e.RowIndex).Value = DR("PName").ToString
                grdMsgHistory.Item("Charge", e.RowIndex).Value = DR("Charge").ToString
                grdMsgHistory.Item("TName", e.RowIndex).Value = DR("TName").ToString
                grdMsgHistory.Item("Status", e.RowIndex).Value = DR("Status").ToString

                If DR("Status").ToString = "Hand Over to Technician" Then
                    grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය Technician හට භාර දී ඇත."
                ElseIf DR("Status").ToString = "Repaired Not Delivered" Then
                    grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + DR("Charge").ToString + " වේ."
                ElseIf DR("Status").ToString = "Returned Not Delivered" Then
                    If DR("Charge") = "0" Then
                        grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු."
                    Else
                        grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටින අතර ඒ සඳහා Rs." + DR("Charge").ToString + " අය කෙරෙයි."
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub grdMsgHistory_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdMsgHistory.EditingControlShowing
        Dim DataCollection As New AutoCompleteStringCollection()
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        Select Case grdMsgHistory.CurrentCell.ColumnIndex
            Case 0, 1
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        End Select
    End Sub

    Private Sub TextBoxQty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        OnlynumberQty(e)
    End Sub

    Private Sub cmbField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbField.SelectedIndexChanged
        cmbRepNo.Text = ""
        cmbRepNo_DropDown(sender, e)
    End Sub

    Private Sub bgworker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgworker.DoWork
        If Me.Tag = "RepTask" Then
            Dim DR1 As MySqlDataReader = Db.GetDataReader("Select RepNo,RDate,CuName, CuTelNo1, PCategory,PName,Charge,Qty,TName, Status from ((((Repair REP INNER JOIN Product P ON P.PNO = REP.PNO) INNER JOIN Receive R ON R.RNo = REP.RNo) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNo=REP.TNo) where Status='Received' or Status='Hand Over to Technician' or Status='Repairing'")
            While DR1.Read
                If bgworker.CancellationPending = True Then Exit Sub
                Dim DR2 As MySqlDataReader = Db.GetDataReader("Select * from Message Where RepNo=" & DR1("RepNo").ToString &
                                                                        " And MsgDate < #" & DateTime.Today.AddDays(-7).Date & "#;")
                If DR2.HasRows = False Then
                    grdRepairTask.Rows.Add("", DR1("RepNo").ToString, DR1("CuName").ToString, DR1("CuTelNo1").ToString, DR1("PCategory").ToString,
                                           DR1("PName").ToString, DR1("Status").ToString, "", "")
                End If
                DR2.Close()
            End While
            DR1.Close()
        End If
    End Sub
End Class