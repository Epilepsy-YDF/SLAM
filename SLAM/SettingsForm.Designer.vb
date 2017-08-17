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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VersionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DonateLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NAudioRadio = New System.Windows.Forms.RadioButton()
        Me.FFMPEGRadio = New System.Windows.Forms.RadioButton()
        Me.OverrideGroup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FinduserdataButton = New System.Windows.Forms.Button()
        Me.userdatatext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FindsteamappsButton = New System.Windows.Forms.Button()
        Me.steamappstext = New System.Windows.Forms.TextBox()
        Me.EnableOverrideBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChangeRelayButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StartMinimizedCheckBox = New System.Windows.Forms.CheckBox()
        Me.MinimizeToSysTrayCheckBox = New System.Windows.Forms.CheckBox()
        Me.HoldToPlay = New System.Windows.Forms.CheckBox()
        Me.ConTagsCheckBox = New System.Windows.Forms.CheckBox()
        Me.StartEnabledCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogCheckBox = New System.Windows.Forms.CheckBox()
        Me.HintCheckBox = New System.Windows.Forms.CheckBox()
        Me.UpdateCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.OverrideGroup.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.VersionLabel, Me.DonateLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 411)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(331, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel1.Text = "版本："
        '
        'VersionLabel
        '
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(35, 17)
        Me.VersionLabel.Text = "0.0.0"
        '
        'DonateLabel
        '
        Me.DonateLabel.IsLink = True
        Me.DonateLabel.Name = "DonateLabel"
        Me.DonateLabel.Size = New System.Drawing.Size(185, 17)
        Me.DonateLabel.Text = "想要以捐助的方式支持SLAM吗？"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NAudioRadio)
        Me.TabPage2.Controls.Add(Me.FFMPEGRadio)
        Me.TabPage2.Controls.Add(Me.OverrideGroup)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(323, 403)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "高级"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NAudioRadio
        '
        Me.NAudioRadio.AutoSize = True
        Me.NAudioRadio.Location = New System.Drawing.Point(146, 217)
        Me.NAudioRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NAudioRadio.Name = "NAudioRadio"
        Me.NAudioRadio.Size = New System.Drawing.Size(142, 21)
        Me.NAudioRadio.TabIndex = 5
        Me.NAudioRadio.TabStop = True
        Me.NAudioRadio.Text = "使用NAudio（传统）"
        Me.NAudioRadio.UseVisualStyleBackColor = True
        '
        'FFMPEGRadio
        '
        Me.FFMPEGRadio.AutoSize = True
        Me.FFMPEGRadio.Location = New System.Drawing.Point(34, 217)
        Me.FFMPEGRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FFMPEGRadio.Name = "FFMPEGRadio"
        Me.FFMPEGRadio.Size = New System.Drawing.Size(97, 21)
        Me.FFMPEGRadio.TabIndex = 4
        Me.FFMPEGRadio.TabStop = True
        Me.FFMPEGRadio.Text = "使用FFMPEG"
        Me.FFMPEGRadio.UseVisualStyleBackColor = True
        '
        'OverrideGroup
        '
        Me.OverrideGroup.Controls.Add(Me.Label2)
        Me.OverrideGroup.Controls.Add(Me.FinduserdataButton)
        Me.OverrideGroup.Controls.Add(Me.userdatatext)
        Me.OverrideGroup.Controls.Add(Me.Label1)
        Me.OverrideGroup.Controls.Add(Me.FindsteamappsButton)
        Me.OverrideGroup.Controls.Add(Me.steamappstext)
        Me.OverrideGroup.Controls.Add(Me.EnableOverrideBox)
        Me.OverrideGroup.Location = New System.Drawing.Point(9, 84)
        Me.OverrideGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OverrideGroup.Name = "OverrideGroup"
        Me.OverrideGroup.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OverrideGroup.Size = New System.Drawing.Size(303, 126)
        Me.OverrideGroup.TabIndex = 3
        Me.OverrideGroup.TabStop = False
        Me.OverrideGroup.Text = "覆盖文件夹检测"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(7, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "userdata:"
        '
        'FinduserdataButton
        '
        Me.FinduserdataButton.Enabled = False
        Me.FinduserdataButton.Location = New System.Drawing.Point(268, 86)
        Me.FinduserdataButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FinduserdataButton.Name = "FinduserdataButton"
        Me.FinduserdataButton.Size = New System.Drawing.Size(28, 30)
        Me.FinduserdataButton.TabIndex = 5
        Me.FinduserdataButton.Text = "..."
        Me.FinduserdataButton.UseVisualStyleBackColor = True
        '
        'userdatatext
        '
        Me.userdatatext.Enabled = False
        Me.userdatatext.Location = New System.Drawing.Point(85, 89)
        Me.userdatatext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.userdatatext.Name = "userdatatext"
        Me.userdatatext.ReadOnly = True
        Me.userdatatext.Size = New System.Drawing.Size(175, 23)
        Me.userdatatext.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(7, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "steamapps:"
        '
        'FindsteamappsButton
        '
        Me.FindsteamappsButton.Enabled = False
        Me.FindsteamappsButton.Location = New System.Drawing.Point(268, 52)
        Me.FindsteamappsButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FindsteamappsButton.Name = "FindsteamappsButton"
        Me.FindsteamappsButton.Size = New System.Drawing.Size(28, 30)
        Me.FindsteamappsButton.TabIndex = 2
        Me.FindsteamappsButton.Text = "..."
        Me.FindsteamappsButton.UseVisualStyleBackColor = True
        '
        'steamappstext
        '
        Me.steamappstext.Enabled = False
        Me.steamappstext.Location = New System.Drawing.Point(85, 55)
        Me.steamappstext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.steamappstext.Name = "steamappstext"
        Me.steamappstext.ReadOnly = True
        Me.steamappstext.Size = New System.Drawing.Size(175, 23)
        Me.steamappstext.TabIndex = 1
        '
        'EnableOverrideBox
        '
        Me.EnableOverrideBox.AutoSize = True
        Me.EnableOverrideBox.Location = New System.Drawing.Point(7, 25)
        Me.EnableOverrideBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EnableOverrideBox.Name = "EnableOverrideBox"
        Me.EnableOverrideBox.Size = New System.Drawing.Size(51, 21)
        Me.EnableOverrideBox.TabIndex = 0
        Me.EnableOverrideBox.Text = "启用"
        Me.EnableOverrideBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChangeRelayButton)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(303, 68)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "继续键"
        '
        'ChangeRelayButton
        '
        Me.ChangeRelayButton.Location = New System.Drawing.Point(7, 25)
        Me.ChangeRelayButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChangeRelayButton.Name = "ChangeRelayButton"
        Me.ChangeRelayButton.Size = New System.Drawing.Size(289, 30)
        Me.ChangeRelayButton.TabIndex = 0
        Me.ChangeRelayButton.Text = "继续键““""{0}""””（更改）"
        Me.ChangeRelayButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.StartMinimizedCheckBox)
        Me.GroupBox2.Controls.Add(Me.MinimizeToSysTrayCheckBox)
        Me.GroupBox2.Controls.Add(Me.HoldToPlay)
        Me.GroupBox2.Controls.Add(Me.ConTagsCheckBox)
        Me.GroupBox2.Controls.Add(Me.StartEnabledCheckBox)
        Me.GroupBox2.Controls.Add(Me.LogCheckBox)
        Me.GroupBox2.Controls.Add(Me.HintCheckBox)
        Me.GroupBox2.Controls.Add(Me.UpdateCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(303, 283)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "其他"
        '
        'StartMinimizedCheckBox
        '
        Me.StartMinimizedCheckBox.AutoSize = True
        Me.StartMinimizedCheckBox.Location = New System.Drawing.Point(7, 235)
        Me.StartMinimizedCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartMinimizedCheckBox.Name = "StartMinimizedCheckBox"
        Me.StartMinimizedCheckBox.Size = New System.Drawing.Size(99, 21)
        Me.StartMinimizedCheckBox.TabIndex = 13
        Me.StartMinimizedCheckBox.Text = "启动时最小化"
        Me.StartMinimizedCheckBox.UseVisualStyleBackColor = True
        '
        'MinimizeToSysTrayCheckBox
        '
        Me.MinimizeToSysTrayCheckBox.AutoSize = True
        Me.MinimizeToSysTrayCheckBox.Location = New System.Drawing.Point(7, 205)
        Me.MinimizeToSysTrayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeToSysTrayCheckBox.Name = "MinimizeToSysTrayCheckBox"
        Me.MinimizeToSysTrayCheckBox.Size = New System.Drawing.Size(99, 21)
        Me.MinimizeToSysTrayCheckBox.TabIndex = 12
        Me.MinimizeToSysTrayCheckBox.Text = "最小化到托盘"
        Me.MinimizeToSysTrayCheckBox.UseVisualStyleBackColor = True
        '
        'HoldToPlay
        '
        Me.HoldToPlay.AutoSize = True
        Me.HoldToPlay.Location = New System.Drawing.Point(7, 176)
        Me.HoldToPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HoldToPlay.Name = "HoldToPlay"
        Me.HoldToPlay.Size = New System.Drawing.Size(75, 21)
        Me.HoldToPlay.TabIndex = 11
        Me.HoldToPlay.Text = "按住播放"
        Me.HoldToPlay.UseVisualStyleBackColor = True
        '
        'ConTagsCheckBox
        '
        Me.ConTagsCheckBox.AutoSize = True
        Me.ConTagsCheckBox.Location = New System.Drawing.Point(7, 144)
        Me.ConTagsCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ConTagsCheckBox.Name = "ConTagsCheckBox"
        Me.ConTagsCheckBox.Size = New System.Drawing.Size(135, 21)
        Me.ConTagsCheckBox.TabIndex = 5
        Me.ConTagsCheckBox.Text = "在控制台中显示标签"
        Me.ConTagsCheckBox.UseVisualStyleBackColor = True
        '
        'StartEnabledCheckBox
        '
        Me.StartEnabledCheckBox.AutoSize = True
        Me.StartEnabledCheckBox.Location = New System.Drawing.Point(7, 115)
        Me.StartEnabledCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartEnabledCheckBox.Name = "StartEnabledCheckBox"
        Me.StartEnabledCheckBox.Size = New System.Drawing.Size(75, 21)
        Me.StartEnabledCheckBox.TabIndex = 4
        Me.StartEnabledCheckBox.Text = "允许启动"
        Me.StartEnabledCheckBox.UseVisualStyleBackColor = True
        '
        'LogCheckBox
        '
        Me.LogCheckBox.AutoSize = True
        Me.LogCheckBox.Location = New System.Drawing.Point(7, 85)
        Me.LogCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogCheckBox.Name = "LogCheckBox"
        Me.LogCheckBox.Size = New System.Drawing.Size(75, 21)
        Me.LogCheckBox.TabIndex = 2
        Me.LogCheckBox.Text = "记录错误"
        Me.LogCheckBox.UseVisualStyleBackColor = True
        '
        'HintCheckBox
        '
        Me.HintCheckBox.AutoSize = True
        Me.HintCheckBox.Location = New System.Drawing.Point(7, 55)
        Me.HintCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HintCheckBox.Name = "HintCheckBox"
        Me.HintCheckBox.Size = New System.Drawing.Size(75, 21)
        Me.HintCheckBox.TabIndex = 3
        Me.HintCheckBox.Text = "关闭提示"
        Me.HintCheckBox.UseVisualStyleBackColor = True
        '
        'UpdateCheckBox
        '
        Me.UpdateCheckBox.AutoSize = True
        Me.UpdateCheckBox.Location = New System.Drawing.Point(7, 25)
        Me.UpdateCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateCheckBox.Name = "UpdateCheckBox"
        Me.UpdateCheckBox.Size = New System.Drawing.Size(75, 21)
        Me.UpdateCheckBox.TabIndex = 2
        Me.UpdateCheckBox.Text = "检查更新"
        Me.UpdateCheckBox.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(331, 433)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(323, 403)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "杂项"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 433)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "设置"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.OverrideGroup.ResumeLayout(False)
        Me.OverrideGroup.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VersionLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StartEnabledCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HintCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UpdateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ConTagsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChangeRelayButton As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents HoldToPlay As System.Windows.Forms.CheckBox
    Friend WithEvents OverrideGroup As GroupBox
    Friend WithEvents FindsteamappsButton As Button
    Friend WithEvents steamappstext As TextBox
    Friend WithEvents EnableOverrideBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DonateLabel As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents FinduserdataButton As Button
    Friend WithEvents userdatatext As TextBox
    Friend WithEvents MinimizeToSysTrayCheckBox As CheckBox
    Friend WithEvents StartMinimizedCheckBox As CheckBox
    Friend WithEvents NAudioRadio As RadioButton
    Friend WithEvents FFMPEGRadio As RadioButton
End Class
