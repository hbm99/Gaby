using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaby.Server.Migrations
{
    public partial class Changing_dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasurementsDate",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Measurements",
                newName: "MeasurementsDateYear");

            migrationBuilder.AddColumn<int>(
                name: "CheckInTimeHour",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckInTimeMinute",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckOutTimeHour",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckOutTimeMinute",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementsDateDay",
                table: "Measurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementsDateMonth",
                table: "Measurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BasicDate",
                columns: table => new
                {
                    Day = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicDate", x => new { x.Day, x.Month, x.Year });
                });

            migrationBuilder.CreateTable(
                name: "BasicTime",
                columns: table => new
                {
                    Hour = table.Column<int>(type: "int", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicTime", x => new { x.Hour, x.Minute });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_CheckInTimeHour_CheckInTimeMinute",
                table: "Members",
                columns: new[] { "CheckInTimeHour", "CheckInTimeMinute" });

            migrationBuilder.CreateIndex(
                name: "IX_Members_CheckOutTimeHour_CheckOutTimeMinute",
                table: "Members",
                columns: new[] { "CheckOutTimeHour", "CheckOutTimeMinute" });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_MeasurementsDateDay_MeasurementsDateMonth_MeasurementsDateYear",
                table: "Measurements",
                columns: new[] { "MeasurementsDateDay", "MeasurementsDateMonth", "MeasurementsDateYear" });

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_BasicDate_MeasurementsDateDay_MeasurementsDateMonth_MeasurementsDateYear",
                table: "Measurements",
                columns: new[] { "MeasurementsDateDay", "MeasurementsDateMonth", "MeasurementsDateYear" },
                principalTable: "BasicDate",
                principalColumns: new[] { "Day", "Month", "Year" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_BasicTime_CheckInTimeHour_CheckInTimeMinute",
                table: "Members",
                columns: new[] { "CheckInTimeHour", "CheckInTimeMinute" },
                principalTable: "BasicTime",
                principalColumns: new[] { "Hour", "Minute" });

            migrationBuilder.AddForeignKey(
                name: "FK_Members_BasicTime_CheckOutTimeHour_CheckOutTimeMinute",
                table: "Members",
                columns: new[] { "CheckOutTimeHour", "CheckOutTimeMinute" },
                principalTable: "BasicTime",
                principalColumns: new[] { "Hour", "Minute" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_BasicDate_MeasurementsDateDay_MeasurementsDateMonth_MeasurementsDateYear",
                table: "Measurements");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_BasicTime_CheckInTimeHour_CheckInTimeMinute",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_BasicTime_CheckOutTimeHour_CheckOutTimeMinute",
                table: "Members");

            migrationBuilder.DropTable(
                name: "BasicDate");

            migrationBuilder.DropTable(
                name: "BasicTime");

            migrationBuilder.DropIndex(
                name: "IX_Members_CheckInTimeHour_CheckInTimeMinute",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_CheckOutTimeHour_CheckOutTimeMinute",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_MeasurementsDateDay_MeasurementsDateMonth_MeasurementsDateYear",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CheckInTimeHour",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CheckInTimeMinute",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CheckOutTimeHour",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CheckOutTimeMinute",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MeasurementsDateDay",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "MeasurementsDateMonth",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "MeasurementsDateYear",
                table: "Measurements",
                newName: "ClientId");

            migrationBuilder.AddColumn<DateTime>(
                name: "MeasurementsDate",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
