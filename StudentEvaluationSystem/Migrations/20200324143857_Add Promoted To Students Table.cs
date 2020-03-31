using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEvaluationSystem.Migrations
{
    public partial class AddPromotedToStudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Graduated",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Graduated",
                table: "Students");
        }
    }
}
