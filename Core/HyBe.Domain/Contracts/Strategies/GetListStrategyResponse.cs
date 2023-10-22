using System;
using HyBe.Domain.Entities.Signals;
using HyBe.Domain.Entities.Strategies;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Strategies;

public class GetListStrategyResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Signals { get; set; }
    public string OrderSignal { get; set; }
    public string Interval { get; set; }
    public string Indicator { get; set; }
    public int Period { get; set; }
    public int Value { get; set; }
    public string Provision { get; set; }
    public string crossingIndicator { get; set; }
    public int crossingIndicatorNumber { get; set; }
}

