using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Enums;

public class CreateEnumRequest
{
    public string? Name { get; set; }
    public int Market { get; set; }
    public int OrderType { get; set; }
    public int PositionType { get; set; }
    public int TrendStrategy { get; set; }
    public int[]? Symbols { get; set; }
    public int[]? Strategy { get; set; }
    public int[]? Formation { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset Finish { get; set; }
}

