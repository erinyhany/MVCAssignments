using MVCSession2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCSession2.Configurations
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(Ms => Ms.Id);

            builder.Property(Ms => Ms.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.HasOne(Ms => Ms.Plan)
                   .WithMany(p => p.PlanSubscriptions)
                   .HasForeignKey(Ms => Ms.PlanId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(Ms => Ms.Member)
                   .WithMany(m => m.MemberSubscriptions)
                   .HasForeignKey(Ms => Ms.MemberId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Ignore(Ms => Ms.Status);
        }

    }
}
