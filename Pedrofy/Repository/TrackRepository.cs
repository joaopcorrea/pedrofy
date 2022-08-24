using Pedrofy.Models;

namespace Pedrofy.Repository
{
    public static class TrackRepository
    {
        private static string fileName = "history.json";

        public static void AddHistory(Track track)
        {
            List<TrackHistory> histories;
            histories = FileRepository.ReadFile<List<TrackHistory>>(fileName);

            TrackHistory history = new TrackHistory
            {
                IdHistory = histories.Count > 0 ? histories.Max(t => t.IdHistory) + 1 : 1,
                IdTrack = track.IdTrack,
                IdAlbum = track.IdAlbum,
                IntDuration = track.IntDuration,
                StrAlbum = track.StrAlbum,
                StrArtist = track.StrArtist,
                StrTrack = track.StrTrack
            };

            histories.Add(history);
            FileRepository.WriteFile(fileName, histories);
        }

        public static void RemoveHistory(int id)
        {
            List<TrackHistory> histories;
            histories = FileRepository.ReadFile<List<TrackHistory>>(fileName);
            histories = histories.Where(t => t.IdHistory != id).ToList();
            FileRepository.WriteFile(fileName, histories);
        }

        public static Stats GetStats()
        {
            List<TrackHistory> histories;
            histories = FileRepository.ReadFile<List<TrackHistory>>(fileName);

            string mostListenedTrack = histories
                .GroupBy(t => t.StrTrack)
                .OrderByDescending(t => t.Count())
                .Select(t => t.Key)
                .FirstOrDefault();

            var mostListenedArtist = histories
                .GroupBy(t => t.StrArtist)
                .OrderByDescending(t => t.Count())
                .Select(t => t.Key)
                .FirstOrDefault();

            string mostListenedAlbum = histories
                .GroupBy(t => t.StrAlbum)
                .OrderByDescending(t => t.Count())
                .Select(t => t.Key)
                .FirstOrDefault();

            int secondsListened = histories.Sum(t => {
                if (int.TryParse(t.IntDuration, out int duration))
                    return duration;
                else return 0;
            });

            Stats stats = new Stats()
            {
                MostListenedTrack = mostListenedTrack,
                MostListenedAlbum = mostListenedAlbum,
                MostListenedArtist = mostListenedArtist,
                SecondsListened = secondsListened.ToString(),
            };

            return stats;
        }
    }
}
