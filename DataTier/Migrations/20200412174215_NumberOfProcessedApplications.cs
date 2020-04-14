using Microsoft.EntityFrameworkCore.Migrations;


namespace DataTier.Migrations
{
    public partial class NumberOfProcessedApplications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "NumberOfProcessedApplications",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfProcessedApplications",
                table: "Users");

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
    }
}
