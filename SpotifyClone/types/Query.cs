using Microsoft.AspNetCore.Mvc.ViewComponents;
using SpotifyClone.Services;
using System.Globalization;

namespace SpotifyClone.types
{
    public class Query
    {
        public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
        {
            var response =  await spotifyService.GetFeaturedPlaylists();
            return response.Playlists.Items.Select(item => new Playlist(item)).ToList();
        }

        public async Task<Playlist?> GetPlaylist(SpotifyService spotifyService, [ID] string Id)
        {
            var response = await spotifyService.GetPlaylistById(Id);
            Console.WriteLine(response);
            return new Playlist(response);
        }
    }
   
}
