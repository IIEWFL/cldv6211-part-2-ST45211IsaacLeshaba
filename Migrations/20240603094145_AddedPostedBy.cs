using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class AddedPostedBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "PostedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "2b4a769b-b794-4440-942b-816da148e6c8", null, "client", "client" },
            //        { "d0666c76-3227-4909-882b-77411fa63d66", null, "admin", "admin" },
            //        { "df5570cd-700a-437c-97c7-880ff55c0b6f", null, "seller", "seller" }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b4a769b-b794-4440-942b-816da148e6c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0666c76-3227-4909-882b-77411fa63d66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df5570cd-700a-437c-97c7-880ff55c0b6f");

            migrationBuilder.DropColumn(
                name: "PostedBy",
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
        }
    }
}
