using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector_Proj.Migrations
{
    public partial class ChangedCustomerProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c8111d-790d-4f93-9588-aac1e3be09da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b64c1e8-a84a-4610-8b33-a66484ee9b42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3a2679e-f018-480c-84b0-9ec29efbb881");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DayId",
                table: "Customers",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_WeekDays_DayId",
                table: "Customers",
                column: "DayId",
                principalTable: "WeekDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_WeekDays_DayId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DayId",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "PickUpDay",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77c8111d-790d-4f93-9588-aac1e3be09da", "c5c5e46f-f2d3-4df0-b031-90dbbd44ef53", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3a2679e-f018-480c-84b0-9ec29efbb881", "8f6463c5-1e03-4998-b1ab-f6a2b0bdffff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b64c1e8-a84a-4610-8b33-a66484ee9b42", "8cc7ed8e-26a2-4cdd-8c24-f8c5f105b190", "Employee", "EMPLOYEE" });
        }
    }
}
