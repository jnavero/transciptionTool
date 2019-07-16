namespace Transcript_Tool
{
    partial class MainWindows
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTranscriptFile = new System.Windows.Forms.Button();
            this.lblTranscriptFile = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.gpboxConfig = new System.Windows.Forms.GroupBox();
            this.txtPause = new System.Windows.Forms.TextBox();
            this.lblpause = new System.Windows.Forms.Label();
            this.lblcutTime = new System.Windows.Forms.Label();
            this.txtCutTime = new System.Windows.Forms.TextBox();
            this.txtRepetitions = new System.Windows.Forms.TextBox();
            this.lblReplay = new System.Windows.Forms.Label();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.gpBoxAudio = new System.Windows.Forms.GroupBox();
            this.btnGoPosition = new System.Windows.Forms.Button();
            this.txtGoTo = new System.Windows.Forms.TextBox();
            this.lblGoto = new System.Windows.Forms.Label();
            this.lblTimeStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnRew10s = new System.Windows.Forms.Button();
            this.btnFwd10sec = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnFwd5sec = new System.Windows.Forms.Button();
            this.lblVolumeStatus = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnRew5s = new System.Windows.Forms.Button();
            this.trackTime = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gpboxConfig.SuspendLayout();
            this.gpBoxAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(833, 511);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnTranscriptFile
            // 
            this.btnTranscriptFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranscriptFile.Location = new System.Drawing.Point(900, 5);
            this.btnTranscriptFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranscriptFile.Name = "btnTranscriptFile";
            this.btnTranscriptFile.Size = new System.Drawing.Size(33, 28);
            this.btnTranscriptFile.TabIndex = 1;
            this.btnTranscriptFile.Text = "...";
            this.btnTranscriptFile.UseVisualStyleBackColor = true;
            this.btnTranscriptFile.Click += new System.EventHandler(this.BtnTranscriptFile_Click);
            // 
            // lblTranscriptFile
            // 
            this.lblTranscriptFile.AutoSize = true;
            this.lblTranscriptFile.Location = new System.Drawing.Point(16, 11);
            this.lblTranscriptFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranscriptFile.Name = "lblTranscriptFile";
            this.lblTranscriptFile.Size = new System.Drawing.Size(97, 17);
            this.lblTranscriptFile.TabIndex = 2;
            this.lblTranscriptFile.Text = "Tanscript File:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(121, 7);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(769, 22);
            this.txtFileName.TabIndex = 3;
            // 
            // gpboxConfig
            // 
            this.gpboxConfig.Controls.Add(this.txtPause);
            this.gpboxConfig.Controls.Add(this.lblpause);
            this.gpboxConfig.Controls.Add(this.lblcutTime);
            this.gpboxConfig.Controls.Add(this.txtCutTime);
            this.gpboxConfig.Controls.Add(this.txtRepetitions);
            this.gpboxConfig.Controls.Add(this.lblReplay);
            this.gpboxConfig.Location = new System.Drawing.Point(16, 41);
            this.gpboxConfig.Margin = new System.Windows.Forms.Padding(4);
            this.gpboxConfig.Name = "gpboxConfig";
            this.gpboxConfig.Padding = new System.Windows.Forms.Padding(4);
            this.gpboxConfig.Size = new System.Drawing.Size(917, 103);
            this.gpboxConfig.TabIndex = 4;
            this.gpboxConfig.TabStop = false;
            this.gpboxConfig.Text = "Project configuration";
            // 
            // txtPause
            // 
            this.txtPause.Location = new System.Drawing.Point(371, 27);
            this.txtPause.Name = "txtPause";
            this.txtPause.Size = new System.Drawing.Size(35, 22);
            this.txtPause.TabIndex = 5;
            this.txtPause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPause_KeyDown);
            // 
            // lblpause
            // 
            this.lblpause.AutoSize = true;
            this.lblpause.Location = new System.Drawing.Point(198, 30);
            this.lblpause.Name = "lblpause";
            this.lblpause.Size = new System.Drawing.Size(167, 17);
            this.lblpause.TabIndex = 4;
            this.lblpause.Text = "Pause between times (s):";
            // 
            // lblcutTime
            // 
            this.lblcutTime.AutoSize = true;
            this.lblcutTime.Location = new System.Drawing.Point(29, 66);
            this.lblcutTime.Name = "lblcutTime";
            this.lblcutTime.Size = new System.Drawing.Size(88, 17);
            this.lblcutTime.TabIndex = 3;
            this.lblcutTime.Text = "Cut time (s): ";
            // 
            // txtCutTime
            // 
            this.txtCutTime.Location = new System.Drawing.Point(123, 63);
            this.txtCutTime.Name = "txtCutTime";
            this.txtCutTime.Size = new System.Drawing.Size(37, 22);
            this.txtCutTime.TabIndex = 2;
            this.txtCutTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCutTime_KeyDown);
            // 
            // txtRepetitions
            // 
            this.txtRepetitions.Location = new System.Drawing.Point(123, 27);
            this.txtRepetitions.Name = "txtRepetitions";
            this.txtRepetitions.Size = new System.Drawing.Size(37, 22);
            this.txtRepetitions.TabIndex = 1;
            this.txtRepetitions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRepetitions_KeyDown);
            // 
            // lblReplay
            // 
            this.lblReplay.AutoSize = true;
            this.lblReplay.Location = new System.Drawing.Point(7, 30);
            this.lblReplay.Name = "lblReplay";
            this.lblReplay.Size = new System.Drawing.Size(110, 17);
            this.lblReplay.TabIndex = 0;
            this.lblReplay.Text = "Replays (times):";
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadProject.Location = new System.Drawing.Point(160, 511);
            this.btnLoadProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(100, 28);
            this.btnLoadProject.TabIndex = 5;
            this.btnLoadProject.Text = "&Load project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveProject.Location = new System.Drawing.Point(268, 511);
            this.btnSaveProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(100, 28);
            this.btnSaveProject.TabIndex = 6;
            this.btnSaveProject.Text = "&Save project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewProject.Location = new System.Drawing.Point(16, 511);
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(100, 28);
            this.btnNewProject.TabIndex = 7;
            this.btnNewProject.Text = "&New project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // gpBoxAudio
            // 
            this.gpBoxAudio.Controls.Add(this.btnGoPosition);
            this.gpBoxAudio.Controls.Add(this.txtGoTo);
            this.gpBoxAudio.Controls.Add(this.lblGoto);
            this.gpBoxAudio.Controls.Add(this.lblTimeStatus);
            this.gpBoxAudio.Controls.Add(this.lblTime);
            this.gpBoxAudio.Controls.Add(this.btnRew10s);
            this.gpBoxAudio.Controls.Add(this.btnFwd10sec);
            this.gpBoxAudio.Controls.Add(this.btnPause);
            this.gpBoxAudio.Controls.Add(this.btnFwd5sec);
            this.gpBoxAudio.Controls.Add(this.lblVolumeStatus);
            this.gpBoxAudio.Controls.Add(this.lblVolume);
            this.gpBoxAudio.Controls.Add(this.trackVolume);
            this.gpBoxAudio.Controls.Add(this.btnRew5s);
            this.gpBoxAudio.Controls.Add(this.trackTime);
            this.gpBoxAudio.Controls.Add(this.btnStop);
            this.gpBoxAudio.Controls.Add(this.btnPlay);
            this.gpBoxAudio.Location = new System.Drawing.Point(16, 152);
            this.gpBoxAudio.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxAudio.Name = "gpBoxAudio";
            this.gpBoxAudio.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxAudio.Size = new System.Drawing.Size(917, 329);
            this.gpBoxAudio.TabIndex = 8;
            this.gpBoxAudio.TabStop = false;
            this.gpBoxAudio.Text = "Audio tools and analytics";
            // 
            // btnGoPosition
            // 
            this.btnGoPosition.Location = new System.Drawing.Point(257, 97);
            this.btnGoPosition.Name = "btnGoPosition";
            this.btnGoPosition.Size = new System.Drawing.Size(67, 28);
            this.btnGoPosition.TabIndex = 15;
            this.btnGoPosition.Text = "Go";
            this.btnGoPosition.UseVisualStyleBackColor = true;
            this.btnGoPosition.Click += new System.EventHandler(this.btnGoPosition_Click);
            // 
            // txtGoTo
            // 
            this.txtGoTo.Location = new System.Drawing.Point(172, 100);
            this.txtGoTo.Name = "txtGoTo";
            this.txtGoTo.Size = new System.Drawing.Size(72, 22);
            this.txtGoTo.TabIndex = 14;
            this.txtGoTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoTo_KeyDown);
            this.txtGoTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoTo_KeyUp);
            // 
            // lblGoto
            // 
            this.lblGoto.AutoSize = true;
            this.lblGoto.Location = new System.Drawing.Point(7, 103);
            this.lblGoto.Name = "lblGoto";
            this.lblGoto.Size = new System.Drawing.Size(159, 17);
            this.lblGoto.TabIndex = 13;
            this.lblGoto.Text = "Go to Position (mm:ss): ";
            // 
            // lblTimeStatus
            // 
            this.lblTimeStatus.AutoSize = true;
            this.lblTimeStatus.Location = new System.Drawing.Point(60, 65);
            this.lblTimeStatus.Name = "lblTimeStatus";
            this.lblTimeStatus.Size = new System.Drawing.Size(36, 17);
            this.lblTimeStatus.TabIndex = 12;
            this.lblTimeStatus.Text = "0:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(7, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 17);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time: ";
            // 
            // btnRew10s
            // 
            this.btnRew10s.Location = new System.Drawing.Point(60, 293);
            this.btnRew10s.Margin = new System.Windows.Forms.Padding(4);
            this.btnRew10s.Name = "btnRew10s";
            this.btnRew10s.Size = new System.Drawing.Size(67, 28);
            this.btnRew10s.TabIndex = 10;
            this.btnRew10s.Text = "&-10 sec";
            this.btnRew10s.UseVisualStyleBackColor = true;
            this.btnRew10s.Click += new System.EventHandler(this.btnRew10s_Click);
            // 
            // btnFwd10sec
            // 
            this.btnFwd10sec.Location = new System.Drawing.Point(435, 293);
            this.btnFwd10sec.Margin = new System.Windows.Forms.Padding(4);
            this.btnFwd10sec.Name = "btnFwd10sec";
            this.btnFwd10sec.Size = new System.Drawing.Size(67, 28);
            this.btnFwd10sec.TabIndex = 9;
            this.btnFwd10sec.Text = "&+10 sec";
            this.btnFwd10sec.UseVisualStyleBackColor = true;
            this.btnFwd10sec.Click += new System.EventHandler(this.btnFwd10sec_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(285, 293);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(67, 28);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnFwd5sec
            // 
            this.btnFwd5sec.Location = new System.Drawing.Point(360, 293);
            this.btnFwd5sec.Margin = new System.Windows.Forms.Padding(4);
            this.btnFwd5sec.Name = "btnFwd5sec";
            this.btnFwd5sec.Size = new System.Drawing.Size(67, 28);
            this.btnFwd5sec.TabIndex = 7;
            this.btnFwd5sec.Text = "&+5 sec";
            this.btnFwd5sec.UseVisualStyleBackColor = true;
            this.btnFwd5sec.Click += new System.EventHandler(this.btnFwd5sec_Click);
            // 
            // lblVolumeStatus
            // 
            this.lblVolumeStatus.AutoSize = true;
            this.lblVolumeStatus.Location = new System.Drawing.Point(853, 304);
            this.lblVolumeStatus.Name = "lblVolumeStatus";
            this.lblVolumeStatus.Size = new System.Drawing.Size(32, 17);
            this.lblVolumeStatus.TabIndex = 6;
            this.lblVolumeStatus.Text = "100";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(846, 65);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(55, 17);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volume";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(853, 86);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(56, 220);
            this.trackVolume.TabIndex = 4;
            this.trackVolume.Value = 100;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // btnRew5s
            // 
            this.btnRew5s.Location = new System.Drawing.Point(135, 293);
            this.btnRew5s.Margin = new System.Windows.Forms.Padding(4);
            this.btnRew5s.Name = "btnRew5s";
            this.btnRew5s.Size = new System.Drawing.Size(67, 28);
            this.btnRew5s.TabIndex = 3;
            this.btnRew5s.Text = "&-5 sec";
            this.btnRew5s.UseVisualStyleBackColor = true;
            this.btnRew5s.Click += new System.EventHandler(this.BtnRew5s_Click);
            // 
            // trackTime
            // 
            this.trackTime.Location = new System.Drawing.Point(8, 23);
            this.trackTime.Margin = new System.Windows.Forms.Padding(4);
            this.trackTime.Maximum = 0;
            this.trackTime.Name = "trackTime";
            this.trackTime.Size = new System.Drawing.Size(901, 56);
            this.trackTime.TabIndex = 2;
            this.trackTime.Scroll += new System.EventHandler(this.trackTime_Scroll);
            this.trackTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackTime_MouseDown);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(529, 293);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(210, 293);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 28);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 554);
            this.Controls.Add(this.gpBoxAudio);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.btnLoadProject);
            this.Controls.Add(this.gpboxConfig);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblTranscriptFile);
            this.Controls.Add(this.btnTranscriptFile);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindows";
            this.Text = "Transcript tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindows_FormClosing);
            this.gpboxConfig.ResumeLayout(false);
            this.gpboxConfig.PerformLayout();
            this.gpBoxAudio.ResumeLayout(false);
            this.gpBoxAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTranscriptFile;
        private System.Windows.Forms.Label lblTranscriptFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox gpboxConfig;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.GroupBox gpBoxAudio;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.Button btnRew5s;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label lblVolumeStatus;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnFwd5sec;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRew10s;
        private System.Windows.Forms.Button btnFwd10sec;
        private System.Windows.Forms.Label lblTimeStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnGoPosition;
        private System.Windows.Forms.TextBox txtGoTo;
        private System.Windows.Forms.Label lblGoto;
        private System.Windows.Forms.Label lblcutTime;
        private System.Windows.Forms.TextBox txtCutTime;
        private System.Windows.Forms.TextBox txtRepetitions;
        private System.Windows.Forms.Label lblReplay;
        private System.Windows.Forms.Label lblpause;
        private System.Windows.Forms.TextBox txtPause;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

