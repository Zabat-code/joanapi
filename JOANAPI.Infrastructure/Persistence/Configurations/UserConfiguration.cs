using JOANAPI.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(u => u.Username)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(u => u.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(350);
 
            builder.Property(u => u.Status)
                   .IsRequired().HasColumnType("boolean");
            builder.Property(u => u.Created)
                .HasDefaultValueSql("NOW()")
                .ValueGeneratedOnAdd();
            builder.Property(u=>u.Updated)
                .HasDefaultValueSql("NOW()")
                .ValueGeneratedOnAddOrUpdate();
            builder.HasQueryFilter(e => !EF.Property<bool>(e, "IsDelete"));
 
        }
    }
}
