using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderNumberToNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
