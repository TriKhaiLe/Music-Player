﻿using BaiTH02.Constants;
using BaiTH02.Entities;
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
        Song song;
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
            this.song = song;
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
            AddMusicToPlaylistForm addMusicToPlaylistForm = new AddMusicToPlaylistForm(song.Id);
            addMusicToPlaylistForm.ShowDialog();
        }
    }
}
