using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPriceToDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f04ce35-85ed-48eb-bb99-4943481c763a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0396989-a0a9-4b26-9f8f-e3ddbf8b8e8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e12b0783-f6db-4e51-8fbf-b048564edb9c");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "231dba41-2730-4f46-bf58-934146b681e4", null, "seller", "seller" },
            //        { "8627b277-1867-4a3b-b0f5-39df0cb42d21", null, "admin", "admin" },
            //        { "c13807a3-d388-4777-8733-157f7cce6b65", null, "client", "client" }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "231dba41-2730-4f46-bf58-934146b681e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8627b277-1867-4a3b-b0f5-39df0cb42d21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c13807a3-d388-4777-8733-157f7cce6b65");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "2f04ce35-85ed-48eb-bb99-4943481c763a", null, "client", "client" },
            //        { "b0396989-a0a9-4b26-9f8f-e3ddbf8b8e8c", null, "seller", "seller" },
            //        { "e12b0783-f6db-4e51-8fbf-b048564edb9c", null, "admin", "admin" }
            //    });
        }
    }
}
