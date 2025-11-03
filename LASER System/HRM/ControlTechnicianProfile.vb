Imports MySqlConnector
Imports LASER_System.StructureDatabase

Public Class ControlTechnicianProfile
    Inherits UserControl

    Public Event Saved()

    Private ReadOnly Db As Database

    Private ReadOnly TextId As New TextBox With {.ReadOnly = True, .Dock = DockStyle.Top}
    Private ReadOnly TextShortName As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly TextFullName As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly TextEmail As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly TextAddress As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly TextTel1 As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly TextTel2 As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly TextTel3 As New TextBox With {.Dock = DockStyle.Top}
    Private ReadOnly CheckActive As New CheckBox With {.Text = "Active", .Dock = DockStyle.Top}
    Private ReadOnly ButtonSave As New Button With {.Text = "Save", .Dock = DockStyle.Bottom}

    Public Sub New(Db As Database)
        Me.Db = Db
        Dock = DockStyle.Fill
        ' Add labels for clarity
        Controls.AddRange({ButtonSave, CheckActive,
        CreateLabeled(TextTel3, "Telephone3"),
        CreateLabeled(TextTel2, "Telephone2"),
        CreateLabeled(TextTel1, "Telephone1"),
        CreateLabeled(TextAddress, "Address"),
        CreateLabeled(TextEmail, "Email"),
        CreateLabeled(TextFullName, "Full Name"),
        CreateLabeled(TextShortName, "Short Name"),
        CreateLabeled(TextId, "Technician ID")})
        AddHandler ButtonSave.Click, AddressOf ButtonSave_Click
    End Sub

    Private Function CreateLabeled(ctrl As Control, labelText As String) As Panel
        Dim p As New Panel With {.Dock = DockStyle.Top, .Height = 44}
        Dim lbl As New Label With {.Text = labelText, .Dock = DockStyle.Top, .AutoSize = True}
        ctrl.Dock = DockStyle.Top
        p.Controls.Add(ctrl)
        p.Controls.Add(lbl)
        Return p
    End Function

    Public Sub PrepareNew()
        TextId.Text = Db.GetNextKey(Tables.Technician, Technician.TNo)
        TextShortName.Text = ""
        TextFullName.Text = ""
        TextEmail.Text = ""
        TextAddress.Text = ""
        TextTel1.Text = ""
        TextTel2.Text = ""
        TextTel3.Text = ""
        CheckActive.Checked = True
    End Sub

    Public Sub LoadTechnician(TNo As Integer)
        Dim DR = Db.GetDataDictionary($"SELECT * FROM {Tables.Technician} WHERE {Technician.TNo}=@TNO;", {New MySqlParameter("TNO", TNo)})
        If DR Is Nothing Then Return
        TextId.Text = DR(Technician.TNo).ToString
        TextShortName.Text = DR(Technician.TName).ToString
        TextFullName.Text = DR(Technician.TFullName).ToString
        TextEmail.Text = DR(Technician.TEmail).ToString
        TextAddress.Text = DR(Technician.TAddress).ToString
        TextTel1.Text = DR(Technician.TTelNo1).ToString
        TextTel2.Text = DR(Technician.TTelNo2).ToString
        TextTel3.Text = DR(Technician.TTelNo3).ToString
        CheckActive.Checked = Convert.ToBoolean(DR(Technician.TActive))
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(TextShortName.Text) Then
            MessageBox.Error("Technician short name is required.")
            Return
        End If

        Dim Exists = Db.CheckDataExists(Tables.Technician, Technician.TNo, TextId.Text)
        If Exists Then
            Db.Execute($"UPDATE {Tables.Technician} SET {Technician.TName}=@TNAME, {Technician.TFullName}=@TFULLNAME, {Technician.TEmail}=@TEMAIL, {Technician.TAddress}=@TADDRESS, {Technician.TTelNo1}=@TTEL1, {Technician.TTelNo2}=@TTEL2, {Technician.TTelNo3}=@TTEL3, {Technician.TActive}=@TACTIVE WHERE {Technician.TNo}=@TNO;", {
            New MySqlParameter("TNAME", TextShortName.Text),
            New MySqlParameter("TFULLNAME", TextFullName.Text),
            New MySqlParameter("TEMAIL", TextEmail.Text),
            New MySqlParameter("TADDRESS", TextAddress.Text),
            New MySqlParameter("TTEL1", TextTel1.Text),
            New MySqlParameter("TTEL2", TextTel2.Text),
            New MySqlParameter("TTEL3", TextTel3.Text),
            New MySqlParameter("TACTIVE", CheckActive.Checked),
            New MySqlParameter("TNO", TextId.Text)
            })
        Else
            Db.Execute($"INSERT INTO {Tables.Technician}({Technician.TNo},{Technician.TName},{Technician.TFullName},{Technician.TEmail},{Technician.TAddress},{Technician.TTelNo1},{Technician.TTelNo2},{Technician.TTelNo3},{Technician.TActive}) VALUES(@TNO,@TNAME,@TFULLNAME,@TEMAIL,@TADDRESS,@TTEL1,@TTEL2,@TTEL3,@TACTIVE);", {
            New MySqlParameter("TNO", TextId.Text),
            New MySqlParameter("TNAME", TextShortName.Text),
            New MySqlParameter("TFULLNAME", TextFullName.Text),
            New MySqlParameter("TEMAIL", TextEmail.Text),
            New MySqlParameter("TADDRESS", TextAddress.Text),
            New MySqlParameter("TTEL1", TextTel1.Text),
            New MySqlParameter("TTEL2", TextTel2.Text),
            New MySqlParameter("TTEL3", TextTel3.Text),
            New MySqlParameter("TACTIVE", CheckActive.Checked)
            })
        End If

        MessageBox.Success("Saved")
        RaiseEvent Saved()
    End Sub
End Class
