using ArmadaBackend.Enums;
using ArmadaBackend.Models;

public class ShipCard
{
    public int Id { get; set; }        
    public int ShipId { get; set; }    
    public CardCategory Category { get; set; } 

    
    public Ship? Ship { get; set; }
}