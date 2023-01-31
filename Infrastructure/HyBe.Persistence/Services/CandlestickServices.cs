using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Symbols;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;

public class CandlestickServices : EfRepository<Candlestick>, ICandlestickServices
{
    public CandlestickServices(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}

