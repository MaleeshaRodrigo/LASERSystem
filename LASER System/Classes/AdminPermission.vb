Public Class AdminPermission
    Public AdminSend As Boolean
    Public Remarks As String
    Public Keys As Dictionary(Of String, String)
    Public APNo As Integer

    Public Sub New()
        Me.APNo = AutomaticPrimaryKey("AdminPermission", "APNo")
        Me.AdminSend = False
        Me.Remarks = ""
        Me.Keys = New Dictionary(Of String, String)
    End Sub
End Class
