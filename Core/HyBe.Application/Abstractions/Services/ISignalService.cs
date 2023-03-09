using HyBe.Domain.Entities.Signals;
using HyBe.Domain.Entities.Strategies;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Application.Abstractions.Services;

public interface ISignalService : IRepository<Signal>
{
}

