using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProdAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryCatID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryCatID",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4b25db-a77d-45a1-8c25-008ab991a726");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "110471dc-03df-458e-83db-3ab476b3a96d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3e4cac1-023c-409b-b497-554826e3cd84");

            migrationBuilder.DropColumn(
                name: "CategoryCatID",
                table: "Products");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "5824842e-f120-40b2-9e7b-e56dfa1f7775", null, "admin", "admin" },
            //        { "785981b1-188b-4ac6-aa16-e6afd1b45eb8", null, "client", "client" },
            //        { "8a40be4c-a13b-4550-85ba-5d53bb671fcc", null, "seller", "seller" }
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatID",
                table: "Products",
                column: "CatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CatID",
                table: "Products",
                column: "CatID",
                principalTable: "Categories",
                principalColumn: "CatID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CatID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatID",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5824842e-f120-40b2-9e7b-e56dfa1f7775");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785981b1-188b-4ac6-aa16-e6afd1b45eb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a40be4c-a13b-4550-85ba-5d53bb671fcc");

            migrationBuilder.AddColumn<int>(
                name: "CategoryCatID",
                table: "Products",
                type: "int",
                nullable: true);

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "0c4b25db-a77d-45a1-8c25-008ab991a726", null, "admin", "admin" },
            //        { "110471dc-03df-458e-83db-3ab476b3a96d", null, "client", "client" },
            //        { "b3e4cac1-023c-409b-b497-554826e3cd84", null, "seller", "seller" }
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryCatID",
                table: "Products",
                column: "CategoryCatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryCatID",
                table: "Products",
                column: "CategoryCatID",
                principalTable: "Categories",
                principalColumn: "CatID");
        }
    }
}
