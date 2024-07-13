Public Class RefreshSMSBalanceProcess
    Implements IProcess

    Public Sub Perform() Implements IProcess.Perform
        'If My.Settings.BGSendSMS <> "OFF" Then
        '    bgworker.ReportProgress(60, "Reloading Balance Amount of the SMS Service...")
        '    Try
        '        Dim request As WebRequest = HttpWebRequest.Create($"http://app.newsletters.lk/smsAPI?balance&apikey={My.Settings.APIKey}&apitoken={My.Settings.APIToken}")
        '        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        '        Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
        '        Dim readStream As New StreamReader(s)
        '        Dim dataString As String = readStream.ReadToEnd()
        '        Dim json As JObject = JObject.Parse(dataString)
        '        lblBalance.Text = "Balance : Rs. " + json.SelectToken("balance").ToString
        '    Catch ex As Exception
        '        lblBalance.Text = "Balance : Rs. ###"
        '        Exit Sub
        '    End Try
        'End If
    End Sub
End Class
