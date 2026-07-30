using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
{
    //egy hajó reprezentációja, lehetséges kártya férőhelyei
    public class Ship
    {
        public int Id { get; set; }
        public int FactinId { get; set; }
        public string? Name { get; set; }
        public int Point { get; set; }
        
        public List<ShipCard> CardsType { get; set; } = new List<ShipCard>();
    }
}
