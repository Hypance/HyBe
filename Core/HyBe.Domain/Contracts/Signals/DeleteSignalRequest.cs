using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Signals;

public class DeleteSignalRequest
{
    public Guid Id { get; set; }
}

