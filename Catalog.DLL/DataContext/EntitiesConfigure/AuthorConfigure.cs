using Microsoft.EntityFrameworkCore;
using System;
using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.DAL.DataContext.EntitiesConfigure
{
    public class AuthorConfigure : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> modelBuilder)
        {
            modelBuilder.ToTable("Author");
            modelBuilder.Property(author => author.Id).UseIdentityColumn(1, 1).IsRequired().HasColumnName("Id");
            modelBuilder.Property(author => author.AuthorName).IsRequired(true).HasMaxLength(100).HasColumnName("Name");
            modelBuilder.Property(author => author.AboutAuthor).IsRequired(true).HasMaxLength(255).HasColumnName("Desctiption");
            modelBuilder.Property(author => author.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Creation Date");
            modelBuilder.Property(author => author.ModifiedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow).HasColumnName("Modified Date");

            // Связь. Один автор может иметь множество книг, перечисленных по ID. Удалять запись об авторе нельзя.
            // Тип связи, один ко многим.
            modelBuilder
                .HasMany<Book>(book => book.Books)
                .WithOne(author => author.Author)
                .HasForeignKey(book => book.Id)
                .OnDelete(DeleteBehavior.Restrict);
        
            /*modelBuilder
                .HasMany<Genre>(genre => genre.Genres)
                .WithOne(author => author.Author)
                .OnDelete(DeleteBehavior.Restrict);*/

        }
    }
}
