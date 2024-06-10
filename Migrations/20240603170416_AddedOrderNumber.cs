using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59368345-a722-4289-90bb-bab3083464d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8121b21c-b725-4a76-a2c8-31a6926d52df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc1d721b-e858-41fa-bc10-8a550e5cac2f");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "85a8dcdb-8bc1-4042-8967-774d94a75b63", null, "admin", "admin" },
            //        { "d153325d-3be4-4d79-821d-c3e10f5813bb", null, "client", "client" },
            //        { "f4594d50-c456-4c0a-8709-3430b919e50b", null, "seller", "seller" }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85a8dcdb-8bc1-4042-8967-774d94a75b63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d153325d-3be4-4d79-821d-c3e10f5813bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4594d50-c456-4c0a-8709-3430b919e50b");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Orders");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "59368345-a722-4289-90bb-bab3083464d3", null, "client", "client" },
            //        { "8121b21c-b725-4a76-a2c8-31a6926d52df", null, "seller", "seller" },
            //        { "cc1d721b-e858-41fa-bc10-8a550e5cac2f", null, "admin", "admin" }
            //    });
        }
    }
}
