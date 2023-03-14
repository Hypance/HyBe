using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Strategies;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;
public class StrategyService : EfRepository<Strategy>, IStrategyService
{
    public StrategyService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}