using MVCSession2.Entities.Enums;

namespace MVCSession2.Entities
{
    public class Trainer : GymUser
    {
        public Specialities Speciality { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;

    }

}
