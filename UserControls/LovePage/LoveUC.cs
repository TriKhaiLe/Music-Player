using BaiTH02.Entities;
using BaiTH02.Shared;
using BaiTH02.UserControls.MusicPage;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH02.UserControls.LovePage
{
    public partial class LoveUC : UserControl
    {
        List<Song> lovedSongs;
        public LoveUC()
        {
            InitializeComponent();
            LoadLovedSongs();
        }

        private void LoadLovedSongs()
        {
            flowLayoutPanel1.Controls.Clear();
            
            // get loved songs from all songs
            lovedSongs = DataStore.Songs.FindAll(song => song.IsFavorite);
            foreach (Song song in lovedSongs)
            {
                MusicInfoBar musicInfoBar = new MusicInfoBar();
                musicInfoBar.SetMusicInfo(song, false, false, true, true, false);
                musicInfoBar.MusicItemClick += MusicItemClick;
                flowLayoutPanel1.Controls.Add(musicInfoBar);
            }
        }

        public event EventHandler MusicItem_Click;
        public void MusicItemClick(object sender, EventArgs e)
        {
            MusicItem_Click(sender, e);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await PlayAllLovedSongsWithCrossFade();

        }

        private async Task PlayAllLovedSongsWithCrossFade()
        {
            var player = MusicPlayerManager.Instance;

            foreach (var song in lovedSongs)
            {
                player.Play(song.FileUrl);
                await CrossFadeIn(player);
                await Task.Delay(9000); // Play for 11 seconds
                await CrossFadeOut(player);
                await Task.Delay(3000); // Wait for the fade-out to complete
            }
        }

        private async Task CrossFadeIn(MusicPlayerManager player)
        {
            for (int volume = 0; volume <= 100; volume++)
            {
                player.SetVolume(volume);
                await Task.Delay(30); // Gradually increase volume over 4 seconds
            }
        }

        private async Task CrossFadeOut(MusicPlayerManager player)
        {
            for (int volume = 100; volume >= 0; volume--)
            {
                player.SetVolume(volume);
                await Task.Delay(30); // Gradually decrease volume over 4 seconds
            }
        }


    }
}
