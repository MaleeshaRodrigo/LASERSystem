Imports Newtonsoft.Json
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class AdminPermissionProcess
    Implements IProcess

    Private ReadOnly Database As Database
    Private ReadOnly Worker As BackgroundWorker

    Public Sub New(Database As Database, Worker As BackgroundWorker)
        Me.Database = Database
        Me.Worker = Worker
    End Sub

    Public Sub Perform() Implements IProcess.Perform
        'Dim DataReader = Database.GetDataReader("Select * from AdminPermission Where Status='Confirmed';")
        'While DataReader.Read
        '    If Worker.CancellationPending Then
        '        e.Cancel = True
        '        Exit Sub
        '    End If

        '    Dim Dict As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(
        '        DataReader("Keys").ToString
        '    )
        '    ' Replace a new index instead of command in keys dictionary.
        '    If Dict.Count > 0 Then
        '        For Each key As String In Dict.Keys.ToList()
        '            If Dict(key).Contains("?") = True Then
        '                Dim splittxt() As String = Dict(key).Split("?")
        '                Select Case splittxt(1)
        '                    Case "NewKey"
        '                        Dict(key) = Dict(key).Replace(
        '                            $"?{splittxt(1)}?{splittxt(2)}?{splittxt(3)}?",
        '                            Database.GetNextKey(splittxt(2), splittxt(3))
        '                        )
        '                End Select
        '            End If
        '        Next
        '        Database.Execute($"Update AdminPermission Set `Keys`='{JsonConvert.SerializeObject(Dict, Formatting.Indented)}' Where APNo={DataReader("APNo")}")
        '    End If
        '    Dim DataReaderCommands = Database.GetDataReader($"Select * from APCommand Where APNo={DataReader("APNo")}")
        '    While DataReaderCommands.Read
        '        Dim Str As String = DataReaderCommands("Commands")
        '        ' Replace a new index instead of command.
        '        If DataReaderCommands("Commands").Contains("?") = True Then
        '            Dim splittxt() As String = Str.Split("?")
        '            Dim i As Integer = 0
        '            While i < splittxt.Length
        '                Select Case splittxt(i)
        '                    Case "NewKey"
        '                        Str = Str.Replace(
        '                            $"?{splittxt(i)}?{splittxt(i + 1)}?{splittxt(i + 2)}?",
        '                            Database.GetNextKey(splittxt(i + 1), splittxt(i + 2))
        '                        )
        '                        i += 2
        '                    Case "Key"
        '                        If Dict.ContainsKey(splittxt(i + 1)) Then
        '                            Str = Str.Replace($"?{splittxt(i)}?{splittxt(i + 1)}?", Dict.Item(splittxt(i + 1)))
        '                            i += 1
        '                        End If
        '                End Select
        '                i += 1
        '            End While
        '            Database.Execute($"Update APCommand Set Commands=""{Str}"" Where APCNo={DataReaderCommands("APCNo")}")
        '        End If
        '        Database.Execute(Str)
        '    End While
        '    Database.Execute("Update AdminPermission set `Status`='Completed' Where APNo=" & DataReader("APNo").ToString)
        'End While
    End Sub
End Class
