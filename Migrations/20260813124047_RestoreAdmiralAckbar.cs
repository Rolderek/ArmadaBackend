using ArmadaBackend.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmadaBackend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260813124047_RestoreAdmiralAckbar")]
    public partial class RestoreAdmiralAckbar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                IF NOT EXISTS (SELECT 1 FROM [Cards] WHERE [Id] = 1)
                BEGIN
                    SET IDENTITY_INSERT [Cards] ON;

                    INSERT INTO [Cards] ([Id], [Category], [Description], [Name], [Point])
                    VALUES (
                        1,
                        0,
                        'Before a friendly ship''s Attack step, it may choose to attack from only its left and right hull zones this round. If it does, it may add 2 red dice to its attack pool while attacking a ship.',
                        'Admiral Ackbar',
                        38
                    );

                    SET IDENTITY_INSERT [Cards] OFF;
                END;
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Intentionally left empty: the card may have existed before this repair.
        }
    }
}
