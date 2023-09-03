Imports System.Data.Common
Imports System.Data.OleDb

Public Class ControlStockInfo
    Private DB As Database
    Public Sub New(DB As Database)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DB = DB
    End Sub

    Public Sub ClearControls()
        TxtSNo.Text = DB.GetNextKey(StructureDatabase.Tables.Stock, StructureDatabase.Stock.Code)
        CmbCategory.Text = ""
        CmbName.Text = ""
        TxtModelNo.Text = ""
        CmbLocation.Text = ""
        TxtCostPrice.Text = "0"
        TxtSalePrice.Text = "0"
        TxtReorderPoint.Text = "3"
        TxtAvailableUnits.Text = "0"
        TxtDamagedUnits.Text = "0"
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
            .AddValidator(New RequiredValidator(TxtCostPrice, "Cost Price"))
            .AddValidator(New RequiredValidator(TxtAvailableUnits.Text, "Available Units"))
            .AddValidator(New RequiredValidator(TxtDamagedUnits.Text, "Damaged Units"))
            .AddValidator(New RequiredValidator(TxtReorderPoint.Text, "Reorder Point"))
            .AddValidator(New CustomValidator(TxtCostPrice.Text > TxtSalePrice.Text,
                                              "Sale Price එක Cost Price එකට වඩා  වැඩි අගයක් ඇතුලත් කරන්න."))
            If Not .Execute() Then Exit Sub
        End With

        If DB.CheckDataIsExist(StructureDatabase.Tables.Stock, StructureDatabase.Stock.Code, TxtSNo.Text) And
            MsgBox("ඔබට මෙම Record එක Update කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
            DB.Execute($"UPDATE {StructureDatabase.Tables.Stock} SET 
            {StructureDatabase.Stock.Category} = @CATEGORY,
            {StructureDatabase.Stock.Name} = @NAME,
            {StructureDatabase.Stock.ModelNo} = @MODELNO,
            {StructureDatabase.Stock.Location} = @LOCATION,
            {StructureDatabase.Stock.Details} = @DETAILS,
            {StructureDatabase.Stock.SalePrice} = @SALEPRICE,
            {StructureDatabase.Stock.CostPrice} = @COSTPRICE,
            {StructureDatabase.Stock.AvailableUnits} = @AVAILABLEUNITS,
            {StructureDatabase.Stock.DamagedUnits} = @DAMAGEDUNITS,
            {StructureDatabase.Stock.ReorderPoint} = @REORDERPOINT
            WHERE {StructureDatabase.Stock.Code} = @CODE;", {
                New OleDbParameter("@CATEGORY", CmbCategory.Text),
                New OleDbParameter("@NAME", CmbName.Text),
                New OleDbParameter("@MODELNO", TxtModelNo.Text),
                New OleDbParameter("@LOCATION", CmbLocation.Text),
                New OleDbParameter("@DETAILS", TxtDetails.Text),
                New OleDbParameter("@SALEPRICE", TxtSalePrice.Text),
                New OleDbParameter("@COSTPRICE", TxtCostPrice.Text),
                New OleDbParameter("@AVAILABLEUNITS", TxtAvailableUnits.Text),
                New OleDbParameter("@DAMAGEDUNITS", TxtDamagedUnits.Text),
                New OleDbParameter("@REORDERPOINT", TxtReorderPoint.Text),
                New OleDbParameter("@CODE", TxtSNo.Text)
            })
            Me.Dispose()
        Else
            DB.Execute($"INSERT INTO {StructureDatabase.Tables.Stock}(
                {StructureDatabase.Stock.Code},
                {StructureDatabase.Stock.Category},
                {StructureDatabase.Stock.Name},
                {StructureDatabase.Stock.ModelNo},
                {StructureDatabase.Stock.Location},
                {StructureDatabase.Stock.Details},
                {StructureDatabase.Stock.SalePrice},
                {StructureDatabase.Stock.CostPrice},
                {StructureDatabase.Stock.AvailableUnits},
                {StructureDatabase.Stock.DamagedUnits},
                {StructureDatabase.Stock.ReorderPoint}
            ) Values(@CODE,@CATEGORY,@NAME,@MODELNO,@LOCATION,@DETAILS,@SALEPRICE,@COSTPRICE,
                @AVAILABLEUNITS,@DAMAGEDUNITS,@REORDERPOINT);", {
                New OleDbParameter("@CODE", TxtSNo.Text),
                New OleDbParameter("@CATEGORY", CmbCategory.Text),
                New OleDbParameter("@NAME", CmbName.Text),
                New OleDbParameter("@MODELNO", TxtModelNo.Text),
                New OleDbParameter("@LOCATION", CmbLocation.Text),
                New OleDbParameter("@DETAILS", TxtDetails.Text),
                New OleDbParameter("@SALEPRICE", TxtSalePrice.Text),
                New OleDbParameter("@COSTPRICE", TxtCostPrice.Text),
                New OleDbParameter("@AVAILABLEUNITS", TxtAvailableUnits.Text),
                New OleDbParameter("@DAMAGEDUNITS", TxtDamagedUnits.Text),
                New OleDbParameter("@REORDERPOINT", TxtReorderPoint.Text)
            })
            Me.Dispose()
        End If
    End Sub

    Private Sub CmbCategory_DropDown(sender As Object, e As EventArgs) Handles CmbCategory.DropDown
        CmbDropDown(CmbCategory,
                    $"SELECT {StructureDatabase.Stock.Category} FROM {StructureDatabase.Tables.Stock} GROUP BY {StructureDatabase.Stock.Category};",
                    StructureDatabase.Stock.Category)
    End Sub

    Private Sub CmbName_DropDown(sender As Object, e As EventArgs) Handles CmbName.DropDown
        CmbDropDown(CmbName,
                    $"SELECT {StructureDatabase.Stock.Name} FROM {StructureDatabase.Tables.Stock} GROUP BY {StructureDatabase.Stock.Name};",
                    StructureDatabase.Stock.Name)
    End Sub

    Private Sub CmbLocation_DropDown(sender As Object, e As EventArgs) Handles CmbLocation.DropDown
        CmbDropDown(CmbLocation,
                    $"SELECT {StructureDatabase.Stock.Location} FROM {StructureDatabase.Tables.Stock} GROUP BY {StructureDatabase.Stock.Location};",
                    StructureDatabase.Stock.Location)
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        If DB.CheckDataIsExist(StructureDatabase.Tables.Stock, StructureDatabase.Stock.Code, TxtSNo.Text) AndAlso MsgBox("ඔබට මෙම Record එක Delete කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
            DB.Execute($"DELETE FROM {StructureDatabase.Tables.Stock} WHERE {StructureDatabase.Stock.Code}=@SNo", {
                    New OleDbParameter("@SNo", TxtSNo.Text)
                })
            Me.Dispose()
        End If
    End Sub
End Class
