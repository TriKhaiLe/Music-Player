using BaiTH02.Constants;
using BaiTH02.Entities;
using BaiTH02.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTH02.Shared
{
    public static class DataStore
    {
        public static List<Song> Songs { get; private set; }
        public static List<Playlist> Playlists { get; private set; }
        public static Song PlayingSong { get; set; }
        public static List<Comment> Comments { get; private set; }

        static DataStore()
        {
            LoadData();
        }

        private static void LoadData()
        {
            Songs = SongServices.GetSongList();
            Playlists = PlaylistServices.GetPlaylistList();
            Comments = CommentRepo.GetCommentsList();
        }

        // add or update song
        public static void AddOrUpdateSong(Song song)
        {
            if (Songs.Exists(s => s.Id == song.Id))
            {
                Songs[Songs.FindIndex(s => s.Id == song.Id)] = song;
            }
            else
            {
                Songs.Add(song);
            }
            SongServices.SaveSong(Songs);
        }

        // add or update playlist
        public static void AddOrUpdatePlaylist(Playlist playlist)
        {
            if (Playlists.Exists(p => p.Id == playlist.Id))
            {
                Playlists[Playlists.FindIndex(p => p.Id == playlist.Id)] = playlist;
            }
            else
            {
                Playlists.Add(playlist);
            }
            PlaylistServices.SavePlaylist(Playlists);
        }

        // delete song
        public static void DeleteSong(string songId)
        {
            Songs.RemoveAll(s => s.Id == songId);
            SongServices.SaveSong(Songs);
        }

        // delete playlist
        public static void DeletePlaylist(Guid playlistId)
        {
            Playlists.RemoveAll(p => p.Id == playlistId);
            PlaylistServices.SavePlaylist(Playlists);
        }

        // get song by id
        public static Song GetSongById(string songId)
        {
            return Songs.FirstOrDefault(s => s.Id == songId);
        }

        // get playlist by id
        public static Playlist GetPlaylistById(Guid playlistId)
        {
            return Playlists.FirstOrDefault(p => p.Id == playlistId);
        }

        // add song to playlist
        public static void AddSongToPlaylist(Guid playlistId, string songId)
        {
            Playlist playlist = Playlists.FirstOrDefault(p => p.Id == playlistId);
            if (playlist == null)
                return;

            if (playlist.SongIds.Contains(songId))
            {
                MessageBox.Show("Song already exists in this playlist");
                return;
            }

            playlist.SongIds.Add(songId);
            AddOrUpdatePlaylist(playlist);
            MessageBox.Show("Add song to playlist successfully");
        }

        // delete song from playlist
        public static void DeleteSongFromPlaylist(Guid playlistId, string songId)
        {
            Playlist playlist = Playlists.FirstOrDefault(p => p.Id == playlistId);
            if (playlist == null)
                return;

            playlist.SongIds.Remove(songId);
            AddOrUpdatePlaylist(playlist);
        }

        // delete all songs from playlist
        public static void DeleteAllSongsFromPlaylist(Guid playlistId)
        {
            Playlist playlist = Playlists.FirstOrDefault(p => p.Id == playlistId);
            if (playlist == null)
                return;

            playlist.SongIds.Clear();
            AddOrUpdatePlaylist(playlist);
        }

        public static void AddComment(Comment comment)
        {
            Comments.Add(comment);
            CommentRepo.AddComment(comment);
        }

        public static List<Comment> GetCommentListBySongId(string songId)
        {
            return Comments.Where(x => x.songId == songId).ToList();
        }
    }
}
