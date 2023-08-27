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

        If DB.CheckDataIsExist(StructureDbTables.Stock, StructureDbStock.Code, TxtSNo.Text) AndAlso MsgBox("ඔබට මෙම Record එක Update කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
            'DB.Execute($"UPDATE {StructureDbTables.Stock} SET 
            '{StructureDbStock.Category} = @CATEGORY,
            '{StructureDbStock.Name} = @NAME,
            '{StructureDbStock.ModelNo} = @MODELNO,
            '{StructureDbStock.Location} = @LOCATION,
            '{StructureDbStock.Details} = @DETAILS,
            '{StructureDbStock.SalePrice} = @SALEPRICE,
            '{StructureDbStock.CostPrice} = @COSTPRICE,
            '{StructureDbStock.ReorderPoint} = @REORDERPOINT
            'WHERE {StructureDbStock.Code} = @CODE;", {
            '    New OleDbParameter("@CATEGORY", CmbCategory.Text),
            '    New OleDbParameter("@NAME", CmbName.Text),
            '    New OleDbParameter("@MODELNO", TxtModelNo.Text),
            '    New OleDbParameter("@LOCATION", CmbLocation.Text),
            '    New OleDbParameter("@DETAILS", TxtDetails.Text),
            '    New OleDbParameter("@SALEPRICE", TxtSalePrice.Text),
            '    New OleDbParameter("@COSTPRICE", TxtCostPrice.Text),
            '    New OleDbParameter("@REORDERPOINT", TxtReorderPoint.Text),
            '    New OleDbParameter("@CODE", TxtSNo.Text)
            '})


        Else
            Dim StockRow As DBDataSet.StockRow
            StockRow = DBDataSet.Stock.NewStockRow()
            With StockRow
                .Sno = TxtSNo.Text
                .SCategory = CmbCategory.Text
                .SName = CmbName.Text
                .SModelNo = TxtModelNo.Text
                .SLocation = CmbLocation.Text
                .SDetails = TxtDetails.Text
                .SSalePrice = TxtSalePrice.Text
                .SCostPrice = TxtCostPrice.Text
                .SMinStocks = TxtReorderPoint.Text
            End With

            DBDataSet.Stock.Rows.Add(StockRow)
            StockTableAdapter.Update(DBDataSet.Stock)
            '    DB.Execute($"INSERT INTO {StructureDbTables.Stock}(
            '    {StructureDbStock.Code},
            '    {StructureDbStock.Category},
            '    {StructureDbStock.Name},
            '    {StructureDbStock.ModelNo},
            '    {StructureDbStock.Location},
            '    {StructureDbStock.Details},
            '    {StructureDbStock.SalePrice},
            '    {StructureDbStock.CostPrice},
            '    {StructureDbStock.AvailableUnits},
            '    {StructureDbStock.DamagedUnits},
            '    {StructureDbStock.ReorderPoint}
            ') Values(@CODE,@CATEGORY,@NAME,@MODELNO,@LOCATION,@DETAILS,@SALEPRICE,@COSTPRICE,0,0,@REORDERPOINT);", {
            '        New OleDbParameter("@CODE", TxtSNo.Text),
            '        New OleDbParameter("@CATEGORY", CmbCategory.Text),
            '        New OleDbParameter("@NAME", CmbName.Text),
            '        New OleDbParameter("@MODELNO", TxtModelNo.Text),
            '        New OleDbParameter("@LOCATION", CmbLocation.Text),
            '        New OleDbParameter("@DETAILS", TxtDetails.Text),
            '        New OleDbParameter("@SALEPRICE", TxtSalePrice.Text),
            '        New OleDbParameter("@COSTPRICE", TxtCostPrice.Text),
            '        New OleDbParameter("@REORDERPOINT", TxtReorderPoint.Text)
            '    })
        End If
    End Sub

    Private Sub CmbCategory_DropDown(sender As Object, e As EventArgs) Handles CmbCategory.DropDown
        CmbDropDown(CmbCategory,
                    $"SELECT {StructureDbStock.Category} FROM {StructureDbTables.Stock} GROUP BY {StructureDbStock.Category};",
                    StructureDbStock.Category)
    End Sub

    Private Sub CmbName_DropDown(sender As Object, e As EventArgs) Handles CmbName.DropDown
        CmbDropDown(CmbName,
                    $"SELECT {StructureDbStock.Name} FROM {StructureDbTables.Stock} GROUP BY {StructureDbStock.Name};",
                    StructureDbStock.Name)
    End Sub

    Private Sub CmbLocation_DropDown(sender As Object, e As EventArgs) Handles CmbLocation.DropDown
        CmbDropDown(CmbLocation,
                    $"SELECT {StructureDbStock.Location} FROM {StructureDbTables.Stock} GROUP BY {StructureDbStock.Location};",
                    StructureDbStock.Location)
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        If DB.CheckDataIsExist(StructureDbTables.Stock, StructureDbStock.Code, TxtSNo.Text) AndAlso MsgBox("ඔබට මෙම Record එක Delete කිරිමට අවශ්‍යද?", vbInformation + vbYesNo) = vbYes Then
            DB.Execute($"DELETE FROM {StructureDbTables.Stock} WHERE {StructureDbStock.Code}=@SNo", {
                    New OleDbParameter("@SNo", TxtSNo.Text)
                })
        End If
    End Sub
End Class
