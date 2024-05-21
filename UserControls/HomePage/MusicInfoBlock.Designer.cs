namespace BaiTH02.UserControls.HomePage
{
    partial class MusicInfoBlock
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
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoverImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCoverImg
            // 
            this.ptbCoverImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbCoverImg.Location = new System.Drawing.Point(0, 0);
            this.ptbCoverImg.Name = "ptbCoverImg";
            this.ptbCoverImg.Size = new System.Drawing.Size(148, 123);
            this.ptbCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCoverImg.TabIndex = 0;
            this.ptbCoverImg.TabStop = false;
            this.ptbCoverImg.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Location = new System.Drawing.Point(0, 123);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(148, 83);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Rồi ta sẽ ngắm pháo hoa cùng nhau";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Click += new System.EventHandler(this.MusicInfoItem_Click);
            // 
            // MusicInfoBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ptbCoverImg);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.Name = "MusicInfoBlock";
            this.Size = new System.Drawing.Size(148, 206);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoverImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCoverImg;
        private System.Windows.Forms.Label lbName;
    }
}
