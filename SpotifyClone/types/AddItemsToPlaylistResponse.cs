namespace SpotifyClone.types
{
    public class AddItemsToPlaylistResponse
    {
        [GraphQLDescription("Similar to HTTP status code, represents the status of the mutation.")]
        public int Code { get; set; }

        [GraphQLDescription("Indicates whether the mutation was successful.")]
        public bool Success { get; set; }

        [GraphQLDescription("Human-readable message for the UI.")]
        public string Message { get; set; }
        [GraphQLDescription("The playlist that contains the newly added items.")]
        public Playlist? Playlist { get; set; }
        public AddItemsToPlaylistResponse(int code, bool success, string message)
        {
            Code = code;
            Success = success;
            Message = message;
        }

        public AddItemsToPlaylistResponse(int code, bool success, string message, Playlist playlist)
        {
            Code = code;
            Success = success;
            Message = message;
            Playlist = playlist;
        }
    }
}
