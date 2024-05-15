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
using BaiTH02.UserControls.MusicPage;

namespace BaiTH02.UserControls.PlaylistPage
{
    public partial class PlaylistUC : UserControl
    {
        public PlaylistUC()
        {
            InitializeComponent();
            panelPlaylistName.Visible = false;
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
                playlistItem.LoadData(playlist.Name, playlist.Id);
                playlistItem.DeleteButtonClick += PlaylistControl_DeleteButtonClick;
                playlistItem.PlaylistDoubleClicked += PlaylistControl_PlaylistDoubleClicked;
                flowLayoutPanel1.Controls.Add(playlistItem);
            }
        }

        private void PlaylistControl_PlaylistDoubleClicked(object sender, EventArgs e)
        {
            if (sender is PlaylistFolderBar playlistControl)
            {
                DisplaySongsInPlaylist(playlistControl.id);
            }
        }

        private void DisplaySongsInPlaylist(Guid playlistId)
        {
            flowLayoutPanel1.Controls.Clear();
            Playlist playlist = DataStore.GetPlaylistById(playlistId);
            foreach (string songId in playlist.SongIds)
            {
                Song song = DataStore.GetSongById(songId);
                MusicInfoBar songControl = new MusicInfoBar();
                songControl.SetMusicInfo(song, false, true, true, true, true);
                flowLayoutPanel1.Controls.Add(songControl);
            }
        }


        private void PlaylistControl_DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Remove the PlaylistControl from the FlowLayoutPanel
                if (sender is PlaylistFolderBar playlistControl)
                {
                    DataStore.DeletePlaylist(playlistControl.id);
                    flowLayoutPanel1.Controls.Remove(playlistControl);
                    playlistControl.Dispose(); // Dispose the control to free resources
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlaylistUC_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
        }
    }
}
