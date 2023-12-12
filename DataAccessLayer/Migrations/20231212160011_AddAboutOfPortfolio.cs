using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddAboutOfPortfolio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioId",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_PortfolioId",
                table: "Abouts",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Portfolios_PortfolioId",
                table: "Abouts",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "PortfolioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Portfolios_PortfolioId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_PortfolioId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Abouts");
        }
    }
}
