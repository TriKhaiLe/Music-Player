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
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.ptbBack = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            this.panelPlaylistName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddPlaylist
            // 
            this.panelAddPlaylist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelAddPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddPlaylist.Controls.Add(this.label1);
            this.panelAddPlaylist.Controls.Add(this.ptbAdd);
            this.panelAddPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddPlaylist.Location = new System.Drawing.Point(0, 0);
            this.panelAddPlaylist.Name = "panelAddPlaylist";
            this.panelAddPlaylist.Size = new System.Drawing.Size(649, 68);
            this.panelAddPlaylist.TabIndex = 0;
            this.panelAddPlaylist.Click += new System.EventHandler(this.panelAddPlaylist_Click);
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
            this.ptbAdd.Location = new System.Drawing.Point(18, 14);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(41, 41);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 0;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // panelPlaylistName
            // 
            this.panelPlaylistName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelPlaylistName.Controls.Add(this.labelPlaylistName);
            this.panelPlaylistName.Controls.Add(this.ptbBack);
            this.panelPlaylistName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistName.Location = new System.Drawing.Point(0, 68);
            this.panelPlaylistName.Name = "panelPlaylistName";
            this.panelPlaylistName.Size = new System.Drawing.Size(649, 68);
            this.panelPlaylistName.TabIndex = 2;
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.AutoSize = true;
            this.labelPlaylistName.Location = new System.Drawing.Point(80, 28);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(90, 16);
            this.labelPlaylistName.TabIndex = 1;
            this.labelPlaylistName.Text = "Playlist Name";
            // 
            // ptbBack
            // 
            this.ptbBack.Image = ((System.Drawing.Image)(resources.GetObject("ptbBack.Image")));
            this.ptbBack.Location = new System.Drawing.Point(18, 15);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(41, 41);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBack.TabIndex = 0;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddPlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.Panel panelPlaylistName;
        private System.Windows.Forms.Label labelPlaylistName;
        private System.Windows.Forms.PictureBox ptbBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
