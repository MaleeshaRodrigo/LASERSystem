Imports System.Threading
Imports LASER_System.StructureDatabase
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class FormRepair
    Public DataReaderRepair As Dictionary(Of String, Object)
    Public Mode As RepairMode
    Public ControlReRepairView As ControlReRepairView
    Public ControlActivityInfo As ControlActivityInfo
    Public ControlAdvancePayInfo As ControlAdvancePayInfo
    Public ControlRemarks As ControlRemarks
    Public ControlRepairDeliverInfo As ControlRepairDeliverInfo
    Public ControlTaskInfo As ControlTaskInfo
    Public ControlTechnicianCostListInfo As ControlTechnicianCostListInfo
    Public ControlTechnicianInfo As ControlTechnicianInfo

    Private Db As New Database
    Private ReportPrintManager As New ReportPrintManager
    Private RepairController As New RepairController

    Public Sub New()
        InitializeComponent()

        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub FrmRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RepairController.SetDatabase(Db)
        CmbRepNo_DropDown(sender, e)
        CmbRetNo_DropDown(sender, e)
        CmbRepNo_SelectedIndexChanged(Nothing, Nothing)
        CmbRetNo_SelectedIndexChanged(Nothing, Nothing)
        If Tag = "" Then
            cmdDone.Enabled = False
        Else
            cmdDone.Enabled = True
        End If

        Enabled = True
        If tabRepair.SelectedIndex = 0 Then
            Mode = RepairMode.Repair
            cmbRepNo.Focus()
        Else
            Mode = RepairMode.ReRepair
            cmbRetNo.Focus()
        End If
    End Sub

    Private Sub frmRepair_Move(sender As Object, e As EventArgs) Handles Me.Move
        frmSearchDropDown.frm_Move()
    End Sub

    Private Sub frmRepair_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If tabRepair.SelectedTab.TabIndex = 0 Then
            cmbRepNo.Focus()
        Else
            cmbRetNo.Focus()
        End If
    End Sub

    Private Sub FrmRepair_Leave(sender As Object, e As EventArgs) Handles Me.Leave, cmdClose.Click, CloseToolStripMenuItem.Click
        DataReaderRepair = Nothing
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
            DataReaderRepair = Db.GetDataDictionary("SELECT RepNo, REP.RNo, RDate,  R.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3, REP.PNo, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Qty, Charge, PaidPrice, REP.AssignedToTNo, REP.HandedOverToTNo, T1.TName AS 'AssignedToTechnician', T2.TName AS 'HandedOverToTechnician', Status, RepDate,REP.DNo, DDate, Location from Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO INNER JOIN PRODUCT  P ON P.PNO = REP.PNO INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO LEFT JOIN Technician T1 ON T1.TNO = REP.AssignedToTNo LEFT JOIN Technician T2 ON T2.TNo = REP.HandedOverToTNo LEFT JOIN DELIVER D ON D.DNO = REP.DNO Where Rep.Repno = " & cmbRepNo.Text)
            If DataReaderRepair Is Nothing Then
                MsgBox("මෙම Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
                Exit Sub
            End If
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem, BoxReRepairView}
                ctrl.Visible = True
            Next
            For Each ctrl As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem}
                ctrl.Enabled = True
            Next
            cmbRepStatus.Text = DataReaderRepair("Status").ToString
            SetBasicInfo()

            ControlReRepairView = New ControlReRepairView().SetDatabase(Db)
            ControlReRepairView.Init(cmbRepNo.Text)

            ControlRemarks = New ControlRemarks(Db, Me)
            ControlRemarks.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlRemarks)

            ControlTaskInfo = New ControlTaskInfo(Db, Me)
            ControlTaskInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTaskInfo)

            ControlActivityInfo = New ControlActivityInfo(Db)
            ControlActivityInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlActivityInfo)
            If cmbRepStatus.Text = RepairStatus.Received Then
                Exit Try
            End If

            ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
            ControlTechnicianInfo.Init(DataReaderRepair(Repair.Status))
            PanelMain.Controls.Add(ControlTechnicianInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 2)
            If {RepairStatus.HandedOverTo, RepairStatus.AssignedTo}.Contains(cmbRepStatus.Text) Then
                Exit Try
            End If

            ControlTechnicianCostListInfo = New ControlTechnicianCostListInfo(Db, Me)
            ControlTechnicianCostListInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTechnicianCostListInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianCostListInfo, 3)
            If cmbRepStatus.Text = RepairStatus.Pending Then
                Exit Try
            End If

            ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
            ControlRepairDeliverInfo.SetRepDetails(
                DataReaderRepair("Charge").ToString,
                DataReaderRepair("RepDate").ToString
                ).SetDeliverInfoVisibility(False)
            PanelMain.Controls.Add(ControlRepairDeliverInfo)
            PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 4)
            If {RepairStatus.Repaired, RepairStatus.Returned}.Contains(cmbRepStatus.Text) Then
                Exit Try
            End If

            ControlRepairDeliverInfo.SetDeliverDetails(
                DataReaderRepair("DNo").ToString,
                DataReaderRepair("PaidPrice").ToString,
                DataReaderRepair("DDate").ToString
                ).SetDeliverInfoVisibility(True)
            If ({RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered}.Contains(cmbRepStatus.Text)) And User.Instance.UserType <> User.Type.Admin And DateValue(DataReaderRepair("DDate").ToString).Month <> Today.Month Then
                For Each Item As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem, ControlActivityInfo, ControlAdvancePayInfo, ControlRemarks, ControlRepairDeliverInfo, ControlReRepairView, ControlTaskInfo, ControlTechnicianCostListInfo, ControlTechnicianInfo}
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
        txtPModelNo.Text = DataReaderRepair("PModelNo").ToString
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
        ControlReRepairView?.Clear()
        ControlActivityInfo?.Clear()
        ControlAdvancePayInfo?.Clear()
        ControlRemarks?.Clear()
        ControlRepairDeliverInfo?.Clear()
        ControlReRepairView?.Clear()
        ControlTaskInfo?.Clear()
        ControlTechnicianCostListInfo?.Clear()
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
            DataReaderRepair = Db.GetDataDictionary($"Select Ret.RetNo, RepNo, Ret.RNo, RDate,  R.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3, CuRemarks,  Ret.PNo, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Location, Qty, Ret.AssignedToTNo, Ret.HandedOverToTNo, T1.TName AS 'AssignedToTechnician', T2.TName AS 'HandedOverToTechnician', TName, Status, Charge, PaidPrice, RepDate, Ret.DNo, DDate FROM `Return` Ret inner join Receive R On Ret.RNo = R.RNo INNER JOIN Customer Cu On R.CuNo = Cu.CuNo INNER JOIN Product P On Ret.PNo = P.PNo LEFT JOIN Technician T1 On Ret.AssignedToTNo = T1.TNo LEFT JOIN Technician T2 ON Ret.HandedOverToTNo = T2.TNo LEFT JOIN Deliver D On D.DNo=Ret.DNo WHERE Ret.RetNo = @RETNO", {
                New MySqlParameter("RETNO", cmbRetNo.Text)
            })
            If DataReaderRepair Is Nothing Then
                MsgBox("මෙම RE-Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
            End If
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem}
                ctrl.Visible = True
            Next
            For Each ctrl As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem}
                ctrl.Enabled = True
            Next
            cmbRetRepNo.Text = DataReaderRepair("RepNo").ToString
            cmbRetStatus.Text = DataReaderRepair("Status").ToString
            SetBasicInfo()

            ControlRemarks = New ControlRemarks(Db, Me)
            ControlRemarks.InitForReRepair(cmbRetNo.Text)
            PanelMain.Controls.Add(ControlRemarks)

            ControlTaskInfo = New ControlTaskInfo(Db, Me)
            ControlTaskInfo.InitForReRepair(cmbRetNo.Text)
            PanelMain.Controls.Add(ControlTaskInfo)

            ControlActivityInfo = New ControlActivityInfo(Db)
            ControlActivityInfo.InitForReRepair(cmbRetNo.Text)
            PanelMain.Controls.Add(ControlActivityInfo)
            If cmbRetStatus.Text = RepairStatus.Received Then
                Exit Try
            End If

            ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
            ControlTechnicianInfo.Init(DataReaderRepair(ReRepair.Status))
            PanelMain.Controls.Add(ControlTechnicianInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 1)
            If {RepairStatus.HandedOverTo, RepairStatus.AssignedTo}.Contains(cmbRetStatus.Text) Then
                Exit Try
            End If

            ControlTechnicianCostListInfo = New ControlTechnicianCostListInfo(Db, Me)
            ControlTechnicianCostListInfo.InitForReRepair(cmbRetRepNo.Text)
            PanelMain.Controls.Add(ControlTechnicianCostListInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianCostListInfo, 2)
            If cmbRetStatus.Text = RepairStatus.Pending Then
                Exit Try
            End If

            ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
            ControlRepairDeliverInfo.SetRepDetails(
                DataReaderRepair("Charge"),
                DataReaderRepair("RepDate")
                ).SetDeliverInfoVisibility(False)
            PanelMain.Controls.Add(ControlRepairDeliverInfo)
            PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 3)
            If {RepairStatus.Repaired, RepairStatus.Returned}.Contains(cmbRetStatus.Text) Then
                Exit Try
            End If

            ControlRepairDeliverInfo.SetDeliverDetails(
                DataReaderRepair("DNo"),
                DataReaderRepair("PaidPrice"),
                DataReaderRepair("DDate")
                ).SetDeliverInfoVisibility(True)
            If ({RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered}.Contains(cmbRepStatus.Text)) And User.Instance.UserType <> User.Type.Admin And DateValue(DataReaderRepair("DDate").ToString).Month <> Today.Month Then
                For Each Item As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem, ControlActivityInfo, ControlAdvancePayInfo, ControlRemarks, ControlRepairDeliverInfo, ControlReRepairView, ControlTaskInfo, ControlTechnicianCostListInfo, ControlTechnicianInfo}
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
        Dim Database As New TransactionDatabase
        Try
            If CheckEmptyControl(txtCuNo, "මෙම Repair එක සඳහා ඔබ Customer කෙනෙකු තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!") = False Then
                Return
            ElseIf CheckEmptyControl(txtPNo, "මෙම Repair එක සඳහා ඔබ Product එකක් තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!!") = False Then
                Return
            End If
            Dim ControlRepStatus As ComboBox = If(Mode = RepairMode.Repair, cmbRepStatus, cmbRetStatus)
            Dim TechnicianMustStatuses = New String() {
                RepairStatus.HandedOverTo, RepairStatus.Pending, RepairStatus.Repaired, RepairStatus.Returned, RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered
            }
            If TechnicianMustStatuses.Contains(ControlRepStatus.Text) AndAlso CheckEmptyControl(ControlTechnicianInfo.ComboHandOverToTechnician, "Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
                Return
            End If

            Dim RepairPriceMushStatuses = New String() {"Repaired Not Delivered", "Repaired Delivered", "Returned Not Delivered", "Returned Delivered"}
            If RepairPriceMushStatuses.Contains(ControlRepStatus.Text) AndAlso String.IsNullOrEmpty(ControlRepairDeliverInfo.txtRepPrice.Text) Then
                MessageBox.Error("Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.")
                Return
            End If

            Dim DeliveredStatuses = New String() {"Repaired Delivered", "Returned Delivered", "Canceled"}
            If (Not DeliveredStatuses.Contains(DataReaderRepair("Status").ToString)) And DeliveredStatuses.Contains(ControlRepStatus.Text) Then
                MessageBox.Error("මෙම Repair Form තුලින් මෙය සිදු කිරීමට නොහැකිය. Deliver Form එක භාවිතා කරන්න.")
                Return
            End If

            If User.Instance.UserType <> User.Type.Admin AndAlso DeliveredStatuses.Contains(DataReaderRepair("Status").ToString) AndAlso DataReaderRepair("Status").ToString <> cmbRepStatus.Text Then
                MessageBox.Error("Delivered හෝ  Canceled Product එකක් නැවත Status එක වෙනස් කිරීමට ඔබ්ට Permission නොමැත.")
                Return
            End If

            Database.BeginTransaction()
            Select Case Mode
                Case RepairMode.Repair
                    If DataReaderRepair("Status").ToString <> cmbRepStatus.Text Then
                        Database.Execute($"UPDATE {Tables.Repair} SET Status = @STATUS WHERE RepNo = @REPNO;", {
                            New MySqlParameter("STATUS", cmbRepStatus.Text),
                            New MySqlParameter("REPNO", cmbRepNo.Text)
                        })
                        RepairController.InsertRepairActivity(Mode, cmbRepNo.Text, "UPDATE: " + JsonConvert.SerializeObject({
                           {"Status", cmbRepStatus.Text}
                        }))
                    End If

                    If DataReaderRepair("CuNo").ToString <> txtCuNo.Text Then
                        Database.Execute($"UPDATE {Tables.Receive} SET CuNo = @CUNO WHERE RNo = @RNO;", {
                            New MySqlParameter("CUNO", txtCuNo.Text),
                            New MySqlParameter("RNO", txtRNo.Text)
                        })
                        RepairController.InsertRepairActivity(Mode, cmbRepNo.Text, "UPDATE: " + JsonConvert.SerializeObject({
                           {"Customer Name", TextCuName.Text},
                           {"Telephone No 1", txtCuTelNo1.Text},
                           {"Telephone No 2", txtCuTelNo2.Text},
                           {"Telephone No 3", txtCuTelNo3.Text}
                        }))
                    End If

                    If DataReaderRepair("RDate").ToString <> txtRDate.Value.ToString Then
                        Database.Execute($"UPDATE {Tables.Receive} SET RDate='" & txtRDate.Value.Date.ToString & "' where rno = " & txtRNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Received Date -> " & txtRDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PNo").ToString <> txtPNo.Text Then
                        Database.Execute($"UPDATE {Tables.Repair} SET pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PSerialNo").ToString <> txtPSerialNo.Text Then
                        Database.Execute($"UPDATE {Tables.Repair} SET pserialno ='" & txtPSerialNo.Text & "' where repno = " & cmbRepNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Product Serial No -> " & txtPSerialNo.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Problem").ToString <> txtPProblem.Text Then
                        Database.Execute($"UPDATE {Tables.Repair} SET Problem ='" & txtPProblem.Text & "' where repno = " & cmbRepNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Problem -> " & txtPProblem.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Location").ToString <> ControlRemarks.cmbLocation.Text Then
                        Database.Execute($"UPDATE {Tables.Repair} SET Location= '" & ControlRemarks.cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Location -> " & ControlRemarks.cmbLocation.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Return
                    End If
                    Dim TNo As Integer = Database.GetData("SELECT TNo FROM Technician WHERE TName='" & ControlTechnicianInfo.ComboHandOverToTechnician.Text & "'")
                    If DataReaderRepair("HandedOverToTNo").ToString <> TNo.ToString Then
                        Database.Execute($"UPDATE {Tables.Repair} SET tno =" & TNo & " where repno=" & cmbRepNo.Text & ";")
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Technician -> " & ControlTechnicianInfo.ComboHandOverToTechnician.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRepStatus.Text.ToString = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Return
                    End If

                    If DataReaderRepair("Charge").ToString <> ControlRepairDeliverInfo.txtRepPrice.Text Then
                        Database.Execute($"UPDATE {Tables.Repair} SET charge=" & ControlRepairDeliverInfo.txtRepPrice.Text & " where repno=" & cmbRepNo.Text & ";")
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Repair Charge -> " & ControlRepairDeliverInfo.txtRepPrice.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("RepDate").ToString <> ControlRepairDeliverInfo.txtRepDate.Value.ToString Then
                        Database.Execute($"UPDATE {Tables.Repair} SET RepDate=@REPDATE WHERE RepNo=@REPNO;", {
                            New MySqlParameter("REPDATE", ControlRepairDeliverInfo.txtRepDate.Value),
                            New MySqlParameter("REPNO", cmbRepNo.Text)
                        })
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",NOW(),'Repaired Date -> " & ControlRepairDeliverInfo.txtRepDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If

                    If Tag = "" Then MsgBox("Update successful!", vbInformation + vbOKOnly)

                    Return
                Case RepairMode.ReRepair
                    If DataReaderRepair("Status").ToString <> cmbRetStatus.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set status ='" & cmbRetStatus.Text & "' where retno=" & cmbRetNo.Text & ";")
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Status -> " & cmbRetStatus.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("CuNo").ToString <> txtCuNo.Text Then
                        Database.Execute($"UPDATE {Tables.Receive} SET Cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Customer -> Name= " & TextCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("RDate").ToString <> txtRDate.Value.ToString Then
                        Database.Execute($"UPDATE {Tables.Receive} SET RDate='" & txtRDate.Value.Date.ToString & "' where rno = " & txtRNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Received Date -> " & txtRDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("PNo").ToString <> txtPNo.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set pno = " & txtPNo.Text & " where RetNo = " & cmbRetNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("PSerialNo").ToString <> txtPSerialNo.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set pserialno ='" & txtPSerialNo.Text & "' where retno = " & cmbRetNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Product Serial No -> " & txtPSerialNo.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("Problem").ToString <> txtPProblem.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set problem ='" & txtPProblem.Text & "' where retno = " & cmbRetNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Problem -> " & txtPProblem.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("Location").ToString <> ControlRemarks.cmbLocation.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set Location= '" & ControlRemarks.cmbLocation.Text & "' where RetNo = " & cmbRetNo.Text)
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Location -> " & ControlRemarks.cmbLocation.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRetStatus.Text = "Received" Or cmbRetStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Return
                    End If

                    Dim TNo As Integer = Database.GetData("SELECT TNo FROM Technician WHERE TName='" & ControlTechnicianInfo.ComboHandOverToTechnician.Text & "'")
                    If DataReaderRepair("TName").ToString <> ControlTechnicianInfo.ComboHandOverToTechnician.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set tno =" & TNo & " where retno=" & cmbRetNo.Text & ";")
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Technician -> " & ControlTechnicianInfo.ComboHandOverToTechnician.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRetStatus.Text = "Hand Over to Technician" Or cmbRetStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Return
                    End If

                    If DataReaderRepair("Charge").ToString <> ControlRepairDeliverInfo.txtRepPrice.Text Then
                        Database.Execute($"update `{Tables.ReRepair}` set charge=" & ControlRepairDeliverInfo.txtRepPrice.Text & " where retno=" & cmbRetNo.Text & ";")
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Database.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",NOW(),'Repair Charge -> " & ControlRepairDeliverInfo.txtRepPrice.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("RepDate").ToString <> ControlRepairDeliverInfo.txtRepDate.Value.ToString Then
                        Database.Execute($"UPDATE `{Tables.ReRepair}` SET RepDate=@REPDATE WHERE RetNo=@RETNO;", {
                            New MySqlParameter("REPDATE", ControlRepairDeliverInfo.txtRepDate.Value),
                            New MySqlParameter("RETNO", cmbRetNo.Text)
                        })
                        Database.Execute($"INSERT INTO {Tables.RepairActivity}(RepANo,RetNo,RepADate,Activity,UNo) VALUES({Database.GetNextKey("RepairActivity", "RepANo")},{cmbRetNo.Text},NOW(),'Repaired Date -> {ControlRepairDeliverInfo.txtRepDate.Value}',{User.Instance.UserNo})")
                    End If
                    If Tag = "" Then
                        MsgBox("Update Successful!", vbInformation + vbOKOnly)
                    End If
                    If tabRepair.SelectedTab.TabIndex = 0 Then
                        CmbRepNo_SelectedIndexChanged(sender, e)
                    End If
            End Select
        Catch Exception As Exception
            MessageBox.Error(Exception.Message)
            Database.RollbackTransaction()
        Finally
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
        PanelMain.Controls.Remove(ControlTechnicianCostListInfo)
        PanelMain.Controls.Remove(ControlRepairDeliverInfo)
        If sender.Text = "Received" Or sender.Text = "Canceled" Then
            Exit Sub
        End If

        ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
        PanelMain.Controls.Add(ControlTechnicianInfo)
        PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 2)
        ControlTechnicianInfo.Init(cmbRepStatus.Text)

        ControlTechnicianCostListInfo = New ControlTechnicianCostListInfo(Db, Me)
        PanelMain.Controls.Add(ControlTechnicianCostListInfo)
        PanelMain.Controls.SetChildIndex(ControlTechnicianCostListInfo, 3)
        If sender Is cmbRepStatus Then
            ControlTechnicianCostListInfo.InitForRepair(cmbRepNo.Text)
        Else
            ControlTechnicianCostListInfo.InitForReRepair(cmbRetNo.Text)
        End If
        If sender.Text = "Hand Over to Technician" Or sender.Text = "Repairing" Then
            ControlTechnicianInfo.ComboHandOverToTechnician.Focus()
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
        Select Case Tag
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
        Dim DR = Db.GetDataDictionary("Select * from Product where PCategory ='" & cmbPCategory.Text & "' and PName ='" & cmbPName.Text & "';")
        If DR.Count Then
            txtPNo.Text = DR("PNo").ToString
            txtPModelNo.Text = DR("PModelNo").ToString
            txtPDetails.Text = DR("PDetails").ToString
        End If
    End Sub

    Private Sub CmdPView_Click(sender As Object, e As EventArgs) Handles cmdPView.Click
        frmProduct.Tag = "Repair"
        frmProduct.Show()
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
        ReportPrintManager.PrintRepairSticker(txtRNo.Text, False, False, "RepairStickerReceipt")
    End Sub

    Private Sub PrintReceivedReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintReceivedReceiptToolStripMenuItem.Click
        ReportPrintManager.PrintReceivedReceipt(txtRNo.Text, False, False, "RepairReceivedReceipt")
    End Sub

    Private Sub PrintDeliverReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDeliverReceiptToolStripMenuItem.Click
        If ControlRepairDeliverInfo Is Nothing OrElse IsNumeric(ControlRepairDeliverInfo.txtDNo.Text) = False Then Exit Sub
        Dim DNo As Integer = Int(ControlRepairDeliverInfo.txtDNo.Text)
        Dim threadDeliver As New Thread(Sub()
                                            FormDeliver.PrintDeliveryReceipt(DNo, False)
                                        End Sub) With {
            .Name = "showDeliverReceiptReport",
        .IsBackground = False,
        .Priority = ThreadPriority.Highest}
        threadDeliver.SetApartmentState(ApartmentState.STA)
        threadDeliver.Start()
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
        If ControlTechnicianCostListInfo IsNot Nothing Then
            ControlTechnicianCostListInfo.Width = PanelMain.Width - 25
        End If
        If ControlTechnicianInfo IsNot Nothing Then
            ControlTechnicianInfo.Width = PanelMain.Width - 25
        End If
    End Sub
End Class