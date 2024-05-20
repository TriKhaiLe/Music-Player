using BaiTH02.Entities;
using BaiTH02.Services;
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
    public partial class MusicUC : UserControl
    {
        public MusicUC()
        {
            InitializeComponent();
        }
        public event EventHandler MusicItem_Click;

        private void MusicUC_Load(object sender, EventArgs e)
        {
            fpn_musics.AutoScroll = false;
            fpn_musics.HorizontalScroll.Maximum = 0;
            fpn_musics.VerticalScroll.Visible = false;
            fpn_musics.AutoScroll = true;
            ReloadFlowPane(DataStore.Songs);
        }

        private void ReloadFlowPane(List<Song> songs)
        {
            fpn_musics.Controls.Clear();
            if (songs != null && songs.Count > 0)
            {
                foreach (Song song in songs)
                {
                    MusicInfoBar MusicInfoBar = new MusicInfoBar();
                    MusicInfoBar.SetMusicInfo(song, true, true, true, true, false);
                    MusicInfoBar.PlayButtonClick += MusicBlock_PlayButtonClick;
                    MusicInfoBar.MusicItemClick += MusicItemClick;
                    fpn_musics.Controls.Add(MusicInfoBar);

                    if (song.FileUrl == MusicPlayerManager.Instance._currentSongPath)
                        MusicPlayerManager.Instance._lastPlayedMusic = MusicInfoBar;
                }
            }
        }

        public void MusicBlock_PlayButtonClick(object sender, EventArgs e)
        {
            MusicInfoBar MusicInfoBar = (MusicInfoBar)sender;
            MusicPlayerManager.Instance.UpdateLastPlayedMusic(MusicInfoBar);
        }
        public void MusicItemClick(object sender, EventArgs e)
        {
            MusicItem_Click(sender, e);
        }

        private void pb_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_search.Text))
            {
                ReloadFlowPane(DataStore.Songs);
                return;
            }
            else
            {
                string searchValue = tb_search.Text.ToLower().RemoveDiacritics();
                List<Song> songs = DataStore.Songs.Where(s =>
                    s.Name.ToLower().RemoveDiacritics().Contains(searchValue) ||
                    s.Author.ToLower().RemoveDiacritics().Contains(searchValue))
                    .ToList();
                ReloadFlowPane(songs);
            }
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pb_search_Click((object)sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void btn_cate_all_Click(object sender, EventArgs e)
        {
            ReloadFlowPane(DataStore.Songs);
        }

        private void btn_cate_vietnam_Click(object sender, EventArgs e)
        {
            ReloadFlowPane(DataStore.Songs.Where(s => s.Genre == "VietNam").ToList());
        }

        private void btn_cate_international_Click(object sender, EventArgs e)
        {
            ReloadFlowPane(DataStore.Songs.Where(s => s.Genre == "International").ToList());
        }
    }
}
