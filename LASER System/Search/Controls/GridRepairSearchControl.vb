Imports LASER_System.StructureDatabase
Imports Microsoft.Office.Interop.Access.Dao
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class GridRepairSearchControl
    Implements GridSearchControl

    Private Db As Database
    Private FormParent As FormSearch
    Private Mode As RepairMode
    Private DatePicker As New DateTimePicker
    Private TechnicianController As New TechnicianController()
    Private RepairController As New RepairController
    Private GridCellPreviousValue As Object
    Private RemarksContol As ControlGridRemarks

    Public ReadOnly Property Control As UserControl Implements GridSearchControl.Control
        Get
            Return Me
        End Get
    End Property

    Public Function Init(Db As Database, ParentForm As FormSearch) As GridSearchControl Implements GridSearchControl.Init
        Me.Db = Db
        TechnicianController.SetDatabase(Db)
        RepairController.SetDatabase(Db)
        FormParent = ParentForm
        ' Fill the technician datagridview combobox
        Dim Technicians As String() = TechnicianController.GetTechnicianNames()
        For Each ColumnName As String In {GridColumns.AssignedTechnician, GridColumns.HandedOverTechnician}
            Dim AssignedTechnicianColumn As DataGridViewComboBoxColumn = Grid.Columns(ColumnName)
            AssignedTechnicianColumn.Items.Clear()
            AssignedTechnicianColumn.Items.AddRange(Technicians)
        Next

        SearchSubmission("", {})
        Return Me
    End Function

    Public Function SetMode(Mode As RepairMode) As GridRepairSearchControl
        Me.Mode = Mode
        If Mode = RepairMode.ReRepair Then
            Grid.Columns(GridColumns.ReRepairNo).Visible = True
            Grid.Columns(GridColumns.ReRepairNo).Frozen = True
        End If

        Return Me
    End Function

    Public Function GetFilterDictionary() As Dictionary(Of String, String) Implements GridSearchControl.GetFilterDictionary
        Return New Dictionary(Of String, String) From {
            {"All", "All"},
            {"RepNo", "Repair No"},
            {"RDate", "Received Date"},
            {"CuName", "Customer Name"},
            {"CuTelNo", "Customer Telephone No"},
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
        Try
            WhereQuery = If(WhereQuery.Trim() = "", "1", WhereQuery)
            Dim FilterQuery As String = GetFilterQuery(WhereQuery)
            Dim DT As DataTable = Db.GetDataTable(FilterQuery, Values)
            FormParent.ControlSearchEngine.QueryValidator(True)
            Grid.DataSource = DT
        Catch ex As Exception
            FormParent.ControlSearchEngine.QueryValidator(False)
        End Try
    End Sub

    Public Sub PerformQueryMapping(ByRef PoistionList As List(Of Object))
        Dim UpdatedPoistionList As New List(Of Object)(PoistionList)
        For Each Poistion As Object In PoistionList
            If Poistion.GetType.Name = "String[]" AndAlso Poistion(0) = "CuTelNo" Then
                Dim NewPoistionList As New List(Of Object)
                NewPoistionList.Append("(")
                NewPoistionList.Append(New List(Of Object) From {"CuTelNo1", Poistion(1)})
                NewPoistionList.Append("OR")
                NewPoistionList.Append(New List(Of Object) From {"CuTelNo2", Poistion(1)})
                NewPoistionList.Append("OR")
                NewPoistionList.Append(New List(Of Object) From {"CuTelNo3", Poistion(1)})
                NewPoistionList.Append(")")
                Dim PoistionIndex = UpdatedPoistionList.IndexOf(Poistion)
                UpdatedPoistionList.Remove(Poistion)
                UpdatedPoistionList.InsertRange(PoistionIndex, NewPoistionList)
            End If
        Next
        PoistionList = UpdatedPoistionList
    End Sub

    Private Function GetFilterQuery(WhereQuery As String) As String
        If Mode = RepairMode.Repair Then
            Return $"SELECT RepNo, RDate, CuName, CONCAT_WS(' | ', NULLIF(CuTelNo1, ''), NULLIF(CuTelNo2, ''), NULLIF(CuTelNo3, '')) AS 'CuTelNo', CONCAT(PCategory, ' ', PName) AS 'Product', PSerialNo, Problem, Location, Qty, Status, AT.TName AS 'AssignedTechnician', HT.TName AS 'HandedOverTechnician', RepDate, Charge, DDate, PaidPrice FROM `{Tables.Repair}` REP INNER JOIN {Tables.Receive} R ON R.RNO = REP.RNO INNER JOIN {Tables.Product} P ON P.PNO = REP.PNO INNER JOIN {Tables.Customer} CU ON CU.CUNO = R.CUNO LEFT JOIN {Tables.Technician} AT ON AT.TNO = REP.AssignedToTNo LEFT JOIN {Tables.Technician} HT ON HT.TNO = REP.HandedOverToTNo LEFT JOIN {Tables.Deliver} D ON D.DNO = REP.DNO WHERE {WhereQuery}"
        ElseIf Mode = RepairMode.ReRepair Then
            Return $"SELECT RetNo, RepNo,Ret.RNo,RDate, R.CuNo, CuName, CONCAT_WS(' | ', NULLIF(CuTelNo1, ''), NULLIF(CuTelNo2, ''), NULLIF(CuTelNo3, '')) AS 'CuTelNo', PCategory, PName, PModelNo, PSerialNo, Problem, Qty, Status, TName, RetREpDate, Charge, Ret.DNo, DDate, PaidPrice FROM `return` Ret INNER JOIN RECEIVE R ON R.RNo = Ret.RNo INNER JOIN PRODUCT  P ON P.PNO = Ret.PNO INNER JOIN CUSTOMER CU ON CU.CUNO = R.CUNO LEFT JOIN Technician T ON T.TNO = Ret.TNO LEFT JOIN DELIVER D ON D.DNO = Ret.DNO WHERE {WhereQuery};"
        Else
            Throw New Exception("Invalid Repair Mode")
        End If
    End Function

    Private Sub Grid_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Grid.CellBeginEdit
        If e.RowIndex < 0 Then
            Return
        End If

        If {RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered, RepairStatus.Canceled}.Contains(Grid.Item(GridColumns.Status, e.RowIndex).Value) Then
            e.Cancel = True
            Return
        End If

        If Grid.Columns(e.ColumnIndex).Name = GridColumns.RepairedDate Then
            Grid.Controls.Add(DatePicker)
            DatePicker.Location = Grid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            DatePicker.Size = New Size(Grid.Columns.Item(e.ColumnIndex).Width, Grid.Rows.Item(e.RowIndex).Height)
            DatePicker.Format = DateTimePickerFormat.Custom
            DatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
            DatePicker.Visible = True
            If Grid.CurrentCell.Value Is Nothing OrElse Grid.CurrentCell.Value.ToString = "" Then
                DatePicker.Value = Now
            Else
                DatePicker.Value = Convert.ToDateTime(Grid.CurrentCell.Value)
            End If
        End If

        GridCellPreviousValue = Grid.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub Grid_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Grid.RowValidating
        If e.RowIndex < 1 Or e.RowIndex >= Grid.Rows.Count Then
            Return
        End If

        Dim RowIndex As Integer = e.RowIndex
        Grid.Rows(RowIndex).ErrorText = ""
        Dim Status As String = Grid.Item(GridColumns.Status, RowIndex).Value

        If (Not {RepairStatus.Received, RepairStatus.Canceled}.Contains(Status)) AndAlso IsDBNull(Grid.Item(GridColumns.AssignedTechnician, RowIndex).Value) Then
            Grid.Rows(RowIndex).ErrorText = "Assigned Technician Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න."
            Return
        End If

        If (Not {RepairStatus.Received, RepairStatus.AssignedTo, RepairStatus.Canceled}.Contains(Status)) AndAlso IsDBNull(Grid.Item(GridColumns.AssignedTechnician, RowIndex).Value) Then
            Grid.Rows(RowIndex).ErrorText = "Handed Over Technician Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පුර්ණ කරන්න."
            Return
        End If

        If Not {RepairStatus.Repaired, RepairStatus.Returned, RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered}.Contains(Status) Then
            Return
        End If

        If String.IsNullOrWhiteSpace(Grid.Item(GridColumns.RepairedDate, RowIndex).Value) Then
            Grid.Item(GridColumns.RepairedDate, RowIndex).Value = Now
        End If

        If String.IsNullOrWhiteSpace(Grid.Item(GridColumns.RepairCharge, RowIndex).Value) Then
            Grid.Rows(RowIndex).ErrorText = "Repair Charge යන Cell එක හිස්ව පවතියි. කරුණාකර එය සම්පූර්ණ කරන්න."
        End If
    End Sub

    Private Sub Grid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Grid.EditingControlShowing
        If Grid.CurrentCell.OwningColumn.Name = GridColumns.RepairedDate Then
            DatePicker.Location = Grid.GetCellDisplayRectangle(Grid.CurrentCell.ColumnIndex, Grid.CurrentCell.RowIndex, True).Location
            DatePicker.Size = New Size(Grid.Columns.Item(Grid.CurrentCell.ColumnIndex).Width, Grid.Rows.Item(Grid.CurrentCell.RowIndex).Height)
        ElseIf Grid.CurrentCell.OwningColumn.Name = GridColumns.Location Then
            Dim LocationTextBox As TextBox = TryCast(e.Control, TextBox)
            frmSearchDropDown.passtext(LocationTextBox)
            AddHandler LocationTextBox.KeyUp, AddressOf frmSearchDropDown.dgv_KeyUp
            frmSearchDropDown.frm_Open(Db, Grid, Me.FormParent, "SELECT Location FROM Repair GROUP BY Location;", "Location")
        End If
    End Sub

    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        If e.RowIndex < 0 Then
            Return
        End If

        Try
            Dim RepairNo As Integer = Grid.Item(GridColumns.RepairNo, e.RowIndex).Value
            ' Dispose the DatePicker for RepairedDate field
            If Grid.Columns(GridColumns.RepairedDate).Index = e.ColumnIndex Then
                Grid.CurrentCell.Value = DatePicker.Value.ToString
                DatePicker.Dispose()
            End If

            Dim CurrentValue As Object = Grid.Item(e.ColumnIndex, e.RowIndex).Value
            If e.ColumnIndex = Grid.Columns.Item(GridColumns.Location).Index Then
                frmSearchDropDown.frm_Close()
            End If

            If GridCellEndEditValidation(CurrentValue, e.RowIndex) = False Then
                Return
            End If

            Dim QueryProperties As New Dictionary(Of String, Object)
            Select Case e.ColumnIndex
                Case Grid.Columns(GridColumns.AssignedTechnician).Index
                    Dim ActivityDictionary As New Dictionary(Of String, Object)
                    If Grid.Item(GridColumns.Status, e.RowIndex).Value = RepairStatus.Received Then
                        Grid.Item(GridColumns.Status, e.RowIndex).Value = RepairStatus.AssignedTo
                        QueryProperties.Add(Repair.Status, RepairStatus.AssignedTo)
                        ActivityDictionary.Add(Repair.Status, RepairStatus.AssignedTo)
                    End If

                    QueryProperties.Add(Repair.AssignedToTNo, TechnicianController.GetTechnicianNo(CurrentValue))
                    ActivityDictionary.Add(Grid.Columns(e.ColumnIndex).DataPropertyName, CurrentValue)
                    PerformRepairUpdate(RepairNo, QueryProperties, ActivityDictionary)
                Case Grid.Columns(GridColumns.HandedOverTechnician).Index
                    Dim ActivityDictionary As New Dictionary(Of String, Object)
                    If {RepairStatus.Received, RepairStatus.AssignedTo}.Contains(Grid.Item(GridColumns.Status, e.RowIndex).Value) Then
                        Grid.Item(GridColumns.Status, e.RowIndex).Value = RepairStatus.HandedOverTo
                        QueryProperties.Add(Repair.Status, RepairStatus.HandedOverTo)
                        ActivityDictionary.Add(Repair.Status, RepairStatus.HandedOverTo)
                    End If

                    QueryProperties.Add(Repair.HandedOverToTNo, TechnicianController.GetTechnicianNo(CurrentValue))
                    ActivityDictionary.Add(Grid.Columns(e.ColumnIndex).DataPropertyName, CurrentValue)
                    PerformRepairUpdate(RepairNo, QueryProperties, ActivityDictionary)
                Case Grid.Columns(GridColumns.RepairCharge).Index
                    If Int(CurrentValue) = 0 Then
                        Grid.Item(GridColumns.Status, e.RowIndex).Value = RepairStatus.Returned
                        QueryProperties.Add(Repair.Status, RepairStatus.Returned)
                    Else
                        Grid.Item(GridColumns.Status, e.RowIndex).Value = RepairStatus.Repaired
                        QueryProperties.Add(Repair.Status, RepairStatus.Repaired)
                    End If

                    Grid.Item(GridColumns.RepairedDate, e.RowIndex).Value = Now
                    QueryProperties.Add(Repair.RepDate, Grid.Item(GridColumns.RepairedDate, e.RowIndex).Value)
                    QueryProperties.Add(Repair.Charge, CurrentValue)
                    PerformRepairUpdate(RepairNo, QueryProperties)
                Case Else
                    QueryProperties.Add(Grid.Columns(e.ColumnIndex).DataPropertyName, CurrentValue)
                    PerformRepairUpdate(RepairNo, QueryProperties)
            End Select
        Catch Ex As Exception
            Grid.Item(e.ColumnIndex, e.RowIndex).Value = GridCellPreviousValue
            MessageBox.Error($"මෙම Record එක Update කිරිමෙදී ගැටලුවක් ඇතිවිය.{vbCrLf + Ex.Message}")
        End Try
    End Sub

    Private Function GridCellEndEditValidation(CurrentValue As Object, RowIndex As Integer) As Boolean
        If GridCellPreviousValue.Equals(CurrentValue) Then
            Return False
        End If

        If {RepairStatus.RepairedDelivered, RepairStatus.ReturnedDelivered, RepairStatus.Canceled}.Contains(Grid.Item(GridColumns.Status, RowIndex).Value) Then
            Return False
        End If

        Return True
    End Function

    Private Sub PerformRepairUpdate(RepairNo As Integer, QueryProperties As Dictionary(Of String, Object), Optional Activity As Dictionary(Of String, Object) = Nothing)
        Dim SetClauses As New List(Of String), Parameters As New List(Of MySqlParameter)
        For Each QueryProperty In QueryProperties
            Dim KeyUpper As String = $"@{QueryProperty.Key.ToUpper()}"
            SetClauses.Add($"{QueryProperty.Key} = {KeyUpper}")
            Parameters.Add(New MySqlParameter(KeyUpper, QueryProperty.Value))
        Next

        Parameters.Add(New MySqlParameter("REPNO", RepairNo))
        Db.Execute($"UPDATE {Tables.Repair} SET {String.Join(", ", SetClauses)} WHERE {Repair.RepNo} = @REPNO;", Parameters.ToArray)
        RepairController.InsertRepairActivity(Mode, RepairNo, $"UPDATE: {JsonConvert.SerializeObject(If(Activity, QueryProperties))}")
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick
        If TypeOf Grid.Columns(e.ColumnIndex) IsNot DataGridViewButtonColumn OrElse e.RowIndex < 0 Then
            Return
        End If

        Select Case e.ColumnIndex
            Case Grid.Columns(GridColumns.RemarksByCustomer).Index
                RemarksContol = New ControlGridRemarks() With {
                    .Left = (Width - RemarksContol.Width) / 2,
                    .Top = (Height - RemarksContol.Height) / 2
                }
                RemarksContol.Init(Db, Mode, ControlRemarksOption.RemarksByCustomer, Grid.Item(GridColumns.RepairNo, e.RowIndex).Value)
                Controls.Add(RemarksContol)
        End Select
    End Sub

    Private Structure GridColumns
        Public Const ReRepairNo As String = "RetNo"
        Public Const RepairNo As String = "RepNo"
        Public Const ReceivedDate As String = "RDate"
        Public Const Customer As String = "CuName"
        Public Const PhoneNumber As String = "CuTelNo"
        Public Const Product As String = "Product"
        Public Const ModelNo As String = "PModelNo"
        Public Const Qty As String = "Qty"
        Public Const Problem As String = "Problem"
        Public Const Location As String = "Location"
        Public Const RemarksByCustomer As String = "RepRemarks1"
        Public Const RemarksByTechnician As String = "RepRemarks2"
        Public Const Status As String = "Status"
        Public Const AssignedTechnician As String = "AssignedTechnician"
        Public Const HandedOverTechnician As String = "HandedOverTechnician"
        Public Const RepairedDate As String = "RepDate"
        Public Const RepairCharge As String = "RepCharge"
        Public Const DeliveredDate As String = "DDate"
        Public Const PaidCharge As String = "PaidPrice"
    End Structure
End Class

