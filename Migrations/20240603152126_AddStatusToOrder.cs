using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12609bb9-32f4-4e5b-8009-742a95b26a31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddda9ab4-4923-46b5-871b-1a8e47dea72a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7befaf5-03fc-43a4-aaef-b4956d834415");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "12609bb9-32f4-4e5b-8009-742a95b26a31", null, "admin", "admin" },
            //        { "ddda9ab4-4923-46b5-871b-1a8e47dea72a", null, "seller", "seller" },
            //        { "f7befaf5-03fc-43a4-aaef-b4956d834415", null, "client", "client" }
            //    });
        }
    }
}
