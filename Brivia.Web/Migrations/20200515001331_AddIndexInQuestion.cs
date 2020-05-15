using Microsoft.EntityFrameworkCore.Migrations;

namespace Brivia.Web.Migrations
{
    public partial class AddIndexInQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Question",
                table: "Questions",
                column: "Question",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Questions_Question",
                table: "Questions");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
