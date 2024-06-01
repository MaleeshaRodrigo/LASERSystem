Imports System.Data.Odbc

Public Class FormRepair
    Private Db As New Database
    Public DataReaderRepair As OdbcDataReader
    Public Mode As RepairMode

    Public ControlReRepairView As ControlReRepairView
    Public ControlActivityInfo As ControlActivityInfo
    Public ControlAdvancePayInfo As ControlAdvancePayInfo
    Public ControlRemarks As ControlRemarks
    Public ControlRepairDeliverInfo As ControlRepairDeliverInfo
    Public ControlTaskInfo As ControlTaskInfo
    Public ControlTechnicianCostInfo As ControlTechnicianCostInfo
    Public ControlTechnicianInfo As ControlTechnicianInfo

    Public Sub New()
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub FrmRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        CmbRepNo_DropDown(sender, e)
        CmbRetNo_DropDown(sender, e)
        CmbRepNo_SelectedIndexChanged(Nothing, Nothing)
        CmbRetNo_SelectedIndexChanged(Nothing, Nothing)
        If Me.Tag = "" Then
            cmdDone.Enabled = False
        Else
            cmdDone.Enabled = True
        End If

        If tabRepair.SelectedIndex = 0 Then
            cmbRepNo.Focus()
            Mode = RepairMode.Repair
        Else
            cmbRetNo.Focus()
            Mode = RepairMode.ReRepair
        End If
    End Sub

    Private Sub frmRepair_Move(sender As Object, e As EventArgs) Handles Me.Move
        frmSearchDropDown.frm_Move()
    End Sub

    Private Sub frmRepair_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If tabRepair.SelectedTab.TabIndex = 0 Then
            cmbRepNo.Focus()
        Else
            cmbRetNo.Focus()
        End If
    End Sub

    Private Sub FrmRepair_Leave(sender As Object, e As EventArgs) Handles Me.Leave, cmdClose.Click, CloseToolStripMenuItem.Click
        DataReaderRepair.Close()
        Db.Disconnect()
    End Sub

    Private Sub CmbRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRepNo.DropDown
        Call ComboBoxDropDown(Db, cmbRepNo, "Select RepNo from Repair order by RepNo Desc")
    End Sub

    Private Sub CmbRetNo_DropDown(sender As Object, e As EventArgs) Handles cmbRetNo.DropDown
        If cmbRetRepNo.Text = "" Then
            Call ComboBoxDropDown(Db, cmbRetNo, "Select RetNo from `Return` order by RetNo Desc;")
        Else
            Call ComboBoxDropDown(Db, cmbRetNo, "Select RetNo from `Return` Where RepNo = " & cmbRetRepNo.Text & " order by RetNo Desc;")
        End If
    End Sub

    Private Sub cmbRetRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRetRepNo.DropDown
        Call ComboBoxDropDown(Db, cmbRetRepNo, "Select RepNo from `Return` Group By RepNo order by RepNo Desc;")
    End Sub

    Public Sub CmbRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRepNo.SelectedIndexChanged
        Try
            tabRepair.Tag = "Repair"
            tabRepair.SelectedTab.TabIndex = 0
            ClearControls()

            If cmbRepNo.Text = "" Then Exit Try
            DataReaderRepair = Db.GetDataReader("SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PDetails, PSerialNo,Problem,Qty,Charge, PaidPrice,REP.TNo, TName, Status, RepDate,REP.DNo, DDate, Location from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where Rep.Repno = " & cmbRepNo.Text)
            If DataReaderRepair.HasRows = False Then
                MsgBox("මෙම Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
                Exit Sub
            End If
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem}
                ctrl.Visible = True
            Next
            For Each ctrl As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem}
                ctrl.Enabled = True
            Next
            DataReaderRepair.Read()
            cmbRepStatus.Text = DataReaderRepair("Status").ToString
            SetBasicInfo()

            ControlReRepairView = New ControlReRepairView(Db)
            ControlReRepairView.Init(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlReRepairView)

            ControlRemarks = New ControlRemarks(Db, Me)
            ControlRemarks.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlRemarks)

            ControlTaskInfo = New ControlTaskInfo(Db)
            ControlTaskInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTaskInfo)

            ControlActivityInfo = New ControlActivityInfo(Db)
            ControlActivityInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlActivityInfo)
            If cmbRepStatus.Text = "Received" Then
                Exit Try
            End If

            ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
            ControlTechnicianInfo.Init()
            PanelMain.Controls.Add(ControlTechnicianInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 2)
            If cmbRepStatus.Text = "Hand Over to Technician" Then
                Exit Try
            End If

            ControlTechnicianCostInfo = New ControlTechnicianCostInfo(Db, Me)
            ControlTechnicianCostInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTechnicianCostInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianCostInfo, 3)
            If cmbRepStatus.Text = "Repairing" Then
                Exit Try
            End If

            ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
            ControlRepairDeliverInfo.SetRepDetails(
                DataReaderRepair("Charge").ToString,
                DataReaderRepair("RepDate").ToString
                ).SetDeliverInfoVisibility(False)
            PanelMain.Controls.Add(ControlRepairDeliverInfo)
            PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 4)
            If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Returnd Then Not Delivered" Then
                Exit Try
            End If

            ControlRepairDeliverInfo.SetDeliverDetails(
                DataReaderRepair("DNo").ToString,
                DataReaderRepair("PaidPrice").ToString,
                DataReaderRepair("DDate").ToString
                ).SetDeliverInfoVisibility(True)
            If (cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Delivered") And User.Instance.UserType <> User.Type.Admin And DateValue(DataReaderRepair("DDate").ToString).Month <> Today.Month Then
                For Each Item As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem, ControlActivityInfo, ControlAdvancePayInfo, ControlRemarks, ControlRepairDeliverInfo, ControlReRepairView, ControlTaskInfo, ControlTechnicianCostInfo, ControlTechnicianInfo}
                    If Item Is Nothing Then
                        Continue For
                    End If
                    Item.Enabled = False
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        End Try
    End Sub

    Private Sub SetBasicInfo()
        txtRNo.Text = DataReaderRepair("RNo").ToString
        txtRDate.Text = DataReaderRepair("RDate").ToString
        txtCuNo.Text = DataReaderRepair("CuNo").ToString
        TextCuName.Text = DataReaderRepair("CuName").ToString
        txtCuTelNo1.Text = DataReaderRepair("CuTelNo1").ToString
        txtCuTelNo2.Text = DataReaderRepair("CuTelNo2").ToString
        txtCuTelNo3.Text = DataReaderRepair("CuTelNo3").ToString
        txtPNo.Text = DataReaderRepair("PNo").ToString
        cmbPCategory.Text = DataReaderRepair("PCategory").ToString
        cmbPName.Text = DataReaderRepair("PName").ToString
        txtPModelNo.Text = DataReaderRepair("PModelNO").ToString
        txtPDetails.Text = DataReaderRepair("PDetails").ToString
        txtPSerialNo.Text = DataReaderRepair("PSerialNo").ToString
        txtPQty.Text = DataReaderRepair("Qty").ToString
        txtPProblem.Text = DataReaderRepair("Problem").ToString
    End Sub

    Private Sub cmbRepNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbRepNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            CmbRepNo_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub ClearControls()
        PanelMain.Controls.Clear()

        For Each Item As Control In {cmbRetRepNo, cmbRetStatus, cmbRepStatus, txtRNo, txtRDate, txtCuNo, TextCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3, txtPNo, cmbPCategory, cmbPName, txtPModelNo, txtPSerialNo, txtPDetails, txtPQty, txtPProblem}
            Item.Text = ""
        Next
        ControlActivityInfo?.Clear()
        ControlAdvancePayInfo?.Clear()
        ControlRemarks?.Clear()
        ControlRepairDeliverInfo?.Clear()
        ControlReRepairView?.Clear()
        ControlTaskInfo?.Clear()
        ControlTechnicianCostInfo?.Clear()
        ControlTechnicianInfo?.Clear()

        For Each Item As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem}
            Item.Visible = False
        Next
    End Sub

    Public Sub CmbRetNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRetNo.SelectedIndexChanged, cmbRetNo.Enter
        Try
            tabRepair.Tag = "Return"
            tabRepair.SelectedTab.TabIndex = 1
            ClearControls()

            If cmbRetNo.Text = "" Then Exit Try
            DataReaderRepair = Db.GetDataReader($"Select Ret.RetNo, RepNo, Ret.RNo, RDate,  R.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3, CuRemarks,  Ret.Pno, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Location, Qty, Ret.TNo, TName, Status, Charge, PaidPrice, RetRepDate, Ret.DNo, DDate FROM (((`Return` Ret inner join Receive R On Ret.RNo = R.RNo) INNER JOIN Customer Cu On R.CuNo = Cu.CuNo) INNER JOIN Product P On Ret.PNo = P.PNo) LEFT JOIN Technician T On Ret.TNo = T.TNo) LEFT JOIN Deliver D On D.DNo=Ret.DNo WHERE Ret.RetNo = ?O", {
                                                New OdbcParameter("RETNO", cmbRetNo.Text)
                                                })
            If DataReaderRepair.HasRows = False Then
                MsgBox("මෙම RE-Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
            End If
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem}
                ctrl.Visible = True
            Next
            For Each ctrl As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem}
                ctrl.Enabled = True
            Next
            DataReaderRepair.Read()
            cmbRetRepNo.Text = DataReaderRepair("RepNo").ToString
            cmbRetStatus.Text = DataReaderRepair("Status").ToString
            SetBasicInfo()

            ControlRemarks = New ControlRemarks(Db, Me)
            ControlRemarks.InitForReRepair(cmbRetNo.Text)
            PanelMain.Controls.Add(ControlRemarks)

            ControlTaskInfo = New ControlTaskInfo(Db)
            ControlTaskInfo.InitForReRepair(cmbRetRepNo.Text)
            PanelMain.Controls.Add(ControlTaskInfo)

            ControlActivityInfo = New ControlActivityInfo(Db)
            ControlActivityInfo.InitForReRepair(cmbRetRepNo.Text)
            PanelMain.Controls.Add(ControlActivityInfo)
            If cmbRetStatus.Text = "Received" Then
                Exit Try
            End If

            ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
            ControlTechnicianInfo.Init()
            PanelMain.Controls.Add(ControlTechnicianInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 1)
            If cmbRetStatus.Text = "Hand Over To Technician" Then
                Exit Try
            End If

            ControlTechnicianCostInfo = New ControlTechnicianCostInfo(Db, Me)
            ControlTechnicianCostInfo.InitForReRepair(cmbRetRepNo.Text)
            PanelMain.Controls.Add(ControlTechnicianCostInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianCostInfo, 2)
            If cmbRetStatus.Text = "Repairing" Then
                Exit Try
            End If

            ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
            ControlRepairDeliverInfo.SetRepDetails(
                DataReaderRepair("Charge"),
                DataReaderRepair("RetRepDate")
                ).SetDeliverInfoVisibility(False)
            PanelMain.Controls.Add(ControlRepairDeliverInfo)
            PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 3)
            If cmbRetStatus.Text = "Repaired Not Delivered" Or cmbRetStatus.Text = "Returned Not Delivered" Then
                Exit Try
            End If

            ControlRepairDeliverInfo.SetDeliverDetails(
                DataReaderRepair("DNo"),
                DataReaderRepair("PaidPrice"),
                DataReaderRepair("DDate")
                ).SetDeliverInfoVisibility(True)
            If (cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Delivered") And User.Instance.UserType <> User.Type.Admin And DateValue(DataReaderRepair("DDate").ToString).Month <> Today.Month Then
                For Each Item As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem, ControlActivityInfo, ControlAdvancePayInfo, ControlRemarks, ControlRepairDeliverInfo, ControlReRepairView, ControlTaskInfo, ControlTechnicianCostInfo, ControlTechnicianInfo}
                    If Item Is Nothing Then
                        Continue For
                    End If
                    Item.Enabled = False
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        End Try
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, UpdateToolStripMenuItem.Click
        Try
            If CheckEmptyControl(txtCuNo, "මෙම Repair එක සඳහා ඔබ Customer කෙනෙකු තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!") = False Then
                Exit Sub
            ElseIf CheckEmptyControl(txtPNo, "මෙම Repair එක සඳහා ඔබ Product එකක් තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!!") = False Then
                Exit Sub
            End If
            Dim ControlRepStatus As ComboBox = If(Mode = RepairMode.Repair, cmbRepStatus, cmbRetStatus)

            Dim TechnicianMustStatuses = New String() {"Hand Over To Technician", "Repairing", "Repaired Not Delivered", "Repaired Delivered"}
            If TechnicianMustStatuses.Contains(ControlRepStatus.Text) AndAlso CheckEmptyControl(ControlTechnicianInfo.cmbTName, "Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
                Exit Sub
            End If

            Dim RepairPriceMushStatuses = New String() {"Repaired Not Delivered", "Repaired Delivered", "Returned Not Delivered", "Returned Delivered"}
            If RepairPriceMushStatuses.Contains(ControlRepStatus.Text) AndAlso String.IsNullOrEmpty(ControlRepairDeliverInfo.txtRepPrice.Text) Then
                MessageBox.Error("Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.")
                Exit Sub
            End If

            Dim DeliveredStatuses = New String() {"Repaired Delivered", "Returned Delivered", "Canceled"}
            If (Not DeliveredStatuses.Contains(DataReaderRepair("Status").ToString)) And DeliveredStatuses.Contains(ControlRepStatus.Text) Then
                MessageBox.Error("මෙම Repair Form තුලින් මෙය සිදු කිරීමට නොහැකිය. Deliver Form එක භාවිතා කරන්න.")
                Exit Sub
            End If
            Select Case Mode
                Case RepairMode.Repair
                    If DataReaderRepair("Status").ToString <> cmbRepStatus.Text Then
                        Db.Execute("update Repair Set status ='" & cmbRepStatus.Text & "' where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Status -> " & cmbRepStatus.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("CuNo").ToString <> txtCuNo.Text Then
                        Db.Execute("update Receive set cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Customer -> Name= " & TextCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("RDate").ToString <> txtRDate.Value.ToString Then
                        Db.Execute("update Receive set RDate='" & txtRDate.Value.Date.ToString & "' where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Received Date -> " & txtRDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PNo").ToString <> txtPNo.Text Then
                        Db.Execute("update Repair set pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PSerialNo").ToString <> txtPSerialNo.Text Then
                        Db.Execute("update Repair set pserialno ='" & txtPSerialNo.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Product Serial No -> " & txtPSerialNo.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Problem").ToString <> txtPProblem.Text Then
                        Db.Execute("update Repair set Problem ='" & txtPProblem.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Problem -> " & txtPProblem.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Location").ToString <> ControlRemarks.cmbLocation.Text Then
                        Db.Execute("update Repair set Location= '" & ControlRemarks.cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Location -> " & ControlRemarks.cmbLocation.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If
                    Dim TNo As Integer = Db.GetData("SELECT TNo FROM Technician WHERE TName='" & ControlTechnicianInfo.cmbTName.Text & "'")
                    If DataReaderRepair("TNo").ToString <> TNo.ToString Then
                        Db.Execute("update Repair set tno =" & TNo & " where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Technician -> " & ControlTechnicianInfo.cmbTName.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRepStatus.Text.ToString = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If

                    If DataReaderRepair("Charge").ToString <> ControlRepairDeliverInfo.txtRepPrice.Text Then
                        Db.Execute("update Repair set charge=" & ControlRepairDeliverInfo.txtRepPrice.Text & " where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Repair Charge -> " & ControlRepairDeliverInfo.txtRepPrice.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("RepDate").ToString <> ControlRepairDeliverInfo.txtRepDate.Value.ToString Then
                        Db.Execute("update Repair set repdate='" & ControlRepairDeliverInfo.txtRepDate.Value.ToString & "' where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",'" & DateAndTime.Now & "','Repaired Date -> " & ControlRepairDeliverInfo.txtRepDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If

                    If Me.Tag = "" Then MsgBox("Update successful!", vbInformation + vbOKOnly)

                    Exit Sub
                Case RepairMode.ReRepair
                    If DataReaderRepair("Status").ToString <> cmbRetStatus.Text Then
                        Db.Execute("update `Return` set status ='" & cmbRetStatus.Text & "' where retno=" & cmbRetNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Status -> " & cmbRetStatus.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("CuNo").ToString <> txtCuNo.Text Then
                        Db.Execute("update Receive set Cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Customer -> Name= " & TextCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("RDate").ToString <> txtRDate.Value.ToString Then
                        Db.Execute("update Receive set RDate='" & txtRDate.Value.Date.ToString & "' where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Received Date -> " & txtRDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PNo").ToString <> txtPNo.Text Then
                        Db.Execute("update `Return` set pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PSerialNo").ToString <> txtPSerialNo.Text Then
                        Db.Execute("update `Return` set pserialno ='" & txtPSerialNo.Text & "' where retno = " & cmbRetNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Product Serial No -> " & txtPSerialNo.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Problem").ToString <> txtPProblem.Text Then
                        Db.Execute("update `Return` set problem ='" & txtPProblem.Text & "' where retno = " & cmbRetNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Problem -> " & txtPProblem.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Location").ToString <> ControlRemarks.cmbLocation.Text Then
                        Db.Execute("update `Return` set Location= '" & ControlRemarks.cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Location -> " & ControlRemarks.cmbLocation.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If cmbRetStatus.Text = "Received" Or cmbRetStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If

                    Dim TNo As Integer = Db.GetData("SELECT TNo FROM Technician WHERE TName='" & ControlTechnicianInfo.cmbTName.Text & "'")
                    If DataReaderRepair("TName").ToString <> ControlTechnicianInfo.cmbTName.Text Then
                        Db.Execute("update `Return` set tno =" & TNo & " where retno=" & cmbRetNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Technician -> " & ControlTechnicianInfo.cmbTName.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRetStatus.Text = "Hand Over to Technician" Or cmbRetStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If

                    If DataReaderRepair("Charge").ToString <> ControlRepairDeliverInfo.txtRepPrice.Text Then
                        Db.Execute("update `Return` set charge=" & ControlRepairDeliverInfo.txtRepPrice.Text & " where retno=" & cmbRetNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",'" & Now & "','Repair Charge -> " & ControlRepairDeliverInfo.txtRepPrice.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("RetRepDate").ToString <> ControlRepairDeliverInfo.txtRepDate.Value.ToString Then
                        Db.Execute($"UPDATE `Return` SET RetRepDate='{ControlRepairDeliverInfo.txtRepDate.Value}' WHERE RetNo={cmbRetNo.Text};")
                        Db.Execute($"INSERT INTO RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) VALUES({Db.GetNextKey("RepairActivity", "RepANo")},{cmbRetNo.Text},'{Now}','Repaired Date -> {ControlRepairDeliverInfo.txtRepDate.Value}',{User.Instance.UserNo})")
                    End If
                    If Me.Tag = "" Then
                        MsgBox("Update Successful!", vbInformation + vbOKOnly)
                    End If
            End Select
        Catch Exception As Exception
            MessageBox.Error(Exception.Message)
        Finally
            If tabRepair.SelectedTab.TabIndex = 0 Then
                CmbRepNo_SelectedIndexChanged(sender, e)
            End If
        End Try
    End Sub

    Public Sub CmbRepStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRepStatus.SelectionChangeCommitted, cmbRetStatus.SelectionChangeCommitted
        If sender Is cmbRepStatus And (cmbRepNo.Text = "" Or cmbRepStatus.Text = "") Then
            Exit Sub
        End If
        If sender Is cmbRetStatus And (cmbRetNo.Text = "" Or cmbRetStatus.Text = "") Then
            Exit Sub
        End If

        PanelMain.Controls.Remove(ControlTechnicianInfo)
        PanelMain.Controls.Remove(ControlTechnicianCostInfo)
        PanelMain.Controls.Remove(ControlRepairDeliverInfo)
        If sender.Text = "Received" Or sender.Text = "Canceled" Then
            Exit Sub
        End If

        ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
        PanelMain.Controls.Add(ControlTechnicianInfo)
        PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 2)
        ControlTechnicianInfo.Init()

        ControlTechnicianCostInfo = New ControlTechnicianCostInfo(Db, Me)
        PanelMain.Controls.Add(ControlTechnicianCostInfo)
        PanelMain.Controls.SetChildIndex(ControlTechnicianCostInfo, 3)
        If sender Is cmbRepStatus Then
            ControlTechnicianCostInfo.InitForRepair(cmbRepNo.Text)
        Else
            ControlTechnicianCostInfo.InitForReRepair(cmbRetNo.Text)
        End If
        If sender.Text = "Hand Over to Technician" Or sender.Text = "Repairing" Then
            Exit Sub
        End If

        ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
        PanelMain.Controls.Add(ControlRepairDeliverInfo)
        PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 4)
        ControlRepairDeliverInfo.SetDeliverInfoVisibility(False)
    End Sub

    Private Sub CmdRepView_Click(sender As Object, e As EventArgs) Handles cmdRepView.Click
        Dim frmSearchRepair As New frmSearch With {
            .Tag = "Repair",
            .Name = "frmSearch" + NextfrmNo(frmSearch).ToString
        }
        frmSearchRepair.Show()
    End Sub

    Private Sub CmdReRepView_Click(sender As Object, e As EventArgs) Handles cmdReRepView.Click
        Dim frmSearchReRepair As New frmSearch With {
            .Tag = "ReRepair",
            .Name = "frmSearch" + NextfrmNo(frmSearch).ToString
        }
        frmSearchReRepair.Show()
    End Sub

    Private Sub CmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click, DoneToolStripMenuItem.Click
        Select Case Me.Tag
            Case "DeliverRepair"
                With FormDeliver
                    Call CmdSave_Click(sender, e)
                    .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = cmbRepNo.Text
                    Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
                    Call .GrdRepair_CellEndEdit(sender, E1)
                End With
            Case "DeliverReRepair"
                With FormDeliver
                    .grdRERepair.Item(0, .grdRERepair.CurrentCell.RowIndex).Value = cmbRetNo.Text
                    Dim E1 As New DataGridViewCellEventArgs(0, .grdRERepair.CurrentCell.RowIndex)
                    Call .grdRERepair_CellEndEdit(sender, E1)
                End With
            Case "RepairAdvanced"
                With frmRepairAdvanced
                    .cmbRepNo.Text = cmbRepNo.Text
                    If tabRepair.SelectedTab.TabIndex = 0 Then
                        .rbRep.Checked = True
                    Else
                        .rbRERep.Checked = True
                    End If
                End With
        End Select
        Call FrmRepair_Leave(sender, e)
    End Sub

    Private Sub CmdCuView_Click(sender As Object, e As EventArgs) Handles cmdCuView.Click
        frmCustomer.Tag = "Repair"
        frmCustomer.Show()
    End Sub

    Private Sub CmbPCategory_DropDown(sender As Object, e As EventArgs) Handles cmbPCategory.DropDown
        Call ComboBoxDropDown(Db, cmbPCategory, "Select PCAtegory from Product Group by PCategory;")
    End Sub

    Private Sub CmbPCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPCategory.SelectedIndexChanged
        cmbPName.Text = ""
    End Sub

    Private Sub CmbPName_DropDown(sender As Object, e As EventArgs) Handles cmbPName.DropDown
        Call ComboBoxDropDown(Db, cmbPName, "Select PName from Product where PCategory='" & cmbPCategory.Text & "' group by PName;")
    End Sub

    Public Sub CmbPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPName.SelectedIndexChanged
        Dim DR As OdbcDataReader = Db.GetDataReader("Select * from Product where PCategory ='" & cmbPCategory.Text & "' and PName ='" & cmbPName.Text & "';")
        If DR.HasRows = True Then
            DR.Read()
            txtPNo.Text = DR("PNo").ToString
            txtPModelNo.Text = DR("PModelNo").ToString
            txtPDetails.Text = DR("PDetails").ToString
        End If
    End Sub

    Private Sub CmdPView_Click(sender As Object, e As EventArgs) Handles cmdPView.Click
        frmProduct.Tag = "Repair"
        frmProduct.Show()
    End Sub

    Private Sub MessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageToolStripMenuItem.Click
        With frmMessage
            .Tag = "Message"
            .Show()
            If tabRepair.SelectedTab.TabIndex = 0 Then
                .cmbField.Text = "Repair"
                .cmbRepNo.Text = cmbRepNo.Text
            ElseIf tabRepair.SelectedTab.TabIndex = 1 Then
                .cmbField.Text = "RERepair"
                .cmbRepNo.Text = cmbRetNo.Text
            End If
        End With
    End Sub

    Private Sub MessageToCustomerForRepairedProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageToCustomerForRepairedProductsToolStripMenuItem.Click
        With frmMessage
            .Tag = "MessagetoCu"
            .Show()
        End With
    End Sub

    Private Sub RepairInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairInfoToolStripMenuItem.Click
        If RepairInfoToolStripMenuItem.Text = "Repair Info" Then
            CmdRepView_Click(sender, e)
        Else
            CmdReRepView_Click(sender, e)
        End If
    End Sub

    Private Sub tabRepair_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabRepair.SelectedIndexChanged
        If tabRepair.SelectedIndex = 0 Then
            RepairInfoToolStripMenuItem.Text = "Repair Info"
            Mode = RepairMode.Repair
            CmbRepNo_SelectedIndexChanged(sender, e)
            cmbRepNo.Focus()
        Else
            Mode = RepairMode.ReRepair
            RepairInfoToolStripMenuItem.Text = "ReRepair Info"
            CmbRetNo_SelectedIndexChanged(sender, e)
            cmbRetNo.Focus()
        End If
    End Sub

    Private Sub PrintRepairStickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRepairStickerToolStripMenuItem.Click
        frmReceive.PrintSticker(txtRNo.Text, False, False, "RepairStickerReceipt")
    End Sub

    Private Sub PrintReceivedReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintReceivedReceiptToolStripMenuItem.Click
        frmReceive.PrintReceivedReceipt(txtRNo.Text, False, False, "RepairReceivedReceipt")
    End Sub

    Private Sub PrintDeliverReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDeliverReceiptToolStripMenuItem.Click
        If ControlRepairDeliverInfo Is Nothing Then Exit Sub
        FormDeliver.PrintDeliveryReceipt(ControlRepairDeliverInfo.txtDNo.Text, False)
    End Sub

    Private Sub PanelMain_Resize(sender As Object, e As EventArgs) Handles PanelMain.Resize, PanelMain.Paint
        If ControlActivityInfo IsNot Nothing Then
            ControlActivityInfo.Width = PanelMain.Width - 25
        End If
        If ControlAdvancePayInfo IsNot Nothing Then
            ControlAdvancePayInfo.Width = PanelMain.Width - 25
        End If
        If ControlRemarks IsNot Nothing Then
            ControlRemarks.Width = PanelMain.Width - 25
        End If
        If ControlRepairDeliverInfo IsNot Nothing Then
            ControlRepairDeliverInfo.Width = PanelMain.Width - 25
        End If
        If ControlReRepairView IsNot Nothing Then
            ControlReRepairView.Width = PanelMain.Width - 25
        End If
        If ControlTaskInfo IsNot Nothing Then
            ControlTaskInfo.Width = PanelMain.Width - 25
        End If
        If ControlTechnicianCostInfo IsNot Nothing Then
            ControlTechnicianCostInfo.Width = PanelMain.Width - 25
        End If
        If ControlTechnicianInfo IsNot Nothing Then
            ControlTechnicianInfo.Width = PanelMain.Width - 25
        End If
    End Sub
End Class