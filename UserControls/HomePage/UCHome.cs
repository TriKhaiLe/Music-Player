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

namespace BaiTH02.UserControls.HomePage
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            // call event click of recently label
            llRecently_LinkClicked(sender, null);

        }

        private void llRecently_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // clear all controls in flow layout panel 
            // and load isplay = true songs
            flowLayoutPanel1.Controls.Clear();
            List<Song> songs = DataStore.Songs;
            foreach (Song song in songs)
            {
                if (song.IsPlayed)
                {
                    MusicInfoBlock musicInfoBlock = new MusicInfoBlock(song);
                    flowLayoutPanel1.Controls.Add(musicInfoBlock);
                }
            }

            // set bg gradient active caption color for selected label
            llRecently.BackColor = Color.Aqua;

            // set bg of download label to bg color of this form
            llDownload.BackColor = this.BackColor;
        }

        private void llDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // clear all controls in flow layout panel 
            // and load isDownload = true songs
            flowLayoutPanel1.Controls.Clear();
            List<Song> songs = DataStore.Songs;
            foreach (Song song in songs)
            {
                if (song.IsDownloaded)
                {
                    MusicInfoBlock musicInfoBlock = new MusicInfoBlock(song);
                    flowLayoutPanel1.Controls.Add(musicInfoBlock);
                }
            }

            // set bg gradient active caption color for selected label
            llDownload.BackColor = Color.Aqua;

            // set bg of recently label to bg color of this form
            llRecently.BackColor = this.BackColor;
        }
    }
}
