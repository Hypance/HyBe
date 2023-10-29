using Binance.Net.Clients;
using Binance.Net.Interfaces.Clients;
using Binance.Net.Objects.Models.Futures;
using CryptoExchange.Net.Authentication;
using HyBe.Application.Abstractions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Infrastructure.ExternalServices.BinanceFeatures
{
    public class BinanceFutureService : IBinanceFutureService
    {
        private readonly IBinanceRestClient _client;
        public BinanceFutureService()
        {
            var binanceClient = new BinanceRestClient(options => { options.UsdFuturesOptions.ApiCredentials = new ApiCredentials("", ""); });
            _client = binanceClient;
        }
        public async Task<List<BinanceFuturesUsdtSymbol>> GetListSymbol()
        {
            var symbolList = await _client.UsdFuturesApi.ExchangeData.GetExchangeInfoAsync();
            if (symbolList.Success)
            {
                return symbolList.Data.Symbols.ToList();
            }
            return new List<BinanceFuturesUsdtSymbol>();
        }
    }
}
