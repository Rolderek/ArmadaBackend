using ArmadaBackend.Enums;

namespace ArmadaBackend.Models
{
    //egy hajó reprezentációja, lehetséges kártya férőhelyei
    public class Ship
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Point { get; set; }
        public List<ShipCard> CardsType { get; set; } = new List<ShipCard>();
    }
}

/*
var rebelShips = new List<Ship>
{
    new Ship
    {
        Name = "GR-75 Medium Transports",
        Point = 18,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.FleetSupport },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "GR-75 Combat Retrofits",
        Point = 24,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.FleetSupport },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },

    // --- KIS HAJÓK ---
    new Ship
    {
        Name = "CR90 Corvette A",
        Point = 44,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "CR90 Corvette B",
        Point = 39,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Hammerhead Scout Corvette",
        Point = 41,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Hammerhead Torpedo Corvette",
        Point = 36,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC30c Scout Torpedo Frigate",
        Point = 69,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC30c Torpedo Frigate",
        Point = 63,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Nebulon-B Escort Frigate",
        Point = 57,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Nebulon-B Support Refit",
        Point = 51,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Pelta-class Assault Ship",
        Point = 56,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.FleetCommandOG },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Pelta-class Command Ship",
        Point = 60,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.FleetCommandOG },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },

    // --- KÖZEPES HAJÓK ---
    new Ship
    {
        Name = "Assault Frigate Mark II A",
        Point = 81,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Assault Frigate Mark II B",
        Point = 72,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },

    // --- NAGY HAJÓK ---
    new Ship
    {
        Name = "MC75 Armored Cruiser",
        Point = 104,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC75 Ordnance Cruiser",
        Point = 100,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.Ordnance },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC80 Assault Cruiser",
        Point = 114,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC80 Command Cruiser",
        Point = 106,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC80 Battle Cruiser",
        Point = 103,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "MC80 Star Cruiser",
        Point = 96,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.SupportTeam },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Starhawk-class Battleship Mark I",
        Point = 140,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.SuperweaponRebel },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    },
    new Ship
    {
        Name = "Starhawk-class Battleship Mark II",
        Point = 150,
        CardsType = new List<ShipCard>
        {
            new ShipCard { Category = CardCategory.CommanderRebel },
            new ShipCard { Category = CardCategory.Officer },
            new ShipCard { Category = CardCategory.WeapTeam },
            new ShipCard { Category = CardCategory.OffensiveRetrofit },
            new ShipCard { Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
            new ShipCard { Category = CardCategory.DefensiveRetrofitOG },
            new ShipCard { Category = CardCategory.SuperweaponRebel },
            new ShipCard { Category = CardCategory.IonCannons },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.Turbolasers },
            new ShipCard { Category = CardCategory.TitleRebel }
        }
    }
};
*/