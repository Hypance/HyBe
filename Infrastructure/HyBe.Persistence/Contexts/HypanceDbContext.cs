using System;
using System.Reflection;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Backtests;
using HyBe.Domain.Entities.Formations;
using HyBe.Domain.Entities.Indicators;
using HyBe.Domain.Entities.Strategies;
using HyBe.Domain.Entities.Symbols;
using HyBe.SharedKernel.Domain;
using HyBe.Domain.Entities.Wallets;
using Microsoft.EntityFrameworkCore;
using HyBe.Domain.Entities.Signals;
using HyBe.Domain.Entities.Members;
using HyBe.Domain.Entities.Transactions;

namespace HyBe.Persistence.Contexts;
public class HypanceDbContext : DbContext
{


    #region Constructor
    public HypanceDbContext(
        DbContextOptions<HypanceDbContext> options
        ):base(options)
    {
       
    }
    #endregion

    #region DbSets
    public DbSet<Backtest> Backtests { get; set; }
    public DbSet<Bot> Bots { get; set; }
    public DbSet<Formation> Formations { get; set; }
    public DbSet<FormationSignal> FormationSignals { get; set; }
    public DbSet<Indicator> Indicators { get; set; }
    public DbSet<IndicatorSignal> IndicatorSignals { get; set; }
    public DbSet<Signal> Signals { get; set; }
    public DbSet<Strategy> Strategies { get; set; }
    public DbSet<Symbol> Symbols { get; set; }
    public DbSet<Candlestick> Candlesticks { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<MemberTransactionRelationship> MemberTransactionRelationships { get; set; }
    public DbSet<MemberSymbol> MemberSymbol { get; set; }
    #endregion

    #region ModelCreating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    #endregion

    #region Methods

    #endregion
}