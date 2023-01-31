using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;

namespace HyBe.Persistence.Services;

public class FormationService : EfRepository<Formation>, IFormationService
{
    public FormationService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}

