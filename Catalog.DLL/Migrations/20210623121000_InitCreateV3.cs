using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class InitCreateV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description Id",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 143, DateTimeKind.Utc).AddTicks(7681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 143, DateTimeKind.Utc).AddTicks(7427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 142, DateTimeKind.Utc).AddTicks(6787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 142, DateTimeKind.Utc).AddTicks(6542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 141, DateTimeKind.Utc).AddTicks(7664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 141, DateTimeKind.Utc).AddTicks(7385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 129, DateTimeKind.Utc).AddTicks(5533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 378, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 128, DateTimeKind.Utc).AddTicks(3649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 377, DateTimeKind.Utc).AddTicks(1563));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 143, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 393, DateTimeKind.Utc).AddTicks(4327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 143, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 142, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 392, DateTimeKind.Utc).AddTicks(2531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 142, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 141, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 391, DateTimeKind.Utc).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 141, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.AddColumn<long>(
                name: "Description Id",
                table: "Book",
                type: "bigint",
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
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 129, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 12, 6, 9, 377, DateTimeKind.Utc).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 23, 12, 10, 0, 128, DateTimeKind.Utc).AddTicks(3649));
        }
    }
}
