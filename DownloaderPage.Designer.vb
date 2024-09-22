<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DownloaderPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TitleLabel = New Label()
        GroupBox1 = New GroupBox()
        LabelATSFolderMsg = New Label()
        TextBoxATSFolder = New TextBox()
        ButtonSelectATSFolder = New Button()
        LinkLabel1 = New LinkLabel()
        GroupBoxSteamNumber = New GroupBox()
        LabelSteamIDMsg = New Label()
        TextBoxSteamID = New TextBox()
        GroupBox3 = New GroupBox()
        ListBoxModders = New ListBox()
        LabelPass = New Label()
        LabelEmail = New Label()
        TextBoxPass = New TextBox()
        TextBoxEmail = New TextBox()
        LabelVersion = New Label()
        LinkDownloaderSource = New LinkLabel()
        ButtonInstall = New Button()
        GroupBox1.SuspendLayout()
        GroupBoxSteamNumber.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TitleLabel.Location = New Point(12, 9)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(331, 31)
        TitleLabel.TabIndex = 0
        TitleLabel.Text = "ModSafe License Downloader"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(LabelATSFolderMsg)
        GroupBox1.Controls.Add(TextBoxATSFolder)
        GroupBox1.Controls.Add(ButtonSelectATSFolder)
        GroupBox1.Location = New Point(21, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(767, 89)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "ATS Folder"
        ' 
        ' LabelATSFolderMsg
        ' 
        LabelATSFolderMsg.AutoSize = True
        LabelATSFolderMsg.ForeColor = Color.Blue
        LabelATSFolderMsg.Location = New Point(17, 56)
        LabelATSFolderMsg.Name = "LabelATSFolderMsg"
        LabelATSFolderMsg.Size = New Size(175, 20)
        LabelATSFolderMsg.TabIndex = 7
        LabelATSFolderMsg.Text = "Select ATS Folder to start"
        ' 
        ' TextBoxATSFolder
        ' 
        TextBoxATSFolder.Location = New Point(17, 26)
        TextBoxATSFolder.Name = "TextBoxATSFolder"
        TextBoxATSFolder.Size = New Size(501, 27)
        TextBoxATSFolder.TabIndex = 1
        ' 
        ' ButtonSelectATSFolder
        ' 
        ButtonSelectATSFolder.Location = New Point(534, 22)
        ButtonSelectATSFolder.Name = "ButtonSelectATSFolder"
        ButtonSelectATSFolder.Size = New Size(218, 34)
        ButtonSelectATSFolder.TabIndex = 6
        ButtonSelectATSFolder.Text = "Select ATS Folder"
        ButtonSelectATSFolder.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(667, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(121, 20)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "YouTube Tutorial"
        ' 
        ' GroupBoxSteamNumber
        ' 
        GroupBoxSteamNumber.BackColor = SystemColors.Control
        GroupBoxSteamNumber.Controls.Add(LabelSteamIDMsg)
        GroupBoxSteamNumber.Controls.Add(TextBoxSteamID)
        GroupBoxSteamNumber.Location = New Point(21, 160)
        GroupBoxSteamNumber.Name = "GroupBoxSteamNumber"
        GroupBoxSteamNumber.Size = New Size(268, 88)
        GroupBoxSteamNumber.TabIndex = 12
        GroupBoxSteamNumber.TabStop = False
        GroupBoxSteamNumber.Text = "SteamNumber"
        ' 
        ' LabelSteamIDMsg
        ' 
        LabelSteamIDMsg.AutoSize = True
        LabelSteamIDMsg.ForeColor = Color.Blue
        LabelSteamIDMsg.Location = New Point(17, 56)
        LabelSteamIDMsg.Name = "LabelSteamIDMsg"
        LabelSteamIDMsg.Size = New Size(229, 20)
        LabelSteamIDMsg.TabIndex = 8
        LabelSteamIDMsg.Text = "Insert your SteamNumber to start"
        ' 
        ' TextBoxSteamID
        ' 
        TextBoxSteamID.Location = New Point(17, 26)
        TextBoxSteamID.Name = "TextBoxSteamID"
        TextBoxSteamID.Size = New Size(229, 27)
        TextBoxSteamID.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Control
        GroupBox3.Controls.Add(ListBoxModders)
        GroupBox3.Controls.Add(LabelPass)
        GroupBox3.Controls.Add(LabelEmail)
        GroupBox3.Controls.Add(TextBoxPass)
        GroupBox3.Controls.Add(TextBoxEmail)
        GroupBox3.Location = New Point(21, 265)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(595, 170)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Login"
        ' 
        ' ListBoxModders
        ' 
        ListBoxModders.FormattingEnabled = True
        ListBoxModders.Location = New Point(17, 29)
        ListBoxModders.Name = "ListBoxModders"
        ListBoxModders.Size = New Size(199, 124)
        ListBoxModders.TabIndex = 4
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Location = New Point(254, 100)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(70, 20)
        LabelPass.TabIndex = 3
        LabelPass.Text = "Password"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(254, 29)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(46, 20)
        LabelEmail.TabIndex = 2
        LabelEmail.Text = "Email"
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Location = New Point(254, 126)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.Size = New Size(311, 27)
        TextBoxPass.TabIndex = 1
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(254, 52)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(311, 27)
        TextBoxEmail.TabIndex = 0
        ' 
        ' LabelVersion
        ' 
        LabelVersion.AutoSize = True
        LabelVersion.Location = New Point(697, 517)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(91, 20)
        LabelVersion.TabIndex = 16
        LabelVersion.Text = "Version 0.0.1"
        ' 
        ' LinkDownloaderSource
        ' 
        LinkDownloaderSource.AutoSize = True
        LinkDownloaderSource.Location = New Point(21, 517)
        LinkDownloaderSource.Name = "LinkDownloaderSource"
        LinkDownloaderSource.Size = New Size(253, 20)
        LinkDownloaderSource.TabIndex = 15
        LinkDownloaderSource.TabStop = True
        LinkDownloaderSource.Text = "License Downloader Source - GitHub"
        ' 
        ' ButtonInstall
        ' 
        ButtonInstall.Enabled = False
        ButtonInstall.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonInstall.Location = New Point(21, 462)
        ButtonInstall.Name = "ButtonInstall"
        ButtonInstall.Size = New Size(767, 52)
        ButtonInstall.TabIndex = 14
        ButtonInstall.Text = "Install Plugin and License"
        ButtonInstall.UseVisualStyleBackColor = True
        ' 
        ' DownloaderPage
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 546)
        Controls.Add(LabelVersion)
        Controls.Add(LinkDownloaderSource)
        Controls.Add(ButtonInstall)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBoxSteamNumber)
        Controls.Add(LinkLabel1)
        Controls.Add(GroupBox1)
        Controls.Add(TitleLabel)
        Enabled = False
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "DownloaderPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModSafe License Downloader"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBoxSteamNumber.ResumeLayout(False)
        GroupBoxSteamNumber.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelATSFolderMsg As Label
    Friend WithEvents TextBoxATSFolder As TextBox
    Friend WithEvents ButtonSelectATSFolder As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBoxSteamNumber As GroupBox
    Friend WithEvents LabelSteamIDMsg As Label
    Friend WithEvents TextBoxSteamID As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBoxModders As ListBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LinkDownloaderSource As LinkLabel
    Friend WithEvents ButtonInstall As Button

End Class
