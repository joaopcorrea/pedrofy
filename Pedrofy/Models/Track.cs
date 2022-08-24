using System.Text.Json.Serialization;

namespace Pedrofy.Models
{
    public class Track
    {
        [JsonPropertyName("idTrack")]
        public string IdTrack { get; set; }
        [JsonPropertyName("idAlbum")]
        public string IdAlbum { get; set; }
        [JsonPropertyName("strTrack")]
        public string StrTrack { get; set; }
        [JsonPropertyName("strAlbum")]
        public string StrAlbum { get; set; }
        [JsonPropertyName("strArtist")]
        public string StrArtist { get; set; }
        [JsonPropertyName("intDuration")]
        public string IntDuration { get; set; }
    }
}
