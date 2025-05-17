﻿namespace JNSoundboard
{
    partial class AddEditHotkeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditHotkeyForm));
            this.tbKeys = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.labelKeys = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.btnBrowseSoundLocation = new System.Windows.Forms.Button();
            this.keysTimer = new System.Windows.Forms.Timer(this.components);
            this.btnReloadWindows = new System.Windows.Forms.Button();
            this.cbWindows = new System.Windows.Forms.ComboBox();
            this.clearHotkey = new System.Windows.Forms.Button();
            this.pnAddEditSound = new System.Windows.Forms.Panel();
            this.nSoundVolume = new System.Windows.Forms.NumericUpDown();
            this.vsSoundVolume = new NAudio.Gui.VolumeSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnAddEditSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKeys
            // 
            this.tbKeys.Location = new System.Drawing.Point(12, 101);
            this.tbKeys.Name = "tbKeys";
            this.tbKeys.ReadOnly = true;
            this.tbKeys.ShortcutsEnabled = false;
            this.tbKeys.Size = new System.Drawing.Size(213, 22);
            this.tbKeys.TabIndex = 2;
            this.tbKeys.Enter += new System.EventHandler(this.tbKeys_Enter);
            this.tbKeys.Leave += new System.EventHandler(this.tbKeys_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(114, 228);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 21);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(195, 228);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(12, 60);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(213, 22);
            this.tbLocation.TabIndex = 0;
            // 
            // labelKeys
            // 
            this.labelKeys.AutoSize = true;
            this.labelKeys.Location = new System.Drawing.Point(12, 86);
            this.labelKeys.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelKeys.Name = "labelKeys";
            this.labelKeys.Size = new System.Drawing.Size(28, 12);
            this.labelKeys.TabIndex = 4;
            this.labelKeys.Text = "Keys";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(12, 45);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(77, 12);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location of file";
            // 
            // btnBrowseSoundLocation
            // 
            this.btnBrowseSoundLocation.Location = new System.Drawing.Point(231, 59);
            this.btnBrowseSoundLocation.Name = "btnBrowseSoundLocation";
            this.btnBrowseSoundLocation.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseSoundLocation.TabIndex = 1;
            this.btnBrowseSoundLocation.Text = "...";
            this.btnBrowseSoundLocation.UseVisualStyleBackColor = true;
            this.btnBrowseSoundLocation.Click += new System.EventHandler(this.btnBrowseSoundLocation_Click);
            // 
            // keysTimer
            // 
            this.keysTimer.Tick += new System.EventHandler(this.keysTimer_Tick);
            // 
            // btnReloadWindows
            // 
            this.btnReloadWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadWindows.Image")));
            this.btnReloadWindows.Location = new System.Drawing.Point(219, 54);
            this.btnReloadWindows.Name = "btnReloadWindows";
            this.btnReloadWindows.Size = new System.Drawing.Size(22, 21);
            this.btnReloadWindows.TabIndex = 7;
            this.btnReloadWindows.UseVisualStyleBackColor = true;
            this.btnReloadWindows.Click += new System.EventHandler(this.btnReloadWindows_Click);
            // 
            // cbWindows
            // 
            this.cbWindows.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWindows.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWindows.FormattingEnabled = true;
            this.cbWindows.Location = new System.Drawing.Point(0, 55);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(213, 20);
            this.cbWindows.TabIndex = 6;
            // 
            // clearHotkey
            // 
            this.clearHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearHotkey.ForeColor = System.Drawing.Color.Red;
            this.clearHotkey.Location = new System.Drawing.Point(231, 100);
            this.clearHotkey.Name = "clearHotkey";
            this.clearHotkey.Size = new System.Drawing.Size(22, 20);
            this.clearHotkey.TabIndex = 3;
            this.clearHotkey.Text = "X";
            this.clearHotkey.UseVisualStyleBackColor = true;
            this.clearHotkey.Click += new System.EventHandler(this.clearHotkey_Click);
            // 
            // pnAddEditSound
            // 
            this.pnAddEditSound.Controls.Add(this.nSoundVolume);
            this.pnAddEditSound.Controls.Add(this.vsSoundVolume);
            this.pnAddEditSound.Controls.Add(this.label3);
            this.pnAddEditSound.Controls.Add(this.label2);
            this.pnAddEditSound.Controls.Add(this.btnReloadWindows);
            this.pnAddEditSound.Controls.Add(this.cbWindows);
            this.pnAddEditSound.Location = new System.Drawing.Point(12, 127);
            this.pnAddEditSound.Name = "pnAddEditSound";
            this.pnAddEditSound.Size = new System.Drawing.Size(258, 75);
            this.pnAddEditSound.TabIndex = 4;
            // 
            // nSoundVolume
            // 
            this.nSoundVolume.Location = new System.Drawing.Point(219, 15);
            this.nSoundVolume.Name = "nSoundVolume";
            this.nSoundVolume.Size = new System.Drawing.Size(39, 22);
            this.nSoundVolume.TabIndex = 5;
            this.nSoundVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nSoundVolume.ValueChanged += new System.EventHandler(this.nSoundVolume_ValueChanged);
            // 
            // vsSoundVolume
            // 
            this.vsSoundVolume.Location = new System.Drawing.Point(0, 15);
            this.vsSoundVolume.Name = "vsSoundVolume";
            this.vsSoundVolume.Size = new System.Drawing.Size(213, 18);
            this.vsSoundVolume.TabIndex = 100;
            this.vsSoundVolume.TabStop = false;
            this.vsSoundVolume.VolumeChanged += new System.EventHandler(this.vsSoundVolume_VolumeChanged);
            this.vsSoundVolume.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.vsSoundVolume_MouseWheel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custom volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Restrict to a certain window";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "拆分為獨立撥放聲音";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddEditHotkeyForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pnAddEditSound);
            this.Controls.Add(this.clearHotkey);
            this.Controls.Add(this.btnBrowseSoundLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelKeys);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditHotkeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/edit sound";
            this.Load += new System.EventHandler(this.AddEditSoundKeys_Load);
            this.pnAddEditSound.ResumeLayout(false);
            this.pnAddEditSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeys;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label labelKeys;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button btnBrowseSoundLocation;
        private System.Windows.Forms.Timer keysTimer;
        private System.Windows.Forms.Button btnReloadWindows;
        private System.Windows.Forms.ComboBox cbWindows;
        private System.Windows.Forms.Button clearHotkey;
        private System.Windows.Forms.Panel pnAddEditSound;
        private NAudio.Gui.VolumeSlider vsSoundVolume;
        private System.Windows.Forms.NumericUpDown nSoundVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}