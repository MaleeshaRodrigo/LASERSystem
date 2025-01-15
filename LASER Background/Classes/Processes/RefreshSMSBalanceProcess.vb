Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class RefreshSmsBalanceProcess
    Implements IProcess
    Private ReadOnly ParentForm As FormBGTasks
    Private ReadOnly SmsController As New SmsController

    Public Sub New(FormParent As FormBGTasks)
        ParentForm = FormParent
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        Try
            ParentForm.lblBalance.Text = "Balance : Rs. " + SmsController.GetBalance()
        Catch ex As Exception
            ParentForm.lblBalance.Text = "Balance : Rs. ###"
            Exit Sub
        End Try
    End Sub

    Public Function CanPerformable() As Boolean Implements IProcess.CanPerformable
        Return My.Settings.SendSMS
    End Function
End Class
