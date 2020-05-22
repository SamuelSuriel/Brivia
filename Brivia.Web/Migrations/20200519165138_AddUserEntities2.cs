using Microsoft.EntityFrameworkCore.Migrations;

namespace Brivia.Web.Migrations
{
    public partial class AddUserEntities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCategory",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "Question",
                table: "Questions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Questions",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_Question",
                table: "Questions",
                newName: "IX_Questions_Description");

            migrationBuilder.AlterColumn<string>(
                name: "Answer4",
                table: "Questions",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Answer3",
                table: "Questions",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Answer2",
                table: "Questions",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Answer1",
                table: "Questions",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Questions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                table: "Questions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AspNetUsers_UserId",
                table: "Questions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AspNetUsers_UserId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_UserId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Questions",
                newName: "Question");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Questions",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_Description",
                table: "Questions",
                newName: "IX_Questions_Question");

            migrationBuilder.AlterColumn<string>(
                name: "Answer4",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Answer3",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Answer2",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Answer1",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "IdCategory",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }
    }
}
