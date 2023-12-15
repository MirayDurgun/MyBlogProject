using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class PortfolioandProjectUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ProjectId",
                table: "Portfolios",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Projects_ProjectId",
                table: "Portfolios",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Projects_ProjectId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ProjectId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Portfolios");
        }
    }
}
