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

    ''' <summary>
    ''' Check whether the result for the given data has rows or not
    ''' </summary>
    ''' <param name="Table">Table Name</param>
    ''' <param name="FieldName">Field Name</param>
    ''' <param name="Value">Value of field</param>
    ''' <returns>True, if there are rows in the SQL query, or false</returns>
    Public Function CheckDataIsExist(Table As String, FieldName As String, Value As String) As Boolean
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

    ''' <summary>
    ''' Update the given SQL Query to the database. If the Admin Permission needs to the SQL query, It won't apply to the database. After Admin 
    ''' accept changes, Then it will apply.
    ''' </summary>
    ''' <param name="Query">The SQL Query</param>
    ''' <param name="AdminPer">The Admin Permission</param>
    Public Sub Execute(Query As String, Optional Parameters() As OleDbParameter = Nothing, Optional AdminPer As AdminPermission = Nothing)
        Dim CMDUPDATEDB As OleDbCommand
        If AdminPer IsNot Nothing AndAlso AdminPer.AdminSend = True Then
            If GetRowsCount($"Select APNo from AdminPermission Where APNo={AdminPer.APNo}") = 0 Then
                Dim APCommand As String = $"Insert into AdminPermission(APNo,APDate,`Status`,AppliedUNo,`Keys`,Remarks)
Values({AdminPer.APNo},#{DateAndTime.Now}#,'Waiting',{MdifrmMain.Tag},
'{JsonConvert.SerializeObject(AdminPer.Keys, Formatting.Indented)}','{AdminPer.Remarks}')"

                CMDUPDATEDB = New OleDbCommand(APCommand, _Connection)
                CMDUPDATEDB.ExecuteNonQuery()
                CMDUPDATEDB.Cancel()

                UpdateOnlineTable(APCommand)
            End If
            Dim APCCommand As String = $"Insert into APCommand(APNo,Commands) Values({AdminPer.APNo},'{Query.ToString.Replace("'", "''")}')"
            CMDUPDATEDB = New OleDbCommand(APCCommand, _Connection)
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
            If Query.Contains("?") = True Then
                Dim splittxt() As String = Query.Split("?")
                Dim i As Integer = 0
                While i < splittxt.Length
                    Select Case splittxt(i)
                        Case "NewKey"
                            Query = Query.Replace("?" + splittxt(i) + "?" + splittxt(i + 1) + "?" + splittxt(i + 2) + "?",
                                                  GetNextKey(splittxt(i + 1), splittxt(i + 2)))
                            i += 2
                        Case "Key"
                            If AdminPer.Keys.ContainsKey(splittxt(i + 1)) Then
                                Query = Query.Replace($"?{splittxt(i)}?{splittxt(i + 1)}?", AdminPer.Keys.Item(splittxt(i + 1)))
                                i += 1
                            End If
                    End Select
                    i += 1
                End While
            End If
            CMDUPDATEDB = New OleDb.OleDbCommand(Query, _Connection)
            For Each Parameter As OleDbParameter In Parameters
                CMDUPDATEDB.Parameters.AddWithValue(Parameter.ParameterName, Parameter.Value)
            Next
            CMDUPDATEDB.ExecuteNonQuery()
            CMDUPDATEDB.Cancel()
            UpdateOnlineTable(Query)
            WriteActivity(Query)
        End If
    End Sub

    Public Sub DirectExecute(Query As String)
        Dim Command As New OleDb.OleDbCommand(Query, _Connection)
        Command.ExecuteNonQuery()
        Command.Cancel()
    End Sub

    Private Sub UpdateOnlineTable(Sql As String)
        Task.Run(Sub()
                     Dim Query As String = $"Insert into OnlineDB(ODate,Command) 
                Values(#{DateAndTime.Now}#,""{Sql.Replace("""", """""")}"")"
                     Dim Command As New OleDbCommand(Query, _Connection)
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

    Public Function GetDataReader(Sql As String) As OleDbDataReader
        CMD = New OleDb.OleDbCommand(Sql, _Connection)
        Return (CMD.ExecuteReader())
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
