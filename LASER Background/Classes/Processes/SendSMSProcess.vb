Imports Newtonsoft.Json.Linq
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class SendSMSProcess
    Implements IProcess
    Private ReadOnly Database As Database
    Private ReadOnly Worker As BackgroundWorker

    Public Sub New(Database As Database, Worker As BackgroundWorker)
        Me.Database = Database
        Me.Worker = Worker
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        'Try
        '    If My.Settings.BGSendSMS = "Automatically Send SMS" Then

        '    ElseIf My.Settings.BGSendSMS = "Only Getting Notification" Then
        '        CMDBG1 = New OleDb.OleDbCommand("Select * from Message Where Status ='Waiting';", CNNBG)
        '        DRBG1 = CMDBG1.ExecuteReader()
        '        While DRBG1.Read()
        '            If Worker.CancellationPending = True Then Exit Sub
        '            Dim Bool As Boolean = True
        '            For Each controlObject As Control In flpMessage.Controls
        '                If controlObject.Tag.ToString.StartsWith("SendSMSConfirmation") = True Then
        '                    If IsNumeric(controlObject.Tag.ToString.Replace("SendSMSConfirmation", "")) = True AndAlso
        '                                DRBG1("MsgNo").ToString = controlObject.Tag.ToString.Replace("SendSMSConfirmation", "") Then
        '                        Bool = False
        '                    End If
        '                End If
        '            Next
        '            If Bool = True Then CreateMessagePanel(Int(DRBG1("MsgNo").ToString))
        '        End While

        '        CMDBG1 = New OleDbCommand("Select * from Message Where Status='Confirmed'", CNNBG)
        '        DRBG1 = CMDBG1.ExecuteReader
        '        While DRBG1.Read
        '            If Worker.CancellationPending = True Then Exit Sub
        '            Dim json As JObject = SendSMS(DRBG1("CuTelNo").ToString)
        '            If json.SelectToken("status").ToString = "queued" Then
        '                Database.Execute("Update Message set Status='Success' Where MsgNo=" & DRBG1("MsgNo").ToString)

        '                Dim C As Integer = 0
        '                Dim Msg As String = ""
        '                For Each controlObject As Control In flpMessage.Controls
        '                    If Worker.CancellationPending = True Then Exit Sub
        '                    If controlObject.Tag.ToString.StartsWith("SMSDeliveredSuccess") = True Then
        '                        If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")) = True Then
        '                            C = controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")
        '                            For Each ctrlMsg As Control In controlObject.Controls
        '                                If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
        '                                    Msg = ctrlMsg.Text
        '                                End If
        '                            Next
        '                        End If
        '                        controlObject.Dispose()
        '                    End If
        '                Next
        '                CreateMessagePanel((C + 1).ToString + " Message" & If(C > 0, "s", "") & " Sent Successfull", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
        '                                       If(DRBG1("RepNo").ToString = "", DRBG1("RetNo").ToString, DRBG1("RepNo").ToString) +
        '                                       ": " + DRBG1("Message").ToString, "SMSDeliveredSuccess" + (C + 1).ToString)
        '            Else
        '                CMDUPDATE("Update Message set Status='Failure' Where MsgNo=" & DRBG1("MsgNo").ToString)

        '                Dim C As Integer = 0
        '                Dim Msg As String = ""
        '                For Each controlObject As Control In flpMessage.Controls
        '                    If Worker.CancellationPending = True Then Exit Sub
        '                    If controlObject.Tag.ToString.StartsWith("SMSDeliveredFailure") = True Then
        '                        If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")) = True Then
        '                            C = controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")
        '                            For Each ctrlMsg As Control In controlObject.Controls
        '                                If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
        '                                    Msg = ctrlMsg.Text
        '                                End If
        '                            Next
        '                        End If
        '                        controlObject.Dispose()
        '                    End If
        '                Next
        '                CreateMessagePanel((C + 1).ToString + " Message " & If(C > 0, "s", "") & " Sent Failure", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
        '                                       If(DRBG1("RepNo").ToString = "", DRBG1("RetNo").ToString, DRBG1("RepNo").ToString) +
        '                                        ": " + DRBG1("Message").ToString, "SMSDeliveredFailure" + (C + 1).ToString)
        '            End If
        '        End While
        '        CMDBG1.Cancel()
        '    End If
        'Catch ex As Exception
        '    CreateMessagePanel("ස්වයංක්‍රීයව යැවෙන SMS පණිවිඩ ක්‍රියාවිරහිත වී ඇත.", "ස්වයංක්‍රීයව SMS යැවෙන පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
        '    vbCrLf + vbCrLf + "Message: " + ex.Message + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendSMSError")
        'Finally
        '    If DRBG1 IsNot Nothing AndAlso DRBG1.IsClosed = False Then
        '        DRBG1.Close()
        '        CMDBG1.Cancel()
        '    End If
        'End Try
    End Sub

    Private Sub PerformAutomaticallySendSMS()
        'Dim DataReaderMessage = Database.GetDataReader("Select * from Message Where Status='Waiting' or Status='Confirmed'")
        'While DataReaderMessage.Read
        '    If Worker.CancellationPending = True Then
        '        Exit Sub
        '    End If

        '    Dim Json As JObject = SendSMS(DataReaderMessage("CuTelNo").ToString)
        '    If Json.SelectToken("status").ToString = "queued" Then
        '        Database.Execute("Update Message set Status='Success' Where MsgNo=" & DataReaderMessage("MsgNo").ToString)

        '        Dim C As Integer = 0
        '        Dim Msg As String = ""
        '        For Each controlObject As Control In flpMessage.Controls
        '            If controlObject.Tag.ToString.StartsWith("SMSDeliveredSuccess") = True Then
        '                If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")) = True Then
        '                    C = controlObject.Tag.ToString.Replace("SMSDeliveredSuccess", "")
        '                    For Each ctrlMsg As Control In controlObject.Controls
        '                        If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
        '                            Msg = ctrlMsg.Text
        '                        End If
        '                    Next
        '                End If
        '                controlObject.Dispose()
        '            End If
        '        Next
        '        CreateMessagePanel((C + 1).ToString + " Message" & If(C > 0, "s", "") & " Sent Successfull", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
        '                               If(DataReaderMessage("RepNo").ToString = "", DataReaderMessage("RetNo").ToString, DataReaderMessage("RepNo").ToString) +
        '                               ": " + DataReaderMessage("Message").ToString, "SMSDeliveredSuccess" + (C + 1).ToString)
        '    Else
        '        Database.Execute("Update Message set Status='Failure' Where MsgNo=" & DataReaderMessage("MsgNo").ToString)

        '        Dim C As Integer = 0
        '        Dim Msg As String = ""
        '        For Each controlObject As Control In flpMessage.Controls
        '            If Worker.CancellationPending = True Then Exit Sub
        '            If controlObject.Tag.ToString.StartsWith("SMSDeliveredFailure") = True Then
        '                If IsNumeric(controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")) = True Then
        '                    C = controlObject.Tag.ToString.Replace("SMSDeliveredFailure", "")
        '                    For Each ctrlMsg As Control In controlObject.Controls
        '                        If ctrlMsg.Name.ToString.StartsWith("lblMessage") = True Then
        '                            Msg = ctrlMsg.Text
        '                        End If
        '                    Next
        '                End If
        '                controlObject.Dispose()
        '            End If
        '        Next
        '        CreateMessagePanel((C + 1).ToString + " Message" & If(C > 0, "s", "") & " Sent Failure", Msg + If(C > 0, vbCrLf + vbCrLf, "") +
        '                               If(DataReaderMessage("RepNo").ToString = "", DataReaderMessage("RetNo").ToString, DataReaderMessage("RepNo").ToString) +
        '                                ": " + DataReaderMessage("Message").ToString, "SMSDeliveredFailure" + (C + 1).ToString)
        '    End If
        'End While
    End Sub
End Class
