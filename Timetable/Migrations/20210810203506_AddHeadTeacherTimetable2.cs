using Microsoft.EntityFrameworkCore.Migrations;

namespace Timetable.Migrations
{
    public partial class AddHeadTeacherTimetable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timetables_Cabinets_CabinetId",
                table: "Timetables");

            migrationBuilder.DropForeignKey(
                name: "FK_Timetables_Classes_ClassId",
                table: "Timetables");

            migrationBuilder.DropForeignKey(
                name: "FK_Timetables_Days_DayId",
                table: "Timetables");

            migrationBuilder.DropForeignKey(
                name: "FK_Timetables_Lessons_LessonId",
                table: "Timetables");

            migrationBuilder.DropForeignKey(
                name: "FK_Timetables_Teachers_TeacherId",
                table: "Timetables");

            migrationBuilder.DropForeignKey(
                name: "FK_Timetables_Times_TimeId",
                table: "Timetables");

            migrationBuilder.DropIndex(
                name: "IX_Timetables_CabinetId",
                table: "Timetables");

            migrationBuilder.DropIndex(
                name: "IX_Timetables_ClassId",
                table: "Timetables");

            migrationBuilder.DropIndex(
                name: "IX_Timetables_DayId",
                table: "Timetables");

            migrationBuilder.DropIndex(
                name: "IX_Timetables_LessonId",
                table: "Timetables");

            migrationBuilder.DropIndex(
                name: "IX_Timetables_TeacherId",
                table: "Timetables");

            migrationBuilder.DropIndex(
                name: "IX_Timetables_TimeId",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "CabinetId",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Timetables");

            migrationBuilder.AddColumn<string>(
                name: "Cabinet",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lesson",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cabinet",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "Lesson",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "Teacher",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Timetables");

            migrationBuilder.AddColumn<int>(
                name: "CabinetId",
                table: "Timetables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Timetables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Timetables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Timetables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Timetables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Timetables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_CabinetId",
                table: "Timetables",
                column: "CabinetId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_ClassId",
                table: "Timetables",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_DayId",
                table: "Timetables",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_LessonId",
                table: "Timetables",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_TeacherId",
                table: "Timetables",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_TimeId",
                table: "Timetables",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timetables_Cabinets_CabinetId",
                table: "Timetables",
                column: "CabinetId",
                principalTable: "Cabinets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timetables_Classes_ClassId",
                table: "Timetables",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timetables_Days_DayId",
                table: "Timetables",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timetables_Lessons_LessonId",
                table: "Timetables",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timetables_Teachers_TeacherId",
                table: "Timetables",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timetables_Times_TimeId",
                table: "Timetables",
                column: "TimeId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
