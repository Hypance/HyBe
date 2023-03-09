using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Signals;

public class GetListSignalResponse
{
    public string Name { get; set; }
    public int Period { get; set; }
    public int IndicatorId { get; set; }
    public SignalResult SignalResult { get; set; }
    public Interval Interval { get; set; }
    public TrendStrategy TrendStrategy { get; set; }
}

