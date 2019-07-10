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
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.gpBoxAudio = new System.Windows.Forms.GroupBox();
            this.lblVolumeStatus = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnRew5s = new System.Windows.Forms.Button();
            this.trackTime = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.gpboxConfig.Location = new System.Drawing.Point(16, 41);
            this.gpboxConfig.Margin = new System.Windows.Forms.Padding(4);
            this.gpboxConfig.Name = "gpboxConfig";
            this.gpboxConfig.Padding = new System.Windows.Forms.Padding(4);
            this.gpboxConfig.Size = new System.Drawing.Size(917, 103);
            this.gpboxConfig.TabIndex = 4;
            this.gpboxConfig.TabStop = false;
            this.gpboxConfig.Text = "Project configuration";
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
            // 
            // gpBoxAudio
            // 
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
            // lblVolumeStatus
            // 
            this.lblVolumeStatus.AutoSize = true;
            this.lblVolumeStatus.Location = new System.Drawing.Point(872, 304);
            this.lblVolumeStatus.Name = "lblVolumeStatus";
            this.lblVolumeStatus.Size = new System.Drawing.Size(16, 17);
            this.lblVolumeStatus.TabIndex = 6;
            this.lblVolumeStatus.Text = "0";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(811, 304);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(63, 17);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volume: ";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(853, 65);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(56, 241);
            this.trackVolume.TabIndex = 4;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // btnRew5s
            // 
            this.btnRew5s.Location = new System.Drawing.Point(81, 248);
            this.btnRew5s.Margin = new System.Windows.Forms.Padding(4);
            this.btnRew5s.Name = "btnRew5s";
            this.btnRew5s.Size = new System.Drawing.Size(100, 28);
            this.btnRew5s.TabIndex = 3;
            this.btnRew5s.Text = "-5 sec";
            this.btnRew5s.UseVisualStyleBackColor = true;
            this.btnRew5s.Click += new System.EventHandler(this.BtnRew5s_Click);
            // 
            // trackTime
            // 
            this.trackTime.Location = new System.Drawing.Point(8, 23);
            this.trackTime.Margin = new System.Windows.Forms.Padding(4);
            this.trackTime.Name = "trackTime";
            this.trackTime.Size = new System.Drawing.Size(901, 56);
            this.trackTime.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(416, 248);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(189, 248);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 28);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
    }
}

