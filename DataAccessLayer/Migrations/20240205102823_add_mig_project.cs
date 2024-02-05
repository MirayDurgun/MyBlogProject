using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_mig_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image10",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image11",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image12",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image13",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image14",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image15",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image16",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image17",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image18",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image19",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image20",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image5",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image6",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image7",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image8",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image9",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescription2",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image10",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image11",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image12",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image13",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image14",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image15",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image16",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image17",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image18",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image19",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image20",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image5",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image6",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image7",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image8",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Image9",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectDescription2",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
