using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTier.Migrations
{
    public partial class key_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Orders_OrderId",
                table: "Contractors");

            migrationBuilder.DropIndex(
                name: "IX_Contractors_OrderId",
                table: "Contractors");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Contractors");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Countries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_UserId",
                table: "Countries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Users_UserId",
                table: "Countries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Users_UserId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_UserId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Countries");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Contractors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_OrderId",
                table: "Contractors",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_Orders_OrderId",
                table: "Contractors",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
