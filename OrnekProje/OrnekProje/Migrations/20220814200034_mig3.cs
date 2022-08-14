using Microsoft.EntityFrameworkCore.Migrations;

namespace OrnekProje.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderHeaders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ProductId",
                table: "OrderHeaders",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_Products_ProductId",
                table: "OrderHeaders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_Products_ProductId",
                table: "OrderHeaders");

            migrationBuilder.DropIndex(
                name: "IX_OrderHeaders_ProductId",
                table: "OrderHeaders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderHeaders");
        }
    }
}
