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
    [Migration("20210621150255_InitMigration")]
    partial class InitMigration
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

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 58, DateTimeKind.Utc).AddTicks(46))
                        .HasColumnName("Creation Date");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 59, DateTimeKind.Utc).AddTicks(2103))
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
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6492))
                        .HasColumnName("Creation Date");

                    b.Property<long?>("DescriptionId")
                        .HasColumnType("bigint");

                    b.Property<long>("Description_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Description Id");

                    b.Property<long>("Genre_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Genre Id");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6829))
                        .HasColumnName("Modified Date");

                    b.Property<long>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("bigint")
                        .HasColumnName("Name");

                    b.Property<long>("Status_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("Status Id");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Catalog.DAL.Entities.Description", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Author_id")
                        .HasColumnType("bigint")
                        .HasColumnName("Author Id");

                    b.Property<long>("Book_id")
                        .HasColumnType("bigint")
                        .HasColumnName("Book Id");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 72, DateTimeKind.Utc).AddTicks(5050))
                        .HasColumnName("Creation Date");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 72, DateTimeKind.Utc).AddTicks(5307))
                        .HasColumnName("Modified Date");

                    b.Property<string>("aboutAuthor")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("About Author");

                    b.Property<string>("aboutBook")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("About Book");

                    b.HasKey("Id");

                    b.ToTable("Description");
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

                    b.Property<long>("Author_id")
                        .HasColumnType("bigint")
                        .HasColumnName("Author id");

                    b.Property<long>("Book_id")
                        .HasColumnType("bigint")
                        .HasColumnName("Book id");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4340))
                        .HasColumnName("Creation Date");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Genres");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4595))
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

                    b.Property<long>("Book_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(5982))
                        .HasColumnName("Creation Date");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(6280))
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
                    b.HasOne("Catalog.DAL.Entities.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

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

                    b.Navigation("Description");

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
