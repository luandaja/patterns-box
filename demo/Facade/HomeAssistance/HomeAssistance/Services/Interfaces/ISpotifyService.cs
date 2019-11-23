using System.Collections.Generic;

namespace HomeAssistance.Services
{
    public interface ISpotifyService
    {
        List<string> GetPlaylistsByGenre(int genreId);
        List<string> GetPlaylists();
        void Play(int PlaylistId);
        void Play();
    }
}
