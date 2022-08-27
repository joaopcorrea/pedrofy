using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pedrofy_front.Models
{
    internal class TrackHistory : Track
    {
        [JsonPropertyName("idHistory")]
        public int IdHistory { get; set; }
    }
}
