Imports Newtonsoft.Json.Linq
Imports System.ComponentModel

Public Class SendSMSProcess
    Implements IProcess
    Private ReadOnly Database As Database
    Private ReadOnly Worker As BackgroundWorker
    Private ReadOnly SmsController As New SMSController

    Public Sub New(Database As Database, Worker As BackgroundWorker)
        Me.Database = Database
        Me.Worker = Worker
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        If My.Settings.SendSMS = False Then
            Exit Sub
        End If

        Dim DataReaderMessage = Database.GetDataList("Select * from Message Where Status='Waiting' or Status='Confirmed'")
        For Each Message In DataReaderMessage
            If Worker.CancellationPending = True Then
                Exit Sub
            End If

            Dim Json As JObject = SmsController.Send(Message("CuTelNo"), Message("Message"))
            If Json.SelectToken("status").ToString = "queued" Then
                Database.Execute($"Update Message set Status='Success' Where MsgNo={DataReaderMessage("MsgNo")}")
            Else
                Database.Execute($"Update Message set Status='Failure' Where MsgNo={DataReaderMessage("MsgNo")}")
            End If
        Next
    End Sub
End Class
