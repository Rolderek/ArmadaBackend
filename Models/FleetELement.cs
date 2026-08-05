namespace ArmadaBackend.Models
{
    // Egy flottába kiválasztott, felszerelt hajót reprezentál.
    public class FleetElement
    {
        public int Id { get; set; }

        // Kapcsolat a flottával.
        public int FleetId { get; set; }
        public Fleet? Fleet { get; set; }

        // A kiválasztott hajókártya törzsadata.
        public int ShipId { get; set; }
        public Ship? Ship { get; set; }

        // A felhasználó által erre a hajóra felszerelt upgrade-kártyák.
        public List<EquippedUpgrade> EquippedUpgrades { get; set; } = new();

        public int Point =>
            (Ship?.Point ?? 0) +
            EquippedUpgrades.Sum(upgrade => upgrade.Card?.Point ?? 0);
    }
}
