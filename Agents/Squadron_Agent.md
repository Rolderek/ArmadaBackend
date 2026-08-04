# Squadron_Agent.md

# Feladat
- A példa soztály alapján hozz létre a Atar Wars armada squadron kártyákat az AppDbContext.cs osztályban, azon belül az 'OnModelCreating' metódusban, hasonlóan mint a hajók és a fejlesztéskártyák vannak.
- Javaslattétel a struktúra javítására, ha szükséges.

# Elvárt eredmény
- Squadron kártyák reprezentálása a példa osztály szereint.
- Javaslat, javaslatok egy 'Javaslat.txt' file-ba összeírva az alapkönyvtárban

# Projekt
- Csak azt használd ami a projektben van, semmi új nugetpackage-t vagy más függőséget ne adj hozzá.


# Munkavégzési szabályok
- Csak a szükséges file-okat módosítsd, más adathoz kódhoz ne nyúlj.


# Példa osztály

'namespace ArmadaBackend.Models
{
    //a listában egy squadront reprezentál, ennek lesz egy összefogó listája a flottában
    public class SquadronElement
    {
        public int Id { get; set; }
        public string SquadronName { get; set; } = string.Empty;
        public int Count { get; set; }

        //kapcsolatok:
        public int FleetId { get; set; }
        public Fleet? Fleet { get; set; }
    }
}'
