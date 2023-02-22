using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Contracts.Indicators;
public class CreateIndicatorRequest
{
    public string Name { get; set; }
    public DateTimeOffset OpenTime { get; set; }
    public decimal OpenPrice { get; set; }
    public decimal HighPrice { get; set; }
    public decimal LowPrice { get; set; }
    public decimal ClosePrice { get; set; }
    public decimal Volume { get; set; }
    public DateTimeOffset CloseTime { get; set; }
    public Interval Interval { get; set; }
    public string Symbol { get; set; }
    public bool IsActive { get; set; }
}