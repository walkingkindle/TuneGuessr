namespace TuneGuessr.Domain.Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Song> Songs { get; set; }

        public int SpotifyId { get; set; }
    }
}
