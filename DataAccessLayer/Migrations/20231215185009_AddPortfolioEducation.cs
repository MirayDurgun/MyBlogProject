using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddPortfolioEducation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PortfolioTitle",
                table: "Portfolios",
                newName: "EducationTitle");

            migrationBuilder.AddColumn<string>(
                name: "EducationDescription",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EducationEndDate",
                table: "Portfolios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationName",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EducationStartDate",
                table: "Portfolios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationDescription",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "EducationEndDate",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "EducationName",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "EducationStartDate",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "EducationTitle",
                table: "Portfolios",
                newName: "PortfolioTitle");
        }
    }
}
