<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        StatusStrip1 = New StatusStrip()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoadToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        TabPage2 = New TabPage()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label12 = New Label()
        TextBox1 = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        C_bUseAuth = New CheckBox()
        C_RCONEnabled = New CheckBox()
        T_ServerName = New TextBox()
        T_ServerDescription = New TextBox()
        T_AdminPassword = New TextBox()
        T_ServerPassword = New TextBox()
        T_PublicPort = New TextBox()
        T_PublicIP = New TextBox()
        T_RCONPort = New TextBox()
        T_BanListURL = New TextBox()
        T_Region = New TextBox()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabPage2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Location = New Point(0, 648)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(987, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(987, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoadToolStripMenuItem, SaveToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LoadToolStripMenuItem
        ' 
        LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        LoadToolStripMenuItem.Size = New Size(100, 22)
        LoadToolStripMenuItem.Text = "Load"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(100, 22)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 24)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(987, 624)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TableLayoutPanel1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(979, 596)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Server Settings"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(Label4, 0, 3)
        TableLayoutPanel1.Controls.Add(Label5, 0, 4)
        TableLayoutPanel1.Controls.Add(Label6, 0, 5)
        TableLayoutPanel1.Controls.Add(Label7, 0, 6)
        TableLayoutPanel1.Controls.Add(Label8, 0, 7)
        TableLayoutPanel1.Controls.Add(Label9, 0, 8)
        TableLayoutPanel1.Controls.Add(Label10, 0, 9)
        TableLayoutPanel1.Controls.Add(Label11, 0, 10)
        TableLayoutPanel1.Controls.Add(C_bUseAuth, 1, 8)
        TableLayoutPanel1.Controls.Add(C_RCONEnabled, 1, 6)
        TableLayoutPanel1.Controls.Add(T_ServerName, 1, 0)
        TableLayoutPanel1.Controls.Add(T_ServerDescription, 1, 1)
        TableLayoutPanel1.Controls.Add(T_AdminPassword, 1, 2)
        TableLayoutPanel1.Controls.Add(T_ServerPassword, 1, 3)
        TableLayoutPanel1.Controls.Add(T_PublicPort, 1, 4)
        TableLayoutPanel1.Controls.Add(T_PublicIP, 1, 5)
        TableLayoutPanel1.Controls.Add(T_RCONPort, 1, 7)
        TableLayoutPanel1.Controls.Add(T_BanListURL, 1, 9)
        TableLayoutPanel1.Controls.Add(T_Region, 1, 10)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 12
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.Size = New Size(973, 590)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 30)
        Label1.TabIndex = 0
        Label1.Text = "ServerName"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Location = New Point(3, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 30)
        Label2.TabIndex = 2
        Label2.Text = "ServerDescription"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Location = New Point(3, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 30)
        Label3.TabIndex = 3
        Label3.Text = "AdminPassword"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Location = New Point(3, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 30)
        Label4.TabIndex = 4
        Label4.Text = "ServerPassword"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Location = New Point(3, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 30)
        Label5.TabIndex = 5
        Label5.Text = "PublicPort"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Location = New Point(3, 150)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 30)
        Label6.TabIndex = 6
        Label6.Text = "PublicIP"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Location = New Point(3, 180)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 30)
        Label7.TabIndex = 7
        Label7.Text = "RCONEnabled"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Fill
        Label8.Location = New Point(3, 210)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 30)
        Label8.TabIndex = 8
        Label8.Text = "RCONPort"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Fill
        Label9.Location = New Point(3, 240)
        Label9.Name = "Label9"
        Label9.Size = New Size(144, 30)
        Label9.TabIndex = 9
        Label9.Text = "bUseAuth"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Fill
        Label10.Location = New Point(3, 270)
        Label10.Name = "Label10"
        Label10.Size = New Size(144, 30)
        Label10.TabIndex = 10
        Label10.Text = "BanListURL"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Dock = DockStyle.Fill
        Label11.Location = New Point(3, 300)
        Label11.Name = "Label11"
        Label11.Size = New Size(144, 30)
        Label11.TabIndex = 30
        Label11.Text = "Region"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TableLayoutPanel2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(979, 596)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Multiplayer Settings"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Label12, 0, 0)
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel2.Controls.Add(Label13, 0, 1)
        TableLayoutPanel2.Controls.Add(Label14, 0, 2)
        TableLayoutPanel2.Controls.Add(Label15, 0, 3)
        TableLayoutPanel2.Controls.Add(Label16, 0, 4)
        TableLayoutPanel2.Controls.Add(Label17, 0, 5)
        TableLayoutPanel2.Controls.Add(Label18, 0, 6)
        TableLayoutPanel2.Controls.Add(Label19, 0, 7)
        TableLayoutPanel2.Controls.Add(Label20, 0, 8)
        TableLayoutPanel2.Controls.Add(Label21, 0, 9)
        TableLayoutPanel2.Controls.Add(Label22, 0, 10)
        TableLayoutPanel2.Controls.Add(TextBox2, 1, 1)
        TableLayoutPanel2.Controls.Add(TextBox3, 1, 2)
        TableLayoutPanel2.Controls.Add(TextBox4, 1, 3)
        TableLayoutPanel2.Controls.Add(TextBox5, 1, 4)
        TableLayoutPanel2.Controls.Add(TextBox6, 1, 5)
        TableLayoutPanel2.Controls.Add(TextBox7, 1, 7)
        TableLayoutPanel2.Controls.Add(TextBox8, 1, 8)
        TableLayoutPanel2.Controls.Add(TextBox9, 1, 10)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 12
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.Size = New Size(973, 590)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Fill
        Label12.Location = New Point(3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(144, 30)
        Label12.TabIndex = 0
        Label12.Text = "-"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(153, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(817, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Fill
        Label13.Location = New Point(3, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(144, 30)
        Label13.TabIndex = 2
        Label13.Text = "-"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Fill
        Label14.Location = New Point(3, 60)
        Label14.Name = "Label14"
        Label14.Size = New Size(144, 30)
        Label14.TabIndex = 3
        Label14.Text = "-"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Fill
        Label15.Location = New Point(3, 90)
        Label15.Name = "Label15"
        Label15.Size = New Size(144, 30)
        Label15.TabIndex = 4
        Label15.Text = "-"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Fill
        Label16.Location = New Point(3, 120)
        Label16.Name = "Label16"
        Label16.Size = New Size(144, 30)
        Label16.TabIndex = 5
        Label16.Text = "-"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Fill
        Label17.Location = New Point(3, 150)
        Label17.Name = "Label17"
        Label17.Size = New Size(144, 30)
        Label17.TabIndex = 6
        Label17.Text = "-"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Dock = DockStyle.Fill
        Label18.Location = New Point(3, 180)
        Label18.Name = "Label18"
        Label18.Size = New Size(144, 30)
        Label18.TabIndex = 7
        Label18.Text = "-"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Location = New Point(3, 210)
        Label19.Name = "Label19"
        Label19.Size = New Size(144, 30)
        Label19.TabIndex = 8
        Label19.Text = "-"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Dock = DockStyle.Fill
        Label20.Location = New Point(3, 240)
        Label20.Name = "Label20"
        Label20.Size = New Size(144, 30)
        Label20.TabIndex = 9
        Label20.Text = "-"
        Label20.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Dock = DockStyle.Fill
        Label21.Location = New Point(3, 270)
        Label21.Name = "Label21"
        Label21.Size = New Size(144, 30)
        Label21.TabIndex = 10
        Label21.Text = "-"
        Label21.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Dock = DockStyle.Fill
        Label22.Location = New Point(3, 300)
        Label22.Name = "Label22"
        Label22.Size = New Size(144, 30)
        Label22.TabIndex = 11
        Label22.Text = "-"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Location = New Point(153, 33)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(817, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Dock = DockStyle.Fill
        TextBox3.Location = New Point(153, 63)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(817, 23)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Dock = DockStyle.Fill
        TextBox4.Location = New Point(153, 93)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(817, 23)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Dock = DockStyle.Fill
        TextBox5.Location = New Point(153, 123)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(817, 23)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Dock = DockStyle.Fill
        TextBox6.Location = New Point(153, 153)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(817, 23)
        TextBox6.TabIndex = 16
        ' 
        ' TextBox7
        ' 
        TextBox7.Dock = DockStyle.Fill
        TextBox7.Location = New Point(153, 213)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(817, 23)
        TextBox7.TabIndex = 18
        ' 
        ' TextBox8
        ' 
        TextBox8.Dock = DockStyle.Fill
        TextBox8.Location = New Point(153, 243)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(817, 23)
        TextBox8.TabIndex = 19
        ' 
        ' TextBox9
        ' 
        TextBox9.Dock = DockStyle.Fill
        TextBox9.Location = New Point(153, 303)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(817, 23)
        TextBox9.TabIndex = 21
        ' 
        ' C_bUseAuth
        ' 
        C_bUseAuth.AutoSize = True
        C_bUseAuth.Dock = DockStyle.Fill
        C_bUseAuth.Location = New Point(153, 243)
        C_bUseAuth.Name = "C_bUseAuth"
        C_bUseAuth.Size = New Size(817, 24)
        C_bUseAuth.TabIndex = 31
        C_bUseAuth.UseVisualStyleBackColor = True
        ' 
        ' C_RCONEnabled
        ' 
        C_RCONEnabled.AutoSize = True
        C_RCONEnabled.Dock = DockStyle.Fill
        C_RCONEnabled.Location = New Point(153, 183)
        C_RCONEnabled.Name = "C_RCONEnabled"
        C_RCONEnabled.Size = New Size(817, 24)
        C_RCONEnabled.TabIndex = 32
        C_RCONEnabled.UseVisualStyleBackColor = True
        ' 
        ' T_ServerName
        ' 
        T_ServerName.Dock = DockStyle.Fill
        T_ServerName.Location = New Point(153, 3)
        T_ServerName.Name = "T_ServerName"
        T_ServerName.Size = New Size(817, 23)
        T_ServerName.TabIndex = 33
        ' 
        ' T_ServerDescription
        ' 
        T_ServerDescription.Dock = DockStyle.Fill
        T_ServerDescription.Location = New Point(153, 33)
        T_ServerDescription.Name = "T_ServerDescription"
        T_ServerDescription.Size = New Size(817, 23)
        T_ServerDescription.TabIndex = 34
        ' 
        ' T_AdminPassword
        ' 
        T_AdminPassword.Dock = DockStyle.Fill
        T_AdminPassword.Location = New Point(153, 63)
        T_AdminPassword.Name = "T_AdminPassword"
        T_AdminPassword.Size = New Size(817, 23)
        T_AdminPassword.TabIndex = 35
        ' 
        ' T_ServerPassword
        ' 
        T_ServerPassword.Dock = DockStyle.Fill
        T_ServerPassword.Location = New Point(153, 93)
        T_ServerPassword.Name = "T_ServerPassword"
        T_ServerPassword.Size = New Size(817, 23)
        T_ServerPassword.TabIndex = 36
        ' 
        ' T_PublicPort
        ' 
        T_PublicPort.Dock = DockStyle.Fill
        T_PublicPort.Location = New Point(153, 123)
        T_PublicPort.Name = "T_PublicPort"
        T_PublicPort.Size = New Size(817, 23)
        T_PublicPort.TabIndex = 37
        ' 
        ' T_PublicIP
        ' 
        T_PublicIP.Dock = DockStyle.Fill
        T_PublicIP.Location = New Point(153, 153)
        T_PublicIP.Name = "T_PublicIP"
        T_PublicIP.Size = New Size(817, 23)
        T_PublicIP.TabIndex = 38
        ' 
        ' T_RCONPort
        ' 
        T_RCONPort.Dock = DockStyle.Fill
        T_RCONPort.Location = New Point(153, 213)
        T_RCONPort.Name = "T_RCONPort"
        T_RCONPort.Size = New Size(817, 23)
        T_RCONPort.TabIndex = 39
        ' 
        ' T_BanListURL
        ' 
        T_BanListURL.Dock = DockStyle.Fill
        T_BanListURL.Location = New Point(153, 273)
        T_BanListURL.Name = "T_BanListURL"
        T_BanListURL.Size = New Size(817, 23)
        T_BanListURL.TabIndex = 40
        ' 
        ' T_Region
        ' 
        T_Region.Dock = DockStyle.Fill
        T_Region.Location = New Point(153, 303)
        T_Region.Name = "T_Region"
        T_Region.Size = New Size(817, 23)
        T_Region.TabIndex = 41
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(987, 670)
        Controls.Add(TabControl1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents C_bUseAuth As CheckBox
    Friend WithEvents C_RCONEnabled As CheckBox
    Friend WithEvents T_ServerName As TextBox
    Friend WithEvents T_ServerDescription As TextBox
    Friend WithEvents T_AdminPassword As TextBox
    Friend WithEvents T_ServerPassword As TextBox
    Friend WithEvents T_PublicPort As TextBox
    Friend WithEvents T_PublicIP As TextBox
    Friend WithEvents T_RCONPort As TextBox
    Friend WithEvents T_BanListURL As TextBox
    Friend WithEvents T_Region As TextBox

End Class
