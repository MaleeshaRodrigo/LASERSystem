Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports LASER_System.My

Public Class Database
    Private _Connection As New OdbcConnection

    Public Sub Connect()
        If _Connection.State = ConnectionState.Open Then Exit Sub
        Dim Encoder As New Encoder()
        Dim DbPassword As String = If(Settings.DBPassword <> "",
            Encoder.Decode(Settings.DBPassword),
            "")
        _Connection = New OdbcConnection($"DRIVER=MySQL ODBC 8.1 Unicode Driver;server={Settings.DBServer};port={Settings.DBPort};user={Settings.DBUserName};password={DbPassword};database={Settings.DBName};Option=3;")
        _Connection.Open()
    End Sub

    Public Function CheckConnection() As (Valid As Boolean, Message As String)
        If Settings.DBUserName = "" Then
            Return (False, "Database User Name එක ඇතුලත් කර නොමැත.")
        End If
        If Settings.DBServer = "" Then
            Return (False, "Database Server එක ඇතුලත් කර නොමැත.")
        End If
        If Settings.DBName = "" Then
            Return (False, "Database Name එක ඇතුලත් කර නොමැත.")
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

    Public Function CheckDataExists(Table As String, FieldName As String, Value As Object) As Boolean
        Dim Command As New OdbcCommand($"SELECT {FieldName} FROM {Table} WHERE {FieldName}=?;", _Connection)
        Command.Parameters.Add(New OdbcParameter("VALUE", Value))
        Using DataReader As OdbcDataReader = Command.ExecuteReader()
            Return DataReader.HasRows
        End Using
    End Function

    Public Sub Execute(Query As String, Optional Parameters As OdbcParameter() = Nothing, Optional AdminPer As AdminPermission = Nothing)
        Query = FormatQuery(Query, AdminPer)
        If AdminPer IsNot Nothing AndAlso AdminPer.AdminSend = True Then
            Exit Sub
        End If
        Dim CommandUpdate As New OdbcCommand(Query, _Connection)
        If Parameters IsNot Nothing Then
            CommandUpdate.Parameters.AddRange(Parameters)
        End If
        CommandUpdate.ExecuteNonQuery()
        CommandUpdate.Cancel()

        Activity.Write(Query)
    End Sub

    Public Sub DirectExecute(Query As String)
        Dim Command As New OdbcCommand(Query, _Connection)
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

    Public Function GetDataTable(Sql As String, Optional Values As OdbcParameter() = Nothing) As DataTable
        Dim DataTable As New DataTable
        Dim DataAdapter As New OdbcDataAdapter(Sql, _Connection)
        If Values IsNot Nothing Then
            DataAdapter.SelectCommand.Parameters.AddRange(Values)
        End If
        DataAdapter.Fill(DataTable)
        DataAdapter.Dispose()
        Return DataTable
    End Function

    Public Function GetArray(Query As String, ColumnName As String) As List(Of String)
        Dim Command = New OdbcCommand(Query, _Connection)
        Dim DataReader As OdbcDataReader = Command.ExecuteReader()
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
        Dim Command As New OdbcCommand($"SELECT `{Column}` FROM `{Table}` ORDER BY `{Column}` DESC LIMIT 1 ", _Connection)
        Dim DataReader As OdbcDataReader = Command.ExecuteReader
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
        Dim Command As New OdbcCommand(Sql, _Connection)
        Dim DataReader As OdbcDataReader = Command.ExecuteReader
        Dim DataTable As New DataTable
        DataTable.Load(DataReader)
        Dim Output As Integer = DataTable.Rows.Count
        DataReader.Close()
        DataTable.Clear()
        Return Output
    End Function

    Public Function GetDataReader(Sql As String, Optional Values As OdbcParameter() = Nothing) As OdbcDataReader
        Dim Command As New OdbcCommand(Sql, _Connection)
        If Values IsNot Nothing Then
            Command.Parameters.AddRange(Values)
        End If
        Return Command.ExecuteReader()
    End Function

    Public Function GetDataAdapter(Query As String) As OdbcDataAdapter
        Dim DA As New OdbcDataAdapter(Query, _Connection)
        Return DA
    End Function

    Public Function GetData(Query As String, Optional Values As OdbcParameter() = Nothing) As Object
        Dim Command As New OdbcCommand(Query, _Connection)
        If Values IsNot Nothing Then
            Command.Parameters.AddRange(Values)
        End If
        Return Command.ExecuteScalar()
    End Function

End Class
