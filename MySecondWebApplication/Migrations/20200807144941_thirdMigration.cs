using Microsoft.EntityFrameworkCore.Migrations;

namespace MySecondWebApplication.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_schools_StudentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_StudentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "schools");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "schools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentId",
                table: "students",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_StudentId",
                table: "students",
                column: "StudentId",
                principalTable: "schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
