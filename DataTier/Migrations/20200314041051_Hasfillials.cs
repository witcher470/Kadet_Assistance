using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataTier.Migrations
{
    public partial class Hasfillials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DealerCenters_HasFillials_HasFillialId",
                table: "DealerCenters");

            migrationBuilder.DropTable(
                name: "HasFillials");

            migrationBuilder.DropIndex(
                name: "IX_DealerCenters_HasFillialId",
                table: "DealerCenters");

            migrationBuilder.DropColumn(
                name: "HasFillialId",
                table: "DealerCenters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HasFillialId",
                table: "DealerCenters",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HasFillials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasFillials", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_HasFillialId",
                table: "DealerCenters",
                column: "HasFillialId");

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_HasFillials_HasFillialId",
                table: "DealerCenters",
                column: "HasFillialId",
                principalTable: "HasFillials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
