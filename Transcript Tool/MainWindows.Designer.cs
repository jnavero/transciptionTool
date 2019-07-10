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
            this.btnPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnRew5s = new System.Windows.Forms.Button();
            this.gpBoxAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(625, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnTranscriptFile
            // 
            this.btnTranscriptFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranscriptFile.Location = new System.Drawing.Point(675, 4);
            this.btnTranscriptFile.Name = "btnTranscriptFile";
            this.btnTranscriptFile.Size = new System.Drawing.Size(25, 23);
            this.btnTranscriptFile.TabIndex = 1;
            this.btnTranscriptFile.Text = "...";
            this.btnTranscriptFile.UseVisualStyleBackColor = true;
            this.btnTranscriptFile.Click += new System.EventHandler(this.BtnTranscriptFile_Click);
            // 
            // lblTranscriptFile
            // 
            this.lblTranscriptFile.AutoSize = true;
            this.lblTranscriptFile.Location = new System.Drawing.Point(12, 9);
            this.lblTranscriptFile.Name = "lblTranscriptFile";
            this.lblTranscriptFile.Size = new System.Drawing.Size(73, 13);
            this.lblTranscriptFile.TabIndex = 2;
            this.lblTranscriptFile.Text = "Tanscript File:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(91, 6);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(578, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // gpboxConfig
            // 
            this.gpboxConfig.Location = new System.Drawing.Point(12, 33);
            this.gpboxConfig.Name = "gpboxConfig";
            this.gpboxConfig.Size = new System.Drawing.Size(688, 108);
            this.gpboxConfig.TabIndex = 4;
            this.gpboxConfig.TabStop = false;
            this.gpboxConfig.Text = "Project configuration";
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadProject.Location = new System.Drawing.Point(120, 415);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProject.TabIndex = 5;
            this.btnLoadProject.Text = "&Load project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveProject.Location = new System.Drawing.Point(201, 415);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProject.TabIndex = 6;
            this.btnSaveProject.Text = "&Save project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            // 
            // btnNewProject
            // 
            this.btnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewProject.Location = new System.Drawing.Point(12, 415);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(75, 23);
            this.btnNewProject.TabIndex = 7;
            this.btnNewProject.Text = "&New project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            // 
            // gpBoxAudio
            // 
            this.gpBoxAudio.Controls.Add(this.btnRew5s);
            this.gpBoxAudio.Controls.Add(this.trackBar1);
            this.gpBoxAudio.Controls.Add(this.btnStop);
            this.gpBoxAudio.Controls.Add(this.btnPlay);
            this.gpBoxAudio.Location = new System.Drawing.Point(12, 160);
            this.gpBoxAudio.Name = "gpBoxAudio";
            this.gpBoxAudio.Size = new System.Drawing.Size(688, 192);
            this.gpBoxAudio.TabIndex = 8;
            this.gpBoxAudio.TabStop = false;
            this.gpBoxAudio.Text = "Audio tools and analytics";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(257, 163);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(607, 163);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 28);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(676, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // btnRew5s
            // 
            this.btnRew5s.Location = new System.Drawing.Point(176, 163);
            this.btnRew5s.Name = "btnRew5s";
            this.btnRew5s.Size = new System.Drawing.Size(75, 23);
            this.btnRew5s.TabIndex = 3;
            this.btnRew5s.Text = "-5 sec";
            this.btnRew5s.UseVisualStyleBackColor = true;
            this.btnRew5s.Click += new System.EventHandler(this.BtnRew5s_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.gpBoxAudio);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.btnLoadProject);
            this.Controls.Add(this.gpboxConfig);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblTranscriptFile);
            this.Controls.Add(this.btnTranscriptFile);
            this.Controls.Add(this.btnExit);
            this.Name = "MainWindows";
            this.Text = "Transcript tool";
            this.gpBoxAudio.ResumeLayout(false);
            this.gpBoxAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnRew5s;
    }
}

