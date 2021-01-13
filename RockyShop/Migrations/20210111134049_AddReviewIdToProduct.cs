using Microsoft.EntityFrameworkCore.Migrations;

namespace RockyShop.Migrations
{
    public partial class AddReviewIdToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ReviewId",
                table: "Product",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Reviews_ReviewId",
                table: "Product",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Reviews_ReviewId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ReviewId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Product");
        }
    }
}
