using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRequestContentTypeFildFromRequestLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestBody",
                table: "StateLogs");

            migrationBuilder.DropColumn(
                name: "ResponseStatus",
                table: "StateLogs");

            migrationBuilder.DropColumn(
                name: "ResponseTime",
                table: "StateLogs");

            migrationBuilder.DropColumn(
                name: "RequestContentType",
                table: "RequestLogs");

            migrationBuilder.RenameColumn(
                name: "ResponseBody",
                table: "StateLogs",
                newName: "Body");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1763));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Body",
                table: "StateLogs",
                newName: "ResponseBody");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(2103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.AddColumn<string>(
                name: "RequestBody",
                table: "StateLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ResponseStatus",
                table: "StateLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResponseTime",
                table: "StateLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.AddColumn<string>(
                name: "RequestContentType",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1331));
        }
    }
}
