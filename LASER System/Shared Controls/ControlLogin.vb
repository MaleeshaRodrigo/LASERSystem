Imports MySqlConnector
Imports System.ComponentModel

Public Class ControlLogin
    Public Event LoginEvent(Success As Boolean, User As Dictionary(Of String, Object))

    Private Db As Database
    Private UserController As New UserController
    Private OtpCode As String

    Public Sub Init(Db As Database)
        Me.Db = Db
        UserController.SetDatabase(Db)
        ComboBoxDropDown(Db, cmbUserName, "SELECT UserName FROM `User` GROUP BY UserName")
        cmbUserName.Focus()
        cmbUserName.Text = UserController.GetLastLoggedUser()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If cmbUserName.Text = "" Then
            ErrorProviderPassword.SetError(cmbUserName, "User Name එක හිස්ව පවතියි.")
            Exit Sub
        Else
            ErrorProviderPassword.SetError(cmbUserName, "")
        End If

        If txtPassword.Text = "" Then
            ErrorProviderPassword.SetError(txtPassword, "Password එක හිස්ව පවතියි.")
            Exit Sub
        Else
            ErrorProviderPassword.SetError(txtPassword, "")
        End If

        Dim User As Dictionary(Of String, Object) = UserController.CheckLogin(cmbUserName.Text, txtPassword.Text)
        RaiseEvent LoginEvent(User IsNot Nothing, User)
    End Sub

    Private Sub cmdGetOTP_Click(sender As Object, e As EventArgs) Handles cmdGetOTP.Click
        If String.IsNullOrWhiteSpace(txtOTPUserName.Text) Then
            ErrorProviderOtp.SetError(txtOTPUserName, "කරුණාකර User Name එක ඇතුලත් කර නැවත උත්සහ කරන්න.")
            Exit Sub
        Else
            ErrorProviderOtp.SetError(txtOTPUserName, "")
        End If

        Dim DR = Db.GetDataDictionary("Select UserName, Email from `User` Where UserName='" & txtOTPUserName.Text & "'")
        If DR Is Nothing Then
            ErrorProviderOtp.SetError(txtOTPUserName, "ඔබ ඇතුලත් කල User Name එක වැරදි කරුණාකර නිවැරදි User Name එක ඇතුලත් කරන්න.")
            Exit Sub
        ElseIf DR IsNot Nothing & DR("Email").ToString = "" Then
            ErrorProviderOtp.SetError(txtOTPUserName, "මෙම User සඳහා  Email ලිපිනයක් ඇතුලත් කර නොමැත. Email ලිපිනයක් සහිත User Name එකක් ඇතුලත් කරන්න.")
            Exit Sub
        Else
            ErrorProviderOtp.SetError(txtOTPUserName, "")
            Dim sPrefix As String = ""
            Dim rdm As New Random()
            For i As Integer = 1 To 5
                sPrefix &= ChrW(rdm.Next(65, 90))
            Next
            Db.Execute($"INSERT INTO Mail(MailDate,EmailTo,Subject,Body,Status) Values(@MAILDATE, @EMAIL, @SUBJECT, @BODY, @STATUS);", {
                New MySqlParameter("MAILDATE", Now),
                New MySqlParameter("EMAIL", DR("Email").ToString),
                New MySqlParameter("SUBJECT", "New Signed in Detected from your LASER System account"),
                New MySqlParameter("BODY", $"Please use the following security code for the LASER System account {txtOTPUserName.Text}." + vbCrLf + vbCrLf +
                    "Security code: " + sPrefix),
                New MySqlParameter("STATUS", "Waiting")
            })
            OtpCode = sPrefix
        End If
    End Sub

    Private Sub cmdOTPLogin_Click(sender As Object, e As EventArgs) Handles cmdOTPLogin.Click
        If txtOTPUserName.Text = "" Then
            ErrorProviderPassword.SetError(txtPassword, "කරුණාකර User Name එක ඇතුලත් කර නැවත උත්සහ කරන්න.")
            Exit Sub
        Else
            ErrorProviderPassword.SetError(txtPassword, "")
        End If

        If txtOTPCode.Text = "" Then
            ErrorProviderPassword.SetError(txtPassword, "කරුණාකර OTP Code එක ඇතුලත් කර නැවත උත්සහ කරන්න.")
            Exit Sub
        Else
            ErrorProviderPassword.SetError(txtPassword, "")
        End If

        Dim User = UserController.GetUser(txtOTPUserName.Text)
        RaiseEvent LoginEvent(txtOTPCode.Text = OtpCode, User)
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedTab.TabIndex = 0 Then
            AcceptButton = cmdLogin
            cmbUserName.Focus()
        Else
            AcceptButton = cmdOTPLogin
            txtOTPUserName.Focus()
        End If
    End Sub
End Class
