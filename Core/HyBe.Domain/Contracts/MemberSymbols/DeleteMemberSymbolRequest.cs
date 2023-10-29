using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.MemberSymbols;
public class DeleteMemberSymbolRequest
{
    public string MemberId { get; set; }
    public Guid Id { get; set; }
}

