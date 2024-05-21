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

namespace BaiTH02.UserControls.SongDetail
{
    public partial class CommentItem : UserControl
    {
        Comment comment;
        public CommentItem()
        {
            InitializeComponent();
        }

        public void loadComment(Comment comment)
        {
            this.comment = comment;
            lb_author.Text = comment.author;
            lb_comment.Text = comment.content;
            Image star_outline = Properties.Resources.star_outline;
            Image star_fill = Properties.Resources.star_fill;
            if (comment.gender)
                pb_avatar.Image = Properties.Resources.female;
            else
                pb_avatar.Image = Properties.Resources.male;

            switch (comment.star)
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
    }
}
