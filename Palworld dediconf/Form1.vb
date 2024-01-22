Imports System.Globalization
Imports System.IO
Imports System.Security.Cryptography

Public Class Form1
    Dim config As New PalworldOptionSettings()
    Dim config_old As New PalworldOptionSettings()
    Dim filething As New FolderBrowserDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Getsettings
            SaveConfigToFile(filething.SelectedPath + "\DefaultPalWorldSettings.bak", config_old)
            SaveConfigToFile(filething.SelectedPath + "\DefaultPalWorldSettings.ini", config)
            MsgBox("File Saved.", MsgBoxStyle.OkOnly, "File Saved.")
        End If
    End Sub
    Private Sub Showsettings()
        T_ServerName.Text = config.ServerName
        T_ServerDescription.Text = config.ServerDescription
        T_AdminPassword.Text = config.AdminPassword
        T_ServerPassword.Text = config.ServerPassword
        T_PublicPort.Text = config.PublicPort
        T_PublicIP.Text = config.PublicIP
        If config.RCONEnabled = True Then
            C_RCONEnabled.Checked = True
        Else
            C_RCONEnabled.Checked = False
        End If
        T_RCONPort.Text = config.RCONPort
        T_Region.Text = config.Region
        If config.bUseAuth = True Then
            C_bUseAuth.Checked = True
        Else
            C_bUseAuth.Checked = False
        End If
        T_BanListURL.Text = config.BanListURL
    End Sub
    Private Sub Getsettings()
        config.ServerName = T_ServerName.Text
        config.ServerDescription = T_ServerDescription.Text
        config.AdminPassword = T_AdminPassword.Text
        config.ServerPassword = T_ServerPassword.Text
        config.PublicPort = T_PublicPort.Text
        config.PublicIP = T_PublicIP.Text
        If C_RCONEnabled.Checked = True Then
            config.RCONEnabled = True
        Else
            config.RCONEnabled = False
        End If
        config.RCONPort = T_RCONPort.Text
        config.Region = T_Region.Text
        If config.bUseAuth = True Then
            C_bUseAuth.Checked = True
        Else
            C_bUseAuth.Checked = False
        End If
        config.BanListURL = T_BanListURL.Text
    End Sub
End Class
