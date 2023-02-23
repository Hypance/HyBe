using HyBe.Domain.Entities.Indicators;
using HyBe.SharedKernel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Services
{
    public interface IIndicatorSignalService : IRepository<IndicatorSignal>
    {
    }
}
