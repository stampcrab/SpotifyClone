
namespace SpotifyClone.types
{
    public class Playlist
    {
        private Services.Playlist item;

        public Playlist(Services.Playlist item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
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
    }
}
