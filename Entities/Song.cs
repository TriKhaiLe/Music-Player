using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH02.Entities
{
    public class Song
    {
        // id, name, author, genre, imageUrl, fileUrl, isFavorite, isPlaying, isDownloaded
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public string FileUrl { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsPlaying { get; set; }
        public bool IsDownloaded { get; set; }
        public Song()
        {
            Id = "";
            Name = "";
            Author = "";
            Genre = "";
            ImageUrl = "";
            FileUrl = "";
            IsFavorite = false;
            IsPlaying = false;
            IsDownloaded = false;
        }
        public Song(string id, string name, string author, string genre, string imageUrl, string fileUrl, bool isFavorite, bool isPlaying, bool isDownloaded)
        {
            Id = id;
            Name = name;
            Author = author;
            Genre = genre;
            ImageUrl = imageUrl;
            FileUrl = fileUrl;
            IsFavorite = isFavorite;
            IsPlaying = isPlaying;
            IsDownloaded = isDownloaded;
        }

    }
}
