using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmithSwimmingSchoolApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    CoachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.CoachId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Swimmers",
                columns: table => new
                {
                    SwimmerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swimmers", x => x.SwimmerId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    Places = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "CoachId");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SwimmerId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId");
                    table.ForeignKey(
                        name: "FK_Enrollments_Swimmers_SwimmerId",
                        column: x => x.SwimmerId,
                        principalTable: "Swimmers",
                        principalColumn: "SwimmerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "EnrollmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "CoachId", "Email", "Name", "Phone_Number" },
                values: new object[,]
                {
                    { 1, "jose.garcia@ejemplo.com", "José García", "1234567890" },
                    { 2, "maria.perez@ejemplo.com", "María Pérez", "9876543210" },
                    { 3, "carlos.sanchez@ejemplo.com", "Carlos Sánchez", "2223334444" },
                    { 4, "laura.martinez@ejemplo.com", "Laura Martínez", "5556667777" },
                    { 5, "miguel.hernandez@ejemplo.com", "Miguel Hernández", "8889990000" },
                    { 6, "sofia.lopez@ejemplo.com", "Sofía López", "1112223333" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "End_Date", "Level", "Name", "Start_Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 8, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1176), 1, "Braza Mañana", new DateTime(2024, 12, 9, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1132) },
                    { 2, new DateTime(2025, 1, 13, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1180), 2, "Braza Tarde", new DateTime(2024, 12, 14, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1178) },
                    { 3, new DateTime(2025, 1, 10, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1183), 1, "Flotación y Propulsión Mañana", new DateTime(2024, 12, 11, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1182) },
                    { 4, new DateTime(2025, 1, 16, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1187), 3, "Flotación y Propulsión Tarde", new DateTime(2024, 12, 17, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1185) },
                    { 5, new DateTime(2025, 1, 18, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1190), 1, "Mariposa Mañana", new DateTime(2024, 12, 19, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1189) },
                    { 6, new DateTime(2025, 1, 21, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1194), 2, "Mariposa Tarde", new DateTime(2024, 12, 22, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1193) },
                    { 7, new DateTime(2025, 1, 19, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1197), 2, "Crol Mañana", new DateTime(2024, 12, 20, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1196) },
                    { 8, new DateTime(2025, 1, 25, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1200), 3, "Crol Tarde", new DateTime(2024, 12, 26, 12, 30, 43, 599, DateTimeKind.Local).AddTicks(1199) }
                });

            migrationBuilder.InsertData(
                table: "Swimmers",
                columns: new[] { "SwimmerId", "Birth_Date", "Email", "Genre", "Name", "Phone_Number" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "juanperez@ejemplo.com", 1, "Juan Pérez", "555123456" },
                    { 2, new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "anagomez@ejemplo.com", 2, "Ana Gómez", "555654321" },
                    { 3, new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "luis.fernandez@ejemplo.com", 1, "Luis Fernández", "444555666" },
                    { 4, new DateTime(2002, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria.torres@ejemplo.com", 2, "María Torres", "777888999" },
                    { 5, new DateTime(1999, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlos.ruiz@ejemplo.com", 1, "Carlos Ruiz", "888777666" },
                    { 6, new DateTime(1996, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucia.ramirez@ejemplo.com", 2, "Lucía Ramírez", "333444555" },
                    { 7, new DateTime(1985, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "pedro.gutierrez@ejemplo.com", 1, "Pedro Gutiérrez", "111222444" },
                    { 8, new DateTime(1994, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sofia.moreno@ejemplo.com", 2, "Sofía Moreno", "555666888" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoachId", "Places", "Title" },
                values: new object[,]
                {
                    { 1, 1, 10, "Braza" },
                    { 2, 2, 15, "Flotación y Propulsión" },
                    { 3, 3, 12, "Mariposa" },
                    { 4, 4, 18, "Crol" },
                    { 5, 5, 8, "Resistencia en Aguas Abiertas" },
                    { 6, 6, 20, "Técnica de Espalda" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "GroupId", "SwimmerId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 2, 2 },
                    { 3, 2, 3, 3 },
                    { 4, 2, 4, 4 },
                    { 5, 3, 5, 5 },
                    { 6, 3, 6, 6 },
                    { 7, 4, 7, 7 },
                    { 8, 4, 8, 8 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "Content", "EnrollmentId" },
                values: new object[,]
                {
                    { 1, "Buen progreso, ¡sigue practicando!", 1 },
                    { 2, "Necesita mejorar la técnica, se requiere más práctica.", 2 },
                    { 3, "Excelente avance en el curso, sigue así.", 3 },
                    { 4, "Algunos problemas con la flotación, se recomienda reforzar.", 3 },
                    { 5, "Gran desempeño en las clases, buen trabajo.", 4 },
                    { 6, "Dificultades en la técnica de brazada, trabajar en ello.", 5 },
                    { 7, "Muestra mejoría constante en las sesiones.", 5 },
                    { 8, "Progreso notable en el nado mariposa.", 6 },
                    { 9, "Problemas menores con la técnica, mejorar coordinación.", 7 },
                    { 10, "Desempeño sobresaliente, excelente actitud.", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CoachId",
                table: "Courses",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_GroupId",
                table: "Enrollments",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SwimmerId",
                table: "Enrollments",
                column: "SwimmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_EnrollmentId",
                table: "Reports",
                column: "EnrollmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Swimmers");

            migrationBuilder.DropTable(
                name: "Coaches");
        }
    }
}
