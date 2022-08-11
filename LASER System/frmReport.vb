Imports System.ComponentModel

Public Class frmReport
    Dim ClosedCount As Integer
    Dim FormName As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MenuStrip1.Items.Add(mnustrpMENU)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ReportViewer.PrintReport()
    End Sub

    Private Sub tmrInterval_Tick(sender As Object, e As EventArgs) Handles tmrInterval.Tick
        ClosedCount -= 1
        Me.Text = FormName + " - Closed at " + ClosedCount.ToString + " sec"
        If ClosedCount <= 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.Tag
            Case "ReceivedRecipt"
                ClosedCount = 60
                FormName = Me.Text
                tmrInterval.Enabled = True
                tmrInterval.Start()
                Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2
                Me.Height = Screen.PrimaryScreen.WorkingArea.Height - Me.Top - 5
                Me.Width = Screen.PrimaryScreen.WorkingArea.Width / 2
                Me.Left = 0
            Case "ReceivedSticker"
                ClosedCount = 60
                FormName = Me.Text
                tmrInterval.Enabled = True
                tmrInterval.Start()
                Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2
                Me.Height = Screen.PrimaryScreen.WorkingArea.Height - Me.Top - 5
                Me.Width = Screen.PrimaryScreen.WorkingArea.Width / 2
                Me.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - 10
        End Select
    End Sub
    Private Sub frmReport_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub frmReport_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class