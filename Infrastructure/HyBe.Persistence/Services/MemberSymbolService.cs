using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Members;
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
    public class MemberSymbolService : EfRepository<MemberSymbol>, IMemberSymbolService
    {
        public MemberSymbolService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
        {

        }
    }
}
