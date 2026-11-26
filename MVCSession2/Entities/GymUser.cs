using MVCSession2.Entities.Enums;

namespace MVCSession2.Entities
{
    public abstract class GymUser : BaseEntity   
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public Address Address { get; set; } = default!;
        public Gender Gender { get; set; }
    }
}
