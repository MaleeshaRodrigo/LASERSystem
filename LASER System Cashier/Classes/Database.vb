﻿Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports LASER_System.My
Imports Newtonsoft.Json

Public Class Database
    Private ReadOnly Provider As String
    Private ReadOnly DataSource As String
    Private ReadOnly Password As String
    Private Connection As New OleDbConnection

    Public Sub New()
        Me.Provider = Settings.DBProvider
        Me.DataSource = Settings.DatabaseCNN
        Me.Password = Settings.DBPassword
        If File.Exists(Me.DataSource) = False Then
            Throw New Exception("Database Path එක සොයා ගැනීමට නොහැකි විය.")
        End If
    End Sub

    Public Sub Connect()
        If Connection.State = ConnectionState.Open Then Exit Sub
        For i As Integer = 0 To 3
            Try
                Connection = New OleDbConnection($"Provider={Provider};Data Source={DataSource};Jet OLEDB:Database Password={Password};")
                Connection.Open()
                Exit For
            Catch ex As FileNotFoundException
                Thread.Sleep(1000)
                Continue For
            End Try
        Next
    End Sub

    Public Sub Disconnect()
        If Connection.State = ConnectionState.Closed Then Exit Sub
        Connection.Close()
    End Sub

    ''' <summary>
    ''' Update the given SQL Query to the database. If the Admin Permission needs to the SQL query, It won't apply to the database. After Admin 
    ''' accept changes, Then it will apply.
    ''' </summary>
    ''' <param name="SQL">The SQL Query</param>
    ''' <param name="AdminPer">The Admin Permission</param>
    Public Sub Update(SQL As String, Optional AdminPer As AdminPermission = Nothing)
        Dim CMDUPDATEDB As OleDbCommand
        If AdminPer IsNot Nothing And AdminPer.AdminSend = True Then
            If GetRowsCount($"Select APNo from AdminPermission Where APNo={AdminPer.APNo}") = 0 Then
                Dim APCommand As String = $"Insert into AdminPermission(APNo,APDate,`Status`,AppliedUNo,`Keys`,Remarks)
Values({AdminPer.APNo},#{DateAndTime.Now}#,'Waiting',{MdifrmMain.Tag},
'{JsonConvert.SerializeObject(AdminPer.Keys, Formatting.Indented)}','{AdminPer.Remarks}')"

                CMDUPDATEDB = New OleDbCommand(APCommand, Connection)
                CMDUPDATEDB.ExecuteNonQuery()
                CMDUPDATEDB.Cancel()

                UpdateOnlineTable(APCommand)
            End If
            Dim APCCommand As String = $"Insert into APCommand(APNo,Commands) Values({AdminPer.APNo},'{SQL.ToString.Replace("'", "''")}')"
            CMDUPDATEDB = New OleDbCommand(APCCommand, Connection)
            CMDUPDATEDB.ExecuteNonQuery()
            CMDUPDATEDB.Cancel()

            UpdateOnlineTable(APCCommand)
        Else
            'Replace a new index instead of command in keys dictionary in adminpermission
            If AdminPer IsNot Nothing AndAlso AdminPer.Keys.Count > 0 Then
                For Each key As String In AdminPer.Keys.Keys.ToList
                    If AdminPer.Keys(key).Contains("?") = True Then
                        Dim splittxt() As String = AdminPer.Keys(key).Split("?")
                        Select Case splittxt(1)
                            Case "NewKey"
                                AdminPer.Keys(key) = AdminPer.Keys(key).Replace("?" + splittxt(1) + "?" + splittxt(2) + "?" + splittxt(3) + "?",
                                              GetNextKey(splittxt(2), splittxt(3)))
                        End Select
                    End If
                Next

            End If
            'Replace a new index instead of command in `str` String in function
            If SQL.Contains("?") = True Then
                Dim splittxt() As String = SQL.Split("?")
                Dim i As Integer = 0
                While i < splittxt.Length
                    Select Case splittxt(i)
                        Case "NewKey"
                            SQL = SQL.Replace("?" + splittxt(i) + "?" + splittxt(i + 1) + "?" + splittxt(i + 2) + "?",
                                                  GetNextKey(splittxt(i + 1), splittxt(i + 2)))
                            i += 2
                        Case "Key"
                            If AdminPer.Keys.ContainsKey(splittxt(i + 1)) Then
                                SQL = SQL.Replace($"?{splittxt(i)}?{splittxt(i + 1)}?", AdminPer.Keys.Item(splittxt(i + 1)))
                                i += 1
                            End If
                    End Select
                    i += 1
                End While
            End If
            CMDUPDATEDB = New OleDb.OleDbCommand(SQL, Connection)
            CMDUPDATEDB.ExecuteNonQuery()
            CMDUPDATEDB.Cancel()
            UpdateOnlineTable(SQL)
            WriteActivity(SQL)
        End If
    End Sub

    Public Sub DirectUpdate(Query As String)
        Dim Command As New OleDb.OleDbCommand(Query, Connection)
        Command.ExecuteNonQuery()
        Command.Cancel()
    End Sub

    Private Sub UpdateOnlineTable(Sql As String)
        Task.Run(Sub()
                     Dim Query As String = $"Insert into OnlineDB(ODate,Command) 
                Values(#{DateAndTime.Now}#,""{Sql.Replace("""", """""")}"")"
                     Dim Command As New OleDbCommand(Query, Connection)
                     Command.ExecuteNonQuery()
                     Command.Cancel()
                 End Sub)
    End Sub

    Public Function GetDataTable(Sql As String) As DataTable
        Dim DataTable As New DataTable
        Dim DataAdapter As New OleDbDataAdapter(Sql, Connection)
        DataAdapter.Fill(DataTable)
        DataAdapter.Dispose()
        Return DataTable
    End Function

    Public Function GetSpecificColumnArray(Query As String, ColumnName As String) As List(Of String)
        Dim Command = New OleDbCommand(Query, Connection)
        Dim DataReader As OleDbDataReader = Command.ExecuteReader()
        Dim Output As New List(Of String)
        While DataReader.Read
            Output.Add(DataReader(ColumnName).ToString)
        End While
        Return (Output)
        Command.Cancel()
        DataReader.Close()
    End Function

    Public Function GetNextKey(Table As String, Column As String) As Integer
        Dim Output As Integer
        Dim Command As New OleDbCommand($"Select Top 1 {Column} from {Table} Order by {Column} Desc", Connection)
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
        Dim Command As New OleDbCommand(Sql, Connection)
        Dim DataReader As OleDbDataReader = Command.ExecuteReader
        Dim DataTable As New DataTable
        DataTable.Load(DataReader)
        Dim Output As Integer = DataTable.Rows.Count
        DataReader.Close()
        DataTable.Clear()
        Return (Output)
    End Function

    Public Function GetDataReader(Sql As String) As OleDbDataReader
        CMD = New OleDb.OleDbCommand(Sql, Connection)
        Return (CMD.ExecuteReader())
    End Function

End Class
