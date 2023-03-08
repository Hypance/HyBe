using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Enums;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Application.Abstractions.Services
{
    public interface IEnumService : IRepository<Enum>
    {
    }
}
