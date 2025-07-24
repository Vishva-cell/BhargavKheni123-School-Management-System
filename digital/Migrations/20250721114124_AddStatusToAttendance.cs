using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digital.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToAttendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "TimeTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentId",
                table: "Users",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Student_StudentId",
                table: "Users",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Student_StudentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StudentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Attendance");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Student",
                newName: "StudentId");
        }
    }
}
