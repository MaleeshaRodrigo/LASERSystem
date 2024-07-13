Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class RefreshSmsBalanceProcess
    Implements IProcess
    Private ReadOnly ParentForm As frmBGTasks
    Private ReadOnly SmsController As New SmsController

    Public Sub New(FormParent As frmBGTasks)
        ParentForm = FormParent
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        If Not My.Settings.SendSMS Then
            Exit Sub
        End If
        Try
            ParentForm.lblBalance.Text = "Balance : Rs. " + SmsController.GetBalance()
        Catch ex As Exception
            ParentForm.lblBalance.Text = "Balance : Rs. ###"
            Exit Sub
        End Try
    End Sub
End Class
