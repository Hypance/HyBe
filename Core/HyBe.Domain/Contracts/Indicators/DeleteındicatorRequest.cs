using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Indicators;

public class DeleteIndicatorRequest
{
    public Guid Id { get; set; }
}