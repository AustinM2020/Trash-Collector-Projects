using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector_Proj.Migrations
{
    public partial class AddWeekdaysTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09af7c8c-1fdb-4c94-b64f-95a00b7e0b92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "970c38c1-99e7-4239-9b44-30bfa8607c8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4fe2a1a-5b41-401e-8224-775bca2c409e");

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeekDays");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "970c38c1-99e7-4239-9b44-30bfa8607c8c", "a71a8de6-91bb-4b1b-8289-a88c6612531e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09af7c8c-1fdb-4c94-b64f-95a00b7e0b92", "5cca8e35-39c2-4113-9209-c664559c9e16", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4fe2a1a-5b41-401e-8224-775bca2c409e", "f76b043c-6065-4d27-92b6-dddb7a10ab78", "Employee", "EMPLOYEE" });
        }
    }
}
