using Microsoft.EntityFrameworkCore;
using UnitOfWorkPractise.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UnitOfWorkPractise.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("nvarchar(30)");

        builder.HasOne(x => x.Faculty)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.Id_Faculty);
    }
}
