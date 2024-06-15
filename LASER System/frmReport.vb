Imports System.ComponentModel
Imports MySqlConnector

Public Class frmReport
    Public boolClosed As Boolean = False
    Private ClosedCount As Integer
    Private FormName As String
    Public Sub New()
        InitializeComponent()

        MenuStrip1.Items.Add(mnustrpMENU)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Select Case Me.Tag
            Case "RepairReceivedReceipt"
                Dim RPT = Me.ReportViewer.ReportSource
                Dim rawKind1 As Integer
                Dim c1 As Integer
                Dim doctoprint1 As New Printing.PrintDocument()
                doctoprint1.PrinterSettings.PrinterName = My.Settings.BillPrinterName
                For c1 = 0 To doctoprint1.PrinterSettings.PaperSizes.Count - 1
                    If doctoprint1.PrinterSettings.PaperSizes(c1).PaperName = My.Settings.BillPrinterPaperName Then
                        rawKind1 = CInt(doctoprint1.PrinterSettings.PaperSizes(c1).
                                                GetType().GetField("kind", Reflection.BindingFlags.Instance Or
                                                Reflection.BindingFlags.NonPublic).GetValue(doctoprint1.PrinterSettings.PaperSizes(c1)))
                        Exit For
                    End If
                Next
                RPT.printoptions.PaperSize = CType(rawKind1, CrystalDecisions.Shared.PaperSize)
                RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                RPT.PrintToPrinter(1, False, 0, 0)
            Case Else
                ReportViewer.PrintReport()
        End Select
    End Sub

    Private Sub tmrInterval_Tick(sender As Object, e As EventArgs) Handles tmrInterval.Tick
        ClosedCount -= 1
        Me.Text = FormName + " - Closed at " + ClosedCount.ToString + " sec"
        If ClosedCount <= 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If boolClosed Then
            ClosedCount = 60
            FormName = Me.Text
            tmrInterval.Enabled = True
            tmrInterval.Start()
        End If
        Select Case Me.Tag
            Case "ReceivedReceipt"
                Me.Top = Screen.PrimaryScreen.WorkingArea.Height / 2
                Me.Height = Screen.PrimaryScreen.WorkingArea.Height - Me.Top - 5
                Me.Width = Screen.PrimaryScreen.WorkingArea.Width / 2
                Me.Left = 0
            Case "ReceivedSticker"
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
End Class