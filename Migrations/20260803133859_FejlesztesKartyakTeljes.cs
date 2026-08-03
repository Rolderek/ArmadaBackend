using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class FejlesztesKartyakTeljes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "Before a friendly ship's Attack step, it may choose to attack from only its left and right hull zones this round. If it does, it may add 2 red dice to its attack pool while attacking a ship.", "Admiral Ackbar", 38 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "While a friendly ship is attacking a ship at distance 1 of a friendly squadron, before rolling attack dice, the attacker may replace up to 2 dice in its attack pool with an equal number of dice of any color or colors.", "Commander Sato", 27 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "After deploying fleets, place 2 non-consecutive round tokens on this card. At the start of the Ship Phase during each round matching 1 of those tokens, each friendly ship may gain a number of command tokens equal to its command value.", "Garm Bel Iblis", 25 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "While a friendly small or medium ship is defending against a ship, if the defender is at speed 3 or higher, the attack is treated as obstructed.", "General Cracken", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "Before an enemy ship is dealt a faceup damage card, look at the top 4 cards of the damage deck, place 1 on top of the deck and discard the others.", "General Dodonna", 20 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "Choose command dials for this card after deploying fleets. At the start of each Ship Phase, you may reveal and discard 1 command dial from this card. If you do, until the end of the round, when an enemy ship spends a matching command dial, it resolves that dial as though it spent a token of the same type instead.", "General Draven", 20 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "When a friendly ship is executing its first maneuver during its activation, during the Determine Course step, it may increase 1 yaw value by 1.", "General Madine", 30 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "Once per round, when a friendly ship or friendly unique squadron is destroyed, it remains in the play area and is treated as if it was not destroyed until the end of the Status Phase.", "General Rieekan", 34 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "After you deploy, gain 1 non-:scatter: defense token. During your \"Spend Defense Tokens\" step, if your speed is not 0, you may discard 1 defense token to resolve the effect of that defense token. You cannot resolve the effect of each type of defense token more than once per attack.", "Kyrsta Agate", 25 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "When a friendly ship resolves a command by spending a command dial, if it has not resolved another command this round, it may resolve that command as if it also spent a matching command token. If it does, that ship cannot resolve additional commands this round.", "Leia Organa", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "When a friendly ship resolves the :evade: token effect, it can cancel 1 die at medium range or reroll 1 additional die at close range or distance 1.", "Mon Mothma", 27 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "At the start of each Status Phase, you may choose any number of enemy ships at distance 1-5 of at least 2 friendly non-flotilla ships, 1 of which must be of medium or larger size class. For each chosen ship you may discard 1 :nav: token from it or increase or decrease its speed by 1 to a minimum of speed 1.", "Admiral Konstantine", 23 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "The hull value of each friendly ship is increased according to its size class: Small ship: 1 Medium ship: 2 Large ship: 3", "Admiral Motti", 24 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "During each friendly ship's Determine Course step, it may change its speed by 1.", "Admiral Ozzel", 20 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "When a friendly ship spends only a command token to resolve a command, you may exhaust this card. If you do, that ship resolves that command as if it had spent a dial of the same type instead.", "Admiral Piett", 22 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "Once per activation, when a friendly ship is attacking, it may spend 1 die to change a die to a face with a :critical: icon.", "Admiral Screed", 24 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "While a friendly squadron without ROGUE is attacking, it may spend 1 die with an :accuracy: icon to choose and spend 1 of the defender's defense tokens. While attacking a ship, it may also reroll 1 die with a :critical: icon.", "Admiral Sloane", 24 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "While a friendly ship is attacking a ship, it may spend 1 defense token to reroll any number of dice in its attack pool.", "Darth Vader", 34 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "After deploying fleets, place 1 defense token of each type on this card. At the start of each Ship Phase you may discard 1 of those tokens. If you do, until the end of the round, if an enemy ship or squadron spends a matching token during its Spend Defense Tokens step, discard that token.", "Emperor Palpatine", 35 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "While a friendly ship is attacking a ship, if the attack is obstructed by a ship or obstacle, the attacker does not remove a die (even if the attack is also obstructed by a card effect), and may add 1 red die to the attack pool.", "General Romodi", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "After deploying fleets, place 2 non-consecutive round tokens on this card. At the start of the Ship Phase during each round matching 1 of those tokens each friendly ship may recover 1 of its discarded defense tokens.", "General Tagge", 25 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "Choose command dials for this card after deploying fleets. At the start of each Ship Phase, you may reveal and discard 1 dial from this card. If you do, until the end of the round, when each friendly ship activates, it gains 1 additional dial matching that discarded dial.", "Grand Admiral Thrawn", 32 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "At the start of each Ship Phase, you may choose 1 command. Each friendly ship gains a command token matching that command.", "Grand Moff Tarkin", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "While a friendly ship executes a maneuver, during the Determine Course step, that ship may suffer 1 damage to change the first yaw value of that maneuver to 'II'.", "Moff Jerjerrod", 23 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "At the start of each Ship Phase, you may discard 1 command token from this card. If you do, either you gain 1 matching command dial, or each friendly ship gains 1 matching command token.", "Admiral Tarkin", 30 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "When a friendly ship resolves a :squadron: command, if it spend a :squadron: token, it may activate 1 additional squadron. When a friendly ship resolves a :repair: command, it may spend engineering points on the following repair effect: Repair Squadron: Spend 2 points to choose a friendly squadron at distance 1-3. That squadron recovers 1 hull point.", "Admiral Yularen", 24 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "While a friendly ship is attacking a ship, if the defender is at distance 1-5 of at least 2 other friendly ships, 1 other friendly ship at distance 1-5 of the defender may spend 1 defense token. If it does, the attacker may reroll up to 3 dice.", "Anakin Skywalker", 27 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "When a friendly ship reveals a command, you may discard up to 1 token of each type from this card. For each token you discard, that ship gains 1 additional command dial matching that token's type.", "Bail Organa", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "While a friendly ship or unique squadron is defending, after the Spend Defense Tokens step, if it spent fewer than 2 defense tokens, it may either ready 1 of its defense tokens it did not spend, or choose another friendly ship at distance 1-5 and ready 1 of that ship's defense tokens.", "Luminara Unduli", 25 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "While a friendly ship is defending, when it spends a readied :redirect: token, it may reduce the total damage by 1 before it suffers damage.", "Obi-Wan Kenobi", 22 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "While a friendly squadron is attacking a ship that is at distance 1-3 of a friendly ship, the attacker may add 1 blue die set to an :accuracy: icon to its attack pool. That die cannot be rerolled or changed. Friendly squadrons without ADEPT gain GRIT while they are at distance 1 of a friendly squadron with ADEPT.", "Plo Koon", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "At the start of each Ship Phase, you may reveal and discard 1 command dial from this card. If you do, until the end of the round, when a friendly ship spends only a matching command token to resolve a command, that ship resolves that command as if it had spent a dial and token of the same type instead.", "Admiral Trench", 32 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "You must choose at least 2 types of command tokens for this card. At the start of each Ship Phase, you may discard 1 command token from this card. If you do, each enemy ship gains a raid token matching that command token.", "Count Dooku", 27 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "When a friendly ship or squadron is destroyed, you may choose 1 friendly ship or unique squadron at distance 1-5 of the destroyed ship or squadron. If you do, the chosen ship or unique squadron may either ready 1 of its defense tokens or recover 1 of its discarded defense tokens and then exhaust that token.", "General Grievous", 20 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "Once per activation, while a friendly ship is attacking a ship, if another friendly ship is at close-medium range of the defender, the attacker may change 1 die to a face with any 1 icon (and no other icons).", "Kraken", 30 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "While a friendly ship is attacking, if the defending hull zone has at least 1 shield remaining, the attacker may add 1 red die to its attack pool. While a friendly ship is attacking a ship that has no shields remaining, after rolling the attack dice, the attacker must cancel 1 attack die.", "Mar Tuuk", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "Once per activation, while a friendly ship is attacking a ship, the attacker adds 1 black die to its attack pool for each raid token the defender has, to a maximum of 2 additional dice.", "TF-1726", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "When you resolve the :redirect: token effect, you can choose more than one hull zone to suffer damage, which may include a nonadjacent hull zone", "Advanced Projectors", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "After a squadron performs an attack against you, even if you are destroyed, you may discard this card to roll 4 blue dice. That squadron suffers 1 damage for each :hit: or :critical: icon rolled.", "Cluster Bombs", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "At the start of each Ship Phase, you may choose 1 of your hull zones and mark it with a chaff token. Until the end of the round, while a ship or squadron is attacking that hull zone, the attack is obstructed. After the Status Phase, remove that chaff token.", "Early Warning System", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "While defending you may exhaust this card to spend 1 defense token that your opponent targeted with an :accuracy: result.", "Electronic Countermeasures", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "While defending, you may exhaust this card and spend a readied defense token to resolve the :salvo: defense effect instead of that token's effect. You cannot resolve the :salvo: defense effect more than once per attack.", "Reactive Gunnery", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "_Modification_. At the start of each Status Phase, you may recover 1 shield.", "Redundant Shields", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 4, "At the start of the Ship Phase, you may discard this card to discard up to 3 of your facedown damage cards.", "Reinforced Blast Doors" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 5, "While defending, after the attacker gathers dice, you may spend 1 :brace: token. If you do, choose and remove half of the dice in the attack pool, rounded down.", "Thermal Shields", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 6, "Before deploying fleets, place 1 grav well token anywhere in the play area. When a ship deploys at distance 1-3 of a grav well token, its speed dial must be set to 0.", "G7-X Grav Well Projector" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 6, "Before an enemy ship at distance 1-5 resolves the Determine Course step, you may exhaust this card to temporarily reduce its speed by 1 to a minimum of speed 0 until the end of the maneuver.", "G-8 Experimental Projector", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 6, "Before deploying fleets, place 1 grav shift token anywhere in the play area. After deploying fleets, you may move each obstacle at distance 1-3 of that token to within distance 1-2 of that obstacle's current location. Obstacles cannot overlap tokens, obstacles, or ships.", "Grav Shift Reroute", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 6, "While a friendly ship at distance 1-3 is defending at close range, during the Spend Defense Tokens step, you may exhaust this card to force the attacker to reroll up to 4 dice of your choice.", "Targeting Scrambler", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the start of the Ship Phase, you may discard this card or spend a :squadron: token. If you do, until the end of the round, the speed of each squadron that a friendly ship activates is increased by 1, to a maximum of 5, until the end of that squadron's activation.", "All Fighters, Follow Me!", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the start of the Ship Phase, you may discard this card or spend a :nav: token. If you do, until the end of the round, each friendly ship may change its speed by 1 during its Determine Course step.", "Entrapment Formation!", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the start of the Ship Phase, you may discard this card or spend a :confire: token. If you do, until the end of the round, while each friendly ship is attacking a ship, it may change 1 die to a face with 1 :hit: icon and no other icons.", "Intensify Firepower!", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the start of the Ship Phase, you may discard this card or spend a :repair: token. If you do, until the end of the round, before a friendly ship reveals a command, it may recover 1 shield.", "Shields to Maximum!", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the start of the Ship Phase, you may discard this card or spend a :nav: token. If you do, until the end of the round, each friendly ship may increase the last yaw value of its current speed by 1 during its Determine Course step.", "Take Evasive Action!", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 8, "At the start of the Squadron Phase, friendly squadrons with adept gain grit until the end of the phase. When a friendly squadron with adept is destroyed, you may choose 1 enemy ship at distance 1-2 of that squadron. If you do, that ship gains 1 raid token of your choice.", "Hot Landing", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 8, "When an enemy ship declares you as the target of a non-:salvo: attack, if this card is readied, the attacker gains a raid token of its choice, if able. When an enemy ship at close range reveals a command, it may discard a :squadron: dial to exhaust this card. While defending, if this card is exhausted, you cannot spend more than 1 defense token.", "Jedi Hostage", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 8, "Before deploying fleets, un-equip this card and choose 1 friendly small ship that is not your flagship. Equip this card to the chosen ship (even if it does not have a :fleet command: icon in its upgrade bar). At the end of the game, if you are within the enemy deployment zone, increase your score by 40 points; if you were destroyed, increase your opponent's score by 15 points.", "Mercy Mission", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "While a friendly squadron with Bomber at distance 1-5 is attacking a ship, it may reroll 1 die.", "Bomber Command Center", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 9, "After the Reveal Command Dial Step, you may remove 1 command token from this ship to assign a matching token to another friendly ship at distance 1-5.", "Comms Net" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "While a squadron at distance 1-2 is attacking a squadron or defending against a squadron, the attack must be treated as obstructed.", "Jamming Field", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "After your Reveal Command Dial step, you may exhaust this card and discard any number of :confire: tokens from it to choose that many friendly ships at distance 1-5. Assign each chosen ship a :confire: token.", "Munitions Resupply", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "After your Reveal Command Dial step, you may exhaust this card and discard any number of :repair: tokens from it to choose that many friendly ships at distance 1-5. Assign each chosen ship a :repair: token.", "Parts Resupply", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 9, ":repair:: Instead of spending engineering points, you may discard 1 damage card from 1 friendly ship at distance 1-2.", "Repair Crews" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 9, "After you execute a maneuver, you may exhaust this card to choose an enemy ship at distance 1-3. Look at the top command dial assigned to that ship. Then you may either choose a new command on its top command dial or that ship gains 1 raid token of your choice that does not match its top command dial. If the chosen ship has no top command dial, it gains 1 raid token of your choice.", "Slicer Tools" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "BLUE :crit: : You may exhaust this card. If you do, the defending hull zone and each adjacent hull zone loses 1 shield.", "Heavy Ion Emplacements", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Modification. The battery armaments for your left and right hull zones are increased by 1 blue die.", "High-Capacity Ion Turbines", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 10, "Blue :critical:: Choose and discard 1 command token from the defender. If the defender does not have any command tokens, the defending hull zone loses 1 shield instead.", "Ion Cannon Batteries" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "While attacking, you may spend 1 blue die to reroll any number of dice in your attack pool.", "Leading Shots", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue :crit:: Choose and exhaust 1 of the defender's upgrade cards.", "MS-1 Ion Cannons", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue :critical: : Exhaust this card to force the defender to choose and discard 1 of its defense tokens.", "NK-7 Ion Cannons", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "BLUE :crit: : Exhaust all of the defender's defense tokens.", "Overload Pulse", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 10, "While defending at close range or distance 1, during the Spend Defense Tokens step, you may force the attacker to reroll 1 die of your choice.", "Point Defense Ion Cannons" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "While attacking a ship, each of your unspent blue :accuracy: icons adds 1 damage to the damage total.", "SW-7 Ion Batteries", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "Modification. Friendly heavy squadrons at distance 1-2 prevent engaged squadrons from attacking ships.", "Advanced Transponder Net", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, ":squadron: : You can activate friendly squadrons at close-long range (instead of close-medium).", "Boosted Comms", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "When you activate, you may discard this card. If you do, the blue dice in your battery armament can be used while attacking ships at close-long range until the end of the round.", "Disposable Capacitors", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "Your squadron value is increased by 1.", "Expanded Hangar Bay", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "Medium or large ship only. Flagship only. Modification You gain 1 :fleet-command: icon in your upgrade bar. You cannot spend a command token to resolve a :fleet-command: card's effect.", "Flag Bridge", 0 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Treat each die in your anti-squadron armament as black. While performing a :salvo: attack, the black dice in your battery armament can be used at medium range and the blue dice in your battery armament can be used at long range.", "Flak Guns", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Large ship only. When you overlap a ship of a smaller size class (or are overlapped by a ship of a smaller size class), deal 1 fewer facedown damage card to your ship.", "Hardened Bulkheads", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "_Modification_. When you activate, you may exhaust this card to choose 1 enemy ship of your size class or smaller at distance 1-5. That ship must spend a :navigate: token or reduce its speed by 1 to a minimum of 1.", "Phylon Q7 Tractor Beams", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "While attacking a squadron at close range, you may reroll your :critical: icons");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Before deploying fleets, you may discard this card to place a number of proximity mine tokens equal to half your engineering value, rounded down. You may place these mines anywhere in the play area beyond distance 5 of enemy ships (and distance 1 of each other).", "Proximity Mines", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "While defending at distance 1, if the attacker is a squadron, you have Counter 1.", "Quad Laser Turrets", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Before deploying fleets, you may set aside a number of friendly squadrons up to your squadron value next to your ship card. When you reveal a command, you may discard this card. If you do, place each squadron set aside with this card within distance 1-2 of you. Those squadrons cannot move during your activation.", "Rapid Launch Bays", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Point" },
                values: new object[] { "When a friendly non-unique squadron with swarm at distance 1-5 is destroyed, you may discard this card. If you do, you may set that squadron's hull points to \"2\" and place that squadron unengaged at distance 1 with its activation slider toggled to the activated side.", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 12, "Before deploying fleets, you may choose a number of friendly, non-rogue squadrons up to your squadron value. Those squadrons gain scout.", "Hyperspace Rings" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 12, "_Modification_. Decrease your squadron value by 2. Ignition (Close) Each of your front, left, or right firing arcs is also a special firing arc. You have a special battery armament of 5 blue dice and 1 black die. After you place your targeting token, exhaust this card. While this card is exhausted, you cannot place targeting tokens.", "SPHA-T", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 13, "While performing a non-:salvo: attack against a ship at close-medium range, you may exhaust this card. If you do, the defender gains 1 raid token of your choice. While attacking a squadron, you may exhaust this card. If you do, add 1 die of a color already in your attack pool to your attack pool.", "B2 Rocket Troopers", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 13, "During the Squadron Phase, when it is your fleet's turn to activate squadrons, you may exhaust this card to choose a number of unactivated, friendly squadrons at close-long range up to your squadron value. This turn, activate each of those squadrons. While attacking, each of those squadrons with AI are treated as if activated by a :squadron: command.", "Hyperwave Signal Boost", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "After you execute a maneuver, if you overlapped an obstacle, you may discard this card instead of resolving the effects of overlapping that obstacle.", "Chart Officer", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "When you resolve the :contain: defense effect, you can prevent the attacker from resolving any critical effects.", "Damage Control Officer", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "Before you reveal a command, you may spend 1 command token to change that command to a :nav: or :repair: command.", "Defense Liaison", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "Before you reveal a command, you may change that command to a :repair: command.", "Engineering Captain", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 14, "While defending, during the Spend Defense Tokens step, when you spend a :redirect: defense token, you may reduce the total damage from the attack by 1 instead of resolving that token's effect.", "Expert Shield Tech" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "During your activation, you can resolve your :squadron: command after you execute a maneuver.", "Flight Commander", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "At the start of the ship phase, you may discard this card to choose 2 different command tokens and place them on 2 different ships. Then your opponent chooses 2 different command tokens you did not choose and places them on 2 different ships.", "Hondo Ohnaka", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "While attacking, after you roll your attack pool, you may exhaust this card to choose 1 defense token. If that token is spent during this attack, discard that token.", "Intel Officer", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "Before you reveal a command, you may change that command to a :navigate: command.", "Navigation Officer", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "Before you reveal a command, you may discard this card to discard your top command dial.", "Skilled First Officer", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "[BANNED - not legal in competitive events.] Large ship only. When it is your turn to activate, you may exhaust this card to pass your turn; your opponent activates a ship instead.", "Strategic Adviser", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 14, "At the start of the Command Phase, you may discard this card to discard all of your command dials.", "Support Officer" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "Before you reveal a command, you may change that command to a :concentrate fire: command.", "Tactical Expert", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "When you reveal a command, you may discard this card to gain 1 command token of your choice.", "Veteran Captain", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "Before you reveal a command, you may spend 1 command token to change that command to a :confire: or :squadron: command.", "Weapons Liaison", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 14, "Before you reveal a command, you may change that command to a :squadron: command.", "Wing Commander" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "After you resolve a :squadron: command, exhaust this card to toggle the activation slider of 1 squadron activated with that command", "Adar Tallon", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "During the activation of a friendly ship at distance 1-5, you may exhaust this card to discard 1 command token from that ship. If you do, that ship may gain 1 command token of any type.", "Ahsoka Tano", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "[BANNED - not legal in competitive events.] Medium or large ship only. After deploying fleets, you may place 1 round token on this card. At the start of the Ship Phase of the round matching that token, if you are the second player you must activate; if you are the first player, you may gain up to 2 command tokens of your choice.", "Bail Organa", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 15, ":squadron:: You may choose 1 enemy ship at close range. That ship gains 1 raid token of your choice. While you are at distance 1-3 of an enemy ship, that ship can discard only 1 raid token of any type when it discards a command dial.", "Captain Rex" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "When you reveal a command, you may discard this card to move 1 obstacle at distance 1-2 so that it is within distance 1-2 of its current location.", "Ezra Bridger", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "While attacking a squadron with counter or intel, add 1 die of any color to your attack pool.", "General Draven", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "Red or Blue :crit:: You may exhaust this card to ready 1 of your exhausted defense tokens. You can resolve this critical effect during a Salvo attack.", "Kyrsta Agate", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "While defending, during the Spend Defense Tokens Step, you may discard this card to force the attacker to reroll 1 or more dice of your choice.", "Lando Calrissian", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "When you reveal a command, you may choose another friendly ship at distance 1-5 and change that ship's top command to your revealed command.", "Leia Organa", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "Before you suffer damage from an attack, you may exhaust this card to reduce the total damage by 1.", "Major Derlin", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "When you reveal a command, you may gain 1 matching command token without spending the command dial.", "Raymus Antilles", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 15, "At the start of the Ship Phase, you may discard this card to place 1 proximity mine token in the play area at distance 1-2 of an obstacle and beyond distance 3 of enemy ships.", "Sabine Wren" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 15, "While another friendly ship or squadron at distance 1-3 is attacking, it may reroll 1 blue die.", "Toryn Farr" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "When you activate, you may discard this card to recover 1 of your discarded defense tokens.", "Walex Blissex", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 15, "Before the end of the Squadron Phase, you may spend 1 :squadron: token to choose up to 3 friendly non-unique squadrons without Strategic at distance 1-5. Those squadrons gain Cloak until the end of the round.", "Wedge Antilles", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, ":Squadron:; Squadrons that you activate can move even if they are engaged. When an engaged squadron moves in this way, treat it as having a printed speed of 2.", "Admiral Chiraneau", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 16, "While defending against a ship, if your speed is 3 or higher, the attack is treated as obstructed. After you execute a maneuver, if you overlapped a ship, discard this card.", "Admiral Montferrat" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "At the start of the first round, you may execute a speed-1 maneuver.", "Admiral Ozzel", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "At the start of the first round, you may change 1 enemy ship's speed by 1.", "Admiral Titus", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While attacking a unique squadron, add 1 die of any color to your attack pool.", "Agent Kallus", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While defending at distance 1-2 of an obstacle, during the Spend Defense Tokens step, you may exhaust this card to choose and cancel 1 attack die.", "Captain Brunson", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "At the start of the first round, you may replace 1 of your defense tokens with an :evade: defense token.", "Captain Needa", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When another friendly ship at distance 1-3 reveals a command, you may exhaust this card to gain 1 command token of the same type.", "Commandant Aresko", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "During your activation, you may resolve a command as if you had spent a command token. If you do, gain 1 raid token of the matching type. You may resolve this effect twice per activation.", "Commander Beck", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While you are defending, the attacker cannot resolve critical effects. After you perform an attack against a ship, discard this card.", "Commander Gherant", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "After you resolve the first command during your activation, you may exhaust this card to gain 1 command token of any type.", "Commander Vanto", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While a friendly, non-SWARM squadron at distance 1-3 is attacking a squadron, it may reroll 1 die of any color.", "Commander Woldar", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While a friendly ship at distance 1-5 attacking a ship, it may discard 1 of its :commander: or :officer: cards (other than Darth Vader) to reroll any number of dice in its attack pool.", "Darth Vader", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When you reveal a command, you may look at all command dials assigned to 1 enemy ship.", "Director Isard", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, ":confire:: While attacking at medium-long range, if you spent a :confire: dial, you may also reroll any number of red dice in your attack pool. If you spent a :confire: token, you may also reroll up to 2 red dice in your attack pool.", "Director Krennic", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 16, "When an enemy ship or unique squadron declares you as the target of an attack, it must spend 1 of its defense tokens (if able).", "Emperor Palpatine" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "Once per activation, while performing an attack against an enemy ship, you may spend 1 shield from the attacking hull zone to change 1 die face to any face without an :accuracy: icon.", "Governor Pryce", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When you resolve the :evade: defense effect, you can cancel 1 die at close range or distance 1. :squadron:: You may discard this card to choose 1 enemy ship at close range. That ship gains 1 raid token of your choice.", "Iden Versio", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While a friendly non-HEAVY squadron is at distance 1-2, it has COUNTER 1 or increases its COUNTER value by 1.", "Instructor Goran", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When you are dealt a faceup damage card, you may spend 1 :repair: token to flip that card facedown (without resolving its effect).", "Lira Wessex", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "You gain an additional :defensive_retro: icon in your upgrade bar. You cannot equip this card to a medium or large ship with a :defensive_retro: icon in its upgrade bar.", "Minister Tua", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "After you are declared as the target of an attack, if the defending hull zone has at least 1 shield remaining, you may exhaust this card to ready 1 defense token.", "Reeva Demesne", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "Choose the command token for this card after deploying fleets. When you reveal a command matching the token on this card, you may gain 1 matching command token without spending the command dial.", "Taskmaster Grint", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When an enemy ship at distance 1-5 changes its speed, you may exhaust this card to increase or decrease your speed by 1.", "The Grand Inquisitor", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When you spend a command token, you may exhaust this card to gain 1 command token of the same type", "Wullf Yularen", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "While defending, when you suffer damage from an attack, you may suffer up to 1 of that damage on the shields of a hull zone adjacent to the defending hull zone for each defense token you spent during the Spend Defense Tokens step. If you do, suffer any remaining damage on the defending hull zone.", "Adi Gallia", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 17, ":squadron: : Each of up to 3 non-unique squadrons that you activate gain snipe 1 for each die in their anti-squadron armament, to a maximum of snipe 3, until the end of its activation.", "Ahsoka Tano" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "While defending, after the attacker declares the defending hull zone, you may spend 1 :redirect: token. If you do, at the start of the Resolve Damage step, choose a different hull zone to be the defending hull zone for this attack.", "Barriss Offee", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "When you execute a maneuver, during your Determine Course step, if you have not resolved a :navigate: command during this activation, you may exhaust this card to increase or decrease your speed by up to 3. If you do, you cannot resolve a :navigate: command during this activation. You can spend tokens from this card to ready it.", "Clone Captain Silver", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "While attacking from your side or rear hull zones, you may exhaust this card to add 1 die to your attack pool of a color already in your attack pool (you cannot add dice to a :salvo: attack). You can spend tokens from this card to ready it.", "Clone Captain Zak", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, ":squadron: : You may exhaust this card. If you do: Each of up to 3 squadrons that you activate without adept gain assault until the end of its activation. Each squadron that you activate with the *assault* keyword can spend a die with a :hit: or :accuracy: icon to resolve the assault effect. You can spend tokens from this card to ready it.", "Clone Commander Wolffe", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "When you reveal a :confire:, :nav:, or :squadron: command, you may exhaust this card to choose a friendly ship at distance 1-5. That ship may gain 1 command token matching your command. You can spend tokens from this card to ready it.", "Clone Navigation Officer", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "After you perform an attack targeting a ship that has 1 or more raid tokens, if the defender suffered one or more damage, you may remove 1 raid token and 1 command token from the defender. If you do, gain a matching command token.", "Asajj Ventress", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When you reveal a command, you may place a matching command token on this card. Then, if you have at least 1 :nav:, 1 :squadron:, 1 :confire:, and 1 :repair: command token on this card, you may gain 1 additional command dial of your choice.", "Passel Argente", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When you reveal a command, you may choose another friendly ship at distance 1-5. If you do, discard any number of command tokens from that ship, this card, or both, to gain 1 matching command token for each discarded token.", "Rune Haako", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When a friendly ship at distance 1-5 resolves a :squad: command, you may discard 1 :squad: token from this card. If you do, that friendly ship may activate 1 additional squadron during that command.", "San Hill", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "After deploying fleets, you may place 2 non-consecutive round tokens on this card. During each round matching 1 of those tokens, while attacking a ship you may reroll up to 3 dice.", "Shu Mai", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "While a friendly unactivated squadron is at distance 1-3, it gains counter 3 or, if it has the printed counter keyword, gains an additional counter 1. After it performs a counter attack, toggle its activation slider to the activated side.", "TI-99", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When you reveal a command, you may place a matching command token on this card. If you do, gain a command token of your choice. During the Command Phase, if you have a command token on this card, you must choose that command on each command dial that is to be assigned to you and show those dials to your opponent. Then discard that command token.", "Tikkes", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When you spend only a :repair:, :nav: or :squadron: command token to resolve a command, you may exhaust this card. If you do, resolve that command as if you had spent a dial of the same type instead.", "T-series Tactical Droid", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, ":repair: : You may spend up to 2 shields from any of your hull zones or any 1 hull zone on another friendly ship at distance 1-5 to gain twice that many additional engineering points.", "Wat Tambor", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "BLACK :crit: : Exhaust this card. Each hull zone adjacent to the defending hull zone suffers 1 damage.", "Assault Concussion Missiles", 5 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Category", "Description", "FleetElementId", "Name", "Point" },
                values: new object[,]
                {
                    { 2, 0, "Before deploying fleets, you may set aside 1 other friendly ship. At the start of any round, you may deploy that ship at distance 1 of a friendly ship. That ship cannot be deployed overlapping squadrons and cannot be the first ship to activate that round.", null, "Admiral Raddus", 26 },
                    { 165, 19, "BLACK :crit: : Exhaust this card to deal 1 faceup damage card to the defender.", null, "Assault Proton Torpedoes", 4 },
                    { 166, 19, "*Modification*. The battery armament for your front hull zone is increased by 2 black dice.", null, "Expanded Launchers", 8 },
                    { 167, 19, "While attacking at close range, you may discard this card to add 2 black dice to your attack pool.", null, "External Racks", 4 },
                    { 168, 19, "While attacking a squadron, you may spend 1 black die with a :critical: icon to toggle its activation slider to the activated side.", null, "Flechette Torpedoes", 3 },
                    { 169, 19, "Medium or large ship only. At the end of your Attack Step, you may exhaust this card and choose 1 of your hull zones. Then perform an attack from that hull zone with an anti-squadron armament of 1 black die, even if you have already attacked from that zone this round.", null, "Ordnance Pods", 3 },
                    { 170, 19, "_Modification_. The battery armaments for your left and right hull zones are increased by 1 black die.", null, "Rapid Reload", 4 },
                    { 171, 19, "Black :crit: : If the defender is a ship, choose 1 other ship or squadron at close range of the defender. That ship or squadron suffers damage equal to half of the total number of black Icon Dice Hit icons in your attack pool, rounded up.", null, "Wide-Area Barrage", 2 },
                    { 172, 20, "Modification. Ignition [Long] Ignition Red :crit:: Each other ship at distance 1 of the defender suffers 2 damage, and each squadron at distance 1 of the defender suffers 1 damage.", null, "Orbital Bombardment Particle Cannons", 5 },
                    { 173, 20, "Modification. Ignition [Medium] Ignition Red :crit:: The defender suffers 1 damage. This occurs once for each red or blue :crit: icon in the pool.", null, "Superheavy Composite Beam Turbolasers", 7 },
                    { 174, 21, "After the end of your activation, you may exhaust this card to choose 1 enemy ship at distance 1-5. That ship's speed is increased or decreased to match your speed. While your speed is 0, you cannot ready this card.", null, "Magnite Crystal Tractor Beam Array", 10 },
                    { 175, 22, ":repair: : You may treat the maximum shield values of your right and left hull zones as increased by 1 when you recover or move shields to those zones. If you do, the number of shields in those zones cannot exceed a maximum of \"4\".", null, "Auxiliary Shields Team", 3 },
                    { 176, 22, ":navigate: : After you execute a maneuver in which you did not overlap a ship, you may exhaust this card to execute a speed-1 maneuver.", null, "Engine Techs", 8 },
                    { 177, 22, ":repair: : Gain 1 additional engineering point.", null, "Engineering Team", 3 },
                    { 178, 22, "After you execute a maneuver, you may select a number of unengaged friendly squadrons up to your squadron value at close-medium range. Those squadrons may move up to distance 1.", null, "Fighter Coordination Team", 3 },
                    { 179, 22, "Before you are dealt a faceup damage card with the Crew trait, you may discard this card to discard that damage card.", null, "Medical Team", 1 },
                    { 180, 22, ":nav: If you spent a :nav: token, once during this maneuver, when you would change your speed, you may instead increase 1 yaw value by 1.", null, "Nav Team", 4 },
                    { 181, 22, ":repair: : You may spend up to 2 engineering points to move that many shields from your ship to a friendly ship at distance 1-5.", null, "Projection Experts", 6 },
                    { 182, 23, "Droid only. :repair: : You may exhaust this card. If you do: - Flip any number of your faceup damage cards with the CREW trait facedown. - Discarding facedown damage cards costs 1 fewer engineering point.", null, "Battle Droid Reserves", 4 },
                    { 183, 24, "While defending, during the Spend Defense Tokens step, you may discard a defense token to cancel 1 attack die.", null, "Admonition", 10 },
                    { 184, 24, "Mark I only. After you deploy, gain 1 :evade: defense token. When an enemy ship overlaps you, you may deal 1 additional facedown damage card to both ships.", null, "Amity", 6 },
                    { 185, 24, "When you deploy this ship, you may move shields to up to 2 of your hull zones from your other hull zones. If you do, the number of shields in a zone cannot exceed a maximum of \"6\". You cannot recover shields while any zone is greater than its maximum shield value.", null, "Aspiration", 3 },
                    { 186, 24, "While defending against an attack that does not target your rear hull zone, before you suffer damage reduce the total damage by 1.", null, "Bright Hope", 2 },
                    { 187, 24, "Mark I only. After you deploy, gain 1 :salvo: defense token. While defending, if your speed is 0, during your Spend Defense Tokens step, you can spend 1 defense token.", null, "Concord", 12 },
                    { 188, 24, "While attacking a ship that has already activated this round, add 1 die of any color to your attack pool.", null, "Defiance", 5 },
                    { 189, 24, "BLUE :crit: Cancel all attack dice to deal 1 faceup damage card to the defender.", null, "Dodonna's Pride", 4 },
                    { 190, 24, "At the start of the first round, gain 1 :contain: defense token.", null, "Endeavor", 4 },
                    { 191, 24, "When you resolve the :evade: defense effect, you can affect 1 additional die. When you resolve the :redirect: defense effect, you can choose 1 additional adjacent hull zone to suffer damage.", null, "Foresight", 10 },
                    { 192, 24, "Before a friendly squadron at distance 1 suffers damage from an attack, reduce the total damage by 1, to a minimum of 1.", null, "Gallant Haven", 8 },
                    { 193, 24, "When you overlap an enemy ship, the enemy ship suffers a faceup damage card instead of a facedown damage card.", null, "Garel's Honor", 4 },
                    { 194, 24, "While another friendly ship at distance 1-5 is attacking, it may change 1 die to a face with an :accuracy: icon.", null, "Home One", 5 },
                    { 195, 24, ":squadron: Each squadron you activate may increase its speed to 4 until the end of its activation. Squadrons that change speed in this way cannot attack this activation.", null, "Independence", 8 },
                    { 196, 24, "You can ignore the effects of overlapping obstacles. Your attacks cannot be obstructed.", null, "Jaina's Light", 5 },
                    { 197, 24, "You gain 1 additional :fleet-command: icon in you upgrade bar. You cannot equip this card if you have a :fleet-command: icon in your upgrade bar. You cannot spend a command token to resolve a :fleet-command: card's effect.", null, "Liberator", 2 },
                    { 198, 24, ":squadron:: If you spent a :squadron: token, you may activate 1 additional squadron.", null, "Liberty", 3 },
                    { 199, 24, "MC only. :repair: : You may choose and exhaust another copy of this card on a friendly ship at distance 1-4. If you do, gain 2 additional engineering points.", null, "Mon Calamari Exodus Fleet", 5 },
                    { 200, 24, ":confire:: While attacking a ship, the defender cannot spend more than 1 defense token during this attack.", null, "Mon Karren", 6 },
                    { 201, 24, "While attacking a ship you have already attacked this round, add 1 black die to your attack pool.", null, "Paragon", 5 },
                    { 202, 24, "You gain 1 additional :officer: icon in your upgrade bar. You can be assigned up to 4 command tokens instead of a number of command tokens equal to your command value.", null, "Phoenix Home", 3 },
                    { 203, 24, "Before deploying fleets, you may set aside 1 small ship with a command value of 1. At the start of any round, you may deploy the set-aside ship at distance 1. You may un-equip up to 1 :commander: and 1 :officer: upgrade cards and equip them to it (if able).", null, "Profundity", 7 },
                    { 204, 24, ":nav:: After you execute a maneuver, you may exhaust this card to execute a 1-speed maneuver with a yaw of \"-\".", null, "Quantum Storm", 1 },
                    { 205, 24, "When a friendly ship at distance 1-5 resolves a :repair: command, it gains 1 additional engineering point.", null, "Redemption", 5 },
                    { 206, 24, "While attacking a ship from your front hull zone, your :crit: icons count as 2 damage instead of 1.", null, "Salvation", 7 },
                    { 207, 24, "Before you gain a command token, 1 friendly ship at distance 1-5 may gain that token instead.", null, "Tantive IV", 3 },
                    { 208, 24, "When you suffer damage from an attack, you may choose and exhaust a copy of this card on another friendly ship at distance 1-3. If you do, that ship suffers 1 of your damage instead. While this card is exhausted, you cannot spend engineering points.", null, "Task Force Antilles", 3 },
                    { 209, 24, "While attacking, you may choose and exhaust a copy of this card on another friendly ship at distance 1-3 to reroll up to 2 attack dice. While this card is exhausted, you cannot attack ships.", null, "Task Force Organa", 1 },
                    { 210, 24, "After you deploy, gain 1 :redirect: defense token. While attacking a squadron, if the defender is engaged with a friendly squadron without the printed Heavy keyword, you may reroll 1 die.", null, "Unity", 10 },
                    { 211, 24, "You gain 1 additional :weapons-team: icon in your upgrade bar. At the start of the first round, you may replace 1 of your defense tokens with a :redirect: defense token.", null, "Vanguard", 4 },
                    { 212, 24, ":squadron:: Each squadron you activate may choose to only attack during your activation. If it does, while attacking, it may add 1 die to its attack pool of a color already in its attack pool.", null, "Yavaris", 5 },
                    { 213, 25, "While attacking a squadron, you may reroll 1 attack die.", null, "Annihilator", 8 },
                    { 214, 25, "While attacking, you may exhaust this card. If you do, the defender cannot spend more than 1 exhausted defense token during this attack.", null, "Avenger", 5 },
                    { 215, 25, "After the start of the Ship Phase, you may spend 1 :confire: to place your targeting token within your special firing arc within the range specified by one of your Ignition keywords.", null, "Cataclysm", 5 },
                    { 216, 25, "When another friendly ship resolves a :squadron: command, up to 2 of the squadrons it activates can be at close-medium range of you.", null, "Centicore", 3 },
                    { 217, 25, "You gain 1 :fleet-command: icon in your upgrade bar. You cannot equip this card if you have a :fleet-command: icon in your upgrade bar. At the start of the Command Phase, you may discard 1 :fleet-command: upgrade card you have equipped and replace it with another :fleet-command: upgrade card.", null, "Chimaera", 4 },
                    { 218, 25, ":squadron:: The speed of each squadron with BOMBER you activate is increased by 1 until the end of its activation", null, "Corrupter", 3 },
                    { 219, 25, "After deploying fleets you may redeploy this ship within your deployment zone.", null, "Corvus", 2 },
                    { 220, 25, "During your Attack step, you can perform only 1 attack. You can perform 1 of your attacks after you execute your first maneuver during your activation.", null, "Demolisher", 10 },
                    { 221, 25, "Once per round, while attacking from your front hull zone, you may add 1 blue die to your attack pool for each of your discarded defense tokens.", null, "Devastator", 10 },
                    { 222, 25, "When attacking at close-medium range, you may spend up to 2 shields from any of your hull zones to add that number of blue dice to your attack pool.", null, "Dominator", 7 },
                    { 223, 25, "When an enemy ship overlaps you, the enemy ship suffers a faceup damage card instead of a facedown damage card.", null, "Eclipse", 3 },
                    { 224, 25, "You can be assigned any number of command tokens of any types, instead of a number of command tokens equal to your command value.", null, "Executor", 2 },
                    { 225, 25, "Before you reveal a command, you may exhaust this card to choose another friendly ship at distance 1-5 and ready 1 of its defense tokens.", null, "Hand of Justice", 2 },
                    { 226, 25, "You gain 1 additional :support-team: icon in your upgrade bar. When you execute a speed-1 maneuver, during your Determine Course step, you may change your first yaw value to \"II\" until the end of your activation.", null, "Harrow", 3 },
                    { 227, 25, "At the end of your Attack Step, choose 1 of your hull zones. You may perform an attack against 1 enemy squadron from that hull zone, even if you have already attacked from that zone this round.", null, "Impetuous", 4 },
                    { 228, 25, "The black dice in your battery armament can be used at medium range. This effect applies only while attacking the rear hull zone of a ship.", null, "Insidious", 3 },
                    { 229, 25, "Enemy squadrons at distance 1 are treated as if they are engaged by 2 additional squadrons, even if they are not currently engaged.", null, "Instigator", 4 },
                    { 230, 25, "When a ship activates, you may exhaust this card to ready 1 other upgrade card equipped to this ship.", null, "Interdictor", 3 },
                    { 231, 25, "When you reveal a command other than a :squadron: command, you may discard this card to resolve a :squadron: Command. You treat this command as if you spent a :squadron: dial.", null, "Pursuant", 2 },
                    { 232, 25, ":nav:: While executing a 0-speed maneuver, you can resolve clicks of yaw at the speed-0 joint, and are treated as having a yaw value of \"I\" for that maneuver.", null, "Rakehell", 4 },
                    { 233, 25, ":confire:: Your :confire: tokens can either reroll 1 attack die or add 1 die to your attack pool. If you add a die, that die must be of a color already in your attack pool.", null, "Ravager", 4 },
                    { 234, 25, "The total number of command dials that must be assigned to your ship during the Command Phase is reduced by 1.", null, "Relentless", 3 },
                    { 235, 25, "Star Destroyer only. While defending against an attack that targets your front hull zone, before you suffer damage, you may choose and exhaust a copy of this card on another friendly ship at distance 1-4 to reduce the total damage by 1.", null, "Seventh Fleet Star Destroyer", 5 },
                    { 236, 25, "At the start of Ship Phase, you may exhaust this card to discard 1 command token from up to 3 friendly ships at distance 1-5. If you do, each of those ships may gain 1 command token of any type.", null, "Sovereign", 4 },
                    { 237, 25, "When you activate, you may choose up to 3 unengaged, friendly squadrons at close-medium range. Those squadrons may move up to distance 2. If they do, they cannot end their movement engaged.", null, "Squall", 7 },
                    { 238, 25, "While a friendly squadron with Swarm at distance 1-2 is defending, the attack is treated as obstructed.", null, "Stronghold", 3 },
                    { 239, 25, "Blue or Black :crit:: You may discard this card to choose and discard 1 :offensive-retro:, :defensive-retro:, :ordnance:, :ion-cannon:, or :turbolaser: upgrade card equipped to the defender.", null, "Sunder", 10 },
                    { 240, 25, "After an enemy ship ends its activation, if it is at distance 1-3, you may choose and exhaust 1 of its defense tokens.", null, "Suppressor", 4 },
                    { 241, 25, ":squadron:: The speed of each squadron without heavy you activate is increased by 1, to a maximum of 5, until the end of its activation.", null, "Vector", 2 },
                    { 242, 25, "While attack, you may change 1 die face with an :accuracy: icon to a face with a :hit: icon.", null, "Warlord", 8 },
                    { 243, 26, "Before you reveal a command, you may discard your top command dial.", null, "FB-88", 4 },
                    { 244, 26, "Before a friendly ship or squadron at distance 1-2 suffers damage from an attack, you may exhaust this card and spend up to 2 shields from your front hull zone to reduce the total damage by that amount.", null, "Implacable", 4 },
                    { 245, 26, ":squadron:: Each non-unique squadron that you activate gains swarm until the end of its activation. Each squadron with swarm that you activate may reroll 1 die while attacking a ship.", null, "Nevoota Bee", 5 },
                    { 246, 26, "You gain 1 :fleet-support: icon in your upgrade bar. You cannot equip :turbolaser: or :ordnance: upgrades.", null, "Radiant VII", 1 },
                    { 247, 26, "You must choose at least 2 types of command tokens for this card. After you resolve a command by spending a dial, you may discard 1 matching command token from this card to gain that token.", null, "Resolute", 4 },
                    { 248, 26, "During your Determine Course step, if you are at distance 1-2 of an obstacle, you may change your speed by 1 or increase 1 yaw value by 1.", null, "Swift Return", 3 },
                    { 249, 26, "After you deploy, gain 1 additional :evade: defense token.", null, "TB-73", 5 },
                    { 250, 26, "While defending, after the Spend Defense Tokens step, if you spent fewer than 2 defense tokens, you may move up to 2 shields from 1 of your hull zones to the defending hull zone. If you do, the number of shields in that zone cannot exceed a maximum of '6'. You cannot recover shields while any zone is greater than its maximum shield value.", null, "Tranquility", 7 },
                    { 251, 26, "While another friendly non-flotilla ship resolves a :squadron: command, up to 3 squadrons without adept that it activates can be at close range of you (even if the squadrons are beyond close-medium range of that ship). This effect is not active during the first round.", null, "Triumphant", 5 },
                    { 252, 27, "When you activate you may exhaust this card and spend 1 or more of your Defense Tokens to choose the same number of Defense Tokens of a friendly ship at distance 1-3 and ready those Defense Tokens.", null, "Beast of Burden", 6 },
                    { 253, 27, "Before you suffer damage from an attack, if the defending hull zone has at least 1 shield remaining, you may exhaust this card to reduce the total damage by 1.", null, "Foreman's Labor", 5 },
                    { 254, 27, "At the end of Command Phase or Ship Phase, you may discard a :redirect: defense token to move shields to 1 of your hull zones. If you do, the number if shields in that zone cannot exceed a maximum of \"6\". You cannot recover shields in that zone while it is greater than its maximum shield value.", null, "Gilded Aegis", 5 },
                    { 255, 27, "You gain 1 additional :defensive retrofit: icon in your upgrade bar.", null, "Invincible", 5 },
                    { 256, 27, "While deploying fleets, if you are in the play area, when you would deploy a squadron with SWARM, you may set that squadron aside next to your ship card instead. You may set aside up to 5 squadrons this way. :squadron: : Choose any number of squadrons set aside with this card. Then place them within distance 1-3 of you. During your activation, those squadrons cannot move, and if they have AI, may increase their AI value by 1.", null, "Invisible Hand", 8 },
                    { 257, 27, "Treat your rear hull zone's printed battery armament as 3 red dice. The battery armament of your left and right hull zones are each increased by 1 black die and decreased by 1 blue die.", null, "Lucid Voice", 6 },
                    { 258, 27, "When you are deployed, you must choose 1 of each type of command token for this card. Your command value is increased to 4. You can be assigned more than 1 of each type of command token. When you reveal a command, you may discard all of the tokens from this card to gain them.", null, "Nova Defiant", 4 },
                    { 259, 27, "While attacking a ship at medium-long range, if this is your first attack during your activation, you may add 2 blue dice to your attack pool. If you do, you cannot attack again during this activation.", null, "Patriot Fist", 6 },
                    { 260, 27, "While defending, if you are at speed 2 or higher, you may spend a defense token to resolve the :evade: defense effect instead of that token's effect. You cannot resolve the :evade: defense effect more than once per attack.", null, "Sa Nalaor", 5 },
                    { 261, 27, "Before you are dealt a faceup damage card with the SHIP trait, you may exhaust this card to discard that damage card (without resolving its effect).", null, "Tide of Progress XII", 2 },
                    { 262, 28, "While performing a :salvo: attack, you may change 1 die to a face with a :critical: icon.", null, "DBY-827 Heavy Turbolaser", 3 },
                    { 263, 28, "_Modification_. While attacking you may exhaust this card to add 1 red die to your attack pool. If you do, remove 1 die from the attack pool.", null, "Dual Turbolaser Turrets", 4 },
                    { 264, 28, "_Modification_. The battery armaments for your left and right hull zones are increased by 1 red die.", null, "Enhanced Armament", 10 },
                    { 265, 28, "_Modification_. While attacking, you may change 1 die face with a :hit: or :crit: icon to a face with an :accuracy: icon.", null, "H9 Turbolasers", 8 },
                    { 266, 28, "While attacking a squadron, before you gather dice, if the defender is not engaged with a friendly squadron you may replace all of the blue dice in your anti-squadron armament with red dice.", null, "Heavy Fire Zone", 2 },
                    { 267, 28, "While attacking, the :brace: defense effect cannot reduce the damage total by more than 1 unless it is the only defense token spent by the defender during the attack.", null, "Heavy Turbolaser Turrets", 4 },
                    { 268, 28, "While attacking a squadron, you may reroll 1 red die in your attack pool. While attacking a ship, if you have the bombard tag, you may reroll 1 red die in your attack pool. During your activation, while attacking the first squadron during an attack, you may exhaust this card to add 2 dice of any color to your attack pool. If you do, you cannot declare additional squadron targets for this attack.", null, "Linked Turbolaser Towers", 7 },
                    { 269, 28, "_Modification_. While attacking a ship with a higher speed than yours, you may add 1 blue die to your attack pool.", null, "Quad Battery Turrets", 5 },
                    { 270, 28, "_Modification_. While attacking, if at least 1 red die face has an :accuracy: icon, add 1 red die set to the :accuracy: icon to your attack pool.", null, "Quad Turbolaser Cannons", 10 },
                    { 271, 28, "_Modification_. You cannot attack more than once per round. While attacking a ship, add 1 red die to your attack pool.", null, "Slaved Turrets", 6 },
                    { 272, 28, "_Modification_. The battery armaments for your front and rear hull zones are increased by 1 red die.", null, "Spinal Armament", 9 },
                    { 273, 28, "While attacking, you may exhaust this card and spend 1 :evade: defense token to change 1 red die to a face with a :critical: icon or 2 :hit: icons.", null, "Turbolaser Reroute Circuits", 7 },
                    { 274, 28, "While attacking, if the defender spends a :redirect: token, it cannot suffer more than 1 damage on each hull zone other than the defending hull zone when it resolves the :redirect: defense effect.", null, "XI7 Turbolasers", 6 },
                    { 275, 28, ":critical:: The first 2 damage cards dealt to the defender by this attack are dealt faceup.", null, "XX-9 Turbolasers", 2 },
                    { 276, 29, "_Modification_. When you reveal a command, you may exhaust this card to choose 1 of your hull zones and mark it with a focus token. While attacking a ship from that hull zone, add 1 die of any color from an adjacent hull zone's armament to your attack pool. While attacking from adjacent hull zones, remove 1 die from your attack pool. When you ready this card, remove that focus token.", null, "Swivel-Mount Batteries", 8 },
                    { 277, 30, "While attacking, you may exhaust this card to reroll any number of dice of 1 color.", null, "Caitken and Shollan", 6 },
                    { 278, 30, ":confire:: You may discard a :confire: token assigned to another friendly ship at distance 1-5 of the defender. If you do, add 1 blue die set to the :accuracy: to your attack pool.", null, "Clone Gunners", 4 },
                    { 279, 30, "During the Resolve Damage Step, you may exhaust this card to resolve 1 additional critical effect. You cannot resolve the same critical effect twice.", null, "Fire-Control Team", 2 },
                    { 280, 30, ":squadron:: When a squadron you activate attacks, before gathering dice, increase its anti-squadron armament by 1 blue die until the end of the attack.", null, "Flight Controllers", 6 },
                    { 281, 30, "After you deploy, place 1 red die set to a blank face on this card. If you are the second player, set it to any face instead. While attacking a ship, you may spend 1 die from the attack pool to exchange it with the die on this card. Both dice remain set to their current faces.", null, "Gunnery Chief Varnillian", 6 },
                    { 282, 30, ":confire:: The next attack you perform this activation can be performed from this hull zone. Each of your hull zones cannot target the same ship or squadron more than once during your activation.", null, "Gunnery Team", 7 },
                    { 283, 30, "After you deploy, you must replace 1 of your defense tokens with a :salvo: defense token.", null, "Local Fire Control", 4 },
                    { 284, 30, "While attacking, you may reroll up to 2 black dice.", null, "Ordnance Experts", 4 },
                    { 285, 30, "After attacking a squadron, you may deal 1 damage to a friendly squadron engaged with the defender. If you do, the defender suffers 1 damage.", null, "Ruthless Strategists", 4 },
                    { 286, 30, "While attacking, you may exhaust this card and spend 1 die to change 1 of your dice to a face with an :accuracy: icon.", null, "Sensor Team", 5 },
                    { 287, 30, "While attacking, you may exhaust this card to reroll all dice in your attack pool.", null, "Veteran Gunners", 5 },
                    { 288, 30, "While attacking a ship, you may change 1 die face with a :accuracy: icon to a face with :crit: icon.", null, "Weapons Battery Techs", 4 },
                    { 289, 31, "When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Look at its facedown damage cards and flip a number of them faceup up to your engineering value (one at a time).", null, "Boarding Engineers", 2 },
                    { 290, 31, "When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Choose and spend a number of its defense tokens up to your squadron value.", null, "Boarding Troopers", 3 },
                    { 291, 31, "When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. If you do you may choose a new command for each command dial assigned to that ship. Then you may choose a new command dial for each of those command dials to be set to.", null, "Cham Syndulla", 5 },
                    { 292, 31, "When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Choose and discard 1 non-:commander: upgrade card equipped to that ship.", null, "Darth Vader", 3 },
                    { 293, 31, "When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. If that ship has no raid tokens, it gains 2 raid tokens of your choice. If that ship has an objective token, you may also gain 1 victory token.", null, "Jyn Erso", 4 },
                    { 294, 31, "When you reveal a command, you may discard a :squadron: dial or token and this card to choose 1 enemy ship at close range. Choose and discard 1 :weapons-team:, :support-team:, :offensive-retro:, :defensive-retro:, :ordnance:, :ion-cannon:, or :turbolaser: upgrade card equipped to that ship.", null, "Shriv Surgaav", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "Can attack from the same hull zone twice...", "Gunnery Team", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While performing a Salvo attack, you may change 1 die to face a hit/crit ($\\text{A}/\\text{B}$) icon.", "DBY-827 Heavy Turbolasers", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking, you may change 1 red die to face a hit ($\\text{A}$) icon.", "Dual Turbolaser Turrets", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking, you may change 1 hit or crit icon to an accuracy icon.", "H9 Turbolasers", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking a ship, if the defender uses the brace defense token, that token reduces the total damage by only 1 instead of halving it.", "Heavy Turbolaser Turrets", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking, you may reroll 1 red die. During your first anti-squadron attack each activation, you may add 1 red die to your attack pool.", "Linked Turbolaser Towers", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking a ship, if your current speed is less than the defender's current speed, you may add 1 blue die to your attack pool.", "Quad Battery Turrets", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking a ship, if you have at least 1 accuracy icon, you may add 1 red die with a hit icon to your attack pool.", "Quad Turbolaser Cannons", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "You cannot attack a ship more than once per activation. While attacking a ship, you may add 1 red die to your attack pool.", "Slaved Turrets", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking a ship, if your attack originates from your forward or rear hull zone, you may add 1 red die to your attack pool.", "Spinal Armament", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "During the attack step, you may spend 1 evade token to change 1 red die to a double-hit or crit icon.", "Turbolaser Reroute Circuits", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking a ship, the defender can resolve only 1 redirect token effect to redirect damage to another hull zone.", "XI7 Turbolasers", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 28, "While attacking a ship, if you deal a critical hit, the defender is dealt the first 2 damage cards of that attack faceup.", "XX-9 Turbolasers", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "Black crit effect: Deal 1 faceup damage card to the defender before damage is resolved.", "Assault Proton Torpedoes", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "Black crit effect: The hull zone adjacent to the defending hull zone suffers 1 damage.", "Concussion Missiles", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "You may add 2 black dice to your forward battery armament.", "Expanded Launchers", 13 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "While attacking a ship at close range, you may discard this card to add 2 black dice to your attack pool.", "External Racks", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "While attacking a squadron, if you roll a crit icon, flip the defender's activation slider.", "Flechette Torpedoes", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "Medium or large ship only. At the end of your attack step, you may exhaust this card and choose 1 of your hull zones. Then perform an attack from that hull zone with an anti-squadron armament of 1 black die.", "Ordnance Pods", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "You may add 1 black die to your left and right battery armaments.", "Rapid Reload", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 19, "Black crit effect: Choose another enemy ship or squadron at distance 1 of the defender. It suffers damage equal to half of the total black hit icons in the attack pool, rounded up.", "Wide-Area Barrage", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue crit effect: The defending hull zone and each adjacent hull zone lose 1 shield.", "Heavy Ion Emplacements", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "You may add 1 blue die to your left and right battery armaments.", "High-Capacity Ion Turbines", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue crit effect: The defender either loses 1 shield from the defending hull zone or discards 1 of its command tokens.", "Ion Cannon Batteries", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "While attacking a ship, you may discard 1 blue die from your attack pool to reroll any number of your other dice.", "Leading Shots", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue crit effect: Choose 1 upgrade card equipped to the defender; exhaust that card.", "MS-1 Ion Cannons", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue crit effect: The defender must discard 1 defense token instead of exhausting it.", "NK-7 Ion Cannons", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "Blue crit effect: Exhaust each of the defender's defense tokens.", "Overload Pulse", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 10, "While attacking, you may treat your blue accuracy icons as hit icons.", "SW-7 Ion Batteries", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "While defending, you can resolve a contain token to cancel standard critical effects.", "Damage Control Officer", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "During the Command Phase, you may discard this card to place your top command dial on the bottom of your command stack.", "Skilled First Officer", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "You may resolve a squadron command after your ship has moved instead of before it moves.", "Flight Commander", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "During the Command Phase, you may discard this card to discard all of your command dials and replan.", "Support Officer", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "While a friendly ship is spending a command token, it may treat that token as if it were a command dial.", "Leia Organa", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "When your ship resolves a command from its dial, it gains a matching command token.", "Raymus Antilles", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "While defending, you may discard this card to force the attacker to reroll all of their attack dice.", "Lando Calrissian", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "While attacking at distance 1–3, friendly ships and squadrons may reroll 1 blue die.", "Toryn Farr", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "When your ship activates, you may discard this card to ready 1 of your exhausted defense tokens.", "Walex Blissex", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "During the ship placement phase, you may replace 1 of your defense tokens with an evade token.", "Captain Needa", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "Your upgrade bar gains 1 defensive retrofit icon. Imperial ship only.", "Minister Tua", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While defending, you may exhaust this card and an obstacle at distance 1–2 to cancel 1 attack die.", "Captain Brunson", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While attacking, you may discard another upgrade card equipped to this ship to reroll any number of attack dice.", "Darth Vader (Officer)", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While resolving a squadron command, you may choose up to 2 engaged friendly squadrons; those squadrons can move as if they were not engaged, but cannot attack.", "Admiral Chiraneau", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 17, "You may discard this card to allow a friendly ship at distance 1–5 (or your ship) to activate +1 squadron this round.", "Clone Captain Rex" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "When you spend a navigate token, you may choose a friendly ship at distance 1–5; it gains a navigate token.", "Clone Navigation Officer", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 17, "When you would spend a command token, you may exhaust this card to not discard that token.", "Admiral Yularen" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "At the end of the ship placement phase, your left and right hull zones each gain 1 shield, up to their maximum values.", "Wat Tambor", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When another friendly ship at distance 1–5 reveals a command dial, you may gain a matching command token.", "Rune Haako", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "At the beginning of the Command Phase, you may gain 1 concentrate fire token.", "San Hill", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "While attacking, choose 1 defense token. If the defender spends that token during this attack, discard it instead of exhausting it.", "Intel Officer", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "During the Command Phase, you may discard this card to gain 1 command token of your choice.", "Veteran Captain", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "During setup, you gain a pass token. You may spend this token during the ship phase to pass your activation.", "Strategic Adviser", 16 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "You may exhaust this card to gain 2 different command tokens. Then, choose an enemy ship at distance 1–5; it gains 1 of those tokens.", "Hondo Ohnaka", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "After you resolve a squadron command, you may exhaust this card to ready 1 friendly squadron you activated.", "Adar Tallon", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "When you suffer damage from an attack, reduce the total damage suffered by 1 to a minimum of 1. Once per round.", "Major Derlin", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "During the Command Phase, you may discard 1 command token to change your top command dial to any other command.", "Ahsoka Tano", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "When you reveal a command dial, you may choose a command token you own. Treat that dial as if it were a matching command.", "Hera Syndulla (Officer)", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 14, "While attacking a ship at distance 1–3, you may assign 1 raid token to the defender.", "Jyn Erso", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 16, "At the start of the ship placement phase, you may choose an enemy ship and change its speed by 1 (to a minimum of 0 and a maximum of its max speed).", "Admiral Titus" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "While attacking a unique squadron, you may add 1 red or black die to your anti-squadron attack pool.", "Agent Kallus", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 16, "When you execute a navigate command, you may change your speed by up to 1 beyond the normal restrictions.", "Captain Ozzel", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "Friendly non-heavy squadrons at distance 1–2 of your ship gain counter 1.", "Instructor Goran", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 16, "At the start of the Command Phase, you may look at an enemy ship's command dials.", "Director Isard" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 16, "When you would spend a command token, you may exhaust this card to not discard that token.", "Wulff Yularen (Imperial)" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "During the Command Phase, you may discard this card to give 1 command token of your choice to up to two other friendly ships at distance 1–5.", "Bail Organa (GAR)", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 17, "While your ship is attacking, you may exhaust this card and discard 1 concentrate fire token to reroll up to 2 attack dice.", "Clone Commander Wolffe", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 17, "Friendly squadrons at distance 1–3 of your ship force the attacker to reroll 1 attack die while defending.", "Aayla Secura" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "While spending a command token, you may treat that token as if it were a command dial.", "T-Series Tactical Droid", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When you resolve a command (from a dial or token), you may gain 1 command token of a type different from that command.", "Passel Argente", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "When you reveal a command dial that matches the command dial you revealed during the previous round, you may gain a matching command token.", "Tikkes", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 18, "While resolving a squadron command, 1 friendly squadron at distance 1–3 gains swarm until the end of the round.", "Poggle the Lesser", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 4, "While resolving a redirect token, you may distribute damage to any of your hull zones' shield tracks instead of just adjacent ones.", "Advanced Projectors" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "While defending, you may exhaust this card to resolve a defense token even if it has been targeted by an accuracy icon.", "Electronic Countermeasures", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "Choose 1 of your hull zones. Attacks targeting that hull zone are obstructed.", "Early Warning System", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "During the Status Phase, you may recover 1 shield in any 1 hull zone.", "Redundant Shields", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "You may discard this card to remove up to 3 facedown damage cards from your ship.", "Reinforced Blast Doors", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "While defending, if you have a ready salvo token, you may discard another defense token to resolve a salvo attack as if you spent that salvo token.", "Reactive Gunnery", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 4, "While an enemy squadron attacks from distance 1, you may discard this card to roll 4 black dice against that squadron. Each hit deals 1 damage.", "Cluster Bombs", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Your squadron value is increased by 1.", "Expanded Hangar Bay", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "When you resolve a squadron command, you may choose squadrons at distance 1–long instead of distance 1–3.", "Boosted Comms", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Your ship gains counter 1.", "Quad Laser Turrets", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "While performing an anti-squadron attack, you may reroll all red and blue critical icons.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "When your ship activates, choose an enemy ship at distance 1–5. If your ship is a larger size class than that ship, it must either discard a navigate token or reduce its speed by 1.", "Phylon Q7 Tractor Beams", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "During deployment, you may place up to your squadron value in squadrons inside your ship. When you resolve a squadron command, you may deploy those squadrons at distance 1 and activate them.", "Rapid Launch Bays", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name", "Point" },
                values: new object[] { "Medium or large ship only. While overlapping a smaller ship, your ship does not suffer damage from the overlap.", "Hardened Bulkheads", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Point" },
                values: new object[] { "When a friendly non-unique swarm squadron is destroyed, you may discard this card to place that squadron at distance 1 with 1 hull remaining.", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 11, "While performing an anti-squadron attack, you may use black dice instead of your anti-squadron armament. You may spend salvo tokens during anti-squadron attacks.", "Flak Guns" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "Friendly non-heavy squadrons at distance 1–2 prevent enemy squadrons at distance 1 from attacking ships while engaged.", "Advanced Transponder Net", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 11, "During setup, you may place 2 mine tokens. Ships and squadrons that overlap or move through these tokens suffer damage.", "Proximity Mines", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "(Lásd az 1. sorszámú kártyát - duplikáció / javított verzió)", "Gunnery Team", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While attacking, you may reroll any number of black dice.", "Ordnance Experts", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While you resolve a squadron command, your activated squadrons add 1 blue die to their anti-squadron attack pools this round.", "Flight Controllers", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While attacking, you may exhaust this card to reroll your entire attack pool.", "Veteran Gunners", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While attacking a ship, you may resolve up to two critical effects.", "Fire-Control Team", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 30, "While attacking, you may exhaust this card and discard 1 die to change another die to an accuracy icon.", "Sensor Team" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While attacking a squadron, after the attack steps, you may inflict 1 damage on a friendly squadron engaged with the defender to inflict 1 damage on the defender.", "Ruthless Strategists", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "During the ship placement phase, you may replace 1 of your defense tokens with a salvo token.", "Local Fire Control", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While attacking, you may exhaust this card to reroll any number of dice of a single color.", "Caitken and Shollan", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 30, "While attacking a ship, you may change 1 blue crit icon to an accuracy icon, OR you may exhaust this card to change 1 accuracy icon to a blue crit icon.", "Weapon Battery Techs", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 6, "After fleets are deployed, you may place 1 grav well token. Enemy ships deployed at distance 1–3 of this token must begin the game at speed 0.", "G7-X Grav Well Projector", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 6, "Before an enemy ship at distance 1–5 executes a maneuver, you may exhaust this card to change its speed by 1 for that maneuver.", "G8 Experimental Projector", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 6, "Before round 1 begins, you may choose and move 1 obstacle up to distance 2.", "Grav Shift Reroute" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 6, "While a friendly ship at distance 1–3 is defending against an attack from close range, you may exhaust this card to force the attacker to reroll up to 4 attack dice.", "Targeting Scrambler", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the beginning of the Ship Phase, you may spend 1 squadron token. If you do, each friendly squadron at distance 1–5 increases its speed by 1 to its max speed this round.", "All fighters, follow me!", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the beginning of the Ship Phase, you may spend 1 navigate token. If you do, each friendly ship at distance 1–5 may increase or decrease its speed by 1 during its maneuver this round.", "Entrapment Formation!", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 7, "At the beginning of the Ship Phase, you may spend 1 concentrate fire token. If you do, while attacking a ship at distance 1–5, friendly ships may change 1 die to a hit icon this round.", "Intensify Firepower!" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the beginning of the Ship Phase, you may spend 1 repair token. If you do, during the Status Phase, each friendly ship at distance 1–5 may recover 1 shield.", "Shields to Maximum!", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 7, "At the beginning of the Ship Phase, you may spend 1 navigate token. If you do, each friendly ship at distance 1–5 gains 1 yaw at its final joint, to a maximum of 2.", "Take Evasive Action!", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 22, "While you resolve an engineering command, you may increase the number of engineering points available from your dial, then exhaust or discard this card.", "Engineering Team", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 22, "At the end of the Status Phase, you may exhaust this card to remove 1 facedown damage card from your ship.", "Damage Control Teams" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 22, "When your ship activates, you may exhaust this card to prevent damage to your crew.", "Medical Team", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 22, "During the Command Phase or when you activate, you may exhaust this card to give a command token to another friendly ship at distance 1–5.", "Comms Net", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 22, "While attacking, you may exhaust this card to change 1 black die to a hit icon after rolling black dice.", "Ammunition Experts", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 22, "During your maneuver or activation, you may exhaust this card to shift 1 shield from one of your hull zones to an adjacent hull zone.", "Auxiliary Shields Team", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "While a friendly bomber at distance 1–5 attacks a ship, it may reroll 1 attack die.", "Bomber Command Center", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 22, "(Duplikáció / lásd a 113. sorszámot)", "Comms Net", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "Friendly and enemy ships and squadrons at distance 1–2 of your ship treat attacks against squadrons as obstructed.", "Jamming Field", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 9, "When you resolve an engineering command, instead of spending engineering points, you may discard 1 damage card from a friendly ship at distance 1–2 or recover 1 shield on it.", "Repair Crews" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 9, "After you execute a maneuver, you may exhaust this card to choose an enemy ship at distance 1–3 and change its top command dial to a command of your choice.", "Slicer Tools" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "When you reveal a command dial, you may discard this card to give up to 5 friendly ships at distance 1–5 1 concentrate fire token.", "Munitions Resupply", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "When you reveal a command dial, you may discard this card to give up to 5 friendly ships at distance 1–5 1 repair token.", "Parts Resupply", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 9, "After you execute a maneuver, you may exhaust this card to choose up to a number of friendly squadrons at distance 1–2 equal to your squadron value; those squadrons may each execute a distance 1 move.", "Fighter Coordination Team", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 20, "Ignition [Close]. While attacking a ship from your ignition arc, each other ship and squadron at distance 1 of the defender suffers 1 damage.", "Orbital Bombardment Particle Cannons" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 20, "Ignition [Long]. While attacking a ship from your ignition arc, after defense tokens are spent, deal 1 damage to each hull zone (other than the defender's) that the line of sight passes through.", "Superheavy Composite Beam Turbolasers", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "While your ship is attacking with only its left or right hull zone during its activation, it may add 2 red dice to its attack pool.", "Admiral Ackbar", 38 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "Before an enemy ship receives a faceup damage card, you may draw 4 damage cards, choose 1 for it to receive, and place the rest on the bottom of the damage deck.", "General Dodonna", 20 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "When a friendly ship or unique squadron is destroyed, it remains in play and can perform actions as normal until the end of the current round.", "General Rieekan", 30 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "Friendly ships and squadrons may spend evade tokens at medium range, and may reroll dice with evade tokens at close range.", "Mon Mothma", 27 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "When a friendly ship is attacking, you may discard 1 shield from any of its hull zones to reroll any number of attack dice.", "Darth Vader (Commander)", 36 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "After deployment, place 3 facedown command dials on this card. During the Command Phase, you may reveal 1: each friendly ship gains a matching command dial this round.", "Grand Admiral Thrawn", 32 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "Each friendly ship's hull value is increased by 1 for small ships, 2 for medium ships, and 3 for large ships.", "Admiral Motti", 24 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "While attacking, each friendly ship may, once per round, discard 1 die to change another die to a face with a crit icon.", "Admiral Screed", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "While a friendly ship is defending, when it spends a defense token, it reduces the total damage suffered by 1 (once per round).", "Obi-Wan Kenobi", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "After deployment, choose 3 command tokens. When an enemy ship spends a matching token, deal 1 damage to it.", "Count Dooku", 30 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 25, "Your ship may perform 1 of its attacks after it executes its maneuver.", "Demolisher (Gladiator-class)", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 25, "While attacking, the defender cannot spend defense tokens that are already exhausted.", "Avenger (Imperial Star Destroyer)", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 25, "Your ship's command value is reduced by 1.", "Relentless (Imperial Star Destroyer)" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 24, "While you resolve a squadron command, activated squadrons that do not move may attack twice.", "Yavaris (Nebulon-B)", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 24, "While a friendly ship at distance 1–5 is attacking, it may change 1 accuracy icon to a hit icon.", "Home One (MC80 Star Cruiser)", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 24, "When you resolve a blue crit effect, instead of resolving its normal effect, the defender is dealt 1 faceup damage card.", "Dodonna's Pride (CR90 Corvette)", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 26, "When a friendly ship at distance 1–5 would suffer damage, you may redirect 1 damage to the Resolute.", "Resolute (Venator-class)", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 27, "You may deploy extra squadrons during setup and deploy them later in the game.", "Invisible Hand (Providence-class)", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 31, "While at distance 1 of an enemy ship, you may exhaust this card to exhaust a number of the defender's defense tokens equal to your squadron value.", "Boarding Troopers", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 31, "While at distance 1 of an enemy ship, you may exhaust this card to flip a number of the defender's facedown damage cards faceup equal to half your engineering value, rounded up.", "Boarding Engineers", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 31, "While at distance 1 of an enemy ship, you may discard this card to choose and discard an upgrade card (other than a commander) equipped to the defender.", "Darth Vader (Boarding Team)", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 31, "While at distance 1 of an enemy ship, you may discard this card to deal 2 faceup damage cards to the defender before the attack is resolved.", "Jyn Erso (Boarding Team)", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 31, "While at distance 1 of an enemy ship, you may discard this card to look at the defender's command dials and change its top dial to a command of your choice.", "Cham Syndulla (Boarding Team)", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { 31, "While at distance 1 of an enemy ship, you may discard this card to choose and discard a weapons team or offensive retrofit upgrade card equipped to the defender.", "Shriv Suurgav (Boarding Team)" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "While attacking a ship, if a friendly squadron is at distance 1 of the target, you may replace up to 2 attack dice with dice of any color.", "Commander Sato", 32 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "When you resolve a navigate command (from a dial or token), your ship gains 1 extra yaw at one of its pivot points.", "General Madine", 30 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "During the Command Phase of rounds 1 and 5, each friendly ship gains command tokens up to its maximum capacity.", "Garm Bel Iblis", 25 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 0, "During setup, choose a friendly ship and set it aside. Later in the game, at the start of a command phase, it may enter play at distance 1 of another friendly ship.", "Admiral Raddus", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "At the beginning of the Command Phase, you may assign 1 command token of the same type to each friendly ship in your fleet.", "Grand Moff Tarkin", 38 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "After deployment, choose 1 defense token type. When an enemy ship spends a token of that type, it must discard it instead of exhausting it unless it spends another token.", "Emperor Palpatine", 35 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "While friendly squadrons attack ships, they may use accuracy icons to exhaust the defender's defense tokens and deal bonus damage.", "Admiral Sloane", 24 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "When a friendly ship uses a navigate token to modify its speed, it may increase or decrease its speed by 2 instead of 1 (to a minimum and maximum speed).", "Admiral Ozzel", 20 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 1, "During your ship's maneuver, it may suffer 1 damage to change its yaw by 1 at the current speed step.", "Moff Jerjerrod", 23 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "While your ships are defending, defense tokens targeted by accuracy icons can still be resolved, but must be discarded if used.", "Luminara Unduli", 25 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "At the beginning of the Ship Phase, each friendly ship may spend 1 command token to trigger a special effect regardless of its dial.", "Anakin Skywalker (Commander)", 29 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 2, "At the beginning of the command phase, you may heal friendly squadrons or grant them escort until the end of the round.", "Plo Koon", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "While attacking a ship, if the defender's command value is less than yours, you may add 1 red die to your attack pool.", "Mar Tuuk", 28 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "While attacking, you may reroll 1 die if another friendly ship at distance 1–3 threatens the target.", "Kraken", 26 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Category", "Description", "Name", "Point" },
                values: new object[] { 3, "While attacking, you may add a bonus die of any color for each raid token on the defending ship.", "TF-1726", 26 });
        }
    }
}
