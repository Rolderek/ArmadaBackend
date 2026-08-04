using ArmadaBackend.Data.Seed;
using ArmadaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<ShipCard> ShipCards { get; set; }
        public DbSet<FleetElement> FleetElements { get; set; }
        public DbSet<SquadronElement> SquadronElements { get; set; }
        public DbSet<SquadronCard> SquadronCards { get; set; }
        public DbSet<ShipNameHolder> ShipNames { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddSeedData();
        }
    }
}
