using MVCSession2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCSession2.Configurations
{
    public class MemberConfigurations : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder) //configure warning because method hiding
        {
            builder.Property(M => M.CreatedAt).HasDefaultValueSql("GETDATE()")
                   .HasColumnName("JoinDate");

            base.Configure(builder); //call base class configure method to apply common configurations for GymUser
        }
    }
}
