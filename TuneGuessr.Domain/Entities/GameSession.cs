namespace TuneGuessr.Domain.Entities
{
    public class GameSession
    {
        public int Id { get; set; }

        public List<Round> Rounds { get; set; }

        public List<PlayerState> PlayerStates { get; set; }

        public List<Player> Players { get; set; }

        public List<Song> Songs { get; set; }
    }
}
