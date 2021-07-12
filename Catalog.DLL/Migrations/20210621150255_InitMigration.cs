using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 58, DateTimeKind.Utc).AddTicks(46)),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 59, DateTimeKind.Utc).AddTicks(2103))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<long>(name: "Author Id", type: "bigint", nullable: false),
                    BookId = table.Column<long>(name: "Book Id", type: "bigint", nullable: false),
                    AboutBook = table.Column<string>(name: "About Book", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AboutAuthor = table.Column<string>(name: "About Author", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 72, DateTimeKind.Utc).AddTicks(5050)),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 72, DateTimeKind.Utc).AddTicks(5307))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authorid = table.Column<long>(name: "Author id", type: "bigint", nullable: false),
                    Bookid = table.Column<long>(name: "Book id", type: "bigint", nullable: false),
                    Genres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4340)),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4595))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(5982)),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(6280))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorGenre",
                columns: table => new
                {
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    GenresId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorGenre", x => new { x.AuthorId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_AuthorGenre_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorGenre_Genre_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<long>(name: "Author Id", type: "bigint", nullable: false),
                    DescriptionId = table.Column<long>(name: "Description Id", type: "bigint", nullable: false),
                    GenreId = table.Column<long>(name: "Genre Id", type: "bigint", nullable: false),
                    StatusId = table.Column<long>(name: "Status Id", type: "bigint", nullable: false),
                    Name = table.Column<long>(type: "bigint", maxLength: 100, nullable: false),
                    DescriptionId0 = table.Column<long>(name: "DescriptionId", type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6492)),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6829))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Author_Id",
                        column: x => x.Id,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Description_DescriptionId",
                        column: x => x.DescriptionId0,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Genre_Id",
                        column: x => x.Id,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Status_Id",
                        column: x => x.Id,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorGenre_GenresId",
                table: "AuthorGenre",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_DescriptionId",
                table: "Book",
                column: "DescriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorGenre");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
