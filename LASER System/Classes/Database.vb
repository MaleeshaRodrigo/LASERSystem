Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports LASER_System.My
Imports Microsoft.Office.Interop.Access.Dao
Imports Newtonsoft.Json

Public Class Database
    Private _Connection As New OleDbConnection

    Public Sub Connect()
        If _Connection.State = ConnectionState.Open Then Exit Sub
        For i As Integer = 0 To 3
            Try
                _Connection = New OleDbConnection($"Provider={Settings.DBProvider};Data Source={Settings.DBPath};Jet OLEDB:Database Password={(New Encoder()).Decode(Settings.DBPassword)};")
                _Connection.Open()
                Exit For
            Catch ex As FileNotFoundException
                If i = 2 Then
                    Throw New Exception("Database Path එක සොයා ගැනීමට නොහැකි විය.")
                End If
                Thread.Sleep(1000)
                Continue For
            Catch ex As Exception
                Throw ex
            End Try
        Next
    End Sub

    Public Function CheckConnection() As (Valid As Boolean, Message As String)
        If Settings.DBProvider = "" Then
            Return (False, "Database Provider ඇතුලත් කර නොමැත.")
        End If
        If Settings.DBPath = "" Then
            Return (False, "Database Path එක ඇතුලත් කර නොමැත.")
        End If
        If Settings.DBPassword = "" Then
            Return (False, "Database Password එක ඇතුලත් කර නොමැත.")
        End If
        If File.Exists(Settings.DBPath) = False Then
            Return (False, "Database Path එක සොයා ගැනීමට නොහැකි විය.")
        End If
        Try
            Connect()
            Disconnect()
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
        Return (True, "")
    End Function

    Public Sub Disconnect()
        If _Connection.State = ConnectionState.Closed Then Exit Sub
        _Connection.Close()
    End Sub

    Public Function CheckDataExists(Table As String, FieldName As String, Value As String) As Boolean
        Dim DR As OleDbDataReader = Nothing
        Try
            Dim Command = New OleDbCommand($"SELECT {FieldName} FROM {Table} WHERE {FieldName} = @VALUE", _Connection)
            Command.Parameters.AddWithValue("@VALUE", Value)
            DR = Command.ExecuteReader()
            Return DR.HasRows
        Catch ex As Exception
            Throw ex
        Finally
            If DR IsNot Nothing Then DR.Close()
        End Try
    End Function

    Public Sub Execute(Query As String, Optional Parameters() As OleDbParameter = Nothing, Optional AdminPer As AdminPermission = Nothing)
        Query = FormatQuery(Query, AdminPer)
        Dim CommandUpdate As New OleDbCommand(Query, _Connection)
        If Parameters IsNot Nothing Then
            CommandUpdate.Parameters.AddRange(Parameters)
        End If
        CommandUpdate.ExecuteNonQuery()
        CommandUpdate.Cancel()

        Activity.Write(Query)
    End Sub

    Public Sub DirectExecute(Query As String)
        Dim Command As New OleDbCommand(Query, _Connection)
        Command.ExecuteNonQuery()
        Command.Cancel()
    End Sub

    Private Function FormatQuery(Query As String, Optional AdminPer As AdminPermission = Nothing) As String
        If Query.Contains("?") = False Then
            Return Query
        End If
        Dim SplitText() As String = Query.Split("?")
        Dim i As Integer = 0
        While i < SplitText.Length
            Select Case SplitText(i)
                Case "NewKey"
                    Query = Query.Replace("?" + SplitText(i) + "?" + SplitText(i + 1) + "?" + SplitText(i + 2) + "?",
                                          GetNextKey(SplitText(i + 1), SplitText(i + 2)))
                    i += 2
                Case "Key"
                    If AdminPer.Keys.ContainsKey(SplitText(i + 1)) Then
                        Query = Query.Replace($"?{SplitText(i)}?{SplitText(i + 1)}?", AdminPer.Keys.Item(SplitText(i + 1)))
                        i += 1
                    End If
            End Select
            i += 1
        End While
        Return Query
    End Function

    Public Function GetDataTable(Sql As String, Optional Values As OleDbParameter() = Nothing) As DataTable
        Dim DataTable As New DataTable
        Dim DataAdapter As New OleDbDataAdapter(Sql, _Connection)
        If Values IsNot Nothing Then
            DataAdapter.SelectCommand.Parameters.AddRange(Values)
        End If
        DataAdapter.Fill(DataTable)
        DataAdapter.Dispose()
        Return DataTable
    End Function

    Public Function GetArray(Query As String, ColumnName As String) As List(Of String)
        Dim Command = New OleDbCommand(Query, _Connection)
        Dim DataReader As OleDbDataReader = Command.ExecuteReader()
        Dim Output As New List(Of String)
        While DataReader.Read
            Output.Add(DataReader(ColumnName).ToString)
        End While
        Command.Cancel()
        DataReader.Close()
        Return (Output)
    End Function

    Public Function GetNextKey(Table As String, Column As String) As Integer
        Dim Output As Integer
        Dim Command As New OleDbCommand($"Select Top 1 `{Column}` from `{Table}` Order by `{Column}` Desc", _Connection)
        Dim DataReader As OleDbDataReader = Command.ExecuteReader
        If DataReader.HasRows = True Then
            DataReader.Read()
            Output = Int(DataReader.Item(Column)) + 1
        Else
            Output = 1
        End If
        DataReader.Close()
        Return Output
    End Function

    Public Function GetRowsCount(Sql As String) As Integer
        Dim Command As New OleDbCommand(Sql, _Connection)
        Dim DataReader As OleDbDataReader = Command.ExecuteReader
        Dim DataTable As New DataTable
        DataTable.Load(DataReader)
        Dim Output As Integer = DataTable.Rows.Count
        DataReader.Close()
        DataTable.Clear()
        Return (Output)
    End Function

    Public Function GetDataReader(Sql As String, Optional Values As OleDbParameter() = Nothing) As OleDbDataReader
        Dim Command As New OleDbCommand(Sql, _Connection)
        If Values IsNot Nothing Then
            Command.Parameters.AddRange(Values)
        End If
        Return (Command.ExecuteReader())
    End Function

    Public Function GetDataAdapter(Query As String) As OleDbDataAdapter
        Dim DA As New OleDbDataAdapter(Query, _Connection)
        Return DA
    End Function

    Public Function GetData(Query As String, Optional Values As OleDbParameter() = Nothing) As Object
        Dim Command As New OleDbCommand(Query, _Connection)
        If Values IsNot Nothing Then
            Command.Parameters.AddRange(Values)
        End If
        Return Command.ExecuteScalar()
    End Function

End Class
