namespace BaiTH02.UserControls.MusicPage
{
    partial class MusicInfoBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicInfoBar));
            this.ptbCoverImg = new System.Windows.Forms.PictureBox();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbDownload = new System.Windows.Forms.PictureBox();
            this.ptbPlay = new System.Windows.Forms.PictureBox();
            this.ptbFavorite = new System.Windows.Forms.PictureBox();
            this.ptbAddToPlaylist = new System.Windows.Forms.PictureBox();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoverImg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddToPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCoverImg
            // 
            this.ptbCoverImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbCoverImg.Location = new System.Drawing.Point(5, 5);
            this.ptbCoverImg.Name = "ptbCoverImg";
            this.ptbCoverImg.Size = new System.Drawing.Size(100, 100);
            this.ptbCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCoverImg.TabIndex = 0;
            this.ptbCoverImg.TabStop = false;
            this.ptbCoverImg.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Location = new System.Drawing.Point(111, 17);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(44, 16);
            this.lbSongName.TabIndex = 1;
            this.lbSongName.Text = "label1";
            this.lbSongName.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.Location = new System.Drawing.Point(111, 54);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(239, 51);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "label2label2label2label2label2label2label2label2label2label2label2label2label2lab" +
    "el2label2label2label2label2label2label2label2label2label2label2\r\n\r\n\r\n";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAuthor.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbDownload);
            this.panel1.Controls.Add(this.ptbPlay);
            this.panel1.Controls.Add(this.ptbFavorite);
            this.panel1.Controls.Add(this.ptbAddToPlaylist);
            this.panel1.Location = new System.Drawing.Point(356, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 51);
            this.panel1.TabIndex = 3;
            // 
            // ptbDownload
            // 
            this.ptbDownload.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbDownload.Image = ((System.Drawing.Image)(resources.GetObject("ptbDownload.Image")));
            this.ptbDownload.Location = new System.Drawing.Point(52, 0);
            this.ptbDownload.Name = "ptbDownload";
            this.ptbDownload.Padding = new System.Windows.Forms.Padding(5);
            this.ptbDownload.Size = new System.Drawing.Size(51, 51);
            this.ptbDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDownload.TabIndex = 3;
            this.ptbDownload.TabStop = false;
            this.ptbDownload.Click += new System.EventHandler(this.ptbDownload_Click);
            // 
            // ptbPlay
            // 
            this.ptbPlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbPlay.Image = ((System.Drawing.Image)(resources.GetObject("ptbPlay.Image")));
            this.ptbPlay.Location = new System.Drawing.Point(103, 0);
            this.ptbPlay.Name = "ptbPlay";
            this.ptbPlay.Padding = new System.Windows.Forms.Padding(5);
            this.ptbPlay.Size = new System.Drawing.Size(51, 51);
            this.ptbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPlay.TabIndex = 2;
            this.ptbPlay.TabStop = false;
            this.ptbPlay.Click += new System.EventHandler(this.ptbPlay_Click);
            // 
            // ptbFavorite
            // 
            this.ptbFavorite.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbFavorite.Image = ((System.Drawing.Image)(resources.GetObject("ptbFavorite.Image")));
            this.ptbFavorite.Location = new System.Drawing.Point(154, 0);
            this.ptbFavorite.Name = "ptbFavorite";
            this.ptbFavorite.Padding = new System.Windows.Forms.Padding(5);
            this.ptbFavorite.Size = new System.Drawing.Size(51, 51);
            this.ptbFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFavorite.TabIndex = 1;
            this.ptbFavorite.TabStop = false;
            this.ptbFavorite.Click += new System.EventHandler(this.ptbFavorite_Click);
            // 
            // ptbAddToPlaylist
            // 
            this.ptbAddToPlaylist.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbAddToPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddToPlaylist.Image")));
            this.ptbAddToPlaylist.Location = new System.Drawing.Point(205, 0);
            this.ptbAddToPlaylist.Margin = new System.Windows.Forms.Padding(5);
            this.ptbAddToPlaylist.Name = "ptbAddToPlaylist";
            this.ptbAddToPlaylist.Padding = new System.Windows.Forms.Padding(6);
            this.ptbAddToPlaylist.Size = new System.Drawing.Size(51, 51);
            this.ptbAddToPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddToPlaylist.TabIndex = 0;
            this.ptbAddToPlaylist.TabStop = false;
            this.ptbAddToPlaylist.Click += new System.EventHandler(this.ptbAddToPlaylist_Click);
            // 
            // ptbDelete
            // 
            this.ptbDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbDelete.Image")));
            this.ptbDelete.Location = new System.Drawing.Point(569, 0);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Padding = new System.Windows.Forms.Padding(5);
            this.ptbDelete.Size = new System.Drawing.Size(51, 51);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDelete.TabIndex = 5;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // MusicInfoBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.ptbDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.ptbCoverImg);
            this.Name = "MusicInfoBar";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(630, 110);
            this.Click += new System.EventHandler(this.MusicInfoItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoverImg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddToPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCoverImg;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbDownload;
        public System.Windows.Forms.PictureBox ptbPlay;
        private System.Windows.Forms.PictureBox ptbFavorite;
        private System.Windows.Forms.PictureBox ptbAddToPlaylist;
        private System.Windows.Forms.PictureBox ptbDelete;
    }
}
