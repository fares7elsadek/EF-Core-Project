using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore07.Migrations
{
    /// <inheritdoc />
    public partial class TpC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "multipleChoiceQuizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    OptionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multipleChoiceQuizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_multipleChoiceQuizzes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trueAndFalseQuizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trueAndFalseQuizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trueAndFalseQuizzes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_multipleChoiceQuizzes_CourseId",
                table: "multipleChoiceQuizzes",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_trueAndFalseQuizzes_CourseId",
                table: "trueAndFalseQuizzes",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "multipleChoiceQuizzes");

            migrationBuilder.DropTable(
                name: "trueAndFalseQuizzes");
        }
    }
}
