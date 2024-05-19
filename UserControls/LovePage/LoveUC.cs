using BaiTH02.Entities;
using BaiTH02.Shared;
using BaiTH02.UserControls.MusicPage;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTH02.UserControls.LovePage
{
    public partial class LoveUC : UserControl
    {
        public LoveUC()
        {
            InitializeComponent();
            LoadLovedSongs();
        }

        private void LoadLovedSongs()
        {
            flowLayoutPanel1.Controls.Clear();
            
            // get loved songs from all songs
            List<Song> lovedSongs = DataStore.Songs.FindAll(song => song.IsFavorite);
            foreach (Song song in lovedSongs)
            {
                MusicInfoBar musicInfoBar = new MusicInfoBar();
                musicInfoBar.SetMusicInfo(song, false, false, true, true, false);
                flowLayoutPanel1.Controls.Add(musicInfoBar);
            }
        }
    }
}
