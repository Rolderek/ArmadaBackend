namespace ArmadaBackend.Models
{
    public class Fleet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Ship> Ships { get; set; } = new List<Ship>();
        public List<SquadronElement> Squadrons { get; set; } = new List<SquadronElement>();
    }
}
