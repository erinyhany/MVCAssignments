namespace MVCSession2.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } // Nullable DateTime to allow for entities that haven't been updated yet

    }
}
