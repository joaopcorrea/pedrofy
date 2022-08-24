using System.Text.Json.Serialization;

namespace Pedrofy.Models
{
    public class Stats
    {
        [JsonPropertyName("mostListenedTrack")]
        public string MostListenedTrack { get; set; }
        [JsonPropertyName("mostListenedAlbum")]
        public string MostListenedAlbum { get; set; }
        [JsonPropertyName("mostListenedArtist")]
        public string MostListenedArtist { get; set; }
        [JsonPropertyName("secondsListened")]
        public string SecondsListened { get; set; }
    }
}
