﻿Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json.Linq
Imports MySqlConnector

Public Class FormMessage
    Private Db As New Database
    Public Sub New()
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub grdMsgHistory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        'If e.ColumnIndex = 0 Then
        '    DR = Db.GetDataDictionary("Select RepNo, RDate, CuName, CuTElNo1, PCategory, PName, Charge, Qty, TName, Status, '' as Message from ((((Repair REP INNER JOIN Product P ON P.PNO = REP.PNO) INNER JOIN Receive R ON R.RNo = REP.RNo) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNo=REP.TNo) where RepNo = " &
        '                                    grdMsgHistory.Item(e.ColumnIndex, e.RowIndex).Value & ";")
        '    If DR.Count Then

        '        grdMsgHistory.Item("RetNo", e.RowIndex).Value = ""
        '        grdMsgHistory.Item("CuName", e.RowIndex).Value = DR("CuName").ToString
        '        grdMsgHistory.Item("CuTelNo1", e.RowIndex).Value = DR("CuTelNo1").ToString
        '        grdMsgHistory.Item("PCategory", e.RowIndex).Value = DR("PCategory").ToString
        '        grdMsgHistory.Item("PName", e.RowIndex).Value = DR("PName").ToString
        '        grdMsgHistory.Item("Charge", e.RowIndex).Value = DR("Charge").ToString
        '        grdMsgHistory.Item("TName", e.RowIndex).Value = DR("TName").ToString
        '        grdMsgHistory.Item("Status", e.RowIndex).Value = DR("Status").ToString

        '        If DR("Status").ToString = "Hand Over to Technician" Then
        '            grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය Technician හට භාර දී ඇත."
        '        ElseIf DR("Status").ToString = "Repaired Not Delivered" Then
        '            grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + DR("Charge").ToString + " වේ."
        '        ElseIf DR("Status").ToString = "Returned Not Delivered" Then
        '            If DR("Charge") = "0" Then
        '                grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු."
        '            Else
        '                grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටින අතර ඒ සඳහා Rs." + DR("Charge").ToString + " අය කෙරෙයි."
        '            End If
        '        End If
        '    End If
        'ElseIf e.ColumnIndex = 1 Then
        '    DR = Db.GetDataDictionary("Select RetNo,RDate,CuName, CuTelNo1, PCategory,PName,Charge,Qty,TName, Status, '' as Message from ((((RETURN RET INNER JOIN Product P ON P.PNO = RET.PNO) INNER JOIN Receive R ON R.RNo = RET.RNo) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNo=RET.TNo) where ReTNo = " & grdMsgHistory.Item(1, e.RowIndex).Value & ";")
        '    If DR.Count Then

        '        grdMsgHistory.Item("RepNo", e.RowIndex).Value = ""
        '        grdMsgHistory.Item("CuName", e.RowIndex).Value = DR("CuName").ToString
        '        grdMsgHistory.Item("CuTelNo1", e.RowIndex).Value = DR("CuTelNo1").ToString
        '        grdMsgHistory.Item("PCategory", e.RowIndex).Value = DR("PCategory").ToString
        '        grdMsgHistory.Item("PName", e.RowIndex).Value = DR("PName").ToString
        '        grdMsgHistory.Item("Charge", e.RowIndex).Value = DR("Charge").ToString
        '        grdMsgHistory.Item("TName", e.RowIndex).Value = DR("TName").ToString
        '        grdMsgHistory.Item("Status", e.RowIndex).Value = DR("Status").ToString

        '        If DR("Status").ToString = "Hand Over to Technician" Then
        '            grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය Technician හට භාර දී ඇත."
        '        ElseIf DR("Status").ToString = "Repaired Not Delivered" Then
        '            grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සාදා අවසන් බැවින් එය ගෙවා රැගෙනයන මෙන් ඉල්ලා සිටින අතර එහි ගාස්තුව Rs." + DR("Charge").ToString + " වේ."
        '        ElseIf DR("Status").ToString = "Returned Not Delivered" Then
        '            If DR("Charge") = "0" Then
        '                grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටිමු."
        '            Else
        '                grdMsgHistory.Item("BatchMessage", e.RowIndex).Value = DR("CuName").ToString + ", ඔබ LASER Electronics ආයතනයට ලබාදුන් " + DR("PName").ToString + " " + DR("PCategory").ToString + " අයිතමය සෑදීමට අවශ්‍ය අමතර කොටස් නොමැති බැවින් එය රැගෙන යන මෙන් ඉල්ලා සිටින අතර ඒ සඳහා Rs." + DR("Charge").ToString + " අය කෙරෙයි."
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub grdMsgHistory_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        'Dim DataCollection As New AutoCompleteStringCollection()
        'RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        'Select Case grdMsgHistory.CurrentCell.ColumnIndex
        '    Case 0, 1
        '        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBoxQty_keyPress
        'End Select
    End Sub

    Private Sub bgworker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgworker.DoWork
        'If Me.Tag = "RepTask" Then
        'Dim DR1 = Db.GetDataReader("Select RepNo,RDate,CuName, CuTelNo1, PCategory,PName,Charge,Qty,TName, Status from ((((Repair REP INNER JOIN Product P ON P.PNO = REP.PNO) INNER JOIN Receive R ON R.RNo = REP.RNo) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNo=REP.TNo) where Status='Received' or Status='Hand Over to Technician' or Status='Repairing'")
        'For Each Item In DR1
        '    If bgworker.CancellationPending = True Then Exit Sub
        '    Dim DR2 = Db.GetDataReader("Select * from Message Where RepNo=" & DR1("RepNo").ToString &
        '                                                            " And MsgDate < '" & DateTime.Today.AddDays(-7).Date & "';")
        '    If DR2.HasRows = False Then
        '        grdRepairTask.Rows.Add("", DR1("RepNo").ToString, DR1("CuName").ToString, DR1("CuTelNo1").ToString, DR1("PCategory").ToString,
        '                               DR1("PName").ToString, DR1("Status").ToString, "", "")
        '    End If
        '    DR2.Close()
        'End While
        'DR1.Close()
        'End If
    End Sub
End Class