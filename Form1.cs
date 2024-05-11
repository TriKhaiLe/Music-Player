using BaiTH02.UserControls.HomePage;
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
            UCHome home = new UCHome();
            home.Dock = DockStyle.Fill;
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(home);
        }
    }
}
