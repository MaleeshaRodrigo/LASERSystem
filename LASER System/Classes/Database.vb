﻿Imports System.Data.SqlClient
Imports LASER_System.My
Imports MySqlConnector

Public Class Database

    Public Function GetConenction() As MySqlConnection
        Dim Encoder As New Encoder()
        Dim DbPassword As String = If(Settings.DBPassword <> "",
            Encoder.Decode(Settings.DBPassword),
            "")
        Return New MySqlConnection($"server={Settings.DBServer};port={Settings.DBPort};user={Settings.DBUserName};password={DbPassword};database={Settings.DBName};")
    End Function

    Public Function CheckConnection() As (Valid As Boolean, Message As String)
        If Settings.DBServer = "" Then
            Return (False, "Database Server එක ඇතුලත් කර නොමැත.")
        End If
        If Settings.DBUserName = "" Then
            Return (False, "Database User Name එක ඇතුලත් කර නොමැත.")
        End If
        If Settings.DBName = "" Then
            Return (False, "Database Name එක ඇතුලත් කර නොමැත.")
        End If
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()

            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function CheckDataExists(Table As String, FieldName As String, Value As Object) As Boolean
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Dim Command As New MySqlCommand($"SELECT `{FieldName}` FROM `{Table}` WHERE `{FieldName}`=@VALUE;", Connection)
            Command.Parameters.Add(New MySqlParameter("VALUE", Value))
            Using DataReader = Command.ExecuteReader()
                Return DataReader.HasRows
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

    Public Sub Execute(Query As String, Optional Parameters As MySqlParameter() = Nothing, Optional AdminPer As AdminPermission = Nothing)
        Query = FormatQuery(Query, AdminPer)
        If AdminPer IsNot Nothing AndAlso AdminPer.AdminSend = True Then
            Exit Sub
        End If
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Using CommandUpdate As New MySqlCommand(Query, Connection)
                If Parameters IsNot Nothing Then
                    CommandUpdate.Parameters.AddRange(Parameters)
                End If
                CommandUpdate.ExecuteNonQuery()
            End Using

            Activity.Write(Query)
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Public Sub DirectExecute(Query As String)
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Using Command As New MySqlCommand(Query, Connection)
                Command.ExecuteNonQuery()
                Command.Cancel()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Public Sub ExecuteBatch(Query As String, Optional ParametersArray As MySqlParameter()() = Nothing)
        Dim Connection As MySqlConnection = GetConenction()
        Connection.Open()
        Dim Transaction As MySqlTransaction = Connection.BeginTransaction()
        Try
            Using Batch = New MySqlBatch(Connection, Transaction)
                For Each Parameters In ParametersArray
                    Dim BatchCommand = New MySqlBatchCommand(Query)
                    If Parameters IsNot Nothing Then
                        BatchCommand.Parameters.AddRange(Parameters)
                    End If
                    Batch.BatchCommands.Add(BatchCommand)
                Next
                Batch.ExecuteNonQuery()
            End Using
            Transaction.Commit()
        Catch ex As Exception
            Transaction.Rollback()
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Public Sub ExecuteBatches(QueriesWithValues As (Query As String, Parameters As MySqlParameter())())
        Dim Connection As MySqlConnection = GetConenction()
        Connection.Open()
        Dim Transaction As MySqlTransaction = Connection.BeginTransaction()
        Try
            Using Batch = New MySqlBatch(Connection, Transaction)
                For Each QueryWithValue In QueriesWithValues
                    Dim BatchCommand = New MySqlBatchCommand(QueryWithValue.Query)
                    If QueryWithValue.Parameters IsNot Nothing Then
                        BatchCommand.Parameters.AddRange(QueryWithValue.Parameters)
                    End If
                    Batch.BatchCommands.Add(BatchCommand)
                Next
                Batch.ExecuteNonQuery()
            End Using
            Transaction.Commit()
        Catch ex As Exception
            Transaction.Rollback()
            Throw ex
        Finally
            Connection.Close()
        End Try
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

    Public Function GetDataTable(Sql As String, Optional Values As MySqlParameter() = Nothing) As DataTable
        Dim DataTable As New DataTable
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Using DataAdapter As New MySqlDataAdapter(Sql, Connection)
                If Values IsNot Nothing Then
                    DataAdapter.SelectCommand.Parameters.AddRange(Values)
                End If
                DataAdapter.Fill(DataTable)
            End Using

            Return DataTable
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function GetArray(Query As String, ColumnName As String) As List(Of String)
        Dim Connection As MySqlConnection = GetConenction()
        Dim Output As New List(Of String)
        Try
            Connection.Open()
            Dim Command = New MySqlCommand(Query, Connection)
            Using DataReader = Command.ExecuteReader()
                For Each Item In DataReader
                    Output.Add(DataReader(ColumnName).ToString)
                Next
            End Using

            Return (Output)
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function GetNextKey(Table As String, Column As String) As Integer
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Dim Command As New MySqlCommand($"SELECT `{Column}` FROM `{Table}` ORDER BY `{Column}` DESC LIMIT 1 ", Connection)
            Using DataReader = Command.ExecuteReader
                If DataReader.HasRows Then
                    DataReader.Read()
                    Return Int(DataReader.Item(Column)) + 1
                Else
                    Return 1
                End If
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function GetRowsCount(Sql As String) As Integer
        Dim Connection As MySqlConnection = GetConenction()
        Dim DataTable As New DataTable
        Try
            Connection.Open()
            Using Command As New MySqlCommand(Sql, Connection), DataReader = Command.ExecuteReader
                DataTable.Load(DataReader)
                Return DataTable.Rows.Count
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function GetDataDictionary(Sql As String, Optional Values As MySqlParameter() = Nothing) As Dictionary(Of String, Object)
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Dim Command As New MySqlCommand(Sql, Connection)
            If Values IsNot Nothing Then
                Command.Parameters.AddRange(Values)
            End If
            Using DataReader = Command.ExecuteReader()
                If Not DataReader.HasRows Then
                    Return Nothing
                End If
                DataReader.Read()

                Return Enumerable.Range(0, DataReader.FieldCount).ToDictionary(
                    Function(i) DataReader.GetName(i),
                    Function(i) DataReader.GetValue(i)
                )
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function GetDataList(Sql As String, Optional Values As MySqlParameter() = Nothing) As List(Of Dictionary(Of String, Object))
        Dim Connection As MySqlConnection = GetConenction()
        Dim Output As New List(Of Dictionary(Of String, Object))
        Try
            Connection.Open()
            Dim Command As New MySqlCommand(Sql, Connection)
            If Values IsNot Nothing Then
                Command.Parameters.AddRange(Values)
            End If
            Using DataReader = Command.ExecuteReader()
                While DataReader.Read()
                    Output.Add(
                        Enumerable.Range(0, DataReader.FieldCount).ToDictionary(
                            Function(i) DataReader.GetName(i),
                            Function(i) DataReader.GetValue(i)
                        )
                    )
                End While

                Return Output
            End Using
        Catch ex As Exception
            Throw
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function GetDataAdapter(Connection As MySqlConnection, Query As String, Optional Values As MySqlParameter() = Nothing) As MySqlDataAdapter
        Dim DA As New MySqlDataAdapter(Query, Connection)
        If Values IsNot Nothing Then
            DA.SelectCommand.Parameters.AddRange(Values)
        End If
        Return DA
    End Function

    Public Function GetData(Query As String, Optional Values As MySqlParameter() = Nothing) As Object
        Dim Connection As MySqlConnection = GetConenction()
        Try
            Connection.Open()
            Dim Command As New MySqlCommand(Query, Connection)
            If Values IsNot Nothing Then
                Command.Parameters.AddRange(Values)
            End If

            Return Command.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function

End Class
