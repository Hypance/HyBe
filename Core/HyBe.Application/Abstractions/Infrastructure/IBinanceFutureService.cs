using Binance.Net.Objects.Models.Futures;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Infrastructure
{
    public interface IBinanceFutureService
    {
        Task<List<BinanceFuturesUsdtSymbol>> GetListSymbol();
    }
}
