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
            modelBuilder.Entity<MemberClient>().HasKey(x => new { x.ClientId });
            modelBuilder.Entity<BasicClient>().HasKey(x => new { x.ClientId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MemberClient> Members { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<BasicClient> Clients { get; set; }

        public DbSet<InscriptionDate> Inscriptions { get; set; }
    }
}
