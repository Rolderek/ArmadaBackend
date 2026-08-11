using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
{
    public class Objectives
    {
        public int Id { get; set; }
        public ObjectiveCategory Category { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Point { get; set; }
    }
}
