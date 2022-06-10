using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaby.Server.Migrations.GabyDb
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmountPerType_Payment_Payments_PaymentId",
                table: "AmountPerType_Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_AmountPerType_Payment_PaymentTypes_PaymentTypeId",
                table: "AmountPerType_Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AmountPerType_Payment",
                table: "AmountPerType_Payment");

            migrationBuilder.RenameTable(
                name: "AmountPerType_Payment",
                newName: "AmountPerTypes");

            migrationBuilder.RenameIndex(
                name: "IX_AmountPerType_Payment_PaymentTypeId",
                table: "AmountPerTypes",
                newName: "IX_AmountPerTypes_PaymentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AmountPerType_Payment_PaymentId",
                table: "AmountPerTypes",
                newName: "IX_AmountPerTypes_PaymentId");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTypeId",
                table: "AmountPerTypes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AmountPerTypes",
                table: "AmountPerTypes",
                column: "AmountPerType_PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmountPerTypes_Payments_PaymentId",
                table: "AmountPerTypes",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmountPerTypes_PaymentTypes_PaymentTypeId",
                table: "AmountPerTypes",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "PaymentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmountPerTypes_Payments_PaymentId",
                table: "AmountPerTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AmountPerTypes_PaymentTypes_PaymentTypeId",
                table: "AmountPerTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AmountPerTypes",
                table: "AmountPerTypes");

            migrationBuilder.RenameTable(
                name: "AmountPerTypes",
                newName: "AmountPerType_Payment");

            migrationBuilder.RenameIndex(
                name: "IX_AmountPerTypes_PaymentTypeId",
                table: "AmountPerType_Payment",
                newName: "IX_AmountPerType_Payment_PaymentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AmountPerTypes_PaymentId",
                table: "AmountPerType_Payment",
                newName: "IX_AmountPerType_Payment_PaymentId");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTypeId",
                table: "AmountPerType_Payment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AmountPerType_Payment",
                table: "AmountPerType_Payment",
                column: "AmountPerType_PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmountPerType_Payment_Payments_PaymentId",
                table: "AmountPerType_Payment",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmountPerType_Payment_PaymentTypes_PaymentTypeId",
                table: "AmountPerType_Payment",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "PaymentTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
