using Microsoft.EntityFrameworkCore.Migrations;

namespace MySecondWebApplication.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_schools_SchoolId",
                table: "students");

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentId",
                table: "students",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_SchoolId",
                table: "students",
                column: "SchoolId",
                principalTable: "schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_StudentId",
                table: "students",
                column: "StudentId",
                principalTable: "schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_schools_SchoolId",
                table: "students");

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

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "schools",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Maharishi Vidya Mandir" });

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_SchoolId",
                table: "students",
                column: "SchoolId",
                principalTable: "schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
