using Audio;
using Configurations;
using System;
using System.Windows.Forms;

namespace Transcript_Tool
{
    public partial class MainWindows : Form
    {
        Config config;
        AudioControl audioControl;
        bool noSignal;
        bool shiftPressed;
        int counter;

        private delegate void UpdatePositionSafe(int position);
        UpdatePositionSafe safeFunction;

        public MainWindows()
        {
            InitializeComponent();
            Initialize();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (!config.ProyectSaved)
            {
                if (MessageBox.Show("The project is not saved. Do you want save it?", "Warning - Not saved project", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveData();
                }
            }
            Environment.Exit(0);
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Play()
        {
            if (audioControl.Play())
            {
                trackVolume.Value = audioControl.GetVolume();
                trackTime.Maximum = audioControl.GetDuration();
            }
        }

        private void AudioControl_UpdatePosition(int position)
        {
            if (!noSignal)
            {
                if (trackTime.InvokeRequired)
                {
                    Invoke(safeFunction, new object[] { position });
                }
                else
                {
                    if (position <= trackTime.Maximum)
                    {
                        trackTime.Value = position;
                        timeTrackSettings(position);
                    }
                }
            }
        }

        private void BtnTranscriptFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                this.txtFileName.Text = openFileDialog1.FileName;
                audioControl.LoadFile(openFileDialog1.FileName);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            audioControl.Stop();
            timer.Stop();
            counter = 0;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void Pause()
        {
            audioControl.Pause();
            timer.Stop();
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            lblVolumeStatus.Text = trackVolume.Value.ToString();
            audioControl.SetVolume(trackVolume.Value);
        }

        private void MainWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            audioControl.UpdatePosition -= AudioControl_UpdatePosition;
            noSignal = true;
            audioControl.Stop();
            audioControl.Dispose();
            audioControl = null;
            config = null;
        }

        private void BtnRew5s_Click(object sender, EventArgs e)
        {
            audioControl.Rewind(5);
        }

        private void btnFwd5sec_Click(object sender, EventArgs e)
        {
            audioControl.Forward(5);
        }

        private void btnRew10s_Click(object sender, EventArgs e)
        {
            audioControl.Rewind(10);
        }

        private void btnFwd10sec_Click(object sender, EventArgs e)
        {
            audioControl.Forward(10);
        }

        private void timeTrackSettings(int position)
        {
            lblTimeStatus.Text = position.ToString() + "s / " + audioControl.GetCurrentPosition();
        }

        private void btnGoPosition_Click(object sender, EventArgs e)
        {
            GotoPosition();
        }

        private void txtGoTo_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumber(e, true);
        }

        private void txtGoTo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPressed = false;
            }
        }

        private void trackTime_Scroll(object sender, EventArgs e)
        {
            var pos = trackTime.Value;
            audioControl.AudioGoToPosition(new TimeSpan(0, 0, pos));
        }

        private void txtRepetitions_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumber(e, false);
        }

        private void txtCutTime_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumber(e, false);
        }

        private void txtPause_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumber(e, false);
        }

        public void OnlyNumber(KeyEventArgs e, bool withTwoPoints)
        {
            if (e.KeyValue == 190 && shiftPressed && withTwoPoints)
            {
                if (!txtGoTo.Text.Contains(":"))
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                e.SuppressKeyPress = false;
            }
            else if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPressed = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left ||
                     e.KeyCode == Keys.Right || e.KeyCode == Keys.Subtract ||
                     e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        private void GotoPosition()
        {
            if (trackTime.Maximum != 0)
            {
                var timeString = txtGoTo.Text;
                if (!timeString.Contains(":"))
                {
                    timeString = "00:" + timeString;
                }
                var time = timeString.Split(new char[] { ':' });
                var timeSpan = new TimeSpan(0, Convert.ToInt32(time[0]), Convert.ToInt32(time[1]));
                audioControl.AudioGoToPosition(timeSpan);
            }
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        void Initialize()
        {
            txtCutTime.Text = "0";
            txtRepetitions.Text = "0";
            txtGoTo.Text = "0";
            txtFileName.Text = string.Empty;

            config = new Config();
            audioControl = new AudioControl();
            audioControl.UpdatePosition += AudioControl_UpdatePosition;
            timer.Tick -= Timer_Tick;
            timer.Tick += Timer_Tick;
            pauseTimer.Tick -= PauseTimer_Tick;
            pauseTimer.Tick += PauseTimer_Tick; 
            safeFunction = new UpdatePositionSafe(AudioControl_UpdatePosition);
            noSignal = false;
        }

        private void btnLoadProject_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void LoadData()
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            var projectName = openFileDialog1.FileName;
            if (!string.IsNullOrEmpty(projectName))
            {
                config.LoadProject(projectName);

                txtCutTime.Text = config.CutTime;
                txtFileName.Text = config.Path;
                txtRepetitions.Text = config.TimesToRepeat;
                txtPause.Text = config.PauseBetTime;
                txtGoTo.Text = config.Position;
            }
        }

        private void SaveData()
        {
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.ShowDialog();
            var projectName = saveFileDialog1.FileName;
            if (!string.IsNullOrEmpty(projectName))
            {
                config.CutTime = txtCutTime.Text;
                config.Path = txtFileName.Text;
                config.TimesToRepeat = txtRepetitions.Text;
                config.PauseBetTime = txtPause.Text;
                config.Position = txtGoTo.Text;
                config.SaveProyect(projectName);
            }
        }

        private void btnplaySettings_Click(object sender, EventArgs e)
        {
            var time = Convert.ToInt32(txtCutTime.Text);
            if (time > 0 )
            {
                counter = 0;
                timer.Interval = time * 1000;
                Play();
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var cutTime = Convert.ToInt32(txtCutTime.Text);

            if (audioControl.GetCurrentSeconds() % cutTime == 0)
            {
                //Hacer una pausa y volver atrás hasta que counter == las repeticiones
                if (counter < Convert.ToInt32(txtRepetitions.Text))
                {
                    counter++;
                    var time = Convert.ToInt32(txtPause.Text);
                    timer.Stop();
                    audioControl.Pause();
                    pauseTimer.Interval = time * 1000;
                    pauseTimer.Start();
                }
                else
                {
                    counter = 0;
                }
            }
        }

        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            audioControl.Rewind(Convert.ToInt32(txtCutTime.Text));
            Play();
            pauseTimer.Stop();
            timer.Start();
        }

    }
}
