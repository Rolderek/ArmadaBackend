using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
{
    public class Card
    {
        public int Id { get; set; }
        public CardCategory Category { get; set; } //ez kapcsolat is
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Point { get; set; }
    }
}