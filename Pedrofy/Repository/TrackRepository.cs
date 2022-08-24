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
    }
}
