using Backend.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Backend.WebApi.Data.Config;

public class NameConfiguration : IEntityTypeConfiguration<Name>
{
    public void Configure(EntityTypeBuilder<Name> builder)
    {
        builder.ToTable("NAME");

        builder.HasKey(n => n.Id);

        builder.Property(n => n.Id)
            .IsRequired()
            .ValueGeneratedOnAdd()
            .HasColumnName("NAME_ID");

        builder.Property(n => n.AuthName)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("NAME_AUTH");

        builder.Property(n => n.FirstName)
            .IsRequired()
            .HasMaxLength(25)
            .HasColumnName("NAME_FIRST");

        builder.Property(n => n.LastName)
            .IsRequired()
            .HasMaxLength(25)
            .HasColumnName("NAME_LAST");
    }
}