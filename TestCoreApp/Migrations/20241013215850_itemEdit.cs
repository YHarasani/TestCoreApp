using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class itemEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9991fe-c0ef-4d2d-8b93-f67e6f0a745e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a898cbe1-4f13-47b4-a56d-6be731dd1491");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c711861-5013-4ec3-826c-fb760d6f71fd", "3a4a07ee-c3c1-4858-a99b-f17b80943e6c", "User", "user" },
                    { "953be297-b509-4673-8d49-8a464fda063b", "c667a067-ba99-4348-9e87-44a313ebd919", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c711861-5013-4ec3-826c-fb760d6f71fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "953be297-b509-4673-8d49-8a464fda063b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e9991fe-c0ef-4d2d-8b93-f67e6f0a745e", "b69cf073-32e2-47fb-b69b-9947c5189c18", "Admin", "admin" },
                    { "a898cbe1-4f13-47b4-a56d-6be731dd1491", "651336a4-8cbf-4a92-ab04-c7f5e85bc166", "User", "user" }
                });
        }
    }
}
