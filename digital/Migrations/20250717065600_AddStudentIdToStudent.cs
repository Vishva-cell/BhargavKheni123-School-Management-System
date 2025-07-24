using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digital.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentIdToStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "Users",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "role");
        }
    }
}
