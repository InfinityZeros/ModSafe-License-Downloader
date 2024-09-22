Imports System.IO
Imports System.Reflection

Public Class LicenseManager

    Public Shared Sub WriteResourceToFile(ByVal resourceName As String, ByVal fileName As String)
        Using resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
            Using file = New FileStream(fileName, FileMode.Create, FileAccess.Write)
                resource.CopyTo(file)
            End Using
        End Using
    End Sub

    Public Shared Sub EnsureAndWritePluginFiles(installationPath As String)
        Dim destinationDirectory = Path.Combine(installationPath, "bin\\win_x64", "plugins")
        Dim modsafePath = Path.Combine(destinationDirectory, "ModSafe.dll")

        If Not Directory.Exists(destinationDirectory) Then
            Directory.CreateDirectory(destinationDirectory)
        Else
            'TODO: check if exists and version
            'If File.Exists(modsafePath) Then
            'End If
        End If

        WriteResourceToFile("ModSafe_Downloader.ModSafe DLL.dll", modsafePath)
    End Sub

    Public Shared Function GetLicenseName(email As String, modderName As String)
        Return modderName + "_" + email + ".modsafe"
    End Function
    Public Shared Sub WriteLicense(email As String, installationPath As String, license As Byte(), modderName As String)
        Dim licensePath = Path.Combine(installationPath, "bin\\win_x64", "plugins", "ModSafe License", GetLicenseName(email, modderName))

        Dim directoryPath As String = Path.GetDirectoryName(licensePath)
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If

        File.WriteAllBytes(licensePath, license)
    End Sub

    Public Shared Async Function RequestAndWriteLicense(
                                                       email As String,
                                                       pass As String,
                                                       steamId As ULong,
                                                       installationPath As String,
                                                       modderName As String
    ) As Task
        Dim license = Await Communication.ModLicenseRequest(modderName, email, pass, steamId)
        WriteLicense(email, installationPath, Util.StringToByteArray(license), modderName)
    End Function
End Class