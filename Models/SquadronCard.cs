namespace ArmadaBackend.Models
{
    // Egy választható századkártya törzsadatait reprezentálja.
    public class SquadronCard
    {
        public int Id { get; set; }
        public int FactionId { get; set; }
        public string SquadronName { get; set; } = string.Empty;
        public string? AceName { get; set; }
        public bool IsUnique { get; set; }
        public bool IsUniqueShip { get; set; } //ha Lando vagy Han ül a falconban...
        public int Point { get; set; }
    }
}
