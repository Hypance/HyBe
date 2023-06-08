using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyBe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class transaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionType",
                table: "Bots",
                newName: "Side");

            migrationBuilder.RenameColumn(
                name: "PositionType",
                table: "Backtests",
                newName: "Side");

            migrationBuilder.AddColumn<decimal>(
                name: "AllTimeProfit",
                table: "Members",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DailyProfit",
                table: "Members",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyProfit",
                table: "Members",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAssetsValue",
                table: "Members",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "WeeklyProfit",
                table: "Members",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "MemberTransactionRelationships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<string>(type: "text", nullable: false),
                    TranId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTransactionRelationships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TranId = table.Column<long>(type: "bigint", nullable: false),
                    Asset = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Size = table.Column<decimal>(type: "numeric", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EndTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    Side = table.Column<int>(type: "integer", nullable: false),
                    EntryPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ExitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberTransactionRelationships");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropColumn(
                name: "AllTimeProfit",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "DailyProfit",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MonthlyProfit",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TotalAssetsValue",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "WeeklyProfit",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "Side",
                table: "Bots",
                newName: "PositionType");

            migrationBuilder.RenameColumn(
                name: "Side",
                table: "Backtests",
                newName: "PositionType");
        }
    }
}
