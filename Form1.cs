using BaiTH02.Entities;
using BaiTH02.Shared;
using BaiTH02.UserControls.HomePage;
using BaiTH02.UserControls.LovePage;
using BaiTH02.UserControls.MusicPage;
using BaiTH02.UserControls.PlaylistPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadHomeTab();
        }

        private void PlaylistTab_Click(object sender, EventArgs e)
        {
            PlaylistUC playlistUC = new PlaylistUC();
            playlistUC.Dock = DockStyle.Fill;
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(playlistUC);
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {
            LoadHomeTab();
        }

        private void LoadHomeTab()
        {
            tempPanel.Controls.Clear();
            UCHome home = new UCHome();
            home.Dock = DockStyle.Fill;
            tempPanel.Controls.Add(home);
        }

        private void MusicTab_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            tempPanel.Controls.Add(flowLayoutPanel);

            List<Song> songs = DataStore.Songs;
            foreach (Song song in songs)
            {
                MusicInfoBar musicInfoBar = new MusicInfoBar();
                musicInfoBar.SetMusicInfo(song, true, true, true, true, false);
                musicInfoBar.PlayButtonClick += MusicBlock_PlayButtonClick;
                flowLayoutPanel.Controls.Add(musicInfoBar);

                if (song.FileUrl == MusicPlayerManager.Instance._currentSongPath)
                    MusicPlayerManager.Instance._lastPlayedMusic = musicInfoBar;
            }
        }

        public void MusicBlock_PlayButtonClick(object sender, EventArgs e)
        {
            MusicInfoBar musicInfoBar = (MusicInfoBar)sender;
            MusicPlayerManager.Instance.UpdateLastPlayedMusic(musicInfoBar);
        }

        private void btnPlaycrossfade_Click(object sender, EventArgs e)
        {

        }

        private void LoveTab_Click(object sender, EventArgs e)
        {
            LoveUC loveUC = new LoveUC();
            loveUC.Dock = DockStyle.Fill;
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(loveUC);
        }
    }
}
