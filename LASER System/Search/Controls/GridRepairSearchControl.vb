Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class GridRepairSearchControl
    Implements GridSearchControl

    Private Db As Database
    Private TechnicianController As New TechnicianController()
    Private FormParent As FormSearch

    Public ReadOnly Property Control As UserControl Implements GridSearchControl.Control
        Get
            Return Me
        End Get
    End Property

    Public Sub Init(Db As Database, ParentForm As FormSearch) Implements GridSearchControl.Init
        Me.Db = Db
        TechnicianController.SetDatabase(Db)
        FormParent = ParentForm
        ' Fill the technician datagridview combobox
        Dim Technicians As String() = TechnicianController.GetTechnicianNames()
        For Each ColumnName As String In {GridColumns.AssignedTechnician, GridColumns.HandedOverTechnician}
            Dim AssignedTechnicianColumn As DataGridViewComboBoxColumn = Grid.Columns(ColumnName)
            AssignedTechnicianColumn.Items.Clear()
            AssignedTechnicianColumn.Items.AddRange(Technicians)
        Next
    End Sub

    Public Function GetFilterDictionary() As Dictionary(Of String, String) Implements GridSearchControl.GetFilterDictionary
        Return New Dictionary(Of String, String) From {
            {"RepNo", "Repair No"},
            {"RDate", "Received Date"},
            {"CuName", "Customer Name"},
            {"CuTelNo", "Customer Telephone No 1"},
            {"PCategory", "Product Category"},
            {"PName", "Product Name"},
            {"PSerialNo", "Product Serial No"},
            {"Problem", "Problem"},
            {"Location", "Location"},
            {"Qty", "Qty"},
            {"RepRemarks1", "Remarks by Customer"},
            {"RepRemarks2", "Remarks by Technician"},
            {"Status", "Status"},
            {"AssignedTechnician", "Assigned Technician"},
            {"HandedOverTechnician", "Handed Over Technician"},
            {"RepDate", "Repaired Date"},
            {"Charge", "Repair Charge"},
            {"DDate", "Delivered Date"},
            {"PaidPrice", "Paid Repair Charge"}
        }
    End Function

    Public Sub SearchSubmission(WhereQuery As String, Values As MySqlParameter()) Implements GridSearchControl.SearchSubmission
        WhereQuery = If(WhereQuery.Trim() = "", "1", WhereQuery)
        Dim FilterQuery As String = $"SELECT RepNo, RDate, R.CuNo, CuName, CONCAT_WS(' | ', NULLIF(CuTelNo1, ''), NULLIF(CuTelNo2, ''), NULLIF(CuTelNo3, '')) AS 'CuTelNo', PCategory, PName, PSerialNo, Problem, Location, Qty, Status, AT.TName AS 'AssignedTechnician', HT.TName AS 'HandedOverTechnician', RepDate, Charge, DDate, PaidPrice FROM `{Tables.Repair}` REP INNER JOIN {Tables.Receive} R ON R.RNO = REP.RNO INNER JOIN {Tables.Product} P ON P.PNO = REP.PNO INNER JOIN {Tables.Customer} CU ON CU.CUNO = R.CUNO LEFT JOIN {Tables.Technician} AT ON AT.TNO = REP.AssignedToTNo LEFT JOIN {Tables.Technician} HT ON HT.TNO = REP.HandedOverToTNo LEFT JOIN {Tables.Deliver} D ON D.DNO = REP.DNO) WHERE {WhereQuery}"
        Dim DT As DataTable
        Try
            DT = Db.GetDataTable(FilterQuery, Values)
            FormParent.ControlSearchEngine.QueryValidator(True)
            Grid.DataSource = DT
        Catch ex As Exception
            FormParent.ControlSearchEngine.QueryValidator(False)
        End Try
    End Sub

    Private Structure GridColumns
        Public Const RepairNo As String = "RepNo"
        Public Const ReceivedDate As String = "RDate"
        Public Const Customer As String = "CuName"
        Public Const PhoneNumber As String = "CuTelNo"
        Public Const Product As String = "Product"
        Public Const ModelNo As String = "PModelNo"
        Public Const Qty As String = "Qty"
        Public Const Problem As String = "Problem"
        Public Const RemarksByCustomer As String = "RepRemarks1"
        Public Const RemarksByTechnician As String = "RepRemarks2"
        Public Const AssignedTechnician As String = "AssignedTechnician"
        Public Const HandedOverTechnician As String = "HandedOverTechnician"
        Public Const RepairCharge As String = "RepCharge"
        Public Const DeliveredDate As String = "DDate"
        Public Const PaidCharge As String = "PaidPrice"
    End Structure
End Class

