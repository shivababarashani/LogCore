using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateLogs_LogType_LogTypeId",
                table: "StateLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogType",
                table: "LogType");

            migrationBuilder.RenameTable(
                name: "LogType",
                newName: "LogTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 614, DateTimeKind.Local).AddTicks(293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.AddColumn<int>(
                name: "ApplicationTypeId",
                table: "RequestLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogTypes",
                table: "LogTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ApplicationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestLogs_ApplicationTypeId",
                table: "RequestLogs",
                column: "ApplicationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLogs_ApplicationTypes_ApplicationTypeId",
                table: "RequestLogs",
                column: "ApplicationTypeId",
                principalTable: "ApplicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StateLogs_LogTypes_LogTypeId",
                table: "StateLogs",
                column: "LogTypeId",
                principalTable: "LogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLogs_ApplicationTypes_ApplicationTypeId",
                table: "RequestLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_StateLogs_LogTypes_LogTypeId",
                table: "StateLogs");

            migrationBuilder.DropTable(
                name: "ApplicationTypes");

            migrationBuilder.DropIndex(
                name: "IX_RequestLogs_ApplicationTypeId",
                table: "RequestLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogTypes",
                table: "LogTypes");

            migrationBuilder.DropColumn(
                name: "ApplicationTypeId",
                table: "RequestLogs");

            migrationBuilder.RenameTable(
                name: "LogTypes",
                newName: "LogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 614, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 1, 1, 22, 32, 910, DateTimeKind.Local).AddTicks(1331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogType",
                table: "LogType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StateLogs_LogType_LogTypeId",
                table: "StateLogs",
                column: "LogTypeId",
                principalTable: "LogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
