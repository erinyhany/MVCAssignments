using MVCSession2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCSession2.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {

            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("CK_Session_Capacity", "Capacity between 1 and 25");
                T.HasCheckConstraint("CK_Session_StartEndCheck", "EndTime > StartTime");
            });

            builder.HasOne(s => s.Trainer)
                   .WithMany(t => t.Sessions)
                   .HasForeignKey(s => s.TrainerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
