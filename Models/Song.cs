using System;

namespace Eurosong
{
    public class Song
    {
        public int ID { get; private set; }
        public string Title { get; set; }
        public int ArtistID { get; set; }
        public string Spotify { get; set; }
        public string Youtube { get; set; }
    }
}
