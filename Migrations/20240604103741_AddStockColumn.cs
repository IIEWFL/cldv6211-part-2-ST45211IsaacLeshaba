using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class AddStockColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e2a39dc-e70a-4d17-b684-5ed08f38e091");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b5fd966-8dd2-4f51-91e7-616dabe8bd4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93680900-463d-46bc-9740-f92d2195f3ba");

            migrationBuilder.AddColumn<string>(
                name: "Stock",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "14a6dc2a-ef6a-4543-8b1a-83d8a66ba7a8", null, "client", "client" },
            //        { "9713918a-be7e-485e-bbd2-8b9af9b736b9", null, "seller", "seller" },
            //        { "dc375231-c441-40e0-a73d-408fb49ec2b4", null, "admin", "admin" }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14a6dc2a-ef6a-4543-8b1a-83d8a66ba7a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9713918a-be7e-485e-bbd2-8b9af9b736b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc375231-c441-40e0-a73d-408fb49ec2b4");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "1e2a39dc-e70a-4d17-b684-5ed08f38e091", null, "admin", "admin" },
            //        { "5b5fd966-8dd2-4f51-91e7-616dabe8bd4b", null, "seller", "seller" },
            //        { "93680900-463d-46bc-9740-f92d2195f3ba", null, "client", "client" }
            //    });
        }
    }
}
