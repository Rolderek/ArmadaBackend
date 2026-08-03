using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class HajoKartyakTeljes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // ShipCard 158-160 már az új 23-as hajóra mutat, ezért azt
            // az EF által generált ShipCard-frissítések előtt kell beszúrni.
            migrationBuilder.InsertData(
                table: "Ships",
                columns: new[] { "Id", "FactinId", "Name", "Point", "Size" },
                values: new object[] { 23, 0, "Providence-class Carrier", 95, 3 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 14, 2 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Category",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Category",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 93,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 94,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 95,
                column: "Category",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 105,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 17 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 107,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 108,
                column: "Category",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 109,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 113,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 18 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 115,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 116,
                column: "Category",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 117,
                column: "Category",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 121,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 19 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 123,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 124,
                column: "Category",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 131,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 132,
                column: "Category",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 139,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 144,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 145,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 146,
                column: "Category",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 147,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 22 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 14, 22 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 150,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 151,
                column: "Category",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 152,
                column: "Category",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 153,
                column: "Category",
                value: 31);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 154,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 155,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 157,
                column: "Category",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 0, 23 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 14, 23 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 14, 23 });

            migrationBuilder.InsertData(
                table: "ShipCards",
                columns: new[] { "Id", "Category", "ShipId" },
                values: new object[,]
                {
                    { 130, 0, 20 },
                    { 138, 0, 21 }
                });

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "MC30c Scout Frigate");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Modified Pelta-class Assault Ship");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Modified Pelta-class Command Ship");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 13,
                column: "Point",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 15,
                column: "Point",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 16,
                column: "Point",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 17,
                column: "Point",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 18,
                column: "Point",
                value: 102);

            migrationBuilder.InsertData(
                table: "Ships",
                columns: new[] { "Id", "FactinId", "Name", "Point", "Size" },
                values: new object[,]
                {
                    { 24, 1, "Gozanti-class Cruisers", 23, 0 },
                    { 25, 1, "Gozanti-class Assault Carriers", 26, 0 },
                    { 26, 1, "Raider I-class Corvette", 44, 1 },
                    { 27, 1, "Raider II-class Corvette", 48, 1 },
                    { 28, 1, "Arquitens-class Light Cruiser", 52, 1 },
                    { 29, 1, "Arquitens-class Command Cruiser", 55, 1 },
                    { 30, 1, "Gladiator I-class Star Destroyer", 56, 1 },
                    { 31, 1, "Gladiator II-class Star Destroyer", 62, 1 },
                    { 32, 1, "Quasar Fire I-class Cruiser-Carrier", 54, 2 },
                    { 33, 1, "Quasar Fire II-class Cruiser-Carrier", 61, 2 },
                    { 34, 1, "Victory I-class Star Destroyer", 73, 2 },
                    { 35, 1, "Victory II-class Star Destroyer", 80, 2 },
                    { 36, 1, "Interdictor Combat Refit", 93, 2 },
                    { 37, 1, "Interdictor Suppression Refit", 90, 2 },
                    { 38, 1, "Imperial I-class Star Destroyer", 110, 3 },
                    { 39, 1, "Imperial II-class Star Destroyer", 120, 3 },
                    { 40, 1, "Imperial Star Destroyer Cymoon 1 Refit", 112, 3 },
                    { 41, 1, "Imperial Star Destroyer Kuat Refit", 112, 3 },
                    { 42, 1, "Onager-class Testbed", 116, 3 },
                    { 43, 1, "Onager-class Star Destroyer", 120, 3 },
                    { 44, 1, "Venator II-class Star Destroyer", 100, 3 },
                    { 45, 1, "Star Dreadnought Command Prototype", 220, 4 },
                    { 46, 1, "Star Dreadnought Assault Prototype", 250, 4 },
                    { 47, 1, "Executor I-class Star Dreadnought", 381, 4 },
                    { 48, 1, "Executor II-class Star Dreadnought", 411, 4 },
                    { 49, 2, "Consular-class Armed Cruiser", 37, 1 },
                    { 50, 2, "Consular-class Charger c70", 42, 1 },
                    { 51, 2, "Pelta-class Medical Frigate", 49, 1 },
                    { 52, 2, "Pelta-class Transport Frigate", 45, 1 },
                    { 53, 2, "Acclamator I-class Assault Ship", 64, 2 },
                    { 54, 2, "Acclamator II-class Assault Ship", 71, 2 },
                    { 55, 2, "Victory I-class Star Destroyer", 73, 2 },
                    { 56, 2, "Venator I-class Star Destroyer", 90, 3 },
                    { 57, 2, "Venator II-class Star Destroyer", 100, 3 },
                    { 58, 3, "C-ROC Gozanti-class Cruisers", 24, 0 },
                    { 59, 3, "Hardcell-class Battle Refit", 50, 1 },
                    { 60, 3, "Hardcell-class Transport", 47, 1 },
                    { 61, 3, "Munificent-class Comms Frigate", 70, 2 },
                    { 62, 3, "Munificent-class Star Frigate", 73, 2 },
                    { 63, 3, "Recusant-class Light Destroyer", 85, 3 },
                    { 64, 3, "Recusant-class Support Destroyer", 90, 3 },
                    { 65, 3, "Providence-class Carrier", 102, 3 },
                    { 66, 3, "Providence-class Dreadnought", 97, 3 }
                });

            migrationBuilder.InsertData(
                table: "ShipCards",
                columns: new[] { "Id", "Category", "ShipId" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // A 23-as hajó törlése előtt a korábban is létező slotokat
            // vissza kell kapcsolni a 22-es hajóhoz.
            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 28, 22 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 28, 22 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 22 });

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Category",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 3 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 93,
                column: "Category",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 94,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 95,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 105,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 16 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 107,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 108,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 109,
                column: "Category",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 113,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 17 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 115,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 116,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 117,
                column: "Category",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 121,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 18 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 123,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 124,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 131,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 132,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 139,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 144,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 145,
                column: "Category",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 146,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 147,
                column: "Category",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 28, 21 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Category", "ShipId" },
                values: new object[] { 24, 21 });

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 150,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 151,
                column: "Category",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 152,
                column: "Category",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 153,
                column: "Category",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 154,
                column: "Category",
                value: 31);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 155,
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ShipCards",
                keyColumn: "Id",
                keyValue: 157,
                column: "Category",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "MC30c Scout Torpedo Frigate");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pelta-class Assault Ship");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Pelta-class Command Ship");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 13,
                column: "Point",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 15,
                column: "Point",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 16,
                column: "Point",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 17,
                column: "Point",
                value: 114);

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 18,
                column: "Point",
                value: 106);
        }
    }
}
