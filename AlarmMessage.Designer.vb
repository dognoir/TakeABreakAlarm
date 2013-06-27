<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlarmMessage))
        Me.AlarmMessageValue = New System.Windows.Forms.Label
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'AlarmMessageValue
        '
        Me.AlarmMessageValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlarmMessageValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmMessageValue.Location = New System.Drawing.Point(0, 0)
        Me.AlarmMessageValue.Name = "AlarmMessageValue"
        Me.AlarmMessageValue.Size = New System.Drawing.Size(324, 159)
        Me.AlarmMessageValue.TabIndex = 0
        Me.AlarmMessageValue.Text = "Get up, take a quick walk around and clear your head!"
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.Yellow
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(237, 124)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Close "
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'AlarmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(324, 159)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AlarmMessageValue)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(330, 185)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(330, 185)
        Me.Name = "AlarmMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm!!!"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlarmMessageValue As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
