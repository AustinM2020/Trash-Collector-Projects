using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector_Proj.Migrations
{
    public partial class AddedTimePickedUpVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292d2224-f367-4ff1-9756-4f4baa4a59a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30583e9d-ca4a-4774-9d18-1872647b1621");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c97f1c51-73b3-4160-bfce-307af10ea4a6");

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpTIme",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ec4ee87-0475-4257-a4ca-dbcb7673cdee", "e631017a-fc93-4cd0-a2b6-6e960e81529e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0360c317-d91b-4791-9a65-65d8a1720baf", "1a0281e9-de61-4739-88a8-b6185367e4bf", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8d23f19-d54b-43fb-afed-68af9ac9172d", "5f97d9ef-bf3b-4803-b5a3-bd8fdf9a300a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0360c317-d91b-4791-9a65-65d8a1720baf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ec4ee87-0475-4257-a4ca-dbcb7673cdee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8d23f19-d54b-43fb-afed-68af9ac9172d");

            migrationBuilder.DropColumn(
                name: "PickUpTIme",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c97f1c51-73b3-4160-bfce-307af10ea4a6", "c05b0221-6d75-4f13-8300-c85a9bb1292c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "292d2224-f367-4ff1-9756-4f4baa4a59a3", "f1ab8d8e-a7ab-4df7-a36b-7e232ab37a59", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30583e9d-ca4a-4774-9d18-1872647b1621", "417f1163-ac62-48f0-a5c8-f132f45e6aed", "Employee", "EMPLOYEE" });
        }
    }
}
