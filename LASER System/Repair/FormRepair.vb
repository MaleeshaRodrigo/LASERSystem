Imports System.Threading
Imports LASER_System.StructureDatabase
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class FormRepair
    Public DataReaderRepair As Dictionary(Of String, Object)
    Public Mode As RepairMode
    Public ControlActivityInfo As ControlActivityInfo
    Public ControlAdvancePayInfo As ControlAdvancePayInfo
    Public ControlRemarks As ControlRemarks
    Public ControlRepairDeliverInfo As ControlRepairDeliverInfo
    Public ControlTaskInfo As ControlTaskInfo
    Public ControlTechnicianCostListInfo As ControlTechnicianCostListInfo
    Public ControlTechnicianInfo As ControlTechnicianInfo

    Private Db As New Database
    Private TransactionDatabase As TransactionDatabase
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

            If cmbRepNo.Text = "" Then
                Return
            End If

            DataReaderRepair = Db.GetDataDictionary("SELECT RepNo, REP.RNo, RDate,  R.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3, REP.PNo, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Qty, Charge, PaidPrice, REP.AssignedToTNo, REP.HandedOverToTNo, T1.TName AS 'AssignedToTechnician', T2.TName AS 'HandedOverToTechnician', Status, RepDate,REP.DNo, DDate, Location from Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO INNER JOIN PRODUCT  P ON P.PNO = REP.PNO INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO LEFT JOIN Technician T1 ON T1.TNO = REP.AssignedToTNo LEFT JOIN Technician T2 ON T2.TNo = REP.HandedOverToTNo LEFT JOIN DELIVER D ON D.DNO = REP.DNO Where Rep.Repno = " & cmbRepNo.Text)
            If DataReaderRepair Is Nothing Then
                MsgBox("මෙම Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
                Return
            End If
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem, ControlReRepairView}
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
                Return
            End If

            ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
            ControlTechnicianInfo.Init(DataReaderRepair(Repair.Status))
            PanelMain.Controls.Add(ControlTechnicianInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 2)
            If {RepairStatus.HandedOverTo, RepairStatus.AssignedTo}.Contains(cmbRepStatus.Text) Then
                Return
            End If

            ControlTechnicianCostListInfo = New ControlTechnicianCostListInfo(Db, Me)
            ControlTechnicianCostListInfo.InitForRepair(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTechnicianCostListInfo)
            PanelMain.Controls.SetChildIndex(ControlTechnicianCostListInfo, 3)
            If cmbRepStatus.Text = RepairStatus.Pending Then
                Return
            End If

            ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
            ControlRepairDeliverInfo.SetRepDetails(
                DataReaderRepair("Charge").ToString,
                DataReaderRepair("RepDate").ToString
                ).SetDeliverInfoVisibility(False)
            PanelMain.Controls.Add(ControlRepairDeliverInfo)
            PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 4)
            If {RepairStatus.Repaired, RepairStatus.Returned}.Contains(cmbRepStatus.Text) Then
                Return
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
            DataReaderRepair = Db.GetDataDictionary($"Select Ret.RetNo, RepNo, Ret.RNo, RDate,  R.CuNo, CuName, CuTelNo1, CuTelNo2, CuTelNo3, CuRemarks,  Ret.PNo, PCategory, PName, PModelNo, PDetails, PSerialNo, Problem, Location, Qty, Ret.AssignedToTNo, Ret.HandedOverToTNo, T1.TName AS 'AssignedToTechnician', T2.TName AS 'HandedOverToTechnician', Status, Charge, PaidPrice, RepDate, Ret.DNo, DDate FROM `Return` Ret inner join Receive R On Ret.RNo = R.RNo INNER JOIN Customer Cu On R.CuNo = Cu.CuNo INNER JOIN Product P On Ret.PNo = P.PNo LEFT JOIN Technician T1 On Ret.AssignedToTNo = T1.TNo LEFT JOIN Technician T2 ON Ret.HandedOverToTNo = T2.TNo LEFT JOIN Deliver D On D.DNo=Ret.DNo WHERE Ret.RetNo = @RETNO", {
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
            cmbRetStatus.Text = DataReaderRepair(ReRepair.Status).ToString
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
        Try
            If Not SaveValidateInputs() Then
                Return
            End If

            TransactionDatabase = New TransactionDatabase()
            TransactionDatabase.BeginTransaction()
            Select Case Mode
                Case RepairMode.Repair
                    UpdateRepair()
                Case RepairMode.ReRepair
                    UpdateReRepair()
            End Select
            TransactionDatabase.CommitTransaction()
            MsgBox("Update successful!", vbInformation + vbOKOnly)
        Catch Exception As Exception
            MessageBox.Error(Exception.Message)
            TransactionDatabase.RollbackTransaction()
        Finally
            TransactionDatabase = Nothing
        End Try
    End Sub

    Public Sub CmbRepStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRepStatus.SelectionChangeCommitted, cmbRetStatus.SelectionChangeCommitted
        If sender Is cmbRepStatus And (cmbRepNo.Text = "" Or cmbRepStatus.Text = "") Then
            Return
        End If
        If sender Is cmbRetStatus And (cmbRetNo.Text = "" Or cmbRetStatus.Text = "") Then
            Return
        End If

        PanelMain.Controls.Remove(ControlTechnicianInfo)
        PanelMain.Controls.Remove(ControlTechnicianCostListInfo)
        PanelMain.Controls.Remove(ControlRepairDeliverInfo)
        If sender.Text = RepairStatus.Received Or sender.Text = RepairStatus.Canceled Then
            Return
        End If

        ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
        PanelMain.Controls.Add(ControlTechnicianInfo)
        PanelMain.Controls.SetChildIndex(ControlTechnicianInfo, 2)
        ControlTechnicianInfo.Init(If(sender Is cmbRepStatus, cmbRepStatus.Text, cmbRetStatus.Text))

        If sender.text = RepairStatus.AssignedTo Then
            Return
        End If

        ControlTechnicianCostListInfo = New ControlTechnicianCostListInfo(Db, Me)
        PanelMain.Controls.Add(ControlTechnicianCostListInfo)
        PanelMain.Controls.SetChildIndex(ControlTechnicianCostListInfo, 3)
        If sender Is cmbRepStatus Then
            ControlTechnicianCostListInfo.InitForRepair(cmbRepNo.Text)
        Else
            ControlTechnicianCostListInfo.InitForReRepair(cmbRetNo.Text)
        End If
        If sender.Text = RepairStatus.HandedOverTo Or sender.Text = RepairStatus.Pending Then
            ControlTechnicianInfo.ComboHandOverToTechnician.Focus()
            Return
        End If

        ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
        PanelMain.Controls.Add(ControlRepairDeliverInfo)
        PanelMain.Controls.SetChildIndex(ControlRepairDeliverInfo, 4)
        ControlRepairDeliverInfo.SetDeliverInfoVisibility(False)
    End Sub

    Private Function SaveValidateInputs() As Boolean
        If CheckEmptyControl(txtCuNo, "මෙම Repair එක සඳහා ඔබ Customer කෙනෙකු තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!") = False Then
            Return False
        End If

        If CheckEmptyControl(txtPNo, "මෙම Repair එක සඳහා ඔබ Product එකක් තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!!") = False Then
            Return False
        End If

        Dim ControlRepStatus As ComboBox = If(Mode = RepairMode.Repair, cmbRepStatus, cmbRetStatus)
        Dim TechnicianMustStatuses = New String() {RepairStatus.AssignedTo, RepairStatus.HandedOverTo, RepairStatus.Pending, RepairStatus.Repaired, RepairStatus.Returned, RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered}
        If TechnicianMustStatuses.Contains(ControlRepStatus.Text) AndAlso CheckEmptyControl(ControlTechnicianInfo.ComboAssignedToTechnician, "Assigned Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
            Return False
        End If

        If TechnicianMustStatuses.Except({RepairStatus.AssignedTo}).Contains(ControlRepStatus.Text) AndAlso CheckEmptyControl(ControlTechnicianInfo.ComboHandOverToTechnician, "Handed Over Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
            Return False
        End If

        Dim RepairPriceMushStatuses = New String() {RepairStatus.Repaired, "Repaired Delivered", RepairStatus.Returned, "Returned Delivered"}
        If RepairPriceMushStatuses.Contains(ControlRepStatus.Text) AndAlso String.IsNullOrEmpty(ControlRepairDeliverInfo.txtRepPrice.Text) Then
            MessageBox.Error("Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.")
            Return False
        End If

        Dim DeliveredStatuses = New String() {"Repaired Delivered", "Returned Delivered", "Canceled"}
        If (Not DeliveredStatuses.Contains(DataReaderRepair("Status").ToString)) And DeliveredStatuses.Contains(ControlRepStatus.Text) Then
            MessageBox.Error("මෙම Repair Form තුලින් මෙය සිදු කිරීමට නොහැකිය. Deliver Form එක භාවිතා කරන්න.")
            Return False
        End If

        If User.Instance.UserType <> User.Type.Admin AndAlso DeliveredStatuses.Contains(DataReaderRepair("Status").ToString) AndAlso DataReaderRepair("Status").ToString <> cmbRepStatus.Text Then
            MessageBox.Error("Delivered හෝ  Canceled Product එකක් නැවත Status එක වෙනස් කිරීමට ඔබ්ට Permission නොමැත.")
            Return False
        End If

        Return True
    End Function

    Private Sub UpdateRepair()
        Dim Activity As New Dictionary(Of String, Object)
        If UpdateRepairField(Repair.Status, cmbRepStatus.Text) Then
            Activity.Add("Status", cmbRepStatus.Text)
        End If

        If UpdateOtherField(Receive.RDate, txtRDate.Value.Date, Tables.Receive, Receive.RNo, txtRNo.Text) Then
            Activity.Add("Received Date", txtRDate.Value.Date)
        End If

        If UpdateOtherField(Receive.CuNo, txtCuNo.Text, Tables.Receive, Receive.RNo, txtRNo.Text) Then
            Activity.Add("Customer Name", TextCuName.Text)
            Activity.Add("Telephone No 1", txtCuTelNo1.Text)
            Activity.Add("Telephone No 2", txtCuTelNo2.Text)
            Activity.Add("Telephone No 3", txtCuTelNo3.Text)
        End If

        If UpdateRepairField(Repair.PNo, txtPNo.Text) Then
            Activity.Add("Product", cmbPCategory.Text + " " + cmbPName.Text)
            Activity.Add("Model No", txtPModelNo.Text)
            Activity.Add("Details", txtPDetails.Text)
        End If

        If UpdateRepairField(Repair.PSerialNo, txtPSerialNo.Text) Then
            Activity.Add("Product Serial No", txtPSerialNo.Text)
        End If

        If UpdateRepairField(Repair.Problem, txtPProblem.Text) Then
            Activity.Add("Problem", txtPProblem.Text)
        End If

        If UpdateRepairField(Repair.Location, ControlRemarks.cmbLocation.Text) Then
            Activity.Add("Location", ControlRemarks.cmbLocation.Text)
        End If

        If {RepairStatus.Received, RepairStatus.Canceled}.Contains(cmbRepStatus.Text) Then
            Return
        End If

        Dim AssignedTechnician = ControlTechnicianInfo.GetAssignedTechnician()
        If IsNothing(AssignedTechnician) = False AndAlso UpdateRepairField(Repair.AssignedToTNo, AssignedTechnician.No) Then
            Activity.Add("Technician", AssignedTechnician.Name)
        End If

        Dim HandedOverTechnician = ControlTechnicianInfo.GetHandedOverTechnician()
        If IsNothing(HandedOverTechnician) = False AndAlso UpdateRepairField(Repair.HandedOverToTNo, HandedOverTechnician.No) Then
            Activity.Add("Technician", HandedOverTechnician.Name)
        End If

        If {RepairStatus.AssignedTo, RepairStatus.HandedOverTo, RepairStatus.Pending}.Contains(cmbRepStatus.Text) Then
            Return
        End If

        If UpdateRepairField(Repair.Charge, ControlRepairDeliverInfo.txtRepPrice.Text) Then
            Activity.Add("Repair Charge", ControlRepairDeliverInfo.txtRepPrice.Text)
        End If

        If UpdateRepairField(Repair.RepDate, ControlRepairDeliverInfo.txtRepDate.Value) Then
            Activity.Add("Repaired Date", ControlRepairDeliverInfo.txtRepDate.Value)
        End If

        If Activity.Count < 1 Then
            Return
        End If

        RepairController.SetDatabase(TransactionDatabase)
        RepairController.InsertRepairActivity(Mode, cmbRepNo.Text, "UPDATE: " + JsonConvert.SerializeObject(Activity))
    End Sub

    Private Sub UpdateReRepair()
        Dim Activity As New Dictionary(Of String, Object)
        If UpdateRepairField(ReRepair.Status, cmbRetStatus.Text) Then
            Activity.Add("Status", cmbRetStatus.Text)
        End If

        If UpdateOtherField(Receive.RDate, txtRDate.Value.Date, Tables.Receive, Receive.RNo, txtRNo.Text) Then
            Activity.Add("Received Date", txtRDate.Value.Date)
        End If

        If UpdateOtherField(Receive.CuNo, txtCuNo.Text, Tables.Receive, Receive.RNo, txtRNo.Text) Then
            Activity.Add("Customer Name", TextCuName.Text)
            Activity.Add("Telephone No 1", txtCuTelNo1.Text)
            Activity.Add("Telephone No 2", txtCuTelNo2.Text)
            Activity.Add("Telephone No 3", txtCuTelNo3.Text)
        End If

        If UpdateRepairField(ReRepair.PNo, txtPNo.Text) Then
            Activity.Add("Product", cmbPCategory.Text + " " + cmbPName.Text)
            Activity.Add("Model No", txtPModelNo.Text)
            Activity.Add("Details", txtPDetails.Text)
        End If

        If UpdateRepairField(ReRepair.PSerialNo, txtPSerialNo.Text) Then
            Activity.Add("Product Serial No", txtPSerialNo.Text)
        End If

        If UpdateRepairField(ReRepair.Problem, txtPProblem.Text) Then
            Activity.Add("Problem", txtPProblem.Text)
        End If

        If UpdateRepairField(ReRepair.Location, ControlRemarks.cmbLocation.Text) Then
            Activity.Add("Location", ControlRemarks.cmbLocation.Text)
        End If

        If {RepairStatus.Received, RepairStatus.Canceled}.Contains(cmbRetStatus.Text) Then
            Return
        End If

        Dim AssignedTechnician = ControlTechnicianInfo.GetAssignedTechnician()
        If IsNothing(AssignedTechnician) = False AndAlso UpdateRepairField(Repair.AssignedToTNo, AssignedTechnician.No) Then
            Activity.Add("Assigned To Technician", AssignedTechnician.Name)
        End If

        If {RepairStatus.AssignedTo}.Contains(cmbRetStatus.Text) Then
            Return
        End If

        Dim HandedOverTechnician = ControlTechnicianInfo.GetHandedOverTechnician()
        If IsNothing(HandedOverTechnician) = False AndAlso UpdateRepairField(Repair.HandedOverToTNo, HandedOverTechnician.No) Then
            Activity.Add("Handed Over To Technician", HandedOverTechnician.Name)
        End If

        If {RepairStatus.HandedOverTo, RepairStatus.Pending}.Contains(cmbRetStatus.Text) Then
            Return
        End If

        If UpdateRepairField(ReRepair.Charge, ControlRepairDeliverInfo.txtRepPrice.Text) Then
            Activity.Add("Repair Charge", ControlRepairDeliverInfo.txtRepPrice.Text)
        End If

        If UpdateRepairField(ReRepair.RepDate, ControlRepairDeliverInfo.txtRepDate.Value) Then
            Activity.Add("Repaired Date", ControlRepairDeliverInfo.txtRepDate.Value)
        End If

        If Activity.Count < 1 Then
            Return
        End If

        RepairController.SetDatabase(TransactionDatabase)
        RepairController.InsertRepairActivity(Mode, cmbRetNo.Text, "UPDATE: " + JsonConvert.SerializeObject(Activity))
    End Sub

    Private Function UpdateRepairField(FieldName As String, NewValue As Object) As Boolean
        Dim TableName As String = If(Mode = RepairMode.Repair, Tables.Repair, Tables.ReRepair)
        Dim IdField As String = If(Mode = RepairMode.Repair, "RepNo", "RetNo")
        Dim IdValue As String = If(Mode = RepairMode.Repair, cmbRepNo.Text, cmbRetNo.Text)

        If DataReaderRepair(FieldName).ToString <> NewValue.ToString Then
            TransactionDatabase.Execute($"UPDATE `{TableName}` SET `{FieldName}` = @NEWVALUE WHERE `{IdField}` = @ID;", {
                New MySqlParameter("NEWVALUE", NewValue),
                New MySqlParameter("ID", IdValue)
            })
            Return True
        End If

        Return False
    End Function

    Private Function UpdateOtherField(FieldName As String, NewValue As Object, TableName As String, IdField As String, IdValue As Integer) As Boolean
        If DataReaderRepair(FieldName).ToString <> NewValue.ToString Then
            TransactionDatabase.Execute($"UPDATE {TableName} SET {FieldName} = @NEWVALUE WHERE {IdField} = @ID;", {
                New MySqlParameter("NEWVALUE", NewValue),
                New MySqlParameter("ID", IdValue)
            })
            Return True
        End If

        Return False
    End Function

    Private Sub CmdRepView_Click(sender As Object, e As EventArgs) Handles cmdRepView.Click
        Dim frmSearchRepair As New FormSearch With {
            .Tag = "Repair",
            .Name = "frmSearch" + NextFormNo(frmSearch).ToString
        }
        frmSearchRepair.Show()
    End Sub

    Private Sub CmdReRepView_Click(sender As Object, e As EventArgs) Handles cmdReRepView.Click
        Dim frmSearchReRepair As New FormSearch With {
            .Tag = "ReRepair",
            .Name = "frmSearch" + NextFormNo(frmSearch).ToString
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
        Dim Form As New FormReport
        Try
            Dim ReportManager As New RepairStickerReport()
            ReportManager.SetPrinterName(My.Settings.StickerPrinterName).SetPaperName(My.Settings.RepairStickerPrinterPaperName)
            Dim Report = ReportManager.GenerateReport(txtRNo.Text)
            Dim FormReport = ReportManager.GetFormReport(Report, "Report - Repair Sticker", False)
            FormReport.Show(Me)
        Catch ex As Exception
            MessageBox.Error("Receipt Sticker එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message)
        End Try
    End Sub

    Private Sub PrintReceivedReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintReceivedReceiptToolStripMenuItem.Click
        Dim Form As New FormReport
        Try
            Dim ReportManager As New ReceivedInvoiceReport()
            ReportManager.SetPrinterName(My.Settings.BillPrinterName).SetPaperName(My.Settings.BillPrinterPaperName)
            Dim Report = ReportManager.GenerateReport(txtRNo.Text)
            Dim FormReport = ReportManager.GetFormReport(Report, "Report - Received Receipt", False)
            FormReport.Show(Me)
        Catch ex As Exception
            MessageBox.Error("Receipt Invoice එක print කර ගැනීමට අපොහොසත් විය." + vbCrLf + "Error: " + ex.Message)
        End Try
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