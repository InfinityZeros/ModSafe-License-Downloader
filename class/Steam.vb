Imports Microsoft.Win32

Public Class Steam

    Private Shared Function ConvertSteamUniverse(steamUniverse As String) As Long
        Select Case steamUniverse
            Case "Public"
                Return 1
            Case "Beta"
                Return 2
            Case "Internal"
                Return 3
            Case "Dev"
                Return 4
            Case Else
                Throw New Exception("Unsuported SteamNumber")
        End Select
    End Function

    Private Shared Function ConvertToSteamID64(universe As Long, accountNumber As Long) As Long
        Return ((1 + (1 << 20) + (universe << 24)) << 32) Or accountNumber
    End Function

    Public Shared Sub ValidateSteamID(steamID64 As String)
        If Not UInt64.TryParse(steamID64, Nothing) Then
            Throw New Exception("SteamNumber must be a number")
        End If

        Dim steamID64Value = Convert.ToUInt64(steamID64)

        If steamID64Value < 76561197960265728 Then
            Throw New Exception("SteamNumber too small")
        End If

        If steamID64Value > 76561197960265728 * 2 Then
            Throw New Exception("SteamNumber too big")
        End If
    End Sub

    Public Shared Function GetSteamID64() As Long
        Dim regPath As String = "HKEY_CURRENT_USER\Software\Valve\Steam\ActiveProcess"

        Dim steamUser As String = Registry.GetValue(regPath, "ActiveUser", Nothing).ToString()
        Dim steamUniverse As String = Registry.GetValue(regPath, "Universe", Nothing).ToString()

        If String.IsNullOrEmpty(steamUser) OrElse String.IsNullOrEmpty(steamUniverse) Then
            Throw New Exception("Unsuported SteamNumber")
        End If

        Dim steamUniverseInt As Long = ConvertSteamUniverse(steamUniverse)
        Dim steamID64 As Long = ConvertToSteamID64(steamUniverseInt, steamUser)

        Return steamID64
    End Function

End Class