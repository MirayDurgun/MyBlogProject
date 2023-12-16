using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Certificates_CertificateId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Educations_EducationId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Jobs_JobId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Projects_ProjectId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Skills_SkillId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Testimonials_TestimonialId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_CertificateId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_EducationId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_JobId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ProjectId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_SkillId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_TestimonialId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "CertificateId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "TestimonialId",
                table: "Portfolios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CertificateId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestimonialId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CertificateId",
                table: "Portfolios",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_EducationId",
                table: "Portfolios",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_JobId",
                table: "Portfolios",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ProjectId",
                table: "Portfolios",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_SkillId",
                table: "Portfolios",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_TestimonialId",
                table: "Portfolios",
                column: "TestimonialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Certificates_CertificateId",
                table: "Portfolios",
                column: "CertificateId",
                principalTable: "Certificates",
                principalColumn: "CertificateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Educations_EducationId",
                table: "Portfolios",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Jobs_JobId",
                table: "Portfolios",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Projects_ProjectId",
                table: "Portfolios",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Skills_SkillId",
                table: "Portfolios",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Testimonials_TestimonialId",
                table: "Portfolios",
                column: "TestimonialId",
                principalTable: "Testimonials",
                principalColumn: "TestimonialId");
        }
    }
}
