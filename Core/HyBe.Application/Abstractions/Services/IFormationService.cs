using HyBe.Domain.Entities.Formations;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Application.Abstractions.Services;

public interface IFormationService : IRepository<Formation>
{
}

