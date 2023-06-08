﻿// <auto-generated />
using System;
using HyBe.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HyBe.Persistence.Migrations
{
    [DbContext(typeof(HypanceDbContext))]
    [Migration("20230608182753_transaction")]
    partial class transaction
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HyBe.Domain.Entities.Backtests.Backtest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Finish")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int[]>("Formation")
                        .HasColumnType("integer[]");

                    b.Property<int>("Market")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderType")
                        .HasColumnType("integer");

                    b.Property<int>("Side")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int[]>("Strategy")
                        .HasColumnType("integer[]");

                    b.Property<int[]>("Symbols")
                        .HasColumnType("integer[]");

                    b.Property<int>("TrendStrategy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Backtests");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Bot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int[]>("AssetIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("BotOptions")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("FormationIds")
                        .HasColumnType("integer[]");

                    b.Property<int>("Market")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderType")
                        .HasColumnType("integer");

                    b.Property<decimal>("PriceVolume")
                        .HasColumnType("numeric");

                    b.Property<int>("Side")
                        .HasColumnType("integer");

                    b.Property<int[]>("StrategyIds")
                        .HasColumnType("integer[]");

                    b.Property<int>("TrendStrategy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Bots");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Formations.Formation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("DefaultPeriod")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Formations.FormationSignal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FormationSignalName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.Property<bool>("Result")
                        .HasColumnType("boolean");

                    b.Property<string>("SymbolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FormationSignals");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Indicators.Indicator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("DefaultPeriod")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Indicators");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Indicators.IndicatorSignal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("IndicatorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.Property<int[]>("Signals")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("SymbolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IndicatorSignals");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Members.Member", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("AllTimeProfit")
                        .HasColumnType("numeric");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<decimal>("DailyProfit")
                        .HasColumnType("numeric");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("MonthlyProfit")
                        .HasColumnType("numeric");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalAssetsValue")
                        .HasColumnType("numeric");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<decimal>("WeeklyProfit")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Signals.Signal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("IndicatorId")
                        .HasColumnType("integer");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.Property<int>("SignalResult")
                        .HasColumnType("integer");

                    b.Property<Guid?>("StrategyId")
                        .HasColumnType("uuid");

                    b.Property<int>("TrendStrategy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.ToTable("Signals");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Strategies.Strategy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Strategies");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Symbols.Candlestick", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("ClosePrice")
                        .HasColumnType("numeric");

                    b.Property<DateTimeOffset>("CloseTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("HighPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal>("LowPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("OpenPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTimeOffset>("OpenTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Candlesticks");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Symbols.Symbol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal>("MaxQuantity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MinQuantity")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Symbols");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Transactions.MemberTransactionRelationship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("TranId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("MemberTransactionRelationships");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Transactions.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Asset")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("EntryPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ExitPrice")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Side")
                        .HasColumnType("integer");

                    b.Property<decimal>("Size")
                        .HasColumnType("numeric");

                    b.Property<DateTimeOffset?>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("TranId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Wallets.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Signals.Signal", b =>
                {
                    b.HasOne("HyBe.Domain.Entities.Strategies.Strategy", null)
                        .WithMany("Signals")
                        .HasForeignKey("StrategyId");
                });

            modelBuilder.Entity("HyBe.Domain.Entities.Strategies.Strategy", b =>
                {
                    b.Navigation("Signals");
                });
#pragma warning restore 612, 618
        }
    }
}
