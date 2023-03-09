using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Signals;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
    public class SignalService : EfRepository<Signal>, ISignalService
    {
        public SignalService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
        {
        
        }
    }
}
