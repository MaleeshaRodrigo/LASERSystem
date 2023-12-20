Imports System.IO
Imports Microsoft.Office.Interop.Access.Dao
Imports Newtonsoft.Json

Public NotInheritable Class Activity
    Private Shared _Instance As Activity

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance As Activity
        Get
            If _Instance Is Nothing Then
                _Instance = New Activity()
            End If
            Return _Instance
        End Get
    End Property

    Public Shared Sub Write(Text As String)
        Dim DataSet As DataSet
        Dim DataTable As DataTable
        Dim LastIndex As Integer = 0
        If Not File.Exists(My.Settings.ActivityFilePath) Then
            Throw New FileNotFoundException($"{My.Settings.ActivityFilePath} cannot be found.")
            Exit Sub
        End If
        Dim ReadJson As String = File.ReadAllText(My.Settings.ActivityFilePath)
        If String.IsNullOrEmpty(ReadJson) Then
            DataSet = New DataSet
            DataTable = New DataTable

            DataTable.Columns.Add("ID")
            DataTable.Columns.Add("Date")
            DataTable.Columns.Add("Command")

            DataSet.Tables.Add(DataTable)
        Else
            DataSet = JsonConvert.DeserializeObject(Of DataSet)(ReadJson)
            DataTable = DataSet.Tables.Item("Table1")
            LastIndex = DataTable.Rows(DataTable.Rows.Count - 1)(0)
        End If
        DataTable.Rows.Add(LastIndex + 1, Now, Text)

        Dim WriteJson As String = JsonConvert.SerializeObject(DataSet, Formatting.Indented)
        File.WriteAllText(My.Settings.ActivityFilePath, WriteJson)
    End Sub


End Class
