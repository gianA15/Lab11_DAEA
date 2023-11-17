using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab11.Migrations
{
    public partial class V2_PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Students",
                newName: "GradeID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                newName: "IX_Students_GradeID");

            migrationBuilder.RenameColumn(
                name: "EnrollmentId",
                table: "Enrollments",
                newName: "EnrollmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "GradeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "GradeID",
                table: "Students",
                newName: "GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GradeID",
                table: "Students",
                newName: "IX_Students_GradeId");

            migrationBuilder.RenameColumn(
                name: "EnrollmentID",
                table: "Enrollments",
                newName: "EnrollmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
