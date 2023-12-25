﻿using Newtonsoft.Json;
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

        public async Task<Playlist> GetPlaylistById(string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://spotify-demo-api-fe224840a08c.herokuapp.com/v1/playlists/{id}" );
            string content = await response.Content.ReadAsStringAsync();
            Playlist playlist = JsonConvert.DeserializeObject<Playlist>(content);
            return playlist;
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
        public PaginatedOfTrack Tracks {  get; set; }
    }
    public class PaginatedOfPlaylist 
    {
        public List<Playlist> Items {  get; set; }
    }
    public class PaginatedOfTrack
    {
        public List<TrackItem> Items { get; set; }
    }
    public class TrackItem
    {
        public Track track { get; set; }
    }
    public class Track
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Duration_Ms { get; set; }
        public bool Explicit { get; set; }
        public string Uri {  get; set; }
    }
}
