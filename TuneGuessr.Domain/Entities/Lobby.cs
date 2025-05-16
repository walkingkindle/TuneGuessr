namespace TuneGuessr.Domain.Entities
{
    public class Lobby
    {
        public int Id { get; set; }

        public List<Player> Players { get; set; }

        public List<PlayerState> PlayerStates { get; set; }

        public int PlayerCount { get; set; }

        public bool IsOpen { get; set; }

        public bool IsPublic { get; set; }

        //Here i need to enforce max 4 players
    }
}
