using ArmadaBackend.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArmadaBackend.Models
{
    //egy hajó reprezentációja, lehetséges kártya férőhelyei
    public class Ship
    {
        public int Id { get; set; }
        public ShipSize Size { get; set; }
        public int FactinId { get; set; }
        public string? Name { get; set; }
        public int Point { get; set; }

        [NotMapped]
        public List<ShipUpgadeCard> EmptyUpgradeSlots { get; set; } = new List<ShipUpgadeCard>();
        [NotMapped]
        public List<ShipUpgadeCard> FilledUpgradeSlots { get; set; } = new List<ShipUpgadeCard>();
    }
}
