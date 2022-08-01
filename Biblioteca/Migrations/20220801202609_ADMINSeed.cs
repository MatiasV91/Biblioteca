using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    public partial class ADMINSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21361211-21eb-45c7-8e79-4855d4663438", 0, "1928c4d2-9dae-4609-87e0-c02a46b30c77", "admin@library.com", false, false, null, "ADMIN@LIBRARY.COM", "ADMIN@LIBRARY.COM", "AQAAAAEAACcQAAAAEKhO2ZS4jkKO7KEgQkiqIrr0ieGGe/bJyR5yfYSme2tTfFIkdvCxosaA9LyMAIiKYQ==", null, false, "8c657b09-4ad0-4df3-a4aa-760f91956c13", false, "admin@library.com" });

            migrationBuilder.UpdateData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookId",
                value: 14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21361211-21eb-45c7-8e79-4855d4663438");

            migrationBuilder.UpdateData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookId",
                value: 1);
        }
    }
}
