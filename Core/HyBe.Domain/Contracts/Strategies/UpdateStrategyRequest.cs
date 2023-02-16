﻿using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Strategies;

public class UpdateStrategyRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Signal> Signals { get; set; }
}
