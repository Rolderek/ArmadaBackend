# AGENTS.md

# Feladat

A példakód alapján készítsd el a hiányzó hajókat (hajó kártya reprezentáció) a Star Wasr Armada nevű játékhoz.

# Elvárt eredmény

- Ne módosíts más seed-adatokat.
- Ellenőrizd az ID-k egyediségét.
- Futtasd a buildet.
- A végén foglald össze a változtatásokat.
- Ellenőrizd az egyes hajók fejlesztési kártya helyeit. Ezek a hajóra teherő kártyákat reprezentálják.

## Projekt

Technológiák:

- .NET SDK 9.0.17
- EntityFrameworkCore 9.0.18
- EntityFrameworkCore.SqlServer 9.0.18
- EntityFrameworkCore.Tools 9.0.18

A fő projekt:

- 'C:\Users\resta\source\repos\ArmadaBackend\ArmadaBackend.sln'

## Munkavégzési szabályok

-csak a szükséges file-okat módosítsd, máshoz ne nyúlj.

## Példa
	
	"modelBuilder.Entity<Ship>().HasData(
        // --- FLOTILLÁK ---
        new Ship { Id = 1, Size = (ShipSize)0, FactinId = 0, Name = "GR-75 Medium Transports", Point = 18 },
        new Ship { Id = 2, Size = (ShipSize)0, FactinId = 0, Name = "GR-75 Combat Retrofits", Point = 24 },

        // --- KIS HAJÓK ---
        new Ship { Id = 3, Size = (ShipSize)1, FactinId = 0, Name = "CR90 Corvette A", Point = 44 },
        new Ship { Id = 4, Size = (ShipSize)1, FactinId = 0,  Name = "CR90 Corvette B", Point = 39 },
        new Ship { Id = 5, Size = (ShipSize)1, FactinId = 0,  Name = "Hammerhead Scout Corvette", Point = 41 },
        new Ship { Id = 6, Size = (ShipSize)1, FactinId = 0,  Name = "Hammerhead Torpedo Corvette", Point = 36 },
        new Ship { Id = 7, Size = (ShipSize)1, FactinId = 0,  Name = "MC30c Scout Torpedo Frigate", Point = 69 },
        new Ship { Id = 8, Size = (ShipSize)1, FactinId = 0,  Name = "MC30c Torpedo Frigate", Point = 63 },
        new Ship { Id = 9, Size = (ShipSize)1, FactinId = 0, Name = "Nebulon-B Escort Frigate", Point = 57 },
        new Ship { Id = 10, Size = (ShipSize)1, FactinId = 0, Name = "Nebulon-B Support Refit", Point = 51 },
        new Ship { Id = 11, Size = (ShipSize)1, FactinId = 0, Name = "Pelta-class Assault Ship", Point = 56 },
        new Ship { Id = 12, Size = (ShipSize)1, FactinId = 0, Name = "Pelta-class Command Ship", Point = 60 },

        // --- KÖZEPES HAJÓK ---
        new Ship { Id = 13, Size = (ShipSize)2, FactinId = 0,  Name = "Assault Frigate Mark II A", Point = 81 },
        new Ship { Id = 14, Size = (ShipSize)2, FactinId = 0, Name = "Assault Frigate Mark II B", Point = 72 },

        // --- NAGY HAJÓK ---
        new Ship { Id = 15, Size = (ShipSize)3, FactinId = 0,  Name = "MC75 Armored Cruiser", Point = 104 },
        new Ship { Id = 16, Size = (ShipSize)3, FactinId = 0,  Name = "MC75 Ordnance Cruiser", Point = 100 },
        new Ship { Id = 17, Size = (ShipSize)3, FactinId = 0,  Name = "MC80 Assault Cruiser", Point = 114 },
        new Ship { Id = 18, Size = (ShipSize)3, FactinId = 0,  Name = "MC80 Command Cruiser", Point = 106 },
        new Ship { Id = 19, Size = (ShipSize)3, FactinId = 0,  Name = "MC80 Battle Cruiser", Point = 103 },
        new Ship { Id = 20, Size = (ShipSize)3, FactinId = 0,  Name = "MC80 Star Cruiser", Point = 96 },
        new Ship { Id = 21, Size = (ShipSize)3, FactinId = 0,  Name = "Starhawk-class Battleship Mark I", Point = 140 },
        new Ship { Id = 22, Size = (ShipSize)3, FactinId = 0, Name = "Starhawk-class Battleship Mark II", Point = 150 }
    );

    // 3. Hajó-kártya fejlesztési slotok
    modelBuilder.Entity<ShipCard>().HasData(
        // 1. GR-75 Medium Transports (Id: 1..5)
        new ShipCard { Id = 1, ShipId = 1, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 2, ShipId = 1, Category = CardCategory.Officer },
        new ShipCard { Id = 3, ShipId = 1, Category = CardCategory.FleetSupport },
        new ShipCard { Id = 4, ShipId = 1, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 5, ShipId = 1, Category = CardCategory.TitleRebel },

        // 2. GR-75 Combat Retrofits (Id: 6..10)
        new ShipCard { Id = 6, ShipId = 2, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 7, ShipId = 2, Category = CardCategory.Officer },
        new ShipCard { Id = 8, ShipId = 2, Category = CardCategory.FleetSupport },
        new ShipCard { Id = 9, ShipId = 2, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 10, ShipId = 2, Category = CardCategory.TitleRebel },

        // 3. CR90 Corvette A (Id: 11..15)
        new ShipCard { Id = 11, ShipId = 3, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 12, ShipId = 3, Category = CardCategory.Officer },
        new ShipCard { Id = 13, ShipId = 3, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 14, ShipId = 3, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 15, ShipId = 3, Category = CardCategory.TitleRebel },

        // 4. CR90 Corvette B (Id: 16..20)
        new ShipCard { Id = 16, ShipId = 4, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 17, ShipId = 4, Category = CardCategory.Officer },
        new ShipCard { Id = 18, ShipId = 4, Category = CardCategory.IonCannons },
        new ShipCard { Id = 19, ShipId = 4, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 20, ShipId = 4, Category = CardCategory.TitleRebel },

        // 5. Hammerhead Scout Corvette (Id: 21..27)
        new ShipCard { Id = 21, ShipId = 5, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 22, ShipId = 5, Category = CardCategory.Officer },
        new ShipCard { Id = 23, ShipId = 5, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 24, ShipId = 5, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 25, ShipId = 5, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 26, ShipId = 5, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 27, ShipId = 5, Category = CardCategory.TitleRebel },

        // 6. Hammerhead Torpedo Corvette (Id: 28..34)
        new ShipCard { Id = 28, ShipId = 6, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 29, ShipId = 6, Category = CardCategory.Officer },
        new ShipCard { Id = 30, ShipId = 6, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 31, ShipId = 6, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 32, ShipId = 6, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 33, ShipId = 6, Category = CardCategory.Ordnance },
        new ShipCard { Id = 34, ShipId = 6, Category = CardCategory.TitleRebel },

        // 7. MC30c Scout Torpedo Frigate (Id: 35..41)
        new ShipCard { Id = 35, ShipId = 7, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 36, ShipId = 7, Category = CardCategory.Officer },
        new ShipCard { Id = 37, ShipId = 7, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 38, ShipId = 7, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 39, ShipId = 7, Category = CardCategory.Ordnance },
        new ShipCard { Id = 40, ShipId = 7, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 41, ShipId = 7, Category = CardCategory.TitleRebel },

        // 8. MC30c Torpedo Frigate (Id: 42..48)
        new ShipCard { Id = 42, ShipId = 8, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 43, ShipId = 8, Category = CardCategory.Officer },
        new ShipCard { Id = 44, ShipId = 8, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 45, ShipId = 8, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 46, ShipId = 8, Category = CardCategory.Ordnance },
        new ShipCard { Id = 47, ShipId = 8, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 48, ShipId = 8, Category = CardCategory.TitleRebel },

        // 9. Nebulon-B Escort Frigate (Id: 49..53)
        new ShipCard { Id = 49, ShipId = 9, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 50, ShipId = 9, Category = CardCategory.Officer },
        new ShipCard { Id = 51, ShipId = 9, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 52, ShipId = 9, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 53, ShipId = 9, Category = CardCategory.TitleRebel },

        // 10. Nebulon-B Support Refit (Id: 54..58)
        new ShipCard { Id = 54, ShipId = 10, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 55, ShipId = 10, Category = CardCategory.Officer },
        new ShipCard { Id = 56, ShipId = 10, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 57, ShipId = 10, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 58, ShipId = 10, Category = CardCategory.TitleRebel },

        // 11. Pelta-class Assault Ship (Id: 59..64)
        new ShipCard { Id = 59, ShipId = 11, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 60, ShipId = 11, Category = CardCategory.Officer },
        new ShipCard { Id = 61, ShipId = 11, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 62, ShipId = 11, Category = CardCategory.FleetCommandOG },
        new ShipCard { Id = 63, ShipId = 11, Category = CardCategory.Ordnance },
        new ShipCard { Id = 64, ShipId = 11, Category = CardCategory.TitleRebel },

        // 12. Pelta-class Command Ship (Id: 65..70)
        new ShipCard { Id = 65, ShipId = 12, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 66, ShipId = 12, Category = CardCategory.Officer },
        new ShipCard { Id = 67, ShipId = 12, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 68, ShipId = 12, Category = CardCategory.FleetCommandOG },
        new ShipCard { Id = 69, ShipId = 12, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 70, ShipId = 12, Category = CardCategory.TitleRebel },

        // 13. Assault Frigate Mark II A (Id: 71..78)
        new ShipCard { Id = 71, ShipId = 13, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 72, ShipId = 13, Category = CardCategory.Officer },
        new ShipCard { Id = 73, ShipId = 13, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 74, ShipId = 13, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 75, ShipId = 13, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 76, ShipId = 13, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 77, ShipId = 13, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 78, ShipId = 13, Category = CardCategory.TitleRebel },

        // 14. Assault Frigate Mark II B (Id: 79..86)
        new ShipCard { Id = 79, ShipId = 14, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 80, ShipId = 14, Category = CardCategory.Officer },
        new ShipCard { Id = 81, ShipId = 14, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 82, ShipId = 14, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 83, ShipId = 14, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 84, ShipId = 14, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 85, ShipId = 14, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 86, ShipId = 14, Category = CardCategory.TitleRebel },

        // 15. MC75 Armored Cruiser (Id: 87..96)
        new ShipCard { Id = 87, ShipId = 15, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 88, ShipId = 15, Category = CardCategory.Officer },
        new ShipCard { Id = 89, ShipId = 15, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 90, ShipId = 15, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 91, ShipId = 15, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 92, ShipId = 15, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 93, ShipId = 15, Category = CardCategory.Ordnance },
        new ShipCard { Id = 94, ShipId = 15, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 95, ShipId = 15, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 96, ShipId = 15, Category = CardCategory.TitleRebel },

        // 16. MC75 Ordnance Cruiser (Id: 97..106)
        new ShipCard { Id = 97, ShipId = 16, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 98, ShipId = 16, Category = CardCategory.Officer },
        new ShipCard { Id = 99, ShipId = 16, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 100, ShipId = 16, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 101, ShipId = 16, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 102, ShipId = 16, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 103, ShipId = 16, Category = CardCategory.Ordnance },
        new ShipCard { Id = 104, ShipId = 16, Category = CardCategory.Ordnance },
        new ShipCard { Id = 105, ShipId = 16, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 106, ShipId = 16, Category = CardCategory.TitleRebel },

        // 17. MC80 Assault Cruiser (Id: 107..114)
        new ShipCard { Id = 107, ShipId = 17, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 108, ShipId = 17, Category = CardCategory.Officer },
        new ShipCard { Id = 109, ShipId = 17, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 110, ShipId = 17, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 111, ShipId = 17, Category = CardCategory.IonCannons },
        new ShipCard { Id = 112, ShipId = 17, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 113, ShipId = 17, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 114, ShipId = 17, Category = CardCategory.TitleRebel },

        // 18. MC80 Command Cruiser (Id: 115..122)
        new ShipCard { Id = 115, ShipId = 18, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 116, ShipId = 18, Category = CardCategory.Officer },
        new ShipCard { Id = 117, ShipId = 18, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 118, ShipId = 18, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 119, ShipId = 18, Category = CardCategory.IonCannons },
        new ShipCard { Id = 120, ShipId = 18, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 121, ShipId = 18, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 122, ShipId = 18, Category = CardCategory.TitleRebel },

        // 19. MC80 Battle Cruiser (Id: 123..130)
        new ShipCard { Id = 123, ShipId = 19, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 124, ShipId = 19, Category = CardCategory.Officer },
        new ShipCard { Id = 125, ShipId = 19, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 126, ShipId = 19, Category = CardCategory.IonCannons },
        new ShipCard { Id = 127, ShipId = 19, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 128, ShipId = 19, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 129, ShipId = 19, Category = CardCategory.TitleRebel },

        // 20. MC80 Star Cruiser (Id: 131..138)
        new ShipCard { Id = 131, ShipId = 20, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 132, ShipId = 20, Category = CardCategory.Officer },
        new ShipCard { Id = 133, ShipId = 20, Category = CardCategory.SupportTeam },
        new ShipCard { Id = 134, ShipId = 20, Category = CardCategory.IonCannons },
        new ShipCard { Id = 135, ShipId = 20, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 136, ShipId = 20, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 137, ShipId = 20, Category = CardCategory.TitleRebel },

        // 21. Starhawk-class Battleship Mark I (Id: 139..149)
        new ShipCard { Id = 139, ShipId = 21, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 140, ShipId = 21, Category = CardCategory.Officer },
        new ShipCard { Id = 141, ShipId = 21, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 142, ShipId = 21, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 143, ShipId = 21, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 144, ShipId = 21, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 145, ShipId = 21, Category = CardCategory.SuperweaponRebel },
        new ShipCard { Id = 146, ShipId = 21, Category = CardCategory.IonCannons },
        new ShipCard { Id = 147, ShipId = 21, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 148, ShipId = 21, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 149, ShipId = 21, Category = CardCategory.TitleRebel },

        // 22. Starhawk-class Battleship Mark II (Id: 150..160)
        new ShipCard { Id = 150, ShipId = 22, Category = CardCategory.CommanderRebel },
        new ShipCard { Id = 151, ShipId = 22, Category = CardCategory.Officer },
        new ShipCard { Id = 152, ShipId = 22, Category = CardCategory.WeapTeam },
        new ShipCard { Id = 153, ShipId = 22, Category = CardCategory.OffensiveRetrofit },
        new ShipCard { Id = 154, ShipId = 22, Category = CardCategory.WeaponsTeamAndOffensiveRetrofit },
        new ShipCard { Id = 155, ShipId = 22, Category = CardCategory.DefensiveRetrofitOG },
        new ShipCard { Id = 156, ShipId = 22, Category = CardCategory.SuperweaponRebel },
        new ShipCard { Id = 157, ShipId = 22, Category = CardCategory.IonCannons },
        new ShipCard { Id = 158, ShipId = 22, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 159, ShipId = 22, Category = CardCategory.Turbolasers },
        new ShipCard { Id = 160, ShipId = 22, Category = CardCategory.TitleRebel }
    );
