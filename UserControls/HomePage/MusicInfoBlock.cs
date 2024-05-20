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
        public MusicInfoBlock(Song song)
        {
            InitializeComponent();
            ptbCoverImg.Image = Image.FromFile(song.ImageUrl);
            lbName.Text = song.Name;
        }
    }
}
