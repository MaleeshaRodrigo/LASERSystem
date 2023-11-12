Imports System.Data.Common
Imports System.Data.OleDb
Imports LASER_System.StructureDatabase

Public Class ControlStockInfo
    Private Db As Database
    Public Sub New(Db As Database)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Db = Db
        If User.Instance.UserType = User.Type.Cashier Then
            SetControlsForCashier()
        End If
    End Sub

    Public Sub ClearControls()
        TxtSNo.Text = Db.GetNextKey(Tables.Stock, Stock.Code)
        CmbCategory.Text = ""
        CmbName.Text = ""
        TxtModelNo.Text = ""
        CmbLocation.Text = ""
        TxtLowestPrice.Text = "0"
        TxtLowestPrice.Text = "0"
        TxtSalePrice.Text = "0"
        TxtReorderPoint.Text = "3"
        TxtAvailableUnits.Text = "0"
        TxtDamagedUnits.Text = "0"
    End Sub

    Private Sub SetControlsForCashier()
        'hide the Cost Price field
        TxtCostPrice.Visible = False
        LblCostPrice.Visible = False
        Dim TableRowTxtCostPrice = TlpStockForm.RowStyles(TlpStockForm.GetRow(TxtCostPrice))
        TableRowTxtCostPrice.SizeType = SizeType.Absolute
        TableRowTxtCostPrice.Height = 0

        TxtAvailableUnits.Enabled = False
        TxtDamagedUnits.Enabled = False
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Dispose()
    End Sub

    Private Sub ControlStockInfo_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GrpInfo.Top = (Me.Height - GrpInfo.Height) / 2
        GrpInfo.Left = (Me.Width - GrpInfo.Width) / 2
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        ' Validations
        Dim Validators As New ExecuteValidators()
        With Validators
            .AddValidator(New RequiredValidator(TxtSNo, "Stock Code"))
            .AddValidator(New RequiredValidator(CmbCategory, "Stock Category"))
            .AddValidator(New RequiredValidator(CmbName, "Stock Name"))
            .AddValidator(New RequiredValidator(TxtSalePrice, "Sale Price"))
            .AddValidator(New RequiredValidator(TxtLowestPrice, "Lowest Price"))
            .AddValidator(New RequiredValidator(TxtAvailableUnits.Text, "Available Units"))
            .AddValidator(New RequiredValidator(TxtDamagedUnits.Text, "Damaged Units"))
            .AddValidator(New RequiredValidator(TxtReorderPoint.Text, "Reorder Point"))
            .AddValidator(New CustomValidator(TxtLowestPrice.Text > TxtSalePrice.Text, "Sale Price එක Cost Price එකට වඩා  වැඩි අගයක් ඇතුලත් කරන්න."))
            .AddValidator(New CustomValidator(TxtLowestPrice.Text > TxtLowestPrice.Text, "Lowest Price එක Cost Price එකට වඩා  වැඩි අගයක් ඇතුලත් කරන්න."))
            If Not .Execute() Then Exit Sub
        End With

        If Db.CheckDataIsExist(Tables.Stock, Stock.Code, TxtSNo.Text) And
            MsgBox("ඔබට මෙම Record එක Update කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
            Db.Execute($"UPDATE {Tables.Stock} SET 
            {Stock.ModelNo} = @MODELNO,
            {Stock.Location} = @LOCATION,
            {Stock.Details} = @DETAILS,
            WHERE {Stock.Code} = @CODE;", {
                New OleDbParameter("@MODELNO", TxtModelNo.Text),
                New OleDbParameter("@LOCATION", CmbLocation.Text),
                New OleDbParameter("@DETAILS", TxtDetails.Text),
                New OleDbParameter("@CODE", TxtSNo.Text)
            })
            Me.Dispose()
        Else
            Db.Execute($"INSERT INTO {Tables.Stock}(
                {Stock.Code},
                {Stock.Category},
                {Stock.Name},
                {Stock.ModelNo},
                {Stock.Location},
                {Stock.Details},
                {Stock.SalePrice},
                {Stock.LowestPrice},
                {Stock.CostPrice},
                {Stock.ReorderPoint}
            ) VALUES(@CODE,@CATEGORY,@NAME,@MODELNO,@LOCATION,@DETAILS,@SALEPRICE,@LOWESTPRICE,@COSTPRICE,@REORDERPOINT);", {
                New OleDbParameter("@CODE", TxtSNo.Text),
                New OleDbParameter("@CATEGORY", CmbCategory.Text),
                New OleDbParameter("@NAME", CmbName.Text),
                New OleDbParameter("@MODELNO", TxtModelNo.Text),
                New OleDbParameter("@LOCATION", CmbLocation.Text),
                New OleDbParameter("@DETAILS", TxtDetails.Text),
                New OleDbParameter("@SALEPRICE", TxtSalePrice.Text),
                New OleDbParameter("@LOWESTPRICE", TxtLowestPrice.Text),
                New OleDbParameter("@COSTPRICE", TxtLowestPrice.Text),
                New OleDbParameter("@REORDERPOINT", TxtReorderPoint.Text)
            })
            Me.Dispose()
        End If
    End Sub

    Private Sub CmbCategory_DropDown(sender As Object, e As EventArgs) Handles CmbCategory.DropDown
        ComboBoxDropDown(Db, CmbCategory,
                    $"SELECT {Stock.Category} FROM {Tables.Stock} GROUP BY {Stock.Category};")
    End Sub

    Private Sub CmbLocation_DropDown(sender As Object, e As EventArgs) Handles CmbLocation.DropDown
        ComboBoxDropDown(Db, CmbLocation,
                    $"SELECT {Stock.Location} FROM {Tables.Stock} GROUP BY {Stock.Location};")
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        If Db.CheckDataIsExist(Tables.Stock, Stock.Code, TxtSNo.Text) AndAlso MsgBox("ඔබට මෙම Record එක Delete කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
            Db.Execute($"DELETE FROM {Tables.Stock} WHERE {Stock.Code}=@SNO", {
                    New OleDbParameter("@SNO", TxtSNo.Text)
                })
            Me.Dispose()
        End If
    End Sub

    Private Sub CmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategory.SelectedIndexChanged
        ComboBoxDropDown(Db, CmbName, $"SELECT {Stock.Name} FROM {Tables.Stock} WHERE {Stock.Category} = '{CmbCategory.Text}' GROUP BY {Stock.Name};")
    End Sub

End Class
