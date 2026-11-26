using MVCSession2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCSession2.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser  //<GymUser> this will be used to configure the GymUser entity in the database.
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(G => G.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(G => G.PhoneNumber)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);

            builder.Property(G => G.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.HasIndex(G => G.Email).IsUnique(); 
            builder.HasIndex(G => G.PhoneNumber).IsUnique();

            builder.ComplexProperty(G => G.Address);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("EmailCheck", "Email LIKE '%@%.%'");
                T.HasCheckConstraint("PhoneNumberCheck", "Len(PhoneNumber) = 11 And (PhoneNumber LIKE '011%' or PhoneNumber LIKE '012%' or PhoneNumber LIKE '015%')");
            });

        }
    }
}
