using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Formations;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Persistence.Services;

public class FormationSignalService : EfRepository<FormationSignal>, IFormationSignalService
{
    public FormationSignalService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
    {
    }
}

