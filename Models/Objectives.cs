using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
    //a point alapértelmezetten legyen 0 vagy alami már érték, mert csinálok rajta az endpointoknál null vizsgálatot
{
    public class Objectives
    {
        public int Id { get; set; }
        public ObjectiveCategory Category { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Point { get; set; } = 0;
    }
}
