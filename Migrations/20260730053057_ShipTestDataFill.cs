using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class ShipTestDataFill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
