using System;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.Domain.Contracts.MemberSymbols;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.MemberSymbolRelations.Commands.DeleteMemberSymbol;
public class DeleteMemberSymbolCommand : IRequest<IResult>
{
    public DeleteMemberSymbolRequest Request { get; set; }
    public string MemberId { get; set; }
    public DeleteMemberSymbolCommand(DeleteMemberSymbolRequest request)
    {
        Request = request;
    }
}