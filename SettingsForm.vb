Imports System.Threading

Public Class SettingsForm

    Public Enum EnumSoundOption As Integer
        DefaultSound = 1
        SystemSound = 2
        CustomSound = 3
    End Enum
    Public RegistryStartLocalMachineKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", True)
    Public SystemSoundFolder As String = "C:\Windows\Media\"
#Region "FORM"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartToolStripMenuItem.Image = My.Resources.clock_run
        StartToolStripMenuItem.Text = "Start"
        Timer1.Interval = 60000
        RunAtStartUpOption.Checked = RegistryStartLocalMachineKey.GetValue("Alarm") IsNot Nothing
        Select Case My.Settings.SoundOption
            Case EnumSoundOption.DefaultSound
                DefaultSoundOption.Checked = True
            Case EnumSoundOption.SystemSound
                SystemSoundOption.Checked = True
            Case EnumSoundOption.CustomSound
                CustomSoundOption.Checked = True
        End Select
        CustomSoundValue.Text = My.Settings.CustomSound

        Dim sidType As Type = GetType(System.Security.Principal.NTAccount)
        Dim owner As System.Security.Principal.IdentityReference
        Dim di As New IO.DirectoryInfo(SystemSoundFolder)
        Dim fi As IO.FileInfo() = di.GetFiles("*.wav")
        'Fill with ONLY System Sounds
        For Each f As IO.FileInfo In fi
            owner = DirectCast(f.GetAccessControl.GetOwner(sidType), Security.Principal.IdentityReference)
            If owner.Value = "NT AUTHORITY\SYSTEM" Then SystemSoundList.Items.Add(f.Name)
        Next
        'If empty then just add ALL items in the directory.
        If SystemSoundList.Items.Count = 0 Then
            For Each f As IO.FileInfo In fi
                SystemSoundList.Items.Add(f.Name)
            Next
        End If
        SystemSoundList.Text = My.Settings.SystemSound

        If (SystemSoundOption.Checked AndAlso SystemSoundList.Text.Trim.Length = 0) _
        OrElse (CustomSoundOption.Checked AndAlso CustomSoundValue.Text.Length = 0) Then
            DefaultSoundOption.Checked = True
        End If

        CustomMessageOption.Checked = My.Settings.UseCustomMessage
        CustomMessageValue.Text = My.Settings.CustomMessage
        CustomMessageValue.Enabled = My.Settings.UseCustomMessage
        Me.Height = Me.MinimumSize.Height

        StartTimerOption.Checked = My.Settings.StartTimer
        If My.Settings.StartTimer Then StartButton_Click(Nothing, Nothing)

    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If DirectCast(sender, Form).WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            nfi.Visible = True
            nfi.Text = "Alarm: " & MinutesLeftValue.Text & " minutes "
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        Timer1.Dispose()
    End Sub

#End Region

#Region "EVENTS"

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click

        Timer1.Tag = Integer.Parse(MinutesValue.Text)
        MinutesLeftValue.Text = Timer1.Tag
        Timer1.Start()
        StartButton.Enabled = False
        StopButton.Enabled = True

        StartToolStripMenuItem.Image = My.Resources.clock_stop
        StartToolStripMenuItem.Text = "Stop"
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        Timer1.Stop()
        MinutesLeftValue.Text = "0"
        StopButton.Enabled = False
        StartButton.Enabled = True

        StartToolStripMenuItem.Image = My.Resources.clock_run
        StartToolStripMenuItem.Text = "Start"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Tag = Timer1.Tag - 1
        MinutesLeftValue.Text = Timer1.Tag
        nfi.Text = "Alarm: " & MinutesLeftValue.Text & " minutes "
        If Timer1.Tag <= 0 Then
            'ALARM!!
            If AlarmMessage.Visible = False Then
                AlarmMessage.ShowDialog()
            End If
            ResetTimer()
        End If
    End Sub

    Private Sub nfi_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nfi.DoubleClick
        RestoreForm()
    End Sub

#End Region

#Region "MENU"

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        If StartButton.Enabled Then
            StartButton_Click(Nothing, Nothing)
        Else
            StopButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        RestoreForm()
    End Sub

    Private Sub ResetTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetTimeToolStripMenuItem.Click
        ResetTimer()
    End Sub

    Private Sub CloseAlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAlarmToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "METHODS"

    Private Sub RestoreForm()
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        nfi.Visible = False
    End Sub

    Private Sub ResetTimer()
        Timer1.Tag = Integer.Parse(MinutesValue.Text)
        MinutesLeftValue.Text = Timer1.Tag
        nfi.Text = "Alarm: " & MinutesLeftValue.Text & " minutes "
    End Sub

