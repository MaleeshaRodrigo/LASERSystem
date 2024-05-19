Imports System.IO

Public Class BackUpDatabaseProcess

    Public Sub Perform()
        'lblLoad.Text = "Backing up Database..."
        'tsProBar.Value = 90
        'Try
        '    If IsFileInUse(My.Settings.DatabasePath) = False Then Exit Try
        '    For Each controlObject As Control In flpMessage.Controls
        '        If controlObject.Tag = "SendSMSError" Then
        '            Exit Try
        '        End If
        '    Next
        '    If My.Settings.BackUpDB1 <> "" Then
        '        File.Copy(My.Settings.DatabasePath, My.Settings.BackUpDB1 + "\Database.accdb", True)
        '    End If
        '    If My.Settings.BackUpDB2 <> "" Then
        '        If Not System.IO.Directory.Exists(My.Settings.BackUpDB3 + "\Database Backup") Then
        '            System.IO.Directory.CreateDirectory(My.Settings.BackUpDB2 + "\Database Backup")
        '        End If
        '        File.Copy(My.Settings.DatabasePath, My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " +
        '                  Today.Month.ToString + ".accdb", True)
        '        File.SetAttributes(My.Settings.BackUpDB2 + "\Database Backup", FileAttributes.Hidden)

        '        File.Copy(My.Settings.DatabasePath, My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " + Today.Month.ToString +
        '                          " " + Today.Day.ToString + " " + DateAndTime.Now.Hour.ToString + ".accdb", True)
        '        For mnt As Integer = 1 To Today.Month
        '            For day As Integer = 1 To (Today.Day - 3)
        '                For hour As Integer = 0 To 23
        '                    If File.Exists(My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
        '                                        " " + day.ToString + " " + hour.ToString + ".accdb") Then
        '                        File.Delete(My.Settings.BackUpDB2 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
        '                                        " " + day.ToString + " " + hour.ToString + ".accdb")
        '                    End If
        '                Next
        '            Next
        '        Next
        '    End If
        '    If My.Settings.BackUpDB3 <> "" Then
        '        If Not System.IO.Directory.Exists(My.Settings.BackUpDB3 + "\Database Backup") Then
        '            System.IO.Directory.CreateDirectory(My.Settings.BackUpDB3 + "\Database Backup")
        '        End If
        '        File.Copy(My.Settings.DatabasePath, My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + Today.Month.ToString + ".accdb", True)
        '        File.SetAttributes(My.Settings.BackUpDB3 + "\Database Backup", FileAttributes.Hidden)

        '        File.Copy(My.Settings.DatabasePath, My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + Today.Month.ToString +
        '                      " " + Today.Day.ToString + " " + DateAndTime.Now.Hour.ToString + ".accdb", True)
        '        For mnt As Integer = 1 To Today.Month
        '            For day As Integer = 1 To (Today.Day - 3)
        '                For hour As Integer = 0 To 23
        '                    If File.Exists(My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
        '                                        " " + day.ToString + " " + hour.ToString + ".accdb") Then
        '                        File.Delete(My.Settings.BackUpDB3 + "\Database Backup\Database " + Today.Year.ToString + " " + mnt.ToString +
        '                                        " " + day.ToString + " " + hour.ToString + ".accdb")
        '                    End If
        '                Next
        '            Next
        '        Next
        '    End If
        'Catch ex As Exception
        '    CreateMessagePanel("Database Back Up කිරීම බිද වැටී ඇත.", "ස්වයංක්‍රීයව Database Back Up කිරීමේ පද්ධතියේ යම් දෝෂයක් නිසා ක්‍රියාවිරහිත වී ඇත." +
        '    vbCrLf + vbCrLf + "Message: " + ex.Message + vbCrLf + "මේ පිළිබඳව Software Developer හට දැනුම් දෙන්න.", "SendSMSError")
        'End Try
    End Sub
End Class
