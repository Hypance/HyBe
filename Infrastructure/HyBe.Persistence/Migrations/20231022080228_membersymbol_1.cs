using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyBe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class membersymbol_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backtests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Market = table.Column<int>(type: "integer", nullable: false),
                    OrderType = table.Column<int>(type: "integer", nullable: false),
                    Side = table.Column<int>(type: "integer", nullable: false),
                    TrendStrategy = table.Column<int>(type: "integer", nullable: false),
                    Symbols = table.Column<int[]>(type: "integer[]", nullable: true),
                    Strategy = table.Column<int[]>(type: "integer[]", nullable: true),
                    Formation = table.Column<int[]>(type: "integer[]", nullable: true),
                    Start = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Finish = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backtests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Market = table.Column<int>(type: "integer", nullable: false),
                    OrderType = table.Column<int>(type: "integer", nullable: false),
                    Side = table.Column<int>(type: "integer", nullable: false),
                    TrendStrategy = table.Column<int>(type: "integer", nullable: false),
                    AssetIds = table.Column<int[]>(type: "integer[]", nullable: false),
                    StrategyIds = table.Column<int[]>(type: "integer[]", nullable: true),
                    FormationIds = table.Column<int[]>(type: "integer[]", nullable: true),
                    PriceVolume = table.Column<decimal>(type: "numeric", nullable: false),
                    BotOptions = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candlesticks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OpenTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    OpenPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    HighPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    LowPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ClosePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Volume = table.Column<decimal>(type: "numeric", nullable: false),
                    CloseTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    Symbol = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candlesticks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    DefaultPeriod = table.Column<int>(type: "integer", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormationSignals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FormationSignalName = table.Column<string>(type: "text", nullable: false),
                    SymbolName = table.Column<string>(type: "text", nullable: false),
                    Period = table.Column<int>(type: "integer", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    Result = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormationSignals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DefaultPeriod = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndicatorSignals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    IndicatorName = table.Column<string>(type: "text", nullable: false),
                    SymbolName = table.Column<string>(type: "text", nullable: false),
                    Period = table.Column<int>(type: "integer", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    Signals = table.Column<int[]>(type: "integer[]", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicatorSignals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalAssetsValue = table.Column<decimal>(type: "numeric", nullable: false),
                    AllTimeProfit = table.Column<decimal>(type: "numeric", nullable: false),
                    MonthlyProfit = table.Column<decimal>(type: "numeric", nullable: false),
                    WeeklyProfit = table.Column<decimal>(type: "numeric", nullable: false),
                    DailyProfit = table.Column<decimal>(type: "numeric", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberSymbol",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    SymbolId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSymbol", x => x.Id);
                });

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
                name: "Strategies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symbols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MinQuantity = table.Column<decimal>(type: "numeric", nullable: false),
                    MaxQuantity = table.Column<decimal>(type: "numeric", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symbols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Asset = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Size = table.Column<decimal>(type: "numeric", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EndTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    Side = table.Column<int>(type: "integer", nullable: false),
                    EntryPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ExitPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Profit = table.Column<decimal>(type: "numeric", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Balance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Signals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Period = table.Column<int>(type: "integer", nullable: false),
                    IndicatorId = table.Column<int>(type: "integer", nullable: false),
                    SignalResult = table.Column<int>(type: "integer", nullable: false),
                    Interval = table.Column<int>(type: "integer", nullable: false),
                    TrendStrategy = table.Column<int>(type: "integer", nullable: false),
                    StrategyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signals_Strategies_StrategyId",
                        column: x => x.StrategyId,
                        principalTable: "Strategies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Signals_StrategyId",
                table: "Signals",
                column: "StrategyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backtests");

            migrationBuilder.DropTable(
                name: "Bots");

            migrationBuilder.DropTable(
                name: "Candlesticks");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "FormationSignals");

            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "IndicatorSignals");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "MemberSymbol");

            migrationBuilder.DropTable(
                name: "MemberTransactionRelationships");

            migrationBuilder.DropTable(
                name: "Signals");

            migrationBuilder.DropTable(
                name: "Symbols");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Strategies");
        }
    }
}
