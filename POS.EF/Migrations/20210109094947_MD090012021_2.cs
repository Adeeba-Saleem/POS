using Microsoft.EntityFrameworkCore.Migrations;

namespace POS.EF.Migrations
{
    public partial class MD090012021_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductsProductId",
                table: "ExpiryDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpiryDetails_ProductsProductId",
                table: "ExpiryDetails",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpiryDetails_ProductDetailTables_ProductsProductId",
                table: "ExpiryDetails",
                column: "ProductsProductId",
                principalTable: "ProductDetailTables",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpiryDetails_ProductDetailTables_ProductsProductId",
                table: "ExpiryDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpiryDetails_ProductsProductId",
                table: "ExpiryDetails");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "ExpiryDetails");
        }
    }
}
