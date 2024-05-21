namespace BaiTH02.UserControls.SongDetail
{
    partial class SongDetailUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongDetailUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_songImg = new System.Windows.Forms.PictureBox();
            this.ptbBack = new System.Windows.Forms.PictureBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_auther_singer = new System.Windows.Forms.Label();
            this.pn_commentPost = new System.Windows.Forms.Panel();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.btn_comment = new System.Windows.Forms.Button();
            this.pb_star_5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_star_4 = new System.Windows.Forms.PictureBox();
            this.pb_star_3 = new System.Windows.Forms.PictureBox();
            this.pb_star_2 = new System.Windows.Forms.PictureBox();
            this.pb_star_1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpn_comment = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEverageRating = new System.Windows.Forms.Label();
            this.ptbPlay = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_songImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            this.pn_commentPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbPlay);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pb_songImg);
            this.panel1.Controls.Add(this.ptbBack);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.lb_auther_singer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 152);
            this.panel1.TabIndex = 8;
            // 
            // pb_songImg
            // 
            this.pb_songImg.Location = new System.Drawing.Point(16, 49);
            this.pb_songImg.Name = "pb_songImg";
            this.pb_songImg.Size = new System.Drawing.Size(102, 89);
            this.pb_songImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_songImg.TabIndex = 0;
            this.pb_songImg.TabStop = false;
            // 
            // ptbBack
            // 
            this.ptbBack.Image = ((System.Drawing.Image)(resources.GetObject("ptbBack.Image")));
            this.ptbBack.Location = new System.Drawing.Point(15, 2);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(41, 41);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBack.TabIndex = 5;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(129, 49);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(111, 27);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Only You";
            // 
            // lb_auther_singer
            // 
            this.lb_auther_singer.AutoSize = true;
            this.lb_auther_singer.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_auther_singer.Location = new System.Drawing.Point(142, 93);
            this.lb_auther_singer.Name = "lb_auther_singer";
            this.lb_auther_singer.Size = new System.Drawing.Size(54, 22);
            this.lb_auther_singer.TabIndex = 2;
            this.lb_auther_singer.Text = "singer";
            // 
            // pn_commentPost
            // 
            this.pn_commentPost.Controls.Add(this.rdbFemale);
            this.pn_commentPost.Controls.Add(this.rdbMale);
            this.pn_commentPost.Controls.Add(this.btn_comment);
            this.pn_commentPost.Controls.Add(this.pb_star_5);
            this.pn_commentPost.Controls.Add(this.label3);
            this.pn_commentPost.Controls.Add(this.pb_star_4);
            this.pn_commentPost.Controls.Add(this.pb_star_3);
            this.pn_commentPost.Controls.Add(this.pb_star_2);
            this.pn_commentPost.Controls.Add(this.pb_star_1);
            this.pn_commentPost.Controls.Add(this.label2);
            this.pn_commentPost.Controls.Add(this.label1);
            this.pn_commentPost.Controls.Add(this.tb_comment);
            this.pn_commentPost.Controls.Add(this.tb_author);
            this.pn_commentPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_commentPost.Location = new System.Drawing.Point(0, 152);
            this.pn_commentPost.Name = "pn_commentPost";
            this.pn_commentPost.Size = new System.Drawing.Size(649, 177);
            this.pn_commentPost.TabIndex = 9;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(502, 102);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(47, 20);
            this.rdbFemale.TabIndex = 9;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Chị";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(502, 74);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(51, 20);
            this.rdbMale.TabIndex = 8;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Anh";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // btn_comment
            // 
            this.btn_comment.BackColor = System.Drawing.Color.Turquoise;
            this.btn_comment.Location = new System.Drawing.Point(344, 128);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(93, 38);
            this.btn_comment.TabIndex = 2;
            this.btn_comment.Text = "Comment";
            this.btn_comment.UseVisualStyleBackColor = false;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // pb_star_5
            // 
            this.pb_star_5.Image = global::BaiTH02.Properties.Resources.star_outline;
            this.pb_star_5.Location = new System.Drawing.Point(162, 36);
            this.pb_star_5.Name = "pb_star_5";
            this.pb_star_5.Size = new System.Drawing.Size(30, 30);
            this.pb_star_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_star_5.TabIndex = 3;
            this.pb_star_5.TabStop = false;
            this.pb_star_5.Click += new System.EventHandler(this.pb_star_5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Comments";
            // 
            // pb_star_4
            // 
            this.pb_star_4.Image = global::BaiTH02.Properties.Resources.star_outline;
            this.pb_star_4.Location = new System.Drawing.Point(126, 36);
            this.pb_star_4.Name = "pb_star_4";
            this.pb_star_4.Size = new System.Drawing.Size(30, 30);
            this.pb_star_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_star_4.TabIndex = 4;
            this.pb_star_4.TabStop = false;
            this.pb_star_4.Click += new System.EventHandler(this.pb_star_4_Click);
            // 
            // pb_star_3
            // 
            this.pb_star_3.Image = global::BaiTH02.Properties.Resources.star_outline;
            this.pb_star_3.Location = new System.Drawing.Point(90, 36);
            this.pb_star_3.Name = "pb_star_3";
            this.pb_star_3.Size = new System.Drawing.Size(30, 30);
            this.pb_star_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_star_3.TabIndex = 5;
            this.pb_star_3.TabStop = false;
            this.pb_star_3.Click += new System.EventHandler(this.pb_star_3_Click);
            // 
            // pb_star_2
            // 
            this.pb_star_2.Image = global::BaiTH02.Properties.Resources.star_outline;
            this.pb_star_2.Location = new System.Drawing.Point(54, 36);
            this.pb_star_2.Name = "pb_star_2";
            this.pb_star_2.Size = new System.Drawing.Size(30, 30);
            this.pb_star_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_star_2.TabIndex = 6;
            this.pb_star_2.TabStop = false;
            this.pb_star_2.Click += new System.EventHandler(this.pb_star_2_Click);
            // 
            // pb_star_1
            // 
            this.pb_star_1.Image = global::BaiTH02.Properties.Resources.star_outline;
            this.pb_star_1.Location = new System.Drawing.Point(18, 36);
            this.pb_star_1.Name = "pb_star_1";
            this.pb_star_1.Size = new System.Drawing.Size(30, 30);
            this.pb_star_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_star_1.TabIndex = 7;
            this.pb_star_1.TabStop = false;
            this.pb_star_1.Click += new System.EventHandler(this.pb_star_1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post Your Comment";
            // 
            // tb_comment
            // 
            this.tb_comment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_comment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comment.Location = new System.Drawing.Point(17, 74);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(420, 48);
            this.tb_comment.TabIndex = 0;
            // 
            // tb_author
            // 
            this.tb_author.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_author.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_author.Location = new System.Drawing.Point(150, 131);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(159, 26);
            this.tb_author.TabIndex = 0;
            this.tb_author.Text = "Harry";
            this.tb_author.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fpn_comment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 207);
            this.panel2.TabIndex = 10;
            // 
            // fpn_comment
            // 
            this.fpn_comment.AutoScroll = true;
            this.fpn_comment.AutoSize = true;
            this.fpn_comment.BackColor = System.Drawing.Color.SteelBlue;
            this.fpn_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpn_comment.Location = new System.Drawing.Point(0, 0);
            this.fpn_comment.MaximumSize = new System.Drawing.Size(450, 220);
            this.fpn_comment.Name = "fpn_comment";
            this.fpn_comment.Size = new System.Drawing.Size(450, 207);
            this.fpn_comment.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbEverageRating);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(449, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 152);
            this.panel3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Average rating";
            // 
            // lbEverageRating
            // 
            this.lbEverageRating.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEverageRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEverageRating.Location = new System.Drawing.Point(0, 32);
            this.lbEverageRating.Name = "lbEverageRating";
            this.lbEverageRating.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbEverageRating.Size = new System.Drawing.Size(200, 31);
            this.lbEverageRating.TabIndex = 15;
            this.lbEverageRating.Text = "label5";
            this.lbEverageRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbPlay
            // 
            this.ptbPlay.Image = ((System.Drawing.Image)(resources.GetObject("ptbPlay.Image")));
            this.ptbPlay.Location = new System.Drawing.Point(392, 93);
            this.ptbPlay.Name = "ptbPlay";
            this.ptbPlay.Padding = new System.Windows.Forms.Padding(5);
            this.ptbPlay.Size = new System.Drawing.Size(51, 51);
            this.ptbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPlay.TabIndex = 18;
            this.ptbPlay.TabStop = false;
            this.ptbPlay.Click += new System.EventHandler(this.ptbPlay_Click);
            // 
            // SongDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_commentPost);
            this.Controls.Add(this.panel1);
            this.Name = "SongDetailUC";
            this.Size = new System.Drawing.Size(649, 536);
            this.Load += new System.EventHandler(this.SongDetailUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_songImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            this.pn_commentPost.ResumeLayout(false);
            this.pn_commentPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_songImg;
        private System.Windows.Forms.PictureBox ptbBack;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_auther_singer;
        private System.Windows.Forms.Panel pn_commentPost;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.PictureBox pb_star_5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_star_4;
        private System.Windows.Forms.PictureBox pb_star_3;
        private System.Windows.Forms.PictureBox pb_star_2;
        private System.Windows.Forms.PictureBox pb_star_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel fpn_comment;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbEverageRating;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox ptbPlay;
    }
}
