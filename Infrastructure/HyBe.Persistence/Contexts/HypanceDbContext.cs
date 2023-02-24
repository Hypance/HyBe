using System;
using System.Reflection;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Backtests;
using HyBe.Domain.Entities.Formations;
using HyBe.Domain.Entities.Indicators;
using HyBe.Domain.Entities.Strategies;
using HyBe.Domain.Entities.Symbols;
using HyBe.SharedKernel.Domain;
using HyBe.SharedKernel.Events;
using Hypance.Core.Domain.Wallets;
using Microsoft.EntityFrameworkCore;

namespace HyBe.Persistence.Contexts;
public class HypanceDbContext : DbContext
{
    #region Fields
    private readonly IDomainEventDispatcher _dispatcher;
    #endregion

    #region Constructor
    public HypanceDbContext(
        DbContextOptions<HypanceDbContext> options,
        IDomainEventDispatcher dispatcher):base(options)
    {
        _dispatcher = dispatcher;
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
    #endregion

    #region ModelCreating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    #endregion

    #region Methods
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        // ignore events if no dispatcher provided
        if (_dispatcher == null)
        {
            return result;
        }

        // dispatch events only if save was successful
        var entitiesWithEvents = this.ChangeTracker.Entries<BaseEntity>()
            .Select(e => e.Entity)
            .Where(e => e.DomainEvents.Any())
            .ToArray();

        await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

        return result;
    }

    public override int SaveChanges()
    {
        return this.SaveChangesAsync().GetAwaiter().GetResult();
    }
    #endregion
}