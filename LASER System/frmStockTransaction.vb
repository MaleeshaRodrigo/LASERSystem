Imports MySqlConnector

Public Class frmStockTransaction
    Private Db As New Database
    Private Sub frmStockTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Db.Connect()
        MenuStrip.Items.Add(mnustrpMENU)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmStockTransaction_Leave(sender, e)
    End Sub

    Private Sub frmStockTransaction_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Db.Disconnect()
    End Sub

    Private Sub cmbSName_DropDown(sender As Object, e As EventArgs) Handles cmbSName.DropDown
        Call ComboBoxDropDown(Db, cmbSName, "Select SName from Stock where SCategory ='" & cmbSCategory.Text & "' group by  SName;")
    End Sub

    Private Sub cmbSCategory_DropDown(sender As Object, e As EventArgs) Handles cmbSCategory.DropDown
        Call ComboBoxDropDown(Db, cmbSCategory, "Select SCategory from Stock group by SCategory;")
    End Sub

    Private Sub cmbSCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCategory.SelectedIndexChanged
        cmbSName.Text = ""
        cmbSName_DropDown(sender, e)
    End Sub

    Private Sub cmbSName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSName.SelectedIndexChanged
        Dim DR = Db.GetDataReader("SELECT * from Stock where Scategory='" & cmbSCategory.Text & "' and sname ='" & cmbSName.Text & "';")
        If DR.Count Then
            
            txtSNo.Text = DR("SNO").ToString
            grdSupply.DataSource = Db.GetDataTable("Select SupDate,SuName,SupType,SupUnits,SupCostPrice,SupTotal from (((Supply Sup Left Join Supplier Su On Su.SuNo = Sup.SuNo) Inner Join StockSupply SSup On SSup.SupNo = Sup.SupNo) Inner Join Stock S On S.SNo =SSup.SNo) Where S.SNo = " & txtSNo.Text & " Order by SupDate;")

            grdSale.DataSource = Db.GetDataTable("Select SaDate,CuName,SaType,SaUnits,SaRate,SaTotal from (((Sale Sa Left Join Customer Cu On Cu.CuNo = Sa.CuNo) Inner Join StockSale SSa On SSa.SaNo = Sa.SaNo) Inner Join Stock S On S.SNo =SSa.SNo) Where S.SNo = " & txtSNo.Text & " Order by SaDate;")

            grdTCost.DataSource = Db.GetDataTable("Select TCDate,TName,RepNo,RetNo,TCRemarks,Rate,Qty,Total from ((TechnicianCost TC Inner Join Stock S On S.SNo = TC.SNo) Inner Join Technician T On T.TNo = TC.TNo) Where S.SNo = " & txtSNo.Text & " Order by TCDate;")

            grdTLoan.DataSource = Db.GetDataTable("Select TLDate,TName,TLReason,Rate,Qty,Total from ((TechnicianLoan TL Inner Join Stock S On S.SNo = TL.SNo) Inner Join Technician T On T.TNo = TL.TNo) Where S.SNo = " & txtSNo.Text & " Order by TLDate;")
        End If
    End Sub

    Public Sub txtSNo_TextChanged(sender As Object, e As EventArgs) Handles txtSNo.TextChanged
        If txtSNo.Text = "" Then Exit Sub
        Dim DR = Db.GetDataReader("Select SNo,SCategory,SName from `Stock` where SNO = " & txtSNo.Text)
        If DR.Count Then
            
            cmbSCategory.Text = DR("SCategory").ToString
            cmbSName.Text = DR("SName").ToString
            Call cmbSName_SelectedIndexChanged(sender, e)
            txtSNo.Focus()
            txtSNo.Select(txtSNo.TextLength, txtSNo.TextLength)
        Else
            cmbSCategory.Text = ""
            cmbSName.Text = ""
            cmbSName_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub txtSNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSNo.KeyPress
        OnlynumberQty(e)
    End Sub

    Public Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        If CheckEmptyControl(txtSNo, "ඔබ තවම Stock එකක් Select කර නොමැත. කරුණාකර Stock එකක් තෝරා ගෙන නැවත උත්සහ කරන්න.") = False Then
            Exit Sub
        End If
        grdSupply.DataSource = Db.GetDataTable("Select SupDate,SuName,SupType,SupUnits,SupCostPrice,SupTotal from StockSupply SSup,Supplier Su,Supply Sup Where Sup.SupNo = SSup.SupNo and Sup.SuNo = Su.SuNo and SNo = " & txtSNo.Text)
        grdSale.DataSource = Db.GetDataTable("Select SaDate,CuName,SaType,SaRate,SaUnits,SaTotal from Sale Sa, StockSale SSa, Customer Cu Where Cu.CuNo = Sa.CuNo and Sa.SaNo = SSa.SaNo and SNo = " & txtSNo.Text)
        grdTCost.DataSource = Db.GetDataTable("Select TCDate, TName, RepNo, RetNo, TCRemarks, Rate, Qty, Total from TechnicianCost TC, Technician T Where T.TNo = TC.TNo and SNo = " & txtSNo.Text)
        grdTLoan.DataSource = Db.GetDataTable("Select TLDate, TName, TLReason, Rate, Qty, Total from TechnicianLoan TL, Technician T Where T.TNo = TL.TNo and SNo = " & txtSNo.Text)
    End Sub

    Private Sub txtSNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmdDone_Click(sender, e)
        End If
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        cmdDone_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        cmdClose_Click(sender, e)
    End Sub
End Class