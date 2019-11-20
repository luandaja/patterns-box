using System;
using System.Collections.Generic;

namespace HomeAssistance.Services
{
    public class SpotifyService
    {
        
        public List<string> GetPlaylistsByGenre(int genreId)
        {
            return new List<string> { "Playlist 1.png", "Playlist 2.png", "Playlist 3.png", "Serie A.png", "Serie B.png" };
        }
        public List<string> GetPlaylists()
        {
            return new List<string> { "Playlist 1.png", "Playlist 2.png", "Playlist 3.png", "Serie A.png", "Serie B.png" };
        }

        public void Play(int PlaylistId)
        {
            var name = GetPlaylist(PlaylistId);
            Console.WriteLine($"We are now playing {name}.");
        }

        private string GetPlaylist(int PlaylistId)
        {
            return $"Playlist {PlaylistId}";
        }
    }
}
