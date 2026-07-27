namespace ArmadaBackend.Models
{
    public class Fleet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<FleetElement> Ships { get; set; } = new List<FleetElement>();
        public List<SquadronElement> Squadrons { get; set; } = new List<SquadronElement>();
    }
}
