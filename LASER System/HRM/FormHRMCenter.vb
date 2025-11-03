Imports System.ComponentModel
Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class FormHRMCenter
    Inherits Form

    Private ReadOnly Db As New Database

    Private ReadOnly Tab As New TabControl With {.Dock = DockStyle.Fill}
    Private ReadOnly TabDashboard As New TabPage("Dashboard")
    Private ReadOnly TabTechnician As New TabPage("Technician Management")
    Private ReadOnly TabSalary As New TabPage("Salary Management")

    ' Dashboard controls
    Private ReadOnly LabelTotalTechnicians As New Label With {.AutoSize = True}
    Private ReadOnly LabelActiveTechnicians As New Label With {.AutoSize = True}

    ' Technician list controls
    Private ReadOnly PanelTechnicianList As New Panel With {.Dock = DockStyle.Top, .Height = 40}
    Private ReadOnly TextTechnicianSearch As New TextBox With {.Dock = DockStyle.Fill}
    Private ReadOnly ButtonNewTechnician As New Button With {.Text = "New Technician", .Dock = DockStyle.Right}
    Private ReadOnly GridTechnicians As New DataGridView With {.Dock = DockStyle.Fill, .ReadOnly = True, .AllowUserToAddRows = False, .SelectionMode = DataGridViewSelectionMode.FullRowSelect}

    ' Technician profile host
    Private ReadOnly PanelTechnicianProfile As New Panel With {.Dock = DockStyle.Bottom, .Height = 350}

    ' Salary placeholder
    Private ReadOnly LabelSalaryInfo As New Label With {.Text = "Salary Management will be migrated here.", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}

    Public Sub New()
        Me.Text = "HRM Center"
        Me.WindowState = FormWindowState.Maximized
        Controls.Add(Tab)
        Tab.TabPages.AddRange({TabDashboard, TabTechnician, TabSalary})

        ' Dashboard
        Dim Flow As New FlowLayoutPanel With {.Dock = DockStyle.Fill}
        Flow.Controls.Add(LabelTotalTechnicians)
        Flow.Controls.Add(LabelActiveTechnicians)
        TabDashboard.Controls.Add(Flow)

        ' Technician Management
        PanelTechnicianList.Controls.Add(TextTechnicianSearch)
        PanelTechnicianList.Controls.Add(ButtonNewTechnician)
        TabTechnician.Controls.Add(GridTechnicians)
        TabTechnician.Controls.Add(PanelTechnicianList)
        TabTechnician.Controls.Add(PanelTechnicianProfile)

        ' Salary Management placeholder
        TabSalary.Controls.Add(LabelSalaryInfo)

        AddHandler Load, AddressOf FormHRMCenter_Load
        AddHandler TextTechnicianSearch.TextChanged, AddressOf TextTechnicianSearch_TextChanged
        AddHandler ButtonNewTechnician.Click, AddressOf ButtonNewTechnician_Click
        AddHandler GridTechnicians.CellDoubleClick, AddressOf GridTechnicians_CellDoubleClick
    End Sub

    Private Sub FormHRMCenter_Load(sender As Object, e As EventArgs)
        If Not User.Instance.IsHrAdmin() Then
            MessageBox.Error("You don't have permission to access HRM Center.")
            Close()
            Return
        End If

        RefreshDashboard()
        LoadTechnicians()
    End Sub

    Private Sub RefreshDashboard()
        Dim Total = Db.GetData("SELECT COUNT(*) FROM Technician;")
        Dim Active = Db.GetData("SELECT COUNT(*) FROM Technician WHERE TActive =1;")
        LabelTotalTechnicians.Text = $"Total Technicians: {Total}"
        LabelActiveTechnicians.Text = $"Active Technicians: {Active}"
    End Sub

    Private Sub LoadTechnicians(Optional Filter As String = "")
        Dim Query As String = "SELECT TNo as 'ID', TFullName as 'Full Name', TName as 'Short Name', TEmail as 'Email', TTelNo1 as 'Phone', TActive as 'Active' FROM Technician"
        Dim Params As New List(Of MySqlParameter)
        If Not String.IsNullOrWhiteSpace(Filter) Then
            Query &= " WHERE TNo LIKE @Q OR TFullName LIKE @Q OR TName LIKE @Q OR TEmail LIKE @Q OR TTelNo1 LIKE @Q"
            Params.Add(New MySqlParameter("Q", $"%{Filter}%"))
        End If
        Query &= " ORDER BY TFullName;"

        GridTechnicians.DataSource = Db.GetDataTable(Query, Params.ToArray())
        GridTechnicians.Refresh()
    End Sub

    Private Sub TextTechnicianSearch_TextChanged(sender As Object, e As EventArgs)
        LoadTechnicians(TextTechnicianSearch.Text)
    End Sub

    Private Sub ButtonNewTechnician_Click(sender As Object, e As EventArgs)
        ShowTechnicianProfile(Nothing)
    End Sub

    Private Sub GridTechnicians_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return
        Dim Row = GridTechnicians.Rows(e.RowIndex)
        Dim Id = Convert.ToInt32(Row.Cells("ID").Value)
        ShowTechnicianProfile(Id)
    End Sub

    Private Sub ShowTechnicianProfile(TechnicianNo As Integer?)
        PanelTechnicianProfile.Controls.Clear()
        Dim Control As New ControlTechnicianProfile(Db)
        PanelTechnicianProfile.Controls.Add(Control)
        Control.Dock = DockStyle.Fill
        If TechnicianNo.HasValue Then
            Control.LoadTechnician(TechnicianNo.Value)
        Else
            Control.PrepareNew()
        End If
        AddHandler Control.Saved, Sub()
                                      LoadTechnicians(TextTechnicianSearch.Text)
                                      RefreshDashboard()
                                  End Sub
    End Sub
End Class
