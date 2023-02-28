using System;
using HyBe.Domain.Entities.Strategies;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Strategies;

public class GetListStrategyResponse
{

    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Signal> Signals { get; set; }
}

