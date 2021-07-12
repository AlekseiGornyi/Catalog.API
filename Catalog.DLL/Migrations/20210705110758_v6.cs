﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DAL.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
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
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 37, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 880, DateTimeKind.Utc).AddTicks(8396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 22, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 879, DateTimeKind.Utc).AddTicks(6754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 21, DateTimeKind.Utc).AddTicks(4852));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutBook",
                table: "Book",
                newName: "Description");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 37, DateTimeKind.Utc).AddTicks(2139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 894, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 36, DateTimeKind.Utc).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(3189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 35, DateTimeKind.Utc).AddTicks(2914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 893, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 22, DateTimeKind.Utc).AddTicks(7181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 880, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation Date",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 10, 15, 23, 21, DateTimeKind.Utc).AddTicks(4852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 5, 11, 7, 57, 879, DateTimeKind.Utc).AddTicks(6754));
        }
    }
}
