using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Catalog.DAL.DataContext.EntitiesConfigure
{
    public class BookConfigure : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> modelBuilder)
        {
            modelBuilder.ToTable("Book");
            modelBuilder.Property(book => book.Id).UseIdentityColumn(1, 1).IsRequired().HasColumnName("Id");
            modelBuilder.Property(book => book.Name).IsRequired(true).HasMaxLength(100).HasColumnName("Name");
            modelBuilder.Property(book => book.AboutBook).IsRequired(true).HasMaxLength(255).HasColumnName("About Book");
            //FK
            modelBuilder.Property(book => book.Author_Id).IsRequired(true).HasColumnName("Author Id");           
            modelBuilder.Property(book => book.Genre_Id).IsRequired(true).HasColumnName("Genre Id");
            modelBuilder.Property(book => book.Status_Id).IsRequired(true).HasColumnName("Status Id");
            //PK
            modelBuilder.Property(book => book.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Creation Date");
            modelBuilder.Property(book => book.ModifiedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Modified Date");

            modelBuilder
                .HasOne<Author>(author => author.Author)
                .WithMany(book => book.Books)
                .HasForeignKey(author => author.Author_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .HasOne<Genre>(genre => genre.Genre)
                .WithMany(book => book.Books)
                .HasForeignKey(genre => genre.Genre_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .HasOne<Status>(status => status.Status)
                .WithMany(book => book.Books)
                .HasForeignKey(status => status.Status_Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
