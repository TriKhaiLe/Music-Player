namespace BaiTH02.UserControls.PlaylistPage
{
    partial class PlaylistUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistUC));
            this.panelAddPlaylist = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.panelPlaylistName = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            this.panelPlaylistName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddPlaylist
            // 
            this.panelAddPlaylist.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelAddPlaylist.Controls.Add(this.label1);
            this.panelAddPlaylist.Controls.Add(this.ptbAdd);
            this.panelAddPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddPlaylist.Location = new System.Drawing.Point(0, 0);
            this.panelAddPlaylist.Name = "panelAddPlaylist";
            this.panelAddPlaylist.Size = new System.Drawing.Size(649, 68);
            this.panelAddPlaylist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Playlist";
            // 
            // ptbAdd
            // 
            this.ptbAdd.Image = ((System.Drawing.Image)(resources.GetObject("ptbAdd.Image")));
            this.ptbAdd.Location = new System.Drawing.Point(33, 15);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(41, 41);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 0;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // panelPlaylistName
            // 
            this.panelPlaylistName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelPlaylistName.Controls.Add(this.label2);
            this.panelPlaylistName.Controls.Add(this.pictureBox1);
            this.panelPlaylistName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistName.Location = new System.Drawing.Point(0, 68);
            this.panelPlaylistName.Name = "panelPlaylistName";
            this.panelPlaylistName.Size = new System.Drawing.Size(649, 68);
            this.panelPlaylistName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Playlist Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 520);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PlaylistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelPlaylistName);
            this.Controls.Add(this.panelAddPlaylist);
            this.Name = "PlaylistUC";
            this.Size = new System.Drawing.Size(649, 656);
            this.Load += new System.EventHandler(this.PlaylistUC_Load);
            this.panelAddPlaylist.ResumeLayout(false);
            this.panelAddPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            this.panelPlaylistName.ResumeLayout(false);
            this.panelPlaylistName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddPlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.Panel panelPlaylistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
