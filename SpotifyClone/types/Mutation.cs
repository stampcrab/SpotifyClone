using SpotifyClone.Services;

namespace SpotifyClone.types
{
    public class Mutation
    {
        public async Task<Playlist?> AddTracksToPlaylist(AddItemsToPlaylistInput input, SpotifyService spotifyService)
        {
            string snapshot_id = await spotifyService.AddTrackToPlaylist(input.PlaylistId, input.Position, string.Join(",", input.Uris));

            var response = await spotifyService.GetPlaylistById(input.PlaylistId);
            return new Playlist(response);
        }
    }
}
