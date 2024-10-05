using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Stopaholic.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyWantLists",
                columns: table => new
                {
                    MonthlyListId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Month = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyWantLists", x => x.MonthlyListId);
                    table.ForeignKey(
                        name: "FK_MonthlyWantLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WantItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PurchaseLink = table.Column<string>(type: "text", nullable: false),
                    TotalCost = table.Column<decimal>(type: "numeric", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    MonthlyWantListId = table.Column<int>(type: "integer", nullable: false),
                    MonthlyListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WantItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_WantItems_MonthlyWantLists_MonthlyListId",
                        column: x => x.MonthlyListId,
                        principalTable: "MonthlyWantLists",
                        principalColumn: "MonthlyListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyWantLists_UserId",
                table: "MonthlyWantLists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WantItems_MonthlyListId",
                table: "WantItems",
                column: "MonthlyListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WantItems");

            migrationBuilder.DropTable(
                name: "MonthlyWantLists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
