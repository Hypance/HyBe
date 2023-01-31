using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Backtests;

public class DeleteBacktestRequest
{
    public Guid Id { get; set; }
}

