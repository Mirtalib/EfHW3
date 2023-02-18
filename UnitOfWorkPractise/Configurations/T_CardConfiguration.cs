using UnitOfWorkPractise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace UnitOfWorkPractise.Configurations
{
    public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.Property(x => x.DateOut)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.DateIn)
                .IsRequired(false);

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.T_Cards)
                .HasForeignKey(x=>x.Id_Teacher);

            builder.HasOne(x => x.Lib)
                .WithMany(x => x.T_Cards)
                .HasForeignKey(x => x.Id_Lib);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.T_Cards)
                .HasForeignKey(x => x.Id_Book);
        }
    }
}