using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Stopaholic.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMonthlyWantList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the foreign key and the MonthlyWantLists table
            migrationBuilder.DropForeignKey(
                name: "FK_WantItems_MonthlyWantLists_MonthlyListId",
                table: "WantItems");

            migrationBuilder.DropTable(
                name: "MonthlyWantLists");

            // Drop the old index
            migrationBuilder.DropIndex(
                name: "IX_WantItems_MonthlyListId",
                table: "WantItems");

            // Drop the MonthlyListId column as it’s no longer necessary
            migrationBuilder.DropColumn(
                name: "MonthlyListId",
                table: "WantItems");

            // Rename MonthlyWantListId to UserId
            migrationBuilder.RenameColumn(
                name: "MonthlyWantListId",
                table: "WantItems",
                newName: "UserId");

            // Optional: Add an index on UserId for performance improvement
            migrationBuilder.CreateIndex(
                name: "IX_WantItems_UserId",
                table: "WantItems",
                column: "UserId");

            // Optional: Add the foreign key constraint for UserId
            migrationBuilder.AddForeignKey(
                name: "FK_WantItems_Users_UserId",
                table: "WantItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "WantItems",
                newName: "MonthlyWantListId");

            migrationBuilder.AddColumn<int>(
                name: "MonthlyListId",
                table: "WantItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MonthlyWantLists",
                columns: table => new
                {
                    MonthlyListId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Month = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_WantItems_MonthlyListId",
                table: "WantItems",
                column: "MonthlyListId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyWantLists_UserId",
                table: "MonthlyWantLists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WantItems_MonthlyWantLists_MonthlyListId",
                table: "WantItems",
                column: "MonthlyListId",
                principalTable: "MonthlyWantLists",
                principalColumn: "MonthlyListId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
