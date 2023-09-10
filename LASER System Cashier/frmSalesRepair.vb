Public Class frmSalesRepair

    Private Sub cmbTName_DropDown(sender As Object, e As EventArgs) Handles cmbTName.DropDown
        CmbDropDown(cmbTName, "Select TName from Technician group by TName;", "TName")
    End Sub

    Private Sub cmbTName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTName.SelectedIndexChanged
        CMD = New OleDb.OleDbCommand("Select TNo,TName from Technician where TName = '" & cmbTName.Text & "';", CNN)
        DR = CMD.ExecuteReader
        If DR.HasRows = True Then
            DR.Read()
            txtTNo.Text = DR("TNo").ToString
        Else
            txtTNo.Text = ""
        End If
    End Sub

    Private Sub frmSalesRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCNN()
        Call cmdSaRepNew_Click(sender, e)
    End Sub

    Private Sub cmdSaRepNew_Click(sender As Object, e As EventArgs) Handles cmdSaRepNew.Click
        AutomaticPrimaryKey(txtSaRepNo, "Select top 1 SaRepNo from SalesRepair Order by SaRepNo Desc;", "SaRepNo")
        cmbSCategory.Text = ""
        cmbSName.Text = ""
        txtSNo.Text = ""
        txtSModelNo.Text = ""
        txtSLocation.Text = ""
        txtSDetails.Text = ""
        txtSMinStocks.Text = ""
        txtSAvailableStocks.Text = ""
        txtSDamagedStocks.Text = ""
        txtSCostPrice.Text = ""
        txtSSalePrice.Text = ""
        txtSCharge.Text = ""
        txtSQuantity.Text = ""
        txtSTotal.Text = ""
        Call cmdSaRepSearch_Click(sender, e)
    End Sub

    Private Sub cmdSaRepSearch_Click(sender As Object, e As EventArgs) Handles cmdSaRepSearch.Click
        If txtTNo.Text = "" Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New OleDb.OleDbDataAdapter("Select SaRepNo,SaRepDate,SNo,Charge,Qty,Total from SalesREpair where TNo = " & txtTNo.Text & " and #" & txtSaRepFrom.Value.ToString & "# <= SaRepDate and SaRepDate <= #" & txtSaRepTo.Value.ToString & "#;", CNN)
        DA.Fill(DT)
        Me.grdSalesRepair.DataSource = DT
        grdSalesRepair.Refresh()
    End Sub

    Private Sub frmSalesRepair_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdSaRepNew.Left = Int(Me.Width) - Int(cmdSaRepNew.Width) - 30
        cmdSaRepClose.Left = cmdSaRepNew.Left
        cmdSaRepSave.Left = cmdSaRepNew.Left
        cmdSaRepDelete.Left = cmdSaRepNew.Left
        grdSalesRepair.Width = Int(Me.Width) - 42
        txtSaRepTotal.Top = Int(Me.Height) - Int(txtSaRepTotal.Height) - 50
        lblSaRepTotal.Top = txtSaRepTotal.Top
        grdSalesRepair.Height = Int(Me.Height) - Int(grdSalesRepair.Top) - Int(txtSaRepTotal.Height) - 60
    End Sub

    Private Sub cmdSaRepClose_Click(sender As Object, e As EventArgs) Handles cmdSaRepClose.Click
        frmSalesRepair_Leave(sender, e)
    End Sub

    Private Sub frmSalesRepair_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub
End Class