#End Region



#Region "OPTIONS"
    Private Sub RunAtStartUpOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunAtStartUpOption.CheckedChanged
        If RunAtStartUpOption.Checked Then
            RegistryStartLocalMachineKey.SetValue("Alarm", Application.ExecutablePath.ToString())
        Else
            RegistryStartLocalMachineKey.DeleteValue("Alarm", False)
        End If
    End Sub


#End Region

    Private Sub DefaultSoundOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultSoundOption.CheckedChanged
        If DefaultSoundOption.Checked Then
            My.Settings.SoundOption = EnumSoundOption.DefaultSound
        End If
    End Sub

    Private Sub SystemSoundOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemSoundOption.CheckedChanged
        If SystemSoundOption.Checked Then
            My.Settings.SoundOption = EnumSoundOption.SystemSound
        End If
        SystemSoundList.Enabled = SystemSoundOption.Checked
    End Sub

    Private Sub CustomSoundOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomSoundOption.CheckedChanged
        If CustomSoundOption.Checked Then
            My.Settings.SoundOption = EnumSoundOption.CustomSound
        End If
        CustomSoundValue.Enabled = CustomSoundOption.Checked
        CustomSoundButton.Enabled = CustomSoundOption.Checked
    End Sub

    Private Sub CustomSoundButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomSoundButton.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Try
            openFileDialog1.InitialDirectory = SystemSoundFolder
            openFileDialog1.Filter = "Wave files (*.wav)|*.wav"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.Audio.Play(openFileDialog1.FileName.Trim)
                    My.Settings.CustomSound = openFileDialog1.FileName.Trim
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Unable to play selected wave file.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                CustomSoundValue.Text = My.Settings.CustomSound
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception in Method CustomSoundButton_Click()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            openFileDialog1.Dispose()
        End Try
    End Sub

    Private Sub SystemSoundList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemSoundList.SelectedIndexChanged
        My.Settings.SystemSound = SystemSoundList.Text.Trim
    End Sub

    Private Sub PlaySoundButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaySoundButton.Click
        Try
            Dim duration As Integer = 200
            Select Case My.Settings.SoundOption
                Case EnumSoundOption.DefaultSound
                    Console.Beep(800, duration)
                    Console.Beep(600, duration)
                    Console.Beep(800, duration)
                    Console.Beep(600, duration)
                    Console.Beep(800, duration)
                    Console.Beep(725, duration)
                    Console.Beep(650, duration)
                    Console.Beep(600, duration)
                    ' Thread.Sleep(200)
                    Console.Beep(800, duration)
                    Console.Beep(600, duration)
                    Console.Beep(800, duration)
                    Console.Beep(600, duration)
                    Console.Beep(800, duration)
                    Console.Beep(725, duration)
                    Console.Beep(650, duration)
                    Console.Beep(600, duration)
                Case EnumSoundOption.SystemSound
                    If My.Settings.SystemSound.Trim.Length > 0 AndAlso IO.File.Exists(SystemSoundFolder & My.Settings.SystemSound) Then
                        Try
                            My.Computer.Audio.Play(SystemSoundFolder & My.Settings.SystemSound)
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message, "Error Playing System Sound", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            My.Settings.SystemSound = ""
                            SystemSoundList.Items.Remove(SystemSoundList.SelectedItem)
                            SystemSoundList.Text = ""
                        End Try

                    End If
                Case EnumSoundOption.CustomSound
                    If My.Settings.CustomSound.Trim.Length > 0 AndAlso IO.File.Exists(My.Settings.CustomSound) Then
                        My.Computer.Audio.Play(My.Settings.CustomSound)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception in Method PlaySoundButton_Click()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OptionsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsButton.Click
        If OptionsButton.Tag Is Nothing OrElse OptionsButton.Tag = 0 Then
            Me.Height = Me.MaximumSize.Height
            OptionsButton.Tag = 1
        Else
            Me.Height = Me.MinimumSize.Height
            OptionsButton.Tag = 0
        End If

    End Sub



    Private Sub CustomMessageOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomMessageOption.CheckedChanged
        My.Settings.UseCustomMessage = CustomMessageOption.Checked
        CustomMessageValue.Enabled = CustomMessageOption.Checked
    End Sub

    Private Sub CustomMessageValue_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomMessageValue.Leave
        My.Settings.CustomMessage = CustomMessageValue.Text
    End Sub

    Private Sub StartTimerOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartTimerOption.CheckedChanged
        My.Settings.StartTimer = StartTimerOption.Checked
    End Sub
End Class
