Imports LASER_System.StructureDatabase
Imports MySqlConnector

Public Class MailController : Inherits AbstractController

    Public Sub InsertToEmailQueue(MailAddress As String, Subject As String, Body As String)
        Db.Execute($"INSERT INTO {Tables.Mail}(MailDate, EmailTo, Subject, Body, Status) VALUES(@DATE, @EMAIL, @SUBJECT, @BODY, @STATUS);", {
            New MySqlParameter("DATE", Date.Now),
            New MySqlParameter("EMAIL", MailAddress),
            New MySqlParameter("SUBJECT", Subject),
            New MySqlParameter("BODY", Body),
            New MySqlParameter("STATUS", MailStatus.Waiting)
        })
    End Sub

    Private Structure MailStatus
        Const Waiting As String = "Waiting"
        Const Sent As String = "Sent"
        Const Failed As String = "Failed"
    End Structure

End Class
