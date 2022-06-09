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
            // Configuring multiple PK, multiple FK for EquipmentRepair table
            modelBuilder.Entity<EquipmentRepair>()
                .HasKey(equipmentRepair => new { equipmentRepair.MaintenanceEmployee, equipmentRepair.Equipment, equipmentRepair.ReparationDate });

            //    .HasForeignKey(equipmentRepair => new { equipmentRepair.MaintenanceEmployee, equipmentRepair.Equipment });






            //modelBuilder.Entity<MemberClient>().HasKey(x => new { x.ClientId });
            //modelBuilder.Entity<BasicClient>().HasKey(x => new { x.ClientId });
            //base.OnModelCreating(modelBuilder);
        }

        //public DbSet<MemberClient> Members { get; set; }

        //public DbSet<Offer> Offers { get; set; }

        //public DbSet<BasicClient> Clients { get; set; }

        //public DbSet<InscriptionDate> Inscriptions { get; set; }
    }
}
