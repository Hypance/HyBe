﻿using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Enums;

public class GetByIdEnumResponse
{
    public string Name { get; set; }
    public Market Market { get; set; }
    public OrderType OrderType { get; set; }
    public PositionType PositionType { get; set; }
    public TrendStrategy TrendStrategy { get; set; }
    public int[]? Symbols { get; set; }
    public int[]? Strategy { get; set; }
    public int[]? Formation { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset Finish { get; set; }
}
