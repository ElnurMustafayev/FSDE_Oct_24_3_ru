using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationsApp.Migrations
{
    /// <inheritdoc />
    public partial class Renametable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "MY_PRODUCTS");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PRODUCT_CODE",
                table: "MY_PRODUCTS",
                newName: "IX_MY_PRODUCTS_PRODUCT_CODE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MY_PRODUCTS",
                table: "MY_PRODUCTS",
                column: "ProductIdentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MY_PRODUCTS",
                table: "MY_PRODUCTS");

            migrationBuilder.RenameTable(
                name: "MY_PRODUCTS",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_MY_PRODUCTS_PRODUCT_CODE",
                table: "Users",
                newName: "IX_Users_PRODUCT_CODE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "ProductIdentifier");
        }
    }
}
