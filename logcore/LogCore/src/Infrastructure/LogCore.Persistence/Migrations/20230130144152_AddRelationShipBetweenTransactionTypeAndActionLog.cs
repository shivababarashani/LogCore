using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationShipBetweenTransactionTypeAndActionLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(32),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_TransactionTypeId",
                table: "ActionLogs",
                column: "TransactionTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionLogs_TransactionTypes_TransactionTypeId",
                table: "ActionLogs",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionLogs_TransactionTypes_TransactionTypeId",
                table: "ActionLogs");

            migrationBuilder.DropIndex(
                name: "IX_ActionLogs_TransactionTypeId",
                table: "ActionLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 41, 52, 611, DateTimeKind.Local).AddTicks(394));
        }
    }
}
