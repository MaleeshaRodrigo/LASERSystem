Imports MySqlConnector

Public Class ControlTechnicianSelection
    Private Db As Database
    Private TechnicianNo As Integer

    Public Sub SetDatabase(Db As Database)
        Me.Db = Db
    End Sub

    Public Sub SetTechnician(Name As String)
        ComboTechnician.Text = Name
        SetTechnicianNo()
    End Sub

    Public Function GetTechnicianNo() As Integer
        Return TechnicianNo
    End Function

    Private Sub ControlTechnicianSelection_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DesignMode Then
            Exit Sub
        End If

        ComboBoxDropDown(Db, ComboTechnician, "SELECT TName FROM Technician WHERE TActive = 1 ORDER BY TName;")
    End Sub

    Private Sub ComboTechnician_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTechnician.SelectedIndexChanged
        SetTechnicianNo()
    End Sub

    Private Sub SetTechnicianNo()
        TechnicianNo = Db.GetData("SELECT TNo FROM Technician WHERE TName=@TNAME;", {
            New MySqlParameter("TNAME", ComboTechnician.Text)
        })
    End Sub
End Class
