using BaiTH02.Constants;
using BaiTH02.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH02.Services
{
    public class PlaylistServices
    {
        // save playlist to json file
        public static void SavePlaylist(List<Playlist> playlists)
        {
            string json = JsonConvert.SerializeObject(playlists);
            File.WriteAllText(DirectoryConsts.PLAYLIST_JSON_FILE_PATH, json);
        }

        // get playlist list from json file
        public static List<Playlist> GetPlaylistList()
        {
            if (File.Exists(DirectoryConsts.PLAYLIST_JSON_FILE_PATH))
            {
                string json = File.ReadAllText(DirectoryConsts.PLAYLIST_JSON_FILE_PATH);
                List<Playlist> playlists = JsonConvert.DeserializeObject<List<Playlist>>(json);
                return playlists == null ? new List<Playlist>() : playlists;
            }
            return new List<Playlist>();
        }

        // add a playlist to json file
        public static void AddPlaylist(Playlist playlist)
        {
            List<Playlist> playlists = GetPlaylistList();
            playlists.Add(playlist);
            SavePlaylist(playlists);
        }

        // delete a playlist from json file
        public static void DeletePlaylist(Guid playlistId)
        {
            List<Playlist> playlists = GetPlaylistList();
            playlists.RemoveAll(p => p.Id == playlistId);
            SavePlaylist(playlists);
        }
    }
}
