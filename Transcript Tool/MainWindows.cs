using Audio;
using Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transcript_Tool
{
    public partial class MainWindows : Form
    {
        Config config;
        AudioControl audioControl;
        bool noSignal;
        bool shiftPressed;

        private delegate void UpdatePositionSafe(int position);
        UpdatePositionSafe safeFunction;

        public MainWindows()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            config = new Config();
            audioControl = new AudioControl();
            audioControl.UpdatePosition += AudioControl_UpdatePosition;
            safeFunction = new UpdatePositionSafe(AudioControl_UpdatePosition);
            noSignal = false;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (!config.ProyectSaved)
            {
                if (MessageBox.Show("The project is not saved. Do you want save it?", "Warning - Not saved project", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    config.SaveProyect();
                }
            }
            Environment.Exit(0);
        }

        private void BtnPlay_Click(object sender, EventArgs e)
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
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            audioControl.Pause();
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            lblVolumeStatus.Text = trackVolume.Value.ToString();
            audioControl.SetVolume(trackVolume.Value);
        }

        private void MainWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            noSignal = true;
            audioControl.UpdatePosition -= AudioControl_UpdatePosition;
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

        private void trackTime_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnGoPosition_Click(object sender, EventArgs e)
        {
            if(trackTime.Maximum != 0)
            {
                var timeString = txtGoTo.Text;
                if (!timeString.Contains(":"))
                {
                    timeString = "00:" + timeString;
                }

                var time = txtGoTo.Text.Split(new char[] { ':' });

                var timeSplit = new TimeSpan(0, Convert.ToInt32(time[0]), Convert.ToInt32(time[1]));
            }
        }

        private void txtGoTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 190 && shiftPressed)
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

        private void txtGoTo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPressed = false;
            }
        }
    }
}
