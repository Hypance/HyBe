using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Backtests;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;
public class BacktestService : EfRepository<Backtest>, IBacktestService
{
    public BacktestService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}