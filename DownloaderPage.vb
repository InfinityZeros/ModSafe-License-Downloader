Public Class DownloaderPage
    Dim atsFolderValid = False
    Dim steamIdValid = False

    Private Sub ReprocessInstallValid()
        ButtonInstall.Enabled = atsFolderValid AndAlso
                            steamIdValid AndAlso
                            ListBoxModders.SelectedIndex >= 0 AndAlso
                            TextBoxEmail.Text.Length >= 10 AndAlso
                            TextBoxPass.Text.Length >= 6
    End Sub

    Private Sub SetATSFolderMsg(msg As String, good As Boolean)
        atsFolderValid = good
        ReprocessInstallValid()
        LabelATSFolderMsg.Text = msg
        LabelATSFolderMsg.ForeColor = If(good, Color.Green, Color.Red)
    End Sub

    Private Sub SetSteamIDMsg(msg As String, good As Boolean)
        steamIdValid = good
        ReprocessInstallValid()
        LabelSteamIDMsg.Text = msg
        LabelSteamIDMsg.ForeColor = If(good, Color.Green, Color.Red)
    End Sub

    Private Async Sub DownloaderPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelVersion.Text = "Version " + Config.LocalVersion

        Try
            TextBoxSteamID.Text = Steam.GetSteamID64()
            SetSteamIDMsg("SteamNumber found!", True)
        Catch ex As Exception
            SetSteamIDMsg(ex.Message, False)
        End Try
        Try
            TextBoxATSFolder.Text = GameInstallation.FindDefaultGameLog()
            SetATSFolderMsg("ATS installation path found!", True)
        Catch ex As Exception
            SetATSFolderMsg(ex.Message, False)
        End Try

        Try
            Await Communication.FirstStatusRequest()
        Catch ex As Exception
            MsgBox("Cannot get basic Status, exiting, error: " + ex.Message)
            'Close()
        End Try

        ListBoxModders.Items.Add("KswMods")
        ListBoxModders.Items.Add("PingaMods")

        Enabled = True
    End Sub

    Private Sub TextBoxSteamID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSteamID.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub ButtonSelectATSFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectATSFolder.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "game.log.txt ATS file|game.log.txt"
            openFileDialog.Title = "Select Game Log File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Try
                    Dim parsedGameLog = GameInstallation.ParseAndValidateGameLog(filePath)
                    SetATSFolderMsg("Found ATS instalation path!", True)
                Catch ex As Exception
                    SetATSFolderMsg(ex.Message, False)
                    MsgBox("Arquivo inválido. Por favor, selecione um arquivo de log válido.")
                End Try
            End If
        End Using
    End Sub

    Private Async Sub ButtonInstall_Click(sender As Object, e As EventArgs) Handles ButtonInstall.Click
        Try
            Await LicenseManager.RequestAndWriteLicense(
                TextBoxEmail.Text,
                TextBoxPass.Text,
                TextBoxSteamID.Text,
                TextBoxATSFolder.Text,
                ListBoxModders.SelectedItem
            )
            LicenseManager.EnsureAndWritePluginFiles(TextBoxATSFolder.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxSteamID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSteamID.TextChanged
        Try
            Steam.ValidateSteamID(TextBoxSteamID.Text)
            SetSteamIDMsg("SteamNumber looks valid!", True)
        Catch ex As Exception
            SetSteamIDMsg(ex.Message, False)
        End Try
    End Sub

    Private Sub TextBoxATSFolder_TextChanged(sender As Object, e As EventArgs) Handles TextBoxATSFolder.TextChanged
        Try
            GameInstallation.ValidatePathATS(TextBoxATSFolder.Text)
            SetATSFolderMsg("Valid ATS path!", True)
        Catch ex As Exception
            SetATSFolderMsg(ex.Message, False)
        End Try
    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged
        ReprocessInstallValid()
    End Sub

    Private Sub TextBoxPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged
        ReprocessInstallValid()
    End Sub

    Private Sub ListBoxModders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxModders.SelectedIndexChanged
        ReprocessInstallValid()
    End Sub
End Class