using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class InitCreateV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Description_DescriptionId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropIndex(
                name: "IX_Book_DescriptionId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.AddColumn<long>(
                name: "Description",
                table: "Book",
                type: "bigint",
                maxLength: 255,
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 378, DateTimeKind.Utc).AddTicks(3869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 59, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 377, DateTimeKind.Utc).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 58, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.AddColumn<string>(
                name: "Desctiption",
                table: "Author",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Desctiption",
                table: "Author");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(6280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 74, DateTimeKind.Utc).AddTicks(5982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 73, DateTimeKind.Utc).AddTicks(4340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 71, DateTimeKind.Utc).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.AddColumn<long>(
                name: "DescriptionId",
                table: "Book",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 59, DateTimeKind.Utc).AddTicks(2103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 378, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 58, DateTimeKind.Utc).AddTicks(46),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 377, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<long>(name: "Author Id", type: "bigint", nullable: false),
                    BookId = table.Column<long>(name: "Book Id", type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(name: "Creation Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 72, DateTimeKind.Utc).AddTicks(5050)),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 21, 15, 2, 55, 72, DateTimeKind.Utc).AddTicks(5307)),
                    AboutAuthor = table.Column<string>(name: "About Author", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AboutBook = table.Column<string>(name: "About Book", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_DescriptionId",
                table: "Book",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Description_DescriptionId",
                table: "Book",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
