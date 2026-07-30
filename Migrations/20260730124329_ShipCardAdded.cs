using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class ShipCardAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardsType",
                table: "Ships");

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

            migrationBuilder.InsertData(
                table: "Ships",
                columns: new[] { "Id", "Name", "Point" },
                values: new object[,]
                {
                    { 1, "GR-75 Medium Transports", 18 },
                    { 2, "GR-75 Combat Retrofits", 24 },
                    { 3, "CR90 Corvette A", 44 },
                    { 4, "CR90 Corvette B", 39 },
                    { 5, "Hammerhead Scout Corvette", 41 },
                    { 6, "Hammerhead Torpedo Corvette", 36 },
                    { 7, "MC30c Scout Torpedo Frigate", 69 },
                    { 8, "MC30c Torpedo Frigate", 63 },
                    { 9, "Nebulon-B Escort Frigate", 57 },
                    { 10, "Nebulon-B Support Refit", 51 },
                    { 11, "Pelta-class Assault Ship", 56 },
                    { 12, "Pelta-class Command Ship", 60 },
                    { 13, "Assault Frigate Mark II A", 81 },
                    { 14, "Assault Frigate Mark II B", 72 },
                    { 15, "MC75 Armored Cruiser", 104 },
                    { 16, "MC75 Ordnance Cruiser", 100 },
                    { 17, "MC80 Assault Cruiser", 114 },
                    { 18, "MC80 Command Cruiser", 106 },
                    { 19, "MC80 Battle Cruiser", 103 },
                    { 20, "MC80 Star Cruiser", 96 },
                    { 21, "Starhawk-class Battleship Mark I", 140 },
                    { 22, "Starhawk-class Battleship Mark II", 150 }
                });

            migrationBuilder.InsertData(
                table: "ShipCards",
                columns: new[] { "Id", "Category", "ShipId" },
                values: new object[,]
                {
                    { 1, 0, 1 },
                    { 2, 14, 1 },
                    { 3, 9, 1 },
                    { 4, 11, 1 },
                    { 5, 24, 1 },
                    { 6, 0, 2 },
                    { 7, 14, 2 },
                    { 8, 9, 2 },
                    { 9, 11, 2 },
                    { 10, 24, 2 },
                    { 11, 0, 3 },
                    { 12, 14, 3 },
                    { 13, 28, 3 },
                    { 14, 4, 3 },
                    { 15, 24, 3 },
                    { 16, 0, 4 },
                    { 17, 14, 4 },
                    { 18, 10, 4 },
                    { 19, 4, 4 },
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
                    { 93, 19, 15 },
                    { 94, 28, 15 },
                    { 95, 28, 15 },
                    { 96, 24, 15 },
                    { 97, 0, 16 },
                    { 98, 14, 16 },
                    { 99, 30, 16 },
                    { 100, 11, 16 },
                    { 101, 31, 16 },
                    { 102, 4, 16 },
                    { 103, 19, 16 },
                    { 104, 19, 16 },
                    { 105, 28, 16 },
                    { 106, 24, 16 },
                    { 107, 0, 17 },
                    { 108, 14, 17 },
                    { 109, 22, 17 },
                    { 110, 4, 17 },
                    { 111, 10, 17 },
                    { 112, 28, 17 },
                    { 113, 28, 17 },
                    { 114, 24, 17 },
                    { 115, 0, 18 },
                    { 116, 14, 18 },
                    { 117, 22, 18 },
                    { 118, 4, 18 },
                    { 119, 10, 18 },
                    { 120, 28, 18 },
                    { 121, 28, 18 },
                    { 122, 24, 18 },
                    { 123, 0, 19 },
                    { 124, 14, 19 },
                    { 125, 22, 19 },
                    { 126, 10, 19 },
                    { 127, 28, 19 },
                    { 128, 28, 19 },
                    { 129, 24, 19 },
                    { 131, 0, 20 },
                    { 132, 14, 20 },
                    { 133, 22, 20 },
                    { 134, 10, 20 },
                    { 135, 28, 20 },
                    { 136, 28, 20 },
                    { 137, 24, 20 },
                    { 139, 0, 21 },
                    { 140, 14, 21 },
                    { 141, 30, 21 },
                    { 142, 11, 21 },
                    { 143, 31, 21 },
                    { 144, 4, 21 },
                    { 145, 21, 21 },
                    { 146, 10, 21 },
                    { 147, 28, 21 },
                    { 148, 28, 21 },
                    { 149, 24, 21 },
                    { 150, 0, 22 },
                    { 151, 14, 22 },
                    { 152, 30, 22 },
                    { 153, 11, 22 },
                    { 154, 31, 22 },
                    { 155, 4, 22 },
                    { 156, 21, 22 },
                    { 157, 10, 22 },
                    { 158, 28, 22 },
                    { 159, 28, 22 },
                    { 160, 24, 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShipCards_ShipId",
                table: "ShipCards",
                column: "ShipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipCards");

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.AddColumn<string>(
                name: "CardsType",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
