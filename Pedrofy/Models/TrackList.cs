using System.Text.Json.Serialization;

namespace Pedrofy.Models
{
    public class TrackList
    {
        [JsonPropertyName("track")]
        public List<Track> List { get; set; }
    }
}
