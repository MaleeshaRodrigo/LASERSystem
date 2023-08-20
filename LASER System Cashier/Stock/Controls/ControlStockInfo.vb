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
        TxtSNo.Text = DB.GetNextKey(StructureDbTables.Stock, StructureDbStock.Code)
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
        Dim Validators As new ExecuteValidators()
        With Validators
            .AddValidator(New RequiredValidator(TxtSNo, "Stock Code"))
            .AddValidator(New RequiredValidator(CmbCategory, "Stock Category"))
            .AddValidator(New RequiredValidator(CmbName, "Stock Name"))
            .AddValidator(New RequiredValidator(TxtSalePrice, "Sale Price"))
            .AddValidator(New RequiredValidator(TxtCostPrice, "Cost Price"))
            .AddValidator(New RequiredValidator(TxtAvailableUnits.Text, "Available Units"))
            .AddValidator(New RequiredValidator(TxtDamagedUnits.Text, "Damaged Units"))
            .AddValidator(New RequiredValidator(TxtReorderPoint.Text, "Reorder Point"))
            .AddValidator(New CustomValidator(TxtCostPrice.Text > TxtSalePrice.Text, "Sale Price එක Cost Price එකට වඩා  වැඩි අගයක් ඇතුලත් කරන්න."))
            If Not .Execute() Then Exit Sub
        End With

        If DB.CheckDataIsExist(StructureDbTables.Stock, StructureDbStock.Code, TxtSNo.Text) Then
            DB.Execute($"UPDATE {StructureDbTables.Stock} SET 
            {StructureDbStock.Category} = @CATEGORY,
            {StructureDbStock.Name} = @NAME,
            {StructureDbStock.ModelNo} = @MODELNO,
            {StructureDbStock.Location} = @LOCATION,
            {StructureDbStock.Details} = @DETAILS,
            {StructureDbStock.SalePrice} = @SALEPRICE,
            {StructureDbStock.CostPrice} = @COSTPRICE,
            {StructureDbStock.AvailableUnits} = @AVAILABLEUNITS,
            {StructureDbStock.DamagedUnits} = @DAMAGEDUNITS,
            {StructureDbStock.ReorderPoint} = @REORDERPOINT
            WHERE {StructureDbStock.Code} = @CODE;", {
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
        Else
            DB.Execute($"INSERT INTO {StructureDbTables.Stock}(
            {StructureDbStock.Code},
            {StructureDbStock.Category},
            {StructureDbStock.Name},
            {StructureDbStock.ModelNo},
            {StructureDbStock.Location},
            {StructureDbStock.Details},
            {StructureDbStock.SalePrice},
            {StructureDbStock.CostPrice},
            {StructureDbStock.AvailableUnits},
            {StructureDbStock.DamagedUnits},
            {StructureDbStock.ReorderPoint}
        ) Values(@CODE,@CATEGORY,@NAME,@MODELNO,@LOCATION,@DETAILS,@SALEPRICE,@COSTPRICE,@AVAILABLEUNITS,@DAMAGEDUNITS,@REORDERPOINT);", {
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
        End If
    End Sub
End Class
