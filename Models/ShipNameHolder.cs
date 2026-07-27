namespace ArmadaBackend.Models
{
    public class ShipNameHolder
    {
        public int Id { get; set; }
        public List<string> ShipName { get; set; } = new();
        private ShipNameHolder() { }
        public ShipNameHolder(List<string> ships)
        {
            ShipName = ships;
        }
    }
}

/*
//később kellhet:
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<ShipNameHolder>()
        .Property(e => e.ShipName)
        .HasConversion(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null)
        );
}
*/