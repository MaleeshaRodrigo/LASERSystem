Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports Newtonsoft.Json

Public NotInheritable Class Activity
    Private Shared _Instance As Activity
    Public Shared ReadOnly FilePath As String = Path.Combine(ApplicationDataFilePath, "Activity.json")
    Private Shared DataSet As DataSet
    Private Shared DataTable As DataTable
    Private Shared LastIndex As Integer
    Private Shared LastSavedTime As New DateTime

    Private Sub New()
    End Sub

    Public ReadOnly Property Instance As Activity
        Get
            If _Instance Is Nothing Then
                _Instance = New Activity()
            End If
            Return _Instance
        End Get
    End Property

    Public Shared Sub Init()
        If Not File.Exists(FilePath) Then
            Throw New FileNotFoundException($"{FilePath} cannot be found.")
            Exit Sub
        End If

        Dim ReadJson As String = File.ReadAllText(FilePath)
        If String.IsNullOrEmpty(ReadJson) Then
            DataSet = New DataSet
            DataTable = New DataTable

            DataTable.Columns.Add("Id")
            DataTable.Columns.Add("Date")
            DataTable.Columns.Add("Command")

            DataSet.Tables.Add(DataTable)
            LastIndex = 0
        Else
            DataSet = JsonConvert.DeserializeObject(Of DataSet)(ReadJson)
            DataTable = DataSet.Tables.Item("Table1")
            LastIndex = DataTable.Rows(DataTable.Rows.Count - 1)(0)
        End If
    End Sub

    Public Shared Function GetDataTable() As DataTable
        Return DataTable
    End Function

    Public Shared Sub Write(Text As String)
        DataTable.Rows.Add(LastIndex + 1, Now, Text)

        If Now() > LastSavedTime.AddMinutes(1) Then
            Dim TaskSave As New Task(Sub() Save())
            TaskSave.Start()
            LastSavedTime = Now()
        End If
    End Sub

    Public Shared Sub Save()
        Dim WriteJson As String = JsonConvert.SerializeObject(DataSet, Formatting.Indented)
        File.WriteAllText(FilePath, WriteJson)
        LastSavedTime = Now()
    End Sub
End Class
