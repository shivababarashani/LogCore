using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddLogTypeTableAndGenerateRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(2103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.AddColumn<int>(
                name: "LogTypeId",
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
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.CreateTable(
                name: "LogType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateLogs_LogTypeId",
                table: "StateLogs",
                column: "LogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StateLogs_LogType_LogTypeId",
                table: "StateLogs",
                column: "LogTypeId",
                principalTable: "LogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateLogs_LogType_LogTypeId",
                table: "StateLogs");

            migrationBuilder.DropTable(
                name: "LogType");

            migrationBuilder.DropIndex(
                name: "IX_StateLogs_LogTypeId",
                table: "StateLogs");

            migrationBuilder.DropColumn(
                name: "LogTypeId",
                table: "StateLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(32),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 31, 21, 42, 23, 904, DateTimeKind.Local).AddTicks(1763));
        }
    }
}
