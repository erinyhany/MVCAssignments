namespace MVCSession2.Entities
{
    public class Session : BaseEntity
    {
        public string Description { get; set; } = default!;
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Trainer Trainer { get; set; } = default!;
        public int TrainerId { get; set; }
    }
}
