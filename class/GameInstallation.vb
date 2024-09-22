Imports System.IO
Imports System.Text.RegularExpressions

Public Class GameInstallation
    Public Shared Function ParseGameLog(filePath As String) As String
        If Not File.Exists(filePath) Then
            Throw New Exception("Invalid game.log path")
        End If

        Dim logContent As String = File.ReadAllText(filePath) 'TODO: limit 4k read size
        Dim regex As New Regex("Command line:\s*(.+?)(\\bin\\win_x64\\amtrucks.exe)", RegexOptions.IgnoreCase)
        Dim match As Match = regex.Match(logContent)

        If match.Success Then
            Return match.Groups(1).Value.Trim()
        Else
            Throw New Exception("Cannot auto find ATS installation path")
        End If
    End Function

    Public Shared Sub ValidatePathATS(atsPath As String)
        Dim amPath As String = Path.Combine(atsPath, "bin\win_x64\amtrucks.exe")
        If Not File.Exists(amPath) Then
            Throw New Exception("Cannot find ATS executable")
        End If
    End Sub

    Public Shared Function ParseAndValidateGameLog(gameLogPath As String) As String
        If Not File.Exists(gameLogPath) Then
            Throw New Exception("Game.log not exists")
        End If
        Dim atsPath = ParseGameLog(gameLogPath)
        ValidatePathATS(atsPath)
        Return atsPath
    End Function

    Public Shared Function FindDefaultGameLog() As String
        Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim gameLogPath As String = Path.Combine(documentsPath, "American Truck Simulator", "game.log.txt")
        Return ParseAndValidateGameLog(gameLogPath)
    End Function
End Class