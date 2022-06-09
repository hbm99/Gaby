using Gaby.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Gaby.Server.Infrastructure
{
    public class GabyDbContext : DbContext
    {
        public GabyDbContext(DbContextOptions<GabyDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring multiple PK

            modelBuilder.Entity<EquipmentRepair>()
                .HasKey(equipmentRepair => new { equipmentRepair.MaintenanceEmployee, equipmentRepair.Equipment,
                        equipmentRepair.ReparationDate });


            modelBuilder.Entity<Offer_Service>()
                .HasKey(offer_service => new { offer_service.OfferId, offer_service.ServiceId });

            modelBuilder.Entity<Lesson>()
                .HasKey(lesson => new { lesson.ServiceId, lesson.EmployeeId });

            modelBuilder.Entity<LessonTurn>()
                .HasKey(lessonTurn => new { lessonTurn.EmployeeId, lessonTurn.ServiceId, lessonTurn.Schedule });

            modelBuilder.Entity<LessonTurn_Client>()
                .HasKey(lessonTurnClient => new { lessonTurnClient.ClientId, lessonTurnClient.ServiceId,
                        lessonTurnClient.Schedule, lessonTurnClient.EmployeeId });

            
        }

        public DbSet<BasicClient> Clients { get; set; }

        public DbSet<CashInBox> CashInBoxes { get; set; }

        public DbSet<CashInBoxDate> CashInBoxDates { get; set; }

        public DbSet<CleanerEmployee> CleanerEmployees { get; set; }

        public DbSet<Coach> Coaches { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentExpense> EquipmentExpenses { get; set; }

        public DbSet<EquipmentRepair> EquipmentRepairs { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

        public DbSet<InscriptionDate> InscriptionDates { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonTurn> LessonTurns { get; set; }

        public DbSet<LessonTurn_Client> LessonTurn_Clients { get; set; }

        public DbSet<MaintenanceEmployee> MaintenanceEmployees { get; set; }

        public DbSet<Measurements> Measurements { get; set; }

        public DbSet<MemberClient> MemberClients { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Offer_Service> Offer_Services { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<PaymentType> PaymentTypes { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

    }
}
