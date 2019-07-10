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

        private delegate void UpdatePositionSafe(int position);


        public MainWindows()
        {
            config = new Config();
            audioControl = new AudioControl();
            audioControl.UpdatePosition += AudioControl_UpdatePosition;

            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (!config.ProyectSaved)
            {
                if(MessageBox.Show("The project is not saved. Do you want save it?", "Warning - Not saved project", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    config.SaveProyect();
                }
            }
            Environment.Exit(0);
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if(audioControl.Play())
            {
                trackBar1.Maximum = audioControl.GetDuration();
            }
        }

        private void AudioControl_UpdatePosition(int position)
        {
            if(trackBar1.InvokeRequired)
            {
                var d = new UpdatePositionSafe(AudioControl_UpdatePosition);
                Invoke(d, new object[] { position });
            }
            else
            {
                if (position <= trackBar1.Maximum)
                {
                    trackBar1.Value = position;
                }
            }
        }

        private void BtnTranscriptFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if(!string.IsNullOrEmpty(openFileDialog1.FileName))
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
    }
}
