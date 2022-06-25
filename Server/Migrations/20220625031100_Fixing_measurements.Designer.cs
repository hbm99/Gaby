﻿// <auto-generated />
using System;
using Gaby.Server.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gaby.Server.Migrations
{
    [DbContext(typeof(GabyDbContext))]
    [Migration("20220625031100_Fixing_measurements")]
    partial class Fixing_measurements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AmountPerType_PaymentPayment", b =>
                {
                    b.Property<int>("AmountPerType_PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentsPaymentId")
                        .HasColumnType("int");

                    b.HasKey("AmountPerType_PaymentId", "PaymentsPaymentId");

                    b.HasIndex("PaymentsPaymentId");

                    b.ToTable("AmountPerType_PaymentPayment");
                });

            modelBuilder.Entity("ExpensePayment", b =>
                {
                    b.Property<int>("ExpensesExpenseId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentsPaymentId")
                        .HasColumnType("int");

                    b.HasKey("ExpensesExpenseId", "PaymentsPaymentId");

                    b.HasIndex("PaymentsPaymentId");

                    b.ToTable("ExpensePayment");
                });

            modelBuilder.Entity("Gaby.Shared.Model.AmountPerType_Payment", b =>
                {
                    b.Property<int>("AmountPerType_PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmountPerType_PaymentId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PaymentTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AmountPerType_PaymentId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("AmountPerTypes");
                });

            modelBuilder.Entity("Gaby.Shared.Model.BasicClient", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("BasicClients");
                });

            modelBuilder.Entity("Gaby.Shared.Model.CashInBox", b =>
                {
                    b.Property<int>("CashInBoxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CashInBoxId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CashInBoxId");

                    b.ToTable("CashInBoxes");
                });

            modelBuilder.Entity("Gaby.Shared.Model.CashInBoxDate", b =>
                {
                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CashInBoxId")
                        .HasColumnType("int");

                    b.HasKey("DateTime");

                    b.HasIndex("CashInBoxId")
                        .IsUnique()
                        .HasFilter("[CashInBoxId] IS NOT NULL");

                    b.ToTable("CashInBoxDates");
                });

            modelBuilder.Entity("Gaby.Shared.Model.ClientOffer", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ClientId", "OfferId", "Date");

                    b.HasIndex("Date");

                    b.HasIndex("OfferId");

                    b.ToTable("ClientOffer");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Gaby.Shared.Model.EquipmentRepair", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReparationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaintenanceEmployeeEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeId", "EquipmentId", "ReparationDate");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("MaintenanceEmployeeEmployeeId");

                    b.ToTable("EquipmentRepairs");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpenseTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ExpenseTypeName");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Gaby.Shared.Model.ExpenseType", b =>
                {
                    b.Property<string>("ExpenseTypeName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExpenseTypeName");

                    b.ToTable("ExpenseTypes");
                });

            modelBuilder.Entity("Gaby.Shared.Model.InscriptionDate", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Date");

                    b.ToTable("InscriptionDates");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Lesson", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CoachEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("MinutesDuration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServiceId", "EmployeeId");

                    b.HasIndex("CoachEmployeeId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Gaby.Shared.Model.LessonTurn", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId", "ServiceId", "Schedule");

                    b.HasIndex("ServiceId");

                    b.ToTable("LessonTurns");
                });

            modelBuilder.Entity("Gaby.Shared.Model.LessonTurn_Client", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Assisted")
                        .HasColumnType("bit");

                    b.Property<string>("CoachEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LessonTurnEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LessonTurnSchedule")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonTurnServiceId")
                        .HasColumnType("int");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.HasKey("ClientId", "ServiceId", "Schedule", "EmployeeId");

                    b.HasIndex("CoachEmployeeId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("LessonTurnEmployeeId", "LessonTurnServiceId", "LessonTurnSchedule");

                    b.ToTable("LessonTurn_Clients");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Measurements", b =>
                {
                    b.Property<int>("MeasurementsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeasurementsId"), 1L, 1);

                    b.Property<float>("ArmSize")
                        .HasColumnType("real");

                    b.Property<float>("CalfSize")
                        .HasColumnType("real");

                    b.Property<float>("ChestSize")
                        .HasColumnType("real");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<float>("HipSize")
                        .HasColumnType("real");

                    b.Property<int>("MemberClientClientId")
                        .HasColumnType("int");

                    b.Property<float>("ThighSize")
                        .HasColumnType("real");

                    b.Property<float>("WaistSize")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("MeasurementsId");

                    b.HasIndex("MemberClientClientId");

                    b.ToTable("ManyMeasurements");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferId"), 1L, 1);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OfferId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Offer_Service", b =>
                {
                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("OfferId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Offer_Services");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Gaby.Shared.Model.PaymentType", b =>
                {
                    b.Property<string>("PaymentTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<string>("ServiceTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ServiceId");

                    b.HasIndex("ServiceTypeName");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Gaby.Shared.Model.ServiceType", b =>
                {
                    b.Property<string>("ServiceTypeName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ServiceTypeName");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("Gaby.Shared.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleting")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PaymentPaymentType", b =>
                {
                    b.Property<string>("PaymentTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PaymentsPaymentId")
                        .HasColumnType("int");

                    b.HasKey("PaymentTypeId", "PaymentsPaymentId");

                    b.HasIndex("PaymentsPaymentId");

                    b.ToTable("PaymentPaymentType");
                });

            modelBuilder.Entity("Gaby.Shared.Model.CleanerEmployee", b =>
                {
                    b.HasBaseType("Gaby.Shared.Model.Employee");

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("CleanerEmployees");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Coach", b =>
                {
                    b.HasBaseType("Gaby.Shared.Model.Employee");

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ExtraSalary")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("Gaby.Shared.Model.EquipmentExpense", b =>
                {
                    b.HasBaseType("Gaby.Shared.Model.Expense");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasIndex("EquipmentId");

                    b.ToTable("EquipmentExpenses");
                });

            modelBuilder.Entity("Gaby.Shared.Model.MaintenanceEmployee", b =>
                {
                    b.HasBaseType("Gaby.Shared.Model.Employee");

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ExtraSalary")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("MaintenanceEmployees");
                });

            modelBuilder.Entity("Gaby.Shared.Model.MemberClient", b =>
                {
                    b.HasBaseType("Gaby.Shared.Model.BasicClient");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Ailments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("AmountPerType_PaymentPayment", b =>
                {
                    b.HasOne("Gaby.Shared.Model.AmountPerType_Payment", null)
                        .WithMany()
                        .HasForeignKey("AmountPerType_PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentsPaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExpensePayment", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Expense", null)
                        .WithMany()
                        .HasForeignKey("ExpensesExpenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentsPaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gaby.Shared.Model.AmountPerType_Payment", b =>
                {
                    b.HasOne("Gaby.Shared.Model.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("Gaby.Shared.Model.CashInBoxDate", b =>
                {
                    b.HasOne("Gaby.Shared.Model.CashInBox", "CashInBox")
                        .WithOne("CashInBoxDate")
                        .HasForeignKey("Gaby.Shared.Model.CashInBoxDate", "CashInBoxId");

                    b.Navigation("CashInBox");
                });

            modelBuilder.Entity("Gaby.Shared.Model.ClientOffer", b =>
                {
                    b.HasOne("Gaby.Shared.Model.MemberClient", "MemberClient")
                        .WithMany("ClientOffers")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.InscriptionDate", "InscriptionDate")
                        .WithMany()
                        .HasForeignKey("Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Offer", "Offer")
                        .WithMany("ClientOffers")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InscriptionDate");

                    b.Navigation("MemberClient");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Gaby.Shared.Model.EquipmentRepair", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Equipment", "Equipment")
                        .WithMany("Repairs")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.MaintenanceEmployee", "MaintenanceEmployee")
                        .WithMany("Repairs")
                        .HasForeignKey("MaintenanceEmployeeEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("MaintenanceEmployee");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Expense", b =>
                {
                    b.HasOne("Gaby.Shared.Model.ExpenseType", "ExpenseType")
                        .WithMany()
                        .HasForeignKey("ExpenseTypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseType");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Lesson", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Gaby.Shared.Model.LessonTurn", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Gaby.Shared.Model.LessonTurn_Client", b =>
                {
                    b.HasOne("Gaby.Shared.Model.BasicClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.LessonTurn", "LessonTurn")
                        .WithMany()
                        .HasForeignKey("LessonTurnEmployeeId", "LessonTurnServiceId", "LessonTurnSchedule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Coach");

                    b.Navigation("LessonTurn");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Measurements", b =>
                {
                    b.HasOne("Gaby.Shared.Model.MemberClient", "MemberClient")
                        .WithMany("ManyMeasurements")
                        .HasForeignKey("MemberClientClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Gaby.Shared.Utils.BasicDate", "MeasurementsDate", b1 =>
                        {
                            b1.Property<int>("MeasurementsId")
                                .HasColumnType("int");

                            b1.Property<int>("Day")
                                .HasColumnType("int");

                            b1.Property<int>("Month")
                                .HasColumnType("int");

                            b1.Property<int>("Year")
                                .HasColumnType("int");

                            b1.HasKey("MeasurementsId");

                            b1.ToTable("ManyMeasurements");

                            b1.WithOwner()
                                .HasForeignKey("MeasurementsId");
                        });

                    b.Navigation("MeasurementsDate")
                        .IsRequired();

                    b.Navigation("MemberClient");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Offer_Service", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Service", b =>
                {
                    b.HasOne("Gaby.Shared.Model.ServiceType", "ServiceType")
                        .WithMany()
                        .HasForeignKey("ServiceTypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("PaymentPaymentType", b =>
                {
                    b.HasOne("Gaby.Shared.Model.PaymentType", null)
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentsPaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gaby.Shared.Model.CleanerEmployee", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Employee", null)
                        .WithOne()
                        .HasForeignKey("Gaby.Shared.Model.CleanerEmployee", "EmployeeId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gaby.Shared.Model.Coach", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Employee", null)
                        .WithOne()
                        .HasForeignKey("Gaby.Shared.Model.Coach", "EmployeeId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gaby.Shared.Model.EquipmentExpense", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Equipment", "Equipment")
                        .WithMany("Expenses")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gaby.Shared.Model.Expense", null)
                        .WithOne()
                        .HasForeignKey("Gaby.Shared.Model.EquipmentExpense", "ExpenseId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("Gaby.Shared.Model.MaintenanceEmployee", b =>
                {
                    b.HasOne("Gaby.Shared.Model.Employee", null)
                        .WithOne()
                        .HasForeignKey("Gaby.Shared.Model.MaintenanceEmployee", "EmployeeId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gaby.Shared.Model.MemberClient", b =>
                {
                    b.HasOne("Gaby.Shared.Model.BasicClient", null)
                        .WithOne()
                        .HasForeignKey("Gaby.Shared.Model.MemberClient", "ClientId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.OwnsOne("Gaby.Shared.Utils.BasicTime", "CheckInTime", b1 =>
                        {
                            b1.Property<int>("MemberClientClientId")
                                .HasColumnType("int");

                            b1.Property<int>("Hour")
                                .HasColumnType("int");

                            b1.Property<int>("Minute")
                                .HasColumnType("int");

                            b1.HasKey("MemberClientClientId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberClientClientId");
                        });

                    b.OwnsOne("Gaby.Shared.Utils.BasicTime", "CheckOutTime", b1 =>
                        {
                            b1.Property<int>("MemberClientClientId")
                                .HasColumnType("int");

                            b1.Property<int>("Hour")
                                .HasColumnType("int");

                            b1.Property<int>("Minute")
                                .HasColumnType("int");

                            b1.HasKey("MemberClientClientId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberClientClientId");
                        });

                    b.OwnsOne("Gaby.Shared.Utils.HomeAddress", "Address", b1 =>
                        {
                            b1.Property<int>("MemberClientClientId")
                                .HasColumnType("int");

                            b1.Property<string>("Community")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("HouseNumber")
                                .HasColumnType("int");

                            b1.Property<string>("MainSt")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Municipality")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SecondarySt1")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SecondarySt2")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("MemberClientClientId");

                            b1.ToTable("Members");

                            b1.WithOwner()
                                .HasForeignKey("MemberClientClientId");
                        });

                    b.Navigation("Address");

                    b.Navigation("CheckInTime");

                    b.Navigation("CheckOutTime");
                });

            modelBuilder.Entity("Gaby.Shared.Model.CashInBox", b =>
                {
                    b.Navigation("CashInBoxDate")
                        .IsRequired();
                });

            modelBuilder.Entity("Gaby.Shared.Model.Equipment", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("Gaby.Shared.Model.Offer", b =>
                {
                    b.Navigation("ClientOffers");
                });

            modelBuilder.Entity("Gaby.Shared.Model.MaintenanceEmployee", b =>
                {
                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("Gaby.Shared.Model.MemberClient", b =>
                {
                    b.Navigation("ClientOffers");

                    b.Navigation("ManyMeasurements");
                });
#pragma warning restore 612, 618
        }
    }
}
