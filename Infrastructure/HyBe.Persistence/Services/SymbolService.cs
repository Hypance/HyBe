using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Symbols;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Persistence.Services;

public class SymbolService : EfRepository<Symbol>, ISymbolService
{
    public SymbolService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}

