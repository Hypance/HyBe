using System;
namespace HyBe.Domain.Contracts.Backtests;

public class GetByIdBacktestRequest
{
    public Guid Id { get; set; }
    public string MemberId { get; set; }
}

