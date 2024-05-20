namespace BaiTH02.UserControls.MusicPage
{
    partial class MusicUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicUC));
            this.pn_categories = new System.Windows.Forms.Panel();
            this.btn_cate_international = new System.Windows.Forms.Button();
            this.btn_cate_vietnam = new System.Windows.Forms.Button();
            this.btn_cate_all = new System.Windows.Forms.Button();
            this.pn_search = new System.Windows.Forms.Panel();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.fpn_musics = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pn_categories.SuspendLayout();
            this.pn_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_categories
            // 
            this.pn_categories.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_categories.Controls.Add(this.btn_cate_international);
            this.pn_categories.Controls.Add(this.btn_cate_vietnam);
            this.pn_categories.Controls.Add(this.btn_cate_all);
            this.pn_categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_categories.Location = new System.Drawing.Point(0, 41);
            this.pn_categories.Name = "pn_categories";
            this.pn_categories.Size = new System.Drawing.Size(450, 53);
            this.pn_categories.TabIndex = 5;
            // 
            // btn_cate_international
            // 
            this.btn_cate_international.Location = new System.Drawing.Point(205, 14);
            this.btn_cate_international.Name = "btn_cate_international";
            this.btn_cate_international.Size = new System.Drawing.Size(102, 25);
            this.btn_cate_international.TabIndex = 2;
            this.btn_cate_international.Text = "International";
            this.btn_cate_international.UseVisualStyleBackColor = true;
            this.btn_cate_international.Click += new System.EventHandler(this.btn_cate_international_Click);
            // 
            // btn_cate_vietnam
            // 
            this.btn_cate_vietnam.Location = new System.Drawing.Point(97, 15);
            this.btn_cate_vietnam.Name = "btn_cate_vietnam";
            this.btn_cate_vietnam.Size = new System.Drawing.Size(102, 25);
            this.btn_cate_vietnam.TabIndex = 1;
            this.btn_cate_vietnam.Text = "VietNam";
            this.btn_cate_vietnam.UseVisualStyleBackColor = true;
            this.btn_cate_vietnam.Click += new System.EventHandler(this.btn_cate_vietnam_Click);
            // 
            // btn_cate_all
            // 
            this.btn_cate_all.Location = new System.Drawing.Point(16, 15);
            this.btn_cate_all.Name = "btn_cate_all";
            this.btn_cate_all.Size = new System.Drawing.Size(75, 23);
            this.btn_cate_all.TabIndex = 0;
            this.btn_cate_all.Text = "All";
            this.btn_cate_all.UseVisualStyleBackColor = true;
            this.btn_cate_all.Click += new System.EventHandler(this.btn_cate_all_Click);
            // 
            // pn_search
            // 
            this.pn_search.Controls.Add(this.tb_search);
            this.pn_search.Controls.Add(this.pb_search);
            this.pn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_search.Location = new System.Drawing.Point(0, 0);
            this.pn_search.Name = "pn_search";
            this.pn_search.Padding = new System.Windows.Forms.Padding(5);
            this.pn_search.Size = new System.Drawing.Size(450, 41);
            this.pn_search.TabIndex = 6;
            // 
            // pb_search
            // 
            this.pb_search.BackColor = System.Drawing.Color.LightGray;
            this.pb_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_search.BackgroundImage")));
            this.pb_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_search.Location = new System.Drawing.Point(393, 5);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(52, 31);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_search.TabIndex = 1;
            this.pb_search.TabStop = false;
            this.pb_search.Click += new System.EventHandler(this.pb_search_Click);
            // 
            // fpn_musics
            // 
            this.fpn_musics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpn_musics.Location = new System.Drawing.Point(0, 94);
            this.fpn_musics.Name = "fpn_musics";
            this.fpn_musics.Size = new System.Drawing.Size(450, 442);
            this.fpn_musics.TabIndex = 8;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.LightGray;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_search.Location = new System.Drawing.Point(5, 5);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(388, 31);
            this.tb_search.TabIndex = 2;
            this.tb_search.Tag = "";
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // MusicUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpn_musics);
            this.Controls.Add(this.pn_categories);
            this.Controls.Add(this.pn_search);
            this.Name = "MusicUC";
            this.Size = new System.Drawing.Size(450, 536);
            this.Load += new System.EventHandler(this.MusicUC_Load);
            this.pn_categories.ResumeLayout(false);
            this.pn_search.ResumeLayout(false);
            this.pn_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_categories;
        private System.Windows.Forms.Button btn_cate_international;
        private System.Windows.Forms.Button btn_cate_vietnam;
        private System.Windows.Forms.Button btn_cate_all;
        private System.Windows.Forms.Panel pn_search;
        private System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.FlowLayoutPanel fpn_musics;
        private System.Windows.Forms.TextBox tb_search;
    }
}
