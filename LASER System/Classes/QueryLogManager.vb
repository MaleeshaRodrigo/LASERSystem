Imports MySqlConnector
Imports Newtonsoft.Json

Public NotInheritable Class QueryLogManager
    Private Shared _Instance As QueryLogManager
    Private Shared ReadOnly Queue As New Queue(Of MySqlCommand)
    Private Shared TaskInstance As Task

    Private Sub New()
        TaskInstance = New Task(AddressOf PerformQueryLog)
    End Sub

    Public Shared ReadOnly Property Instance As QueryLogManager
        Get
            If _Instance Is Nothing Then
                _Instance = New QueryLogManager()
            End If
            Return _Instance
        End Get
    End Property

    Public Sub Log(Command As MySqlCommand)
        Queue.Enqueue(Command)
        StartTaskIfCompleted()
    End Sub

    Public Sub Log(QueriesWithValues As (Query As String, Parameters As MySqlParameter())())
        For Each QueryWithValues In QueriesWithValues
            Dim Command As New MySqlCommand(QueryWithValues.Query)
            If QueryWithValues.Parameters IsNot Nothing Then
                Command.Parameters.AddRange(QueryWithValues.Parameters)
            End If

            Queue.Enqueue(Command)
        Next
        StartTaskIfCompleted()
    End Sub

    Private Sub PerformQueryLog()
        Dim Database As New Database()
        While Queue.Count > 0
            'Dim RegEx As New Regex("[\s|\t|\r|\n]+", RegexOptions.Multiline)
            Dim QueueCommand As MySqlCommand = Queue.Dequeue()
            Dim ParameterDictionary As Dictionary(Of String, Object) = QueueCommand.Parameters.ToDictionary(Function(Parameter) Parameter.ParameterName, Function(Parameter) Parameter.Value)
            Database.DirectExecute("INSERT INTO `query_log` (Location, Query, Parameters, created_at) VALUES ('local', @QUERY, @PARAMETERS, NOW());", {
                New MySqlParameter("QUERY", QueueCommand.CommandText),
                New MySqlParameter("PARAMETERS", JsonConvert.SerializeObject(ParameterDictionary))
            })
            'New MySqlParameter("QUERY", RegEx.Replace(QueueCommand.CommandText, " ")),
        End While
    End Sub

    Private Sub StartTaskIfCompleted()
        If TaskInstance IsNot Nothing AndAlso (TaskInstance.Status = TaskStatus.Created Or TaskInstance.IsCompleted) Then
            TaskInstance = New Task(AddressOf PerformQueryLog)
            TaskInstance.Start()
        End If
    End Sub

End Class
