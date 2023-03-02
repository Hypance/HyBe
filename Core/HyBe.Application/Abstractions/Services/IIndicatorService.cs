using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Indicators;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Application.Abstractions.Services;

public interface IIndicatorService : IRepository<Indicator>
{
}

