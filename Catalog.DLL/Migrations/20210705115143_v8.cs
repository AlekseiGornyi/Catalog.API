using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_Id",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(9680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 958, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 289, DateTimeKind.Utc).AddTicks(3224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 944, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 288, DateTimeKind.Utc).AddTicks(538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 943, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.CreateIndex(
                name: "IX_Book_Author Id",
                table: "Book",
                column: "Author Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_Author Id",
                table: "Book",
                column: "Author Id",
                principalTable: "Author",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_Author Id",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_Author Id",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 958, DateTimeKind.Utc).AddTicks(9082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 305, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 302, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 944, DateTimeKind.Utc).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 289, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 943, DateTimeKind.Utc).AddTicks(7095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 51, 43, 288, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_Id",
                table: "Book",
                column: "Id",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
