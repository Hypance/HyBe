using CryptoExchange.Net.Interfaces;
using HyBe.Application.Abstractions.Infrastructure;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Symbols;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.SharedKernel.Repositories;
using System.Net;

namespace HyBe.Persistence.Services;

public class SymbolService : EfRepository<Symbol>, ISymbolService
{
    private readonly IBinanceFutureService _binanceFutureService;
    public SymbolService(HypanceDbContext hypanceDbContext, IBinanceFutureService binanceFutureService) : base(hypanceDbContext)
    {
        _binanceFutureService = binanceFutureService;
    }
    public async Task AddOrUpdateSymbolList()
    {
        var symbolList = await _binanceFutureService.GetListSymbol();
        foreach (var symbol in symbolList)
        {
            var newSymbol = new Symbol
            {
                Name = symbol.Pair,
                MinQuantity = symbol.LotSizeFilter.MinQuantity,
                MaxQuantity = symbol.LotSizeFilter.MaxQuantity,
                IsActive = true,
                TickSize = symbol.PriceFilter.TickSize,
                StepSize = symbol.LotSizeFilter.StepSize,
                Precision = symbol.PricePrecision,
                Icon = GetSymbolIcon(symbol.BaseAsset)
            };
            Add(newSymbol);
        }
    }
    private string GetSymbolIcon(string coin)
    {
        string imageUrl = $"https://s3-symbol-logo.tradingview.com/crypto/XTVC%7Bcoin%7D--big.svg";
        string fileName = $"{coin}.svg";
        string savePath = Path.Combine(Environment.CurrentDirectory, "wwwroot/icons");
        Directory.CreateDirectory(savePath);
        string filePath = Path.Combine(savePath, fileName);
        if (File.Exists(filePath))
            return filePath;

        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile(imageUrl, filePath);
                return filePath;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

