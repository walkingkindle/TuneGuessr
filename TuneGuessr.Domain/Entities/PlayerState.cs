namespace TuneGuessr.Domain.Entities
{
    public class PlayerState
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }

        public int Score { get; set; }
    }
}