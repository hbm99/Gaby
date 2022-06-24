using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaby.Server.Migrations
{
    public partial class Fixing_date_time_rebuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Members_MemberClientClientId",
                table: "Measurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.RenameTable(
                name: "Measurements",
                newName: "ManyMeasurements");

            migrationBuilder.RenameIndex(
                name: "IX_Measurements_MemberClientClientId",
                table: "ManyMeasurements",
                newName: "IX_ManyMeasurements_MemberClientClientId");

            migrationBuilder.AddColumn<int>(
                name: "CheckInTime_Hour",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckInTime_Minute",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckOutTime_Hour",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckOutTime_Minute",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementsDate_Day",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementsDate_Month",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementsDate_Year",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManyMeasurements",
                table: "ManyMeasurements",
                column: "MeasurementsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManyMeasurements_Members_MemberClientClientId",
                table: "ManyMeasurements",
                column: "MemberClientClientId",
                principalTable: "Members",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManyMeasurements_Members_MemberClientClientId",
                table: "ManyMeasurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManyMeasurements",
                table: "ManyMeasurements");

            migrationBuilder.DropColumn(
                name: "CheckInTime_Hour",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CheckInTime_Minute",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CheckOutTime_Hour",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CheckOutTime_Minute",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MeasurementsDate_Day",
                table: "ManyMeasurements");

            migrationBuilder.DropColumn(
                name: "MeasurementsDate_Month",
                table: "ManyMeasurements");

            migrationBuilder.DropColumn(
                name: "MeasurementsDate_Year",
                table: "ManyMeasurements");

            migrationBuilder.RenameTable(
                name: "ManyMeasurements",
                newName: "Measurements");

            migrationBuilder.RenameIndex(
                name: "IX_ManyMeasurements_MemberClientClientId",
                table: "Measurements",
                newName: "IX_Measurements_MemberClientClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                column: "MeasurementsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Members_MemberClientClientId",
                table: "Measurements",
                column: "MemberClientClientId",
                principalTable: "Members",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
