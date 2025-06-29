﻿namespace JNSoundboard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblPlayback1 = new System.Windows.Forms.Label();
            this.cbPlaybackDevices1 = new System.Windows.Forms.ComboBox();
            this.cbEnableHotkeys = new System.Windows.Forms.CheckBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvKeySounds = new System.Windows.Forms.ListView();
            this.chKeys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWindow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReloadDevices = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texttospeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoopback = new System.Windows.Forms.Label();
            this.cbLoopbackDevices = new System.Windows.Forms.ComboBox();
            this.btnPlaySelectedSound = new System.Windows.Forms.Button();
            this.btnStopAllSounds = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPushToTalk = new System.Windows.Forms.GroupBox();
            this.clearHotkey = new System.Windows.Forms.Button();
            this.btnReloadWindows = new System.Windows.Forms.Button();
            this.cbEnablePushToTalk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPushToTalkKey = new System.Windows.Forms.TextBox();
            this.cbWindows = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAudioDevices = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoopbackDevices2 = new System.Windows.Forms.ComboBox();
            this.cbPlaybackDevices2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayback2 = new System.Windows.Forms.Label();
            this.pushToTalkKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.cbEnableLoopback = new System.Windows.Forms.CheckBox();
            this.vsSoundVolume = new NAudio.Gui.VolumeSlider();
            this.nSoundVolume = new System.Windows.Forms.NumericUpDown();
            this.gbSoundboard = new System.Windows.Forms.GroupBox();
            this.cbEnableLoopback2 = new System.Windows.Forms.CheckBox();
            this.saveSettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbPushToTalk.SuspendLayout();
            this.gbAudioDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).BeginInit();
            this.gbSoundboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayback1
            // 
            this.lblPlayback1.AutoSize = true;
            this.lblPlayback1.Location = new System.Drawing.Point(8, 19);
            this.lblPlayback1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.lblPlayback1.Name = "lblPlayback1";
            this.lblPlayback1.Size = new System.Drawing.Size(124, 12);
            this.lblPlayback1.TabIndex = 5;
            this.lblPlayback1.Text = "Speakers or Virtual Cable";
            // 
            // cbPlaybackDevices1
            // 
            this.cbPlaybackDevices1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaybackDevices1.FormattingEnabled = true;
            this.cbPlaybackDevices1.Location = new System.Drawing.Point(142, 17);
            this.cbPlaybackDevices1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.cbPlaybackDevices1.Name = "cbPlaybackDevices1";
            this.cbPlaybackDevices1.Size = new System.Drawing.Size(176, 20);
            this.cbPlaybackDevices1.TabIndex = 11;
            // 
            // cbEnableHotkeys
            // 
            this.cbEnableHotkeys.AutoSize = true;
            this.cbEnableHotkeys.Location = new System.Drawing.Point(8, 18);
            this.cbEnableHotkeys.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.cbEnableHotkeys.Name = "cbEnableHotkeys";
            this.cbEnableHotkeys.Size = new System.Drawing.Size(97, 16);
            this.cbEnableHotkeys.TabIndex = 16;
            this.cbEnableHotkeys.Text = "Enable Hotkeys";
            this.cbEnableHotkeys.UseVisualStyleBackColor = true;
            this.cbEnableHotkeys.CheckedChanged += new System.EventHandler(this.cbEnableHotkeys_CheckedChanged);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 50;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(138, 333);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 21);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(572, 115);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(572, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(572, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvKeySounds
            // 
            this.lvKeySounds.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvKeySounds.AllowDrop = true;
            this.lvKeySounds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvKeySounds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKeys,
            this.chVolume,
            this.chWindow,
            this.chLocation});
            this.lvKeySounds.FullRowSelect = true;
            this.lvKeySounds.GridLines = true;
            this.lvKeySounds.HideSelection = false;
            this.lvKeySounds.Location = new System.Drawing.Point(12, 25);
            this.lvKeySounds.MultiSelect = false;
            this.lvKeySounds.Name = "lvKeySounds";
            this.lvKeySounds.ShowItemToolTips = true;
            this.lvKeySounds.Size = new System.Drawing.Size(554, 302);
            this.lvKeySounds.TabIndex = 0;
            this.lvKeySounds.UseCompatibleStateImageBehavior = false;
            this.lvKeySounds.View = System.Windows.Forms.View.Details;
            this.lvKeySounds.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvKeySounds_DragDrop);
            this.lvKeySounds.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvKeySounds_DragEnter);
            this.lvKeySounds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvKeySounds_KeyDown);
            this.lvKeySounds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvKeySounds_MouseClick);
            this.lvKeySounds.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvKeySounds_MouseDoubleClick);
            // 
            // chKeys
            // 
            this.chKeys.Text = "Keys";
            this.chKeys.Width = 100;
            // 
            // chVolume
            // 
            this.chVolume.Text = "Volume";
            this.chVolume.Width = 85;
            // 
            // chWindow
            // 
            this.chWindow.Text = "Window";
            this.chWindow.Width = 100;
            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            this.chLocation.Width = 265;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(12, 333);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 21);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReloadDevices
            // 
            this.btnReloadDevices.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadDevices.Image")));
            this.btnReloadDevices.Location = new System.Drawing.Point(324, 16);
            this.btnReloadDevices.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.btnReloadDevices.Name = "btnReloadDevices";
            this.btnReloadDevices.Size = new System.Drawing.Size(23, 21);
            this.btnReloadDevices.TabIndex = 14;
            this.btnReloadDevices.UseVisualStyleBackColor = true;
            this.btnReloadDevices.Click += new System.EventHandler(this.btnReloadDevices_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(572, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAs.Location = new System.Drawing.Point(264, 333);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(120, 21);
            this.btnSaveAs.TabIndex = 9;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.texttospeechToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.form_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // texttospeechToolStripMenuItem
            // 
            this.texttospeechToolStripMenuItem.Name = "texttospeechToolStripMenuItem";
            this.texttospeechToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.texttospeechToolStripMenuItem.Text = "Text-to-speech";
            this.texttospeechToolStripMenuItem.Click += new System.EventHandler(this.texttospeechToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.checkForUpdateToolStripMenuItem.Text = "Check for update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // lblLoopback
            // 
            this.lblLoopback.AutoSize = true;
            this.lblLoopback.Location = new System.Drawing.Point(8, 44);
            this.lblLoopback.Margin = new System.Windows.Forms.Padding(5);
            this.lblLoopback.Name = "lblLoopback";
            this.lblLoopback.Size = new System.Drawing.Size(112, 12);
            this.lblLoopback.TabIndex = 18;
            this.lblLoopback.Text = "Microphone Loopback";
            // 
            // cbLoopbackDevices
            // 
            this.cbLoopbackDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoopbackDevices.FormattingEnabled = true;
            this.cbLoopbackDevices.Location = new System.Drawing.Point(142, 42);
            this.cbLoopbackDevices.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbLoopbackDevices.Name = "cbLoopbackDevices";
            this.cbLoopbackDevices.Size = new System.Drawing.Size(176, 20);
            this.cbLoopbackDevices.TabIndex = 12;
            // 
            // btnPlaySelectedSound
            // 
            this.btnPlaySelectedSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaySelectedSound.Location = new System.Drawing.Point(572, 206);
            this.btnPlaySelectedSound.Name = "btnPlaySelectedSound";
            this.btnPlaySelectedSound.Size = new System.Drawing.Size(75, 40);
            this.btnPlaySelectedSound.TabIndex = 5;
            this.btnPlaySelectedSound.Text = "Play sound";
            this.btnPlaySelectedSound.UseVisualStyleBackColor = true;
            this.btnPlaySelectedSound.Click += new System.EventHandler(this.btnPlaySound_Click);
            // 
            // btnStopAllSounds
            // 
            this.btnStopAllSounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopAllSounds.Location = new System.Drawing.Point(572, 251);
            this.btnStopAllSounds.Name = "btnStopAllSounds";
            this.btnStopAllSounds.Size = new System.Drawing.Size(75, 40);
            this.btnStopAllSounds.TabIndex = 6;
            this.btnStopAllSounds.Text = "Stop all sounds";
            this.btnStopAllSounds.UseVisualStyleBackColor = true;
            this.btnStopAllSounds.Click += new System.EventHandler(this.btnStopAllSounds_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Minimised to the tray.";
            this.notifyIcon1.BalloonTipTitle = "JN Soundboard";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JN Soundboard";
            this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // gbPushToTalk
            // 
            this.gbPushToTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPushToTalk.Controls.Add(this.clearHotkey);
            this.gbPushToTalk.Controls.Add(this.btnReloadWindows);
            this.gbPushToTalk.Controls.Add(this.cbEnablePushToTalk);
            this.gbPushToTalk.Controls.Add(this.label3);
            this.gbPushToTalk.Controls.Add(this.tbPushToTalkKey);
            this.gbPushToTalk.Controls.Add(this.cbWindows);
            this.gbPushToTalk.Controls.Add(this.label4);
            this.gbPushToTalk.Location = new System.Drawing.Point(373, 463);
            this.gbPushToTalk.Name = "gbPushToTalk";
            this.gbPushToTalk.Size = new System.Drawing.Size(274, 89);
            this.gbPushToTalk.TabIndex = 19;
            this.gbPushToTalk.TabStop = false;
            this.gbPushToTalk.Text = "Auto activate push to talk";
            this.gbPushToTalk.Click += new System.EventHandler(this.form_Click);
            // 
            // clearHotkey
            // 
            this.clearHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearHotkey.ForeColor = System.Drawing.Color.Red;
            this.clearHotkey.Location = new System.Drawing.Point(244, 16);
            this.clearHotkey.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.clearHotkey.Name = "clearHotkey";
            this.clearHotkey.Size = new System.Drawing.Size(22, 20);
            this.clearHotkey.TabIndex = 21;
            this.clearHotkey.Text = "X";
            this.clearHotkey.UseVisualStyleBackColor = true;
            this.clearHotkey.Click += new System.EventHandler(this.clearHotkey_Click);
            // 
            // btnReloadWindows
            // 
            this.btnReloadWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadWindows.Image")));
            this.btnReloadWindows.Location = new System.Drawing.Point(244, 40);
            this.btnReloadWindows.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnReloadWindows.Name = "btnReloadWindows";
            this.btnReloadWindows.Size = new System.Drawing.Size(22, 21);
            this.btnReloadWindows.TabIndex = 23;
            this.btnReloadWindows.UseVisualStyleBackColor = true;
            this.btnReloadWindows.Click += new System.EventHandler(this.btnReloadWindows_Click);
            // 
            // cbEnablePushToTalk
            // 
            this.cbEnablePushToTalk.AutoSize = true;
            this.cbEnablePushToTalk.Location = new System.Drawing.Point(8, 66);
            this.cbEnablePushToTalk.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.cbEnablePushToTalk.Name = "cbEnablePushToTalk";
            this.cbEnablePushToTalk.Size = new System.Drawing.Size(56, 16);
            this.cbEnablePushToTalk.TabIndex = 24;
            this.cbEnablePushToTalk.Text = "Enable";
            this.cbEnablePushToTalk.UseVisualStyleBackColor = true;
            this.cbEnablePushToTalk.CheckedChanged += new System.EventHandler(this.cbEnablePushToTalk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Key";
            // 
            // tbPushToTalkKey
            // 
            this.tbPushToTalkKey.Location = new System.Drawing.Point(62, 17);
            this.tbPushToTalkKey.Name = "tbPushToTalkKey";
            this.tbPushToTalkKey.ReadOnly = true;
            this.tbPushToTalkKey.ShortcutsEnabled = false;
            this.tbPushToTalkKey.Size = new System.Drawing.Size(176, 22);
            this.tbPushToTalkKey.TabIndex = 20;
            this.tbPushToTalkKey.Enter += new System.EventHandler(this.tbPushToTalkKey_Enter);
            this.tbPushToTalkKey.Leave += new System.EventHandler(this.tbPushToTalkKey_Leave);
            // 
            // cbWindows
            // 
            this.cbWindows.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWindows.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWindows.FormattingEnabled = true;
            this.cbWindows.Location = new System.Drawing.Point(62, 41);
            this.cbWindows.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(176, 20);
            this.cbWindows.TabIndex = 22;
            this.cbWindows.Leave += new System.EventHandler(this.cbWindows_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Window";
            // 
            // gbAudioDevices
            // 
            this.gbAudioDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAudioDevices.Controls.Add(this.checkBox1);
            this.gbAudioDevices.Controls.Add(this.label1);
            this.gbAudioDevices.Controls.Add(this.label2);
            this.gbAudioDevices.Controls.Add(this.cbLoopbackDevices2);
            this.gbAudioDevices.Controls.Add(this.cbPlaybackDevices2);
            this.gbAudioDevices.Controls.Add(this.label6);
            this.gbAudioDevices.Controls.Add(this.lblPlayback2);
            this.gbAudioDevices.Controls.Add(this.lblPlayback1);
            this.gbAudioDevices.Controls.Add(this.lblLoopback);
            this.gbAudioDevices.Controls.Add(this.btnReloadDevices);
            this.gbAudioDevices.Controls.Add(this.cbPlaybackDevices1);
            this.gbAudioDevices.Controls.Add(this.cbLoopbackDevices);
            this.gbAudioDevices.Location = new System.Drawing.Point(12, 362);
            this.gbAudioDevices.Name = "gbAudioDevices";
            this.gbAudioDevices.Size = new System.Drawing.Size(355, 190);
            this.gbAudioDevices.TabIndex = 10;
            this.gbAudioDevices.TabStop = false;
            this.gbAudioDevices.Text = "Soundboard Audio devices";
            this.gbAudioDevices.Click += new System.EventHandler(this.form_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "(do not choose virtual cable)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Microphone Loopback2";
            // 
            // cbLoopbackDevices2
            // 
            this.cbLoopbackDevices2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoopbackDevices2.FormattingEnabled = true;
            this.cbLoopbackDevices2.Location = new System.Drawing.Point(142, 78);
            this.cbLoopbackDevices2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbLoopbackDevices2.Name = "cbLoopbackDevices2";
            this.cbLoopbackDevices2.Size = new System.Drawing.Size(176, 20);
            this.cbLoopbackDevices2.TabIndex = 21;
            // 
            // cbPlaybackDevices2
            // 
            this.cbPlaybackDevices2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaybackDevices2.FormattingEnabled = true;
            this.cbPlaybackDevices2.Location = new System.Drawing.Point(142, 112);
            this.cbPlaybackDevices2.Margin = new System.Windows.Forms.Padding(5);
            this.cbPlaybackDevices2.Name = "cbPlaybackDevices2";
            this.cbPlaybackDevices2.Size = new System.Drawing.Size(176, 20);
            this.cbPlaybackDevices2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "(do not choose virtual cable)";
            // 
            // lblPlayback2
            // 
            this.lblPlayback2.AutoSize = true;
            this.lblPlayback2.Location = new System.Drawing.Point(8, 117);
            this.lblPlayback2.Margin = new System.Windows.Forms.Padding(5);
            this.lblPlayback2.Name = "lblPlayback2";
            this.lblPlayback2.Size = new System.Drawing.Size(91, 12);
            this.lblPlayback2.TabIndex = 19;
            this.lblPlayback2.Text = "Playback Device 2";
            // 
            // pushToTalkKeyTimer
            // 
            this.pushToTalkKeyTimer.Tick += new System.EventHandler(this.pushToTalkKeyTimer_Tick);
            // 
            // cbEnableLoopback
            // 
            this.cbEnableLoopback.AutoSize = true;
            this.cbEnableLoopback.Location = new System.Drawing.Point(115, 18);
            this.cbEnableLoopback.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.cbEnableLoopback.Name = "cbEnableLoopback";
            this.cbEnableLoopback.Size = new System.Drawing.Size(106, 16);
            this.cbEnableLoopback.TabIndex = 17;
            this.cbEnableLoopback.Text = "Enable Loopback";
            this.cbEnableLoopback.UseVisualStyleBackColor = true;
            this.cbEnableLoopback.CheckedChanged += new System.EventHandler(this.cbEnableLoopback_CheckedChanged);
            // 
            // vsSoundVolume
            // 
            this.vsSoundVolume.Location = new System.Drawing.Point(8, 70);
            this.vsSoundVolume.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.vsSoundVolume.Name = "vsSoundVolume";
            this.vsSoundVolume.Size = new System.Drawing.Size(213, 18);
            this.vsSoundVolume.TabIndex = 100;
            this.vsSoundVolume.TabStop = false;
            this.vsSoundVolume.VolumeChanged += new System.EventHandler(this.vsSoundVolume_VolumeChanged);
            this.vsSoundVolume.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.vsSoundVolume_MouseWheel);
            // 
            // nSoundVolume
            // 
            this.nSoundVolume.Location = new System.Drawing.Point(227, 66);
            this.nSoundVolume.Margin = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.nSoundVolume.Name = "nSoundVolume";
            this.nSoundVolume.Size = new System.Drawing.Size(39, 22);
            this.nSoundVolume.TabIndex = 18;
            this.nSoundVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nSoundVolume.ValueChanged += new System.EventHandler(this.nSoundVolume_ValueChanged);
            // 
            // gbSoundboard
            // 
            this.gbSoundboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSoundboard.Controls.Add(this.cbEnableLoopback2);
            this.gbSoundboard.Controls.Add(this.vsSoundVolume);
            this.gbSoundboard.Controls.Add(this.nSoundVolume);
            this.gbSoundboard.Controls.Add(this.cbEnableLoopback);
            this.gbSoundboard.Controls.Add(this.cbEnableHotkeys);
            this.gbSoundboard.Location = new System.Drawing.Point(373, 362);
            this.gbSoundboard.Name = "gbSoundboard";
            this.gbSoundboard.Size = new System.Drawing.Size(274, 96);
            this.gbSoundboard.TabIndex = 15;
            this.gbSoundboard.TabStop = false;
            this.gbSoundboard.Text = "Soundboard";
            this.gbSoundboard.Click += new System.EventHandler(this.form_Click);
            // 
            // cbEnableLoopback2
            // 
            this.cbEnableLoopback2.AutoSize = true;
            this.cbEnableLoopback2.Location = new System.Drawing.Point(115, 40);
            this.cbEnableLoopback2.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.cbEnableLoopback2.Name = "cbEnableLoopback2";
            this.cbEnableLoopback2.Size = new System.Drawing.Size(112, 16);
            this.cbEnableLoopback2.TabIndex = 101;
            this.cbEnableLoopback2.Text = "Enable Loopback2";
            this.cbEnableLoopback2.UseVisualStyleBackColor = true;
            this.cbEnableLoopback2.CheckedChanged += new System.EventHandler(this.cbEnableLoopback_CheckedChanged);
            // 
            // saveSettingsTimer
            // 
            this.saveSettingsTimer.Interval = 1000;
            this.saveSettingsTimer.Tick += new System.EventHandler(this.saveSettingsTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(390, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 16);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "PotPlayer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 563);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbSoundboard);
            this.Controls.Add(this.gbAudioDevices);
            this.Controls.Add(this.gbPushToTalk);
            this.Controls.Add(this.btnStopAllSounds);
            this.Controls.Add(this.btnPlaySelectedSound);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvKeySounds);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(675, 535);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JN Soundboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Click += new System.EventHandler(this.form_Click);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbPushToTalk.ResumeLayout(false);
            this.gbPushToTalk.PerformLayout();
            this.gbAudioDevices.ResumeLayout(false);
            this.gbAudioDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).EndInit();
            this.gbSoundboard.ResumeLayout(false);
            this.gbSoundboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayback1;
        private System.Windows.Forms.ComboBox cbPlaybackDevices1;
        private System.Windows.Forms.CheckBox cbEnableHotkeys;
        internal System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ListView lvKeySounds;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReloadDevices;
        internal System.Windows.Forms.ColumnHeader chKeys;
        internal System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblLoopback;
        private System.Windows.Forms.ComboBox cbLoopbackDevices;
        private System.Windows.Forms.Button btnPlaySelectedSound;
        private System.Windows.Forms.Button btnStopAllSounds;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox gbPushToTalk;
        private System.Windows.Forms.CheckBox cbEnablePushToTalk;
        private System.Windows.Forms.ComboBox cbWindows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPushToTalkKey;
        private System.Windows.Forms.GroupBox gbAudioDevices;
        private System.Windows.Forms.ToolStripMenuItem texttospeechToolStripMenuItem;
        private System.Windows.Forms.Button btnReloadWindows;
        private System.Windows.Forms.Timer pushToTalkKeyTimer;
        internal System.Windows.Forms.ColumnHeader chWindow;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbPlaybackDevices2;
        private System.Windows.Forms.Label lblPlayback2;
        private System.Windows.Forms.Button clearHotkey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbEnableLoopback;
        private NAudio.Gui.VolumeSlider vsSoundVolume;
        private System.Windows.Forms.NumericUpDown nSoundVolume;
        private System.Windows.Forms.GroupBox gbSoundboard;
        private System.Windows.Forms.Timer saveSettingsTimer;
        internal System.Windows.Forms.ColumnHeader chVolume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoopbackDevices2;
        private System.Windows.Forms.CheckBox cbEnableLoopback2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

