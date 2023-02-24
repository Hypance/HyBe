using HyBe.SharedKernel.Repositories;
using HyBe.Domain.Entities.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Services
{
    public interface IWalletService : IRepository<Wallet>
    {
    }
}
