namespace TuneGuessr.Domain.Entities
{
    public class Round
    {
        public int Id { get; set; }

        public int CurrentTrackId { get; set; }

        public int CurrentPreviewLength { get; set; }

        public bool IsFinished { get; set; }
    }
}