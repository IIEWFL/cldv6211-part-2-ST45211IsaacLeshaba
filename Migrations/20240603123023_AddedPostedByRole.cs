using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class AddedPostedByRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PostedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PostedByRole",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "327317bc-90b0-40c9-99ca-2454b9b6feed", null, "client", "client" },
            //        { "3d902c4b-6e8c-402c-b21c-9eb8453c145d", null, "seller", "seller" },
            //        { "4d690437-cc98-414c-9b61-45a3fcf11b4b", null, "admin", "admin" }
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "327317bc-90b0-40c9-99ca-2454b9b6feed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d902c4b-6e8c-402c-b21c-9eb8453c145d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d690437-cc98-414c-9b61-45a3fcf11b4b");

            migrationBuilder.DropColumn(
                name: "PostedByRole",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "PostedBy",
                table: "Products",
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
            //        { "2b4a769b-b794-4440-942b-816da148e6c8", null, "client", "client" },
            //        { "d0666c76-3227-4909-882b-77411fa63d66", null, "admin", "admin" },
            //        { "df5570cd-700a-437c-97c7-880ff55c0b6f", null, "seller", "seller" }
            //    });
        }
    }
}
