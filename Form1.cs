using BaiTH02.Constants;
using BaiTH02.Entities;
using BaiTH02.Shared;
using BaiTH02.UserControls.HomePage;
using BaiTH02.UserControls.LovePage;
using BaiTH02.UserControls.MusicPage;
using BaiTH02.UserControls.PlaylistPage;
using BaiTH02.UserControls.SongDetail;
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
            playlistUC.MusicItem_Click += MusicItem_Click;
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
            home.MusicItem_Click += MusicItem_Click;
            tempPanel.Controls.Add(home);
        }

        private void MusicTab_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            MusicUC musicUC = new MusicUC();
            musicUC.Dock = DockStyle.Fill;
            musicUC.MusicItem_Click += MusicItem_Click;
            tempPanel.Controls.Add(musicUC);
        }

        private void MusicItem_Click(object sender, EventArgs e)
        {
            Song song = sender as Song;
            SongDetailUC songDetail = new SongDetailUC(song);
            songDetail.Dock = DockStyle.Fill;
            songDetail.BackButton_Click += SongDetail_BackButton_Click;
            tempPanel.Controls[0].Visible = false;
            tempPanel.Controls.Add(songDetail);
        }

        private void SongDetail_BackButton_Click(object sender, EventArgs e)
        {
            tempPanel.Controls[0].Visible = true;
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
            loveUC.MusicItem_Click += MusicItem_Click;
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(loveUC);
        }
    }
}
