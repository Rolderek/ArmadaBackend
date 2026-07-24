using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
{
    public class Ship
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Point { get; set; }
        public List<CardCategory> CardsType { get; set; }
    }
}
