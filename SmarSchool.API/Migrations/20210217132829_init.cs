using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjects_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentsSubjects",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentsSubjects", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_studentsSubjects_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentsSubjects_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 1, "Kent", "Marta", "33225555" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 2, "Isabela", "Paula", "3354288" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 3, "Antonia", "Laura", "55668899" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 4, "Maria", "Luiza", "6565659" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 5, "Machado", "Lucas", "565685415" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 6, "Alvares", "Pedro", "456454545" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "LastName", "Name", "Phone" },
                values: new object[] { 7, "José", "Paulo", "9874512" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Lauro" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ronaldo" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Rodrigo" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Alexandre" });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "Matemática", 1 });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Física", 2 });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Português", 3 });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 4, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 5, "Programação", 5 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "studentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_studentsSubjects_SubjectId",
                table: "studentsSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_TeacherId",
                table: "subjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentsSubjects");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "teachers");
        }
    }
}
