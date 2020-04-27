using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector_Proj.Migrations
{
    public partial class AddedDaysOFWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00719e60-e595-4a49-8627-1d181b06f171");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2552a0c3-da2f-4ba3-9259-2b8fb98a6811");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f02511f-22fa-42eb-81ae-e9ea916e3a2a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a3b02e3a-4699-48f1-a435-b8dbbc987142", "567da1a3-34c6-4957-b12e-37de69128361", "Admin", "ADMIN" },
                    { "e7b6b725-5036-4777-9f87-5691157e1789", "61c863da-33b3-4e76-ac2b-585f129034a7", "Customer", "CUSTOMER" },
                    { "036d5f1b-7a3e-4391-a2ec-7f298f805fcd", "50f2c145-baa8-4082-9e8b-30edb6989478", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "WeekDays",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sunday" },
                    { 2, "Monday" },
                    { 3, "Tuesday" },
                    { 4, "Wednesday" },
                    { 5, "Thursday" },
                    { 6, "Friday" },
                    { 7, "Saturday" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "036d5f1b-7a3e-4391-a2ec-7f298f805fcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3b02e3a-4699-48f1-a435-b8dbbc987142");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b6b725-5036-4777-9f87-5691157e1789");

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2552a0c3-da2f-4ba3-9259-2b8fb98a6811", "fb34bfa5-ffa9-4655-81a7-9fe1a5b470b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f02511f-22fa-42eb-81ae-e9ea916e3a2a", "cd91105b-bd02-4d11-a3ae-cda6c08464ad", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00719e60-e595-4a49-8627-1d181b06f171", "294c6b5e-917c-45c0-ab01-b65640d729b7", "Employee", "EMPLOYEE" });
        }
    }
}
