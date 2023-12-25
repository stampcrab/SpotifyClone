using SpotifyClone.Services;
using System.Diagnostics;

namespace SpotifyClone.types
{
    public class Track
    {
        [ID]
        [GraphQLDescription("The Spotify ID for the track.")]
        public string Id { get; }

        [GraphQLDescription("The name of the track.")]
        public string Name { get; set; }

        [GraphQLDescription("The track length in milliseconds.")]
        public double DurationMs { get; set; }

        [GraphQLDescription(
            "Whether or not the track has explicit lyrics (true = yes it does; false = no it does not OR unknown)"
        )]
        public bool Explicit { get; set; }

        [GraphQLDescription("The Spotify URI for the track.")]
        public string Uri { get; set; }
        public Track(string id, string name, string uri)
        {
            Id = id;
            Name = name;
            Uri = uri;
        }

        public Track(SpotifyClone.Services.Track track)
        {
            Id = track.Id;
            Name = track.Name;
            Uri = track.Uri;
            Explicit = track.Explicit;
            DurationMs = track.Duration_Ms;
        }
    }
}
