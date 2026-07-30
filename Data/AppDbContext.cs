using ArmadaBackend.Enums;
using ArmadaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ArmadaBackend.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<ShipCard> ShipCards { get; set; }
        public DbSet<FleetElement> FleetElements { get; set; }
        public DbSet<SquadronElement> SquadronElements { get; set; }
        public DbSet<ShipNameHolder> ShipNames { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Kártyák inicializálása (Data Seeding)
            modelBuilder.Entity<Card>().HasData(
                new Card { Id = 1, Category = (CardCategory)30, Name = @"Gunnery Team", Description = @"Can attack from the same hull zone twice...", Point = 7 },
                new Card { Id = 3, Category = (CardCategory)28, Name = @"DBY-827 Heavy Turbolasers", Description = @"While performing a Salvo attack, you may change 1 die to face a hit/crit ($\text{A}/\text{B}$) icon.", Point = 3 },
                new Card { Id = 4, Category = (CardCategory)28, Name = @"Dual Turbolaser Turrets", Description = @"While attacking, you may change 1 red die to face a hit ($\text{A}$) icon.", Point = 5 },
                new Card { Id = 5, Category = (CardCategory)28, Name = @"H9 Turbolasers", Description = @"While attacking, you may change 1 hit or crit icon to an accuracy icon.", Point = 8 },
                new Card { Id = 6, Category = (CardCategory)28, Name = @"Heavy Turbolaser Turrets", Description = @"While attacking a ship, if the defender uses the brace defense token, that token reduces the total damage by only 1 instead of halving it.", Point = 6 },
                new Card { Id = 7, Category = (CardCategory)28, Name = @"Linked Turbolaser Towers", Description = @"While attacking, you may reroll 1 red die. During your first anti-squadron attack each activation, you may add 1 red die to your attack pool.", Point = 7 },
                new Card { Id = 8, Category = (CardCategory)28, Name = @"Quad Battery Turrets", Description = @"While attacking a ship, if your current speed is less than the defender's current speed, you may add 1 blue die to your attack pool.", Point = 5 },
                new Card { Id = 9, Category = (CardCategory)28, Name = @"Quad Turbolaser Cannons", Description = @"While attacking a ship, if you have at least 1 accuracy icon, you may add 1 red die with a hit icon to your attack pool.", Point = 10 },
                new Card { Id = 10, Category = (CardCategory)28, Name = @"Slaved Turrets", Description = @"You cannot attack a ship more than once per activation. While attacking a ship, you may add 1 red die to your attack pool.", Point = 6 },
                new Card { Id = 11, Category = (CardCategory)28, Name = @"Spinal Armament", Description = @"While attacking a ship, if your attack originates from your forward or rear hull zone, you may add 1 red die to your attack pool.", Point = 9 },
                new Card { Id = 12, Category = (CardCategory)28, Name = @"Turbolaser Reroute Circuits", Description = @"During the attack step, you may spend 1 evade token to change 1 red die to a double-hit or crit icon.", Point = 7 },
                new Card { Id = 13, Category = (CardCategory)28, Name = @"XI7 Turbolasers", Description = @"While attacking a ship, the defender can resolve only 1 redirect token effect to redirect damage to another hull zone.", Point = 6 },
                new Card { Id = 14, Category = (CardCategory)28, Name = @"XX-9 Turbolasers", Description = @"While attacking a ship, if you deal a critical hit, the defender is dealt the first 2 damage cards of that attack faceup.", Point = 5 },
                new Card { Id = 15, Category = (CardCategory)19, Name = @"Assault Proton Torpedoes", Description = @"Black crit effect: Deal 1 faceup damage card to the defender before damage is resolved.", Point = 5 },
                new Card { Id = 16, Category = (CardCategory)19, Name = @"Concussion Missiles", Description = @"Black crit effect: The hull zone adjacent to the defending hull zone suffers 1 damage.", Point = 4 },
                new Card { Id = 17, Category = (CardCategory)19, Name = @"Expanded Launchers", Description = @"You may add 2 black dice to your forward battery armament.", Point = 13 },
                new Card { Id = 18, Category = (CardCategory)19, Name = @"External Racks", Description = @"While attacking a ship at close range, you may discard this card to add 2 black dice to your attack pool.", Point = 4 },
                new Card { Id = 19, Category = (CardCategory)19, Name = @"Flechette Torpedoes", Description = @"While attacking a squadron, if you roll a crit icon, flip the defender's activation slider.", Point = 3 },
                new Card { Id = 20, Category = (CardCategory)19, Name = @"Ordnance Pods", Description = @"Medium or large ship only. At the end of your attack step, you may exhaust this card and choose 1 of your hull zones. Then perform an attack from that hull zone with an anti-squadron armament of 1 black die.", Point = 3 },
                new Card { Id = 21, Category = (CardCategory)19, Name = @"Rapid Reload", Description = @"You may add 1 black die to your left and right battery armaments.", Point = 8 },
                new Card { Id = 22, Category = (CardCategory)19, Name = @"Wide-Area Barrage", Description = @"Black crit effect: Choose another enemy ship or squadron at distance 1 of the defender. It suffers damage equal to half of the total black hit icons in the attack pool, rounded up.", Point = 2 },
                new Card { Id = 23, Category = (CardCategory)10, Name = @"Heavy Ion Emplacements", Description = @"Blue crit effect: The defending hull zone and each adjacent hull zone lose 1 shield.", Point = 9 },
                new Card { Id = 24, Category = (CardCategory)10, Name = @"High-Capacity Ion Turbines", Description = @"You may add 1 blue die to your left and right battery armaments.", Point = 8 },
                new Card { Id = 25, Category = (CardCategory)10, Name = @"Ion Cannon Batteries", Description = @"Blue crit effect: The defender either loses 1 shield from the defending hull zone or discards 1 of its command tokens.", Point = 5 },
                new Card { Id = 26, Category = (CardCategory)10, Name = @"Leading Shots", Description = @"While attacking a ship, you may discard 1 blue die from your attack pool to reroll any number of your other dice.", Point = 6 },
                new Card { Id = 27, Category = (CardCategory)10, Name = @"MS-1 Ion Cannons", Description = @"Blue crit effect: Choose 1 upgrade card equipped to the defender; exhaust that card.", Point = 2 },
                new Card { Id = 28, Category = (CardCategory)10, Name = @"NK-7 Ion Cannons", Description = @"Blue crit effect: The defender must discard 1 defense token instead of exhausting it.", Point = 10 },
                new Card { Id = 29, Category = (CardCategory)10, Name = @"Overload Pulse", Description = @"Blue crit effect: Exhaust each of the defender's defense tokens.", Point = 8 },
                new Card { Id = 30, Category = (CardCategory)10, Name = @"SW-7 Ion Batteries", Description = @"While attacking, you may treat your blue accuracy icons as hit icons.", Point = 5 },
                new Card { Id = 31, Category = (CardCategory)14, Name = @"Damage Control Officer", Description = @"While defending, you can resolve a contain token to cancel standard critical effects.", Point = 5 },
                new Card { Id = 32, Category = (CardCategory)14, Name = @"Skilled First Officer", Description = @"During the Command Phase, you may discard this card to place your top command dial on the bottom of your command stack.", Point = 1 },
                new Card { Id = 33, Category = (CardCategory)14, Name = @"Flight Commander", Description = @"You may resolve a squadron command after your ship has moved instead of before it moves.", Point = 3 },
                new Card { Id = 34, Category = (CardCategory)14, Name = @"Support Officer", Description = @"During the Command Phase, you may discard this card to discard all of your command dials and replan.", Point = 4 },
                new Card { Id = 35, Category = (CardCategory)14, Name = @"Leia Organa", Description = @"While a friendly ship is spending a command token, it may treat that token as if it were a command dial.", Point = 3 },
                new Card { Id = 36, Category = (CardCategory)14, Name = @"Raymus Antilles", Description = @"When your ship resolves a command from its dial, it gains a matching command token.", Point = 7 },
                new Card { Id = 37, Category = (CardCategory)14, Name = @"Lando Calrissian", Description = @"While defending, you may discard this card to force the attacker to reroll all of their attack dice.", Point = 4 },
                new Card { Id = 38, Category = (CardCategory)14, Name = @"Toryn Farr", Description = @"While attacking at distance 1–3, friendly ships and squadrons may reroll 1 blue die.", Point = 7 },
                new Card { Id = 39, Category = (CardCategory)14, Name = @"Walex Blissex", Description = @"When your ship activates, you may discard this card to ready 1 of your exhausted defense tokens.", Point = 5 },
                new Card { Id = 40, Category = (CardCategory)16, Name = @"Captain Needa", Description = @"During the ship placement phase, you may replace 1 of your defense tokens with an evade token.", Point = 2 },
                new Card { Id = 41, Category = (CardCategory)16, Name = @"Minister Tua", Description = @"Your upgrade bar gains 1 defensive retrofit icon. Imperial ship only.", Point = 2 },
                new Card { Id = 42, Category = (CardCategory)16, Name = @"Captain Brunson", Description = @"While defending, you may exhaust this card and an obstacle at distance 1–2 to cancel 1 attack die.", Point = 5 },
                new Card { Id = 43, Category = (CardCategory)16, Name = @"Darth Vader (Officer)", Description = @"While attacking, you may discard another upgrade card equipped to this ship to reroll any number of attack dice.", Point = 3 },
                new Card { Id = 44, Category = (CardCategory)16, Name = @"Admiral Chiraneau", Description = @"While resolving a squadron command, you may choose up to 2 engaged friendly squadrons; those squadrons can move as if they were not engaged, but cannot attack.", Point = 10 },
                new Card { Id = 45, Category = (CardCategory)17, Name = @"Clone Captain Rex", Description = @"You may discard this card to allow a friendly ship at distance 1–5 (or your ship) to activate +1 squadron this round.", Point = 5 },
                new Card { Id = 46, Category = (CardCategory)17, Name = @"Clone Navigation Officer", Description = @"When you spend a navigate token, you may choose a friendly ship at distance 1–5; it gains a navigate token.", Point = 4 },
                new Card { Id = 47, Category = (CardCategory)17, Name = @"Admiral Yularen", Description = @"When you would spend a command token, you may exhaust this card to not discard that token.", Point = 2 },
                new Card { Id = 48, Category = (CardCategory)17, Name = @"Wat Tambor", Description = @"At the end of the ship placement phase, your left and right hull zones each gain 1 shield, up to their maximum values.", Point = 5 },
                new Card { Id = 49, Category = (CardCategory)18, Name = @"Rune Haako", Description = @"When another friendly ship at distance 1–5 reveals a command dial, you may gain a matching command token.", Point = 4 },
                new Card { Id = 50, Category = (CardCategory)18, Name = @"San Hill", Description = @"At the beginning of the Command Phase, you may gain 1 concentrate fire token.", Point = 3 },
                new Card { Id = 51, Category = (CardCategory)11, Name = @"Intel Officer", Description = @"While attacking, choose 1 defense token. If the defender spends that token during this attack, discard it instead of exhausting it.", Point = 7 },
                new Card { Id = 52, Category = (CardCategory)18, Name = @"Veteran Captain", Description = @"During the Command Phase, you may discard this card to gain 1 command token of your choice.", Point = 3 },
                new Card { Id = 53, Category = (CardCategory)18, Name = @"Strategic Adviser", Description = @"During setup, you gain a pass token. You may spend this token during the ship phase to pass your activation.", Point = 16 },
                new Card { Id = 54, Category = (CardCategory)18, Name = @"Hondo Ohnaka", Description = @"You may exhaust this card to gain 2 different command tokens. Then, choose an enemy ship at distance 1–5; it gains 1 of those tokens.", Point = 2 },
                new Card { Id = 55, Category = (CardCategory)18, Name = @"Adar Tallon", Description = @"After you resolve a squadron command, you may exhaust this card to ready 1 friendly squadron you activated.", Point = 10 },
                new Card { Id = 56, Category = (CardCategory)14, Name = @"Major Derlin", Description = @"When you suffer damage from an attack, reduce the total damage suffered by 1 to a minimum of 1. Once per round.", Point = 7 },
                new Card { Id = 57, Category = (CardCategory)14, Name = @"Ahsoka Tano", Description = @"During the Command Phase, you may discard 1 command token to change your top command dial to any other command.", Point = 2 },
                new Card { Id = 58, Category = (CardCategory)14, Name = @"Hera Syndulla (Officer)", Description = @"When you reveal a command dial, you may choose a command token you own. Treat that dial as if it were a matching command.", Point = 4 },
                new Card { Id = 59, Category = (CardCategory)14, Name = @"Jyn Erso", Description = @"While attacking a ship at distance 1–3, you may assign 1 raid token to the defender.", Point = 4 },
                new Card { Id = 60, Category = (CardCategory)16, Name = @"Admiral Titus", Description = @"At the start of the ship placement phase, you may choose an enemy ship and change its speed by 1 (to a minimum of 0 and a maximum of its max speed).", Point = 2 },
                new Card { Id = 61, Category = (CardCategory)16, Name = @"Agent Kallus", Description = @"While attacking a unique squadron, you may add 1 red or black die to your anti-squadron attack pool.", Point = 3 },
                new Card { Id = 62, Category = (CardCategory)16, Name = @"Captain Ozzel", Description = @"When you execute a navigate command, you may change your speed by up to 1 beyond the normal restrictions.", Point = 2 },
                new Card { Id = 63, Category = (CardCategory)18, Name = @"Instructor Goran", Description = @"Friendly non-heavy squadrons at distance 1–2 of your ship gain counter 1.", Point = 7 },
                new Card { Id = 64, Category = (CardCategory)16, Name = @"Director Isard", Description = @"At the start of the Command Phase, you may look at an enemy ship's command dials.", Point = 3 },
                new Card { Id = 65, Category = (CardCategory)16, Name = @"Wulff Yularen (Imperial)", Description = @"When you would spend a command token, you may exhaust this card to not discard that token.", Point = 7 },
                new Card { Id = 66, Category = (CardCategory)17, Name = @"Bail Organa (GAR)", Description = @"During the Command Phase, you may discard this card to give 1 command token of your choice to up to two other friendly ships at distance 1–5.", Point = 5 },
                new Card { Id = 67, Category = (CardCategory)17, Name = @"Clone Commander Wolffe", Description = @"While your ship is attacking, you may exhaust this card and discard 1 concentrate fire token to reroll up to 2 attack dice.", Point = 5 },
                new Card { Id = 68, Category = (CardCategory)17, Name = @"Aayla Secura", Description = @"Friendly squadrons at distance 1–3 of your ship force the attacker to reroll 1 attack die while defending.", Point = 5 },
                new Card { Id = 69, Category = (CardCategory)18, Name = @"T-Series Tactical Droid", Description = @"While spending a command token, you may treat that token as if it were a command dial.", Point = 4 },
                new Card { Id = 70, Category = (CardCategory)18, Name = @"Passel Argente", Description = @"When you resolve a command (from a dial or token), you may gain 1 command token of a type different from that command.", Point = 6 },
                new Card { Id = 71, Category = (CardCategory)18, Name = @"Tikkes", Description = @"When you reveal a command dial that matches the command dial you revealed during the previous round, you may gain a matching command token.", Point = 2 },
                new Card { Id = 72, Category = (CardCategory)18, Name = @"Poggle the Lesser", Description = @"While resolving a squadron command, 1 friendly squadron at distance 1–3 gains swarm until the end of the round.", Point = 3 },
                new Card { Id = 73, Category = (CardCategory)4, Name = @"Advanced Projectors", Description = @"While resolving a redirect token, you may distribute damage to any of your hull zones' shield tracks instead of just adjacent ones.", Point = 6 },
                new Card { Id = 74, Category = (CardCategory)4, Name = @"Electronic Countermeasures", Description = @"While defending, you may exhaust this card to resolve a defense token even if it has been targeted by an accuracy icon.", Point = 7 },
                new Card { Id = 75, Category = (CardCategory)4, Name = @"Early Warning System", Description = @"Choose 1 of your hull zones. Attacks targeting that hull zone are obstructed.", Point = 7 },
                new Card { Id = 76, Category = (CardCategory)4, Name = @"Redundant Shields", Description = @"During the Status Phase, you may recover 1 shield in any 1 hull zone.", Point = 8 },
                new Card { Id = 77, Category = (CardCategory)4, Name = @"Reinforced Blast Doors", Description = @"You may discard this card to remove up to 3 facedown damage cards from your ship.", Point = 5 },
                new Card { Id = 78, Category = (CardCategory)4, Name = @"Reactive Gunnery", Description = @"While defending, if you have a ready salvo token, you may discard another defense token to resolve a salvo attack as if you spent that salvo token.", Point = 4 },
                new Card { Id = 79, Category = (CardCategory)4, Name = @"Cluster Bombs", Description = @"While an enemy squadron attacks from distance 1, you may discard this card to roll 4 black dice against that squadron. Each hit deals 1 damage.", Point = 5 },
                new Card { Id = 80, Category = (CardCategory)11, Name = @"Expanded Hangar Bay", Description = @"Your squadron value is increased by 1.", Point = 5 },
                new Card { Id = 81, Category = (CardCategory)11, Name = @"Boosted Comms", Description = @"When you resolve a squadron command, you may choose squadrons at distance 1–long instead of distance 1–3.", Point = 4 },
                new Card { Id = 82, Category = (CardCategory)11, Name = @"Quad Laser Turrets", Description = @"Your ship gains counter 1.", Point = 5 },
                new Card { Id = 83, Category = (CardCategory)11, Name = @"Point-Defense Reroute", Description = @"While performing an anti-squadron attack, you may reroll all red and blue critical icons.", Point = 5 },
                new Card { Id = 84, Category = (CardCategory)11, Name = @"Phylon Q7 Tractor Beams", Description = @"When your ship activates, choose an enemy ship at distance 1–5. If your ship is a larger size class than that ship, it must either discard a navigate token or reduce its speed by 1.", Point = 6 },
                new Card { Id = 85, Category = (CardCategory)11, Name = @"Rapid Launch Bays", Description = @"During deployment, you may place up to your squadron value in squadrons inside your ship. When you resolve a squadron command, you may deploy those squadrons at distance 1 and activate them.", Point = 6 },
                new Card { Id = 86, Category = (CardCategory)11, Name = @"Hardened Bulkheads", Description = @"Medium or large ship only. While overlapping a smaller ship, your ship does not suffer damage from the overlap.", Point = 5 },
                new Card { Id = 87, Category = (CardCategory)11, Name = @"Reserve Hangar Deck", Description = @"When a friendly non-unique swarm squadron is destroyed, you may discard this card to place that squadron at distance 1 with 1 hull remaining.", Point = 3 },
                new Card { Id = 88, Category = (CardCategory)11, Name = @"Flak Guns", Description = @"While performing an anti-squadron attack, you may use black dice instead of your anti-squadron armament. You may spend salvo tokens during anti-squadron attacks.", Point = 3 },
                new Card { Id = 89, Category = (CardCategory)11, Name = @"Advanced Transponder Net", Description = @"Friendly non-heavy squadrons at distance 1–2 prevent enemy squadrons at distance 1 from attacking ships while engaged.", Point = 5 },
                new Card { Id = 90, Category = (CardCategory)11, Name = @"Proximity Mines", Description = @"During setup, you may place 2 mine tokens. Ships and squadrons that overlap or move through these tokens suffer damage.", Point = 4 },
                new Card { Id = 91, Category = (CardCategory)30, Name = @"Gunnery Team", Description = @"(Lásd az 1. sorszámú kártyát - duplikáció / javított verzió)", Point = 7 },
                new Card { Id = 92, Category = (CardCategory)30, Name = @"Ordnance Experts", Description = @"While attacking, you may reroll any number of black dice.", Point = 4 },
                new Card { Id = 93, Category = (CardCategory)30, Name = @"Flight Controllers", Description = @"While you resolve a squadron command, your activated squadrons add 1 blue die to their anti-squadron attack pools this round.", Point = 6 },
                new Card { Id = 94, Category = (CardCategory)30, Name = @"Veteran Gunners", Description = @"While attacking, you may exhaust this card to reroll your entire attack pool.", Point = 5 },
                new Card { Id = 95, Category = (CardCategory)30, Name = @"Fire-Control Team", Description = @"While attacking a ship, you may resolve up to two critical effects.", Point = 2 },
                new Card { Id = 96, Category = (CardCategory)30, Name = @"Sensor Team", Description = @"While attacking, you may exhaust this card and discard 1 die to change another die to an accuracy icon.", Point = 5 },
                new Card { Id = 97, Category = (CardCategory)30, Name = @"Ruthless Strategists", Description = @"While attacking a squadron, after the attack steps, you may inflict 1 damage on a friendly squadron engaged with the defender to inflict 1 damage on the defender.", Point = 4 },
                new Card { Id = 98, Category = (CardCategory)30, Name = @"Local Fire Control", Description = @"During the ship placement phase, you may replace 1 of your defense tokens with a salvo token.", Point = 4 },
                new Card { Id = 99, Category = (CardCategory)30, Name = @"Caitken and Shollan", Description = @"While attacking, you may exhaust this card to reroll any number of dice of a single color.", Point = 6 },
                new Card { Id = 100, Category = (CardCategory)30, Name = @"Weapon Battery Techs", Description = @"While attacking a ship, you may change 1 blue crit icon to an accuracy icon, OR you may exhaust this card to change 1 accuracy icon to a blue crit icon.", Point = 5 },
                new Card { Id = 101, Category = (CardCategory)6, Name = @"G7-X Grav Well Projector", Description = @"After fleets are deployed, you may place 1 grav well token. Enemy ships deployed at distance 1–3 of this token must begin the game at speed 0.", Point = 2 },
                new Card { Id = 102, Category = (CardCategory)6, Name = @"G8 Experimental Projector", Description = @"Before an enemy ship at distance 1–5 executes a maneuver, you may exhaust this card to change its speed by 1 for that maneuver.", Point = 8 },
                new Card { Id = 103, Category = (CardCategory)6, Name = @"Grav Shift Reroute", Description = @"Before round 1 begins, you may choose and move 1 obstacle up to distance 2.", Point = 2 },
                new Card { Id = 104, Category = (CardCategory)6, Name = @"Targeting Scrambler", Description = @"While a friendly ship at distance 1–3 is defending against an attack from close range, you may exhaust this card to force the attacker to reroll up to 4 attack dice.", Point = 5 },
                new Card { Id = 105, Category = (CardCategory)7, Name = @"All fighters, follow me!", Description = @"At the beginning of the Ship Phase, you may spend 1 squadron token. If you do, each friendly squadron at distance 1–5 increases its speed by 1 to its max speed this round.", Point = 5 },
                new Card { Id = 106, Category = (CardCategory)7, Name = @"Entrapment Formation!", Description = @"At the beginning of the Ship Phase, you may spend 1 navigate token. If you do, each friendly ship at distance 1–5 may increase or decrease its speed by 1 during its maneuver this round.", Point = 5 },
                new Card { Id = 107, Category = (CardCategory)7, Name = @"Intensify Firepower!", Description = @"At the beginning of the Ship Phase, you may spend 1 concentrate fire token. If you do, while attacking a ship at distance 1–5, friendly ships may change 1 die to a hit icon this round.", Point = 6 },
                new Card { Id = 108, Category = (CardCategory)7, Name = @"Shields to Maximum!", Description = @"At the beginning of the Ship Phase, you may spend 1 repair token. If you do, during the Status Phase, each friendly ship at distance 1–5 may recover 1 shield.", Point = 6 },
                new Card { Id = 109, Category = (CardCategory)7, Name = @"Take Evasive Action!", Description = @"At the beginning of the Ship Phase, you may spend 1 navigate token. If you do, each friendly ship at distance 1–5 gains 1 yaw at its final joint, to a maximum of 2.", Point = 6 },
                new Card { Id = 110, Category = (CardCategory)22, Name = @"Engineering Team", Description = @"While you resolve an engineering command, you may increase the number of engineering points available from your dial, then exhaust or discard this card.", Point = 5 },
                new Card { Id = 111, Category = (CardCategory)22, Name = @"Damage Control Teams", Description = @"At the end of the Status Phase, you may exhaust this card to remove 1 facedown damage card from your ship.", Point = 5 },
                new Card { Id = 112, Category = (CardCategory)22, Name = @"Medical Team", Description = @"When your ship activates, you may exhaust this card to prevent damage to your crew.", Point = 1 },
                new Card { Id = 113, Category = (CardCategory)22, Name = @"Comms Net", Description = @"During the Command Phase or when you activate, you may exhaust this card to give a command token to another friendly ship at distance 1–5.", Point = 2 },
                new Card { Id = 114, Category = (CardCategory)22, Name = @"Ammunition Experts", Description = @"While attacking, you may exhaust this card to change 1 black die to a hit icon after rolling black dice.", Point = 3 },
                new Card { Id = 115, Category = (CardCategory)22, Name = @"Auxiliary Shields Team", Description = @"During your maneuver or activation, you may exhaust this card to shift 1 shield from one of your hull zones to an adjacent hull zone.", Point = 3 },
                new Card { Id = 116, Category = (CardCategory)9, Name = @"Bomber Command Center", Description = @"While a friendly bomber at distance 1–5 attacks a ship, it may reroll 1 attack die.", Point = 8 },
                new Card { Id = 117, Category = (CardCategory)22, Name = @"Comms Net", Description = @"(Duplikáció / lásd a 113. sorszámot)", Point = 2 },
                new Card { Id = 118, Category = (CardCategory)9, Name = @"Jamming Field", Description = @"Friendly and enemy ships and squadrons at distance 1–2 of your ship treat attacks against squadrons as obstructed.", Point = 2 },
                new Card { Id = 119, Category = (CardCategory)9, Name = @"Repair Crews", Description = @"When you resolve an engineering command, instead of spending engineering points, you may discard 1 damage card from a friendly ship at distance 1–2 or recover 1 shield on it.", Point = 4 },
                new Card { Id = 120, Category = (CardCategory)9, Name = @"Slicer Tools", Description = @"After you execute a maneuver, you may exhaust this card to choose an enemy ship at distance 1–3 and change its top command dial to a command of your choice.", Point = 7 },
                new Card { Id = 121, Category = (CardCategory)9, Name = @"Munitions Resupply", Description = @"When you reveal a command dial, you may discard this card to give up to 5 friendly ships at distance 1–5 1 concentrate fire token.", Point = 3 },
                new Card { Id = 122, Category = (CardCategory)9, Name = @"Parts Resupply", Description = @"When you reveal a command dial, you may discard this card to give up to 5 friendly ships at distance 1–5 1 repair token.", Point = 3 },
                new Card { Id = 123, Category = (CardCategory)9, Name = @"Fighter Coordination Team", Description = @"After you execute a maneuver, you may exhaust this card to choose up to a number of friendly squadrons at distance 1–2 equal to your squadron value; those squadrons may each execute a distance 1 move.", Point = 3 },
                new Card { Id = 124, Category = (CardCategory)20, Name = @"Orbital Bombardment Particle Cannons", Description = @"Ignition [Close]. While attacking a ship from your ignition arc, each other ship and squadron at distance 1 of the defender suffers 1 damage.", Point = 5 },
                new Card { Id = 125, Category = (CardCategory)20, Name = @"Superheavy Composite Beam Turbolasers", Description = @"Ignition [Long]. While attacking a ship from your ignition arc, after defense tokens are spent, deal 1 damage to each hull zone (other than the defender's) that the line of sight passes through.", Point = 7 },
                new Card { Id = 126, Category = (CardCategory)0, Name = @"Admiral Ackbar", Description = @"While your ship is attacking with only its left or right hull zone during its activation, it may add 2 red dice to its attack pool.", Point = 38 },
                new Card { Id = 127, Category = (CardCategory)0, Name = @"General Dodonna", Description = @"Before an enemy ship receives a faceup damage card, you may draw 4 damage cards, choose 1 for it to receive, and place the rest on the bottom of the damage deck.", Point = 20 },
                new Card { Id = 128, Category = (CardCategory)0, Name = @"General Rieekan", Description = @"When a friendly ship or unique squadron is destroyed, it remains in play and can perform actions as normal until the end of the current round.", Point = 30 },
                new Card { Id = 129, Category = (CardCategory)0, Name = @"Mon Mothma", Description = @"Friendly ships and squadrons may spend evade tokens at medium range, and may reroll dice with evade tokens at close range.", Point = 27 },
                new Card { Id = 130, Category = (CardCategory)1, Name = @"Darth Vader (Commander)", Description = @"When a friendly ship is attacking, you may discard 1 shield from any of its hull zones to reroll any number of attack dice.", Point = 36 },
                new Card { Id = 131, Category = (CardCategory)1, Name = @"Grand Admiral Thrawn", Description = @"After deployment, place 3 facedown command dials on this card. During the Command Phase, you may reveal 1: each friendly ship gains a matching command dial this round.", Point = 32 },
                new Card { Id = 132, Category = (CardCategory)1, Name = @"Admiral Motti", Description = @"Each friendly ship's hull value is increased by 1 for small ships, 2 for medium ships, and 3 for large ships.", Point = 24 },
                new Card { Id = 133, Category = (CardCategory)1, Name = @"Admiral Screed", Description = @"While attacking, each friendly ship may, once per round, discard 1 die to change another die to a face with a crit icon.", Point = 26 },
                new Card { Id = 134, Category = (CardCategory)2, Name = @"Obi-Wan Kenobi", Description = @"While a friendly ship is defending, when it spends a defense token, it reduces the total damage suffered by 1 (once per round).", Point = 28 },
                new Card { Id = 135, Category = (CardCategory)3, Name = @"Count Dooku", Description = @"After deployment, choose 3 command tokens. When an enemy ship spends a matching token, deal 1 damage to it.", Point = 30 },
                new Card { Id = 136, Category = (CardCategory)25, Name = @"Demolisher (Gladiator-class)", Description = @"Your ship may perform 1 of its attacks after it executes its maneuver.", Point = 10 },
                new Card { Id = 137, Category = (CardCategory)25, Name = @"Avenger (Imperial Star Destroyer)", Description = @"While attacking, the defender cannot spend defense tokens that are already exhausted.", Point = 5 },
                new Card { Id = 138, Category = (CardCategory)25, Name = @"Relentless (Imperial Star Destroyer)", Description = @"Your ship's command value is reduced by 1.", Point = 3 },
                new Card { Id = 139, Category = (CardCategory)24, Name = @"Yavaris (Nebulon-B)", Description = @"While you resolve a squadron command, activated squadrons that do not move may attack twice.", Point = 5 },
                new Card { Id = 140, Category = (CardCategory)24, Name = @"Home One (MC80 Star Cruiser)", Description = @"While a friendly ship at distance 1–5 is attacking, it may change 1 accuracy icon to a hit icon.", Point = 7 },
                new Card { Id = 141, Category = (CardCategory)24, Name = @"Dodonna's Pride (CR90 Corvette)", Description = @"When you resolve a blue crit effect, instead of resolving its normal effect, the defender is dealt 1 faceup damage card.", Point = 6 },
                new Card { Id = 142, Category = (CardCategory)26, Name = @"Resolute (Venator-class)", Description = @"When a friendly ship at distance 1–5 would suffer damage, you may redirect 1 damage to the Resolute.", Point = 6 },
                new Card { Id = 143, Category = (CardCategory)27, Name = @"Invisible Hand (Providence-class)", Description = @"You may deploy extra squadrons during setup and deploy them later in the game.", Point = 9 },
                new Card { Id = 144, Category = (CardCategory)31, Name = @"Boarding Troopers", Description = @"While at distance 1 of an enemy ship, you may exhaust this card to exhaust a number of the defender's defense tokens equal to your squadron value.", Point = 3 },
                new Card { Id = 145, Category = (CardCategory)31, Name = @"Boarding Engineers", Description = @"While at distance 1 of an enemy ship, you may exhaust this card to flip a number of the defender's facedown damage cards faceup equal to half your engineering value, rounded up.", Point = 2 },
                new Card { Id = 146, Category = (CardCategory)31, Name = @"Darth Vader (Boarding Team)", Description = @"While at distance 1 of an enemy ship, you may discard this card to choose and discard an upgrade card (other than a commander) equipped to the defender.", Point = 3 },
                new Card { Id = 147, Category = (CardCategory)31, Name = @"Jyn Erso (Boarding Team)", Description = @"While at distance 1 of an enemy ship, you may discard this card to deal 2 faceup damage cards to the defender before the attack is resolved.", Point = 4 },
                new Card { Id = 148, Category = (CardCategory)31, Name = @"Cham Syndulla (Boarding Team)", Description = @"While at distance 1 of an enemy ship, you may discard this card to look at the defender's command dials and change its top dial to a command of your choice.", Point = 5 },
                new Card { Id = 149, Category = (CardCategory)31, Name = @"Shriv Suurgav (Boarding Team)", Description = @"While at distance 1 of an enemy ship, you may discard this card to choose and discard a weapons team or offensive retrofit upgrade card equipped to the defender.", Point = 6 },
                new Card { Id = 150, Category = (CardCategory)0, Name = @"Commander Sato", Description = @"While attacking a ship, if a friendly squadron is at distance 1 of the target, you may replace up to 2 attack dice with dice of any color.", Point = 32 },
                new Card { Id = 151, Category = (CardCategory)0, Name = @"General Madine", Description = @"When you resolve a navigate command (from a dial or token), your ship gains 1 extra yaw at one of its pivot points.", Point = 30 },
                new Card { Id = 152, Category = (CardCategory)0, Name = @"Garm Bel Iblis", Description = @"During the Command Phase of rounds 1 and 5, each friendly ship gains command tokens up to its maximum capacity.", Point = 25 },
                new Card { Id = 153, Category = (CardCategory)0, Name = @"Admiral Raddus", Description = @"During setup, choose a friendly ship and set it aside. Later in the game, at the start of a command phase, it may enter play at distance 1 of another friendly ship.", Point = 26 },
                new Card { Id = 154, Category = (CardCategory)1, Name = @"Grand Moff Tarkin", Description = @"At the beginning of the Command Phase, you may assign 1 command token of the same type to each friendly ship in your fleet.", Point = 38 },
                new Card { Id = 155, Category = (CardCategory)1, Name = @"Emperor Palpatine", Description = @"After deployment, choose 1 defense token type. When an enemy ship spends a token of that type, it must discard it instead of exhausting it unless it spends another token.", Point = 35 },
                new Card { Id = 156, Category = (CardCategory)1, Name = @"Admiral Sloane", Description = @"While friendly squadrons attack ships, they may use accuracy icons to exhaust the defender's defense tokens and deal bonus damage.", Point = 24 },
                new Card { Id = 157, Category = (CardCategory)1, Name = @"Admiral Ozzel", Description = @"When a friendly ship uses a navigate token to modify its speed, it may increase or decrease its speed by 2 instead of 1 (to a minimum and maximum speed).", Point = 20 },
                new Card { Id = 158, Category = (CardCategory)1, Name = @"Moff Jerjerrod", Description = @"During your ship's maneuver, it may suffer 1 damage to change its yaw by 1 at the current speed step.", Point = 23 },
                new Card { Id = 159, Category = (CardCategory)2, Name = @"Luminara Unduli", Description = @"While your ships are defending, defense tokens targeted by accuracy icons can still be resolved, but must be discarded if used.", Point = 25 },
                new Card { Id = 160, Category = (CardCategory)2, Name = @"Anakin Skywalker (Commander)", Description = @"At the beginning of the Ship Phase, each friendly ship may spend 1 command token to trigger a special effect regardless of its dial.", Point = 29 },
                new Card { Id = 161, Category = (CardCategory)2, Name = @"Plo Koon", Description = @"At the beginning of the command phase, you may heal friendly squadrons or grant them escort until the end of the round.", Point = 26 },
                new Card { Id = 162, Category = (CardCategory)3, Name = @"Mar Tuuk", Description = @"While attacking a ship, if the defender's command value is less than yours, you may add 1 red die to your attack pool.", Point = 28 },
                new Card { Id = 163, Category = (CardCategory)3, Name = @"Kraken", Description = @"While attacking, you may reroll 1 die if another friendly ship at distance 1–3 threatens the target.", Point = 26 },
                new Card { Id = 164, Category = (CardCategory)3, Name = @"TF-1726", Description = @"While attacking, you may add a bonus die of any color for each raid token on the defending ship.", Point = 26 }
            );

            // 2. Hajók inicializálása
            modelBuilder.Entity<Ship>().HasData(
                // --- FLOTILLÁK ---
                new Ship { Id = 1, Name = "GR-75 Medium Transports", Point = 18 },
                new Ship { Id = 2, Name = "GR-75 Combat Retrofits", Point = 24 },

                // --- KIS HAJÓK ---
                new Ship { Id = 3, Name = "CR90 Corvette A", Point = 44 },
                new Ship { Id = 4, Name = "CR90 Corvette B", Point = 39 },
                new Ship { Id = 5, Name = "Hammerhead Scout Corvette", Point = 41 },
                new Ship { Id = 6, Name = "Hammerhead Torpedo Corvette", Point = 36 },
                new Ship { Id = 7, Name = "MC30c Scout Torpedo Frigate", Point = 69 },
                new Ship { Id = 8, Name = "MC30c Torpedo Frigate", Point = 63 },
                new Ship { Id = 9, Name = "Nebulon-B Escort Frigate", Point = 57 },
                new Ship { Id = 10, Name = "Nebulon-B Support Refit", Point = 51 },
                new Ship { Id = 11, Name = "Pelta-class Assault Ship", Point = 56 },
                new Ship { Id = 12, Name = "Pelta-class Command Ship", Point = 60 },

                // --- KÖZEPES HAJÓK ---
                new Ship { Id = 13, Name = "Assault Frigate Mark II A", Point = 81 },
                new Ship { Id = 14, Name = "Assault Frigate Mark II B", Point = 72 },

                // --- NAGY HAJÓK ---
                new Ship { Id = 15, Name = "MC75 Armored Cruiser", Point = 104 },
                new Ship { Id = 16, Name = "MC75 Ordnance Cruiser", Point = 100 },
                new Ship { Id = 17, Name = "MC80 Assault Cruiser", Point = 114 },
                new Ship { Id = 18, Name = "MC80 Command Cruiser", Point = 106 },
                new Ship { Id = 19, Name = "MC80 Battle Cruiser", Point = 103 },
                new Ship { Id = 20, Name = "MC80 Star Cruiser", Point = 96 },
                new Ship { Id = 21, Name = "Starhawk-class Battleship Mark I", Point = 140 },
                new Ship { Id = 22, Name = "Starhawk-class Battleship Mark II", Point = 150 }
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
        }
    }
}