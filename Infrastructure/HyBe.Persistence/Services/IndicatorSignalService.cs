using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Backtests;
using HyBe.Domain.Entities.Indicators;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services;
    public class IndicatorSignalService : EfRepository<IndicatorSignal> , IIndicatorSignalService
    {
        public IndicatorSignalService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
        {
        }
    }
