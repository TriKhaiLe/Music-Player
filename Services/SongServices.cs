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
    public class SongServices
    {
        // save song to json file
        public static void SaveSong(List<Song> songs)
        {
            string json = JsonConvert.SerializeObject(songs);
            File.WriteAllText(DirectoryConsts.SONG_JSON_FILE_PATH, json);
        }


        // get song list from json file
        public static List<Song> GetSongList()
        {
            if (File.Exists(DirectoryConsts.SONG_JSON_FILE_PATH))
            {
                string json = File.ReadAllText(DirectoryConsts.SONG_JSON_FILE_PATH);
                List<Song> songs = JsonConvert.DeserializeObject<List<Song>>(json);
                return songs == null ? new List<Song>() : songs;
            }
            return new List<Song>();
        }

        // add a song to json file
        public static void AddSong(Song song)
        {
            List<Song> songs = GetSongList();
            songs.Add(song);
            SaveSong(songs);
        }

        // delete a song from json file
        public static void DeleteSong(string songId)
        {
            List<Song> songs = GetSongList();
            songs.RemoveAll(s => s.Id == songId);
            SaveSong(songs);
        }
    }
}
