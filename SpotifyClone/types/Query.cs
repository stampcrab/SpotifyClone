using Microsoft.AspNetCore.Mvc.ViewComponents;
using SpotifyClone.Services;
using System.Globalization;

namespace SpotifyClone.types
{
    public class Query
    {
        public async Task<List<Playlist>> Playlists(SpotifyService spotifyService)
        {
            var response =  await spotifyService.GetFeaturedPlaylists();
            return response.Playlists.Items.Select(item => new Playlist(item)).ToList();
        }
}
   
}
