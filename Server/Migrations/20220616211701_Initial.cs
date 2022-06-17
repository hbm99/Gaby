using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gaby.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicClients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicClients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "CashInBoxes",
                columns: table => new
                {
                    CashInBoxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInBoxes", x => x.CashInBoxId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    ExpenseTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.ExpenseTypeName);
                });

            migrationBuilder.CreateTable(
                name: "InscriptionDates",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscriptionDates", x => x.Date);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    ServiceTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ServiceTypeName);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleting = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address_MainSt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_SecondarySt1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_SecondarySt2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_HouseNumber = table.Column<int>(type: "int", nullable: true),
                    Address_Community = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Municipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ailments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Members_BasicClients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "BasicClients",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "CashInBoxDates",
                columns: table => new
                {
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CashInBoxId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInBoxDates", x => x.DateTime);
                    table.ForeignKey(
                        name: "FK_CashInBoxDates_CashInBoxes_CashInBoxId",
                        column: x => x.CashInBoxId,
                        principalTable: "CashInBoxes",
                        principalColumn: "CashInBoxId");
                });

            migrationBuilder.CreateTable(
                name: "CleanerEmployees",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleanerEmployees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_CleanerEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Coaches_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceEmployees",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceEmployees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_MaintenanceEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpenseTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseTypes_ExpenseTypeName",
                        column: x => x.ExpenseTypeName,
                        principalTable: "ExpenseTypes",
                        principalColumn: "ExpenseTypeName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmountPerTypes",
                columns: table => new
                {
                    AmountPerType_PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountPerTypes", x => x.AmountPerType_PaymentId);
                    table.ForeignKey(
                        name: "FK_AmountPerTypes_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPaymentType",
                columns: table => new
                {
                    PaymentTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentsPaymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPaymentType", x => new { x.PaymentTypeId, x.PaymentsPaymentId });
                    table.ForeignKey(
                        name: "FK_PaymentPaymentType_Payments_PaymentsPaymentId",
                        column: x => x.PaymentsPaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentPaymentType_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeName",
                        column: x => x.ServiceTypeName,
                        principalTable: "ServiceTypes",
                        principalColumn: "ServiceTypeName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientOffer",
                columns: table => new
                {
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOffer", x => new { x.ClientId, x.OfferId, x.Date });
                    table.ForeignKey(
                        name: "FK_ClientOffer_InscriptionDates_Date",
                        column: x => x.Date,
                        principalTable: "InscriptionDates",
                        principalColumn: "Date",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientOffer_Members_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Members",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientOffer_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "OfferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    MeasurementsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    MemberClientClientId = table.Column<int>(type: "int", nullable: false),
                    MeasurementsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    ArmSize = table.Column<float>(type: "real", nullable: false),
                    ThighSize = table.Column<float>(type: "real", nullable: false),
                    ChestSize = table.Column<float>(type: "real", nullable: false),
                    CalfSize = table.Column<float>(type: "real", nullable: false),
                    HipSize = table.Column<float>(type: "real", nullable: false),
                    WaistSize = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.MeasurementsId);
                    table.ForeignKey(
                        name: "FK_Measurements_Members_MemberClientClientId",
                        column: x => x.MemberClientClientId,
                        principalTable: "Members",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentRepairs",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    ReparationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintenanceEmployeeEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentRepairs", x => new { x.EmployeeId, x.EquipmentId, x.ReparationDate });
                    table.ForeignKey(
                        name: "FK_EquipmentRepairs_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentRepairs_MaintenanceEmployees_MaintenanceEmployeeEmployeeId",
                        column: x => x.MaintenanceEmployeeEmployeeId,
                        principalTable: "MaintenanceEmployees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentExpenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentExpenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_EquipmentExpenses_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentExpenses_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "ExpenseId");
                });

            migrationBuilder.CreateTable(
                name: "ExpensePayment",
                columns: table => new
                {
                    ExpensesExpenseId = table.Column<int>(type: "int", nullable: false),
                    PaymentsPaymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensePayment", x => new { x.ExpensesExpenseId, x.PaymentsPaymentId });
                    table.ForeignKey(
                        name: "FK_ExpensePayment_Expenses_ExpensesExpenseId",
                        column: x => x.ExpensesExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "ExpenseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpensePayment_Payments_PaymentsPaymentId",
                        column: x => x.PaymentsPaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmountPerType_PaymentPayment",
                columns: table => new
                {
                    AmountPerType_PaymentId = table.Column<int>(type: "int", nullable: false),
                    PaymentsPaymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountPerType_PaymentPayment", x => new { x.AmountPerType_PaymentId, x.PaymentsPaymentId });
                    table.ForeignKey(
                        name: "FK_AmountPerType_PaymentPayment_AmountPerTypes_AmountPerType_PaymentId",
                        column: x => x.AmountPerType_PaymentId,
                        principalTable: "AmountPerTypes",
                        principalColumn: "AmountPerType_PaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmountPerType_PaymentPayment_Payments_PaymentsPaymentId",
                        column: x => x.PaymentsPaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoachEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    MinutesDuration = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => new { x.ServiceId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_Lessons_Coaches_CoachEmployeeId",
                        column: x => x.CoachEmployeeId,
                        principalTable: "Coaches",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonTurns",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTurns", x => new { x.EmployeeId, x.ServiceId, x.Schedule });
                    table.ForeignKey(
                        name: "FK_LessonTurns_Coaches_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Coaches",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LessonTurns_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Offer_Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer_Services", x => new { x.OfferId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_Offer_Services_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "OfferId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offer_Services_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonTurn_Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoachEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonTurnEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonTurnServiceId = table.Column<int>(type: "int", nullable: false),
                    LessonTurnSchedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    Assisted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTurn_Clients", x => new { x.ClientId, x.ServiceId, x.Schedule, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_LessonTurn_Clients_BasicClients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "BasicClients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTurn_Clients_Coaches_CoachEmployeeId",
                        column: x => x.CoachEmployeeId,
                        principalTable: "Coaches",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTurn_Clients_LessonTurns_LessonTurnEmployeeId_LessonTurnServiceId_LessonTurnSchedule",
                        columns: x => new { x.LessonTurnEmployeeId, x.LessonTurnServiceId, x.LessonTurnSchedule },
                        principalTable: "LessonTurns",
                        principalColumns: new[] { "EmployeeId", "ServiceId", "Schedule" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTurn_Clients_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmountPerType_PaymentPayment_PaymentsPaymentId",
                table: "AmountPerType_PaymentPayment",
                column: "PaymentsPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_AmountPerTypes_PaymentTypeId",
                table: "AmountPerTypes",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CashInBoxDates_CashInBoxId",
                table: "CashInBoxDates",
                column: "CashInBoxId",
                unique: true,
                filter: "[CashInBoxId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOffer_Date",
                table: "ClientOffer",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOffer_OfferId",
                table: "ClientOffer",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentExpenses_EquipmentId",
                table: "EquipmentExpenses",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRepairs_EquipmentId",
                table: "EquipmentRepairs",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRepairs_MaintenanceEmployeeEmployeeId",
                table: "EquipmentRepairs",
                column: "MaintenanceEmployeeEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensePayment_PaymentsPaymentId",
                table: "ExpensePayment",
                column: "PaymentsPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeName",
                table: "Expenses",
                column: "ExpenseTypeName");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CoachEmployeeId",
                table: "Lessons",
                column: "CoachEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTurn_Clients_CoachEmployeeId",
                table: "LessonTurn_Clients",
                column: "CoachEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTurn_Clients_LessonTurnEmployeeId_LessonTurnServiceId_LessonTurnSchedule",
                table: "LessonTurn_Clients",
                columns: new[] { "LessonTurnEmployeeId", "LessonTurnServiceId", "LessonTurnSchedule" });

            migrationBuilder.CreateIndex(
                name: "IX_LessonTurn_Clients_ServiceId",
                table: "LessonTurn_Clients",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTurns_ServiceId",
                table: "LessonTurns",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_MemberClientClientId",
                table: "Measurements",
                column: "MemberClientClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Services_ServiceId",
                table: "Offer_Services",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPaymentType_PaymentsPaymentId",
                table: "PaymentPaymentType",
                column: "PaymentsPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeName",
                table: "Services",
                column: "ServiceTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmountPerType_PaymentPayment");

            migrationBuilder.DropTable(
                name: "CashInBoxDates");

            migrationBuilder.DropTable(
                name: "CleanerEmployees");

            migrationBuilder.DropTable(
                name: "ClientOffer");

            migrationBuilder.DropTable(
                name: "EquipmentExpenses");

            migrationBuilder.DropTable(
                name: "EquipmentRepairs");

            migrationBuilder.DropTable(
                name: "ExpensePayment");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "LessonTurn_Clients");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "Offer_Services");

            migrationBuilder.DropTable(
                name: "PaymentPaymentType");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AmountPerTypes");

            migrationBuilder.DropTable(
                name: "CashInBoxes");

            migrationBuilder.DropTable(
                name: "InscriptionDates");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "MaintenanceEmployees");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "LessonTurns");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "BasicClients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ServiceTypes");
        }
    }
}
