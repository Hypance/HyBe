using System;
namespace HyBe.Domain.Contracts.Indicators;

public class GetByIdIndicatorRequest
{
    public Guid Id { get; set; }
    public string MemberId { get; set; }
}