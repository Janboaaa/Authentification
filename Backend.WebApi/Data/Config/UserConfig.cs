using Backend.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Backend.WebApi.Data.Config;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("SB");

        builder.HasKey(u => u.Id);

        builder.HasOne(u => u.Name)
            .WithMany()
            .HasForeignKey(u => u.NameId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(u => u.Id)
            .IsRequired()
            .ValueGeneratedOnAdd()
            .HasColumnName("SB_ID");

        builder.Property(u => u.NameId)
            .IsRequired()
            .HasColumnName("SB_NAME_ID");

        builder.Property(u => u.Key)
            .IsRequired()
            .HasColumnName("SB_PASSWORT")
            .HasMaxLength(50);

        builder.Property(u => u.RememberMe)
            .IsRequired()
            .HasColumnName("SB_REMEMBERME");
    }
}
