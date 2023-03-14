using System;
using HyBe.Domain.Entities.Signals;
using HyBe.Domain.Entities.Strategies;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Strategies;

public class CreateStrategyRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    
}

