using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Symbols;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using Hypance.Core.Domain.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
    public class WalletService : EfRepository<Wallet>, IWalletService
    {
        public WalletService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
        {
        }
    }
}
