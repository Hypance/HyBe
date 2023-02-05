using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Contracts.Candlesticks;
public class CreateCandlestickRequest
{
    public string Name { get; set; }
    public DateTime OpenTime { get; set; }
    public decimal OpenPrice { get; set; }
    public decimal HighPrice { get; set; }
    public decimal LowPrice { get; set; }
    public decimal ClosePrice { get; set; }
    public decimal Volume { get; set; }
    public DateTime CloseTime { get; set; }
    public Interval Interval { get; set; }
    public string Symbol { get; set; }
    public bool IsActive { get; set; }
}