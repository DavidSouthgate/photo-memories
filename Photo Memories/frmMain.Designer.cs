namespace Back_In_Time_Photo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdNextImg = new System.Windows.Forms.Button();
            this.cmdPrevImg = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.bgw_load_images = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdNextImg
            // 
            this.cmdNextImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cmdNextImg.FlatAppearance.BorderSize = 0;
            this.cmdNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNextImg.Location = new System.Drawing.Point(500, 349);
            this.cmdNextImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdNextImg.Name = "cmdNextImg";
            this.cmdNextImg.Size = new System.Drawing.Size(30, 62);
            this.cmdNextImg.TabIndex = 2;
            this.cmdNextImg.Text = ">";
            this.cmdNextImg.UseVisualStyleBackColor = false;
            this.cmdNextImg.Click += new System.EventHandler(this.cmdNextImg_Click);
            // 
            // cmdPrevImg
            // 
            this.cmdPrevImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cmdPrevImg.FlatAppearance.BorderSize = 0;
            this.cmdPrevImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrevImg.Location = new System.Drawing.Point(0, 349);
            this.cmdPrevImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdPrevImg.Name = "cmdPrevImg";
            this.cmdPrevImg.Size = new System.Drawing.Size(30, 62);
            this.cmdPrevImg.TabIndex = 3;
            this.cmdPrevImg.Text = "<";
            this.cmdPrevImg.UseVisualStyleBackColor = false;
            this.cmdPrevImg.Click += new System.EventHandler(this.cmdPrevImg_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.panelInfo.Controls.Add(this.lblDate);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(530, 63);
            this.panelInfo.TabIndex = 4;
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
            // bgw_load_images
            // 
            this.bgw_load_images.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_load_images_DoWork);
            this.bgw_load_images.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_load_images_ProgressChanged);
            this.bgw_load_images.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_load_images_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(531, 817);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.cmdPrevImg);
            this.Controls.Add(this.cmdNextImg);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdNextImg;
        private System.Windows.Forms.Button cmdPrevImg;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblDate;
        private System.ComponentModel.BackgroundWorker bgw_load_images;
    }
}

