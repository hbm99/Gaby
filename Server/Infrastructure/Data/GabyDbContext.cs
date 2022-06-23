using Gaby.Shared.Model;
using Gaby.Shared.Utils;
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

            modelBuilder.Entity<EquipmentRepair>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.ReparationDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
            modelBuilder.Entity<EquipmentRepair>()
                .HasKey(equipmentRepair => new
                {
                    equipmentRepair.EmployeeId,
                    equipmentRepair.EquipmentId,
                    equipmentRepair.ReparationDate
                });

            modelBuilder.Entity<Offer_Service>()
                .HasKey(offer_service => new
                {
                    offer_service.OfferId,
                    offer_service.ServiceId
                });

            modelBuilder.Entity<Lesson>()
                .HasKey(lesson => new
                {
                    lesson.ServiceId,
                    lesson.EmployeeId
                });

            modelBuilder.Entity<LessonTurn>()
                .HasKey(lessonTurn => new
                {
                    lessonTurn.EmployeeId,
                    lessonTurn.ServiceId,
                    lessonTurn.Schedule
                });

            modelBuilder.Entity<LessonTurn_Client>()
                .HasKey(lessonTurnClient => new
                {
                    lessonTurnClient.ClientId,
                    lessonTurnClient.ServiceId,
                    lessonTurnClient.Schedule,
                    lessonTurnClient.EmployeeId
                });
            modelBuilder.Entity<ClientOffer>()
                .HasKey(clientOffer => new
                {
                    clientOffer.ClientId,
                    clientOffer.OfferId,
                    clientOffer.Date
                });
            /*modelBuilder.Entity<Measurements>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.MeasurementsDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });*/
            modelBuilder.Entity<InscriptionDate>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.Date)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
            modelBuilder.Entity<Expense>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.ExpenseDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });
            //modelBuilder.Entity<MemberClient>(builder =>
            //{
            //    // CheckinTime is a TimeOnly property and date on database
            //    builder.Property(x => x.CheckInTime)
            //        .HasConversion<TimeOnlyConverter, TimeOnlyComparer>();
            //    // CheckOutTime is a TimeOnly property and date on database
            //    builder.Property(x => x.CheckOutTime)
            //        .HasConversion<TimeOnlyConverter, TimeOnlyComparer>();
            //});
            //Tuple property
            modelBuilder.Entity<Payment>(builder =>
            {
                // Date is a DateOnly property and date on database
                builder.Property(x => x.PaymentDate)
                    .HasConversion<DateOnlyConverter, DateOnlyComparer>();
            });

            //HomeAddress property
            modelBuilder.Entity<MemberClient>().OwnsOne(x => x.Address);


            modelBuilder.Entity<BasicDate>()
                .HasKey(basicDate => new
                {
                    basicDate.Day,
                    basicDate.Month,
                    basicDate.Year
                });
            
            modelBuilder.Entity<BasicTime>()
                .HasKey(basicTime => new
                {
                    basicTime.Hour,
                    basicTime.Minute
                });

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<BasicClient> BasicClients { get; set; }

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

        public DbSet<AmountPerType_Payment> AmountPerTypes { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
