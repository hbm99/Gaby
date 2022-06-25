using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaby.Server.Migrations
{
    public partial class Turning_back : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManyMeasurements_Members_MemberClientClientId",
                table: "ManyMeasurements");

            migrationBuilder.AlterColumn<int>(
                name: "MemberClientClientId",
                table: "ManyMeasurements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementsDate_Year",
                table: "ManyMeasurements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementsDate_Month",
                table: "ManyMeasurements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementsDate_Day",
                table: "ManyMeasurements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ManyMeasurements_Members_MemberClientClientId",
                table: "ManyMeasurements",
                column: "MemberClientClientId",
                principalTable: "Members",
                principalColumn: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManyMeasurements_Members_MemberClientClientId",
                table: "ManyMeasurements");

            migrationBuilder.AlterColumn<int>(
                name: "MemberClientClientId",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementsDate_Year",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementsDate_Month",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementsDate_Day",
                table: "ManyMeasurements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ManyMeasurements_Members_MemberClientClientId",
                table: "ManyMeasurements",
                column: "MemberClientClientId",
                principalTable: "Members",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
