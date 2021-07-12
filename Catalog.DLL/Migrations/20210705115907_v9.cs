using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_Id",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Status_Id",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 58, DateTimeKind.Utc).AddTicks(9786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 57, DateTimeKind.Utc).AddTicks(9091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 57, DateTimeKind.Utc).AddTicks(8821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 60, DateTimeKind.Utc).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 60, DateTimeKind.Utc).AddTicks(5469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 45, DateTimeKind.Utc).AddTicks(9346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 289, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 44, DateTimeKind.Utc).AddTicks(7838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 288, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.CreateIndex(
                name: "IX_Book_Genre Id",
                table: "Book",
                column: "Genre Id");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Status Id",
                table: "Book",
                column: "Status Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_Genre Id",
                table: "Book",
                column: "Genre Id",
                principalTable: "Genre",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Status_Status Id",
                table: "Book",
                column: "Status Id",
                principalTable: "Status",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_Genre Id",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Status_Status Id",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_Genre Id",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_Status Id",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(9680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 58, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 57, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 57, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 60, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 60, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 289, DateTimeKind.Utc).AddTicks(3224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 45, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 288, DateTimeKind.Utc).AddTicks(538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 59, 7, 44, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_Id",
                table: "Book",
                column: "Id",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Status_Id",
                table: "Book",
                column: "Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
