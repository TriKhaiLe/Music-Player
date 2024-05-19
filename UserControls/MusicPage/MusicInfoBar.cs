using BaiTH02.Constants;
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

            if (song.IsPlaying)
                ptbPlay.Image = Image.FromFile(DirectoryConsts.PLAYING_IMAGE_PATH);
            else
                ptbPlay.Image = Image.FromFile(DirectoryConsts.UNPLAY_IMAGE_PATH);
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
                MusicPlayerManager.Instance.PlayOrPause(_song.FileUrl);
                UpdatePlayButtonImage();
            }

            PlayButtonClick?.Invoke(this, e);
        }

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
    }
}
