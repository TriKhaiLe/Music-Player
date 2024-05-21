using BaiTH02.Constants;
using BaiTH02.Entities;
using BaiTH02.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH02.UserControls.MusicPage
{
    public partial class MusicInfoBar : UserControl
    {
        public Song _song;

        public MusicInfoBar()
        {
            InitializeComponent();
        }

        public void SetMusicInfo(
            Song song, 
            bool isAddToPlaylistVisible, 
            bool isFavoriteVisible, 
            bool isPlayVisible, 
            bool isDownloadVisible, 
            bool isDeleteVisible)
        {
            this._song = song;
            ptbCoverImg.Image = Image.FromFile(song.ImageUrl);
            lbSongName.Text = song.Name;
            lbAuthor.Text = song.Author;
            ptbAddToPlaylist.Visible = isAddToPlaylistVisible;
            ptbFavorite.Visible = isFavoriteVisible;
            ptbPlay.Visible = isPlayVisible;
            ptbDownload.Visible = isDownloadVisible;
            ptbDelete.Visible = isDeleteVisible;

            if (song.IsFavorite)
                ptbFavorite.Image = Image.FromFile(DirectoryConsts.FAVORITE_IMAGE_PATH);
            else
                ptbFavorite.Image = Image.FromFile(DirectoryConsts.UNFAVORITE_IMAGE_PATH);

            UpdatePlayButtonImage();
        }

        private void ptbAddToPlaylist_Click(object sender, EventArgs e)
        {
            AddMusicToPlaylistForm addMusicToPlaylistForm = new AddMusicToPlaylistForm(_song.Id);
            addMusicToPlaylistForm.ShowDialog();
        }


            public event EventHandler PlayButtonClick;
        private void ptbPlay_Click(object sender, EventArgs e)
        {
            if (_song != null)
            {
                _song.IsPlayed = true;
                DataStore.AddOrUpdateSong(_song);

                MusicPlayerManager.Instance.PlayOrPause(_song.FileUrl);
                UpdatePlayButtonImage();
            }

            PlayButtonClick?.Invoke(this, e);
        }

        // method to update the icon of the current playing MusicInfoBar
        public void UpdatePlayButtonImage()
        {
            var player = MusicPlayerManager.Instance;
            if (player.IsPlaying(_song.FileUrl))
            {
                ptbPlay.Image = Image.FromFile(DirectoryConsts.PLAYING_IMAGE_PATH);
            }
            else
            {
                ptbPlay.Image = Image.FromFile(DirectoryConsts.UNPLAY_IMAGE_PATH);
            }
        }

        private void ptbFavorite_Click(object sender, EventArgs e)
        {
            if (_song == null)
                return;

            _song.IsFavorite = !_song.IsFavorite;
            if (_song.IsFavorite)
                ptbFavorite.Image = Image.FromFile(DirectoryConsts.FAVORITE_IMAGE_PATH);
            else
                ptbFavorite.Image = Image.FromFile(DirectoryConsts.UNFAVORITE_IMAGE_PATH);

            DataStore.AddOrUpdateSong(_song);
        }

        private void ptbDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = Path.Combine(folderBrowserDialog.SelectedPath, Path.GetFileName(_song.FileUrl));

                    try
                    {
                        if (File.Exists(destinationPath))
                        {
                            DialogResult result = MessageBox.Show("The file already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No)
                            {
                                return;
                            }
                        }

                        File.Copy(_song.FileUrl, destinationPath, true);
                        _song.IsDownloaded = true;
                        DataStore.AddOrUpdateSong(_song);
                        MessageBox.Show("Download completed successfully!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while downloading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public event EventHandler MusicItemClick;
        private void MusicInfoItem_Click(object sender, EventArgs e)
        {
            MusicItemClick(_song, e);
        }

        public event EventHandler DeleteButtonClick;

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, e);
        }
    }
}
