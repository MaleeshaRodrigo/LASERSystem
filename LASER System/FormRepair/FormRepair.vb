Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class FormRepair
    Private Db As New Database
    Public DataReaderRepair As OleDbDataReader

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
        'CmbRetNo_SelectedIndexChanged(Nothing, Nothing)
        If Me.Tag = "" Then
            cmdDone.Enabled = False
        Else
            cmdDone.Enabled = True
        End If

        If tabRepair.SelectedIndex = 0 Then
            cmbRepNo.Focus()
        Else
            cmbRetNo.Focus()
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
            Call ComboBoxDropDown(Db, cmbRetNo, "Select RetNo from Return order by RetNo Desc;")
        Else
            Call ComboBoxDropDown(Db, cmbRetNo, "Select RetNo from Return Where RepNo = " & cmbRetRepNo.Text & " order by RetNo Desc;")
        End If
    End Sub

    Private Sub cmbRetRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRetRepNo.DropDown
        Call ComboBoxDropDown(Db, cmbRetRepNo, "Select RepNo from Return Group By RepNo order by RepNo Desc;")
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
            ControlRemarks.Init(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlRemarks)

            ControlActivityInfo = New ControlActivityInfo(Db)
            ControlActivityInfo.Init(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlActivityInfo)

            ControlTaskInfo = New ControlTaskInfo(Db)
            ControlTaskInfo.Init(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTaskInfo)
            If cmbRepStatus.Text = "Received" Then
                Exit Try
            End If

            ControlTechnicianInfo = New ControlTechnicianInfo(Db, Me)
            ControlTechnicianInfo.Init()
            PanelMain.Controls.Add(ControlTechnicianInfo)
            If cmbRepStatus.Text = "Hand Over to Technician" Then
                Exit Try
            End If

            ControlTechnicianCostInfo = New ControlTechnicianCostInfo(Db, Me)
            ControlTechnicianCostInfo.Init(cmbRepNo.Text)
            PanelMain.Controls.Add(ControlTechnicianCostInfo)
            If cmbRepStatus.Text = "Repairing" Then
                Exit Try
            End If

            ControlRepairDeliverInfo = New ControlRepairDeliverInfo(Db)
            ControlRepairDeliverInfo.SetRepDetails(DataReaderRepair("Charge").ToString, DataReaderRepair("RepDate").ToString).InvisibleDeliverInfo()
            If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Returned Not Delivered" Then
                Exit Try
            End If

            ControlRepairDeliverInfo.SetDeliverDetails(DataReaderRepair("DNo").ToString, DataReaderRepair("PaidPrice").ToString, DataReaderRepair("DDate").ToString).VisibleDeliverInfo()
            If (cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Delivered") And User.Instance.UserType <> User.Type.Admin And DateValue(DataReaderRepair("DDate").ToString).Month <> Today.Month Then
                PanelMain.Enabled = False
                For Each Item As Control In {boxReceive, boxProduct, boxCustomer, txtPProblem}
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

        For Each Item As Control In {cmbRetNo, cmbRetRepNo, cmbRetStatus, cmbRepStatus, txtRNo, txtRDate, txtCuNo, TextCuName, txtCuTelNo1, txtCuTelNo2, txtCuTelNo3, txtPNo, cmbPCategory, cmbPName, txtPModelNo, txtPSerialNo, txtPDetails, txtPQty, txtPProblem}
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
        '    Try
        '        tabRepair.Tag = "Return"
        '        tabRepair.SelectedTab.TabIndex = 1
        '        For Each ctrl As Control In {cmbRetStatus, cmbRepStatus, txtRNo, txtRDate, txtCuNo, cmbCuName, txtCuTelNo1, txtCuTelNo2,
        '            txtCuTelNo3, txtPNo, cmbPCategory, cmbPName, txtPModelNo, txtPSerialNo, txtPDetails, txtPQty, txtPProblem, cmbLocation, cmbTName, txtRepPrice,
        '            txtRepDate, txtDNo, txtDDate}
        '            ctrl.Text = ""
        '        Next
        '        grdRepRemarks1.Rows.Clear()
        '        grdRepRemarks2.Rows.Clear()
        '        grdAdvance.Rows.Clear()
        '        grdRepTask.Rows.Clear()
        '        grdActivity.Rows.Clear()
        '        grdTechnicianCost.Rows.Clear()
        '        imgRepair.Image = Nothing
        '        imgRepair.Refresh()
        '        GC.Collect()
        '        For Each ctrl As Control In {boxTechnician, boxItem, boxRepair, boxDeliver, lblRepRemarks2, grdRepRemarks2, boxReceive, boxCustomer, boxProduct,
        '            lblPProblem, txtPProblem, lblRepRemarks1, grdRepRemarks1, lblLocation, cmbLocation, grpAdvancePay, grpRepTask, grpActivity}
        '            ctrl.Visible = False
        '        Next

        '        If cmbRetNo.Text = "" Then Exit Try
        '        For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem, lblRepRemarks1, grdRepRemarks1, lblLocation,
        '            cmbLocation, grpAdvancePay, grpRepTask, grpActivity}
        '            ctrl.Visible = True
        '        Next
        '        For Each ctrl As Control In {boxTechnician, boxReceive, boxProduct, boxRepair, boxDeliver, boxCustomer, txtPProblem, lblLocation, cmbLocation,
        '            grpAdvancePay, grpRepTask, grpActivity}
        '            ctrl.Enabled = True
        '        Next
        '        DataReaderRepair = Db.GetDataReader("Select Return.RetNo,Return.RNo,Receive.RDate,Receive.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3,Customer.CuRemarks,Return.Pno,Product.PCategory,Product.PName,Product.PModelNo,Product.PDetails,Return.PSerialNo,Return.Problem,Return.Qty,Return.TNo,Technician.TName,Return.Status,Return.Charge,Return.PaidPrice,Return.RetRepDate,Return.DNo,Location from ((((Return inner join Receive on Return.RNo = Receive.RNo) inner join Customer on Receive.CuNo = Customer.CuNo) inner join Product on Return.PNo = Product.PNo) left join Technician on Return.TNo = Technician.TNo)where Return.RetNo = " & cmbRetNo.Text)
        '        If DataReaderRepair.HasRows = False Then
        '            MsgBox("මෙම RE-Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
        '        End If
        '        DataReaderRepair.Read()
        '        cmbRetRepNo.Text = DataReaderRepair("RepNo").ToString
        '        cmbRetStatus.Text = DataReaderRepair("Status").ToString
        '        txtRNo.Text = DataReaderRepair("RNo").ToString
        '        txtRDate.Text = DataReaderRepair("RDate").ToString
        '        txtCuNo.Text = DataReaderRepair("CuNo").ToString
        '        cmbCuName.Text = DataReaderRepair("CuName").ToString
        '        txtCuTelNo1.Text = DataReaderRepair("CuTelNo1").ToString
        '        txtCuTelNo2.Text = DataReaderRepair("CuTelNo2").ToString
        '        txtCuTelNo3.Text = DataReaderRepair("CuTelNo3").ToString
        '        txtPNo.Text = DataReaderRepair("PNo").ToString
        '        cmbPCategory.Text = DataReaderRepair("PCategory").ToString
        '        cmbPName.Text = DataReaderRepair("PName").ToString
        '        txtPModelNo.Text = DataReaderRepair("PModelNO").ToString
        '        txtPDetails.Text = DataReaderRepair("PDetails").ToString
        '        txtPSerialNo.Text = DataReaderRepair("PSerialNo").ToString
        '        txtPQty.Text = DataReaderRepair("Qty").ToString
        '        txtPProblem.Text = DataReaderRepair("Problem").ToString
        '        cmbLocation.Text = DataReaderRepair("Location").ToString
        '        Dim DRRETNo1 As OleDbDataReader = Db.GetDataReader("Select * from RepairRemarks1 Where RetNo=" & cmbRetNo.Text)
        '        grdRepRemarks1.Rows.Clear()
        '        While DRRETNo1.Read
        '            grdRepRemarks1.Rows.Add(DRRETNo1("Rem1No").ToString, DRRETNo1("Rem1Date").ToString, DRRETNo1("Remarks").ToString, Db.GetData("Select UserName from [User] Where UNo=" & DRRETNo1("UNo").ToString))
        '        End While
        '        Dim FilePath As String = Path.Combine(SystemFolderPath, "System Files\Images\" + "RET-" + cmbRetNo.Text + ".png")
        '        If File.Exists(FilePath) Then
        '            imgRepair.Image = Image.FromFile(FilePath)
        '        Else
        '            imgRepair.Image = Nothing
        '        End If
        '        DRRETNo1 = Db.GetDataReader("Select * from RepairActivity Where RetNo=" & cmbRetNo.Text)
        '        grdActivity.Rows.Clear()
        '        While DRRETNo1.Read
        '            grdActivity.Rows.Add(DRRETNo1("RepANo").ToString, DRRETNo1("RepADate").ToString, DRRETNo1("Activity").ToString,
        '                                    Db.GetData("Select UserName from [User] Where UNo=" & DRRETNo1("UNo").ToString))
        '        End While
        '        DRRETNo1 = Db.GetDataReader("Select MsgNo,MsgDate,Action,Message,Status from Message where RetNo = " & cmbRetNo.Text)
        '        grdRepTask.Rows.Clear()
        '        While DRRETNo1.Read
        '            grdRepTask.Rows.Add(DRRETNo1("MsgNo").ToString, DRRETNo1("MsgDate").ToString, DRRETNo1("Action").ToString, DRRETNo1("MESSAGE").ToString,
        '                                DRRETNo1("STATUS").ToString)
        '        End While
        '        DRRETNo1.Close()
        '        If cmbRetStatus.Text = "Received" Then
        '            Exit Try
        '        End If
        '        boxTechnician.Visible = True
        '        lblRepRemarks2.Visible = True
        '        grdRepRemarks2.Visible = True       'fill fields Technician details
        '        cmbTName.Text = DataReaderRepair("TName").ToString
        '        DRRETNo1 = Db.GetDataReader("Select * from RepairRemarks2 Where RetNo=" & cmbRetNo.Text)
        '        grdRepRemarks2.Rows.Clear()
        '        While DRRETNo1.Read
        '            grdRepRemarks2.Rows.Add(DRRETNo1("Rem2No").ToString, DRRETNo1("Rem2Date").ToString, DRRETNo1("Remarks").ToString, Db.GetData("Select UserName from [User] Where UNo=" & DRRETNo1("UNo").ToString))
        '        End While
        '        DRRETNo1.Close()
        '        If cmbRetStatus.Text = "Hand Over to Technician" Then
        '            Exit Try
        '        End If
        '        boxItem.Visible = True
        '        DRRETNo1 = Db.GetDataReader("SELECT TechnicianCost.TCNo,TechnicianCost.TCDate,TechnicianCost.SNo,Stock.SCategory,Stock.SName,TechnicianCost.Rate,TechnicianCost.Qty,TechnicianCost.Total,TechnicianCost.TCRemarks from STock, TechnicianCost where TechnicianCost.SNo = Stock.SNo And RetNo=" & cmbRetNo.Text & ";")
        '        grdTechnicianCost.Rows.Clear()
        '        If DRRETNo1.HasRows = True Then
        '            While DRRETNo1.Read
        '                grdTechnicianCost.Rows.Add(DRRETNo1("TCNo").ToString, DRRETNo1("TCDate").ToString, DRRETNo1("SNo").ToString, DRRETNo1("SCategory").ToString, DRRETNo1("SName").ToString, DRRETNo1("Rate").ToString, DRRETNo1("Qty").ToString, DRRETNo1("Total").ToString, DRRETNo1("TCRemarks").ToString)
        '            End While
        '        End If
        '        DRRETNo1.Close()
        '        If cmbRetStatus.Text = "Repairing" Then
        '            Exit Try
        '        End If
        '        boxRepair.Visible = True
        '        txtRepPrice.Text = DataReaderRepair("Charge").ToString
        '        txtRepDate.Text = DataReaderRepair("RetRepDate").ToString
        '        If cmbRetStatus.Text = "Repaired Not Delivered" Or cmbRetStatus.Text = "Returned Not Delivered" Then
        '            Exit Try
        '        End If
        '        boxDeliver.Visible = True
        '        txtDNo.Text = DataReaderRepair("DNo").ToString
        '        txtDPaidPrice.Text = DataReaderRepair("PaidPrice").ToString
        '        DRRETNo1 = Db.GetDataReader("Select Deliver.DDate, Deliver.CuNo, Customer.CuName, Customer.CuTelNo1, Customer.CuTelNo2, Customer.CuTelNo3 from Deliver, Customer where Deliver.Cuno = Customer.Cuno And Deliver.DNo = " & txtDNo.Text)
        '        If DRRETNo1.HasRows = True Then
        '            DRRETNo1.Read()
        '            txtDDate.Value = DRRETNo1("DDAte").ToString
        '        End If
        '        DRRETNo1.Close()
        '        If cmbRetStatus.Text = "Repaired Delivered" Or cmbRetStatus.Text = "Returned Delivered" Then

        '            If User.Instance.UserName = User.Type.Cashier And txtDDate.Value.Month <> Today.Month Then
        '                For Each ctrl As Control In {boxTechnician, boxReceive, boxProduct, boxRepair, boxDeliver, boxCustomer, txtPProblem, lblLocation, cmbLocation,
        '                    grpAdvancePay, grpRepTask, grpActivity}
        '                    ctrl.Enabled = False
        '                Next
        '            End If
        '            Exit Try
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message, vbCritical + vbOKOnly)
        '    Finally
        '        frmRepair_Resize(sender, e)
        '    End Try
    End Sub

    'Private Sub cmbRetRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRetRepNo.SelectedIndexChanged
    '    CmbRetNo_DropDown(sender, e)
    '    cmbRetNo.SelectedIndex = 0
    'End Sub

    'Private Sub cmbRetNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbRetNo.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        CmbRetNo_SelectedIndexChanged(sender, e)
    '    End If
    'End Sub

    'Private Sub cmbRetRepNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbRetRepNo.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        cmbRetRepNo_SelectedIndexChanged(sender, e)
    '    End If
    'End Sub
    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, UpdateToolStripMenuItem.Click
        Try
            If CheckEmptyfield(txtCuNo, "මෙම Repair එක සඳහා ඔබ Customer කෙනෙකු තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!") = False Then
                Exit Sub
            ElseIf CheckEmptyfield(txtPNo, "මෙම Repair එක සඳහා ඔබ Product එකක් තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!!") = False Then
                Exit Sub
            End If
            Select Case tabRepair.SelectedTab.TabIndex
                Case 0              'check empty fields which have filled to user
                    If cmbRepStatus.Text = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Or cmbRepStatus.Text = "Repaired Not Delivered" Or
                        cmbRepStatus.Text = "Repaired Delivered" Then
                        If CheckEmptyfield(cmbTName, "Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
                            Exit Sub
                        End If
                    End If
                    If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Not Delivered" Or
                        cmbRepStatus.Text = "Returned Delivered" Then
                        If CheckEmptyfield(txtRepPrice, "Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.") = False Then
                            Exit Sub
                        End If
                    End If
                    If (Not (DataReaderRepair("Status").ToString = "Repaired Delivered" Or DataReaderRepair("Status").ToString = "Returned Delivered" Or
                        DataReaderRepair("Status").ToString = "Canceled") And (cmbRepStatus.Text = "Repaired Delivered" Or
                        cmbRepStatus.Text = "Returned Delivered" Or cmbRepStatus.Text = "Canceled")) Then
                        MsgBox("මෙම Repair Form තුලින් මෙය සිදු කිරීමට නොහැකිය. Deliver Form එක භාවිතා කරන්න.", vbExclamation)
                        Exit Sub
                    End If
                    If DataReaderRepair("Status").ToString <> cmbRepStatus.Text Then
                        Db.Execute("update Repair set status ='" & cmbRepStatus.Text & "' where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Status -> " & cmbRepStatus.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("CuNo").ToString <> txtCuNo.Text Then
                        Db.Execute("update Receive set cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Customer -> Name= " & TextCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("RDate").ToString <> txtRDate.Value.ToString Then
                        Db.Execute("update Receive set RDate=#" & txtRDate.Value.Date.ToString & "# where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Received Date -> " & txtRDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PNo").ToString <> txtPNo.Text Then
                        Db.Execute("update Repair set pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PSerialNo").ToString <> txtPSerialNo.Text Then
                        Db.Execute("update Repair set pserialno ='" & txtPSerialNo.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Product Serial No -> " & txtPSerialNo.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Problem").ToString <> txtPProblem.Text Then
                        Db.Execute("update Repair set Problem ='" & txtPProblem.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Problem -> " & txtPProblem.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Location").ToString <> ControlRemarks.cmbLocation.Text Then
                        Db.Execute("update Repair set Location= '" & ControlRemarks.cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Location -> " & ControlRemarks.cmbLocation.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If
                    Dim TNo As Integer = Db.GetData("SELECT TNo FROM Technician WHERE TName='" & cmbTName.Text & "'")
                    If DataReaderRepair("TNo").ToString <> TNo Then
                        Db.Execute("update Repair set tno =" & TNo & " where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Technician -> " & cmbTName.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRepStatus.Text.ToString = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If

                    If DataReaderRepair("Charge").ToString <> txtRepPrice.Text Then
                        Db.Execute("update Repair set charge=" & txtRepPrice.Text & " where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Repair Charge -> " & txtRepPrice.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("RepDate").ToString <> ControlRepairDeliverInfo.txtRepDate.Value.ToString Then
                        Db.Execute("update Repair set repdate=#" & ControlRepairDeliverInfo.txtRepDate.Value.ToString & "# where repno=" & cmbRepNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Repaired Date -> " & ControlRepairDeliverInfo.txtRepDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If

                    If Me.Tag = "" Then MsgBox("Update successful!", vbInformation + vbOKOnly)

                    Exit Sub
                Case 1
                    If cmbRetStatus.Text = "Hand Over to Technician" Or "Repairing" Or "Repaired Not Delivered" Or "Repaired Delivered" Then
                        If CheckEmptyfield(txtTNo, "Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
                            Exit Sub
                        End If
                    End If
                    If cmbRetStatus.Text = "Repaired Not Delivered" Or "Repaired Delivered" Or "Returned Not Delivered" Or "Returned Delivered" Then
                        If CheckEmptyfield(txtRepPrice, "Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.") = False Then
                            Exit Sub
                        End If
                    End If
                    If Not ((DataReaderRepair("Status").ToString = "Repaired Delivered" Or DataReaderRepair("Status").ToString = "Returned Delivered" Or
                        DataReaderRepair("Status").ToString = "Canceled") And (cmbRetStatus.Text = "Repaired Delivered" Or cmbRetStatus.Text = "Returned Delivered" Or
                        cmbRetStatus.Text = "Canceled")) Then
                        MsgBox("මෙම Repair Form තුලින් මෙය සිදු කිරීමට නොහැකිය. Deliver Form එක භාවිතා කරන්න.", vbExclamation)
                        Exit Sub
                    End If

                    If DataReaderRepair("Status") <> cmbRetStatus.Text Then
                        Db.Execute("update Return set status ='" & cmbRetStatus.Text & "' where retno=" & cmbRetNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Status -> " & cmbRetStatus.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("CuNo") <> txtCuNo.Text Then
                        Db.Execute("update Receive set Cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Customer -> Name= " & TextCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If DataReaderRepair("RDate") <> txtRDate.Value.ToString Then
                        Db.Execute("update Receive set RDate=#" & txtRDate.Value.Date.ToString & "# where rno = " & txtRNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Received Date -> " & txtRDate.Value.ToString & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PNo") <> txtPNo.Text Then
                        Db.Execute("update Return set pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("PSerialNo") <> txtPSerialNo.Text Then
                        Db.Execute("update Return set pserialno ='" & txtPSerialNo.Text & "' where retno = " & cmbRetNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Product Serial No -> " & txtPSerialNo.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Problem") <> txtPProblem.Text Then
                        Db.Execute("update Return set problem ='" & txtPProblem.Text & "' where retno = " & cmbRetNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Problem -> " & txtPProblem.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("Location") <> ControlRemarks.cmbLocation.Text Then
                        Db.Execute("update Return set Location= '" & ControlRemarks.cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Location -> " & ControlRemarks.cmbLocation.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If
                    If DataReaderRepair("TNo") <> txtTNo.Text Then
                        Db.Execute("update Return set tno =" & txtTNo.Text & " where retno=" & cmbRetNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Technician -> " & cmbTName.Text & "'," & User.Instance.UserNo & ")")
                    End If

                    If cmbRepStatus.Text = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If

                    If DataReaderRepair("Charge") <> txtRepPrice.Text Then
                        Db.Execute("update Return set charge=" & txtRepPrice.Text & " where retno=" & cmbRetNo.Text & ";")
                        Db.Execute("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) Values(" & Db.GetNextKey("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & Now & "#,'Repair Charge -> " & txtRepPrice.Text & "'," & User.Instance.UserNo & ")")
                    End If
                    If DataReaderRepair("RepDate") <> ControlRepairDeliverInfo.txtRepDate.Value.ToString Then
                        Db.Execute($"UPDATE Return SET RepDate=#{ControlRepairDeliverInfo.txtRepDate.Value.ToString}# WHERE RetNo={cmbRetNo.Text};")
                        Db.Execute($"INSERT INTO RepairActivity(RepANo,RetNo,RepADate,Activity,UNo) VALUES({Db.GetNextKey("RepairActivity", "RepANo")},{cmbRetNo.Text},#{Now}#,'Repaired Date -> {ControlRepairDeliverInfo.txtRepDate.Value}',{User.Instance.UserNo})")
                    End If
                    If Me.Tag = "" Then MsgBox("Update successful!", vbInformation + vbOKOnly)
                    Exit Sub
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        Finally
            If tabRepair.SelectedTab.TabIndex = 0 Then
                CmbRepNo_SelectedIndexChanged(sender, e)
            End If
        End Try
    End Sub

    'Public Sub CmbRetStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRetStatus.SelectionChangeCommitted
    '    boxTechnician.Visible = False
    '    boxItem.Visible = False
    '    boxRepair.Visible = False
    '    boxDeliver.Visible = False
    '    lblRepRemarks2.Visible = False
    '    grdRepRemarks2.Visible = False
    '    boxReceive.Visible = False
    '    boxCustomer.Visible = False
    '    boxProduct.Visible = False
    '    lblPProblem.Visible = False
    '    txtPProblem.Visible = False
    '    lblRepRemarks1.Visible = False
    '    grdRepRemarks1.Visible = False
    '    If cmbRetNo.Text = "" Then Exit Sub
    '    If cmbRetStatus.Text = "" Then Exit Sub
    '    boxReceive.Visible = True
    '    boxCustomer.Visible = True
    '    boxProduct.Visible = True
    '    lblPProblem.Visible = True
    '    txtPProblem.Visible = True
    '    lblRepRemarks1.Visible = True
    '    grdRepRemarks1.Visible = True
    '    If cmbRetStatus.Text = "Received" Or cmbRetStatus.Text = "Canceled" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxTechnician.Visible = True
    '    lblRepRemarks2.Visible = True
    '    grdRepRemarks2.Visible = True
    '    If cmbRetRepNo.Text <> "" Then
    '        Dim DR As OleDbDataReader = Db.GetDataReader("Select Technician.TNo,Technician.TName from Return,Technician where Return.TNo = Technician.TNo and Return.RepNo=" & cmbRetRepNo.Text)
    '        If DR.HasRows = True Then
    '            DR.Read()
    '            cmbTName.Text = DR("TName").ToString
    '        End If
    '    End If
    '    If cmbRetStatus.Text = "Hand Over to Technician" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxItem.Visible = True
    '    If cmbRetStatus.Text = "Repairing" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxRepair.Visible = True
    '    If cmbRetStatus.Text = "Repaired Not Delivered" Or cmbRetStatus.Text = "Returned Not Delivered" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxDeliver.Visible = True
    '    If cmbRetStatus.Text = "Repaired Delivered" Or cmbRetStatus.Text = "Returned Delivered" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    'End Sub

    'Public Sub CmbRepStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRepStatus.SelectionChangeCommitted
    '    boxTechnician.Visible = False
    '    boxItem.Visible = False
    '    boxRepair.Visible = False
    '    boxDeliver.Visible = False
    '    lblRepRemarks2.Visible = False
    '    grdRepRemarks2.Visible = False
    '    boxReceive.Visible = False
    '    boxCustomer.Visible = False
    '    boxProduct.Visible = False
    '    lblPProblem.Visible = False
    '    txtPProblem.Visible = False
    '    lblRepRemarks1.Visible = False
    '    grdRepRemarks1.Visible = False
    '    If cmbRepNo.Text = "" Then Exit Sub
    '    If cmbRepStatus.Text = "" Then Exit Sub
    '    boxReceive.Visible = True
    '    boxCustomer.Visible = True
    '    boxProduct.Visible = True
    '    lblPProblem.Visible = True
    '    txtPProblem.Visible = True
    '    lblRepRemarks1.Visible = True
    '    grdRepRemarks1.Visible = True
    '    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxTechnician.Visible = True
    '    lblRepRemarks2.Visible = True
    '    grdRepRemarks2.Visible = True
    '    If cmbRepStatus.Text = "Hand Over to Technician" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxItem.Visible = True
    '    If cmbRepStatus.Text = "Repairing" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxRepair.Visible = True
    '    If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Returned Not Delivered" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    '    boxDeliver.Visible = True
    '    If cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Delivered" Then
    '        frmRepair_Resize(sender, e)
    '        Exit Sub
    '    End If
    'End Sub
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
        Dim DR As OleDbDataReader = Db.GetDataReader("Select * from Product where PCategory ='" & cmbPCategory.Text & "' and PName ='" & cmbPName.Text & "';")
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
            CmbRepNo_SelectedIndexChanged(sender, e)
            cmbRepNo.Focus()
        Else
            RepairInfoToolStripMenuItem.Text = "ReRepair Info"
            'CmbRetNo_SelectedIndexChanged(sender, e)
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