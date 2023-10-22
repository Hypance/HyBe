using System;
namespace HyBe.Domain.Contracts.Signals;

public class GetByIdSignalRequest
{
    public Guid Id { get; set; }
    public string MemberId { get; set; }
}

