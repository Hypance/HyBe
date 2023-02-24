using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Indicators;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;
public class IndicatorService : EfRepository<Indicator>, IIndicatorService
{
    public IndicatorService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}