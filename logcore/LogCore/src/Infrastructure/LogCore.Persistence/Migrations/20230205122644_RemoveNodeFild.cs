using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNodeFild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Node",
                table: "RequestLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 614, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(6688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9972));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 614, DateTimeKind.Local).AddTicks(293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.AddColumn<string>(
                name: "Node",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 15, 0, 613, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7477));
        }
    }
}
