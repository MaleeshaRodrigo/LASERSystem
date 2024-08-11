Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions
Imports MySqlConnector

Public Class DatabaseBackupProcess
    Implements IProcess

    Private ReadOnly Database As Database
    Private ReadOnly Worker As BackgroundWorker

    Public Sub New(Database As Database, Worker As BackgroundWorker)
        Me.Database = Database
        Me.Worker = Worker
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        Dim Connection As MySqlConnection = Database.GetConenction
        Try
            If Worker.CancellationPending Then
                Exit Sub
            End If

            Connection.Open()
            Dim Backup As New MySqlBackup(New MySqlCommand With {.Connection = Connection})
            If CheckValidation(My.Settings.BackUpDB1) Then
                Backup.ExportToFile(Path.Combine(My.Settings.BackUpDB1, "Database.sql"))
            End If
            If CheckValidation(My.Settings.BackUpDB2) Then
                Backup.ExportToFile(Path.Combine(My.Settings.BackUpDB2, $"Database {Now.Date.ToShortDateString} {Now.Hour}.sql"))
                DeleteExpiredBackUps(My.Settings.BackUpDB2)
            End If
            If CheckValidation(My.Settings.BackUpDB3) Then
                Backup.ExportToFile(Path.Combine(My.Settings.BackUpDB3, $"Database {Now.Date.ToShortDateString} {Now.Hour}.sql"))
                DeleteExpiredBackUps(My.Settings.BackUpDB3)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Private Function CheckValidation(FolderPath As String) As Boolean
        If My.Settings.BackUpDB1.Trim() = "" Then
            Return False
        End If
        If Not Directory.Exists(FolderPath) Then
            Return False
        End If

        Return True
    End Function

    Private Sub DeleteExpiredBackUps(FolderPath As String)
        Dim FilePaths As String() = Directory.GetFiles(My.Settings.BackUpDB2)
        For Each FilePath As String In FilePaths
            Dim FileName = Path.GetFileName(FilePath)
            Dim ExtractDateFromFileNameRegEx As New Regex("Database ([\d-]+) \d+.sql")
            If Not ExtractDateFromFileNameRegEx.IsMatch(FileName) Then
                Continue For
            End If

            Dim CreatedDate As Date = Date.Parse(ExtractDateFromFileNameRegEx.Match(FileName).Groups(1).ToString)
            If CreatedDate < Now.AddDays(-7) Then
                File.Delete(FilePath)
            End If
        Next
    End Sub
End Class
