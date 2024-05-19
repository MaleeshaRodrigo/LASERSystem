Imports System.Data.OleDb
Imports Newtonsoft.Json

Public Class FrmAdvDB
    'Private CNN As OleDbConnection
    'Private 
    'Private Sub FrmAdvDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    CNN = New OleDbConnection("Provider=" & My.Settings.DatabaseProvider & ";Data Source=" &
    '                                        My.Settings.DatabasePath & ";Jet OLEDB:Database Password=" &
    '                                        frmBGTasks.Simple.Decode(My.Settings.DatabasePassword) & ";")
    '    CNN.Open()
    'End Sub

    'Private Sub LoadOnlineDB()
    '    Dim CMD As New OleDbCommand("Select * from OnlineDB Order By ID;", CNN)
    '    Dim DR As OleDbDataReader = CMD.ExecuteReader
    '    Dim DT As New DataTable
    '    DT.Load(DR)
    '    GridOnlineDB.DataSource = DT
    'End Sub

    'Private Sub CmbOTable_DropDown(sender As Object, e As EventArgs) Handles CmbOTable.DropDown
    '    CmbOTable.Items.Clear()
    '    Dim JSONResponse As String = frmBGTasks.GetResponse(My.Settings.OnlineDatabasePath + "/view", $"user={HashPassword(My.Settings.OnlineDatabaseUser, frmBGTasks.Simple.Decode(My.Settings.ODBToken))}&password={HashPassword(frmBGTasks.Simple.Decode(My.Settings.OnlineDatabasePassword) + Format(Now(), "yyyy-MM-dd"), frmBGTasks.Simple.Decode(My.Settings.ODBToken))}&sql=SHOW tables;")
    '    Dim BGDT As DataTable = JsonConvert.DeserializeObject(Of DataTable)(JSONResponse)
    '    For Each DTRow As DataRow In BGDT.Rows
    '        CmbOTable.Items.Add(DTRow(0))
    '    Next
    'End Sub

    'Private Sub CmbTable_DropDown(sender As Object, e As EventArgs) Handles CmbTable.DropDown
    '    CmbTable.Items.Clear()
    '    Dim dt As DataTable = CNN.GetSchema("TABLES", {Nothing, Nothing, Nothing, "TABLE"})
    '    For Each dr As DataRow In dt.Rows
    '        CmbTable.Items.Add(dr("TABLE_NAME"))
    '    Next
    'End Sub
    'Private Sub CmbOTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOTable.SelectedIndexChanged
    '    If String.IsNullOrEmpty(CmbOTable.Text) Then Exit Sub
    '    Dim JSONResponse As String = frmBGTasks.GetResponse(My.Settings.OnlineDatabasePath + "/view", $"user={HashPassword(My.Settings.OnlineDatabaseUser, frmBGTasks.Simple.Decode(My.Settings.ODBToken))}&password={HashPassword(frmBGTasks.Simple.Decode(My.Settings.OnlineDatabasePassword) + Format(Now(), "yyyy-MM-dd"), frmBGTasks.Simple.Decode(My.Settings.ODBToken))}&sql=SELECT * FROM `{CmbOTable.Text}`;")
    '    Dim BGDT As DataTable = JsonConvert.DeserializeObject(Of DataTable)(JSONResponse)
    '    GridOnline.DataSource = BGDT
    'End Sub

    'Private Sub CmbTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTable.SelectedIndexChanged
    '    If String.IsNullOrEmpty(CmbTable.Text) Then Exit Sub
    '    Dim CMD As New OleDbCommand($"SELECT * FROM `{CmbTable.Text}`", CNN)
    '    Dim DR As OleDbDataReader = CMD.ExecuteReader
    '    Dim DT As New DataTable
    '    DT.Load(DR)
    '    GridLocal.DataSource = DT

    'End Sub

    'Private Sub GridOnlineDB_SelectionChanged(sender As Object, e As EventArgs) Handles GridOnlineDB.SelectionChanged
    '    If GridOnlineDB.CurrentRow.Index < 1 Then Exit Sub
    '    TxtCommand.Tag = GridOnlineDB.Item("ID", GridOnlineDB.CurrentRow.Index).Value
    '    TxtCommand.Text = GridOnlineDB.Item("Command", GridOnlineDB.CurrentRow.Index).Value
    'End Sub

    'Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
    '    Dim CMD As New OleDbCommand($"UPDATE OnlineDB SET Command=""{TxtCommand.Text.Replace("""", """""")}"" WHERE ID={TxtCommand.Tag}", CNN)
    '    CMD.ExecuteNonQuery()
    'End Sub

    'Private Sub BtnTurnUpdate_Click(sender As Object, e As EventArgs) Handles BtnTurnUpdate.Click
    '    Dim SQL As String = TxtCommand.Text.Trim
    '    Dim TableName As String = ""
    '    Dim CollectionColumnName As New List(Of String)
    '    Dim CollectionValue As New List(Of String)
    '    If SQL.StartsWith("Insert into") Then
    '        Dim i1 As Integer = SQL.IndexOf("(")
    '        TableName = SQL.Substring(11, i1 - 11).Trim
    '        Dim i2 As Integer = SQL.IndexOf(")", i1 + 1)
    '        Dim ColumnNames As String = SQL.Substring(i1 + 1, i2 - i1 - 1)
    '        For Each ColumnName As String In ColumnNames.Split(",")
    '            CollectionColumnName.Add(ColumnName)
    '        Next

    '        Dim j1 As Integer = SQL.IndexOf("(", i2 + 1)
    '        Dim j2 As Integer = SQL.IndexOf(")", j1 + 1)
    '        Dim Values As String = SQL.Substring(j1 + 1, j2 - j1 - 1)
    '        Dim bool As Boolean = False
    '        For Each Value As String In Values.Split(",")
    '            Dim prebool As Boolean = bool
    '            For Each chr As Char In Value
    '                If chr = "'" Or chr = """" Then
    '                    If bool Then
    '                        bool = False
    '                    Else
    '                        bool = True
    '                    End If
    '                End If
    '            Next
    '            If (prebool = True And bool = True) Or (prebool = True And bool = False) Then
    '                Dim lastIndex As Integer = CollectionValue.Count - 1
    '                CollectionValue.Item(lastIndex) += "," + Value
    '                Continue For
    '            End If
    '            CollectionValue.Add(Value)
    '        Next
    '    End If
    '    Dim ConvertedSQL As String = $"UPDATE {TableName} SET "
    '    For i As Integer = 1 To CollectionColumnName.Count - 1
    '        If i <> 1 Then ConvertedSQL += ","
    '        ConvertedSQL += CollectionColumnName.Item(i) + "=" + CollectionValue.Item(i)
    '    Next
    '    ConvertedSQL += $" WHERE {CollectionColumnName.Item(0)}={CollectionValue.Item(0)}"
    '    TxtCommand.Text = ConvertedSQL
    'End Sub
End Class