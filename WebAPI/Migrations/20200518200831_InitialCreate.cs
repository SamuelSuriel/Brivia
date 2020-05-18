using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUser1 = table.Column<int>(nullable: false),
                    IdUser2 = table.Column<int>(nullable: false),
                    Turn = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Round = table.Column<int>(nullable: false),
                    CorrectAnwer1 = table.Column<int>(nullable: false),
                    Person1 = table.Column<int>(nullable: false),
                    CorrectAnwer2 = table.Column<int>(nullable: false),
                    Person2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    GamesWon = table.Column<int>(nullable: false),
                    MissedGames = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdGameId = table.Column<int>(nullable: true),
                    IdUserId = table.Column<int>(nullable: true),
                    IdCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameDetails_Categories_IdCategoryId",
                        column: x => x.IdCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameDetails_Games_IdGameId",
                        column: x => x.IdGameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameDetails_Users_IdUserId",
                        column: x => x.IdUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    IdCategoryId = table.Column<int>(nullable: true),
                    IncorrectAnswer1 = table.Column<string>(nullable: false),
                    IncorrectAnswer2 = table.Column<string>(nullable: false),
                    IncorrectAnswer3 = table.Column<string>(nullable: false),
                    IncorrectAnswer4 = table.Column<string>(nullable: false),
                    CorrectAnswer = table.Column<int>(nullable: false),
                    IdUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_IdCategoryId",
                        column: x => x.IdCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Users_IdUserId",
                        column: x => x.IdUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUserId = table.Column<int>(nullable: true),
                    IdCategoryId = table.Column<int>(nullable: true),
                    CorrectAnswer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Categories_IdCategoryId",
                        column: x => x.IdCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Records_Users_IdUserId",
                        column: x => x.IdUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameDetails_IdCategoryId",
                table: "GameDetails",
                column: "IdCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GameDetails_IdGameId",
                table: "GameDetails",
                column: "IdGameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameDetails_IdUserId",
                table: "GameDetails",
                column: "IdUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IdCategoryId",
                table: "Questions",
                column: "IdCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IdUserId",
                table: "Questions",
                column: "IdUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_IdCategoryId",
                table: "Records",
                column: "IdCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_IdUserId",
                table: "Records",
                column: "IdUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameDetails");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
