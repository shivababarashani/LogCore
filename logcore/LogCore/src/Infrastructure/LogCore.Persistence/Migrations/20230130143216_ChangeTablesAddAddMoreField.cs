using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogCore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTablesAddAddMoreField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "ActionLogs");

            migrationBuilder.RenameColumn(
                name: "Response",
                table: "StateLogs",
                newName: "TraceId");

            migrationBuilder.RenameColumn(
                name: "Request",
                table: "StateLogs",
                newName: "ResponseBody");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "StateLogs",
                newName: "ResponseTime");

            migrationBuilder.RenameColumn(
                name: "ServiceCode",
                table: "RequestLogs",
                newName: "ServerId");

            migrationBuilder.RenameColumn(
                name: "Response",
                table: "RequestLogs",
                newName: "UserAgent");

            migrationBuilder.RenameColumn(
                name: "Request",
                table: "RequestLogs",
                newName: "TraceId");

            migrationBuilder.RenameColumn(
                name: "ControllerName",
                table: "RequestLogs",
                newName: "Controller");

            migrationBuilder.RenameColumn(
                name: "ActionName",
                table: "RequestLogs",
                newName: "Action");

            migrationBuilder.RenameColumn(
                name: "ResponseCode",
                table: "ActionLogs",
                newName: "TransactionTypeId");

            migrationBuilder.RenameColumn(
                name: "Response",
                table: "ActionLogs",
                newName: "TraceId");

            migrationBuilder.RenameColumn(
                name: "Request",
                table: "ActionLogs",
                newName: "ResponseBody");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "ActionLogs",
                newName: "ResponseStatus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 13, 41, 14, 991, DateTimeKind.Local).AddTicks(9529));

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

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "RequestLogs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 13, 41, 14, 991, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.AddColumn<string>(
                name: "ClientIp",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExceptionMessage",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExceptionStackTrace",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Node",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestBody",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestContentType",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDateTime",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RequestHost",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestMethod",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestPath",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestQuery",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequestScheme",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResponseBody",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResponseContentType",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseDateTime",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ResponseStatus",
                table: "RequestLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResponseTime",
                table: "RequestLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ResponseTime",
                table: "ActionLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 13, 41, 14, 991, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.AddColumn<string>(
                name: "RequestBody",
                table: "ActionLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ProxyCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProxyCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProxyCompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionTypes_ProxyCompanies_ProxyCompanyId",
                        column: x => x.ProxyCompanyId,
                        principalTable: "ProxyCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_ProxyCompanyId",
                table: "TransactionTypes",
                column: "ProxyCompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "ProxyCompanies");

            migrationBuilder.DropColumn(
                name: "RequestBody",
                table: "StateLogs");

            migrationBuilder.DropColumn(
                name: "ResponseStatus",
                table: "StateLogs");

            migrationBuilder.DropColumn(
                name: "ClientIp",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ExceptionMessage",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ExceptionStackTrace",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "Node",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestBody",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestContentType",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestDateTime",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestHost",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestMethod",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestPath",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestQuery",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestScheme",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseBody",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseContentType",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseDateTime",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseStatus",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseTime",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "RequestBody",
                table: "ActionLogs");

            migrationBuilder.RenameColumn(
                name: "TraceId",
                table: "StateLogs",
                newName: "Response");

            migrationBuilder.RenameColumn(
                name: "ResponseTime",
                table: "StateLogs",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "ResponseBody",
                table: "StateLogs",
                newName: "Request");

            migrationBuilder.RenameColumn(
                name: "UserAgent",
                table: "RequestLogs",
                newName: "Response");

            migrationBuilder.RenameColumn(
                name: "TraceId",
                table: "RequestLogs",
                newName: "Request");

            migrationBuilder.RenameColumn(
                name: "ServerId",
                table: "RequestLogs",
                newName: "ServiceCode");

            migrationBuilder.RenameColumn(
                name: "Controller",
                table: "RequestLogs",
                newName: "ControllerName");

            migrationBuilder.RenameColumn(
                name: "Action",
                table: "RequestLogs",
                newName: "ActionName");

            migrationBuilder.RenameColumn(
                name: "TransactionTypeId",
                table: "ActionLogs",
                newName: "ResponseCode");

            migrationBuilder.RenameColumn(
                name: "TraceId",
                table: "ActionLogs",
                newName: "Response");

            migrationBuilder.RenameColumn(
                name: "ResponseStatus",
                table: "ActionLogs",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "ResponseBody",
                table: "ActionLogs",
                newName: "Request");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "StateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 13, 41, 14, 991, DateTimeKind.Local).AddTicks(9529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "RequestLogs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RequestLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 13, 41, 14, 991, DateTimeKind.Local).AddTicks(8979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.AlterColumn<string>(
                name: "ResponseTime",
                table: "ActionLogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActionLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 13, 41, 14, 991, DateTimeKind.Local).AddTicks(9341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 30, 6, 32, 16, 758, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "ActionLogs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
