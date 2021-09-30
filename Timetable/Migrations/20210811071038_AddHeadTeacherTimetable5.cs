using Microsoft.EntityFrameworkCore.Migrations;

namespace Timetable.Migrations
{
    public partial class AddHeadTeacherTimetable5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Timetables",
                newName: "timeStart");

            migrationBuilder.AddColumn<string>(
                name: "timeEnd",
                table: "Timetables",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "timeEnd",
                table: "Timetables");

            migrationBuilder.RenameColumn(
                name: "timeStart",
                table: "Timetables",
                newName: "Time");
        }
    }
}
