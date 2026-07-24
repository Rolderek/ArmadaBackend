namespace ArmadaBackend
{
    public class Squadrons
    {
        public Dictionary<string, (int Pont, string Leiras)> RebelSquadrons { get; set; }
        public Dictionary<string, (int Pont, string Leiras)> ImperialSquadrons { get; set; }
        public Dictionary<string, (int Pont, string Leiras)> GARSquadrons { get; set; }
        public Dictionary<string, (int Pont, string Leiras)> CISSquadrons { get; set; }

        public Squadrons(
            Dictionary<string, (int Pont, string Leiras)> R,
            Dictionary<string, (int Pont, string Leiras)> I,
            Dictionary<string, (int Pont, string Leiras)> G,
            Dictionary<string, (int Pont, string Leiras)> C )
        {
            RebelSquadrons = RebelsData;
            ImperialSquadrons = I;
            GARSquadrons= G;
            CISSquadrons = C;
        }

        //data:
        Dictionary<string, (int Pont, string Leiras)> RebelsData = new Dictionary<string, (int, string)>
        {
            { "A-wing Squadron", (11, "Counter 2, Swarm") },
            { "B-wing Squadron", (14, "Bomber, Heavy") },
            { "E-wing Squadron", (15, "Bomber, Snipe 3") },
            { "X-wing Squadron", (13, "Bomber, Escort") },
            { "Y-wing Squadron", (10, "Bomber, Heavy") },
            { "Z-95 Headhunter Squadron", (7, "Swarm") },
            { "HWK-290", (12, "Counter 1, Intel") },
            { "Lancer-class Pursuit Craft", (15, "Bomber, Grit, Rogue") },
            { "Scurrg H-6 Bomber", (16, "Bomber, Grit, Heavy") },
            { "VCX-100 Freighter", (15, "Heavy, Relay 1, Strategic") },
            { "YT-1300", (13, "Counter 1, Escort") },
            { "YT-2400", (16, "Rogue") },
            { "Luke Skywalker", (20, "Bomber, Escort. Amikor hajót támadsz, úgy kell tekinteni, mintha a védőnek nem lennének pajzsai.") },
            { "Wedge Antilles", (19, "Bomber, Escort. Amikor osztagot támadsz, ha a védő már aktiválódott ebben a körben, +1 kék kockát adhatsz a támadásodhoz.") },
            { "Biggs Darklighter", (19, "Bomber, Escort. Amikor egy másik baráti osztag 1-es távolságon belül védekezik, a támadónak téged kell célpontnak választania, ha lehetséges.") },
            { "Rogue Squadron", (14, "Bomber, Escort, Rogue.") },
            { "\"Dutch\" Vander", (16, "Bomber, Heavy. Miután hajót támadtál, választhatsz egy baráti Bomber osztagot 1-es távolságon belül. Az az osztag is támadhatja ugyanazt a hajót.") },
            { "Norra Wexley", (17, "Bomber. Amikor egy baráti Bomber osztag hajót támad 1-es távolságon belül, a védő elveszít 1 pajzsot a védekező hajótest-zónáról.") },
            { "Gold Squadron", (12, "Bomber, Heavy. (Nevesített Y-wing elit osztag alap statisztikákkal és speciális védekezési tokenekkel).") },
            { "Tycho Celchu", (16, "Counter 2. Nem akadályoz meg a mozgásban vagy a támadásban, ha ellenséges osztaggal állsz harcban (Engaged).") },
            { "Shara Bey", (17, "Counter 2, Swarm. Amikor védekezel, ha a támadó harcban áll (Engaged) egy másik baráti osztaggal, a támadó 1-gyel kevesebb kockával dob.") },
            { "Green Squadron", (12, "Counter 2, Swarm. (Nevesített A-wing elit osztag speciális védekezési tokenekkel).") },
            { "Keyan Farlander", (20, "Bomber. Amikor hajót támadsz, ha a védekező zónán nincs pajzs, megváltoztathatsz 1 kockát Hit/Crit eredményre.") },
            { "Ten Numb", (19, "Bomber. Amikor hajót támadsz, ha dobsz Critical ikont, a védő nem költhet el védekezési tokeneket.") },
            { "Dagger Squadron", (15, "Bomber, Swarm. (Nevesített B-wing elit osztag, a Heavy helyett Swarm kulcsszóval).") },
            { "Corran Horn", (22, "Bomber, Rogue, Snipe 3. Miután támadtál, mozoghatsz legfeljebb 1-es távolságra (ha nem vagy Engaged).") },
            { "Dash Rendar", (24, "Bomber, Rogue. Támadás során 1 tetszőleges kockát újradobhatsz.") },
            { "Han Solo", (26, "Grit, Rogue. Az Osztag Fázis (Squadron Phase) legelején aktiválódhatsz, mielőtt a normál aktivációk megkezdődnének.") },
            { "Hera Syndulla", (28, "Dodge, Grit. Legfeljebb két baráti osztag 1-2-es távolságon belül megkapja a Rogue kulcsszót.") },
            { "Jan Ors", (19, "Counter 1, Intel. Amikor egy baráti osztag védekezik 1-2-es távolságon belül, költhetsz védekezési tokent a nevében.") },
            { "Ketsu Onyo", (22, "Bomber, Grit, Rogue. Amikor osztagot támadsz, kiválaszthatod a védő 1 védekezési tokenjét; azt nem költheti el ebben a támadásban.") },
            { "Lando Calrissian", (23, "Grit, Rogue. Védekezés során eldobhatsz 1 védekezési tokent, hogy a támadó kénytelen legyen újradobni az általad választott kockáit.") },
            { "Lieutenant Blount", (14, "Swarm. Amikor támadsz, függetlenül attól, hogy van-e találat, a védő elszenved 1 sebzést.") },
            { "Malee Hurra", (26, "Bomber, Grit, Heavy. Amikor hajót támadsz és Crit ikont dobsz, nem okoz plusz sebzést, de eldobat 1 védekezési tokent a védőtől.") },
            { "Mart Mattin", (22, "Relay 1, Strategic. Amikor aktiválódsz, 1-2-es távolságon belül mozgathatsz egy akadályt (pl. aszteroidát) egy kis mértékben.") },
            { "Nym", (21, "Bomber, Grit, Heavy. Amikor hajót támadsz, a kék kockán lévő Crit ikonok kiosztanak 1 képpel felfelé fordított (faceup) sebzéskártyát a pajzsok helyett.") },
            { "Ezra Bridger", (17, "Bomber, Relay 1, Rogue. Ha egy akadály (Obstacle) 1-es távolságán belül vagy támadáskor, 1 kockát újradobhatsz.") }
        };
    }


}
