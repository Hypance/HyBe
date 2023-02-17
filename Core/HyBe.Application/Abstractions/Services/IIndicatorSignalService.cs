using AutoMapper;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Indicators;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Application.Abstractions.Services
{
    public interface IIndicatorSignalService : IRepository<IndicatorSignal>
    {
        object Add(Mapper indicatorSignalMapper);
        object Get(Func<object, bool> value);
    }
}