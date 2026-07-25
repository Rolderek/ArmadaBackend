namespace ArmadaBackend.Models
{
    public class Fleet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<FleetELement> Ships { get; set; } = new List<FleetELement>();
        public List<SquadronElement> Squadrons { get; set; } = new List<SquadronElement>();
    }
}
