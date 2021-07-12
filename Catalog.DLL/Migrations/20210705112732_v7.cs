using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutBook",
                table: "Book",
                newName: "About Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 958, DateTimeKind.Utc).AddTicks(9082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 894, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 944, DateTimeKind.Utc).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 880, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 943, DateTimeKind.Utc).AddTicks(7095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 879, DateTimeKind.Utc).AddTicks(6754));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "About Book",
                table: "Book",
                newName: "AboutBook");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 894, DateTimeKind.Utc).AddTicks(8894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 958, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 957, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 880, DateTimeKind.Utc).AddTicks(8396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 944, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 879, DateTimeKind.Utc).AddTicks(6754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 27, 31, 943, DateTimeKind.Utc).AddTicks(7095));
        }
    }
}
