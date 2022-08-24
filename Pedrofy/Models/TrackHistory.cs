using System.Text.Json.Serialization;

namespace Pedrofy.Models
{
    public class TrackHistory : Track
    {
        [JsonPropertyName("idHistory")]
        public int IdHistory { get; set; }
    }
}
