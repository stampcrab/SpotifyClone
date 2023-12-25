
namespace SpotifyClone.types
{
    public class Playlist
    {

        public Playlist(Services.Playlist item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            var tracks = item.Tracks.Items.Select((trackItem) => new Track(trackItem.track));
            Tracks = tracks.ToList();
        }

        public Playlist(string id, string name)
        {
            Id = id;
            Name = name;
            
        }
        [ID]
        [GraphQLDescription("The Spotify ID for the playlist.")]
        public string Id { get; set; }
        [GraphQLDescription("The name of the playlist.")]
        public string? Name { get; set; }
        [GraphQLDescription(
            "The playlist description. _Only returned for modified, verified playlists, otherwise null_."
            )]
        public string? Description { get; set; }
        [GraphQLDescription("The playlist's tracks.")]
        public List<Track> Tracks { get; set; }
    }
}
