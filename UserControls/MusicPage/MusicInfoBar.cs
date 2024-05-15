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
            lbSongName.Text = song.Name;
            lbAuthor.Text = song.Author;
            ptbAddToPlaylist.Visible = isAddToPlaylistVisible;
            ptbFavorite.Visible = isFavoriteVisible;
            ptbPlay.Visible = isPlayVisible;
            ptbDownload.Visible = isDownloadVisible;
            ptbDelete.Visible = isDeleteVisible;
        }


    }
}
