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

namespace BaiTH02.UserControls.HomePage
{
    public partial class MusicInfoBlock : UserControl
    {
        Song song;
        public MusicInfoBlock(Song song)
        {
            InitializeComponent();
            this.song = song;
            ptbCoverImg.Image = Image.FromFile(song.ImageUrl);
            lbName.Text = song.Name;
        }
        public event EventHandler MusicItemClick;
        private void MusicInfoItem_Click(object sender, EventArgs e)
        {
            MusicItemClick?.Invoke(song, e);
        }
    }
}
