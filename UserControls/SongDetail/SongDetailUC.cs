using BaiTH02.Constants;
using BaiTH02.Entities;
using BaiTH02.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTH02.UserControls.SongDetail
{
    public partial class SongDetailUC : UserControl
    {
        private Song song;
        private int star = 0;
        bool gender = true;
        public SongDetailUC(Song song)
        {
            InitializeComponent();
            this.song = song;
            rdbFemale.Checked = true;
        }

        private void SongDetailUC_Load(object sender, EventArgs e)
        {
            pb_songImg.Image = Image.FromFile(song.ImageUrl);
            lb_Name.Text = song.Name;
            lb_auther_singer.Text = song.Author;
            loadComments();
        }

        private void loadComments()
        {
            fpn_comment.Controls.Clear();

            List<Comment> comments = DataStore.GetCommentListBySongId(this.song.Id);
            foreach (Comment comment in comments)
            {
                CommentItem commentItem = new CommentItem();
                commentItem.loadComment(comment);
                commentItem.AutoSize = true;
                fpn_comment.Controls.Add(commentItem);
            }

            lbEverageRating.Text = CommentRepo.GetAverageStarBySongId(this.song.Id).ToString() + "/5";
        }

        private void btn_comment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_author.Text))
            {
                tb_author.Text = "Anonymous";
            }
            if (tb_author.Text.Length > 20)
            {
                MessageBox.Show("Cannot enter name longer than 20 characters");
                return;
            }
            if (string.IsNullOrEmpty(tb_comment.Text))
            {
                MessageBox.Show("Please enter your comment");
                return;
            }

            Comment comment = new Comment(song.Id, tb_comment.Text, tb_author.Text, star, gender);
            DataStore.AddComment(comment);
            loadComments();
            tb_comment.Clear();
        }

        public event EventHandler BackButton_Click;
        private void ptbBack_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
            this.Dispose();
        }

        private void pb_star_1_Click(object sender, EventArgs e)
        {
            star = 1;
            updateStar();
        }

        private void pb_star_2_Click(object sender, EventArgs e)
        {
            star = 2;
            updateStar();
        }

        private void pb_star_3_Click(object sender, EventArgs e)
        {
            star = 3;
            updateStar();
        }

        private void pb_star_4_Click(object sender, EventArgs e)
        {
            star = 4;
            updateStar();
        }

        private void pb_star_5_Click(object sender, EventArgs e)
        {
            star = 5;
            updateStar();
        }
        private void updateStar()
        {
            Image star_outline = Properties.Resources.star_outline;
            Image star_fill = Properties.Resources.star_fill;
            switch (this.star)
            {
                case 0:
                    {
                        pb_star_1.Image = star_outline;
                        pb_star_2.Image = star_outline;
                        pb_star_3.Image = star_outline;
                        pb_star_4.Image = star_outline;
                        pb_star_5.Image = star_outline;
                    }
                    break;
                case 1:
                    {
                        pb_star_1.Image = star_fill;
                        pb_star_2.Image = star_outline;
                        pb_star_3.Image = star_outline;
                        pb_star_4.Image = star_outline;
                        pb_star_5.Image = star_outline;
                    }
                    break;
                case 2:
                    {
                        pb_star_1.Image = star_fill;
                        pb_star_2.Image = star_fill;
                        pb_star_3.Image = star_outline;
                        pb_star_4.Image = star_outline;
                        pb_star_5.Image = star_outline;
                    }
                    break;
                case 3:
                    {
                        pb_star_1.Image = star_fill;
                        pb_star_2.Image = star_fill;
                        pb_star_3.Image = star_fill;
                        pb_star_4.Image = star_outline;
                        pb_star_5.Image = star_outline;
                    }
                    break;
                case 4:
                    {
                        pb_star_1.Image = star_fill;
                        pb_star_2.Image = star_fill;
                        pb_star_3.Image = star_fill;
                        pb_star_4.Image = star_fill;
                        pb_star_5.Image = star_outline;
                    }
                    break;
                case 5:
                    {
                        pb_star_1.Image = star_fill;
                        pb_star_2.Image = star_fill;
                        pb_star_3.Image = star_fill;
                        pb_star_4.Image = star_fill;
                        pb_star_5.Image = star_fill;
                    }
                    break;
                default:
                    {
                        pb_star_1.Image = star_outline;
                        pb_star_2.Image = star_outline;
                        pb_star_3.Image = star_outline;
                        pb_star_4.Image = star_outline;
                        pb_star_5.Image = star_outline;
                    }
                    break;
            }
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = false;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = true;
        }

            public event EventHandler PlayButtonClick;
        private void ptbPlay_Click(object sender, EventArgs e)
        {
            if (song != null)
            {
                song.IsPlayed = true;
                DataStore.AddOrUpdateSong(song);

                MusicPlayerManager.Instance.PlayOrPause(song.FileUrl);
                UpdatePlayButtonImage();
            }

            PlayButtonClick?.Invoke(this, e);
        }

        public void UpdatePlayButtonImage()
        {
            var player = MusicPlayerManager.Instance;
            if (player.IsPlaying(song.FileUrl))
            {
                ptbPlay.Image = Image.FromFile(DirectoryConsts.PLAYING_IMAGE_PATH);
            }
            else
            {
                ptbPlay.Image = Image.FromFile(DirectoryConsts.UNPLAY_IMAGE_PATH);
            }
        }

    }
}
