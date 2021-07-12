using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Catalog.DAL.DataContext.EntitiesConfigure
{
    public class StatusConfigure : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> modelBuilder)
        {
            modelBuilder.ToTable("Status");
            modelBuilder.Property(status => status.Id).UseIdentityColumn(1, 1).IsRequired().HasColumnName("Id");
            modelBuilder.Property(status => status.Name).IsRequired(true).HasMaxLength(100).HasColumnName("Name");
            modelBuilder.Property(status => status.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Creation Date");
            modelBuilder.Property(status => status.ModifiedDate).IsRequired(true).HasColumnName("Modified Date");

            modelBuilder
                .HasMany<Book>(book => book.Books)
                .WithOne(status => status.Status)
                .HasForeignKey(book => book.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
