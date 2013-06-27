<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button
        Me.MinutesValue = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.StopButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MinutesLeftValue = New System.Windows.Forms.Label
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIconMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RunAtStartUpOption = New System.Windows.Forms.CheckBox
        Me.SystemSoundList = New System.Windows.Forms.ComboBox
        Me.CustomSoundOption = New System.Windows.Forms.RadioButton
        Me.SystemSoundOption = New System.Windows.Forms.RadioButton
        Me.DefaultSoundOption = New System.Windows.Forms.RadioButton
        Me.CustomSoundValue = New System.Windows.Forms.TextBox
        Me.CustomSoundButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PlaySoundButton = New System.Windows.Forms.Button
        Me.OptionsButton = New System.Windows.Forms.Button
        Me.CustomMessageValue = New System.Windows.Forms.TextBox
        Me.CustomMessageOption = New System.Windows.Forms.CheckBox
        Me.StartTimerOption = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.NotifyIconMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Green
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Location = New System.Drawing.Point(79, 64)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(59, 23)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'MinutesValue
        '
        Me.MinutesValue.Location = New System.Drawing.Point(119, 6)
        Me.MinutesValue.Name = "MinutesValue"
        Me.MinutesValue.Size = New System.Drawing.Size(35, 20)
        Me.MinutesValue.TabIndex = 1
        Me.MinutesValue.Text = "30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alarm to go off every"
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.Red
        Me.StopButton.Enabled = False
        Me.StopButton.ForeColor = System.Drawing.Color.White
        Me.StopButton.Location = New System.Drawing.Point(144, 64)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(59, 23)
        Me.StopButton.TabIndex = 0
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "minutes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time to next alarm:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "minutes"
        '
        'MinutesLeftValue
        '
        Me.MinutesLeftValue.AutoSize = True
        Me.MinutesLeftValue.Location = New System.Drawing.Point(118, 34)
        Me.MinutesLeftValue.Name = "MinutesLeftValue"
        Me.MinutesLeftValue.Size = New System.Drawing.Size(13, 13)
        Me.MinutesLeftValue.TabIndex = 2
        Me.MinutesLeftValue.Text = "0"
        '
        'nfi
        '
        Me.nfi.ContextMenuStrip = Me.NotifyIconMenu
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "Alarm"
        '
        'NotifyIconMenu
        '
        Me.NotifyIconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ResetTimeToolStripMenuItem, Me.StartToolStripMenuItem, Me.CloseAlarmToolStripMenuItem})
        Me.NotifyIconMenu.Name = "NotifyIconMenu"
        Me.NotifyIconMenu.Size = New System.Drawing.Size(133, 92)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RestoreToolStripMenuItem.Image = Global.Alarm.My.Resources.Resources.window_time
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ResetTimeToolStripMenuItem
        '
        Me.ResetTimeToolStripMenuItem.Image = Global.Alarm.My.Resources.Resources.clock_refresh
        Me.ResetTimeToolStripMenuItem.Name = "ResetTimeToolStripMenuItem"
        Me.ResetTimeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ResetTimeToolStripMenuItem.Text = "Reset Time"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Image = Global.Alarm.My.Resources.Resources.clock_run
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'CloseAlarmToolStripMenuItem
        '
        Me.CloseAlarmToolStripMenuItem.Image = Global.Alarm.My.Resources.Resources._error
        Me.CloseAlarmToolStripMenuItem.Name = "CloseAlarmToolStripMenuItem"
        Me.CloseAlarmToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CloseAlarmToolStripMenuItem.Text = "Exit"
        '
        'RunAtStartUpOption
        '
        Me.RunAtStartUpOption.AutoSize = True
        Me.RunAtStartUpOption.Location = New System.Drawing.Point(12, 11)
        Me.RunAtStartUpOption.Name = "RunAtStartUpOption"
        Me.RunAtStartUpOption.Size = New System.Drawing.Size(140, 17)
        Me.RunAtStartUpOption.TabIndex = 3
        Me.RunAtStartUpOption.Text = "Run at Windows startup"
        Me.RunAtStartUpOption.UseVisualStyleBackColor = True
        '
        'SystemSoundList
        '
        Me.SystemSoundList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SystemSoundList.Enabled = False
        Me.SystemSoundList.FormattingEnabled = True
        Me.SystemSoundList.Location = New System.Drawing.Point(6, 56)
        Me.SystemSoundList.Name = "SystemSoundList"
        Me.SystemSoundList.Size = New System.Drawing.Size(188, 21)
        Me.SystemSoundList.TabIndex = 4
        '
        'CustomSoundOption
        '
        Me.CustomSoundOption.AutoSize = True
        Me.CustomSoundOption.Location = New System.Drawing.Point(6, 83)
        Me.CustomSoundOption.Name = "CustomSoundOption"
        Me.CustomSoundOption.Size = New System.Drawing.Size(116, 17)
        Me.CustomSoundOption.TabIndex = 5
        Me.CustomSoundOption.TabStop = True
        Me.CustomSoundOption.Text = "Use Custom Sound"
        Me.CustomSoundOption.UseVisualStyleBackColor = True
        '
        'SystemSoundOption
        '
        Me.SystemSoundOption.AutoSize = True
        Me.SystemSoundOption.Location = New System.Drawing.Point(6, 33)
        Me.SystemSoundOption.Name = "SystemSoundOption"
        Me.SystemSoundOption.Size = New System.Drawing.Size(115, 17)
        Me.SystemSoundOption.TabIndex = 5
        Me.SystemSoundOption.TabStop = True
        Me.SystemSoundOption.Text = "Use System Sound"
        Me.SystemSoundOption.UseVisualStyleBackColor = True
        '
        'DefaultSoundOption
        '
        Me.DefaultSoundOption.AutoSize = True
        Me.DefaultSoundOption.Location = New System.Drawing.Point(6, 13)
        Me.DefaultSoundOption.Name = "DefaultSoundOption"
        Me.DefaultSoundOption.Size = New System.Drawing.Size(115, 17)
        Me.DefaultSoundOption.TabIndex = 5
        Me.DefaultSoundOption.TabStop = True
        Me.DefaultSoundOption.Text = "Use Default Sound"
        Me.DefaultSoundOption.UseVisualStyleBackColor = True
        '
        'CustomSoundValue
        '
        Me.CustomSoundValue.Enabled = False
        Me.CustomSoundValue.Location = New System.Drawing.Point(6, 106)
        Me.CustomSoundValue.Name = "CustomSoundValue"
        Me.CustomSoundValue.ReadOnly = True
        Me.CustomSoundValue.Size = New System.Drawing.Size(131, 20)
        Me.CustomSoundValue.TabIndex = 6
        '
        'CustomSoundButton
        '
        Me.CustomSoundButton.Enabled = False
        Me.CustomSoundButton.Location = New System.Drawing.Point(138, 105)
        Me.CustomSoundButton.Name = "CustomSoundButton"
        Me.CustomSoundButton.Size = New System.Drawing.Size(56, 23)
        Me.CustomSoundButton.TabIndex = 7
        Me.CustomSoundButton.Text = "Browse"
        Me.CustomSoundButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PlaySoundButton
        '
        Me.PlaySoundButton.Location = New System.Drawing.Point(119, 132)
        Me.PlaySoundButton.Name = "PlaySoundButton"
        Me.PlaySoundButton.Size = New System.Drawing.Size(75, 23)
        Me.PlaySoundButton.TabIndex = 8
        Me.PlaySoundButton.Text = "Play Sound"
        Me.PlaySoundButton.UseVisualStyleBackColor = True
        '
        'OptionsButton
        '
        Me.OptionsButton.Location = New System.Drawing.Point(12, 64)
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.Size = New System.Drawing.Size(59, 23)
        Me.OptionsButton.TabIndex = 8
        Me.OptionsButton.Text = "Options"
        Me.OptionsButton.UseVisualStyleBackColor = True
        '
        'CustomMessageValue
        '
        Me.CustomMessageValue.Location = New System.Drawing.Point(5, 37)
        Me.CustomMessageValue.Multiline = True
        Me.CustomMessageValue.Name = "CustomMessageValue"
        Me.CustomMessageValue.Size = New System.Drawing.Size(188, 53)
        Me.CustomMessageValue.TabIndex = 9
        Me.CustomMessageValue.Text = "Get up, take a quick walk around and clear your head!"
        '
        'CustomMessageOption
        '
        Me.CustomMessageOption.AutoSize = True
        Me.CustomMessageOption.Location = New System.Drawing.Point(5, 15)
        Me.CustomMessageOption.Name = "CustomMessageOption"
        Me.CustomMessageOption.Size = New System.Drawing.Size(129, 17)
        Me.CustomMessageOption.TabIndex = 3
        Me.CustomMessageOption.Text = "Use Custom Message"
        Me.CustomMessageOption.UseVisualStyleBackColor = True
        '
        'StartTimerOption
        '
        Me.StartTimerOption.AutoSize = True
        Me.StartTimerOption.Location = New System.Drawing.Point(12, 28)
        Me.StartTimerOption.Name = "StartTimerOption"
        Me.StartTimerOption.Size = New System.Drawing.Size(166, 17)
        Me.StartTimerOption.TabIndex = 3
        Me.StartTimerOption.Text = "Start timer when program runs"
        Me.StartTimerOption.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.RunAtStartUpOption)
        Me.GroupBox1.Controls.Add(Me.StartTimerOption)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 49)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CustomSoundButton)
        Me.GroupBox2.Controls.Add(Me.CustomSoundOption)
        Me.GroupBox2.Controls.Add(Me.SystemSoundOption)
        Me.GroupBox2.Controls.Add(Me.DefaultSoundOption)
        Me.GroupBox2.Controls.Add(Me.SystemSoundList)
        Me.GroupBox2.Controls.Add(Me.CustomSoundValue)
        Me.GroupBox2.Controls.Add(Me.PlaySoundButton)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 163)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CustomMessageValue)
        Me.GroupBox3.Controls.Add(Me.CustomMessageOption)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(214, 404)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.OptionsButton)
        Me.Controls.Add(Me.MinutesLeftValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MinutesValue)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(230, 440)
        Me.MinimumSize = New System.Drawing.Size(230, 130)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm Control"
        Me.NotifyIconMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents MinutesValue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MinutesLeftValue As System.Windows.Forms.Label
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotifyIconMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAlarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunAtStartUpOption As System.Windows.Forms.CheckBox
    Friend WithEvents SystemSoundList As System.Windows.Forms.ComboBox
    Friend WithEvents CustomSoundOption As System.Windows.Forms.RadioButton
    Friend WithEvents SystemSoundOption As System.Windows.Forms.RadioButton
    Friend WithEvents DefaultSoundOption As System.Windows.Forms.RadioButton
    Friend WithEvents CustomSoundValue As System.Windows.Forms.TextBox
    Friend WithEvents CustomSoundButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PlaySoundButton As System.Windows.Forms.Button
    Friend WithEvents OptionsButton As System.Windows.Forms.Button
    Friend WithEvents CustomMessageValue As System.Windows.Forms.TextBox
    Friend WithEvents CustomMessageOption As System.Windows.Forms.CheckBox
    Friend WithEvents StartTimerOption As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
