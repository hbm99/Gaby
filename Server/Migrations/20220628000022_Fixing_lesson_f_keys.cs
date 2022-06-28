using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaby.Server.Migrations
{
    public partial class Fixing_lesson_f_keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Coaches_CoachEmployeeId",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CoachEmployeeId",
                table: "Lessons",
                newName: "CoachId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CoachEmployeeId",
                table: "Lessons",
                newName: "IX_Lessons_CoachId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                columns: new[] { "ServiceId", "CoachId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Coaches_CoachId",
                table: "Lessons",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Coaches_CoachId",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CoachId",
                table: "Lessons",
                newName: "CoachEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CoachId",
                table: "Lessons",
                newName: "IX_Lessons_CoachEmployeeId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Lessons",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                columns: new[] { "ServiceId", "EmployeeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Coaches_CoachEmployeeId",
                table: "Lessons",
                column: "CoachEmployeeId",
                principalTable: "Coaches",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
