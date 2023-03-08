using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Enums;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;


namespace HyBe.Persistence.Services;
public class EnumService : EfRepository<Enum>, IEnumService
{
    public EnumService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}