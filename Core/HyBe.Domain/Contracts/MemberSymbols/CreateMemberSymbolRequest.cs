using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.MemberSymbols;
public class CreateMemberSymbolRequest
{
    public string MemberId { get; set; }
    public Guid SymbolId { get; set; }
}

