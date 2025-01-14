Imports MySqlConnector

Public Class TransactionDatabase
    Inherits Database

    Private Transaction As MySqlTransaction = Nothing
    Private Connection As MySqlConnection = Nothing

    Public Sub BeginTransaction()
        If Connection Is Nothing Then
            Connection = GetConenction()
            Connection.Open()
        End If

        If Transaction Is Nothing Then
            Transaction = Connection.BeginTransaction()
        Else
            Throw New InvalidOperationException("A transaction is already active.")
        End If
    End Sub

    Public Sub CommitTransaction()
        If Transaction IsNot Nothing Then
            Transaction.Commit()
            Transaction.Dispose()
            Transaction = Nothing
            EndConnection()
        Else
            Throw New InvalidOperationException("No active transaction to commit.")
        End If
    End Sub

    Public Sub RollbackTransaction()
        If Transaction IsNot Nothing Then
            Transaction.Rollback()
            Transaction.Dispose()
            Transaction = Nothing
            EndConnection()
        Else
            Throw New InvalidOperationException("No active transaction to roll back.")
        End If
    End Sub

    Public Overrides Sub Execute(Query As String, Optional Parameters As MySqlParameter() = Nothing)
        If Transaction Is Nothing Then
            Throw New InvalidOperationException("Transaction must be started before executing queries.")
        End If

        Try
            Using CommandUpdate As New MySqlCommand(Query, Connection, Transaction)
                If Parameters IsNot Nothing Then
                    CommandUpdate.Parameters.AddRange(Parameters)
                End If
                CommandUpdate.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Function GetDataDictionary(Sql As String, Optional Values As MySqlParameter() = Nothing) As Dictionary(Of String, Object)
        Try
            Dim Command As New MySqlCommand(Sql, Connection, Transaction)
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
        End Try
    End Function

    Public Overrides Function GetData(Query As String, Optional Values As MySqlParameter() = Nothing) As Object
        Try
            Dim Command As New MySqlCommand(Query, Connection, Transaction)
            If Values IsNot Nothing Then
                Command.Parameters.AddRange(Values)
            End If

            Return Command.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EndConnection()
        If Connection IsNot Nothing Then
            Connection.Close()
            Connection.Dispose()
            Connection = Nothing
        End If
    End Sub
End Class
