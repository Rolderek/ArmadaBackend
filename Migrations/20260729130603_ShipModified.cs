using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class ShipModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardsType",
                table: "Ships");

            migrationBuilder.CreateTable(
                name: "ShipCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipCard_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            /*
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Category", "Description", "FleetElementId", "Name", "Point" },
                values: new object[,]
                {
                    { 1, 30, "Can attack from the same hull zone twice...", null, "Gunnery Team", 7 },
                    { 3, 28, "While performing a Salvo attack, you may change 1 die to face a hit/crit ($\\text{A}/\\text{B}$) icon.", null, "DBY-827 Heavy Turbolasers", 3 },
                    { 4, 28, "While attacking, you may change 1 red die to face a hit ($\\text{A}$) icon.", null, "Dual Turbolaser Turrets", 5 },
                    { 5, 28, "While attacking, you may change 1 hit or crit icon to an accuracy icon.", null, "H9 Turbolasers", 8 },
                    { 6, 28, "While attacking a ship, if the defender uses the brace defense token, that token reduces the total damage by only 1 instead of halving it.", null, "Heavy Turbolaser Turrets", 6 },
                    { 7, 28, "While attacking, you may reroll 1 red die. During your first anti-squadron attack each activation, you may add 1 red die to your attack pool.", null, "Linked Turbolaser Towers", 7 },
                    { 8, 28, "While attacking a ship, if your current speed is less than the defender's current speed, you may add 1 blue die to your attack pool.", null, "Quad Battery Turrets", 5 },
                    { 9, 28, "While attacking a ship, if you have at least 1 accuracy icon, you may add 1 red die with a hit icon to your attack pool.", null, "Quad Turbolaser Cannons", 10 },
                    { 10, 28, "You cannot attack a ship more than once per activation. While attacking a ship, you may add 1 red die to your attack pool.", null, "Slaved Turrets", 6 },
                    { 11, 28, "While attacking a ship, if your attack originates from your forward or rear hull zone, you may add 1 red die to your attack pool.", null, "Spinal Armament", 9 },
                    { 12, 28, "During the attack step, you may spend 1 evade token to change 1 red die to a double-hit or crit icon.", null, "Turbolaser Reroute Circuits", 7 },
                    { 13, 28, "While attacking a ship, the defender can resolve only 1 redirect token effect to redirect damage to another hull zone.", null, "XI7 Turbolasers", 6 },
                    { 14, 28, "While attacking a ship, if you deal a critical hit, the defender is dealt the first 2 damage cards of that attack faceup.", null, "XX-9 Turbolasers", 5 },
                    { 15, 19, "Black crit effect: Deal 1 faceup damage card to the defender before damage is resolved.", null, "Assault Proton Torpedoes", 5 },
                    { 16, 19, "Black crit effect: The hull zone adjacent to the defending hull zone suffers 1 damage.", null, "Concussion Missiles", 4 },
                    { 17, 19, "You may add 2 black dice to your forward battery armament.", null, "Expanded Launchers", 13 },
                    { 18, 19, "While attacking a ship at close range, you may discard this card to add 2 black dice to your attack pool.", null, "External Racks", 4 },
                    { 19, 19, "While attacking a squadron, if you roll a crit icon, flip the defender's activation slider.", null, "Flechette Torpedoes", 3 },
                    { 20, 19, "Medium or large ship only. At the end of your attack step, you may exhaust this card and choose 1 of your hull zones. Then perform an attack from that hull zone with an anti-squadron armament of 1 black die.", null, "Ordnance Pods", 3 },
                    { 21, 19, "You may add 1 black die to your left and right battery armaments.", null, "Rapid Reload", 8 },
                    { 22, 19, "Black crit effect: Choose another enemy ship or squadron at distance 1 of the defender. It suffers damage equal to half of the total black hit icons in the attack pool, rounded up.", null, "Wide-Area Barrage", 2 },
                    { 23, 10, "Blue crit effect: The defending hull zone and each adjacent hull zone lose 1 shield.", null, "Heavy Ion Emplacements", 9 },
                    { 24, 10, "You may add 1 blue die to your left and right battery armaments.", null, "High-Capacity Ion Turbines", 8 },
                    { 25, 10, "Blue crit effect: The defender either loses 1 shield from the defending hull zone or discards 1 of its command tokens.", null, "Ion Cannon Batteries", 5 },
                    { 26, 10, "While attacking a ship, you may discard 1 blue die from your attack pool to reroll any number of your other dice.", null, "Leading Shots", 6 },
                    { 27, 10, "Blue crit effect: Choose 1 upgrade card equipped to the defender; exhaust that card.", null, "MS-1 Ion Cannons", 2 },
                    { 28, 10, "Blue crit effect: The defender must discard 1 defense token instead of exhausting it.", null, "NK-7 Ion Cannons", 10 },
                    { 29, 10, "Blue crit effect: Exhaust each of the defender's defense tokens.", null, "Overload Pulse", 8 },
                    { 30, 10, "While attacking, you may treat your blue accuracy icons as hit icons.", null, "SW-7 Ion Batteries", 5 },
                    { 31, 14, "While defending, you can resolve a contain token to cancel standard critical effects.", null, "Damage Control Officer", 5 },
                    { 32, 14, "During the Command Phase, you may discard this card to place your top command dial on the bottom of your command stack.", null, "Skilled First Officer", 1 },
                    { 33, 14, "You may resolve a squadron command after your ship has moved instead of before it moves.", null, "Flight Commander", 3 },
                    { 34, 14, "During the Command Phase, you may discard this card to discard all of your command dials and replan.", null, "Support Officer", 4 },
                    { 35, 14, "While a friendly ship is spending a command token, it may treat that token as if it were a command dial.", null, "Leia Organa", 3 },
                    { 36, 14, "When your ship resolves a command from its dial, it gains a matching command token.", null, "Raymus Antilles", 7 },
                    { 37, 14, "While defending, you may discard this card to force the attacker to reroll all of their attack dice.", null, "Lando Calrissian", 4 },
                    { 38, 14, "While attacking at distance 1–3, friendly ships and squadrons may reroll 1 blue die.", null, "Toryn Farr", 7 },
                    { 39, 14, "When your ship activates, you may discard this card to ready 1 of your exhausted defense tokens.", null, "Walex Blissex", 5 },
                    { 40, 16, "During the ship placement phase, you may replace 1 of your defense tokens with an evade token.", null, "Captain Needa", 2 },
                    { 41, 16, "Your upgrade bar gains 1 defensive retrofit icon. Imperial ship only.", null, "Minister Tua", 2 },
                    { 42, 16, "While defending, you may exhaust this card and an obstacle at distance 1–2 to cancel 1 attack die.", null, "Captain Brunson", 5 },
                    { 43, 16, "While attacking, you may discard another upgrade card equipped to this ship to reroll any number of attack dice.", null, "Darth Vader (Officer)", 3 },
                    { 44, 16, "While resolving a squadron command, you may choose up to 2 engaged friendly squadrons; those squadrons can move as if they were not engaged, but cannot attack.", null, "Admiral Chiraneau", 10 },
                    { 45, 17, "You may discard this card to allow a friendly ship at distance 1–5 (or your ship) to activate +1 squadron this round.", null, "Clone Captain Rex", 5 },
                    { 46, 17, "When you spend a navigate token, you may choose a friendly ship at distance 1–5; it gains a navigate token.", null, "Clone Navigation Officer", 4 },
                    { 47, 17, "When you would spend a command token, you may exhaust this card to not discard that token.", null, "Admiral Yularen", 2 },
                    { 48, 17, "At the end of the ship placement phase, your left and right hull zones each gain 1 shield, up to their maximum values.", null, "Wat Tambor", 5 },
                    { 49, 18, "When another friendly ship at distance 1–5 reveals a command dial, you may gain a matching command token.", null, "Rune Haako", 4 },
                    { 50, 18, "At the beginning of the Command Phase, you may gain 1 concentrate fire token.", null, "San Hill", 3 },
                    { 51, 11, "While attacking, choose 1 defense token. If the defender spends that token during this attack, discard it instead of exhausting it.", null, "Intel Officer", 7 },
                    { 52, 18, "During the Command Phase, you may discard this card to gain 1 command token of your choice.", null, "Veteran Captain", 3 },
                    { 53, 18, "During setup, you gain a pass token. You may spend this token during the ship phase to pass your activation.", null, "Strategic Adviser", 16 },
                    { 54, 18, "You may exhaust this card to gain 2 different command tokens. Then, choose an enemy ship at distance 1–5; it gains 1 of those tokens.", null, "Hondo Ohnaka", 2 },
                    { 55, 18, "After you resolve a squadron command, you may exhaust this card to ready 1 friendly squadron you activated.", null, "Adar Tallon", 10 },
                    { 56, 14, "When you suffer damage from an attack, reduce the total damage suffered by 1 to a minimum of 1. Once per round.", null, "Major Derlin", 7 },
                    { 57, 14, "During the Command Phase, you may discard 1 command token to change your top command dial to any other command.", null, "Ahsoka Tano", 2 },
                    { 58, 14, "When you reveal a command dial, you may choose a command token you own. Treat that dial as if it were a matching command.", null, "Hera Syndulla (Officer)", 4 },
                    { 59, 14, "While attacking a ship at distance 1–3, you may assign 1 raid token to the defender.", null, "Jyn Erso", 4 },
                    { 60, 16, "At the start of the ship placement phase, you may choose an enemy ship and change its speed by 1 (to a minimum of 0 and a maximum of its max speed).", null, "Admiral Titus", 2 },
                    { 61, 16, "While attacking a unique squadron, you may add 1 red or black die to your anti-squadron attack pool.", null, "Agent Kallus", 3 },
                    { 62, 16, "When you execute a navigate command, you may change your speed by up to 1 beyond the normal restrictions.", null, "Captain Ozzel", 2 },
                    { 63, 18, "Friendly non-heavy squadrons at distance 1–2 of your ship gain counter 1.", null, "Instructor Goran", 7 },
                    { 64, 16, "At the start of the Command Phase, you may look at an enemy ship's command dials.", null, "Director Isard", 3 },
                    { 65, 16, "When you would spend a command token, you may exhaust this card to not discard that token.", null, "Wulff Yularen (Imperial)", 7 },
                    { 66, 17, "During the Command Phase, you may discard this card to give 1 command token of your choice to up to two other friendly ships at distance 1–5.", null, "Bail Organa (GAR)", 5 },
                    { 67, 17, "While your ship is attacking, you may exhaust this card and discard 1 concentrate fire token to reroll up to 2 attack dice.", null, "Clone Commander Wolffe", 5 },
                    { 68, 17, "Friendly squadrons at distance 1–3 of your ship force the attacker to reroll 1 attack die while defending.", null, "Aayla Secura", 5 },
                    { 69, 18, "While spending a command token, you may treat that token as if it were a command dial.", null, "T-Series Tactical Droid", 4 },
                    { 70, 18, "When you resolve a command (from a dial or token), you may gain 1 command token of a type different from that command.", null, "Passel Argente", 6 },
                    { 71, 18, "When you reveal a command dial that matches the command dial you revealed during the previous round, you may gain a matching command token.", null, "Tikkes", 2 },
                    { 72, 18, "While resolving a squadron command, 1 friendly squadron at distance 1–3 gains swarm until the end of the round.", null, "Poggle the Lesser", 3 },
                    { 73, 4, "While resolving a redirect token, you may distribute damage to any of your hull zones' shield tracks instead of just adjacent ones.", null, "Advanced Projectors", 6 },
                    { 74, 4, "While defending, you may exhaust this card to resolve a defense token even if it has been targeted by an accuracy icon.", null, "Electronic Countermeasures", 7 },
                    { 75, 4, "Choose 1 of your hull zones. Attacks targeting that hull zone are obstructed.", null, "Early Warning System", 7 },
                    { 76, 4, "During the Status Phase, you may recover 1 shield in any 1 hull zone.", null, "Redundant Shields", 8 },
                    { 77, 4, "You may discard this card to remove up to 3 facedown damage cards from your ship.", null, "Reinforced Blast Doors", 5 },
                    { 78, 4, "While defending, if you have a ready salvo token, you may discard another defense token to resolve a salvo attack as if you spent that salvo token.", null, "Reactive Gunnery", 4 },
                    { 79, 4, "While an enemy squadron attacks from distance 1, you may discard this card to roll 4 black dice against that squadron. Each hit deals 1 damage.", null, "Cluster Bombs", 5 },
                    { 80, 11, "Your squadron value is increased by 1.", null, "Expanded Hangar Bay", 5 },
                    { 81, 11, "When you resolve a squadron command, you may choose squadrons at distance 1–long instead of distance 1–3.", null, "Boosted Comms", 4 },
                    { 82, 11, "Your ship gains counter 1.", null, "Quad Laser Turrets", 5 },
                    { 83, 11, "While performing an anti-squadron attack, you may reroll all red and blue critical icons.", null, "Point-Defense Reroute", 5 },
                    { 84, 11, "When your ship activates, choose an enemy ship at distance 1–5. If your ship is a larger size class than that ship, it must either discard a navigate token or reduce its speed by 1.", null, "Phylon Q7 Tractor Beams", 6 },
                    { 85, 11, "During deployment, you may place up to your squadron value in squadrons inside your ship. When you resolve a squadron command, you may deploy those squadrons at distance 1 and activate them.", null, "Rapid Launch Bays", 6 },
                    { 86, 11, "Medium or large ship only. While overlapping a smaller ship, your ship does not suffer damage from the overlap.", null, "Hardened Bulkheads", 5 },
                    { 87, 11, "When a friendly non-unique swarm squadron is destroyed, you may discard this card to place that squadron at distance 1 with 1 hull remaining.", null, "Reserve Hangar Deck", 3 },
                    { 88, 11, "While performing an anti-squadron attack, you may use black dice instead of your anti-squadron armament. You may spend salvo tokens during anti-squadron attacks.", null, "Flak Guns", 3 },
                    { 89, 11, "Friendly non-heavy squadrons at distance 1–2 prevent enemy squadrons at distance 1 from attacking ships while engaged.", null, "Advanced Transponder Net", 5 },
                    { 90, 11, "During setup, you may place 2 mine tokens. Ships and squadrons that overlap or move through these tokens suffer damage.", null, "Proximity Mines", 4 },
                    { 91, 30, "(Lásd az 1. sorszámú kártyát - duplikáció / javított verzió)", null, "Gunnery Team", 7 },
                    { 92, 30, "While attacking, you may reroll any number of black dice.", null, "Ordnance Experts", 4 },
                    { 93, 30, "While you resolve a squadron command, your activated squadrons add 1 blue die to their anti-squadron attack pools this round.", null, "Flight Controllers", 6 },
                    { 94, 30, "While attacking, you may exhaust this card to reroll your entire attack pool.", null, "Veteran Gunners", 5 },
                    { 95, 30, "While attacking a ship, you may resolve up to two critical effects.", null, "Fire-Control Team", 2 },
                    { 96, 30, "While attacking, you may exhaust this card and discard 1 die to change another die to an accuracy icon.", null, "Sensor Team", 5 },
                    { 97, 30, "While attacking a squadron, after the attack steps, you may inflict 1 damage on a friendly squadron engaged with the defender to inflict 1 damage on the defender.", null, "Ruthless Strategists", 4 },
                    { 98, 30, "During the ship placement phase, you may replace 1 of your defense tokens with a salvo token.", null, "Local Fire Control", 4 },
                    { 99, 30, "While attacking, you may exhaust this card to reroll any number of dice of a single color.", null, "Caitken and Shollan", 6 },
                    { 100, 30, "While attacking a ship, you may change 1 blue crit icon to an accuracy icon, OR you may exhaust this card to change 1 accuracy icon to a blue crit icon.", null, "Weapon Battery Techs", 5 },
                    { 101, 6, "After fleets are deployed, you may place 1 grav well token. Enemy ships deployed at distance 1–3 of this token must begin the game at speed 0.", null, "G7-X Grav Well Projector", 2 },
                    { 102, 6, "Before an enemy ship at distance 1–5 executes a maneuver, you may exhaust this card to change its speed by 1 for that maneuver.", null, "G8 Experimental Projector", 8 },
                    { 103, 6, "Before round 1 begins, you may choose and move 1 obstacle up to distance 2.", null, "Grav Shift Reroute", 2 },
                    { 104, 6, "While a friendly ship at distance 1–3 is defending against an attack from close range, you may exhaust this card to force the attacker to reroll up to 4 attack dice.", null, "Targeting Scrambler", 5 },
                    { 105, 7, "At the beginning of the Ship Phase, you may spend 1 squadron token. If you do, each friendly squadron at distance 1–5 increases its speed by 1 to its max speed this round.", null, "All fighters, follow me!", 5 },
                    { 106, 7, "At the beginning of the Ship Phase, you may spend 1 navigate token. If you do, each friendly ship at distance 1–5 may increase or decrease its speed by 1 during its maneuver this round.", null, "Entrapment Formation!", 5 },
                    { 107, 7, "At the beginning of the Ship Phase, you may spend 1 concentrate fire token. If you do, while attacking a ship at distance 1–5, friendly ships may change 1 die to a hit icon this round.", null, "Intensify Firepower!", 6 },
                    { 108, 7, "At the beginning of the Ship Phase, you may spend 1 repair token. If you do, during the Status Phase, each friendly ship at distance 1–5 may recover 1 shield.", null, "Shields to Maximum!", 6 },
                    { 109, 7, "At the beginning of the Ship Phase, you may spend 1 navigate token. If you do, each friendly ship at distance 1–5 gains 1 yaw at its final joint, to a maximum of 2.", null, "Take Evasive Action!", 6 },
                    { 110, 22, "While you resolve an engineering command, you may increase the number of engineering points available from your dial, then exhaust or discard this card.", null, "Engineering Team", 5 },
                    { 111, 22, "At the end of the Status Phase, you may exhaust this card to remove 1 facedown damage card from your ship.", null, "Damage Control Teams", 5 },
                    { 112, 22, "When your ship activates, you may exhaust this card to prevent damage to your crew.", null, "Medical Team", 1 },
                    { 113, 22, "During the Command Phase or when you activate, you may exhaust this card to give a command token to another friendly ship at distance 1–5.", null, "Comms Net", 2 },
                    { 114, 22, "While attacking, you may exhaust this card to change 1 black die to a hit icon after rolling black dice.", null, "Ammunition Experts", 3 },
                    { 115, 22, "During your maneuver or activation, you may exhaust this card to shift 1 shield from one of your hull zones to an adjacent hull zone.", null, "Auxiliary Shields Team", 3 },
                    { 116, 9, "While a friendly bomber at distance 1–5 attacks a ship, it may reroll 1 attack die.", null, "Bomber Command Center", 8 },
                    { 117, 22, "(Duplikáció / lásd a 113. sorszámot)", null, "Comms Net", 2 },
                    { 118, 9, "Friendly and enemy ships and squadrons at distance 1–2 of your ship treat attacks against squadrons as obstructed.", null, "Jamming Field", 2 },
                    { 119, 9, "When you resolve an engineering command, instead of spending engineering points, you may discard 1 damage card from a friendly ship at distance 1–2 or recover 1 shield on it.", null, "Repair Crews", 4 },
                    { 120, 9, "After you execute a maneuver, you may exhaust this card to choose an enemy ship at distance 1–3 and change its top command dial to a command of your choice.", null, "Slicer Tools", 7 },
                    { 121, 9, "When you reveal a command dial, you may discard this card to give up to 5 friendly ships at distance 1–5 1 concentrate fire token.", null, "Munitions Resupply", 3 },
                    { 122, 9, "When you reveal a command dial, you may discard this card to give up to 5 friendly ships at distance 1–5 1 repair token.", null, "Parts Resupply", 3 },
                    { 123, 9, "After you execute a maneuver, you may exhaust this card to choose up to a number of friendly squadrons at distance 1–2 equal to your squadron value; those squadrons may each execute a distance 1 move.", null, "Fighter Coordination Team", 3 },
                    { 124, 20, "Ignition [Close]. While attacking a ship from your ignition arc, each other ship and squadron at distance 1 of the defender suffers 1 damage.", null, "Orbital Bombardment Particle Cannons", 5 },
                    { 125, 20, "Ignition [Long]. While attacking a ship from your ignition arc, after defense tokens are spent, deal 1 damage to each hull zone (other than the defender's) that the line of sight passes through.", null, "Superheavy Composite Beam Turbolasers", 7 },
                    { 126, 0, "While your ship is attacking with only its left or right hull zone during its activation, it may add 2 red dice to its attack pool.", null, "Admiral Ackbar", 38 },
                    { 127, 0, "Before an enemy ship receives a faceup damage card, you may draw 4 damage cards, choose 1 for it to receive, and place the rest on the bottom of the damage deck.", null, "General Dodonna", 20 },
                    { 128, 0, "When a friendly ship or unique squadron is destroyed, it remains in play and can perform actions as normal until the end of the current round.", null, "General Rieekan", 30 },
                    { 129, 0, "Friendly ships and squadrons may spend evade tokens at medium range, and may reroll dice with evade tokens at close range.", null, "Mon Mothma", 27 },
                    { 130, 1, "When a friendly ship is attacking, you may discard 1 shield from any of its hull zones to reroll any number of attack dice.", null, "Darth Vader (Commander)", 36 },
                    { 131, 1, "After deployment, place 3 facedown command dials on this card. During the Command Phase, you may reveal 1: each friendly ship gains a matching command dial this round.", null, "Grand Admiral Thrawn", 32 },
                    { 132, 1, "Each friendly ship's hull value is increased by 1 for small ships, 2 for medium ships, and 3 for large ships.", null, "Admiral Motti", 24 },
                    { 133, 1, "While attacking, each friendly ship may, once per round, discard 1 die to change another die to a face with a crit icon.", null, "Admiral Screed", 26 },
                    { 134, 2, "While a friendly ship is defending, when it spends a defense token, it reduces the total damage suffered by 1 (once per round).", null, "Obi-Wan Kenobi", 28 },
                    { 135, 3, "After deployment, choose 3 command tokens. When an enemy ship spends a matching token, deal 1 damage to it.", null, "Count Dooku", 30 },
                    { 136, 25, "Your ship may perform 1 of its attacks after it executes its maneuver.", null, "Demolisher (Gladiator-class)", 10 },
                    { 137, 25, "While attacking, the defender cannot spend defense tokens that are already exhausted.", null, "Avenger (Imperial Star Destroyer)", 5 },
                    { 138, 25, "Your ship's command value is reduced by 1.", null, "Relentless (Imperial Star Destroyer)", 3 },
                    { 139, 24, "While you resolve a squadron command, activated squadrons that do not move may attack twice.", null, "Yavaris (Nebulon-B)", 5 },
                    { 140, 24, "While a friendly ship at distance 1–5 is attacking, it may change 1 accuracy icon to a hit icon.", null, "Home One (MC80 Star Cruiser)", 7 },
                    { 141, 24, "When you resolve a blue crit effect, instead of resolving its normal effect, the defender is dealt 1 faceup damage card.", null, "Dodonna's Pride (CR90 Corvette)", 6 },
                    { 142, 26, "When a friendly ship at distance 1–5 would suffer damage, you may redirect 1 damage to the Resolute.", null, "Resolute (Venator-class)", 6 },
                    { 143, 27, "You may deploy extra squadrons during setup and deploy them later in the game.", null, "Invisible Hand (Providence-class)", 9 },
                    { 144, 31, "While at distance 1 of an enemy ship, you may exhaust this card to exhaust a number of the defender's defense tokens equal to your squadron value.", null, "Boarding Troopers", 3 },
                    { 145, 31, "While at distance 1 of an enemy ship, you may exhaust this card to flip a number of the defender's facedown damage cards faceup equal to half your engineering value, rounded up.", null, "Boarding Engineers", 2 },
                    { 146, 31, "While at distance 1 of an enemy ship, you may discard this card to choose and discard an upgrade card (other than a commander) equipped to the defender.", null, "Darth Vader (Boarding Team)", 3 },
                    { 147, 31, "While at distance 1 of an enemy ship, you may discard this card to deal 2 faceup damage cards to the defender before the attack is resolved.", null, "Jyn Erso (Boarding Team)", 4 },
                    { 148, 31, "While at distance 1 of an enemy ship, you may discard this card to look at the defender's command dials and change its top dial to a command of your choice.", null, "Cham Syndulla (Boarding Team)", 5 },
                    { 149, 31, "While at distance 1 of an enemy ship, you may discard this card to choose and discard a weapons team or offensive retrofit upgrade card equipped to the defender.", null, "Shriv Suurgav (Boarding Team)", 6 },
                    { 150, 0, "While attacking a ship, if a friendly squadron is at distance 1 of the target, you may replace up to 2 attack dice with dice of any color.", null, "Commander Sato", 32 },
                    { 151, 0, "When you resolve a navigate command (from a dial or token), your ship gains 1 extra yaw at one of its pivot points.", null, "General Madine", 30 },
                    { 152, 0, "During the Command Phase of rounds 1 and 5, each friendly ship gains command tokens up to its maximum capacity.", null, "Garm Bel Iblis", 25 },
                    { 153, 0, "During setup, choose a friendly ship and set it aside. Later in the game, at the start of a command phase, it may enter play at distance 1 of another friendly ship.", null, "Admiral Raddus", 26 },
                    { 154, 1, "At the beginning of the Command Phase, you may assign 1 command token of the same type to each friendly ship in your fleet.", null, "Grand Moff Tarkin", 38 },
                    { 155, 1, "After deployment, choose 1 defense token type. When an enemy ship spends a token of that type, it must discard it instead of exhausting it unless it spends another token.", null, "Emperor Palpatine", 35 },
                    { 156, 1, "While friendly squadrons attack ships, they may use accuracy icons to exhaust the defender's defense tokens and deal bonus damage.", null, "Admiral Sloane", 24 },
                    { 157, 1, "When a friendly ship uses a navigate token to modify its speed, it may increase or decrease its speed by 2 instead of 1 (to a minimum and maximum speed).", null, "Admiral Ozzel", 20 },
                    { 158, 1, "During your ship's maneuver, it may suffer 1 damage to change its yaw by 1 at the current speed step.", null, "Moff Jerjerrod", 23 },
                    { 159, 2, "While your ships are defending, defense tokens targeted by accuracy icons can still be resolved, but must be discarded if used.", null, "Luminara Unduli", 25 },
                    { 160, 2, "At the beginning of the Ship Phase, each friendly ship may spend 1 command token to trigger a special effect regardless of its dial.", null, "Anakin Skywalker (Commander)", 29 },
                    { 161, 2, "At the beginning of the command phase, you may heal friendly squadrons or grant them escort until the end of the round.", null, "Plo Koon", 26 },
                    { 162, 3, "While attacking a ship, if the defender's command value is less than yours, you may add 1 red die to your attack pool.", null, "Mar Tuuk", 28 },
                    { 163, 3, "While attacking, you may reroll 1 die if another friendly ship at distance 1–3 threatens the target.", null, "Kraken", 26 },
                    { 164, 3, "While attacking, you may add a bonus die of any color for each raid token on the defending ship.", null, "TF-1726", 26 }
                });
            */

            migrationBuilder.CreateIndex(
                name: "IX_ShipCard_ShipId",
                table: "ShipCard",
                column: "ShipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipCard");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.AddColumn<string>(
                name: "CardsType",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
