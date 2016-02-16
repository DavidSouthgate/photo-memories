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
            this.lblDate = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.cmdNextImg = new System.Windows.Forms.Button();
            this.cmdPrevImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.cmdSettingsSource = new System.Windows.Forms.Button();
            this.lblSettingsSource = new System.Windows.Forms.Label();
            this.bgw_refresh_files = new System.ComponentModel.BackgroundWorker();
            this.panelInfo.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.panelInfo.Controls.Add(this.cmdRefresh);
            this.panelInfo.Controls.Add(this.cmdSettings);
            this.panelInfo.Controls.Add(this.lblDate);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(530, 63);
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
            this.cmdRefresh.Location = new System.Drawing.Point(398, 0);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(63, 63);
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
            this.cmdSettings.Location = new System.Drawing.Point(467, 0);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(63, 63);
            this.cmdSettings.TabIndex = 1;
            this.cmdSettings.UseVisualStyleBackColor = true;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(18, 14);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.cmdNextImg);
            this.panelPicture.Controls.Add(this.cmdPrevImg);
            this.panelPicture.Controls.Add(this.pictureBox1);
            this.panelPicture.Location = new System.Drawing.Point(490, 153);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(481, 281);
            this.panelPicture.TabIndex = 5;
            // 
            // cmdNextImg
            // 
            this.cmdNextImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cmdNextImg.FlatAppearance.BorderSize = 0;
            this.cmdNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNextImg.Location = new System.Drawing.Point(451, 113);
            this.cmdNextImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdNextImg.Name = "cmdNextImg";
            this.cmdNextImg.Size = new System.Drawing.Size(30, 62);
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
            this.cmdPrevImg.Location = new System.Drawing.Point(0, 113);
            this.cmdPrevImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdPrevImg.Name = "cmdPrevImg";
            this.cmdPrevImg.Size = new System.Drawing.Size(30, 62);
            this.cmdPrevImg.TabIndex = 4;
            this.cmdPrevImg.Text = "<";
            this.cmdPrevImg.UseVisualStyleBackColor = false;
            this.cmdPrevImg.Visible = false;
            this.cmdPrevImg.Click += new System.EventHandler(this.cmdPrevImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.cmdSettingsSource);
            this.panelSettings.Controls.Add(this.lblSettingsSource);
            this.panelSettings.Location = new System.Drawing.Point(23, 100);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(481, 442);
            this.panelSettings.TabIndex = 6;
            this.panelSettings.Visible = false;
            // 
            // cmdSettingsSource
            // 
            this.cmdSettingsSource.FlatAppearance.BorderSize = 0;
            this.cmdSettingsSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cmdSettingsSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmdSettingsSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSettingsSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSettingsSource.ForeColor = System.Drawing.Color.White;
            this.cmdSettingsSource.Location = new System.Drawing.Point(20, 66);
            this.cmdSettingsSource.Name = "cmdSettingsSource";
            this.cmdSettingsSource.Size = new System.Drawing.Size(434, 46);
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
            this.lblSettingsSource.Location = new System.Drawing.Point(19, 22);
            this.lblSettingsSource.Name = "lblSettingsSource";
            this.lblSettingsSource.Size = new System.Drawing.Size(148, 46);
            this.lblSettingsSource.TabIndex = 0;
            this.lblSettingsSource.Text = "Source";
            // 
            // bgw_refresh_files
            // 
            this.bgw_refresh_files.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_refresh_files_DoWork);
            this.bgw_refresh_files.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_refresh_files_ProgressChanged);
            this.bgw_refresh_files.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_refresh_files_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(555, 817);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.panelInfo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button cmdSettings;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdNextImg;
        private System.Windows.Forms.Button cmdPrevImg;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button cmdSettingsSource;
        private System.Windows.Forms.Label lblSettingsSource;
        private System.Windows.Forms.Button cmdRefresh;
        private System.ComponentModel.BackgroundWorker bgw_refresh_files;
    }
}

