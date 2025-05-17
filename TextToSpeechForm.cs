using System;
using System.Diagnostics;
using System.IO;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JNSoundboard
{
    public partial class TextToSpeechForm : Form
    {
        MainForm mainForm;
        SpeechSynthesizer _synth = null;
        SpeechSynthesizer synth
        {
            get
            {
                if (_synth == null)
                {
                    _synth = new SpeechSynthesizer();
                }
                return _synth;
            }
            set
            {
                _synth = value;
            }
        }
        Prompt previewPrompt;

        internal static int lastGenderIndex = 0;
        internal static bool lastAddToListChecked = false;
        internal static string lastWindow = "";
        internal static float lastSoundVolume = 1;

        public VoiceGender Gender { get; set; } = VoiceGender.Neutral;

        public TextToSpeechForm()
        {
            InitializeComponent();
        }

        private void TTS_Load(object sender, EventArgs e)
        {
            mainForm = Application.OpenForms[0] as MainForm;

            cbGender.SelectedIndex = lastGenderIndex;
            Gender = (VoiceGender)cbGender.SelectedIndex + 1; //1 = Male; 2 = Female

            cbAddToList.Checked = lastAddToListChecked;
            tbKeys.Enabled = lastAddToListChecked;
            clearHotkey.Enabled = lastAddToListChecked;
            cbWindows.Enabled = lastAddToListChecked;
            btnReloadWindows.Enabled = lastAddToListChecked;
            vsSoundVolume.Enabled = lastAddToListChecked;
            nSoundVolume.Enabled = lastAddToListChecked;

            vsSoundVolume.Volume = lastSoundVolume;

            Helper.getWindows(cbWindows);
            Helper.selectWindow(cbWindows, lastWindow);
        }

        private void btnCreateWAV_Click(object sender, EventArgs e)
        {
            string[] fileLocation;

            if (!string.IsNullOrWhiteSpace(tbText.Text))
            {
                //show dialog
                var diag = new SaveFileDialog();
                diag.FileName = tbText.Text;
                diag.Filter = "WAV files|*.wav";

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = new string[] { diag.FileName };
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No text entered");
                return;
            }

            //create file
            synth.SelectVoiceByHints(Gender, VoiceAge.NotSet);
            synth.SetOutputToWaveFile(fileLocation[0]);

            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(tbText.Text);

            synth.Speak(builder);
            synth.Dispose();
            synth = null;

            if (cbAddToList.Checked)
            {
                //add to list
                if (!Helper.stringToKeysArray(tbKeys.Text, out Keyboard.Keys[] keysArray, out _)) keysArray = new Keyboard.Keys[] { };

                string windowText = (cbWindows.SelectedIndex > 0) ? cbWindows.Text : "";

                mainForm.soundHotkeys.Add(new XMLSettings.SoundHotkey(keysArray, vsSoundVolume.Volume, windowText, fileLocation));

                var newItem = new ListViewItem(tbKeys.Text);
                newItem.SubItems.Add(vsSoundVolume.Volume == 1 ? "" : Helper.linearVolumeToString(vsSoundVolume.Volume));
                newItem.SubItems.Add(windowText);
                newItem.SubItems.Add(fileLocation[0]);

                newItem.ToolTipText = Helper.getFileNamesTooltip(fileLocation);

                mainForm.lvKeySounds.Items.Add(newItem);

                mainForm.sortHotkeys();

                //remember last used options
                lastWindow = cbWindows.Text;
                lastSoundVolume = vsSoundVolume.Volume;
            }

            //remember last used options
            lastGenderIndex = cbGender.SelectedIndex;
            lastAddToListChecked = cbAddToList.Checked;

            MessageBox.Show("Saved: " + fileLocation[0]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (previewPrompt != null) StopPreview();
            this.Close();
        }

        private void tbKeys_Enter(object sender, EventArgs e)
        {
            keysTimer.Enabled = true;
        }

        private void tbKeys_Leave(object sender, EventArgs e)
        {
            keysTimer.Enabled = false;
            keysTimer.Interval = 100;
        }


        int lastAmountPressed = 0;
        private void keysTimer_Tick(object sender, EventArgs e)
        {
            keysTimer.Interval = 10; //lowering the interval to avoid missing key presses (e.g. when an input is corrected)

            var keysData = Keyboard.getKeys(lastAmountPressed, tbKeys.Text);

            lastAmountPressed = keysData.Item1;
            tbKeys.Text = keysData.Item2;
        }

        private void clearHotkey_Click(object sender, EventArgs e)
        {
            tbKeys.Text = "";
        }

        private void preview_Click(object sender, EventArgs e)
        {
            StopPreview();

            if (!string.IsNullOrWhiteSpace(tbText.Text))
            {
                synth.SelectVoiceByHints(Gender, VoiceAge.NotSet);
                previewPrompt = synth.SpeakAsync(tbText.Text);
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = (VoiceGender)cbGender.SelectedIndex + 1; //1 = Male; 2 = Female
        }

        private void stopPreview_Click(object sender, EventArgs e)
        {
            StopPreview();
        }

        private void StopPreview()
        {
            if (synth.State == SynthesizerState.Speaking) synth.SpeakAsyncCancel(previewPrompt);
        }

        private void btnReloadWindows_Click(object sender, EventArgs e)
        {
            Helper.getWindows(cbWindows);
        }

        private void cbAddToList_CheckedChanged(object sender, EventArgs e)
        {
            tbKeys.Enabled = cbAddToList.Checked;
            clearHotkey.Enabled = cbAddToList.Checked;
            cbWindows.Enabled = cbAddToList.Checked;
            btnReloadWindows.Enabled = cbAddToList.Checked;
            vsSoundVolume.Enabled = cbAddToList.Checked;
            nSoundVolume.Enabled = cbAddToList.Checked;
        }


        private bool volumeChangedBySlider = false;
        private bool volumeChangedByField = false;
        public void vsSoundVolume_VolumeChanged(object sender, EventArgs e)
        {
            //prevent infinite or skipped changes
            if (volumeChangedByField)
            {
                volumeChangedByField = false;

                return;
            }

            volumeChangedBySlider = true;

            nSoundVolume.Value = Helper.linearVolumeToInteger(vsSoundVolume.Volume);
        }

        public void vsSoundVolume_MouseWheel(object sender, MouseEventArgs e)
        {
            vsSoundVolume.Volume = Helper.getNewSoundVolume(vsSoundVolume.Volume, e.Delta);
        }

        public void nSoundVolume_ValueChanged(object sender, EventArgs e)
        {
            //prevent infinite or skipped changes
            if (volumeChangedBySlider)
            {
                volumeChangedBySlider = false;

                return;
            }

            volumeChangedByField = true;

            vsSoundVolume.Volume = (float)(nSoundVolume.Value / 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = GetSafeFileName(tbText.Text) + ".wav";
            synth = new SpeechSynthesizer();
            //create file
            synth.SelectVoiceByHints(Gender, VoiceAge.NotSet);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), name);
            synth.SetOutputToWaveFile(path);
            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(tbText.Text);
            synth.Speak(builder);
            synth.Dispose();
            synth = null;
            string[] locations = new string[] { path };

            //add to list
            if (!Helper.stringToKeysArray(tbKeys.Text, out Keyboard.Keys[] keysArray, out _)) keysArray = new Keyboard.Keys[] { };

            string windowText = (cbWindows.SelectedIndex > 0) ? cbWindows.Text : "";

            mainForm.soundHotkeys.Add(new XMLSettings.SoundHotkey(keysArray, vsSoundVolume.Volume, windowText, locations));

            var newItem = new ListViewItem(tbKeys.Text);
            newItem.SubItems.Add(vsSoundVolume.Volume == 1 ? "" : Helper.linearVolumeToString(vsSoundVolume.Volume));
            newItem.SubItems.Add(windowText);
            newItem.SubItems.Add(path);

            newItem.ToolTipText = Helper.getFileNamesTooltip(locations);

            mainForm.lvKeySounds.Items.Add(newItem);

            mainForm.sortHotkeys();

            //remember last used options
            lastWindow = cbWindows.Text;
            lastSoundVolume = vsSoundVolume.Volume;

            //remember last used options
            lastGenderIndex = cbGender.SelectedIndex;
            lastAddToListChecked = cbAddToList.Checked;

            mainForm.playSound(path);
        }
        static string GetSafeFileName(string input)
        {
            // 取代無效字元為下底線
            string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            string invalidRegex = $"[{invalidChars}]";
            string safeName = Regex.Replace(input, invalidRegex, "_");

            // 檢查保留名稱
            string[] reservedNames = { "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };
            if (Array.Exists(reservedNames, name => name.Equals(safeName, StringComparison.OrdinalIgnoreCase)))
            {
                safeName = "_" + safeName;
            }

            // 移除前後空格並確保不為空
            safeName = safeName.Trim();
            return string.IsNullOrEmpty(safeName) ? "DefaultFileName" : safeName;
        }
    }
}
