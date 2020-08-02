using Microsoft.EntityFrameworkCore.Migrations;

namespace MySecondWebApplication.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_SchoolId",
                table: "students",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_SchoolId",
                table: "students",
                column: "SchoolId",
                principalTable: "schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_schools_SchoolId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_SchoolId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "students");

            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
