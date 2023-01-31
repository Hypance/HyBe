﻿using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;
namespace HyBe.Domain.Entities.Backtests;
public class Backtest : BaseEntity
{
    public string Name { get; set; }
    public Market Market { get; set; }
    public OrderType OrderType { get; set; }
    public PositionType PositionType { get; set; }
    public TrendStrategy TrendStrategy { get; set; }
    public int[]? Symbols { get; set; }
    public int[]? Strategy { get; set; }
    public int[]? Formation { get; set; }
    public DateTime Start { get; set; }
    public DateTime Finish { get; set; }
}