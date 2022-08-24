using Pedrofy.Models;

namespace Pedrofy.Repository
{
    public class LazyObjects
    {
        public static readonly Lazy<Queue<Track>> TracksQueue = new(() => new Queue<Track>());
        public static readonly Lazy<Stack<Track>> TracksStack = new(() => new Stack<Track>());
        public static Lazy<Track> ActualTrack = new();
    }
}
