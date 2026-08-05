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
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<FleetElement> FleetElements { get; set; }
        public DbSet<EquippedUpgrade> EquippedUpgrades { get; set; }
        public DbSet<SquadronElement> SquadronElements { get; set; }
        public DbSet<SquadronCard> SquadronCards { get; set; }
        public DbSet<ShipNameHolder> ShipNames { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // A Fleet entitás korábbi táblanevének megőrzése.
            modelBuilder.Entity<Fleet>().ToTable("Fleet");

            modelBuilder.Entity<FleetElement>()
                .HasOne(fleetElement => fleetElement.Fleet)
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

            modelBuilder.Entity<EquippedUpgrade>()
                .HasOne(upgrade => upgrade.Card)
                .WithMany()
                .HasForeignKey(upgrade => upgrade.CardId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ugyanaz a kártya egy hajóra legfeljebb egyszer szerelhető fel.
            modelBuilder.Entity<EquippedUpgrade>()
                .HasIndex(upgrade => new { upgrade.FleetElementId, upgrade.CardId })
                .IsUnique();

            modelBuilder.AddSeedData();
        }
    }
}
