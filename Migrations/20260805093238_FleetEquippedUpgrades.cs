using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmadaBackend.Migrations
{
    /// <inheritdoc />
    public partial class FleetEquippedUpgrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquippedUpgrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FleetElementId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_EquippedUpgrades_CardId",
                table: "EquippedUpgrades",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_EquippedUpgrades_FleetElementId_CardId",
                table: "EquippedUpgrades",
                columns: new[] { "FleetElementId", "CardId" },
                unique: true);

            // A régi egy-a-többhöz kapcsolat adatainak átemelése az új kapcsolótáblába.
            migrationBuilder.Sql(
                """
                INSERT INTO [EquippedUpgrades] ([FleetElementId], [CardId])
                SELECT [FleetElementId], [Id]
                FROM [Cards]
                WHERE [FleetElementId] IS NOT NULL;
                """);

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_FleetElements_FleetElementId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_FleetElementId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "FleetElementId",
                table: "Cards");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FleetElementId",
                table: "Cards",
                type: "int",
                nullable: true);

            // A régi séma kártyánként csak egy hajókapcsolatot tud tárolni.
            migrationBuilder.Sql(
                """
                UPDATE [Cards]
                SET [FleetElementId] = [FirstUpgrade].[FleetElementId]
                FROM [Cards]
                CROSS APPLY
                (
                    SELECT TOP (1) [EquippedUpgrades].[FleetElementId]
                    FROM [EquippedUpgrades]
                    WHERE [EquippedUpgrades].[CardId] = [Cards].[Id]
                    ORDER BY [EquippedUpgrades].[Id]
                ) AS [FirstUpgrade];
                """);

            migrationBuilder.DropTable(
                name: "EquippedUpgrades");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_FleetElementId",
                table: "Cards",
                column: "FleetElementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_FleetElements_FleetElementId",
                table: "Cards",
                column: "FleetElementId",
                principalTable: "FleetElements",
                principalColumn: "Id");
        }
    }
}
