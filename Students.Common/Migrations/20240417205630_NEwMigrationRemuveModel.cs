using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students.Common.Migrations
{
    /// <inheritdoc />
    public partial class NEwMigrationRemuveModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearchAreaStudent");

            migrationBuilder.DropTable(
                name: "ResearchWorker");

            migrationBuilder.DropTable(
                name: "ResearchArea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResearchArea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchWorker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchWorker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchAreaStudent",
                columns: table => new
                {
                    ResearchAreaId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchAreaStudent", x => new { x.ResearchAreaId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_ResearchAreaStudent_ResearchArea_ResearchAreaId",
                        column: x => x.ResearchAreaId,
                        principalTable: "ResearchArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearchAreaStudent_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResearchAreaStudent_StudentId",
                table: "ResearchAreaStudent",
                column: "StudentId");
        }
    }
}
