﻿Imports System.Security.Cryptography

Public NotInheritable Class Encoder
    Private _TripleDes As New TripleDESCryptoServiceProvider

    Sub New()
        ' Initialize the crypto provider.
        Dim key = "pFlMe36hg6O&nnz^"
        _TripleDes.Key = TruncateHash(key, _TripleDes.KeySize \ 8)
        _TripleDes.IV = TruncateHash("", _TripleDes.BlockSize \ 8)
    End Sub

    Public Function Encode(txt As String) As String
        Try
            Return EncryptData(txt)
        Catch ex As CryptographicException
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Decode(cipher As String) As String
        Try
            If cipher <> "" Then
                Return DecryptData(cipher)
            Else
                Return ""
            End If
        Catch ex As CryptographicException
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Private Function EncryptData(ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array. 
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream. 
        Dim encStream As New CryptoStream(ms,
            _TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string. 


        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Private Function DecryptData(ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array. 
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream. 
        Dim decStream As New CryptoStream(ms,
            _TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string. 
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class