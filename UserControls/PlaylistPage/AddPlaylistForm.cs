using BaiTH02.Entities;
using BaiTH02.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH02.UserControls.PlaylistPage
{
    public partial class AddPlaylistForm : Form
    {
        public AddPlaylistForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check empty input
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter playlist name");
                return;
            }

            // add new playlist
            Playlist playlist = new Playlist(textBox1.Text, new List<int>());
            DataStore.AddOrUpdatePlaylist(playlist);
            this.Close();
        }
    }
}
