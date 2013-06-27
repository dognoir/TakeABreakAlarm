Imports System.Threading
Public Class AlarmMessage
    Private Sub AlarmMessage_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim duration As Integer = 200
        Application.DoEvents()
        Select Case My.Settings.SoundOption
            Case SettingsForm.EnumSoundOption.DefaultSound
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
            Case SettingsForm.EnumSoundOption.SystemSound
                My.Computer.Audio.Play(SettingsForm.SystemSoundFolder & My.Settings.SystemSound)
            Case SettingsForm.EnumSoundOption.CustomSound
                My.Computer.Audio.Play(My.Settings.CustomSound)
        End Select
    End Sub

    Private Sub AlarmMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.UseCustomMessage Then
            AlarmMessageValue.Text = My.Settings.CustomMessage
        Else
            AlarmMessageValue.Text = My.Settings.DefaultMessage
        End If
    End Sub
End Class