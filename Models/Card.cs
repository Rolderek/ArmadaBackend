using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
{
    public class Card
    {
        public CardCategory Category { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Point { get; set; }
    }
}