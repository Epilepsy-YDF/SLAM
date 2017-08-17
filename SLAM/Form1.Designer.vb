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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GameSelector = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.TrackList = New System.Windows.Forms.ListView()
        Me.LoadedCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TrackCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HotKeyCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VolumeCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Trimmed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TagsCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ImportDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.WavWorker = New System.ComponentModel.BackgroundWorker()
        Me.PollRelayWorker = New System.ComponentModel.BackgroundWorker()
        Me.ChangeDirButton = New System.Windows.Forms.Button()
        Me.TrackContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveHotkeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextHotKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayKeyButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SystemTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SystemTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SystemTrayMenu_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemTrayMenu_StartStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SystemTrayMenu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.YTButton = New System.Windows.Forms.Button()
        Me.TrackContextMenu.SuspendLayout()
        Me.SystemTrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameSelector
        '
        Me.GameSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GameSelector.FormattingEnabled = True
        Me.GameSelector.Location = New System.Drawing.Point(65, 16)
        Me.GameSelector.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GameSelector.MaxDropDownItems = 100
        Me.GameSelector.Name = "GameSelector"
        Me.GameSelector.Size = New System.Drawing.Size(507, 25)
        Me.GameSelector.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "游戏："
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImportButton.Location = New System.Drawing.Point(17, 388)
        Me.ImportButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(63, 30)
        Me.ImportButton.TabIndex = 3
        Me.ImportButton.Text = "导入"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'TrackList
        '
        Me.TrackList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackList.AutoArrange = False
        Me.TrackList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LoadedCol, Me.TrackCol, Me.HotKeyCol, Me.VolumeCol, Me.Trimmed, Me.TagsCol})
        Me.TrackList.FullRowSelect = True
        Me.TrackList.HideSelection = False
        Me.TrackList.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TrackList.Location = New System.Drawing.Point(17, 51)
        Me.TrackList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrackList.Name = "TrackList"
        Me.TrackList.Size = New System.Drawing.Size(649, 328)
        Me.TrackList.TabIndex = 4
        Me.TrackList.UseCompatibleStateImageBehavior = False
        Me.TrackList.View = System.Windows.Forms.View.Details
        '
        'LoadedCol
        '
        Me.LoadedCol.Text = "准备播放"
        '
        'TrackCol
        '
        Me.TrackCol.Text = "曲目"
        Me.TrackCol.Width = 137
        '
        'HotKeyCol
        '
        Me.HotKeyCol.Text = "绑定快捷键"
        '
        'VolumeCol
        '
        Me.VolumeCol.Text = "音量"
        Me.VolumeCol.Width = 100
        '
        'Trimmed
        '
        Me.Trimmed.Text = "提取片段"
        '
        'TagsCol
        '
        Me.TagsCol.Text = "标签"
        Me.TagsCol.Width = 43
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(112, 388)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(87, 30)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "开始"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ImportDialog
        '
        Me.ImportDialog.Filter = "媒体文件|*.mp3;*.wav;*.aac;*.wma;*.m4a;*.mp4;*.wmv;*.avi;*.m4v;*.mov;|Audio files|*.m" &
    "p3;*.wav;*.aac;*.wma;*.m4a;|Video files|*.mp4;*.wmv;*.avi;*.m4v;*.mov;|All files" &
    "|*.*"
        Me.ImportDialog.Multiselect = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 426)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(650, 30)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 6
        '
        'WavWorker
        '
        Me.WavWorker.WorkerReportsProgress = True
        '
        'PollRelayWorker
        '
        Me.PollRelayWorker.WorkerReportsProgress = True
        Me.PollRelayWorker.WorkerSupportsCancellation = True
        '
        'ChangeDirButton
        '
        Me.ChangeDirButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeDirButton.Location = New System.Drawing.Point(580, 13)
        Me.ChangeDirButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChangeDirButton.Name = "ChangeDirButton"
        Me.ChangeDirButton.Size = New System.Drawing.Size(87, 30)
        Me.ChangeDirButton.TabIndex = 7
        Me.ChangeDirButton.Text = "设置"
        Me.ChangeDirButton.UseVisualStyleBackColor = True
        '
        'TrackContextMenu
        '
        Me.TrackContextMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TrackContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextDelete, Me.GoToToolStripMenuItem, Me.ContextRefresh, Me.RemoveHotkeyToolStripMenuItem, Me.RenameToolStripMenuItem, Me.ContextHotKey, Me.SetVolumeToolStripMenuItem, Me.TrimToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.TrackContextMenu.Name = "TrackContextMenu"
        Me.TrackContextMenu.Size = New System.Drawing.Size(137, 202)
        '
        'ContextDelete
        '
        Me.ContextDelete.Name = "ContextDelete"
        Me.ContextDelete.Size = New System.Drawing.Size(136, 22)
        Me.ContextDelete.Text = "删除"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GoToToolStripMenuItem.Text = "到达"
        '
        'ContextRefresh
        '
        Me.ContextRefresh.Name = "ContextRefresh"
        Me.ContextRefresh.Size = New System.Drawing.Size(136, 22)
        Me.ContextRefresh.Text = "刷新"
        '
        'RemoveHotkeyToolStripMenuItem
        '
        Me.RemoveHotkeyToolStripMenuItem.Name = "RemoveHotkeyToolStripMenuItem"
        Me.RemoveHotkeyToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RemoveHotkeyToolStripMenuItem.Text = "移除快捷键"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RenameToolStripMenuItem.Text = "重命名"
        '
        'ContextHotKey
        '
        Me.ContextHotKey.Name = "ContextHotKey"
        Me.ContextHotKey.Size = New System.Drawing.Size(136, 22)
        Me.ContextHotKey.Text = "绑定快捷键"
        '
        'SetVolumeToolStripMenuItem
        '
        Me.SetVolumeToolStripMenuItem.Name = "SetVolumeToolStripMenuItem"
        Me.SetVolumeToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SetVolumeToolStripMenuItem.Text = "设置音量"
        '
        'TrimToolStripMenuItem
        '
        Me.TrimToolStripMenuItem.Name = "TrimToolStripMenuItem"
        Me.TrimToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.TrimToolStripMenuItem.Text = "截取…"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LoadToolStripMenuItem.Text = "准备播放"
        '
        'PlayKeyButton
        '
        Me.PlayKeyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayKeyButton.Location = New System.Drawing.Point(443, 388)
        Me.PlayKeyButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlayKeyButton.Name = "PlayKeyButton"
        Me.PlayKeyButton.Size = New System.Drawing.Size(224, 30)
        Me.PlayKeyButton.TabIndex = 8
        Me.PlayKeyButton.Text = "播放键：““""{0}""””““更改””"
        Me.PlayKeyButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(206, 395)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(68, 17)
        Me.StatusLabel.TabIndex = 9
        Me.StatusLabel.Text = "状态：空闲"
        '
        'SystemTrayIcon
        '
        Me.SystemTrayIcon.ContextMenuStrip = Me.SystemTrayMenu
        Me.SystemTrayIcon.Icon = CType(resources.GetObject("SystemTrayIcon.Icon"), System.Drawing.Icon)
        Me.SystemTrayIcon.Text = "SLAM"
        '
        'SystemTrayMenu
        '
        Me.SystemTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemTrayMenu_Open, Me.SystemTrayMenu_StartStop, Me.ToolStripSeparator1, Me.SystemTrayMenu_Exit})
        Me.SystemTrayMenu.Name = "SystemTrayMenu"
        Me.SystemTrayMenu.Size = New System.Drawing.Size(137, 76)
        '
        'SystemTrayMenu_Open
        '
        Me.SystemTrayMenu_Open.Name = "SystemTrayMenu_Open"
        Me.SystemTrayMenu_Open.Size = New System.Drawing.Size(136, 22)
        Me.SystemTrayMenu_Open.Text = "打开主界面"
        '
        'SystemTrayMenu_StartStop
        '
        Me.SystemTrayMenu_StartStop.Name = "SystemTrayMenu_StartStop"
        Me.SystemTrayMenu_StartStop.Size = New System.Drawing.Size(136, 22)
        Me.SystemTrayMenu_StartStop.Text = "开始"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'SystemTrayMenu_Exit
        '
        Me.SystemTrayMenu_Exit.Name = "SystemTrayMenu_Exit"
        Me.SystemTrayMenu_Exit.Size = New System.Drawing.Size(136, 22)
        Me.SystemTrayMenu_Exit.Text = "退出"
        '
        'YTButton
        '
        Me.YTButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YTButton.Image = CType(resources.GetObject("YTButton.Image"), System.Drawing.Image)
        Me.YTButton.Location = New System.Drawing.Point(79, 388)
        Me.YTButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.YTButton.Name = "YTButton"
        Me.YTButton.Size = New System.Drawing.Size(26, 30)
        Me.YTButton.TabIndex = 10
        Me.YTButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 472)
        Me.Controls.Add(Me.YTButton)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.PlayKeyButton)
        Me.Controls.Add(Me.ChangeDirButton)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.TrackList)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GameSelector)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(581, 511)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "起源引擎现场混音器"
        Me.TrackContextMenu.ResumeLayout(False)
        Me.SystemTrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameSelector As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImportButton As System.Windows.Forms.Button
    Friend WithEvents TrackList As System.Windows.Forms.ListView
    Friend WithEvents LoadedCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents TrackCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents TagsCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents ImportDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents WavWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PollRelayWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ChangeDirButton As System.Windows.Forms.Button
    Friend WithEvents TrackContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextHotKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotKeyCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents RemoveHotkeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayKeyButton As System.Windows.Forms.Button
    Friend WithEvents VolumeCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents SetVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrimToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Trimmed As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemTrayIcon As NotifyIcon
    Friend WithEvents SystemTrayMenu As ContextMenuStrip
    Friend WithEvents SystemTrayMenu_Open As ToolStripMenuItem
    Friend WithEvents SystemTrayMenu_StartStop As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SystemTrayMenu_Exit As ToolStripMenuItem
    Friend WithEvents YTButton As Button
End Class
