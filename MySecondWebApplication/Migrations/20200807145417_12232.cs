using Microsoft.EntityFrameworkCore.Migrations;

namespace MySecondWebApplication.Migrations
{
    public partial class _12232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "schools",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Saraswati vidya mandir" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
