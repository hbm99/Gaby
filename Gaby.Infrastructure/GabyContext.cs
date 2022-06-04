using Gaby.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Gaby.Infrastructure
{
    /*
     * You would want to generate the model from an existing database via scaffolding.
     * Then move the entities into Gaby.Core project and keep here the DbContext.
     * See https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli
     */
    public class GabyContext : DbContext
    {
        public GabyContext(DbContextOptions<GabyContext> options) : base(options)
        {

        }

        public virtual DbSet<Member>? Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
