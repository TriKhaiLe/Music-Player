using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTH02.Entities;
using BaiTH02.Shared;

namespace BaiTH02.UserControls.PlaylistPage
{
    public partial class PlaylistUC : UserControl
    {
        public PlaylistUC()
        {
            InitializeComponent();
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            AddPlaylistForm addPlaylistForm = new AddPlaylistForm();
            addPlaylistForm.ShowDialog();

            // reload playlist
            LoadPlaylist();
        }

        private void LoadPlaylist()
        {
            // clear all playlist
            flowLayoutPanel1.Controls.Clear();

            // get all playlist
            List<Playlist> playlists = DataStore.Playlists;
            foreach (Playlist playlist in playlists)
            {
                // append playlist to flow layout panel
                PlaylistFolderBar playlistItem = new PlaylistFolderBar();
                playlistItem.LoadData(playlist.Name);
                flowLayoutPanel1.Controls.Add(playlistItem);

            }
        }

        private void PlaylistUC_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
        }
    }
}
