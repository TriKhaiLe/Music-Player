namespace BaiTH02.UserControls.HomePage
{
    partial class UCHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.llDownload = new System.Windows.Forms.LinkLabel();
            this.llRecently = new System.Windows.Forms.LinkLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 451);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 205);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.llDownload);
            this.panel11.Controls.Add(this.llRecently);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 400);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(649, 51);
            this.panel11.TabIndex = 6;
            // 
            // llDownload
            // 
            this.llDownload.ActiveLinkColor = System.Drawing.Color.MediumSpringGreen;
            this.llDownload.AutoSize = true;
            this.llDownload.BackColor = System.Drawing.SystemColors.Control;
            this.llDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDownload.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llDownload.Location = new System.Drawing.Point(116, 18);
            this.llDownload.Name = "llDownload";
            this.llDownload.Size = new System.Drawing.Size(76, 16);
            this.llDownload.TabIndex = 1;
            this.llDownload.TabStop = true;
            this.llDownload.Text = "Download";
            this.llDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDownload_LinkClicked);
            // 
            // llRecently
            // 
            this.llRecently.ActiveLinkColor = System.Drawing.Color.MediumSpringGreen;
            this.llRecently.AutoSize = true;
            this.llRecently.BackColor = System.Drawing.SystemColors.Control;
            this.llRecently.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRecently.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llRecently.Location = new System.Drawing.Point(12, 18);
            this.llRecently.Name = "llRecently";
            this.llRecently.Size = new System.Drawing.Size(68, 16);
            this.llRecently.TabIndex = 0;
            this.llRecently.TabStop = true;
            this.llRecently.Text = "Recently";
            this.llRecently.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRecently_LinkClicked);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 200);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(649, 200);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(649, 200);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(649, 656);
            this.Load += new System.EventHandler(this.UCHome_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.LinkLabel llDownload;
        private System.Windows.Forms.LinkLabel llRecently;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
