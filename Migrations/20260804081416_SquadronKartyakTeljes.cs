using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class SquadronKartyakTeljes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SquadronCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactionId = table.Column<int>(type: "int", nullable: false),
                    SquadronName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadronCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SquadronCards",
                columns: new[] { "Id", "AceName", "FactionId", "IsUnique", "Point", "SquadronName" },
                values: new object[,]
                {
                    { 1, null, 0, false, 11, "A-wing Squadron" },
                    { 2, "Green Squadron", 0, true, 12, "A-wing Squadron" },
                    { 3, "Shara Bey", 0, true, 17, "A-wing Squadron" },
                    { 4, "Tycho Celchu", 0, true, 16, "A-wing Squadron" },
                    { 5, null, 0, false, 14, "B-Wing Squadron" },
                    { 6, "Dagger Squadron", 0, true, 15, "B-Wing Squadron" },
                    { 7, "Keyan Farlander", 0, true, 18, "B-Wing Squadron" },
                    { 8, "Ten Numb", 0, true, 19, "B-Wing Squadron" },
                    { 9, null, 0, false, 14, "E-wing Squadron" },
                    { 10, "Corran Horn", 0, true, 22, "E-wing Squadron" },
                    { 11, null, 0, false, 12, "HWK-290" },
                    { 12, "Jan Ors", 0, true, 19, "Moldy Crow" },
                    { 13, "Kanan Jarrus", 0, true, 19, "HWK-290" },
                    { 14, null, 0, false, 14, "Lancer-class Pursuit Craft" },
                    { 15, "Ketsu Onyo", 0, true, 22, "Shadow Caster" },
                    { 16, "Fenn Rau", 0, true, 24, "Mandalorian Gauntlet Fighter" },
                    { 17, null, 0, false, 16, "Scurrg H-6 Bomber" },
                    { 18, "Malee Hurra", 0, true, 21, "Scurrg H-6 Bomber" },
                    { 19, "Nym", 0, true, 21, "Havoc" },
                    { 20, null, 0, false, 15, "VCX-100 Freighter" },
                    { 21, "Hera Syndulla", 0, true, 28, "Ghost" },
                    { 22, null, 0, false, 13, "X-wing Squadron" },
                    { 23, "Biggs Darklighter", 0, true, 19, "X-wing Squadron" },
                    { 24, "Hera Syndulla", 0, true, 23, "X-wing Squadron" },
                    { 25, "Luke Skywalker", 0, true, 20, "X-wing Squadron" },
                    { 26, "Rogue Squadron", 0, true, 14, "X-wing Squadron" },
                    { 27, "Wedge Antilles", 0, true, 19, "X-wing Squadron" },
                    { 28, null, 0, false, 10, "Y-Wing Squadron" },
                    { 29, "Dutch Vander", 0, true, 16, "Y-Wing Squadron" },
                    { 30, "Gold Squadron", 0, true, 12, "Y-Wing Squadron" },
                    { 31, "Norra Wexley", 0, true, 17, "Y-Wing Squadron" },
                    { 32, null, 0, false, 13, "YT-1300" },
                    { 33, "Han Solo", 0, true, 26, "Millennium Falcon" },
                    { 34, "Lando Calrissian", 0, true, 24, "Millennium Falcon" },
                    { 35, null, 0, false, 16, "YT-2400" },
                    { 36, "Dash Rendar", 0, true, 24, "Outrider" },
                    { 37, "Mart Mattin", 0, true, 22, "Sato's Hammer" },
                    { 38, null, 0, false, 7, "Z-95 Headhunter Squadron" },
                    { 39, "Lieutenant Blount", 0, true, 14, "Z-95 Headhunter Squadron" },
                    { 40, null, 1, false, 15, "Aggressor Assault Fighter" },
                    { 41, "IG-88", 1, true, 19, "IG-2000" },
                    { 42, "IG-88B", 1, true, 19, "IG-2000B" },
                    { 43, null, 1, false, 18, "Firespray-31" },
                    { 44, "Boba Fett", 1, true, 24, "Slave I" },
                    { 45, "Hondo Ohnaka", 1, true, 24, "Slave I" },
                    { 46, null, 1, false, 12, "JumpMaster 5000" },
                    { 47, "Dengar", 1, true, 20, "Punishing One" },
                    { 48, "Tel Trevura", 1, true, 17, "JumpMaster 5000" },
                    { 49, null, 1, false, 15, "Lambda-class Shuttle" },
                    { 50, "Colonel Jendon", 1, true, 23, "Lambda-class Shuttle" },
                    { 51, null, 1, false, 18, "Mandalorian Gauntlet Fighter" },
                    { 52, "Gar Saxon", 1, true, 20, "Mandalorian Gauntlet Fighter" },
                    { 53, null, 1, false, 12, "TIE Advanced Squadron" },
                    { 54, "Darth Vader", 1, true, 21, "TIE Advanced Squadron" },
                    { 55, "Tempest Squadron", 1, true, 13, "TIE Advanced Squadron" },
                    { 56, "Zertik Strom", 1, true, 15, "TIE Advanced Squadron" },
                    { 57, null, 1, false, 9, "TIE Bomber Squadron" },
                    { 58, "Captain Jonus", 1, true, 16, "TIE Bomber Squadron" },
                    { 59, "Gamma Squadron", 1, true, 10, "TIE Bomber Squadron" },
                    { 60, "Major Rhymer", 1, true, 16, "TIE Bomber Squadron" },
                    { 61, null, 1, false, 16, "TIE Defender Squadron" },
                    { 62, "Darth Vader", 1, true, 25, "TIE Defender Squadron" },
                    { 63, "Maarek Stele", 1, true, 21, "TIE Defender Squadron" },
                    { 64, null, 1, false, 8, "TIE Fighter Squadron" },
                    { 65, "Black Squadron", 1, true, 9, "TIE Fighter Squadron" },
                    { 66, "Howlrunner", 1, true, 16, "TIE Fighter Squadron" },
                    { 67, "Mauler Mithel", 1, true, 15, "TIE Fighter Squadron" },
                    { 68, "Valen Rudor", 1, true, 13, "TIE Fighter Squadron" },
                    { 69, null, 1, false, 11, "TIE Interceptor Squadron" },
                    { 70, "Ciena Ree", 1, true, 17, "TIE Interceptor Squadron" },
                    { 71, "Saber Squadron", 1, true, 12, "TIE Interceptor Squadron" },
                    { 72, "Soontir Fel", 1, true, 18, "TIE Interceptor Squadron" },
                    { 73, "Vult Skerris", 1, true, 18, "TIE Interceptor Squadron" },
                    { 74, null, 1, false, 14, "TIE Phantom Squadron" },
                    { 75, "Whisper", 1, true, 18, "TIE Phantom Squadron" },
                    { 76, null, 1, false, 22, "VT-49 Decimator" },
                    { 77, "Morna Kee", 1, true, 27, "VT-49 Decimator" },
                    { 78, null, 1, false, 15, "YV-666" },
                    { 79, "Bossk", 1, true, 23, "Hound's Tooth" },
                    { 80, "Moralo Eval", 1, true, 22, "YV-666" },
                    { 81, null, 2, false, 15, "ARC-170 Starfighter Squadron" },
                    { 82, "Odd Ball", 2, true, 20, "ARC-170 Starfighter Squadron" },
                    { 83, null, 2, false, 10, "BTL-B Y-wing Squadron" },
                    { 84, "Anakin Skywalker", 2, true, 18, "BTL-B Y-wing Squadron" },
                    { 85, "Matchstick", 2, true, 16, "BTL-B Y-wing Squadron" },
                    { 86, null, 2, false, 17, "Delta-7 Aethersprite Squadron" },
                    { 87, "Ahsoka Tano", 2, true, 23, "Delta-7 Aethersprite Squadron" },
                    { 88, "Anakin Skywalker", 2, true, 24, "Delta-7 Aethersprite Squadron" },
                    { 89, "Kit Fisto", 2, true, 24, "Delta-7 Aethersprite Squadron" },
                    { 90, "Luminara Unduli", 2, true, 23, "Delta-7 Aethersprite Squadron" },
                    { 91, "Plo Koon", 2, true, 24, "Delta-7 Aethersprite Squadron" },
                    { 92, null, 2, false, 12, "V-19 Torrent Squadron" },
                    { 93, "Axe", 2, true, 17, "V-19 Torrent Squadron" },
                    { 94, "Kickback", 2, true, 16, "V-19 Torrent Squadron" },
                    { 95, null, 3, false, 15, "Belbullab-22 Starfighter Squadron" },
                    { 96, "General Grievous", 3, true, 22, "Belbullab-22 Starfighter Squadron" },
                    { 97, "Wat Tambor", 3, true, 18, "Belbullab-22 Starfighter Squadron" },
                    { 98, null, 3, false, 11, "Droid Tri-Fighter Squadron" },
                    { 99, "DIS-T81", 3, true, 17, "Droid Tri-Fighter Squadron" },
                    { 100, "Phlac-Arphocc Prototypes", 3, true, 18, "Droid Tri-Fighter Squadron" },
                    { 101, "Jango Fett", 3, true, 22, "Slave I" },
                    { 102, null, 3, false, 11, "Hyena-class Droid Bomber Squadron" },
                    { 103, "Baktoid Prototypes", 3, true, 16, "Hyena-class Droid Bomber Squadron" },
                    { 104, "DBS-404", 3, true, 17, "Hyena-class Droid Bomber Squadron" },
                    { 105, null, 3, false, 8, "Vulture-class Droid Fighter Squadron" },
                    { 106, "DFS-311", 3, true, 16, "Vulture-class Droid Fighter Squadron" },
                    { 107, "Haor Chall Prototypes", 3, true, 16, "Vulture-class Droid Fighter Squadron" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SquadronCards");
        }
    }
}
