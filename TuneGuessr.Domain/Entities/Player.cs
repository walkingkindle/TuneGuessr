namespace TuneGuessr.Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SpotifyId { get; set; }

        public List<Playlist> PlayLists { get; set; }
    }
}
