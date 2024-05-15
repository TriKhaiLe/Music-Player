using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH02.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<string> SongIds { get; set; }

        public Playlist()
        {
            Id = Guid.NewGuid();
            Name = "";
            ImageUrl = "";
            SongIds = new List<string>();
        }

        public Playlist(string name, List<string> songIds)
        {
            Id = Guid.NewGuid();
            Name = name;
            SongIds = songIds;
        }


    }
}
