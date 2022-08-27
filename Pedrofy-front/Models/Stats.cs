using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pedrofy_front.Models
{
    internal class Stats
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
