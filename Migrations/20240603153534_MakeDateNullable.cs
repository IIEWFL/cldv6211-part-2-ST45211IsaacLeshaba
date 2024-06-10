using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class MakeDateNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b97d19e-cf83-4633-a8fc-c59e2e51cdcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "884195b8-05ed-4fd7-9f23-236f5395752a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7e29892-77e7-48bf-8600-d76e79e61e97");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "2b97d19e-cf83-4633-a8fc-c59e2e51cdcd", null, "admin", "admin" },
            //        { "884195b8-05ed-4fd7-9f23-236f5395752a", null, "client", "client" },
            //        { "d7e29892-77e7-48bf-8600-d76e79e61e97", null, "seller", "seller" }
            //    });
        }
    }
}
