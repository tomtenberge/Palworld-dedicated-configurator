Imports System.Globalization
Imports System.IO
Imports System.Security.Policy

Public Class Form1
    Dim config As New PalworldOptionSettings()
    Dim config_old As New PalworldOptionSettings()
    Dim filething As New FolderBrowserDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tt As New ToolTip
        tt.SetToolTip(Label1, "Sets the name on the server browser list.")
        tt.SetToolTip(Label2, "Display a brief summary of what players can expect from your server on the in-game server list.")
        tt.SetToolTip(Label3, "The password used by admins to grant themselves admin permissions in-game.")
        tt.SetToolTip(Label4, "Sets a password to connect to your server.")
        tt.SetToolTip(Label5, "Sets the port to connect to your server.")
        tt.SetToolTip(Label6, "Sets the public IP to connect to your server.")
        tt.SetToolTip(Label7, "enables or disables the remote admin terminal.")
        tt.SetToolTip(Label8, "Sets the port to connect to the remote admin terminal.")
        tt.SetToolTip(Label9, "Sets if the Server uses authentication.")
        tt.SetToolTip(Label10, "Sets the url to the list of banned steamids")
        tt.SetToolTip(Label11, "Sets the region of the server")
    End Sub
    Sub LoadConfigFromFile(filePath As String)

        ' Check if the file exists
        If File.Exists(filePath) Then
            Try
                ' Read all lines from the file
                Dim lines As String() = File.ReadAllLines(filePath)

                ' Iterate through each line
                For Each line As String In lines
                    ' Check if the line contains "OptionSettings"
                    If line.Contains("OptionSettings") Then
                        ' Extract the content inside the parentheses
                        Dim contentStartIndex As Integer = line.IndexOf("(") + 1
                        Dim contentEndIndex As Integer = line.IndexOf(")")
                        Dim content As String = line.Substring(contentStartIndex, contentEndIndex - contentStartIndex)

                        ' Remove quotation marks from content
                        content = content.Replace("""", String.Empty)

                        ' Split the content into key-value pairs
                        Dim pairs As String() = content.Split(","c)

                        ' Iterate through each pair
                        For Each pair As String In pairs
                            ' Split each pair into key and value
                            Dim keyValue As String() = pair.Split("="c)
                            If keyValue.Length = 2 Then
                                ' Trim whitespaces
                                Dim key As String = keyValue(0).Trim()
                                Dim value As String = keyValue(1).Trim()

                                ' Special case for Difficulty
                                If key = "Difficulty" Then
                                    config.Difficulty = If(value.Equals("None", StringComparison.OrdinalIgnoreCase), Nothing, value)
                                Else
                                    ' Use reflection to set the property value dynamically
                                    Dim propertyInfo = config.GetType().GetProperty(key)
                                    If propertyInfo IsNot Nothing Then
                                        ' Convert the value to the appropriate data type
                                        Dim convertedValue As Object = ConvertValue(propertyInfo.PropertyType, value)

                                        ' Set the property value
                                        propertyInfo.SetValue(config, convertedValue)
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next

            Catch ex As Exception
                Console.WriteLine("Error reading the file: " & ex.Message)
            End Try
        Else
            Console.WriteLine("File not found: " & filePath)
        End If
    End Sub

    Sub SaveConfigToFile(filePath As String, config As PalworldOptionSettings)
        ' Create a StringBuilder to build the content of the file
        Dim contentBuilder As New Text.StringBuilder()

        ' Add header comments
        contentBuilder.AppendLine("; This configuration file is a sample of the default server settings.")
        contentBuilder.AppendLine("; Changes to this file will NOT be reflected on the server.")
        contentBuilder.AppendLine("; To change the server settings, modify Pal/Saved/Config/WindowsServer/PalWorldSettings.ini.")
        contentBuilder.AppendLine("[/Script/Pal.PalGameWorldSettings]")

        ' Add OptionSettings
        contentBuilder.Append("OptionSettings=(")

        ' Iterate through each property and append key-value pairs
        For Each propertyInfo As Reflection.PropertyInfo In config.GetType().GetProperties()
            Dim key As String = propertyInfo.Name
            Dim value As String = ConvertValueToString(propertyInfo.GetValue(config))

            ' Special case for Difficulty
            If key = "Difficulty" Then
                ' If Difficulty is Nothing, don't add quotation marks
                If config.Difficulty Is Nothing Then
                    contentBuilder.Append($"{key}=None,")
                Else
                    contentBuilder.Append($"{key}=""{value}"",")
                End If
            Else
                ' Add the key-value pair with or without quotation marks
                If TypeOf propertyInfo.GetValue(config) Is String Then
                    contentBuilder.Append($"{key}=""{value}"",")
                Else
                    contentBuilder.Append($"{key}={value},")
                End If
            End If
        Next

        ' Remove the trailing comma and close the OptionSettings
        contentBuilder.Length -= 1 ' Remove the trailing comma
        contentBuilder.AppendLine(")")

        ' Write the content to the file
        Try
            File.WriteAllText(filePath, contentBuilder.ToString())
            Console.WriteLine("Configuration saved to file: " & filePath)
        Catch ex As Exception
            Console.WriteLine("Error writing to the file: " & ex.Message)
        End Try
    End Sub

    Function ConvertFloatToString(value As Object) As String
        ' Convert floating-point numbers to a formatted string
        If TypeOf value Is Double Then
            ' Use format to include trailing zeros
            Return DirectCast(value, Double).ToString("0.000000", Globalization.CultureInfo.InvariantCulture)
        Else
            ' For other types, use the default conversion
            Return Convert.ToString(value, Globalization.CultureInfo.InvariantCulture)
        End If
    End Function

    Function ConvertValue(targetType As Type, value As String) As Object
        ' Convert the value to the appropriate data type
        If targetType = GetType(Double) Then
            ' Use InvariantCulture for double conversion
            Return Double.Parse(value, CultureInfo.InvariantCulture)
        Else
            ' For other types, use the default conversion
            Return Convert.ChangeType(value, targetType)
        End If
    End Function
    Function ConvertValueToString(value As Object) As String
        ' Convert values to strings, formatting floating-point numbers with the desired precision
        If TypeOf value Is Double Then
            ' Use format to include trailing zeros
            Return DirectCast(value, Double).ToString("0.000000", Globalization.CultureInfo.InvariantCulture)
        Else
            ' For other types, use the default conversion
            Return Convert.ToString(value, Globalization.CultureInfo.InvariantCulture)
        End If
    End Function

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        filething.UseDescriptionForTitle = True
        filething.Description = "Please select your configuration folder"
        filething.ShowDialog()
        If filething.SelectedPath = "" Then
            Exit Sub
        Else
            LoadConfigFromFile(filething.SelectedPath + "\DefaultPalWorldSettings.ini")
            Showsettings()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If filething.SelectedPath = "" Then
            Exit Sub
        Else
            Getsettings()
            SaveConfigToFile(filething.SelectedPath + "\DefaultPalWorldSettings.bak", config_old)
            SaveConfigToFile(filething.SelectedPath + "\DefaultPalWorldSettings.ini", config)
            MsgBox("File Saved.", MsgBoxStyle.OkOnly, "File Saved.")
        End If
    End Sub
    Private Sub DecimalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_DropItemAliveMaxHours.KeyPress, T_AutoResetGuildTimeNoOnlinePlayers.KeyPress, T_PalEggDefaultHatchingTime.KeyPress, T_WorkSpeedRate.KeyPress, T_BuildObjectDamageRate.KeyPress, T_BuildObjectDeteriorationDamageRate.KeyPress, T_CollectionDropRate.KeyPress, T_CollectionObjectHpRate.KeyPress, T_CollectionObjectRespawnSpeedRate.KeyPress, T_EnemyDropItemRate.KeyPress, T_PalStomachDecreaceRate.KeyPress, T_PalStaminaDecreaceRate.KeyPress, T_PalAutoHPRegeneRate.KeyPress, T_PalAutoHpRegeneRateInSleep.KeyPress, T_PalDamageRateAttack.KeyPress, T_PalDamageRateDefence.KeyPress, T_PlayerDamageRateAttack.KeyPress, T_PlayerDamageRateDefance.KeyPress, T_PlayerStomachDecreaceRate.KeyPress, T_PlayerStaminaDecreaceRate.KeyPress, T_PlayerAutoHPRegeneRate.KeyPress, T_PlayerAutoHpRegeneRateInSleep.KeyPress, T_DayTimeSpeedRate.KeyPress, T_NightTimeSpeedRate.KeyPress, T_ExpRate.KeyPress, T_PalCaptureRate.KeyPress, T_PalSpawnNumRate.KeyPress
        ' Allow digits, decimal point, Backspace, and Delete keys
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso (TryCast(sender, TextBox).Text.Contains(".") OrElse TryCast(sender, TextBox).SelectionStart = 0) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Showsettings()
        'server part
        T_ServerName.Text = config.ServerName
        T_ServerDescription.Text = config.ServerDescription
        T_AdminPassword.Text = config.AdminPassword
        T_ServerPassword.Text = config.ServerPassword
        T_PublicPort.Value = config.PublicPort
        T_PublicIP.Text = config.PublicIP
        C_RCONEnabled.Checked = config.RCONEnabled
        T_RCONPort.Value = config.RCONPort
        T_Region.Text = config.Region
        C_bUseAuth.Checked = config.bUseAuth
        T_BanListURL.Text = config.BanListURL
        'multiplayer part
        C_IsMultiplay.Checked = config.bIsMultiplay
        C_IsPvP.Checked = config.bIsPvP
        C_CanPickupOtherGuildDeathPenaltyDrop.Checked = config.bCanPickupOtherGuildDeathPenaltyDrop
        C_EnableNonLoginPenalty.Checked = config.bEnableNonLoginPenalty
        C_EnableFastTravel.Checked = config.bEnableFastTravel
        C_IsStartLovationSelectByMap.Checked = config.bIsStartLocationSelectByMap
        C_ExistPlayerAfterLogout.Checked = config.bExistPlayerAfterLogout
        C_EnableDefenseOtherGuildPlayer.Checked = config.bEnableDefenseOtherGuildPlayer
        T_CoopPlayerMaxNum.Value = config.CoopPlayerMaxNum
        T_ServerPlayerMaxnum.Value = config.ServerPlayerMaxNum
        'Limits and numbers
        N_DropItemMaxNum.Value = config.DropItemMaxNum
        N_DropItemMaxNum_UNKO.Value = config.DropItemMaxNum_UNKO
        N_BaseCampMaxNum.Value = config.BaseCampMaxNum
        N_BaseCampWorkersNaxNum.Value = config.BaseCampWorkerMaxNum
        T_DropItemAliveMaxHours.Text = config.DropItemAliveMaxHours
        C_AutoResetGuildNoOnlinePlayers.Checked = config.bAutoResetGuildNoOnlinePlayers
        T_AutoResetGuildTimeNoOnlinePlayers.Text = config.AutoResetGuildTimeNoOnlinePlayers
        N_GuildPlayerMaxNum.Value = config.GuildPlayerMaxNum
        T_PalEggDefaultHatchingTime.Text = config.PalEggDefaultHatchingTime
        T_WorkSpeedRate.Text = config.WorkSpeedRate
        'death and penalty settings
        CO_DeathPenalty.Text = config.DeathPenalty
        C_EnablePlayerToPlayerDamage.Checked = config.bEnablePlayerToPlayerDamage
        C_EnableFriendlyFire.Checked = config.bEnableFriendlyFire
        C_EnableInvadersEnemy.Checked = config.bEnableInvaderEnemy
        C_ActiveUNKO.Checked = config.bActiveUNKO
        C_EnableAimAssistPad.Checked = config.bEnableAimAssistPad
        C_EnableAimAssistKeyboard.Checked = config.bEnableAimAssistKeyboard
        'Object and collection settings
        T_BuildObjectDamageRate.Text = config.BuildObjectDamageRate
        T_BuildObjectDeteriorationDamageRate.Text = config.BuildObjectDeteriorationDamageRate
        T_CollectionDropRate.Text = config.CollectionDropRate
        T_CollectionObjectHpRate.Text = config.CollectionObjectHpRate
        T_CollectionObjectRespawnSpeedRate.Text = config.CollectionObjectRespawnSpeedRate
        T_EnemyDropItemRate.Text = config.EnemyDropItemRate
        'Pal Settings
        T_PalStomachDecreaceRate.Text = config.PalStomachDecreaceRate
        T_PalStaminaDecreaceRate.Text = config.PalStaminaDecreaceRate
        T_PalAutoHPRegeneRate.Text = config.PalAutoHPRegeneRate
        T_PalAutoHpRegeneRateInSleep.Text = config.PalAutoHpRegeneRateInSleep
        T_PalDamageRateAttack.Text = config.PalDamageRateAttack
        T_PalDamageRateDefence.Text = config.PalDamageRateDefense
        'player setttings
        T_PlayerDamageRateAttack.Text = config.PlayerDamageRateAttack
        T_PlayerDamageRateDefance.Text = config.PlayerDamageRateDefense
        T_PlayerStomachDecreaceRate.Text = config.PlayerStomachDecreaceRate
        T_PlayerStaminaDecreaceRate.Text = config.PlayerStaminaDecreaceRate
        T_PlayerAutoHPRegeneRate.Text = config.PlayerAutoHPRegeneRate
        T_PlayerAutoHpRegeneRateInSleep.Text = config.PlayerAutoHpRegeneRateInSleep
        'General settings
        If config.Difficulty = Nothing Then
            CO_Difficulty.Text = "None"
        Else
            CO_Difficulty.Text = "ERROR"
        End If
        T_DayTimeSpeedRate.Text = config.DayTimeSpeedRate
        T_NightTimeSpeedRate.Text = config.NightTimeSpeedRate
        T_ExpRate.Text = config.ExpRate
        T_PalCaptureRate.Text = config.PalCaptureRate
        T_PalSpawnNumRate.Text = config.PalSpawnNumRate
    End Sub
    Private Sub Getsettings()
        'server part
        config.ServerName = T_ServerName.Text
        config.ServerDescription = T_ServerDescription.Text
        config.AdminPassword = T_AdminPassword.Text
        config.ServerPassword = T_ServerPassword.Text
        config.PublicPort = T_PublicPort.Value
        config.PublicIP = T_PublicIP.Text
        config.RCONEnabled = C_RCONEnabled.Checked
        config.RCONPort = T_RCONPort.Value
        config.Region = T_Region.Text
        config.bUseAuth = C_bUseAuth.Checked
        config.BanListURL = T_BanListURL.Text
        'Multiplayer part
        config.bIsMultiplay = C_IsMultiplay.Checked
        config.bIsPvP = C_IsPvP.Checked
        config.bCanPickupOtherGuildDeathPenaltyDrop = C_CanPickupOtherGuildDeathPenaltyDrop.Checked
        config.bEnableNonLoginPenalty = C_EnableNonLoginPenalty.Checked
        config.bEnableFastTravel = C_EnableFastTravel.Checked
        config.bIsStartLocationSelectByMap = C_IsStartLovationSelectByMap.Checked
        config.bExistPlayerAfterLogout = C_ExistPlayerAfterLogout.Checked
        config.bEnableDefenseOtherGuildPlayer = C_EnableDefenseOtherGuildPlayer.Checked
        config.CoopPlayerMaxNum = T_CoopPlayerMaxNum.Value
        config.ServerPlayerMaxNum = T_ServerPlayerMaxnum.Value
        'Limits and numbers
        config.DropItemMaxNum = N_DropItemMaxNum.Value
        config.DropItemMaxNum_UNKO = N_DropItemMaxNum_UNKO.Value
        config.BaseCampMaxNum = N_BaseCampMaxNum.Value
        config.BaseCampWorkerMaxNum = N_BaseCampWorkersNaxNum.Value
        config.DropItemAliveMaxHours = T_DropItemAliveMaxHours.Text
        config.bAutoResetGuildNoOnlinePlayers = C_AutoResetGuildNoOnlinePlayers.Checked
        config.AutoResetGuildTimeNoOnlinePlayers = T_AutoResetGuildTimeNoOnlinePlayers.Text
        config.GuildPlayerMaxNum = N_GuildPlayerMaxNum.Value
        config.PalEggDefaultHatchingTime = T_PalEggDefaultHatchingTime.Text
        config.WorkSpeedRate = T_WorkSpeedRate.Text
        'death and penalty settings
        config.DeathPenalty = CO_DeathPenalty.Text
        config.bEnablePlayerToPlayerDamage = C_EnablePlayerToPlayerDamage.Checked
        config.bEnableFriendlyFire = C_EnableFriendlyFire.Checked
        config.bEnableInvaderEnemy = C_EnableInvadersEnemy.Checked
        config.bActiveUNKO = C_ActiveUNKO.Checked
        config.bEnableAimAssistPad = C_EnableAimAssistPad.Checked
        config.bEnableAimAssistKeyboard = C_EnableAimAssistKeyboard.Checked
        'Object and collection settings
        config.BuildObjectDamageRate = T_BuildObjectDamageRate.Text
        config.BuildObjectDeteriorationDamageRate = T_BuildObjectDeteriorationDamageRate.Text
        config.CollectionDropRate = T_CollectionDropRate.Text
        config.CollectionObjectHpRate = T_CollectionObjectHpRate.Text
        config.CollectionObjectRespawnSpeedRate = T_CollectionObjectRespawnSpeedRate.Text
        config.EnemyDropItemRate = T_EnemyDropItemRate.Text
        'Pal Settings
        config.PalStomachDecreaceRate = T_PalStomachDecreaceRate.Text
        config.PalStaminaDecreaceRate = T_PalStaminaDecreaceRate.Text
        config.PalAutoHPRegeneRate = T_PalAutoHPRegeneRate.Text
        config.PalAutoHpRegeneRateInSleep = T_PalAutoHpRegeneRateInSleep.Text
        config.PalDamageRateAttack = T_PalDamageRateAttack.Text
        config.PalDamageRateDefense = T_PalDamageRateDefence.Text
        'player setttings
        config.PlayerDamageRateAttack = T_PlayerDamageRateAttack.Text
        config.PlayerDamageRateDefense = T_PlayerDamageRateDefance.Text
        config.PlayerStomachDecreaceRate = T_PlayerStomachDecreaceRate.Text
        config.PlayerStaminaDecreaceRate = T_PlayerStaminaDecreaceRate.Text
        config.PlayerAutoHPRegeneRate = T_PlayerAutoHPRegeneRate.Text
        config.PlayerAutoHpRegeneRateInSleep = T_PlayerAutoHpRegeneRateInSleep.Text
        'General settings
        If config.Difficulty = "None" Then
            config.Difficulty = Nothing
        Else
            config.Difficulty = Nothing
        End If
        config.DayTimeSpeedRate = T_DayTimeSpeedRate.Text
        config.NightTimeSpeedRate = T_NightTimeSpeedRate.Text
        config.ExpRate = T_ExpRate.Text
        config.PalCaptureRate = T_PalCaptureRate.Text
        config.PalSpawnNumRate = T_PalSpawnNumRate.Text
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            ' Start the default web browser with the specified URL
            Process.Start("https://github.com/tomtenberge/Palworld-dedicated-configurator")
        Catch ex As Exception
            ' Handle any exceptions, such as the default browser not being found
            MessageBox.Show("Error opening webpage: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
