namespace ArmadaBackend.Models
{
    //a listában egy squadront reprezentál, ennek lesz egy összefogó listája a flottában
    public class SquadronElement
    {
        public int Id { get; set; }
        public int SquadronId { get; set; }
        public int Count { get; set; }

        //kapcsolatok:
        public int FleetId { get; set; }
        public Fleet? Fleet { get; set; }
    }
}
