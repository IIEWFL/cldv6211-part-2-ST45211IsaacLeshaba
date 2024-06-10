using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStockToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Stock",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
