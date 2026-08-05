namespace ArmadaBackend.Models
{
    // Egy upgrade-kártya felszerelését kapcsolja egy konkrét flottahajóhoz.
    public class EquippedUpgrade
    {
        public int Id { get; set; }

        public int FleetElementId { get; set; }
        public FleetElement? FleetElement { get; set; }

        public int CardId { get; set; }
        public Card? Card { get; set; }
    }
}
