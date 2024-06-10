using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3485ce3d-b357-4412-925d-2c147b290686", null, "admin", "admin" },
                    { "8971a79e-cdeb-4f0e-91ef-0d11f6b3ceda", null, "seller", "seller" },
                    { "b0d23b58-1bf2-49da-ad9c-65f7c95028eb", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3485ce3d-b357-4412-925d-2c147b290686");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8971a79e-cdeb-4f0e-91ef-0d11f6b3ceda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0d23b58-1bf2-49da-ad9c-65f7c95028eb");
        }
    }
}
