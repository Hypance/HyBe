using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities;
public class Bot : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Market Market { get; set; }
    public OrderType OrderType { get; set; }
    public PositionType PositionType { get; set; }
    public TrendStrategy TrendStrategy { get; set; }
    public int[] AssetIds { get; set; }
    public int[]? StrategyIds { get; set; }
    public int[]? FormationIds { get; set; }
    public decimal PriceVolume { get; set; }
    public BotOptions BotOptions { get; set; }
}