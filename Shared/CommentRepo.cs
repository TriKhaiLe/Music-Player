using BaiTH02.Constants;
using BaiTH02.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiTH02.Shared
{
    // save all method for handling comments
    internal class CommentRepo
    {
        public static void SaveComment(List<Comment> comments)
        {
            string json = JsonConvert.SerializeObject(comments);
            File.WriteAllText(DirectoryConsts.COMMENTS_JSON_FILE_PATH, json);
        }

        public static List<Comment> GetCommentsList()
        {
            if (File.Exists(DirectoryConsts.COMMENTS_JSON_FILE_PATH))
            {
                string json = File.ReadAllText(DirectoryConsts.COMMENTS_JSON_FILE_PATH);
                List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(json);
                return comments == null ? new List<Comment>() : comments;
            }
            return new List<Comment>();
        }

        public static void AddComment(Comment comment)
        {
            List<Comment> comments = GetCommentsList();
            comments.Add(comment);
            SaveComment(comments);
        }

        // get comments by song id
        public static List<Comment> GetCommentsBySongId(string songId)
        {
            List<Comment> comments = GetCommentsList();
            return comments.Where(c => c.songId == songId).ToList();
        }

        // get number of comments by song id
        public static int GetNumberOfCommentsBySongId(string songId)
        {
            List<Comment> comments = GetCommentsList();
            return comments.Count(c => c.songId == songId);
        }

        // get average star by song id
        public static double GetAverageStarBySongId(string songId)
        {
            List<Comment> comments = GetCommentsList();
            List<Comment> commentsBySongId = comments.Where(c => c.songId == songId).ToList();
            if (commentsBySongId.Count == 0)
            {
                return 0;
            }
            return commentsBySongId.Average(c => c.star);
        }

    }
}
