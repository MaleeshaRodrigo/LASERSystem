﻿Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public NotInheritable Class FrmSplash
    Private Db As New Database
    Dim C As Integer
    Dim flName As Object

    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Db.Connect()
        imgSplash.Top = 0
        imgSplash.Left = 0
        C = 0
        LoadingBar.Minimum = 0
        LoadingBar.Maximum = 100
        LoadingBar.Value = 0
        tmrSplash.Start()
    End Sub

    Private Sub TmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        C += 1
        If C = 100 Then
            Me.Close()
            tmrSplash.Stop()
        Else
            LoadingBar.Value = C
            bgworker_DoWork()
        End If
    End Sub

    Private Sub bgworker_DoWork()
        tmrSplash.Stop()
        Select Case LoadingBar.Value
            Case 1
                txtLoad.Text = "Checking System Files..."
                If Not Directory.Exists(Application.StartupPath + "/System Files/Reports") Then
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/System Files/Reports")
                End If
                If Not Directory.Exists(Application.StartupPath + "/System Files") Then
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/System Files")
                End If
                If Not Directory.Exists(Application.StartupPath + "/System Files/Images") Then
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/System Files/Images")
                End If
                If Not Directory.Exists(Application.StartupPath + "/System Files/Activity") Then
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/System Files/Activity")
                End If
                If Not File.Exists(Application.StartupPath + "/System Files/Activity/Activity.json") Then
                    Dim d As FileStream
                    d = File.Create(Application.StartupPath & "/System Files/Activity/Activity.json")
                    d.Close()
                End If
            Case 20
                If File.Exists(My.Settings.BGWorkerPath) Then
                    Process.Start(My.Settings.BGWorkerPath)
                End If
            Case 50
                txtLoad.Text = "Optimizing Report Viewer for printing..."
                frmReport.WindowState = FormWindowState.Minimized
                frmReport.Show()
                frmReport.Hide()
            Case 60
                txtLoad.Text = "Setting Main Menu..."
                With MdifrmMain
                    WriteActivity("Logged In Successfull by " + .tslblUserName.Text + " as a " + .tslblUserType.Text)
                    .WindowState = FormWindowState.Minimized
                    .Show()
                    .Hide()
                    .WindowState = FormWindowState.Maximized
                    .tabChart.TabPages.Remove(.pageIncomevsDate)
                    .tabChart.TabPages.Remove(.pageReceivedRepvsDate)
                    .tabChart.TabPages.Remove(.pageCashier)
                    .tabChart.TabPages.Add(.pageIncomevsDate)
                    .tabChart.TabPages.Add(.pageReceivedRepvsDate)
                    .cmbIncomevsDateView.Text = "Days"
                    .txtIncomevsDateCustom.Text = "5"
                    .cmbReceivedRepvsDateView.Text = "Days"
                    .txtReceivedRepvsDateCustom.Text = "5"
                    .txtIncomevsDateCustom_TextChanged(Nothing, Nothing)
                    .lblQtyRRepDetails.Visible = True
                    .lblTodayIncomeDetails.Visible = True
                    .lblQtyRRepNo.Visible = True
                    .lblQtyRRetNo.Visible = True
                    .lblTodayIncomeNo.Visible = True
                    .GrdActivity.Width = .tabChart.Width + .tabChart.Left - .GrdActivity.Left - 2
                    .GrdActivity.Left = .lblTodayIncomeNo.Left + .lblTodayIncomeNo.Width + 5
                End With
            Case 70
                With MdifrmMain
                    LoadingBar.Value += 5
                    txtLoad.Text = "Getting Message to the Message Panel in Main Menu..."
                    DR = Db.GetDataReader("Select COUNT(SNo) as SNoCount from [Stock] Where SAvailableStocks < SMinStocks")
                    If DR.HasRows Then
                        DR.Read()
                        Dim MessagePanel As New MessagePanel("Stocks Report", DR("SNoCount").ToString & " Stocks නැවත පිරවීමට ඇති බැවින් බඩු ගැනීමට පැමිණි පාරිභෝගිකයන් නැවත හරවා " &
                                                      "නොයැවීමට නම් මෙම stocks නැවත පිරවීම සඳහා පියවර ගන්න.")
                        MessagePanel.Add()
                    End If
                    DR = Db.GetDataReader("Select * from [User] Where UserName='" & .tslblUserName.Text & "'")
                    If DR.HasRows Then
                        DR.Read()
                        .lblUName.Text = "Name: " + DR("UserName").ToString
                        .lblUEmail.Text = "Email: " + DR("Email").ToString
                        .lblULastLogin.Text = "Last Login: " + DR("LastLogin").ToString
                        .lblULoginCount.Text = "Login Count: " + DR("LoginCount").ToString
                        If File.Exists(SpecialDirectories.MyDocuments + "\Images\U-" & DR("UNo").ToString & ".ls") Then
                            .picUImage.Image = Image.FromFile(SpecialDirectories.MyDocuments + "\Images\U-" & DR("UNo").ToString & ".ls")
                        End If
                    End If
                    .TmrReload_Tick(Nothing, Nothing)
                    .tmrReload.Start()
                End With
            Case 80
                txtLoad.Text = "Setting Accessibility..."
                With MdifrmMain
                    .BarCodePort.Close()
                    If My.Settings.BarcodeScannerCOMMode = True Then
                        Try
                            If My.Settings.BarcodeScannerCOMPort1 <> "" And
                                IO.Ports.SerialPort.GetPortNames.Contains(My.Settings.BarcodeScannerCOMPort1) Then
                                .BarCodePort.BaudRate = My.Settings.BarcodeScannerBaudRate
                                .BarCodePort.PortName = My.Settings.BarcodeScannerCOMPort1
                                .BarCodePort.Open()
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                End With
            Case 90
                txtLoad.Text = "Finalizing..."
                MdifrmMain.GrdActivity.Left = MdifrmMain.lblTodayIncomeNo.Left + MdifrmMain.lblTodayIncomeNo.Width + 5
            Case 99
                MdifrmMain.Visible = True
        End Select
        tmrSplash.Start()
    End Sub

    Private Sub FrmSplash_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub
End Class