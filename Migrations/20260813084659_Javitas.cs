using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class Javitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquippedUpgrades");

            migrationBuilder.DropTable(
                name: "ShipCards");

            migrationBuilder.DropTable(
                name: "ShipNames");

            migrationBuilder.DropTable(
                name: "SquadronElements");

            migrationBuilder.DropTable(
                name: "FleetElements");

            migrationBuilder.AddColumn<bool>(
                name: "IsUniqueShip",
                table: "SquadronCards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Objectives",
                table: "Fleet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ships",
                table: "Fleet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Squadrons",
                table: "Fleet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ObjectiveCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectiveCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipUpgradeCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipUpgradeCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipUpgradeCards_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ObjectiveCards",
                columns: new[] { "Id", "Category", "Description", "Name", "Point" },
                values: new object[,]
                {
                    { 1, 0, "Setup: After deploying fleets, each player chooses 1 of their ships to be an objective ship, starting with the first player. Special Rule: The first player's objective ship may perform each of its attacks from the same hull zone. It cannot target the same hull zone or squadron more than once each round with that hull zone. The second player's objective ship may perform each of its attacks from the same hull zone, and it may do so against the same target. End of Game: The fleet point cost of a destroyed objective ship is doubled. Do not double the cost of its upgrade cards.", "Advanced Gunnery", 0 },
                    { 2, 0, "Setup: The 3' edges of the play area become the player edges. Each player's deployment zone is within 2 range ruler lengths of their edge. The second player places all obstacles. Obstacles must be placed beyond 2 range ruler lengths of both player edges and beyond distance 1 of other obstacles. Special Rule: The second player assigns 1 objective token to each of their ships. When a ship with an objective token is destroyed, the first player gains 1 victory token. End of Game: The second player gains 1 victory token for each ship with an objective token within the first player's deployment zone.", "Blockade Run", 20 },
                    { 3, 0, "Setup: Place obstacles, adding the 2 dust fields, as normal. Special Rule: While one of the second player's ships is attacking a ship, the attacker may spend 1 die with an :accuracy: icon. If it does, the attacker's owner gains 1 victory token. While one of the first player's ships is attacking a ship, the attacker may spend 2 dice with :accuracy: icons. If it does, the attacker's owner gains 1 victory token.", "Close-Range Intel Scan", 10 },
                    { 4, 0, "Setup: The second player places all obstacles, excluding the station, beyond distance 5 of both players' edges. Special Rule: When a ship that does not have an objective token ends its movement beyond distance 2 of any obstacles, or beyond distance 1 if that ship belongs to the first player, assign 1 objective token to that ship. When a ship resolves a :repair: command, it may discard its objective token. Each ship has the following critical effect: :critical:: If the defender has an objective token, the attacking ship's owner gains 1 victory token. Then choose and discard 1 command token from the defender. If the defender does not have any command tokens, the defending hull zone loses 1 shield instead.", "Ion Storm", 15 },
                    { 5, 0, "Setup: Place obstacles as normal, adding the 2 dust fields and excluding the station and asteroid fields. Then the second player places the 2 purrgil in the setup area. Each purrgil must be placed beyond distance 1 of all obstacles and beyond distance 5 of both players' edges. Special Rule: Each ship has the following critical effect: :critical:: If this attack is at close-medium range, remove all objective tokens from enemy ships. Then assign an objective token to the attacker. End of Round: After a player moves a purrgil, if that purrgil is at distance 1 of a ship with an objective token, that player may discard 1 objective token from that ship. Then that ship suffers 1 facedown damage and the opposing fleet's owner gains 1 victory token.", "Marked for Destruction", 15 },
                    { 6, 0, "Setup: After deploying fleets, the second player chooses 1 of their ships and 1 of the first player's ships to be the objective ships. Special Rule: While attacking an objective ship, the attacker may add 1 die of any color that is already in its attack pool to its attack pool. End of Game: The fleet point cost of a destroyed objective ship is doubled. Do not double the cost of its upgrade cards.", "Most Wanted", 0 },
                    { 7, 0, "Setup: After deploying fleets, assign 1 objective token to each ship. Special Rule: The first time a ship performs an attack against another ship, discard the attacker's objective token. If the attacker belongs to the first player, add 2 red dice to the attack pool. If the attacker belongs to the second player, add 2 dice, each of any color, to the attack pool. End of Game: Each player increases their final score by half the fleet point cost of each enemy ship in the play area that has at least 1 damage card, rounded up.", "Opening Salvo", 0 },
                    { 8, 0, "Setup: After deploying fleets, each of the second player's ships gains a :confire: token. Special Rule: When a squadron with Bomber or a ship is attacking, it may spend 1 die with a :hit: icon to flip 1 random facedown damage card on the defender faceup. After a squadron with Bomber or a ship performs an attack, its owner gains 1 victory token for each damage card that was dealt faceup or flipped faceup during that attack.", "Precision Strike", 15 },
                    { 9, 0, "Setup: Place obstacles as normal, excluding the station and adding the gravity rift. Special Rule: While a ship is attacking, if the defender is beyond distance 1 of any obstacles and does not have an objective token, the attacker may spend 1 die to assign an objective token to the defender. Then the attacker's owner gains 1 victory token. While a ship with an objective token is defending, during the Resolve Attack Effects step, the attacker may discard that objective token to change 1 die to a face with a :hit: icon or 1 :critical: icon and no other icons. If the attacker belongs to the second player, it may change 1 die to a face with any icon. End of Round: Each ship at distance 1-2 of the gravity rift that is at speed 1 or lower suffers 1 facedown damage card.", "Rift Assault", 10 },
                    { 10, 0, "Setup: Place obstacles as normal, excluding the station. Then the second player places 2 stations in the setup area. Each station must be placed beyond distance 1 of all obstacles and beyond distance 3 of both players' edges. Both stations are Unarmed Stations. Special Rule: The first player's ships and squadrons cannot resolve an unarmed station's effect to discard damage cards or recover hull points when they overlap it. End of Game: The second player gains 1 victory token for each unarmed station that is not destroyed. The first player gains 1 victory token for each unarmed station that is destroyed.", "Station Assault", 40 },
                    { 11, 0, "Setup: The second player places the station at distance 1-5 of the first player's edge. Then place the remaining obstacles as normal. While deploying fleets, the first player must deploy their flagship before deploying any other ships and must deploy their flagship overlapping the station, but it may be beyond their deployment zone. The first player cannot deploy any ship at a speed greater than half of that ship's maximum speed, rounded up. After deploying fleets, the second player places 3 facedown command dials in a stack on this card. Special Rule: At the start of the Ship Phase during the first, second, and third rounds, the second player reveals the top command dial on this card, and each of the first player's ships gains a raid token matching that dial.", "Surprise Attack", 0 },
                    { 12, 0, "Setup: After placing obstacles, the players alternate placing a total of 4 objective tokens in the setup area, starting with the second player. Special Rule: While one of the second player's ships is attacking a ship that is at distance 1-2 of an objective token, the attacker may reroll up to 2 attack dice in the attack pool.", "Targeting Beacons", 0 },
                    { 13, 1, "Setup: The second player places the station in the center of the setup area. Then, starting with the second player, the players alternate placing the remaining obstacles, adding 2 purrgil and 2 dust fields and excluding the asteroid fields, at distance 2-5 of the station. After deploying fleets, each of the second player's ships gains a :repair: token. Special Rule: Each ship can resolve the following effect: :repair:: You may spend engineering points to gain victory tokens from 1 station or dust field at distance 1. If that obstacle is a station, gain 1 token for each 3 points you spend. If that obstacle is a dust field, gain 1 token for each 2 points you spend. Then, if that obstacle is a dust field and you gained more than 1 victory token, remove that obstacle from the play area.", "Abandoned Mining Facility", 10 },
                    { 14, 1, "Setup: The second player places all obstacles, excluding the station. Special Rule: When one of the first player's ships or unique squadrons overlaps an asteroid field, it may recover 1 of its non-:scatter: defense tokens. That token must be exhausted. When one of the second player's ships or unique squadrons overlaps an asteroid field, that obstacle has no effect and that ship or squadron may recover 1 of its non-:scatter: defense tokens or ready 1 of its defense tokens. After the start of each Squadron Phase, after exogorths perform attacks, remove each exogorth obstacle from the play area. End of Round: The second player places the 2 exogorth obstacles, each touching a different obstacle.", "Asteroid Tactics", 0 },
                    { 15, 1, "Setup: After placing obstacles, the second player places 1 objective token at distance 1 of any obstacle and beyond distance 5 of all edges of the setup area. Special Rule: When a ship at distance 1 of the objective token reveals a command dial, the ship's owner may remove that objective token from the play area and place it on that ship's card. When a ship with the objective token on its ship card is destroyed, the opposing player places the objective token in the play area touching the destroyed ship's base. End of Game: If a player's ship has the objective token, that player gains 1 victory token.", "Capture the VIP", 50 },
                    { 16, 1, "Setup: Place obstacles as normal, excluding the station. Then the second player places the station in the setup area beyond distance 1 of all obstacles and beyond distance 5 of both players' edges. Special Rule: The station does not obstruct attacks and does not have the ability to discard damage cards or recover hull points. End of Round: Each player sums the command values of their ships at distance 1 of the station. The player with the highest total gains 1 victory token.", "Contested Outpost", 20 },
                    { 17, 1, "Setup: Before deploying fleets, the second player sets aside all of their squadrons. After deploying fleets, the second player deploys all of their squadrons. Each of those squadrons can be placed as normal or at distance 1 of an obstacle, but all of them must be beyond distance 5 of the first player's edge. Special Rule: After a squadron performs an attack against a ship, if the defender was dealt at least 1 damage card, the squadron's owner gains 1 victory token.", "Fighter Ambush", 15 },
                    { 18, 1, "Setup: After placing obstacles, the second player places 3 objective tokens in the setup area beyond distance 4 of both players' edges. Then the first player may move each objective token to within distance 1-2 of its current position. End of Round: Each player gains 1 victory token for each objective token they control. To determine control of each token, players measure attack range and line of sight from each of their ships' hull zones as if performing attacks with battery armaments targeting that objective token. The player with the highest total number of dice in their combined attack pool controls that token. If a player's ship or squadron overlaps an objective token, their opponent controls that token; if both players' ships or squadrons overlap the same token, neither player controls it.", "Fire Lanes", 15 },
                    { 19, 1, "Setup: The portion of the setup area that is beyond distance 5 of any edge of the setup area is the ambush zone. Players mark the corners of the ambush zone with objective tokens. Players take turns deploying fleets as normal, but must deploy all ships before deploying any squadrons. The first player must deploy ships within the ambush zone on their odd-numbered deployment turns, starting with their first turn. The first player cannot deploy ships or squadrons overlapping obstacles in the ambush zone. After setup is complete, remove all objective tokens from the play area.", "Fleet Ambush", 0 },
                    { 20, 1, "Setup: After deploying fleets, the first player assigns each of their ships 1 objective token. Then the second player assigns each of their ships a number of objective tokens equal to that ship's command value. Special Rule: When a ship with an objective token is declared as the target of an attack, it may discard 1 objective token to ready 1 of its exhausted defense tokens. End of Round: If a ship is at distance 1-5 of 1 of the 3' edges of the play area, or at distance 1-3 of a player edge, remove 1 objective token from that ship. End of Game: Each player gains 1 victory token for each enemy ship in the play area that does not have an objective token.", "Fleet in Being", 15 },
                    { 21, 1, "Setup: Before deploying fleets, the second player sets aside 1 small or medium ship and up to 3 squadrons; do not deploy them during setup. Then the second player places 3 objective tokens in the play area beyond distance 3 of both players' edges. Special Rule: At the start of any round after the first round, the second player may deploy the ship and squadrons that were set aside at distance 1 of 1 objective token. Then remove all objective tokens. The ship may be deployed overlapping squadrons. The first player places those squadrons as though the ship had overlapped them while executing a maneuver. If the second player does not deploy, they may move 1 objective token to within distance 1 of its current position.", "Hyperspace Assault", 0 },
                    { 22, 1, "Setup: Place obstacles as normal, excluding the station and replacing the 2 debris fields with the 2 dust fields. After deploying fleets, the second player places 2 objective tokens in the setup area at distance 1-5 of each other. Special Rule: While attacking, if neither the attacker nor defender is overlapping an objective token and line of sight is traced across an objective token or the line between the 2 objective tokens, the attacker must choose and remove half of the dice from the attack pool, rounded down, before rolling.", "Jamming Barrier", 0 },
                    { 23, 1, "Setup: After placing obstacles, the second player places 3 objective tokens in the play area beyond distance 5 of both players' edges. Special Rule: At the end of the Command Phase, the second player may choose 1 enemy ship at distance 1-3 of an objective token and remove that token from the play area to perform an attack against that ship. The attacker is treated as if it is a ship with a battery armament of 4 blue dice, but is not friendly to any ship or squadron. The attack is treated as being at medium range, cannot be obstructed, can target any of the defender's hull zones, and has the following critical effect: Blue :critical:: The defender must choose and exhaust 1 of its defense tokens.", "Planetary Ion Cannon", 0 },
                    { 24, 1, "Setup: The second player places all obstacles, excluding the station and adding the gravity rift and 2 dust fields. The gravity rift must be placed beyond distance 5 of both players' edges. After deploying fleets, the second player may choose 1 enemy ship. That ship must execute a speed-1 maneuver with a yaw value of '-'. Then the second player may increase or decrease that ship's speed by 1, to a minimum of speed 0. Special Rule: After a ship executes a maneuver, if it is at distance 1-2 of the gravity rift, it must execute a speed-1 maneuver with a yaw value of '-'. If that ship belongs to the second player, it may use its speed-1 yaw value. The gravity rift does not have the ability to temporarily reduce a ship's speed during this maneuver.", "Rift Ambush", 0 },
                    { 25, 2, "Setup: Obstacles must be placed in the setup area beyond distance 5 of both players' edges. After placing obstacles, place 1 objective token on each obstacle. Special Rule: When a ship overlaps an obstacle, the ship's owner may remove the objective token on that obstacle to gain 1 victory token.", "Dangerous Territory", 15 },
                    { 26, 2, "Setup: The second player places the gravity rift in the center of the setup area. Then, starting with the first player, the players alternate placing the remaining obstacles, excluding the station. Then the second player places the station in the setup area beyond distance 1 of all obstacles and beyond distance 5 of both players' edges. End of Round: Starting with the second player and alternating, each player chooses 1 obstacle that does not have an objective token on it and moves it to within distance 1-2 of its current location toward the gravity rift, which cannot be chosen. Then that player places an objective token on that obstacle. When an obstacle touches the gravity rift, that obstacle is removed from the play area. After all obstacles are moved, each player sums the command values of their ships at distance 1 of the station. The player with the highest total gains 1 victory token. Then remove all objective tokens from the play area.", "Doomed Station", 20 },
                    { 27, 2, "Setup: Place obstacles as normal, excluding the station. Then the second player places 1 objective token in the play area at distance 1 of a 3' edge and places 1 objective token at distance 1 of the opposite 3' edge. Special Rule: At the start of the Ship Phase of the first and third rounds, the second player places 1 purrgil not in the play area at distance 1 of 1 objective token; the same objective token must be used during both rounds. Purrgil must move toward the objective token at the opposite 3' edge instead of the closest ship. When a purrgil touches that objective token, remove that purrgil from the play area. End of Round: If a ship has 1 objective token on it, remove the token and that ship's owner gains 1 victory token. If a ship is at distance 1 of a purrgil and has no objective token on it, place 1 objective token on the ship.", "Hyperspace Migration", 20 },
                    { 28, 2, "Setup: Place obstacles as normal, excluding the station. After placing obstacles, place 1 objective token on each obstacle. Then the second player places 2 exogorth obstacles, each touching a different obstacle. Special Rule: When a ship or squadron overlaps an obstacle, its owner may remove the objective token on that obstacle to gain 1 victory token. After the start of each Squadron Phase, after exogorths perform attacks, remove each exogorth from the play area. Then the second player moves the obstacle each exogorth was touching to within distance 1-2 of its current position.", "Infested Fields", 15 },
                    { 29, 2, "Setup: After placing obstacles, the players alternate placing a total of 5 objective tokens in the setup area, starting with the second player. Each token must be placed beyond distance 5 of both players' edges and beyond distance 3 of all other objective tokens. Then each player chooses 1 of their ships to be an objective ship, starting with the first player. Special Rule: When a player's objective ship reveals a command dial, that player may choose 1 objective token at distance 1 of that ship and remove it from the play area to gain 1 victory token. End of Game: If a player has more victory tokens than their opponent, increase that player's final score by 75.", "Intel Sweep", 0 },
                    { 30, 2, "Setup: The second player places all obstacles. They may place them anywhere in the setup area, even in deployment zones, and must place them beyond distance 5 of each other. Then the second player places 6 objective tokens. Each objective token must be placed at distance 1 of an obstacle and beyond distance 1 of all other objective tokens. Special Rule: If a ship ends its movement at distance 1 of an objective token, remove that objective token from the play area and roll 2 blue dice. That ship is dealt 1 facedown damage card for each :hit: or :critical: icon rolled. If there is at least 1 :critical: icon, deal the first damage card faceup.", "Minefields", 0 },
                    { 31, 2, "Setup: Place obstacles as normal, excluding the station. Then the second player places the station in the setup area beyond distance 1 of all obstacles and beyond distance 5 of both players' edges. Special Rule: When a ship overlaps an obstacle and suffers 1 or more damage or is dealt 1 or more damage cards, the opposing fleet's owner gains 1 victory token. End of Round: Starting with the second player and alternating, each player chooses 1 asteroid or debris field that does not have an objective token on it and moves it to within distance 1-2 of its current position. Then that player places an objective token on that obstacle. An obstacle cannot be moved so that it overlaps a ship, squadron, or other obstacle. At the start of the next round, remove all objective tokens from the play area.", "Navigational Hazards", 15 },
                    { 32, 2, "Setup: The second player places the station in the center of the play area. Then, starting with the second player, the players alternate placing the remaining obstacles, adding the 2 dust fields, at distance 1-5 of the station. After placing obstacles, the second player places a total of 4 objective tokens in the setup area. Each token must be at distance 1 of the station and beyond distance 1 of all other objective tokens. After deploying fleets, each of the second player's ships gains a :nav: token. Special Rule: When a player's ship reveals a command dial, that player may choose 1 objective token at distance 1 of that ship and remove it from the play area to gain 1 victory token.", "Salvage Run", 20 },
                    { 33, 2, "Setup: After placing obstacles, the players alternate placing a total of 4 objective tokens in the setup area, starting with the first player. Each token must be placed beyond distance 5 of both players' edges and beyond distance 3 of all other objective tokens. Special Rule: When a ship reveals a command dial, if it is at distance 1 of at least 1 objective token, its owner gains 1 victory token. Then its owner chooses 1 of those objective tokens. The opposing player must move that token so it is at distance 1-2 of its current position. If the opposing player is the second player, they move it so it is at distance 1-4 of its current position.", "Sensor Net", 15 },
                    { 34, 2, "Setup: The first player must deploy all of their ships and squadrons before the second player. After the second player deploys ships and squadrons, the second player must choose 1 of the 3' edges of the play area to be the corona. Special Rule: While a ship is attacking, before resolving any attack effects, if any portion of the corona is inside the attacking hull zone's firing arc, the attacker must discard 1 die with an :accuracy: icon from the attack pool, if able.", "Solar Corona", 0 },
                    { 35, 2, "Setup: The first player must deploy all of their ships and squadrons before the second player. Special Rule: After a ship or squadron performs an attack against the rear hull zone of another ship, if the defender suffers at least 1 damage, the attacker's owner gains 1 victory token.", "Superior Positions", 15 },
                    { 36, 2, "Setup: Place obstacles as normal, excluding the station and adding the 2 dust fields. Special Rule: While a ship is attacking a ship, the attacker may choose 1 obstacle at distance 1 of the defender, then resolve the following critical effect: Blue :critical:: Each ship or squadron at distance 1 of the chosen obstacle suffers damage equal to half of the total number of :critical: icons in the attack pool, rounded up. If the defender is one of the first player's ships, the attacker may resolve this effect with any :critical: icon. End of Round: For each asteroid field, each player sums the command values of their ships at distance 1. For each asteroid field, the player with the highest total gains 1 victory token.", "Volatile Deposits", 15 }
                });

            migrationBuilder.InsertData(
                table: "ShipUpgradeCards",
                columns: new[] { "Id", "Category", "ShipId" },
                values: new object[,]
                {
                    { 1, 14, 1 },
                    { 2, 9, 1 },
                    { 3, 11, 1 },
                    { 4, 24, 1 },
                    { 5, 14, 2 },
                    { 6, 9, 2 },
                    { 7, 11, 2 },
                    { 8, 24, 2 },
                    { 9, 0, 3 },
                    { 10, 14, 3 },
                    { 11, 22, 3 },
                    { 12, 4, 3 },
                    { 13, 28, 3 },
                    { 14, 24, 3 },
                    { 15, 0, 4 },
                    { 16, 14, 4 },
                    { 17, 22, 4 },
                    { 18, 4, 4 },
                    { 19, 10, 4 },
                    { 20, 24, 4 },
                    { 21, 0, 5 },
                    { 22, 14, 5 },
                    { 23, 30, 5 },
                    { 24, 11, 5 },
                    { 25, 31, 5 },
                    { 26, 28, 5 },
                    { 27, 24, 5 },
                    { 28, 0, 6 },
                    { 29, 14, 6 },
                    { 30, 30, 6 },
                    { 31, 11, 6 },
                    { 32, 31, 6 },
                    { 33, 19, 6 },
                    { 34, 24, 6 },
                    { 35, 0, 7 },
                    { 36, 14, 7 },
                    { 37, 30, 7 },
                    { 38, 4, 7 },
                    { 39, 19, 7 },
                    { 40, 28, 7 },
                    { 41, 24, 7 },
                    { 42, 0, 8 },
                    { 43, 14, 8 },
                    { 44, 30, 8 },
                    { 45, 4, 8 },
                    { 46, 19, 8 },
                    { 47, 28, 8 },
                    { 48, 24, 8 },
                    { 49, 0, 9 },
                    { 50, 14, 9 },
                    { 51, 22, 9 },
                    { 52, 28, 9 },
                    { 53, 24, 9 },
                    { 54, 0, 10 },
                    { 55, 14, 10 },
                    { 56, 22, 10 },
                    { 57, 28, 10 },
                    { 58, 24, 10 },
                    { 59, 0, 11 },
                    { 60, 14, 11 },
                    { 61, 22, 11 },
                    { 62, 7, 11 },
                    { 63, 19, 11 },
                    { 64, 24, 11 },
                    { 65, 0, 12 },
                    { 66, 14, 12 },
                    { 67, 22, 12 },
                    { 68, 7, 12 },
                    { 69, 11, 12 },
                    { 70, 24, 12 },
                    { 71, 0, 13 },
                    { 72, 14, 13 },
                    { 73, 30, 13 },
                    { 74, 11, 13 },
                    { 75, 31, 13 },
                    { 76, 4, 13 },
                    { 77, 28, 13 },
                    { 78, 24, 13 },
                    { 79, 0, 14 },
                    { 80, 14, 14 },
                    { 81, 30, 14 },
                    { 82, 11, 14 },
                    { 83, 31, 14 },
                    { 84, 4, 14 },
                    { 85, 28, 14 },
                    { 86, 24, 14 },
                    { 87, 0, 15 },
                    { 88, 14, 15 },
                    { 89, 30, 15 },
                    { 90, 11, 15 },
                    { 91, 31, 15 },
                    { 92, 4, 15 },
                    { 93, 28, 15 },
                    { 94, 10, 15 },
                    { 95, 19, 15 },
                    { 96, 24, 15 },
                    { 97, 0, 16 },
                    { 98, 14, 16 },
                    { 99, 30, 16 },
                    { 100, 11, 16 },
                    { 101, 31, 16 },
                    { 102, 4, 16 },
                    { 103, 19, 16 },
                    { 104, 19, 16 },
                    { 105, 24, 16 },
                    { 106, 0, 17 },
                    { 107, 14, 17 },
                    { 108, 22, 17 },
                    { 109, 4, 17 },
                    { 110, 4, 17 },
                    { 111, 10, 17 },
                    { 112, 28, 17 },
                    { 113, 24, 17 },
                    { 114, 0, 18 },
                    { 115, 14, 18 },
                    { 116, 22, 18 },
                    { 117, 11, 18 },
                    { 118, 4, 18 },
                    { 119, 10, 18 },
                    { 120, 28, 18 },
                    { 121, 24, 18 },
                    { 122, 0, 19 },
                    { 123, 14, 19 },
                    { 124, 30, 19 },
                    { 125, 22, 19 },
                    { 126, 10, 19 },
                    { 127, 28, 19 },
                    { 128, 28, 19 },
                    { 129, 24, 19 },
                    { 130, 0, 20 },
                    { 131, 14, 20 },
                    { 132, 30, 20 },
                    { 133, 22, 20 },
                    { 134, 10, 20 },
                    { 135, 28, 20 },
                    { 136, 28, 20 },
                    { 137, 24, 20 },
                    { 138, 0, 21 },
                    { 139, 14, 21 },
                    { 140, 14, 21 },
                    { 141, 30, 21 },
                    { 142, 11, 21 },
                    { 143, 31, 21 },
                    { 144, 10, 21 },
                    { 145, 28, 21 },
                    { 146, 21, 21 },
                    { 147, 24, 21 },
                    { 148, 0, 22 },
                    { 149, 14, 22 },
                    { 150, 14, 22 },
                    { 151, 30, 22 },
                    { 152, 11, 22 },
                    { 153, 31, 22 },
                    { 154, 10, 22 },
                    { 155, 28, 22 },
                    { 156, 21, 22 },
                    { 157, 24, 22 },
                    { 158, 0, 23 },
                    { 159, 14, 23 },
                    { 160, 14, 23 },
                    { 161, 30, 23 },
                    { 162, 30, 23 },
                    { 163, 11, 23 },
                    { 164, 11, 23 },
                    { 165, 31, 23 },
                    { 166, 31, 23 },
                    { 167, 22, 23 },
                    { 168, 22, 23 },
                    { 169, 24, 23 },
                    { 170, 14, 24 },
                    { 171, 9, 24 },
                    { 172, 11, 24 },
                    { 173, 25, 24 },
                    { 174, 14, 25 },
                    { 175, 9, 25 },
                    { 176, 11, 25 },
                    { 177, 25, 25 },
                    { 178, 1, 26 },
                    { 179, 14, 26 },
                    { 180, 30, 26 },
                    { 181, 11, 26 },
                    { 182, 31, 26 },
                    { 183, 19, 26 },
                    { 184, 25, 26 },
                    { 185, 1, 27 },
                    { 186, 14, 27 },
                    { 187, 30, 27 },
                    { 188, 11, 27 },
                    { 189, 31, 27 },
                    { 190, 10, 27 },
                    { 191, 25, 27 },
                    { 192, 1, 28 },
                    { 193, 14, 28 },
                    { 194, 4, 28 },
                    { 195, 28, 28 },
                    { 196, 25, 28 },
                    { 197, 1, 29 },
                    { 198, 14, 29 },
                    { 199, 22, 29 },
                    { 200, 4, 29 },
                    { 201, 28, 29 },
                    { 202, 25, 29 },
                    { 203, 1, 30 },
                    { 204, 14, 30 },
                    { 205, 30, 30 },
                    { 206, 22, 30 },
                    { 207, 19, 30 },
                    { 208, 25, 30 },
                    { 209, 1, 31 },
                    { 210, 14, 31 },
                    { 211, 30, 31 },
                    { 212, 22, 31 },
                    { 213, 19, 31 },
                    { 214, 25, 31 },
                    { 215, 1, 32 },
                    { 216, 14, 32 },
                    { 217, 30, 32 },
                    { 218, 11, 32 },
                    { 219, 11, 32 },
                    { 220, 31, 32 },
                    { 221, 25, 32 },
                    { 222, 1, 33 },
                    { 223, 14, 33 },
                    { 224, 30, 33 },
                    { 225, 30, 33 },
                    { 226, 11, 33 },
                    { 227, 31, 33 },
                    { 228, 25, 33 },
                    { 229, 1, 34 },
                    { 230, 14, 34 },
                    { 231, 30, 34 },
                    { 232, 11, 34 },
                    { 233, 31, 34 },
                    { 234, 28, 34 },
                    { 235, 19, 34 },
                    { 236, 25, 34 },
                    { 237, 1, 35 },
                    { 238, 14, 35 },
                    { 239, 30, 35 },
                    { 240, 11, 35 },
                    { 241, 31, 35 },
                    { 242, 28, 35 },
                    { 243, 10, 35 },
                    { 244, 25, 35 },
                    { 245, 1, 36 },
                    { 246, 14, 36 },
                    { 247, 22, 36 },
                    { 248, 11, 36 },
                    { 249, 6, 36 },
                    { 250, 10, 36 },
                    { 251, 25, 36 },
                    { 252, 1, 37 },
                    { 253, 14, 37 },
                    { 254, 22, 37 },
                    { 255, 11, 37 },
                    { 256, 6, 37 },
                    { 257, 6, 37 },
                    { 258, 10, 37 },
                    { 259, 25, 37 },
                    { 260, 1, 38 },
                    { 261, 14, 38 },
                    { 262, 30, 38 },
                    { 263, 11, 38 },
                    { 264, 11, 38 },
                    { 265, 31, 38 },
                    { 266, 10, 38 },
                    { 267, 28, 38 },
                    { 268, 25, 38 },
                    { 269, 1, 39 },
                    { 270, 14, 39 },
                    { 271, 30, 39 },
                    { 272, 11, 39 },
                    { 273, 31, 39 },
                    { 274, 4, 39 },
                    { 275, 10, 39 },
                    { 276, 28, 39 },
                    { 277, 25, 39 },
                    { 278, 1, 40 },
                    { 279, 14, 40 },
                    { 280, 30, 40 },
                    { 281, 7, 40 },
                    { 282, 11, 40 },
                    { 283, 31, 40 },
                    { 284, 28, 40 },
                    { 285, 28, 40 },
                    { 286, 25, 40 },
                    { 287, 1, 41 },
                    { 288, 14, 41 },
                    { 289, 30, 41 },
                    { 290, 11, 41 },
                    { 291, 31, 41 },
                    { 292, 4, 41 },
                    { 293, 10, 41 },
                    { 294, 19, 41 },
                    { 295, 25, 41 },
                    { 296, 1, 42 },
                    { 297, 14, 42 },
                    { 298, 30, 42 },
                    { 299, 30, 42 },
                    { 300, 22, 42 },
                    { 301, 20, 42 },
                    { 302, 25, 42 },
                    { 303, 1, 43 },
                    { 304, 14, 43 },
                    { 305, 30, 43 },
                    { 306, 30, 43 },
                    { 307, 28, 43 },
                    { 308, 20, 43 },
                    { 309, 25, 43 },
                    { 310, 1, 44 },
                    { 311, 14, 44 },
                    { 312, 30, 44 },
                    { 313, 4, 44 },
                    { 314, 28, 44 },
                    { 315, 19, 44 },
                    { 316, 19, 44 },
                    { 317, 25, 44 },
                    { 318, 1, 45 },
                    { 319, 14, 45 },
                    { 320, 14, 45 },
                    { 321, 14, 45 },
                    { 322, 30, 45 },
                    { 323, 7, 45 },
                    { 324, 7, 45 },
                    { 325, 11, 45 },
                    { 326, 31, 45 },
                    { 327, 10, 45 },
                    { 328, 28, 45 },
                    { 329, 25, 45 },
                    { 330, 1, 46 },
                    { 331, 14, 46 },
                    { 332, 14, 46 },
                    { 333, 14, 46 },
                    { 334, 30, 46 },
                    { 335, 11, 46 },
                    { 336, 11, 46 },
                    { 337, 31, 46 },
                    { 338, 10, 46 },
                    { 339, 10, 46 },
                    { 340, 28, 46 },
                    { 341, 28, 46 },
                    { 342, 25, 46 },
                    { 343, 1, 47 },
                    { 344, 14, 47 },
                    { 345, 14, 47 },
                    { 346, 14, 47 },
                    { 347, 14, 47 },
                    { 348, 30, 47 },
                    { 349, 7, 47 },
                    { 350, 7, 47 },
                    { 351, 7, 47 },
                    { 352, 7, 47 },
                    { 353, 11, 47 },
                    { 354, 31, 47 },
                    { 355, 28, 47 },
                    { 356, 10, 47 },
                    { 357, 25, 47 },
                    { 358, 1, 48 },
                    { 359, 14, 48 },
                    { 360, 14, 48 },
                    { 361, 14, 48 },
                    { 362, 14, 48 },
                    { 363, 30, 48 },
                    { 364, 7, 48 },
                    { 365, 11, 48 },
                    { 366, 11, 48 },
                    { 367, 31, 48 },
                    { 368, 10, 48 },
                    { 369, 10, 48 },
                    { 370, 28, 48 },
                    { 371, 28, 48 },
                    { 372, 25, 48 },
                    { 373, 2, 49 },
                    { 374, 14, 49 },
                    { 375, 22, 49 },
                    { 376, 5, 49 },
                    { 377, 19, 49 },
                    { 378, 26, 49 },
                    { 379, 2, 50 },
                    { 380, 14, 50 },
                    { 381, 22, 50 },
                    { 382, 12, 50 },
                    { 383, 29, 50 },
                    { 384, 26, 50 },
                    { 385, 2, 51 },
                    { 386, 14, 51 },
                    { 387, 22, 51 },
                    { 388, 9, 51 },
                    { 389, 12, 51 },
                    { 390, 26, 51 },
                    { 391, 2, 52 },
                    { 392, 14, 52 },
                    { 393, 22, 52 },
                    { 394, 9, 52 },
                    { 395, 5, 52 },
                    { 396, 26, 52 },
                    { 397, 2, 53 },
                    { 398, 14, 53 },
                    { 399, 30, 53 },
                    { 400, 12, 53 },
                    { 401, 12, 53 },
                    { 402, 31, 53 },
                    { 403, 29, 53 },
                    { 404, 19, 53 },
                    { 405, 26, 53 },
                    { 406, 2, 54 },
                    { 407, 14, 54 },
                    { 408, 30, 54 },
                    { 409, 5, 54 },
                    { 410, 29, 54 },
                    { 411, 19, 54 },
                    { 412, 26, 54 },
                    { 413, 2, 55 },
                    { 414, 14, 55 },
                    { 415, 30, 55 },
                    { 416, 22, 55 },
                    { 417, 12, 55 },
                    { 418, 31, 55 },
                    { 419, 19, 55 },
                    { 420, 19, 55 },
                    { 421, 26, 55 },
                    { 422, 2, 56 },
                    { 423, 14, 56 },
                    { 424, 30, 56 },
                    { 425, 8, 56 },
                    { 426, 12, 56 },
                    { 427, 31, 56 },
                    { 428, 29, 56 },
                    { 429, 19, 56 },
                    { 430, 26, 56 },
                    { 431, 2, 57 },
                    { 432, 14, 57 },
                    { 433, 30, 57 },
                    { 434, 12, 57 },
                    { 435, 31, 57 },
                    { 436, 5, 57 },
                    { 437, 29, 57 },
                    { 438, 19, 57 },
                    { 439, 26, 57 },
                    { 440, 14, 58 },
                    { 441, 30, 58 },
                    { 442, 10, 58 },
                    { 443, 27, 58 },
                    { 444, 3, 59 },
                    { 445, 14, 59 },
                    { 446, 13, 59 },
                    { 447, 5, 59 },
                    { 448, 29, 59 },
                    { 449, 27, 59 },
                    { 450, 3, 60 },
                    { 451, 14, 60 },
                    { 452, 14, 60 },
                    { 453, 23, 60 },
                    { 454, 9, 60 },
                    { 455, 27, 60 },
                    { 456, 3, 61 },
                    { 457, 14, 61 },
                    { 458, 23, 61 },
                    { 459, 13, 61 },
                    { 460, 29, 61 },
                    { 461, 10, 61 },
                    { 462, 27, 61 },
                    { 463, 3, 62 },
                    { 464, 14, 62 },
                    { 465, 23, 62 },
                    { 466, 5, 62 },
                    { 467, 29, 62 },
                    { 468, 10, 62 },
                    { 469, 27, 62 },
                    { 470, 3, 63 },
                    { 471, 14, 63 },
                    { 472, 30, 63 },
                    { 473, 13, 63 },
                    { 474, 31, 63 },
                    { 475, 19, 63 },
                    { 476, 29, 63 },
                    { 477, 27, 63 },
                    { 478, 3, 64 },
                    { 479, 14, 64 },
                    { 480, 30, 64 },
                    { 481, 13, 64 },
                    { 482, 13, 64 },
                    { 483, 31, 64 },
                    { 484, 29, 64 },
                    { 485, 27, 64 },
                    { 486, 3, 65 },
                    { 487, 14, 65 },
                    { 488, 5, 65 },
                    { 489, 8, 65 },
                    { 490, 13, 65 },
                    { 491, 19, 65 },
                    { 492, 10, 65 },
                    { 493, 29, 65 },
                    { 494, 27, 65 },
                    { 495, 3, 66 },
                    { 496, 14, 66 },
                    { 497, 30, 66 },
                    { 498, 13, 66 },
                    { 499, 31, 66 },
                    { 500, 19, 66 },
                    { 501, 10, 66 },
                    { 502, 29, 66 },
                    { 503, 29, 66 },
                    { 504, 27, 66 }
                });

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 29,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 30,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 31,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 32,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 33,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 34,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 35,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 36,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 37,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 38,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 39,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 40,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 41,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 42,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 43,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 44,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 45,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 46,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 47,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 48,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 49,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 50,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 51,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 52,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 53,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 54,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 55,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 56,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 57,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 58,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 59,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 60,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 61,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 62,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 63,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 64,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 65,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 66,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 67,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 68,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 69,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 70,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 71,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 72,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 73,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 74,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 75,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 76,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 77,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 78,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 79,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 80,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 81,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 82,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 83,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 84,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 85,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 86,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 87,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 88,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 89,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 90,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 91,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 92,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 93,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 94,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 95,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 96,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 97,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 98,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 99,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 100,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 101,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 102,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 103,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 104,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 105,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 106,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.UpdateData(
                table: "SquadronCards",
                keyColumn: "Id",
                keyValue: 107,
                column: "IsUniqueShip",
                value: false);

            migrationBuilder.CreateIndex(
                name: "IX_ShipUpgradeCards_ShipId",
                table: "ShipUpgradeCards",
                column: "ShipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObjectiveCards");

            migrationBuilder.DropTable(
                name: "ShipUpgradeCards");

            migrationBuilder.DropColumn(
                name: "IsUniqueShip",
                table: "SquadronCards");

            migrationBuilder.DropColumn(
                name: "Objectives",
                table: "Fleet");

            migrationBuilder.DropColumn(
                name: "Ships",
                table: "Fleet");

            migrationBuilder.DropColumn(
                name: "Squadrons",
                table: "Fleet");

            migrationBuilder.CreateTable(
                name: "FleetElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FleetId = table.Column<int>(type: "int", nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FleetElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FleetElements_Fleet_FleetId",
                        column: x => x.FleetId,
                        principalTable: "Fleet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FleetElements_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipCards_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SquadronElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FleetId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    SquadronName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadronElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadronElements_Fleet_FleetId",
                        column: x => x.FleetId,
                        principalTable: "Fleet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquippedUpgrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    FleetElementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquippedUpgrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquippedUpgrades_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquippedUpgrades_FleetElements_FleetElementId",
                        column: x => x.FleetElementId,
                        principalTable: "FleetElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ShipCards",
                columns: new[] { "Id", "Category", "ShipId" },
                values: new object[,]
                {
                    { 1, 14, 1 },
                    { 2, 9, 1 },
                    { 3, 11, 1 },
                    { 4, 24, 1 },
                    { 5, 14, 2 },
                    { 6, 9, 2 },
                    { 7, 11, 2 },
                    { 8, 24, 2 },
                    { 9, 0, 3 },
                    { 10, 14, 3 },
                    { 11, 22, 3 },
                    { 12, 4, 3 },
                    { 13, 28, 3 },
                    { 14, 24, 3 },
                    { 15, 0, 4 },
                    { 16, 14, 4 },
                    { 17, 22, 4 },
                    { 18, 4, 4 },
                    { 19, 10, 4 },
                    { 20, 24, 4 },
                    { 21, 0, 5 },
                    { 22, 14, 5 },
                    { 23, 30, 5 },
                    { 24, 11, 5 },
                    { 25, 31, 5 },
                    { 26, 28, 5 },
                    { 27, 24, 5 },
                    { 28, 0, 6 },
                    { 29, 14, 6 },
                    { 30, 30, 6 },
                    { 31, 11, 6 },
                    { 32, 31, 6 },
                    { 33, 19, 6 },
                    { 34, 24, 6 },
                    { 35, 0, 7 },
                    { 36, 14, 7 },
                    { 37, 30, 7 },
                    { 38, 4, 7 },
                    { 39, 19, 7 },
                    { 40, 28, 7 },
                    { 41, 24, 7 },
                    { 42, 0, 8 },
                    { 43, 14, 8 },
                    { 44, 30, 8 },
                    { 45, 4, 8 },
                    { 46, 19, 8 },
                    { 47, 28, 8 },
                    { 48, 24, 8 },
                    { 49, 0, 9 },
                    { 50, 14, 9 },
                    { 51, 22, 9 },
                    { 52, 28, 9 },
                    { 53, 24, 9 },
                    { 54, 0, 10 },
                    { 55, 14, 10 },
                    { 56, 22, 10 },
                    { 57, 28, 10 },
                    { 58, 24, 10 },
                    { 59, 0, 11 },
                    { 60, 14, 11 },
                    { 61, 22, 11 },
                    { 62, 7, 11 },
                    { 63, 19, 11 },
                    { 64, 24, 11 },
                    { 65, 0, 12 },
                    { 66, 14, 12 },
                    { 67, 22, 12 },
                    { 68, 7, 12 },
                    { 69, 11, 12 },
                    { 70, 24, 12 },
                    { 71, 0, 13 },
                    { 72, 14, 13 },
                    { 73, 30, 13 },
                    { 74, 11, 13 },
                    { 75, 31, 13 },
                    { 76, 4, 13 },
                    { 77, 28, 13 },
                    { 78, 24, 13 },
                    { 79, 0, 14 },
                    { 80, 14, 14 },
                    { 81, 30, 14 },
                    { 82, 11, 14 },
                    { 83, 31, 14 },
                    { 84, 4, 14 },
                    { 85, 28, 14 },
                    { 86, 24, 14 },
                    { 87, 0, 15 },
                    { 88, 14, 15 },
                    { 89, 30, 15 },
                    { 90, 11, 15 },
                    { 91, 31, 15 },
                    { 92, 4, 15 },
                    { 93, 28, 15 },
                    { 94, 10, 15 },
                    { 95, 19, 15 },
                    { 96, 24, 15 },
                    { 97, 0, 16 },
                    { 98, 14, 16 },
                    { 99, 30, 16 },
                    { 100, 11, 16 },
                    { 101, 31, 16 },
                    { 102, 4, 16 },
                    { 103, 19, 16 },
                    { 104, 19, 16 },
                    { 105, 24, 16 },
                    { 106, 0, 17 },
                    { 107, 14, 17 },
                    { 108, 22, 17 },
                    { 109, 4, 17 },
                    { 110, 4, 17 },
                    { 111, 10, 17 },
                    { 112, 28, 17 },
                    { 113, 24, 17 },
                    { 114, 0, 18 },
                    { 115, 14, 18 },
                    { 116, 22, 18 },
                    { 117, 11, 18 },
                    { 118, 4, 18 },
                    { 119, 10, 18 },
                    { 120, 28, 18 },
                    { 121, 24, 18 },
                    { 122, 0, 19 },
                    { 123, 14, 19 },
                    { 124, 30, 19 },
                    { 125, 22, 19 },
                    { 126, 10, 19 },
                    { 127, 28, 19 },
                    { 128, 28, 19 },
                    { 129, 24, 19 },
                    { 130, 0, 20 },
                    { 131, 14, 20 },
                    { 132, 30, 20 },
                    { 133, 22, 20 },
                    { 134, 10, 20 },
                    { 135, 28, 20 },
                    { 136, 28, 20 },
                    { 137, 24, 20 },
                    { 138, 0, 21 },
                    { 139, 14, 21 },
                    { 140, 14, 21 },
                    { 141, 30, 21 },
                    { 142, 11, 21 },
                    { 143, 31, 21 },
                    { 144, 10, 21 },
                    { 145, 28, 21 },
                    { 146, 21, 21 },
                    { 147, 24, 21 },
                    { 148, 0, 22 },
                    { 149, 14, 22 },
                    { 150, 14, 22 },
                    { 151, 30, 22 },
                    { 152, 11, 22 },
                    { 153, 31, 22 },
                    { 154, 10, 22 },
                    { 155, 28, 22 },
                    { 156, 21, 22 },
                    { 157, 24, 22 },
                    { 158, 0, 23 },
                    { 159, 14, 23 },
                    { 160, 14, 23 },
                    { 161, 30, 23 },
                    { 162, 30, 23 },
                    { 163, 11, 23 },
                    { 164, 11, 23 },
                    { 165, 31, 23 },
                    { 166, 31, 23 },
                    { 167, 22, 23 },
                    { 168, 22, 23 },
                    { 169, 24, 23 },
                    { 170, 14, 24 },
                    { 171, 9, 24 },
                    { 172, 11, 24 },
                    { 173, 25, 24 },
                    { 174, 14, 25 },
                    { 175, 9, 25 },
                    { 176, 11, 25 },
                    { 177, 25, 25 },
                    { 178, 1, 26 },
                    { 179, 14, 26 },
                    { 180, 30, 26 },
                    { 181, 11, 26 },
                    { 182, 31, 26 },
                    { 183, 19, 26 },
                    { 184, 25, 26 },
                    { 185, 1, 27 },
                    { 186, 14, 27 },
                    { 187, 30, 27 },
                    { 188, 11, 27 },
                    { 189, 31, 27 },
                    { 190, 10, 27 },
                    { 191, 25, 27 },
                    { 192, 1, 28 },
                    { 193, 14, 28 },
                    { 194, 4, 28 },
                    { 195, 28, 28 },
                    { 196, 25, 28 },
                    { 197, 1, 29 },
                    { 198, 14, 29 },
                    { 199, 22, 29 },
                    { 200, 4, 29 },
                    { 201, 28, 29 },
                    { 202, 25, 29 },
                    { 203, 1, 30 },
                    { 204, 14, 30 },
                    { 205, 30, 30 },
                    { 206, 22, 30 },
                    { 207, 19, 30 },
                    { 208, 25, 30 },
                    { 209, 1, 31 },
                    { 210, 14, 31 },
                    { 211, 30, 31 },
                    { 212, 22, 31 },
                    { 213, 19, 31 },
                    { 214, 25, 31 },
                    { 215, 1, 32 },
                    { 216, 14, 32 },
                    { 217, 30, 32 },
                    { 218, 11, 32 },
                    { 219, 11, 32 },
                    { 220, 31, 32 },
                    { 221, 25, 32 },
                    { 222, 1, 33 },
                    { 223, 14, 33 },
                    { 224, 30, 33 },
                    { 225, 30, 33 },
                    { 226, 11, 33 },
                    { 227, 31, 33 },
                    { 228, 25, 33 },
                    { 229, 1, 34 },
                    { 230, 14, 34 },
                    { 231, 30, 34 },
                    { 232, 11, 34 },
                    { 233, 31, 34 },
                    { 234, 28, 34 },
                    { 235, 19, 34 },
                    { 236, 25, 34 },
                    { 237, 1, 35 },
                    { 238, 14, 35 },
                    { 239, 30, 35 },
                    { 240, 11, 35 },
                    { 241, 31, 35 },
                    { 242, 28, 35 },
                    { 243, 10, 35 },
                    { 244, 25, 35 },
                    { 245, 1, 36 },
                    { 246, 14, 36 },
                    { 247, 22, 36 },
                    { 248, 11, 36 },
                    { 249, 6, 36 },
                    { 250, 10, 36 },
                    { 251, 25, 36 },
                    { 252, 1, 37 },
                    { 253, 14, 37 },
                    { 254, 22, 37 },
                    { 255, 11, 37 },
                    { 256, 6, 37 },
                    { 257, 6, 37 },
                    { 258, 10, 37 },
                    { 259, 25, 37 },
                    { 260, 1, 38 },
                    { 261, 14, 38 },
                    { 262, 30, 38 },
                    { 263, 11, 38 },
                    { 264, 11, 38 },
                    { 265, 31, 38 },
                    { 266, 10, 38 },
                    { 267, 28, 38 },
                    { 268, 25, 38 },
                    { 269, 1, 39 },
                    { 270, 14, 39 },
                    { 271, 30, 39 },
                    { 272, 11, 39 },
                    { 273, 31, 39 },
                    { 274, 4, 39 },
                    { 275, 10, 39 },
                    { 276, 28, 39 },
                    { 277, 25, 39 },
                    { 278, 1, 40 },
                    { 279, 14, 40 },
                    { 280, 30, 40 },
                    { 281, 7, 40 },
                    { 282, 11, 40 },
                    { 283, 31, 40 },
                    { 284, 28, 40 },
                    { 285, 28, 40 },
                    { 286, 25, 40 },
                    { 287, 1, 41 },
                    { 288, 14, 41 },
                    { 289, 30, 41 },
                    { 290, 11, 41 },
                    { 291, 31, 41 },
                    { 292, 4, 41 },
                    { 293, 10, 41 },
                    { 294, 19, 41 },
                    { 295, 25, 41 },
                    { 296, 1, 42 },
                    { 297, 14, 42 },
                    { 298, 30, 42 },
                    { 299, 30, 42 },
                    { 300, 22, 42 },
                    { 301, 20, 42 },
                    { 302, 25, 42 },
                    { 303, 1, 43 },
                    { 304, 14, 43 },
                    { 305, 30, 43 },
                    { 306, 30, 43 },
                    { 307, 28, 43 },
                    { 308, 20, 43 },
                    { 309, 25, 43 },
                    { 310, 1, 44 },
                    { 311, 14, 44 },
                    { 312, 30, 44 },
                    { 313, 4, 44 },
                    { 314, 28, 44 },
                    { 315, 19, 44 },
                    { 316, 19, 44 },
                    { 317, 25, 44 },
                    { 318, 1, 45 },
                    { 319, 14, 45 },
                    { 320, 14, 45 },
                    { 321, 14, 45 },
                    { 322, 30, 45 },
                    { 323, 7, 45 },
                    { 324, 7, 45 },
                    { 325, 11, 45 },
                    { 326, 31, 45 },
                    { 327, 10, 45 },
                    { 328, 28, 45 },
                    { 329, 25, 45 },
                    { 330, 1, 46 },
                    { 331, 14, 46 },
                    { 332, 14, 46 },
                    { 333, 14, 46 },
                    { 334, 30, 46 },
                    { 335, 11, 46 },
                    { 336, 11, 46 },
                    { 337, 31, 46 },
                    { 338, 10, 46 },
                    { 339, 10, 46 },
                    { 340, 28, 46 },
                    { 341, 28, 46 },
                    { 342, 25, 46 },
                    { 343, 1, 47 },
                    { 344, 14, 47 },
                    { 345, 14, 47 },
                    { 346, 14, 47 },
                    { 347, 14, 47 },
                    { 348, 30, 47 },
                    { 349, 7, 47 },
                    { 350, 7, 47 },
                    { 351, 7, 47 },
                    { 352, 7, 47 },
                    { 353, 11, 47 },
                    { 354, 31, 47 },
                    { 355, 28, 47 },
                    { 356, 10, 47 },
                    { 357, 25, 47 },
                    { 358, 1, 48 },
                    { 359, 14, 48 },
                    { 360, 14, 48 },
                    { 361, 14, 48 },
                    { 362, 14, 48 },
                    { 363, 30, 48 },
                    { 364, 7, 48 },
                    { 365, 11, 48 },
                    { 366, 11, 48 },
                    { 367, 31, 48 },
                    { 368, 10, 48 },
                    { 369, 10, 48 },
                    { 370, 28, 48 },
                    { 371, 28, 48 },
                    { 372, 25, 48 },
                    { 373, 2, 49 },
                    { 374, 14, 49 },
                    { 375, 22, 49 },
                    { 376, 5, 49 },
                    { 377, 19, 49 },
                    { 378, 26, 49 },
                    { 379, 2, 50 },
                    { 380, 14, 50 },
                    { 381, 22, 50 },
                    { 382, 12, 50 },
                    { 383, 29, 50 },
                    { 384, 26, 50 },
                    { 385, 2, 51 },
                    { 386, 14, 51 },
                    { 387, 22, 51 },
                    { 388, 9, 51 },
                    { 389, 12, 51 },
                    { 390, 26, 51 },
                    { 391, 2, 52 },
                    { 392, 14, 52 },
                    { 393, 22, 52 },
                    { 394, 9, 52 },
                    { 395, 5, 52 },
                    { 396, 26, 52 },
                    { 397, 2, 53 },
                    { 398, 14, 53 },
                    { 399, 30, 53 },
                    { 400, 12, 53 },
                    { 401, 12, 53 },
                    { 402, 31, 53 },
                    { 403, 29, 53 },
                    { 404, 19, 53 },
                    { 405, 26, 53 },
                    { 406, 2, 54 },
                    { 407, 14, 54 },
                    { 408, 30, 54 },
                    { 409, 5, 54 },
                    { 410, 29, 54 },
                    { 411, 19, 54 },
                    { 412, 26, 54 },
                    { 413, 2, 55 },
                    { 414, 14, 55 },
                    { 415, 30, 55 },
                    { 416, 22, 55 },
                    { 417, 12, 55 },
                    { 418, 31, 55 },
                    { 419, 19, 55 },
                    { 420, 19, 55 },
                    { 421, 26, 55 },
                    { 422, 2, 56 },
                    { 423, 14, 56 },
                    { 424, 30, 56 },
                    { 425, 8, 56 },
                    { 426, 12, 56 },
                    { 427, 31, 56 },
                    { 428, 29, 56 },
                    { 429, 19, 56 },
                    { 430, 26, 56 },
                    { 431, 2, 57 },
                    { 432, 14, 57 },
                    { 433, 30, 57 },
                    { 434, 12, 57 },
                    { 435, 31, 57 },
                    { 436, 5, 57 },
                    { 437, 29, 57 },
                    { 438, 19, 57 },
                    { 439, 26, 57 },
                    { 440, 14, 58 },
                    { 441, 30, 58 },
                    { 442, 10, 58 },
                    { 443, 27, 58 },
                    { 444, 3, 59 },
                    { 445, 14, 59 },
                    { 446, 13, 59 },
                    { 447, 5, 59 },
                    { 448, 29, 59 },
                    { 449, 27, 59 },
                    { 450, 3, 60 },
                    { 451, 14, 60 },
                    { 452, 14, 60 },
                    { 453, 23, 60 },
                    { 454, 9, 60 },
                    { 455, 27, 60 },
                    { 456, 3, 61 },
                    { 457, 14, 61 },
                    { 458, 23, 61 },
                    { 459, 13, 61 },
                    { 460, 29, 61 },
                    { 461, 10, 61 },
                    { 462, 27, 61 },
                    { 463, 3, 62 },
                    { 464, 14, 62 },
                    { 465, 23, 62 },
                    { 466, 5, 62 },
                    { 467, 29, 62 },
                    { 468, 10, 62 },
                    { 469, 27, 62 },
                    { 470, 3, 63 },
                    { 471, 14, 63 },
                    { 472, 30, 63 },
                    { 473, 13, 63 },
                    { 474, 31, 63 },
                    { 475, 19, 63 },
                    { 476, 29, 63 },
                    { 477, 27, 63 },
                    { 478, 3, 64 },
                    { 479, 14, 64 },
                    { 480, 30, 64 },
                    { 481, 13, 64 },
                    { 482, 13, 64 },
                    { 483, 31, 64 },
                    { 484, 29, 64 },
                    { 485, 27, 64 },
                    { 486, 3, 65 },
                    { 487, 14, 65 },
                    { 488, 5, 65 },
                    { 489, 8, 65 },
                    { 490, 13, 65 },
                    { 491, 19, 65 },
                    { 492, 10, 65 },
                    { 493, 29, 65 },
                    { 494, 27, 65 },
                    { 495, 3, 66 },
                    { 496, 14, 66 },
                    { 497, 30, 66 },
                    { 498, 13, 66 },
                    { 499, 31, 66 },
                    { 500, 19, 66 },
                    { 501, 10, 66 },
                    { 502, 29, 66 },
                    { 503, 29, 66 },
                    { 504, 27, 66 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquippedUpgrades_CardId",
                table: "EquippedUpgrades",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_EquippedUpgrades_FleetElementId_CardId",
                table: "EquippedUpgrades",
                columns: new[] { "FleetElementId", "CardId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FleetElements_FleetId",
                table: "FleetElements",
                column: "FleetId");

            migrationBuilder.CreateIndex(
                name: "IX_FleetElements_ShipId",
                table: "FleetElements",
                column: "ShipId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipCards_ShipId",
                table: "ShipCards",
                column: "ShipId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadronElements_FleetId",
                table: "SquadronElements",
                column: "FleetId");
        }
    }
}
