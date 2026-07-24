namespace ArmadaBackend.Models
{
    public class ShipNameHolder
    {
        public List<string> ShipName { get; set; }

        public ShipNameHolder(List<string> ships) 
        {
            ShipName = ships;
        }

    }
}
