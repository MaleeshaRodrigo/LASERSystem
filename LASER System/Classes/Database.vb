Imports System.Data.OleDb
Imports System.IO
Imports System.Threading
Imports LASER_System.My

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

    ''' <summary>
    ''' Check whether the result for the given data has rows or not
    ''' </summary>
    ''' <param name="Table">Table Name</param>
    ''' <param name="FieldName">Field Name</param>
    ''' <param name="Value">Value of field</param>
    ''' <returns>True, if there are rows in the SQL query, or false</returns>
    Public Function CheckDataIsExist(Table As String, FieldName As String, Value As String) As Boolean
        Try
            Dim Command = New OleDbCommand($"SELECT {FieldName} FROM {Table} WHERE {FieldName} = @VALUE", _Connection)
            Command.Parameters.AddWithValue("@VALUE", Value)
            Dim DR As OleDbDataReader = Command.ExecuteReader()
            Return DR.HasRows
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Update the given SQL Query to the database. 
    ''' </summary>
    ''' <param name="Query">The SQL Query</param>
    ''' <param name="Parameters">Query Parameters</param>
    Public Sub Execute(Query As String, Optional Parameters() As OleDbParameter = Nothing)
        Dim CMDUPDATEDB As OleDbCommand
        'Replace a new index 
        If Query.Contains("?") = True Then
            Dim splittxt() As String = Query.Split("?")
            Dim i As Integer = 0
            While i < splittxt.Length
                Select Case splittxt(i)
                    Case "NewKey"
                        Query = Query.Replace("?" + splittxt(i) + "?" + splittxt(i + 1) + "?" + splittxt(i + 2) + "?",
                                              GetNextKey(splittxt(i + 1), splittxt(i + 2)))
                        i += 2
                End Select
                i += 1
            End While
        End If
        CMDUPDATEDB = New OleDb.OleDbCommand(Query, _Connection)
        If Parameters IsNot Nothing Then
            CMDUPDATEDB.Parameters.AddRange(Parameters)
        End If
        CMDUPDATEDB.ExecuteNonQuery()
        CMDUPDATEDB.Cancel()
        StoreQueryForOnlineDb(Query)
        WriteActivity(Query)
    End Sub

    Public Sub DirectExecute(Query As String)
        Dim Command As New OleDbCommand(Query, _Connection)
        Command.ExecuteNonQuery()
        Command.Cancel()
    End Sub

    Private Sub StoreQueryForOnlineDb(Sql As String)
        Task.Run(Sub()
                     Dim Query As String = $"Insert into OnlineDB(ODate,Command) Values(@DATE,@COMMAND)"
                     Dim Command As New OleDbCommand(Query, _Connection)
                     Command.Parameters.AddRange({
                                                New OleDbParameter("@DATE", DateAndTime.Now.ToString),
                                                New OleDbParameter("@COMMAND", Sql)
                                                })
                     Command.ExecuteNonQuery()
                     Command.Cancel()
                 End Sub)
    End Sub

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
        Dim Command As New OleDbCommand($"Select Top 1 {Column} from {Table} Order by {Column} Desc", _Connection)
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

    Public Function GetDataReader(Sql As String, Optional Parameters() As OleDbParameter = Nothing) As OleDbDataReader
        Dim Command As OleDbCommand = New OleDbCommand(Sql, _Connection)
        If Parameters IsNot Nothing Then
            Command.Parameters.AddRange(Parameters)
        End If
        Return (Command.ExecuteReader())
    End Function

    Public Function GetDataAdapter(Query As String) As OleDbDataAdapter
        Dim DA As New OleDbDataAdapter(Query, _Connection)
        Return DA
    End Function

    Public Function GetData(Query As String) As Object
        Dim Command As New OleDbCommand(Query, _Connection)
        Return Command.ExecuteScalar()
    End Function

End Class
