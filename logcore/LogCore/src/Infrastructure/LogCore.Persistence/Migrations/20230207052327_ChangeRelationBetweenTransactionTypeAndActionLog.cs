using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelationBetweenTransactionTypeAndActionLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ActionLogs_TransactionTypeId",
                table: "ActionLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 21, 23, 27, 166, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 21, 23, 27, 166, DateTimeKind.Local).AddTicks(1666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 6, 21, 23, 27, 166, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_TransactionTypeId",
                table: "ActionLogs",
                column: "TransactionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ActionLogs_TransactionTypeId",
                table: "ActionLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 6, 21, 23, 27, 166, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(6688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 6, 21, 23, 27, 166, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 5, 4, 26, 44, 190, DateTimeKind.Local).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 6, 21, 23, 27, 166, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_TransactionTypeId",
                table: "ActionLogs",
                column: "TransactionTypeId",
                unique: true);
        }
    }
}
