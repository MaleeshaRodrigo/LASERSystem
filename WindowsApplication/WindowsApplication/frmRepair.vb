Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports ZXing
Imports System.Drawing
Imports System.IO
Imports System.IO.Ports
Imports System.Diagnostics
Imports System.Globalization
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class frmRepair
    Private dtpDate As New DateTimePicker
    Private DRREPNO, DRRETNO As OleDb.OleDbDataReader
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MenuStrip.Items.Add(mnustrpMENU)
        Call CmbRepNo_SelectedIndexChanged(Nothing, Nothing)
        Call CmbRetNo_SelectedIndexChanged(Nothing, Nothing)
        Call CmbTName_DropDown(Nothing, Nothing)
        If Me.Tag = "" Then
            cmdDone.Enabled = False
        Else
            cmdDone.Enabled = True
        End If
        If MdifrmMain.Tag <> "Cashier" Then
            For Each columns As DataGridViewColumn In {
                grdRepRemarks1.Columns(0),
                grdRepRemarks2.Columns(0),
                grdActivity.Columns(0),
                grdRepTask.Columns(0)}
                columns.Visible = True
            Next
            For Each ctrl As Control In {txtRNo, txtPNo, txtCuNo, txtDNo}
                    ctrl.Visible = True
                Next
        End If

    End Sub

    Private Sub FrmRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        If tabRepair.SelectedTab.TabIndex = 0 Then
            cmbRepNo.Focus()
        Else
            cmbRetNo.Focus()
        End If
    End Sub

    Private Sub frmRepair_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call CmbRepNo_DropDown(sender, e)
        Call CmbRetNo_DropDown(sender, e)
    End Sub

    Private Sub frmRepair_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If boxTechnician.Visible = False Then
            grpAdvancePay.Top = grdRepRemarks1.Top + grdRepRemarks1.Height + 5
        ElseIf boxItem.Visible = False Then
            grpAdvancePay.Top = grdRepRemarks2.Top + grdRepRemarks2.Height + 5
        ElseIf boxRepair.Visible = False Then
            grpAdvancePay.Top = boxItem.Top + boxItem.Height + 5
        ElseIf boxDeliver.Visible = False Then
            grpAdvancePay.Top = boxRepair.Top + boxRepair.Height + 5
        Else
            grpAdvancePay.Top = boxDeliver.Top + boxDeliver.Height + 5
        End If
        grpRepTask.Top = grpAdvancePay.Top + grpAdvancePay.Height + 5
        grpActivity.Top = grpRepTask.Top + grpRepTask.Height + 5
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

    Private Sub FrmRepair_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Tag = ""
        DRREPNO.Close()
        dtpDate.Dispose()
        Me.Close()
    End Sub

    Private Sub CmbRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRepNo.DropDown
        Call CmbDropDown(cmbRepNo, "Select RepNo from Repair order by RepNo Desc", "RepNo")
    End Sub

    Private Sub CmbRetNo_DropDown(sender As Object, e As EventArgs) Handles cmbRetNo.DropDown
        If cmbRetRepNo.Text = "" Then
            Call CmbDropDown(cmbRetNo, "Select RetNo from Return order by RetNo Desc;", "RetNo")
        Else
            Call CmbDropDown(cmbRetNo, "Select RetNo from Return Where RepNo = " & cmbRetRepNo.Text & " order by RetNo Desc;", "RetNo")
        End If
    End Sub

    Private Sub cmbRetRepNo_DropDown(sender As Object, e As EventArgs) Handles cmbRetRepNo.DropDown
        Call CmbDropDown(cmbRetRepNo, "Select RepNo from Return Group By RepNo order by RepNo Desc;", "RepNo")
    End Sub

    Private Sub cmbLocation_DropDown(sender As Object, e As EventArgs) Handles cmbLocation.DropDown
        CmbDropDown(cmbLocation, "Select Location from Repair Group by Location;", "Location")
    End Sub

    Public Sub CmbRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRepNo.SelectedIndexChanged
        Dim CMDREPNO As New OleDb.OleDbCommand
        Try
            tabRepair.Tag = "Repair"
            tabRepair.SelectedTab.TabIndex = 0
            For Each ctrl As Control In {cmbRetNo, cmbRetRepNo, cmbRetStatus, cmbRepStatus, txtRNo, txtRDate, txtCuNo, cmbCuName, txtCuTelNo1, txtCuTelNo2,
                txtCuTelNo3, txtPNo, cmbPCategory, cmbPName, txtPModelNo, txtPSerialNo, txtPDetails, txtPQty, txtPProblem, cmbLocation, cmbTName, txtRepPrice,
                txtRepDate, txtDNo, txtDDate}
                ctrl.Text = ""
            Next
            grdRepRemarks1.Rows.Clear()
            grdRepRemarks2.Rows.Clear()
            grdAdvance.Rows.Clear()
            grdRepTask.Rows.Clear()
            grdActivity.Rows.Clear()
            grdTechnicianCost.Rows.Clear()
            imgRepair.Image = Nothing
            imgRepair.Refresh()
            GC.Collect()
            For Each ctrl As Control In {boxTechnician, boxItem, boxRepair, boxDeliver, lblRepRemarks2, grdRepRemarks2, boxReceive, boxCustomer, boxProduct,
                lblPProblem, txtPProblem, lblRepRemarks1, grdRepRemarks1, lblLocation, cmbLocation, grpAdvancePay, grpRepTask, grpActivity}
                ctrl.Visible = False
            Next

            If cmbRepNo.Text = "" Then Exit Try
            CMDREPNO = New OleDb.OleDbCommand("SELECT RepNo,REP.RNo,RDate, R.CuNo, CuName, CuTelNo1,CuTelNo2, CuTelNo3, REP.PNo,PCategory,PName, PModelNo, PDetails, " &
                                              "PSerialNo,Problem,Qty,Charge, PaidPrice,REP.TNo, TName, Status, RepDate,REP.DNo, DDate, Location from (((((Repair REP INNER JOIN RECEIVE R ON R.RNO = REP.RNO) INNER JOIN PRODUCT  P ON P.PNO = REP.PNO) " &
                                              "INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO) LEFT JOIN Technician T ON T.TNO = REP.TNO) LEFT JOIN DELIVER D ON D.DNO = REP.DNO) Where Rep.Repno = " & cmbRepNo.Text, CNN)
            DRREPNO = CMDREPNO.ExecuteReader
            If DRREPNO.HasRows = False Then
                MsgBox("මෙම Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
                Exit Sub
            End If
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem, lblRepRemarks1, grdRepRemarks1, lblLocation,
                cmbLocation, grpAdvancePay, grpRepTask, grpActivity}
                ctrl.Visible = True
            Next
            For Each ctrl As Control In {boxTechnician, boxReceive, boxProduct, boxRepair, boxDeliver, boxCustomer, txtPProblem, lblLocation, cmbLocation,
                grpAdvancePay, grpRepTask, grpActivity}
                ctrl.Enabled = True
            Next
            DRREPNO.Read()
            cmbRepStatus.Text = DRREPNO("Status").ToString
            txtRNo.Text = DRREPNO("RNo").ToString
            txtRDate.Text = DRREPNO("RDate").ToString
            txtCuNo.Text = DRREPNO("CuNo").ToString
            cmbCuName.Text = DRREPNO("CuName").ToString
            txtCuTelNo1.Text = DRREPNO("CuTelNo1").ToString
            txtCuTelNo2.Text = DRREPNO("CuTelNo2").ToString
            txtCuTelNo3.Text = DRREPNO("CuTelNo3").ToString
            txtPNo.Text = DRREPNO("PNo").ToString
            cmbPCategory.Text = DRREPNO("PCategory").ToString
            cmbPName.Text = DRREPNO("PName").ToString
            txtPModelNo.Text = DRREPNO("PModelNO").ToString
            txtPDetails.Text = DRREPNO("PDetails").ToString
            txtPSerialNo.Text = DRREPNO("PSerialNo").ToString
            txtPQty.Text = DRREPNO("Qty").ToString
            txtPProblem.Text = DRREPNO("Problem").ToString
            cmbLocation.Text = DRREPNO("Location").ToString
            'Adding Data to grdRepRemarks1 
            Dim CMDREPNO1 As OleDbCommand = New OleDbCommand("Select * from RepairRemarks1 Where RepNo=" & cmbRepNo.Text, CNN)
            Dim DRREPNO1 As OleDbDataReader = CMDREPNO1.ExecuteReader()
            grdRepRemarks1.Rows.Clear()
            While DRREPNO1.Read
                grdRepRemarks1.Rows.Add(DRREPNO1("Rem1No").ToString, DRREPNO1("Rem1Date").ToString, DRREPNO1("Remarks").ToString,
                                            GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRREPNO1("UNo").ToString, "UserName"))
                If MdifrmMain.tslblUserType.Text <> "Admin" And txtDDate.Value.Month <> Today.Month Then
                    grdRepRemarks1.Rows.Item(grdRepRemarks1.Rows.Count - 1).ReadOnly = True
                End If
            End While
            If File.Exists(Application.StartupPath & "\System Files\Images\" + "REP-" + cmbRepNo.Text + ".ls") Then
                imgRepair.Image = Image.FromFile(Application.StartupPath & "\System Files\Images\" + "REP-" + cmbRepNo.Text + ".ls")
            Else
                imgRepair.Image = Nothing
            End If
            'Adding Data to Activity
            CMDREPNO1 = New OleDbCommand("Select * from RepairActivity Where RepNo=" & cmbRepNo.Text, CNN)
            DRREPNO1 = CMDREPNO1.ExecuteReader()
            grdActivity.Rows.Clear()
            While DRREPNO1.Read
                grdActivity.Rows.Add(DRREPNO1("RepANo").ToString, DRREPNO1("RepADate").ToString, DRREPNO1("Activity").ToString,
                                            GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRREPNO1("UNo").ToString, "UserName"))
            End While
            CMDREPNO1 = New OleDbCommand("Select MsgNo,MsgDate,Action,Message,Status from Message where RepNo = " & cmbRepNo.Text, CNN)
            DRREPNO1 = CMDREPNO1.ExecuteReader
            grdRepTask.Rows.Clear()
            While DRREPNO1.Read
                grdRepTask.Rows.Add(DRREPNO1("MsgNo").ToString, DRREPNO1("MsgDate").ToString, DRREPNO1("Action").ToString, DRREPNO1("MESSAGE").ToString,
                                    DRREPNO1("STATUS").ToString)
            End While
            CMDREPNO1.Cancel()
            DRREPNO1.Close()
            If cmbRepStatus.Text = "Received" Then
                Exit Try
            End If
            boxTechnician.Visible = True
            lblRepRemarks2.Visible = True
            grdRepRemarks2.Visible = True
            txtTNo.Text = DRREPNO("TNo").ToString
            cmbTName.Text = DRREPNO("TName").ToString 'fill fields Technician details
            CMDREPNO1 = New OleDbCommand("Select * from RepairRemarks2 Where RepNo=" & cmbRepNo.Text, CNN)
            DRREPNO1 = CMDREPNO1.ExecuteReader()
            grdRepRemarks2.Rows.Clear()
            While DRREPNO1.Read
                grdRepRemarks2.Rows.Add(DRREPNO1("Rem2No").ToString, DRREPNO1("Rem2Date").ToString, DRREPNO1("Remarks").ToString,
                                            GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRREPNO1("UNo").ToString, "UserName"))
                If MdifrmMain.tslblUserType.Text <> "Admin" And txtDDate.Value.Month <> Today.Month Then
                    grdRepRemarks2.Rows.Item(grdRepRemarks2.Rows.Count - 1).ReadOnly = True
                End If
            End While
            CMDREPNO1.Cancel()
            DRREPNO1.Close()
            If cmbRepStatus.Text = "Hand Over to Technician" Then
                Exit Try
            End If
            boxItem.Visible = True
            CMDREPNO1 = New OleDb.OleDbCommand("SELECT TechnicianCost.TCNo,TechnicianCost.TCDate,TechnicianCost.SNo,Stock.SCategory,Stock.SName," &
                                              "TechnicianCost.Rate,TechnicianCost.Qty,TechnicianCost.Total,TechnicianCost.TCRemarks,UNo from " &
                                              "STock,TechnicianCost where TechnicianCost.SNo = Stock.SNo and RepNo=" & cmbRepNo.Text & ";", CNN)
            DRREPNO1 = CMDREPNO1.ExecuteReader()
            grdTechnicianCost.Rows.Clear()
            While DRREPNO1.Read
                grdTechnicianCost.Rows.Add(DRREPNO1("TCNo").ToString, DRREPNO1("TCDate").ToString, DRREPNO1("SNo").ToString, DRREPNO1("SCategory").ToString, DRREPNO1("SName").ToString,
                                      DRREPNO1("Rate").ToString, DRREPNO1("Qty").ToString, DRREPNO1("Total").ToString, DRREPNO1("TCRemarks").ToString,
                                      If(DRREPNO1("UNo").ToString <> "", GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRREPNO1("UNo").ToString, "UserName"),
                                      ""))
            End While
            CMDREPNO1.Cancel()
            DRREPNO1.Close()
            If cmbRepStatus.Text = "Repairing" Then
                Exit Try
            End If
            boxRepair.Visible = True
            txtRepPrice.Text = DRREPNO("Charge").ToString
            txtRepDate.Text = DRREPNO("RepDate").ToString
            If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Returned Not Delivered" Then
                Exit Try
            End If
            boxDeliver.Visible = True
            txtDNo.Text = DRREPNO("DNo").ToString
            txtDPaidPrice.Text = DRREPNO("PaidPrice").ToString
            CMDREPNO1 = New OleDb.OleDbCommand("Select Deliver.DDate,Deliver.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3 from Deliver,Customer where Deliver.Cuno = Customer.Cuno and Deliver.DNo = " & txtDNo.Text, CNN)
            DRREPNO1 = CMDREPNO1.ExecuteReader
            If DRREPNO1.HasRows = True Then
                DRREPNO1.Read()
                txtDDate.Value = DRREPNO1("DDate").ToString
            End If
            DRREPNO1.Close()
            CMDREPNO1.Cancel()
            If cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Delivered" Then
                If MdifrmMain.tslblUserType.Text <> "Admin" And txtDDate.Value.Month <> Today.Month Then
                    For Each ctrl As Control In {boxTechnician, boxReceive, boxProduct, boxRepair, boxDeliver, boxCustomer, txtPProblem, lblLocation, cmbLocation,
                        grpAdvancePay, grpRepTask, grpActivity}
                        ctrl.Enabled = False
                    Next
                End If
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        Finally
            'If DRREPNO IsNot Nothing AndAlso DRREPNO.IsClosed = False Then
            '    CMDREPNO.Cancel()
            'End If
            frmRepair_Resize(sender, e)
        End Try
    End Sub
    Private Sub cmbRepNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbRepNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            CmbRepNo_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Public Sub CmbRetNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRetNo.SelectedIndexChanged, cmbRetNo.Enter
        Dim CMDRETNO As New OleDbCommand
        Try
            tabRepair.Tag = "Return"
            tabRepair.SelectedTab.TabIndex = 1
            For Each ctrl As Control In {cmbRetStatus, cmbRepStatus, txtRNo, txtRDate, txtCuNo, cmbCuName, txtCuTelNo1, txtCuTelNo2,
                txtCuTelNo3, txtPNo, cmbPCategory, cmbPName, txtPModelNo, txtPSerialNo, txtPDetails, txtPQty, txtPProblem, cmbLocation, cmbTName, txtRepPrice,
                txtRepDate, txtDNo, txtDDate}
                ctrl.Text = ""
            Next
            grdRepRemarks1.Rows.Clear()
            grdRepRemarks2.Rows.Clear()
            grdAdvance.Rows.Clear()
            grdRepTask.Rows.Clear()
            grdActivity.Rows.Clear()
            grdTechnicianCost.Rows.Clear()
            imgRepair.Image = Nothing
            imgRepair.Refresh()
            GC.Collect()
            For Each ctrl As Control In {boxTechnician, boxItem, boxRepair, boxDeliver, lblRepRemarks2, grdRepRemarks2, boxReceive, boxCustomer, boxProduct,
                lblPProblem, txtPProblem, lblRepRemarks1, grdRepRemarks1, lblLocation, cmbLocation, grpAdvancePay, grpRepTask, grpActivity}
                ctrl.Visible = False
            Next

            If cmbRetNo.Text = "" Then Exit Try
            For Each ctrl As Control In {boxReceive, boxCustomer, boxProduct, lblPProblem, txtPProblem, lblRepRemarks1, grdRepRemarks1, lblLocation,
                cmbLocation, grpAdvancePay, grpRepTask, grpActivity}
                ctrl.Visible = True
            Next
            For Each ctrl As Control In {boxTechnician, boxReceive, boxProduct, boxRepair, boxDeliver, boxCustomer, txtPProblem, lblLocation, cmbLocation,
                grpAdvancePay, grpRepTask, grpActivity}
                ctrl.Enabled = True
            Next
            CMDRETNO = New OleDb.OleDbCommand("Select Return.RetNo,Return.RNo,Receive.RDate,Receive.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3,Customer.CuRemarks," &
                                             "Return.Pno,Product.PCategory,Product.PName,Product.PModelNo,Product.PDetails,Return.PSerialNo,Return.Problem,Return.Qty,Return.TNo,Technician.TName," &
                                             "Return.Status,Return.Charge,Return.PaidPrice,Return.RetRepDate,Return.DNo,Location " &
                                             "from ((((Return inner join Receive on Return.RNo = Receive.RNo) inner join Customer on Receive.CuNo = Customer.CuNo) " &
                                             "inner join Product on Return.PNo = Product.PNo) left join Technician on Return.TNo = Technician.TNo)" &
                                             "where Return.RetNo = " & cmbRetNo.Text, CNN)
            DRREPNO = CMDRETNO.ExecuteReader()
            If DRREPNO.HasRows = False Then
                MsgBox("මෙම RE-Repair No එක Database එක තුල නොපවතියි.", vbCritical + vbOKOnly)
            End If
            DRREPNO.Read()
            cmbRetStatus.Text = DRREPNO("Status").ToString
            txtRNo.Text = DRREPNO("RNo").ToString
            txtRDate.Text = DRREPNO("RDate").ToString
            txtCuNo.Text = DRREPNO("CuNo").ToString
            cmbCuName.Text = DRREPNO("CuName").ToString
            txtCuTelNo1.Text = DRREPNO("CuTelNo1").ToString
            txtCuTelNo2.Text = DRREPNO("CuTelNo2").ToString
            txtCuTelNo3.Text = DRREPNO("CuTelNo3").ToString
            txtPNo.Text = DRREPNO("PNo").ToString
            cmbPCategory.Text = DRREPNO("PCategory").ToString
            cmbPName.Text = DRREPNO("PName").ToString
            txtPModelNo.Text = DRREPNO("PModelNO").ToString
            txtPDetails.Text = DRREPNO("PDetails").ToString
            txtPSerialNo.Text = DRREPNO("PSerialNo").ToString
            txtPQty.Text = DRREPNO("Qty").ToString
            txtPProblem.Text = DRREPNO("Problem").ToString
            cmbLocation.Text = DRREPNO("Location").ToString
            Dim CMDRETNO1 As New OleDbCommand("Select * from RepairRemarks1 Where RetNo=" & cmbRetNo.Text, CNN)
            Dim DRRETNo1 As OleDbDataReader = CMDRETNO1.ExecuteReader()
            grdRepRemarks1.Rows.Clear()
            While DRRETNo1.Read
                grdRepRemarks1.Rows.Add(DRRETNo1("Rem1No").ToString, DRRETNo1("Rem1Date").ToString, DRRETNo1("Remarks").ToString,
                                        GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRRETNo1("UNo").ToString, "UserName"))
            End While
            If File.Exists(Application.StartupPath & "\System Files\Images\" + "RET-" + cmbRetNo.Text + ".ls") Then
                imgRepair.Image = Image.FromFile(Application.StartupPath & "\System Files\Images\" + "RET-" + cmbRetNo.Text + ".ls")
            Else
                imgRepair.Image = Nothing
            End If
            CMDRETNO1 = New OleDbCommand("Select * from RepairActivity Where RetNo=" & cmbRetNo.Text, CNN)
            DRRETNo1 = CMDRETNO1.ExecuteReader()
            grdActivity.Rows.Clear()
            While DRRETNo1.Read
                grdActivity.Rows.Add(DRRETNo1("RepANo").ToString, DRRETNo1("RepADate").ToString, DRRETNo1("Activity").ToString,
                                        GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRRETNo1("UNo").ToString, "UserName"))
            End While
            CMDRETNO1 = New OleDbCommand("Select MsgNo,MsgDate,Action,Message,Status from Message where RetNo = " & cmbRetNo.Text, CNN)
            DRRETNo1 = CMDRETNO1.ExecuteReader
            grdRepTask.Rows.Clear()
            While DRRETNo1.Read
                grdRepTask.Rows.Add(DRRETNo1("MsgNo").ToString, DRRETNo1("MsgDate").ToString, DRRETNo1("Action").ToString, DRRETNo1("MESSAGE").ToString,
                                    DRRETNo1("STATUS").ToString)
            End While
            CMDRETNO1.Cancel()
            DRRETNo1.Close()
            If cmbRetStatus.Text = "Received" Then
                Exit Try
            End If
            boxTechnician.Visible = True
            lblRepRemarks2.Visible = True
            grdRepRemarks2.Visible = True       'fill fields Technician details
            txtTNo.Text = DRREPNO("TNo").ToString
            cmbTName.Text = DRREPNO("TName").ToString
            CMDRETNO1 = New OleDbCommand("Select * from RepairRemarks2 Where RetNo=" & cmbRetNo.Text, CNN)
            DRRETNo1 = CMDRETNO1.ExecuteReader()
            grdRepRemarks2.Rows.Clear()
            While DRRETNo1.Read
                grdRepRemarks2.Rows.Add(DRRETNo1("Rem2No").ToString, DRRETNo1("Rem2Date").ToString, DRRETNo1("Remarks").ToString,
                                        GetStrfromRelatedfield("Select UserName from [User] Where UNo=" & DRRETNo1("UNo").ToString, "UserName"))
            End While
            CMDRETNO1.Cancel()
            DRRETNo1.Close()
            If cmbRetStatus.Text = "Hand Over to Technician" Then
                Exit Try
            End If
            boxItem.Visible = True
            CMDRETNO1 = New OleDb.OleDbCommand("SELECT TechnicianCost.TCNo,TechnicianCost.TCDate,TechnicianCost.SNo,Stock.SCategory,Stock.SName," &
                                          "TechnicianCost.Rate,TechnicianCost.Qty,TechnicianCost.Total,TechnicianCost.TCRemarks from " &
                                          "STock, TechnicianCost where TechnicianCost.SNo = Stock.SNo And RetNo=" & cmbRetNo.Text & ";", CNN)
            DRRETNo1 = CMDRETNO1.ExecuteReader()
            grdTechnicianCost.Rows.Clear()
            If DRRETNo1.HasRows = True Then
                While DRRETNo1.Read
                    grdTechnicianCost.Rows.Add(DRRETNo1("TCNo").ToString, DRRETNo1("TCDate").ToString, DRRETNo1("SNo").ToString, DRRETNo1("SCategory").ToString,
                                               DRRETNo1("SName").ToString, DRRETNo1("Rate").ToString, DRRETNo1("Qty").ToString, DRRETNo1("Total").ToString, DRRETNo1("TCRemarks").ToString)
                End While
            End If
            DRRETNo1.Close()
            CMDRETNO1.Cancel()
            If cmbRetStatus.Text = "Repairing" Then
                Exit Try
            End If
            boxRepair.Visible = True
            txtRepPrice.Text = DRREPNO("Charge").ToString
            txtRepDate.Text = DRREPNO("RetRepDate").ToString
            If cmbRetStatus.Text = "Repaired Not Delivered" Or cmbRetStatus.Text = "Returned Not Delivered" Then
                Exit Try
            End If
            boxDeliver.Visible = True
            txtDNo.Text = DRREPNO("DNo").ToString
            txtDPaidPrice.Text = DRREPNO("PaidPrice").ToString
            CMDRETNO1 = New OleDb.OleDbCommand("Select Deliver.DDate, Deliver.CuNo, Customer.CuName, Customer.CuTelNo1, Customer.CuTelNo2, Customer.CuTelNo3 from Deliver, Customer where Deliver.Cuno = Customer.Cuno And Deliver.DNo = " & txtDNo.Text, CNN)
            DRRETNo1 = CMDRETNO1.ExecuteReader
            If DRRETNo1.HasRows = True Then
                DRRETNo1.Read()
                txtDDate.Value = DRRETNo1("DDAte").ToString
            End If
            DRRETNo1.Close()
            CMDRETNO1.Cancel()
            If cmbRetStatus.Text = "Repaired Delivered" Or cmbRetStatus.Text = "Returned Delivered" Then
                CMDRETNO.Cancel()

                If MdifrmMain.Tag = "Cashier" And txtDDate.Value.Month <> Today.Month Then
                    For Each ctrl As Control In {boxTechnician, boxReceive, boxProduct, boxRepair, boxDeliver, boxCustomer, txtPProblem, lblLocation, cmbLocation,
                        grpAdvancePay, grpRepTask, grpActivity}
                        ctrl.Enabled = False
                    Next
                End If
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        Finally
            If DRRETNO IsNot Nothing AndAlso DRRETNO.IsClosed = False Then
                CMDRETNO.Cancel()
            End If
            frmRepair_Resize(sender, e)
        End Try
    End Sub

    Private Sub cmbRetRepNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRetRepNo.SelectedIndexChanged
        CmbRetNo_DropDown(sender, e)
        cmbRetNo.SelectedIndex = 0
    End Sub

    Private Sub cmbRetNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbRetNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            CmbRetNo_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub cmbRetRepNo_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbRetRepNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbRetRepNo_SelectedIndexChanged(sender, e)
        End If
    End Sub
    Private Sub CmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        Call CmbDropDown(cmbTName, "Select TName from Technician Where TActive = True group by TName;", "TName")
    End Sub

    Private Sub cmbTName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTName.SelectedIndexChanged
        If cmbTName.Text = "" Then Exit Sub
        If tabRepair.SelectedTab.TabIndex = 0 Then
            If cmbRepStatus.Text = "Received" Then Exit Sub
        Else
            If cmbRetStatus.Text = "Received" Then Exit Sub
        End If
        txtTNo.Text = GetStrfromRelatedfield("Select TNo from Technician Where TName='" & cmbTName.Text & "'", "TNo")
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Call FrmRepair_Leave(sender, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            If CheckEmptyfieldtxt(txtCuNo, "මෙම Repair එක සඳහා ඔබ Customer කෙනෙකු තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!") = False Then
                Exit Try
            ElseIf CheckEmptyfieldtxt(txtPNo, "මෙම Repair එක සඳහා ඔබ Product එකක් තෝරා නොමැත. කරුණාකර එය ඇතුලත් කර නැවත උත්සහ කරන්න!!") = False Then
                Exit Try
            End If
            Select Case tabRepair.SelectedTab.TabIndex
                Case 0              'check empty fields which have filled to user
                    If cmbRepStatus.Text = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Or cmbRepStatus.Text = "Repaired Not Delivered" Or
                        cmbRepStatus.Text = "Repaired Delivered" Then
                        If CheckEmptyfieldcmb(cmbTName, "Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
                            Exit Try
                        End If
                    End If
                    If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Not Delivered" Or
                        cmbRepStatus.Text = "Returned Delivered" Then
                        If CheckEmptyfieldtxt(txtRepPrice, "Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.") = False Then
                            Exit Try
                        End If
                    End If

                    If DRREPNO("Status").ToString <> cmbRepStatus.Text Then
                        CMDUPDATE("update Repair set status ='" & cmbRepStatus.Text & "' where repno=" & cmbRepNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Status -> " & cmbRepStatus.Text & "'," & MdifrmMain.Tag & ")")
                    End If

                    If DRREPNO("CuNo").ToString <> txtCuNo.Text Then
                        CMDUPDATE("update Receive set cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Customer -> Name= " & cmbCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & MdifrmMain.Tag & ")")
                    End If

                    If DRREPNO("RDate").ToString <> txtRDate.Value.ToString Then
                        CMDUPDATE("update Receive set RDate=#" & txtRDate.Value.Date.ToString & "# where rno = " & txtRNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Received Date -> " & txtRDate.Value.ToString & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("PNo").ToString <> txtPNo.Text Then
                        CMDUPDATE("update Repair set pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("PSerialNo").ToString <> txtPSerialNo.Text Then
                        CMDUPDATE("update Repair set pserialno ='" & txtPSerialNo.Text & "' where repno = " & cmbRepNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Product Serial No -> " & txtPSerialNo.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("Problem").ToString <> txtPProblem.Text Then
                        CMDUPDATE("update Repair set Problem ='" & txtPProblem.Text & "' where repno = " & cmbRepNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Problem -> " & txtPProblem.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("Location").ToString <> cmbLocation.Text Then
                        CMDUPDATE("update Repair set Location= '" & cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Location -> " & cmbLocation.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Try
                    End If
                    If DRREPNO("TNo").ToString <> txtTNo.Text Then
                        CMDUPDATE("update Repair set tno =" & txtTNo.Text & " where repno=" & cmbRepNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Technician -> " & cmbTName.Text & "'," & MdifrmMain.Tag & ")")
                    End If

                    If cmbRepStatus.Text.ToString = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Try
                    End If

                    If DRREPNO("Charge").ToString <> txtRepPrice.Text Then
                        CMDUPDATE("update Repair set charge=" & txtRepPrice.Text & " where repno=" & cmbRepNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Repair Charge -> " & txtRepPrice.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("RepDate").ToString <> txtRepDate.Value.ToString Then
                        CMDUPDATE("update Repair set repdate=#" & txtRepDate.Value.ToString & "# where repno=" & cmbRepNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RepNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRepNo.Text & ",#" & DateAndTime.Now & "#,'Repaired Date -> " & txtRepDate.Value.ToString & "'," & MdifrmMain.Tag & ")")
                    End If

                    If Me.Tag = "" Then MsgBox("Update successful!", vbInformation + vbOKOnly)

                    Exit Try
                Case 1
                    If cmbRetStatus.Text = "Hand Over to Technician" Or "Repairing" Or "Repaired Not Delivered" Or "Repaired Delivered" Then
                        If CheckEmptyfieldtxt(txtTNo, "Technician කෙනෙකු තොරා නොමැත. කරුණාකර අදාළ Technician ව තෝරා දෙන්න.") = False Then
                            Exit Try
                        End If
                    End If
                    If cmbRetStatus.Text = "Repaired Not Delivered" Or "Repaired Delivered" Or "Returned Not Delivered" Or "Returned Delivered" Then
                        If CheckEmptyfieldtxt(txtRepPrice, "Repair Price එකක් ඇතුලත් කර නොමැත කරුණාකර Repair Price එක ඇතුලත් කරන්න.") = False Then
                            Exit Try
                        End If
                    End If

                    If DRREPNO("Status") <> cmbRetStatus.Text Then
                        CMDUPDATE("update Return set status ='" & cmbRetStatus.Text & "' where retno=" & cmbRetNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Status -> " & cmbRetStatus.Text & "'," & MdifrmMain.Tag & ")")
                    End If

                    If DRREPNO("CuNo") <> txtCuNo.Text Then
                        CMDUPDATE("update Receive set Cuno =" & txtCuNo.Text & " where rno = " & txtRNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Customer -> Name= " & cmbCuName.Text & ", Telephone No 1= " & txtCuTelNo1.Text &
                                  ", Telephone No 2= " & txtCuTelNo2.Text & ", Telephone No 3= " & txtCuTelNo3.Text & "'," & MdifrmMain.Tag & ")")
                    End If

                    If DRREPNO("RDate") <> txtRDate.Value.ToString Then
                        CMDUPDATE("update Receive set RDate=#" & txtRDate.Value.Date.ToString & "# where rno = " & txtRNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Received Date -> " & txtRDate.Value.ToString & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("PNo") <> txtPNo.Text Then
                        CMDUPDATE("update Return set pno = " & txtPNo.Text & " where repno = " & cmbRepNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Product -> Category= " & cmbPCategory.Text & ", Name= " & cmbPName.Text &
                                  ", Model No= " & txtPModelNo.Text & ", Qty= " & txtPQty.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("PSerialNo") <> txtPSerialNo.Text Then
                        CMDUPDATE("update Return set pserialno ='" & txtPSerialNo.Text & "' where retno = " & cmbRetNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Product Serial No -> " & txtPSerialNo.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("Problem") <> txtPProblem.Text Then
                        CMDUPDATE("update Return set problem ='" & txtPProblem.Text & "' where retno = " & cmbRetNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Problem -> " & txtPProblem.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("Location") <> cmbLocation.Text Then
                        CMDUPDATE("update Return set Location= '" & cmbLocation.Text & "' where repno = " & cmbRepNo.Text)
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Location -> " & cmbLocation.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Try
                    End If
                    If DRREPNO("TNo") <> txtTNo.Text Then
                        CMDUPDATE("update Return set tno =" & txtTNo.Text & " where retno=" & cmbRetNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Technician -> " & cmbTName.Text & "'," & MdifrmMain.Tag & ")")
                    End If

                    If cmbRepStatus.Text = "Hand Over to Technician" Or cmbRepStatus.Text = "Repairing" Then
                        MsgBox("Update successful!", vbInformation + vbOKOnly)
                        Exit Try
                    End If

                    If DRREPNO("Charge") <> txtRepPrice.Text Then
                        CMDUPDATE("update Return set charge=" & txtRepPrice.Text & " where retno=" & cmbRetNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Repair Charge -> " & txtRepPrice.Text & "'," & MdifrmMain.Tag & ")")
                    End If
                    If DRREPNO("RepDate") <> txtRepDate.Value.ToString Then
                        CMDUPDATE("update Return set repdate=#" & txtRepDate.Value.ToString & "# where retno=" & cmbRetNo.Text & ";")
                        CMDUPDATE("Insert into RepairActivity(RepANo,RetNo,RepADate,Activity,UNo)" &
                                  " Values(" & AutomaticPrimaryKeyStr("RepairActivity", "RepANo") & "," &
                                  cmbRetNo.Text & ",#" & DateAndTime.Now & "#,'Repaired Date -> " & txtRepDate.Value.ToString & "'," & MdifrmMain.Tag & ")")
                    End If
                    If Me.Tag = "" Then MsgBox("Update successful!", vbInformation + vbOKOnly)
                    Exit Try
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly)
        Finally
            If tabRepair.SelectedTab.TabIndex = 0 Then
                CmbRepNo_SelectedIndexChanged(sender, e)
            End If
        End Try
    End Sub

    Public Sub CmbRetStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRetStatus.SelectionChangeCommitted
        boxTechnician.Visible = False
        boxItem.Visible = False
        boxRepair.Visible = False
        boxDeliver.Visible = False
        lblRepRemarks2.Visible = False
        grdRepRemarks2.Visible = False
        boxReceive.Visible = False
        boxCustomer.Visible = False
        boxProduct.Visible = False
        lblPProblem.Visible = False
        txtPProblem.Visible = False
        lblRepRemarks1.Visible = False
        grdRepRemarks1.Visible = False
        If cmbRetNo.Text = "" Then Exit Sub
        If cmbRetStatus.Text = "" Then Exit Sub
        boxReceive.Visible = True
        boxCustomer.Visible = True
        boxProduct.Visible = True
        lblPProblem.Visible = True
        txtPProblem.Visible = True
        lblRepRemarks1.Visible = True
        grdRepRemarks1.Visible = True
        If cmbRetStatus.Text = "Received" Or cmbRetStatus.Text = "Canceled" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxTechnician.Visible = True
        lblRepRemarks2.Visible = True
        grdRepRemarks2.Visible = True
        If cmbRetRepNo.Text <> "" Then
            CMD = New OleDb.OleDbCommand("Select Technician.TNo,Technician.TName from Return,Technician where Return.TNo = Technician.TNo and Return.RepNo=" & cmbRetRepNo.Text, CNN)
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                DR.Read()
                cmbTName.Text = DR("TName").ToString
            End If
        End If
        If cmbRetStatus.Text = "Hand Over to Technician" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxItem.Visible = True
        If cmbRetStatus.Text = "Repairing" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxRepair.Visible = True
        If cmbRetStatus.Text = "Repaired Not Delivered" Or cmbRetStatus.Text = "Returned Not Delivered" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxDeliver.Visible = True
        If cmbRetStatus.Text = "Repaired Delivered" Or cmbRetStatus.Text = "Returned Delivered" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
    End Sub

    Public Sub CmbRepStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRepStatus.SelectionChangeCommitted
        boxTechnician.Visible = False
        boxItem.Visible = False
        boxRepair.Visible = False
        boxDeliver.Visible = False
        lblRepRemarks2.Visible = False
        grdRepRemarks2.Visible = False
        boxReceive.Visible = False
        boxCustomer.Visible = False
        boxProduct.Visible = False
        lblPProblem.Visible = False
        txtPProblem.Visible = False
        lblRepRemarks1.Visible = False
        grdRepRemarks1.Visible = False
        If cmbRepNo.Text = "" Then Exit Sub
        If cmbRepStatus.Text = "" Then Exit Sub
        boxReceive.Visible = True
        boxCustomer.Visible = True
        boxProduct.Visible = True
        lblPProblem.Visible = True
        txtPProblem.Visible = True
        lblRepRemarks1.Visible = True
        grdRepRemarks1.Visible = True
        If cmbRepStatus.Text = "Received" Or cmbRepStatus.Text = "Canceled" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxTechnician.Visible = True
        lblRepRemarks2.Visible = True
        grdRepRemarks2.Visible = True
        If cmbRepStatus.Text = "Hand Over to Technician" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxItem.Visible = True
        If cmbRepStatus.Text = "Repairing" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxRepair.Visible = True
        If cmbRepStatus.Text = "Repaired Not Delivered" Or cmbRepStatus.Text = "Returned Not Delivered" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
        boxDeliver.Visible = True
        If cmbRepStatus.Text = "Repaired Delivered" Or cmbRepStatus.Text = "Returned Delivered" Then
            frmRepair_Resize(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Call cmdSave_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Call CmdClose_Click(sender, e)
    End Sub

    Private Sub CmdRepView_Click(sender As Object, e As EventArgs) Handles cmdRepView.Click
        Dim frmSearchRepair As New frmSearch With {
            .Tag = "Repair"
        }
        frmSearchRepair.Show()
    End Sub

    Private Sub CmdReRepView_Click(sender As Object, e As EventArgs) Handles cmdReRepView.Click
        Dim frmSearchReRepair As New frmSearch With {
            .Tag = "ReRepair"
        }
        frmSearchReRepair.Show()
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure this repair will be deleted?", vbYesNo + vbCritical) = vbYes Then
            If cmbRetNo.Text = "" Then
                CMDUPDATE("DELETE from Repair where RepNo=" & cmbRepNo.Text)
            Else
                CMDUPDATE("DELETE from Return where RetNo=" & cmbRetNo.Text)
            End If
        End If
        Dim cmd1 As New OleDb.OleDbCommand()
        Dim x As String = ""
        CMD = New OleDb.OleDbCommand("Select RNo,RepNo from Repair where RepNo = " & cmbRepNo.Text, CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            If DR.FieldCount > 1 Then
                x = "were " + Str(DR.FieldCount) + " repair fields"
            Else
                x = "was " + Str(DR.FieldCount) + " repair field"
            End If
        End If
        If MsgBox("There " + x + " of received details. Are you sure received details of this repair will be deleted?", vbYesNo + vbCritical) = vbYes Then
            If cmbRetNo.Text = "" Then
                CMD = New OleDb.OleDbCommand("Select RNo from Repair where RepNo = " & cmbRepNo.Text, CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    CMDUPDATE("DELETE from Receive where RNo=" & DR("RNO").ToString)
                End If
            Else
                CMD = New OleDb.OleDbCommand("Select RNo from Return where RetNo = " & cmbRetNo.Text, CNN)
                DR = CMD.ExecuteReader()
                If DR.HasRows = True Then
                    CMDUPDATE("DELETE from Receive where RNo=" & DR("RNO").ToString)
                End If
            End If
        End If
        If MsgBox("Are you sure this techniciancost will be deleted?", vbYesNo + vbCritical) = vbYes Then
            If cmbRetNo.Text = "" Then
                CMDUPDATE("DELETE from TechnicianCost where RepNo=" & cmbRepNo.Text)
            Else
                CMDUPDATE("DELETE from TechnicianCost where RetNo=" & cmbRetNo.Text)
            End If
        End If
    End Sub

    Private Sub CmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        Select Case Me.Tag
            Case "DeliverRepair"
                With frmDeliver
                    Call cmdSave_Click(sender, e)
                    With frmDeliver
                        .grdRepair.Item(0, .grdRepair.CurrentCell.RowIndex).Value = cmbRepNo.Text
                        Dim E1 As New DataGridViewCellEventArgs(0, .grdRepair.CurrentCell.RowIndex)
                        Call .GrdRepair_CellEndEdit(sender, E1)
                    End With
                End With
            Case "DeliverReRepair"
                With frmDeliver
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

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        Call CmdDone_Click(sender, e)
    End Sub

    Private Sub CmbCuName_DropDown(sender As Object, e As EventArgs) Handles cmbCuName.DropDown
        Call CmbDropDown(cmbCuName, "Select CuName from Customer group by CuName;", "CuName")
    End Sub

    Public Sub CmbCuName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("Select * from Customer Where CuName = '" & cmbCuName.Text & "';", CNN)
        DR = CMD.ExecuteReader()
        If DR.HasRows = True Then
            DR.Read()
            txtCuNo.Text = DR("CuNo").ToString
            txtCuTelNo1.Text = DR("CuTelno1").ToString
            txtCuTelNo2.Text = DR("CuTelNo2").ToString
            txtCuTelNo3.Text = DR("CuTelNo3").ToString
        End If
    End Sub

    Private Sub CmdCuView_Click(sender As Object, e As EventArgs) Handles cmdCuView.Click
        frmCustomer.Tag = "Repair"
        frmCustomer.Show()
    End Sub

    Private Sub CmbPCategory_DropDown(sender As Object, e As EventArgs) Handles cmbPCategory.DropDown
        Call CmbDropDown(cmbPCategory, "Select PCAtegory from Product Group by PCategory;", "PCategory")
    End Sub

    Private Sub CmbPCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPCategory.SelectedIndexChanged
        cmbPName.Text = ""
    End Sub

    Private Sub CmbPName_DropDown(sender As Object, e As EventArgs) Handles cmbPName.DropDown
        Call CmbDropDown(cmbPName, "Select PName from Product where PCategory='" & cmbPCategory.Text & "' group by PName;", "PName")
    End Sub

    Public Sub CmbPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("Select * from Product where PCategory ='" & cmbPCategory.Text & "' and PName ='" & cmbPName.Text & "';", CNN)
        DR = CMD.ExecuteReader
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
        If tabRepair.SelectedTab.TabIndex = 0 Then
            RepairInfoToolStripMenuItem.Text = "Repair Info"
            CmbRepNo_SelectedIndexChanged(sender, e)
        Else
            RepairInfoToolStripMenuItem.Text = "ReRepair Info"
            CmbRetNo_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub PrintRepairStickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRepairStickerToolStripMenuItem.Click
        Dim frm As New frmReport
        Dim DT As New DataTable
        DT.Clear()
        DT.Columns.Add("RepNo")
        DT.Columns.Add("CuName")
        DT.Columns.Add("CuTelNo1")
        DT.Columns.Add("CuTelNo2")
        DT.Columns.Add("CuTelNo3")
        DT.Columns.Add("PCategory")
        DT.Columns.Add("PName")
        DT.Columns.Add("RDate")
        DT.Columns.Add(New DataColumn("Barcode", GetType(Byte())))
        Dim imgStream As MemoryStream = New MemoryStream()
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        writer.Options.PureBarcode = True
        Dim img As Image = writer.Write(cmbRepNo.Text)
        img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
        imgStream.Close()
        Dim byteArray As Byte() = imgStream.ToArray()
        DT.Rows.Add("R" + cmbRepNo.Text, cmbCuName.Text, txtCuTelNo1.Text, txtCuTelNo2.Text, txtCuTelNo3.Text, cmbPCategory.Text, cmbPName.Text,
                    txtRDate.Value.ToString, byteArray)
        Dim rpt As New rptRepairSticker
        rpt.SetDataSource(DT)
        Dim c As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = My.Settings.StickerPrinterName
        Dim rawKind As Integer
        For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(c).PaperName = My.Settings.RepairStickerPrinterPaperName Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                Exit For
            End If
        Next
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
        frm.ReportViewer.ReportSource = rpt
        frm.Show(Me)
    End Sub

    Private Sub PrintReceivedReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintReceivedReceiptToolStripMenuItem.Click
        Dim bgWorker As New System.ComponentModel.BackgroundWorker With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}
        AddHandler bgWorker.DoWork, AddressOf bgWorker_DoWork
        AddHandler bgWorker.RunWorkerCompleted, AddressOf bgWorker_RunWorkerCompleted
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs)
        Dim RPT As New rptReceive
        Dim DS1 As New DataSet
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT Repair.RepNo,Repair.PNo,Product.PCategory,Product.PName,Product.PModelNo,Product.PDetails," &
                                              "Repair.PSerialNo,Repair.Qty,Repair.Problem,'' as RepRemarks1 from Repair,Product,Receive where " &
                                              "Receive.RNO = Repair.RNo And Repair.PNo = Product.PNo And Receive.RNo = " & txtRNo.Text & ";", CNN)
        DA1.Fill(DS1, "Repair")
        DA1.Fill(DS1, "Product")
        For Each row As DataRow In DS1.Tables.Item("Repair").Rows
            Dim CMD1 As New OleDbCommand("Select Remarks from RepairRemarks1 Where RepNo=" & row.Item("RepNo"), CNN)
            Dim DR1 As OleDbDataReader = CMD1.ExecuteReader
            row.Item("RepRemarks1") = ""
            While DR1.Read
                row.Item("RepRemarks1") += DR1("Remarks").ToString + vbCrLf
            End While
        Next
        RPT.Subreports.Item("rptReceiveRepair.rpt").SetDataSource(DS1)
        Dim RPT2 As New rptReceiveReturn 'The report you created.
        Dim DS2 As New DataSet
        Dim DA2 As New OleDb.OleDbDataAdapter("Select Return.RetNo,Return.RepNo,Return.PNo,Product.PCategory,Product.Pname,Product.PModelNo,Return.PSerialNo,Return.Qty,Return.Problem,Return.RetRemarks1 from Return,Product,Receive where Receive.RNO = Return.RNo And Return.PNo = Product.PNo And Receive.RNo = " & txtRNo.Text & ";", CNN)
        DA2.Fill(DS2, "Return")
        DA2.Fill(DS2, "Product")
        RPT.Subreports.Item("rptReceiveReturn.rpt").SetDataSource(DS2)
        Dim DS3 As New DataSet
        Dim DA3 As New OleDb.OleDbDataAdapter("SELECT Receive.RNo,Receive.RDate,Receive.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3 from Receive,Customer where Receive.CuNo = Customer.CuNo And Receive.RNo = " & txtRNo.Text & ";", CNN)
        DA3.Fill(DS3, "Receive")
        DA3.Fill(DS3, "Customer")
        RPT.SetDataSource(DS3)
        RPT.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text) 'Set Cashier Name to Parameter Value
        Dim c As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = "Zonerich AB-220K"
        Dim rawKind As Integer
        For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(c).PaperName = "76mm * 297mm" Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                Exit For
            End If
        Next
        RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        RPT.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
        e.Result = RPT
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim frm As New frmReport
        frm.ReportViewer.ReportSource = e.Result
        frm.Show(Me)

    End Sub
    Private Sub PrintDeliverReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDeliverReceiptToolStripMenuItem.Click
        If boxDeliver.Visible = False Or txtDNo.Text = "" Then
            Exit Sub
        End If
        Dim RPT As New rptDeliver
        Dim frm As New frmReport
        Dim DT1 As New DataTable
        Dim DS1 As New DataSet
        Dim DA1 As New OleDb.OleDbDataAdapter("SELECT Repair.RepNo,Repair.PNo,Product.PCategory,Product.PName,Repair.Qty,Repair.PaidPrice,Repair.TNo from Repair,Product,Deliver where Deliver.DNO = Repair.DNo And Repair.PNo = Product.PNo And Deliver.DNo = " & txtDNo.Text & ";", CNN)
        DA1.Fill(DS1, "Repair")
        DA1.Fill(DS1, "Product")
        RPT.Subreports.Item("rptDeliverRepair.rpt").SetDataSource(DS1)
        Dim RPT2 As New rptReceiveReturn 'The report you created.
        Dim DT2 As New DataTable
        Dim DS2 As New DataSet
        Dim DA2 As New OleDb.OleDbDataAdapter("Select Return.RetNo,Return.RepNo,Return.PNo,Product.PCategory,Product.Pname,Return.Qty,Return.PaidPrice,Return.TNo from Return,Product,Deliver where Deliver.DNO = Return.DNo And Return.PNo = Product.PNo And Deliver.DNO  = " & txtDNo.Text & ";", CNN)
        DA2.Fill(DS2, "Return")
        DA2.Fill(DS2, "Product")
        RPT.Subreports.Item("rptDeliverReturn.rpt").SetDataSource(DS2)
        Dim DT3 As New DataTable
        Dim DS3 As New DataSet
        Dim DA3 As New OleDb.OleDbDataAdapter("SELECT Deliver.DNo, Deliver.DDate,Deliver.CuNo,Customer.CuName,Customer.CuTelNo1,Customer.CuTelNo2,Customer.CuTelNo3,Deliver.DGrandTotal,Deliver.CReceived,Deliver.CBalance,Deliver.CAmount,Deliver.CPInvoiceNO,Deliver.CPAmount,Deliver.CuLNo,Deliver.CuLAmount,Deliver.DRemarks from Deliver,Customer where Deliver.CuNo = Customer.CuNo And Deliver.DNo = " & txtDNo.Text & ";", CNN)
        DA3.Fill(DS3, "Deliver")
        DA3.Fill(DS3, "Customer")
        RPT.SetDataSource(DS3)
        RPT.SetParameterValue("Cashier Name", MdifrmMain.tslblUserName.Text) 'Set Cashier Name to Parameter Value
        Dim c As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = "Zonerich AB-220K"
        Dim rawKind As Integer
        For c = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(c).PaperName = "76mm * 297mm" Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(c).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(c)))
                Exit For
            End If
        Next
        RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        RPT.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
        frm.ReportViewer.ReportSource = RPT
        frm.Show(Me)
    End Sub

#Region "grdRepRemarks1Property"
    Private Sub grdRepRemarks1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks1.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = 1 Then
            grdRepRemarks1.Controls.Add(dtpDate)
            dtpDate.Location = grdRepRemarks1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            dtpDate.Size = New Size(grdRepRemarks1.Columns.Item(e.ColumnIndex).Width, grdRepRemarks1.Rows.Item(e.RowIndex).Height)
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
            dtpDate.Visible = True
            If grdRepRemarks1.CurrentCell.Value Is Nothing Then
                dtpDate.Value = DateTime.Now
            Else
                dtpDate.Value = Convert.ToDateTime(grdRepRemarks1.CurrentCell.Value)
            End If
        End If
        grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Tag = grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdRepRemarks1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepRemarks1.EditingControlShowing
        If grdRepRemarks1.CurrentCell.RowIndex < 0 Then Exit Sub
        If grdRepRemarks1.Focused And grdRepRemarks1.CurrentCell.ColumnIndex = 1 Then
            dtpDate.Location = grdRepRemarks1.GetCellDisplayRectangle(grdRepRemarks1.CurrentCell.ColumnIndex, grdRepRemarks1.CurrentCell.RowIndex, True).Location
            dtpDate.Size = New Size(grdRepRemarks1.Columns.Item(grdRepRemarks1.CurrentCell.ColumnIndex).Width, grdRepRemarks1.Rows.Item(grdRepRemarks1.CurrentCell.RowIndex).Height)
        End If
    End Sub

    Private Sub grdRepRemarks1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepRemarks1.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Dim AdminSend As Boolean = False
        Dim Remarks As String = ""
        If e.ColumnIndex = 1 Then
            grdRepRemarks1.CurrentCell.Value = dtpDate.Value.ToString
            dtpDate.Visible = False
            If grdRepRemarks1.Item(1, e.RowIndex).Tag IsNot Nothing AndAlso
                Convert.ToDateTime(grdRepRemarks1.Item(1, e.RowIndex).Tag).Date <> DateTime.Today.Date Then
                AdminSend = True
                Remarks = "Repair Remarks 1 හිදි අද දිනට නොමැති Remarks එකක දිනයක් වෙනස් කෙරුණි."
            End If
        ElseIf e.ColumnIndex = 2 And e.RowIndex <> (grdRepRemarks1.Rows.Count - 1) Then
            If (MdifrmMain.tslblUserType.Text <> "Admin" And grdRepRemarks1.Item(1, e.RowIndex).Value IsNot Nothing AndAlso
                grdRepRemarks1.Item(1, e.RowIndex).Value.ToString <> "" AndAlso
                DateAndTime.DateValue(grdRepRemarks1.Item(1, e.RowIndex).Value) <> DateTime.Today.Date) Then
                AdminSend = True
                Remarks = "Repair Remarks 1 හිදි අද දිනට නොමැති Remarks එකක් වෙනස් කෙරුණි."
            End If
            If grdRepRemarks1.Item(1, e.RowIndex).Value Is Nothing Or
                grdRepRemarks1.Item(2, e.RowIndex).Value <> grdRepRemarks1.Item(2, e.RowIndex).Tag Then grdRepRemarks1.Item(1, e.RowIndex).Value = DateTime.Now
            If grdRepRemarks1.Item(3, e.RowIndex).Value Is Nothing Or
                    grdRepRemarks1.Item(2, e.RowIndex).Value <> grdRepRemarks1.Item(2, e.RowIndex).Tag Then grdRepRemarks1.Item(3, e.RowIndex).Value =
                    MdifrmMain.tslblUserName.Text
            If grdRepRemarks1.Item(2, e.RowIndex).Value Is Nothing Then
                grdRepRemarks1.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            ElseIf grdRepRemarks1.Item(2, e.RowIndex).Value.ToString.Replace(" ", "") = "" Then
                grdRepRemarks1.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            Else
                If grdRepRemarks1.Item(0, e.RowIndex).Value Is Nothing Then grdRepRemarks1.Item(0, e.RowIndex).Value =
                    AutomaticPrimaryKeyStr("RepairRemarks1", "Rem1No")
            End If
        End If
        If e.RowIndex <> (grdRepRemarks1.Rows.Count - 1) And
            grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Tag <> grdRepRemarks1.Item(e.ColumnIndex, e.RowIndex).Value Then
            If CheckExistData("Select Rem1No from RepairRemarks1 Where Rem1No=" & grdRepRemarks1.Item(0, e.RowIndex).Value) = True Then
                CMDUPDATE("Update RepairRemarks1 set " &
                          If(tabRepair.SelectedTab.TabIndex = 0, "RepNo=" & cmbRepNo.Text, "RetNo=" & cmbRetNo.Text) &
                          ",Rem1Date=#" & grdRepRemarks1.Item(1, e.RowIndex).Value &
                          "#,Remarks='" & grdRepRemarks1.Item(2, e.RowIndex).Value &
                          "',UNo=" & GetStrfromRelatedfield("Select UNo from [User] Where UserName='" & grdRepRemarks1.Item(3, e.RowIndex).Value & "'", "UNo") &
                          " Where Rem1No=" & grdRepRemarks1.Item(0, e.RowIndex).Value, AdminSend, Remarks)
            Else
                CMDUPDATE("Insert into RepairRemarks1(Rem1No," & If(tabRepair.SelectedTab.TabIndex = 0, "RepNo", "RetNo") &
                          ", Rem1Date, Remarks, UNo) Values(" & grdRepRemarks1.Item(0, e.RowIndex).Value & "," &
                          If(tabRepair.SelectedTab.TabIndex = 0, cmbRepNo.Text, cmbRetNo.Text) & ",#" & grdRepRemarks1.Item(1, e.RowIndex).Value &
                          "#,'" & grdRepRemarks1.Item(2, e.RowIndex).Value & "'," &
                          GetStrfromRelatedfield("Select UNo from [User] Where UserName='" & grdRepRemarks1.Item(3, e.RowIndex).Value & "'", "UNo") &
                          ")", AdminSend, Remarks)
            End If
        End If
        If AdminSend = True Then
            Dim E1 As New DataGridViewCellCancelEventArgs(e.ColumnIndex, e.RowIndex)
            grdRepRemarks1_RowValidating(sender, E1)
        End If
    End Sub

    Private Sub grdRepRemarks1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdRepRemarks1.UserDeletingRow
        If e.Row.Index < 0 Or e.Row.Index = (grdRepRemarks1.Rows.Count - 1) Then Exit Sub
        Dim AdminSend As Boolean = False
        Dim Remarks As String = ""
        If MdifrmMain.tslblUserType.Text <> "Admin" And Convert.ToDateTime(grdRepRemarks1.Item(1, e.Row.Index).Value).Date <> DateTime.Today.Date Then
            AdminSend = True
            Remarks = "Repair Remarks 1 හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        CMDUPDATE("Delete from RepairRemarks1 Where Rem1No=" & grdRepRemarks1.Item(0, e.Row.Index).Value, AdminSend, Remarks)
    End Sub

    Private Sub grdRepRemarks1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks1.RowValidating
        If e.RowIndex < 0 Then Exit Sub
        If grdRepRemarks1.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
        Dim CMD1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT Rem1No,Rem1Date,Remarks,UNo from " &
                                        "RepairRemarks1 where Rem1No=" & grdRepRemarks1.Item(0, e.RowIndex).Value & ";", CNN)
        Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader()
        If DR1.HasRows Then
            DR1.Read()
            grdRepRemarks1.Item(1, e.RowIndex).Value = DR1("Rem1Date").ToString
            grdRepRemarks1.Item(2, e.RowIndex).Value = DR1("Remarks").ToString
            grdRepRemarks1.Item(3, e.RowIndex).Value = If(DR1("UNo").ToString <> "",
                GetStrfromRelatedfield("Select UserName from [User] where Uno=" & DR1("UNo").ToString, "UserName"), "")
        Else
            grdRepRemarks1.Rows.RemoveAt(e.RowIndex)
        End If
        CMD1.Cancel()
        DR1.Close()
    End Sub
#End Region

#Region "grdRepRemarks2Property"
    Private Sub grdRepRemarks2_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks2.CellBeginEdit
        If grdRepRemarks2.Focused And e.ColumnIndex = 1 And e.RowIndex > -1 Then
            grdRepRemarks2.Controls.Add(dtpDate)
            dtpDate.Location = grdRepRemarks2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            dtpDate.Size = New Size(grdRepRemarks2.Columns.Item(e.ColumnIndex).Width, grdRepRemarks2.Rows.Item(e.RowIndex).Height)
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
            dtpDate.Visible = True
            If grdRepRemarks2.CurrentCell.Value IsNot Nothing Then
                dtpDate.Value = Convert.ToDateTime(grdRepRemarks2.CurrentCell.Value)
            Else
                dtpDate.Value = DateTime.Now
            End If
        End If
        grdRepRemarks2.Item(e.ColumnIndex, e.RowIndex).Tag = grdRepRemarks2.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdRepRemarks2_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdRepRemarks2.EditingControlShowing
        If grdRepRemarks2.CurrentCell.RowIndex < 0 Then Exit Sub
        If grdRepRemarks2.Focused And grdRepRemarks2.CurrentCell.ColumnIndex = 1 Then
            dtpDate.Location = grdRepRemarks2.GetCellDisplayRectangle(grdRepRemarks2.CurrentCell.ColumnIndex, grdRepRemarks2.CurrentCell.RowIndex, True).Location
            dtpDate.Size = New Size(grdRepRemarks2.Columns.Item(grdRepRemarks2.CurrentCell.ColumnIndex).Width, grdRepRemarks2.Rows.Item(grdRepRemarks2.CurrentCell.RowIndex).Height)
        End If
    End Sub

    Private Sub grdRepRemarks2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepRemarks2.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Dim AdminSend As Boolean = False
        Dim Remarks As String = ""
        If grdRepRemarks2.Focused And e.ColumnIndex = 1 Then
            grdRepRemarks2.CurrentCell.Value = dtpDate.Value.ToString
            dtpDate.Visible = False
            If grdRepRemarks2.Item(1, e.RowIndex).Tag IsNot Nothing AndAlso
                Convert.ToDateTime(grdRepRemarks2.Item(1, e.RowIndex).Tag).Date <> DateTime.Today.Date Then
                AdminSend = True
                Remarks = "Repair Remarks 2 හිදි අද දිනට නොමැති Remarks එකක දිනයක් වෙනස් කෙරුණි."
            End If
        ElseIf e.ColumnIndex = 2 And e.RowIndex <> (grdRepRemarks2.Rows.Count - 1) Then
            If (MdifrmMain.tslblUserType.Text <> "Admin" And grdRepRemarks2.Item(1, e.RowIndex).Value IsNot Nothing AndAlso
           Convert.ToDateTime(grdRepRemarks2.Item(1, e.RowIndex).Value).Date <> DateTime.Today.Date) Then
                AdminSend = True
                Remarks = "Repair Remarks 2 හිදි අද දිනට නොමැති Remarks එකක් වෙනස් කෙරුණි."
            End If
            If grdRepRemarks2.Item(1, e.RowIndex).Value Is Nothing Or
                grdRepRemarks2.Item(2, e.RowIndex).Value <> grdRepRemarks2.Item(2, e.RowIndex).Tag Then grdRepRemarks2.Item(1, e.RowIndex).Value = DateTime.Now
            If grdRepRemarks2.Item(3, e.RowIndex).Value Is Nothing Or
                grdRepRemarks2.Item(2, e.RowIndex).Value <> grdRepRemarks2.Item(2, e.RowIndex).Tag Then grdRepRemarks2.Item(3, e.RowIndex).Value = MdifrmMain.tslblUserName.Text
            If grdRepRemarks2.Item(2, e.RowIndex).Value Is Nothing Then
                grdRepRemarks2.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            ElseIf grdRepRemarks2.Item(2, e.RowIndex).Value.ToString.Replace(" ", "") = "" Then
                grdRepRemarks2.Rows.RemoveAt(e.RowIndex)
                Exit Sub
            Else
                If grdRepRemarks2.Item(0, e.RowIndex).Value Is Nothing Then
                    grdRepRemarks2.Item(0, e.RowIndex).Value = AutomaticPrimaryKeyStr("RepairRemarks2", "Rem2No")
                    For Each row As DataGridViewRow In grdRepRemarks2.Rows
                        If row.Index = e.RowIndex Or row.Index = (grdRepRemarks2.Rows.Count - 1) Then Continue For
                        If row.Cells(0).Value >= grdRepRemarks2.Item(0, e.RowIndex).Value Then
                            grdRepRemarks2.Item(0, e.RowIndex).Value = row.Cells(0).Value + 1
                        End If
                    Next
                End If
            End If
        End If
        If e.RowIndex <> (grdRepRemarks2.Rows.Count - 1) Then
            If CheckExistData("Select Rem2No from RepairRemarks2 Where Rem2No=" & grdRepRemarks2.Item(0, e.RowIndex).Value) = True Then
                CMDUPDATE("Update RepairRemarks2 set " & If(tabRepair.SelectedTab.TabIndex = 0, "RepNo=" & cmbRepNo.Text, "RetNo=" & cmbRetNo.Text) &
                          ", Rem2Date =#" & grdRepRemarks2.Item(1, e.RowIndex).Value &
                          "#, Remarks ='" & grdRepRemarks2.Item(2, e.RowIndex).Value &
                          "',UNo=" & GetStrfromRelatedfield("Select UNo from [User] Where UserName='" & grdRepRemarks2.Item(3, e.RowIndex).Value & "'", "UNo") &
                          " Where Rem2No=" & grdRepRemarks2.Item(0, e.RowIndex).Value, AdminSend, Remarks)
            Else
                CMDUPDATE("Insert into RepairRemarks2(Rem2No," & If(tabRepair.SelectedTab.TabIndex = 0, "RepNo", "RetNo") &
                          ",Rem2Date,Remarks,UNo) Values(" & grdRepRemarks2.Item(0, e.RowIndex).Value & "," &
                          If(tabRepair.SelectedTab.TabIndex = 0, cmbRepNo.Text, cmbRetNo.Text) & ",#" & grdRepRemarks2.Item(1, e.RowIndex).Value &
                          "#,'" & grdRepRemarks2.Item(2, e.RowIndex).Value & "'," &
                          GetStrfromRelatedfield("Select UNo from [User] Where UserName='" & grdRepRemarks2.Item(3, e.RowIndex).Value & "'", "UNo") &
                          ")", AdminSend, Remarks)
            End If

        End If
        If AdminSend = True Then
            Dim E1 As New DataGridViewCellCancelEventArgs(e.ColumnIndex, e.RowIndex)
            grdRepRemarks2_RowValidating(sender, E1)
        End If
    End Sub
    Private Sub grdRepRemarks2_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdRepRemarks2.UserDeletingRow
        If e.Row.Index < 0 Or e.Row.Index = (grdRepRemarks2.Rows.Count - 1) Then Exit Sub
        Dim AdminSend As Boolean = False
        Dim Remarks As String = ""
        If MdifrmMain.tslblUserType.Text <> "Admin" And Convert.ToDateTime(grdRepRemarks2.Item(1, e.Row.Index).Value).Date <> DateTime.Today.Date Then
            AdminSend = True
            Remarks = "Repair Remarks 2 හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        CMDUPDATE("Delete from RepairRemarks2 Where Rem2No=" & grdRepRemarks2.Item(0, e.Row.Index).Value, AdminSend, Remarks)
    End Sub
    Private Sub grdRepRemarks2_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdRepRemarks2.RowValidating
        If e.RowIndex < 0 Then Exit Sub
        If grdRepRemarks2.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
        Dim CMD1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT Rem2No,Rem2Date,Remarks,UNo from " &
                                        "RepairRemarks2 where Rem2No=" & grdRepRemarks2.Item(0, e.RowIndex).Value & ";", CNN)
        Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader()
        If DR1.HasRows Then
            DR1.Read()
            grdRepRemarks2.Item(1, e.RowIndex).Value = DR1("Rem2Date").ToString
            grdRepRemarks2.Item(2, e.RowIndex).Value = DR1("Remarks").ToString
            grdRepRemarks2.Item(3, e.RowIndex).Value = If(DR1("UNo").ToString <> "",
                GetStrfromRelatedfield("Select UserName from [User] where Uno=" & DR1("UNo").ToString, "UserName"), "")
        Else
            grdRepRemarks2.Rows.RemoveAt(e.RowIndex)
        End If
        CMD1.Cancel()
        DR1.Close()
    End Sub
#End Region

#Region "grdTechnicianCost"

    Private Sub grdTechnicianCost_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdTechnicianCost.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        If CheckEmptyfieldcmb(cmbTName, "Technician Name යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.") = False Then
            If (grdTechnicianCost.Rows.Count - 1) <> e.RowIndex Then
                grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
            End If
            Exit Sub
        ElseIf CheckEmptyfieldcmb(cmbRepNo, "Repair No යන field එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න.") = False Then
            If (grdTechnicianCost.Rows.Count - 1) <> e.RowIndex Then
                grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
            End If
            Exit Sub
        End If
        Dim AdminSend As Boolean = False
        Dim Remarks As String = ""
        Select Case e.ColumnIndex
            Case 1
                grdTechnicianCost.CurrentCell.Value = dtpDate.Value.ToString
                dtpDate.Visible = False
                If grdTechnicianCost.Item(1, e.RowIndex).Tag IsNot Nothing AndAlso
                    Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Tag).Date <> DateTime.Today.Date Then
                    AdminSend = True
                    Remarks = "Repair හි Technician Cost හිදි අද දිනට නොමැති Technician Cost Data එකක දිනයක් වෙනස් කෙරුණි."
                End If
            Case 2
                If grdTechnicianCost.Item(2, e.RowIndex).Value Is Nothing Then Exit Sub
                CMD = New OleDbCommand("Select SNo,SCategory,SName,SCostPrice from Stock Where SNo=" & grdTechnicianCost.Item(2, e.RowIndex).Value.ToString, CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows Then
                    DR.Read()
                    grdTechnicianCost.Item(3, e.RowIndex).Value = DR("SCategory").ToString
                    grdTechnicianCost.Item(4, e.RowIndex).Value = DR("SName").ToString
                    grdTechnicianCost.Item(5, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdTechnicianCost.Item(6, e.RowIndex).Value = "1"
                    Dim E1 As New DataGridViewCellEventArgs(5, e.RowIndex)
                    grdTechnicianCost_CellEndEdit(sender, E1)
                End If
            Case 3, 4
                frmSearchDropDown.frm_Close()
                CMD = New OleDbCommand("Select SNo,SCategory,SName,SCostPrice from Stock Where SCategory='" & grdTechnicianCost.Item(3, e.RowIndex).Value &
                                       "' and SName='" & grdTechnicianCost.Item(4, e.RowIndex).Value & "';", CNN)
                DR = CMD.ExecuteReader
                If DR.HasRows Then
                    DR.Read()
                    grdTechnicianCost.Item(2, e.RowIndex).Value = DR("SNo").ToString
                    grdTechnicianCost.Item(3, e.RowIndex).Value = DR("SCategory").ToString
                    grdTechnicianCost.Item(4, e.RowIndex).Value = DR("SName").ToString
                    grdTechnicianCost.Item(5, e.RowIndex).Value = DR("SCostPrice").ToString
                    grdTechnicianCost.Item(6, e.RowIndex).Value = "1"
                    Dim E1 As New DataGridViewCellEventArgs(5, e.RowIndex)
                    grdTechnicianCost_CellEndEdit(sender, E1)
                Else
                    grdTechnicianCost.Item(2, e.RowIndex).Value = ""
                End If
            Case 6, 5
                If grdTechnicianCost.Item(5, e.RowIndex).Value IsNot Nothing And grdTechnicianCost.Item(6, e.RowIndex).Value IsNot Nothing Then
                    grdTechnicianCost.Item(7, e.RowIndex).Value = grdTechnicianCost.Item(5, e.RowIndex).Value * grdTechnicianCost.Item(6, e.RowIndex).Value
                End If
        End Select
        If MdifrmMain.tslblUserType.Text <> "Admin" And (grdTechnicianCost.Item(1, e.RowIndex).Value IsNot Nothing AndAlso
           Convert.ToDateTime(grdTechnicianCost.Item(1, e.RowIndex).Value).Date <> DateTime.Today.Date) Then
            AdminSend = True
            Remarks = "Repair හි Technician Cost හිදි අද දිනට නොමැති Technician Cost එකක් වෙනස් කෙරුණි."
        End If
        If e.RowIndex = (grdTechnicianCost.Rows.Count - 1) Then Exit Sub
        If grdTechnicianCost.Item(1, e.RowIndex).Value Is Nothing Then grdTechnicianCost.Item(1, e.RowIndex).Value = DateAndTime.Now
        If grdTechnicianCost.Item(9, e.RowIndex).Value Is Nothing Or
            grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value <> grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag Then grdTechnicianCost.Item(9, e.RowIndex).Value = MdifrmMain.tslblUserName.Text
        If grdTechnicianCost.Item(0, e.RowIndex).Value Is Nothing Then
            grdTechnicianCost.Item(0, e.RowIndex).Value = AutomaticPrimaryKeyStr("TechnicianCost", "TCNo")
            CMDUPDATE("Insert into TechnicianCost(TCNo,TCDate,TNo,RepNo,UNo) Values(" & grdTechnicianCost.Item(0, e.RowIndex).Value & ",#" &
                grdTechnicianCost.Item(1, e.RowIndex).Value & "#," & txtTNo.Text & "," & cmbRepNo.Text & "," &
                GetStrfromRelatedfield("Select UNo from [User] Where UserName='" & grdTechnicianCost.Item("UNo", e.RowIndex).Value & "'", "UNo") & ")",
                      AdminSend, Remarks)
        End If
        If CheckExistData("Select * from TechnicianCost Where TCNo=" & grdTechnicianCost.Item(0, e.RowIndex).Value) = True Then
            CMDUPDATE("Update TechnicianCost set TCDate=#" & grdTechnicianCost.Item("TCDate", e.RowIndex).Value &
                      "#,SNo=" & grdTechnicianCost.Item("SNo", e.RowIndex).Value &
                      ",SCategory='" & grdTechnicianCost.Item("SCategory", e.RowIndex).Value &
                      "',SName='" & grdTechnicianCost.Item("SName", e.RowIndex).Value &
                      "',Rate=" & grdTechnicianCost.Item("Rate", e.RowIndex).Value &
                      ",Qty=" & grdTechnicianCost.Item("Qty", e.RowIndex).Value &
                      ",Total=" & grdTechnicianCost.Item("Total", e.RowIndex).Value &
                      ",TCRemarks='" & grdTechnicianCost.Item("TCRemarks", e.RowIndex).Value &
                      "',UNo=" & GetStrfromRelatedfield("Select UNo from [User] Where UserName='" & grdTechnicianCost.Item("UNo", e.RowIndex).Value & "'", "UNo") &
                      " Where TCNo=" & grdTechnicianCost.Item("TCNo", e.RowIndex).Value, AdminSend, Remarks)
        End If
        If AdminSend = True Then
            Dim E1 As New DataGridViewCellCancelEventArgs(e.ColumnIndex, e.RowIndex)
            grdTechnicianCost_RowValidating(sender, E1)
        End If
    End Sub

    Private Sub grdTechnicianCost_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdTechnicianCost.CellBeginEdit
        If e.RowIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 1
                grdTechnicianCost.Controls.Add(dtpDate)
                dtpDate.Location = grdTechnicianCost.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
                dtpDate.Size = New Size(grdTechnicianCost.Columns.Item(e.ColumnIndex).Width, grdTechnicianCost.Rows.Item(e.RowIndex).Height)
                dtpDate.Format = DateTimePickerFormat.Custom
                dtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
                dtpDate.Visible = True
                If grdTechnicianCost.CurrentCell.Value Is Nothing Then
                    dtpDate.Value = DateAndTime.Now
                Else
                    dtpDate.Value = Convert.ToDateTime(grdTechnicianCost.CurrentCell.Value)
                End If
                dtpDate.Focus()
        End Select
        grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Tag = grdTechnicianCost.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grdTechnicianCost_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdTechnicianCost.EditingControlShowing
        If grdTechnicianCost.CurrentCell.RowIndex < 0 Then Exit Sub
        Select Case grdTechnicianCost.CurrentCell.ColumnIndex
            Case 1
                dtpDate.Location = grdTechnicianCost.GetCellDisplayRectangle(grdTechnicianCost.CurrentCell.ColumnIndex, grdTechnicianCost.CurrentCell.RowIndex, True).Location
                dtpDate.Size = New Size(grdTechnicianCost.Columns.Item(grdTechnicianCost.CurrentCell.ColumnIndex).Width, grdTechnicianCost.Rows.Item(grdTechnicianCost.CurrentCell.RowIndex).Height)
            Case 3
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdTechnicianCost, Me, "Select SCategory from Stock group by SCategory;", "SCategory")
            Case 4
                Dim tb As TextBox = TryCast(e.Control, TextBox)
                frmSearchDropDown.passtext(tb)
                AddHandler tb.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
                frmSearchDropDown.frm_Open(grdTechnicianCost, Me, "Select SCategory,SName from Stock where SCategory ='" &
                                                   grdTechnicianCost.Item(3, grdTechnicianCost.CurrentCell.RowIndex).Value & "';", "SName")
        End Select
    End Sub

    Private Sub grdTechnicianCost_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles grdTechnicianCost.UserDeletingRow
        If e.Row.Index < 0 Or e.Row.Index = (grdTechnicianCost.Rows.Count - 1) Then Exit Sub
        Dim AdminSend As Boolean = False
        Dim Remarks As String = ""
        If MdifrmMain.tslblUserType.Text <> "Admin" And Convert.ToDateTime(grdTechnicianCost.Item(1, e.Row.Index).Value).Date <>
            DateTime.Today.Date Then
            AdminSend = True
            Remarks = "Repair හි Technician Cost හි Field එකක් Delete කෙරුණි."
            e.Cancel = True
        End If
        CMDUPDATE("Delete from TechnicianCost Where TCNo=" & grdTechnicianCost.Item(0, e.Row.Index).Value, AdminSend, Remarks)
    End Sub

    Private Sub grdTechnicianCost_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdTechnicianCost.RowValidating
        If e.RowIndex < 0 Then Exit Sub
        If grdTechnicianCost.Item(0, e.RowIndex).Value Is Nothing Then Exit Sub
        Dim CMD1 As OleDbCommand = New OleDb.OleDbCommand("SELECT * from TechnicianCost where TCNo=" & grdTechnicianCost.Item(0, e.RowIndex).Value & ";", CNN)
        Dim DR1 As OleDb.OleDbDataReader = CMD1.ExecuteReader()
        If DR1.HasRows Then
            DR1.Read()
            grdTechnicianCost.Item(1, e.RowIndex).Value = DR1("TCDate").ToString
            grdTechnicianCost.Item(2, e.RowIndex).Value = DR1("SNo").ToString
            grdTechnicianCost.Item(3, e.RowIndex).Value = DR1("SCategory").ToString
            grdTechnicianCost.Item(4, e.RowIndex).Value = DR1("SName").ToString
            grdTechnicianCost.Item(5, e.RowIndex).Value = DR1("Rate").ToString
            grdTechnicianCost.Item(6, e.RowIndex).Value = DR1("Qty").ToString
            grdTechnicianCost.Item(7, e.RowIndex).Value = DR1("Total").ToString
            grdTechnicianCost.Item(8, e.RowIndex).Value = DR1("TCRemarks").ToString
            grdTechnicianCost.Item(9, e.RowIndex).Value = If(DR1("UNo").ToString <> "",
                GetStrfromRelatedfield("Select UserName from [User] where Uno=" & DR1("UNo").ToString, "UserName"), "")
        Else
            grdTechnicianCost.Rows.RemoveAt(e.RowIndex)
        End If
        CMD1.Cancel()
        DR1.Close()
    End Sub

#End Region
End Class