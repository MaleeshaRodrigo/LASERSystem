Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.FileIO
Imports MySqlConnector
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class DatabaseSynchronizationProcess
    Implements IProcess
    Private LocalDatabase As New TransactionDatabase()
    Private RemoteDatabase As New TransactionDatabase()

    Public Sub Perform() Implements IProcess.Perform
        Dim DatabasesValidation = VerifyDatabases()
        If DatabasesValidation.Valid = False Then
            Throw New Exception(DatabasesValidation.Message)
        End If

        Dim LocalQueryLog = LocalDatabase.GetDataTable("SELECT * FROM `query_log` WHERE `Location` = 'local' AND `Synchronized` = 0 AND `Error` IS NULL;")
        Dim RemoteQueryLog = RemoteDatabase.GetDataTable("SELECT * FROM `query_log` WHERE `Location` = 'cloud' AND `Synchronized` = 0 AND `Error` IS NULL;")
        LocalQueryLog.Merge(RemoteQueryLog, False)
        LocalQueryLog.DefaultView.Sort = "created_at ASC"
        LocalQueryLog = LocalQueryLog.DefaultView.ToTable
        For Each Row As DataRow In LocalQueryLog.Rows
            Dim TargetDatabase, CurrentDatabase As TransactionDatabase
            If Row("Location") = DatabaseLocation.CLOUD Then
                TargetDatabase = LocalDatabase
                CurrentDatabase = RemoteDatabase
            ElseIf Row("Location") = DatabaseLocation.LOCAL Then
                TargetDatabase = RemoteDatabase
                CurrentDatabase = LocalDatabase
            Else
                Continue For
            End If

            Try
                CurrentDatabase.BeginTransaction()
                TargetDatabase.BeginTransaction()

                ExecuteTheQuery(TargetDatabase, Row("Query"), Row("Parameters"))
                InsertQueryLog(TargetDatabase, Row)
                MarkSynchronized(CurrentDatabase, Row)

                CurrentDatabase.CommitTransaction()
                TargetDatabase.CommitTransaction()
            Catch Ex As Exception
                CurrentDatabase.RollbackTransaction()
                TargetDatabase.RollbackTransaction()
                MarkError(CurrentDatabase, Row, Ex.Message)
            End Try
        Next

        If Date.Now.DayOfWeek = DayOfWeek.Sunday And Now.Hour > 15 And Date.Parse(My.Settings.DatabaseLastSynchronizedAt).Day < Now.Day Then
            FullSynchronizeLocalToRemote()
            My.Settings.DatabaseLastSynchronizedAt = Now
        End If
    End Sub

    Public Function CanPerformable() As Boolean Implements IProcess.CanPerformable
        Return (My.Settings.RemoteDatabaseActive And CheckForInternetConnection())
    End Function

    Private Function VerifyDatabases() As (Valid As Boolean, Message As String)
        RemoteDatabase.SetConfiguration(
            My.Settings.RemoteDatabaseServer,
            My.Settings.RemoteDatabasePort,
            My.Settings.RemoteDatabaseUserName,
            My.Settings.RemoteDatabasePassword,
            My.Settings.RemoteDatabaseName
        )
        Dim RemoteDatabaseValidation = RemoteDatabase.CheckConnection()
        If RemoteDatabaseValidation.Valid = False Then
            Return (False, RemoteDatabaseValidation.Message)
        End If

        Dim LocalDatabaseValidation = LocalDatabase.CheckConnection()
        If RemoteDatabaseValidation.Valid = False Then
            Return (False, LocalDatabaseValidation.Message)
        End If

        Return (True, "")
    End Function

    Private Sub ExecuteTheQuery(Database As Database, Query As String, ParametersString As String)
        Dim ParametersJsonObject As Object = JsonConvert.DeserializeObject(ParametersString)
        If TypeOf ParametersJsonObject Is JObject Then
            Dim Parameters As JObject = ParametersJsonObject
            ExecuteForDictionaryOfParameters(Database, Query, Parameters.ToObject(Of Dictionary(Of String, Object)))
        ElseIf TypeOf ParametersJsonObject Is JArray Then
            Dim Parameters As JArray = ParametersJsonObject
            ExecuteForListOfParameters(Database, Query, Parameters.ToObject(Of List(Of Object)))
        Else
            Throw New Exception("Parameter type is handled.")
        End If
    End Sub

    Private Sub ExecuteForListOfParameters(Database As Database, Query As String, Parameters As List(Of Object))
        Dim MySqlParameters As New List(Of MySqlParameter)
        Dim i As Integer = 1
        Dim ParameterRegex As New Regex("\?")
        For Each Value As Object In Parameters
            Dim ParameterHolder As String = $"@VALUE{i}"
            Query = ParameterRegex.Replace(Query, ParameterHolder, 1)
            MySqlParameters.Add(New MySqlParameter(ParameterHolder, Value))
            i += 1
        Next
        Database.Execute(Query, MySqlParameters.ToArray())
    End Sub

    Private Sub ExecuteForDictionaryOfParameters(Database As Database, Query As String, Parameters As Dictionary(Of String, Object))
        Dim MySqlParameters As New List(Of MySqlParameter)
        For Each Parameter As KeyValuePair(Of String, Object) In Parameters
            MySqlParameters.Add(New MySqlParameter(Parameter.Key, Parameter.Value))
        Next
        Database.Execute(Query, MySqlParameters.ToArray())
    End Sub

    Private Sub InsertQueryLog(Database As Database, Row As DataRow)
        Database.Execute("INSERT INTO `query_log`(LogId, Location, Query, Parameters, Synchronized, Error, created_at, updated_at) VALUES(@ID, @LOCATION, @QUERY, @PARAMETERS, @SYNCHRONIZED, @ERROR, @CREATED_AT, @UPDATED_AT)", {
            New MySqlParameter("ID", Row("LogId")),
            New MySqlParameter("LOCATION", Row("Location")),
            New MySqlParameter("QUERY", Row("Query")),
            New MySqlParameter("PARAMETERS", Row("Parameters")),
            New MySqlParameter("SYNCHRONIZED", 1),
            New MySqlParameter("ERROR", Row("Error")),
            New MySqlParameter("CREATED_AT", Row("created_at")),
            New MySqlParameter("UPDATED_AT", Row("updated_at"))
        })
    End Sub

    Private Sub MarkError(Database As TransactionDatabase, Row As DataRow, ErrorMessage As String)
        Try
            Database.BeginTransaction()
            Database.Execute("UPDATE `query_log` SET `Error` = @ERROR WHERE `LogId` = @ID AND `Location` = @LOCATION;", {
                New MySqlParameter("ERROR", ErrorMessage),
                New MySqlParameter("ID", Row("LogId")),
                New MySqlParameter("LOCATION", Row("Location"))
            })
            Database.CommitTransaction()
        Catch ex As Exception
            Database.RollbackTransaction()
            Throw ex
        End Try
    End Sub

    Private Sub MarkSynchronized(Database As TransactionDatabase, Row As DataRow)
        Database.Execute("UPDATE `query_log` SET `Synchronized` = 1 WHERE `LogId` = @ID AND `Location` = @LOCATION;", {
            New MySqlParameter("ID", Row("LogId")),
            New MySqlParameter("LOCATION", Row("Location"))
        })
    End Sub

    Private Sub MarkSyncronizedLocalQueryLog()
        Try
            LocalDatabase.BeginTransaction()
            LocalDatabase.Execute("UPDATE `query_log` SET `Synchronized` = 1, `Error` = NULL WHERE `Synchronized` = 0 AND Location = @LOCATION;", {
                New MySqlParameter("LOCATION", DatabaseLocation.LOCAL)
            })
            LocalDatabase.CommitTransaction()
        Catch ex As Exception
            LocalDatabase.RollbackTransaction()
            Throw ex
        End Try
    End Sub

    Private Sub FullSynchronizeLocalToRemote()
        Dim LocalDatabaseConnection As MySqlConnection = LocalDatabase.GetConenction()
        Dim RemoteDatabaseConnection As MySqlConnection = RemoteDatabase.GetConenction()
        Try
            LocalDatabaseConnection.Open()
            RemoteDatabaseConnection.Open()

            MarkSyncronizedLocalQueryLog()
            Dim LocalBackup As New MySqlBackup(New MySqlCommand With {.Connection = LocalDatabaseConnection})
            LocalBackup.ExportToFile(Path.Combine(SpecialDirectories.MyDocuments, "LASER System Data", "LASER Background", "Database Back Up.sql"))

            Dim RemoteBakcup As New MySqlBackup(New MySqlCommand With {.Connection = RemoteDatabaseConnection})
            RemoteBakcup.ImportFromFile(Path.Combine(SpecialDirectories.MyDocuments, "LASER System Data", "LASER Background", "Database Back Up.sql"))
        Catch ex As Exception
            Throw ex
        Finally
            LocalDatabaseConnection.Close()
            RemoteDatabaseConnection.Close()
        End Try
    End Sub
End Class