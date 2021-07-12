﻿// <auto-generated />
using System;
using Catalog.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Catalog.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210705101523_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorGenre", b =>
                {
                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<long>("GenresId")
                        .HasColumnType("bigint");

                    b.HasKey("AuthorId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("AuthorGenre");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutAuthor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Desctiption");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 21, DateTimeKind.Utc).AddTicks(4852))
                        .HasColumnName("Creation Date");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 22, DateTimeKind.Utc).AddTicks(7181))
                        .HasColumnName("Modified Date");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Book", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Author_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Author Id");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(2914))
                        .HasColumnName("Creation Date");

                    b.Property<long>("Genre_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Genre Id");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(3189))
                        .HasColumnName("Modified Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<long>("Status_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Status Id");

                    b.Property<string>("aboutBook")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Genre", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1030))
                        .HasColumnName("Creation Date");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Genres");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1275))
                        .HasColumnName("Modified Date");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 5, 10, 15, 23, 37, DateTimeKind.Utc).AddTicks(2139))
                        .HasColumnName("Creation Date");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Modified Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("AuthorGenre", b =>
                {
                    b.HasOne("Catalog.DAL.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.DAL.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Book", b =>
                {
                    b.HasOne("Catalog.DAL.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Catalog.DAL.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Catalog.DAL.Entities.Status", "Status")
                        .WithMany("Books")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Status", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
