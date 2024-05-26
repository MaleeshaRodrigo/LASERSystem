Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.FileIO

Module Utils
    Public ApplicationDataFilePath As String = Path.Combine(SpecialDirectories.MyDocuments, "LASER System Data", "LASER Background")

    Public Function CheckForInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("lasertec.lk")
        Catch
            Return False
        End Try
    End Function

    Public Function GetIpAddress() As String
        Dim client As New WebClient
        '// Add a user agent header in case the requested URI contains a query.
        client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko")
        Dim baseurl As String = "http://checkip.dyndns.org/"
        ' with proxy server only:
        Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
        proxy.Credentials = CredentialCache.DefaultNetworkCredentials
        client.Proxy = proxy
        Dim data As Stream
        Try
            data = client.OpenRead(baseurl)
        Catch ex As Exception
            Return ""
            Exit Function
        End Try
        Dim Reader As New StreamReader(data)
        Dim s As String = Reader.ReadToEnd()
        data.Close()
        Reader.Close()
        s = s.Replace("<html><head><title>Current IP Check</title></head><body>", "").Replace("</body></html>", "").ToString()
        Return s
    End Function

    Public Function HashPassword(ByVal Password As String, ByVal Salt As String) As String
        Dim pwd As String = Password & Salt
        Dim hasher As New System.Security.Cryptography.SHA256Managed()
        Dim pwdb As Byte() = System.Text.Encoding.UTF8.GetBytes(pwd)
        Dim pwdh As Byte() = hasher.ComputeHash(pwdb)
        Return Convert.ToBase64String(pwdh)
    End Function

    Public Function CheckEmptyfield(cmb As Object, msg As String) As Boolean
        CheckEmptyfield = True
        If cmb.Text = "" Then
            MsgBox(msg, vbCritical + vbOKOnly)
            cmb.Focus()
            Return False
        End If
    End Function

End Module
