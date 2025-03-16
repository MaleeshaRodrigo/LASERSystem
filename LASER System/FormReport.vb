Imports System.ComponentModel
Imports MySqlConnector

Public Class FormReport
    Public ActiviteTimelyClosed As Boolean = False
    Public WindowPosition As Position

    Private ClosedCount As Integer
    Private FormName As String
    Private ReportManager As AbstractReportManager

    Public Sub New()
        InitializeComponent()
        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Public Sub SetReportManager(ReportManager As AbstractReportManager)
        Me.ReportManager = ReportManager
    End Sub

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ActiviteTimelyClosed Then
            ClosedCount = 60
            FormName = Text
            tmrInterval.Enabled = True
            tmrInterval.Start()
        End If

        Select Case WindowPosition
            Case Position.BottomLeft
                Top = Screen.PrimaryScreen.WorkingArea.Height / 2
                Height = Screen.PrimaryScreen.WorkingArea.Height - Top - 5
                Width = Screen.PrimaryScreen.WorkingArea.Width / 2
                Left = 0
            Case Position.BottomRight
                Top = Screen.PrimaryScreen.WorkingArea.Height / 2
                Height = Screen.PrimaryScreen.WorkingArea.Height - Top - 5
                Width = Screen.PrimaryScreen.WorkingArea.Width / 2
                Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - 10
        End Select
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ReportViewer.PrintReport()
    End Sub

    Private Sub tmrInterval_Tick(sender As Object, e As EventArgs) Handles tmrInterval.Tick
        ClosedCount -= 1
        Text = FormName + " - Closed at " + ClosedCount.ToString + " sec"
        If ClosedCount <= 0 Then
            Close()
        End If
    End Sub

    Private Sub frmReport_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
End Class

Public Enum Position
    BottomLeft
    BottomRight
End Enum