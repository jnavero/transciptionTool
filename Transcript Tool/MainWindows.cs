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
        bool endSignal;

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
            endSignal = false;

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
            if (!endSignal)
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

        private void BtnRew5s_Click(object sender, EventArgs e)
        {
            audioControl.Rewind(5);
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            lblVolumeStatus.Text = trackVolume.Value.ToString();
            audioControl.SetVolume(trackVolume.Value);
        }

        private void MainWindows_FormClosing(object sender, FormClosingEventArgs e)
        {

            endSignal = true;
            audioControl.UpdatePosition -= AudioControl_UpdatePosition;
            audioControl.Stop();
            audioControl.Dispose();
            audioControl = null;
            config = null;
        }
    }
}
