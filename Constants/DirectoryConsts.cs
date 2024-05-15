using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH02.Constants
{
    public class DirectoryConsts
    {
        // song json file path
        public static string SONG_JSON_FILE_PATH = @"Data\music_info.json";

        // playlist json file path
        public static string PLAYLIST_JSON_FILE_PATH = @"Data\playlist_info.json";

        // image folder path stored in the debug folder of the project
        public static string IMAGE_FOLDER_PATH = @"Images\";

        // music folder path stored in the debug folder of the project
        public static string MUSIC_FOLDER_PATH = @"Songs\";

        // default image path
        public static string FAVORITE_IMAGE_PATH = @"Assets\icons8-love-30.png";
        public static string UNFAVORITE_IMAGE_PATH = @"Assets\icons8-favorite-30.png";
        public static string PLAYING_IMAGE_PATH = @"Assets\icons8-wave-50.png";
        public static string UNPLAY_IMAGE_PATH = @"Assets\icons8-play-60.png";
    }
}
