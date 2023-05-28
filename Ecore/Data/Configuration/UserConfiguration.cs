using Ecore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ecore.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(250);
            builder.HasIndex(x => x.Username)
                .IsUnique();
            builder.Property(x => x.FirstName).HasMaxLength(250);
            builder.Property(x => x.LastName).HasMaxLength(250);
            builder.Property(x => x.Password).HasMaxLength(250);
            builder.Property(x => x.Email).HasMaxLength(250);
        }
    }
}
