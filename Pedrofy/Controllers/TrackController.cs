using Microsoft.AspNetCore.Mvc;
using Pedrofy.Models;
using Pedrofy.Repository;
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

        static Queue<Track> queue;
        static Stack<Track> stack;

        static Track ActualTrack 
        { 
            get
            {
                return LazyObjects.ActualTrack.Value;
            }
            set 
            {
                LazyObjects.ActualTrack = new(() => value);

                if (value?.IdTrack != null) TrackRepository.AddHistory(value);
            } 
        }

        public TrackController()
        { 
            url = "https://theaudiodb.com/api/v1/json/2/track.php?m=";
            albums = new string[] { "2337674", "2113944", "2113067", "2281777" };

            client = new HttpClient();

            queue = LazyObjects.TracksQueue.Value;
            stack = LazyObjects.TracksStack.Value;
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

            if (!string.IsNullOrEmpty(filter))
            {
                tracks = tracks
                    .OrderBy(t => rnd.Next())
                    .Where(t => t.StrTrack.ToLower().Contains(filter) ||
                                t.StrArtist.ToLower().Contains(filter) ||
                                t.StrAlbum.ToLower().Contains(filter))
                    .Select(t => { t.IntDuration = (Convert.ToInt32(t.IntDuration) / 1000).ToString(); return t; })
                    .ToList();
            }
            else
            {
                tracks = tracks
                .OrderBy(t => rnd.Next())
                .Select(t => { t.IntDuration = (Convert.ToInt32(t.IntDuration) / 1000).ToString(); return t; })
                .ToList();
            }

            if (tracks != null)
                return Ok(tracks);
            else
                return NotFound("");
        }

        [HttpGet("history")]
        public ObjectResult GetHistory()
        {
            List<TrackHistory> histories;
            histories = FileRepository.ReadFile<List<TrackHistory>>("history.json");

            if (histories != null)
                return Ok(histories.OrderByDescending(t => t.IdHistory).ToList());
            else
                return NotFound("");
        }

        [HttpGet("stats")]
        public ObjectResult GetStats()
        {
            Stats stats;
            stats = TrackRepository.GetStats();

            if (stats != null)
                return Ok(stats);
            else
                return NotFound("");
        }

        [HttpDelete("history/{id}")]
        public NoContentResult RemoveAtHistory(int id)
        {
            TrackRepository.RemoveHistory(id);

            return NoContent();
        }

        [HttpPost("queue")]
        public ObjectResult AddToQueue([FromBody]Track track)
        {
            queue.Enqueue(track);
            return Created(track.IdTrack, track.StrTrack);
        }

        [HttpPost("previous")]
        public ObjectResult PlayPrevious()
        {
            if (stack.Count == 0)
            {
                return NotFound("");
            }

            ActualTrack = stack.Pop();

            return Ok(ActualTrack);
        }

        [HttpPost("next")]
        public ObjectResult PlayNext()
        {
            if (ActualTrack?.IdTrack != null)
                stack.Push(ActualTrack);

            if (queue.Count == 0)
            {
                ActualTrack = null;
                return NotFound(ActualTrack);
            }

            var next = queue.Dequeue();

            ActualTrack = next;

            return Ok(ActualTrack);
        }
    }
}
