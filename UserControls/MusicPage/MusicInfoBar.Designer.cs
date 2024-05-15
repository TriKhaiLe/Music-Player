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
            this.ptbCoverImg = new System.Windows.Forms.PictureBox();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.ptbDownload = new System.Windows.Forms.PictureBox();
            this.ptbPlay = new System.Windows.Forms.PictureBox();
            this.ptbFavorite = new System.Windows.Forms.PictureBox();
            this.ptbAddToPlaylist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoverImg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddToPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCoverImg
            // 
            this.ptbCoverImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbCoverImg.Location = new System.Drawing.Point(5, 5);
            this.ptbCoverImg.Name = "ptbCoverImg";
            this.ptbCoverImg.Size = new System.Drawing.Size(100, 100);
            this.ptbCoverImg.TabIndex = 0;
            this.ptbCoverImg.TabStop = false;
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Location = new System.Drawing.Point(111, 17);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(44, 16);
            this.lbSongName.TabIndex = 1;
            this.lbSongName.Text = "label1";
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbDelete);
            this.panel1.Controls.Add(this.ptbDownload);
            this.panel1.Controls.Add(this.ptbPlay);
            this.panel1.Controls.Add(this.ptbFavorite);
            this.panel1.Controls.Add(this.ptbAddToPlaylist);
            this.panel1.Location = new System.Drawing.Point(356, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 51);
            this.panel1.TabIndex = 3;
            // 
            // ptbDelete
            // 
            this.ptbDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbDelete.Location = new System.Drawing.Point(204, 0);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(51, 51);
            this.ptbDelete.TabIndex = 4;
            this.ptbDelete.TabStop = false;
            // 
            // ptbDownload
            // 
            this.ptbDownload.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbDownload.Location = new System.Drawing.Point(153, 0);
            this.ptbDownload.Name = "ptbDownload";
            this.ptbDownload.Size = new System.Drawing.Size(51, 51);
            this.ptbDownload.TabIndex = 3;
            this.ptbDownload.TabStop = false;
            // 
            // ptbPlay
            // 
            this.ptbPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbPlay.Location = new System.Drawing.Point(102, 0);
            this.ptbPlay.Name = "ptbPlay";
            this.ptbPlay.Size = new System.Drawing.Size(51, 51);
            this.ptbPlay.TabIndex = 2;
            this.ptbPlay.TabStop = false;
            // 
            // ptbFavorite
            // 
            this.ptbFavorite.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbFavorite.Location = new System.Drawing.Point(51, 0);
            this.ptbFavorite.Name = "ptbFavorite";
            this.ptbFavorite.Size = new System.Drawing.Size(51, 51);
            this.ptbFavorite.TabIndex = 1;
            this.ptbFavorite.TabStop = false;
            // 
            // ptbAddToPlaylist
            // 
            this.ptbAddToPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAddToPlaylist.Location = new System.Drawing.Point(0, 0);
            this.ptbAddToPlaylist.Name = "ptbAddToPlaylist";
            this.ptbAddToPlaylist.Size = new System.Drawing.Size(51, 51);
            this.ptbAddToPlaylist.TabIndex = 0;
            this.ptbAddToPlaylist.TabStop = false;
            // 
            // MusicInfoBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.ptbCoverImg);
            this.Name = "MusicInfoBar";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(620, 110);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoverImg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddToPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCoverImg;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbDownload;
        private System.Windows.Forms.PictureBox ptbPlay;
        private System.Windows.Forms.PictureBox ptbFavorite;
        private System.Windows.Forms.PictureBox ptbAddToPlaylist;
        private System.Windows.Forms.PictureBox ptbDelete;
    }
}
