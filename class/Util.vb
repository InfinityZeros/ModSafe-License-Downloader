Imports System.Text.RegularExpressions

Public Class Util
    Public Shared Function StringToByteArray(ByVal str As String) As Byte()
        Return Text.Encoding.UTF8.GetBytes(str)
    End Function

    Public Shared Function MakeValidFileName(ByVal email As String) As String
        ' Substitui caracteres inválidos por um sublinhado
        Dim invalidChars As String = New String(System.IO.Path.GetInvalidFileNameChars())
        Dim regex As New Regex("[" & Regex.Escape(invalidChars) & "]")
        Dim validFileName As String = regex.Replace(email, "_")

        ' Adicionalmente, você pode querer substituir caracteres específicos
        validFileName = validFileName.Replace("@", "_at_").Replace(".", "_dot_")

        Return validFileName
    End Function

End Class
