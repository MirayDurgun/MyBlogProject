using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addmigdeleteparentcomment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentComments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentComments",
                columns: table => new
                {
                    ParentCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    ParentCommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentCommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentComments", x => x.ParentCommentId);
                });
        }
    }
}
