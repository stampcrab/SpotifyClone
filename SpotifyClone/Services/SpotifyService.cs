using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace SpotifyClone.Services
{
    public class SpotifyService
    {
        private HttpClient _httpClient;

        public SpotifyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<SpotifyFeaturedPlaylist> GetFeaturedPlaylists()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://spotify-demo-api-fe224840a08c.herokuapp.com/v1/browse/featured-playlists");
            string content = await response.Content.ReadAsStringAsync();
            SpotifyFeaturedPlaylist featuredPlaylist = JsonConvert.DeserializeObject<SpotifyFeaturedPlaylist>(content);
            return featuredPlaylist;
        }

    }
    public class SpotifyFeaturedPlaylist
    {
        public string Message { get; set; }
        public PaginatedOfPlaylist Playlists { get; set; }
    }
    public class Playlist
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
    public class PaginatedOfPlaylist 
    {
        public List<Playlist> Items {  get; set; }
    }
}
