namespace BaiTH02.Utils
{
    partial class ImportInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportInputForm));
            this.textBox1SongName = new System.Windows.Forms.TextBox();
            this.textBox2Author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3FileName = new System.Windows.Forms.TextBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4Id = new System.Windows.Forms.TextBox();
            this.textBox1ImageUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1SongName
            // 
            this.textBox1SongName.Location = new System.Drawing.Point(150, 50);
            this.textBox1SongName.Name = "textBox1SongName";
            this.textBox1SongName.Size = new System.Drawing.Size(177, 22);
            this.textBox1SongName.TabIndex = 0;
            // 
            // textBox2Author
            // 
            this.textBox2Author.Location = new System.Drawing.Point(150, 117);
            this.textBox2Author.Name = "textBox2Author";
            this.textBox2Author.Size = new System.Drawing.Size(177, 22);
            this.textBox2Author.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tác giả";
            // 
            // comboBox1Type
            // 
            this.comboBox1Type.FormattingEnabled = true;
            this.comboBox1Type.Items.AddRange(new object[] {
            "VietNam",
            "International"});
            this.comboBox1Type.Location = new System.Drawing.Point(150, 176);
            this.comboBox1Type.Name = "comboBox1Type";
            this.comboBox1Type.Size = new System.Drawing.Size(177, 24);
            this.comboBox1Type.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể loại";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox3FileName
            // 
            this.textBox3FileName.Enabled = false;
            this.textBox3FileName.Location = new System.Drawing.Point(150, 372);
            this.textBox3FileName.Multiline = true;
            this.textBox3FileName.Name = "textBox3FileName";
            this.textBox3FileName.Size = new System.Drawing.Size(222, 44);
            this.textBox3FileName.TabIndex = 7;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(27, 372);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFile.TabIndex = 8;
            this.buttonLoadFile.Text = "Load file";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(416, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bìa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id";
            // 
            // textBox4Id
            // 
            this.textBox4Id.Location = new System.Drawing.Point(150, 6);
            this.textBox4Id.Name = "textBox4Id";
            this.textBox4Id.Size = new System.Drawing.Size(66, 22);
            this.textBox4Id.TabIndex = 12;
            this.textBox4Id.Text = "21";
            // 
            // textBox1ImageUrl
            // 
            this.textBox1ImageUrl.Enabled = false;
            this.textBox1ImageUrl.Location = new System.Drawing.Point(257, 236);
            this.textBox1ImageUrl.Multiline = true;
            this.textBox1ImageUrl.Name = "textBox1ImageUrl";
            this.textBox1ImageUrl.Size = new System.Drawing.Size(177, 88);
            this.textBox1ImageUrl.TabIndex = 13;
            // 
            // ImportInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.textBox1ImageUrl);
            this.Controls.Add(this.textBox4Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.textBox3FileName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2Author);
            this.Controls.Add(this.textBox1SongName);
            this.Name = "ImportInputForm";
            this.Text = "ImportInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1SongName;
        private System.Windows.Forms.TextBox textBox2Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3FileName;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4Id;
        private System.Windows.Forms.TextBox textBox1ImageUrl;
    }
}