using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book_id",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Author id",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "Book id",
                table: "Genre");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 682, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 37, DateTimeKind.Utc).AddTicks(2139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 682, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 681, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 681, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(3189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 680, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Book",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(2914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 680, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 22, DateTimeKind.Utc).AddTicks(7181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 668, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 21, DateTimeKind.Utc).AddTicks(4852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 666, DateTimeKind.Utc).AddTicks(9174));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 682, DateTimeKind.Utc).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 682, DateTimeKind.Utc).AddTicks(8018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 37, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.AddColumn<long>(
                name: "Book_id",
                table: "Status",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 681, DateTimeKind.Utc).AddTicks(6949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 681, DateTimeKind.Utc).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.AddColumn<long>(
                name: "Author id",
                table: "Genre",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Book id",
                table: "Genre",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "Name",
                table: "Book",
                type: "bigint",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 680, DateTimeKind.Utc).AddTicks(7555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.AlterColumn<long>(
                name: "Description",
                table: "Book",
                type: "bigint",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 680, DateTimeKind.Utc).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 668, DateTimeKind.Utc).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 22, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 13, 32, 666, DateTimeKind.Utc).AddTicks(9174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 21, DateTimeKind.Utc).AddTicks(4852));
        }
    }
}
