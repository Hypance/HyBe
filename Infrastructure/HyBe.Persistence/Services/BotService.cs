using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;

public class BotService : EfRepository<Bot>, IBotService
{
    public BotService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}

