using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Catalog.DAL.DataContext.EntitiesConfigure
{
    public class GenreConfigure : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> modelBuilder)
        {
            modelBuilder.ToTable("Genre");
            modelBuilder.Property(genre => genre.Id).UseIdentityColumn(1, 1).IsRequired().HasColumnName("Id");
            
            modelBuilder.Property(genre => genre.Genres).IsRequired(true).HasMaxLength(100).HasColumnName("Genres");
            modelBuilder.Property(genre => genre.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Creation Date");
            modelBuilder.Property(genre => genre.ModifiedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Modified Date");

            modelBuilder
                .HasMany<Book>(book => book.Books)
                .WithOne(genre => genre.Genre)
                .HasForeignKey(book => book.Id)
                .OnDelete(DeleteBehavior.Restrict);            
        }

    }
}
