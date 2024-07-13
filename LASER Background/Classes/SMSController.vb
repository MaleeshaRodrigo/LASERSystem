Imports Newtonsoft
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Web

Public Class SmsController
    Private ReadOnly Host As String = "https://app.newsletters.lk/smsAPI"
    Private ReadOnly ApiKey As String = My.Settings.APIKey
    Private ReadOnly ApiToken As String = My.Settings.APIToken

    Public Function Send(Phone As String, Message As String) As Object
        Phone = Phone.TrimStart("0"c)
        Dim originator As String = "94" + Phone.Replace(" ", String.Empty)
        Dim url As String = $"{Host}?sendsms&" & "apikey=" & HttpUtility.UrlEncode(ApiKey) _
                & "&apitoken=" + HttpUtility.UrlEncode(ApiToken) _
                & "&type=sms&from=LASERelect" _
                & "&to=" & HttpUtility.UrlEncode(originator) _
                & "&text=" + HttpUtility.UrlEncode(Message)
        Dim request As WebRequest = WebRequest.Create(url)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
        Dim readStream As New StreamReader(s)
        Dim dataString As String = readStream.ReadToEnd()

        response.Close()
        s.Close()
        readStream.Close()

        Return JObject.Parse(dataString)
    End Function

    Public Function GetBalance() As String
        Dim request As WebRequest = WebRequest.Create($"{Host}?balance&apikey={My.Settings.APIKey}&apitoken={My.Settings.APIToken}")
        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
        Dim readStream As New StreamReader(s)
        Dim dataString As String = readStream.ReadToEnd()
        Dim json As JObject = JObject.Parse(dataString)

        Return json.SelectToken("balance").ToString
    End Function
End Class
