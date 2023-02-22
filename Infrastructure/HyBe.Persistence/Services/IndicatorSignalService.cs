using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Indicators;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;
public class IndicatorSignalService : EfRepository<IndicatorSignal>, IIndicatorSignalService
{
    public IndicatorSignalService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}