using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector_Proj.Migrations
{
    public partial class AddedBoolTrashPickedUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf21d21c-0d21-43d3-bd66-3d133851d033");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb179013-ee87-4355-92ed-e48007f2e52d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7ff2ec2-4ea7-4f34-ad6b-9e9b0434236a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "TrashPickedUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TrashPickedUp",
                table: "Customers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb179013-ee87-4355-92ed-e48007f2e52d", "d379744d-8797-4719-a9a8-3990c77ac90e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf21d21c-0d21-43d3-bd66-3d133851d033", "08d940dc-b987-4b37-9514-d53dd23b88a3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7ff2ec2-4ea7-4f34-ad6b-9e9b0434236a", "3cfde703-8d7a-4b55-ba31-3572db538d56", "Employee", "EMPLOYEE" });
        }
    }
}
