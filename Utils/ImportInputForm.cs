using BaiTH02.Constants;
using BaiTH02.Entities;
using BaiTH02.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTH02.Utils
{
    public partial class ImportInputForm : Form
    {
        public ImportInputForm()
        {
            InitializeComponent();
            // Set the default value for the combobox is the first item
            comboBox1Type.SelectedIndex = 0;
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            // open a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox3FileName.Text = openFileDialog.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // load image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                textBox1ImageUrl.Text = openFileDialog.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            // Lấy dữ liệu từ các TextBox
            string songId = textBox4Id.Text;
            string songName = textBox1SongName.Text;
            string author = textBox2Author.Text;
            string genre = comboBox1Type.Text;
            string dataPath = @"D:\Desktop\music_info.txt";

            // Tạo hoặc mở file để ghi
            using (StreamWriter writer = new StreamWriter(dataPath, true))
            {

                // Ghi dữ liệu vào file với định dạng đã cho
                writer.WriteLine("Id nhạc: " + songId);
                writer.WriteLine("Tác giả: " + author);
                writer.WriteLine("Thể loại: " + genre);
                writer.WriteLine(); // Dòng trống để ngăn cách giữa các bản ghi

                // đổi tên file ảnh và mp3 theo id
                string imageFileName = songId + ".jpg";
                string mp3FileName = songId + ".mp3";

                // copy file ảnh và mp3 
                string imageFilePath = DirectoryConsts.IMAGE_FOLDER_PATH + imageFileName;
                string mp3FilePath = DirectoryConsts.IMAGE_FOLDER_PATH + mp3FileName;

                File.Copy(textBox1ImageUrl.Text, imageFilePath);
                File.Copy(textBox3FileName.Text, mp3FilePath);

                // Thông báo khi di chuyển file thành công
                MessageBox.Show("File ảnh và file nhạc đã được di chuyển vào thư mục mới");


            }

            // luu xuong json
            Song song = new Song(songId, songName, author, genre, textBox1ImageUrl.Text, textBox3FileName.Text, false, false, false);
            SongServices.AddSong(song);

            // xoa du lieu trong cac o text
            textBox4Id.Text = "";
            textBox1SongName.Text = "";
            textBox2Author.Text = "";
            textBox1ImageUrl.Text = "";
            textBox3FileName.Text = "";

            // tăng id lên 1
            int id = int.Parse(songId);
            id++;
            textBox4Id.Text = id.ToString();

        }
    }
}
