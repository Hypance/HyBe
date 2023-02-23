using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Candlesticks;

public class DeleteCandlestickRequest
{
    public Guid Id { get; set; }
}
