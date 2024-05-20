namespace BaiTH02.UserControls.PlaylistPage
{
    partial class PlaylistFolderBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistFolderBar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.ptbDeleteInside = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeleteInside)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbDelete);
            this.panel1.Controls.Add(this.ptbDeleteInside);
            this.panel1.Location = new System.Drawing.Point(510, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 51);
            this.panel1.TabIndex = 2;
            // 
            // ptbDelete
            // 
            this.ptbDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbDelete.Image")));
            this.ptbDelete.Location = new System.Drawing.Point(66, 0);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Padding = new System.Windows.Forms.Padding(6);
            this.ptbDelete.Size = new System.Drawing.Size(51, 51);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDelete.TabIndex = 2;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // ptbDeleteInside
            // 
            this.ptbDeleteInside.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbDeleteInside.Image = ((System.Drawing.Image)(resources.GetObject("ptbDeleteInside.Image")));
            this.ptbDeleteInside.Location = new System.Drawing.Point(0, 0);
            this.ptbDeleteInside.Name = "ptbDeleteInside";
            this.ptbDeleteInside.Padding = new System.Windows.Forms.Padding(6);
            this.ptbDeleteInside.Size = new System.Drawing.Size(51, 51);
            this.ptbDeleteInside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDeleteInside.TabIndex = 1;
            this.ptbDeleteInside.TabStop = false;
            this.ptbDeleteInside.Click += new System.EventHandler(this.ptbDeleteInside_Click);
            // 
            // PlaylistFolderBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlaylistFolderBar";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(635, 83);
            this.DoubleClick += new System.EventHandler(this.PlaylistFolderBar_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeleteInside)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.PictureBox ptbDeleteInside;
    }
}
