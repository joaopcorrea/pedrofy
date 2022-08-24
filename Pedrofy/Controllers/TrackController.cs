using Microsoft.AspNetCore.Mvc;
using Pedrofy.Models;
using System.Text.Json;

namespace Pedrofy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackController : ControllerBase
    {
        string url;
        string[] albums;

        static HttpClient client;

        public TrackController()
        {
            url = "https://theaudiodb.com/api/v1/json/2/track.php?m=";
            albums = new string[] { "2337674", "2113944", "2113067", "2281777", };

            client = new HttpClient();
        }

        [HttpGet]
        public async Task<ObjectResult> GetAll([FromQuery]string? filter = "")
        {
            List<Track> tracks = new List<Track>();

            foreach(var album in albums)
            {
                HttpResponseMessage response = await client.GetAsync(url+album);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var albumTracks = JsonSerializer.Deserialize<TrackList>(json);

                    tracks = tracks.Concat(albumTracks.List).ToList();
                }
                else
                    return BadRequest(response);
            }
            Random rnd = new Random();
            filter = filter.Trim().ToLower();
            tracks = tracks
                .OrderBy(t => rnd.Next())
                .Where(t => t.StrTrack.ToLower().Contains(filter) ||
                            t.StrArtist.ToLower().Contains(filter) ||
                            t.StrAlbum.ToLower().Contains(filter))
                .ToList();

            return Ok(tracks);
        }

        [HttpGet("history")]
        public ObjectResult GetHistory()
        {
            return Ok("history");
        }

        [HttpDelete("history/{id}")]
        public NoContentResult RemoveAtHistory()
        {
            return NoContent();
        }

        [HttpPost("queue")]
        public ObjectResult AddToQueue()
        {
            return Created("", "created");
        }

        [HttpPost("previous")]
        public ObjectResult PlayPrevious()
        {
            return Ok("previous");
        }

        [HttpPost("next")]
        public ObjectResult PlayNext()
        {
            return Ok("next");
        }
    }
}
