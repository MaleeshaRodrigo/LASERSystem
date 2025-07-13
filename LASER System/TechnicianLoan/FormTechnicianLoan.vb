Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class FormTechnicianLoan
    Private Db As New Database

    Public Sub New()
        InitializeComponent()

        ControlTechnicianSelection.SetDatabase(Db)
    End Sub

    Public Sub PerformSearch() Handles ButtonSearch.Click, TextFromDate.ValueChanged, TextToDate.ValueChanged, ControlTechnicianSelection.TechnicianChanged
        Dim dt As New DataTable
        If ControlTechnicianSelection.GetTechnician() Is Nothing Then
            GridTechnicianLoan.Rows.Clear()
            Return
        End If

        GridTechnicianLoan.DataSource = Db.GetDataTable("SELECT TLNo, TLDate, SNo, SCategory, SName, TLReason, Rate, Qty, Total FROM TechnicianLoan WHERE TNo = @TNO and TLDate BETWEEN @DATEFROM AND @DATETO;", {
            New MySqlParameter("TNO", ControlTechnicianSelection.GetTechnicianNo()),
            New MySqlParameter("DATEFROM", TextFromDate.Value.Date & " 00:00:00"),
            New MySqlParameter("DATETO", TextToDate.Value.Date & " 23:59:59")
        })
        GridTechnicianLoan.Refresh()

        Dim Total As New Decimal
        For Each Row As DataGridViewRow In GridTechnicianLoan.Rows
            Total += Convert.ToDecimal(Row.Cells("Total").Value)
        Next
        TextTotal.Text = Total.ToString("N2")
    End Sub

    Private Sub CalculateTotal()
        Dim Total As Decimal = 0
        For Each Row As DataGridViewRow In GridTechnicianLoan.Rows
            Total += Val(Row.Cells("Total").Value)
        Next

        TextTotal.Text = Total
    End Sub

    Private Sub ShowTechnicianLoanInfo(Mode As UpdateMode, Data As Dictionary(Of String, Object))
        If ControlTechnicianSelection.IsTechnicianSelected() Then
            MessageBox.Error("Technician කෙනෙක් නෝරා නොමැත.")
            Return
        End If

        Dim Control As New ControlTechnicianLoanInfo
        Control.SetDatabase(Db)
        Control.SetUpdateMode(Mode, Data)

        Controls.Add(Control)
        Control.Dock = DockStyle.Fill
        Control.BringToFront()
    End Sub

    Private Sub frmTechnicianLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Items.Add(mnustrpMENU)
        TextFromDate.Value = Date.Today.Year & "-" & Date.Today.Month & "-01"
        TextToDate.Value = Date.Today
        Call PerformSearch()
    End Sub

    Private Sub grdTLSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTechnicianLoan.CellDoubleClick
        If e.RowIndex < 0 Or e.RowIndex > (GridTechnicianLoan.Rows.Count - 1) Then
            Return
        End If

        ShowTechnicianLoanInfo(UpdateMode.Edit, New Dictionary(Of String, Object) From {
            {Technician.TName, ControlTechnicianSelection.GetTechnician()},
            {TechnicianLoan.No, GridTechnicianLoan.Item(GridColumn.No, e.RowIndex).Value},
            {TechnicianLoan.TLDate, GridTechnicianLoan.Item(GridColumn.TLDate, e.RowIndex).Value},
            {TechnicianLoan.SNo, GridTechnicianLoan.Item(GridColumn.ItemCode, e.RowIndex).Value},
            {TechnicianLoan.SCategory, GridTechnicianLoan.Item(GridColumn.ItemCategory, e.RowIndex).Value},
            {TechnicianLoan.SName, GridTechnicianLoan.Item(GridColumn.ItemName, e.RowIndex).Value},
            {TechnicianLoan.TCRemarks, GridTechnicianLoan.Item(GridColumn.Reason, e.RowIndex).Value},
            {TechnicianLoan.Rate, GridTechnicianLoan.Item(GridColumn.Rate, e.RowIndex).Value},
            {TechnicianLoan.Qty, GridTechnicianLoan.Item(GridColumn.Qty, e.RowIndex).Value},
            {TechnicianLoan.Total, GridTechnicianLoan.Item(GridColumn.Total, e.RowIndex).Value}
        })
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        ShowTechnicianLoanInfo(UpdateMode.New, New Dictionary(Of String, Object) From {
            {Technician.TName, ControlTechnicianSelection.GetTechnician()}
        })
    End Sub

    Private Structure GridColumn
        Const No = "TLNo"
        Const TLDate = "TLDate"
        Const ItemCode = "SNo"
        Const ItemCategory = "SCategory"
        Const ItemName = "SName"
        Const Reason = "TLReason"
        Const Rate = "Rate"
        Const Qty = "Qty"
        Const Total = "Total"
    End Structure
End Class


