Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Communication

#Disable Warning IDE1006 ' Naming Styles
    Public Class ApiResponse
        Public Property [error] As String
        Public Property data As Object ' Replace with appropriate type if known
    End Class
#Enable Warning IDE1006 ' Naming Styles

    Private Const ApiBase As String = "https://modsafe.app/api/"
    Private Const ApiBaseDebug As String = "http://localhost:3006/api/"

    Private Shared ReadOnly WebClient As New HttpClient()

    Public Shared Async Function RequestBaseAsync(endpoint As String, Optional bodyVal As Dictionary(Of String, Object) = Nothing) As Task(Of Object)
        WebClient.DefaultRequestHeaders.Accept.Clear()
        WebClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage

        Dim selectedApiBase = ApiBaseDebug

        If bodyVal IsNot Nothing AndAlso bodyVal.Count > 0 Then
            Dim json As String = JsonConvert.SerializeObject(bodyVal, Formatting.Indented)
            Dim stringContent As New StringContent(json, System.Text.Encoding.UTF8, "application/json")

            response = Await WebClient.PostAsync(selectedApiBase + endpoint, stringContent)
        Else
            response = Await WebClient.GetAsync(selectedApiBase + endpoint)
        End If

        response.EnsureSuccessStatusCode()
        Dim responseBody As String = Await response.Content.ReadAsStringAsync()
        Console.WriteLine(responseBody)

        Dim parsed = JsonConvert.DeserializeObject(Of ApiResponse)(responseBody)
        If parsed.error IsNot Nothing Then
            Throw New ZException(parsed.error)
        End If

        If parsed.data Is Nothing Then
            Throw New ZException("Invalid Response Data")
        End If

        Return parsed.data

    End Function

    Public Shared Async Function FirstStatusRequest() As Task(Of Boolean)
        Dim response = Await RequestBaseAsync("status")

        If response("version") Is Nothing Then
            Throw New ZException("Invalid Status Request Version")
        End If

        Dim remoteVersion = response("version").ToString()

        If remoteVersion <> Config.LocalVersion Then
            Throw New ZException("ModSafe has a Update, please Download it in WebSite 'modsafe.app/download' Local Version: " + Config.LocalVersion + "- Latest Version: " + remoteVersion)
        End If

        Return True
    End Function

    Public Shared Async Function ModLicenseRequest(modderName As String, email As String, pass As String, steamId As ULong) As Task(Of String)
        Dim bodyVal As New Dictionary(Of String, Object) From {
            {"modderName", modderName},
            {"email", email},
            {"pass", pass},
            {"steamId", steamId},
            {"uniqueExclusiveKey", Config.UniqueExclusiveKey},
            {"version", Config.LocalVersion}
        }
        Dim response = Await RequestBaseAsync("license", bodyVal)

        If response("license") Is Nothing Then
            Throw New ZException("Invalid License")
        End If

        Dim license = response("license").ToString()

        MsgBox(license)

        Return license
    End Function
End Class