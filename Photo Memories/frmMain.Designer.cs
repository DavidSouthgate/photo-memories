namespace Photo_Memories
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.cmdNextImg = new System.Windows.Forms.Button();
            this.cmdPrevImg = new System.Windows.Forms.Button();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.lblSettingsAboutInfo = new System.Windows.Forms.Label();
            this.lblSettingsAbout = new System.Windows.Forms.Label();
            this.cmdSettingsSource = new System.Windows.Forms.Button();
            this.lblSettingsSource = new System.Windows.Forms.Label();
            this.bgw_refresh_files = new System.ComponentModel.BackgroundWorker();
            this.panelInfo.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.panelInfo.Controls.Add(this.cmdRefresh);
            this.panelInfo.Controls.Add(this.cmdSettings);
            this.panelInfo.Controls.Add(this.lblHead);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(353, 41);
            this.panelInfo.TabIndex = 4;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRefresh.FlatAppearance.BorderSize = 0;
            this.cmdRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cmdRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefresh.ForeColor = System.Drawing.Color.White;
            this.cmdRefresh.Location = new System.Drawing.Point(265, 0);
            this.cmdRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(42, 41);
            this.cmdRefresh.TabIndex = 2;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdSettings
            // 
            this.cmdSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSettings.BackgroundImage")));
            this.cmdSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSettings.FlatAppearance.BorderSize = 0;
            this.cmdSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cmdSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSettings.ForeColor = System.Drawing.Color.White;
            this.cmdSettings.Location = new System.Drawing.Point(311, 0);
            this.cmdSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(42, 41);
            this.cmdSettings.TabIndex = 1;
            this.cmdSettings.UseVisualStyleBackColor = true;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(12, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(0, 22);
            this.lblHead.TabIndex = 0;
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.cmdNextImg);
            this.panelPicture.Controls.Add(this.cmdPrevImg);
            this.panelPicture.Controls.Add(this.picDisplay);
            this.panelPicture.Location = new System.Drawing.Point(327, 99);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(321, 183);
            this.panelPicture.TabIndex = 5;
            // 
            // cmdNextImg
            // 
            this.cmdNextImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cmdNextImg.FlatAppearance.BorderSize = 0;
            this.cmdNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNextImg.Location = new System.Drawing.Point(301, 73);
            this.cmdNextImg.Name = "cmdNextImg";
            this.cmdNextImg.Size = new System.Drawing.Size(20, 40);
            this.cmdNextImg.TabIndex = 5;
            this.cmdNextImg.Text = ">";
            this.cmdNextImg.UseVisualStyleBackColor = false;
            this.cmdNextImg.Visible = false;
            this.cmdNextImg.Click += new System.EventHandler(this.cmdNextImg_Click);
            // 
            // cmdPrevImg
            // 
            this.cmdPrevImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cmdPrevImg.FlatAppearance.BorderSize = 0;
            this.cmdPrevImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrevImg.Location = new System.Drawing.Point(0, 73);
            this.cmdPrevImg.Name = "cmdPrevImg";
            this.cmdPrevImg.Size = new System.Drawing.Size(20, 40);
            this.cmdPrevImg.TabIndex = 4;
            this.cmdPrevImg.Text = "<";
            this.cmdPrevImg.UseVisualStyleBackColor = false;
            this.cmdPrevImg.Visible = false;
            this.cmdPrevImg.Click += new System.EventHandler(this.cmdPrevImg_Click);
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(25, 26);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(260, 122);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.lblSettingsAboutInfo);
            this.panelSettings.Controls.Add(this.lblSettingsAbout);
            this.panelSettings.Controls.Add(this.cmdSettingsSource);
            this.panelSettings.Controls.Add(this.lblSettingsSource);
            this.panelSettings.Location = new System.Drawing.Point(15, 65);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(321, 287);
            this.panelSettings.TabIndex = 6;
            this.panelSettings.Visible = false;
            // 
            // lblSettingsAboutInfo
            // 
            this.lblSettingsAboutInfo.AutoSize = true;
            this.lblSettingsAboutInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAboutInfo.ForeColor = System.Drawing.Color.White;
            this.lblSettingsAboutInfo.Location = new System.Drawing.Point(15, 135);
            this.lblSettingsAboutInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettingsAboutInfo.Name = "lblSettingsAboutInfo";
            this.lblSettingsAboutInfo.Size = new System.Drawing.Size(64, 20);
            this.lblSettingsAboutInfo.TabIndex = 4;
            this.lblSettingsAboutInfo.Text = "ABOUT";
            // 
            // lblSettingsAbout
            // 
            this.lblSettingsAbout.AutoSize = true;
            this.lblSettingsAbout.BackColor = System.Drawing.Color.Black;
            this.lblSettingsAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAbout.ForeColor = System.Drawing.Color.White;
            this.lblSettingsAbout.Location = new System.Drawing.Point(13, 97);
            this.lblSettingsAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettingsAbout.Name = "lblSettingsAbout";
            this.lblSettingsAbout.Size = new System.Drawing.Size(85, 31);
            this.lblSettingsAbout.TabIndex = 3;
            this.lblSettingsAbout.Text = "About";
            // 
            // cmdSettingsSource
            // 
            this.cmdSettingsSource.FlatAppearance.BorderSize = 0;
            this.cmdSettingsSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cmdSettingsSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmdSettingsSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSettingsSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSettingsSource.ForeColor = System.Drawing.Color.White;
            this.cmdSettingsSource.Location = new System.Drawing.Point(13, 46);
            this.cmdSettingsSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSettingsSource.Name = "cmdSettingsSource";
            this.cmdSettingsSource.Size = new System.Drawing.Size(289, 30);
            this.cmdSettingsSource.TabIndex = 2;
            this.cmdSettingsSource.Text = "Save";
            this.cmdSettingsSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSettingsSource.UseVisualStyleBackColor = true;
            this.cmdSettingsSource.Click += new System.EventHandler(this.cmdSettingsSource_Click);
            // 
            // lblSettingsSource
            // 
            this.lblSettingsSource.AutoSize = true;
            this.lblSettingsSource.BackColor = System.Drawing.Color.Black;
            this.lblSettingsSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsSource.ForeColor = System.Drawing.Color.White;
            this.lblSettingsSource.Location = new System.Drawing.Point(13, 14);
            this.lblSettingsSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettingsSource.Name = "lblSettingsSource";
            this.lblSettingsSource.Size = new System.Drawing.Size(100, 31);
            this.lblSettingsSource.TabIndex = 0;
            this.lblSettingsSource.Text = "Source";
            // 
            // bgw_refresh_files
            // 
            this.bgw_refresh_files.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_refresh_files_DoWork);
            this.bgw_refresh_files.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_refresh_files_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 531);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.panelInfo);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button cmdSettings;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Button cmdNextImg;
        private System.Windows.Forms.Button cmdPrevImg;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button cmdSettingsSource;
        private System.Windows.Forms.Label lblSettingsSource;
        private System.Windows.Forms.Button cmdRefresh;
        private System.ComponentModel.BackgroundWorker bgw_refresh_files;
        private System.Windows.Forms.Label lblSettingsAbout;
        private System.Windows.Forms.Label lblSettingsAboutInfo;
    }
}

