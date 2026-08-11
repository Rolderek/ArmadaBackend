using ArmadaBackend.Data.Seed;
using ArmadaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<ShipUpgadeCard> ShipUpgradeCards { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<SquadronCard> SquadronCards { get; set; }
        public DbSet<Objectives> Objectives { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // A Fleet entitás korábbi táblanevének megőrzése.
            modelBuilder.Entity<Fleet>().ToTable("Fleet");

 /*           modelBuilder.Entity<Fleet>()
                .HasMany(ship => ship.)
                .WithMany(fleet => fleet.Ships)
                .HasForeignKey(fleetElement => fleetElement.FleetId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FleetElement>()
                .HasOne(fleetElement => fleetElement.Ship)
                .WithMany()
                .HasForeignKey(fleetElement => fleetElement.ShipId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EquippedUpgrade>()
                .HasOne(upgrade => upgrade.FleetElement)
                .WithMany(fleetElement => fleetElement.EquippedUpgrades)
                .HasForeignKey(upgrade => upgrade.FleetElementId)
                .OnDelete(DeleteBehavior.Cascade);
 */

            modelBuilder.AddSeedData();
        }
    }
}
